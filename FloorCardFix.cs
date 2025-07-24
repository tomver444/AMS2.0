// Floor Card Creation Fix for Form_IssueGuestCardDMS.cs
// This file contains the corrected implementations for the floor card creation functionality

// 1. txtFloorBuildingValue_TextChanged event handler
private void txtFloorBuildingValue_TextChanged(object sender, EventArgs e)
{
    CheckFloorKeyButtonState();
}

// 2. CheckFloorKeyButtonState method (was missing)
private void CheckFloorKeyButtonState()
{
    // Enable the floor key button only if building value is entered and valid
    if (button6 != null)
    {
        button6.Enabled = !string.IsNullOrWhiteSpace(txtFloorBuildingValue.Text) && 
                         int.TryParse(txtFloorBuildingValue.Text.Trim(), out int result) && 
                         result > 0;
    }
}

// 3. FormatFloorCardDataString method (new helper method)
private string FormatFloorCardDataString()
{
    // Format the floor card data string according to the door lock system requirements
    // This creates a string that contains the building number, floor number, and access dates
    string buildingNo = gCardProperty.BuildingNo.PadLeft(2, '0');
    string floorNo = gCardProperty.FloorNo.PadLeft(2, '0');
    string cardNo = gCardProperty.CardNo.PadLeft(8, '0');
    
    // Format dates as YYMMDD
    string startDate = gCardProperty.CheckInDate.ToString("yyMMdd");
    string endDate = gCardProperty.CheckOutDate.ToString("yyMMdd");
    
    // Format times as HHMM
    string startTime = gCardProperty.CheckInTime.ToString("HHmm");
    string endTime = gCardProperty.CheckOutTime.ToString("HHmm");
    
    // Create the floor card data string - adjust format as needed for your system
    string floorCardData = $"{buildingNo}{floorNo}{cardNo}{startDate}{endDate}{startTime}{endTime}";
    
    // Ensure the string is properly padded to the expected length (61 characters max based on SmartCard_Procedures)
    floorCardData = floorCardData.PadRight(60, '0');
    
    return floorCardData;
}

// 4. Corrected button6_Click event handler
private void button6_Click(object sender, EventArgs e)
{
    // Validate floor building value input
    if (string.IsNullOrWhiteSpace(txtFloorBuildingValue.Text))
    {
        MessageBox.Show("Please enter a building number for the floor key.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtFloorBuildingValue.Focus();
        return;
    }

    int buildingNumber;
    if (!int.TryParse(txtFloorBuildingValue.Text.Trim(), out buildingNumber) || buildingNumber < 1)
    {
        MessageBox.Show("Please enter a valid building number (positive integer).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtFloorBuildingValue.Focus();
        return;
    }

    try
    {
        // Check if card reader is available
        if (!Global_Data.Card_Reader_Found_Flag)
        {
            MessageBox.Show("Card reader not found. Please check the connection and try again.", "Card Reader Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Disable button during processing to prevent multiple clicks
        button6.Enabled = false;
        button6.Text = "Creating...";
        this.Refresh();

        // Set card properties for floor key
        gCardProperty.CardType = "Floor";
        gCardProperty.BuildingNo = buildingNumber.ToString();
        gCardProperty.CardNo = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(false, buildingNumber);

        // Set floor access dates (typically longer term for floor keys)
        gCardProperty.CheckInDate = DateTime.Now.Date;
        gCardProperty.CheckInTime = DateTime.Now;
        gCardProperty.CheckOutDate = DateTime.Now.AddYears(1).Date; // Floor keys typically valid for 1 year
        gCardProperty.CheckOutTime = DateTime.Parse(gCardProperty.CheckOutDate.ToShortDateString() + " 23:59:59");

        // Set floor number from the selected floor (if available)
        if (comboBox5.SelectedItem != null)
        {
            gCardProperty.FloorNo = comboBox5.SelectedItem.ToString().PadLeft(2, '0');
        }
        else
        {
            gCardProperty.FloorNo = "01"; // Default to floor 1
        }

        // Set account and room number for floor access
        gCardProperty.Account = "000000";
        gCardProperty.RoomNo = "00"; // Floor keys don't access specific rooms

        // Create the formatted floor card data string
        string floorCardDataString = FormatFloorCardDataString();

        // Create the floor card using the CORRECT method signature with COM port and data string
        bool cardCreated = SmartCard_Procedures.Make_Floor_Card((int)Global_Data.COM_NUM, floorCardDataString);

        if (cardCreated)
        {
            MessageBox.Show($"Floor key for Building {buildingNumber}, Floor {gCardProperty.FloorNo} created successfully!\nCard Number: {gCardProperty.CardNo}\nValid until: {gCardProperty.CheckOutDate.ToShortDateString()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Log the floor key creation
            string logMessage = $"Floor key created - Building: {buildingNumber}, Floor: {gCardProperty.FloorNo}, Card: {gCardProperty.CardNo}, Date: {DateTime.Now}";
            // Add logging here if needed

            // Clear the input field after successful creation
            txtFloorBuildingValue.Clear();
        }
        else
        {
            MessageBox.Show("Failed to create floor key. Please ensure the card is properly inserted and try again.", "Card Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"An error occurred while creating the floor key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        // Re-enable the button and restore original text
        button6.Enabled = true;
        button6.Text = "Create Floor Key";
        CheckFloorKeyButtonState(); // Update button state based on input validation
    }
}

// 5. PopulateComboBox3WithRange method (was referenced but missing)
private void PopulateComboBox3WithRange(int start, int end)
{
    comboBox3.Items.Clear();
    for (int roomNumber = start; roomNumber <= end; roomNumber++)
    {
        comboBox3.Items.Add($"{roomNumber}");
    }
    if (comboBox3.Items.Count > 0)
    {
        comboBox3.SelectedIndex = 0;
    }
}

// 6. Extension method for comboBox2 change event to update comboBox3
private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
{
    if (comboBox2.SelectedItem != null && int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedFloor))
    {
        if (selectedFloor > 0 && selectedFloor < floorRoomRanges.Length && floorRoomRanges[selectedFloor] != null)
        {
            PopulateComboBox3WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
        }
    }
}

// 7. Extension method for comboBox5 change event to update comboBox6 (for floor key section)
private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
{
    if (comboBox5.SelectedItem != null && int.TryParse(comboBox5.SelectedItem.ToString(), out int selectedFloor))
    {
        if (selectedFloor > 0 && selectedFloor < floorRoomRanges.Length && floorRoomRanges[selectedFloor] != null)
        {
            PopulateComboBox6WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
        }
    }
}

// 8. PopulateComboBox6WithRange method 
private void PopulateComboBox6WithRange(int start, int end)
{
    comboBox6.Items.Clear();
    for (int roomNumber = start; roomNumber <= end; roomNumber++)
    {
        comboBox6.Items.Add($"{roomNumber}");
    }
    if (comboBox6.Items.Count > 0)
    {
        comboBox6.SelectedIndex = 0;
    }
}
