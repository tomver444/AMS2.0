// Decompiled with JetBrains decompiler
// Type: AMS.Form_RmStatusbwr
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.BuildingDB1DataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_RmStatusbwr : Form
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
    private BuildingDB1DataSet buildingDB1DataSet;
    private BindingSource roomStatusBindingSource;
    private RoomStatusTableAdapter roomStatusTableAdapter;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn Description;
    private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;

    public Form_RmStatusbwr() => this.InitializeComponent();

    private void Form_RmStatusbwr_Load(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmStatusSearch(this.cboOrder);
      this.roomStatusBindingSource.DataSource = (object) ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Browse_RoomStatus_BuildingDB1DataSet;
      this.Check_Selected_Order();
      this.Load_RoomStatus_Data();
      this.dataGridView1.Focus();
      this.dataGridView1.Select();
    }

    private void Load_RoomStatus_Data()
    {
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.RoomStatusTableAdapter_1.Fill(ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus);
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.RoomStatusTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from RoomStatus " + this.ord;
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.RoomStatusTableAdapter_1.Fill(ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus);
      this.dataGridView1.Refresh();
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.selected_rowindex = 0;
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
          this.ord = " ORDER BY Description";
          break;
        case 2:
          this.ord = " ORDER BY RoomType";
          break;
        case 3:
          this.ord = "ORDER BY ClientID";
          break;
        case 4:
          this.ord = " ORDER BY StartDate";
          break;
        case 5:
          this.ord = " ORDER BY EndDate";
          break;
      }
    }

    private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_Selected_Order();
      this.Load_RoomStatus_Data();
    }

    private void dataGridView1_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus.Rows.Count || this.dataGridView1.Rows.Count != ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus.Rows.Count)
        return;
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.selected_rowindex = e.Row.Index;
    }

    private void cmdSelect_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.OK_Flag = true;
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Selected_Room_No = (string) this.dataGridView1.Rows[ModDoorLockSystem.Form_RoomStatusDMS_Ptr.selected_rowindex].Cells[this.roomNoDataGridViewTextBoxColumn.Name].Value;
      this.Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.OK_Flag = false;
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
      this.cboOrder = new ComboBox();
      this.cmdSelect = new Button();
      this.cmdCancel = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.Label2 = new Label();
      this.dataGridView1 = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.Description = new DataGridViewTextBoxColumn();
      this.roomTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomStatusBindingSource = new BindingSource(this.components);
      this.buildingDB1DataSet = new BuildingDB1DataSet();
      this.roomStatusTableAdapter = new RoomStatusTableAdapter();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.roomStatusBindingSource).BeginInit();
      this.buildingDB1DataSet.BeginInit();
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
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.Description, (DataGridViewColumn) this.roomTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.startDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.endDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.staffIDDataGridViewTextBoxColumn);
      this.dataGridView1.DataSource = (object) this.roomStatusBindingSource;
      this.dataGridView1.Location = new Point(1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(780, 458);
      this.dataGridView1.TabIndex = 16;
      this.dataGridView1.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.Description.DataPropertyName = "Description";
      this.Description.HeaderText = "Status";
      this.Description.Name = "Description";
      this.Description.ReadOnly = true;
      this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
      this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Type";
      this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
      this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
      this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
      this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
      this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
      this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
      this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
      this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
      this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
      this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
      this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomStatusBindingSource.DataMember = "RoomStatus";
      this.roomStatusBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.buildingDB1DataSet.DataSetName = "BuildingDB1DataSet";
      this.buildingDB1DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.roomStatusTableAdapter.ClearBeforeFill = true;
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
      this.Name = "Form_RmStatusbwr";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Room Status";
      this.Load += new EventHandler(this.Form_RmStatusbwr_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.roomStatusBindingSource).EndInit();
      this.buildingDB1DataSet.EndInit();
      this.ResumeLayout(false);
    }
  }
}
