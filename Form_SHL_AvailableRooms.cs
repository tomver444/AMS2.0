// Decompiled with JetBrains decompiler
// Type: AMS.Form_SHL_AvailableRooms
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.TempDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_SHL_AvailableRooms : Form
  {
    private Color Reserved_Back_Color = Color.FromArgb((int) byte.MaxValue, 128, 128);
    private Color Occupied_Back_Color = Color.Red;
    private Color Vacant_Back_Color = Color.Cyan;
    private Color VacantClean_Back_Color = Color.Yellow;
    private Color OutOfOrder_Back_Color = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
    private DB db = new DB();
    private DateTime Old_Start_Date = DateTime.Now.Date;
    private DateTime Old_End_Date = DateTime.Now.Date;
    private DateTime Old_Booking_StartDate = DateTime.Now.Date;
    private DateTime Old_Booking_EndDate = DateTime.Now.Date;
    private bool Date_Time_Inserting_Flag;
    private double Old_Deposit;
    private string Old_Reserved_Room = "";
    private bool Editing_Mode;
    private Color New_Reserve_Active_Backcolor = Color.FromArgb(128, (int) byte.MaxValue, 128);
    private Color New_Reserve_Inactive_Backcolor = SystemColors.InactiveCaption;
    private Color Reserve_View_Active_Backcolor = Color.FromArgb((int) byte.MaxValue, 128, 128);
    private Color Reserve_View_Inactive_Backcolor = SystemColors.InactiveCaption;
    private int iStatus;
    private int iIssuedCard;
    private int iRoomType;
    private IContainer components;
    private TabControl tabControl1;
    private TabPage Level1;
    private DataGridView dataGridView_Tab1;
    private TabPage Level2;
    private DataGridView dataGridView_Tab2;
    private TabPage Level3;
    private DataGridView dataGridView_Tab3;
    private TabPage Level4;
    private DataGridView dataGridView_Tab4;
    private TabPage Level5;
    private DataGridView dataGridView_Tab5;
    private TabPage Level6;
    private DataGridView dataGridView_Tab6;
    private TabPage Level7;
    private DataGridView dataGridView_Tab7;
    private TabPage All_Level;
    private DataGridView dataGridView_Tab8;
    public Label lbBuilding;
    public ComboBox cboBuilding;
    public Button cmdReturn;
    public Panel StatusFrame;
    public Label Label10;
    public Label label2;
    public Label Label8;
    public Label Label7;
    public Label Label4;
    public Label label11;
    public Label label14;
    public Label label15;
    public Label label16;
    public Label label19;
    public GroupBox ViewFrame;
    public GroupBox StudioFrame;
    public Label lblURate1;
    public Label lblURate;
    public Label lblMRate2;
    public Label lblWRate2;
    public Label lblDRate2;
    public Label lblMRate1;
    public Label lblWRate1;
    public Label lblDRate1;
    public Label Label42;
    public Label Label41;
    public Label Label40;
    public GroupBox DateFrame;
    public MaskedTextBox mskAvailableStart;
    public MaskedTextBox mskAvailableEnd;
    public Label label1;
    public Label label3;
    public TextBox txtFloorNo;
    public TextBox txtBuildingNo;
    public Label Label36;
    public Label Label33;
    public Label lblMRate;
    public Label Label35;
    public Label lblWRate;
    public Label lblDeposit;
    public Label lblRoomStatus;
    public Label lblIssuedCard;
    public Label Label20;
    public Label lblRoomType;
    public Label label5;
    public Label label6;
    public Label lblDRate;
    public Label Label13;
    public Label lblRoomNo;
    public Label Label12;
    private GroupBox groupBox_RoomsDisplay;
    private TempDataSet tempDataSet;
    private BindingSource gViewRoomTempBindingSource;
    private GViewRoom_TempTableAdapter gViewRoom_TempTableAdapter;
    public GroupBox DetailFrame;
    public Label lblMonthlyRate;
    private DataGridView dataGridView1;
    public Button cmdOkay;
    public Label lblTwo;
    public Label lblOne;
    public Label lblDailyRate1;
    public Label lblWeeklyRate1;
    public Label lblMonthlyRate1;
    public Label Label37;
    public Label Label39;
    public Label Label38;
    public Label lblWeeklyRate;
    public Label lblIssued;
    public Label Label31;
    public Label lblDailyRate;
    public Label Label28;
    public Label lblNo;
    public Label Label26;
    public Label lblBuildingType;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn foreNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    private Label lblRmType;

    public Form_SHL_AvailableRooms()
    {
      this.InitializeComponent();
      this.Init_DataGrid_View(this.dataGridView_Tab1, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab2, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab3, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab4, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab5, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab6, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab7, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab8, 8);
    }

    private void Init_DataGrid_View(DataGridView para_DataGridView, int para_Column_Count)
    {
      DataGridViewTextBoxColumn[] viewTextBoxColumnArray = new DataGridViewTextBoxColumn[para_Column_Count];
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      for (int index = 0; index < para_Column_Count; ++index)
        viewTextBoxColumnArray[index] = new DataGridViewTextBoxColumn();
      para_DataGridView.Columns.AddRange((DataGridViewColumn[]) viewTextBoxColumnArray);
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.SelectionBackColor = Color.Transparent;
      gridViewCellStyle.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle.WrapMode = DataGridViewTriState.True;
      for (int index = 0; index < para_Column_Count; ++index)
      {
        viewTextBoxColumnArray[index].DefaultCellStyle = gridViewCellStyle;
        viewTextBoxColumnArray[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        viewTextBoxColumnArray[index].DefaultCellStyle = gridViewCellStyle;
        viewTextBoxColumnArray[index].DividerWidth = 5;
        viewTextBoxColumnArray[index].HeaderText = "RoomNo";
        viewTextBoxColumnArray[index].Name = "TextBoxColumn" + index.ToString();
        viewTextBoxColumnArray[index].ReadOnly = true;
        viewTextBoxColumnArray[index].Resizable = DataGridViewTriState.False;
        viewTextBoxColumnArray[index].Width = 100;
      }
    }

    private void Disable_AutoSelected_Cell(DataGridView para_DataGridView)
    {
      for (int index1 = 0; index1 < para_DataGridView.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < para_DataGridView.ColumnCount; ++index2)
        {
          if (para_DataGridView.Rows[index1].Cells[index2].Selected)
            para_DataGridView.Rows[index1].Cells[index2].Selected = false;
        }
      }
    }

    private void Setup_Rooms_In_DataGridView_forAllLevel(
      DataGridView para_DataGridView,
      DataTable para_DataTable)
    {
      para_DataGridView.Rows.Clear();
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "01", 0, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "02", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "03", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "04", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "05", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "06", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "07", para_DataGridView.Rows.Count, 0, true);
    }

    private void Setup_Rooms_In_DataGridView(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No)
    {
      int index1 = 0;
      int index2 = 0;
      para_DataGridView.Rows.Clear();
      if (!(para_DataTable is TempDataSet.AvailableRoom_TempDataTable) || para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index3 = 0; index3 < para_DataTable.Rows.Count; ++index3)
      {
        if (((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (index2 < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[index1].Cells[index2].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[index1].Cells[index2];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).Description);
            para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = !((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Occupied") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++index2;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            int index4 = 0;
            ++index1;
            para_DataGridView.Rows[index1].Cells[index4].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[index1].Cells[index4];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).Description);
            para_DataGridView.Rows[index1].Cells[index4].Style.BackColor = !(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription == "Occupied") ? (!(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription == "Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            index2 = index4 + 1;
          }
        }
      }
      if (para_DataTable.Rows.Count <= 0)
        return;
      for (; index2 < para_DataGridView.ColumnCount; ++index2)
        para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = para_DataGridView.BackgroundColor;
    }

    private void Insert_Rooms_In_DataGridView_Relative(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No,
      int para_dataGridView_CurrentRow,
      int para_dataGridView_CurrentColumn,
      bool Add_Blank_Row_Flag)
    {
      if (!(para_DataTable is TempDataSet.AvailableRoom_TempDataTable) || para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index = 0; index < para_DataTable.Rows.Count; ++index)
      {
        if (((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).Description);
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = !((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Occupied") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            para_dataGridView_CurrentColumn = 0;
            ++para_dataGridView_CurrentRow;
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).Description);
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = !(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Occupied") ? (!(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
        }
      }
      if (para_DataTable.Rows.Count <= 0)
        return;
      for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
      {
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
      }
      if (!Add_Blank_Row_Flag)
        return;
      para_DataGridView.Rows.Add(1);
      para_dataGridView_CurrentColumn = 0;
      ++para_dataGridView_CurrentRow;
      for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
      {
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
      }
      para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[0].Style.ForeColor = Color.Red;
      para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[0].Value = (object) ("Level" + Convert.ToInt16(para_Level_No).ToString());
      para_DataGridView.Rows.Add(1);
      para_dataGridView_CurrentColumn = 0;
      ++para_dataGridView_CurrentRow;
      for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
      {
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
      }
    }

    private void dataGridView_Tab1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
        this.DetailFrame.Visible = true;
        this.ViewFrame.Visible = false;
      }
      else if ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.DetailFrame.Visible = true;
        this.ViewFrame.Visible = false;
      }
      else
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        if (!this.Editing_Mode)
          this.Clear_Client_Information();
        this.DetailFrame.Visible = false;
        this.ViewFrame.Visible = true;
      }
    }

    private void dataGridView_Tab1__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab2_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab3_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab4_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab5_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab6_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab7_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
        if (this.Editing_Mode)
          ;
      }
      else if ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      else
      {
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      Console.Beep(600, 300);
      try
      {
        string para_RoomNo = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        string para_RoomType_Des = !((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("SINGLE") ? (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("STUDIO") ? (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("UNIT") ? (string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value : "UNIT") : "STUDIO") : "SINGLE";
        if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.dataGridView_Tab8.Refresh();
          this.Get_and_Set_OldReserved_Information((string) this.cboBuilding.SelectedItem, para_RoomNo, para_RoomType_Des);
          this.DetailFrame.Visible = true;
          this.ViewFrame.Visible = false;
        }
        else if ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") || this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.Get_and_Set_OldReserved_Information((string) this.cboBuilding.SelectedItem, para_RoomNo, para_RoomType_Des);
          this.DetailFrame.Visible = true;
          this.ViewFrame.Visible = false;
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Vacant_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_Vancant_N_VacantClean_Information(para_RoomNo, para_RoomType_Des);
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.VacantClean_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_Vancant_N_VacantClean_Information(para_RoomNo, para_RoomType_Des);
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_OutofOrder_Information(para_RoomNo, para_RoomType_Des);
        }
      }
      catch
      {
      }
      Thread.Sleep(500);
    }

    private void dataGridView_Tab8_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      Console.Beep(600, 300);
      try
      {
        string para_RoomNo = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        string para_RoomType_Des = !((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("SINGLE") ? (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("STUDIO") ? (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("UNIT") ? (string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value : "UNIT") : "STUDIO") : "SINGLE";
        if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.dataGridView_Tab8.Refresh();
          this.Get_and_Set_OldReserved_Information((string) this.cboBuilding.SelectedItem, para_RoomNo, para_RoomType_Des);
          this.DetailFrame.Visible = true;
          this.ViewFrame.Visible = false;
        }
        else if ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") || this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.Get_and_Set_OldReserved_Information((string) this.cboBuilding.SelectedItem, para_RoomNo, para_RoomType_Des);
          this.DetailFrame.Visible = true;
          this.ViewFrame.Visible = false;
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Vacant_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_Vancant_N_VacantClean_Information(para_RoomNo, para_RoomType_Des);
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.VacantClean_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_Vancant_N_VacantClean_Information(para_RoomNo, para_RoomType_Des);
        }
        else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
        {
          this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
          this.DetailFrame.Visible = false;
          this.ViewFrame.Visible = true;
          this.Display_OutofOrder_Information(para_RoomNo, para_RoomType_Des);
        }
      }
      catch
      {
      }
      Thread.Sleep(500);
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.DetailFrame.Visible = false;
      if (this.tabControl1.SelectedTab == this.Level1)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab1, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "01");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab1);
      }
      else if (this.tabControl1.SelectedTab == this.Level2)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab2, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "02");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab2);
      }
      else if (this.tabControl1.SelectedTab == this.Level3)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab3, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "03");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab3);
      }
      else if (this.tabControl1.SelectedTab == this.Level4)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab4, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "04");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab4);
      }
      else if (this.tabControl1.SelectedTab == this.Level5)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab5, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "05");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab5);
      }
      else if (this.tabControl1.SelectedTab == this.Level6)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab6, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "06");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab6);
      }
      else if (this.tabControl1.SelectedTab == this.Level7)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab7, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "07");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab7);
      }
      else
      {
        if (this.tabControl1.SelectedTab != this.All_Level)
          return;
        this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab8, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp);
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      }
    }

    private void Form_SHL_RoomView_Load(object sender, EventArgs e)
    {
      this.gViewRoom_TempTableAdapter.Fill(this.tempDataSet.GViewRoom_Temp);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit = false;
      this.CheckBuilding(this.cboBuilding, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.Update_Date_Building_Roomstaus_Table((string) this.cboBuilding.SelectedItem);
      this.CheckBuildingType(this.cboBuilding.Text);
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      this.db.temp_DB.tempDataSet.AvailableRoom_Temp.Clear();
      this.dataGridView_Tab1.Rows.Clear();
      this.dataGridView_Tab2.Rows.Clear();
      this.dataGridView_Tab3.Rows.Clear();
      this.dataGridView_Tab4.Rows.Clear();
      this.dataGridView_Tab5.Rows.Clear();
      this.dataGridView_Tab6.Rows.Clear();
      this.dataGridView_Tab7.Rows.Clear();
      this.dataGridView_Tab8.Rows.Clear();
    }

    private void CheckBuilding(ComboBox para_ComboBox, string para_myAccLevel)
    {
      para_ComboBox.Items.Clear();
      try
      {
        if (this.db.system_DB.systemDataSet.Building.Rows.Count <= 0)
          this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      catch
      {
        this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (para_myAccLevel != "0")
        {
          if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
            para_ComboBox.Items.Add((object) row.BuildingNo);
        }
        else
          para_ComboBox.Items.Add((object) row.BuildingNo);
        if (para_ComboBox.Items.Count > 0)
          para_ComboBox.SelectedItem = (object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      }
    }

    private void Form_SHL_ViewRoomReservation_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_SHL_ViewRoomReservation_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      this.db.Get_AvailableRoom_Temp((string) this.cboBuilding.SelectedItem, "ALLGUEST");
      this.tabControl1.SelectedTab = this.All_Level;
      this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab8, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      this.db.Get_AccReservationList();
      this.tabControl1.Refresh();
      this.ViewFrame.Visible = false;
      this.DetailFrame.Visible = false;
    }

    private void Display_OutofOrder_Information(string para_RoomNo, string para_RoomType_Des)
    {
      if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (!roomTypeDescription.ToUpper().Contains("STUDIO") && !roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            this.StudioFrame.Visible = false;
            this.lblRoomNo.Text = row.RoomNo;
            this.lblDRate.Text = row.DailyRate.ToString();
            this.lblWRate.Text = row.WeeklyRate.ToString();
            this.lblMRate.Text = row.MonthlyRate.ToString();
            this.lblIssuedCard.Text = row.IssuedCard.ToString();
            this.lblRoomType.Text = para_RoomType_Des;
            this.txtBuildingNo.Text = row.BuildingNo;
            this.txtFloorNo.Text = row.FloorNo;
            break;
          }
          this.lblRoomNo.Text = row.RoomNo;
          this.StudioFrame.Visible = true;
          this.lblURate.Text = "One";
          this.lblURate1.Text = "Two";
          this.lblDRate1.Text = row.DailyRate.ToString();
          this.lblWRate1.Text = row.WeeklyRate.ToString();
          this.lblMRate1.Text = row.MonthlyRate.ToString();
          this.lblDRate2.Text = row.DailyRate2.ToString();
          this.lblWRate2.Text = row.WeeklyRate2.ToString();
          this.lblMRate2.Text = row.MonthlyRate2.ToString();
          this.lblIssuedCard.Text = row.IssuedCard.ToString();
          this.lblRoomType.Text = para_RoomType_Des;
          this.txtBuildingNo.Text = row.BuildingNo;
          this.txtFloorNo.Text = row.FloorNo;
          break;
        }
      }
      if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count <= 0)
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          this.mskAvailableStart.Text = row.StartDate.ToShortDateString();
          this.mskAvailableEnd.Text = "____-__-__";
          this.lblRoomStatus.Text = row.Description;
          break;
        }
      }
    }

    private void Display_Vancant_N_VacantClean_Information(
      string para_RoomNo,
      string para_RoomType_Des)
    {
      if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (!roomTypeDescription.ToUpper().Contains("STUDIO") && !roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            this.StudioFrame.Visible = false;
            this.lblRoomNo.Text = row.RoomNo;
            this.lblDRate.Text = row.DailyRate.ToString();
            this.lblWRate.Text = row.WeeklyRate.ToString();
            this.lblMRate.Text = row.MonthlyRate.ToString();
            this.lblIssuedCard.Text = row.IssuedCard.ToString();
            this.lblRoomType.Text = para_RoomType_Des;
            this.txtBuildingNo.Text = row.BuildingNo;
            this.txtFloorNo.Text = row.FloorNo;
            break;
          }
          this.lblRoomNo.Text = row.RoomNo;
          this.StudioFrame.Visible = true;
          this.lblURate.Text = "One";
          this.lblURate1.Text = "Two";
          this.lblDRate1.Text = row.DailyRate.ToString();
          this.lblWRate1.Text = row.WeeklyRate.ToString();
          this.lblMRate1.Text = row.MonthlyRate.ToString();
          this.lblDRate2.Text = row.DailyRate2.ToString();
          this.lblWRate2.Text = row.WeeklyRate2.ToString();
          this.lblMRate2.Text = row.MonthlyRate2.ToString();
          this.lblIssuedCard.Text = row.IssuedCard.ToString();
          this.lblRoomType.Text = para_RoomType_Des;
          this.txtBuildingNo.Text = row.BuildingNo;
          this.txtFloorNo.Text = row.FloorNo;
          break;
        }
      }
      if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count <= 0)
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
      {
        BuildingDB1DataSet.RoomStatusRow row1 = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
        if (row1.RoomNo == para_RoomNo)
        {
          if (row1.Description == "Vacant" || row1.Description == "Vacant Clean")
          {
            if (row1.StartDate == row1.EndDate)
            {
              this.mskAvailableStart.Text = "____-__-__";
              this.mskAvailableEnd.Text = "____-__-__";
              this.lblRoomStatus.Text = row1.Description;
              break;
            }
            this.mskAvailableStart.Text = row1.StartDate.ToShortDateString();
            this.mskAvailableEnd.Text = row1.EndDate.ToShortDateString();
            this.lblRoomStatus.Text = row1.Description;
            break;
          }
          ++index;
          if (index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count)
          {
            BuildingDB1DataSet.RoomStatusRow row2 = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
            if (row2.RoomNo == para_RoomNo && (row2.Description == "Vacant" || row2.Description == "Vacant Clean"))
            {
              if (row2.StartDate == row2.EndDate)
              {
                this.mskAvailableStart.Text = "____-__-__";
                this.mskAvailableEnd.Text = "____-__-__";
                this.lblRoomStatus.Text = row2.Description;
                break;
              }
              this.mskAvailableStart.Text = row2.StartDate.ToShortDateString();
              this.mskAvailableEnd.Text = row2.EndDate.ToShortDateString();
              this.lblRoomStatus.Text = row2.Description;
              break;
            }
          }
        }
      }
    }

    private void Get_and_Set_OldReserved_Information(
      string para_BuildingNo,
      string para_RoomNo,
      string para_RoomType_Des)
    {
      this.db.Get_GViewRoom_Temp(para_BuildingNo, para_RoomNo);
      this.gViewRoomTempBindingSource.DataSource = (object) this.db.temp_DB.tempDataSet;
      if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          this.lblNo.Text = row.RoomNo;
          this.lblDailyRate.Text = row.DailyRate.ToString();
          this.lblWeeklyRate.Text = row.WeeklyRate.ToString();
          this.lblMonthlyRate.Text = row.MonthlyRate.ToString();
          this.lblIssued.Text = row.IssuedCard.ToString();
          this.lblRmType.Text = para_RoomType_Des;
          this.iRoomType = (int) row.RoomType;
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            this.lblOne.Visible = true;
            this.lblTwo.Visible = true;
            this.lblOne.Text = "One Person";
            this.lblTwo.Text = "Two Person";
            this.lblDailyRate1.Text = row.DailyRate2.ToString();
            this.lblWeeklyRate1.Text = row.WeeklyRate2.ToString();
            this.lblMonthlyRate1.Text = row.MonthlyRate2.ToString();
            break;
          }
          this.lblOne.Visible = false;
          this.lblTwo.Visible = false;
          this.lblDailyRate1.Text = "";
          this.lblWeeklyRate1.Text = "";
          this.lblMonthlyRate1.Text = "";
          break;
        }
      }
    }

    private void CheckBuildingType(string para_BuildingNo)
    {
      this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == para_BuildingNo)
        {
          this.lblBuildingType.Text = row.BuildingType;
          break;
        }
      }
    }

    private void Clear_Client_Information()
    {
    }

    private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '-')
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cmdOkay_Click(object sender, EventArgs e) => this.DetailFrame.Visible = false;

    private void lblOne_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_SHL_AvailableRooms));
      this.tabControl1 = new TabControl();
      this.Level1 = new TabPage();
      this.dataGridView_Tab1 = new DataGridView();
      this.Level2 = new TabPage();
      this.dataGridView_Tab2 = new DataGridView();
      this.Level3 = new TabPage();
      this.dataGridView_Tab3 = new DataGridView();
      this.Level4 = new TabPage();
      this.dataGridView_Tab4 = new DataGridView();
      this.Level5 = new TabPage();
      this.dataGridView_Tab5 = new DataGridView();
      this.Level6 = new TabPage();
      this.dataGridView_Tab6 = new DataGridView();
      this.Level7 = new TabPage();
      this.dataGridView_Tab7 = new DataGridView();
      this.All_Level = new TabPage();
      this.dataGridView_Tab8 = new DataGridView();
      this.lbBuilding = new Label();
      this.cboBuilding = new ComboBox();
      this.StatusFrame = new Panel();
      this.Label10 = new Label();
      this.label2 = new Label();
      this.Label8 = new Label();
      this.Label7 = new Label();
      this.Label4 = new Label();
      this.label11 = new Label();
      this.label14 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label19 = new Label();
      this.ViewFrame = new GroupBox();
      this.StudioFrame = new GroupBox();
      this.lblURate1 = new Label();
      this.lblURate = new Label();
      this.lblMRate2 = new Label();
      this.lblWRate2 = new Label();
      this.lblDRate2 = new Label();
      this.lblMRate1 = new Label();
      this.lblWRate1 = new Label();
      this.lblDRate1 = new Label();
      this.Label42 = new Label();
      this.Label41 = new Label();
      this.Label40 = new Label();
      this.DateFrame = new GroupBox();
      this.mskAvailableStart = new MaskedTextBox();
      this.mskAvailableEnd = new MaskedTextBox();
      this.label1 = new Label();
      this.label3 = new Label();
      this.txtFloorNo = new TextBox();
      this.txtBuildingNo = new TextBox();
      this.Label36 = new Label();
      this.Label33 = new Label();
      this.lblMRate = new Label();
      this.Label35 = new Label();
      this.lblWRate = new Label();
      this.lblDeposit = new Label();
      this.lblRoomStatus = new Label();
      this.lblIssuedCard = new Label();
      this.Label20 = new Label();
      this.lblRoomType = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.lblDRate = new Label();
      this.Label13 = new Label();
      this.lblRoomNo = new Label();
      this.Label12 = new Label();
      this.groupBox_RoomsDisplay = new GroupBox();
      this.gViewRoomTempBindingSource = new BindingSource(this.components);
      this.tempDataSet = new TempDataSet();
      this.gViewRoom_TempTableAdapter = new GViewRoom_TempTableAdapter();
      this.cmdReturn = new Button();
      this.DetailFrame = new GroupBox();
      this.lblRmType = new Label();
      this.lblMonthlyRate = new Label();
      this.dataGridView1 = new DataGridView();
      this.clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.foreNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.surNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.cmdOkay = new Button();
      this.lblTwo = new Label();
      this.lblOne = new Label();
      this.lblDailyRate1 = new Label();
      this.lblWeeklyRate1 = new Label();
      this.lblMonthlyRate1 = new Label();
      this.Label37 = new Label();
      this.Label39 = new Label();
      this.Label38 = new Label();
      this.lblWeeklyRate = new Label();
      this.lblIssued = new Label();
      this.Label31 = new Label();
      this.lblDailyRate = new Label();
      this.Label28 = new Label();
      this.lblNo = new Label();
      this.Label26 = new Label();
      this.lblBuildingType = new Label();
      this.Level5 = new TabPage();
      this.Level6 = new TabPage();
      this.Level7 = new TabPage();
      this.tabControl1.SuspendLayout();
      this.Level1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab1).BeginInit();
      this.Level2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab2).BeginInit();
      this.Level3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab3).BeginInit();
      this.Level4.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab4).BeginInit();
      this.Level5.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab5).BeginInit();
      this.Level6.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab6).BeginInit();
      this.Level7.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab7).BeginInit();
      this.All_Level.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab8).BeginInit();
      this.StatusFrame.SuspendLayout();
      this.ViewFrame.SuspendLayout();
      this.StudioFrame.SuspendLayout();
      this.DateFrame.SuspendLayout();
      this.groupBox_RoomsDisplay.SuspendLayout();
      ((ISupportInitialize) this.gViewRoomTempBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.DetailFrame.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.Level1);
      this.tabControl1.Controls.Add((Control) this.Level2);
      this.tabControl1.Controls.Add((Control) this.Level3);
      this.tabControl1.Controls.Add((Control) this.Level4);
      this.tabControl1.Controls.Add((Control) this.Level5);
      this.tabControl1.Controls.Add((Control) this.Level6);
      this.tabControl1.Controls.Add((Control) this.Level7);
      this.tabControl1.Controls.Add((Control) this.All_Level);
      this.tabControl1.Font = new Font("Arial", 9f);
      this.tabControl1.Location = new Point(10, 31);
      this.tabControl1.Margin = new Padding(2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(556, 474);
      this.tabControl1.TabIndex = 7;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.Level1.BackColor = SystemColors.AppWorkspace;
      this.Level1.Controls.Add((Control) this.dataGridView_Tab1);
      this.Level1.Location = new Point(4, 24);
      this.Level1.Margin = new Padding(2);
      this.Level1.Name = "Level1";
      this.Level1.Padding = new Padding(2);
      this.Level1.Size = new Size(548, 446);
      this.Level1.TabIndex = 0;
      this.Level1.Text = "Level 1";
      this.Level1.UseVisualStyleBackColor = true;
      this.dataGridView_Tab1.AllowUserToAddRows = false;
      this.dataGridView_Tab1.AllowUserToDeleteRows = false;
      this.dataGridView_Tab1.AllowUserToResizeColumns = false;
      this.dataGridView_Tab1.AllowUserToResizeRows = false;
      this.dataGridView_Tab1.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab1.ColumnHeadersVisible = false;
      this.dataGridView_Tab1.Cursor = Cursors.Hand;
      this.dataGridView_Tab1.Dock = DockStyle.Fill;
      this.dataGridView_Tab1.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab1.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab1.Location = new Point(2, 2);
      this.dataGridView_Tab1.Margin = new Padding(2);
      this.dataGridView_Tab1.MultiSelect = false;
      this.dataGridView_Tab1.Name = "dataGridView_Tab1";
      this.dataGridView_Tab1.ReadOnly = true;
      this.dataGridView_Tab1.RowHeadersVisible = false;
      this.dataGridView_Tab1.RowHeadersWidth = 100;
      this.dataGridView_Tab1.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab1.RowTemplate.Height = 60;
      this.dataGridView_Tab1.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab1.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab1.ShowEditingIcon = false;
      this.dataGridView_Tab1.Size = new Size(544, 442);
      this.dataGridView_Tab1.TabIndex = 5;
      this.dataGridView_Tab1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab1__CellDoubleClick);
      this.dataGridView_Tab1.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab1_CellClick);
      this.Level2.BackColor = SystemColors.AppWorkspace;
      this.Level2.Controls.Add((Control) this.dataGridView_Tab2);
      this.Level2.Location = new Point(4, 24);
      this.Level2.Margin = new Padding(2);
      this.Level2.Name = "Level2";
      this.Level2.Padding = new Padding(2);
      this.Level2.Size = new Size(548, 446);
      this.Level2.TabIndex = 1;
      this.Level2.Text = "Level 2";
      this.Level2.UseVisualStyleBackColor = true;
      this.dataGridView_Tab2.AllowUserToAddRows = false;
      this.dataGridView_Tab2.AllowUserToDeleteRows = false;
      this.dataGridView_Tab2.AllowUserToResizeColumns = false;
      this.dataGridView_Tab2.AllowUserToResizeRows = false;
      this.dataGridView_Tab2.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab2.ColumnHeadersVisible = false;
      this.dataGridView_Tab2.Cursor = Cursors.Hand;
      this.dataGridView_Tab2.Dock = DockStyle.Fill;
      this.dataGridView_Tab2.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab2.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab2.Location = new Point(2, 2);
      this.dataGridView_Tab2.Margin = new Padding(2);
      this.dataGridView_Tab2.MultiSelect = false;
      this.dataGridView_Tab2.Name = "dataGridView_Tab2";
      this.dataGridView_Tab2.ReadOnly = true;
      this.dataGridView_Tab2.RowHeadersVisible = false;
      this.dataGridView_Tab2.RowHeadersWidth = 100;
      this.dataGridView_Tab2.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab2.RowTemplate.Height = 60;
      this.dataGridView_Tab2.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab2.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab2.ShowEditingIcon = false;
      this.dataGridView_Tab2.Size = new Size(544, 442);
      this.dataGridView_Tab2.TabIndex = 6;
      this.dataGridView_Tab2.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab2_CellDoubleClick);
      this.dataGridView_Tab2.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab2_CellClick);
      this.Level3.BackColor = SystemColors.AppWorkspace;
      this.Level3.Controls.Add((Control) this.dataGridView_Tab3);
      this.Level3.Location = new Point(4, 24);
      this.Level3.Margin = new Padding(2);
      this.Level3.Name = "Level3";
      this.Level3.Padding = new Padding(2);
      this.Level3.Size = new Size(548, 446);
      this.Level3.TabIndex = 2;
      this.Level3.Text = "Level 3";
      this.Level3.UseVisualStyleBackColor = true;
      this.dataGridView_Tab3.AllowUserToAddRows = false;
      this.dataGridView_Tab3.AllowUserToDeleteRows = false;
      this.dataGridView_Tab3.AllowUserToResizeColumns = false;
      this.dataGridView_Tab3.AllowUserToResizeRows = false;
      this.dataGridView_Tab3.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab3.ColumnHeadersVisible = false;
      this.dataGridView_Tab3.Cursor = Cursors.Hand;
      this.dataGridView_Tab3.Dock = DockStyle.Fill;
      this.dataGridView_Tab3.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab3.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab3.Location = new Point(2, 2);
      this.dataGridView_Tab3.Margin = new Padding(2);
      this.dataGridView_Tab3.MultiSelect = false;
      this.dataGridView_Tab3.Name = "dataGridView_Tab3";
      this.dataGridView_Tab3.ReadOnly = true;
      this.dataGridView_Tab3.RowHeadersVisible = false;
      this.dataGridView_Tab3.RowHeadersWidth = 100;
      this.dataGridView_Tab3.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab3.RowTemplate.Height = 60;
      this.dataGridView_Tab3.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab3.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab3.ShowEditingIcon = false;
      this.dataGridView_Tab3.Size = new Size(544, 442);
      this.dataGridView_Tab3.TabIndex = 7;
      this.dataGridView_Tab3.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab3_CellDoubleClick);
      this.dataGridView_Tab3.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab3_CellClick);
      this.Level4.BackColor = SystemColors.AppWorkspace;
      this.Level4.Controls.Add((Control) this.dataGridView_Tab4);
      this.Level4.Location = new Point(4, 24);
      this.Level4.Margin = new Padding(2);
      this.Level4.Name = "Level4";
      this.Level4.Padding = new Padding(2);
      this.Level4.Size = new Size(548, 446);
      this.Level4.TabIndex = 3;
      this.Level4.Text = "Level 4";
      this.Level4.UseVisualStyleBackColor = true;
      this.dataGridView_Tab4.AllowUserToAddRows = false;
      this.dataGridView_Tab4.AllowUserToDeleteRows = false;
      this.dataGridView_Tab4.AllowUserToResizeColumns = false;
      this.dataGridView_Tab4.AllowUserToResizeRows = false;
      this.dataGridView_Tab4.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab4.ColumnHeadersVisible = false;
      this.dataGridView_Tab4.Cursor = Cursors.Hand;
      this.dataGridView_Tab4.Dock = DockStyle.Fill;
      this.dataGridView_Tab4.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab4.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab4.Location = new Point(2, 2);
      this.dataGridView_Tab4.Margin = new Padding(2);
      this.dataGridView_Tab4.MultiSelect = false;
      this.dataGridView_Tab4.Name = "dataGridView_Tab4";
      this.dataGridView_Tab4.ReadOnly = true;
      this.dataGridView_Tab4.RowHeadersVisible = false;
      this.dataGridView_Tab4.RowHeadersWidth = 100;
      this.dataGridView_Tab4.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab4.RowTemplate.Height = 60;
      this.dataGridView_Tab4.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab4.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab4.ShowEditingIcon = false;
      this.dataGridView_Tab4.Size = new Size(544, 442);
      this.dataGridView_Tab4.TabIndex = 7;
      this.dataGridView_Tab4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab4_CellDoubleClick);
      this.dataGridView_Tab4.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab4_CellClick);
      this.Level5.BackColor = SystemColors.AppWorkspace;
      this.Level5.Controls.Add((Control) this.dataGridView_Tab5);
      this.Level5.Location = new Point(4, 24);
      this.Level5.Margin = new Padding(2);
      this.Level5.Name = "Level5";
      this.Level5.Padding = new Padding(2);
      this.Level5.Size = new Size(548, 446);
      this.Level5.TabIndex = 3;
      this.Level5.Text = "Level 5";
      this.dataGridView_Tab5.AllowUserToAddRows = false;
      this.dataGridView_Tab5.AllowUserToDeleteRows = false;
      this.dataGridView_Tab5.AllowUserToResizeColumns = false;
      this.dataGridView_Tab5.AllowUserToResizeRows = false;
      this.dataGridView_Tab5.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab5.ColumnHeadersVisible = false;
      this.dataGridView_Tab5.Cursor = Cursors.Hand;
      this.dataGridView_Tab5.Dock = DockStyle.Fill;
      this.dataGridView_Tab5.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab5.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab5.Location = new Point(2, 2);
      this.dataGridView_Tab5.Margin = new Padding(2);
      this.dataGridView_Tab5.MultiSelect = false;
      this.dataGridView_Tab5.Name = "dataGridView_Tab5";
      this.dataGridView_Tab5.ReadOnly = true;
      this.dataGridView_Tab5.RowHeadersVisible = false;
      this.dataGridView_Tab5.RowHeadersWidth = 100;
      this.dataGridView_Tab5.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab5.RowTemplate.Height = 60;
      this.dataGridView_Tab5.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab5.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab5.ShowEditingIcon = false;
      this.dataGridView_Tab5.Size = new Size(544, 442);
      this.dataGridView_Tab5.TabIndex = 7;
      this.dataGridView_Tab5.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab5_CellDoubleClick);
      this.dataGridView_Tab5.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab5_CellClick);
      this.Level6.BackColor = SystemColors.AppWorkspace;
      this.Level6.Controls.Add((Control) this.dataGridView_Tab6);
      this.Level6.Location = new Point(4, 24);
      this.Level6.Margin = new Padding(2);
      this.Level6.Name = "Level6";
      this.Level6.Padding = new Padding(2);
      this.Level6.Size = new Size(548, 446);
      this.Level6.TabIndex = 3;
      this.Level6.Text = "Level 6";
      this.dataGridView_Tab6.AllowUserToAddRows = false;
      this.dataGridView_Tab6.AllowUserToDeleteRows = false;
      this.dataGridView_Tab6.AllowUserToResizeColumns = false;
      this.dataGridView_Tab6.AllowUserToResizeRows = false;
      this.dataGridView_Tab6.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab6.ColumnHeadersVisible = false;
      this.dataGridView_Tab6.Cursor = Cursors.Hand;
      this.dataGridView_Tab6.Dock = DockStyle.Fill;
      this.dataGridView_Tab6.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab6.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab6.Location = new Point(2, 2);
      this.dataGridView_Tab6.Margin = new Padding(2);
      this.dataGridView_Tab6.MultiSelect = false;
      this.dataGridView_Tab6.Name = "dataGridView_Tab6";
      this.dataGridView_Tab6.ReadOnly = true;
      this.dataGridView_Tab6.RowHeadersVisible = false;
      this.dataGridView_Tab6.RowHeadersWidth = 100;
      this.dataGridView_Tab6.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab6.RowTemplate.Height = 60;
      this.dataGridView_Tab6.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab6.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab6.ShowEditingIcon = false;
      this.dataGridView_Tab6.Size = new Size(544, 442);
      this.dataGridView_Tab6.TabIndex = 7;
      this.dataGridView_Tab6.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab6_CellDoubleClick);
      this.dataGridView_Tab6.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab6_CellClick);
      this.Level7.BackColor = SystemColors.AppWorkspace;
      this.Level7.Controls.Add((Control) this.dataGridView_Tab7);
      this.Level7.Location = new Point(4, 24);
      this.Level7.Margin = new Padding(2);
      this.Level7.Name = "Level7";
      this.Level7.Padding = new Padding(2);
      this.Level7.Size = new Size(548, 446);
      this.Level7.TabIndex = 3;
      this.Level7.Text = "Level 7";
      this.dataGridView_Tab7.AllowUserToAddRows = false;
      this.dataGridView_Tab7.AllowUserToDeleteRows = false;
      this.dataGridView_Tab7.AllowUserToResizeColumns = false;
      this.dataGridView_Tab7.AllowUserToResizeRows = false;
      this.dataGridView_Tab7.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab7.ColumnHeadersVisible = false;
      this.dataGridView_Tab7.Cursor = Cursors.Hand;
      this.dataGridView_Tab7.Dock = DockStyle.Fill;
      this.dataGridView_Tab7.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab7.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab7.Location = new Point(2, 2);
      this.dataGridView_Tab7.Margin = new Padding(2);
      this.dataGridView_Tab7.MultiSelect = false;
      this.dataGridView_Tab7.Name = "dataGridView_Tab7";
      this.dataGridView_Tab7.ReadOnly = true;
      this.dataGridView_Tab7.RowHeadersVisible = false;
      this.dataGridView_Tab7.RowHeadersWidth = 100;
      this.dataGridView_Tab7.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab7.RowTemplate.Height = 60;
      this.dataGridView_Tab7.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab7.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab7.ShowEditingIcon = false;
      this.dataGridView_Tab7.Size = new Size(544, 442);
      this.dataGridView_Tab7.TabIndex = 7;
      this.dataGridView_Tab7.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab7_CellDoubleClick);
      this.dataGridView_Tab7.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab7_CellClick);
      this.All_Level.BackColor = SystemColors.AppWorkspace;
      this.All_Level.Controls.Add((Control) this.dataGridView_Tab8);
      this.All_Level.Location = new Point(4, 24);
      this.All_Level.Margin = new Padding(2);
      this.All_Level.Name = "All_Level";
      this.All_Level.Padding = new Padding(2);
      this.All_Level.Size = new Size(548, 446);
      this.All_Level.TabIndex = 4;
      this.All_Level.Text = "All";
      this.All_Level.UseVisualStyleBackColor = true;
      this.dataGridView_Tab8.AllowUserToAddRows = false;
      this.dataGridView_Tab8.AllowUserToDeleteRows = false;
      this.dataGridView_Tab8.AllowUserToResizeColumns = false;
      this.dataGridView_Tab8.AllowUserToResizeRows = false;
      this.dataGridView_Tab8.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab8.ColumnHeadersVisible = false;
      this.dataGridView_Tab8.Cursor = Cursors.Hand;
      this.dataGridView_Tab8.Dock = DockStyle.Fill;
      this.dataGridView_Tab8.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab8.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab8.Location = new Point(2, 2);
      this.dataGridView_Tab8.Margin = new Padding(2);
      this.dataGridView_Tab8.MultiSelect = false;
      this.dataGridView_Tab8.Name = "dataGridView_Tab8";
      this.dataGridView_Tab8.ReadOnly = true;
      this.dataGridView_Tab8.RowHeadersVisible = false;
      this.dataGridView_Tab8.RowHeadersWidth = 100;
      this.dataGridView_Tab8.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab8.RowTemplate.Height = 60;
      this.dataGridView_Tab8.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab8.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab8.ShowEditingIcon = false;
      this.dataGridView_Tab8.Size = new Size(544, 442);
      this.dataGridView_Tab8.TabIndex = 7;
      this.dataGridView_Tab8.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab8_CellClick);
      this.lbBuilding.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lbBuilding.Cursor = Cursors.Default;
      this.lbBuilding.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbBuilding.ForeColor = SystemColors.ControlText;
      this.lbBuilding.Location = new Point(601, 11);
      this.lbBuilding.Name = "lbBuilding";
      this.lbBuilding.RightToLeft = RightToLeft.No;
      this.lbBuilding.Size = new Size(57, 17);
      this.lbBuilding.TabIndex = 491;
      this.lbBuilding.Text = "Building";
      this.lbBuilding.TextAlign = ContentAlignment.TopRight;
      this.cboBuilding.BackColor = SystemColors.Window;
      this.cboBuilding.Cursor = Cursors.Default;
      this.cboBuilding.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuilding.ForeColor = SystemColors.WindowText;
      this.cboBuilding.Location = new Point(673, 11);
      this.cboBuilding.Name = "cboBuilding";
      this.cboBuilding.RightToLeft = RightToLeft.No;
      this.cboBuilding.Size = new Size(49, 22);
      this.cboBuilding.TabIndex = 485;
      this.StatusFrame.BackColor = Color.White;
      this.StatusFrame.Controls.Add((Control) this.Label10);
      this.StatusFrame.Controls.Add((Control) this.label2);
      this.StatusFrame.Controls.Add((Control) this.Label8);
      this.StatusFrame.Controls.Add((Control) this.Label7);
      this.StatusFrame.Controls.Add((Control) this.Label4);
      this.StatusFrame.Controls.Add((Control) this.label11);
      this.StatusFrame.Controls.Add((Control) this.label14);
      this.StatusFrame.Controls.Add((Control) this.label15);
      this.StatusFrame.Controls.Add((Control) this.label16);
      this.StatusFrame.Controls.Add((Control) this.label19);
      this.StatusFrame.Cursor = Cursors.Default;
      this.StatusFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.StatusFrame.ForeColor = SystemColors.ControlText;
      this.StatusFrame.Location = new Point(6, 517);
      this.StatusFrame.Name = "StatusFrame";
      this.StatusFrame.RightToLeft = RightToLeft.No;
      this.StatusFrame.Size = new Size(569, 49);
      this.StatusFrame.TabIndex = 730;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.ControlText;
      this.Label10.Location = new Point(456, 16);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(17, 17);
      this.Label10.TabIndex = 172;
      this.label2.BackColor = Color.White;
      this.label2.Cursor = Cursors.Default;
      this.label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Blue;
      this.label2.Location = new Point(480, 16);
      this.label2.Name = "label2";
      this.label2.RightToLeft = RightToLeft.No;
      this.label2.Size = new Size(81, 17);
      this.label2.TabIndex = 171;
      this.label2.Text = "Out Of Order";
      this.Label8.BackColor = Color.Yellow;
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(328, 16);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(17, 17);
      this.Label8.TabIndex = 170;
      this.Label7.BackColor = Color.White;
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.Blue;
      this.Label7.Location = new Point(352, 16);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(73, 17);
      this.Label7.TabIndex = 169;
      this.Label7.Text = "Vacant Clean";
      this.Label4.BackColor = Color.Cyan;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(224, 16);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(17, 17);
      this.Label4.TabIndex = 168;
      this.label11.BackColor = Color.White;
      this.label11.Cursor = Cursors.Default;
      this.label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Blue;
      this.label11.Location = new Point(248, 16);
      this.label11.Name = "label11";
      this.label11.RightToLeft = RightToLeft.No;
      this.label11.Size = new Size(49, 17);
      this.label11.TabIndex = 167;
      this.label11.Text = "Vacant";
      this.label14.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.label14.Cursor = Cursors.Default;
      this.label14.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(112, 16);
      this.label14.Name = "label14";
      this.label14.RightToLeft = RightToLeft.No;
      this.label14.Size = new Size(17, 17);
      this.label14.TabIndex = 166;
      this.label15.BackColor = Color.White;
      this.label15.Cursor = Cursors.Default;
      this.label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.Blue;
      this.label15.Location = new Point(136, 16);
      this.label15.Name = "label15";
      this.label15.RightToLeft = RightToLeft.No;
      this.label15.Size = new Size(49, 17);
      this.label15.TabIndex = 165;
      this.label15.Text = "Reserved";
      this.label16.BackColor = Color.Red;
      this.label16.Cursor = Cursors.Default;
      this.label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = SystemColors.ControlText;
      this.label16.Location = new Point(16, 16);
      this.label16.Name = "label16";
      this.label16.RightToLeft = RightToLeft.No;
      this.label16.Size = new Size(17, 17);
      this.label16.TabIndex = 164;
      this.label19.BackColor = Color.White;
      this.label19.Cursor = Cursors.Default;
      this.label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.Blue;
      this.label19.Location = new Point(40, 16);
      this.label19.Name = "label19";
      this.label19.RightToLeft = RightToLeft.No;
      this.label19.Size = new Size(49, 17);
      this.label19.TabIndex = 163;
      this.label19.Text = "Occupied";
      this.ViewFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.ViewFrame.Controls.Add((Control) this.StudioFrame);
      this.ViewFrame.Controls.Add((Control) this.DateFrame);
      this.ViewFrame.Controls.Add((Control) this.txtFloorNo);
      this.ViewFrame.Controls.Add((Control) this.txtBuildingNo);
      this.ViewFrame.Controls.Add((Control) this.Label36);
      this.ViewFrame.Controls.Add((Control) this.Label33);
      this.ViewFrame.Controls.Add((Control) this.lblMRate);
      this.ViewFrame.Controls.Add((Control) this.Label35);
      this.ViewFrame.Controls.Add((Control) this.lblWRate);
      this.ViewFrame.Controls.Add((Control) this.lblDeposit);
      this.ViewFrame.Controls.Add((Control) this.lblRoomStatus);
      this.ViewFrame.Controls.Add((Control) this.lblIssuedCard);
      this.ViewFrame.Controls.Add((Control) this.Label20);
      this.ViewFrame.Controls.Add((Control) this.lblRoomType);
      this.ViewFrame.Controls.Add((Control) this.label5);
      this.ViewFrame.Controls.Add((Control) this.label6);
      this.ViewFrame.Controls.Add((Control) this.lblDRate);
      this.ViewFrame.Controls.Add((Control) this.Label13);
      this.ViewFrame.Controls.Add((Control) this.lblRoomNo);
      this.ViewFrame.Controls.Add((Control) this.Label12);
      this.ViewFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ViewFrame.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.ViewFrame.Location = new Point(574, 148);
      this.ViewFrame.Name = "ViewFrame";
      this.ViewFrame.Padding = new Padding(0);
      this.ViewFrame.RightToLeft = RightToLeft.No;
      this.ViewFrame.Size = new Size(209, 345);
      this.ViewFrame.TabIndex = 740;
      this.ViewFrame.TabStop = false;
      this.ViewFrame.Text = "ROOM DETAILS :";
      this.ViewFrame.Visible = false;
      this.StudioFrame.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.StudioFrame.Controls.Add((Control) this.lblURate1);
      this.StudioFrame.Controls.Add((Control) this.lblURate);
      this.StudioFrame.Controls.Add((Control) this.lblMRate2);
      this.StudioFrame.Controls.Add((Control) this.lblWRate2);
      this.StudioFrame.Controls.Add((Control) this.lblDRate2);
      this.StudioFrame.Controls.Add((Control) this.lblMRate1);
      this.StudioFrame.Controls.Add((Control) this.lblWRate1);
      this.StudioFrame.Controls.Add((Control) this.lblDRate1);
      this.StudioFrame.Controls.Add((Control) this.Label42);
      this.StudioFrame.Controls.Add((Control) this.Label41);
      this.StudioFrame.Controls.Add((Control) this.Label40);
      this.StudioFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.StudioFrame.ForeColor = SystemColors.ControlText;
      this.StudioFrame.Location = new Point(6, 104);
      this.StudioFrame.Name = "StudioFrame";
      this.StudioFrame.Padding = new Padding(0);
      this.StudioFrame.RightToLeft = RightToLeft.No;
      this.StudioFrame.Size = new Size(201, 97);
      this.StudioFrame.TabIndex = 206;
      this.StudioFrame.TabStop = false;
      this.StudioFrame.Text = "Studio Apartment Rate :";
      this.lblURate1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblURate1.Cursor = Cursors.Default;
      this.lblURate1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblURate1.ForeColor = Color.White;
      this.lblURate1.Location = new Point((int) sbyte.MaxValue, 16);
      this.lblURate1.Name = "lblURate1";
      this.lblURate1.RightToLeft = RightToLeft.No;
      this.lblURate1.Size = new Size(65, 17);
      this.lblURate1.TabIndex = 377;
      this.lblURate1.Text = "Whole Unit";
      this.lblURate1.TextAlign = ContentAlignment.TopCenter;
      this.lblURate.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblURate.Cursor = Cursors.Default;
      this.lblURate.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblURate.ForeColor = Color.White;
      this.lblURate.Location = new Point(56, 16);
      this.lblURate.Name = "lblURate";
      this.lblURate.RightToLeft = RightToLeft.No;
      this.lblURate.Size = new Size(65, 17);
      this.lblURate.TabIndex = 376;
      this.lblURate.Text = "Individaul";
      this.lblURate.TextAlign = ContentAlignment.TopCenter;
      this.lblMRate2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblMRate2.Cursor = Cursors.Default;
      this.lblMRate2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMRate2.ForeColor = SystemColors.ControlText;
      this.lblMRate2.Location = new Point(136, 72);
      this.lblMRate2.Name = "lblMRate2";
      this.lblMRate2.RightToLeft = RightToLeft.No;
      this.lblMRate2.Size = new Size(49, 17);
      this.lblMRate2.TabIndex = 215;
      this.lblMRate2.TextAlign = ContentAlignment.TopCenter;
      this.lblWRate2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblWRate2.Cursor = Cursors.Default;
      this.lblWRate2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWRate2.ForeColor = SystemColors.ControlText;
      this.lblWRate2.Location = new Point(136, 52);
      this.lblWRate2.Name = "lblWRate2";
      this.lblWRate2.RightToLeft = RightToLeft.No;
      this.lblWRate2.Size = new Size(49, 17);
      this.lblWRate2.TabIndex = 214;
      this.lblWRate2.TextAlign = ContentAlignment.TopCenter;
      this.lblDRate2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblDRate2.Cursor = Cursors.Default;
      this.lblDRate2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDRate2.ForeColor = SystemColors.ControlText;
      this.lblDRate2.Location = new Point(136, 32);
      this.lblDRate2.Name = "lblDRate2";
      this.lblDRate2.RightToLeft = RightToLeft.No;
      this.lblDRate2.Size = new Size(49, 17);
      this.lblDRate2.TabIndex = 213;
      this.lblDRate2.TextAlign = ContentAlignment.TopCenter;
      this.lblMRate1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblMRate1.Cursor = Cursors.Default;
      this.lblMRate1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMRate1.ForeColor = SystemColors.ControlText;
      this.lblMRate1.Location = new Point(72, 72);
      this.lblMRate1.Name = "lblMRate1";
      this.lblMRate1.RightToLeft = RightToLeft.No;
      this.lblMRate1.Size = new Size(49, 17);
      this.lblMRate1.TabIndex = 212;
      this.lblMRate1.TextAlign = ContentAlignment.TopCenter;
      this.lblWRate1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblWRate1.Cursor = Cursors.Default;
      this.lblWRate1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWRate1.ForeColor = SystemColors.ControlText;
      this.lblWRate1.Location = new Point(72, 52);
      this.lblWRate1.Name = "lblWRate1";
      this.lblWRate1.RightToLeft = RightToLeft.No;
      this.lblWRate1.Size = new Size(49, 17);
      this.lblWRate1.TabIndex = 211;
      this.lblWRate1.TextAlign = ContentAlignment.TopCenter;
      this.lblDRate1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblDRate1.Cursor = Cursors.Default;
      this.lblDRate1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDRate1.ForeColor = SystemColors.ControlText;
      this.lblDRate1.Location = new Point(72, 32);
      this.lblDRate1.Name = "lblDRate1";
      this.lblDRate1.RightToLeft = RightToLeft.No;
      this.lblDRate1.Size = new Size(49, 17);
      this.lblDRate1.TabIndex = 210;
      this.lblDRate1.TextAlign = ContentAlignment.TopCenter;
      this.Label42.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.Label42.Cursor = Cursors.Default;
      this.Label42.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label42.ForeColor = Color.Blue;
      this.Label42.Location = new Point(8, 32);
      this.Label42.Name = "Label42";
      this.Label42.RightToLeft = RightToLeft.No;
      this.Label42.Size = new Size(49, 17);
      this.Label42.TabIndex = 209;
      this.Label42.Text = "Daily  ";
      this.Label42.TextAlign = ContentAlignment.TopRight;
      this.Label41.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.Label41.Cursor = Cursors.Default;
      this.Label41.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label41.ForeColor = Color.Blue;
      this.Label41.Location = new Point(8, 52);
      this.Label41.Name = "Label41";
      this.Label41.RightToLeft = RightToLeft.No;
      this.Label41.Size = new Size(49, 17);
      this.Label41.TabIndex = 208;
      this.Label41.Text = "Weekly  ";
      this.Label41.TextAlign = ContentAlignment.TopRight;
      this.Label40.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.Label40.Cursor = Cursors.Default;
      this.Label40.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label40.ForeColor = Color.Blue;
      this.Label40.Location = new Point(8, 72);
      this.Label40.Name = "Label40";
      this.Label40.RightToLeft = RightToLeft.No;
      this.Label40.Size = new Size(49, 17);
      this.Label40.TabIndex = 207;
      this.Label40.Text = "Monthly ";
      this.Label40.TextAlign = ContentAlignment.TopRight;
      this.DateFrame.BackColor = Color.Cyan;
      this.DateFrame.Controls.Add((Control) this.mskAvailableStart);
      this.DateFrame.Controls.Add((Control) this.mskAvailableEnd);
      this.DateFrame.Controls.Add((Control) this.label1);
      this.DateFrame.Controls.Add((Control) this.label3);
      this.DateFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.DateFrame.ForeColor = SystemColors.ControlText;
      this.DateFrame.Location = new Point(8, 232);
      this.DateFrame.Name = "DateFrame";
      this.DateFrame.Padding = new Padding(0);
      this.DateFrame.RightToLeft = RightToLeft.No;
      this.DateFrame.Size = new Size(193, 81);
      this.DateFrame.TabIndex = 194;
      this.DateFrame.TabStop = false;
      this.DateFrame.Text = "Date Range :";
      this.mskAvailableStart.AllowPromptAsInput = false;
      this.mskAvailableStart.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskAvailableStart.ForeColor = Color.Blue;
      this.mskAvailableStart.Location = new Point(96, 16);
      this.mskAvailableStart.Mask = "####-##-##";
      this.mskAvailableStart.Name = "mskAvailableStart";
      this.mskAvailableStart.Size = new Size(73, 20);
      this.mskAvailableStart.TabIndex = 195;
      this.mskAvailableEnd.AllowPromptAsInput = false;
      this.mskAvailableEnd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskAvailableEnd.ForeColor = Color.Blue;
      this.mskAvailableEnd.Location = new Point(96, 48);
      this.mskAvailableEnd.Mask = "####-##-##";
      this.mskAvailableEnd.Name = "mskAvailableEnd";
      this.mskAvailableEnd.Size = new Size(73, 20);
      this.mskAvailableEnd.TabIndex = 197;
      this.label1.BackColor = Color.Cyan;
      this.label1.Cursor = Cursors.Default;
      this.label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Red;
      this.label1.Location = new Point(16, 48);
      this.label1.Name = "label1";
      this.label1.RightToLeft = RightToLeft.No;
      this.label1.Size = new Size(73, 17);
      this.label1.TabIndex = 198;
      this.label1.Text = "End Date";
      this.label1.TextAlign = ContentAlignment.TopRight;
      this.label3.BackColor = Color.Cyan;
      this.label3.Cursor = Cursors.Default;
      this.label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(16, 16);
      this.label3.Name = "label3";
      this.label3.RightToLeft = RightToLeft.No;
      this.label3.Size = new Size(73, 17);
      this.label3.TabIndex = 196;
      this.label3.Text = "Start Date";
      this.label3.TextAlign = ContentAlignment.TopRight;
      this.txtFloorNo.AcceptsReturn = true;
      this.txtFloorNo.BackColor = SystemColors.Window;
      this.txtFloorNo.Cursor = Cursors.IBeam;
      this.txtFloorNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFloorNo.ForeColor = SystemColors.WindowText;
      this.txtFloorNo.Location = new Point(56, 80);
      this.txtFloorNo.MaxLength = 0;
      this.txtFloorNo.Name = "txtFloorNo";
      this.txtFloorNo.RightToLeft = RightToLeft.No;
      this.txtFloorNo.Size = new Size(33, 20);
      this.txtFloorNo.TabIndex = 190;
      this.txtBuildingNo.AcceptsReturn = true;
      this.txtBuildingNo.BackColor = SystemColors.Window;
      this.txtBuildingNo.Cursor = Cursors.IBeam;
      this.txtBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingNo.ForeColor = SystemColors.WindowText;
      this.txtBuildingNo.Location = new Point(56, 48);
      this.txtBuildingNo.MaxLength = 0;
      this.txtBuildingNo.Name = "txtBuildingNo";
      this.txtBuildingNo.RightToLeft = RightToLeft.No;
      this.txtBuildingNo.Size = new Size(33, 20);
      this.txtBuildingNo.TabIndex = 188;
      this.Label36.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label36.Cursor = Cursors.Default;
      this.Label36.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label36.ForeColor = Color.Red;
      this.Label36.Location = new Point(8, 112);
      this.Label36.Name = "Label36";
      this.Label36.RightToLeft = RightToLeft.No;
      this.Label36.Size = new Size(41, 17);
      this.Label36.TabIndex = 205;
      this.Label36.Text = "RATE:";
      this.Label36.TextAlign = ContentAlignment.TopRight;
      this.Label33.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label33.Cursor = Cursors.Default;
      this.Label33.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label33.ForeColor = SystemColors.ControlText;
      this.Label33.Location = new Point(16, 160);
      this.Label33.Name = "Label33";
      this.Label33.RightToLeft = RightToLeft.No;
      this.Label33.Size = new Size(73, 17);
      this.Label33.TabIndex = 204;
      this.Label33.Text = "Monthly ";
      this.Label33.TextAlign = ContentAlignment.TopRight;
      this.lblMRate.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblMRate.Cursor = Cursors.Default;
      this.lblMRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMRate.ForeColor = Color.Red;
      this.lblMRate.Location = new Point(104, 160);
      this.lblMRate.Name = "lblMRate";
      this.lblMRate.RightToLeft = RightToLeft.No;
      this.lblMRate.Size = new Size(89, 17);
      this.lblMRate.TabIndex = 203;
      this.Label35.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label35.Cursor = Cursors.Default;
      this.Label35.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label35.ForeColor = SystemColors.ControlText;
      this.Label35.Location = new Point(40, 136);
      this.Label35.Name = "Label35";
      this.Label35.RightToLeft = RightToLeft.No;
      this.Label35.Size = new Size(49, 17);
      this.Label35.TabIndex = 202;
      this.Label35.Text = "Weekly  ";
      this.Label35.TextAlign = ContentAlignment.TopRight;
      this.lblWRate.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblWRate.Cursor = Cursors.Default;
      this.lblWRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWRate.ForeColor = Color.Red;
      this.lblWRate.Location = new Point(104, 136);
      this.lblWRate.Name = "lblWRate";
      this.lblWRate.RightToLeft = RightToLeft.No;
      this.lblWRate.Size = new Size(89, 17);
      this.lblWRate.TabIndex = 201;
      this.lblDeposit.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblDeposit.Cursor = Cursors.Default;
      this.lblDeposit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDeposit.ForeColor = SystemColors.ControlText;
      this.lblDeposit.Location = new Point(120, 256);
      this.lblDeposit.Name = "lblDeposit";
      this.lblDeposit.RightToLeft = RightToLeft.No;
      this.lblDeposit.Size = new Size(81, 17);
      this.lblDeposit.TabIndex = 200;
      this.lblRoomStatus.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblRoomStatus.Cursor = Cursors.Default;
      this.lblRoomStatus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomStatus.ForeColor = Color.Red;
      this.lblRoomStatus.Location = new Point(8, 208);
      this.lblRoomStatus.Name = "lblRoomStatus";
      this.lblRoomStatus.RightToLeft = RightToLeft.No;
      this.lblRoomStatus.Size = new Size(193, 25);
      this.lblRoomStatus.TabIndex = 199;
      this.lblRoomStatus.TextAlign = ContentAlignment.TopCenter;
      this.lblIssuedCard.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblIssuedCard.Cursor = Cursors.Default;
      this.lblIssuedCard.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblIssuedCard.ForeColor = Color.Blue;
      this.lblIssuedCard.Location = new Point(104, 320);
      this.lblIssuedCard.Name = "lblIssuedCard";
      this.lblIssuedCard.RightToLeft = RightToLeft.No;
      this.lblIssuedCard.Size = new Size(81, 17);
      this.lblIssuedCard.TabIndex = 193;
      this.Label20.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label20.Cursor = Cursors.Default;
      this.Label20.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = SystemColors.ControlText;
      this.Label20.Location = new Point(16, 320);
      this.Label20.Name = "Label20";
      this.Label20.RightToLeft = RightToLeft.No;
      this.Label20.Size = new Size(73, 17);
      this.Label20.TabIndex = 192;
      this.Label20.Text = "Issued Card ";
      this.Label20.TextAlign = ContentAlignment.TopRight;
      this.lblRoomType.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblRoomType.Cursor = Cursors.Default;
      this.lblRoomType.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomType.ForeColor = Color.Blue;
      this.lblRoomType.Location = new Point(96, 48);
      this.lblRoomType.Name = "lblRoomType";
      this.lblRoomType.RightToLeft = RightToLeft.No;
      this.lblRoomType.Size = new Size(105, 25);
      this.lblRoomType.TabIndex = 191;
      this.lblRoomType.TextAlign = ContentAlignment.TopCenter;
      this.label5.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.label5.Cursor = Cursors.Default;
      this.label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.FromArgb(235, 55, 116);
      this.label5.Location = new Point(24, 80);
      this.label5.Name = "label5";
      this.label5.RightToLeft = RightToLeft.No;
      this.label5.Size = new Size(25, 17);
      this.label5.TabIndex = 189;
      this.label5.Text = "Floor";
      this.label5.TextAlign = ContentAlignment.TopRight;
      this.label6.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.label6.Cursor = Cursors.Default;
      this.label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.FromArgb(192, 64, 0);
      this.label6.Location = new Point(16, 48);
      this.label6.Name = "label6";
      this.label6.RightToLeft = RightToLeft.No;
      this.label6.Size = new Size(41, 17);
      this.label6.TabIndex = 187;
      this.label6.Text = "Building ";
      this.lblDRate.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblDRate.Cursor = Cursors.Default;
      this.lblDRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDRate.ForeColor = Color.Red;
      this.lblDRate.Location = new Point(104, 112);
      this.lblDRate.Name = "lblDRate";
      this.lblDRate.RightToLeft = RightToLeft.No;
      this.lblDRate.Size = new Size(89, 17);
      this.lblDRate.TabIndex = 186;
      this.Label13.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.ControlText;
      this.Label13.Location = new Point(40, 112);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(49, 17);
      this.Label13.TabIndex = 185;
      this.Label13.Text = "Daily  ";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.lblRoomNo.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.lblRoomNo.Cursor = Cursors.Default;
      this.lblRoomNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomNo.ForeColor = Color.Red;
      this.lblRoomNo.Location = new Point(104, 24);
      this.lblRoomNo.Name = "lblRoomNo";
      this.lblRoomNo.RightToLeft = RightToLeft.No;
      this.lblRoomNo.Size = new Size(89, 17);
      this.lblRoomNo.TabIndex = 184;
      this.Label12.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(16, 24);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(65, 17);
      this.Label12.TabIndex = 183;
      this.Label12.Text = "Room No. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.groupBox_RoomsDisplay.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.groupBox_RoomsDisplay.Controls.Add((Control) this.tabControl1);
      this.groupBox_RoomsDisplay.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.groupBox_RoomsDisplay.Location = new Point(-4, -2);
      this.groupBox_RoomsDisplay.Margin = new Padding(2);
      this.groupBox_RoomsDisplay.Name = "groupBox_RoomsDisplay";
      this.groupBox_RoomsDisplay.Padding = new Padding(2);
      this.groupBox_RoomsDisplay.Size = new Size(571, 510);
      this.groupBox_RoomsDisplay.TabIndex = 6;
      this.groupBox_RoomsDisplay.TabStop = false;
      this.groupBox_RoomsDisplay.Text = "Rooms Display";
      this.gViewRoomTempBindingSource.DataMember = "GViewRoom_Temp";
      this.gViewRoomTempBindingSource.DataSource = (object) this.tempDataSet;
      this.tempDataSet.DataSetName = "TempDataSet";
      this.tempDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gViewRoom_TempTableAdapter.ClearBeforeFill = true;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(640, 517);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(135, 40);
      this.cmdReturn.TabIndex = 497;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.DetailFrame.BackColor = Color.FromArgb(155, 183, 225);
      this.DetailFrame.Controls.Add((Control) this.lblRmType);
      this.DetailFrame.Controls.Add((Control) this.lblMonthlyRate);
      this.DetailFrame.Controls.Add((Control) this.dataGridView1);
      this.DetailFrame.Controls.Add((Control) this.cmdOkay);
      this.DetailFrame.Controls.Add((Control) this.lblTwo);
      this.DetailFrame.Controls.Add((Control) this.lblOne);
      this.DetailFrame.Controls.Add((Control) this.lblDailyRate1);
      this.DetailFrame.Controls.Add((Control) this.lblWeeklyRate1);
      this.DetailFrame.Controls.Add((Control) this.lblMonthlyRate1);
      this.DetailFrame.Controls.Add((Control) this.Label37);
      this.DetailFrame.Controls.Add((Control) this.Label39);
      this.DetailFrame.Controls.Add((Control) this.Label38);
      this.DetailFrame.Controls.Add((Control) this.lblWeeklyRate);
      this.DetailFrame.Controls.Add((Control) this.lblIssued);
      this.DetailFrame.Controls.Add((Control) this.Label31);
      this.DetailFrame.Controls.Add((Control) this.lblDailyRate);
      this.DetailFrame.Controls.Add((Control) this.Label28);
      this.DetailFrame.Controls.Add((Control) this.lblNo);
      this.DetailFrame.Controls.Add((Control) this.Label26);
      this.DetailFrame.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DetailFrame.ForeColor = SystemColors.ControlText;
      this.DetailFrame.Location = new Point(6, 196);
      this.DetailFrame.Margin = new Padding(2);
      this.DetailFrame.Name = "DetailFrame";
      this.DetailFrame.Padding = new Padding(0);
      this.DetailFrame.RightToLeft = RightToLeft.No;
      this.DetailFrame.Size = new Size(518, 315);
      this.DetailFrame.TabIndex = 705;
      this.DetailFrame.TabStop = false;
      this.DetailFrame.Text = "Room Information :";
      this.DetailFrame.Visible = false;
      this.lblMonthlyRate.BackColor = Color.FromArgb(155, 183, 225);
      this.lblMonthlyRate.Cursor = Cursors.Default;
      this.lblMonthlyRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMonthlyRate.ForeColor = Color.Yellow;
      this.lblMonthlyRate.Location = new Point(197, 103);
      this.lblMonthlyRate.Margin = new Padding(2, 0, 2, 0);
      this.lblMonthlyRate.Name = "lblMonthlyRate";
      this.lblMonthlyRate.RightToLeft = RightToLeft.No;
      this.lblMonthlyRate.Size = new Size(43, 14);
      this.lblMonthlyRate.TabIndex = 715;
      this.lblMonthlyRate.Text = "1321";
      this.lblMonthlyRate.TextAlign = ContentAlignment.TopCenter;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.BackgroundColor = SystemColors.Window;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.foreNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.surNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.descriptionDataGridViewTextBoxColumn, (DataGridViewColumn) this.startDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.endDateDataGridViewTextBoxColumn);
      this.dataGridView1.DataSource = (object) this.gViewRoomTempBindingSource;
      this.dataGridView1.Location = new Point(2, 141);
      this.dataGridView1.Margin = new Padding(2);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new Size(503, 122);
      this.dataGridView1.TabIndex = 724;
      this.clientIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
      this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.foreNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.foreNameDataGridViewTextBoxColumn.DataPropertyName = "ForeName";
      this.foreNameDataGridViewTextBoxColumn.HeaderText = "ForeName";
      this.foreNameDataGridViewTextBoxColumn.Name = "foreNameDataGridViewTextBoxColumn";
      this.foreNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.surNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
      this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
      this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
      this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
      this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
      this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
      this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
      this.startDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
      this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
      this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
      this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.endDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
      this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
      this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
      this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.cmdOkay.BackColor = SystemColors.Control;
      this.cmdOkay.Cursor = Cursors.Default;
      this.cmdOkay.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOkay.ForeColor = SystemColors.ControlText;
      this.cmdOkay.Location = new Point(463, 277);
      this.cmdOkay.Margin = new Padding(2);
      this.cmdOkay.Name = "cmdOkay";
      this.cmdOkay.RightToLeft = RightToLeft.No;
      this.cmdOkay.Size = new Size(43, 20);
      this.cmdOkay.TabIndex = 705;
      this.cmdOkay.Text = "&OK";
      this.cmdOkay.UseVisualStyleBackColor = false;
      this.cmdOkay.Click += new EventHandler(this.cmdOkay_Click);
      this.lblTwo.BackColor = Color.Blue;
      this.lblTwo.Cursor = Cursors.Default;
      this.lblTwo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTwo.ForeColor = Color.White;
      this.lblTwo.Location = new Point(266, 21);
      this.lblTwo.Margin = new Padding(2, 0, 2, 0);
      this.lblTwo.Name = "lblTwo";
      this.lblTwo.RightToLeft = RightToLeft.No;
      this.lblTwo.Size = new Size(77, 14);
      this.lblTwo.TabIndex = 722;
      this.lblTwo.Text = "Two Persons";
      this.lblTwo.TextAlign = ContentAlignment.TopCenter;
      this.lblOne.BackColor = Color.Blue;
      this.lblOne.Cursor = Cursors.Default;
      this.lblOne.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblOne.ForeColor = Color.White;
      this.lblOne.Location = new Point(182, 21);
      this.lblOne.Margin = new Padding(2, 0, 2, 0);
      this.lblOne.Name = "lblOne";
      this.lblOne.RightToLeft = RightToLeft.No;
      this.lblOne.Size = new Size(76, 14);
      this.lblOne.TabIndex = 721;
      this.lblOne.Text = "One Person";
      this.lblOne.TextAlign = ContentAlignment.TopCenter;
      this.lblOne.Click += new EventHandler(this.lblOne_Click);
      this.lblDailyRate1.BackColor = Color.FromArgb(155, 183, 225);
      this.lblDailyRate1.Cursor = Cursors.Default;
      this.lblDailyRate1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDailyRate1.ForeColor = Color.Yellow;
      this.lblDailyRate1.Location = new Point(280, 44);
      this.lblDailyRate1.Margin = new Padding(2, 0, 2, 0);
      this.lblDailyRate1.Name = "lblDailyRate1";
      this.lblDailyRate1.RightToLeft = RightToLeft.No;
      this.lblDailyRate1.Size = new Size(43, 14);
      this.lblDailyRate1.TabIndex = 720;
      this.lblDailyRate1.Text = "69";
      this.lblDailyRate1.TextAlign = ContentAlignment.TopCenter;
      this.lblWeeklyRate1.BackColor = Color.FromArgb(155, 183, 225);
      this.lblWeeklyRate1.Cursor = Cursors.Default;
      this.lblWeeklyRate1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWeeklyRate1.ForeColor = Color.Yellow;
      this.lblWeeklyRate1.Location = new Point(280, 74);
      this.lblWeeklyRate1.Margin = new Padding(2, 0, 2, 0);
      this.lblWeeklyRate1.Name = "lblWeeklyRate1";
      this.lblWeeklyRate1.RightToLeft = RightToLeft.No;
      this.lblWeeklyRate1.Size = new Size(43, 14);
      this.lblWeeklyRate1.TabIndex = 719;
      this.lblWeeklyRate1.Text = "420";
      this.lblWeeklyRate1.TextAlign = ContentAlignment.TopCenter;
      this.lblMonthlyRate1.BackColor = Color.FromArgb(155, 183, 225);
      this.lblMonthlyRate1.Cursor = Cursors.Default;
      this.lblMonthlyRate1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMonthlyRate1.ForeColor = Color.Yellow;
      this.lblMonthlyRate1.Location = new Point(282, 103);
      this.lblMonthlyRate1.Margin = new Padding(2, 0, 2, 0);
      this.lblMonthlyRate1.Name = "lblMonthlyRate1";
      this.lblMonthlyRate1.RightToLeft = RightToLeft.No;
      this.lblMonthlyRate1.Size = new Size(43, 14);
      this.lblMonthlyRate1.TabIndex = 718;
      this.lblMonthlyRate1.Text = "1516";
      this.lblMonthlyRate1.TextAlign = ContentAlignment.TopCenter;
      this.Label37.BackColor = Color.FromArgb(155, 183, 225);
      this.Label37.Cursor = Cursors.Default;
      this.Label37.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label37.ForeColor = Color.Blue;
      this.Label37.Location = new Point(94, 21);
      this.Label37.Margin = new Padding(2, 0, 2, 0);
      this.Label37.Name = "Label37";
      this.Label37.RightToLeft = RightToLeft.No;
      this.Label37.Size = new Size(86, 14);
      this.Label37.TabIndex = 717;
      this.Label37.Text = "ROOM RATE :";
      this.Label37.TextAlign = ContentAlignment.TopRight;
      this.Label39.BackColor = Color.FromArgb(155, 183, 225);
      this.Label39.Cursor = Cursors.Default;
      this.Label39.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label39.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label39.Location = new Point(115, 102);
      this.Label39.Margin = new Padding(2, 0, 2, 0);
      this.Label39.Name = "Label39";
      this.Label39.RightToLeft = RightToLeft.No;
      this.Label39.Size = new Size(57, 14);
      this.Label39.TabIndex = 716;
      this.Label39.Text = "Monthly ";
      this.Label39.TextAlign = ContentAlignment.TopRight;
      this.Label38.BackColor = Color.FromArgb(155, 183, 225);
      this.Label38.Cursor = Cursors.Default;
      this.Label38.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label38.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label38.Location = new Point(115, 73);
      this.Label38.Margin = new Padding(2, 0, 2, 0);
      this.Label38.Name = "Label38";
      this.Label38.RightToLeft = RightToLeft.No;
      this.Label38.Size = new Size(57, 14);
      this.Label38.TabIndex = 714;
      this.Label38.Text = "Weekly ";
      this.Label38.TextAlign = ContentAlignment.TopRight;
      this.lblWeeklyRate.BackColor = Color.FromArgb(155, 183, 225);
      this.lblWeeklyRate.Cursor = Cursors.Default;
      this.lblWeeklyRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWeeklyRate.ForeColor = Color.Yellow;
      this.lblWeeklyRate.Location = new Point(197, 74);
      this.lblWeeklyRate.Margin = new Padding(2, 0, 2, 0);
      this.lblWeeklyRate.Name = "lblWeeklyRate";
      this.lblWeeklyRate.RightToLeft = RightToLeft.No;
      this.lblWeeklyRate.Size = new Size(43, 14);
      this.lblWeeklyRate.TabIndex = 713;
      this.lblWeeklyRate.Text = "365";
      this.lblWeeklyRate.TextAlign = ContentAlignment.TopCenter;
      this.lblIssued.BackColor = Color.FromArgb(155, 183, 225);
      this.lblIssued.Cursor = Cursors.Default;
      this.lblIssued.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblIssued.ForeColor = Color.Blue;
      this.lblIssued.Location = new Point(442, 43);
      this.lblIssued.Margin = new Padding(2, 0, 2, 0);
      this.lblIssued.Name = "lblIssued";
      this.lblIssued.RightToLeft = RightToLeft.No;
      this.lblIssued.Size = new Size(49, 14);
      this.lblIssued.TabIndex = 712;
      this.lblIssued.Text = "2";
      this.Label31.BackColor = Color.FromArgb(155, 183, 225);
      this.Label31.Cursor = Cursors.Default;
      this.Label31.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label31.ForeColor = SystemColors.ControlText;
      this.Label31.Location = new Point(357, 43);
      this.Label31.Margin = new Padding(2, 0, 2, 0);
      this.Label31.Name = "Label31";
      this.Label31.RightToLeft = RightToLeft.No;
      this.Label31.Size = new Size(80, 14);
      this.Label31.TabIndex = 711;
      this.Label31.Text = "Issued Card ";
      this.Label31.TextAlign = ContentAlignment.TopRight;
      this.lblDailyRate.BackColor = Color.FromArgb(155, 183, 225);
      this.lblDailyRate.Cursor = Cursors.Default;
      this.lblDailyRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDailyRate.ForeColor = Color.Yellow;
      this.lblDailyRate.Location = new Point(197, 44);
      this.lblDailyRate.Margin = new Padding(2, 0, 2, 0);
      this.lblDailyRate.Name = "lblDailyRate";
      this.lblDailyRate.RightToLeft = RightToLeft.No;
      this.lblDailyRate.Size = new Size(43, 14);
      this.lblDailyRate.TabIndex = 710;
      this.lblDailyRate.Text = "60";
      this.lblDailyRate.TextAlign = ContentAlignment.TopCenter;
      this.Label28.BackColor = Color.FromArgb(155, 183, 225);
      this.Label28.Cursor = Cursors.Default;
      this.Label28.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label28.Location = new Point(112, 43);
      this.Label28.Margin = new Padding(2, 0, 2, 0);
      this.Label28.Name = "Label28";
      this.Label28.RightToLeft = RightToLeft.No;
      this.Label28.Size = new Size(50, 14);
      this.Label28.TabIndex = 709;
      this.Label28.Text = "Daily ";
      this.Label28.TextAlign = ContentAlignment.TopRight;
      this.lblNo.BackColor = Color.FromArgb(155, 183, 225);
      this.lblNo.Cursor = Cursors.Default;
      this.lblNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblNo.ForeColor = Color.Red;
      this.lblNo.Location = new Point(59, 44);
      this.lblNo.Margin = new Padding(2, 0, 2, 0);
      this.lblNo.Name = "lblNo";
      this.lblNo.RightToLeft = RightToLeft.No;
      this.lblNo.Size = new Size(49, 20);
      this.lblNo.TabIndex = 708;
      this.lblNo.Text = "10220";
      this.lblNo.TextAlign = ContentAlignment.TopCenter;
      this.Label26.BackColor = Color.FromArgb(155, 183, 225);
      this.Label26.Cursor = Cursors.Default;
      this.Label26.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.Blue;
      this.Label26.Location = new Point(17, 44);
      this.Label26.Margin = new Padding(2, 0, 2, 0);
      this.Label26.Name = "Label26";
      this.Label26.RightToLeft = RightToLeft.No;
      this.Label26.Size = new Size(49, 14);
      this.Label26.TabIndex = 707;
      this.Label26.Text = "Room No. ";
      this.lblBuildingType.BackColor = Color.White;
      this.lblBuildingType.Cursor = Cursors.Default;
      this.lblBuildingType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuildingType.ForeColor = Color.Blue;
      this.lblBuildingType.Location = new Point(729, 11);
      this.lblBuildingType.Margin = new Padding(2, 0, 2, 0);
      this.lblBuildingType.Name = "lblBuildingType";
      this.lblBuildingType.RightToLeft = RightToLeft.No;
      this.lblBuildingType.Size = new Size(55, 20);
      this.lblBuildingType.TabIndex = 741;
      this.lblRmType.AutoSize = true;
      this.lblRmType.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.lblRmType.ForeColor = Color.Red;
      this.lblRmType.Location = new Point(357, 21);
      this.lblRmType.Name = "lblRmType";
      this.lblRmType.Size = new Size(46, 14);
      this.lblRmType.TabIndex = 726;
      this.lblRmType.Text = "STUDIO";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(793, 602);
      this.Controls.Add((Control) this.lblBuildingType);
      this.Controls.Add((Control) this.DetailFrame);
      this.Controls.Add((Control) this.ViewFrame);
      this.Controls.Add((Control) this.StatusFrame);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.lbBuilding);
      this.Controls.Add((Control) this.cboBuilding);
      this.Controls.Add((Control) this.groupBox_RoomsDisplay);
      this.Margin = new Padding(2);
      this.Name = "Form_SHL_AvailableRooms";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "View Room Status";
      this.Load += new EventHandler(this.Form_SHL_RoomView_Load);
      this.VisibleChanged += new EventHandler(this.Form_SHL_ViewRoomReservation_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_SHL_ViewRoomReservation_FormClosing);
      this.tabControl1.ResumeLayout(false);
      this.Level1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab1).EndInit();
      this.Level2.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab2).EndInit();
      this.Level3.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab3).EndInit();
      this.Level4.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab4).EndInit();
      this.Level5.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab5).EndInit();
      this.Level6.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab6).EndInit();
      this.Level7.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab7).EndInit();
      this.All_Level.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab8).EndInit();
      this.StatusFrame.ResumeLayout(false);
      this.ViewFrame.ResumeLayout(false);
      this.ViewFrame.PerformLayout();
      this.StudioFrame.ResumeLayout(false);
      this.DateFrame.ResumeLayout(false);
      this.DateFrame.PerformLayout();
      this.groupBox_RoomsDisplay.ResumeLayout(false);
      ((ISupportInitialize) this.gViewRoomTempBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.DetailFrame.ResumeLayout(false);
      this.DetailFrame.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
