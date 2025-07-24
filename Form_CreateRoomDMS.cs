// Decompiled with JetBrains decompiler
// Type: AMS.Form_CreateRoomDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.SystemDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_CreateRoomDMS : Form
  {
    private DB db;
    private int selected_rowindex = -1;
    private IContainer components;
    public ComboBox cboBuildingType;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public TextBox txtBldName;
    public ListBox lstRoom;
    public Button cmdCreate;
    public Button cmdDelete;
    public Label Label3;
    public Label Label2;
    public Label lbBuildingNo;
    public Label Label5;
    public Label Label4;
    public Label lbFloorNo;
    public Label Label1;
    private SystemDataSet systemDataSet;
    private BindingSource roomBindingSource;
    private RoomTableAdapter roomTableAdapter;
    private Process process1;
    public TextBox textBox_NewRoom_Complete;
    public TextBox textBox_NewRoom;
    public Label lb_NewRoom;
    public Label label6;
    private DataGridView dataGridView_Room;
    private BindingSource roomBindingSource1;
    private ComboBox comboBox_FloorNumber;
    public ComboBox cboBuildingNo;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn1;
    public Label label_RoomSelectedTodelete;
    public TextBox textBox_RoomSelectedToDelete;
    private GroupBox groupBox_NewRoomToCreate;
    private GroupBox groupBox_RoomToDelete;
    public Label label8;
    public Label label7;
    public Button cmd_BldNameUpdate;

    public Form_CreateRoomDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
    }

    private void Form_CreateRoomDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_CreateRoomDMS_Load(object sender, EventArgs e)
    {
      this.roomBindingSource1.DataSource = (object) this.db.system_DB.systemDataSet;
      this.db.CheckBuilding(this.cboBuildingNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == (string) this.cboBuildingNo.SelectedItem)
        {
          this.txtBldName.Text = row.BldName;
          this.cboBuildingType.Items.Add((object) row.BuildingType);
        }
      }
      if (this.cboBuildingType.Items.Count > 0)
        this.cboBuildingType.SelectedIndex = 0;
      for (int index = 1; index <= 99; ++index)
        this.comboBox_FloorNumber.Items.Add((object) index.ToString());
      this.comboBox_FloorNumber.SelectedIndex = 0;
    }

    private void Init_lstRoom(string para_Bld_Num, string para_Flr_Num)
    {
      this.lstRoom.Items.Clear();
      string str1 = para_Bld_Num + para_Flr_Num;
      for (int index = 1; index < 100; ++index)
      {
        string str2 = index.ToString("D2");
        bool flag = false;
        foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
        {
          if (str2 == row.RoomNo.Substring(3, 2))
          {
            flag = true;
            break;
          }
        }
        if (!flag)
          this.lstRoom.Items.Add((object) str2);
      }
    }

    private void Init_Data()
    {
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      this.dataGridView_Room.Refresh();
      if (this.dataGridView_Room.Rows.Count > 0)
        this.dataGridView_Room.Rows[0].Selected = false;
      this.Init_lstRoom((string) this.cboBuildingNo.SelectedItem, Convert.ToByte((string) this.comboBox_FloorNumber.SelectedItem).ToString("D2"));
      this.lstRoom.Select();
      this.cmdCreate.Enabled = false;
      this.cmdDelete.Enabled = false;
      this.groupBox_RoomToDelete.Visible = false;
      this.groupBox_NewRoomToCreate.Visible = false;
      this.Label1.Text = "Select Any New Room or Current Room List To Create or Delete Room";
    }

    private void Form_CreateRoomDMS_VisibleChanged(object sender, EventArgs e) => this.Init_Data();

    private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lstRoom.SelectedIndex < 0)
        return;
      this.textBox_NewRoom.Text = (string) this.lstRoom.SelectedItem;
      this.textBox_NewRoom_Complete.Text = this.cboBuildingNo.SelectedItem.ToString() + Convert.ToByte((string) this.comboBox_FloorNumber.SelectedItem).ToString("D2") + (string) this.lstRoom.SelectedItem;
      if (this.selected_rowindex >= 0 && this.selected_rowindex < this.dataGridView_Room.Rows.Count)
        this.dataGridView_Room.Rows[this.selected_rowindex].Selected = false;
      this.cmdCreate.Enabled = true;
      this.cmdDelete.Enabled = false;
      this.groupBox_RoomToDelete.Visible = false;
      this.groupBox_NewRoomToCreate.Visible = true;
      this.Label1.Text = "Click CREATE Button to Create Room";
    }

    private void dataGridView_Room_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.system_DB.systemDataSet.Room.Rows.Count || this.dataGridView_Room.Rows.Count != this.db.system_DB.systemDataSet.Room.Rows.Count)
        return;
      this.textBox_RoomSelectedToDelete.Text = (string) this.dataGridView_Room.Rows[e.Row.Index].Cells[this.roomNoDataGridViewTextBoxColumn1.Name].Value;
      this.selected_rowindex = e.Row.Index;
      if (this.lstRoom.SelectedIndex >= 0)
        this.lstRoom.SetSelected(this.lstRoom.SelectedIndex, false);
      this.cmdCreate.Enabled = false;
      this.cmdDelete.Enabled = true;
      this.groupBox_RoomToDelete.Visible = true;
      this.groupBox_NewRoomToCreate.Visible = false;
      this.Label1.Text = "Click DELETE Button to delete Room";
    }

    private void comboBox_FloorNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
    }

    private void cboBuildingNo_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void cboBuildingType_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void comboBox_FloorNumber_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Init_lstRoom((string) this.cboBuildingNo.SelectedItem, Convert.ToByte((string) this.comboBox_FloorNumber.SelectedItem).ToString("D2"));
      this.lstRoom.Select();
      this.cmdCreate.Enabled = false;
      this.cmdDelete.Enabled = false;
      this.groupBox_RoomToDelete.Visible = false;
      this.groupBox_NewRoomToCreate.Visible = false;
      this.Label1.Text = "Select Any New Room or Current Room List To Create or Delete Room";
      this.dataGridView_Room.Refresh();
      if (this.dataGridView_Room.Rows.Count <= 0)
        return;
      this.dataGridView_Room.Rows[0].Selected = false;
    }

    private bool RC_Room_Add(string para_RoomNo)
    {
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          int num = (int) MessageBox.Show(para_RoomNo + " is already existed !", "ALARM");
          return false;
        }
      }
      SystemDataSet.RoomRow row1 = this.db.system_DB.systemDataSet.Room.NewRoomRow();
      row1.RoomNo = para_RoomNo;
      row1.FloorNo = para_RoomNo.Substring(1, 2);
      row1.BuildingNo = para_RoomNo.Substring(0, 1);
      row1.RoomID = this.textBox_NewRoom.Text;
      row1.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      row1.Update = false;
      row1.RoomType = (byte) 1;
      row1.DailyRate = 0M;
      row1.DailyRate2 = 0M;
      row1.WeeklyRate = 0M;
      row1.WeeklyRate2 = 0M;
      row1.MonthlyRate = 0M;
      row1.MonthlyRate2 = 0M;
      row1.IssuedCard = (short) 0;
      row1.TotalStay = (byte) 0;
      this.db.system_DB.systemDataSet.Room.AddRoomRow(row1);
      if (this.db.system_DB.roomTableAdapter.Update(this.db.system_DB.systemDataSet.Room) > 0)
        return true;
      int num1 = (int) MessageBox.Show("Can not Create " + para_RoomNo + " !", "ALARM");
      return false;
    }

    private bool RC_Status_Add(string para_BuildingNo, string para_RoomNo)
    {
      bool flag1 = false;
      bool flag2 = false;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          flag1 = true;
          break;
        }
      }
      if (!flag1)
      {
        BuildingDB1DataSet.RoomStatusRow row = this.db.building_DB1.buildingDB1DataSet.RoomStatus.NewRoomStatusRow();
        row.RoomNo = para_RoomNo;
        row.RoomType = (byte) 1;
        row.StartDate = DateTime.Now.Date;
        row.EndDate = DateTime.Now.Date;
        row.Status = (byte) 0;
        row.Description = "Vacant";
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        row.Update = false;
        this.db.building_DB1.buildingDB1DataSet.RoomStatus.AddRoomStatusRow(row);
        if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
        {
          this.db.Update_RoomStausXX_inSystemDB((string) this.cboBuildingNo.SelectedItem);
          flag2 = true;
        }
      }
      return flag2;
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
      Convert.ToInt16((string) this.comboBox_FloorNumber.SelectedItem).ToString("D2");
      this.RC_Floor_Add((string) this.cboBuildingNo.SelectedItem, Convert.ToByte((string) this.comboBox_FloorNumber.SelectedItem).ToString("D2"));
      if (!this.RC_Room_Add(this.textBox_NewRoom_Complete.Text))
        return;
      this.RC_Status_Add((string) this.cboBuildingNo.SelectedItem, this.textBox_NewRoom_Complete.Text);
      int num = (int) MessageBox.Show("Create Room No." + this.textBox_NewRoom_Complete.Text + " Successful !");
      this.Init_Data();
    }

    private bool RC_Floor_Add(string para_BuildingNo, string para_FloorNo)
    {
      bool flag = false;
      this.db.system_DB.floorTableAdapter.Fill(this.db.system_DB.systemDataSet.Floor);
      foreach (SystemDataSet.FloorRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Floor.Rows)
      {
        if (row.BuildingNo == para_BuildingNo && row.FloorNo == para_FloorNo)
        {
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        SystemDataSet.FloorRow row = this.db.system_DB.systemDataSet.Floor.NewFloorRow();
        row.FloorNo = para_FloorNo;
        row.BuildingNo = para_BuildingNo;
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        row.Update = false;
        this.db.system_DB.systemDataSet.Floor.AddFloorRow(row);
        if (this.db.system_DB.floorTableAdapter.Update(this.db.system_DB.systemDataSet.Floor) > 0)
          return true;
      }
      return false;
    }

    private bool RC_Room_Del(string para_RoomNo)
    {
      if (this.db.system_DB.roomTableAdapter.Delete(para_RoomNo) > 0)
        return true;
      int num = (int) MessageBox.Show("Can not Delete " + para_RoomNo + " !", "ALARM");
      return false;
    }

    private bool RC_Status_Del(string para_BuildingNo, string para_RoomNo)
    {
      return this.db.building_DB1.roomStatusTableAdapter.Delete(para_RoomNo) > 0;
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      if (!this.RC_Room_Del(this.textBox_RoomSelectedToDelete.Text))
        return;
      this.RC_Status_Del((string) this.cboBuildingNo.SelectedItem, this.textBox_RoomSelectedToDelete.Text);
      int num = (int) MessageBox.Show("Delete Room No." + this.textBox_RoomSelectedToDelete.Text + " Successful !");
      this.Init_Data();
    }

    private bool RC_Building_Add(
      string para_BuildingNumber,
      string para_BldName,
      string para_BldType)
    {
      bool flag = false;
      this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == para_BuildingNumber)
        {
          row.BldName = para_BldName;
          row.BuildingType = para_BldType;
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.BuildingNo = para_BuildingNumber;
          flag = true;
          break;
        }
      }
      return flag && this.db.system_DB.buildingTableAdapter.Update(this.db.system_DB.systemDataSet.Building) > 0;
    }

    private void cmd_BldNameUpdate_Click(object sender, EventArgs e)
    {
      if (this.RC_Building_Add((string) this.cboBuildingNo.SelectedItem, this.txtBldName.Text, (string) this.cboBuildingType.SelectedItem))
      {
        int num1 = (int) MessageBox.Show("Already Saved!");
      }
      else
      {
        int num2 = (int) MessageBox.Show("Can not Update!");
      }
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_CreateRoomDMS));
      this.cboBuildingType = new ComboBox();
      this.cmdReturn = new Button();
      this.txtBldName = new TextBox();
      this.lstRoom = new ListBox();
      this.roomBindingSource = new BindingSource(this.components);
      this.systemDataSet = new SystemDataSet();
      this.cmdCreate = new Button();
      this.cmdDelete = new Button();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.lbBuildingNo = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.textBox_NewRoom = new TextBox();
      this.textBox_NewRoom_Complete = new TextBox();
      this.cboBuildingNo = new ComboBox();
      this.textBox_RoomSelectedToDelete = new TextBox();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.lbFloorNo = new Label();
      this.Label1 = new Label();
      this.process1 = new Process();
      this.lb_NewRoom = new Label();
      this.label6 = new Label();
      this.dataGridView_Room = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.roomBindingSource1 = new BindingSource(this.components);
      this.comboBox_FloorNumber = new ComboBox();
      this.label_RoomSelectedTodelete = new Label();
      this.groupBox_NewRoomToCreate = new GroupBox();
      this.groupBox_RoomToDelete = new GroupBox();
      this.label7 = new Label();
      this.label8 = new Label();
      this.roomTableAdapter = new RoomTableAdapter();
      this.cmd_BldNameUpdate = new Button();
      ((ISupportInitialize) this.roomBindingSource).BeginInit();
      this.systemDataSet.BeginInit();
      ((ISupportInitialize) this.dataGridView_Room).BeginInit();
      ((ISupportInitialize) this.roomBindingSource1).BeginInit();
      this.groupBox_NewRoomToCreate.SuspendLayout();
      this.groupBox_RoomToDelete.SuspendLayout();
      this.SuspendLayout();
      this.cboBuildingType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.cboBuildingType.Cursor = Cursors.Default;
      this.cboBuildingType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingType.ForeColor = Color.Blue;
      this.cboBuildingType.Location = new Point(658, 113);
      this.cboBuildingType.Name = "cboBuildingType";
      this.cboBuildingType.RightToLeft = RightToLeft.No;
      this.cboBuildingType.Size = new Size(105, 22);
      this.cboBuildingType.TabIndex = 29;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingType, "Building Type");
      this.cboBuildingType.KeyPress += new KeyPressEventHandler(this.cboBuildingType_KeyPress);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(543, 422);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(129, 39);
      this.cmdReturn.TabIndex = 21;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Switch Back to Main Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtBldName.AcceptsReturn = true;
      this.txtBldName.BackColor = SystemColors.Window;
      this.txtBldName.Cursor = Cursors.IBeam;
      this.txtBldName.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtBldName.ForeColor = SystemColors.WindowText;
      this.txtBldName.Location = new Point(554, 153);
      this.txtBldName.MaxLength = 20;
      this.txtBldName.Name = "txtBldName";
      this.txtBldName.RightToLeft = RightToLeft.No;
      this.txtBldName.Size = new Size(209, 20);
      this.txtBldName.TabIndex = 17;
      this.ToolTip1.SetToolTip((Control) this.txtBldName, "Enter Building Name");
      this.lstRoom.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lstRoom.ColumnWidth = 30;
      this.lstRoom.Cursor = Cursors.Default;
      this.lstRoom.DataBindings.Add(new Binding("SelectedValue", (object) this.roomBindingSource, "RoomNo", true));
      this.lstRoom.Font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lstRoom.ForeColor = SystemColors.WindowText;
      this.lstRoom.ItemHeight = 16;
      this.lstRoom.Location = new Point(24, 130);
      this.lstRoom.MultiColumn = true;
      this.lstRoom.Name = "lstRoom";
      this.lstRoom.RightToLeft = RightToLeft.No;
      this.lstRoom.Size = new Size(188, 356);
      this.lstRoom.TabIndex = 22;
      this.lstRoom.SelectedIndexChanged += new EventHandler(this.lstRoom_SelectedIndexChanged);
      this.roomBindingSource.DataMember = "Room";
      this.roomBindingSource.DataSource = (object) this.systemDataSet;
      this.systemDataSet.DataSetName = "SystemDataSet";
      this.systemDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.cmdCreate.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.cmdCreate.Cursor = Cursors.Default;
      this.cmdCreate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdCreate.ForeColor = SystemColors.ControlText;
      this.cmdCreate.Location = new Point(543, 309);
      this.cmdCreate.Name = "cmdCreate";
      this.cmdCreate.RightToLeft = RightToLeft.No;
      this.cmdCreate.Size = new Size(129, 39);
      this.cmdCreate.TabIndex = 19;
      this.cmdCreate.Text = "&CREATE ROOM";
      this.ToolTip1.SetToolTip((Control) this.cmdCreate, "To Create Room");
      this.cmdCreate.UseVisualStyleBackColor = false;
      this.cmdCreate.Click += new EventHandler(this.cmdCreate_Click);
      this.cmdDelete.BackColor = Color.FromArgb(0, 192, 0);
      this.cmdDelete.Cursor = Cursors.Default;
      this.cmdDelete.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDelete.ForeColor = SystemColors.ControlText;
      this.cmdDelete.Location = new Point(543, 365);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.RightToLeft = RightToLeft.No;
      this.cmdDelete.Size = new Size(129, 39);
      this.cmdDelete.TabIndex = 20;
      this.cmdDelete.Text = "&DELETE ROOM";
      this.ToolTip1.SetToolTip((Control) this.cmdDelete, "To Delete Room");
      this.cmdDelete.UseVisualStyleBackColor = false;
      this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(2, 9);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(785, 41);
      this.Label3.TabIndex = 27;
      this.Label3.Text = "System Mode";
      this.Label3.TextAlign = ContentAlignment.TopCenter;
      this.Label2.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(2, 65);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 25);
      this.Label2.TabIndex = 26;
      this.Label2.Text = "CREATE ROOM ";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.lbBuildingNo.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lbBuildingNo.Cursor = Cursors.Default;
      this.lbBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbBuildingNo.ForeColor = SystemColors.ControlText;
      this.lbBuildingNo.Location = new Point(458, 113);
      this.lbBuildingNo.Name = "lbBuildingNo";
      this.lbBuildingNo.RightToLeft = RightToLeft.No;
      this.lbBuildingNo.Size = new Size(83, 20);
      this.lbBuildingNo.TabIndex = 25;
      this.lbBuildingNo.Text = "Building No.";
      this.textBox_NewRoom.AcceptsReturn = true;
      this.textBox_NewRoom.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.textBox_NewRoom.Cursor = Cursors.IBeam;
      this.textBox_NewRoom.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox_NewRoom.ForeColor = SystemColors.WindowText;
      this.textBox_NewRoom.Location = new Point(109, 28);
      this.textBox_NewRoom.MaxLength = 2;
      this.textBox_NewRoom.Name = "textBox_NewRoom";
      this.textBox_NewRoom.ReadOnly = true;
      this.textBox_NewRoom.RightToLeft = RightToLeft.No;
      this.textBox_NewRoom.Size = new Size(34, 22);
      this.textBox_NewRoom.TabIndex = 34;
      this.ToolTip1.SetToolTip((Control) this.textBox_NewRoom, "Enter Floor No.");
      this.textBox_NewRoom_Complete.AcceptsReturn = true;
      this.textBox_NewRoom_Complete.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.textBox_NewRoom_Complete.Cursor = Cursors.IBeam;
      this.textBox_NewRoom_Complete.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox_NewRoom_Complete.ForeColor = SystemColors.WindowText;
      this.textBox_NewRoom_Complete.Location = new Point(198, 28);
      this.textBox_NewRoom_Complete.MaxLength = 2;
      this.textBox_NewRoom_Complete.Name = "textBox_NewRoom_Complete";
      this.textBox_NewRoom_Complete.ReadOnly = true;
      this.textBox_NewRoom_Complete.RightToLeft = RightToLeft.No;
      this.textBox_NewRoom_Complete.Size = new Size(67, 22);
      this.textBox_NewRoom_Complete.TabIndex = 35;
      this.ToolTip1.SetToolTip((Control) this.textBox_NewRoom_Complete, "Enter Floor No.");
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = SystemColors.WindowText;
      this.cboBuildingNo.Location = new Point(546, 111);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 22);
      this.cboBuildingNo.TabIndex = 475;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Choose Building No.");
      this.cboBuildingNo.KeyPress += new KeyPressEventHandler(this.cboBuildingNo_KeyPress);
      this.textBox_RoomSelectedToDelete.AcceptsReturn = true;
      this.textBox_RoomSelectedToDelete.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.textBox_RoomSelectedToDelete.Cursor = Cursors.IBeam;
      this.textBox_RoomSelectedToDelete.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox_RoomSelectedToDelete.ForeColor = SystemColors.WindowText;
      this.textBox_RoomSelectedToDelete.Location = new Point(144, 26);
      this.textBox_RoomSelectedToDelete.MaxLength = 2;
      this.textBox_RoomSelectedToDelete.Name = "textBox_RoomSelectedToDelete";
      this.textBox_RoomSelectedToDelete.ReadOnly = true;
      this.textBox_RoomSelectedToDelete.RightToLeft = RightToLeft.No;
      this.textBox_RoomSelectedToDelete.Size = new Size(67, 22);
      this.textBox_RoomSelectedToDelete.TabIndex = 476;
      this.ToolTip1.SetToolTip((Control) this.textBox_RoomSelectedToDelete, "Enter Floor No.");
      this.Label5.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(602, 105);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(51, 28);
      this.Label5.TabIndex = 31;
      this.Label5.Text = "Building Type. ";
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(458, 153);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(83, 20);
      this.Label4.TabIndex = 28;
      this.Label4.Text = "Building Name";
      this.lbFloorNo.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lbFloorNo.Cursor = Cursors.Default;
      this.lbFloorNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbFloorNo.ForeColor = SystemColors.ControlText;
      this.lbFloorNo.Location = new Point(458, 193);
      this.lbFloorNo.Name = "lbFloorNo";
      this.lbFloorNo.RightToLeft = RightToLeft.No;
      this.lbFloorNo.Size = new Size(83, 20);
      this.lbFloorNo.TabIndex = 24;
      this.lbFloorNo.Text = "Level No.";
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Red;
      this.Label1.Location = new Point(11, 499);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(593, 49);
      this.Label1.TabIndex = 23;
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.process1.StartInfo.Domain = "";
      this.process1.StartInfo.LoadUserProfile = false;
      this.process1.StartInfo.Password = (SecureString) null;
      this.process1.StartInfo.StandardErrorEncoding = (Encoding) null;
      this.process1.StartInfo.StandardOutputEncoding = (Encoding) null;
      this.process1.StartInfo.UserName = "";
      this.process1.SynchronizingObject = (ISynchronizeInvoke) this;
      this.lb_NewRoom.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lb_NewRoom.Cursor = Cursors.Default;
      this.lb_NewRoom.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lb_NewRoom.ForeColor = Color.Red;
      this.lb_NewRoom.Location = new Point(13, 28);
      this.lb_NewRoom.Name = "lb_NewRoom";
      this.lb_NewRoom.RightToLeft = RightToLeft.No;
      this.lb_NewRoom.Size = new Size(83, 20);
      this.lb_NewRoom.TabIndex = 33;
      this.lb_NewRoom.Text = "New Room No";
      this.label6.BackColor = SystemColors.Control;
      this.label6.Cursor = Cursors.Default;
      this.label6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = SystemColors.ActiveCaption;
      this.label6.Location = new Point(156, 28);
      this.label6.Name = "label6";
      this.label6.RightToLeft = RightToLeft.No;
      this.label6.Size = new Size(31, 20);
      this.label6.TabIndex = 36;
      this.label6.Text = "=>";
      this.dataGridView_Room.AllowUserToAddRows = false;
      this.dataGridView_Room.AllowUserToDeleteRows = false;
      this.dataGridView_Room.AllowUserToResizeColumns = false;
      this.dataGridView_Room.AllowUserToResizeRows = false;
      this.dataGridView_Room.AutoGenerateColumns = false;
      this.dataGridView_Room.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Room.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn1);
      this.dataGridView_Room.DataSource = (object) this.roomBindingSource1;
      this.dataGridView_Room.Location = new Point(238, 130);
      this.dataGridView_Room.MultiSelect = false;
      this.dataGridView_Room.Name = "dataGridView_Room";
      this.dataGridView_Room.ReadOnly = true;
      this.dataGridView_Room.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView_Room.Size = new Size(198, 360);
      this.dataGridView_Room.TabIndex = 37;
      this.dataGridView_Room.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView_Room_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn1.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn1.HeaderText = "Room Number";
      this.roomNoDataGridViewTextBoxColumn1.Name = "roomNoDataGridViewTextBoxColumn1";
      this.roomNoDataGridViewTextBoxColumn1.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn1.Width = 150;
      this.roomBindingSource1.DataMember = "Room";
      this.roomBindingSource1.DataSource = (object) this.systemDataSet;
      this.comboBox_FloorNumber.FormattingEnabled = true;
      this.comboBox_FloorNumber.Location = new Point(554, 192);
      this.comboBox_FloorNumber.Name = "comboBox_FloorNumber";
      this.comboBox_FloorNumber.Size = new Size(68, 21);
      this.comboBox_FloorNumber.TabIndex = 38;
      this.comboBox_FloorNumber.SelectedIndexChanged += new EventHandler(this.comboBox_FloorNumber_SelectedIndexChanged);
      this.comboBox_FloorNumber.KeyPress += new KeyPressEventHandler(this.comboBox_FloorNumber_KeyPress);
      this.label_RoomSelectedTodelete.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label_RoomSelectedTodelete.Cursor = Cursors.Default;
      this.label_RoomSelectedTodelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label_RoomSelectedTodelete.ForeColor = Color.Red;
      this.label_RoomSelectedTodelete.Location = new Point(13, 29);
      this.label_RoomSelectedTodelete.Name = "label_RoomSelectedTodelete";
      this.label_RoomSelectedTodelete.RightToLeft = RightToLeft.No;
      this.label_RoomSelectedTodelete.Size = new Size(111, 20);
      this.label_RoomSelectedTodelete.TabIndex = 477;
      this.label_RoomSelectedTodelete.Text = "Selected Room";
      this.groupBox_NewRoomToCreate.Controls.Add((Control) this.label6);
      this.groupBox_NewRoomToCreate.Controls.Add((Control) this.textBox_NewRoom_Complete);
      this.groupBox_NewRoomToCreate.Controls.Add((Control) this.textBox_NewRoom);
      this.groupBox_NewRoomToCreate.Controls.Add((Control) this.lb_NewRoom);
      this.groupBox_NewRoomToCreate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox_NewRoomToCreate.ForeColor = Color.BlueViolet;
      this.groupBox_NewRoomToCreate.Location = new Point(461, 228);
      this.groupBox_NewRoomToCreate.Name = "groupBox_NewRoomToCreate";
      this.groupBox_NewRoomToCreate.Size = new Size(296, 63);
      this.groupBox_NewRoomToCreate.TabIndex = 478;
      this.groupBox_NewRoomToCreate.TabStop = false;
      this.groupBox_NewRoomToCreate.Text = "New Room";
      this.groupBox_RoomToDelete.Controls.Add((Control) this.label_RoomSelectedTodelete);
      this.groupBox_RoomToDelete.Controls.Add((Control) this.textBox_RoomSelectedToDelete);
      this.groupBox_RoomToDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox_RoomToDelete.ForeColor = Color.BlueViolet;
      this.groupBox_RoomToDelete.Location = new Point(461, 225);
      this.groupBox_RoomToDelete.Name = "groupBox_RoomToDelete";
      this.groupBox_RoomToDelete.Size = new Size(245, 60);
      this.groupBox_RoomToDelete.TabIndex = 479;
      this.groupBox_RoomToDelete.TabStop = false;
      this.groupBox_RoomToDelete.Text = "Selected Room";
      this.label7.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label7.Cursor = Cursors.Default;
      this.label7.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.Red;
      this.label7.Location = new Point(21, 107);
      this.label7.Name = "label7";
      this.label7.RightToLeft = RightToLeft.No;
      this.label7.Size = new Size(180, 20);
      this.label7.TabIndex = 480;
      this.label7.Text = "New Room List";
      this.label8.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label8.Cursor = Cursors.Default;
      this.label8.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.Red;
      this.label8.Location = new Point(235, 107);
      this.label8.Name = "label8";
      this.label8.RightToLeft = RightToLeft.No;
      this.label8.Size = new Size(180, 20);
      this.label8.TabIndex = 481;
      this.label8.Text = "Current Room List";
      this.roomTableAdapter.ClearBeforeFill = true;
      this.cmd_BldNameUpdate.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.cmd_BldNameUpdate.Cursor = Cursors.Default;
      this.cmd_BldNameUpdate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmd_BldNameUpdate.ForeColor = SystemColors.ControlText;
      this.cmd_BldNameUpdate.Location = new Point(659, 179);
      this.cmd_BldNameUpdate.Name = "cmd_BldNameUpdate";
      this.cmd_BldNameUpdate.RightToLeft = RightToLeft.No;
      this.cmd_BldNameUpdate.Size = new Size(104, 52);
      this.cmd_BldNameUpdate.TabIndex = 482;
      this.cmd_BldNameUpdate.Text = "&Update Building Info";
      this.ToolTip1.SetToolTip((Control) this.cmd_BldNameUpdate, "To Create Room");
      this.cmd_BldNameUpdate.UseVisualStyleBackColor = false;
      this.cmd_BldNameUpdate.Click += new EventHandler(this.cmd_BldNameUpdate_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.ClientSize = new Size(793, 577);
      this.Controls.Add((Control) this.cmd_BldNameUpdate);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.groupBox_RoomToDelete);
      this.Controls.Add((Control) this.groupBox_NewRoomToCreate);
      this.Controls.Add((Control) this.cboBuildingNo);
      this.Controls.Add((Control) this.comboBox_FloorNumber);
      this.Controls.Add((Control) this.dataGridView_Room);
      this.Controls.Add((Control) this.cboBuildingType);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.txtBldName);
      this.Controls.Add((Control) this.lstRoom);
      this.Controls.Add((Control) this.cmdCreate);
      this.Controls.Add((Control) this.cmdDelete);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.lbBuildingNo);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.lbFloorNo);
      this.Controls.Add((Control) this.Label1);
      this.Name = "Form_CreateRoomDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_CreateRoomDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_CreateRoomDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_CreateRoomDMS_FormClosing);
      ((ISupportInitialize) this.roomBindingSource).EndInit();
      this.systemDataSet.EndInit();
      ((ISupportInitialize) this.dataGridView_Room).EndInit();
      ((ISupportInitialize) this.roomBindingSource1).EndInit();
      this.groupBox_NewRoomToCreate.ResumeLayout(false);
      this.groupBox_NewRoomToCreate.PerformLayout();
      this.groupBox_RoomToDelete.ResumeLayout(false);
      this.groupBox_RoomToDelete.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
