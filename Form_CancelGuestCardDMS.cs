// Decompiled with JetBrains decompiler
// Type: AMS.Form_CancelGuestCardDMS
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
  public class Form_CancelGuestCardDMS : Form
  {
    private IContainer components;
    public ToolTip ToolTip1;
    public MaskedTextBox mskContractStart;
    public MaskedTextBox mskContractEnd;
    public MaskedTextBox mskValidEnd;
    public CheckBox chkRefund;
    public Button cmdReturn;
    public Button cmdOK;
    public TextBox txtExtraTotal;
    public TextBox _txtDesExtra_4;
    public TextBox _txtDesExtra_3;
    public TextBox _txtDesExtra_2;
    public TextBox _txtExtraAmount_4;
    public TextBox _txtExtraAmount_3;
    public TextBox _txtExtraAmount_2;
    public TextBox _txtExtraAmount_1;
    public TextBox _txtDesExtra_1;
    public TextBox _txtExtraAmount_0;
    public TextBox _txtDesExtra_0;
    public Button cmdCancel;
    public TextBox txtClientID;
    public RadioButton _optCard_1;
    public RadioButton _optCard_0;
    public Button cmdPrint;
    public TextBox txtAdvance;
    public TextBox txtCheckInDate;
    public TextBox txtChargeType;
    public TextBox txtBuildingNo;
    public GroupBox Frame1;
    public TextBox txtRoomNo;
    public TextBox txtRoomType;
    public TextBox txtCardNo;
    public TextBox txtRemark;
    public TextBox txtGracePeriod;
    public MaskedTextBox mskValidStart;
    public Label lblMessage1;
    public Label Label29;
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
    public TextBox txtRoomCharge;
    public TextBox txtDeposit;
    public TextBox txtAmountDue;
    public System.Windows.Forms.Timer Timer1;
    public TextBox txtAmountPaid;
    public Label Label30;
    public Label Label20;
    public MaskedTextBox mskCheckOutDate;
    public GroupBox Frame2;
    public TextBox txtGovBond;
    public Label Label32;
    public TextBox txtExtraCharge;
    public GroupBox ChargesFrame;
    public Label Label15;
    public Label Label16;
    public Label Label22;
    public Label Label23;
    public Label lblMessage2;
    public Label lblMessage;
    public Label Label2;
    public Label Label1;
    public TextBox txtExtraDescription;
    public GroupBox ExtraChargeFrame;
    public Label lblExtraTotal;
    public Label lblMessage3;
    public Panel Frame3;
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
    public Label LabelSearchRoom;
    public Label Label26;
    public Label Label31;
    public Label lbRefund;
    public TextBox txtRefundAmount;
    public Panel RefundFrame;
    private Button button_Select;
    private Button button_CheckCard;
    private ComboBox comboBox_txtSearchRoom;
    public Label label7;
    public TextBox textBox_Email;
    public Label label33;
    public Label label21;
    private string bld_no = "";
    private string floor_no = "";
    private string room_no = "";
    private string Begin_Date = "";
    private string End_Date;
    private string Room_No_Calculated = "";
    private bool bWoCard = true;
    private string sCardBuildingNo = "";
    private DB db = new DB();
    private string sBuildingType;
    private double sKeyDeposit;
    private bool bRefund;
    private string sCAdvance = "";
    private string sNewGSTRate = "";
    private bool bBondRefund;
    private bool bUnitClear;
    private string sCalculatedRefund = "";
    private string sGovBondTemp = "";
    private string sCBond = "";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_CancelGuestCardDMS));
      this.ToolTip1 = new ToolTip(this.components);
      this.mskContractStart = new MaskedTextBox();
      this.mskContractEnd = new MaskedTextBox();
      this.mskValidEnd = new MaskedTextBox();
      this.chkRefund = new CheckBox();
      this.cmdReturn = new Button();
      this.cmdOK = new Button();
      this.txtExtraTotal = new TextBox();
      this._txtDesExtra_4 = new TextBox();
      this._txtDesExtra_3 = new TextBox();
      this._txtDesExtra_2 = new TextBox();
      this._txtExtraAmount_4 = new TextBox();
      this._txtExtraAmount_3 = new TextBox();
      this._txtExtraAmount_2 = new TextBox();
      this._txtExtraAmount_1 = new TextBox();
      this._txtDesExtra_1 = new TextBox();
      this._txtExtraAmount_0 = new TextBox();
      this._txtDesExtra_0 = new TextBox();
      this.cmdCancel = new Button();
      this.txtClientID = new TextBox();
      this._optCard_1 = new RadioButton();
      this._optCard_0 = new RadioButton();
      this.cmdPrint = new Button();
      this.textBox_Email = new TextBox();
      this.txtAdvance = new TextBox();
      this.txtCheckInDate = new TextBox();
      this.txtChargeType = new TextBox();
      this.txtBuildingNo = new TextBox();
      this.Frame1 = new GroupBox();
      this.mskCheckOutDate = new MaskedTextBox();
      this.txtRoomNo = new TextBox();
      this.txtRoomType = new TextBox();
      this.txtCardNo = new TextBox();
      this.txtRemark = new TextBox();
      this.txtGracePeriod = new TextBox();
      this.mskValidStart = new MaskedTextBox();
      this.lblMessage1 = new Label();
      this.Label29 = new Label();
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
      this.txtRoomCharge = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtAmountDue = new TextBox();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.txtAmountPaid = new TextBox();
      this.Label30 = new Label();
      this.Label20 = new Label();
      this.Frame2 = new GroupBox();
      this.txtGovBond = new TextBox();
      this.Label32 = new Label();
      this.txtExtraCharge = new TextBox();
      this.ChargesFrame = new GroupBox();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.Label22 = new Label();
      this.Label23 = new Label();
      this.lblMessage2 = new Label();
      this.lblMessage = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.txtExtraDescription = new TextBox();
      this.ExtraChargeFrame = new GroupBox();
      this.label33 = new Label();
      this.label21 = new Label();
      this.lblExtraTotal = new Label();
      this.lblMessage3 = new Label();
      this.Frame3 = new Panel();
      this.label7 = new Label();
      this.comboBox_txtSearchRoom = new ComboBox();
      this.button_CheckCard = new Button();
      this.button_Select = new Button();
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
      this.LabelSearchRoom = new Label();
      this.Label26 = new Label();
      this.Label31 = new Label();
      this.lbRefund = new Label();
      this.txtRefundAmount = new TextBox();
      this.RefundFrame = new Panel();
      this.Frame1.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.ChargesFrame.SuspendLayout();
      this.ExtraChargeFrame.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.RefundFrame.SuspendLayout();
      this.SuspendLayout();
      this.mskContractStart.AllowPromptAsInput = false;
      this.mskContractStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractStart.ForeColor = Color.Blue;
      this.mskContractStart.Location = new Point(104, 88);
      this.mskContractStart.Mask = "####-##-##";
      this.mskContractStart.Name = "mskContractStart";
      this.mskContractStart.Size = new Size(81, 20);
      this.mskContractStart.TabIndex = 8;
      this.ToolTip1.SetToolTip((Control) this.mskContractStart, "Press any key to enter contract start date.");
      this.mskContractEnd.AllowPromptAsInput = false;
      this.mskContractEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskContractEnd.ForeColor = Color.Blue;
      this.mskContractEnd.Location = new Point(280, 88);
      this.mskContractEnd.Mask = "####-##-##";
      this.mskContractEnd.Name = "mskContractEnd";
      this.mskContractEnd.Size = new Size(81, 20);
      this.mskContractEnd.TabIndex = 9;
      this.ToolTip1.SetToolTip((Control) this.mskContractEnd, "Press any key to enter contract end date.");
      this.mskValidEnd.AllowPromptAsInput = false;
      this.mskValidEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidEnd.ForeColor = Color.Blue;
      this.mskValidEnd.Location = new Point(280, 120);
      this.mskValidEnd.Mask = "####-##-##";
      this.mskValidEnd.Name = "mskValidEnd";
      this.mskValidEnd.PromptChar = ' ';
      this.mskValidEnd.Size = new Size(81, 20);
      this.mskValidEnd.TabIndex = 11;
      this.ToolTip1.SetToolTip((Control) this.mskValidEnd, "Press any key to enter Valid End date.");
      this.chkRefund.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.chkRefund.Cursor = Cursors.Default;
      this.chkRefund.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkRefund.ForeColor = SystemColors.ControlText;
      this.chkRefund.Location = new Point(8, 0);
      this.chkRefund.Name = "chkRefund";
      this.chkRefund.RightToLeft = RightToLeft.No;
      this.chkRefund.Size = new Size(121, 17);
      this.chkRefund.TabIndex = 53;
      this.chkRefund.Text = "Refund Bond";
      this.ToolTip1.SetToolTip((Control) this.chkRefund, "Tick to Refund Bond Directly to Guest (OR) Unclick to Refund by RBA.");
      this.chkRefund.UseVisualStyleBackColor = false;
      this.chkRefund.CheckedChanged += new EventHandler(this.chkRefund_CheckedChanged);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(730, 520);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(52, 47);
      this.cmdReturn.TabIndex = 83;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Operation Menu Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdOK.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdOK.Cursor = Cursors.Default;
      this.cmdOK.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdOK.ForeColor = SystemColors.ControlText;
      this.cmdOK.Location = new Point(416, 248);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.RightToLeft = RightToLeft.No;
      this.cmdOK.Size = new Size(89, 33);
      this.cmdOK.TabIndex = 92;
      this.cmdOK.Text = "OK";
      this.ToolTip1.SetToolTip((Control) this.cmdOK, "Click to Back Check Out Frame");
      this.cmdOK.UseVisualStyleBackColor = false;
      this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
      this.txtExtraTotal.AcceptsReturn = true;
      this.txtExtraTotal.BackColor = Color.FromArgb(192, 192, 192);
      this.txtExtraTotal.Cursor = Cursors.IBeam;
      this.txtExtraTotal.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtExtraTotal.ForeColor = Color.FromArgb(0, 0, 192);
      this.txtExtraTotal.Location = new Point(416, 213);
      this.txtExtraTotal.MaxLength = 0;
      this.txtExtraTotal.Name = "txtExtraTotal";
      this.txtExtraTotal.ReadOnly = true;
      this.txtExtraTotal.RightToLeft = RightToLeft.No;
      this.txtExtraTotal.Size = new Size(89, 22);
      this.txtExtraTotal.TabIndex = 91;
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtExtraTotal, "Total Extra Charge Amount");
      this._txtDesExtra_4.AcceptsReturn = true;
      this._txtDesExtra_4.BackColor = SystemColors.Window;
      this._txtDesExtra_4.Cursor = Cursors.IBeam;
      this._txtDesExtra_4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtDesExtra_4.ForeColor = SystemColors.WindowText;
      this._txtDesExtra_4.Location = new Point(16, 181);
      this._txtDesExtra_4.MaxLength = 50;
      this._txtDesExtra_4.Name = "_txtDesExtra_4";
      this._txtDesExtra_4.RightToLeft = RightToLeft.No;
      this._txtDesExtra_4.Size = new Size(393, 20);
      this._txtDesExtra_4.TabIndex = 89;
      this.ToolTip1.SetToolTip((Control) this._txtDesExtra_4, "Extra Charge Description");
      this._txtDesExtra_4.Visible = false;
      this._txtDesExtra_4.KeyPress += new KeyPressEventHandler(this._txtDesExtra_4_KeyPress);
      this._txtDesExtra_3.AcceptsReturn = true;
      this._txtDesExtra_3.BackColor = SystemColors.Window;
      this._txtDesExtra_3.Cursor = Cursors.IBeam;
      this._txtDesExtra_3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtDesExtra_3.ForeColor = SystemColors.WindowText;
      this._txtDesExtra_3.Location = new Point(16, 149);
      this._txtDesExtra_3.MaxLength = 50;
      this._txtDesExtra_3.Name = "_txtDesExtra_3";
      this._txtDesExtra_3.RightToLeft = RightToLeft.No;
      this._txtDesExtra_3.Size = new Size(393, 20);
      this._txtDesExtra_3.TabIndex = 87;
      this.ToolTip1.SetToolTip((Control) this._txtDesExtra_3, "Extra Charge Description");
      this._txtDesExtra_3.Visible = false;
      this._txtDesExtra_3.KeyPress += new KeyPressEventHandler(this._txtDesExtra_3_KeyPress);
      this._txtDesExtra_2.AcceptsReturn = true;
      this._txtDesExtra_2.BackColor = SystemColors.Window;
      this._txtDesExtra_2.Cursor = Cursors.IBeam;
      this._txtDesExtra_2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtDesExtra_2.ForeColor = SystemColors.WindowText;
      this._txtDesExtra_2.Location = new Point(16, 117);
      this._txtDesExtra_2.MaxLength = 50;
      this._txtDesExtra_2.Name = "_txtDesExtra_2";
      this._txtDesExtra_2.RightToLeft = RightToLeft.No;
      this._txtDesExtra_2.Size = new Size(393, 20);
      this._txtDesExtra_2.TabIndex = 85;
      this.ToolTip1.SetToolTip((Control) this._txtDesExtra_2, "Extra Charge Description");
      this._txtDesExtra_2.Visible = false;
      this._txtDesExtra_2.KeyPress += new KeyPressEventHandler(this._txtDesExtra_2_KeyPress);
      this._txtExtraAmount_4.AcceptsReturn = true;
      this._txtExtraAmount_4.BackColor = SystemColors.Window;
      this._txtExtraAmount_4.Cursor = Cursors.IBeam;
      this._txtExtraAmount_4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtExtraAmount_4.ForeColor = SystemColors.WindowText;
      this._txtExtraAmount_4.Location = new Point(416, 181);
      this._txtExtraAmount_4.MaxLength = 0;
      this._txtExtraAmount_4.Name = "_txtExtraAmount_4";
      this._txtExtraAmount_4.RightToLeft = RightToLeft.No;
      this._txtExtraAmount_4.Size = new Size(89, 20);
      this._txtExtraAmount_4.TabIndex = 90;
      this._txtExtraAmount_4.Text = "0.00";
      this._txtExtraAmount_4.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this._txtExtraAmount_4, "Extra Charge Amount");
      this._txtExtraAmount_4.Visible = false;
      this._txtExtraAmount_4.KeyUp += new KeyEventHandler(this._txtExtraAmount_4_KeyUp);
      this._txtExtraAmount_4.KeyPress += new KeyPressEventHandler(this._txtExtraAmount_4_KeyPress);
      this._txtExtraAmount_3.AcceptsReturn = true;
      this._txtExtraAmount_3.BackColor = SystemColors.Window;
      this._txtExtraAmount_3.Cursor = Cursors.IBeam;
      this._txtExtraAmount_3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtExtraAmount_3.ForeColor = SystemColors.WindowText;
      this._txtExtraAmount_3.Location = new Point(416, 149);
      this._txtExtraAmount_3.MaxLength = 0;
      this._txtExtraAmount_3.Name = "_txtExtraAmount_3";
      this._txtExtraAmount_3.RightToLeft = RightToLeft.No;
      this._txtExtraAmount_3.Size = new Size(89, 20);
      this._txtExtraAmount_3.TabIndex = 88;
      this._txtExtraAmount_3.Text = "0.00";
      this._txtExtraAmount_3.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this._txtExtraAmount_3, "Extra Charge Amount");
      this._txtExtraAmount_3.Visible = false;
      this._txtExtraAmount_3.KeyUp += new KeyEventHandler(this._txtExtraAmount_3_KeyUp);
      this._txtExtraAmount_3.KeyPress += new KeyPressEventHandler(this._txtExtraAmount_3_KeyPress);
      this._txtExtraAmount_2.AcceptsReturn = true;
      this._txtExtraAmount_2.BackColor = SystemColors.Window;
      this._txtExtraAmount_2.Cursor = Cursors.IBeam;
      this._txtExtraAmount_2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtExtraAmount_2.ForeColor = SystemColors.WindowText;
      this._txtExtraAmount_2.Location = new Point(416, 117);
      this._txtExtraAmount_2.MaxLength = 0;
      this._txtExtraAmount_2.Name = "_txtExtraAmount_2";
      this._txtExtraAmount_2.RightToLeft = RightToLeft.No;
      this._txtExtraAmount_2.Size = new Size(89, 20);
      this._txtExtraAmount_2.TabIndex = 86;
      this._txtExtraAmount_2.Text = "0.00";
      this._txtExtraAmount_2.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this._txtExtraAmount_2, "Extra Charge Amount");
      this._txtExtraAmount_2.Visible = false;
      this._txtExtraAmount_2.KeyUp += new KeyEventHandler(this._txtExtraAmount_2_KeyUp);
      this._txtExtraAmount_2.KeyPress += new KeyPressEventHandler(this._txtExtraAmount_2_KeyPress);
      this._txtExtraAmount_1.AcceptsReturn = true;
      this._txtExtraAmount_1.BackColor = SystemColors.Window;
      this._txtExtraAmount_1.Cursor = Cursors.IBeam;
      this._txtExtraAmount_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtExtraAmount_1.ForeColor = SystemColors.WindowText;
      this._txtExtraAmount_1.Location = new Point(416, 85);
      this._txtExtraAmount_1.MaxLength = 0;
      this._txtExtraAmount_1.Name = "_txtExtraAmount_1";
      this._txtExtraAmount_1.RightToLeft = RightToLeft.No;
      this._txtExtraAmount_1.Size = new Size(89, 20);
      this._txtExtraAmount_1.TabIndex = 84;
      this._txtExtraAmount_1.Text = "0.00";
      this._txtExtraAmount_1.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this._txtExtraAmount_1, "Extra Charge Amount");
      this._txtExtraAmount_1.Visible = false;
      this._txtExtraAmount_1.KeyUp += new KeyEventHandler(this._txtExtraAmount_1_KeyUp);
      this._txtExtraAmount_1.KeyPress += new KeyPressEventHandler(this._txtExtraAmount_1_KeyPress);
      this._txtDesExtra_1.AcceptsReturn = true;
      this._txtDesExtra_1.BackColor = SystemColors.Window;
      this._txtDesExtra_1.Cursor = Cursors.IBeam;
      this._txtDesExtra_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtDesExtra_1.ForeColor = SystemColors.WindowText;
      this._txtDesExtra_1.Location = new Point(16, 85);
      this._txtDesExtra_1.MaxLength = 50;
      this._txtDesExtra_1.Name = "_txtDesExtra_1";
      this._txtDesExtra_1.RightToLeft = RightToLeft.No;
      this._txtDesExtra_1.Size = new Size(393, 20);
      this._txtDesExtra_1.TabIndex = 83;
      this.ToolTip1.SetToolTip((Control) this._txtDesExtra_1, "Extra Charge Description");
      this._txtDesExtra_1.Visible = false;
      this._txtDesExtra_1.KeyPress += new KeyPressEventHandler(this._txtDesExtra_1_KeyPress);
      this._txtExtraAmount_0.AcceptsReturn = true;
      this._txtExtraAmount_0.BackColor = SystemColors.Window;
      this._txtExtraAmount_0.Cursor = Cursors.IBeam;
      this._txtExtraAmount_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtExtraAmount_0.ForeColor = SystemColors.WindowText;
      this._txtExtraAmount_0.Location = new Point(416, 53);
      this._txtExtraAmount_0.MaxLength = 0;
      this._txtExtraAmount_0.Name = "_txtExtraAmount_0";
      this._txtExtraAmount_0.RightToLeft = RightToLeft.No;
      this._txtExtraAmount_0.Size = new Size(89, 20);
      this._txtExtraAmount_0.TabIndex = 82;
      this._txtExtraAmount_0.Text = "0.00";
      this._txtExtraAmount_0.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this._txtExtraAmount_0, "Extra Charge Amount");
      this._txtExtraAmount_0.KeyUp += new KeyEventHandler(this._txtExtraAmount_0_KeyUp);
      this._txtExtraAmount_0.KeyPress += new KeyPressEventHandler(this._txtExtraAmount_0_KeyPress);
      this._txtDesExtra_0.AcceptsReturn = true;
      this._txtDesExtra_0.BackColor = SystemColors.Window;
      this._txtDesExtra_0.Cursor = Cursors.IBeam;
      this._txtDesExtra_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._txtDesExtra_0.ForeColor = SystemColors.WindowText;
      this._txtDesExtra_0.Location = new Point(16, 53);
      this._txtDesExtra_0.MaxLength = 50;
      this._txtDesExtra_0.Name = "_txtDesExtra_0";
      this._txtDesExtra_0.RightToLeft = RightToLeft.No;
      this._txtDesExtra_0.Size = new Size(393, 20);
      this._txtDesExtra_0.TabIndex = 81;
      this.ToolTip1.SetToolTip((Control) this._txtDesExtra_0, "Extra Charge Description");
      this._txtDesExtra_0.KeyPress += new KeyPressEventHandler(this._txtDesExtra_0_KeyPress);
      this.cmdCancel.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.cmdCancel.Cursor = Cursors.Default;
      this.cmdCancel.Enabled = false;
      this.cmdCancel.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = SystemColors.ControlText;
      this.cmdCancel.Image = (Image) componentResourceManager.GetObject("cmdCancel.Image");
      this.cmdCancel.Location = new Point(618, 520);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.RightToLeft = RightToLeft.No;
      this.cmdCancel.Size = new Size(52, 47);
      this.cmdCancel.TabIndex = 81;
      this.cmdCancel.Text = "&Cancel";
      this.cmdCancel.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdCancel, "Confirm to Check Out/Clear Card");
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.Blue;
      this.txtClientID.Location = new Point(104, 48);
      this.txtClientID.MaxLength = 0;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.ReadOnly = true;
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(105, 20);
      this.txtClientID.TabIndex = 69;
      this.ToolTip1.SetToolTip((Control) this.txtClientID, "Guest ID");
      this._optCard_1.BackColor = Color.Yellow;
      this._optCard_1.Cursor = Cursors.Default;
      this._optCard_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCard_1.ForeColor = SystemColors.ControlText;
      this._optCard_1.Location = new Point(322, 15);
      this._optCard_1.Name = "_optCard_1";
      this._optCard_1.RightToLeft = RightToLeft.No;
      this._optCard_1.Size = new Size(97, 24);
      this._optCard_1.TabIndex = 59;
      this._optCard_1.Text = "Without Card";
      this.ToolTip1.SetToolTip((Control) this._optCard_1, "Without Card Selection");
      this._optCard_1.UseVisualStyleBackColor = false;
      this._optCard_1.CheckedChanged += new EventHandler(this._optCard_1_CheckedChanged);
      this._optCard_0.BackColor = Color.Yellow;
      this._optCard_0.Checked = true;
      this._optCard_0.Cursor = Cursors.Default;
      this._optCard_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCard_0.ForeColor = SystemColors.ControlText;
      this._optCard_0.Location = new Point(431, 15);
      this._optCard_0.Name = "_optCard_0";
      this._optCard_0.RightToLeft = RightToLeft.No;
      this._optCard_0.Size = new Size(97, 23);
      this._optCard_0.TabIndex = 58;
      this._optCard_0.TabStop = true;
      this._optCard_0.Text = "With Card";
      this.ToolTip1.SetToolTip((Control) this._optCard_0, "With Card Selection");
      this._optCard_0.UseVisualStyleBackColor = false;
      this._optCard_0.CheckedChanged += new EventHandler(this._optCard_0_CheckedChanged);
      this.cmdPrint.BackColor = Color.Yellow;
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(674, 520);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(52, 47);
      this.cmdPrint.TabIndex = 82;
      this.cmdPrint.Text = "&Print Receipt";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdPrint, "Click to Print Receipt");
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.textBox_Email.AcceptsReturn = true;
      this.textBox_Email.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.textBox_Email.Cursor = Cursors.IBeam;
      this.textBox_Email.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox_Email.ForeColor = SystemColors.WindowText;
      this.textBox_Email.Location = new Point(105, 196);
      this.textBox_Email.MaxLength = 30;
      this.textBox_Email.Name = "textBox_Email";
      this.textBox_Email.RightToLeft = RightToLeft.No;
      this.textBox_Email.Size = new Size(282, 26);
      this.textBox_Email.TabIndex = 83;
      this.ToolTip1.SetToolTip((Control) this.textBox_Email, "Email Address");
      this.txtAdvance.AcceptsReturn = true;
      this.txtAdvance.BackColor = SystemColors.Window;
      this.txtAdvance.Cursor = Cursors.IBeam;
      this.txtAdvance.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAdvance.ForeColor = SystemColors.WindowText;
      this.txtAdvance.Location = new Point(104, 184);
      this.txtAdvance.MaxLength = 0;
      this.txtAdvance.Name = "txtAdvance";
      this.txtAdvance.ReadOnly = true;
      this.txtAdvance.RightToLeft = RightToLeft.No;
      this.txtAdvance.Size = new Size(81, 20);
      this.txtAdvance.TabIndex = 0;
      this.txtAdvance.Text = "0.00";
      this.txtAdvance.TextAlign = HorizontalAlignment.Center;
      this.txtCheckInDate.AcceptsReturn = true;
      this.txtCheckInDate.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtCheckInDate.Cursor = Cursors.IBeam;
      this.txtCheckInDate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCheckInDate.ForeColor = SystemColors.WindowText;
      this.txtCheckInDate.Location = new Point(280, 152);
      this.txtCheckInDate.MaxLength = 0;
      this.txtCheckInDate.Name = "txtCheckInDate";
      this.txtCheckInDate.RightToLeft = RightToLeft.No;
      this.txtCheckInDate.Size = new Size(81, 20);
      this.txtCheckInDate.TabIndex = 47;
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
      this.txtChargeType.TabIndex = 41;
      this.txtChargeType.TextAlign = HorizontalAlignment.Center;
      this.txtBuildingNo.AcceptsReturn = true;
      this.txtBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtBuildingNo.Cursor = Cursors.IBeam;
      this.txtBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingNo.ForeColor = SystemColors.WindowText;
      this.txtBuildingNo.Location = new Point(104, 24);
      this.txtBuildingNo.MaxLength = 0;
      this.txtBuildingNo.Name = "txtBuildingNo";
      this.txtBuildingNo.ReadOnly = true;
      this.txtBuildingNo.RightToLeft = RightToLeft.No;
      this.txtBuildingNo.Size = new Size(81, 20);
      this.txtBuildingNo.TabIndex = 40;
      this.Frame1.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.Frame1.Controls.Add((Control) this.mskCheckOutDate);
      this.Frame1.Controls.Add((Control) this.txtCheckInDate);
      this.Frame1.Controls.Add((Control) this.txtBuildingNo);
      this.Frame1.Controls.Add((Control) this.txtRoomNo);
      this.Frame1.Controls.Add((Control) this.txtRoomType);
      this.Frame1.Controls.Add((Control) this.txtCardNo);
      this.Frame1.Controls.Add((Control) this.txtRemark);
      this.Frame1.Controls.Add((Control) this.txtGracePeriod);
      this.Frame1.Controls.Add((Control) this.mskContractStart);
      this.Frame1.Controls.Add((Control) this.mskContractEnd);
      this.Frame1.Controls.Add((Control) this.mskValidStart);
      this.Frame1.Controls.Add((Control) this.mskValidEnd);
      this.Frame1.Controls.Add((Control) this.lblMessage1);
      this.Frame1.Controls.Add((Control) this.Label29);
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
      this.Frame1.Location = new Point(4, 281);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(553, 241);
      this.Frame1.TabIndex = 86;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "Client Account";
      this.mskCheckOutDate.AllowPromptAsInput = false;
      this.mskCheckOutDate.Enabled = false;
      this.mskCheckOutDate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskCheckOutDate.ForeColor = Color.Blue;
      this.mskCheckOutDate.Location = new Point(369, 120);
      this.mskCheckOutDate.Mask = "####-##-##";
      this.mskCheckOutDate.Name = "mskCheckOutDate";
      this.mskCheckOutDate.Size = new Size(81, 20);
      this.mskCheckOutDate.TabIndex = 87;
      this.txtRoomNo.AcceptsReturn = true;
      this.txtRoomNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtRoomNo.Cursor = Cursors.IBeam;
      this.txtRoomNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.ForeColor = SystemColors.WindowText;
      this.txtRoomNo.Location = new Point(280, 24);
      this.txtRoomNo.MaxLength = 0;
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.ReadOnly = true;
      this.txtRoomNo.RightToLeft = RightToLeft.No;
      this.txtRoomNo.Size = new Size(73, 20);
      this.txtRoomNo.TabIndex = 39;
      this.txtRoomType.AcceptsReturn = true;
      this.txtRoomType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtRoomType.Cursor = Cursors.IBeam;
      this.txtRoomType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomType.ForeColor = SystemColors.WindowText;
      this.txtRoomType.Location = new Point(360, 24);
      this.txtRoomType.MaxLength = 0;
      this.txtRoomType.Name = "txtRoomType";
      this.txtRoomType.ReadOnly = true;
      this.txtRoomType.RightToLeft = RightToLeft.No;
      this.txtRoomType.Size = new Size(73, 20);
      this.txtRoomType.TabIndex = 28;
      this.txtCardNo.AcceptsReturn = true;
      this.txtCardNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtCardNo.Cursor = Cursors.IBeam;
      this.txtCardNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCardNo.ForeColor = Color.Red;
      this.txtCardNo.Location = new Point(280, 56);
      this.txtCardNo.MaxLength = 0;
      this.txtCardNo.Name = "txtCardNo";
      this.txtCardNo.ReadOnly = true;
      this.txtCardNo.RightToLeft = RightToLeft.No;
      this.txtCardNo.Size = new Size(73, 20);
      this.txtCardNo.TabIndex = 26;
      this.txtCardNo.TextAlign = HorizontalAlignment.Center;
      this.txtRemark.AcceptsReturn = true;
      this.txtRemark.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
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
      this.txtRemark.TabIndex = 13;
      this.txtGracePeriod.AcceptsReturn = true;
      this.txtGracePeriod.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtGracePeriod.Cursor = Cursors.IBeam;
      this.txtGracePeriod.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGracePeriod.ForeColor = SystemColors.WindowText;
      this.txtGracePeriod.Location = new Point(104, 152);
      this.txtGracePeriod.MaxLength = 0;
      this.txtGracePeriod.Name = "txtGracePeriod";
      this.txtGracePeriod.ReadOnly = true;
      this.txtGracePeriod.RightToLeft = RightToLeft.No;
      this.txtGracePeriod.Size = new Size(41, 20);
      this.txtGracePeriod.TabIndex = 12;
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
      this.mskValidStart.TabIndex = 10;
      this.lblMessage1.BackColor = Color.Transparent;
      this.lblMessage1.Cursor = Cursors.Default;
      this.lblMessage1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage1.ForeColor = Color.Blue;
      this.lblMessage1.Location = new Point(360, 56);
      this.lblMessage1.Name = "lblMessage1";
      this.lblMessage1.RightToLeft = RightToLeft.No;
      this.lblMessage1.Size = new Size(177, 25);
      this.lblMessage1.TabIndex = 50;
      this.Label29.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label29.Cursor = Cursors.Default;
      this.Label29.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label29.ForeColor = SystemColors.ControlText;
      this.Label29.Location = new Point(200, 152);
      this.Label29.Name = "Label29";
      this.Label29.RightToLeft = RightToLeft.No;
      this.Label29.Size = new Size(73, 17);
      this.Label29.TabIndex = 46;
      this.Label29.Text = "Check In Date";
      this.Label29.TextAlign = ContentAlignment.TopRight;
      this.Label13.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.ControlText;
      this.Label13.Location = new Point(456, 120);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(81, 17);
      this.Label13.TabIndex = 34;
      this.Label13.Text = "Inc.Grace";
      this.lbCardType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lbCardType.BorderStyle = BorderStyle.Fixed3D;
      this.lbCardType.Cursor = Cursors.Default;
      this.lbCardType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbCardType.ForeColor = Color.Blue;
      this.lbCardType.Location = new Point(104, 56);
      this.lbCardType.Name = "lbCardType";
      this.lbCardType.RightToLeft = RightToLeft.No;
      this.lbCardType.Size = new Size(81, 21);
      this.lbCardType.TabIndex = 27;
      this.Label28.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label28.Cursor = Cursors.Default;
      this.Label28.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = SystemColors.ControlText;
      this.Label28.Location = new Point(200, 56);
      this.Label28.Name = "Label28";
      this.Label28.RightToLeft = RightToLeft.No;
      this.Label28.Size = new Size(73, 17);
      this.Label28.TabIndex = 25;
      this.Label28.Text = "Card No.";
      this.Label28.TextAlign = ContentAlignment.TopRight;
      this.Label27.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label27.Cursor = Cursors.Default;
      this.Label27.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label27.ForeColor = SystemColors.ControlText;
      this.Label27.Location = new Point(16, 192);
      this.Label27.Name = "Label27";
      this.Label27.RightToLeft = RightToLeft.No;
      this.Label27.Size = new Size(81, 17);
      this.Label27.TabIndex = 24;
      this.Label27.Text = "Note: ";
      this.Label27.TextAlign = ContentAlignment.TopRight;
      this.Label25.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label25.Cursor = Cursors.Default;
      this.Label25.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = SystemColors.ControlText;
      this.Label25.Location = new Point(200, 120);
      this.Label25.Name = "Label25";
      this.Label25.RightToLeft = RightToLeft.No;
      this.Label25.Size = new Size(73, 17);
      this.Label25.TabIndex = 23;
      this.Label25.Text = "Valid End Date";
      this.Label25.TextAlign = ContentAlignment.TopRight;
      this.Label24.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label24.Cursor = Cursors.Default;
      this.Label24.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = SystemColors.ControlText;
      this.Label24.Location = new Point(16, 120);
      this.Label24.Name = "Label24";
      this.Label24.RightToLeft = RightToLeft.No;
      this.Label24.Size = new Size(81, 17);
      this.Label24.TabIndex = 22;
      this.Label24.Text = "Valid Start Date";
      this.Label24.TextAlign = ContentAlignment.TopRight;
      this.Label19.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label19.Cursor = Cursors.Default;
      this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = SystemColors.ControlText;
      this.Label19.Location = new Point(16, 152);
      this.Label19.Name = "Label19";
      this.Label19.RightToLeft = RightToLeft.No;
      this.Label19.Size = new Size(81, 17);
      this.Label19.TabIndex = 21;
      this.Label19.Text = "Grace Period";
      this.Label19.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(200, 88);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(73, 17);
      this.Label18.TabIndex = 20;
      this.Label18.Text = "Contract End";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(16, 88);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 19;
      this.Label17.Text = "Contract Start";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label14.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = SystemColors.ControlText;
      this.Label14.Location = new Point(200, 24);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(73, 17);
      this.Label14.TabIndex = 18;
      this.Label14.Text = "Room No.";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(16, 24);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(81, 17);
      this.Label12.TabIndex = 17;
      this.Label12.Text = "Building No. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.txtRoomCharge.AcceptsReturn = true;
      this.txtRoomCharge.BackColor = SystemColors.Window;
      this.txtRoomCharge.Cursor = Cursors.IBeam;
      this.txtRoomCharge.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomCharge.ForeColor = SystemColors.WindowText;
      this.txtRoomCharge.Location = new Point(104, 56);
      this.txtRoomCharge.MaxLength = 0;
      this.txtRoomCharge.Name = "txtRoomCharge";
      this.txtRoomCharge.ReadOnly = true;
      this.txtRoomCharge.RightToLeft = RightToLeft.No;
      this.txtRoomCharge.Size = new Size(81, 20);
      this.txtRoomCharge.TabIndex = 38;
      this.txtRoomCharge.TextAlign = HorizontalAlignment.Center;
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = SystemColors.Window;
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = SystemColors.WindowText;
      this.txtDeposit.Location = new Point(104, 88);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.ReadOnly = true;
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(81, 20);
      this.txtDeposit.TabIndex = 36;
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.txtAmountDue.AcceptsReturn = true;
      this.txtAmountDue.BackColor = SystemColors.Window;
      this.txtAmountDue.Cursor = Cursors.IBeam;
      this.txtAmountDue.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmountDue.ForeColor = SystemColors.WindowText;
      this.txtAmountDue.Location = new Point(104, 120);
      this.txtAmountDue.MaxLength = 0;
      this.txtAmountDue.Name = "txtAmountDue";
      this.txtAmountDue.ReadOnly = true;
      this.txtAmountDue.RightToLeft = RightToLeft.No;
      this.txtAmountDue.Size = new Size(81, 20);
      this.txtAmountDue.TabIndex = 14;
      this.txtAmountDue.TextAlign = HorizontalAlignment.Center;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 500;
      this.txtAmountPaid.AcceptsReturn = true;
      this.txtAmountPaid.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.txtAmountPaid.Cursor = Cursors.IBeam;
      this.txtAmountPaid.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmountPaid.ForeColor = Color.Red;
      this.txtAmountPaid.Location = new Point(104, 152);
      this.txtAmountPaid.MaxLength = 0;
      this.txtAmountPaid.Name = "txtAmountPaid";
      this.txtAmountPaid.ReadOnly = true;
      this.txtAmountPaid.RightToLeft = RightToLeft.No;
      this.txtAmountPaid.Size = new Size(81, 20);
      this.txtAmountPaid.TabIndex = 15;
      this.txtAmountPaid.TextAlign = HorizontalAlignment.Center;
      this.Label30.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label30.Cursor = Cursors.Default;
      this.Label30.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label30.ForeColor = SystemColors.ControlText;
      this.Label30.Location = new Point(8, 184);
      this.Label30.Name = "Label30";
      this.Label30.RightToLeft = RightToLeft.No;
      this.Label30.Size = new Size(81, 17);
      this.Label30.TabIndex = 45;
      this.Label30.Text = "Advanced ";
      this.Label30.TextAlign = ContentAlignment.TopRight;
      this.Label20.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label20.Cursor = Cursors.Default;
      this.Label20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = SystemColors.ControlText;
      this.Label20.Location = new Point(8, 56);
      this.Label20.Name = "Label20";
      this.Label20.RightToLeft = RightToLeft.No;
      this.Label20.Size = new Size(81, 17);
      this.Label20.TabIndex = 37;
      this.Label20.Text = "Room Rate";
      this.Label20.TextAlign = ContentAlignment.TopRight;
      this.Frame2.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.Frame2.Controls.Add((Control) this.chkRefund);
      this.Frame2.Controls.Add((Control) this.txtGovBond);
      this.Frame2.Controls.Add((Control) this.Label32);
      this.Frame2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = SystemColors.ControlText;
      this.Frame2.Location = new Point(8, 96);
      this.Frame2.Name = "Frame2";
      this.Frame2.Padding = new Padding(0);
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(185, 65);
      this.Frame2.TabIndex = 51;
      this.Frame2.TabStop = false;
      this.Frame2.Text = "                       ";
      this.txtGovBond.AcceptsReturn = true;
      this.txtGovBond.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtGovBond.Cursor = Cursors.IBeam;
      this.txtGovBond.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGovBond.ForeColor = Color.Blue;
      this.txtGovBond.Location = new Point(96, 24);
      this.txtGovBond.MaxLength = 0;
      this.txtGovBond.Name = "txtGovBond";
      this.txtGovBond.ReadOnly = true;
      this.txtGovBond.RightToLeft = RightToLeft.No;
      this.txtGovBond.Size = new Size(81, 22);
      this.txtGovBond.TabIndex = 52;
      this.txtGovBond.Text = "0.00";
      this.txtGovBond.TextAlign = HorizontalAlignment.Center;
      this.Label32.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label32.Cursor = Cursors.Default;
      this.Label32.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label32.ForeColor = SystemColors.ControlText;
      this.Label32.Location = new Point(8, 24);
      this.Label32.Name = "Label32";
      this.Label32.RightToLeft = RightToLeft.No;
      this.Label32.Size = new Size(81, 25);
      this.Label32.TabIndex = 54;
      this.Label32.Text = "Government Bond";
      this.txtExtraCharge.AcceptsReturn = true;
      this.txtExtraCharge.BackColor = SystemColors.Window;
      this.txtExtraCharge.Cursor = Cursors.IBeam;
      this.txtExtraCharge.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtExtraCharge.ForeColor = SystemColors.WindowText;
      this.txtExtraCharge.Location = new Point(104, 24);
      this.txtExtraCharge.MaxLength = 0;
      this.txtExtraCharge.Name = "txtExtraCharge";
      this.txtExtraCharge.RightToLeft = RightToLeft.No;
      this.txtExtraCharge.Size = new Size(81, 20);
      this.txtExtraCharge.TabIndex = 2;
      this.txtExtraCharge.Text = "0.00";
      this.txtExtraCharge.TextAlign = HorizontalAlignment.Center;
      this.txtExtraCharge.TextChanged += new EventHandler(this.txtExtraCharge_TextChanged);
      this.txtExtraCharge.Click += new EventHandler(this.txtExtraCharge_Click);
      this.txtExtraCharge.KeyPress += new KeyPressEventHandler(this.txtExtraCharge_KeyPress);
      this.ChargesFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.ChargesFrame.Controls.Add((Control) this.txtAdvance);
      this.ChargesFrame.Controls.Add((Control) this.txtChargeType);
      this.ChargesFrame.Controls.Add((Control) this.txtRoomCharge);
      this.ChargesFrame.Controls.Add((Control) this.txtDeposit);
      this.ChargesFrame.Controls.Add((Control) this.txtAmountDue);
      this.ChargesFrame.Controls.Add((Control) this.txtAmountPaid);
      this.ChargesFrame.Controls.Add((Control) this.Label30);
      this.ChargesFrame.Controls.Add((Control) this.Label20);
      this.ChargesFrame.Controls.Add((Control) this.Label15);
      this.ChargesFrame.Controls.Add((Control) this.Label16);
      this.ChargesFrame.Controls.Add((Control) this.Label22);
      this.ChargesFrame.Controls.Add((Control) this.Label23);
      this.ChargesFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ChargesFrame.ForeColor = SystemColors.ControlText;
      this.ChargesFrame.Location = new Point(589, 77);
      this.ChargesFrame.Name = "ChargesFrame";
      this.ChargesFrame.Padding = new Padding(0);
      this.ChargesFrame.RightToLeft = RightToLeft.No;
      this.ChargesFrame.Size = new Size(201, 217);
      this.ChargesFrame.TabIndex = 88;
      this.ChargesFrame.TabStop = false;
      this.ChargesFrame.Text = "Charges";
      this.Label15.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = SystemColors.ControlText;
      this.Label15.Location = new Point(8, 88);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(81, 17);
      this.Label15.TabIndex = 35;
      this.Label15.Text = "Key Deposit";
      this.Label15.TextAlign = ContentAlignment.TopRight;
      this.Label16.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = SystemColors.ControlText;
      this.Label16.Location = new Point(8, 24);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(81, 17);
      this.Label16.TabIndex = 33;
      this.Label16.Text = "Charge Type";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Label22.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label22.Cursor = Cursors.Default;
      this.Label22.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = SystemColors.ControlText;
      this.Label22.Location = new Point(8, 120);
      this.Label22.Name = "Label22";
      this.Label22.RightToLeft = RightToLeft.No;
      this.Label22.Size = new Size(81, 17);
      this.Label22.TabIndex = 32;
      this.Label22.Text = "Amount Paid";
      this.Label22.TextAlign = ContentAlignment.TopRight;
      this.Label23.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label23.Cursor = Cursors.Default;
      this.Label23.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = SystemColors.ControlText;
      this.Label23.Location = new Point(8, 152);
      this.Label23.Name = "Label23";
      this.Label23.RightToLeft = RightToLeft.No;
      this.Label23.Size = new Size(81, 17);
      this.Label23.TabIndex = 31;
      this.Label23.Text = "Last Received";
      this.Label23.TextAlign = ContentAlignment.TopRight;
      this.lblMessage2.BackColor = Color.White;
      this.lblMessage2.Cursor = Cursors.Default;
      this.lblMessage2.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage2.ForeColor = Color.Blue;
      this.lblMessage2.Location = new Point(331, 520);
      this.lblMessage2.Name = "lblMessage2";
      this.lblMessage2.RightToLeft = RightToLeft.No;
      this.lblMessage2.Size = new Size(281, 49);
      this.lblMessage2.TabIndex = 91;
      this.lblMessage2.TextAlign = ContentAlignment.TopCenter;
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(3, 520);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(329, 49);
      this.lblMessage.TabIndex = 90;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(5, 29);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 33);
      this.Label2.TabIndex = 85;
      this.Label2.Text = "CHECK OUT / CANCEL CARD AFTER CHECK OUT";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(5, -3);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 49);
      this.Label1.TabIndex = 84;
      this.Label1.Text = "Operation Mode ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.txtExtraDescription.AcceptsReturn = true;
      this.txtExtraDescription.BackColor = SystemColors.Window;
      this.txtExtraDescription.Cursor = Cursors.IBeam;
      this.txtExtraDescription.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtExtraDescription.ForeColor = SystemColors.WindowText;
      this.txtExtraDescription.Location = new Point(8, 24);
      this.txtExtraDescription.MaxLength = 30;
      this.txtExtraDescription.Name = "txtExtraDescription";
      this.txtExtraDescription.RightToLeft = RightToLeft.No;
      this.txtExtraDescription.Size = new Size(89, 20);
      this.txtExtraDescription.TabIndex = 1;
      this.txtExtraDescription.Click += new EventHandler(this.txtExtraDescription_Click);
      this.txtExtraDescription.KeyPress += new KeyPressEventHandler(this.txtExtraDescription_KeyPress);
      this.ExtraChargeFrame.BackColor = SystemColors.Control;
      this.ExtraChargeFrame.Controls.Add((Control) this.label33);
      this.ExtraChargeFrame.Controls.Add((Control) this.label21);
      this.ExtraChargeFrame.Controls.Add((Control) this.cmdOK);
      this.ExtraChargeFrame.Controls.Add((Control) this.txtExtraTotal);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtDesExtra_4);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtDesExtra_3);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtDesExtra_2);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtExtraAmount_4);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtExtraAmount_3);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtExtraAmount_2);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtExtraAmount_1);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtDesExtra_1);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtExtraAmount_0);
      this.ExtraChargeFrame.Controls.Add((Control) this._txtDesExtra_0);
      this.ExtraChargeFrame.Controls.Add((Control) this.lblExtraTotal);
      this.ExtraChargeFrame.Controls.Add((Control) this.lblMessage3);
      this.ExtraChargeFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ExtraChargeFrame.ForeColor = Color.FromArgb(0, 0, 128);
      this.ExtraChargeFrame.Location = new Point(22, 175);
      this.ExtraChargeFrame.Name = "ExtraChargeFrame";
      this.ExtraChargeFrame.Padding = new Padding(0);
      this.ExtraChargeFrame.RightToLeft = RightToLeft.No;
      this.ExtraChargeFrame.Size = new Size(521, 329);
      this.ExtraChargeFrame.TabIndex = 93;
      this.ExtraChargeFrame.TabStop = false;
      this.ExtraChargeFrame.Text = "Other Charges List";
      this.ExtraChargeFrame.Visible = false;
      this.ExtraChargeFrame.Leave += new EventHandler(this.ExtraChargeFrame_Leave);
      this.ExtraChargeFrame.Enter += new EventHandler(this.ExtraChargeFrame_Enter);
      this.label33.BackColor = SystemColors.Control;
      this.label33.Cursor = Cursors.Default;
      this.label33.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label33.ForeColor = Color.Blue;
      this.label33.Location = new Point(420, 22);
      this.label33.Name = "label33";
      this.label33.RightToLeft = RightToLeft.No;
      this.label33.Size = new Size(85, 25);
      this.label33.TabIndex = 96;
      this.label33.Text = "Amount";
      this.label33.TextAlign = ContentAlignment.MiddleCenter;
      this.label21.BackColor = SystemColors.Control;
      this.label21.Cursor = Cursors.Default;
      this.label21.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label21.ForeColor = Color.Blue;
      this.label21.Location = new Point(17, 25);
      this.label21.Name = "label21";
      this.label21.RightToLeft = RightToLeft.No;
      this.label21.Size = new Size(85, 25);
      this.label21.TabIndex = 95;
      this.label21.Text = "Description";
      this.label21.TextAlign = ContentAlignment.MiddleCenter;
      this.lblExtraTotal.BackColor = SystemColors.Control;
      this.lblExtraTotal.Cursor = Cursors.Default;
      this.lblExtraTotal.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblExtraTotal.ForeColor = Color.Blue;
      this.lblExtraTotal.Location = new Point(208, 213);
      this.lblExtraTotal.Name = "lblExtraTotal";
      this.lblExtraTotal.RightToLeft = RightToLeft.No;
      this.lblExtraTotal.Size = new Size(201, 25);
      this.lblExtraTotal.TabIndex = 94;
      this.lblExtraTotal.Text = "Total Extra Charges  ";
      this.lblExtraTotal.TextAlign = ContentAlignment.TopRight;
      this.lblMessage3.BackColor = SystemColors.Control;
      this.lblMessage3.Cursor = Cursors.Default;
      this.lblMessage3.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage3.ForeColor = Color.Red;
      this.lblMessage3.Location = new Point(16, 298);
      this.lblMessage3.Name = "lblMessage3";
      this.lblMessage3.RightToLeft = RightToLeft.No;
      this.lblMessage3.Size = new Size(489, 23);
      this.lblMessage3.TabIndex = 93;
      this.lblMessage3.TextAlign = ContentAlignment.TopCenter;
      this.Frame3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Frame3.Controls.Add((Control) this.label7);
      this.Frame3.Controls.Add((Control) this.textBox_Email);
      this.Frame3.Controls.Add((Control) this.comboBox_txtSearchRoom);
      this.Frame3.Controls.Add((Control) this.button_CheckCard);
      this.Frame3.Controls.Add((Control) this.button_Select);
      this.Frame3.Controls.Add((Control) this.txtClientID);
      this.Frame3.Controls.Add((Control) this.txtFirstName);
      this.Frame3.Controls.Add((Control) this.txtSurName);
      this.Frame3.Controls.Add((Control) this.txtIdentity);
      this.Frame3.Controls.Add((Control) this.txtNationality);
      this.Frame3.Controls.Add((Control) this.txtAddress);
      this.Frame3.Controls.Add((Control) this.txtContact);
      this.Frame3.Controls.Add((Control) this.txtSex);
      this.Frame3.Controls.Add((Control) this.txtCountry);
      this.Frame3.Controls.Add((Control) this._optCard_1);
      this.Frame3.Controls.Add((Control) this._optCard_0);
      this.Frame3.Controls.Add((Control) this.Label3);
      this.Frame3.Controls.Add((Control) this.Label4);
      this.Frame3.Controls.Add((Control) this.Label5);
      this.Frame3.Controls.Add((Control) this.Label6);
      this.Frame3.Controls.Add((Control) this._Label7_0);
      this.Frame3.Controls.Add((Control) this.Label8);
      this.Frame3.Controls.Add((Control) this.Label9);
      this.Frame3.Controls.Add((Control) this.Label10);
      this.Frame3.Controls.Add((Control) this.Label11);
      this.Frame3.Controls.Add((Control) this.LabelSearchRoom);
      this.Frame3.Cursor = Cursors.Default;
      this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = SystemColors.ControlText;
      this.Frame3.Location = new Point(29, 53);
      this.Frame3.Name = "Frame3";
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(554, 228);
      this.Frame3.TabIndex = 92;
      this.label7.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.label7.Cursor = Cursors.Default;
      this.label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = SystemColors.ControlText;
      this.label7.Location = new Point(8, 196);
      this.label7.Name = "label7";
      this.label7.RightToLeft = RightToLeft.No;
      this.label7.Size = new Size(81, 17);
      this.label7.TabIndex = 84;
      this.label7.Text = "Email";
      this.label7.TextAlign = ContentAlignment.TopRight;
      this.comboBox_txtSearchRoom.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.comboBox_txtSearchRoom.FormattingEnabled = true;
      this.comboBox_txtSearchRoom.Location = new Point(104, 15);
      this.comboBox_txtSearchRoom.Margin = new Padding(2);
      this.comboBox_txtSearchRoom.Name = "comboBox_txtSearchRoom";
      this.comboBox_txtSearchRoom.Size = new Size(81, 22);
      this.comboBox_txtSearchRoom.TabIndex = 82;
      this.comboBox_txtSearchRoom.SelectedIndexChanged += new EventHandler(this.comboBox_txtSearchRoom_SelectedIndexChanged);
      this.button_CheckCard.Enabled = false;
      this.button_CheckCard.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.button_CheckCard.Location = new Point(202, 12);
      this.button_CheckCard.Margin = new Padding(2);
      this.button_CheckCard.Name = "button_CheckCard";
      this.button_CheckCard.Size = new Size(88, 30);
      this.button_CheckCard.TabIndex = 81;
      this.button_CheckCard.Text = "C&heck Card";
      this.button_CheckCard.UseVisualStyleBackColor = true;
      this.button_CheckCard.Visible = false;
      this.button_CheckCard.Click += new EventHandler(this.button_CheckCard_Click);
      this.button_Select.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.button_Select.Location = new Point(196, 12);
      this.button_Select.Margin = new Padding(2);
      this.button_Select.Name = "button_Select";
      this.button_Select.Size = new Size(94, 29);
      this.button_Select.TabIndex = 80;
      this.button_Select.Text = "&Select";
      this.button_Select.UseVisualStyleBackColor = true;
      this.button_Select.Click += new EventHandler(this.button_Select_Click);
      this.txtFirstName.AcceptsReturn = true;
      this.txtFirstName.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtFirstName.Cursor = Cursors.IBeam;
      this.txtFirstName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFirstName.ForeColor = SystemColors.WindowText;
      this.txtFirstName.Location = new Point(104, 80);
      this.txtFirstName.MaxLength = 0;
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.ReadOnly = true;
      this.txtFirstName.RightToLeft = RightToLeft.No;
      this.txtFirstName.Size = new Size(153, 20);
      this.txtFirstName.TabIndex = 68;
      this.txtSurName.AcceptsReturn = true;
      this.txtSurName.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtSurName.Cursor = Cursors.IBeam;
      this.txtSurName.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSurName.ForeColor = SystemColors.WindowText;
      this.txtSurName.Location = new Point(392, 80);
      this.txtSurName.MaxLength = 0;
      this.txtSurName.Name = "txtSurName";
      this.txtSurName.ReadOnly = true;
      this.txtSurName.RightToLeft = RightToLeft.No;
      this.txtSurName.Size = new Size(153, 20);
      this.txtSurName.TabIndex = 67;
      this.txtIdentity.AcceptsReturn = true;
      this.txtIdentity.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtIdentity.Cursor = Cursors.IBeam;
      this.txtIdentity.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIdentity.ForeColor = SystemColors.WindowText;
      this.txtIdentity.Location = new Point(104, 112);
      this.txtIdentity.MaxLength = 0;
      this.txtIdentity.Name = "txtIdentity";
      this.txtIdentity.ReadOnly = true;
      this.txtIdentity.RightToLeft = RightToLeft.No;
      this.txtIdentity.Size = new Size(153, 20);
      this.txtIdentity.TabIndex = 66;
      this.txtNationality.AcceptsReturn = true;
      this.txtNationality.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtNationality.Cursor = Cursors.IBeam;
      this.txtNationality.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNationality.ForeColor = SystemColors.WindowText;
      this.txtNationality.Location = new Point(392, 112);
      this.txtNationality.MaxLength = 0;
      this.txtNationality.Name = "txtNationality";
      this.txtNationality.ReadOnly = true;
      this.txtNationality.RightToLeft = RightToLeft.No;
      this.txtNationality.Size = new Size(153, 20);
      this.txtNationality.TabIndex = 65;
      this.txtAddress.AcceptsReturn = true;
      this.txtAddress.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtAddress.Cursor = Cursors.IBeam;
      this.txtAddress.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAddress.ForeColor = SystemColors.WindowText;
      this.txtAddress.Location = new Point(104, 144);
      this.txtAddress.MaxLength = 50;
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.ReadOnly = true;
      this.txtAddress.RightToLeft = RightToLeft.No;
      this.txtAddress.Size = new Size(153, 36);
      this.txtAddress.TabIndex = 64;
      this.txtContact.AcceptsReturn = true;
      this.txtContact.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtContact.Cursor = Cursors.IBeam;
      this.txtContact.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtContact.ForeColor = SystemColors.WindowText;
      this.txtContact.Location = new Point(392, 144);
      this.txtContact.MaxLength = 0;
      this.txtContact.Name = "txtContact";
      this.txtContact.ReadOnly = true;
      this.txtContact.RightToLeft = RightToLeft.No;
      this.txtContact.Size = new Size(153, 20);
      this.txtContact.TabIndex = 63;
      this.txtSex.AcceptsReturn = true;
      this.txtSex.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtSex.Cursor = Cursors.IBeam;
      this.txtSex.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSex.ForeColor = SystemColors.WindowText;
      this.txtSex.Location = new Point(392, 48);
      this.txtSex.MaxLength = 0;
      this.txtSex.Name = "txtSex";
      this.txtSex.ReadOnly = true;
      this.txtSex.RightToLeft = RightToLeft.No;
      this.txtSex.Size = new Size(49, 20);
      this.txtSex.TabIndex = 62;
      this.txtCountry.AcceptsReturn = true;
      this.txtCountry.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtCountry.Cursor = Cursors.IBeam;
      this.txtCountry.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCountry.ForeColor = SystemColors.WindowText;
      this.txtCountry.Location = new Point(392, 176);
      this.txtCountry.MaxLength = 0;
      this.txtCountry.Name = "txtCountry";
      this.txtCountry.ReadOnly = true;
      this.txtCountry.RightToLeft = RightToLeft.No;
      this.txtCountry.Size = new Size(153, 20);
      this.txtCountry.TabIndex = 61;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(8, 48);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(81, 17);
      this.Label3.TabIndex = 79;
      this.Label3.Text = "Client ID";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(8, 80);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 17);
      this.Label4.TabIndex = 78;
      this.Label4.Text = "First Name";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(296, 80);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(81, 17);
      this.Label5.TabIndex = 77;
      this.Label5.Text = "SurName ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.Label6.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = SystemColors.ControlText;
      this.Label6.Location = new Point(320, 48);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(57, 17);
      this.Label6.TabIndex = 76;
      this.Label6.Text = "Sex";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this._Label7_0.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this._Label7_0.Cursor = Cursors.Default;
      this._Label7_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._Label7_0.ForeColor = SystemColors.ControlText;
      this._Label7_0.Location = new Point(8, 112);
      this._Label7_0.Name = "_Label7_0";
      this._Label7_0.RightToLeft = RightToLeft.No;
      this._Label7_0.Size = new Size(81, 17);
      this._Label7_0.TabIndex = 75;
      this._Label7_0.Text = "Passport No.";
      this._Label7_0.TextAlign = ContentAlignment.TopRight;
      this.Label8.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(296, 112);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(81, 17);
      this.Label8.TabIndex = 74;
      this.Label8.Text = "Nationality";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      this.Label9.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(8, 144);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(81, 17);
      this.Label9.TabIndex = 73;
      this.Label9.Text = "Address";
      this.Label9.TextAlign = ContentAlignment.TopRight;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.ControlText;
      this.Label10.Location = new Point(296, 144);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(81, 17);
      this.Label10.TabIndex = 72;
      this.Label10.Text = "Contact No.";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.Label11.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = SystemColors.ControlText;
      this.Label11.Location = new Point(296, 176);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(81, 17);
      this.Label11.TabIndex = 71;
      this.Label11.Text = "Country";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.LabelSearchRoom.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.LabelSearchRoom.Cursor = Cursors.Default;
      this.LabelSearchRoom.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LabelSearchRoom.ForeColor = SystemColors.ControlText;
      this.LabelSearchRoom.Location = new Point(8, 16);
      this.LabelSearchRoom.Name = "LabelSearchRoom";
      this.LabelSearchRoom.RightToLeft = RightToLeft.No;
      this.LabelSearchRoom.Size = new Size(81, 17);
      this.LabelSearchRoom.TabIndex = 70;
      this.LabelSearchRoom.Text = "Room No.";
      this.LabelSearchRoom.TextAlign = ContentAlignment.TopRight;
      this.Label26.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label26.Cursor = Cursors.Default;
      this.Label26.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.Blue;
      this.Label26.Location = new Point(8, 8);
      this.Label26.Name = "Label26";
      this.Label26.RightToLeft = RightToLeft.No;
      this.Label26.Size = new Size(89, 17);
      this.Label26.TabIndex = 48;
      this.Label26.Text = "Other Charges";
      this.Label31.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label31.Cursor = Cursors.Default;
      this.Label31.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label31.ForeColor = Color.Blue;
      this.Label31.Location = new Point(104, 8);
      this.Label31.Name = "Label31";
      this.Label31.RightToLeft = RightToLeft.No;
      this.Label31.Size = new Size(81, 17);
      this.Label31.TabIndex = 49;
      this.Label31.Text = "Amount";
      this.lbRefund.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lbRefund.Cursor = Cursors.Default;
      this.lbRefund.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbRefund.ForeColor = SystemColors.ControlText;
      this.lbRefund.Location = new Point(8, 72);
      this.lbRefund.Name = "lbRefund";
      this.lbRefund.RightToLeft = RightToLeft.No;
      this.lbRefund.Size = new Size(81, 17);
      this.lbRefund.TabIndex = 43;
      this.lbRefund.Text = "To Collect ->";
      this.lbRefund.TextAlign = ContentAlignment.TopRight;
      this.txtRefundAmount.AcceptsReturn = true;
      this.txtRefundAmount.BackColor = SystemColors.Window;
      this.txtRefundAmount.Cursor = Cursors.IBeam;
      this.txtRefundAmount.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRefundAmount.ForeColor = SystemColors.WindowText;
      this.txtRefundAmount.Location = new Point(104, 72);
      this.txtRefundAmount.MaxLength = 0;
      this.txtRefundAmount.Name = "txtRefundAmount";
      this.txtRefundAmount.ReadOnly = true;
      this.txtRefundAmount.RightToLeft = RightToLeft.No;
      this.txtRefundAmount.Size = new Size(81, 20);
      this.txtRefundAmount.TabIndex = 44;
      this.txtRefundAmount.Text = "0.00";
      this.txtRefundAmount.TextAlign = HorizontalAlignment.Center;
      this.RefundFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.RefundFrame.Controls.Add((Control) this.Frame2);
      this.RefundFrame.Controls.Add((Control) this.txtExtraDescription);
      this.RefundFrame.Controls.Add((Control) this.txtExtraCharge);
      this.RefundFrame.Controls.Add((Control) this.txtRefundAmount);
      this.RefundFrame.Controls.Add((Control) this.Label31);
      this.RefundFrame.Controls.Add((Control) this.Label26);
      this.RefundFrame.Controls.Add((Control) this.lbRefund);
      this.RefundFrame.Cursor = Cursors.Default;
      this.RefundFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.RefundFrame.ForeColor = Color.Black;
      this.RefundFrame.Location = new Point(589, 301);
      this.RefundFrame.Name = "RefundFrame";
      this.RefundFrame.RightToLeft = RightToLeft.No;
      this.RefundFrame.Size = new Size(201, 169);
      this.RefundFrame.TabIndex = 89;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.ClientSize = new Size(794, 594);
      this.Controls.Add((Control) this.ExtraChargeFrame);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.ChargesFrame);
      this.Controls.Add((Control) this.lblMessage2);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.Frame3);
      this.Controls.Add((Control) this.RefundFrame);
      this.Name = "Form_CancelGuestCardDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_CancelGuestCardDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_CancelGuestCardDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_CancelGuestCardDMS_FormClosing);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ChargesFrame.ResumeLayout(false);
      this.ChargesFrame.PerformLayout();
      this.ExtraChargeFrame.ResumeLayout(false);
      this.ExtraChargeFrame.PerformLayout();
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.RefundFrame.ResumeLayout(false);
      this.RefundFrame.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_CancelGuestCardDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      this._optCard_0.Checked = true;
      this.Check_Cancel_Mode_n_Setup();
    }

    private void Form_CancelGuestCardDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void GetClientDataFromRoomNo()
    {
    }

    private void Clear_Infomation()
    {
      this.txtClientID.Clear();
      this.txtFirstName.Clear();
      this.txtIdentity.Clear();
      this.txtAddress.Clear();
      this.txtSex.Clear();
      this.txtSurName.Clear();
      this.txtNationality.Clear();
      this.txtContact.Clear();
      this.txtCountry.Clear();
      this.textBox_Email.Clear();
      this.lblMessage1.Text = "";
      this.txtBuildingNo.Clear();
      this.txtRoomNo.Clear();
      this.txtRoomType.Clear();
      this.txtCardNo.Clear();
      this.mskContractStart.Clear();
      this.mskContractEnd.Clear();
      this.mskValidStart.Clear();
      this.mskValidEnd.Clear();
      this.mskCheckOutDate.Clear();
      this.txtGracePeriod.Clear();
      this.txtCheckInDate.Clear();
      this.txtRemark.Clear();
      this.txtChargeType.Clear();
      this.txtRoomCharge.Text = "0.00";
      this.txtDeposit.Text = "0.00";
      this.txtAmountDue.Text = "0.00";
      this.txtAmountPaid.Text = "0.00";
      this.txtAdvance.Text = "0.00";
      this.txtExtraCharge.Text = "0.00";
      this.txtRefundAmount.Text = "0.00";
      this.txtGovBond.Text = "0.00";
      this.sCBond = "0.00";
      this.chkRefund.Checked = false;
      this._txtDesExtra_0.Clear();
      this._txtDesExtra_1.Clear();
      this._txtDesExtra_2.Clear();
      this._txtDesExtra_3.Clear();
      this._txtDesExtra_4.Clear();
      this._txtExtraAmount_0.Text = "0.00";
      this._txtExtraAmount_1.Text = "0.00";
      this._txtExtraAmount_2.Text = "0.00";
      this._txtExtraAmount_3.Text = "0.00";
      this._txtExtraAmount_4.Text = "0.00";
      this._txtDesExtra_1.Visible = false;
      this._txtDesExtra_2.Visible = false;
      this._txtDesExtra_3.Visible = false;
      this._txtDesExtra_4.Visible = false;
      this._txtExtraAmount_1.Visible = false;
      this._txtExtraAmount_2.Visible = false;
      this._txtExtraAmount_3.Visible = false;
      this._txtExtraAmount_4.Visible = false;
      this.ExtraChargeFrame.Visible = false;
      this.txtExtraDescription.Enabled = false;
      this.txtExtraCharge.Enabled = false;
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraDescription.Text = "";
      this.txtExtraCharge.Text = "0.00";
      this.lbCardType.Text = "";
      this.lblMessage2.Text = "";
      this.lblMessage3.Text = "";
      this.lblMessage.Text = "";
    }

    private void Setup_Combo_SearchRoom()
    {
      bool flag = false;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      this.comboBox_txtSearchRoom.Text = "";
      this.comboBox_txtSearchRoom.Items.Clear();
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.Description.Contains("Occupied"))
        {
          this.comboBox_txtSearchRoom.Items.Add((object) row.RoomNo);
          flag = true;
        }
      }
      if (!flag)
        return;
      this.comboBox_txtSearchRoom.SelectedIndex = 0;
    }

    private void Check_Cancel_Mode_n_Setup()
    {
      this.Clear_Infomation();
      this.cmdPrint.Enabled = false;
      if (this._optCard_1.Checked)
      {
        this.bWoCard = true;
        this.button_CheckCard.Enabled = false;
        this.button_CheckCard.Visible = false;
        this.comboBox_txtSearchRoom.Enabled = true;
        this.comboBox_txtSearchRoom.Visible = true;
        this.LabelSearchRoom.Visible = true;
        this.button_Select.Enabled = true;
        this.button_Select.Visible = true;
        this.cmdCancel.Text = "Confirm";
        this.cmdCancel.Enabled = false;
        this.lblMessage2.Text = "Key-In Room No...";
        this.Setup_Combo_SearchRoom();
      }
      else
      {
        if (!this._optCard_0.Checked)
          return;
        this.bWoCard = false;
        this.button_CheckCard.Enabled = true;
        this.button_CheckCard.Visible = true;
        this.comboBox_txtSearchRoom.Enabled = false;
        this.comboBox_txtSearchRoom.Visible = false;
        this.LabelSearchRoom.Visible = false;
        this.button_Select.Enabled = false;
        this.button_Select.Visible = false;
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.Enabled = false;
        this.lblMessage2.Text = "";
      }
    }

    private void Form_CancelGuestCardDMS_Load(object sender, EventArgs e)
    {
      this.Check_Cancel_Mode_n_Setup();
    }

    private void _optCard_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Cancel_Mode_n_Setup();
    }

    private void _optCard_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Cancel_Mode_n_Setup();
    }

    private void RefundCalculate()
    {
      double num = Convert.ToDouble(this.txtAdvance.Text) + Convert.ToDouble(this.sCBond) + this.sKeyDeposit - Convert.ToDouble(this.txtExtraCharge.Text);
      if (num >= 0.0)
      {
        this.lbRefund.Text = "To Refund->";
        this.bRefund = true;
        if (!this.bUnitClear)
          this.txtRefundAmount.Text = num.ToString("F02");
        else
          this.txtRefundAmount.Text = "0.00";
      }
      else
      {
        this.lbRefund.Text = "To Collect->";
        this.bRefund = false;
        if (!this.bUnitClear)
          this.txtRefundAmount.Text = (-num).ToString("F02");
        else
          this.txtRefundAmount.Text = "0.00";
      }
      this.sCalculatedRefund = this.txtRefundAmount.Text;
    }

    private void RefundWithoutBond()
    {
      try
      {
        if (this._optCard_1.Checked)
          this.sKeyDeposit = 0.0;
      }
      catch
      {
      }
      double num = Convert.ToDouble(this.txtAdvance.Text) + this.sKeyDeposit - Convert.ToDouble(this.txtExtraCharge.Text);
      if (num >= 0.0)
      {
        this.lbRefund.Text = "To Refund->";
        this.bRefund = true;
        if (!this.bUnitClear)
          this.txtRefundAmount.Text = num.ToString("F02");
        else
          this.txtRefundAmount.Text = "0.00";
      }
      else
      {
        this.lbRefund.Text = "To Collect->";
        this.bRefund = false;
        if (!this.bUnitClear)
          this.txtRefundAmount.Text = (-num).ToString("F02");
        else
          this.txtRefundAmount.Text = "0.00";
      }
      this.sCalculatedRefund = this.txtRefundAmount.Text;
    }

    private void Calculate_Refund()
    {
      if (this.chkRefund.Checked)
      {
        this.bBondRefund = true;
        this.txtGovBond.Text = "0.00";
        this.RefundCalculate();
      }
      else
      {
        this.bBondRefund = false;
        this.txtGovBond.Text = this.sCBond;
        this.RefundWithoutBond();
      }
      if (!this.cmdCancel.Enabled)
        return;
      this.cmdCancel.Focus();
    }

    private void Process_Selected_Room_information(string para_Room_No)
    {
      bool flag = false;
      byte para_RoomType = 1;
      byte num = 0;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_Room_No)
        {
          try
          {
            this.txtClientID.Text = row.ClientID;
          }
          catch
          {
          }
          flag = true;
          this.sBuildingType = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.CheckBuildingType(row.RoomNo.Substring(0, 1));
          break;
        }
      }
      if (!flag)
        return;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_Room_No)
        {
          string condition = row.Condition;
          break;
        }
      }
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          this.txtFirstName.Text = row.ForeName;
          this.txtIdentity.Text = row.Identity;
          this.txtAddress.Text = row.Address;
          this.txtSex.Text = row.Sex;
          this.txtSurName.Text = row.SurName;
          this.txtNationality.Text = row.Nationality;
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
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          this.txtBuildingNo.Text = row.RoomNo.Substring(0, 1);
          this.txtRoomNo.Text = row.RoomNo;
          this.txtCardNo.Text = row.CardNo;
          this.mskContractStart.Text = row.ContractStart.ToShortDateString();
          this.mskContractEnd.Text = row.ContractEnd.ToShortDateString();
          this.mskValidStart.Text = row.ValidStart.ToShortDateString();
          this.mskValidEnd.Text = row.ValidEnd.ToShortDateString();
          this.txtGracePeriod.Text = row.GracePeriod.ToString();
          this.txtCheckInDate.Text = row.CheckInDate.ToShortDateString();
          try
          {
            this.txtRemark.Text = row.Remark;
          }
          catch
          {
            this.txtRemark.Text = "";
          }
          this.mskCheckOutDate.Text = row.CheckOutDate.ToShortDateString();
          this.mskCheckOutDate.Visible = true;
          this.mskCheckOutDate.BringToFront();
          if (row.ChargeType.Contains("M"))
            this.txtChargeType.Text = "Monthly";
          else if (row.ChargeType.Contains("W"))
            this.txtChargeType.Text = "Weekly";
          else if (row.ChargeType.Contains("D"))
            this.txtChargeType.Text = "Daily";
          this.txtDeposit.Text = row.KeyDeposit.ToString("F02");
          this.sKeyDeposit = 0.0;
          this.txtAmountDue.Text = row.AmountPaid.ToString("F02");
          this.txtAmountPaid.Text = row.LastPayment.ToString("F02");
          this.txtAdvance.Text = row.AdvancedPayment.ToString("F02");
          this.sCAdvance = row.AdvancedPayment.ToString("F2");
          this.txtGovBond.Text = row.Bond.ToString("F02");
          this.sCBond = row.Bond.ToString("F2");
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition = row.Condition;
          num = row.NoOfPeople;
          if (row.ValidEnd.CompareTo(DateTime.Now) >= 0)
          {
            if (!this._optCard_0.Checked)
              break;
            break;
          }
          break;
        }
      }
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          para_RoomType = row.RoomType;
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            if (row.TotalStay == (byte) 1)
            {
              if (this.txtChargeType.Text.Contains("Monthly"))
              {
                this.txtRoomCharge.Text = row.MonthlyRate.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Weekly"))
              {
                this.txtRoomCharge.Text = row.WeeklyRate.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Daily"))
              {
                this.txtRoomCharge.Text = row.DailyRate.ToString("F02");
                break;
              }
              break;
            }
            if (row.TotalStay == (byte) 2)
            {
              if (this.txtChargeType.Text.Contains("Monthly"))
              {
                this.txtRoomCharge.Text = row.MonthlyRate2.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Weekly"))
              {
                this.txtRoomCharge.Text = row.WeeklyRate2.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Daily"))
              {
                this.txtRoomCharge.Text = row.DailyRate2.ToString("F02");
                break;
              }
              break;
            }
            break;
          }
          if (this.txtChargeType.Text.Contains("Monthly"))
          {
            this.txtRoomCharge.Text = row.MonthlyRate.ToString("F02");
            break;
          }
          if (this.txtChargeType.Text.Contains("Weekly"))
          {
            this.txtRoomCharge.Text = row.WeeklyRate.ToString("F02");
            break;
          }
          if (this.txtChargeType.Text.Contains("Daily"))
          {
            this.txtRoomCharge.Text = row.DailyRate.ToString("F02");
            break;
          }
          break;
        }
      }
      this.txtRoomType.Text = this.db.Get_RoomType_Description(para_RoomType);
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        if (row.CardNo == this.txtCardNo.Text)
        {
          Mod_UpdateData.iChkCardStatus = row.CardStatus;
          this.lbCardType.Text = row.CardType;
          switch (Mod_UpdateData.iChkCardStatus)
          {
            case 0:
              if (num == (byte) 2)
              {
                this.lblMessage1.Text = "Second Major Card: " + this.txtCardNo.Text;
                goto label_92;
              }
              else
              {
                this.lblMessage1.Text = "Major Card: " + this.txtCardNo.Text;
                goto label_92;
              }
            case 1:
              this.lblMessage1.Text = "Spare Card: " + this.txtCardNo.Text;
              goto label_92;
            case 2:
              this.lblMessage1.Text = "Loss Card: " + this.txtCardNo.Text;
              goto label_92;
            case 3:
              this.lblMessage1.Text = "CheckOut/Cancel Card:" + this.txtCardNo.Text;
              goto label_92;
            case 4:
              this.lblMessage1.Text = "CheckOut/Cancel Without Card:" + this.txtCardNo.Text;
              goto label_92;
            default:
              goto label_92;
          }
        }
      }
