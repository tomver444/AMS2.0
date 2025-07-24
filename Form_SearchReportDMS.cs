// Decompiled with JetBrains decompiler
// Type: AMS.Form_SearchReportDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_SearchReportDMS : Form
  {
    private IContainer components;
    public ComboBox cboRoomList;
    public RadioButton _optGenerate_1;
    public Label Label1;
    public GroupBox Frame2;
    public RadioButton _optGenerate_0;
    public GroupBox UnlockFrame;
    public GroupBox Frame4;
    public TextBox txtClientID;
    public ComboBox cboClientID;
    public Label Label3;
    public Button cmdReport;
    public Button cmdReturn;
    public Label lblMessage;
    public RadioButton _optCardIssued_3;
    public RadioButton _optCardIssued_2;
    public MaskedTextBox mskToDate;
    public RadioButton _optCardIssued_1;
    public MaskedTextBox mskDate;
    public GroupBox DateFrame;
    public Label lblFromDate;
    public Label lblToDate;
    public ToolTip ToolTip1;
    public GroupBox CardIssuedFrame;
    public RadioButton _optCardIssued_0;
    public ComboBox cboFloorNo;
    public ComboBox cboBuildingNo;
    public Label Label2;
    public GroupBox Frame1;
    public GroupBox Frame3;
    public RadioButton _optGuest_3;
    public RadioButton _optGuest_2;
    public RadioButton _optGuest_1;
    public RadioButton _optGuest_0;
    private DB db;
    private int iReportType;
    public string sRoomNo = "";
    public string sClientID = "";
    public string sBuildingNo = "";
    public string sFloorNo = "";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_SearchReportDMS));
      this.cboRoomList = new ComboBox();
      this._optGenerate_1 = new RadioButton();
      this.Label1 = new Label();
      this.Frame2 = new GroupBox();
      this._optGenerate_0 = new RadioButton();
      this.UnlockFrame = new GroupBox();
      this.Frame4 = new GroupBox();
      this.txtClientID = new TextBox();
      this.cboClientID = new ComboBox();
      this.Label3 = new Label();
      this.lblMessage = new Label();
      this._optCardIssued_3 = new RadioButton();
      this._optCardIssued_2 = new RadioButton();
      this.mskToDate = new MaskedTextBox();
      this._optCardIssued_1 = new RadioButton();
      this.mskDate = new MaskedTextBox();
      this.DateFrame = new GroupBox();
      this.lblFromDate = new Label();
      this.lblToDate = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.CardIssuedFrame = new GroupBox();
      this._optCardIssued_0 = new RadioButton();
      this.cboFloorNo = new ComboBox();
      this.cboBuildingNo = new ComboBox();
      this.Label2 = new Label();
      this.Frame1 = new GroupBox();
      this.cmdReport = new Button();
      this.cmdReturn = new Button();
      this.Frame3 = new GroupBox();
      this._optGuest_3 = new RadioButton();
      this._optGuest_2 = new RadioButton();
      this._optGuest_1 = new RadioButton();
      this._optGuest_0 = new RadioButton();
      this.Frame2.SuspendLayout();
      this.UnlockFrame.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.DateFrame.SuspendLayout();
      this.CardIssuedFrame.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      this.cboRoomList.BackColor = SystemColors.Window;
      this.cboRoomList.Cursor = Cursors.Default;
      this.cboRoomList.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboRoomList.ForeColor = SystemColors.WindowText;
      this.cboRoomList.Location = new Point(120, 43);
      this.cboRoomList.Name = "cboRoomList";
      this.cboRoomList.RightToLeft = RightToLeft.No;
      this.cboRoomList.Size = new Size(89, 24);
      this.cboRoomList.TabIndex = 31;
      this._optGenerate_1.BackColor = Color.Blue;
      this._optGenerate_1.Cursor = Cursors.Default;
      this._optGenerate_1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGenerate_1.ForeColor = Color.White;
      this._optGenerate_1.Location = new Point(216, 48);
      this._optGenerate_1.Name = "_optGenerate_1";
      this._optGenerate_1.RightToLeft = RightToLeft.No;
      this._optGenerate_1.Size = new Size(121, 49);
      this._optGenerate_1.TabIndex = 11;
      this._optGenerate_1.TabStop = true;
      this._optGenerate_1.Text = "BY LOCK NO";
      this._optGenerate_1.UseVisualStyleBackColor = false;
      this._optGenerate_1.CheckedChanged += new EventHandler(this._optGenerate_1_CheckedChanged);
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(24, 48);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(89, 17);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "ROOM NO";
      this.Frame2.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Frame2.Controls.Add((Control) this.cboRoomList);
      this.Frame2.Controls.Add((Control) this.Label1);
      this.Frame2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = SystemColors.ControlText;
      this.Frame2.Location = new Point(254, 168);
      this.Frame2.Name = "Frame2";
      this.Frame2.Padding = new Padding(0);
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(233, 89);
      this.Frame2.TabIndex = 30;
      this.Frame2.TabStop = false;
      this.Frame2.Text = "ENTER ROOM NO ...";
      this._optGenerate_0.BackColor = Color.Blue;
      this._optGenerate_0.Cursor = Cursors.Default;
      this._optGenerate_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGenerate_0.ForeColor = Color.White;
      this._optGenerate_0.Location = new Point(40, 48);
      this._optGenerate_0.Name = "_optGenerate_0";
      this._optGenerate_0.RightToLeft = RightToLeft.No;
      this._optGenerate_0.Size = new Size(121, 49);
      this._optGenerate_0.TabIndex = 10;
      this._optGenerate_0.TabStop = true;
      this._optGenerate_0.Text = "ALL LIST";
      this._optGenerate_0.UseVisualStyleBackColor = false;
      this._optGenerate_0.CheckedChanged += new EventHandler(this._optGenerate_0_CheckedChanged);
      this.UnlockFrame.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.UnlockFrame.Controls.Add((Control) this._optGenerate_1);
      this.UnlockFrame.Controls.Add((Control) this._optGenerate_0);
      this.UnlockFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.UnlockFrame.ForeColor = SystemColors.ControlText;
      this.UnlockFrame.Location = new Point(190, 128);
      this.UnlockFrame.Name = "UnlockFrame";
      this.UnlockFrame.Padding = new Padding(0);
      this.UnlockFrame.RightToLeft = RightToLeft.No;
      this.UnlockFrame.Size = new Size(393, 137);
      this.UnlockFrame.TabIndex = 31;
      this.UnlockFrame.TabStop = false;
      this.UnlockFrame.Text = "CHOOSE REPORT TYPE :";
      this.Frame4.BackColor = Color.FromArgb(224, 224, 224);
      this.Frame4.Controls.Add((Control) this.txtClientID);
      this.Frame4.Controls.Add((Control) this.cboClientID);
      this.Frame4.Controls.Add((Control) this.Label3);
      this.Frame4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame4.ForeColor = SystemColors.ControlText;
      this.Frame4.Location = new Point(270, 168);
      this.Frame4.Name = "Frame4";
      this.Frame4.Padding = new Padding(0);
      this.Frame4.RightToLeft = RightToLeft.No;
      this.Frame4.Size = new Size(225, 81);
      this.Frame4.TabIndex = 26;
      this.Frame4.TabStop = false;
      this.Frame4.Text = "Choose Guest ID :";
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = SystemColors.WindowText;
      this.txtClientID.Location = new Point(176, 32);
      this.txtClientID.MaxLength = 0;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(41, 20);
      this.txtClientID.TabIndex = 4;
      this.txtClientID.Visible = false;
      this.cboClientID.BackColor = SystemColors.Window;
      this.cboClientID.Cursor = Cursors.Default;
      this.cboClientID.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboClientID.ForeColor = Color.Blue;
      this.cboClientID.Location = new Point(72, 32);
      this.cboClientID.Name = "cboClientID";
      this.cboClientID.RightToLeft = RightToLeft.No;
      this.cboClientID.Size = new Size(105, 24);
      this.cboClientID.TabIndex = 0;
      this.Label3.BackColor = Color.FromArgb(224, 224, 224);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(8, 32);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(57, 17);
      this.Label3.TabIndex = 5;
      this.Label3.Text = "Guest ID";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.lblMessage.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Blue;
      this.lblMessage.Location = new Point(78, 0);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(617, 49);
      this.lblMessage.TabIndex = 29;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this._optCardIssued_3.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this._optCardIssued_3.Cursor = Cursors.Default;
      this._optCardIssued_3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCardIssued_3.ForeColor = SystemColors.ControlText;
      this._optCardIssued_3.Location = new Point(216, 144);
      this._optCardIssued_3.Name = "_optCardIssued_3";
      this._optCardIssued_3.RightToLeft = RightToLeft.No;
      this._optCardIssued_3.Size = new Size(145, 57);
      this._optCardIssued_3.TabIndex = 16;
      this._optCardIssued_3.TabStop = true;
      this._optCardIssued_3.Text = "BY LEVEL NO";
      this._optCardIssued_3.UseVisualStyleBackColor = false;
      this._optCardIssued_3.CheckedChanged += new EventHandler(this._optCardIssued_3_CheckedChanged);
      this._optCardIssued_2.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this._optCardIssued_2.Cursor = Cursors.Default;
      this._optCardIssued_2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCardIssued_2.ForeColor = SystemColors.ControlText;
      this._optCardIssued_2.Location = new Point(216, 48);
      this._optCardIssued_2.Name = "_optCardIssued_2";
      this._optCardIssued_2.RightToLeft = RightToLeft.No;
      this._optCardIssued_2.Size = new Size(145, 57);
      this._optCardIssued_2.TabIndex = 15;
      this._optCardIssued_2.TabStop = true;
      this._optCardIssued_2.Text = "BY ROOM NO";
      this._optCardIssued_2.UseVisualStyleBackColor = false;
      this._optCardIssued_2.CheckedChanged += new EventHandler(this._optCardIssued_2_CheckedChanged);
      this.mskToDate.AllowPromptAsInput = false;
      this.mskToDate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskToDate.ForeColor = Color.Blue;
      this.mskToDate.Location = new Point(144, 104);
      this.mskToDate.Mask = "####-##-##";
      this.mskToDate.Name = "mskToDate";
      this.mskToDate.Size = new Size(81, 22);
      this.mskToDate.TabIndex = 27;
      this.mskToDate.Visible = false;
      this._optCardIssued_1.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this._optCardIssued_1.Cursor = Cursors.Default;
      this._optCardIssued_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCardIssued_1.ForeColor = SystemColors.ControlText;
      this._optCardIssued_1.Location = new Point(32, 144);
      this._optCardIssued_1.Name = "_optCardIssued_1";
      this._optCardIssued_1.RightToLeft = RightToLeft.No;
      this._optCardIssued_1.Size = new Size(145, 57);
      this._optCardIssued_1.TabIndex = 14;
      this._optCardIssued_1.TabStop = true;
      this._optCardIssued_1.Text = "BY GUEST ID";
      this._optCardIssued_1.UseVisualStyleBackColor = false;
      this._optCardIssued_1.CheckedChanged += new EventHandler(this._optCardIssued_1_CheckedChanged);
      this.mskDate.AllowPromptAsInput = false;
      this.mskDate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskDate.ForeColor = Color.Blue;
      this.mskDate.Location = new Point(144, 48);
      this.mskDate.Mask = "####-##-##";
      this.mskDate.Name = "mskDate";
      this.mskDate.Size = new Size(81, 22);
      this.mskDate.TabIndex = 26;
      this.DateFrame.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.DateFrame.Controls.Add((Control) this.mskDate);
      this.DateFrame.Controls.Add((Control) this.mskToDate);
      this.DateFrame.Controls.Add((Control) this.lblFromDate);
      this.DateFrame.Controls.Add((Control) this.lblToDate);
      this.DateFrame.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateFrame.ForeColor = SystemColors.ControlText;
      this.DateFrame.Location = new Point(230, 136);
      this.DateFrame.Name = "DateFrame";
      this.DateFrame.Padding = new Padding(0);
      this.DateFrame.RightToLeft = RightToLeft.No;
      this.DateFrame.Size = new Size(313, 169);
      this.DateFrame.TabIndex = 35;
      this.DateFrame.TabStop = false;
      this.DateFrame.Text = "ENTER DATE :";
      this.lblFromDate.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblFromDate.Cursor = Cursors.Default;
      this.lblFromDate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.lblFromDate.Location = new Point(48, 48);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.RightToLeft = RightToLeft.No;
      this.lblFromDate.Size = new Size(65, 17);
      this.lblFromDate.TabIndex = 29;
      this.lblFromDate.Text = "FROM ";
      this.lblFromDate.TextAlign = ContentAlignment.TopRight;
      this.lblFromDate.Visible = false;
      this.lblToDate.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblToDate.Cursor = Cursors.Default;
      this.lblToDate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblToDate.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.lblToDate.Location = new Point(48, 104);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.RightToLeft = RightToLeft.No;
      this.lblToDate.Size = new Size(65, 17);
      this.lblToDate.TabIndex = 28;
      this.lblToDate.Text = "TO ";
      this.lblToDate.TextAlign = ContentAlignment.TopRight;
      this.lblToDate.Visible = false;
      this.CardIssuedFrame.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.CardIssuedFrame.Controls.Add((Control) this._optCardIssued_3);
      this.CardIssuedFrame.Controls.Add((Control) this._optCardIssued_2);
      this.CardIssuedFrame.Controls.Add((Control) this._optCardIssued_1);
      this.CardIssuedFrame.Controls.Add((Control) this._optCardIssued_0);
      this.CardIssuedFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CardIssuedFrame.ForeColor = SystemColors.ControlText;
      this.CardIssuedFrame.Location = new Point(206, 104);
      this.CardIssuedFrame.Name = "CardIssuedFrame";
      this.CardIssuedFrame.Padding = new Padding(0);
      this.CardIssuedFrame.RightToLeft = RightToLeft.No;
      this.CardIssuedFrame.Size = new Size(401, 233);
      this.CardIssuedFrame.TabIndex = 32;
      this.CardIssuedFrame.TabStop = false;
      this.CardIssuedFrame.Text = "DETAIL CARD ISSUED FOR GUEST...";
      this._optCardIssued_0.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this._optCardIssued_0.Cursor = Cursors.Default;
      this._optCardIssued_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCardIssued_0.ForeColor = SystemColors.ControlText;
      this._optCardIssued_0.Location = new Point(32, 48);
      this._optCardIssued_0.Name = "_optCardIssued_0";
      this._optCardIssued_0.RightToLeft = RightToLeft.No;
      this._optCardIssued_0.Size = new Size(145, 57);
      this._optCardIssued_0.TabIndex = 13;
      this._optCardIssued_0.TabStop = true;
      this._optCardIssued_0.Text = "ALL LIST";
      this._optCardIssued_0.UseVisualStyleBackColor = false;
      this._optCardIssued_0.CheckedChanged += new EventHandler(this._optCardIssued_0_CheckedChanged);
      this.cboFloorNo.BackColor = SystemColors.Window;
      this.cboFloorNo.Cursor = Cursors.Default;
      this.cboFloorNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboFloorNo.ForeColor = Color.Blue;
      this.cboFloorNo.Location = new Point(56, 64);
      this.cboFloorNo.Name = "cboFloorNo";
      this.cboFloorNo.RightToLeft = RightToLeft.No;
      this.cboFloorNo.Size = new Size(81, 22);
      this.cboFloorNo.TabIndex = 20;
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(56, 64);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(81, 22);
      this.cboBuildingNo.TabIndex = 18;
      this.Label2.BackColor = Color.FromArgb(155, 183, 225);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(56, 32);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(105, 25);
      this.Label2.TabIndex = 19;
      this.Label2.Text = "BUILDING";
      this.Frame1.BackColor = Color.FromArgb(155, 183, 225);
      this.Frame1.Controls.Add((Control) this.cboFloorNo);
      this.Frame1.Controls.Add((Control) this.cboBuildingNo);
      this.Frame1.Controls.Add((Control) this.Label2);
      this.Frame1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = Color.Red;
      this.Frame1.Location = new Point(286, 160);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(193, 113);
      this.Frame1.TabIndex = 33;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "SELECT BUILDING NO...";
      this.cmdReport.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdReport.Cursor = Cursors.Default;
      this.cmdReport.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReport.ForeColor = SystemColors.ControlText;
      this.cmdReport.Image = (Image) componentResourceManager.GetObject("cmdReport.Image");
      this.cmdReport.Location = new Point(262, 408);
      this.cmdReport.Name = "cmdReport";
      this.cmdReport.RightToLeft = RightToLeft.No;
      this.cmdReport.Size = new Size(97, 49);
      this.cmdReport.TabIndex = 27;
      this.cmdReport.Text = "&REPORT";
      this.cmdReport.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReport.UseVisualStyleBackColor = false;
      this.cmdReport.Click += new EventHandler(this.cmdReport_Click);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(390, 408);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(97, 49);
      this.cmdReturn.TabIndex = 28;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.Frame3.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Frame3.Controls.Add((Control) this._optGuest_3);
      this.Frame3.Controls.Add((Control) this._optGuest_2);
      this.Frame3.Controls.Add((Control) this._optGuest_1);
      this.Frame3.Controls.Add((Control) this._optGuest_0);
      this.Frame3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = Color.White;
      this.Frame3.Location = new Point(177, 155);
      this.Frame3.Name = "Frame3";
      this.Frame3.Padding = new Padding(0);
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(441, 233);
      this.Frame3.TabIndex = 36;
      this.Frame3.TabStop = false;
      this.Frame3.Text = "SELECT OPTIONS :";
      this._optGuest_3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optGuest_3.Cursor = Cursors.Default;
      this._optGuest_3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGuest_3.ForeColor = Color.Blue;
      this._optGuest_3.Location = new Point(232, 136);
      this._optGuest_3.Name = "_optGuest_3";
      this._optGuest_3.RightToLeft = RightToLeft.No;
      this._optGuest_3.Size = new Size(161, 65);
      this._optGuest_3.TabIndex = 30;
      this._optGuest_3.TabStop = true;
      this._optGuest_3.Text = "BY LEVEL NO.";
      this._optGuest_3.UseVisualStyleBackColor = false;
      this._optGuest_3.CheckedChanged += new EventHandler(this._optGuest_3_CheckedChanged);
      this._optGuest_2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optGuest_2.Cursor = Cursors.Default;
      this._optGuest_2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGuest_2.ForeColor = Color.Blue;
      this._optGuest_2.Location = new Point(232, 40);
      this._optGuest_2.Name = "_optGuest_2";
      this._optGuest_2.RightToLeft = RightToLeft.No;
      this._optGuest_2.Size = new Size(161, 65);
      this._optGuest_2.TabIndex = 24;
      this._optGuest_2.TabStop = true;
      this._optGuest_2.Text = "GUEST INFO";
      this._optGuest_2.UseVisualStyleBackColor = false;
      this._optGuest_2.CheckedChanged += new EventHandler(this._optGuest_2_CheckedChanged);
      this._optGuest_1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optGuest_1.Cursor = Cursors.Default;
      this._optGuest_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGuest_1.ForeColor = Color.Blue;
      this._optGuest_1.Location = new Point(40, 136);
      this._optGuest_1.Name = "_optGuest_1";
      this._optGuest_1.RightToLeft = RightToLeft.No;
      this._optGuest_1.Size = new Size(161, 65);
      this._optGuest_1.TabIndex = 23;
      this._optGuest_1.TabStop = true;
      this._optGuest_1.Text = "GUEST RECORD DATE";
      this._optGuest_1.UseVisualStyleBackColor = false;
      this._optGuest_1.CheckedChanged += new EventHandler(this._optGuest_1_CheckedChanged);
      this._optGuest_0.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optGuest_0.Cursor = Cursors.Default;
      this._optGuest_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optGuest_0.ForeColor = Color.Blue;
      this._optGuest_0.Location = new Point(40, 40);
      this._optGuest_0.Name = "_optGuest_0";
      this._optGuest_0.RightToLeft = RightToLeft.No;
      this._optGuest_0.Size = new Size(161, 65);
      this._optGuest_0.TabIndex = 22;
      this._optGuest_0.TabStop = true;
      this._optGuest_0.Text = "GUEST ACCOUNT";
      this._optGuest_0.UseVisualStyleBackColor = false;
      this._optGuest_0.CheckedChanged += new EventHandler(this._optGuest_0_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.ClientSize = new Size(795, 543);
      this.ControlBox = false;
      this.Controls.Add((Control) this.cmdReport);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.UnlockFrame);
      this.Controls.Add((Control) this.DateFrame);
      this.Controls.Add((Control) this.Frame4);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Frame3);
      this.Controls.Add((Control) this.CardIssuedFrame);
      this.Controls.Add((Control) this.Frame2);
      this.Name = "Form_SearchReportDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form_SearchReportDMS";
      this.Load += new EventHandler(this.Form_SearchReportDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_SearchReportDMS_VisibleChanged);
      this.Frame2.ResumeLayout(false);
      this.UnlockFrame.ResumeLayout(false);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.DateFrame.ResumeLayout(false);
      this.DateFrame.PerformLayout();
      this.CardIssuedFrame.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Form_SearchReportDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void Form_SearchReportDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBuildingNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.ComboSelectedRooms(this.cboRoomList);
      this.db.ComboFloorCheck(this.cboFloorNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
      this.db.ComboAddClientID(this.cboClientID, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
    }

    private void cmdReport_Click(object sender, EventArgs e)
    {
      switch (Global_Data.iReport)
      {
        case 0:
          this.sRoomNo = this.cboRoomList.Text;
          Global_Data.bCurrent = true;
          this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
          ReportForm reportForm1 = new ReportForm();
          RoomHistoryReportClass historyReportClass1 = new RoomHistoryReportClass();
          reportForm1.crystalReportViewer1.ReportSource = (object) historyReportClass1.CHECK_ROOMHISTORY(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
          int num1 = (int) reportForm1.ShowDialog();
          break;
        case 4:
          this.sClientID = this.cboClientID.Text;
          Global_Data.bCurrent = true;
          this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
          ReportForm reportForm2 = new ReportForm();
          ReportClass_GuestHistory classGuestHistory = new ReportClass_GuestHistory();
          reportForm2.crystalReportViewer1.ReportSource = (object) classGuestHistory.CHECK_GUESTHISTORY(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
          int num2 = (int) reportForm2.ShowDialog();
          break;
        case 5:
          Global_Data.bCurrent = true;
          this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
          if (this.iReportType == 1)
          {
            ReportForm reportForm3 = new ReportForm();
            ReportClass_DetailGuestIssued detailGuestIssued = new ReportClass_DetailGuestIssued();
            reportForm3.crystalReportViewer1.ReportSource = (object) detailGuestIssued.CHECK_DETAILGUESTISSUED(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num3 = (int) reportForm3.ShowDialog();
            break;
          }
          if (this.iReportType == 2)
          {
            this.sClientID = this.cboClientID.Text;
            ReportForm reportForm4 = new ReportForm();
            ReportClass_GuestIssuedByGuestID guestIssuedByGuestId = new ReportClass_GuestIssuedByGuestID();
            reportForm4.crystalReportViewer1.ReportSource = (object) guestIssuedByGuestId.CHECK_GUESTISSUEDBYCLIENTID(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num4 = (int) reportForm4.ShowDialog();
            break;
          }
          if (this.iReportType == 3)
          {
            this.sRoomNo = this.cboRoomList.Text;
            ReportForm reportForm5 = new ReportForm();
            GuestIssuedByRoomNo_ReportClass roomNoReportClass = new GuestIssuedByRoomNo_ReportClass();
            reportForm5.crystalReportViewer1.ReportSource = (object) roomNoReportClass.CHECK_GUESTISSUEDBYROOMNO(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num5 = (int) reportForm5.ShowDialog();
            break;
          }
          if (this.iReportType != 4)
            break;
          this.sFloorNo = this.cboFloorNo.Text;
          ReportForm reportForm6 = new ReportForm();
          ReportClass_GuestIssuedByFloorNo guestIssuedByFloorNo = new ReportClass_GuestIssuedByFloorNo();
          reportForm6.crystalReportViewer1.ReportSource = (object) guestIssuedByFloorNo.CHECK_GUESTISSUEDBYFLOORNO(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
          int num6 = (int) reportForm6.ShowDialog();
          break;
        case 6:
          Global_Data.bCurrent = true;
          this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
          if (this.iReportType == 1)
          {
            ReportForm reportForm7 = new ReportForm();
            UnLockDoorHistory_ReportClass historyReportClass2 = new UnLockDoorHistory_ReportClass();
            reportForm7.crystalReportViewer1.ReportSource = (object) historyReportClass2.CHECK_UNLOCKDOORHISTORY(Global_Data.bCurrent, Global_Data.ReportCalendar_Text, Global_Data.sBldNo);
            int num7 = (int) reportForm7.ShowDialog();
            break;
          }
          if (this.iReportType != 2)
            break;
          this.sRoomNo = this.cboRoomList.Text;
          ReportForm reportForm8 = new ReportForm();
          UnLockDoorByRoomNo_ReportClass roomNoReportClass1 = new UnLockDoorByRoomNo_ReportClass();
          reportForm8.crystalReportViewer1.ReportSource = (object) roomNoReportClass1.CHECK_UNLOCKDOORBYROOMNO(Global_Data.bCurrent, Global_Data.ReportCalendar_Text, Global_Data.sBldNo);
          int num8 = (int) reportForm8.ShowDialog();
          break;
        case 10:
          if (this.iReportType == 1)
          {
            this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
            ReportForm reportForm9 = new ReportForm();
            StayingGuest_ByCurrentAccount_ReportClass accountReportClass = new StayingGuest_ByCurrentAccount_ReportClass();
            reportForm9.crystalReportViewer1.ReportSource = (object) accountReportClass.CHECK_CURRENTGACCOUNT(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num9 = (int) reportForm9.ShowDialog();
            break;
          }
          if (this.iReportType == 2)
          {
            this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
            ReportForm reportForm10 = new ReportForm();
            StayingGuest_ByRecordDate_ReportClass recordDateReportClass = new StayingGuest_ByRecordDate_ReportClass();
            reportForm10.crystalReportViewer1.ReportSource = (object) recordDateReportClass.CHECK_CURRENTGRECORDDATE(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num10 = (int) reportForm10.ShowDialog();
            break;
          }
          if (this.iReportType == 3)
          {
            this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
            ReportForm reportForm11 = new ReportForm();
            StayingGuest_ByCurrentGInfo_ReportClass ginfoReportClass = new StayingGuest_ByCurrentGInfo_ReportClass();
            reportForm11.crystalReportViewer1.ReportSource = (object) ginfoReportClass.CHECK_CURRENTGINFO(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
            int num11 = (int) reportForm11.ShowDialog();
            break;
          }
          if (this.iReportType != 4)
            break;
          this.db.RetrieveBldName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
          this.sFloorNo = this.cboFloorNo.Text;
          ReportForm reportForm12 = new ReportForm();
          StayingGuest_ByCurrentGByFloorNo_ReportClass floorNoReportClass = new StayingGuest_ByCurrentGByFloorNo_ReportClass();
          reportForm12.crystalReportViewer1.ReportSource = (object) floorNoReportClass.CHECK_CURRENTGBYFLOORNO(Global_Data.bCurrent, Global_Data.ReportCalendar_Text);
          int num12 = (int) reportForm12.ShowDialog();
          break;
      }
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_OtherReportsDMS_Ptr.Visible = true;
      this.Visible = false;
    }

    private void Check_Enable_Disable_Frames()
    {
      switch (Global_Data.iReport)
      {
        case 0:
          this.lblMessage.Text = " ROOM HISTORY ";
          this.Frame2.Visible = true;
          this.Frame4.Visible = false;
          this.Frame1.Visible = false;
          this.UnlockFrame.Visible = false;
          this.DateFrame.Visible = false;
          this.CardIssuedFrame.Visible = false;
          this.Frame3.Visible = false;
          break;
        case 4:
          this.lblMessage.Text = " GUEST HISTORY ";
          this.Frame4.Visible = true;
          this.Frame2.Visible = false;
          this.Frame1.Visible = false;
          this.UnlockFrame.Visible = false;
          this.DateFrame.Visible = false;
          this.CardIssuedFrame.Visible = false;
          this.Frame3.Visible = false;
          break;
        case 5:
          this.lblMessage.Text = " DETAIL GUEST CARD ISSUED ";
          this.Frame4.Visible = false;
          this.Frame2.Visible = false;
          this.Frame1.Visible = false;
          this.UnlockFrame.Visible = false;
          this.DateFrame.Visible = false;
          this.CardIssuedFrame.Visible = true;
          this.Frame3.Visible = false;
          this._optCardIssued_0.Visible = true;
          this._optCardIssued_0.Checked = false;
          this._optCardIssued_1.Visible = true;
          this._optCardIssued_1.Checked = false;
          this._optCardIssued_2.Visible = true;
          this._optCardIssued_2.Checked = false;
          this._optCardIssued_3.Visible = true;
          this._optCardIssued_3.Checked = false;
          break;
        case 6:
          this.lblMessage.Text = " UNLOCK DOOR HISTROY ";
          this.UnlockFrame.Visible = true;
          this.Frame4.Visible = false;
          this.Frame2.Visible = false;
          this.Frame1.Visible = false;
          this.DateFrame.Visible = false;
          this.CardIssuedFrame.Visible = false;
          this.Frame3.Visible = false;
          this._optGenerate_0.Visible = true;
          this._optGenerate_0.Checked = false;
          this._optGenerate_1.Visible = true;
          this._optGenerate_1.Checked = false;
          break;
        case 10:
          this.lblMessage.Text = " CURRENT STAYING GUEST LIST ";
          this.Frame3.Visible = true;
          this.Frame1.Visible = false;
          this.Frame2.Visible = false;
          this.Frame4.Visible = false;
          this.DateFrame.Visible = false;
          this.UnlockFrame.Visible = false;
          this.CardIssuedFrame.Visible = false;
          if (Global_Data.bCurrent)
          {
            this._optGuest_0.Visible = true;
            this._optGuest_0.Checked = false;
            this._optGuest_1.Visible = true;
            this._optGuest_1.Checked = false;
            this._optGuest_2.Visible = true;
            this._optGuest_2.Checked = false;
            this._optGuest_3.Visible = true;
            this._optGuest_3.Checked = false;
            this._optGuest_3.Enabled = true;
            break;
          }
          this._optGuest_0.Visible = true;
          this._optGuest_0.Checked = false;
          this._optGuest_1.Visible = true;
          this._optGuest_1.Checked = false;
          this._optGuest_2.Visible = true;
          this._optGuest_2.Checked = false;
          this._optGuest_3.Visible = true;
          this._optGuest_3.Checked = false;
          this._optGuest_3.Enabled = false;
          break;
      }
    }

    private void Form_SearchReportDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Check_Enable_Disable_Frames();
    }

    private void Check_optGuest()
    {
      this.sRoomNo = "";
      this.sBuildingNo = "";
      this.sFloorNo = "";
      this.iReportType = 0;
      if (this._optGuest_0.Checked)
        this.iReportType = 1;
      else if (this._optGuest_1.Checked)
        this.iReportType = 2;
      else if (this._optGuest_2.Checked)
      {
        this.iReportType = 3;
      }
      else
      {
        if (!this._optGuest_3.Checked)
          return;
        this.iReportType = 4;
        this.Frame1.Visible = true;
        this.Frame2.Visible = false;
        this.Frame4.Visible = false;
        this.Frame3.Visible = false;
        this.UnlockFrame.Visible = false;
        this.DateFrame.Visible = false;
        this.CardIssuedFrame.Visible = false;
        this.Frame1.Text = "Select Level No:";
        this.Label2.Text = "Level";
        this.cboFloorNo.Visible = true;
        this.cboBuildingNo.Visible = false;
      }
    }

    private void _optGuest_0_CheckedChanged(object sender, EventArgs e) => this.Check_optGuest();

    private void _optGuest_1_CheckedChanged(object sender, EventArgs e) => this.Check_optGuest();

    private void _optGuest_2_CheckedChanged(object sender, EventArgs e) => this.Check_optGuest();

    private void _optGuest_3_CheckedChanged(object sender, EventArgs e) => this.Check_optGuest();

    private void Check_optCardIssued()
    {
      this.sRoomNo = "";
      this.sClientID = "";
      this.sBuildingNo = "";
      this.sFloorNo = "";
      this.iReportType = 0;
      if (this._optCardIssued_0.Checked)
        this.iReportType = 1;
      else if (this._optCardIssued_1.Checked)
      {
        this.iReportType = 2;
        this.Frame4.Visible = true;
        this.Frame2.Visible = false;
        this.Frame1.Visible = false;
        this.UnlockFrame.Visible = false;
        this.DateFrame.Visible = false;
        this.CardIssuedFrame.Visible = false;
      }
      else if (this._optCardIssued_2.Checked)
      {
        this.iReportType = 3;
        this.Frame2.Visible = true;
        this.Frame4.Visible = false;
        this.Frame1.Visible = false;
        this.UnlockFrame.Visible = false;
        this.DateFrame.Visible = false;
        this.CardIssuedFrame.Visible = false;
      }
      else
      {
        if (!this._optCardIssued_3.Checked)
          return;
        this.iReportType = 4;
        this.Frame1.Visible = true;
        this.Frame2.Visible = false;
        this.UnlockFrame.Visible = false;
        this.DateFrame.Visible = false;
        this.CardIssuedFrame.Visible = false;
        this.Frame1.Text = "Select Level No:";
        this.Label2.Text = "Level";
        this.cboFloorNo.Visible = true;
        this.cboBuildingNo.Visible = false;
      }
    }

    private void _optCardIssued_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optCardIssued();
    }

    private void _optCardIssued_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optCardIssued();
    }

    private void _optCardIssued_2_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optCardIssued();
    }

    private void _optCardIssued_3_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optCardIssued();
    }

    private void Check_optGenerate()
    {
      this.sRoomNo = "";
      if (this._optGenerate_0.Checked)
      {
        this.iReportType = 1;
      }
      else
      {
        if (!this._optGenerate_1.Checked)
          return;
        this.iReportType = 2;
        this.Frame2.Visible = true;
        this.Frame4.Visible = false;
        this.UnlockFrame.Visible = false;
      }
    }

    private void _optGenerate_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optGenerate();
    }

    private void _optGenerate_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_optGenerate();
    }
  }
}
