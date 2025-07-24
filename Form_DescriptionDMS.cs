// Decompiled with JetBrains decompiler
// Type: AMS.Form_DescriptionDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_DescriptionDMS : Form
  {
    private IContainer components;
    public RadioButton _optEntitle1_0;
    public ToolTip ToolTip1;
    public Button cmdSpareCharge;
    public TextBox txtSpareKeyCharge;
    public Button cmdKeyDeposit;
    public TextBox txtKeyDeposit;
    public CheckBox chkGrace;
    public CheckBox chkGST;
    public Button CmdPrint;
    public TextBox txtSystemID;
    public TextBox txtStaffID;
    public Button cmdReturn;
    public TextBox txtSystemDescription;
    public Button cmdSet;
    public TextBox txtGSTRate;
    public ComboBox cboCommPort;
    public ComboBox cboBuildingNo;
    public CheckBox chkBonus;
    public RadioButton _optEntitle1_1;
    public RadioButton _optEntitle1_2;
    public TextBox txtTotalBonus1;
    public TextBox txtTotalStay1;
    public Label lblBonus1;
    public Label lblTotalBonus1;
    public GroupBox EntitleFrame2;
    public GroupBox WFrame;
    public Label lblTotalStay1;
    public Label Label9;
    public ComboBox cboDGrace;
    public Label Label8;
    public TextBox txtCommPort;
    public ComboBox cboWGrace;
    public GroupBox BonusFrame;
    public GroupBox MFrame;
    public TextBox txtTotalStay;
    public Label lblTotalStay;
    public Label Label10;
    public Label Label13;
    public ComboBox cboMGrace;
    public GroupBox KeyCharges;
    public Label Label11;
    public Label Label7;
    public Label Label6;
    public Label Label5;
    public Label Label4;
    public Label Label3;
    public Label Label2;
    public Label Label1;
    public Label lblBuilding;
    public GroupBox GraceFrame;
    public Label Label15;
    public Label Label14;
    public Label Label12;
    public RadioButton _optEntitle_2;
    public GroupBox Frame1;
    public TextBox txtTotalBonus;
    public GroupBox EntitleFrame;
    public RadioButton _optEntitle_1;
    public RadioButton _optEntitle_0;
    public Label lblTotalBonus;
    public Label lblBonus;
    private DateTimePicker dateTimePicker_mskBonusStart1;
    private DateTimePicker dateTimePicker_mskBonusDisableDate;
    public ComboBox cboBuildingType;
    public MaskedTextBox txtCheckOutTime;
    private DateTimePicker dateTimePicker_mskBonusStart;
    private DB db;
    private string sSystemID = "";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_DescriptionDMS));
      this._optEntitle1_0 = new RadioButton();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdSpareCharge = new Button();
      this.txtSpareKeyCharge = new TextBox();
      this.cmdKeyDeposit = new Button();
      this.txtKeyDeposit = new TextBox();
      this.cboBuildingType = new ComboBox();
      this.chkGrace = new CheckBox();
      this.chkGST = new CheckBox();
      this.CmdPrint = new Button();
      this.txtSystemID = new TextBox();
      this.txtStaffID = new TextBox();
      this.cmdReturn = new Button();
      this.txtSystemDescription = new TextBox();
      this.cmdSet = new Button();
      this.txtGSTRate = new TextBox();
      this.cboCommPort = new ComboBox();
      this.cboBuildingNo = new ComboBox();
      this.chkBonus = new CheckBox();
      this.txtCheckOutTime = new MaskedTextBox();
      this._optEntitle1_1 = new RadioButton();
      this._optEntitle1_2 = new RadioButton();
      this.txtTotalBonus1 = new TextBox();
      this.txtTotalStay1 = new TextBox();
      this.lblBonus1 = new Label();
      this.lblTotalBonus1 = new Label();
      this.EntitleFrame2 = new GroupBox();
      this.WFrame = new GroupBox();
      this.lblTotalStay1 = new Label();
      this.Label9 = new Label();
      this.cboDGrace = new ComboBox();
      this.Label8 = new Label();
      this.txtCommPort = new TextBox();
      this.cboWGrace = new ComboBox();
      this.BonusFrame = new GroupBox();
      this.Label10 = new Label();
      this.Label13 = new Label();
      this.MFrame = new GroupBox();
      this.EntitleFrame = new GroupBox();
      this.txtTotalBonus = new TextBox();
      this._optEntitle_2 = new RadioButton();
      this._optEntitle_1 = new RadioButton();
      this._optEntitle_0 = new RadioButton();
      this.lblTotalBonus = new Label();
      this.lblBonus = new Label();
      this.txtTotalStay = new TextBox();
      this.lblTotalStay = new Label();
      this.dateTimePicker_mskBonusStart1 = new DateTimePicker();
      this.dateTimePicker_mskBonusStart = new DateTimePicker();
      this.cboMGrace = new ComboBox();
      this.KeyCharges = new GroupBox();
      this.Label11 = new Label();
      this.Label7 = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.lblBuilding = new Label();
      this.GraceFrame = new GroupBox();
      this.Label15 = new Label();
      this.Label14 = new Label();
      this.Label12 = new Label();
      this.Frame1 = new GroupBox();
      this.dateTimePicker_mskBonusDisableDate = new DateTimePicker();
      this.EntitleFrame2.SuspendLayout();
      this.WFrame.SuspendLayout();
      this.BonusFrame.SuspendLayout();
      this.MFrame.SuspendLayout();
      this.EntitleFrame.SuspendLayout();
      this.KeyCharges.SuspendLayout();
      this.GraceFrame.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this._optEntitle1_0.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle1_0.Cursor = Cursors.Default;
      this._optEntitle1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle1_0.ForeColor = SystemColors.ControlText;
      this._optEntitle1_0.Location = new Point(8, 24);
      this._optEntitle1_0.Name = "_optEntitle1_0";
      this._optEntitle1_0.RightToLeft = RightToLeft.No;
      this._optEntitle1_0.Size = new Size(57, 25);
      this._optEntitle1_0.TabIndex = 27;
      this._optEntitle1_0.TabStop = true;
      this._optEntitle1_0.Text = "Day";
      this._optEntitle1_0.UseVisualStyleBackColor = false;
      this.cmdSpareCharge.BackColor = SystemColors.Control;
      this.cmdSpareCharge.Cursor = Cursors.Default;
      this.cmdSpareCharge.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSpareCharge.ForeColor = SystemColors.ControlText;
      this.cmdSpareCharge.Location = new Point(256, 48);
      this.cmdSpareCharge.Name = "cmdSpareCharge";
      this.cmdSpareCharge.RightToLeft = RightToLeft.No;
      this.cmdSpareCharge.Size = new Size(57, 25);
      this.cmdSpareCharge.TabIndex = 13;
      this.cmdSpareCharge.Text = "Update";
      this.ToolTip1.SetToolTip((Control) this.cmdSpareCharge, "To Update Spare Key Charge");
      this.cmdSpareCharge.UseVisualStyleBackColor = false;
      this.cmdSpareCharge.Click += new EventHandler(this.cmdSpareCharge_Click);
      this.txtSpareKeyCharge.AcceptsReturn = true;
      this.txtSpareKeyCharge.BackColor = SystemColors.Window;
      this.txtSpareKeyCharge.Cursor = Cursors.IBeam;
      this.txtSpareKeyCharge.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtSpareKeyCharge.ForeColor = SystemColors.WindowText;
      this.txtSpareKeyCharge.Location = new Point(184, 48);
      this.txtSpareKeyCharge.MaxLength = 0;
      this.txtSpareKeyCharge.Name = "txtSpareKeyCharge";
      this.txtSpareKeyCharge.RightToLeft = RightToLeft.No;
      this.txtSpareKeyCharge.Size = new Size(57, 20);
      this.txtSpareKeyCharge.TabIndex = 12;
      this.txtSpareKeyCharge.Text = "0.00";
      this.ToolTip1.SetToolTip((Control) this.txtSpareKeyCharge, "Spare Key Charge");
      this.cmdKeyDeposit.BackColor = SystemColors.Control;
      this.cmdKeyDeposit.Cursor = Cursors.Default;
      this.cmdKeyDeposit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdKeyDeposit.ForeColor = SystemColors.ControlText;
      this.cmdKeyDeposit.Location = new Point(88, 48);
      this.cmdKeyDeposit.Name = "cmdKeyDeposit";
      this.cmdKeyDeposit.RightToLeft = RightToLeft.No;
      this.cmdKeyDeposit.Size = new Size(57, 25);
      this.cmdKeyDeposit.TabIndex = 11;
      this.cmdKeyDeposit.Text = "Update";
      this.ToolTip1.SetToolTip((Control) this.cmdKeyDeposit, "To Update New Key Deposit");
      this.cmdKeyDeposit.UseVisualStyleBackColor = false;
      this.cmdKeyDeposit.Click += new EventHandler(this.cmdKeyDeposit_Click);
      this.txtKeyDeposit.AcceptsReturn = true;
      this.txtKeyDeposit.BackColor = SystemColors.Window;
      this.txtKeyDeposit.Cursor = Cursors.IBeam;
      this.txtKeyDeposit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtKeyDeposit.ForeColor = SystemColors.WindowText;
      this.txtKeyDeposit.Location = new Point(16, 48);
      this.txtKeyDeposit.MaxLength = 0;
      this.txtKeyDeposit.Name = "txtKeyDeposit";
      this.txtKeyDeposit.RightToLeft = RightToLeft.No;
      this.txtKeyDeposit.Size = new Size(57, 20);
      this.txtKeyDeposit.TabIndex = 10;
      this.txtKeyDeposit.Text = "0.00";
      this.ToolTip1.SetToolTip((Control) this.txtKeyDeposit, "New Key Deposit");
      this.cboBuildingType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.cboBuildingType.Cursor = Cursors.Default;
      this.cboBuildingType.Enabled = false;
      this.cboBuildingType.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingType.ForeColor = Color.Blue;
      this.cboBuildingType.FormatString = "N2";
      this.cboBuildingType.FormattingEnabled = true;
      this.cboBuildingType.Location = new Point(192, 48);
      this.cboBuildingType.Name = "cboBuildingType";
      this.cboBuildingType.Size = new Size(105, 24);
      this.cboBuildingType.TabIndex = 63;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingType, "To Select Building Type");
      this.chkGrace.BackColor = Color.FromArgb(0, 192, 0);
      this.chkGrace.Cursor = Cursors.Default;
      this.chkGrace.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkGrace.ForeColor = Color.White;
      this.chkGrace.Location = new Point(392, 24);
      this.chkGrace.Name = "chkGrace";
      this.chkGrace.RightToLeft = RightToLeft.No;
      this.chkGrace.Size = new Size(169, 25);
      this.chkGrace.TabIndex = 14;
      this.chkGrace.Text = "Grace Period Edit";
      this.ToolTip1.SetToolTip((Control) this.chkGrace, "Tick to Edit Grace Period");
      this.chkGrace.UseVisualStyleBackColor = false;
      this.chkGST.BackColor = Color.Cyan;
      this.chkGST.Cursor = Cursors.Default;
      this.chkGST.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkGST.ForeColor = Color.Blue;
      this.chkGST.Location = new Point(248, 280);
      this.chkGST.Name = "chkGST";
      this.chkGST.RightToLeft = RightToLeft.No;
      this.chkGST.Size = new Size(81, 25);
      this.chkGST.TabIndex = 9;
      this.chkGST.Text = "CHANGE";
      this.ToolTip1.SetToolTip((Control) this.chkGST, "Tick to Edit GST Rate");
      this.chkGST.UseVisualStyleBackColor = false;
      this.CmdPrint.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.CmdPrint.Cursor = Cursors.Default;
      this.CmdPrint.Enabled = false;
      this.CmdPrint.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CmdPrint.ForeColor = SystemColors.ControlText;
      this.CmdPrint.Image = (Image) componentResourceManager.GetObject("CmdPrint.Image");
      this.CmdPrint.Location = new Point(280, 408);
      this.CmdPrint.Name = "CmdPrint";
      this.CmdPrint.RightToLeft = RightToLeft.No;
      this.CmdPrint.Size = new Size(113, 47);
      this.CmdPrint.TabIndex = 31;
      this.CmdPrint.Text = "&PRINT";
      this.CmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdPrint, "To Print System Info");
      this.CmdPrint.UseVisualStyleBackColor = false;
      this.CmdPrint.Click += new EventHandler(this.CmdPrint_Click);
      this.txtSystemID.AcceptsReturn = true;
      this.txtSystemID.BackColor = SystemColors.Window;
      this.txtSystemID.Cursor = Cursors.IBeam;
      this.txtSystemID.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSystemID.ForeColor = Color.Red;
      this.txtSystemID.Location = new Point(192, 200);
      this.txtSystemID.MaxLength = 0;
      this.txtSystemID.Name = "txtSystemID";
      this.txtSystemID.RightToLeft = RightToLeft.No;
      this.txtSystemID.Size = new Size(129, 22);
      this.txtSystemID.TabIndex = 6;
      this.txtSystemID.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtSystemID, "System ID");
      this.txtStaffID.AcceptsReturn = true;
      this.txtStaffID.BackColor = SystemColors.Window;
      this.txtStaffID.Cursor = Cursors.IBeam;
      this.txtStaffID.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtStaffID.ForeColor = Color.Red;
      this.txtStaffID.Location = new Point(192, 240);
      this.txtStaffID.MaxLength = 0;
      this.txtStaffID.Name = "txtStaffID";
      this.txtStaffID.ReadOnly = true;
      this.txtStaffID.RightToLeft = RightToLeft.No;
      this.txtStaffID.Size = new Size(129, 22);
      this.txtStaffID.TabIndex = 7;
      this.txtStaffID.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtStaffID, "Staff ID");
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(408, 408);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(113, 47);
      this.cmdReturn.TabIndex = 32;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "To Return Main Setting Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtSystemDescription.AcceptsReturn = true;
      this.txtSystemDescription.BackColor = SystemColors.Window;
      this.txtSystemDescription.Cursor = Cursors.IBeam;
      this.txtSystemDescription.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSystemDescription.ForeColor = Color.Red;
      this.txtSystemDescription.Location = new Point(192, 80);
      this.txtSystemDescription.MaxLength = 35;
      this.txtSystemDescription.Name = "txtSystemDescription";
      this.txtSystemDescription.RightToLeft = RightToLeft.No;
      this.txtSystemDescription.Size = new Size(313, 22);
      this.txtSystemDescription.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.txtSystemDescription, "System Description");
      this.cmdSet.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cmdSet.Cursor = Cursors.Default;
      this.cmdSet.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdSet.ForeColor = SystemColors.ControlText;
      this.cmdSet.Image = (Image) componentResourceManager.GetObject("cmdSet.Image");
      this.cmdSet.Location = new Point(152, 408);
      this.cmdSet.Name = "cmdSet";
      this.cmdSet.RightToLeft = RightToLeft.No;
      this.cmdSet.Size = new Size(113, 47);
      this.cmdSet.TabIndex = 30;
      this.cmdSet.Text = "&SET";
      this.cmdSet.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdSet, "Confirm Update System Setting");
      this.cmdSet.UseVisualStyleBackColor = false;
      this.cmdSet.Click += new EventHandler(this.cmdSet_Click);
      this.txtGSTRate.AcceptsReturn = true;
      this.txtGSTRate.BackColor = SystemColors.Window;
      this.txtGSTRate.Cursor = Cursors.IBeam;
      this.txtGSTRate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGSTRate.ForeColor = Color.Red;
      this.txtGSTRate.Location = new Point(192, 280);
      this.txtGSTRate.MaxLength = 0;
      this.txtGSTRate.Name = "txtGSTRate";
      this.txtGSTRate.RightToLeft = RightToLeft.No;
      this.txtGSTRate.Size = new Size(49, 22);
      this.txtGSTRate.TabIndex = 8;
      this.txtGSTRate.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtGSTRate, "GST Rate");
      this.txtGSTRate.TextChanged += new EventHandler(this.txtGSTRate_TextChanged);
      this.txtGSTRate.KeyPress += new KeyPressEventHandler(this.txtGSTRate_KeyPress);
      this.cboCommPort.BackColor = SystemColors.Window;
      this.cboCommPort.Cursor = Cursors.Default;
      this.cboCommPort.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboCommPort.ForeColor = Color.Black;
      this.cboCommPort.Location = new Point(35, 93);
      this.cboCommPort.Name = "cboCommPort";
      this.cboCommPort.RightToLeft = RightToLeft.No;
      this.cboCommPort.Size = new Size(113, 24);
      this.cboCommPort.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.cboCommPort, "To Select Communication Port");
      this.cboCommPort.Visible = false;
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Enabled = false;
      this.cboBuildingNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = SystemColors.WindowText;
      this.cboBuildingNo.FormatString = "N2";
      this.cboBuildingNo.FormattingEnabled = true;
      this.cboBuildingNo.Location = new Point(192, 16);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(57, 22);
      this.cboBuildingNo.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Building Selection");
      this.chkBonus.BackColor = Color.Yellow;
      this.chkBonus.Cursor = Cursors.Default;
      this.chkBonus.Enabled = false;
      this.chkBonus.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkBonus.ForeColor = Color.Blue;
      this.chkBonus.Location = new Point(352, 112);
      this.chkBonus.Name = "chkBonus";
      this.chkBonus.RightToLeft = RightToLeft.No;
      this.chkBonus.Size = new Size(81, 25);
      this.chkBonus.TabIndex = 3;
      this.chkBonus.Text = "BONUS ";
      this.ToolTip1.SetToolTip((Control) this.chkBonus, "Tick for Bonus Enable/ Untick to Disable Bonus Function");
      this.chkBonus.UseVisualStyleBackColor = false;
      this.chkBonus.Visible = false;
      this.chkBonus.CheckedChanged += new EventHandler(this.chkBonus_CheckedChanged);
      this.txtCheckOutTime.AllowPromptAsInput = false;
      this.txtCheckOutTime.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.txtCheckOutTime.ForeColor = Color.Red;
      this.txtCheckOutTime.Location = new Point(192, 159);
      this.txtCheckOutTime.Mask = "##:##";
      this.txtCheckOutTime.Name = "txtCheckOutTime";
      this.txtCheckOutTime.PromptChar = '0';
      this.txtCheckOutTime.Size = new Size(49, 22);
      this.txtCheckOutTime.TabIndex = 168;
      this.ToolTip1.SetToolTip((Control) this.txtCheckOutTime, "Valid End Time");
      this.txtCheckOutTime.KeyPress += new KeyPressEventHandler(this.txtCheckOutTime_KeyPress);
      this._optEntitle1_1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle1_1.Cursor = Cursors.Default;
      this._optEntitle1_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle1_1.ForeColor = SystemColors.ControlText;
      this._optEntitle1_1.Location = new Point(8, 56);
      this._optEntitle1_1.Name = "_optEntitle1_1";
      this._optEntitle1_1.RightToLeft = RightToLeft.No;
      this._optEntitle1_1.Size = new Size(57, 25);
      this._optEntitle1_1.TabIndex = 26;
      this._optEntitle1_1.TabStop = true;
      this._optEntitle1_1.Text = "Week";
      this._optEntitle1_1.UseVisualStyleBackColor = false;
      this._optEntitle1_2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle1_2.Cursor = Cursors.Default;
      this._optEntitle1_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle1_2.ForeColor = SystemColors.ControlText;
      this._optEntitle1_2.Location = new Point(8, 88);
      this._optEntitle1_2.Name = "_optEntitle1_2";
      this._optEntitle1_2.RightToLeft = RightToLeft.No;
      this._optEntitle1_2.Size = new Size(57, 25);
      this._optEntitle1_2.TabIndex = 28;
      this._optEntitle1_2.TabStop = true;
      this._optEntitle1_2.Text = "Month";
      this._optEntitle1_2.UseVisualStyleBackColor = false;
      this.txtTotalBonus1.AcceptsReturn = true;
      this.txtTotalBonus1.BackColor = SystemColors.Window;
      this.txtTotalBonus1.Cursor = Cursors.IBeam;
      this.txtTotalBonus1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalBonus1.ForeColor = Color.Blue;
      this.txtTotalBonus1.Location = new Point(96, 90);
      this.txtTotalBonus1.MaxLength = 0;
      this.txtTotalBonus1.Name = "txtTotalBonus1";
      this.txtTotalBonus1.RightToLeft = RightToLeft.No;
      this.txtTotalBonus1.Size = new Size(49, 20);
      this.txtTotalBonus1.TabIndex = 29;
      this.txtTotalBonus1.TextAlign = HorizontalAlignment.Center;
      this.txtTotalStay1.AcceptsReturn = true;
      this.txtTotalStay1.BackColor = SystemColors.Window;
      this.txtTotalStay1.Cursor = Cursors.IBeam;
      this.txtTotalStay1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalStay1.ForeColor = Color.Blue;
      this.txtTotalStay1.Location = new Point(104, 16);
      this.txtTotalStay1.MaxLength = 0;
      this.txtTotalStay1.Name = "txtTotalStay1";
      this.txtTotalStay1.RightToLeft = RightToLeft.No;
      this.txtTotalStay1.Size = new Size(57, 20);
      this.txtTotalStay1.TabIndex = 25;
      this.lblBonus1.BackColor = Color.FromArgb(0, 192, 192);
      this.lblBonus1.Cursor = Cursors.Default;
      this.lblBonus1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBonus1.ForeColor = Color.White;
      this.lblBonus1.Location = new Point(72, 40);
      this.lblBonus1.Name = "lblBonus1";
      this.lblBonus1.RightToLeft = RightToLeft.No;
      this.lblBonus1.Size = new Size(97, 25);
      this.lblBonus1.TabIndex = 57;
      this.lblBonus1.Text = "Total Bonus";
      this.lblTotalBonus1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblTotalBonus1.Cursor = Cursors.Default;
      this.lblTotalBonus1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalBonus1.ForeColor = SystemColors.ControlText;
      this.lblTotalBonus1.Location = new Point(88, 64);
      this.lblTotalBonus1.Name = "lblTotalBonus1";
      this.lblTotalBonus1.RightToLeft = RightToLeft.No;
      this.lblTotalBonus1.Size = new Size(65, 25);
      this.lblTotalBonus1.TabIndex = 56;
      this.lblTotalBonus1.TextAlign = ContentAlignment.TopCenter;
      this.EntitleFrame2.BackColor = Color.FromArgb(192, 192, 0);
      this.EntitleFrame2.Controls.Add((Control) this._optEntitle1_0);
      this.EntitleFrame2.Controls.Add((Control) this._optEntitle1_1);
      this.EntitleFrame2.Controls.Add((Control) this._optEntitle1_2);
      this.EntitleFrame2.Controls.Add((Control) this.txtTotalBonus1);
      this.EntitleFrame2.Controls.Add((Control) this.lblBonus1);
      this.EntitleFrame2.Controls.Add((Control) this.lblTotalBonus1);
      this.EntitleFrame2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EntitleFrame2.ForeColor = SystemColors.ControlText;
      this.EntitleFrame2.Location = new Point(8, 48);
      this.EntitleFrame2.Name = "EntitleFrame2";
      this.EntitleFrame2.Padding = new Padding(0);
      this.EntitleFrame2.RightToLeft = RightToLeft.No;
      this.EntitleFrame2.Size = new Size(177, 121);
      this.EntitleFrame2.TabIndex = 55;
      this.EntitleFrame2.TabStop = false;
      this.EntitleFrame2.Text = "Entitle For";
      this.WFrame.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.WFrame.Controls.Add((Control) this.EntitleFrame2);
      this.WFrame.Controls.Add((Control) this.txtTotalStay1);
      this.WFrame.Controls.Add((Control) this.lblTotalStay1);
      this.WFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.WFrame.ForeColor = Color.Black;
      this.WFrame.Location = new Point(216, 72);
      this.WFrame.Name = "WFrame";
      this.WFrame.Padding = new Padding(0);
      this.WFrame.RightToLeft = RightToLeft.No;
      this.WFrame.Size = new Size(193, 177);
      this.WFrame.TabIndex = 52;
      this.WFrame.TabStop = false;
      this.WFrame.Text = "WEEKLY STAY :";
      this.lblTotalStay1.BackColor = Color.Blue;
      this.lblTotalStay1.Cursor = Cursors.Default;
      this.lblTotalStay1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalStay1.ForeColor = Color.White;
      this.lblTotalStay1.Location = new Point(8, 16);
      this.lblTotalStay1.Name = "lblTotalStay1";
      this.lblTotalStay1.RightToLeft = RightToLeft.No;
      this.lblTotalStay1.Size = new Size(89, 25);
      this.lblTotalStay1.TabIndex = 54;
      this.lblTotalStay1.Text = "Total Stay";
      this.lblTotalStay1.TextAlign = ContentAlignment.TopRight;
      this.Label9.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(184, 16);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(129, 25);
      this.Label9.TabIndex = 39;
      this.Label9.Text = "Spare Key Charge";
      this.cboDGrace.BackColor = SystemColors.Window;
      this.cboDGrace.Cursor = Cursors.Default;
      this.cboDGrace.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboDGrace.ForeColor = SystemColors.WindowText;
      this.cboDGrace.Location = new Point(112, 77);
      this.cboDGrace.Name = "cboDGrace";
      this.cboDGrace.RightToLeft = RightToLeft.No;
      this.cboDGrace.Size = new Size(49, 22);
      this.cboDGrace.TabIndex = 17;
      this.cboDGrace.KeyPress += new KeyPressEventHandler(this.cboDGrace_KeyPress);
      this.cboDGrace.KeyDown += new KeyEventHandler(this.cboDGrace_KeyDown);
      this.Label8.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(16, 16);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(129, 25);
      this.Label8.TabIndex = 38;
      this.Label8.Text = "New Key Deposit";
      this.txtCommPort.BackColor = SystemColors.Window;
      this.txtCommPort.Cursor = Cursors.IBeam;
      this.txtCommPort.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCommPort.ForeColor = Color.Black;
      this.txtCommPort.Location = new Point(192, 120);
      this.txtCommPort.MaxLength = 0;
      this.txtCommPort.Name = "txtCommPort";
      this.txtCommPort.ReadOnly = true;
      this.txtCommPort.RightToLeft = RightToLeft.No;
      this.txtCommPort.Size = new Size(105, 20);
      this.txtCommPort.TabIndex = 36;
      this.cboWGrace.BackColor = SystemColors.Window;
      this.cboWGrace.Cursor = Cursors.Default;
      this.cboWGrace.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboWGrace.ForeColor = SystemColors.WindowText;
      this.cboWGrace.Location = new Point(112, 50);
      this.cboWGrace.Name = "cboWGrace";
      this.cboWGrace.RightToLeft = RightToLeft.No;
      this.cboWGrace.Size = new Size(49, 22);
      this.cboWGrace.TabIndex = 16;
      this.cboWGrace.KeyPress += new KeyPressEventHandler(this.cboWGrace_KeyPress);
      this.cboWGrace.KeyDown += new KeyEventHandler(this.cboWGrace_KeyDown);
      this.BonusFrame.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.BonusFrame.Controls.Add((Control) this.WFrame);
      this.BonusFrame.Controls.Add((Control) this.Label10);
      this.BonusFrame.Controls.Add((Control) this.Label13);
      this.BonusFrame.Controls.Add((Control) this.MFrame);
      this.BonusFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BonusFrame.ForeColor = SystemColors.ControlText;
      this.BonusFrame.Location = new Point(335, 145);
      this.BonusFrame.Name = "BonusFrame";
      this.BonusFrame.Padding = new Padding(0);
      this.BonusFrame.RightToLeft = RightToLeft.No;
      this.BonusFrame.Size = new Size(417, 257);
      this.BonusFrame.TabIndex = 35;
      this.BonusFrame.TabStop = false;
      this.BonusFrame.Visible = false;
      this.Label10.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.White;
      this.Label10.Location = new Point(216, 16);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(193, 21);
      this.Label10.TabIndex = 62;
      this.Label10.Text = "Weekly Bonus Implement Date ";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.Label13.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.White;
      this.Label13.Location = new Point(8, 16);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(185, 21);
      this.Label13.TabIndex = 47;
      this.Label13.Text = "Monthly Bonus Implement Date ";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.MFrame.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.MFrame.Controls.Add((Control) this.EntitleFrame);
      this.MFrame.Controls.Add((Control) this.txtTotalStay);
      this.MFrame.Controls.Add((Control) this.lblTotalStay);
      this.MFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MFrame.ForeColor = Color.Black;
      this.MFrame.Location = new Point(3, 72);
      this.MFrame.Name = "MFrame";
      this.MFrame.Padding = new Padding(0);
      this.MFrame.RightToLeft = RightToLeft.No;
      this.MFrame.Size = new Size(193, 177);
      this.MFrame.TabIndex = 51;
      this.MFrame.TabStop = false;
      this.MFrame.Text = "MONTHLY STAY :";
      this.EntitleFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.EntitleFrame.Controls.Add((Control) this.txtTotalBonus);
      this.EntitleFrame.Controls.Add((Control) this._optEntitle_2);
      this.EntitleFrame.Controls.Add((Control) this._optEntitle_1);
      this.EntitleFrame.Controls.Add((Control) this._optEntitle_0);
      this.EntitleFrame.Controls.Add((Control) this.lblTotalBonus);
      this.EntitleFrame.Controls.Add((Control) this.lblBonus);
      this.EntitleFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EntitleFrame.ForeColor = SystemColors.ControlText;
      this.EntitleFrame.Location = new Point(5, 48);
      this.EntitleFrame.Name = "EntitleFrame";
      this.EntitleFrame.Padding = new Padding(0);
      this.EntitleFrame.RightToLeft = RightToLeft.No;
      this.EntitleFrame.Size = new Size(177, 121);
      this.EntitleFrame.TabIndex = 51;
      this.EntitleFrame.TabStop = false;
      this.EntitleFrame.Text = "Entitle For";
      this.txtTotalBonus.AcceptsReturn = true;
      this.txtTotalBonus.BackColor = SystemColors.Window;
      this.txtTotalBonus.Cursor = Cursors.IBeam;
      this.txtTotalBonus.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalBonus.ForeColor = Color.Blue;
      this.txtTotalBonus.Location = new Point(96, 90);
      this.txtTotalBonus.MaxLength = 0;
      this.txtTotalBonus.Name = "txtTotalBonus";
      this.txtTotalBonus.RightToLeft = RightToLeft.No;
      this.txtTotalBonus.Size = new Size(49, 20);
      this.txtTotalBonus.TabIndex = 23;
      this.txtTotalBonus.TextAlign = HorizontalAlignment.Center;
      this._optEntitle_2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle_2.Cursor = Cursors.Default;
      this._optEntitle_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle_2.ForeColor = SystemColors.ControlText;
      this._optEntitle_2.Location = new Point(8, 88);
      this._optEntitle_2.Name = "_optEntitle_2";
      this._optEntitle_2.RightToLeft = RightToLeft.No;
      this._optEntitle_2.Size = new Size(57, 25);
      this._optEntitle_2.TabIndex = 22;
      this._optEntitle_2.TabStop = true;
      this._optEntitle_2.Text = "Month";
      this._optEntitle_2.UseVisualStyleBackColor = false;
      this._optEntitle_1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle_1.Cursor = Cursors.Default;
      this._optEntitle_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle_1.ForeColor = SystemColors.ControlText;
      this._optEntitle_1.Location = new Point(8, 56);
      this._optEntitle_1.Name = "_optEntitle_1";
      this._optEntitle_1.RightToLeft = RightToLeft.No;
      this._optEntitle_1.Size = new Size(57, 25);
      this._optEntitle_1.TabIndex = 21;
      this._optEntitle_1.TabStop = true;
      this._optEntitle_1.Text = "Week";
      this._optEntitle_1.UseVisualStyleBackColor = false;
      this._optEntitle_0.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optEntitle_0.Cursor = Cursors.Default;
      this._optEntitle_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._optEntitle_0.ForeColor = SystemColors.ControlText;
      this._optEntitle_0.Location = new Point(8, 24);
      this._optEntitle_0.Name = "_optEntitle_0";
      this._optEntitle_0.RightToLeft = RightToLeft.No;
      this._optEntitle_0.Size = new Size(57, 25);
      this._optEntitle_0.TabIndex = 20;
      this._optEntitle_0.TabStop = true;
      this._optEntitle_0.Text = "Day";
      this._optEntitle_0.UseVisualStyleBackColor = false;
      this.lblTotalBonus.BackColor = Color.FromArgb((int) byte.MaxValue, 192, (int) byte.MaxValue);
      this.lblTotalBonus.Cursor = Cursors.Default;
      this.lblTotalBonus.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalBonus.ForeColor = SystemColors.ControlText;
      this.lblTotalBonus.Location = new Point(88, 64);
      this.lblTotalBonus.Name = "lblTotalBonus";
      this.lblTotalBonus.RightToLeft = RightToLeft.No;
      this.lblTotalBonus.Size = new Size(65, 25);
      this.lblTotalBonus.TabIndex = 50;
      this.lblTotalBonus.TextAlign = ContentAlignment.TopCenter;
      this.lblBonus.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.lblBonus.Cursor = Cursors.Default;
      this.lblBonus.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBonus.ForeColor = Color.White;
      this.lblBonus.Location = new Point(72, 40);
      this.lblBonus.Name = "lblBonus";
      this.lblBonus.RightToLeft = RightToLeft.No;
      this.lblBonus.Size = new Size(97, 25);
      this.lblBonus.TabIndex = 49;
      this.lblBonus.Text = "Total Bonus";
      this.txtTotalStay.AcceptsReturn = true;
      this.txtTotalStay.BackColor = SystemColors.Window;
      this.txtTotalStay.Cursor = Cursors.IBeam;
      this.txtTotalStay.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalStay.ForeColor = Color.Blue;
      this.txtTotalStay.Location = new Point(104, 16);
      this.txtTotalStay.MaxLength = 0;
      this.txtTotalStay.Name = "txtTotalStay";
      this.txtTotalStay.RightToLeft = RightToLeft.No;
      this.txtTotalStay.Size = new Size(57, 20);
      this.txtTotalStay.TabIndex = 19;
      this.lblTotalStay.BackColor = Color.Blue;
      this.lblTotalStay.Cursor = Cursors.Default;
      this.lblTotalStay.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTotalStay.ForeColor = Color.White;
      this.lblTotalStay.Location = new Point(8, 16);
      this.lblTotalStay.Name = "lblTotalStay";
      this.lblTotalStay.RightToLeft = RightToLeft.No;
      this.lblTotalStay.Size = new Size(89, 25);
      this.lblTotalStay.TabIndex = 53;
      this.lblTotalStay.Text = "Total Stay";
      this.lblTotalStay.TextAlign = ContentAlignment.TopRight;
      this.dateTimePicker_mskBonusStart1.CalendarFont = new Font("Arial", 9.75f, FontStyle.Bold);
      this.dateTimePicker_mskBonusStart1.Checked = false;
      this.dateTimePicker_mskBonusStart1.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskBonusStart1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.dateTimePicker_mskBonusStart1.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskBonusStart1.Location = new Point(600, 182);
      this.dateTimePicker_mskBonusStart1.Name = "dateTimePicker_mskBonusStart1";
      this.dateTimePicker_mskBonusStart1.Size = new Size(98, 22);
      this.dateTimePicker_mskBonusStart1.TabIndex = 166;
      this.dateTimePicker_mskBonusStart.CalendarFont = new Font("Arial", 9.75f, FontStyle.Bold);
      this.dateTimePicker_mskBonusStart.Checked = false;
      this.dateTimePicker_mskBonusStart.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskBonusStart.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.dateTimePicker_mskBonusStart.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskBonusStart.Location = new Point(384, 182);
      this.dateTimePicker_mskBonusStart.Name = "dateTimePicker_mskBonusStart";
      this.dateTimePicker_mskBonusStart.Size = new Size(98, 22);
      this.dateTimePicker_mskBonusStart.TabIndex = 165;
      this.dateTimePicker_mskBonusStart.ValueChanged += new EventHandler(this.dateTimePicker_mskBonusStart_ValueChanged);
      this.cboMGrace.BackColor = SystemColors.Window;
      this.cboMGrace.Cursor = Cursors.Default;
      this.cboMGrace.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboMGrace.ForeColor = SystemColors.WindowText;
      this.cboMGrace.Location = new Point(112, 24);
      this.cboMGrace.Name = "cboMGrace";
      this.cboMGrace.RightToLeft = RightToLeft.No;
      this.cboMGrace.Size = new Size(49, 22);
      this.cboMGrace.TabIndex = 15;
      this.cboMGrace.KeyPress += new KeyPressEventHandler(this.cboMGrace_KeyPress);
      this.cboMGrace.KeyDown += new KeyEventHandler(this.cboMGrace_KeyDown);
      this.KeyCharges.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.KeyCharges.Controls.Add((Control) this.cmdSpareCharge);
      this.KeyCharges.Controls.Add((Control) this.txtSpareKeyCharge);
      this.KeyCharges.Controls.Add((Control) this.cmdKeyDeposit);
      this.KeyCharges.Controls.Add((Control) this.txtKeyDeposit);
      this.KeyCharges.Controls.Add((Control) this.Label9);
      this.KeyCharges.Controls.Add((Control) this.Label8);
      this.KeyCharges.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.KeyCharges.ForeColor = SystemColors.ControlText;
      this.KeyCharges.Location = new Point(16, 312);
      this.KeyCharges.Name = "KeyCharges";
      this.KeyCharges.Padding = new Padding(0);
      this.KeyCharges.RightToLeft = RightToLeft.No;
      this.KeyCharges.Size = new Size(329, 89);
      this.KeyCharges.TabIndex = 37;
      this.KeyCharges.TabStop = false;
      this.KeyCharges.Text = "Key Charges";
      this.Label11.BackColor = Color.Cyan;
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.Blue;
      this.Label11.Location = new Point(48, 48);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(131, 20);
      this.Label11.TabIndex = 64;
      this.Label11.Text = "BUILDING TYPE";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.Label7.BackColor = Color.Cyan;
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.Blue;
      this.Label7.Location = new Point(16, 240);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(161, 25);
      this.Label7.TabIndex = 46;
      this.Label7.Text = "STAFF ID";
      this.Label7.TextAlign = ContentAlignment.TopRight;
      this.Label6.BackColor = Color.Cyan;
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Blue;
      this.Label6.Location = new Point(16, 160);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(161, 25);
      this.Label6.TabIndex = 45;
      this.Label6.Text = "CHECK OUT TIME";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(9, 9);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(777, 41);
      this.Label5.TabIndex = 49;
      this.Label5.Text = "SYSTEM SETTING";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.Cyan;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Blue;
      this.Label4.Location = new Point(16, 80);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(161, 25);
      this.Label4.TabIndex = 44;
      this.Label4.Text = "SYSTEM DESCRIPTION";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.Cyan;
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(16, 200);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(161, 25);
      this.Label3.TabIndex = 43;
      this.Label3.Text = "SYSTEM ID";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.Cyan;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Blue;
      this.Label2.Location = new Point(16, 280);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(161, 25);
      this.Label2.TabIndex = 42;
      this.Label2.Text = "GST RATE";
      this.Label2.TextAlign = ContentAlignment.TopRight;
      this.Label1.BackColor = Color.Cyan;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(16, 120);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(161, 25);
      this.Label1.TabIndex = 41;
      this.Label1.Text = "COMMUNICATION PORT";
      this.Label1.TextAlign = ContentAlignment.TopRight;
      this.lblBuilding.BackColor = Color.Cyan;
      this.lblBuilding.Cursor = Cursors.Default;
      this.lblBuilding.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblBuilding.ForeColor = Color.Blue;
      this.lblBuilding.Location = new Point(40, 16);
      this.lblBuilding.Name = "lblBuilding";
      this.lblBuilding.RightToLeft = RightToLeft.No;
      this.lblBuilding.Size = new Size(137, 25);
      this.lblBuilding.TabIndex = 40;
      this.lblBuilding.Text = "BUILDING";
      this.lblBuilding.TextAlign = ContentAlignment.TopRight;
      this.GraceFrame.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.GraceFrame.Controls.Add((Control) this.cboDGrace);
      this.GraceFrame.Controls.Add((Control) this.cboWGrace);
      this.GraceFrame.Controls.Add((Control) this.cboMGrace);
      this.GraceFrame.Controls.Add((Control) this.Label15);
      this.GraceFrame.Controls.Add((Control) this.Label14);
      this.GraceFrame.Controls.Add((Control) this.Label12);
      this.GraceFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GraceFrame.ForeColor = Color.Red;
      this.GraceFrame.Location = new Point(568, 24);
      this.GraceFrame.Name = "GraceFrame";
      this.GraceFrame.Padding = new Padding(0);
      this.GraceFrame.RightToLeft = RightToLeft.No;
      this.GraceFrame.Size = new Size(201, 107);
      this.GraceFrame.TabIndex = 58;
      this.GraceFrame.TabStop = false;
      this.GraceFrame.Text = "Grace Period Default :";
      this.Label15.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.Blue;
      this.Label15.Location = new Point(40, 80);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(65, 17);
      this.Label15.TabIndex = 61;
      this.Label15.Text = "Daily ";
      this.Label14.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.Blue;
      this.Label14.Location = new Point(40, 52);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(65, 17);
      this.Label14.TabIndex = 60;
      this.Label14.Text = "Weekly";
      this.Label12.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.Blue;
      this.Label12.Location = new Point(40, 24);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(65, 17);
      this.Label12.TabIndex = 59;
      this.Label12.Text = "Monthly ";
      this.Frame1.BackColor = Color.Cyan;
      this.Frame1.Controls.Add((Control) this.dateTimePicker_mskBonusStart1);
      this.Frame1.Controls.Add((Control) this.txtCheckOutTime);
      this.Frame1.Controls.Add((Control) this.dateTimePicker_mskBonusStart);
      this.Frame1.Controls.Add((Control) this.dateTimePicker_mskBonusDisableDate);
      this.Frame1.Controls.Add((Control) this.txtCommPort);
      this.Frame1.Controls.Add((Control) this.cboBuildingType);
      this.Frame1.Controls.Add((Control) this.chkGrace);
      this.Frame1.Controls.Add((Control) this.GraceFrame);
      this.Frame1.Controls.Add((Control) this.KeyCharges);
      this.Frame1.Controls.Add((Control) this.chkGST);
      this.Frame1.Controls.Add((Control) this.CmdPrint);
      this.Frame1.Controls.Add((Control) this.txtSystemID);
      this.Frame1.Controls.Add((Control) this.txtStaffID);
      this.Frame1.Controls.Add((Control) this.cmdReturn);
      this.Frame1.Controls.Add((Control) this.txtSystemDescription);
      this.Frame1.Controls.Add((Control) this.cmdSet);
      this.Frame1.Controls.Add((Control) this.txtGSTRate);
      this.Frame1.Controls.Add((Control) this.cboBuildingNo);
      this.Frame1.Controls.Add((Control) this.BonusFrame);
      this.Frame1.Controls.Add((Control) this.chkBonus);
      this.Frame1.Controls.Add((Control) this.Label11);
      this.Frame1.Controls.Add((Control) this.Label7);
      this.Frame1.Controls.Add((Control) this.Label6);
      this.Frame1.Controls.Add((Control) this.Label4);
      this.Frame1.Controls.Add((Control) this.Label3);
      this.Frame1.Controls.Add((Control) this.Label2);
      this.Frame1.Controls.Add((Control) this.Label1);
      this.Frame1.Controls.Add((Control) this.lblBuilding);
      this.Frame1.Controls.Add((Control) this.cboCommPort);
      this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(9, 57);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(777, 473);
      this.Frame1.TabIndex = 50;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "SYSTEM SETTING :";
      this.dateTimePicker_mskBonusDisableDate.Checked = false;
      this.dateTimePicker_mskBonusDisableDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskBonusDisableDate.Enabled = false;
      this.dateTimePicker_mskBonusDisableDate.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.dateTimePicker_mskBonusDisableDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskBonusDisableDate.Location = new Point(439, 113);
      this.dateTimePicker_mskBonusDisableDate.Name = "dateTimePicker_mskBonusDisableDate";
      this.dateTimePicker_mskBonusDisableDate.Size = new Size(98, 22);
      this.dateTimePicker_mskBonusDisableDate.TabIndex = 167;
      this.dateTimePicker_mskBonusDisableDate.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(794, 549);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Frame1);
      this.Name = "Form_DescriptionDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_DescriptionDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_DescriptionDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_DescriptionDMS_FormClosing);
      this.EntitleFrame2.ResumeLayout(false);
      this.EntitleFrame2.PerformLayout();
      this.WFrame.ResumeLayout(false);
      this.WFrame.PerformLayout();
      this.BonusFrame.ResumeLayout(false);
      this.MFrame.ResumeLayout(false);
      this.MFrame.PerformLayout();
      this.EntitleFrame.ResumeLayout(false);
      this.EntitleFrame.PerformLayout();
      this.KeyCharges.ResumeLayout(false);
      this.KeyCharges.PerformLayout();
      this.GraceFrame.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_DescriptionDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
    }

    private void Form_DescriptionDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void ClearBonus()
    {
      this.txtTotalStay.Text = "";
      this._optEntitle_0.Checked = false;
      this._optEntitle_1.Checked = false;
      this._optEntitle_2.Checked = false;
      this.txtTotalBonus.Text = "";
      this.txtTotalStay1.Text = "";
      this._optEntitle1_0.Checked = false;
      this._optEntitle1_1.Checked = false;
      this._optEntitle1_2.Checked = false;
      this.txtTotalBonus1.Text = "";
    }

    public void Get_Setting(string para_Building_No)
    {
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.systemSet1TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet1);
          if (this.db.system_DB.systemDataSet.SystemSet1.Rows.Count <= 0)
            break;
          IEnumerator enumerator1 = this.db.system_DB.systemDataSet.SystemSet1.Rows.GetEnumerator();
          try
          {
            if (!enumerator1.MoveNext())
              break;
            SystemDataSet.SystemSet1Row current = (SystemDataSet.SystemSet1Row) enumerator1.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.db.system_DB.systemSet2TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet2);
          if (this.db.system_DB.systemDataSet.SystemSet2.Rows.Count <= 0)
            break;
          IEnumerator enumerator2 = this.db.system_DB.systemDataSet.SystemSet2.Rows.GetEnumerator();
          try
          {
            if (!enumerator2.MoveNext())
              break;
            SystemDataSet.SystemSet2Row current = (SystemDataSet.SystemSet2Row) enumerator2.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.db.system_DB.systemSet3TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet3);
          if (this.db.system_DB.systemDataSet.SystemSet3.Rows.Count <= 0)
            break;
          IEnumerator enumerator3 = this.db.system_DB.systemDataSet.SystemSet3.Rows.GetEnumerator();
          try
          {
            if (!enumerator3.MoveNext())
              break;
            SystemDataSet.SystemSet3Row current = (SystemDataSet.SystemSet3Row) enumerator3.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.db.system_DB.systemSet4TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet4);
          if (this.db.system_DB.systemDataSet.SystemSet4.Rows.Count <= 0)
            break;
          IEnumerator enumerator4 = this.db.system_DB.systemDataSet.SystemSet4.Rows.GetEnumerator();
          try
          {
            if (!enumerator4.MoveNext())
              break;
            SystemDataSet.SystemSet4Row current = (SystemDataSet.SystemSet4Row) enumerator4.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.db.system_DB.systemSet5TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet5);
          if (this.db.system_DB.systemDataSet.SystemSet5.Rows.Count <= 0)
            break;
          IEnumerator enumerator5 = this.db.system_DB.systemDataSet.SystemSet5.Rows.GetEnumerator();
          try
          {
            if (!enumerator5.MoveNext())
              break;
            SystemDataSet.SystemSet5Row current = (SystemDataSet.SystemSet5Row) enumerator5.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.db.system_DB.systemSet6TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet6);
          if (this.db.system_DB.systemDataSet.SystemSet6.Rows.Count <= 0)
            break;
          IEnumerator enumerator6 = this.db.system_DB.systemDataSet.SystemSet6.Rows.GetEnumerator();
          try
          {
            if (!enumerator6.MoveNext())
              break;
            SystemDataSet.SystemSet6Row current = (SystemDataSet.SystemSet6Row) enumerator6.Current;
            this.txtSystemID.Text = current.SystemID.ToString();
            if (current.Description != "")
              this.txtSystemDescription.Text = current.Description;
            try
            {
              if (current.BuildingType != null)
                this.cboBuildingType.Text = current.BuildingType;
              else
                this.cboBuildingType.Text = "";
            }
            catch
            {
              this.cboBuildingType.Text = "";
            }
            this.cboCommPort.Text = "COM" + current.Comport.ToString();
            this.txtCommPort.Text = "COM" + current.Comport.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST = current.GSTRate.ToString("F2");
            this.txtGSTRate.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGST;
            this.txtCheckOutTime.Text = current.CheckOutTime;
            this.chkBonus.Checked = current.Bonus;
            this.cboMGrace.Text = current.MGraceDefault.ToString();
            this.cboWGrace.Text = current.WGraceDefault.ToString();
            this.cboDGrace.Text = current.DGraceDefault.ToString();
            try
            {
              this.txtStaffID.Text = current.StaffID;
              break;
            }
            catch
            {
              this.txtStaffID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              break;
            }
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
    }

    private void CheckSystemSetting()
    {
      this.ClearBonus();
      this.Get_Setting((string) this.cboBuildingNo.SelectedItem);
      if (this.chkBonus.Checked)
      {
        this.BonusFrame.Visible = true;
        this.dateTimePicker_mskBonusDisableDate.Visible = false;
        this.dateTimePicker_mskBonusStart.Visible = true;
        this.dateTimePicker_mskBonusStart1.Visible = true;
        this.GetBonusData(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo);
      }
      else
      {
        this.BonusFrame.Visible = false;
        this.GetBonusDisableDate(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo);
        this.dateTimePicker_mskBonusStart.Visible = false;
        this.dateTimePicker_mskBonusStart1.Visible = false;
      }
      this.Get_KeyCharges((string) this.cboBuildingNo.SelectedItem);
    }

    private void Get_KeyCharges(string para_BuildingNo)
    {
      this.db.building_DB1.keyChargesTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.KeyCharges);
      foreach (BuildingDB1DataSet.KeyChargesRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.KeyCharges.Rows)
      {
        if (row.BuildingNo == para_BuildingNo)
        {
          this.txtKeyDeposit.Text = row.KeyDeposit.ToString("F2");
          this.txtSpareKeyCharge.Text = row.SpareKeyCharge.ToString("F2");
          break;
        }
        this.txtKeyDeposit.Text = "0.00";
        this.txtSpareKeyCharge.Text = "0.00";
      }
    }

    private void GetBonusData(string para_Building_No)
    {
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.bonus1TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus1);
          foreach (SystemDataSet.Bonus1Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus1.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator1 = this.db.system_DB.systemDataSet.Bonus1.Rows.GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
            {
              SystemDataSet.Bonus1Row current = (SystemDataSet.Bonus1Row) enumerator1.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.db.system_DB.bonus2TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus2);
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator2 = this.db.system_DB.systemDataSet.Bonus2.Rows.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              SystemDataSet.Bonus2Row current = (SystemDataSet.Bonus2Row) enumerator2.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.db.system_DB.bonus3TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus3);
          foreach (SystemDataSet.Bonus3Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus3.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator3 = this.db.system_DB.systemDataSet.Bonus3.Rows.GetEnumerator();
          try
          {
            while (enumerator3.MoveNext())
            {
              SystemDataSet.Bonus3Row current = (SystemDataSet.Bonus3Row) enumerator3.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.db.system_DB.bonus4TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus4);
          foreach (SystemDataSet.Bonus4Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus4.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator4 = this.db.system_DB.systemDataSet.Bonus4.Rows.GetEnumerator();
          try
          {
            while (enumerator4.MoveNext())
            {
              SystemDataSet.Bonus4Row current = (SystemDataSet.Bonus4Row) enumerator4.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.db.system_DB.bonus5TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus5);
          foreach (SystemDataSet.Bonus5Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus5.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator5 = this.db.system_DB.systemDataSet.Bonus5.Rows.GetEnumerator();
          try
          {
            while (enumerator5.MoveNext())
            {
              SystemDataSet.Bonus5Row current = (SystemDataSet.Bonus5Row) enumerator5.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.db.system_DB.bonus6TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus6);
          foreach (SystemDataSet.Bonus6Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus6.Rows)
          {
            if (row.StayType == "M")
            {
              this.txtTotalStay.Text = row.StayLength.ToString();
              try
              {
                if (row.BonusType == "D")
                  this._optEntitle_0.Checked = true;
                else if (row.BonusType == "W")
                  this._optEntitle_1.Checked = true;
                else if (row.BonusType == "M")
                  this._optEntitle_2.Checked = true;
                else if (row.BonusType == "")
                {
                  this._optEntitle_0.Checked = false;
                  this._optEntitle_1.Checked = false;
                  this._optEntitle_2.Checked = false;
                }
              }
              catch
              {
                this._optEntitle_0.Checked = true;
                this._optEntitle_1.Checked = false;
                this._optEntitle_2.Checked = false;
              }
              this.txtTotalBonus.Text = row.BonusLength.ToString();
              try
              {
                if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Days";
                else if (row.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Day";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Weeks";
                else if (row.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                  this.lblTotalBonus.Text = "Week";
                else if (row.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus.Text) > 1M)
                  this.lblTotalBonus.Text = "Months";
                else if (row.BonusType == "M")
                {
                  if (Convert.ToDecimal(this.txtTotalBonus.Text) == 1M)
                    this.lblTotalBonus.Text = "Month";
                }
              }
              catch
              {
                this.lblTotalBonus.Text = "Days";
              }
              try
              {
                if (row.BonusStart != null)
                {
                  this.dateTimePicker_mskBonusStart.Text = row.BonusStart;
                  this.dateTimePicker_mskBonusStart.Value = DateTime.Parse(row.BonusStart);
                  break;
                }
                this.dateTimePicker_mskBonusStart.Text = "____-__-__";
                break;
              }
              catch
              {
                break;
              }
            }
          }
          IEnumerator enumerator6 = this.db.system_DB.systemDataSet.Bonus6.Rows.GetEnumerator();
          try
          {
            while (enumerator6.MoveNext())
            {
              SystemDataSet.Bonus6Row current = (SystemDataSet.Bonus6Row) enumerator6.Current;
              if (current.StayType == "W")
              {
                this.txtTotalStay1.Text = current.StayLength.ToString();
                try
                {
                  if (current.BonusType == "D")
                    this._optEntitle1_0.Checked = true;
                  else if (current.BonusType == "W")
                    this._optEntitle1_1.Checked = true;
                  else if (current.BonusType == "M")
                    this._optEntitle1_2.Checked = true;
                  else if (current.BonusType == "")
                  {
                    this._optEntitle1_0.Checked = false;
                    this._optEntitle1_1.Checked = false;
                    this._optEntitle1_2.Checked = false;
                  }
                }
                catch
                {
                  this._optEntitle1_0.Checked = true;
                  this._optEntitle1_1.Checked = false;
                  this._optEntitle1_2.Checked = false;
                }
                this.txtTotalBonus1.Text = current.BonusLength.ToString();
                try
                {
                  if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Days";
                  else if (current.BonusType == "D" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Day";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Weeks";
                  else if (current.BonusType == "W" && Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                    this.lblTotalBonus1.Text = "Week";
                  else if (current.BonusType == "M" && Convert.ToDecimal(this.txtTotalBonus1.Text) > 1M)
                    this.lblTotalBonus1.Text = "Months";
                  else if (current.BonusType == "M")
                  {
                    if (Convert.ToDecimal(this.txtTotalBonus1.Text) == 1M)
                      this.lblTotalBonus1.Text = "Month";
                  }
                }
                catch
                {
                  this.lblTotalBonus1.Text = "Days";
                }
                try
                {
                  if (current.BonusStart != null)
                  {
                    this.dateTimePicker_mskBonusStart1.Text = current.BonusStart;
                    this.dateTimePicker_mskBonusStart1.Value = DateTime.Parse(current.BonusStart);
                    break;
                  }
                  this.dateTimePicker_mskBonusStart1.Text = "____-__-__";
                  break;
                }
                catch
                {
                  break;
                }
              }
            }
            break;
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      this.BonusFrame.Invalidate();
      this.BonusFrame.Refresh();
    }

    private void GetBonusDisableDate(string para_Building_No)
    {
      bool flag = false;
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.bonus1TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus1);
          foreach (SystemDataSet.Bonus1Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus1.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        case "2":
          this.db.system_DB.bonus2TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus2);
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        case "3":
          this.db.system_DB.bonus3TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus3);
          foreach (SystemDataSet.Bonus3Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus3.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        case "4":
          this.db.system_DB.bonus4TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus4);
          foreach (SystemDataSet.Bonus4Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus4.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        case "5":
          this.db.system_DB.bonus5TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus5);
          foreach (SystemDataSet.Bonus5Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus5.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        case "6":
          this.db.system_DB.bonus6TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus6);
          foreach (SystemDataSet.Bonus6Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus6.Rows)
          {
            if (row.StayType == "X")
            {
              this.dateTimePicker_mskBonusDisableDate.Text = row.BonusStart;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case 3-6");
          break;
      }
    }

    private void chkBonus_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkBonus.Checked)
      {
        this.dateTimePicker_mskBonusDisableDate.Visible = false;
        this.GetBonusData(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo);
        this.BonusFrame.Visible = true;
        this.dateTimePicker_mskBonusStart.Visible = true;
        this.dateTimePicker_mskBonusStart1.Visible = true;
      }
      else
      {
        this.GetBonusDisableDate(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo);
        this.BonusFrame.Visible = false;
        this.dateTimePicker_mskBonusStart.Visible = false;
        this.dateTimePicker_mskBonusStart1.Visible = false;
        this.dateTimePicker_mskBonusDisableDate.Visible = true;
      }
    }

    private void CheckBuilding()
    {
      bool flag = false;
      DB db = new DB();
      db.system_DB.buildingTableAdapter.Fill(db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) db.system_DB.systemDataSet.Building.Rows)
      {
        this.cboBuildingNo.Items.Add((object) row.BuildingNo);
        flag = true;
      }
      if (!flag)
      {
        int num = (int) MessageBox.Show("Need to Configure System Setting by Owner...");
        Application.Exit();
      }
      else
        this.cboBuildingNo.SelectedIndex = 0;
    }

    private void Form_DescriptionDMS_Load(object sender, EventArgs e)
    {
      this.cboCommPort.Items.Add((object) Global_Data.COM_NUM.ToString());
      this.cboCommPort.SelectedIndex = 0;
      this.txtCommPort.Text = Global_Data.COM_NUM.ToString();
      this.chkBonus.Checked = false;
      this.chkGST.Checked = false;
      this.CheckBuilding();
      this.cboBuildingType.Items.Add((object) "Normal");
      this.cboBuildingType.SelectedIndex = 0;
      this.cboMGrace.Items.Add((object) "0");
      this.cboMGrace.Items.Add((object) "1");
      this.cboMGrace.Items.Add((object) "2");
      this.cboMGrace.Items.Add((object) "3");
      this.cboMGrace.Items.Add((object) "4");
      this.cboMGrace.Items.Add((object) "5");
      this.cboMGrace.Items.Add((object) "6");
      this.cboMGrace.Items.Add((object) "7");
      this.cboMGrace.Items.Add((object) "8");
      this.cboMGrace.Items.Add((object) "9");
      this.cboMGrace.Items.Add((object) "10");
      this.cboMGrace.Items.Add((object) "11");
      this.cboMGrace.Items.Add((object) "12");
      this.cboMGrace.Items.Add((object) "13");
      this.cboMGrace.Items.Add((object) "14");
      this.cboWGrace.Items.Add((object) "0");
      this.cboWGrace.Items.Add((object) "1");
      this.cboWGrace.Items.Add((object) "2");
      this.cboWGrace.Items.Add((object) "3");
      this.cboWGrace.Items.Add((object) "4");
      this.cboWGrace.Items.Add((object) "5");
      this.cboWGrace.Items.Add((object) "6");
      this.cboWGrace.Items.Add((object) "7");
      this.cboWGrace.Items.Add((object) "8");
      this.cboWGrace.Items.Add((object) "9");
      this.cboWGrace.Items.Add((object) "10");
      this.cboWGrace.Items.Add((object) "11");
      this.cboWGrace.Items.Add((object) "12");
      this.cboWGrace.Items.Add((object) "13");
      this.cboWGrace.Items.Add((object) "14");
      this.cboWGrace.SelectedIndex = 1;
      this.cboDGrace.Items.Add((object) "0");
      this.cboDGrace.Items.Add((object) "1");
      this.cboDGrace.Items.Add((object) "2");
      this.cboDGrace.Items.Add((object) "3");
      this.cboDGrace.Items.Add((object) "4");
      this.cboDGrace.Items.Add((object) "5");
      this.cboDGrace.Items.Add((object) "6");
      this.cboDGrace.Items.Add((object) "7");
      this.cboDGrace.Items.Add((object) "8");
      this.cboDGrace.Items.Add((object) "9");
      this.cboDGrace.Items.Add((object) "10");
      this.cboDGrace.Items.Add((object) "11");
      this.cboDGrace.Items.Add((object) "12");
      this.cboDGrace.Items.Add((object) "13");
      this.cboDGrace.Items.Add((object) "14");
      this.CheckSystemSetting();
    }

    private bool RC_SystemSet_Update(string para_gUserID, string para_Building_No)
    {
      bool flag1 = false;
      bool flag2 = false;
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.systemSet1TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet1);
          IEnumerator enumerator1 = this.db.system_DB.systemDataSet.SystemSet1.Rows.GetEnumerator();
          try
          {
            if (enumerator1.MoveNext())
            {
              SystemDataSet.SystemSet1Row current = (SystemDataSet.SystemSet1Row) enumerator1.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet1TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet1) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet1Row row = this.db.system_DB.systemDataSet.SystemSet1.NewSystemSet1Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet1.AddSystemSet1Row(row);
            if (this.db.system_DB.systemSet1TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet1) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        case "2":
          this.db.system_DB.systemSet2TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet2);
          IEnumerator enumerator2 = this.db.system_DB.systemDataSet.SystemSet2.Rows.GetEnumerator();
          try
          {
            if (enumerator2.MoveNext())
            {
              SystemDataSet.SystemSet2Row current = (SystemDataSet.SystemSet2Row) enumerator2.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet2TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet2) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet2Row row = this.db.system_DB.systemDataSet.SystemSet2.NewSystemSet2Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet2.AddSystemSet2Row(row);
            if (this.db.system_DB.systemSet2TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet2) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        case "3":
          this.db.system_DB.systemSet3TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet3);
          IEnumerator enumerator3 = this.db.system_DB.systemDataSet.SystemSet3.Rows.GetEnumerator();
          try
          {
            if (enumerator3.MoveNext())
            {
              SystemDataSet.SystemSet3Row current = (SystemDataSet.SystemSet3Row) enumerator3.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet3TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet3) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet3Row row = this.db.system_DB.systemDataSet.SystemSet3.NewSystemSet3Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet3.AddSystemSet3Row(row);
            if (this.db.system_DB.systemSet3TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet3) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        case "4":
          this.db.system_DB.systemSet4TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet4);
          IEnumerator enumerator4 = this.db.system_DB.systemDataSet.SystemSet4.Rows.GetEnumerator();
          try
          {
            if (enumerator4.MoveNext())
            {
              SystemDataSet.SystemSet4Row current = (SystemDataSet.SystemSet4Row) enumerator4.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet4TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet4) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet4Row row = this.db.system_DB.systemDataSet.SystemSet4.NewSystemSet4Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet4.AddSystemSet4Row(row);
            if (this.db.system_DB.systemSet4TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet4) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        case "5":
          this.db.system_DB.systemSet5TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet5);
          IEnumerator enumerator5 = this.db.system_DB.systemDataSet.SystemSet5.Rows.GetEnumerator();
          try
          {
            if (enumerator5.MoveNext())
            {
              SystemDataSet.SystemSet5Row current = (SystemDataSet.SystemSet5Row) enumerator5.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet5TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet5) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet5Row row = this.db.system_DB.systemDataSet.SystemSet5.NewSystemSet5Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet5.AddSystemSet5Row(row);
            if (this.db.system_DB.systemSet5TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet5) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        case "6":
          this.db.system_DB.systemSet6TableAdapter.Fill(this.db.system_DB.systemDataSet.SystemSet6);
          IEnumerator enumerator6 = this.db.system_DB.systemDataSet.SystemSet6.Rows.GetEnumerator();
          try
          {
            if (enumerator6.MoveNext())
            {
              SystemDataSet.SystemSet6Row current = (SystemDataSet.SystemSet6Row) enumerator6.Current;
              current.Description = this.txtSystemDescription.Text;
              current.BuildingType = this.cboBuildingType.Text;
              if (this.chkGST.Checked)
                current.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
              current.CheckOutTime = this.txtCheckOutTime.Text;
              current.SystemID = Convert.ToInt16(this.txtSystemID.Text);
              current.Bonus = this.chkBonus.Checked;
              if (this.chkGrace.Checked)
              {
                current.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
                current.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
                current.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
              }
              current.StaffID = para_gUserID;
              current.Update = false;
              if (this.db.system_DB.systemSet6TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet6) > 0)
                flag2 = true;
              flag1 = true;
            }
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
          if (!flag1)
          {
            SystemDataSet.SystemSet6Row row = this.db.system_DB.systemDataSet.SystemSet6.NewSystemSet6Row();
            row.Description = this.txtSystemDescription.Text;
            row.BuildingType = this.cboBuildingType.Text;
            row.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
            row.CheckOutTime = this.txtCheckOutTime.Text;
            row.SystemID = Convert.ToInt16(this.txtSystemID.Text);
            row.Bonus = this.chkBonus.Checked;
            if (this.chkGrace.Checked)
            {
              row.MGraceDefault = Convert.ToInt32(this.cboMGrace.Text);
              row.WGraceDefault = Convert.ToInt32(this.cboWGrace.Text);
              row.DGraceDefault = Convert.ToInt32(this.cboDGrace.Text);
            }
            row.StaffID = para_gUserID;
            row.Update = false;
            this.db.system_DB.systemDataSet.SystemSet6.AddSystemSet6Row(row);
            if (this.db.system_DB.systemSet6TableAdapter.Update(this.db.system_DB.systemDataSet.SystemSet6) > 0)
            {
              flag2 = true;
              break;
            }
            break;
          }
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      return flag2;
    }

    private bool RC_GSTHISTORY_Update(string para_Building_No)
    {
      bool flag = false;
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.gSTHistory1TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory1);
          SystemDataSet.GSTHistory1Row row1 = this.db.system_DB.systemDataSet.GSTHistory1.NewGSTHistory1Row();
          row1.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row1.UpdateDate = DateTime.Now.Date;
          row1.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory1.AddGSTHistory1Row(row1);
          if (this.db.system_DB.gSTHistory1TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory1) > 0)
          {
            flag = true;
            break;
          }
          break;
        case "2":
          this.db.system_DB.gSTHistory2TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory2);
          SystemDataSet.GSTHistory2Row row2 = this.db.system_DB.systemDataSet.GSTHistory2.NewGSTHistory2Row();
          row2.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row2.UpdateDate = DateTime.Now.Date;
          row2.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory2.AddGSTHistory2Row(row2);
          if (this.db.system_DB.gSTHistory2TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory2) > 0)
          {
            flag = true;
            break;
          }
          break;
        case "3":
          this.db.system_DB.gSTHistory3TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory3);
          SystemDataSet.GSTHistory3Row row3 = this.db.system_DB.systemDataSet.GSTHistory3.NewGSTHistory3Row();
          row3.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row3.UpdateDate = DateTime.Now.Date;
          row3.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory3.AddGSTHistory3Row(row3);
          if (this.db.system_DB.gSTHistory3TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory3) > 0)
          {
            flag = true;
            break;
          }
          break;
        case "4":
          this.db.system_DB.gSTHistory4TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory4);
          SystemDataSet.GSTHistory4Row row4 = this.db.system_DB.systemDataSet.GSTHistory4.NewGSTHistory4Row();
          row4.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row4.UpdateDate = DateTime.Now.Date;
          row4.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory4.AddGSTHistory4Row(row4);
          if (this.db.system_DB.gSTHistory4TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory4) > 0)
          {
            flag = true;
            break;
          }
          break;
        case "5":
          this.db.system_DB.gSTHistory5TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory5);
          SystemDataSet.GSTHistory5Row row5 = this.db.system_DB.systemDataSet.GSTHistory5.NewGSTHistory5Row();
          row5.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row5.UpdateDate = DateTime.Now.Date;
          row5.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory5.AddGSTHistory5Row(row5);
          if (this.db.system_DB.gSTHistory5TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory5) > 0)
          {
            flag = true;
            break;
          }
          break;
        case "6":
          this.db.system_DB.gSTHistory6TableAdapter.Fill(this.db.system_DB.systemDataSet.GSTHistory6);
          SystemDataSet.GSTHistory6Row row6 = this.db.system_DB.systemDataSet.GSTHistory6.NewGSTHistory6Row();
          row6.GSTRate = Convert.ToDouble(this.txtGSTRate.Text);
          row6.UpdateDate = DateTime.Now.Date;
          row6.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          this.db.system_DB.systemDataSet.GSTHistory6.AddGSTHistory6Row(row6);
          if (this.db.system_DB.gSTHistory6TableAdapter.Update(this.db.system_DB.systemDataSet.GSTHistory6) > 0)
          {
            flag = true;
            break;
          }
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      return flag;
    }

    private bool UpdateBonusDisableDate(string para_Building_No)
    {
      bool flag1 = false;
      bool flag2 = false;
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.bonus1TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus1);
          foreach (SystemDataSet.Bonus1Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus1.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus1Row bonus1Row = this.db.system_DB.systemDataSet.Bonus1.NewBonus1Row();
            bonus1Row.StayType = "X";
            bonus1Row.StayLength = (short) 0;
            bonus1Row.BonusLength = (short) 0;
            bonus1Row.BonusType = "X";
            bonus1Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus1Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus1Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus1TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus1) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        case "2":
          this.db.system_DB.bonus2TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus2);
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus2Row bonus2Row = this.db.system_DB.systemDataSet.Bonus2.NewBonus2Row();
            bonus2Row.StayType = "X";
            bonus2Row.StayLength = (short) 0;
            bonus2Row.BonusLength = (short) 0;
            bonus2Row.BonusType = "X";
            bonus2Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus2Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus2Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus2TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus2) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        case "3":
          this.db.system_DB.bonus3TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus3);
          foreach (SystemDataSet.Bonus3Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus3.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus3Row bonus3Row = this.db.system_DB.systemDataSet.Bonus3.NewBonus3Row();
            bonus3Row.StayType = "X";
            bonus3Row.StayLength = (short) 0;
            bonus3Row.BonusLength = (short) 0;
            bonus3Row.BonusType = "X";
            bonus3Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus3Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus3Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus3TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus3) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        case "4":
          this.db.system_DB.bonus4TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus4);
          foreach (SystemDataSet.Bonus4Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus4.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus4Row bonus4Row = this.db.system_DB.systemDataSet.Bonus4.NewBonus4Row();
            bonus4Row.StayType = "X";
            bonus4Row.StayLength = (short) 0;
            bonus4Row.BonusLength = (short) 0;
            bonus4Row.BonusType = "X";
            bonus4Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus4Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus4Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus4TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus4) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        case "5":
          this.db.system_DB.bonus5TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus5);
          foreach (SystemDataSet.Bonus5Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus5.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus5Row bonus5Row = this.db.system_DB.systemDataSet.Bonus5.NewBonus5Row();
            bonus5Row.StayType = "X";
            bonus5Row.StayLength = (short) 0;
            bonus5Row.BonusLength = (short) 0;
            bonus5Row.BonusType = "X";
            bonus5Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus5Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus5Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus5TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus5) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        case "6":
          this.db.system_DB.bonus6TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus6);
          foreach (SystemDataSet.Bonus6Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus6.Rows)
          {
            if (row.StayType == "X")
            {
              row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
              flag1 = true;
            }
          }
          if (!flag1)
          {
            SystemDataSet.Bonus6Row bonus6Row = this.db.system_DB.systemDataSet.Bonus6.NewBonus6Row();
            bonus6Row.StayType = "X";
            bonus6Row.StayLength = (short) 0;
            bonus6Row.BonusLength = (short) 0;
            bonus6Row.BonusType = "X";
            bonus6Row.BonusStart = this.dateTimePicker_mskBonusDisableDate.Value.ToShortDateString();
            bonus6Row.DateUpdate = DateTime.Now.ToShortDateString();
            bonus6Row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          }
          if (this.db.system_DB.bonus6TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus6) > 0)
          {
            flag2 = true;
            break;
          }
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      return flag2;
    }

    private bool RC_BONUS_Update(string para_Building_No)
    {
      bool flag = false;
      switch (para_Building_No)
      {
        case "1":
          this.db.system_DB.bonus1TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus1);
          foreach (SystemDataSet.Bonus1Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus1.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus1Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus1.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus1TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus1) > 1)
          {
            flag = true;
            break;
          }
          break;
        case "2":
          this.db.system_DB.bonus2TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus2);
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus2TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus2) > 1)
          {
            flag = true;
            break;
          }
          break;
        case "3":
          this.db.system_DB.bonus3TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus3);
          foreach (SystemDataSet.Bonus3Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus3.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus3Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus3.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus3TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus3) > 1)
          {
            flag = true;
            break;
          }
          break;
        case "4":
          this.db.system_DB.bonus4TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus4);
          foreach (SystemDataSet.Bonus4Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus4.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus4Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus4.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus4TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus4) > 1)
          {
            flag = true;
            break;
          }
          break;
        case "5":
          this.db.system_DB.bonus5TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus5);
          foreach (SystemDataSet.Bonus5Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus5.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus5Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus5.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus5TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus5) > 1)
          {
            flag = true;
            break;
          }
          break;
        case "6":
          this.db.system_DB.bonus6TableAdapter.Fill(this.db.system_DB.systemDataSet.Bonus6);
          foreach (SystemDataSet.Bonus6Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus6.Rows)
          {
            if (row.StayType == "M")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay.Text != "" || this.txtTotalStay.Text == "0" ? Convert.ToInt16(this.txtTotalStay.Text) : (short) 0;
              row.BonusType = !this._optEntitle_0.Checked ? (!this._optEntitle_1.Checked ? (!this._optEntitle_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus.Text != "" || this.txtTotalBonus.Text == "0" ? Convert.ToInt16(this.txtTotalBonus.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          foreach (SystemDataSet.Bonus2Row row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Bonus2.Rows)
          {
            if (row.StayType == "W")
            {
              row.BonusStart = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
              row.StayLength = this.txtTotalStay1.Text != "" || this.txtTotalStay1.Text == "0" ? Convert.ToInt16(this.txtTotalStay1.Text) : (short) 0;
              row.BonusType = !this._optEntitle1_0.Checked ? (!this._optEntitle1_1.Checked ? (!this._optEntitle1_2.Checked ? "" : "M") : "W") : "D";
              row.BonusLength = this.txtTotalBonus1.Text != "" || this.txtTotalBonus1.Text == "0" ? Convert.ToInt16(this.txtTotalBonus1.Text) : (short) 0;
              row.Staff = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.DateUpdate = DateTime.Now.ToShortDateString();
            }
          }
          if (this.db.system_DB.bonus6TableAdapter.Update(this.db.system_DB.systemDataSet.Bonus6) > 1)
          {
            flag = true;
            break;
          }
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      return flag;
    }

    private void cmdSet_Click(object sender, EventArgs e)
    {
      this.sSystemID = this.txtSystemID.Text;
      if (!this.RC_SystemSet_Update(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID, (string) this.cboBuildingNo.SelectedItem))
      {
        int num1 = (int) MessageBox.Show(" Can't Update System Setting!");
      }
      else if (this.chkGST.Checked && !this.RC_GSTHISTORY_Update(this.cboBuildingNo.Text))
      {
        int num2 = (int) MessageBox.Show(" Can't Update GST History!");
      }
      else
      {
        if (!this.chkBonus.Checked)
        {
          this.txtTotalStay.Text = "";
          this._optEntitle_0.Checked = false;
          this._optEntitle_1.Checked = false;
          this._optEntitle_2.Checked = false;
          this.txtTotalBonus.Text = "";
          this.txtTotalStay1.Text = "";
          this._optEntitle1_0.Checked = false;
          this._optEntitle1_1.Checked = false;
          this._optEntitle1_1.Checked = false;
          this.txtTotalBonus1.Text = "";
          this.UpdateBonusDisableDate(this.cboBuildingNo.Text);
        }
        else if (!this.RC_BONUS_Update(this.cboBuildingNo.Text))
        {
          int num3 = (int) MessageBox.Show(" Can't Update Bonus");
          return;
        }
        this.CheckSystemSetting();
        int num4 = (int) MessageBox.Show("New Setting Successful!");
        this.chkGST.Checked = false;
      }
    }

    private void cmdKeyDeposit_Click(object sender, EventArgs e)
    {
      bool flag1 = false;
      if (MessageBox.Show("Please comfirm Yes/No ?\n\r Update Key Deposit ? ", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      bool flag2 = false;
      this.db.building_DB1.keyChargesTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.KeyCharges);
      foreach (BuildingDB1DataSet.KeyChargesRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.KeyCharges.Rows)
      {
        if (row.BuildingNo == this.cboBuildingNo.Text)
        {
          row.KeyDeposit = Convert.ToDecimal(this.txtKeyDeposit.Text);
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag2 = true;
          break;
        }
      }
      if (!flag2)
      {
        BuildingDB1DataSet.KeyChargesRow row = this.db.building_DB1.buildingDB1DataSet.KeyCharges.NewKeyChargesRow();
        row.BuildingNo = this.cboBuildingNo.Text;
        row.KeyDeposit = Convert.ToDecimal(this.txtKeyDeposit.Text);
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        row.Update = false;
        this.db.building_DB1.buildingDB1DataSet.KeyCharges.AddKeyChargesRow(row);
      }
      if (this.db.building_DB1.keyChargesTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.KeyCharges) > 0)
        flag1 = true;
      if (!flag1)
      {
        int num1 = (int) MessageBox.Show("Cannot Update Settings!");
      }
      else
      {
        int num2 = (int) MessageBox.Show("New Setting Successful!");
      }
    }

    private void cmdSpareCharge_Click(object sender, EventArgs e)
    {
      bool flag1 = false;
      if (MessageBox.Show("Please comfirm Yes/No ?\n\r Update Spare Key Charge ? ", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      bool flag2 = false;
      this.db.building_DB1.keyChargesTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.KeyCharges);
      foreach (BuildingDB1DataSet.KeyChargesRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.KeyCharges.Rows)
      {
        if (row.BuildingNo == this.cboBuildingNo.Text)
        {
          row.SpareKeyCharge = Convert.ToDecimal(this.txtSpareKeyCharge.Text);
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag2 = true;
          break;
        }
      }
      if (!flag2)
      {
        BuildingDB1DataSet.KeyChargesRow row = this.db.building_DB1.buildingDB1DataSet.KeyCharges.NewKeyChargesRow();
        row.BuildingNo = this.cboBuildingNo.Text;
        row.SpareKeyCharge = Convert.ToDecimal(this.txtSpareKeyCharge.Text);
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        row.Update = false;
        this.db.building_DB1.buildingDB1DataSet.KeyCharges.AddKeyChargesRow(row);
      }
      if (this.db.building_DB1.keyChargesTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.KeyCharges) > 0)
        flag1 = true;
      if (!flag1)
      {
        int num1 = (int) MessageBox.Show("Cannot Update Settings!");
      }
      else
      {
        int num2 = (int) MessageBox.Show("New Setting Successful!");
      }
    }

    private void Filter_Keys_Only(KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else
        e.Handled = true;
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

    private void txtCheckOutTime_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Filter_Keys_Only(e);
    }

    private void txtGSTRate_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Filter_Keys_N_Dot(e, this.txtGSTRate.Text);
    }

    private void txtGSTRate_TextChanged(object sender, EventArgs e)
    {
      if (this.txtGSTRate.Text.Length != 0)
        return;
      this.txtGSTRate.Text = "0";
    }

    private void Form_DescriptionDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.dateTimePicker_mskBonusStart.Text = this.dateTimePicker_mskBonusStart.Value.ToShortDateString();
      this.dateTimePicker_mskBonusStart1.Text = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString();
    }

    private void CmdPrint_Click(object sender, EventArgs e)
    {
      this.dateTimePicker_mskBonusStart.Text = this.dateTimePicker_mskBonusStart.Value.ToShortDateString().Substring(0);
      this.dateTimePicker_mskBonusStart1.Text = this.dateTimePicker_mskBonusStart1.Value.ToShortDateString().Substring(0);
      this.BonusFrame.Refresh();
    }

    private void dateTimePicker_mskBonusStart_ValueChanged(object sender, EventArgs e)
    {
    }

    private void cboMGrace_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsControl(e.KeyChar) && (e.KeyChar == '&' || e.KeyChar == '('))
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cboWGrace_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsControl(e.KeyChar) && (e.KeyChar == '&' || e.KeyChar == '('))
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cboDGrace_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsControl(e.KeyChar) && (e.KeyChar == '&' || e.KeyChar == '('))
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cboMGrace_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cboWGrace_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void cboDGrace_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
        e.Handled = false;
      else
        e.Handled = true;
    }
  }
}
