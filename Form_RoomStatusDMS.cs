// Decompiled with JetBrains decompiler
// Type: AMS.Form_RoomStatusDMS
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
  public class Form_RoomStatusDMS : Form
  {
    private DB db;
    public BuildingDB1DataSet Browse_RoomStatus_BuildingDB1DataSet;
    public RoomStatusTableAdapter RoomStatusTableAdapter_1;
    public int selected_rowindex;
    public bool OK_Flag;
    public string Selected_Room_No = "";
    private int Old_RoomType_Index;
    private bool Drop_Down_Flag;
    private string old_Room_Status = "";
    private IContainer components;
    public ComboBox cboBuildingNo;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public ComboBox cboRmType;
    public ComboBox cboStatus;
    public TextBox txtStaffID;
    public Button cmdRmStatusBrowser;
    public TextBox txtRoomNo;
    public Button cmdNew;
    public Button cmdAdd;
    public MaskedTextBox mskStartDate;
    public MaskedTextBox mskEndDate;
    public TextBox txtRmType;
    public TextBox txtStatus;
    public Label Label16;
    public GroupBox Frame1;
    public Label Label3;
    public Label Label18;
    public Label Label17;
    public Label Label1;
    public Label Label2;
    public Label Label4;
    private DateTimePicker dateTimePicker_mskEndDate;
    private DateTimePicker dateTimePicker_mskStartDate;

    public Form_RoomStatusDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
      this.Browse_RoomStatus_BuildingDB1DataSet = new BuildingDB1DataSet();
      this.RoomStatusTableAdapter_1 = new RoomStatusTableAdapter();
      this.RoomStatusTableAdapter_1.ClearBeforeFill = true;
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
      this.Clear_Screen();
    }

    private void Form_RoomStatusDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_RoomStatusDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBuildingNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboStatus(this.cboStatus);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmType(this.cboRmType);
    }

    private bool CheckBuilding_N_DisplayBrowser(string para_BuildingNo) => true;

    private void cmdRmStatusBrowser_Click(object sender, EventArgs e)
    {
      if (!this.CheckBuilding_N_DisplayBrowser((string) this.cboBuildingNo.SelectedItem))
        return;
      int num1 = (int) new Form_RmStatusbwr().ShowDialog();
      if (!this.OK_Flag)
        return;
      this.txtRoomNo.Text = this.Selected_Room_No;
      BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus.Rows[this.selected_rowindex];
      if (this.txtRoomNo.Text == row.RoomNo)
      {
        this.txtRmType.Text = this.db.Get_RoomType_Description(row.RoomType);
        this.cboRmType.SelectedItem = (object) this.db.Get_RoomType_Description(row.RoomType);
        this.txtStaffID.Text = row.StaffID;
        this.txtStatus.Text = row.Description;
        this.cboStatus.SelectedItem = (object) row.Description;
        this.old_Room_Status = row.Description;
        this.mskStartDate.Text = row.StartDate.ToShortDateString();
        this.mskEndDate.Text = row.EndDate.ToShortDateString();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Something wrong!");
      }
    }

    private void Clear_Screen()
    {
      this.txtRoomNo.Text = "";
      this.mskStartDate.Text = "";
      this.mskEndDate.Text = "";
      this.txtRmType.Text = "";
      this.txtStaffID.Text = "";
      this.old_Room_Status = "";
    }

    private void cmdNew_Click(object sender, EventArgs e) => this.Clear_Screen();

    private bool Update_Selected_Room_Status()
    {
      bool flag1 = false;
      bool flag2 = false;
      this.RoomStatusTableAdapter_1.Fill(this.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.Browse_RoomStatus_BuildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          row.Description = (string) this.cboStatus.SelectedItem;
          row.Status = this.db.Get_Room_Status_Num((string) this.cboStatus.SelectedItem);
          row.StartDate = DateTime.Parse(this.mskStartDate.Text);
          row.EndDate = DateTime.Parse(this.mskEndDate.Text);
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag2 = true;
          flag1 = true;
          break;
        }
      }
      if (!flag1 || !flag2 || this.RoomStatusTableAdapter_1.Update(this.Browse_RoomStatus_BuildingDB1DataSet) <= 0)
        return false;
      int num = (int) MessageBox.Show("Save Successfully");
      this.old_Room_Status = (string) this.cboStatus.SelectedItem;
      return true;
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      if (this.txtRoomNo.Text.Length >= 5)
      {
        if (this.Update_Selected_Room_Status())
          return;
        this.cboStatus.SelectedItem = (object) this.old_Room_Status;
      }
      else
      {
        int num = (int) MessageBox.Show("Pls. Select Any Room No.!");
        this.cmdRmStatusBrowser.Focus();
        this.cmdRmStatusBrowser.Select();
      }
    }

    private void cboRmType_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void cboRmType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.Drop_Down_Flag)
        return;
      this.cboRmType.SelectedIndex = this.Old_RoomType_Index;
      this.Drop_Down_Flag = false;
    }

    private void cboRmType_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.Old_RoomType_Index = this.cboRmType.Items.IndexOf((object) this.cboRmType.Text);
      this.Drop_Down_Flag = true;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_RoomStatusDMS));
      this.cboBuildingNo = new ComboBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.cboRmType = new ComboBox();
      this.cboStatus = new ComboBox();
      this.txtStaffID = new TextBox();
      this.txtRoomNo = new TextBox();
      this.mskStartDate = new MaskedTextBox();
      this.mskEndDate = new MaskedTextBox();
      this.cmdReturn = new Button();
      this.cmdRmStatusBrowser = new Button();
      this.cmdNew = new Button();
      this.cmdAdd = new Button();
      this.txtRmType = new TextBox();
      this.txtStatus = new TextBox();
      this.Label16 = new Label();
      this.Frame1 = new GroupBox();
      this.dateTimePicker_mskEndDate = new DateTimePicker();
      this.dateTimePicker_mskStartDate = new DateTimePicker();
      this.Label3 = new Label();
      this.Label18 = new Label();
      this.Label17 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this.cboBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(192, 24);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 26);
      this.cboBuildingNo.TabIndex = 19;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building");
      this.cboRmType.BackColor = SystemColors.Window;
      this.cboRmType.Cursor = Cursors.Default;
      this.cboRmType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboRmType.ForeColor = SystemColors.WindowText;
      this.cboRmType.Location = new Point(264, 64);
      this.cboRmType.Name = "cboRmType";
      this.cboRmType.RightToLeft = RightToLeft.No;
      this.cboRmType.Size = new Size(81, 22);
      this.cboRmType.TabIndex = 15;
      this.ToolTip1.SetToolTip((Control) this.cboRmType, "Choose Room Type");
      this.cboRmType.SelectionChangeCommitted += new EventHandler(this.cboRmType_SelectionChangeCommitted);
      this.cboRmType.SelectedIndexChanged += new EventHandler(this.cboRmType_SelectedIndexChanged);
      this.cboRmType.KeyPress += new KeyPressEventHandler(this.cboRmType_KeyPress);
      this.cboStatus.BackColor = SystemColors.Window;
      this.cboStatus.Cursor = Cursors.Default;
      this.cboStatus.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboStatus.ForeColor = SystemColors.WindowText;
      this.cboStatus.Location = new Point(192, 104);
      this.cboStatus.Name = "cboStatus";
      this.cboStatus.RightToLeft = RightToLeft.No;
      this.cboStatus.Size = new Size(105, 22);
      this.cboStatus.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.cboStatus, "Room Status");
      this.txtStaffID.AcceptsReturn = true;
      this.txtStaffID.BackColor = SystemColors.Window;
      this.txtStaffID.Cursor = Cursors.IBeam;
      this.txtStaffID.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtStaffID.ForeColor = SystemColors.WindowText;
      this.txtStaffID.Location = new Point(192, 208);
      this.txtStaffID.MaxLength = 10;
      this.txtStaffID.Name = "txtStaffID";
      this.txtStaffID.RightToLeft = RightToLeft.No;
      this.txtStaffID.Size = new Size(113, 20);
      this.txtStaffID.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.txtStaffID, "Staff ID");
      this.txtStaffID.Visible = false;
      this.txtRoomNo.AcceptsReturn = true;
      this.txtRoomNo.BackColor = SystemColors.Window;
      this.txtRoomNo.Cursor = Cursors.IBeam;
      this.txtRoomNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.ForeColor = SystemColors.WindowText;
      this.txtRoomNo.Location = new Point(192, 64);
      this.txtRoomNo.MaxLength = 0;
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.ReadOnly = true;
      this.txtRoomNo.RightToLeft = RightToLeft.No;
      this.txtRoomNo.Size = new Size(41, 20);
      this.txtRoomNo.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.txtRoomNo, "Room No.");
      this.mskStartDate.AllowPromptAsInput = false;
      this.mskStartDate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskStartDate.ForeColor = Color.Blue;
      this.mskStartDate.Location = new Point(192, 136);
      this.mskStartDate.Mask = "####-##-##";
      this.mskStartDate.Name = "mskStartDate";
      this.mskStartDate.Size = new Size(73, 20);
      this.mskStartDate.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.mskStartDate, "Enter Start Date");
      this.mskEndDate.AllowPromptAsInput = false;
      this.mskEndDate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskEndDate.ForeColor = Color.Blue;
      this.mskEndDate.Location = new Point(192, 176);
      this.mskEndDate.Mask = "####-##-##";
      this.mskEndDate.Name = "mskEndDate";
      this.mskEndDate.Size = new Size(73, 20);
      this.mskEndDate.TabIndex = 3;
      this.ToolTip1.SetToolTip((Control) this.mskEndDate, "Enter End Date");
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(264, 232);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(97, 47);
      this.cmdReturn.TabIndex = 17;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to System Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdRmStatusBrowser.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.cmdRmStatusBrowser.Cursor = Cursors.Default;
      this.cmdRmStatusBrowser.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdRmStatusBrowser.ForeColor = SystemColors.ControlText;
      this.cmdRmStatusBrowser.Image = (Image) componentResourceManager.GetObject("cmdRmStatusBrowser.Image");
      this.cmdRmStatusBrowser.Location = new Point(233, 61);
      this.cmdRmStatusBrowser.Name = "cmdRmStatusBrowser";
      this.cmdRmStatusBrowser.RightToLeft = RightToLeft.No;
      this.cmdRmStatusBrowser.Size = new Size(25, 25);
      this.cmdRmStatusBrowser.TabIndex = 8;
      this.cmdRmStatusBrowser.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdRmStatusBrowser, "To View Room Status");
      this.cmdRmStatusBrowser.UseVisualStyleBackColor = false;
      this.cmdRmStatusBrowser.Click += new EventHandler(this.cmdRmStatusBrowser_Click);
      this.cmdNew.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cmdNew.Cursor = Cursors.Default;
      this.cmdNew.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNew.ForeColor = SystemColors.ControlText;
      this.cmdNew.Image = (Image) componentResourceManager.GetObject("cmdNew.Image");
      this.cmdNew.Location = new Point(168, 232);
      this.cmdNew.Name = "cmdNew";
      this.cmdNew.RightToLeft = RightToLeft.No;
      this.cmdNew.Size = new Size(97, 47);
      this.cmdNew.TabIndex = 6;
      this.cmdNew.Text = "&Clear";
      this.cmdNew.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdNew, "To Clear Screen");
      this.cmdNew.UseVisualStyleBackColor = false;
      this.cmdNew.Click += new EventHandler(this.cmdNew_Click);
      this.cmdAdd.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdAdd.Cursor = Cursors.Default;
      this.cmdAdd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdAdd.ForeColor = SystemColors.ControlText;
      this.cmdAdd.Image = (Image) componentResourceManager.GetObject("cmdAdd.Image");
      this.cmdAdd.Location = new Point(72, 232);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.RightToLeft = RightToLeft.No;
      this.cmdAdd.Size = new Size(97, 47);
      this.cmdAdd.TabIndex = 5;
      this.cmdAdd.Text = "&Save";
      this.cmdAdd.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdAdd, "To Confirm Room Status ");
      this.cmdAdd.UseVisualStyleBackColor = false;
      this.cmdAdd.Click += new EventHandler(this.cmdAdd_Click);
      this.txtRmType.AcceptsReturn = true;
      this.txtRmType.BackColor = SystemColors.Window;
      this.txtRmType.Cursor = Cursors.IBeam;
      this.txtRmType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRmType.ForeColor = SystemColors.WindowText;
      this.txtRmType.Location = new Point(344, 64);
      this.txtRmType.MaxLength = 0;
      this.txtRmType.Name = "txtRmType";
      this.txtRmType.RightToLeft = RightToLeft.No;
      this.txtRmType.Size = new Size(25, 20);
      this.txtRmType.TabIndex = 16;
      this.txtRmType.TextAlign = HorizontalAlignment.Center;
      this.txtRmType.Visible = false;
      this.txtStatus.AcceptsReturn = true;
      this.txtStatus.BackColor = SystemColors.Window;
      this.txtStatus.Cursor = Cursors.IBeam;
      this.txtStatus.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtStatus.ForeColor = SystemColors.WindowText;
      this.txtStatus.Location = new Point(296, 104);
      this.txtStatus.MaxLength = 30;
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.RightToLeft = RightToLeft.No;
      this.txtStatus.Size = new Size(25, 20);
      this.txtStatus.TabIndex = 9;
      this.txtStatus.Visible = false;
      this.Label16.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Red;
      this.Label16.Location = new Point(88, 24);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(89, 25);
      this.Label16.TabIndex = 20;
      this.Label16.Text = "Building ";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Frame1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Frame1.Controls.Add((Control) this.dateTimePicker_mskEndDate);
      this.Frame1.Controls.Add((Control) this.cboBuildingNo);
      this.Frame1.Controls.Add((Control) this.dateTimePicker_mskStartDate);
      this.Frame1.Controls.Add((Control) this.cmdReturn);
      this.Frame1.Controls.Add((Control) this.txtRmType);
      this.Frame1.Controls.Add((Control) this.cboRmType);
      this.Frame1.Controls.Add((Control) this.cboStatus);
      this.Frame1.Controls.Add((Control) this.txtStaffID);
      this.Frame1.Controls.Add((Control) this.txtStatus);
      this.Frame1.Controls.Add((Control) this.cmdRmStatusBrowser);
      this.Frame1.Controls.Add((Control) this.txtRoomNo);
      this.Frame1.Controls.Add((Control) this.cmdNew);
      this.Frame1.Controls.Add((Control) this.cmdAdd);
      this.Frame1.Controls.Add((Control) this.mskStartDate);
      this.Frame1.Controls.Add((Control) this.mskEndDate);
      this.Frame1.Controls.Add((Control) this.Label16);
      this.Frame1.Controls.Add((Control) this.Label3);
      this.Frame1.Controls.Add((Control) this.Label18);
      this.Frame1.Controls.Add((Control) this.Label17);
      this.Frame1.Controls.Add((Control) this.Label1);
      this.Frame1.Controls.Add((Control) this.Label2);
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = Color.Blue;
      this.Frame1.Location = new Point(182, 129);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(433, 305);
      this.Frame1.TabIndex = 19;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "ROOM STATUS :";
      this.dateTimePicker_mskEndDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskEndDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskEndDate.Location = new Point(296, 169);
      this.dateTimePicker_mskEndDate.Name = "dateTimePicker_mskEndDate";
      this.dateTimePicker_mskEndDate.Size = new Size(98, 22);
      this.dateTimePicker_mskEndDate.TabIndex = 169;
      this.dateTimePicker_mskEndDate.Visible = false;
      this.dateTimePicker_mskStartDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskStartDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskStartDate.Location = new Point(296, 136);
      this.dateTimePicker_mskStartDate.Name = "dateTimePicker_mskStartDate";
      this.dateTimePicker_mskStartDate.Size = new Size(98, 22);
      this.dateTimePicker_mskStartDate.TabIndex = 168;
      this.dateTimePicker_mskStartDate.Visible = false;
      this.Label3.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(88, 208);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(81, 17);
      this.Label3.TabIndex = 14;
      this.Label3.Text = "Staff ID ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label3.Visible = false;
      this.Label18.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(88, 176);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(81, 17);
      this.Label18.TabIndex = 13;
      this.Label18.Text = "End Date";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(96, 136);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 12;
      this.Label17.Text = "Start Date  ";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ControlText;
      this.Label1.Location = new Point(80, 64);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(97, 25);
      this.Label1.TabIndex = 11;
      this.Label1.Text = "Room No. ";
      this.Label1.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(104, 104);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(65, 25);
      this.Label2.TabIndex = 10;
      this.Label2.Text = "Status ";
      this.Label2.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 26.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Red;
      this.Label4.Location = new Point(-2, 9);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(785, 49);
      this.Label4.TabIndex = 20;
      this.Label4.Text = "Accommodation Management System ";
      this.Label4.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(790, 582);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Label4);
      this.Name = "Form_RoomStatusDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_RoomStatusDMS_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form_RoomStatusDMS_FormClosing);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