label_92:
      this.Calculate_Refund();
      if (this._optCard_1.Checked)
      {
        this.cmdCancel.Text = "Confirm";
        this.cmdCancel.Enabled = true;
        this.txtExtraDescription.Enabled = true;
        this.txtExtraCharge.Enabled = true;
      }
      else
      {
        if (!this._optCard_0.Checked)
          return;
        this.cmdCancel.Text = "Cancel";
      }
    }

    private void button_Select_Click(object sender, EventArgs e)
    {
      this.Process_Selected_Room_information((string) this.comboBox_txtSearchRoom.SelectedItem);
      this.cmdPrint.Enabled = false;
    }

    private void chkRefund_CheckedChanged(object sender, EventArgs e) => this.Calculate_Refund();

    private void Check_Extra_textBoxs()
    {
      this._txtDesExtra_0.Enabled = true;
      this._txtDesExtra_0.Visible = true;
      this._txtExtraAmount_0.Enabled = true;
      this._txtExtraAmount_0.Visible = true;
      if (this._txtDesExtra_0.Text.Length > 0)
      {
        this._txtDesExtra_1.Enabled = true;
        this._txtDesExtra_1.Visible = true;
        this._txtExtraAmount_1.Enabled = true;
        this._txtExtraAmount_1.Visible = true;
        this._txtDesExtra_1.Focus();
        this._txtDesExtra_1.Select();
      }
      else
      {
        this._txtDesExtra_0.Focus();
        this._txtDesExtra_0.Select();
      }
      if (this._txtDesExtra_1.Text.Length > 0)
      {
        this._txtDesExtra_2.Enabled = true;
        this._txtDesExtra_2.Visible = true;
        this._txtExtraAmount_2.Enabled = true;
        this._txtExtraAmount_2.Visible = true;
        this._txtDesExtra_2.Focus();
        this._txtDesExtra_2.Select();
      }
      if (this._txtDesExtra_2.Text.Length > 0)
      {
        this._txtDesExtra_3.Enabled = true;
        this._txtDesExtra_3.Visible = true;
        this._txtExtraAmount_3.Enabled = true;
        this._txtExtraAmount_3.Visible = true;
        this._txtDesExtra_3.Focus();
        this._txtDesExtra_3.Select();
      }
      if (this._txtDesExtra_3.Text.Length > 0)
      {
        this._txtDesExtra_4.Enabled = true;
        this._txtDesExtra_4.Visible = true;
        this._txtExtraAmount_4.Enabled = true;
        this._txtExtraAmount_4.Visible = true;
        this._txtDesExtra_4.Focus();
        this._txtDesExtra_4.Select();
      }
      if (this._txtDesExtra_4.Text.Length <= 0)
        return;
      this._txtExtraAmount_4.Focus();
      this._txtExtraAmount_4.Select();
    }

    private double Check_Extra_Values()
    {
      double num1 = 0.0;
      this.lblMessage.Text = "Click OK after finish!";
      for (int index = 0; index <= 4; ++index)
      {
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index] = "0";
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index] = "";
      }
      if (this._txtDesExtra_4.Text.Length > 0)
      {
        if (this._txtExtraAmount_4.Text.Length > 0)
        {
          try
          {
            double num2 = Convert.ToDouble(this._txtExtraAmount_4.Text);
            num1 += num2;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4] = this._txtExtraAmount_4.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] = this._txtDesExtra_4.Text;
          }
          catch
          {
            int num3 = (int) MessageBox.Show("Incorrect Input Number in ExtraAmount 5!");
          }
        }
      }
      if (this._txtDesExtra_3.Text.Length > 0)
      {
        if (this._txtExtraAmount_3.Text.Length > 0)
        {
          try
          {
            double num4 = Convert.ToDouble(this._txtExtraAmount_3.Text);
            num1 += num4;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3] = this._txtExtraAmount_3.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] = this._txtDesExtra_3.Text;
          }
          catch
          {
            int num5 = (int) MessageBox.Show("Incorrect Input Number in ExtraAmount 4!");
          }
        }
      }
      if (this._txtDesExtra_2.Text.Length > 0)
      {
        if (this._txtExtraAmount_2.Text.Length > 0)
        {
          try
          {
            double num6 = Convert.ToDouble(this._txtExtraAmount_2.Text);
            num1 += num6;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2] = this._txtExtraAmount_2.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] = this._txtDesExtra_2.Text;
          }
          catch
          {
            int num7 = (int) MessageBox.Show("Incorrect Input Number in ExtraAmount 3!");
          }
        }
      }
      if (this._txtDesExtra_1.Text.Length > 0)
      {
        if (this._txtExtraAmount_1.Text.Length > 0)
        {
          try
          {
            double num8 = Convert.ToDouble(this._txtExtraAmount_1.Text);
            num1 += num8;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1] = this._txtExtraAmount_1.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] = this._txtDesExtra_1.Text;
          }
          catch
          {
            int num9 = (int) MessageBox.Show("Incorrect Input Number in ExtraAmount 2!");
          }
        }
      }
      if (this._txtDesExtra_0.Text.Length > 0)
      {
        if (this._txtExtraAmount_0.Text.Length > 0)
        {
          try
          {
            double num10 = Convert.ToDouble(this._txtExtraAmount_0.Text);
            num1 += num10;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0] = this._txtExtraAmount_0.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] = this._txtDesExtra_0.Text;
          }
          catch
          {
            int num11 = (int) MessageBox.Show("Incorrect Input Number in ExtraAmount 1!");
          }
        }
      }
      return num1;
    }

    private void _txtExtraAmount_0_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this._txtDesExtra_0.Text.Length == 0)
      {
        this.lblMessage3.Text = "Enter Description First!";
        this.lblMessage3.Refresh();
        Console.Beep(700, 300);
        this._txtDesExtra_0.Select();
        this._txtDesExtra_0.Focus();
        Thread.Sleep(500);
        this.lblMessage3.Text = "";
        e.Handled = true;
      }
      else if (e.KeyChar == '\r')
      {
        if (this._txtExtraAmount_0.Text.Length == 0)
          this._txtExtraAmount_0.Text = "0.00";
        this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
        this._txtDesExtra_1.Enabled = true;
        this._txtDesExtra_1.Visible = true;
        this._txtExtraAmount_1.Enabled = true;
        this._txtExtraAmount_1.Visible = true;
        e.Handled = true;
        this._txtDesExtra_1.Focus();
        this._txtDesExtra_1.Select();
      }
      else
        this.Filter_Keys_N_Dot(e, this._txtExtraAmount_0.Text);
    }

    private void _txtExtraAmount_1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this._txtDesExtra_1.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Pls. include description first!");
        e.Handled = true;
      }
      else if (e.KeyChar == '\r')
      {
        if (this._txtExtraAmount_1.Text.Length == 0)
          this._txtExtraAmount_1.Text = "0.00";
        this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
        this._txtDesExtra_2.Enabled = true;
        this._txtDesExtra_2.Visible = true;
        this._txtExtraAmount_2.Enabled = true;
        this._txtExtraAmount_2.Visible = true;
        e.Handled = true;
        this._txtDesExtra_2.Focus();
        this._txtDesExtra_2.Select();
      }
      else
        this.Filter_Keys_N_Dot(e, this._txtExtraAmount_1.Text);
    }

    private void _txtExtraAmount_2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this._txtDesExtra_2.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Pls. include description first!");
        e.Handled = true;
      }
      else if (e.KeyChar == '\r')
      {
        if (this._txtExtraAmount_2.Text.Length == 0)
          this._txtExtraAmount_2.Text = "0.00";
        this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
        this._txtDesExtra_3.Enabled = true;
        this._txtDesExtra_3.Visible = true;
        this._txtExtraAmount_3.Enabled = true;
        this._txtExtraAmount_3.Visible = true;
        e.Handled = true;
        this._txtDesExtra_3.Focus();
        this._txtDesExtra_3.Select();
      }
      else
        this.Filter_Keys_N_Dot(e, this._txtExtraAmount_2.Text);
    }

    private void _txtExtraAmount_3_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this._txtDesExtra_3.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Pls. include description first!");
        e.Handled = true;
      }
      else if (e.KeyChar == '\r')
      {
        if (this._txtExtraAmount_3.Text.Length == 0)
          this._txtExtraAmount_3.Text = "0.00";
        this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
        this._txtDesExtra_4.Enabled = true;
        this._txtDesExtra_4.Visible = true;
        this._txtExtraAmount_4.Enabled = true;
        this._txtExtraAmount_4.Visible = true;
        e.Handled = true;
        this._txtDesExtra_4.Focus();
        this._txtDesExtra_4.Select();
      }
      else
        this.Filter_Keys_N_Dot(e, this._txtExtraAmount_3.Text);
    }

    private void _txtExtraAmount_4_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this._txtDesExtra_4.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Pls. include description first!");
        e.Handled = true;
      }
      else if (e.KeyChar == '\r')
      {
        if (this._txtExtraAmount_4.Text.Length == 0)
          this._txtExtraAmount_4.Text = "0.00";
        this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
        e.Handled = true;
        this.cmdOK.Focus();
        this.cmdOK.Select();
      }
      else
        this.Filter_Keys_N_Dot(e, this._txtExtraAmount_4.Text);
    }

    private void _txtExtraAmount_0_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
    }

    private void _txtExtraAmount_1_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
    }

    private void _txtExtraAmount_2_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
    }

    private void _txtExtraAmount_3_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
    }

    private void _txtExtraAmount_4_KeyUp(object sender, KeyEventArgs e)
    {
      this.txtExtraTotal.Text = "0.00";
      this.txtExtraTotal.Text = this.Check_Extra_Values().ToString("F02");
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      this.txtExtraCharge.Text = "0.00";
      this.txtExtraDescription.Text = "";
      double num = this.Check_Extra_Values();
      this.ExtraChargeFrame.Enabled = false;
      this.ExtraChargeFrame.Visible = false;
      this.ExtraChargeFrame.SendToBack();
      this.txtExtraDescription.Enabled = true;
      this.txtExtraCharge.Text = num.ToString("F02");
      this.txtExtraDescription.Text = "Total Extra Charges";
      if (this._txtDesExtra_0.Text.Length == 0 && this._txtDesExtra_1.Text.Length == 0 && this._txtDesExtra_2.Text.Length == 0 && this._txtDesExtra_3.Text.Length == 0 && this._txtDesExtra_4.Text.Length == 0)
        this.txtExtraDescription.Text = "";
      this.lblMessage.Text = "";
      this.ExtraChargeFrame_Exit_Process();
    }

    private void txtExtraCharge_TextChanged(object sender, EventArgs e) => this.Calculate_Refund();

    private void gGetCardProperty()
    {
      gCardProperty.CardType = this.lbCardType.Text;
      gCardProperty.CardNo = this.txtCardNo.Text;
      try
      {
        gCardProperty.CheckInDate = DateTime.Parse(this.txtCheckInDate.Text).Date;
      }
      catch
      {
      }
      gCardProperty.CheckOutDate = DateTime.Now.Date;
      gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
    }

    private void gGetClientProperty()
    {
      gCardProperty.CardType = this.lbCardType.Text;
      gClientProperty.ClientID = this.txtClientID.Text;
      gClientProperty.Sex = this.txtSex.Text;
      gClientProperty.ClientType = this.lbCardType.Text.Substring(0, 1);
      gClientProperty.ForeName = this.txtFirstName.Text;
      gClientProperty.SurName = this.txtSurName.Text;
      gClientProperty.Contact = this.txtContact.Text;
      gClientProperty.Address = this.txtAddress.Text;
      gClientProperty.Country = this.txtCountry.Text;
      gClientProperty.Identity = this.txtIdentity.Text;
      gClientProperty.Nationality = this.txtNationality.Text;
      gClientProperty.Email = "";
      gClientProperty.CardNo = this.txtCardNo.Text;
      gClientProperty.RoomNo = this.txtRoomNo.Text;
      gClientProperty.DEPOSIT = "0.00";
      if (this.chkRefund.Checked)
      {
        gClientProperty.Bond = (-Convert.ToDecimal(this.sCBond)).ToString("F2");
      }
      else
      {
        gClientProperty.Bond = "0";
        gClientProperty.RBA = Convert.ToDecimal(this.sCBond).ToString("F2");
      }
      if (this._optCard_1.Checked)
      {
        gClientProperty.KeyDeposit = "0.00";
      }
      else
      {
        this.GetCardDeposit();
        if (Mod_UpdateData.iChkCardStatus == (byte) 1 || Mod_UpdateData.iChkCardStatus == (byte) 0 || Mod_UpdateData.iChkCardStatus == (byte) 4)
          gClientProperty.KeyDeposit = gClientProperty.KeyDeposit.Insert(0, "-");
      }
      gClientProperty.ContractStart = this.mskContractStart.Text;
      gClientProperty.ContractEnd = this.mskContractEnd.Text;
      if (this.txtChargeType.Text != "")
        gClientProperty.ChargeType = this.txtChargeType.Text.Substring(0, 1);
      gClientProperty.GracePeriod = this.txtGracePeriod.Text;
      gClientProperty.ValidStart = this.mskValidStart.Text;
      gClientProperty.ValidEnd = this.mskValidEnd.Text;
      gClientProperty.Advance = "-" + this.sCAdvance;
      gClientProperty.CurAdvance = "-" + this.sCAdvance;
      gClientProperty.PrevAdvance = this.sCAdvance;
      gClientProperty.ExtraCharge = "0";
      Mod_UpdateData.sChkExtraCharge = gClientProperty.ExtraCharge;
      gClientProperty.ExDesp = "";
      Decimal num1;
      try
      {
        num1 = Convert.ToDecimal(this.txtExtraCharge.Text);
      }
      catch
      {
        num1 = 0M;
      }
      if (num1 != 0M)
      {
        try
        {
          gClientProperty.ExDesp = !(this.txtExtraDescription.Text != "") ? "Extra Charges" : this.txtExtraDescription.Text;
        }
        catch
        {
          gClientProperty.ExDesp = "Extra Charges";
        }
        gClientProperty.ExtraCharge = num1.ToString("F2");
        Mod_UpdateData.sChkExtraCharge = gClientProperty.ExtraCharge;
      }
      gClientProperty.LastPayment = this.lbRefund.Text.Contains("To Collect ->") ? this.txtRefundAmount.Text : "-" + this.txtRefundAmount.Text;
      gClientProperty.CheckOutDate = gCardProperty.CheckOutDate.ToShortDateString();
      gClientProperty.CheckOutTime = gCardProperty.CheckOutTime.ToShortTimeString();
      gClientProperty.LastRecDate = DateTime.Now.ToShortDateString();
      if (!this._optCard_1.Checked)
      {
        gClientProperty.ExtraKey = "3";
        gClientProperty.People = "9";
        gClientProperty.TransType = "CC";
      }
      else
      {
        gClientProperty.ExtraKey = "4";
        gClientProperty.People = "9";
        gClientProperty.TransType = "CN";
      }
      gClientProperty.RoomStart = DateTime.Now.ToShortDateString();
      gClientProperty.Remark = this.txtRemark.Text;
      gClientProperty.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition;
      double num2 = Convert.ToDouble(gClientProperty.RoomCharge) + Convert.ToDouble(gClientProperty.ExtraCharge);
      gClientProperty.TransGST = num2.ToString();
      if (!(num1 != 0M))
        return;
      if (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) != 0.0)
      {
        double num3 = Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) + Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gConstantGST);
        this.sNewGSTRate = num3.ToString();
        gClientProperty.TransGST = (num2 * (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) / num3)).ToString();
      }
      else
        gClientProperty.TransGST = "0";
      gClientProperty.Update = false;
    }

    private void GetCardDeposit()
    {
      gClientProperty.KeyDeposit = "0.00";
      try
      {
        this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
        {
          if (row.RoomNo == this.txtRoomNo.Text)
            gClientProperty.KeyDeposit = row.KeyCharge.ToString("F2");
        }
      }
      catch
      {
        gClientProperty.KeyDeposit = this.txtDeposit.Text;
      }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Please comfirm Yes/No ?      ", " Cancel Guest Card. ", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.Refresh();
      bool flag = this.db.Backup_Before_Transact(this.txtBuildingNo.Text);
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
      {
        this.lblMessage.Text = "Please wait. Cancellation in progress ... ";
        if (!this.bWoCard)
        {
          if (Mod_UpdateData.iChkCardStatus != (byte) 2)
          {
            if (!this.bUnitClear)
            {
              if (!this.CancelCardRoutine())
              {
                this.lblMessage.Refresh();
                this.lblMessage.Text = "Cancel Failed";
                this.lblMessage.Refresh();
                if (!flag)
                  return;
                this.db.Restore_For_FailedTransact(this.txtBuildingNo.Text);
                return;
              }
            }
            else
              this.ClearCardRoutine();
          }
          else
            this.ClearCardRoutine();
        }
        else if (!this.CancelWoCardRoutine())
        {
          this.lblMessage.Refresh();
          this.lblMessage.Text = "Cancel Failed";
          this.lblMessage.Refresh();
          if (!flag)
            return;
          this.db.Restore_For_FailedTransact(this.txtBuildingNo.Text);
          return;
        }
        this.lblMessage.Refresh();
        this.lblMessage.Text = "Cancel Successful";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.Check_Cancel_Mode_n_Setup();
        this.cmdPrint.Enabled = true;
      }
      else if (this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
      {
        this.lblMessage.Text = "Please wait. Cancellation in progress ... ";
        if (!this.bWoCard)
        {
          if (Mod_UpdateData.iChkCardStatus != (byte) 2)
          {
            if (!this.CancelCardRoutine())
            {
              this.lblMessage.Refresh();
              this.lblMessage.Text = "Cancel Failed";
              this.lblMessage.Refresh();
              if (!flag)
                return;
              this.db.Restore_For_FailedTransact(this.txtBuildingNo.Text);
              return;
            }
          }
          else
            this.ClearCardRoutine();
        }
        else if (!this.CancelWoCardRoutine())
        {
          this.lblMessage.Refresh();
          this.lblMessage.Text = "Cancel Failed";
          this.lblMessage.Refresh();
          if (!flag)
            return;
          this.db.Restore_For_FailedTransact(this.txtBuildingNo.Text);
          return;
        }
        this.lblMessage.Refresh();
        this.lblMessage.Text = "Cancel Successful";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.Check_Cancel_Mode_n_Setup();
        this.cmdPrint.Enabled = true;
        this.cmdPrint.Enabled = true;
      }
      else
      {
        int num = (int) MessageBox.Show("Not Allowed to Cancel this Building's Guest Card.!");
      }
    }

    private bool CancelCardRoutine()
    {
      this.gGetCardProperty();
      this.gGetClientProperty();
      int newTransId = this.db.GetNew_TransID(this.txtBuildingNo.Text);
      if (newTransId == -1)
      {
        int num = (int) MessageBox.Show("Can't Get TransID!");
        return false;
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
      if (!this.UpdateData())
        return false;
      if (SmartCard_Procedures.Make_Empty_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
      {
        this.cmdCancel.Enabled = false;
        int num = (int) MessageBox.Show("Make Card Empty Success!");
        return true;
      }
      int num1 = (int) MessageBox.Show("Make Card Empty Failed!");
      return false;
    }

    private void ClearCardRoutine()
    {
    }

    private bool CancelWoCardRoutine()
    {
      this.gGetCardProperty();
      this.gGetClientProperty();
      int newTransId = this.db.GetNew_TransID(this.txtBuildingNo.Text);
      if (newTransId == -1)
      {
        int num = (int) MessageBox.Show("Can't Get TransID!");
        return false;
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
      return this.UpdateCancelWoCard();
    }

    private bool RoomStatusCancel(string para_RoomNo)
    {
      int num1 = 0;
      bool flag1 = false;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
      {
        if (((BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index]).RoomNo == para_RoomNo)
          ++num1;
      }
      int count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
      if (num1 > 1)
      {
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          bool flag2;
          try
          {
            flag2 = row.ClientID == null;
          }
          catch
          {
            flag2 = true;
          }
          if (!flag2 && Mod_UpdateData.sChkClient == row.ClientID && para_RoomNo == row.RoomNo && Mod_UpdateData.iChkStatus == (int) row.Status)
          {
            if (this.db.building_DB1.roomStatusTableAdapter.Delete(row.RoomNo) > 0)
            {
              flag1 = true;
              this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
              count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
              break;
            }
            flag1 = false;
            break;
          }
        }
        if (!flag1)
        {
          int num2 = (int) MessageBox.Show("Cannot delete duplicate RoomStatus row!");
          return false;
        }
      }
      else
      {
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          bool flag3;
          try
          {
            flag3 = row.ClientID == null;
          }
          catch
          {
            flag3 = true;
          }
          if (!flag3)
          {
            if (row.ClientID == Mod_UpdateData.sChkClient && (int) row.Status == Mod_UpdateData.iChkStatus)
            {
              if (para_RoomNo == row.RoomNo)
              {
                row.Status = (byte) 0;
                row.Description = "Vacant";
                row.StartDate = DateTime.Now.Date;
                row.EndDate = DateTime.Now.Date;
                row.ClientID = "";
                row.Condition = "";
                row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                row.Update = false;
                if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
                {
                  this.db.Update_RoomStausXX_inSystemDB(this.txtBuildingNo.Text);
                  flag1 = true;
                  break;
                }
                flag1 = false;
                break;
              }
            }
            else
              flag1 = true;
          }
        }
        if (!flag1)
        {
          int num3 = (int) MessageBox.Show("Cannot Update RoomStatus row!");
          return false;
        }
      }
      return true;
    }

    private bool CancelRoomStatus(string para_RoomNo)
    {
      int num1 = 0;
      bool flag1 = false;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
      {
        if (((BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index]).RoomNo == para_RoomNo)
          ++num1;
      }
      int count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
      if (num1 > 1)
      {
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          bool flag2;
          try
          {
            flag2 = row.ClientID == null;
          }
          catch
          {
            flag2 = true;
          }
          if (!flag2 && Mod_UpdateData.sChkClient == row.ClientID && para_RoomNo == row.RoomNo && Mod_UpdateData.iChkStatus == (int) row.Status)
          {
            if (this.db.building_DB1.roomStatusTableAdapter.Delete(row.RoomNo) > 0)
            {
              flag1 = true;
              this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
              count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
              break;
            }
            flag1 = false;
            break;
          }
        }
        if (!flag1)
        {
          int num2 = (int) MessageBox.Show("Cannot delete duplicate RoomStatus row!");
          return false;
        }
      }
      else
      {
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          bool flag3;
          try
          {
            flag3 = row.ClientID == null;
          }
          catch
          {
            flag3 = true;
          }
          if (!flag3 && row.ClientID == Mod_UpdateData.sChkClient && (int) row.Status == Mod_UpdateData.iChkStatus)
          {
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType == "Unit")
            {
              if (para_RoomNo.Substring(1, 2) == row.RoomNo.Substring(1, 2))
              {
                row.Status = (byte) 0;
                row.Description = "Vacant";
                row.StartDate = DateTime.Now.Date;
                row.EndDate = DateTime.Now.Date;
                row.ClientID = "";
                row.Condition = "";
                row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                row.Update = false;
                if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
                {
                  this.db.Update_RoomStausXX_inSystemDB(this.txtBuildingNo.Text);
                  flag1 = true;
                }
                else
                  flag1 = false;
              }
            }
            else if (para_RoomNo == row.RoomNo)
            {
              row.Status = (byte) 0;
              row.Description = "Vacant";
              row.StartDate = DateTime.Now.Date;
              row.EndDate = DateTime.Now.Date;
              row.ClientID = "";
              row.Condition = "";
              row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.Update = false;
              if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
              {
                this.db.Update_RoomStausXX_inSystemDB(this.txtBuildingNo.Text);
                flag1 = true;
                break;
              }
              flag1 = false;
              break;
            }
          }
        }
        if (!flag1)
        {
          int num3 = (int) MessageBox.Show("Cannot Update RoomStatus row!");
          return false;
        }
      }
      return true;
    }

    private bool ExtraCharge()
    {
      bool flag = false;
      this.db.building_DB1.extraChargeTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ExtraCharge);
      for (int index = 0; index <= 4; ++index)
      {
        Decimal num;
        try
        {
          num = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index]);
        }
        catch
        {
          num = 0M;
        }
        if (num != 0M)
        {
          BuildingDB1DataSet.ExtraChargeRow row = this.db.building_DB1.buildingDB1DataSet.ExtraCharge.NewExtraChargeRow();
          row.ReceiptID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
          row.ClientID = gClientProperty.ClientID;
          row.ExDescription = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index];
          row.ExtraCharge = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index]);
          this.db.building_DB1.buildingDB1DataSet.ExtraCharge.AddExtraChargeRow(row);
          flag = true;
        }
      }
      return flag && this.db.building_DB1.extraChargeTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ExtraCharge) != 0;
    }

    private bool UpdateData()
    {
      Mod_UpdateData.sChkCardNo = this.txtCardNo.Text;
      if (!this.db.CardDataUpdate(Mod_UpdateData.sChkCardNo, Global_Data.Card_AutoNumber, Global_Data.Card_HW_ID))
      {
        int num = (int) MessageBox.Show("CardDataUpdate() failed!");
        return false;
      }
      string text = this.txtRoomNo.Text;
      Mod_UpdateData.sChkRoom = text;
      bool flag1 = false;
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (roomTypeDescription.ToUpper().Contains("SINGLE"))
            row.TotalStay = (byte) 0;
          else if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            if (row.TotalStay == (byte) 2)
              --row.TotalStay;
            else
              row.TotalStay = (byte) 0;
          }
          if (row.IssuedCard > (short) 0)
          {
            --row.IssuedCard;
            if (row.IssuedCard == (short) 0)
              row.TotalStay = (byte) 0;
          }
          row.Update = false;
          flag1 = true;
          break;
        }
      }
      if (flag1)
      {
        if (this.db.system_DB.roomTableAdapter.Update(this.db.system_DB.systemDataSet.Room) <= 0)
        {
          int num = (int) MessageBox.Show("Room table update failed!");
          return false;
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Room table update failed! RoomNo not found in Room Table!");
      }
      Mod_UpdateData.iChkStatus = 3;
      Mod_UpdateData.sChkRoom = this.txtRoomNo.Text;
      Mod_UpdateData.sChkClient = this.txtClientID.Text;
      if (this.sBuildingType != "Apartment")
      {
        if (!this.RoomStatusCancel(Mod_UpdateData.sChkRoom))
        {
          int num2 = (int) MessageBox.Show("RoomStatusCancel Failed!");
          return false;
        }
      }
      else if (!this.CancelRoomStatus(Mod_UpdateData.sChkRoom))
      {
        int num3 = (int) MessageBox.Show("CancelRoomStatus Failed!");
        return false;
      }
      bool flag2 = false;
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          if (this.sBuildingType == "Normal")
          {
            row.RoomNo = "";
            row.CardNo = "";
            row.Bond = 0M;
            row.Deposit = 0M;
            row.Remark = "";
            row.NoOfPeople = Convert.ToByte(gClientProperty.People);
            row.OldRoom = "";
            row.Condition = "";
            row.AdvancedPayment = 0M;
            row.LastPayment = 0M;
            row.AmountPaid = 0M;
            row.CheckOutDate = DateTime.Now.Date;
            row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
            row.LastRecDate = DateTime.Now.Date;
            row.Update = false;
            flag2 = true;
            break;
          }
          if (row.RoomNo.Substring(1, 2) == text.Substring(1, 2))
          {
            row.RoomNo = "";
            row.CardNo = "";
            row.Bond = 0M;
            row.Deposit = 0M;
            row.Remark = "";
            row.NoOfPeople = Convert.ToByte(gClientProperty.People);
            row.OldRoom = "";
            row.Condition = "";
            row.AdvancedPayment = 0M;
            row.LastPayment = 0M;
            row.AmountPaid = 0M;
            row.CheckOutDate = DateTime.Now.Date;
            row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
            row.LastRecDate = DateTime.Now.Date;
            row.Update = false;
            flag2 = true;
            break;
          }
        }
      }
      if (flag2)
      {
        if (this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) <= 0)
        {
          int num4 = (int) MessageBox.Show("ClientAcc Update failed!");
          return false;
        }
        if (!this.db.TransactionAdd())
        {
          int num5 = (int) MessageBox.Show("Transaction Record in CardTrans can not be added!");
          return false;
        }
        Mod_UpdateData.sChkExtraCharge = gClientProperty.ExtraCharge;
        try
        {
          if (Convert.ToDecimal(Mod_UpdateData.sChkExtraCharge) != 0M)
          {
            if (!this.ExtraCharge())
            {
              int num6 = (int) MessageBox.Show("ExtraCharge Table Update Failed!");
              return false;
            }
          }
        }
        catch
        {
        }
        gCardProperty.CheckOutDate = DateTime.Now.Date;
        gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
        if (this.db.LastTransAdd())
          return true;
        int num7 = (int) MessageBox.Show("Transaction Record in LastTrans Table can not be added!");
        return false;
      }
      int num8 = (int) MessageBox.Show("ClientAcc Update failed! ClientID not found!");
      return false;
    }

    private bool UpdateCancelWoCard()
    {
      Mod_UpdateData.sChkCardNo = this.txtCardNo.Text;
      if (!this.db.CardDataUpdate_WoCard(Mod_UpdateData.sChkCardNo))
      {
        int num = (int) MessageBox.Show("CardDataUpdate_WoCard() failed!");
        return false;
      }
      string text = this.txtRoomNo.Text;
      Mod_UpdateData.sChkRoom = text;
      bool flag1 = false;
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == this.txtRoomNo.Text)
        {
          string roomTypeDescription = this.db.Get_RoomType_Description(row.RoomType);
          if (roomTypeDescription.ToUpper().Contains("SINGLE"))
            row.TotalStay = (byte) 0;
          else if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
          {
            if (row.TotalStay == (byte) 2)
              --row.TotalStay;
            else
              row.TotalStay = (byte) 0;
          }
          if (row.IssuedCard > (short) 0)
          {
            --row.IssuedCard;
            if (row.IssuedCard == (short) 0)
              row.TotalStay = (byte) 0;
          }
          row.Update = false;
          flag1 = true;
          break;
        }
      }
      if (flag1)
      {
        if (this.db.system_DB.roomTableAdapter.Update(this.db.system_DB.systemDataSet.Room) <= 0)
        {
          int num = (int) MessageBox.Show("Room table update failed!");
          return false;
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Room table update failed! RoomNo not found in Room Table!");
      }
      Mod_UpdateData.iChkStatus = 3;
      Mod_UpdateData.sChkRoom = this.txtRoomNo.Text;
      Mod_UpdateData.sChkClient = this.txtClientID.Text;
      if (this.sBuildingType != "Apartment")
      {
        if (!this.RoomStatusCancel(Mod_UpdateData.sChkRoom))
        {
          int num2 = (int) MessageBox.Show("RoomStatusCancel Failed!");
          return false;
        }
      }
      else if (!this.CancelRoomStatus(Mod_UpdateData.sChkRoom))
      {
        int num3 = (int) MessageBox.Show("CancelRoomStatus Failed!");
        return false;
      }
      bool flag2 = false;
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          if (this.sBuildingType == "Normal")
          {
            row.RoomNo = "CN";
            row.Bond = 0M;
            row.Deposit = 0M;
            row.Remark = "Cancel WithoutCard";
            row.NoOfPeople = Convert.ToByte(gClientProperty.People);
            row.OldRoom = "";
            row.Condition = "";
            row.AdvancedPayment = 0M;
            row.LastPayment = 0M;
            row.AmountPaid = 0M;
            row.CheckOutDate = DateTime.Now.Date;
            row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
            row.LastRecDate = DateTime.Now.Date;
            row.Update = false;
            flag2 = true;
            break;
          }
          if (row.RoomNo.Substring(1, 2) == text.Substring(1, 2))
          {
            row.RoomNo = "CN";
            row.Bond = 0M;
            row.Deposit = 0M;
            row.Remark = "Cancel WithoutCard";
            row.NoOfPeople = Convert.ToByte(gClientProperty.People);
            row.OldRoom = "";
            row.Condition = "";
            row.AdvancedPayment = 0M;
            row.LastPayment = 0M;
            row.AmountPaid = 0M;
            row.CheckOutDate = DateTime.Now.Date;
            row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
            row.LastRecDate = DateTime.Now.Date;
            row.Update = false;
            flag2 = true;
            break;
          }
        }
      }
      if (flag2)
      {
        if (this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) <= 0)
        {
          int num4 = (int) MessageBox.Show("ClientAcc Update failed!");
          return false;
        }
        bool flag3 = true;
        if (this.txtRoomType.Text.ToUpper().Contains("STUDIO") || this.txtRoomType.Text.ToUpper().Contains("TWIN"))
        {
          foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
          {
            bool flag4;
            try
            {
              flag4 = row.RoomNo == null;
            }
            catch
            {
              flag4 = true;
            }
            if (!flag4 && (string) this.comboBox_txtSearchRoom.SelectedItem == row.RoomNo && row.NoOfPeople == (byte) 2)
            {
              row.RoomNo = "CN";
              row.Bond = 0M;
              row.Deposit = 0M;
              row.Remark = "Cancel WithoutCard";
              row.NoOfPeople = (byte) 0;
              row.OldRoom = "";
              row.Condition = "";
              row.AdvancedPayment = 0M;
              row.LastPayment = 0M;
              row.AmountPaid = 0M;
              row.CheckOutDate = DateTime.Now.Date;
              row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
              row.LastRecDate = DateTime.Now.Date;
              row.Update = false;
              if (this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) <= 0)
              {
                flag3 = false;
                break;
              }
              break;
            }
          }
        }
        if (!flag3)
        {
          int num5 = (int) MessageBox.Show("Second Major Card Cancel Update Failed!");
          return false;
        }
        if (!this.db.TransactionAdd())
        {
          int num6 = (int) MessageBox.Show("Transaction Record in CardTrans can not be added!");
          return false;
        }
        Mod_UpdateData.sChkExtraCharge = gClientProperty.ExtraCharge;
        try
        {
          if (Convert.ToDecimal(Mod_UpdateData.sChkExtraCharge) != 0M)
          {
            if (!this.ExtraCharge())
            {
              int num7 = (int) MessageBox.Show("ExtraCharge Table Update Failed!");
              return false;
            }
          }
        }
        catch
        {
        }
        gCardProperty.CheckOutDate = DateTime.Now.Date;
        gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
        if (this.db.LastTransAdd())
          return true;
        int num8 = (int) MessageBox.Show("Transaction Record in LastTrans Table can not be added!");
        return false;
      }
      int num9 = (int) MessageBox.Show("ClientAcc Update failed! ClientID not found!");
      return false;
    }

    private void button_CheckCard_Click(object sender, EventArgs e)
    {
      if (Global_Data.Card_Reader_Found_Flag)
      {
        this.Clear_Infomation();
        this.Refresh();
        if (this.Read_CardInformattion())
        {
          this.cmdCancel.Enabled = false;
          if (!this.CheckClientData())
          {
            this.lblMessage.Text = "Invalid Guest Card!";
            this.lblMessage.Refresh();
            Console.Beep(700, 300);
            Thread.Sleep(500);
            this.lblMessage.Text = "";
          }
          else
          {
            this.CheckClientData_Org();
            if (!this.CheckBuildingNoFromCard(this.Room_No_Calculated.Substring(0, 1)))
            {
              this.lblMessage.Text = "Invalid Card for current building!";
              this.lblMessage.Refresh();
              Console.Beep(700, 300);
              Thread.Sleep(500);
              this.lblMessage.Text = "";
            }
            else
            {
              this.txtRoomNo.Text = this.Room_No_Calculated;
              this.txtBuildingNo.Text = this.bld_no.Substring(1, 1);
              this.sBuildingType = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.CheckBuildingType(this.txtRoomNo.Text.Substring(0, 1));
              if (this.GetClientData())
              {
                this.Calculate_Refund();
                this.cmdCancel.Enabled = true;
                this.txtExtraDescription.Enabled = true;
                this.txtExtraCharge.Enabled = true;
              }
              else
              {
                this.lblMessage.Text = "GetClientData() Failed!";
                this.lblMessage.Refresh();
                Console.Beep(700, 300);
                Thread.Sleep(500);
                this.lblMessage.Text = "";
              }
            }
          }
        }
        else
          this.Clear_Infomation();
      }
      else
      {
        this.lblMessage.Text = "Card Reader Not Found!";
        this.lblMessage.Refresh();
        Console.Beep(700, 300);
        Thread.Sleep(500);
        this.lblMessage.Text = "";
        this.Clear_Infomation();
      }
    }

    private bool GetClientData()
    {
      byte num1 = 0;
      DateTime now = DateTime.Now;
      this.lblMessage.Text = "";
      this.lblMessage1.Text = "";
      this.lblMessage2.Text = "";
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
          int roomType = (int) row.RoomType;
          this.txtRoomType.Text = this.db.Get_RoomType_Description(row.RoomType);
          break;
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count <= 0)
          this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      catch
      {
        this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      bool flag = false;
      Mod_UpdateData.iChkCardStatus = byte.MaxValue;
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        try
        {
          if (row.CardNo == this.txtCardNo.Text)
          {
            if (row.Card_HW_ID == Global_Data.Card_HW_ID)
            {
              if (row.Card_AutoNumber == Global_Data.Card_AutoNumber)
              {
                this.txtClientID.Text = row.ClientID;
                this.txtDeposit.Text = row.KeyCharge.ToString("F2");
                this.sKeyDeposit = Convert.ToDouble(row.KeyCharge);
                this.lbCardType.Text = row.CardType;
                Mod_UpdateData.iChkCardStatus = row.CardStatus;
                if (!this.lbCardType.Text.ToUpper().Contains("GUEST"))
                  return false;
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
      if (!flag)
        return false;
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
          this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      catch
      {
        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      foreach (BuildingDB1DataSet.ClientAccRow row1 in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row1.ClientID == this.txtClientID.Text)
        {
          try
          {
            if (row1.ChargeType == "D")
              this.txtChargeType.Text = "Daily";
            else if (row1.ChargeType == "W")
              this.txtChargeType.Text = "Weekly";
            else
              this.txtChargeType.Text = "Monthly";
          }
          catch
          {
            //int num2 = (int) MessageBox.Show("Invalid Card!");
            return false;
          }
          num1 = row1.NoOfPeople;
          if (row1.NoOfPeople == (byte) 9 && this.txtRoomNo.Text != row1.RoomNo)
          {
            if (Mod_UpdateData.iChkCardStatus == (byte) 1 || Mod_UpdateData.iChkCardStatus == (byte) 0 || Mod_UpdateData.iChkCardStatus == (byte) 4)
            {
              if (row1.RoomNo == "CN")
              {
                this.cmdCancel.Text = "Cancel";
                this.lblMessage.Text = "Guest Already CheckOut/Cancel Without Card..";
                this.lblMessage2.Text = "Click Cancel Button to Clear Card Data..";
              }
              else
              {
                this.lblMessage.Text = "Guest Already CheckOut/Cancel..";
                this.lblMessage2.Text = "Click Cancel Button to Clear Card Data..";
                this.cmdCancel.Text = "Cancel";
              }
            }
            else
            {
              if (row1.RoomNo == "CN")
              {
                this.cmdCancel.Text = "Cancel";
                this.lblMessage.Text = "Guest Already CheckOut/Cancel Without Card..";
                this.lblMessage2.Text = "Click Cancel Button to Clear Card Data..";
              }
              else
              {
                this.lblMessage.Text = "Guest Already CheckOut/Cancel..";
                this.lblMessage2.Text = "Click Cancel Button to Clear Card Data..";
                this.cmdCancel.Text = "Cancel";
              }
              return false;
            }
          }
          if (row1.RoomNo == this.txtRoomNo.Text.Trim())
          {
            this.txtGracePeriod.Text = row1.GracePeriod.ToString();
            if (row1.NoOfPeople == (byte) 9)
            {
              this.txtAmountDue.Text = "0.00";
              this.txtAdvance.Text = "0.00";
              this.txtAmountPaid.Text = "0.00";
              this.txtGovBond.Text = "0.00";
              this.sCBond = "0.00";
            }
            else if (Mod_UpdateData.iChkCardStatus != (byte) 2)
            {
              this.txtAmountDue.Text = row1.AmountPaid.ToString("F2");
              this.txtAdvance.Text = row1.AdvancedPayment.ToString("F2");
              this.sCAdvance = row1.AdvancedPayment.ToString("F2");
              this.txtAmountPaid.Text = row1.LastPayment.ToString("F2");
              this.txtGovBond.Text = row1.Bond.ToString("F2");
              this.sCBond = row1.Bond.ToString("F2");
            }
            else
            {
              this.sKeyDeposit = 0.0;
              this.cmdCancel.Text = "Clear";
              this.lblMessage2.Text = "Click Clear Button To Clear Card Data..";
            }
            try
            {
              this.mskContractStart.Text = row1.ContractStart.ToShortDateString();
            }
            catch
            {
            }
            try
            {
              this.mskContractEnd.Text = row1.ContractEnd.ToShortDateString();
            }
            catch
            {
            }
            string text = this.mskCheckOutDate.Text;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition = row1.Condition;
            this.mskValidStart.Text = AccessCard.sCardInDate;
            try
            {
              this.txtCheckInDate.Text = row1.CheckInDate.ToShortDateString();
            }
            catch
            {
            }
            try
            {
              gCardProperty.CheckInDate = row1.CheckInDate;
            }
            catch
            {
            }
            try
            {
              gCardProperty.CheckInTime = row1.CheckInTime;
            }
            catch
            {
            }
            this.mskValidEnd.Text = DateTime.Parse(this.mskCheckOutDate.Text).AddDays((double) -row1.GracePeriod).ToShortDateString();
            try
            {
              if (row1.Remark != "")
                this.txtRemark.Text = row1.Remark;
              else
                this.txtRemark.Text = "";
            }
            catch
            {
              this.txtRemark.Text = "";
            }
          }
          else
          {
            this.mskContractStart.Text = AccessCard.sCardInDate;
            this.mskContractEnd.Text = AccessCard.sCardOutDate;
            this.mskValidStart.Text = AccessCard.sCardInDate;
            string text = this.mskCheckOutDate.Text;
            this.mskValidEnd.Text = DateTime.Parse(this.mskCheckOutDate.Text).AddDays((double) -row1.GracePeriod).ToShortDateString();
            this.txtAmountDue.Text = "0.00";
            this.txtAdvance.Text = "0.00";
            this.txtAmountPaid.Text = "0.00";
            this.txtGovBond.Text = "0.00";
            this.sCBond = "0.00";
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition = row1.Condition;
          }
          this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
          foreach (SystemDataSet.RoomRow row2 in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
          {
            if (row2.RoomNo == this.txtRoomNo.Text)
            {
              int roomType = (int) row2.RoomType;
              string roomTypeDescription = this.db.Get_RoomType_Description(row2.RoomType);
              if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
              {
                if (row2.TotalStay == (byte) 1)
                {
                  if (this.txtChargeType.Text.Contains("Monthly"))
                  {
                    this.txtRoomCharge.Text = row2.MonthlyRate.ToString("F02");
                    break;
                  }
                  if (this.txtChargeType.Text.Contains("Weekly"))
                  {
                    this.txtRoomCharge.Text = row2.WeeklyRate.ToString("F02");
                    break;
                  }
                  if (this.txtChargeType.Text.Contains("Daily"))
                  {
                    this.txtRoomCharge.Text = row2.DailyRate.ToString("F02");
                    break;
                  }
                  break;
                }
                if (row2.TotalStay == (byte) 2)
                {
                  if (this.txtChargeType.Text.Contains("Monthly"))
                  {
                    this.txtRoomCharge.Text = row2.MonthlyRate2.ToString("F02");
                    break;
                  }
                  if (this.txtChargeType.Text.Contains("Weekly"))
                  {
                    this.txtRoomCharge.Text = row2.WeeklyRate2.ToString("F02");
                    break;
                  }
                  if (this.txtChargeType.Text.Contains("Daily"))
                  {
                    this.txtRoomCharge.Text = row2.DailyRate2.ToString("F02");
                    break;
                  }
                  break;
                }
                break;
              }
              if (this.txtChargeType.Text.Contains("Monthly"))
              {
                this.txtRoomCharge.Text = row2.MonthlyRate.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Weekly"))
              {
                this.txtRoomCharge.Text = row2.WeeklyRate.ToString("F02");
                break;
              }
              if (this.txtChargeType.Text.Contains("Daily"))
              {
                this.txtRoomCharge.Text = row2.DailyRate.ToString("F02");
                break;
              }
              break;
            }
          }
          if (this.sBuildingType == "Apartment")
          {
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsCondition == "Unit")
              Mod_UpdateData.sChkRoom = this.txtRoomNo.Text;
          }
          try
          {
            if (row1.Remark != "")
            {
              this.txtRemark.Text = row1.Remark;
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
          break;
        case 3:
          this.lblMessage1.Text = "CheckOut/Cancel Card: " + this.txtCardNo.Text;
          break;
        case 4:
          this.lblMessage1.Text = "CheckOut/Cancel Without Card: " + this.txtCardNo.Text;
          break;
      }
      return true;
    }

    private bool Read_CardInformattion()
    {
      this.Room_No_Calculated = "00000";
      if (SmartCard_Procedures.ReadCard_Information((int) Global_Data.COM_NUM))
      {
        string str = SmartCard_Procedures.Card_Information_String.Substring(2, 2);
        int int32 = Convert.ToInt32(str);
        if (!SmartCard_Procedures.ReadCardID((int) Global_Data.COM_NUM))
          return false;
        Global_Data.Card_HW_ID = SmartCard_Procedures.Card_ID_String;
        if (!SmartCard_Procedures.ReadCardNumber((int) Global_Data.COM_NUM))
          return false;
        Global_Data.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
        if (str == Card_Type_Code.Guest_card)
        {
          this.bld_no = SmartCard_Procedures.Card_Information_String.Substring(8, 2);
          this.floor_no = SmartCard_Procedures.Card_Information_String.Substring(10, 2);
          this.room_no = SmartCard_Procedures.Card_Information_String.Substring(12, 2);
          this.Begin_Date = "20" + SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
          this.End_Date = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
          this.Room_No_Calculated = this.bld_no.Substring(1, 1) + this.floor_no + this.room_no;
          AccessCard.sCardInDate = "20" + SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
          this.mskValidStart.Text = AccessCard.sCardInDate;
          this.mskCheckOutDate.Text = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
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

    private bool CheckClientData()
    {
      bool flag = false;
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count <= 0)
          this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      catch
      {
        this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      }
      Mod_UpdateData.iChkCardStatus = byte.MaxValue;
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        try
        {
          if (row.RoomNo == this.Room_No_Calculated)
          {
            if (row.Card_HW_ID == Global_Data.Card_HW_ID)
            {
              if (row.Card_AutoNumber == Global_Data.Card_AutoNumber)
              {
                this.txtCardNo.Text = row.CardNo;
                this.txtClientID.Text = row.ClientID;
                Mod_UpdateData.iChkCardStatus = row.CardStatus;
                this.txtDeposit.Text = row.KeyCharge.ToString("F2");
                this.sKeyDeposit = Convert.ToDouble(row.KeyCharge);
                this.lbCardType.Text = row.CardType;
                if (!this.lbCardType.Text.ToUpper().Contains("GUEST"))
                  return false;
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

    private bool CheckClientData_Org()
    {
      AccessCard.sCardRoom = this.Room_No_Calculated;
      AccessCard.sCardOutDate = "20" + SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
      AccessCard.sCardInDate = "20" + SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
      this.mskCheckOutDate.Text = AccessCard.sCardOutDate;
      this.txtCheckInDate.Text = AccessCard.sCardInDate;
      this.txtRoomNo.Text = AccessCard.sCardRoom;
      this.sCardBuildingNo = this.bld_no;
      this.txtBuildingNo.Text = Convert.ToInt16(this.bld_no).ToString();
      return true;
    }

    private bool CheckBuildingNoFromCard(string para_BuildingNo)
    {
      if (para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || para_BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
      {
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sCardSerialNo = this.txtCardNo.Text;
        return true;
      }
      //this.lblMessage.Text = "Invalid Card : " + this.txtCardNo.Text;
      return false;
    }

    private void comboBox_txtSearchRoom_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Clear_Infomation();
      this.cmdPrint.Enabled = false;
      this.cmdCancel.Enabled = false;
      this.button_Select.Enabled = true;
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      if (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count <= 0)
        return;
      BuildingDB1DataSet.LastTransRow lastTran = this.db.building_DB1.buildingDB1DataSet.LastTrans[this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count - 1];
      string transType = lastTran.TransType;
      int transId = lastTran.TransID;
      this.Refresh();
      ReportForm reportForm = new ReportForm();
      ReportClass_Receipt_CancelGuest receiptCancelGuest = new ReportClass_Receipt_CancelGuest();
      reportForm.crystalReportViewer1.ReportSource = receiptCancelGuest.CHECK_TransType(transType, transId, Global_Data.sBldNo);
      int num = (int) reportForm.ShowDialog();
    }

    private void Form_CancelGuestCardDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Clear_Infomation();
      this.cmdPrint.Enabled = false;
    }

    private void Filter_Keys_N_Dot(KeyPressEventArgs e, string para_string)
    {
      if (para_string.Contains(".") && e.KeyChar == '.')
        e.Handled = true;
      else if (para_string.Contains("-") && e.KeyChar == '-')
        e.Handled = true;
      else if (e.KeyChar == '-')
        e.Handled = false;
      else if (e.KeyChar == '.')
        e.Handled = false;
      else if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void txtExtraCharge_Click(object sender, EventArgs e)
    {
      this.ExtraChargeFrame.Enabled = true;
      this.ExtraChargeFrame.Visible = true;
      this.ExtraChargeFrame.BringToFront();
      this.txtExtraDescription.Enabled = false;
      this.Check_Extra_textBoxs();
    }

    private void txtExtraCharge_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.ExtraChargeFrame.Enabled = true;
      this.ExtraChargeFrame.Visible = true;
      this.ExtraChargeFrame.BringToFront();
      this.txtExtraDescription.Enabled = false;
      this.Check_Extra_textBoxs();
      e.Handled = true;
    }

    private void txtExtraDescription_Click(object sender, EventArgs e)
    {
      this.ExtraChargeFrame.Enabled = true;
      this.ExtraChargeFrame.Visible = true;
      this.ExtraChargeFrame.BringToFront();
      this.txtExtraDescription.Enabled = false;
      this.Check_Extra_textBoxs();
    }

    private void txtExtraDescription_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.ExtraChargeFrame.Enabled = true;
      this.ExtraChargeFrame.Visible = true;
      this.ExtraChargeFrame.BringToFront();
      this.txtExtraDescription.Enabled = false;
      this.Check_Extra_textBoxs();
      e.Handled = true;
    }

    private void _txtDesExtra_0_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.lblMessage.Text = "Click OK after finish!";
      if (e.KeyChar != '\r')
        return;
      this._txtExtraAmount_0.Select();
      this._txtExtraAmount_0.Focus();
      e.Handled = true;
    }

    private void _txtDesExtra_1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.lblMessage.Text = "Click OK after finish!";
      if (e.KeyChar != '\r')
        return;
      this._txtExtraAmount_1.Select();
      this._txtExtraAmount_1.Focus();
      e.Handled = true;
    }

    private void _txtDesExtra_2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.lblMessage.Text = "Click OK after finish!";
      if (e.KeyChar != '\r')
        return;
      this._txtExtraAmount_2.Select();
      this._txtExtraAmount_2.Focus();
      e.Handled = true;
    }

    private void _txtDesExtra_3_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.lblMessage.Text = "Click OK after finish!";
      if (e.KeyChar != '\r')
        return;
      this._txtExtraAmount_3.Select();
      this._txtExtraAmount_3.Focus();
      e.Handled = true;
    }

    private void _txtDesExtra_4_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.lblMessage.Text = "Click OK after finish!";
      if (e.KeyChar != '\r')
        return;
      this._txtExtraAmount_4.Select();
      this._txtExtraAmount_4.Focus();
      e.Handled = true;
    }

    private void ExtraChargeFrame_Leave(object sender, EventArgs e)
    {
    }

    private void ExtraChargeFrame_Enter_Process()
    {
      if (!this.ExtraChargeFrame.Visible)
        return;
      this.button_CheckCard.Enabled = false;
      this.button_Select.Enabled = false;
      this._optCard_0.Enabled = false;
      this._optCard_1.Enabled = false;
      this.comboBox_txtSearchRoom.Enabled = false;
      this.cmdCancel.Enabled = false;
    }

    private void ExtraChargeFrame_Exit_Process()
    {
      this.button_CheckCard.Enabled = true;
      this.button_Select.Enabled = true;
      this._optCard_0.Enabled = true;
      this._optCard_1.Enabled = true;
      this.comboBox_txtSearchRoom.Enabled = true;
      this.cmdCancel.Enabled = true;
    }

    private void ExtraChargeFrame_Enter(object sender, EventArgs e)
    {
      this.ExtraChargeFrame_Enter_Process();
    }
  }
}
