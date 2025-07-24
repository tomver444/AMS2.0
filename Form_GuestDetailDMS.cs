// Decompiled with JetBrains decompiler
// Type: AMS.Form_GuestDetailDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_GuestDetailDMS : Form
  {
    private IContainer components;
    public ComboBox cboBuildingNo;
    public ToolTip ToolTip1;
    public Label Label19;
    public ComboBox cboCountry;
    public Label Label18;
    public Button cmdClear;
    public Button cmdUpdate;
    public Button cmdEdit;
    public Label Label2;
    public TextBox txtAddress;
    public Label Label24;
    public TextBox txtContact;
    public TextBox txtNationality;
    public TextBox txtIdentity;
    public TextBox txtSurName;
    public TextBox txtFirstName;
    public Label Label25;
    public TextBox txtClientID;
    public Label Label27;
    public Label Label28;
    public TextBox txtRoomNo;
    public Label Label15;
    public Label Label13;
    public Label lblRoomStatus;
    public Label Label12;
    public Button cmdView;
    public Label Label17;
    public Label lblFloorNo;
    public Label Label16;
    public Timer Timer1;
    public MaskedTextBox mskContractStart;
    public MaskedTextBox mskContractEnd;
    public Button cmdReturn;
    public Label Label1;
    public Label Label11;
    public Label lblMessage;
    public Label Label10;
    public MaskedTextBox mskValidEnd;
    public Label Label9;
    public Label Label8;
    public Label _Label7_0;
    public Label Label6;
    public Label Label5;
    public Label Label4;
    public Label Label3;
    public GroupBox Frame3;
    public Label Label14;
    public Label lblReserveRefNo;
    public MaskedTextBox mskValidStart;
    public TextBox txtGracePeriod;
    public Panel Frame1;
    public TextBox txtRemark;
    public TextBox txtCardNo;
    public TextBox txtBuildingNo;
    public TextBox txtRoomType;
    public Label Data1;
    private ComboBox cboSex;
    public Label label7;
    public TextBox textBox_Email;
    private string sClientType = "";
    private DB db;
    public string Old_Client_ID = "";
    public bool Old_Client_OK_flag;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_GuestDetailDMS));
      this.cboBuildingNo = new ComboBox();
      this.Label19 = new Label();
      this.cboCountry = new ComboBox();
      this.Label18 = new Label();
      this.cmdClear = new Button();
      this.cmdUpdate = new Button();
      this.cmdEdit = new Button();
      this.Label2 = new Label();
      this.txtAddress = new TextBox();
      this.Label24 = new Label();
      this.txtContact = new TextBox();
      this.txtNationality = new TextBox();
      this.txtIdentity = new TextBox();
      this.txtSurName = new TextBox();
      this.txtFirstName = new TextBox();
      this.Label25 = new Label();
      this.txtClientID = new TextBox();
      this.Label27 = new Label();
      this.Label28 = new Label();
      this.txtRoomNo = new TextBox();
      this.Label15 = new Label();
      this.Label13 = new Label();
      this.lblRoomStatus = new Label();
      this.Label12 = new Label();
      this.cmdView = new Button();
      this.Label17 = new Label();
      this.lblFloorNo = new Label();
      this.Label16 = new Label();
      this.Timer1 = new Timer(this.components);
      this.ToolTip1 = new ToolTip(this.components);
      this.mskContractStart = new MaskedTextBox();
      this.mskContractEnd = new MaskedTextBox();
      this.cmdReturn = new Button();
      this.textBox_Email = new TextBox();
      this.Label1 = new Label();
      this.Label11 = new Label();
      this.lblMessage = new Label();
      this.Label10 = new Label();
      this.mskValidEnd = new MaskedTextBox();
      this.Label9 = new Label();
      this.Label8 = new Label();
      this._Label7_0 = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Frame3 = new GroupBox();
      this.label7 = new Label();
      this.cboSex = new ComboBox();
      this.Label14 = new Label();
      this.lblReserveRefNo = new Label();
      this.mskValidStart = new MaskedTextBox();
      this.txtGracePeriod = new TextBox();
      this.Frame1 = new Panel();
      this.txtRemark = new TextBox();
      this.txtCardNo = new TextBox();
      this.txtBuildingNo = new TextBox();
      this.txtRoomType = new TextBox();
      this.Data1 = new Label();
      this.Frame3.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this.cboBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(112, 16);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 26);
      this.cboBuildingNo.TabIndex = 55;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building No.");
      this.cboBuildingNo.KeyPress += new KeyPressEventHandler(this.cboBuildingNo_KeyPress);
      this.Label19.BackColor = Color.Yellow;
      this.Label19.Cursor = Cursors.Default;
      this.Label19.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = SystemColors.ControlText;
      this.Label19.Location = new Point(32, 128);
      this.Label19.Name = "Label19";
      this.Label19.RightToLeft = RightToLeft.No;
      this.Label19.Size = new Size(81, 17);
      this.Label19.TabIndex = 15;
      this.Label19.Text = "Grace Period";
      this.Label19.TextAlign = ContentAlignment.TopRight;
      this.cboCountry.BackColor = SystemColors.Window;
      this.cboCountry.Cursor = Cursors.Default;
      this.cboCountry.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboCountry.ForeColor = SystemColors.WindowText;
      this.cboCountry.Location = new Point(400, 176);
      this.cboCountry.Name = "cboCountry";
      this.cboCountry.RightToLeft = RightToLeft.No;
      this.cboCountry.Size = new Size(153, 24);
      this.cboCountry.TabIndex = 40;
      this.ToolTip1.SetToolTip((Control) this.cboCountry, "Country");
      this.Label18.BackColor = Color.Yellow;
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(296, 64);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(89, 17);
      this.Label18.TabIndex = 16;
      this.Label18.Text = "Contract End";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.cmdClear.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Image = (Image) componentResourceManager.GetObject("cmdClear.Image");
      this.cmdClear.Location = new Point(696, 144);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(57, 65);
      this.cmdClear.TabIndex = 53;
      this.cmdClear.Text = "&Clear";
      this.cmdClear.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "Click to Clear Screen");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.cmdUpdate.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdUpdate.Cursor = Cursors.Default;
      this.cmdUpdate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdUpdate.ForeColor = SystemColors.ControlText;
      this.cmdUpdate.Image = (Image) componentResourceManager.GetObject("cmdUpdate.Image");
      this.cmdUpdate.Location = new Point(632, 144);
      this.cmdUpdate.Name = "cmdUpdate";
      this.cmdUpdate.RightToLeft = RightToLeft.No;
      this.cmdUpdate.Size = new Size(57, 65);
      this.cmdUpdate.TabIndex = 52;
      this.cmdUpdate.Text = "&Update";
      this.cmdUpdate.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdUpdate, "Confirm to Update Info");
      this.cmdUpdate.UseVisualStyleBackColor = false;
      this.cmdUpdate.Click += new EventHandler(this.cmdUpdate_Click);
      this.cmdEdit.BackColor = Color.FromArgb(0, 128, 0);
      this.cmdEdit.Cursor = Cursors.Default;
      this.cmdEdit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdEdit.ForeColor = SystemColors.ControlText;
      this.cmdEdit.Image = (Image) componentResourceManager.GetObject("cmdEdit.Image");
      this.cmdEdit.Location = new Point(568, 144);
      this.cmdEdit.Name = "cmdEdit";
      this.cmdEdit.RightToLeft = RightToLeft.No;
      this.cmdEdit.Size = new Size(57, 65);
      this.cmdEdit.TabIndex = 51;
      this.cmdEdit.Text = "&Edit";
      this.cmdEdit.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdEdit, "Click to Enable Edit");
      this.cmdEdit.UseVisualStyleBackColor = false;
      this.cmdEdit.Click += new EventHandler(this.cmdEdit_Click);
      this.Label2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(7, 41);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(777, 33);
      this.Label2.TabIndex = 36;
      this.Label2.Text = "SEARCH /EDIT GUEST DATA WITHOUT CARD";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.txtAddress.AcceptsReturn = true;
      this.txtAddress.BackColor = SystemColors.Window;
      this.txtAddress.Cursor = Cursors.IBeam;
      this.txtAddress.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAddress.ForeColor = SystemColors.WindowText;
      this.txtAddress.Location = new Point(112, 144);
      this.txtAddress.MaxLength = 50;
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.RightToLeft = RightToLeft.No;
      this.txtAddress.Size = new Size(180, 49);
      this.txtAddress.TabIndex = 38;
      this.ToolTip1.SetToolTip((Control) this.txtAddress, "Address");
      this.Label24.BackColor = Color.Yellow;
      this.Label24.Cursor = Cursors.Default;
      this.Label24.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = SystemColors.ControlText;
      this.Label24.Location = new Point(16, 96);
      this.Label24.Name = "Label24";
      this.Label24.RightToLeft = RightToLeft.No;
      this.Label24.Size = new Size(97, 17);
      this.Label24.TabIndex = 14;
      this.Label24.Text = "Valid Start Date";
      this.Label24.TextAlign = ContentAlignment.TopRight;
      this.txtContact.AcceptsReturn = true;
      this.txtContact.BackColor = SystemColors.Window;
      this.txtContact.Cursor = Cursors.IBeam;
      this.txtContact.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtContact.ForeColor = SystemColors.WindowText;
      this.txtContact.Location = new Point(400, 144);
      this.txtContact.MaxLength = 0;
      this.txtContact.Name = "txtContact";
      this.txtContact.ReadOnly = true;
      this.txtContact.RightToLeft = RightToLeft.No;
      this.txtContact.Size = new Size(153, 20);
      this.txtContact.TabIndex = 39;
      this.ToolTip1.SetToolTip((Control) this.txtContact, "Contact No.");
      this.txtNationality.AcceptsReturn = true;
      this.txtNationality.BackColor = SystemColors.Window;
      this.txtNationality.Cursor = Cursors.IBeam;
      this.txtNationality.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNationality.ForeColor = SystemColors.WindowText;
      this.txtNationality.Location = new Point(400, 112);
      this.txtNationality.MaxLength = 0;
      this.txtNationality.Name = "txtNationality";
      this.txtNationality.ReadOnly = true;
      this.txtNationality.RightToLeft = RightToLeft.No;
      this.txtNationality.Size = new Size(153, 20);
      this.txtNationality.TabIndex = 37;
      this.ToolTip1.SetToolTip((Control) this.txtNationality, "Nationality");
      this.txtIdentity.AcceptsReturn = true;
      this.txtIdentity.BackColor = SystemColors.Window;
      this.txtIdentity.Cursor = Cursors.IBeam;
      this.txtIdentity.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIdentity.ForeColor = SystemColors.WindowText;
      this.txtIdentity.Location = new Point(112, 112);
      this.txtIdentity.MaxLength = 0;
      this.txtIdentity.Name = "txtIdentity";
      this.txtIdentity.ReadOnly = true;
      this.txtIdentity.RightToLeft = RightToLeft.No;
      this.txtIdentity.Size = new Size(153, 20);
      this.txtIdentity.TabIndex = 36;
      this.ToolTip1.SetToolTip((Control) this.txtIdentity, "Passport No");
      this.txtSurName.AcceptsReturn = true;
      this.txtSurName.BackColor = SystemColors.Window;
      this.txtSurName.Cursor = Cursors.IBeam;
      this.txtSurName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSurName.ForeColor = SystemColors.WindowText;
      this.txtSurName.Location = new Point(400, 80);
      this.txtSurName.MaxLength = 0;
      this.txtSurName.Name = "txtSurName";
      this.txtSurName.ReadOnly = true;
      this.txtSurName.RightToLeft = RightToLeft.No;
      this.txtSurName.Size = new Size(153, 20);
      this.txtSurName.TabIndex = 34;
      this.ToolTip1.SetToolTip((Control) this.txtSurName, "Guest's SurName");
      this.txtFirstName.AcceptsReturn = true;
      this.txtFirstName.BackColor = SystemColors.Window;
      this.txtFirstName.Cursor = Cursors.IBeam;
      this.txtFirstName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFirstName.ForeColor = SystemColors.WindowText;
      this.txtFirstName.Location = new Point(112, 80);
      this.txtFirstName.MaxLength = 0;
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.ReadOnly = true;
      this.txtFirstName.RightToLeft = RightToLeft.No;
      this.txtFirstName.Size = new Size(153, 20);
      this.txtFirstName.TabIndex = 33;
      this.ToolTip1.SetToolTip((Control) this.txtFirstName, "Guest's First Name");
      this.Label25.BackColor = Color.Yellow;
      this.Label25.Cursor = Cursors.Default;
      this.Label25.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = SystemColors.ControlText;
      this.Label25.Location = new Point(296, 96);
      this.Label25.Name = "Label25";
      this.Label25.RightToLeft = RightToLeft.No;
      this.Label25.Size = new Size(89, 17);
      this.Label25.TabIndex = 13;
      this.Label25.Text = "Valid End Date";
      this.Label25.TextAlign = ContentAlignment.TopRight;
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.Blue;
      this.txtClientID.Location = new Point(400, 48);
      this.txtClientID.MaxLength = 0;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.ReadOnly = true;
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(113, 20);
      this.txtClientID.TabIndex = 32;
      this.Label27.BackColor = Color.Yellow;
      this.Label27.Cursor = Cursors.Default;
      this.Label27.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label27.ForeColor = SystemColors.ControlText;
      this.Label27.Location = new Point(32, 160);
      this.Label27.Name = "Label27";
      this.Label27.RightToLeft = RightToLeft.No;
      this.Label27.Size = new Size(81, 17);
      this.Label27.TabIndex = 12;
      this.Label27.Text = "Note: ";
      this.Label27.TextAlign = ContentAlignment.TopRight;
      this.Label28.BackColor = Color.Yellow;
      this.Label28.Cursor = Cursors.Default;
      this.Label28.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = SystemColors.ControlText;
      this.Label28.Location = new Point(296, 32);
      this.Label28.Name = "Label28";
      this.Label28.RightToLeft = RightToLeft.No;
      this.Label28.Size = new Size(89, 17);
      this.Label28.TabIndex = 11;
      this.Label28.Text = "Card No.";
      this.Label28.TextAlign = ContentAlignment.TopRight;
      this.txtRoomNo.AcceptsReturn = true;
      this.txtRoomNo.BackColor = SystemColors.Window;
      this.txtRoomNo.Cursor = Cursors.IBeam;
      this.txtRoomNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.ForeColor = Color.Blue;
      this.txtRoomNo.Location = new Point(112, 48);
      this.txtRoomNo.MaxLength = 5;
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.ReadOnly = true;
      this.txtRoomNo.RightToLeft = RightToLeft.No;
      this.txtRoomNo.Size = new Size(65, 22);
      this.txtRoomNo.TabIndex = 31;
      this.ToolTip1.SetToolTip((Control) this.txtRoomNo, "Room No");
      this.Label15.BackColor = Color.Yellow;
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = SystemColors.ControlText;
      this.Label15.Location = new Point(296, 0);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(89, 17);
      this.Label15.TabIndex = 23;
      this.Label15.Text = "Room Status ";
      this.Label15.TextAlign = ContentAlignment.TopRight;
      this.Label13.BackColor = Color.Yellow;
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.ControlText;
      this.Label13.Location = new Point(32, 32);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(81, 17);
      this.Label13.TabIndex = 22;
      this.Label13.Text = "Level No. ";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.lblRoomStatus.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblRoomStatus.Cursor = Cursors.Default;
      this.lblRoomStatus.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomStatus.ForeColor = Color.White;
      this.lblRoomStatus.Location = new Point(400, 0);
      this.lblRoomStatus.Name = "lblRoomStatus";
      this.lblRoomStatus.RightToLeft = RightToLeft.No;
      this.lblRoomStatus.Size = new Size(153, 25);
      this.lblRoomStatus.TabIndex = 21;
      this.Label12.BackColor = Color.Yellow;
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(32, 0);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(81, 17);
      this.Label12.TabIndex = 18;
      this.Label12.Text = "Building No. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.cmdView.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.cmdView.Cursor = Cursors.Default;
      this.cmdView.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdView.ForeColor = SystemColors.ControlText;
      this.cmdView.Image = (Image) componentResourceManager.GetObject("cmdView.Image");
      this.cmdView.Location = new Point(192, 37);
      this.cmdView.Name = "cmdView";
      this.cmdView.RightToLeft = RightToLeft.No;
      this.cmdView.Size = new Size(73, 33);
      this.cmdView.TabIndex = 30;
      this.cmdView.Text = "Search";
      this.cmdView.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdView, "Click to View/Select Room");
      this.cmdView.UseVisualStyleBackColor = false;
      this.cmdView.Click += new EventHandler(this.cmdView_Click);
      this.Label17.BackColor = Color.Yellow;
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(32, 64);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 17;
      this.Label17.Text = "Contract Start";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.lblFloorNo.BackColor = Color.White;
      this.lblFloorNo.BorderStyle = BorderStyle.Fixed3D;
      this.lblFloorNo.Cursor = Cursors.Default;
      this.lblFloorNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFloorNo.ForeColor = Color.Blue;
      this.lblFloorNo.Location = new Point(120, 32);
      this.lblFloorNo.Name = "lblFloorNo";
      this.lblFloorNo.RightToLeft = RightToLeft.No;
      this.lblFloorNo.Size = new Size(49, 21);
      this.lblFloorNo.TabIndex = 10;
      this.lblFloorNo.TextAlign = ContentAlignment.TopCenter;
      this.Label16.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Red;
      this.Label16.Location = new Point(8, 16);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(89, 25);
      this.Label16.TabIndex = 56;
      this.Label16.Text = "Building ";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 500;
      this.mskContractStart.AllowPromptAsInput = false;
      this.mskContractStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractStart.ForeColor = Color.Blue;
      this.mskContractStart.Location = new Point(120, 64);
      this.mskContractStart.Mask = "####-##-##";
      this.mskContractStart.Name = "mskContractStart";
      this.mskContractStart.Size = new Size(81, 20);
      this.mskContractStart.TabIndex = 6;
      this.ToolTip1.SetToolTip((Control) this.mskContractStart, "Press any key to enter contract start date.");
      this.mskContractEnd.AllowPromptAsInput = false;
      this.mskContractEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractEnd.ForeColor = Color.Blue;
      this.mskContractEnd.Location = new Point(400, 64);
      this.mskContractEnd.Mask = "####-##-##";
      this.mskContractEnd.Name = "mskContractEnd";
      this.mskContractEnd.Size = new Size(81, 20);
      this.mskContractEnd.TabIndex = 7;
      this.ToolTip1.SetToolTip((Control) this.mskContractEnd, "Press any key to enter contract end date.");
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(679, 512);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(113, 39);
      this.cmdReturn.TabIndex = 31;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "to Return Operation Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.textBox_Email.AcceptsReturn = true;
      this.textBox_Email.BackColor = Color.White;
      this.textBox_Email.Cursor = Cursors.IBeam;
      this.textBox_Email.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox_Email.ForeColor = SystemColors.WindowText;
      this.textBox_Email.Location = new Point(112, 196);
      this.textBox_Email.MaxLength = 30;
      this.textBox_Email.Name = "textBox_Email";
      this.textBox_Email.RightToLeft = RightToLeft.No;
      this.textBox_Email.Size = new Size(282, 26);
      this.textBox_Email.TabIndex = 41;
      this.ToolTip1.SetToolTip((Control) this.textBox_Email, "Email Address");
      this.textBox_Email.Leave += new EventHandler(this.textBox_Email_Leave);
      this.textBox_Email.KeyPress += new KeyPressEventHandler(this.textBox_Email_KeyPress);
      this.textBox_Email.Enter += new EventHandler(this.textBox_Email_Enter);
      this.Label1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(-1, 1);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(793, 41);
      this.Label1.TabIndex = 35;
      this.Label1.Text = "Operation Mode";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.Label11.BackColor = Color.Yellow;
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = SystemColors.ControlText;
      this.Label11.Location = new Point(304, 176);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(81, 17);
      this.Label11.TabIndex = 50;
      this.Label11.Text = "Country ";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.lblMessage.BackColor = Color.Transparent;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(22, 526);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(633, 25);
      this.lblMessage.TabIndex = 33;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label10.BackColor = Color.Yellow;
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.ControlText;
      this.Label10.Location = new Point(304, 144);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(81, 17);
      this.Label10.TabIndex = 49;
      this.Label10.Text = "Contact No. ";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.mskValidEnd.AllowPromptAsInput = false;
      this.mskValidEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidEnd.ForeColor = Color.Blue;
      this.mskValidEnd.Location = new Point(400, 96);
      this.mskValidEnd.Mask = "####-##-##";
      this.mskValidEnd.Name = "mskValidEnd";
      this.mskValidEnd.PromptChar = ' ';
      this.mskValidEnd.Size = new Size(81, 20);
      this.mskValidEnd.TabIndex = 9;
      this.Label9.BackColor = Color.Yellow;
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(16, 144);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(81, 17);
      this.Label9.TabIndex = 48;
      this.Label9.Text = "Address ";
      this.Label9.TextAlign = ContentAlignment.TopRight;
      this.Label8.BackColor = Color.Yellow;
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(304, 112);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(81, 17);
      this.Label8.TabIndex = 47;
      this.Label8.Text = "Nationality ";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      this._Label7_0.BackColor = Color.Yellow;
      this._Label7_0.Cursor = Cursors.Default;
      this._Label7_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._Label7_0.ForeColor = SystemColors.ControlText;
      this._Label7_0.Location = new Point(16, 112);
      this._Label7_0.Name = "_Label7_0";
      this._Label7_0.RightToLeft = RightToLeft.No;
      this._Label7_0.Size = new Size(81, 17);
      this._Label7_0.TabIndex = 46;
      this._Label7_0.Text = "Passport No. ";
      this._Label7_0.TextAlign = ContentAlignment.TopRight;
      this.Label6.BackColor = Color.Yellow;
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = SystemColors.ControlText;
      this.Label6.Location = new Point(584, 80);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(57, 17);
      this.Label6.TabIndex = 45;
      this.Label6.Text = "Sex ";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.Yellow;
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(304, 80);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(81, 17);
      this.Label5.TabIndex = 44;
      this.Label5.Text = "SurName  ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.Yellow;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(16, 80);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 17);
      this.Label4.TabIndex = 43;
      this.Label4.Text = "First Name ";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.Yellow;
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(304, 48);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(81, 17);
      this.Label3.TabIndex = 42;
      this.Label3.Text = "Guest ID ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Frame3.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Frame3.Controls.Add((Control) this.label7);
      this.Frame3.Controls.Add((Control) this.textBox_Email);
      this.Frame3.Controls.Add((Control) this.cboSex);
      this.Frame3.Controls.Add((Control) this.cboBuildingNo);
      this.Frame3.Controls.Add((Control) this.cboCountry);
      this.Frame3.Controls.Add((Control) this.cmdClear);
      this.Frame3.Controls.Add((Control) this.cmdUpdate);
      this.Frame3.Controls.Add((Control) this.cmdEdit);
      this.Frame3.Controls.Add((Control) this.txtContact);
      this.Frame3.Controls.Add((Control) this.txtAddress);
      this.Frame3.Controls.Add((Control) this.txtNationality);
      this.Frame3.Controls.Add((Control) this.txtIdentity);
      this.Frame3.Controls.Add((Control) this.txtSurName);
      this.Frame3.Controls.Add((Control) this.txtFirstName);
      this.Frame3.Controls.Add((Control) this.txtClientID);
      this.Frame3.Controls.Add((Control) this.txtRoomNo);
      this.Frame3.Controls.Add((Control) this.cmdView);
      this.Frame3.Controls.Add((Control) this.Label16);
      this.Frame3.Controls.Add((Control) this.Label11);
      this.Frame3.Controls.Add((Control) this.Label10);
      this.Frame3.Controls.Add((Control) this.Label9);
      this.Frame3.Controls.Add((Control) this.Label8);
      this.Frame3.Controls.Add((Control) this._Label7_0);
      this.Frame3.Controls.Add((Control) this.Label6);
      this.Frame3.Controls.Add((Control) this.Label5);
      this.Frame3.Controls.Add((Control) this.Label4);
      this.Frame3.Controls.Add((Control) this.Label3);
      this.Frame3.Controls.Add((Control) this.Label14);
      this.Frame3.Controls.Add((Control) this.lblReserveRefNo);
      this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = SystemColors.ControlText;
      this.Frame3.Location = new Point(7, 73);
      this.Frame3.Name = "Frame3";
      this.Frame3.Padding = new Padding(0);
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(761, 232);
      this.Frame3.TabIndex = 38;
      this.Frame3.TabStop = false;
      this.label7.BackColor = Color.Yellow;
      this.label7.Cursor = Cursors.Default;
      this.label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = SystemColors.ControlText;
      this.label7.Location = new Point(16, 203);
      this.label7.Name = "label7";
      this.label7.RightToLeft = RightToLeft.No;
      this.label7.Size = new Size(81, 17);
      this.label7.TabIndex = 141;
      this.label7.Text = "Email";
      this.label7.TextAlign = ContentAlignment.TopRight;
      this.cboSex.FormattingEnabled = true;
      this.cboSex.Location = new Point(647, 77);
      this.cboSex.Name = "cboSex";
      this.cboSex.Size = new Size(78, 22);
      this.cboSex.TabIndex = 35;
      this.cboSex.KeyPress += new KeyPressEventHandler(this.cboSex_KeyPress);
      this.Label14.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.Red;
      this.Label14.Location = new Point(24, 48);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(73, 17);
      this.Label14.TabIndex = 41;
      this.Label14.Text = "Room No.";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.lblReserveRefNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblReserveRefNo.BorderStyle = BorderStyle.Fixed3D;
      this.lblReserveRefNo.Cursor = Cursors.Default;
      this.lblReserveRefNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblReserveRefNo.ForeColor = Color.Red;
      this.lblReserveRefNo.Location = new Point(520, 48);
      this.lblReserveRefNo.Name = "lblReserveRefNo";
      this.lblReserveRefNo.RightToLeft = RightToLeft.No;
      this.lblReserveRefNo.Size = new Size(105, 25);
      this.lblReserveRefNo.TabIndex = 40;
      this.mskValidStart.AllowPromptAsInput = false;
      this.mskValidStart.Enabled = false;
      this.mskValidStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidStart.ForeColor = Color.Blue;
      this.mskValidStart.Location = new Point(120, 96);
      this.mskValidStart.Mask = "####-##-##";
      this.mskValidStart.Name = "mskValidStart";
      this.mskValidStart.Size = new Size(81, 20);
      this.mskValidStart.TabIndex = 8;
      this.txtGracePeriod.AcceptsReturn = true;
      this.txtGracePeriod.BackColor = SystemColors.Window;
      this.txtGracePeriod.Cursor = Cursors.IBeam;
      this.txtGracePeriod.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGracePeriod.ForeColor = SystemColors.WindowText;
      this.txtGracePeriod.Location = new Point(120, 128);
      this.txtGracePeriod.MaxLength = 0;
      this.txtGracePeriod.Name = "txtGracePeriod";
      this.txtGracePeriod.ReadOnly = true;
      this.txtGracePeriod.RightToLeft = RightToLeft.No;
      this.txtGracePeriod.Size = new Size(41, 20);
      this.txtGracePeriod.TabIndex = 5;
      this.txtGracePeriod.Text = "0";
      this.txtGracePeriod.TextAlign = HorizontalAlignment.Center;
      this.Frame1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Frame1.Controls.Add((Control) this.txtGracePeriod);
      this.Frame1.Controls.Add((Control) this.txtRemark);
      this.Frame1.Controls.Add((Control) this.txtCardNo);
      this.Frame1.Controls.Add((Control) this.txtBuildingNo);
      this.Frame1.Controls.Add((Control) this.mskContractStart);
      this.Frame1.Controls.Add((Control) this.mskContractEnd);
      this.Frame1.Controls.Add((Control) this.txtRoomType);
      this.Frame1.Controls.Add((Control) this.mskValidStart);
      this.Frame1.Controls.Add((Control) this.mskValidEnd);
      this.Frame1.Controls.Add((Control) this.Label15);
      this.Frame1.Controls.Add((Control) this.Label13);
      this.Frame1.Controls.Add((Control) this.lblRoomStatus);
      this.Frame1.Controls.Add((Control) this.Label12);
      this.Frame1.Controls.Add((Control) this.Label17);
      this.Frame1.Controls.Add((Control) this.Label18);
      this.Frame1.Controls.Add((Control) this.Label19);
      this.Frame1.Controls.Add((Control) this.Label24);
      this.Frame1.Controls.Add((Control) this.Label25);
      this.Frame1.Controls.Add((Control) this.Label27);
      this.Frame1.Controls.Add((Control) this.Label28);
      this.Frame1.Controls.Add((Control) this.lblFloorNo);
      this.Frame1.Cursor = Cursors.Default;
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(31, 308);
      this.Frame1.Name = "Frame1";
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(601, 215);
      this.Frame1.TabIndex = 32;
      this.txtRemark.AcceptsReturn = true;
      this.txtRemark.BackColor = SystemColors.Window;
      this.txtRemark.Cursor = Cursors.IBeam;
      this.txtRemark.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRemark.ForeColor = SystemColors.WindowText;
      this.txtRemark.Location = new Point(120, 160);
      this.txtRemark.MaxLength = 40;
      this.txtRemark.Multiline = true;
      this.txtRemark.Name = "txtRemark";
      this.txtRemark.ReadOnly = true;
      this.txtRemark.RightToLeft = RightToLeft.No;
      this.txtRemark.Size = new Size(273, 37);
      this.txtRemark.TabIndex = 4;
      this.txtCardNo.AcceptsReturn = true;
      this.txtCardNo.BackColor = SystemColors.Window;
      this.txtCardNo.Cursor = Cursors.IBeam;
      this.txtCardNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCardNo.ForeColor = Color.Red;
      this.txtCardNo.Location = new Point(400, 32);
      this.txtCardNo.MaxLength = 0;
      this.txtCardNo.Name = "txtCardNo";
      this.txtCardNo.ReadOnly = true;
      this.txtCardNo.RightToLeft = RightToLeft.No;
      this.txtCardNo.Size = new Size(73, 20);
      this.txtCardNo.TabIndex = 3;
      this.txtCardNo.TextAlign = HorizontalAlignment.Center;
      this.txtBuildingNo.AcceptsReturn = true;
      this.txtBuildingNo.BackColor = SystemColors.Window;
      this.txtBuildingNo.Cursor = Cursors.IBeam;
      this.txtBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingNo.ForeColor = SystemColors.WindowText;
      this.txtBuildingNo.Location = new Point(120, 0);
      this.txtBuildingNo.MaxLength = 0;
      this.txtBuildingNo.Name = "txtBuildingNo";
      this.txtBuildingNo.ReadOnly = true;
      this.txtBuildingNo.RightToLeft = RightToLeft.No;
      this.txtBuildingNo.Size = new Size(49, 20);
      this.txtBuildingNo.TabIndex = 2;
      this.txtBuildingNo.TextAlign = HorizontalAlignment.Center;
      this.txtRoomType.AcceptsReturn = true;
      this.txtRoomType.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtRoomType.BorderStyle = BorderStyle.None;
      this.txtRoomType.Cursor = Cursors.IBeam;
      this.txtRoomType.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomType.ForeColor = Color.Red;
      this.txtRoomType.Location = new Point(187, 7);
      this.txtRoomType.MaxLength = 0;
      this.txtRoomType.Name = "txtRoomType";
      this.txtRoomType.ReadOnly = true;
      this.txtRoomType.RightToLeft = RightToLeft.No;
      this.txtRoomType.Size = new Size(81, 18);
      this.txtRoomType.TabIndex = 34;
      this.Data1.BackColor = Color.Red;
      this.Data1.BorderStyle = BorderStyle.FixedSingle;
      this.Data1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Data1.ForeColor = Color.Black;
      this.Data1.Location = new Point(7, 57);
      this.Data1.Name = "Data1";
      this.Data1.Size = new Size(76, 23);
      this.Data1.TabIndex = 39;
      this.Data1.Text = "Data1";
      this.Data1.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.ClientSize = new Size(795, 577);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Frame3);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Data1);
      this.Name = "Form_GuestDetailDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_GuestDetailDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_GuestDetailDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_GuestDetailDMS_FormClosing);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_GuestDetailDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void Clear_All_Interface()
    {
      this.ClearScreen();
      this.txtRoomNo.Text = "";
      this.txtCardNo.Text = "";
      this.mskValidEnd.Text = "    -  -  ";
      this.cmdEdit.Enabled = false;
      this.Frame1.Visible = true;
      this.cmdUpdate.Visible = false;
      this.Disable_Edit_Client_Boxs();
      this.lblMessage.Text = "Click Search Button to Select Room No..";
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      this.Clear_All_Interface();
    }

    private void Form_GuestDetailDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Check_OldGuest_Options_And_Process()
    {
      string commandText = this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText;
      this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from GInfo_Temp";
      this.db.temp_DB.gInfo_TempTableAdapter.Delete((string) null);
      this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText;
      this.db.Local_Command.CommandText = "Insert into GInfo_Temp(ClientID,ForeName,SurName,RoomNo,CardNo,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople <>9)AND (len(ClientAcc.RoomNo)=5)ORDER BY ClientAcc.RoomNo ASC";
      this.db.Local_Command.Connection = this.db.building_DB1.clientTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
    }

    private void txtRoomNo_KeyPress(string para_Building_No)
    {
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          this.txtRoomType.Text = this.db.Get_RoomType_Description(row.RoomType);
          this.txtBuildingNo.Text = row.BuildingNo;
          this.lblFloorNo.Text = row.FloorNo;
          break;
        }
      }
      if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        {
          if (row.ClientID == this.txtClientID.Text)
          {
            try
            {
              this.txtCardNo.Text = row.CardNo;
            }
            catch
            {
            }
            this.mskContractStart.Text = row.ContractStart.ToShortDateString();
            this.mskContractEnd.Text = row.ContractEnd.ToShortDateString();
            try
            {
              this.mskValidStart.Text = row.ValidStart.ToShortDateString();
            }
            catch
            {
            }
            try
            {
              this.mskValidEnd.Text = row.ValidEnd.ToShortDateString();
            }
            catch
            {
            }
            try
            {
              this.txtGracePeriod.Text = row.GracePeriod.ToString();
              break;
            }
            catch
            {
              break;
            }
          }
        }
        if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
        if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count > 0)
        {
          foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
          {
            if (row.ClientID == this.txtClientID.Text)
            {
              try
              {
                if (row.Sex == "F")
                  this.cboSex.SelectedItem = (object) "Female";
                else if (row.Sex == "M")
                  this.cboSex.SelectedItem = (object) "Male";
              }
              catch
              {
              }
              try
              {
                this.txtIdentity.Text = row.Identity;
              }
              catch
              {
              }
              try
              {
                this.txtNationality.Text = row.Nationality;
              }
              catch
              {
              }
              try
              {
                this.txtAddress.Text = row.Address;
              }
              catch
              {
              }
              try
              {
                this.cboCountry.SelectedItem = (object) row.Country;
              }
              catch
              {
              }
              try
              {
                this.txtContact.Text = row.Contact;
                break;
              }
              catch
              {
                break;
              }
            }
          }
        }
        this.lblRoomStatus.Text = "";
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          if (row.RoomNo == this.txtRoomNo.Text)
          {
            this.lblRoomStatus.Text = row.Description;
            break;
          }
        }
      }
      if (this.lblRoomStatus.Text == "Reserved")
      {
        this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
        foreach (BuildingDB1DataSet.ReserveRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Reserve.Rows)
        {
          if (row.RoomNo == this.txtRoomNo.Text)
          {
            this.lblReserveRefNo.Visible = true;
            this.lblReserveRefNo.Text = row.ReserveRef;
          }
        }
      }
      this.lblMessage.Text = "";
    }

    private void ClearScreen()
    {
      this.txtClientID.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.cboSex.SelectedItem = (object) "Male";
      this.txtIdentity.Text = "";
      this.txtNationality.Text = "";
      this.txtAddress.Text = "";
      this.txtContact.Text = "";
      this.txtBuildingNo.Text = "";
      this.lblFloorNo.Text = "";
      this.mskContractStart.Text = "____-__-__";
      this.mskContractEnd.Text = "____-__-__";
      this.mskValidStart.Text = "____-__-__";
      this.txtGracePeriod.Text = "";
      this.txtRemark.Text = "";
      this.lblRoomStatus.Text = "";
      this.txtRoomType.Visible = false;
      this.lblReserveRefNo.Visible = false;
      this.textBox_Email.Text = "";
      this.cboCountry.SelectedIndex = 0;
    }

    private void cmdView_Click(object sender, EventArgs e)
    {
      this.Check_OldGuest_Options_And_Process();
      this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
      int num = (int) new Form_GuestBrowserDMS().ShowDialog();
      if (!this.Old_Client_OK_flag)
        return;
      this.ClearScreen();
      this.Refresh();
      foreach (TempDataSet.GInfo_TempRow row1 in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
      {
        if (row1.ClientID == this.Old_Client_ID)
        {
          this.txtClientID.Text = row1.ClientID;
          this.txtFirstName.Text = row1.ForeName;
          this.txtSurName.Text = row1.SurName;
          this.txtRoomNo.Text = row1.RoomNo;
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
          foreach (BuildingDB1DataSet.ClientRow row2 in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
          {
            if (row2.ClientID == this.txtClientID.Text)
            {
              try
              {
                this.textBox_Email.Text = row2.Email;
                break;
              }
              catch
              {
                this.textBox_Email.Text = "";
                break;
              }
            }
          }
          try
          {
            if (row1.CardNo != null)
              this.txtCardNo.Text = row1.CardNo;
            else
              this.txtCardNo.Text = "";
          }
          catch
          {
            this.txtCardNo.Text = "";
          }
          this.txtRoomNo_KeyPress(this.cboBuildingNo.Text);
          this.cmdEdit.Enabled = true;
          this.Frame1.Visible = true;
          this.cmdUpdate.Visible = false;
          this.Disable_Edit_Client_Boxs();
          break;
        }
      }
    }

    private void Form_GuestDetailDMS_Load(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialze_ComboCountry(this.cboCountry);
      this.cboBuildingNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo;
      this.cmdUpdate.Visible = false;
      this.Disable_Edit_Client_Boxs();
      this.cmdEdit.Enabled = false;
      this.cboSex.Items.Add((object) "Male");
      this.cboSex.Items.Add((object) "Female");
      this.cboSex.SelectedIndex = 0;
    }

    private void Enable_Edit_Client_Boxs()
    {
      this.txtAddress.ReadOnly = false;
      this.txtSurName.ReadOnly = false;
      this.txtFirstName.ReadOnly = false;
      this.txtIdentity.ReadOnly = false;
      this.txtContact.ReadOnly = false;
      this.txtNationality.ReadOnly = false;
      this.textBox_Email.ReadOnly = false;
    }

    private void Disable_Edit_Client_Boxs()
    {
      this.txtAddress.ReadOnly = true;
      this.txtSurName.ReadOnly = true;
      this.txtFirstName.ReadOnly = true;
      this.txtIdentity.ReadOnly = true;
      this.txtContact.ReadOnly = true;
      this.txtNationality.ReadOnly = true;
      this.textBox_Email.ReadOnly = true;
    }

    private void cmdEdit_Click(object sender, EventArgs e)
    {
      this.Frame1.Visible = false;
      this.cmdUpdate.Visible = true;
      this.Enable_Edit_Client_Boxs();
      this.txtFirstName.Focus();
      this.txtFirstName.Select();
    }

    private void cmdUpdate_Click(object sender, EventArgs e)
    {
      this.Disable_Edit_Client_Boxs();
      this.cmdUpdate.Visible = false;
      this.Frame1.Visible = true;
      this.gGetClientProperty();
      if (this.db.ClientEdit(this.txtClientID.Text))
      {
        int num1 = (int) MessageBox.Show("Client Data Updated!");
      }
      else
      {
        int num2 = (int) MessageBox.Show("Client Data Update Failed!");
      }
    }

    private void gGetClientProperty()
    {
      gClientProperty.ClientID = this.txtClientID.Text;
      this.sClientType = "G";
      gClientProperty.ClientType = this.sClientType;
      gClientProperty.ForeName = this.txtFirstName.Text;
      gClientProperty.SurName = this.txtSurName.Text;
      gClientProperty.Sex = this.cboSex.Text.Substring(0, 1);
      gClientProperty.Identity = this.txtIdentity.Text;
      gClientProperty.Nationality = this.txtNationality.Text;
      gClientProperty.Address = this.txtAddress.Text;
      gClientProperty.Contact = this.txtContact.Text;
      gClientProperty.Country = this.cboCountry.Text;
      gClientProperty.Email = this.textBox_Email.Text;
      gClientProperty.Update = false;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      this.ClearScreen();
      this.txtRoomNo.Text = "";
      this.txtCardNo.Text = "";
      this.mskValidEnd.Text = "    -  -  ";
      this.lblMessage.Text = "Click Search Button to Select Room No..";
    }

    private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Filter_For_Email_Address(e, this.textBox_Email.Text);
    }

    private void Filter_For_Email_Address(KeyPressEventArgs e, string para_string)
    {
      if (para_string.Contains("@") && e.KeyChar == '@')
      {
        this.lblMessage.Text = "Enter valid email format !";
        this.lblMessage.Refresh();
        Console.Beep(200, 300);
        e.Handled = true;
        this.lblMessage.Text = "";
      }
      else if (e.KeyChar == '@')
      {
        if (para_string.Length == 0)
        {
          this.lblMessage.Text = "Enter valid email format !";
          this.lblMessage.Refresh();
          Console.Beep(200, 300);
          e.Handled = true;
          this.lblMessage.Text = "";
        }
        else
          e.Handled = false;
      }
      else
      {
        if (para_string.Contains("."))
        {
          if (para_string.IndexOf('.') != para_string.LastIndexOf('.'))
          {
            if (e.KeyChar == '.')
            {
              this.lblMessage.Text = "Enter valid email format !";
              this.lblMessage.Refresh();
              Console.Beep(200, 300);
              e.Handled = true;
              this.lblMessage.Text = "";
              return;
            }
          }
          else if (para_string.Length == para_string.LastIndexOf('.') + 1)
          {
            if (e.KeyChar == '.')
            {
              this.lblMessage.Text = "Enter valid email format !";
              this.lblMessage.Refresh();
              Console.Beep(200, 300);
              e.Handled = true;
              this.lblMessage.Text = "";
              return;
            }
          }
          else
          {
            e.Handled = false;
            return;
          }
        }
        if (e.KeyChar == '.')
        {
          if (para_string.Length == 0)
          {
            this.lblMessage.Text = "Enter valid email format !";
            this.lblMessage.Refresh();
            Console.Beep(200, 300);
            e.Handled = true;
            this.lblMessage.Text = "";
          }
          else if (!para_string.Contains("@"))
          {
            this.lblMessage.Text = "Enter valid email format !";
            this.lblMessage.Refresh();
            Console.Beep(200, 300);
            e.Handled = true;
            this.lblMessage.Text = "";
          }
          else if (para_string.Length == para_string.LastIndexOf('@') + 1)
          {
            this.lblMessage.Text = "Enter valid email format !";
            this.lblMessage.Refresh();
            Console.Beep(200, 300);
            e.Handled = true;
            this.lblMessage.Text = "";
          }
          else
            e.Handled = false;
        }
        else if (char.IsNumber(e.KeyChar))
          e.Handled = false;
        else if (char.IsLetterOrDigit(e.KeyChar))
          e.Handled = false;
        else if (char.IsControl(e.KeyChar))
        {
          e.Handled = false;
        }
        else
        {
          this.lblMessage.Text = "Enter valid email format !";
          this.lblMessage.Refresh();
          Console.Beep(200, 300);
          e.Handled = true;
          this.lblMessage.Text = "";
        }
      }
    }

    private void textBox_Email_Enter(object sender, EventArgs e)
    {
    }

    private void textBox_Email_Leave(object sender, EventArgs e)
    {
      if (this.textBox_Email.Text.Length > 0)
      {
        if (!this.textBox_Email.ReadOnly)
        {
          try
          {
            this.lblMessage.Text = "";
            MailAddress mailAddress = new MailAddress(this.textBox_Email.Text);
            return;
          }
          catch (FormatException ex)
          {
            string message = ex.Message;
            this.lblMessage.Text = "Please enter correct email address";
            int num = (int) MessageBox.Show("Please Enter A Valid Email");
            this.textBox_Email.Focus();
            this.textBox_Email.Select();
            return;
          }
        }
      }
      this.lblMessage.Text = "";
    }

    private void cboSex_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void cboBuildingNo_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void Form_GuestDetailDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Clear_All_Interface();
      this.cmdView.Focus();
      this.cmdView.Select();
    }
  }
}
