// Decompiled with JetBrains decompiler
// Type: AMS.Form_Roombwr
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.SystemDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_Roombwr : Form
  {
    private DB db = new DB();
    private string ord = "";
    private IContainer components;
    public ComboBox cboOrder;
    public Button cmdSelect;
    public Button cmdCancel;
    public ToolTip ToolTip1;
    public Label Label2;
    private DataGridView dataGridView1;
    private SystemDataSet systemDataSet;
    private RoomTableAdapter roomTableAdapter;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn floorNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn buildingNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dailyRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weeklyRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn monthlyRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dailyRate2DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weeklyRate2DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn monthlyRate2DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn issuedCardDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn totalStayDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
    private BindingSource roomBindingSource1;

    public Form_Roombwr() => this.InitializeComponent();

    private void Form_Roombwr_Load(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRoomSearch(this.cboOrder);
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.RoomTableAdapter_1.Fill(ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet.Room);
      this.roomBindingSource1.DataSource = (object) ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet;
      this.Check_Selected_Order();
      this.Load_Room_Data();
      this.dataGridView1.Focus();
      this.dataGridView1.Select();
    }

    private void Load_Room_Data()
    {
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.RoomTableAdapter_1.Fill(ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet.Room);
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.RoomTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from Room " + this.ord;
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.RoomTableAdapter_1.Fill(ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet.Room);
      this.dataGridView1.Refresh();
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.selected_rowindex = 0;
    }

    private void Check_Selected_Order()
    {
      this.ord = "";
      switch (this.cboOrder.SelectedIndex)
      {
        case 0:
          this.ord = " ORDER BY RoomNo";
          break;
        case 1:
          this.ord = " ORDER BY RoomID";
          break;
        case 2:
          this.ord = " ORDER BY RoomType";
          break;
        case 3:
          this.ord = " ORDER BY FloorNo";
          break;
        case 4:
          this.ord = " ORDER BY BuildingNo";
          break;
        case 5:
          this.ord = " ORDER BY DailyRate";
          break;
        case 6:
          this.ord = " ORDER BY WeeklyRate";
          break;
        case 7:
          this.ord = " ORDER BY MonthlyRate";
          break;
        case 8:
          this.ord = " ORDER BY DailyRate2";
          break;
        case 9:
          this.ord = " ORDER BY WeeklyRate2";
          break;
        case 10:
          this.ord = " ORDER BY MonthlyRate2";
          break;
        case 11:
          this.ord = " ORDER BY IssuedCard";
          break;
        case 12:
          this.ord = " ORDER BY TotalStay";
          break;
      }
    }

    private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_Selected_Order();
      this.Load_Room_Data();
    }

    private void dataGridView1_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet.Room.Rows.Count || this.dataGridView1.Rows.Count != ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Browse_Room_SystemDataSet.Room.Rows.Count)
        return;
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.selected_rowindex = e.Row.Index;
    }

    private void cmdSelect_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.OK_Flag = true;
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Selected_Room_No = (string) this.dataGridView1.Rows[ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.selected_rowindex].Cells[this.roomNoDataGridViewTextBoxColumn.Name].Value;
      this.Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.OK_Flag = false;
      this.Close();
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.cboOrder = new ComboBox();
      this.cmdSelect = new Button();
      this.cmdCancel = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.Label2 = new Label();
      this.dataGridView1 = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.floorNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.buildingNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.dailyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.weeklyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.monthlyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.dailyRate2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.weeklyRate2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.monthlyRate2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.issuedCardDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.totalStayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomBindingSource1 = new BindingSource(this.components);
      this.systemDataSet = new SystemDataSet();
      this.roomTableAdapter = new RoomTableAdapter();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.roomBindingSource1).BeginInit();
      this.systemDataSet.BeginInit();
      this.SuspendLayout();
      this.cboOrder.BackColor = SystemColors.Window;
      this.cboOrder.Cursor = Cursors.Default;
      this.cboOrder.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboOrder.ForeColor = SystemColors.WindowText;
      this.cboOrder.Location = new Point(79, 481);
      this.cboOrder.Name = "cboOrder";
      this.cboOrder.RightToLeft = RightToLeft.No;
      this.cboOrder.Size = new Size(145, 22);
      this.cboOrder.TabIndex = 13;
      this.cboOrder.SelectedIndexChanged += new EventHandler(this.cboOrder_SelectedIndexChanged);
      this.cmdSelect.BackColor = SystemColors.Control;
      this.cmdSelect.Cursor = Cursors.Default;
      this.cmdSelect.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSelect.ForeColor = SystemColors.ControlText;
      this.cmdSelect.Location = new Point(167, 521);
      this.cmdSelect.Name = "cmdSelect";
      this.cmdSelect.RightToLeft = RightToLeft.No;
      this.cmdSelect.Size = new Size(73, 25);
      this.cmdSelect.TabIndex = 11;
      this.cmdSelect.Text = "&Select";
      this.cmdSelect.UseVisualStyleBackColor = false;
      this.cmdSelect.Click += new EventHandler(this.cmdSelect_Click);
      this.cmdCancel.BackColor = SystemColors.Control;
      this.cmdCancel.Cursor = Cursors.Default;
      this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = SystemColors.ControlText;
      this.cmdCancel.Location = new Point(279, 521);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.RightToLeft = RightToLeft.No;
      this.cmdCancel.Size = new Size(73, 25);
      this.cmdCancel.TabIndex = 10;
      this.cmdCancel.Text = "&Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
      this.Label2.BackColor = SystemColors.Control;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(7, 481);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(81, 21);
      this.Label2.TabIndex = 14;
      this.Label2.Text = "Order By:";
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.floorNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.buildingNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.dailyRateDataGridViewTextBoxColumn, (DataGridViewColumn) this.weeklyRateDataGridViewTextBoxColumn, (DataGridViewColumn) this.monthlyRateDataGridViewTextBoxColumn, (DataGridViewColumn) this.dailyRate2DataGridViewTextBoxColumn, (DataGridViewColumn) this.weeklyRate2DataGridViewTextBoxColumn, (DataGridViewColumn) this.monthlyRate2DataGridViewTextBoxColumn, (DataGridViewColumn) this.issuedCardDataGridViewTextBoxColumn, (DataGridViewColumn) this.totalStayDataGridViewTextBoxColumn, (DataGridViewColumn) this.staffIDDataGridViewTextBoxColumn);
      this.dataGridView1.DataSource = (object) this.roomBindingSource1;
      this.dataGridView1.Location = new Point(1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle2;
      this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(780, 458);
      this.dataGridView1.TabIndex = 16;
      this.dataGridView1.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room No.";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
      this.roomIDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
      this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomIDDataGridViewTextBoxColumn.Width = 50;
      this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
      this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Type";
      this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
      this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomTypeDataGridViewTextBoxColumn.Width = 50;
      this.floorNoDataGridViewTextBoxColumn.DataPropertyName = "FloorNo";
      this.floorNoDataGridViewTextBoxColumn.HeaderText = "Level";
      this.floorNoDataGridViewTextBoxColumn.Name = "floorNoDataGridViewTextBoxColumn";
      this.floorNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.floorNoDataGridViewTextBoxColumn.Width = 50;
      this.buildingNoDataGridViewTextBoxColumn.DataPropertyName = "BuildingNo";
      this.buildingNoDataGridViewTextBoxColumn.HeaderText = "Building";
      this.buildingNoDataGridViewTextBoxColumn.Name = "buildingNoDataGridViewTextBoxColumn";
      this.buildingNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.buildingNoDataGridViewTextBoxColumn.Width = 50;
      this.dailyRateDataGridViewTextBoxColumn.DataPropertyName = "DailyRate";
      this.dailyRateDataGridViewTextBoxColumn.HeaderText = "DailyRate";
      this.dailyRateDataGridViewTextBoxColumn.Name = "dailyRateDataGridViewTextBoxColumn";
      this.dailyRateDataGridViewTextBoxColumn.ReadOnly = true;
      this.weeklyRateDataGridViewTextBoxColumn.DataPropertyName = "WeeklyRate";
      this.weeklyRateDataGridViewTextBoxColumn.HeaderText = "WeeklyRate";
      this.weeklyRateDataGridViewTextBoxColumn.Name = "weeklyRateDataGridViewTextBoxColumn";
      this.weeklyRateDataGridViewTextBoxColumn.ReadOnly = true;
      this.monthlyRateDataGridViewTextBoxColumn.DataPropertyName = "MonthlyRate";
      this.monthlyRateDataGridViewTextBoxColumn.HeaderText = "MonthlyRate";
      this.monthlyRateDataGridViewTextBoxColumn.Name = "monthlyRateDataGridViewTextBoxColumn";
      this.monthlyRateDataGridViewTextBoxColumn.ReadOnly = true;
      this.dailyRate2DataGridViewTextBoxColumn.DataPropertyName = "DailyRate2";
      this.dailyRate2DataGridViewTextBoxColumn.HeaderText = "DailyRate2";
      this.dailyRate2DataGridViewTextBoxColumn.Name = "dailyRate2DataGridViewTextBoxColumn";
      this.dailyRate2DataGridViewTextBoxColumn.ReadOnly = true;
      this.weeklyRate2DataGridViewTextBoxColumn.DataPropertyName = "WeeklyRate2";
      this.weeklyRate2DataGridViewTextBoxColumn.HeaderText = "WeeklyRate2";
      this.weeklyRate2DataGridViewTextBoxColumn.Name = "weeklyRate2DataGridViewTextBoxColumn";
      this.weeklyRate2DataGridViewTextBoxColumn.ReadOnly = true;
      this.monthlyRate2DataGridViewTextBoxColumn.DataPropertyName = "MonthlyRate2";
      this.monthlyRate2DataGridViewTextBoxColumn.HeaderText = "MonthlyRate2";
      this.monthlyRate2DataGridViewTextBoxColumn.Name = "monthlyRate2DataGridViewTextBoxColumn";
      this.monthlyRate2DataGridViewTextBoxColumn.ReadOnly = true;
      this.issuedCardDataGridViewTextBoxColumn.DataPropertyName = "IssuedCard";
      this.issuedCardDataGridViewTextBoxColumn.HeaderText = "Issued";
      this.issuedCardDataGridViewTextBoxColumn.Name = "issuedCardDataGridViewTextBoxColumn";
      this.issuedCardDataGridViewTextBoxColumn.ReadOnly = true;
      this.totalStayDataGridViewTextBoxColumn.DataPropertyName = "TotalStay";
      this.totalStayDataGridViewTextBoxColumn.HeaderText = "TotalStay";
      this.totalStayDataGridViewTextBoxColumn.Name = "totalStayDataGridViewTextBoxColumn";
      this.totalStayDataGridViewTextBoxColumn.ReadOnly = true;
      this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
      this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomBindingSource1.DataMember = "Room";
      this.roomBindingSource1.DataSource = (object) this.systemDataSet;
      this.systemDataSet.DataSetName = "SystemDataSet";
      this.systemDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.roomTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(793, 573);
      this.ControlBox = false;
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.cboOrder);
      this.Controls.Add((Control) this.cmdSelect);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.Label2);
      this.Name = "Form_Roombwr";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form_Roombwr";
      this.Load += new EventHandler(this.Form_Roombwr_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.roomBindingSource1).EndInit();
      this.systemDataSet.EndInit();
      this.ResumeLayout(false);
    }
  }
}
