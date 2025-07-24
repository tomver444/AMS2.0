// Complete floor card implementation for button6_Click
// This follows the same pattern as button7_Click building card creation

private void button6_Click(object sender, EventArgs e)
{
    //floor card
    string buildingAndFloor = txtFloorBuildingValue.Text;
    if (buildingAndFloor.Length < 2)
    {
        int aaa = (int)MessageBox.Show("Failure: Input should be at least 2 characters (e.g., 1F for Building 1 Floor F)");
        return;
    }
    
    // Parse building number (first character(s)) and floor identifier (last character)
    string buildingPart = buildingAndFloor.Substring(0, buildingAndFloor.Length - 1);
    string floorPart = buildingAndFloor.Substring(buildingAndFloor.Length - 1, 1);
    
    if (!int.TryParse(buildingPart, out int buildingNum))
    {
        int aaa = (int)MessageBox.Show("Failure: Invalid building number in " + buildingAndFloor);
        return;
    }
    
    // Convert floor letter to number (A=1, B=2, etc.) or use numeric floors
    string floorCode;
    if (char.IsDigit(floorPart[0]))
    {
        floorCode = floorPart.PadLeft(2, '0'); // Numeric floor (1, 2, 3, etc.)
    }
    else
    {
        // Letter floor (A, B, C, etc.)
        char floorChar = char.ToUpper(floorPart[0]);
        int floorNum = floorChar - 'A' + 1; // A=1, B=2, C=3, etc.
        floorCode = floorNum.ToString("D2");
    }
    
    // Create floor card parameter string similar to building card
    // Format: SystemPassword + BuildingNumber + FloorCode + "F8" + DateTime info
    string para_string = Global_Data.System_Pas_String + buildingNum.ToString("D2") + floorCode + "F8";
    
    if (SmartCard_Procedures.Make_Floor_Card((int)Global_Data.COM_NUM, para_string))
    {
        int aaa = (int)MessageBox.Show("Success floor card: Building " + buildingNum + " Floor " + floorPart);
        //success
    }
    else
    {
        int aaa = (int)MessageBox.Show("Failure floor card: " + buildingAndFloor);
    }
}

// Supporting methods that may be missing:

private void txtFloorBuildingValue_TextChanged(object sender, EventArgs e)
{
    CheckFloorKeyButtonState();
}

private void CheckFloorKeyButtonState()
{
    // Enable/disable the floor key button based on input validation
    if (string.IsNullOrWhiteSpace(txtFloorBuildingValue.Text))
    {
        button6.Enabled = false;
        button6.BackColor = SystemColors.InactiveCaption;
    }
    else
    {
        button6.Enabled = true;
        button6.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
    }
}

private void PopulateComboBox3WithRange(int start, int end)
{
    comboBox3.Items.Clear();
    for (int roomNumber = start; roomNumber <= end; roomNumber++)
    {
        comboBox3.Items.Add(roomNumber.ToString());
    }
    if (comboBox3.Items.Count > 0)
    {
        comboBox3.SelectedIndex = 0;
    }
}

// Additional methods if needed for floor card logic:

private void Change_For_OldGuest_Extension()
{
    // Implementation for old guest extension logic if referenced but missing
    // This would handle extending existing guest cards
}

private void Reservation_Frame_Enabled()
{
    // Enable reservation frame controls
    // Implementation depends on specific UI requirements
}

private void Reservation_Frame_Disabled()
{
    // Disable reservation frame controls  
    // Implementation depends on specific UI requirements
}
