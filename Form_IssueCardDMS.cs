// Decompiled with JetBrains decompiler
// Type: AMS.Form_IssueCardDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static AMS.Form_IssueGuestCardDMS;

#nullable disable
namespace AMS
{
  public class Form_IssueCardDMS : Form
  {
    private IContainer components;
    public MaskedTextBox mskCheckOutTime;
    public ToolTip ToolTip1;
    public Button cmdViewClient;
    public TextBox txtClientID;
    public MaskedTextBox mskCheckInTime;
    public ComboBox cboSex;
    public TextBox txtRemark;
    public ComboBox cboCountry;
    public TextBox txtContact;
    public TextBox txtAddress;
    public TextBox txtNationality;
    public TextBox txtIdentity;
    public TextBox txtSurName;
    public TextBox txtFirstName;
    public Button cmdLoss;
    public TextBox txtCardNo;
    public ComboBox cboCardType;
    public Button cmdClear;
    public ComboBox cboBuilding;
    public Button cmdReturn;
    public Button cmdIssue;
    public ComboBox cboZoneNo;
    public ComboBox cboOfficeRoom;
    public ComboBox cboRoomType;
    public TextBox txtNoOfDays;
    public Label lbInTime;
    public Label lbOutTime;
    public RadioButton _optUser_1;
    public Label Label27;
    public Label Label11;
    public GroupBox ClientIDFrame;
    public RadioButton _optUser_0;
    public Label Label3;
    public ComboBox cboFloorNo;
    public Label Label14;
    public Label lbBuilding;
    public Label lbFloor;
    public GroupBox IssueCardFrame;
    public TextBox txtCountry;
    public Label Label10;
    public Label Label9;
    public Label Label8;
    public Label _Label7_0;
    public Label Label6;
    public Label lbNodays;
    public Label lbValidEnd;
    public Label Label24;
    public Label Label4;
    public Label Label5;
    public Label Label28;
    public Label lblMsgFunction2;
    public Label lbMsgFunction;
    public Label Label1;
    public Label lblMessage;
    public Label lbIssueCardHeader;
    public GroupBox FloorFrame;
    public ComboBox cboRoomNo;
    public Label Label2;
    public GroupBox ZoneFrame;
    public Label lbZoneNo;
    public GroupBox RoomTypeFrame;
    public GroupBox RoomFrame;
    public GroupBox Frame1;
    public System.Windows.Forms.Timer Timer1;
    public GroupBox Frame2;
    private Panel panel_CommStatus;
    public PictureBox pictureBox_COMM_Color;
    private Label label_CommState;
    public GroupBox groupBox_Setting_DateTime;
    private Label label_SettingDateTime;
    public TextBox txtRoomType;
    public Label Label13;
    public Label Label15;
    private GroupBox GroupBox_DoorTypeChoice;
    private RadioButton radio_FloorSet;
    private RadioButton radio_BuildingSet;
    private RadioButton radio_RoomSet;
    private DateTimePicker dateTimePicker_ValidEnd;
    private DateTimePicker dateTimePicker_SettingDate;
    private DateTimePicker dateTimePicker_ValidStart;
    public MaskedTextBox mskSettingTime;
    public ComboBox cboRoomType_Others;
    private DB db;
    private string Old_Date_Time = DateTime.Now.ToLongTimeString();
    public string Old_Client_ID = "";
    public bool Old_Client_OK_flag;
    private bool _1stTime_Flag;
    private bool Init_Flag;
    private DateTime Old_Valid_Start_Date = DateTime.Now;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private Button button2;
        public Button button3;
        private Button button4;
        private TextBox buildingValue;
        private Label label12;
        private Button button5;
        private TextBox txtFloorBuildingValue;
        private Label label16;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private DateTime Old_Valid_End_Date = DateTime.Now;
        int buildingNumber = 1;
        public int[] floorRoomCounts;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private CheckBox checkBoxSingleCard;
        public RoomRange[] floorRoomRanges;
        public class RoomRange
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
        protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.mskCheckOutTime = new System.Windows.Forms.MaskedTextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdViewClient = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.mskCheckInTime = new System.Windows.Forms.MaskedTextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmdLoss = new System.Windows.Forms.Button();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cboBuilding = new System.Windows.Forms.ComboBox();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdIssue = new System.Windows.Forms.Button();
            this.cboZoneNo = new System.Windows.Forms.ComboBox();
            this.cboOfficeRoom = new System.Windows.Forms.ComboBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.mskSettingTime = new System.Windows.Forms.MaskedTextBox();
            this.cboRoomType_Others = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.lbInTime = new System.Windows.Forms.Label();
            this.lbOutTime = new System.Windows.Forms.Label();
            this._optUser_1 = new System.Windows.Forms.RadioButton();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.ClientIDFrame = new System.Windows.Forms.GroupBox();
            this._optUser_0 = new System.Windows.Forms.RadioButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboFloorNo = new System.Windows.Forms.ComboBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.lbBuilding = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.IssueCardFrame = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker_ValidStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ValidEnd = new System.Windows.Forms.DateTimePicker();
            this.GroupBox_DoorTypeChoice = new System.Windows.Forms.GroupBox();
            this.radio_FloorSet = new System.Windows.Forms.RadioButton();
            this.radio_BuildingSet = new System.Windows.Forms.RadioButton();
            this.radio_RoomSet = new System.Windows.Forms.RadioButton();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this._Label7_0 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lbNodays = new System.Windows.Forms.Label();
            this.lbValidEnd = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.groupBox_Setting_DateTime = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker_SettingDate = new System.Windows.Forms.DateTimePicker();
            this.label_SettingDateTime = new System.Windows.Forms.Label();
            this.lblMsgFunction2 = new System.Windows.Forms.Label();
            this.lbMsgFunction = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lbIssueCardHeader = new System.Windows.Forms.Label();
            this.FloorFrame = new System.Windows.Forms.GroupBox();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ZoneFrame = new System.Windows.Forms.GroupBox();
            this.lbZoneNo = new System.Windows.Forms.Label();
            this.RoomTypeFrame = new System.Windows.Forms.GroupBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.RoomFrame = new System.Windows.Forms.GroupBox();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtFloorBuildingValue = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buildingValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxSingleCard = new System.Windows.Forms.CheckBox();
            this.ClientIDFrame.SuspendLayout();
            this.IssueCardFrame.SuspendLayout();
            this.GroupBox_DoorTypeChoice.SuspendLayout();
            this.groupBox_Setting_DateTime.SuspendLayout();
            this.FloorFrame.SuspendLayout();
            this.ZoneFrame.SuspendLayout();
            this.RoomTypeFrame.SuspendLayout();
            this.RoomFrame.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCheckOutTime
            // 
            this.mskCheckOutTime.AllowPromptAsInput = false;
            this.mskCheckOutTime.Enabled = false;
            this.mskCheckOutTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCheckOutTime.ForeColor = System.Drawing.Color.Blue;
            this.mskCheckOutTime.Location = new System.Drawing.Point(332, 199);
            this.mskCheckOutTime.Mask = "##:##:##";
            this.mskCheckOutTime.Name = "mskCheckOutTime";
            this.mskCheckOutTime.Size = new System.Drawing.Size(81, 20);
            this.mskCheckOutTime.TabIndex = 30;
            // 
            // cmdViewClient
            // 
            this.cmdViewClient.BackColor = System.Drawing.Color.Gray;
            this.cmdViewClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdViewClient.Enabled = false;
            this.cmdViewClient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdViewClient.Location = new System.Drawing.Point(350, 10);
            this.cmdViewClient.Name = "cmdViewClient";
            this.cmdViewClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdViewClient.Size = new System.Drawing.Size(79, 32);
            this.cmdViewClient.TabIndex = 5;
            this.cmdViewClient.Text = "Select User";
            this.ToolTip1.SetToolTip(this.cmdViewClient, "Click to View/Select Client");
            this.cmdViewClient.UseVisualStyleBackColor = false;
            this.cmdViewClient.Click += new System.EventHandler(this.cmdViewClient_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.AcceptsReturn = true;
            this.txtClientID.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClientID.Location = new System.Drawing.Point(255, 17);
            this.txtClientID.MaxLength = 8;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientID.Size = new System.Drawing.Size(89, 20);
            this.txtClientID.TabIndex = 4;
            this.ToolTip1.SetToolTip(this.txtClientID, "Guest ID");
            // 
            // mskCheckInTime
            // 
            this.mskCheckInTime.AllowPromptAsInput = false;
            this.mskCheckInTime.Enabled = false;
            this.mskCheckInTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCheckInTime.ForeColor = System.Drawing.Color.Blue;
            this.mskCheckInTime.Location = new System.Drawing.Point(332, 145);
            this.mskCheckInTime.Mask = "##:##:##";
            this.mskCheckInTime.Name = "mskCheckInTime";
            this.mskCheckInTime.Size = new System.Drawing.Size(122, 20);
            this.mskCheckInTime.TabIndex = 20;
            this.ToolTip1.SetToolTip(this.mskCheckInTime, "Valid Start Time");
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.SystemColors.Window;
            this.cboSex.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboSex.Location = new System.Drawing.Point(104, 92);
            this.cboSex.Name = "cboSex";
            this.cboSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSex.Size = new System.Drawing.Size(49, 22);
            this.cboSex.TabIndex = 11;
            this.ToolTip1.SetToolTip(this.cboSex, "Select Sex.");
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemark.Location = new System.Drawing.Point(237, 281);
            this.txtRemark.MaxLength = 40;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemark.Size = new System.Drawing.Size(193, 37);
            this.txtRemark.TabIndex = 24;
            this.ToolTip1.SetToolTip(this.txtRemark, "Key-In Remark If Needed.");
            this.txtRemark.Visible = false;
            // 
            // cboCountry
            // 
            this.cboCountry.BackColor = System.Drawing.SystemColors.Window;
            this.cboCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboCountry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCountry.Location = new System.Drawing.Point(104, 311);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCountry.Size = new System.Drawing.Size(97, 22);
            this.cboCountry.TabIndex = 23;
            this.ToolTip1.SetToolTip(this.cboCountry, "Select Country");
            this.cboCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCountry_KeyPress);
            // 
            // txtContact
            // 
            this.txtContact.AcceptsReturn = true;
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContact.Location = new System.Drawing.Point(104, 220);
            this.txtContact.MaxLength = 20;
            this.txtContact.Name = "txtContact";
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContact.Size = new System.Drawing.Size(97, 20);
            this.txtContact.TabIndex = 16;
            this.ToolTip1.SetToolTip(this.txtContact, "Enter Contact No.");
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(104, 253);
            this.txtAddress.MaxLength = 40;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(97, 17);
            this.txtAddress.TabIndex = 17;
            this.ToolTip1.SetToolTip(this.txtAddress, "Enter Address");
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtNationality
            // 
            this.txtNationality.AcceptsReturn = true;
            this.txtNationality.BackColor = System.Drawing.SystemColors.Window;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNationality.Location = new System.Drawing.Point(104, 280);
            this.txtNationality.MaxLength = 20;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationality.Size = new System.Drawing.Size(97, 20);
            this.txtNationality.TabIndex = 22;
            this.ToolTip1.SetToolTip(this.txtNationality, "Nationality");
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationality_KeyPress);
            // 
            // txtIdentity
            // 
            this.txtIdentity.AcceptsReturn = true;
            this.txtIdentity.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdentity.Location = new System.Drawing.Point(104, 188);
            this.txtIdentity.MaxLength = 20;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentity.Size = new System.Drawing.Size(97, 20);
            this.txtIdentity.TabIndex = 15;
            this.ToolTip1.SetToolTip(this.txtIdentity, "Enter Passport No.");
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_KeyPress);
            // 
            // txtSurName
            // 
            this.txtSurName.AcceptsReturn = true;
            this.txtSurName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSurName.Location = new System.Drawing.Point(104, 156);
            this.txtSurName.MaxLength = 20;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurName.Size = new System.Drawing.Size(97, 20);
            this.txtSurName.TabIndex = 14;
            this.ToolTip1.SetToolTip(this.txtSurName, "Enter SurName");
            this.txtSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = true;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(104, 124);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(97, 20);
            this.txtFirstName.TabIndex = 13;
            this.ToolTip1.SetToolTip(this.txtFirstName, "Enter First Name.");
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // cmdLoss
            // 
            this.cmdLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdLoss.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLoss.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLoss.Location = new System.Drawing.Point(227, 298);
            this.cmdLoss.Name = "cmdLoss";
            this.cmdLoss.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLoss.Size = new System.Drawing.Size(89, 33);
            this.cmdLoss.TabIndex = 10;
            this.cmdLoss.Text = "LOSS";
            this.ToolTip1.SetToolTip(this.cmdLoss, "To Inform Loss Card");
            this.cmdLoss.UseVisualStyleBackColor = false;
            this.cmdLoss.Visible = false;
            // 
            // txtCardNo
            // 
            this.txtCardNo.AcceptsReturn = true;
            this.txtCardNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.ForeColor = System.Drawing.Color.Red;
            this.txtCardNo.Location = new System.Drawing.Point(400, 86);
            this.txtCardNo.MaxLength = 0;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCardNo.Size = new System.Drawing.Size(54, 20);
            this.txtCardNo.TabIndex = 9;
            this.ToolTip1.SetToolTip(this.txtCardNo, "Card Number");
            // 
            // cboCardType
            // 
            this.cboCardType.BackColor = System.Drawing.SystemColors.Window;
            this.cboCardType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboCardType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCardType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCardType.Location = new System.Drawing.Point(71, 22);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCardType.Size = new System.Drawing.Size(154, 24);
            this.cboCardType.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.cboCardType, "Select Card Type.");
            this.cboCardType.SelectedIndexChanged += new System.EventHandler(this.cboCardType_SelectedIndexChanged);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Cyan;
            this.cmdClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClear.Location = new System.Drawing.Point(290, 16);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClear.Size = new System.Drawing.Size(113, 32);
            this.cmdClear.TabIndex = 26;
            this.cmdClear.Text = "Clear Data";
            this.ToolTip1.SetToolTip(this.cmdClear, "To Clear Screen Data");
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cboBuilding
            // 
            this.cboBuilding.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuilding.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBuilding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuilding.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBuilding.Location = new System.Drawing.Point(282, 23);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboBuilding.Size = new System.Drawing.Size(49, 22);
            this.cboBuilding.TabIndex = 45;
            this.ToolTip1.SetToolTip(this.cboBuilding, "Select Building");
            this.cboBuilding.SelectedIndexChanged += new System.EventHandler(this.cboBuilding_SelectedIndexChanged);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(643, 16);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(113, 32);
            this.cmdReturn.TabIndex = 27;
            this.cmdReturn.Text = "← Return";
            this.ToolTip1.SetToolTip(this.cmdReturn, "Return to Admin Screen");
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdIssue
            // 
            this.cmdIssue.BackColor = System.Drawing.Color.Yellow;
            this.cmdIssue.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdIssue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIssue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIssue.Location = new System.Drawing.Point(158, 16);
            this.cmdIssue.Name = "cmdIssue";
            this.cmdIssue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdIssue.Size = new System.Drawing.Size(113, 32);
            this.cmdIssue.TabIndex = 25;
            this.cmdIssue.Text = "ISSUE CARD";
            this.ToolTip1.SetToolTip(this.cmdIssue, "Comfirm to issue card.");
            this.cmdIssue.UseVisualStyleBackColor = false;
            this.cmdIssue.Click += new System.EventHandler(this.cmdIssue_Click);
            // 
            // cboZoneNo
            // 
            this.cboZoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboZoneNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboZoneNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZoneNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboZoneNo.Location = new System.Drawing.Point(88, 16);
            this.cboZoneNo.Name = "cboZoneNo";
            this.cboZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboZoneNo.Size = new System.Drawing.Size(41, 22);
            this.cboZoneNo.TabIndex = 67;
            this.ToolTip1.SetToolTip(this.cboZoneNo, "Select Zone No.");
            // 
            // cboOfficeRoom
            // 
            this.cboOfficeRoom.BackColor = System.Drawing.SystemColors.Window;
            this.cboOfficeRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboOfficeRoom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOfficeRoom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboOfficeRoom.Location = new System.Drawing.Point(302, 296);
            this.cboOfficeRoom.Name = "cboOfficeRoom";
            this.cboOfficeRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboOfficeRoom.Size = new System.Drawing.Size(65, 22);
            this.cboOfficeRoom.TabIndex = 8;
            this.ToolTip1.SetToolTip(this.cboOfficeRoom, "Select Room No.");
            this.cboOfficeRoom.Visible = false;
            // 
            // cboRoomType
            // 
            this.cboRoomType.BackColor = System.Drawing.SystemColors.Window;
            this.cboRoomType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRoomType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRoomType.Location = new System.Drawing.Point(19, 16);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomType.Size = new System.Drawing.Size(89, 22);
            this.cboRoomType.TabIndex = 6;
            this.ToolTip1.SetToolTip(this.cboRoomType, "Select Room Type.");
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // mskSettingTime
            // 
            this.mskSettingTime.AllowPromptAsInput = false;
            this.mskSettingTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSettingTime.ForeColor = System.Drawing.Color.Blue;
            this.mskSettingTime.Location = new System.Drawing.Point(21, 85);
            this.mskSettingTime.Mask = "##:##:##";
            this.mskSettingTime.Name = "mskSettingTime";
            this.mskSettingTime.Size = new System.Drawing.Size(89, 26);
            this.mskSettingTime.TabIndex = 21;
            this.ToolTip1.SetToolTip(this.mskSettingTime, "Valid End Time");
            this.mskSettingTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSettingTime_MaskInputRejected);
            // 
            // cboRoomType_Others
            // 
            this.cboRoomType_Others.BackColor = System.Drawing.SystemColors.Window;
            this.cboRoomType_Others.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRoomType_Others.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType_Others.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRoomType_Others.Location = new System.Drawing.Point(23, 14);
            this.cboRoomType_Others.Name = "cboRoomType_Others";
            this.cboRoomType_Others.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomType_Others.Size = new System.Drawing.Size(89, 22);
            this.cboRoomType_Others.TabIndex = 175;
            this.ToolTip1.SetToolTip(this.cboRoomType_Others, "Select Room Type.");
            this.cboRoomType_Others.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_Others_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(13, 16);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(127, 32);
            this.button3.TabIndex = 176;
            this.button3.Text = "♲ Recycle Card";
            this.ToolTip1.SetToolTip(this.button3, "Clear Screen Data");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.AcceptsReturn = true;
            this.txtNoOfDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoOfDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfDays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfDays.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoOfDays.Location = new System.Drawing.Point(289, 86);
            this.txtNoOfDays.MaxLength = 3;
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.ReadOnly = true;
            this.txtNoOfDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoOfDays.Size = new System.Drawing.Size(41, 20);
            this.txtNoOfDays.TabIndex = 12;
            this.txtNoOfDays.Text = "1";
            // 
            // lbInTime
            // 
            this.lbInTime.BackColor = System.Drawing.Color.Gainsboro;
            this.lbInTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbInTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInTime.Location = new System.Drawing.Point(219, 148);
            this.lbInTime.Name = "lbInTime";
            this.lbInTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInTime.Size = new System.Drawing.Size(97, 17);
            this.lbInTime.TabIndex = 49;
            this.lbInTime.Text = "Valid StartTime";
            this.lbInTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbOutTime
            // 
            this.lbOutTime.BackColor = System.Drawing.Color.Gainsboro;
            this.lbOutTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOutTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOutTime.Location = new System.Drawing.Point(219, 202);
            this.lbOutTime.Name = "lbOutTime";
            this.lbOutTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOutTime.Size = new System.Drawing.Size(97, 17);
            this.lbOutTime.TabIndex = 47;
            this.lbOutTime.Text = "Valid End Time";
            this.lbOutTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _optUser_1
            // 
            this._optUser_1.BackColor = System.Drawing.Color.DarkGray;
            this._optUser_1.Checked = true;
            this._optUser_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUser_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUser_1.ForeColor = System.Drawing.Color.Black;
            this._optUser_1.Location = new System.Drawing.Point(112, 16);
            this._optUser_1.Name = "_optUser_1";
            this._optUser_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUser_1.Size = new System.Drawing.Size(81, 25);
            this._optUser_1.TabIndex = 3;
            this._optUser_1.TabStop = true;
            this._optUser_1.Text = "Old User";
            this._optUser_1.UseVisualStyleBackColor = false;
            this._optUser_1.CheckedChanged += new System.EventHandler(this._optUser_1_CheckedChanged);
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.Gainsboro;
            this.Label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.Red;
            this.Label27.Location = new System.Drawing.Point(275, 278);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(41, 17);
            this.Label27.TabIndex = 43;
            this.Label27.Text = "Note: ";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label27.Visible = false;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Gainsboro;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(16, 314);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(73, 17);
            this.Label11.TabIndex = 41;
            this.Label11.Text = "Country";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClientIDFrame
            // 
            this.ClientIDFrame.BackColor = System.Drawing.Color.DarkGray;
            this.ClientIDFrame.Controls.Add(this.cmdViewClient);
            this.ClientIDFrame.Controls.Add(this.txtClientID);
            this.ClientIDFrame.Controls.Add(this._optUser_1);
            this.ClientIDFrame.Controls.Add(this._optUser_0);
            this.ClientIDFrame.Controls.Add(this.Label3);
            this.ClientIDFrame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIDFrame.ForeColor = System.Drawing.Color.IndianRed;
            this.ClientIDFrame.Location = new System.Drawing.Point(8, 16);
            this.ClientIDFrame.Name = "ClientIDFrame";
            this.ClientIDFrame.Padding = new System.Windows.Forms.Padding(0);
            this.ClientIDFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClientIDFrame.Size = new System.Drawing.Size(449, 47);
            this.ClientIDFrame.TabIndex = 58;
            this.ClientIDFrame.TabStop = false;
            this.ClientIDFrame.Text = "SELECT a User Type";
            // 
            // _optUser_0
            // 
            this._optUser_0.BackColor = System.Drawing.Color.DarkGray;
            this._optUser_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUser_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUser_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optUser_0.Location = new System.Drawing.Point(16, 16);
            this._optUser_0.Name = "_optUser_0";
            this._optUser_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUser_0.Size = new System.Drawing.Size(81, 25);
            this._optUser_0.TabIndex = 2;
            this._optUser_0.Text = "New User";
            this._optUser_0.UseVisualStyleBackColor = false;
            this._optUser_0.CheckedChanged += new System.EventHandler(this._optUser_0_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.DarkGray;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(199, 19);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 59;
            this.Label3.Text = "Client ID";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboFloorNo
            // 
            this.cboFloorNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboFloorNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboFloorNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboFloorNo.Location = new System.Drawing.Point(47, 17);
            this.cboFloorNo.Name = "cboFloorNo";
            this.cboFloorNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboFloorNo.Size = new System.Drawing.Size(55, 22);
            this.cboFloorNo.TabIndex = 51;
            this.cboFloorNo.SelectedIndexChanged += new System.EventHandler(this.cboFloorNo_SelectedIndexChanged);
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Gainsboro;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(3, 25);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(65, 17);
            this.Label14.TabIndex = 48;
            this.Label14.Text = "Card Type";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBuilding
            // 
            this.lbBuilding.BackColor = System.Drawing.Color.Gainsboro;
            this.lbBuilding.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbBuilding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuilding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBuilding.Location = new System.Drawing.Point(221, 26);
            this.lbBuilding.Name = "lbBuilding";
            this.lbBuilding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBuilding.Size = new System.Drawing.Size(73, 17);
            this.lbBuilding.TabIndex = 46;
            this.lbBuilding.Text = "Building";
            this.lbBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.BackColor = System.Drawing.Color.Gainsboro;
            this.lbFloor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFloor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFloor.Location = new System.Drawing.Point(2, 21);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFloor.Size = new System.Drawing.Size(47, 19);
            this.lbFloor.TabIndex = 52;
            this.lbFloor.Text = "Level No.";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IssueCardFrame
            // 
            this.IssueCardFrame.BackColor = System.Drawing.Color.Gainsboro;
            this.IssueCardFrame.Controls.Add(this.label20);
            this.IssueCardFrame.Controls.Add(this.dateTimePicker_ValidStart);
            this.IssueCardFrame.Controls.Add(this.dateTimePicker_ValidEnd);
            this.IssueCardFrame.Controls.Add(this.GroupBox_DoorTypeChoice);
            this.IssueCardFrame.Controls.Add(this.txtCountry);
            this.IssueCardFrame.Controls.Add(this.ClientIDFrame);
            this.IssueCardFrame.Controls.Add(this.mskCheckOutTime);
            this.IssueCardFrame.Controls.Add(this.cboOfficeRoom);
            this.IssueCardFrame.Controls.Add(this.mskCheckInTime);
            this.IssueCardFrame.Controls.Add(this.cboSex);
            this.IssueCardFrame.Controls.Add(this.cboCountry);
            this.IssueCardFrame.Controls.Add(this.txtContact);
            this.IssueCardFrame.Controls.Add(this.txtAddress);
            this.IssueCardFrame.Controls.Add(this.txtNationality);
            this.IssueCardFrame.Controls.Add(this.txtIdentity);
            this.IssueCardFrame.Controls.Add(this.txtNoOfDays);
            this.IssueCardFrame.Controls.Add(this.txtSurName);
            this.IssueCardFrame.Controls.Add(this.txtFirstName);
            this.IssueCardFrame.Controls.Add(this.cmdLoss);
            this.IssueCardFrame.Controls.Add(this.txtCardNo);
            this.IssueCardFrame.Controls.Add(this.lbInTime);
            this.IssueCardFrame.Controls.Add(this.lbOutTime);
            this.IssueCardFrame.Controls.Add(this.Label11);
            this.IssueCardFrame.Controls.Add(this.Label10);
            this.IssueCardFrame.Controls.Add(this.Label9);
            this.IssueCardFrame.Controls.Add(this.Label8);
            this.IssueCardFrame.Controls.Add(this._Label7_0);
            this.IssueCardFrame.Controls.Add(this.Label6);
            this.IssueCardFrame.Controls.Add(this.lbNodays);
            this.IssueCardFrame.Controls.Add(this.lbValidEnd);
            this.IssueCardFrame.Controls.Add(this.Label24);
            this.IssueCardFrame.Controls.Add(this.Label4);
            this.IssueCardFrame.Controls.Add(this.Label5);
            this.IssueCardFrame.Controls.Add(this.Label28);
            this.IssueCardFrame.Controls.Add(this.txtRemark);
            this.IssueCardFrame.Controls.Add(this.Label27);
            this.IssueCardFrame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueCardFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IssueCardFrame.Location = new System.Drawing.Point(12, 145);
            this.IssueCardFrame.Name = "IssueCardFrame";
            this.IssueCardFrame.Padding = new System.Windows.Forms.Padding(0);
            this.IssueCardFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IssueCardFrame.Size = new System.Drawing.Size(613, 361);
            this.IssueCardFrame.TabIndex = 67;
            this.IssueCardFrame.TabStop = false;
            this.IssueCardFrame.Text = "ISSUE CARD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 16);
            this.label20.TabIndex = 216;
            this.label20.Text = "New User Details";
            // 
            // dateTimePicker_ValidStart
            // 
            this.dateTimePicker_ValidStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ValidStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ValidStart.Location = new System.Drawing.Point(332, 116);
            this.dateTimePicker_ValidStart.Name = "dateTimePicker_ValidStart";
            this.dateTimePicker_ValidStart.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker_ValidStart.TabIndex = 180;
            this.dateTimePicker_ValidStart.ValueChanged += new System.EventHandler(this.dateTimePickerValid_Start_ValueChanged);
            this.dateTimePicker_ValidStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerValid_Start_MouseDown);
            // 
            // dateTimePicker_ValidEnd
            // 
            this.dateTimePicker_ValidEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ValidEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ValidEnd.Location = new System.Drawing.Point(332, 173);
            this.dateTimePicker_ValidEnd.Name = "dateTimePicker_ValidEnd";
            this.dateTimePicker_ValidEnd.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker_ValidEnd.TabIndex = 168;
            this.dateTimePicker_ValidEnd.ValueChanged += new System.EventHandler(this.dateTimePicker_ValidEnd_ValueChanged);
            this.dateTimePicker_ValidEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker_ValidEnd_MouseDown);
            // 
            // GroupBox_DoorTypeChoice
            // 
            this.GroupBox_DoorTypeChoice.BackColor = System.Drawing.Color.Azure;
            this.GroupBox_DoorTypeChoice.Controls.Add(this.radio_FloorSet);
            this.GroupBox_DoorTypeChoice.Controls.Add(this.radio_BuildingSet);
            this.GroupBox_DoorTypeChoice.Controls.Add(this.radio_RoomSet);
            this.GroupBox_DoorTypeChoice.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_DoorTypeChoice.ForeColor = System.Drawing.Color.Black;
            this.GroupBox_DoorTypeChoice.Location = new System.Drawing.Point(468, 14);
            this.GroupBox_DoorTypeChoice.Name = "GroupBox_DoorTypeChoice";
            this.GroupBox_DoorTypeChoice.Size = new System.Drawing.Size(129, 125);
            this.GroupBox_DoorTypeChoice.TabIndex = 179;
            this.GroupBox_DoorTypeChoice.TabStop = false;
            this.GroupBox_DoorTypeChoice.Text = "Choose Door Type";
            this.GroupBox_DoorTypeChoice.Enter += new System.EventHandler(this.GroupBox_DoorTypeChoice_Enter);
            // 
            // radio_FloorSet
            // 
            this.radio_FloorSet.AutoSize = true;
            this.radio_FloorSet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_FloorSet.ForeColor = System.Drawing.Color.IndianRed;
            this.radio_FloorSet.Location = new System.Drawing.Point(18, 52);
            this.radio_FloorSet.Name = "radio_FloorSet";
            this.radio_FloorSet.Size = new System.Drawing.Size(82, 18);
            this.radio_FloorSet.TabIndex = 54;
            this.radio_FloorSet.Text = "Floor Door";
            this.radio_FloorSet.UseVisualStyleBackColor = true;
            this.radio_FloorSet.CheckedChanged += new System.EventHandler(this.radio_FloorSet_CheckedChanged);
            // 
            // radio_BuildingSet
            // 
            this.radio_BuildingSet.AutoSize = true;
            this.radio_BuildingSet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_BuildingSet.ForeColor = System.Drawing.Color.IndianRed;
            this.radio_BuildingSet.Location = new System.Drawing.Point(18, 77);
            this.radio_BuildingSet.Name = "radio_BuildingSet";
            this.radio_BuildingSet.Size = new System.Drawing.Size(98, 18);
            this.radio_BuildingSet.TabIndex = 55;
            this.radio_BuildingSet.Text = "Building Door";
            this.radio_BuildingSet.UseVisualStyleBackColor = true;
            this.radio_BuildingSet.CheckedChanged += new System.EventHandler(this.radio_BuildingSet_CheckedChanged);
            // 
            // radio_RoomSet
            // 
            this.radio_RoomSet.AutoSize = true;
            this.radio_RoomSet.Checked = true;
            this.radio_RoomSet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_RoomSet.ForeColor = System.Drawing.Color.IndianRed;
            this.radio_RoomSet.Location = new System.Drawing.Point(18, 25);
            this.radio_RoomSet.Name = "radio_RoomSet";
            this.radio_RoomSet.Size = new System.Drawing.Size(86, 18);
            this.radio_RoomSet.TabIndex = 53;
            this.radio_RoomSet.TabStop = true;
            this.radio_RoomSet.Text = "Room Door";
            this.radio_RoomSet.UseVisualStyleBackColor = true;
            this.radio_RoomSet.CheckedChanged += new System.EventHandler(this.radio_RoomSet_CheckedChanged);
            // 
            // txtCountry
            // 
            this.txtCountry.AcceptsReturn = true;
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCountry.Location = new System.Drawing.Point(308, 314);
            this.txtCountry.MaxLength = 0;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.Size = new System.Drawing.Size(41, 20);
            this.txtCountry.TabIndex = 64;
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountry.Visible = false;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Gainsboro;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(8, 223);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(81, 17);
            this.Label10.TabIndex = 40;
            this.Label10.Text = "Contact No.";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Gainsboro;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(16, 255);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(65, 17);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "Address";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Gainsboro;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(8, 281);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(81, 17);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "Nationality";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label7_0
            // 
            this._Label7_0.BackColor = System.Drawing.Color.Gainsboro;
            this._Label7_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label7_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label7_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label7_0.Location = new System.Drawing.Point(8, 191);
            this._Label7_0.Name = "_Label7_0";
            this._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label7_0.Size = new System.Drawing.Size(81, 17);
            this._Label7_0.TabIndex = 37;
            this._Label7_0.Text = "Passport No.";
            this._Label7_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Gainsboro;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(48, 93);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(33, 17);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Sex";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbNodays
            // 
            this.lbNodays.BackColor = System.Drawing.Color.Gainsboro;
            this.lbNodays.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNodays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNodays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNodays.Location = new System.Drawing.Point(210, 89);
            this.lbNodays.Name = "lbNodays";
            this.lbNodays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNodays.Size = new System.Drawing.Size(73, 17);
            this.lbNodays.TabIndex = 35;
            this.lbNodays.Text = "No Of Days";
            this.lbNodays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbValidEnd
            // 
            this.lbValidEnd.BackColor = System.Drawing.Color.Gainsboro;
            this.lbValidEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbValidEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValidEnd.Location = new System.Drawing.Point(219, 176);
            this.lbValidEnd.Name = "lbValidEnd";
            this.lbValidEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbValidEnd.Size = new System.Drawing.Size(97, 17);
            this.lbValidEnd.TabIndex = 34;
            this.lbValidEnd.Text = "Valid End Date";
            this.lbValidEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.Gainsboro;
            this.Label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label24.Location = new System.Drawing.Point(219, 119);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(97, 17);
            this.Label24.TabIndex = 33;
            this.Label24.Text = "Valid Start Date";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Gainsboro;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(16, 127);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "First Name";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Gainsboro;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(16, 161);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(65, 17);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "Surname";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.Gainsboro;
            this.Label28.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label28.Location = new System.Drawing.Point(332, 89);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(62, 17);
            this.Label28.TabIndex = 29;
            this.Label28.Text = "Card No.";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox_Setting_DateTime
            // 
            this.groupBox_Setting_DateTime.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox_Setting_DateTime.Controls.Add(this.label18);
            this.groupBox_Setting_DateTime.Controls.Add(this.dateTimePicker_SettingDate);
            this.groupBox_Setting_DateTime.Controls.Add(this.label_SettingDateTime);
            this.groupBox_Setting_DateTime.Controls.Add(this.mskSettingTime);
            this.groupBox_Setting_DateTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Setting_DateTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Setting_DateTime.Location = new System.Drawing.Point(21, 355);
            this.groupBox_Setting_DateTime.Name = "groupBox_Setting_DateTime";
            this.groupBox_Setting_DateTime.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_Setting_DateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_Setting_DateTime.Size = new System.Drawing.Size(205, 131);
            this.groupBox_Setting_DateTime.TabIndex = 178;
            this.groupBox_Setting_DateTime.TabStop = false;
            this.groupBox_Setting_DateTime.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 14);
            this.label18.TabIndex = 214;
            this.label18.Text = "(set to current time)";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // dateTimePicker_SettingDate
            // 
            this.dateTimePicker_SettingDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_SettingDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_SettingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_SettingDate.Location = new System.Drawing.Point(21, 53);
            this.dateTimePicker_SettingDate.Name = "dateTimePicker_SettingDate";
            this.dateTimePicker_SettingDate.Size = new System.Drawing.Size(122, 26);
            this.dateTimePicker_SettingDate.TabIndex = 178;
            this.dateTimePicker_SettingDate.ValueChanged += new System.EventHandler(this.dateTimePicker_SettingDate_ValueChanged);
            // 
            // label_SettingDateTime
            // 
            this.label_SettingDateTime.AutoSize = true;
            this.label_SettingDateTime.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SettingDateTime.ForeColor = System.Drawing.Color.Black;
            this.label_SettingDateTime.Location = new System.Drawing.Point(17, 13);
            this.label_SettingDateTime.Name = "label_SettingDateTime";
            this.label_SettingDateTime.Size = new System.Drawing.Size(168, 19);
            this.label_SettingDateTime.TabIndex = 177;
            this.label_SettingDateTime.Text = "SET DATE AND TIME";
            this.label_SettingDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsgFunction2
            // 
            this.lblMsgFunction2.BackColor = System.Drawing.Color.MistyRose;
            this.lblMsgFunction2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMsgFunction2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgFunction2.ForeColor = System.Drawing.Color.Blue;
            this.lblMsgFunction2.Location = new System.Drawing.Point(433, 142);
            this.lblMsgFunction2.Name = "lblMsgFunction2";
            this.lblMsgFunction2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsgFunction2.Size = new System.Drawing.Size(361, 33);
            this.lblMsgFunction2.TabIndex = 73;
            this.lblMsgFunction2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMsgFunction
            // 
            this.lbMsgFunction.BackColor = System.Drawing.Color.MistyRose;
            this.lbMsgFunction.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMsgFunction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgFunction.ForeColor = System.Drawing.Color.Red;
            this.lbMsgFunction.Location = new System.Drawing.Point(1, 142);
            this.lbMsgFunction.Name = "lbMsgFunction";
            this.lbMsgFunction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMsgFunction.Size = new System.Drawing.Size(433, 33);
            this.lbMsgFunction.TabIndex = 72;
            this.lbMsgFunction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(159, 4);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(534, 41);
            this.Label1.TabIndex = 70;
            this.Label1.Text = "Admin Mode";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.MistyRose;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(1, 175);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(793, 33);
            this.lblMessage.TabIndex = 68;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbIssueCardHeader
            // 
            this.lbIssueCardHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbIssueCardHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbIssueCardHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueCardHeader.ForeColor = System.Drawing.Color.IndianRed;
            this.lbIssueCardHeader.Location = new System.Drawing.Point(145, 52);
            this.lbIssueCardHeader.Name = "lbIssueCardHeader";
            this.lbIssueCardHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIssueCardHeader.Size = new System.Drawing.Size(339, 33);
            this.lbIssueCardHeader.TabIndex = 66;
            this.lbIssueCardHeader.Text = "Legacy System";
            this.lbIssueCardHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIssueCardHeader.Visible = false;
            this.lbIssueCardHeader.Click += new System.EventHandler(this.lbIssueCardHeader_Click);
            // 
            // FloorFrame
            // 
            this.FloorFrame.BackColor = System.Drawing.Color.Gainsboro;
            this.FloorFrame.Controls.Add(this.cboFloorNo);
            this.FloorFrame.Controls.Add(this.lbFloor);
            this.FloorFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FloorFrame.Location = new System.Drawing.Point(337, 6);
            this.FloorFrame.Name = "FloorFrame";
            this.FloorFrame.Padding = new System.Windows.Forms.Padding(0);
            this.FloorFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FloorFrame.Size = new System.Drawing.Size(121, 41);
            this.FloorFrame.TabIndex = 50;
            this.FloorFrame.TabStop = false;
            this.FloorFrame.Visible = false;
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboRoomNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRoomNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRoomNo.Location = new System.Drawing.Point(518, 24);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomNo.Size = new System.Drawing.Size(65, 22);
            this.cboRoomNo.TabIndex = 56;
            this.cboRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboRoomNo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Gainsboro;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(453, 25);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(59, 19);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Room No.";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ZoneFrame
            // 
            this.ZoneFrame.BackColor = System.Drawing.Color.Gainsboro;
            this.ZoneFrame.Controls.Add(this.cboZoneNo);
            this.ZoneFrame.Controls.Add(this.lbZoneNo);
            this.ZoneFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoneFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZoneFrame.Location = new System.Drawing.Point(321, 6);
            this.ZoneFrame.Name = "ZoneFrame";
            this.ZoneFrame.Padding = new System.Windows.Forms.Padding(0);
            this.ZoneFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoneFrame.Size = new System.Drawing.Size(137, 41);
            this.ZoneFrame.TabIndex = 66;
            this.ZoneFrame.TabStop = false;
            this.ZoneFrame.Visible = false;
            // 
            // lbZoneNo
            // 
            this.lbZoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbZoneNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbZoneNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZoneNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbZoneNo.Location = new System.Drawing.Point(16, 16);
            this.lbZoneNo.Name = "lbZoneNo";
            this.lbZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbZoneNo.Size = new System.Drawing.Size(57, 17);
            this.lbZoneNo.TabIndex = 68;
            this.lbZoneNo.Text = "Zone No. ";
            this.lbZoneNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RoomTypeFrame
            // 
            this.RoomTypeFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RoomTypeFrame.Controls.Add(this.txtRoomType);
            this.RoomTypeFrame.Controls.Add(this.Label13);
            this.RoomTypeFrame.Controls.Add(this.Label15);
            this.RoomTypeFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RoomTypeFrame.Location = new System.Drawing.Point(450, 142);
            this.RoomTypeFrame.Name = "RoomTypeFrame";
            this.RoomTypeFrame.Padding = new System.Windows.Forms.Padding(0);
            this.RoomTypeFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomTypeFrame.Size = new System.Drawing.Size(305, 41);
            this.RoomTypeFrame.TabIndex = 60;
            this.RoomTypeFrame.TabStop = false;
            this.RoomTypeFrame.Visible = false;
            // 
            // txtRoomType
            // 
            this.txtRoomType.AcceptsReturn = true;
            this.txtRoomType.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRoomType.Location = new System.Drawing.Point(176, 16);
            this.txtRoomType.MaxLength = 0;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRoomType.Size = new System.Drawing.Size(17, 20);
            this.txtRoomType.TabIndex = 7;
            this.txtRoomType.Visible = false;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(8, 16);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(65, 15);
            this.Label13.TabIndex = 62;
            this.Label13.Text = "Room Type";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(192, 16);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(41, 15);
            this.Label15.TabIndex = 61;
            this.Label15.Text = "Room";
            // 
            // RoomFrame
            // 
            this.RoomFrame.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomFrame.Controls.Add(this.cboRoomType);
            this.RoomFrame.Controls.Add(this.cboRoomType_Others);
            this.RoomFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RoomFrame.Location = new System.Drawing.Point(557, 6);
            this.RoomFrame.Name = "RoomFrame";
            this.RoomFrame.Padding = new System.Windows.Forms.Padding(0);
            this.RoomFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomFrame.Size = new System.Drawing.Size(115, 41);
            this.RoomFrame.TabIndex = 54;
            this.RoomFrame.TabStop = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.Gainsboro;
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.cboRoomNo);
            this.Frame1.Controls.Add(this.RoomFrame);
            this.Frame1.Controls.Add(this.FloorFrame);
            this.Frame1.Controls.Add(this.cboCardType);
            this.Frame1.Controls.Add(this.cboBuilding);
            this.Frame1.Controls.Add(this.Label14);
            this.Frame1.Controls.Add(this.lbBuilding);
            this.Frame1.Controls.Add(this.ZoneFrame);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 88);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(613, 51);
            this.Frame1.TabIndex = 69;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Select Room";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.Turquoise;
            this.Frame2.Controls.Add(this.button3);
            this.Frame2.Controls.Add(this.cmdClear);
            this.Frame2.Controls.Add(this.cmdReturn);
            this.Frame2.Controls.Add(this.button1);
            this.Frame2.Controls.Add(this.cmdIssue);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(7, 515);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(774, 65);
            this.Frame2.TabIndex = 71;
            this.Frame2.TabStop = false;
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(530, 11);
            this.panel_CommStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CommStatus.Name = "panel_CommStatus";
            this.panel_CommStatus.Size = new System.Drawing.Size(119, 28);
            this.panel_CommStatus.TabIndex = 174;
            // 
            // pictureBox_COMM_Color
            // 
            this.pictureBox_COMM_Color.Image = global::AMS.Properties.Resources.COM_RED;
            this.pictureBox_COMM_Color.InitialImage = global::AMS.Properties.Resources.COM_YELLOW;
            this.pictureBox_COMM_Color.Location = new System.Drawing.Point(101, 3);
            this.pictureBox_COMM_Color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_COMM_Color.Name = "pictureBox_COMM_Color";
            this.pictureBox_COMM_Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_COMM_Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_COMM_Color.TabIndex = 1;
            this.pictureBox_COMM_Color.TabStop = false;
            // 
            // label_CommState
            // 
            this.label_CommState.AutoSize = true;
            this.label_CommState.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CommState.ForeColor = System.Drawing.Color.Blue;
            this.label_CommState.Location = new System.Drawing.Point(4, 6);
            this.label_CommState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CommState.Name = "label_CommState";
            this.label_CommState.Size = new System.Drawing.Size(96, 13);
            this.label_CommState.TabIndex = 0;
            this.label_CommState.Text = "Connected State";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(425, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 32);
            this.button1.TabIndex = 175;
            this.button1.Text = "Go To Guest Key Section....";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.checkBoxSingleCard);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtFloorBuildingValue);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buildingValue);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox_Setting_DateTime);
            this.panel1.Location = new System.Drawing.Point(718, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 508);
            this.panel1.TabIndex = 177;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 488);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(247, 13);
            this.label19.TabIndex = 215;
            this.label19.Text = "Required for legacy AND bulk setting card creation";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 20);
            this.label17.TabIndex = 213;
            this.label17.Text = "SETTING CARDS";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(21, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(55, 24);
            this.comboBox4.TabIndex = 212;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(82, 100);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(59, 24);
            this.comboBox5.TabIndex = 211;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(147, 100);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(60, 24);
            this.comboBox6.TabIndex = 210;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 24);
            this.comboBox1.TabIndex = 209;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(148, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 24);
            this.comboBox3.TabIndex = 208;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 24);
            this.comboBox2.TabIndex = 207;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 189;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtFloorBuildingValue
            // 
            this.txtFloorBuildingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorBuildingValue.Location = new System.Drawing.Point(21, 286);
            this.txtFloorBuildingValue.Name = "txtFloorBuildingValue";
            this.txtFloorBuildingValue.Size = new System.Drawing.Size(46, 22);
            this.txtFloorBuildingValue.TabIndex = 188;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 187;
            this.label16.Text = "Floor SETTING";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 186;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buildingValue
            // 
            this.buildingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingValue.Location = new System.Drawing.Point(21, 191);
            this.buildingValue.Name = "buildingValue";
            this.buildingValue.Size = new System.Drawing.Size(46, 22);
            this.buildingValue.TabIndex = 184;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 16);
            this.label12.TabIndex = 183;
            this.label12.Text = "Building SETTING";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 182;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 177;
            this.label7.Text = "Bulk Room SETTING Cards";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.IndianRed;
            this.label21.Location = new System.Drawing.Point(223, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 29);
            this.label21.TabIndex = 216;
            this.label21.Text = "Legacy System";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 217;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(5, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 430);
            this.textBox1.TabIndex = 218;
            // 
            // checkBoxSingleCard
            // 
            this.checkBoxSingleCard.AutoSize = true;
            this.checkBoxSingleCard.Location = new System.Drawing.Point(214, 74);
            this.checkBoxSingleCard.Name = "checkBoxSingleCard";
            this.checkBoxSingleCard.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSingleCard.TabIndex = 216;
            this.checkBoxSingleCard.Text = "Create Single Card";
            this.checkBoxSingleCard.UseVisualStyleBackColor = true;
            this.checkBoxSingleCard.CheckedChanged += new System.EventHandler(this.checkBoxSingleCard_CheckedChanged);
            // 
            // Form_IssueCardDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1059, 592);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbIssueCardHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.IssueCardFrame);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMsgFunction2);
            this.Controls.Add(this.lbMsgFunction);
            this.Controls.Add(this.RoomTypeFrame);
            this.Name = "Form_IssueCardDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_IssueCardDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_IssueCardDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_IssueCardDMS_VisibleChanged);
            this.ClientIDFrame.ResumeLayout(false);
            this.ClientIDFrame.PerformLayout();
            this.IssueCardFrame.ResumeLayout(false);
            this.IssueCardFrame.PerformLayout();
            this.GroupBox_DoorTypeChoice.ResumeLayout(false);
            this.GroupBox_DoorTypeChoice.PerformLayout();
            this.groupBox_Setting_DateTime.ResumeLayout(false);
            this.groupBox_Setting_DateTime.PerformLayout();
            this.FloorFrame.ResumeLayout(false);
            this.ZoneFrame.ResumeLayout(false);
            this.RoomTypeFrame.ResumeLayout(false);
            this.RoomTypeFrame.PerformLayout();
            this.RoomFrame.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form_IssueCardDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
      this.Clear_Info_Screen();
    }

    private void Check_ForNewUser()
    {
      Issue_Card_Class issueCardClass = new Issue_Card_Class();
      this.txtCardNo.Text = issueCardClass.GetNew_CardNo(false, Convert.ToInt32(this.cboBuilding.Text));
      this.txtClientID.Text = issueCardClass.GetNew_ClientID(false, Convert.ToInt32(this.cboBuilding.Text));
    }

    private void Check_For_OldUser()
    {
      this.txtCardNo.Text = new Issue_Card_Class().GetNew_CardNo(false, Convert.ToInt32(this.cboBuilding.Text));
    }

    private void Check_New_or_Old()
    {
      if (this._optUser_0.Checked && !this.Init_Flag)
      {
        this.Check_ForNewUser();
      }
      else
      {
        if (!this._optUser_1.Checked)
          return;
        this.Clear_Info_Screen();
        this.cmdViewClient.Enabled = true;
      }
    }

    private void Form_IssueCardDMS_Load(object sender, EventArgs e)
    {
            string filePath = "dropdowns.txt";
            int buildingNumber = 0;
            int maxFloor = 0;

            // Create a class to hold room range information


            // Read all lines from the file
            var lines = File.ReadAllLines(filePath);

            // First pass: Determine the maximum floor number
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    if (parts[0] == "b" && int.TryParse(parts[1], out int number))
                    {
                        buildingNumber = number;
                    }
                    else if (int.TryParse(parts[0], out int floor))
                    {
                        if (floor > maxFloor)
                            maxFloor = floor;
                    }
                }
            }

            // Create arrays to store start and end room numbers for each floor
            floorRoomRanges = new RoomRange[maxFloor + 1];

            // Second pass: Parse the room ranges for each floor
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && parts[0] != "b" && int.TryParse(parts[0], out int floor))
                {
                    if (parts[1].Contains("-"))
                    {
                        var rangeParts = parts[1].Split('-');
                        if (rangeParts.Length == 2 &&
                            int.TryParse(rangeParts[0], out int start) &&
                            int.TryParse(rangeParts[1], out int end))
                        {
                            floorRoomRanges[floor] = new RoomRange { Start = start, End = end };
                        }
                    }
                }
            }

            // Populate UI components
            // For comboBox1: display the building number
            comboBox1.Items.Clear();
            comboBox1.Items.Add($"{buildingNumber}");
            comboBox1.SelectedIndex = 0;

            // For comboBox2: list the floor numbers (from 1 to maxFloor)
            comboBox2.Items.Clear();
            for (int floor = 1; floor <= maxFloor; floor++)
            {
                comboBox2.Items.Add($"{floor}");
            }
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }

            // For comboBox3: populate with room numbers for floor 1 (if available)
            if (floorRoomRanges[1] != null)
            {
                PopulateComboBox3WithRange(floorRoomRanges[1].Start, floorRoomRanges[1].End);
            }

            // For comboBox4: display the building number
            comboBox4.Items.Clear();
            comboBox4.Items.Add($"{buildingNumber}");
            comboBox4.SelectedIndex = 0;

            // For comboBox5: list the floor numbers
            comboBox5.Items.Clear();
            for (int floor = 1; floor <= maxFloor; floor++)
            {
                comboBox5.Items.Add($"{floor}");
            }
            if (comboBox5.Items.Count > 0)
            {
                comboBox5.SelectedIndex = 0;
            }

            this.dateTimePicker_ValidStart.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_ValidStart.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_ValidEnd.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_ValidEnd.CustomFormat = "yyyy-MM-dd";
      DateTime dateTime1 = new DateTime();
      DateTime dateTime2 = DateTime.Now;
      dateTime2 = dateTime2.AddDays(1.0);
      this.dateTimePicker_ValidEnd.Value = dateTime2;
      this.mskCheckInTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
      this.mskCheckOutTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
      this.mskSettingTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
      this.cboBuilding.Items.Add((object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo.ToString());
      this.cboBuilding.SelectedIndex = 0;
      this.db.ComboFloorCheck(this.cboFloorNo, Global_Data.sBldNo);
      if (this.cboFloorNo.Items.Count > 0)
        this.cboFloorNo.SelectedIndex = 0;
      this.Init_cboCardType(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.Old_Valid_Start_Date = this.dateTimePicker_ValidStart.Value;
      this.Old_Valid_End_Date = this.dateTimePicker_ValidEnd.Value;
      this.cboCardType.Focus();
      this.cboCardType.Select();
      this.Check_New_or_Old();
    }
        private void PopulateComboBox3(int roomCount)
        {
            comboBox3.Items.Clear();
            for (int roomNumber = 1; roomNumber <= roomCount; roomNumber++)
            {
                comboBox3.Items.Add($"{roomNumber}");
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
        }

        private void PopulateComboBox6(int roomCount)
        {
            comboBox6.Items.Clear();
            for (int roomNumber = 1; roomNumber <= roomCount; roomNumber++)
            {
                comboBox6.Items.Add($"{roomNumber}");
            }
            if (comboBox6.Items.Count > 0)
            {
                comboBox6.SelectedIndex = 0;
            }
        }
        private void Form_IssueCardDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Check_OldGuest_Options_And_Process()
    {
      string commandText = this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText;
      this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from GInfo_Temp";
      this.db.temp_DB.gInfo_TempTableAdapter.Delete((string) null);
      this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText;
      this.db.Local_Command.CommandText = "Insert into GInfo_Temp(ClientID,ForeName,SurName,RoomNo,CardNo,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)<'5000'))AND (ClientAcc.NoOfPeople<>9)ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = this.db.building_DB1.clientTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
    }

    private void Check_CardType(string para_Building_No, string para_CardNo)
    {
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        if (row.CardNo == para_CardNo)
        {
          if (!(row.ClientID == this.txtClientID.Text))
            break;
          break;
        }
      }
    }

    private void CheckClientNumber()
    {
      switch (this.txtClientID.Text.Length)
      {
        case 1:
          this.txtClientID.Text = "0000000" + this.txtClientID.Text;
          break;
        case 2:
          this.txtClientID.Text = "000000" + this.txtClientID.Text;
          break;
        case 3:
          this.txtClientID.Text = "00000" + this.txtClientID.Text;
          break;
        case 4:
          this.txtClientID.Text = "0000" + this.txtClientID.Text;
          break;
        case 5:
          this.txtClientID.Text = "000" + this.txtClientID.Text;
          break;
        case 6:
          this.txtClientID.Text = "00" + this.txtClientID.Text;
          break;
        case 7:
          this.txtClientID.Text = "0" + this.txtClientID.Text;
          break;
      }
    }

    private bool GetClient_Record(string para_Building_No)
    {
      bool clientRecord = false;
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          this.cboSex.Text = row.Sex;
          this.txtFirstName.Text = row.ForeName;
          this.txtSurName.Text = row.SurName;
          this.txtContact.Text = row.Contact;
          this.txtAddress.Text = row.Address;
          this.cboCountry.Text = row.Country;
          this.txtIdentity.Text = row.Identity;
          this.txtNationality.Text = row.Nationality;
          clientRecord = true;
          break;
        }
      }
      return clientRecord;
    }

    private void cmdViewClient_Click(object sender, EventArgs e)
    {
      this.Check_OldGuest_Options_And_Process();
      this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
      int num = (int) new Form_GuestBrowserDMS().ShowDialog();
      if (!this.Old_Client_OK_flag)
        return;
      this.lblMessage.Text = "";
      this.Refresh();
      foreach (TempDataSet.GInfo_TempRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
      {
        if (row.ClientID == this.Old_Client_ID)
        {
          this.txtClientID.Text = row.ClientID;
          this.txtFirstName.Text = row.ForeName;
          this.txtSurName.Text = row.SurName;
          try
          {
            string cardNo = row.CardNo;
          }
          catch
          {
          }
          this.CheckClientNumber();
          this.GetClient_Record(this.cboBuilding.Text);
          this.Check_For_OldUser();
          break;
        }
      }
    }

    private void Clear_Info_Screen()
    {
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.txtIdentity.Text = "";
      this.txtContact.Text = "";
      this.txtAddress.Text = "";
      this.txtNationality.Text = "";
      this.txtRemark.Text = "";
      this.lblMessage.Text = "";
    }

    private void _optUser_0_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optUser_0.Checked)
        return;
      this.Clear_Info_Screen();
      this.txtClientID.Text = "";
      this.txtClientID.Refresh();
      this.cmdViewClient.Enabled = false;
      this.Check_ForNewUser();
    }

    private void _optUser_1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optUser_1.Checked)
        return;
      this.Clear_Info_Screen();
      this.txtClientID.Text = "";
      this.txtClientID.Refresh();
      this.lblMessage.Text = "Pls. Click Client ID Browser !";
      this.cmdViewClient.Enabled = true;
      this.cmdViewClient.Select();
      this.cmdViewClient.Focus();
    }

    private void Get_All_Rooms()
    {
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      this.db.Get_AvailableRoom_Temp((string) this.cboBuilding.SelectedItem, "ALLROOM");
    }

    private void Init_Room_For_RoomType(string para_RoomType)
    {
      this.cboRoomNo.Items.Clear();
      this.cboRoomNo.Text = "";
      foreach (TempDataSet.AvailableRoom_TempRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.AvailableRoom_Temp.Rows)
      {
        if (row.Description == para_RoomType)
          this.cboRoomNo.Items.Add((object) row.RoomNo);
      }
      if (this.cboRoomNo.Items.Count <= 0)
        return;
      this.cboRoomNo.SelectedIndex = 0;
    }

    private void Init_Room_For_SelectedFloor(string para_FloorNum)
    {
      this.cboRoomNo.Items.Clear();
      this.cboRoomNo.Text = "";
      foreach (TempDataSet.AvailableRoom_TempRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.AvailableRoom_Temp.Rows)
      {
        if (row.RoomNo.Substring(1, 2) == para_FloorNum)
          this.cboRoomNo.Items.Add((object) row.RoomNo);
      }
      if (this.cboRoomNo.Items.Count <= 0)
        return;
      this.cboRoomNo.SelectedIndex = 0;
    }

    private void Init_cboCardType(string para_ACCLEVEL)
    {
      this.cboCardType.Items.Clear();
      this.cboCardType.Text = "";
           
            switch (para_ACCLEVEL)
      {
        case "0":
          this.cboCardType.Items.Add((object) "Room setting Card");
          this.cboCardType.Items.Add((object) "Times setting Card");
          this.cboCardType.Items.Add((object) "Region setting Card");
          this.cboCardType.Items.Add((object) "Cleared Card");
          this.cboCardType.Items.Add((object) "Loss Card");
          this.cboCardType.Items.Add((object) "Loss recovery Card");
          this.cboCardType.Items.Add((object) "Limited room Card");
          this.cboCardType.Items.Add((object) "Recovery room Card");
          this.cboCardType.Items.Add((object) "Acquisition Card");
          this.cboCardType.Items.Add((object) "Floor Card");
          this.cboCardType.Items.Add((object) "Emergency");
          //this.cboCardType.Items.Add((object) "Region Card");
          //this.cboCardType.Items.Add((object) "Chief Card");
          this.cboCardType.Items.Add((object) "Building Card");
          this.cboCardType.Items.Add((object) "Spare Card");
          this.cboCardType.Items.Add((object) "OtherRooms");
          try
          {
            this.cboCardType.SelectedItem = (object) "Room setting Card";
            this.lbIssueCardHeader.Text = "ISSUE ROOM SETTING CARD";
            break;
          }
          catch
          {
            this.cboCardType.SelectedIndex = 0;
            break;
          }
        case "1":
          this.cboCardType.Items.Add((object) "Times setting Card");
          this.cboCardType.Items.Add((object) "Loss Card");
          this.cboCardType.Items.Add((object) "Loss recovery Card");
          this.cboCardType.Items.Add((object) "Recovery room Card");
          this.cboCardType.Items.Add((object) "Emergency");
          this.cboCardType.Items.Add((object) "Acquisition Card");
          this.cboCardType.SelectedIndex = 0;
          break;
        case "3":
          this.cboCardType.Items.Add((object) "Times setting Card");
          this.cboCardType.Items.Add((object) "Emergency");
          this.cboCardType.SelectedIndex = 0;
          break;
      }
            this.cboCardType.Items.Add((object)"Emergency");
        }

    private void Disable_Buttons()
    {
      this.cmdClear.Enabled = false;
      this.cmdReturn.Enabled = false;
      this.cmdIssue.Enabled = false;
    }

    private void Enable_Buttons()
    {
      this.cmdClear.Enabled = true;
      this.cmdReturn.Enabled = true;
    }

    private void Form_IssueCardDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Disable_Buttons();
      this.lblMessage.Text = "Loading Information!";
      this.lblMessage.Refresh();
      this.Init_Flag = true;
      this.Timer1.Start();
      this._1stTime_Flag = false;
      this.Old_Date_Time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            this.mskCheckInTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            this.mskSettingTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            this.Init_cboCardType(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
    }

    private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Init_Room_For_RoomType((string) this.cboRoomType.SelectedItem);
    }

    private void Init_Floor_Region_Combos()
    {
      this.cboZoneNo.Items.Clear();
      for (int index = 0; index < 100; ++index)
      {
        this.cboZoneNo.Items.Add((object) index.ToString("D"));
        try
        {
          this.cboZoneNo.SelectedItem = (object) "1";
        }
        catch
        {
        }
      }
    }

    private bool Initialize_Controls()
    {
      try
      {
        try
        {
          this.Get_All_Rooms();
        }
        catch
        {
          this.lblMessage.Text = "Get_All_Rooms() Failed!";
          this.lblMessage.Refresh();
        }
        try
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmType(this.cboRoomType);
        }
        catch
        {
          this.lblMessage.Text = "Initialize_ComboRmType() Failed!";
          this.lblMessage.Refresh();
        }
        try
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmType_Others(this.cboRoomType_Others);
        }
        catch
        {
          this.lblMessage.Text = "Initialize_ComboRmType_Others() Failed!";
          this.lblMessage.Refresh();
        }
        try
        {
          this.Init_Room_For_RoomType((string) this.cboRoomType.SelectedItem);
        }
        catch
        {
          this.lblMessage.Text = "Init_Room_For_RoomType() Failed!";
          this.lblMessage.Refresh();
        }
        try
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialze_ComboCountry(this.cboCountry);
        }
        catch
        {
          this.lblMessage.Text = "Initialze_ComboCountry() Failed!";
          this.lblMessage.Refresh();
        }
        this.cboSex.Items.Clear();
        this.cboSex.Items.Add((object) "M");
        this.cboSex.Items.Add((object) "F");
        this.cboSex.SelectedItem = (object) "M";
        try
        {
          this.Init_Floor_Region_Combos();
        }
        catch
        {
          this.lblMessage.Text = "Init_Floor_Region_Combos() Failed!";
          this.lblMessage.Refresh();
        }
        this._optUser_0.Checked = true;
        this.Clear_Info_Screen();
        this.cmdViewClient.Enabled = false;
        try
        {
          this.Check_ForNewUser();
        }
        catch
        {
          this.lblMessage.Text = "Check_ForNewUser() Failed!";
          this.lblMessage.Refresh();
        }
        this.lblMessage.Text = "";
        this.Enable_Buttons();
        this.Init_Flag = false;
        try
        {
          this.Check_SelectedIndex((string) this.cboCardType.SelectedItem);
        }
        catch
        {
          this.lblMessage.Text = "Check_SelectedIndex() Failed!";
          this.lblMessage.Refresh();
        }
        return true;
      }
      catch
      {
        this.lblMessage.Text = "Initialize_Controls() Failed!";
        this.lblMessage.Refresh();
        this.Init_Flag = false;
        return false;
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (this.Visible && this.Init_Flag)
        this.Initialize_Controls();
      if (this.Old_Date_Time != DateTime.Now.ToLongTimeString())
      {
        this.Old_Date_Time = DateTime.Now.ToLongTimeString();
        this.mskCheckInTime.Text = DateTime.Now.ToLongTimeString();
      }
      if (!this.Visible)
        return;
      this.Check_Issue_Enable();
    }

    private void Check_Issue_Enable()
    {
      if (this.txtFirstName.Text.Length > 0 && this.txtSurName.Text.Length > 0 && this.txtIdentity.Text.Length > 0 && this.txtContact.Text.Length > 0 && this.txtAddress.Text.Length > 0 && this.txtClientID.Text.Length > 0 && this.txtCardNo.Text.Length > 0 && this.txtNationality.Text.Length > 0)
        this.cmdIssue.Enabled = true;
      else
        this.cmdIssue.Enabled = false;
    }

    private void Enable_Start_End_DateTime(bool para_Enable_Flag)
    {
      if (para_Enable_Flag)
      {
        this.dateTimePicker_ValidStart.Visible = true;
        this.dateTimePicker_ValidEnd.Visible = true;
        this.Label24.Visible = true;
        this.lbInTime.Visible = true;
        this.mskCheckInTime.Visible = true;
        this.lbValidEnd.Visible = true;
        this.lbOutTime.Visible = true;
        this.mskCheckOutTime.Visible = true;
      }
      else
      {
        this.dateTimePicker_ValidStart.Visible = false;
        this.dateTimePicker_ValidEnd.Visible = false;
        this.Label24.Visible = false;
        this.lbInTime.Visible = false;
        this.mskCheckInTime.Visible = false;
        this.lbValidEnd.Visible = false;
        this.lbOutTime.Visible = false;
        this.mskCheckOutTime.Visible = false;
      }
    }

    private void Enable_Start_End_DateOnly(bool para_Enable_Flag)
    {
      if (para_Enable_Flag)
      {
        this.dateTimePicker_ValidStart.Visible = true;
        this.dateTimePicker_ValidEnd.Visible = true;
        this.Label24.Visible = true;
        this.lbInTime.Visible = true;
        this.mskCheckInTime.Visible = true;
        this.lbValidEnd.Visible = true;
        this.lbOutTime.Visible = false;
        this.mskCheckOutTime.Visible = false;
      }
      else
      {
        this.dateTimePicker_ValidStart.Visible = false;
        this.dateTimePicker_ValidEnd.Visible = false;
        this.Label24.Visible = false;
        this.lbInTime.Visible = false;
        this.mskCheckInTime.Visible = false;
        this.lbValidEnd.Visible = false;
        this.lbOutTime.Visible = false;
        this.mskCheckOutTime.Visible = false;
      }
    }

    private void Check_SelectedIndex(string para_CardType)
    {
      switch (para_CardType)
      {
        case "Guest Card limit":
          this.lbIssueCardHeader.Text = "ISSUE GUEST LIMIT CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Room setting Card":
          this.lbIssueCardHeader.Text = "ISSUE ROOM SETTING CARD";
          this.FloorFrame.Visible = true;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = true;
          this.groupBox_Setting_DateTime.Visible = true;
          this.radio_RoomSet.Checked = true;
          this.GroupBox_DoorTypeChoice.Visible = true;
          this.Enable_Start_End_DateTime(false);
          this.cboFloorNo.SelectedItem = (object) "1";
          this.Init_Room_For_SelectedFloor(Convert.ToByte((string) this.cboFloorNo.SelectedItem).ToString("D2"));
          int count1 = this.cboRoomNo.Items.Count;
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Emergency":
          this.lbIssueCardHeader.Text = "ISSUE EMERGENCY CARD";
          this.FloorFrame.Visible = true;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = true;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          if (Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL) > (short) 0)
            this.Enable_Start_End_DateOnly(true);
          else
            this.Enable_Start_End_DateTime(true);
          this.cboFloorNo.SelectedItem = (object) "1";
          this.Init_Room_For_SelectedFloor(Convert.ToByte((string) this.cboFloorNo.SelectedItem).ToString("D2"));
          int count2 = this.cboRoomNo.Items.Count;
          this.lbNodays.Visible = true;
          this.txtNoOfDays.Visible = true;
          break;
        case "OtherRooms":
          this.lbIssueCardHeader.Text = "ISSUE OTHER ROOM CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = true;
          this.RoomFrame.Visible = true;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(true);
          this.Init_Room_For_RoomType((string) this.cboRoomType_Others.SelectedItem);
          this.lbNodays.Visible = true;
          this.txtNoOfDays.Visible = true;
          break;
        case "Times setting Card":
          this.lbIssueCardHeader.Text = "ISSUE TIME SETTING CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = true;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Region setting Card":
          this.lbIssueCardHeader.Text = "ISSUE REGION SETTING CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = true;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Cleared Card":
          this.lbIssueCardHeader.Text = "ISSUE CLEARED CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Loss Card":
          this.lbIssueCardHeader.Text = "ISSUE LOSS CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Loss recovery Card":
          this.lbIssueCardHeader.Text = "ISSUE LOSS RECOVERY CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Limited room Card":
          this.lbIssueCardHeader.Text = "ISSUE LIMITED ROOM CARD";
          this.FloorFrame.Visible = true;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = true;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.cboFloorNo.SelectedItem = (object) "1";
          this.Init_Room_For_SelectedFloor(Convert.ToByte((string) this.cboFloorNo.SelectedItem).ToString("D2"));
          int count3 = this.cboRoomNo.Items.Count;
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Recovery room Card":
          this.lbIssueCardHeader.Text = "ISSUE RECOVERY ROOM CARD";
          this.FloorFrame.Visible = true;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = true;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.cboFloorNo.SelectedItem = (object) "1";
          this.Init_Room_For_SelectedFloor(Convert.ToByte((string) this.cboFloorNo.SelectedItem).ToString("D2"));
          int count4 = this.cboRoomNo.Items.Count;
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Acquisition Card":
          this.lbIssueCardHeader.Text = "ISSUE ACQUISITION CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Floor Card":
          this.lbIssueCardHeader.Text = "ISSUE FLOOR CARD";
          this.FloorFrame.Visible = true;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(true);
          this.lbNodays.Visible = true;
          this.txtNoOfDays.Visible = true;
          break;
        case "Region Card":
          this.lbIssueCardHeader.Text = "ISSUE AREA(REGION) CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = true;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(true);
          this.lbNodays.Visible = true;
          this.txtNoOfDays.Visible = true;
          break;
        /*case "Chief Card":
        
          this.lbIssueCardHeader.Text = "ISSUE CHIEF CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;*/
        case "Emergency Card":
          this.lbIssueCardHeader.Text = "ISSUE EMERGENCY CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = true;
          this.txtNoOfDays.Visible = true;
          break;
        case "Building Card":
          this.lbIssueCardHeader.Text = "ISSUE BUILDING CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
        case "Spare Card":
          this.lbIssueCardHeader.Text = "ISSUE SPARE CARD";
          this.FloorFrame.Visible = false;
          this.ZoneFrame.Visible = false;
          this.cboRoomType.Visible = false;
          this.cboRoomType_Others.Visible = false;
          this.RoomFrame.Visible = false;
          this.groupBox_Setting_DateTime.Visible = false;
          this.GroupBox_DoorTypeChoice.Visible = false;
          this.Enable_Start_End_DateTime(false);
          this.lbNodays.Visible = false;
          this.txtNoOfDays.Visible = false;
          break;
      }
    }

    private void cboCardType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_SelectedIndex((string) this.cboCardType.SelectedItem);
    }

    private void radio_RoomSet_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radio_RoomSet.Checked)
        return;
      this.cboRoomType.Visible = true;
      this.RoomFrame.Visible = true;
      this.FloorFrame.Visible = false;
    }

    private void radio_FloorSet_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radio_FloorSet.Checked)
        return;
      this.cboRoomType.Visible = false;
      this.RoomFrame.Visible = false;
      this.FloorFrame.Visible = true;
    }

    private void radio_BuildingSet_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radio_BuildingSet.Checked)
        return;
      this.cboRoomType.Visible = false;
      this.RoomFrame.Visible = false;
      this.FloorFrame.Visible = false;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      this.Clear_Info_Screen();
      this._optUser_0.Checked = false;
            this._optUser_1.Checked = true;
        }

    private void dateTimePicker_ValidEnd_ValueChanged(object sender, EventArgs e)
    {
      if (this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ValidStart.Value) < 0)
      {
        this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
        this.dateTimePicker_ValidEnd.Refresh();
        int num = (int) MessageBox.Show("Invalid Date Range");
      }
      else
      {
        this.txtNoOfDays.Text = this.db.Get_No_Of_Days(this.dateTimePicker_ValidStart.Value, this.dateTimePicker_ValidEnd.Value).ToString();
        if (!((string) this.cboCardType.SelectedItem == "Emergency"))
          return;
        short int16 = Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL);
        if (int16 > (short) 0)
        {
          if (int16 == (short) 3 || int16 == (short) 1)
          {
            if (Convert.ToInt16(this.txtNoOfDays.Text) <= (short) 1)
              return;
            this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
            this.dateTimePicker_ValidEnd.Refresh();
            int num = (int) MessageBox.Show("Invalid Date Range");
          }
          else
          {
            this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
            this.dateTimePicker_ValidEnd.Refresh();
            int num = (int) MessageBox.Show("Invalid User");
          }
        }
        else if (int16 == (short) 0)
        {
          if (Convert.ToInt16(this.txtNoOfDays.Text) <= (short) 3)
            return;
          this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
          this.dateTimePicker_ValidEnd.Refresh();
          int num = (int) MessageBox.Show("Invalid Date Range");
        }
        else
        {
          this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
          this.dateTimePicker_ValidEnd.Refresh();
          int num = (int) MessageBox.Show("Invalid User");
        }
      }
    }

    private void dateTimePickerValid_Start_ValueChanged(object sender, EventArgs e)
    {
      if (this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ValidStart.Value) >= 0)
        return;
      this.dateTimePicker_ValidStart.Value = this.Old_Valid_Start_Date;
      this.dateTimePicker_ValidStart.Refresh();
      int num = (int) MessageBox.Show("Invalid Date Range");
    }

    private void dateTimePicker_ValidEnd_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_Valid_End_Date = this.dateTimePicker_ValidEnd.Value;
    }

    private void dateTimePickerValid_Start_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_Valid_Start_Date = this.dateTimePicker_ValidStart.Value;
    }

    private bool CheckNoOfDays() => true;

    private void GetCardPropertyValue()
    {
      gCardProperty.CardNo = this.txtCardNo.Text;
      gCardProperty.CardType = this.cboCardType.Text;
      gCardProperty.CardType = gCardProperty.CardType.Replace(" Card", "");
      if ("Room setting Card".Contains(gCardProperty.CardType))
      {
        if (this.radio_FloorSet.Checked)
          gCardProperty.CardType = gCardProperty.CardType.Replace("Room", "Flr.");
        else if (this.radio_BuildingSet.Checked)
          gCardProperty.CardType = gCardProperty.CardType.Replace("Room", "Bld.");
      }

            try
            {
                gCardProperty.CheckInDate = this.dateTimePicker_ValidStart.Value.Date;
                gCardProperty.CheckOutDate = this.dateTimePicker_ValidEnd.Value.Date;
                gCardProperty.CheckInTime = DateTime.Parse("1899-12-30 " + this.mskCheckInTime.Text);
            } catch (Exception exc) {
                gCardProperty.CheckInTime = DateTime.Parse("1899-12-30 12:00AM");
            }
      if (!this.cboCardType.Text.Contains("Room setting Card"))
      {
        if (!this.cboCardType.Text.Contains("Times setting Card"))
        {
          if (gCardProperty.CardType.Contains("Emergency"))
          {
            try
            {
              gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + this.mskCheckInTime.Text + ":00");
              goto label_14;
            }
            catch
            {
              gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
              goto label_14;
            }
          }
          else
          {
            try
            {
              gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + this.mskCheckInTime.Text + ":00");
              goto label_14;
            }
            catch
            {
              gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
              goto label_14;
            }
          }
        }
      }
      try
      {
        gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + this.mskSettingTime.Text + ":00");
      }
      catch
      {
        gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
      }
