// Decompiled with JetBrains decompiler
// Type: AMS.Form_ReadGuestCardDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_ReadGuestCardDMS : Form
  {
    private IContainer components;
    public TextBox txtBuildingNo;
    public TextBox txtRoomNo;
    public TextBox txtRoomType;
    public TextBox txtCardNo;
    public Panel Frame2;
    public TextBox txtClientID;
    public ToolTip ToolTip1;
    public TextBox txtFirstName;
    public TextBox txtSurName;
    public TextBox txtIdentity;
    public TextBox txtNationality;
    public TextBox txtAddress;
    public TextBox txtContact;
    public TextBox txtSex;
    public TextBox txtCountry;
    public Label Label3;
    public Label Label4;
    public Label Label5;
    public Label Label6;
    public Label _Label7_0;
    public Label Label8;
    public Label Label9;
    public Label Label10;
    public Label Label11;
    public TextBox txtRemark;
    public TextBox txtGracePeriod;
    public MaskedTextBox mskValidStart;
    public Label lblMessage1;
    public System.Windows.Forms.Timer Timer1;
    public TextBox txtChargeType;
    public GroupBox Frame1;
    public MaskedTextBox mskContractStart;
    public MaskedTextBox mskContractEnd;
    public MaskedTextBox mskValidEnd;
    public Label Label13;
    public Label lbCardType;
    public Label Label28;
    public Label Label27;
    public Label Label25;
    public Label Label24;
    public Label Label19;
    public Label Label18;
    public Label Label17;
    public Label Label14;
    public Label Label12;
    public TextBox txtAdvance;
    public TextBox txtDeposit;
    public TextBox txtBond;
    public TextBox txtAmountDue;
    public TextBox txtAmountPaid;
    public Label lblMessage2;
    public Label lblMessage;
    public Label Label2;
    public Label Label1;
    public MaskedTextBox mskCheckOutDate;
    public Label Label16;
    public Button cmdCancel;
    public Button cmdReturn;
    public GroupBox Charges;
    public Label Label20;
    public Label Label15;
    public Label Label21;
    public Label Label22;
    public Label Label23;
    private GroupBox groupBox_CardData;
    private TextBox textBox7;
    private TextBox textBox9;
    private Label label7;
    private TextBox textBox10;
    private Label label26;
    private TextBox textBox8;
    private Label label29;
    private TextBox textBox6;
    private Label label30;
    private TextBox textBox5;
    private Label label31;
    private TextBox textBox4;
    private Label label32;
    private Label label33;
    public Button cmdReadCard;
    public Label label34;
    public TextBox textBox_Email;
    public Label label36;
    public Label label35;
    public MaskedTextBox mskCheckInDate;
    public MaskedTextBox mskCheckInTime;
    private string bld_no = "";
    private string floor_no = "";
    private string room_no = "";
    private string Begin_Date = "";
    private string End_Date;
    private string Room_No_Calculated = "";
    private string HW_ID = "";
    private string Card_AutoNumber = "";
    private DB db;
    private string sBuildingType = "";
    private bool bCheckBuilding;
    private bool Init_Flag;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_ReadGuestCardDMS));
      this.txtBuildingNo = new TextBox();
      this.txtRoomNo = new TextBox();
      this.txtRoomType = new TextBox();
      this.txtCardNo = new TextBox();
      this.Frame2 = new Panel();
      this.label34 = new Label();
      this.textBox_Email = new TextBox();
      this.txtClientID = new TextBox();
      this.txtFirstName = new TextBox();
      this.txtSurName = new TextBox();
      this.txtIdentity = new TextBox();
      this.txtNationality = new TextBox();
      this.txtAddress = new TextBox();
      this.txtContact = new TextBox();
      this.txtSex = new TextBox();
      this.txtCountry = new TextBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this._Label7_0 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.txtRemark = new TextBox();
      this.txtGracePeriod = new TextBox();
      this.mskValidStart = new MaskedTextBox();
      this.lblMessage1 = new Label();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.txtChargeType = new TextBox();
      this.Frame1 = new GroupBox();
      this.mskContractStart = new MaskedTextBox();
      this.mskContractEnd = new MaskedTextBox();
      this.mskValidEnd = new MaskedTextBox();
      this.Label13 = new Label();
      this.lbCardType = new Label();
      this.Label28 = new Label();
      this.Label27 = new Label();
      this.Label25 = new Label();
      this.Label24 = new Label();
      this.Label19 = new Label();
      this.Label18 = new Label();
      this.Label17 = new Label();
      this.Label14 = new Label();
      this.Label12 = new Label();
      this.txtAdvance = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtBond = new TextBox();
      this.txtAmountDue = new TextBox();
      this.txtAmountPaid = new TextBox();
      this.lblMessage2 = new Label();
      this.lblMessage = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.mskCheckOutDate = new MaskedTextBox();
      this.Label16 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdCancel = new Button();
      this.cmdReturn = new Button();
      this.Charges = new GroupBox();
      this.Label20 = new Label();
      this.Label15 = new Label();
      this.Label21 = new Label();
      this.Label22 = new Label();
      this.Label23 = new Label();
      this.groupBox_CardData = new GroupBox();
      this.textBox7 = new TextBox();
      this.textBox9 = new TextBox();
      this.label7 = new Label();
      this.textBox10 = new TextBox();
      this.label26 = new Label();
      this.textBox8 = new TextBox();
      this.label29 = new Label();
      this.textBox6 = new TextBox();
      this.label30 = new Label();
      this.textBox5 = new TextBox();
      this.label31 = new Label();
      this.textBox4 = new TextBox();
      this.label32 = new Label();
      this.label33 = new Label();
      this.cmdReadCard = new Button();
      this.mskCheckInTime = new MaskedTextBox();
      this.mskCheckInDate = new MaskedTextBox();
      this.label35 = new Label();
      this.label36 = new Label();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Charges.SuspendLayout();
      this.groupBox_CardData.SuspendLayout();
      this.SuspendLayout();
      this.txtBuildingNo.AcceptsReturn = true;
      this.txtBuildingNo.BackColor = SystemColors.Window;
      this.txtBuildingNo.Cursor = Cursors.IBeam;
      this.txtBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingNo.ForeColor = SystemColors.WindowText;
      this.txtBuildingNo.Location = new Point(104, 24);
      this.txtBuildingNo.MaxLength = 0;
      this.txtBuildingNo.Name = "txtBuildingNo";
      this.txtBuildingNo.ReadOnly = true;
      this.txtBuildingNo.RightToLeft = RightToLeft.No;
      this.txtBuildingNo.Size = new Size(81, 20);
      this.txtBuildingNo.TabIndex = 38;
      this.txtRoomNo.AcceptsReturn = true;
      this.txtRoomNo.BackColor = SystemColors.Window;
      this.txtRoomNo.Cursor = Cursors.IBeam;
      this.txtRoomNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.ForeColor = SystemColors.WindowText;
      this.txtRoomNo.Location = new Point(280, 24);
      this.txtRoomNo.MaxLength = 0;
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.ReadOnly = true;
      this.txtRoomNo.RightToLeft = RightToLeft.No;
      this.txtRoomNo.Size = new Size(73, 20);
      this.txtRoomNo.TabIndex = 37;
      this.txtRoomType.AcceptsReturn = true;
      this.txtRoomType.BackColor = SystemColors.Window;
      this.txtRoomType.Cursor = Cursors.IBeam;
      this.txtRoomType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomType.ForeColor = SystemColors.WindowText;
      this.txtRoomType.Location = new Point(360, 24);
      this.txtRoomType.MaxLength = 0;
      this.txtRoomType.Name = "txtRoomType";
      this.txtRoomType.ReadOnly = true;
      this.txtRoomType.RightToLeft = RightToLeft.No;
      this.txtRoomType.Size = new Size(73, 20);
      this.txtRoomType.TabIndex = 24;
      this.txtCardNo.AcceptsReturn = true;
      this.txtCardNo.BackColor = SystemColors.Window;
      this.txtCardNo.Cursor = Cursors.IBeam;
      this.txtCardNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCardNo.ForeColor = Color.Red;
      this.txtCardNo.Location = new Point(280, 56);
      this.txtCardNo.MaxLength = 0;
      this.txtCardNo.Name = "txtCardNo";
      this.txtCardNo.ReadOnly = true;
      this.txtCardNo.RightToLeft = RightToLeft.No;
      this.txtCardNo.Size = new Size(73, 20);
      this.txtCardNo.TabIndex = 22;
      this.txtCardNo.TextAlign = HorizontalAlignment.Center;
      this.Frame2.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Frame2.Controls.Add((Control) this.label34);
      this.Frame2.Controls.Add((Control) this.textBox_Email);
      this.Frame2.Controls.Add((Control) this.txtClientID);
      this.Frame2.Controls.Add((Control) this.txtFirstName);
      this.Frame2.Controls.Add((Control) this.txtSurName);
      this.Frame2.Controls.Add((Control) this.txtIdentity);
      this.Frame2.Controls.Add((Control) this.txtNationality);
      this.Frame2.Controls.Add((Control) this.txtAddress);
      this.Frame2.Controls.Add((Control) this.txtContact);
      this.Frame2.Controls.Add((Control) this.txtSex);
      this.Frame2.Controls.Add((Control) this.txtCountry);
      this.Frame2.Controls.Add((Control) this.Label3);
      this.Frame2.Controls.Add((Control) this.Label4);
      this.Frame2.Controls.Add((Control) this.Label5);
      this.Frame2.Controls.Add((Control) this.Label6);
      this.Frame2.Controls.Add((Control) this._Label7_0);
      this.Frame2.Controls.Add((Control) this.Label8);
      this.Frame2.Controls.Add((Control) this.Label9);
      this.Frame2.Controls.Add((Control) this.Label10);
      this.Frame2.Controls.Add((Control) this.Label11);
      this.Frame2.Cursor = Cursors.Default;
      this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = SystemColors.ControlText;
      this.Frame2.Location = new Point(34, 74);
      this.Frame2.Name = "Frame2";
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(746, 197);
      this.Frame2.TabIndex = 69;
      this.label34.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label34.Cursor = Cursors.Default;
      this.label34.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label34.ForeColor = SystemColors.ControlText;
      this.label34.Location = new Point(16, 162);
      this.label34.Name = "label34";
      this.label34.RightToLeft = RightToLeft.No;
      this.label34.Size = new Size(81, 17);
      this.label34.TabIndex = 60;
      this.label34.Text = "Email";
      this.label34.TextAlign = ContentAlignment.TopRight;
      this.textBox_Email.AcceptsReturn = true;
      this.textBox_Email.BackColor = Color.White;
      this.textBox_Email.Cursor = Cursors.IBeam;
      this.textBox_Email.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox_Email.ForeColor = SystemColors.WindowText;
      this.textBox_Email.Location = new Point(112, 162);
      this.textBox_Email.MaxLength = 30;
      this.textBox_Email.Name = "textBox_Email";
      this.textBox_Email.RightToLeft = RightToLeft.No;
      this.textBox_Email.Size = new Size(282, 26);
      this.textBox_Email.TabIndex = 59;
      this.ToolTip1.SetToolTip((Control) this.textBox_Email, "Email Address");
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.Blue;
      this.txtClientID.Location = new Point(112, 8);
      this.txtClientID.MaxLength = 0;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.ReadOnly = true;
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(113, 20);
      this.txtClientID.TabIndex = 49;
      this.ToolTip1.SetToolTip((Control) this.txtClientID, "Guest ID");
      this.txtFirstName.AcceptsReturn = true;
      this.txtFirstName.BackColor = SystemColors.Window;
      this.txtFirstName.Cursor = Cursors.IBeam;
      this.txtFirstName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFirstName.ForeColor = SystemColors.WindowText;
      this.txtFirstName.Location = new Point(112, 40);
      this.txtFirstName.MaxLength = 0;
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.ReadOnly = true;
      this.txtFirstName.RightToLeft = RightToLeft.No;
      this.txtFirstName.Size = new Size(153, 20);
      this.txtFirstName.TabIndex = 48;
      this.txtSurName.AcceptsReturn = true;
      this.txtSurName.BackColor = SystemColors.Window;
      this.txtSurName.Cursor = Cursors.IBeam;
      this.txtSurName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSurName.ForeColor = SystemColors.WindowText;
      this.txtSurName.Location = new Point(376, 40);
      this.txtSurName.MaxLength = 0;
      this.txtSurName.Name = "txtSurName";
      this.txtSurName.ReadOnly = true;
      this.txtSurName.RightToLeft = RightToLeft.No;
      this.txtSurName.Size = new Size(153, 20);
      this.txtSurName.TabIndex = 47;
      this.txtIdentity.AcceptsReturn = true;
      this.txtIdentity.BackColor = SystemColors.Window;
      this.txtIdentity.Cursor = Cursors.IBeam;
      this.txtIdentity.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIdentity.ForeColor = SystemColors.WindowText;
      this.txtIdentity.Location = new Point(112, 72);
      this.txtIdentity.MaxLength = 0;
      this.txtIdentity.Name = "txtIdentity";
      this.txtIdentity.ReadOnly = true;
      this.txtIdentity.RightToLeft = RightToLeft.No;
      this.txtIdentity.Size = new Size(153, 20);
      this.txtIdentity.TabIndex = 46;
      this.txtNationality.AcceptsReturn = true;
      this.txtNationality.BackColor = SystemColors.Window;
      this.txtNationality.Cursor = Cursors.IBeam;
      this.txtNationality.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNationality.ForeColor = SystemColors.WindowText;
      this.txtNationality.Location = new Point(376, 72);
      this.txtNationality.MaxLength = 0;
      this.txtNationality.Name = "txtNationality";
      this.txtNationality.ReadOnly = true;
      this.txtNationality.RightToLeft = RightToLeft.No;
      this.txtNationality.Size = new Size(153, 20);
      this.txtNationality.TabIndex = 45;
      this.txtAddress.AcceptsReturn = true;
      this.txtAddress.BackColor = SystemColors.Window;
      this.txtAddress.Cursor = Cursors.IBeam;
      this.txtAddress.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAddress.ForeColor = SystemColors.WindowText;
      this.txtAddress.Location = new Point(112, 104);
      this.txtAddress.MaxLength = 50;
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.ReadOnly = true;
      this.txtAddress.RightToLeft = RightToLeft.No;
      this.txtAddress.Size = new Size(153, 49);
      this.txtAddress.TabIndex = 44;
      this.txtContact.AcceptsReturn = true;
      this.txtContact.BackColor = SystemColors.Window;
      this.txtContact.Cursor = Cursors.IBeam;
      this.txtContact.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtContact.ForeColor = SystemColors.WindowText;
      this.txtContact.Location = new Point(376, 104);
      this.txtContact.MaxLength = 0;
      this.txtContact.Name = "txtContact";
      this.txtContact.ReadOnly = true;
      this.txtContact.RightToLeft = RightToLeft.No;
      this.txtContact.Size = new Size(153, 20);
      this.txtContact.TabIndex = 43;
      this.txtSex.AcceptsReturn = true;
      this.txtSex.BackColor = SystemColors.Window;
      this.txtSex.Cursor = Cursors.IBeam;
      this.txtSex.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSex.ForeColor = SystemColors.WindowText;
      this.txtSex.Location = new Point(632, 40);
      this.txtSex.MaxLength = 0;
      this.txtSex.Name = "txtSex";
      this.txtSex.ReadOnly = true;
      this.txtSex.RightToLeft = RightToLeft.No;
      this.txtSex.Size = new Size(49, 20);
      this.txtSex.TabIndex = 42;
      this.txtCountry.AcceptsReturn = true;
      this.txtCountry.BackColor = SystemColors.Window;
      this.txtCountry.Cursor = Cursors.IBeam;
      this.txtCountry.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCountry.ForeColor = SystemColors.WindowText;
      this.txtCountry.Location = new Point(376, 136);
      this.txtCountry.MaxLength = 0;
      this.txtCountry.Name = "txtCountry";
      this.txtCountry.ReadOnly = true;
      this.txtCountry.RightToLeft = RightToLeft.No;
      this.txtCountry.Size = new Size(153, 20);
      this.txtCountry.TabIndex = 41;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(16, 8);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(81, 17);
      this.Label3.TabIndex = 58;
      this.Label3.Text = "Guest ID";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(16, 40);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 17);
      this.Label4.TabIndex = 57;
      this.Label4.Text = "First Name";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(280, 40);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(81, 17);
      this.Label5.TabIndex = 56;
      this.Label5.Text = "SurName ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.Label6.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = SystemColors.ControlText;
      this.Label6.Location = new Point(560, 40);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(57, 17);
      this.Label6.TabIndex = 55;
      this.Label6.Text = "Sex";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this._Label7_0.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._Label7_0.Cursor = Cursors.Default;
      this._Label7_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._Label7_0.ForeColor = SystemColors.ControlText;
      this._Label7_0.Location = new Point(16, 72);
      this._Label7_0.Name = "_Label7_0";
      this._Label7_0.RightToLeft = RightToLeft.No;
      this._Label7_0.Size = new Size(81, 17);
      this._Label7_0.TabIndex = 54;
      this._Label7_0.Text = "Passport No.";
      this._Label7_0.TextAlign = ContentAlignment.TopRight;
      this.Label8.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(280, 72);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(81, 17);
      this.Label8.TabIndex = 53;
      this.Label8.Text = "Nationality";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      this.Label9.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(16, 104);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(81, 17);
      this.Label9.TabIndex = 52;
      this.Label9.Text = "Address";
      this.Label9.TextAlign = ContentAlignment.TopRight;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.ControlText;
      this.Label10.Location = new Point(280, 104);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(81, 17);
      this.Label10.TabIndex = 51;
      this.Label10.Text = "Contact No.";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.Label11.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = SystemColors.ControlText;
      this.Label11.Location = new Point(280, 136);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(81, 17);
      this.Label11.TabIndex = 50;
      this.Label11.Text = "Country";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.txtRemark.AcceptsReturn = true;
      this.txtRemark.BackColor = SystemColors.Window;
      this.txtRemark.Cursor = Cursors.IBeam;
      this.txtRemark.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRemark.ForeColor = SystemColors.WindowText;
      this.txtRemark.Location = new Point(104, 192);
      this.txtRemark.MaxLength = 40;
      this.txtRemark.Multiline = true;
      this.txtRemark.Name = "txtRemark";
      this.txtRemark.ReadOnly = true;
      this.txtRemark.RightToLeft = RightToLeft.No;
      this.txtRemark.Size = new Size(273, 37);
      this.txtRemark.TabIndex = 7;
      this.txtGracePeriod.AcceptsReturn = true;
      this.txtGracePeriod.BackColor = SystemColors.Window;
      this.txtGracePeriod.Cursor = Cursors.IBeam;
      this.txtGracePeriod.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGracePeriod.ForeColor = SystemColors.WindowText;
      this.txtGracePeriod.Location = new Point(104, 152);
      this.txtGracePeriod.MaxLength = 0;
      this.txtGracePeriod.Name = "txtGracePeriod";
      this.txtGracePeriod.ReadOnly = true;
      this.txtGracePeriod.RightToLeft = RightToLeft.No;
      this.txtGracePeriod.Size = new Size(41, 20);
      this.txtGracePeriod.TabIndex = 6;
      this.txtGracePeriod.Text = "0";
      this.txtGracePeriod.TextAlign = HorizontalAlignment.Center;
      this.mskValidStart.AllowPromptAsInput = false;
      this.mskValidStart.Enabled = false;
      this.mskValidStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidStart.ForeColor = Color.Blue;
      this.mskValidStart.Location = new Point(104, 120);
      this.mskValidStart.Mask = "####-##-##";
      this.mskValidStart.Name = "mskValidStart";
      this.mskValidStart.Size = new Size(81, 20);
      this.mskValidStart.TabIndex = 4;
      this.lblMessage1.BackColor = Color.Transparent;
      this.lblMessage1.Cursor = Cursors.Default;
      this.lblMessage1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage1.ForeColor = Color.Blue;
      this.lblMessage1.Location = new Point(360, 56);
      this.lblMessage1.Name = "lblMessage1";
      this.lblMessage1.RightToLeft = RightToLeft.No;
      this.lblMessage1.Size = new Size(177, 25);
      this.lblMessage1.TabIndex = 60;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 500;
      this.Timer1.Tick += new EventHandler(this.Timer1_Tick);
      this.txtChargeType.AcceptsReturn = true;
      this.txtChargeType.BackColor = SystemColors.Window;
      this.txtChargeType.Cursor = Cursors.IBeam;
      this.txtChargeType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtChargeType.ForeColor = SystemColors.WindowText;
      this.txtChargeType.Location = new Point(104, 24);
      this.txtChargeType.MaxLength = 0;
      this.txtChargeType.Name = "txtChargeType";
      this.txtChargeType.ReadOnly = true;
      this.txtChargeType.RightToLeft = RightToLeft.No;
      this.txtChargeType.Size = new Size(81, 20);
      this.txtChargeType.TabIndex = 39;
      this.txtChargeType.TextAlign = HorizontalAlignment.Center;
      this.Frame1.BackColor = Color.FromArgb(0, 192, 192);
      this.Frame1.Controls.Add((Control) this.label36);
      this.Frame1.Controls.Add((Control) this.label35);
      this.Frame1.Controls.Add((Control) this.mskCheckInDate);
      this.Frame1.Controls.Add((Control) this.mskCheckInTime);
      this.Frame1.Controls.Add((Control) this.txtBuildingNo);
      this.Frame1.Controls.Add((Control) this.txtRoomNo);
      this.Frame1.Controls.Add((Control) this.txtRoomType);
      this.Frame1.Controls.Add((Control) this.txtCardNo);
      this.Frame1.Controls.Add((Control) this.txtRemark);
      this.Frame1.Controls.Add((Control) this.mskCheckOutDate);
      this.Frame1.Controls.Add((Control) this.txtGracePeriod);
      this.Frame1.Controls.Add((Control) this.mskContractStart);
      this.Frame1.Controls.Add((Control) this.mskContractEnd);
      this.Frame1.Controls.Add((Control) this.mskValidStart);
      this.Frame1.Controls.Add((Control) this.mskValidEnd);
      this.Frame1.Controls.Add((Control) this.lblMessage1);
      this.Frame1.Controls.Add((Control) this.Label13);
      this.Frame1.Controls.Add((Control) this.lbCardType);
      this.Frame1.Controls.Add((Control) this.Label28);
      this.Frame1.Controls.Add((Control) this.Label27);
      this.Frame1.Controls.Add((Control) this.Label25);
      this.Frame1.Controls.Add((Control) this.Label24);
      this.Frame1.Controls.Add((Control) this.Label19);
      this.Frame1.Controls.Add((Control) this.Label18);
      this.Frame1.Controls.Add((Control) this.Label17);
      this.Frame1.Controls.Add((Control) this.Label14);
      this.Frame1.Controls.Add((Control) this.Label12);
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(26, 279);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(545, 241);
      this.Frame1.TabIndex = 64;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "Client Account";
      this.Frame1.Enter += new EventHandler(this.Frame1_Enter);
      this.mskContractStart.AllowPromptAsInput = false;
      this.mskContractStart.Enabled = false;
      this.mskContractStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractStart.ForeColor = Color.Blue;
      this.mskContractStart.Location = new Point(104, 88);
      this.mskContractStart.Mask = "####-##-##";
      this.mskContractStart.Name = "mskContractStart";
      this.mskContractStart.Size = new Size(81, 20);
      this.mskContractStart.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.mskContractStart, "Press any key to enter contract start date.");
      this.mskContractEnd.AllowPromptAsInput = false;
      this.mskContractEnd.Enabled = false;
      this.mskContractEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractEnd.ForeColor = Color.Blue;
      this.mskContractEnd.Location = new Point(280, 88);
      this.mskContractEnd.Mask = "####-##-##";
      this.mskContractEnd.Name = "mskContractEnd";
      this.mskContractEnd.Size = new Size(81, 20);
      this.mskContractEnd.TabIndex = 3;
      this.ToolTip1.SetToolTip((Control) this.mskContractEnd, "Press any key to enter contract end date.");
      this.mskValidEnd.AllowPromptAsInput = false;
      this.mskValidEnd.Enabled = false;
      this.mskValidEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidEnd.ForeColor = Color.Blue;
      this.mskValidEnd.Location = new Point(280, 120);
      this.mskValidEnd.Mask = "####-##-##";
      this.mskValidEnd.Name = "mskValidEnd";
      this.mskValidEnd.PromptChar = ' ';
      this.mskValidEnd.Size = new Size(81, 20);
      this.mskValidEnd.TabIndex = 5;
      this.ToolTip1.SetToolTip((Control) this.mskValidEnd, "Press any key to enter Valid End date.");
      this.Label13.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.ControlText;
      this.Label13.Location = new Point(456, 120);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(81, 17);
      this.Label13.TabIndex = 31;
      this.Label13.Text = "Inc.Gace";
      this.lbCardType.BackColor = Color.White;
      this.lbCardType.BorderStyle = BorderStyle.Fixed3D;
      this.lbCardType.Cursor = Cursors.Default;
      this.lbCardType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbCardType.ForeColor = Color.Blue;
      this.lbCardType.Location = new Point(104, 56);
      this.lbCardType.Name = "lbCardType";
      this.lbCardType.RightToLeft = RightToLeft.No;
      this.lbCardType.Size = new Size(81, 21);
      this.lbCardType.TabIndex = 23;
      this.Label28.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label28.Cursor = Cursors.Default;
      this.Label28.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = SystemColors.ControlText;
      this.Label28.Location = new Point(200, 56);
      this.Label28.Name = "Label28";
      this.Label28.RightToLeft = RightToLeft.No;
      this.Label28.Size = new Size(73, 17);
      this.Label28.TabIndex = 21;
      this.Label28.Text = "Card No.";
      this.Label28.TextAlign = ContentAlignment.TopRight;
      this.Label27.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label27.Cursor = Cursors.Default;
      this.Label27.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label27.ForeColor = SystemColors.ControlText;
      this.Label27.Location = new Point(16, 192);
      this.Label27.Name = "Label27";
      this.Label27.RightToLeft = RightToLeft.No;
      this.Label27.Size = new Size(81, 17);
      this.Label27.TabIndex = 19;
      this.Label27.Text = "Note: ";
      this.Label27.TextAlign = ContentAlignment.TopRight;
      this.Label25.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label25.Cursor = Cursors.Default;
      this.Label25.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = SystemColors.ControlText;
      this.Label25.Location = new Point(200, 120);
      this.Label25.Name = "Label25";
      this.Label25.RightToLeft = RightToLeft.No;
      this.Label25.Size = new Size(73, 17);
      this.Label25.TabIndex = 18;
      this.Label25.Text = "Valid End Date";
      this.Label25.TextAlign = ContentAlignment.TopRight;
      this.Label24.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label24.Cursor = Cursors.Default;
      this.Label24.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = SystemColors.ControlText;
      this.Label24.Location = new Point(16, 120);
      this.Label24.Name = "Label24";
      this.Label24.RightToLeft = RightToLeft.No;
      this.Label24.Size = new Size(81, 17);
      this.Label24.TabIndex = 17;
      this.Label24.Text = "Valid Start Date";
      this.Label24.TextAlign = ContentAlignment.TopRight;
      this.Label19.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label19.Cursor = Cursors.Default;
      this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = SystemColors.ControlText;
      this.Label19.Location = new Point(16, 152);
      this.Label19.Name = "Label19";
      this.Label19.RightToLeft = RightToLeft.No;
      this.Label19.Size = new Size(81, 17);
      this.Label19.TabIndex = 16;
      this.Label19.Text = "Grace Period";
      this.Label19.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(200, 88);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(73, 17);
      this.Label18.TabIndex = 15;
      this.Label18.Text = "Contract End";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(16, 88);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 14;
      this.Label17.Text = "Contract Start";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label14.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = SystemColors.ControlText;
      this.Label14.Location = new Point(200, 24);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(73, 17);
      this.Label14.TabIndex = 13;
      this.Label14.Text = "Room No.";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(16, 24);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(81, 17);
      this.Label12.TabIndex = 12;
      this.Label12.Text = "Building No. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.txtAdvance.AcceptsReturn = true;
      this.txtAdvance.BackColor = SystemColors.Window;
      this.txtAdvance.Cursor = Cursors.IBeam;
      this.txtAdvance.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAdvance.ForeColor = SystemColors.WindowText;
      this.txtAdvance.Location = new Point(104, 152);
      this.txtAdvance.MaxLength = 0;
      this.txtAdvance.Name = "txtAdvance";
      this.txtAdvance.ReadOnly = true;
      this.txtAdvance.RightToLeft = RightToLeft.No;
      this.txtAdvance.Size = new Size(81, 20);
      this.txtAdvance.TabIndex = 36;
      this.txtAdvance.TextAlign = HorizontalAlignment.Center;
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = SystemColors.Window;
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = SystemColors.WindowText;
      this.txtDeposit.Location = new Point(104, 120);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.ReadOnly = true;
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(81, 20);
      this.txtDeposit.TabIndex = 34;
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.txtBond.AcceptsReturn = true;
      this.txtBond.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtBond.Cursor = Cursors.IBeam;
      this.txtBond.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBond.ForeColor = Color.Red;
      this.txtBond.Location = new Point(104, 56);
      this.txtBond.MaxLength = 0;
      this.txtBond.Name = "txtBond";
      this.txtBond.ReadOnly = true;
      this.txtBond.RightToLeft = RightToLeft.No;
      this.txtBond.Size = new Size(81, 20);
      this.txtBond.TabIndex = 8;
      this.txtBond.TextAlign = HorizontalAlignment.Center;
      this.txtAmountDue.AcceptsReturn = true;
      this.txtAmountDue.BackColor = SystemColors.Window;
      this.txtAmountDue.Cursor = Cursors.IBeam;
      this.txtAmountDue.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmountDue.ForeColor = SystemColors.WindowText;
      this.txtAmountDue.Location = new Point(104, 88);
      this.txtAmountDue.MaxLength = 0;
      this.txtAmountDue.Name = "txtAmountDue";
      this.txtAmountDue.ReadOnly = true;
      this.txtAmountDue.RightToLeft = RightToLeft.No;
      this.txtAmountDue.Size = new Size(81, 20);
      this.txtAmountDue.TabIndex = 9;
      this.txtAmountDue.TextAlign = HorizontalAlignment.Center;
      this.txtAmountPaid.AcceptsReturn = true;
      this.txtAmountPaid.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.txtAmountPaid.Cursor = Cursors.IBeam;
      this.txtAmountPaid.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmountPaid.ForeColor = Color.Red;
      this.txtAmountPaid.Location = new Point(104, 184);
      this.txtAmountPaid.MaxLength = 0;
      this.txtAmountPaid.Name = "txtAmountPaid";
      this.txtAmountPaid.ReadOnly = true;
      this.txtAmountPaid.RightToLeft = RightToLeft.No;
      this.txtAmountPaid.Size = new Size(81, 20);
      this.txtAmountPaid.TabIndex = 10;
      this.txtAmountPaid.TextAlign = HorizontalAlignment.Center;
      this.lblMessage2.BackColor = Color.White;
      this.lblMessage2.Cursor = Cursors.Default;
      this.lblMessage2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage2.ForeColor = Color.Blue;
      this.lblMessage2.Location = new Point(415, 527);
      this.lblMessage2.Name = "lblMessage2";
      this.lblMessage2.RightToLeft = RightToLeft.No;
      this.lblMessage2.Size = new Size(265, 41);
      this.lblMessage2.TabIndex = 71;
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(23, 527);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(393, 41);
      this.lblMessage.TabIndex = 65;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(2, 42);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 33);
      this.Label2.TabIndex = 63;
      this.Label2.Text = "GUEST INFORMATION / RECYCLE INVALID CARD";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(2, 2);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 49);
      this.Label1.TabIndex = 62;
      this.Label1.Text = "Operation Mode ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.mskCheckOutDate.AllowPromptAsInput = false;
      this.mskCheckOutDate.Enabled = false;
      this.mskCheckOutDate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskCheckOutDate.ForeColor = Color.Blue;
      this.mskCheckOutDate.Location = new Point(367, 120);
      this.mskCheckOutDate.Mask = "####-##-##";
      this.mskCheckOutDate.Name = "mskCheckOutDate";
      this.mskCheckOutDate.Size = new Size(81, 20);
      this.mskCheckOutDate.TabIndex = 66;
      this.Label16.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = SystemColors.ControlText;
      this.Label16.Location = new Point(8, 24);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(81, 17);
      this.Label16.TabIndex = 30;
      this.Label16.Text = "Charge Type";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.cmdCancel.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.cmdCancel.Cursor = Cursors.Default;
      this.cmdCancel.Enabled = false;
      this.cmdCancel.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = SystemColors.ControlText;
      this.cmdCancel.Image = (Image) componentResourceManager.GetObject("cmdCancel.Image");
      this.cmdCancel.Location = new Point(599, 473);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.RightToLeft = RightToLeft.No;
      this.cmdCancel.Size = new Size(52, 47);
      this.cmdCancel.TabIndex = 70;
      this.cmdCancel.Text = "&Recycle Card";
      this.cmdCancel.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdCancel, "Click to Recycle Invalid Card Data");
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(724, 521);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(52, 47);
      this.cmdReturn.TabIndex = 68;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Operation Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.Charges.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.Charges.Controls.Add((Control) this.txtChargeType);
      this.Charges.Controls.Add((Control) this.txtAdvance);
      this.Charges.Controls.Add((Control) this.txtDeposit);
      this.Charges.Controls.Add((Control) this.txtBond);
      this.Charges.Controls.Add((Control) this.txtAmountDue);
      this.Charges.Controls.Add((Control) this.txtAmountPaid);
      this.Charges.Controls.Add((Control) this.Label20);
      this.Charges.Controls.Add((Control) this.Label15);
      this.Charges.Controls.Add((Control) this.Label16);
      this.Charges.Controls.Add((Control) this.Label21);
      this.Charges.Controls.Add((Control) this.Label22);
      this.Charges.Controls.Add((Control) this.Label23);
      this.Charges.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Charges.ForeColor = SystemColors.ControlText;
      this.Charges.Location = new Point(578, 250);
      this.Charges.Name = "Charges";
      this.Charges.Padding = new Padding(0);
      this.Charges.RightToLeft = RightToLeft.No;
      this.Charges.Size = new Size(201, 217);
      this.Charges.TabIndex = 67;
      this.Charges.TabStop = false;
      this.Charges.Text = "Charges";
      this.Label20.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label20.Cursor = Cursors.Default;
      this.Label20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = SystemColors.ControlText;
      this.Label20.Location = new Point(8, 152);
      this.Label20.Name = "Label20";
      this.Label20.RightToLeft = RightToLeft.No;
      this.Label20.Size = new Size(81, 17);
      this.Label20.TabIndex = 35;
      this.Label20.Text = "Advance";
      this.Label20.TextAlign = ContentAlignment.TopRight;
      this.Label15.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = SystemColors.ControlText;
      this.Label15.Location = new Point(8, 120);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(81, 17);
      this.Label15.TabIndex = 33;
      this.Label15.Text = "Deposit";
      this.Label15.TextAlign = ContentAlignment.TopRight;
      this.Label21.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label21.Cursor = Cursors.Default;
      this.Label21.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = SystemColors.ControlText;
      this.Label21.Location = new Point(8, 56);
      this.Label21.Name = "Label21";
      this.Label21.RightToLeft = RightToLeft.No;
      this.Label21.Size = new Size(81, 17);
      this.Label21.TabIndex = 29;
      this.Label21.Text = "Bond Amount";
      this.Label21.TextAlign = ContentAlignment.TopRight;
      this.Label22.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label22.Cursor = Cursors.Default;
      this.Label22.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = SystemColors.ControlText;
      this.Label22.Location = new Point(8, 88);
      this.Label22.Name = "Label22";
      this.Label22.RightToLeft = RightToLeft.No;
      this.Label22.Size = new Size(81, 17);
      this.Label22.TabIndex = 28;
      this.Label22.Text = "Amount Paid";
      this.Label22.TextAlign = ContentAlignment.TopRight;
      this.Label23.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label23.Cursor = Cursors.Default;
      this.Label23.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = SystemColors.ControlText;
      this.Label23.Location = new Point(8, 184);
      this.Label23.Name = "Label23";
      this.Label23.RightToLeft = RightToLeft.No;
      this.Label23.Size = new Size(81, 17);
      this.Label23.TabIndex = 27;
      this.Label23.Text = "Last Received";
      this.Label23.TextAlign = ContentAlignment.TopRight;
      this.groupBox_CardData.Controls.Add((Control) this.textBox7);
      this.groupBox_CardData.Controls.Add((Control) this.textBox9);
      this.groupBox_CardData.Controls.Add((Control) this.label7);
      this.groupBox_CardData.Controls.Add((Control) this.textBox10);
      this.groupBox_CardData.Controls.Add((Control) this.label26);
      this.groupBox_CardData.Controls.Add((Control) this.textBox8);
      this.groupBox_CardData.Controls.Add((Control) this.label29);
      this.groupBox_CardData.Controls.Add((Control) this.textBox6);
      this.groupBox_CardData.Controls.Add((Control) this.label30);
      this.groupBox_CardData.Controls.Add((Control) this.textBox5);
      this.groupBox_CardData.Controls.Add((Control) this.label31);
      this.groupBox_CardData.Controls.Add((Control) this.textBox4);
      this.groupBox_CardData.Controls.Add((Control) this.label32);
      this.groupBox_CardData.Controls.Add((Control) this.label33);
      this.groupBox_CardData.Location = new Point(404, 69);
      this.groupBox_CardData.Name = "groupBox_CardData";
      this.groupBox_CardData.Size = new Size(359, 174);
      this.groupBox_CardData.TabIndex = 59;
      this.groupBox_CardData.TabStop = false;
      this.groupBox_CardData.Text = "Card's Data";
      this.groupBox_CardData.Visible = false;
      this.textBox7.Location = new Point(70, 100);
      this.textBox7.Margin = new Padding(2);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(110, 20);
      this.textBox7.TabIndex = 48;
      this.textBox9.Location = new Point(70, 149);
      this.textBox9.Margin = new Padding(2);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(110, 20);
      this.textBox9.TabIndex = 47;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(6, 30);
      this.label7.Name = "label7";
      this.label7.Size = new Size(44, 13);
      this.label7.TabIndex = 35;
      this.label7.Text = "Building";
      this.textBox10.Location = new Point(244, 148);
      this.textBox10.Margin = new Padding(2);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new Size(109, 20);
      this.textBox10.TabIndex = 46;
      this.label26.AutoSize = true;
      this.label26.Location = new Point(6, 100);
      this.label26.Name = "label26";
      this.label26.Size = new Size(60, 13);
      this.label26.TabIndex = 36;
      this.label26.Text = "Begin Date";
      this.textBox8.Location = new Point(244, 97);
      this.textBox8.Margin = new Padding(2);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(109, 20);
      this.textBox8.TabIndex = 45;
      this.label29.AutoSize = true;
      this.label29.Location = new Point(6, 150);
      this.label29.Name = "label29";
      this.label29.Size = new Size(60, 13);
      this.label29.TabIndex = 37;
      this.label29.Text = "Begin Time";
      this.textBox6.Location = new Point(244, 62);
      this.textBox6.Margin = new Padding(2);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(46, 20);
      this.textBox6.TabIndex = 44;
      this.label30.AutoSize = true;
      this.label30.Location = new Point(187, 33);
      this.label30.Name = "label30";
      this.label30.Size = new Size(30, 13);
      this.label30.TabIndex = 38;
      this.label30.Text = "Floor";
      this.textBox5.Location = new Point(244, 30);
      this.textBox5.Margin = new Padding(2);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(46, 20);
      this.textBox5.TabIndex = 43;
      this.label31.AutoSize = true;
      this.label31.Location = new Point(187, 65);
      this.label31.Name = "label31";
      this.label31.Size = new Size(35, 13);
      this.label31.TabIndex = 39;
      this.label31.Text = "Room";
      this.textBox4.Location = new Point(70, 30);
      this.textBox4.Margin = new Padding(2);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(53, 20);
      this.textBox4.TabIndex = 42;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(187, 103);
      this.label32.Name = "label32";
      this.label32.Size = new Size(52, 13);
      this.label32.TabIndex = 40;
      this.label32.Text = "End Date";
      this.label33.AutoSize = true;
      this.label33.Location = new Point(187, 151);
      this.label33.Name = "label33";
      this.label33.Size = new Size(59, 13);
      this.label33.TabIndex = 41;
      this.label33.Text = "Dead Time";
      this.cmdReadCard.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdReadCard.Cursor = Cursors.Default;
      this.cmdReadCard.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.cmdReadCard.ForeColor = SystemColors.ControlText;
      this.cmdReadCard.Location = new Point(657, 475);
      this.cmdReadCard.Name = "cmdReadCard";
      this.cmdReadCard.RightToLeft = RightToLeft.No;
      this.cmdReadCard.Size = new Size(109, 40);
      this.cmdReadCard.TabIndex = 72;
      this.cmdReadCard.Text = "Read Guest Card";
      this.cmdReadCard.UseVisualStyleBackColor = false;
      this.cmdReadCard.Click += new EventHandler(this.cmdReadCard_Click);
      this.mskCheckInTime.AllowPromptAsInput = false;
      this.mskCheckInTime.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskCheckInTime.ForeColor = Color.Blue;
      this.mskCheckInTime.Location = new Point(454, 155);
      this.mskCheckInTime.Mask = "##:##:##";
      this.mskCheckInTime.Name = "mskCheckInTime";
      this.mskCheckInTime.Size = new Size(61, 20);
      this.mskCheckInTime.TabIndex = 67;
      this.ToolTip1.SetToolTip((Control) this.mskCheckInTime, "Valid End Time");
      this.mskCheckInDate.AllowPromptAsInput = false;
      this.mskCheckInDate.Enabled = false;
      this.mskCheckInDate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskCheckInDate.ForeColor = Color.Blue;
      this.mskCheckInDate.Location = new Point(280, 155);
      this.mskCheckInDate.Mask = "####-##-##";
      this.mskCheckInDate.Name = "mskCheckInDate";
      this.mskCheckInDate.Size = new Size(81, 20);
      this.mskCheckInDate.TabIndex = 68;
      this.label35.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label35.Cursor = Cursors.Default;
      this.label35.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label35.ForeColor = SystemColors.ControlText;
      this.label35.Location = new Point(200, 155);
      this.label35.Name = "label35";
      this.label35.RightToLeft = RightToLeft.No;
      this.label35.Size = new Size(73, 17);
      this.label35.TabIndex = 69;
      this.label35.Text = "Check In Date";
      this.label35.TextAlign = ContentAlignment.TopRight;
      this.label36.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.label36.Cursor = Cursors.Default;
      this.label36.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label36.ForeColor = SystemColors.ControlText;
      this.label36.Location = new Point(375, 155);
      this.label36.Name = "label36";
      this.label36.RightToLeft = RightToLeft.No;
      this.label36.Size = new Size(73, 17);
      this.label36.TabIndex = 70;
      this.label36.Text = "Check In Time";
      this.label36.TextAlign = ContentAlignment.TopRight;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(792, 586);
      this.Controls.Add((Control) this.cmdReadCard);
      this.Controls.Add((Control) this.lblMessage2);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.Charges);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Frame2);
      this.Controls.Add((Control) this.groupBox_CardData);
      this.Name = "Form_ReadGuestCardDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.VisibleChanged += new EventHandler(this.Form_ReadGuestCardDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_ReadGuestCardDMS_FormClosing);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Charges.ResumeLayout(false);
      this.Charges.PerformLayout();
      this.groupBox_CardData.ResumeLayout(false);
      this.groupBox_CardData.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_ReadGuestCardDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      this.Clear_GuestInfo();
    }

    private void Form_ReadGuestCardDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_ReadGuestCardDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Timer1.Start();
      this.Timer1.Interval = 200;
      this.Init_Flag = true;
    }

    private bool CheckBuildingNoFromCard()
    {
      if (this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
      {
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sCardSerialNo = this.txtCardNo.Text;
        this.bCheckBuilding = false;
        return true;
      }
      //this.lblMessage.Text = "Invalid Card : " + this.txtCardNo.Text;
      this.bCheckBuilding = true;
      return false;
    }

    private bool CheckBuildingType()
    {
      bool flag = false;
      this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
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
        if (row.BuildingNo == this.txtBuildingNo.Text)
        {
          flag = true;
          this.sBuildingType = row.BuildingType;
          break;
        }
      }
      return flag;
    }

    private bool GetClientData()
    {
      byte num1 = 0;
      DateTime now = DateTime.Now;
      this.lblMessage.Text = "";
      this.lblMessage1.Text = "";
      this.lblMessage2.Text = "";
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      try
      {
        if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
          this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      }
      catch
      {
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      }
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          this.txtRoomType.Text = this.db.Get_RoomType_Description(row.RoomType);
          break;
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
          this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      catch
      {
        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          try
          {
            if (row.ChargeType == "D")
              this.txtChargeType.Text = "Daily";
            else if (row.ChargeType == "W")
              this.txtChargeType.Text = "Weekly";
            else
              this.txtChargeType.Text = "Monthly";
          }
          catch
          {
            //int num2 = (int) MessageBox.Show("Invalid Card!");
            return false;
          }
          num1 = row.NoOfPeople;
          if (row.NoOfPeople == (byte) 9 && this.txtRoomNo.Text != row.RoomNo)
          {
            if (row.RoomNo == "CN")
              this.lblMessage.Text = "Guest Already CheckOut/Cancel Without Card..";
            else
              this.lblMessage.Text = "Guest Already CheckOut/Cancel..";
          }
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition = row.Condition;
          this.txtGracePeriod.Text = row.GracePeriod.ToString();
          this.txtAmountDue.Text = row.AmountPaid.ToString("F2");
          this.txtDeposit.Text = row.Deposit.ToString("F2");
          this.txtAdvance.Text = row.AdvancedPayment.ToString("F2");
          this.txtAmountPaid.Text = row.LastPayment.ToString("F2");
          try
          {
            this.mskContractStart.Text = row.ContractStart.ToShortDateString();
          }
          catch
          {
            int num3 = (int) MessageBox.Show("Invalid Guest Card!");
            return false;
          }
          try
          {
            this.mskCheckInDate.Text = row.CheckInDate.ToShortDateString();
          }
          catch
          {
          }
          try
          {
            this.mskCheckInTime.Text = row.CheckInTime.ToLongTimeString();
          }
          catch
          {
          }
          this.mskContractEnd.Text = row.ContractEnd.ToShortDateString();
          this.mskValidStart.Text = AccessCard.sCardInDate;
          this.mskValidEnd.Text = DateTime.Parse(this.mskCheckOutDate.Text).AddDays((double) -row.GracePeriod).ToShortDateString();
          if (this.sBuildingType == "Apartment")
          {
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition == "Unit")
            {
              Mod_UpdateData.sChkRoom = this.txtRoomNo.Text;
              goto label_45;
            }
          }
          try
          {
            if (row.CheckOutDate.CompareTo(DateTime.Parse(this.mskCheckOutDate.Text)) >= 0)
            {
              if (!this.bCheckBuilding)
              {
                this.lblMessage2.Text = "Click Recycle Button To Clear Invalid Card Data..";
                this.cmdCancel.Enabled = true;
              }
              else
              {
                this.lblMessage2.Text = "Invalid Card.To Be Recycle at Respective Building.";
                this.cmdCancel.Enabled = false;
              }
            }
            else
            {
              this.lblMessage2.Text = "Not Allow To Recycle.";
              this.cmdCancel.Enabled = false;
            }
          }
          catch
          {
            if (!this.bCheckBuilding)
            {
              this.lblMessage2.Text = "Click Recycle Button To Clear Invalid Card Data..";
              this.cmdCancel.Enabled = true;
            }
          }
label_45:
          this.txtBond.Text = row.Bond.ToString("F2");
          try
          {
            if (row.Remark != "")
            {
              this.txtRemark.Text = row.Remark;
              break;
            }
            break;
          }
          catch
          {
            break;
          }
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      }
      catch
      {
        this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      }
      foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          this.txtFirstName.Text = row.ForeName;
          this.txtSurName.Text = row.SurName;
          this.txtSex.Text = row.Sex;
          this.txtIdentity.Text = row.Identity;
          this.txtNationality.Text = row.Nationality;
          this.txtAddress.Text = row.Address;
          this.txtContact.Text = row.Contact;
          this.txtCountry.Text = row.Country;
          try
          {
            this.textBox_Email.Text = row.Email;
            break;
          }
          catch
          {
            this.textBox_Email.Text = "";
            break;
          }
        }
      }
      switch (Mod_UpdateData.iChkCardStatus)
      {
        case 0:
          if (num1 == (byte) 2)
          {
            this.lblMessage1.Text = "Second Major Card: " + this.txtCardNo.Text;
            break;
          }
          this.lblMessage1.Text = "Major Card: " + this.txtCardNo.Text;
          break;
        case 1:
          this.lblMessage1.Text = "Spare Card: " + this.txtCardNo.Text;
          break;
        case 2:
          this.lblMessage1.Text = "Loss Card: " + this.txtCardNo.Text;
          this.lblMessage.Text = "Reported Loss Card..";
          break;
      }
      return true;
    }

    private bool Read_CardInformattion()
    {
      if (SmartCard_Procedures.ReadCard_Information((int) Global_Data.COM_NUM))
      {
        string str = SmartCard_Procedures.Card_Information_String.Substring(2, 2);
        int int32 = Convert.ToInt32(str);
        this.Card_AutoNumber = SmartCard_Procedures.Card_Information_String.Substring(0, 2) + "FF" + SmartCard_Procedures.Card_Information_String.Substring(4, 4) + "00000000";
        if (!SmartCard_Procedures.ReadCardID((int) Global_Data.COM_NUM))
          return false;
        this.HW_ID = SmartCard_Procedures.Card_ID_String;
        if (str == Card_Type_Code.Guest_card)
        {
          this.bld_no = SmartCard_Procedures.Card_Information_String.Substring(8, 2);
          this.floor_no = SmartCard_Procedures.Card_Information_String.Substring(10, 2);
          this.room_no = SmartCard_Procedures.Card_Information_String.Substring(12, 2);
          this.Begin_Date = "20" + SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
          this.End_Date = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
          this.Room_No_Calculated = this.bld_no.Substring(1, 1) + this.floor_no + this.room_no;
          this.txtRoomNo.Text = this.Room_No_Calculated;
          AccessCard.sCardInDate = "20" + SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
          this.mskValidStart.Text = AccessCard.sCardInDate;
          AccessCard.sCardOutDate = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
          this.mskCheckOutDate.Text = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
          this.txtBuildingNo.Text = this.bld_no.Substring(1, 1);
          return true;
        }
        if (int32 == 0 || int32 > 18)
        {
          this.lblMessage.Text = "New Card!";
          this.lblMessage.Refresh();
          Console.Beep(700, 300);
          Thread.Sleep(500);
          this.lblMessage.Text = "";
          return false;
        }
        this.lblMessage.Text = "Incorrect Card Type!";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.lblMessage.Text = "";
        return false;
      }
      this.lblMessage.Text = "Can Not Read Card!";
      this.lblMessage.Refresh();
      Console.Beep(700, 300);
      Thread.Sleep(800);
      this.lblMessage.Text = "";
      return false;
    }

    private void Clear_GuestInfo()
    {
      this.txtClientID.Text = "";
      this.txtFirstName.Text = "";
      this.txtIdentity.Text = "";
      this.txtAddress.Text = "";
      this.txtSurName.Text = "";
      this.txtNationality.Text = "";
      this.txtContact.Text = "";
      this.txtCountry.Text = "";
      this.textBox_Email.Text = "";
      this.txtSex.Text = "";
      this.txtBuildingNo.Text = "";
      this.txtRoomNo.Text = "";
      this.txtRoomType.Text = "";
      this.lbCardType.Text = "";
      this.txtCardNo.Text = "";
      this.mskContractStart.Text = "";
      this.mskContractEnd.Text = "";
      this.mskValidStart.Text = "";
      this.mskValidEnd.Text = "";
      this.txtGracePeriod.Text = "";
      this.txtRemark.Text = "";
      this.txtChargeType.Text = "";
      this.txtBond.Text = "";
      this.txtAmountDue.Text = "";
      this.txtDeposit.Text = "";
      this.txtAdvance.Text = "";
      this.txtAmountPaid.Text = "";
      this.lblMessage.Text = "";
      this.lblMessage1.Text = "";
      this.lblMessage2.Text = "";
      this.cmdCancel.Enabled = false;
      this.mskCheckOutDate.Text = "";
      this.mskCheckInDate.Text = "";
      this.mskCheckInTime.Text = "";
    }

    private bool CheckClientData()
    {
      bool flag = false;
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count <= 0)
          this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      catch
      {
        this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        try
        {
          if (row.RoomNo == this.Room_No_Calculated)
          {
            if (row.Card_HW_ID == this.HW_ID)
            {
              if (row.Card_AutoNumber == this.Card_AutoNumber)
              {
                this.txtCardNo.Text = row.CardNo;
                this.txtClientID.Text = row.ClientID;
                Mod_UpdateData.iChkCardStatus = row.CardStatus;
                flag = true;
                break;
              }
            }
          }
        }
        catch
        {
        }
      }
      return flag;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (!this.Visible || !this.Init_Flag)
        return;
      this.Init_Flag = false;
      this.Timer1.Interval = 500;
      if (Global_Data.Card_Reader_Found_Flag)
      {
        if (this.Read_CardInformattion())
        {
          if (!this.CheckClientData())
          {
            /*this.lblMessage.Text = "Invalid Card!";
            this.lblMessage.Refresh();
            Console.Beep(700, 300);
            Thread.Sleep(500);
            this.lblMessage.Text = "";*/
          }
          else if (!this.CheckBuildingNoFromCard())
          {
            this.lblMessage.Text = "Invalid Card for current building!";
            this.lblMessage.Refresh();
            Console.Beep(700, 300);
            Thread.Sleep(500);
            this.lblMessage.Text = "";
          }
          else
          {
            this.CheckBuildingType();
            this.GetClientData();
          }
        }
        else
          this.Clear_GuestInfo();
      }
      else
      {
        this.lblMessage.Text = "Card Reader Not Found!";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.lblMessage.Text = "";
        this.Clear_GuestInfo();
      }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      if (Global_Data.COM_NUM == (byte) 0)
      {
        int num1 = (int) MessageBox.Show("Card Reader Not Found!");
      }
      else
      {
        if (MessageBox.Show("Are you sure erasing?\r\nPlease comfirm Yes/No ", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes || !SmartCard_Procedures.Make_Empty_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
          return;
        this.cmdCancel.Enabled = false;
        int num2 = (int) MessageBox.Show("Success!");
      }
    }

    private void cmdReadCard_Click(object sender, EventArgs e)
    {
      if (Global_Data.Card_Reader_Found_Flag)
      {
        this.Clear_GuestInfo();
        this.Refresh();
        if (this.Read_CardInformattion())
        {
          if (!this.CheckClientData())
          {
            /*this.lblMessage.Text = "Invalid Card!";
            this.lblMessage.Refresh();
            Console.Beep(700, 300);
            Thread.Sleep(500);
            this.lblMessage.Text = "";*/
          }
          else if (!this.CheckBuildingNoFromCard())
          {
            this.lblMessage.Text = "Invalid Card for current building!";
            this.lblMessage.Refresh();
            Console.Beep(700, 300);
            Thread.Sleep(500);
            this.lblMessage.Text = "";
          }
          else
          {
            this.CheckBuildingType();
            this.GetClientData();
          }
        }
        else
          this.Clear_GuestInfo();
      }
      else
      {
        this.lblMessage.Text = "Card Reader Not Found!";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.lblMessage.Text = "";
        this.Clear_GuestInfo();
      }
    }

    private void Frame1_Enter(object sender, EventArgs e)
    {
    }
  }
}