label_14:
      gCardProperty.BuildingNo = this.cboBuilding.Text;
      gCardProperty.FloorNo = this.cboFloorNo.Text;
      gCardProperty.RoomNo = this.cboRoomNo.Text.Substring(3, 2);
      if (this.cboZoneNo.Visible)
        gCardProperty.ZoneNo = this.cboZoneNo.Text;
      gCardProperty.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      gCardProperty.Account = "000000";
    }

    private void GetClientPropertyData()
    {
      if (this.cboCardType.Text.Contains("Emergency") && ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL == "3")
        gCardProperty.CardType = "ECard";
      else if (this.cboCardType.Text.Contains("Emergency") && ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL != "3")
        gCardProperty.CardType = "Emergency";
      else if (this.cboCardType.Text.Contains("OtherRooms"))
        gCardProperty.CardType = "RoomCard";
      gClientProperty.Identity = this.txtIdentity.Text;
      gClientProperty.Nationality = this.txtNationality.Text;
      gClientProperty.Remark = this.txtRemark.Text;
      gClientProperty.CardNo = this.txtCardNo.Text;
      if (this.cboCardType.Text.Contains("Emergency") || this.cboCardType.Text.Contains("OtherRooms"))
        gClientProperty.RoomNo = this.cboRoomNo.Text;
      else if (this.cboCardType.Text == "Room setting Card" || this.cboCardType.Text == "Recovery room Card" || this.cboCardType.Text == "Limited room Card")
      {
        if (this.cboCardType.Text == "Room setting Card")
        {
          if (this.radio_FloorSet.Checked || this.radio_BuildingSet.Checked)
          {
            if (this.radio_FloorSet.Checked)
              gClientProperty.RoomNo = "Fl " + this.cboFloorNo.Text;
            else if (this.radio_BuildingSet.Checked)
              gClientProperty.RoomNo = "Bl " + this.cboBuilding.Text;
          }
          else
            gClientProperty.RoomNo = this.cboRoomNo.Text;
        }
        else
          gClientProperty.RoomNo = this.cboRoomNo.Text;
      }
      else
        gClientProperty.RoomNo = this.cboCardType.Text == "Building Card" || this.cboCardType.Text == "Floor Card" || this.cboCardType.Text == "Region Card" || this.cboCardType.Text == "Region setting Card" ? (!(this.cboCardType.Text == "Building Card") ? (!(this.cboCardType.Text == "Floor Card") ? (this.cboCardType.Text == "Region Card" || this.cboCardType.Text == "Region setting Card" ? "Zn " + this.cboZoneNo.Text : " ") : "Fl " + this.cboFloorNo.Text) : "Bl " + this.cboBuilding.Text) : " ";
      gClientProperty.ClientType = this.cboCardType.Text.Substring(0, 2);
      gClientProperty.ClientID = this.txtClientID.Text;
      gClientProperty.ForeName = this.txtFirstName.Text;
      gClientProperty.SurName = this.txtSurName.Text;
      gClientProperty.Sex = this.cboSex.Text;
      gClientProperty.Contact = this.txtContact.Text;
      gClientProperty.Address = this.txtAddress.Text;
      gClientProperty.Country = this.cboCountry.Text;
      if (gCardProperty.LossLog == 0)
      {
        gClientProperty.ExtraKey = "0";
        gClientProperty.TransType = "A";
      }
      else
      {
        gClientProperty.ExtraKey = "2";
        gClientProperty.TransType = "L";
      }
      gClientProperty.People = "0";
      gClientProperty.ValidStart = this.dateTimePicker_ValidStart.Value.ToShortDateString();
      gClientProperty.ValidEnd = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
      gClientProperty.CheckInDate = DateTime.Now.ToShortDateString();
      gClientProperty.CheckInTime = this.mskCheckInTime.Text;
      gClientProperty.CheckOutTime = this.cboCardType.Text == "Room setting Card" || this.cboCardType.Text == "Times setting Card" ? this.mskSettingTime.Text : this.mskCheckInTime.Text;
      gClientProperty.LastRecDate = DateTime.Now.ToShortDateString();
    }

    private bool Check_Empty_Card()
    {
      try
      {
        if (SmartCard_Procedures.ReadCard_Information((int) Global_Data.COM_NUM))
        {
          int int32 = Convert.ToInt32(SmartCard_Procedures.Card_Information_String.Substring(2, 2));
          return int32 == 0 || int32 > 18;
        }
        int num = (int) MessageBox.Show("Not Empty Card!");
        return false;
      }
      catch
      {
        return false;
      }
    }

    private bool ClientAdd()
    {
      try
      {
        if (!new Issue_Card_Class()
        {
          Client_Row_Buffer = {
            Address = gClientProperty.Address,
            ClientID = gClientProperty.ClientID,
            ClientType = gClientProperty.ClientType,
            Contact = gClientProperty.Contact,
            Country = gClientProperty.Country,
            ForeName = gClientProperty.ForeName,
            Identity = gClientProperty.Identity,
            Nationality = gClientProperty.Nationality,
            Sex = gClientProperty.Sex,
            SurName = gClientProperty.SurName,
            Email = gClientProperty.Email,
            Update = false
          }
        }.Write_Client_Table())
        {
          int num = (int) MessageBox.Show("Write Failed! ClientAdd()");
          return false;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception Write Failed! ClientAdd()");
        return false;
      }
      return true;
    }

    private bool ClientAccountAdd()
    {
      try
      {
        Issue_Card_Class issueCardClass = new Issue_Card_Class();
        issueCardClass.ClientAcc_Row_Buffer.CardNo = gCardProperty.CardNo;
        issueCardClass.ClientAcc_Row_Buffer.ChargeType = gClientProperty.ChargeType;
        issueCardClass.ClientAcc_Row_Buffer.ClientID = gClientProperty.ClientID;
        issueCardClass.ClientAcc_Row_Buffer.Condition = gClientProperty.Condition;
        switch (Mod_UpdateData.sChkGuest)
        {
          case "N":
            issueCardClass.ClientAcc_Row_Buffer.Deposit = Convert.ToDecimal(gClientProperty.DEPOSIT);
            issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
            issueCardClass.ClientAcc_Row_Buffer.Bond = Convert.ToInt16(gClientProperty.People) != (short) 1 ? 0M : Convert.ToDecimal(gClientProperty.Bond);
            break;
          case "S":
            issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
            issueCardClass.ClientAcc_Row_Buffer.Deposit = 0M;
            issueCardClass.ClientAcc_Row_Buffer.Bond = 0M;
            break;
          default:
            issueCardClass.ClientAcc_Row_Buffer.Deposit = 0M;
            issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = 0M;
            issueCardClass.ClientAcc_Row_Buffer.Bond = 0M;
            break;
        }
        issueCardClass.ClientAcc_Row_Buffer.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
        issueCardClass.ClientAcc_Row_Buffer.NoOfPeople = Convert.ToByte(gClientProperty.People);
        issueCardClass.ClientAcc_Row_Buffer.OldRoom = (string) null;
        issueCardClass.ClientAcc_Row_Buffer.Remark = gClientProperty.Remark;
        issueCardClass.ClientAcc_Row_Buffer.RoomNo = gClientProperty.RoomNo;
        issueCardClass.ClientAcc_Row_Buffer.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd);
        issueCardClass.ClientAcc_Row_Buffer.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
        if (Mod_UpdateData.sChkGuest != "A")
        {
          issueCardClass.ClientAcc_Row_Buffer.AdvancedPayment = Convert.ToDecimal(gClientProperty.Advance);
          issueCardClass.ClientAcc_Row_Buffer.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
          issueCardClass.ClientAcc_Row_Buffer.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
        }
        else
        {
          issueCardClass.ClientAcc_Row_Buffer.AdvancedPayment = 0M;
          issueCardClass.ClientAcc_Row_Buffer.LastPayment = 0M;
          issueCardClass.ClientAcc_Row_Buffer.AmountPaid = 0M;
        }
        if (gClientProperty.BonusClaim != "0")
        {
          if (gClientProperty.BonusDate != "")
          {
            issueCardClass.ClientAcc_Row_Buffer.BonusDate = gClientProperty.BonusDate;
            issueCardClass.ClientAcc_Row_Buffer.CheckInDate = !ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready ? gCardProperty.CheckInDate : DateTime.Parse(gClientProperty.BonusDate);
          }
        }
        else
          issueCardClass.ClientAcc_Row_Buffer.CheckInDate = gCardProperty.CheckInDate;
        issueCardClass.ClientAcc_Row_Buffer.CheckOutTime = DateTime.Parse("1899-12-30 " + gClientProperty.CheckOutTime);
        issueCardClass.ClientAcc_Row_Buffer.CheckInTime = DateTime.Parse("1899-12-30 " + gCardProperty.CheckInTime.ToShortTimeString());
        issueCardClass.ClientAcc_Row_Buffer.CheckOutDate = gCardProperty.CheckOutDate;
        issueCardClass.ClientAcc_Row_Buffer.RmPriceAdjust = gClientProperty.RmPrice;
        issueCardClass.ClientAcc_Row_Buffer.Update = gClientProperty.Update;
        issueCardClass.ClientAcc_Row_Buffer.LastRecDate = DateTime.Parse(gClientProperty.LastRecDate);
        issueCardClass.ClientAcc_Row_Buffer.RoomNo = !(Mod_UpdateData.sChkGuest != "A") ? (!(Mod_UpdateData.sChkGuest == "A") || !(gCardProperty.CardType == "Emergency") && !(gCardProperty.CardType == "RoomCard") ? " " : (!(gClientProperty.RoomNo != "") ? " " : gClientProperty.RoomNo)) : (!(gClientProperty.RoomNo != "") ? " " : gClientProperty.RoomNo);
        if (!issueCardClass.Write_ClientAcc_Table())
        {
          int num = (int) MessageBox.Show("Write Failed! ClientAccountAdd()");
          return false;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception Write Failed! ClientAccountAdd()");
        return false;
      }
      return true;
    }

    private bool UpdateData()
    {
      Mod_UpdateData.sChkGuest = "A";
      if (gCardProperty.LossLog == 1)
      {
        Mod_UpdateData.sChkCardNo = this.txtCardNo.Text;
        if (!this.Check_Empty_Card())
          return false;
        if (!this.db.CardDataUpdate(Mod_UpdateData.sChkCardNo, gClientProperty.Card_AutoNumber, gClientProperty.Card_HW_ID))
        {
          int num = (int) MessageBox.Show("CardDataUpdate Failed!");
          return false;
        }
      }
      if (!this.IssueNewCard())
      {
        int num = (int) MessageBox.Show("Issue Failed!");
        return false;
      }
      if (this._optUser_0.Checked)
      {
        if (!this.ClientAdd() || !this.ClientAccountAdd())
          return false;
      }
      else
      {
        if (!this.db.ClientEdit(this.txtClientID.Text))
        {
          int num = (int) MessageBox.Show("ClientEdit() Failed!");
          return false;
        }
        if (!this.db.ClientAccountEdit(this.txtClientID.Text))
        {
          int num = (int) MessageBox.Show("ClientAccountEdit() Failed!");
          return false;
        }
      }
      Issue_Card_Class issueCardClass = new Issue_Card_Class();
      try
      {
        issueCardClass.CardTrans_Row_Buffer.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
        issueCardClass.CardTrans_Row_Buffer.ClientID = gClientProperty.ClientID;
        issueCardClass.CardTrans_Row_Buffer.CardNo = gClientProperty.CardNo;
        issueCardClass.CardTrans_Row_Buffer.CardType = gCardProperty.CardType;
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception 1 UpdateData()!");
        return false;
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.RoomNo = gClientProperty.RoomNo.Length > 0 ? gClientProperty.RoomNo : " ";
      }
      catch
      {
        issueCardClass.CardTrans_Row_Buffer.RoomNo = " ";
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.TransType = gClientProperty.TransType;
        issueCardClass.CardTrans_Row_Buffer.TransDate = DateTime.Now.Date;
        issueCardClass.CardTrans_Row_Buffer.TransTime = DateTime.Now.ToLongTimeString();
        issueCardClass.CardTrans_Row_Buffer.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
        issueCardClass.CardTrans_Row_Buffer.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd);
        issueCardClass.CardTrans_Row_Buffer.CheckInTime = gCardProperty.CheckInTime.ToLongTimeString();
        issueCardClass.CardTrans_Row_Buffer.CheckOutDate = gCardProperty.CheckOutDate;
        issueCardClass.CardTrans_Row_Buffer.CheckOutTime = gCardProperty.CheckOutTime.ToLongTimeString();
        issueCardClass.CardTrans_Row_Buffer.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        issueCardClass.CardTrans_Row_Buffer.Update = false;
        if (!issueCardClass.Write_CardTrans_Table())
          return false;
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception 2 UpdateData()!");
        return false;
      }
      int num1 = (int) MessageBox.Show(gCardProperty.CardType + " Card Successfully Issued !");
      this.Refresh();
      return true;
    }

    private bool Make_Other_Cards(string para_CardType)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      string str1 = "DE";
      string str2 = "DE";
      string str3 = "DE";
      string str4 = "DE";
      string str5 = "DE";
      string str6 = "DE";
      string str7 = "08001600";
      Global_Data.Check_COM_Port_Num();
      if (this.cboBuilding.Visible)
      {
        try
        {
          num1 = (int) Convert.ToInt16(this.cboBuilding.SelectedItem);
        }
        catch
        {
          int num5 = (int) MessageBox.Show("Pls. Insert Valid Building number!");
          return false;
        }
      }
      if (this.cboFloorNo.Visible)
      {
        try
        {
          num2 = (int) Convert.ToInt16((string) this.cboFloorNo.SelectedItem);
        }
        catch
        {
          int num6 = (int) MessageBox.Show("Pls. Insert Valid Floor Number!");
          return false;
        }
      }
      if (this.cboRoomNo.Visible)
      {
        try
        {
          string selectedItem = (string) this.cboRoomNo.SelectedItem;
          num3 = (int) Convert.ToInt16(selectedItem.Substring(3, 2));
          num2 = (int) Convert.ToInt16(selectedItem.Substring(1, 2));
        }
        catch
        {
          int num7 = (int) MessageBox.Show("Pls. Insert Valid Room number!");
          return false;
        }
      }
      else if (this.cboZoneNo.Visible)
      {
        try
        {
          num4 = (int) Convert.ToInt16((string) this.cboZoneNo.SelectedItem);
        }
        catch
        {
          int num8 = (int) MessageBox.Show("Pls. Insert Valid Area_Region Number!");
          return false;
        }
      }
      switch (para_CardType)
      {
        case "Room setting Card":
          if (Global_Data.System_Pas_String.Length > 4)
          {
            if (this.radio_RoomSet.Checked)
            {
              string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + num2.ToString("D2") + num3.ToString("D2") + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
              if (SmartCard_Procedures.Make_RoomSettings_Card((int) Global_Data.COM_NUM, para_string))
                return true;
              break;
            }
            if (this.radio_FloorSet.Checked)
            {
              string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + num2.ToString("D2") + "F9" + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
              if (SmartCard_Procedures.Make_RoomSettings_Card((int) Global_Data.COM_NUM, para_string))
                return true;
              break;
            }
            if (this.radio_BuildingSet.Checked)
            {
              string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + "DEF8" + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
              if (SmartCard_Procedures.Make_RoomSettings_Card((int) Global_Data.COM_NUM, para_string))
                return true;
              break;
            }
            break;
          }
          break;
        case "Acquisition Card":
          if (SmartCard_Procedures.Make_Acquisition_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Region Card":
          string para_string2_1 = num1.ToString("D2") + num4.ToString("D2") + str6 + this.dateTimePicker_ValidStart.Text.Substring(2, 2) + this.dateTimePicker_ValidStart.Text.Substring(5, 2) + this.dateTimePicker_ValidStart.Text.Substring(8, 2) + this.mskCheckInTime.Text.Substring(0, 2) + this.mskCheckInTime.Text.Substring(3, 2) + this.dateTimePicker_ValidEnd.Text.Substring(2, 2) + this.dateTimePicker_ValidEnd.Text.Substring(5, 2) + this.dateTimePicker_ValidEnd.Text.Substring(8, 2) + this.mskCheckOutTime.Text.Substring(0, 2) + this.mskCheckOutTime.Text.Substring(3, 2) + str7;
          if (SmartCard_Procedures.Make_AreaRegion_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, para_string2_1))
            return true;
          break;
        case "Building Card":
          if (SmartCard_Procedures.Make_Building_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, num1.ToString("D2")))
            return true;
          break;
        case "Chief Card":
          if (SmartCard_Procedures.Make_Chief_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Cleared Card":
          if (SmartCard_Procedures.Make_Clean_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Emergency Card":
          if (SmartCard_Procedures.Make_Emergency_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Floor Card":
          string para_string1 = Global_Data.System_Pas_String + num1.ToString("D2") + num2.ToString("D2") + str1 + str2 + str3 + str4 + str5 + this.dateTimePicker_ValidStart.Text.Substring(2, 2) + this.dateTimePicker_ValidStart.Text.Substring(5, 2) + this.dateTimePicker_ValidStart.Text.Substring(8, 2) + "0101" + this.dateTimePicker_ValidEnd.Text.Substring(2, 2) + this.dateTimePicker_ValidEnd.Text.Substring(5, 2) + this.dateTimePicker_ValidEnd.Text.Substring(8, 2) + "3590" + this.mskCheckInTime.Text.Substring(0, 2) + this.mskCheckInTime.Text.Substring(3, 2) + this.mskCheckOutTime.Text.Substring(0, 2) + this.mskCheckOutTime.Text.Substring(3, 2);
          if (SmartCard_Procedures.Make_Floor_Card((int) Global_Data.COM_NUM, para_string1))
            return true;
          break;
        case "Guest Card limit":
          if (SmartCard_Procedures.Make_LimitGuest_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Limited room Card":
          if (SmartCard_Procedures.Make_LimitedRoom_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, num1.ToString("D2"), num2.ToString("D2"), num3.ToString("D2")))
            return true;
          break;
        case "Loss Card":
          if (SmartCard_Procedures.Make_Loss_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, Global_Data.Card_HW_ID))
            return true;
          break;
        case "Loss recovery Card":
          if (SmartCard_Procedures.Make_LossRecovery_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, Global_Data.Card_HW_ID))
            return true;
          break;
        case "Recovery room Card":
          if (SmartCard_Procedures.Make_RecoveryRoom_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, num1.ToString("D2"), num2.ToString("D2"), num3.ToString("D2")))
            return true;
          break;
        case "Region setting Card":
          if (SmartCard_Procedures.Make_RegionSetting_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, num4.ToString("D2")))
            return true;
          break;
        case "Spare Card":
          if (SmartCard_Procedures.Make_Spare_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
            return true;
          break;
        case "Times setting Card":
          string para_string2_2 = this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
          if (SmartCard_Procedures.Make_Time_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String, para_string2_2))
            return true;
          break;
        default:
          if (para_CardType.Contains("OtherRooms") || para_CardType.Contains("Emergency"))
          {
            string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + num2.ToString("D2") + num3.ToString("D2") + this.dateTimePicker_ValidStart.Text.Substring(2, 2) + this.dateTimePicker_ValidStart.Text.Substring(5, 2) + this.dateTimePicker_ValidStart.Text.Substring(8, 2) + gClientProperty.CheckInTime.Substring(0, 2) + gClientProperty.CheckInTime.Substring(3, 2) + this.dateTimePicker_ValidEnd.Text.Substring(2, 2) + this.dateTimePicker_ValidEnd.Text.Substring(5, 2) + this.dateTimePicker_ValidEnd.Text.Substring(8, 2) + gClientProperty.CheckOutTime.Substring(0, 2) + gClientProperty.CheckOutTime.Substring(3, 2) + "DEDEDEDE";
            if (SmartCard_Procedures.Make_Guest_Card((int) Global_Data.COM_NUM, para_string))
              return true;
            break;
          }
          int num9 = (int) MessageBox.Show("Not Implemented!");
          return false;
      }
      return false;
    }

    private bool IssueNewCard()
    {
      if (gCardProperty.LossLog != 1)
      {
        if (!this.Check_Empty_Card())
          return false;
      }
      else
      {
        int num1 = (int) MessageBox.Show("Loss Replacement Card!");
      }
      try
      {
        if (this.Make_Other_Cards(this.cboCardType.Text))
        {
          if (!SmartCard_Procedures.ReadCardNumber((int) Global_Data.COM_NUM))
            return false;
          Global_Data.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
        }
        else
        {
          int num2 = (int) MessageBox.Show("Write Failed!");
          return false;
        }
      }
      catch (Exception e)
      {
        int num3 = (int) MessageBox.Show("Write Failed! Make_Other_Cards() !" + e.Message);
        return false;
      }
      try
      {
        Issue_Card_Class issueCardClass = new Issue_Card_Class();
        issueCardClass.CardNo_Row_Buffer.CardNo = gCardProperty.CardNo;
        issueCardClass.CardNo_Row_Buffer.CardStatus = Convert.ToByte(gClientProperty.ExtraKey);
        issueCardClass.CardNo_Row_Buffer.CardType = gCardProperty.CardType;
        issueCardClass.CardNo_Row_Buffer.ClientID = gClientProperty.ClientID;
        if (gClientProperty.KeyDeposit != "0")
          issueCardClass.CardNo_Row_Buffer.KeyCharge = Convert.ToDecimal(gClientProperty.KeyDeposit);
        else if (gClientProperty.TransType == "NE")
          issueCardClass.CardNo_Row_Buffer.KeyCharge = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giExtraKeyCharge);
        issueCardClass.CardNo_Row_Buffer.RecordDate = DateTime.Parse(gClientProperty.LastRecDate);
        issueCardClass.CardNo_Row_Buffer.RecordTime = DateTime.Now.ToShortTimeString();
        issueCardClass.CardNo_Row_Buffer.RoomNo = gClientProperty.RoomNo;
        issueCardClass.CardNo_Row_Buffer.Update = gClientProperty.Update;
        issueCardClass.CardNo_Row_Buffer.Card_AutoNumber = Global_Data.Card_AutoNumber;
        issueCardClass.CardNo_Row_Buffer.Card_HW_ID = Global_Data.Card_HW_ID;
        issueCardClass.CardNo_Row_Buffer.ReaderID = Global_Data.Card_Reader_ID;
        if (!issueCardClass.Write_CardNo_Table())
        {
          int num4 = (int) MessageBox.Show("Write_CardNo_Table() Failed!");
          return false;
        }
      }
      catch
      {
        int num5 = (int) MessageBox.Show("Exception Write_CardNo_Table() Failed!");
        return false;
      }
      return true;
    }

    private bool IssueCardRoutine()
    {
      this.GetCardPropertyValue();
      this.GetClientPropertyData();
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sCardSerialNo = this.txtCardNo.Text;
      int newTransId = this.db.GetNew_TransID(this.cboBuilding.Text);
      if (newTransId == -1)
      {
        int num = (int) MessageBox.Show("Can't Get TransID!");
        return false;
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
      bool flag = this.db.Backup_Before_Transact((string) this.cboBuilding.SelectedItem);
      if (this.UpdateData())
        return true;
      if (flag)
        this.db.Restore_For_FailedTransact((string) this.cboBuilding.SelectedItem);
      return false;
    }

    private void cmdIssue_Click(object sender, EventArgs e)
    {
      if (this.cboRoomNo.Visible && this.cboRoomNo.Text.Length <= 0)
      {
        int num1 = (int) MessageBox.Show("No Room No. Found!");
      }
      else if (!Global_Data.Card_Reader_Found_Flag)
      {
        int num2 = (int) MessageBox.Show("Card Reader Not Found!");
      }
      else
      {
        if (MessageBox.Show("Are you sure issuing  ' " + this.cboCardType.Text + " ' ?   \r\nPlease comfirm Yes/No ", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.Refresh();
        if (SmartCard_Procedures.ReadCardID((int) Global_Data.COM_NUM))
        {
          Global_Data.Card_HW_ID = SmartCard_Procedures.Card_ID_String;
          this.lblMessage.ForeColor = ColorTranslator.FromOle((int) byte.MaxValue);
          this.lblMessage.Text = "Please wait, Writing Data to Key Card .....";
          this.lblMessage.ForeColor = ColorTranslator.FromOle((int) byte.MaxValue);
          this.lblMessage.Refresh();
          this.lblMsgFunction2.Text = "";
          if (!this.CheckNoOfDays())
            return;
          if (this.IssueCardRoutine())
          {
            this.lblMessage.Text = "Admin Card Successfully Issued!";
            this.lblMessage.Refresh();
            Thread.Sleep(500);
            this._optUser_0.Checked = true;
            this.Clear_Info_Screen();
            this.cmdViewClient.Enabled = false;
            this.Check_ForNewUser();
            this.lblMessage.Text = "";
          }
          else
          {
            this.lblMessage.Text = "Admin Card Issue Failed!";
            this.lblMessage.Refresh();
            Thread.Sleep(500);
            this.lblMessage.Text = "";
          }
          this.lblMessage.Text = "";
        }
        else
        {
          int num3 = (int) MessageBox.Show("No Card Found!");
        }
      }
    }

    private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtSurName.Focus();
    }

    private void txtSurName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtIdentity.Focus();
    }

    private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtContact.Focus();
    }

    private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtAddress.Focus();
    }

    private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtNationality.Focus();
    }

    private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.cboCountry.Focus();
    }

    private void cboCountry_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r')
        this.txtRemark.Focus();
      e.Handled = true;
    }

    private void cboRoomType_Others_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Init_Room_For_RoomType((string) this.cboRoomType_Others.SelectedItem);
    }

    private void cboFloorNo_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.cboFloorNo.Visible || !this.RoomFrame.Visible)
        return;
      this.Init_Room_For_SelectedFloor(Convert.ToByte((string) this.cboFloorNo.SelectedItem).ToString("D2"));
    }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
            ModDoorLockSystem.Form_OperationDMS_Ptr.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1) Get the 'start' values from the first row
            int startBuilding = int.Parse(comboBox1.SelectedItem.ToString());
            int startFloor = int.Parse(comboBox2.SelectedItem.ToString());
            int startRoom = int.Parse(comboBox3.SelectedItem.ToString());

            // 2) Determine the 'end' values
            int endBuilding, endFloor, endRoom;
            if (checkBoxSingleCard.Checked)
            {
                // Single card = end same as start
                endBuilding = startBuilding;
                endFloor = startFloor;
                endRoom = startRoom;
            }
            else
            {
                // Get the second row for the 'end' values
                endBuilding = int.Parse(comboBox4.SelectedItem.ToString());
                endFloor = int.Parse(comboBox5.SelectedItem.ToString());
                endRoom = int.Parse(comboBox6.SelectedItem.ToString());
            }

            // 3) Convert start/end building-floor-room to numeric strings of the format BBBFFRR
            //    e.g., Building=1, Floor=9, Room=5 => "10905"
            //    (Depending on the building number width, adjust the zero-padding if needed)
            string startString = startBuilding.ToString()
                                 + startFloor.ToString("D2")
                                 + startRoom.ToString("D2");
            string endString = endBuilding.ToString()
                                 + endFloor.ToString("D2")
                                 + endRoom.ToString("D2");

            int startNumber = int.Parse(startString);
            int endNumber = int.Parse(endString);

            // 4) Loop from 'startNumber' to 'endNumber'
            for (int n = startNumber; n <= endNumber; n++)
            {
                // Example: n=10503 => Building=1, Floor=05, Room=03
                // Let's parse them out again:
                //    num1 => building
                //    num2 => floor
                //    num3 => room
                string nString = n.ToString(); // e.g. "10503"

                // Make sure your building is 1 digit. If building can be more than 1 digit,
                // you may need to adjust substring indexes. For now, assume building is 1 digit:
                int num1 = int.Parse(nString.Substring(0, 1));   // building
                int num2 = int.Parse(nString.Substring(1, 2));   // floor
                int num3 = int.Parse(nString.Substring(3, 2));   // room

                // Validate room/floor if needed
               /* if (!(num3 <= (int)floorRoomCounts[num2]))
                {
                    // If room is out of range for this floor, skip
                    continue;
                }
               */
                // If room=0, skip
                if (num3 == 0) continue;

                // Attempt to make an empty card
                if (!SmartCard_Procedures.Make_Empty_Card((int)Global_Data.COM_NUM, Global_Data.System_Pas_String))
                {
                    MessageBox.Show("FAILURE report to andy!");
                    // Decide if you want to 'continue' or break here
                    continue;
                }

                // Build up the parameter string (para_string) as in your original code
                string para_string =
                    Global_Data.System_Pas_String
                    + num1.ToString("D2")
                    + num2.ToString("D2")
                    + num3.ToString("D2")
                    + dateTimePicker_SettingDate.Text.Substring(2, 2)
                    + dateTimePicker_SettingDate.Text.Substring(5, 2)
                    + dateTimePicker_SettingDate.Text.Substring(8, 2)
                    + mskSettingTime.Text.Substring(0, 2)
                    + mskSettingTime.Text.Substring(3, 2);

                // Make the RoomSettings card
                if (SmartCard_Procedures.Make_RoomSettings_Card((int)Global_Data.COM_NUM, para_string))
                {
                    MessageBox.Show("Success: " + n);
                }
                else
                {
                    MessageBox.Show("Failure: " + n);
                }
            }
        }

        private void txtRoomFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!SmartCard_Procedures.Make_Empty_Card((int)Global_Data.COM_NUM, Global_Data.System_Pas_String))
            {
                int num24 = (int)MessageBox.Show("FAILURE report to andy!");
            }
            int num3 = (int)MessageBox.Show("Make Empty Card Success!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string buildingAndFloor = buildingValue.Text;
            if (buildingAndFloor.Length != 1)
            {
                int aaa = (int)MessageBox.Show("Failure: " + buildingAndFloor);
                return;
            }
            int num1 = int.Parse(buildingAndFloor.Substring(0, 1)); //4;//build #
            //int num2 = int.Parse(buildingAndFloor.Substring(1, 2)); ;//flr #
            //int num3 = int.Parse(Convert.ToString(n).Substring(3, 2));// rm#
            string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + "DEF8" + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
            if (SmartCard_Procedures.Make_RoomSettings_Card((int)Global_Data.COM_NUM, para_string))
            {
                int aaa = (int)MessageBox.Show("Success: " + buildingAndFloor);
                //success
            }
            else
            {
                int aaa = (int)MessageBox.Show("Failure: " + buildingAndFloor);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string buildingAndFloor = txtFloorBuildingValue.Text;
            if (buildingAndFloor.Length != 3)
            {
                int aaa = (int)MessageBox.Show("Failure: " + buildingAndFloor);
                return;
            }
            int num1 = int.Parse(buildingAndFloor.Substring(0, 1)); //401;//build #
            int num2 = int.Parse(buildingAndFloor.Substring(1, 2)); ;//flr #
            //int num3 = int.Parse(Convert.ToString(n).Substring(3, 2));// rm#
            string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + num2.ToString("D2") + "F9" + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
            if (SmartCard_Procedures.Make_RoomSettings_Card((int)Global_Data.COM_NUM, para_string))
            {
                int aaa = (int)MessageBox.Show("Success: " + buildingAndFloor);
                //success
            }
            else
            {
                int aaa = (int)MessageBox.Show("Failure: " + buildingAndFloor);
            }
        }



        private void dateTimePicker_SettingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mskSettingTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbIssueCardHeader_Click(object sender, EventArgs e)
        {

        }

        private void cboBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curFloor = Convert.ToInt32(comboBox2.Text);
            PopulateComboBox3(floorRoomCounts[curFloor]);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curFloor = Convert.ToInt32(comboBox5.Text);
            PopulateComboBox6(floorRoomCounts[curFloor]);
        }*/
        private void PopulateComboBox3WithRange(int start, int end)
        {
            comboBox3.Items.Clear();
            for (int room = start; room <= end; room++)
            {
                comboBox3.Items.Add($"{room}");
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
        }

        // Event handler for when the selected floor changes
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedFloor))
            {
                if (floorRoomRanges[selectedFloor] != null)
                {
                    PopulateComboBox3WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
                }
                else
                {
                    comboBox3.Items.Clear();
                }
            }
        }

        // Similarly for comboBox5
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null && int.TryParse(comboBox5.SelectedItem.ToString(), out int selectedFloor))
            {
                if (floorRoomRanges[selectedFloor] != null)
                {
                    PopulateComboBox6WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
                }
                else
                {
                    comboBox6.Items.Clear();
                }
            }
        }

        // Helper method to populate comboBox6 with a range of room numbers
        private void PopulateComboBox6WithRange(int start, int end)
        {
            comboBox6.Items.Clear();
            for (int room = start; room <= end; room++)
            {
                comboBox6.Items.Add($"{room}");
            }
            if (comboBox6.Items.Count > 0)
            {
                comboBox6.SelectedIndex = 0;
            }
        }

        private void GroupBox_DoorTypeChoice_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxSingleCard_CheckedChanged(object sender, EventArgs e)
        {
            // Disable/enable the second row based on checkbox state
            comboBox4.Enabled = !checkBoxSingleCard.Checked;
            comboBox5.Enabled = !checkBoxSingleCard.Checked;
            comboBox6.Enabled = !checkBoxSingleCard.Checked;

            // If you have date pickers for the end date, add them here
            // datePickerEnd.Enabled = !checkBoxSingleCard.Checked;
        }
    }
}
