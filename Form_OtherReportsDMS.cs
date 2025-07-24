// Decompiled with JetBrains decompiler
// Type: AMS.Form_OtherReportsDMS
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
  public class Form_OtherReportsDMS : Form
  {
    private IContainer components;
    public RadioButton _optReport_14;
    public RadioButton _optReport_13;
    public ToolTip ToolTip1;
    public RadioButton _optReport_12;
    public RadioButton _optReport_11;
    public RadioButton _optReport_10;
    public RadioButton _optReport_9;
    public RadioButton _optReport_8;
    public RadioButton _optReport_7;
    public RadioButton _optReport_6;
    public ComboBox cboBuildingNo;
    public RadioButton _optReport_5;
    public RadioButton _optReport_4;
    public Label Label3;
    public Label lblDay;
    public RadioButton _optReport_0;
    public RadioButton _optReport_3;
    public Label Label2;
    public RadioButton _optReport_2;
    public RadioButton _optReport_1;
    public Label lblReportName;
    public Panel Frame3;
    public RadioButton optYear;
    public RadioButton optMonth;
    public RadioButton optDay;
    public Label Label1;
    public RadioButton _optReport_15;
    public RadioButton _optReport_16;
    public RadioButton _optChoice_1;
    public GroupBox ViewFrame;
    public RadioButton _optRecordView_0;
    public RadioButton _optRecordView_1;
    public Label lblbldno;
    public GroupBox Frame_All_Ind_Choice;
    public ComboBox cboBldNo;
    public GroupBox Frame5;
    public RadioButton _optChoice_0;
    public Button cmdPrint;
    public Label lblMonth;
    public Button cmdBack;
    public GroupBox ReportFrame;
    public Label lblYear;
    public Button cmdReturn;
    public Panel DMYFrame;
    private DateTimePicker dateTimePicker_ReportCalendar;
    private DateTimePicker dateTimePicker_cboYear;
    private DateTimePicker dateTimePicker_cboMonth;
    private DateTimePicker dateTimePicker_cboDay;
    private DB db;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_OtherReportsDMS));
      this._optReport_14 = new RadioButton();
      this._optReport_13 = new RadioButton();
      this.ToolTip1 = new ToolTip(this.components);
      this._optReport_12 = new RadioButton();
      this._optReport_11 = new RadioButton();
      this._optReport_10 = new RadioButton();
      this._optReport_9 = new RadioButton();
      this._optReport_8 = new RadioButton();
      this._optReport_7 = new RadioButton();
      this._optReport_6 = new RadioButton();
      this.cboBuildingNo = new ComboBox();
      this._optReport_5 = new RadioButton();
      this._optReport_4 = new RadioButton();
      this.Label3 = new Label();
      this.lblDay = new Label();
      this._optReport_0 = new RadioButton();
      this._optReport_3 = new RadioButton();
      this.Label2 = new Label();
      this._optReport_2 = new RadioButton();
      this._optReport_1 = new RadioButton();
      this.lblReportName = new Label();
      this.Frame3 = new Panel();
      this.optYear = new RadioButton();
      this.optMonth = new RadioButton();
      this.optDay = new RadioButton();
      this.Label1 = new Label();
      this._optReport_15 = new RadioButton();
      this._optReport_16 = new RadioButton();
      this._optChoice_1 = new RadioButton();
      this.ViewFrame = new GroupBox();
      this._optRecordView_0 = new RadioButton();
      this._optRecordView_1 = new RadioButton();
      this.lblbldno = new Label();
      this.Frame_All_Ind_Choice = new GroupBox();
      this.cboBldNo = new ComboBox();
      this.Frame5 = new GroupBox();
      this._optChoice_0 = new RadioButton();
      this.cmdPrint = new Button();
      this.lblMonth = new Label();
      this.cmdBack = new Button();
      this.ReportFrame = new GroupBox();
      this.lblYear = new Label();
      this.cmdReturn = new Button();
      this.DMYFrame = new Panel();
      this.dateTimePicker_ReportCalendar = new DateTimePicker();
      this.dateTimePicker_cboYear = new DateTimePicker();
      this.dateTimePicker_cboMonth = new DateTimePicker();
      this.dateTimePicker_cboDay = new DateTimePicker();
      this.Frame3.SuspendLayout();
      this.ViewFrame.SuspendLayout();
      this.Frame_All_Ind_Choice.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.ReportFrame.SuspendLayout();
      this.DMYFrame.SuspendLayout();
      this.SuspendLayout();
      this._optReport_14.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_14.Cursor = Cursors.Default;
      this._optReport_14.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_14.ForeColor = SystemColors.ControlText;
      this._optReport_14.Location = new Point(416, 336);
      this._optReport_14.Name = "_optReport_14";
      this._optReport_14.RightToLeft = RightToLeft.No;
      this._optReport_14.Size = new Size(177, 49);
      this._optReport_14.TabIndex = 33;
      this._optReport_14.TabStop = true;
      this._optReport_14.Text = "CANCEL WITHOUT CARD LIST";
      this._optReport_14.UseVisualStyleBackColor = false;
      this._optReport_14.CheckedChanged += new EventHandler(this._optReport_14_CheckedChanged);
      this._optReport_13.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_13.Cursor = Cursors.Default;
      this._optReport_13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_13.ForeColor = SystemColors.ControlText;
      this._optReport_13.Location = new Point(416, 149);
      this._optReport_13.Name = "_optReport_13";
      this._optReport_13.RightToLeft = RightToLeft.No;
      this._optReport_13.Size = new Size(177, 49);
      this._optReport_13.TabIndex = 15;
      this._optReport_13.TabStop = true;
      this._optReport_13.Text = "EMERGENCY CARD LIST";
      this._optReport_13.UseVisualStyleBackColor = false;
      this._optReport_13.CheckedChanged += new EventHandler(this._optReport_13_CheckedChanged);
      this._optReport_12.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_12.Cursor = Cursors.Default;
      this._optReport_12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_12.ForeColor = SystemColors.ControlText;
      this._optReport_12.Location = new Point(416, 274);
      this._optReport_12.Name = "_optReport_12";
      this._optReport_12.RightToLeft = RightToLeft.No;
      this._optReport_12.Size = new Size(177, 49);
      this._optReport_12.TabIndex = 14;
      this._optReport_12.TabStop = true;
      this._optReport_12.Text = "CANCEL CARD LIST";
      this._optReport_12.UseVisualStyleBackColor = false;
      this._optReport_12.CheckedChanged += new EventHandler(this._optReport_12_CheckedChanged);
      this._optReport_11.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_11.Cursor = Cursors.Default;
      this._optReport_11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_11.ForeColor = SystemColors.ControlText;
      this._optReport_11.Location = new Point(416, 211);
      this._optReport_11.Name = "_optReport_11";
      this._optReport_11.RightToLeft = RightToLeft.No;
      this._optReport_11.Size = new Size(177, 49);
      this._optReport_11.TabIndex = 13;
      this._optReport_11.TabStop = true;
      this._optReport_11.Text = "RECYCLE CARD LIST";
      this._optReport_11.UseVisualStyleBackColor = false;
      this._optReport_11.CheckedChanged += new EventHandler(this._optReport_11_CheckedChanged);
      this._optReport_10.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_10.Cursor = Cursors.Default;
      this._optReport_10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_10.ForeColor = SystemColors.ControlText;
      this._optReport_10.Location = new Point(216, 211);
      this._optReport_10.Name = "_optReport_10";
      this._optReport_10.RightToLeft = RightToLeft.No;
      this._optReport_10.Size = new Size(177, 49);
      this._optReport_10.TabIndex = 11;
      this._optReport_10.TabStop = true;
      this._optReport_10.Text = "CURRENT GUEST LIST";
      this._optReport_10.UseVisualStyleBackColor = false;
      this._optReport_10.CheckedChanged += new EventHandler(this._optReport_10_CheckedChanged);
      this._optReport_9.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this._optReport_9.Cursor = Cursors.Default;
      this._optReport_9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_9.ForeColor = SystemColors.ControlText;
      this._optReport_9.Location = new Point(216, 24);
      this._optReport_9.Name = "_optReport_9";
      this._optReport_9.RightToLeft = RightToLeft.No;
      this._optReport_9.Size = new Size(177, 49);
      this._optReport_9.TabIndex = 10;
      this._optReport_9.TabStop = true;
      this._optReport_9.Text = "STAYING GRACE PERIOD GUEST LIST";
      this._optReport_9.UseVisualStyleBackColor = false;
      this._optReport_9.CheckedChanged += new EventHandler(this._optReport_9_CheckedChanged);
      this._optReport_8.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_8.Cursor = Cursors.Default;
      this._optReport_8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_8.ForeColor = SystemColors.ControlText;
      this._optReport_8.Location = new Point(416, 86);
      this._optReport_8.Name = "_optReport_8";
      this._optReport_8.RightToLeft = RightToLeft.No;
      this._optReport_8.Size = new Size(177, 49);
      this._optReport_8.TabIndex = 9;
      this._optReport_8.TabStop = true;
      this._optReport_8.Text = "EXTRA CARD REPORT";
      this._optReport_8.UseVisualStyleBackColor = false;
      this._optReport_8.CheckedChanged += new EventHandler(this._optReport_8_CheckedChanged);
      this._optReport_7.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_7.Cursor = Cursors.Default;
      this._optReport_7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_7.ForeColor = SystemColors.ControlText;
      this._optReport_7.Location = new Point(416, 24);
      this._optReport_7.Name = "_optReport_7";
      this._optReport_7.RightToLeft = RightToLeft.No;
      this._optReport_7.Size = new Size(177, 49);
      this._optReport_7.TabIndex = 8;
      this._optReport_7.TabStop = true;
      this._optReport_7.Text = "LOSS CARD REPORT ";
      this._optReport_7.UseVisualStyleBackColor = false;
      this._optReport_7.CheckedChanged += new EventHandler(this._optReport_7_CheckedChanged);
      this._optReport_6.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_6.Cursor = Cursors.Default;
      this._optReport_6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_6.ForeColor = SystemColors.ControlText;
      this._optReport_6.Location = new Point(16, 336);
      this._optReport_6.Name = "_optReport_6";
      this._optReport_6.RightToLeft = RightToLeft.No;
      this._optReport_6.Size = new Size(177, 49);
      this._optReport_6.TabIndex = 7;
      this._optReport_6.TabStop = true;
      this._optReport_6.Text = "UNLOCK DOOR HISTORY";
      this._optReport_6.UseVisualStyleBackColor = false;
      this._optReport_6.CheckedChanged += new EventHandler(this._optReport_6_CheckedChanged);
      this.cboBuildingNo.BackColor = Color.White;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(16, 171);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(65, 29);
      this.cboBuildingNo.TabIndex = 25;
      this.cboBuildingNo.Visible = false;
      this._optReport_5.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_5.Cursor = Cursors.Default;
      this._optReport_5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_5.ForeColor = SystemColors.ControlText;
      this._optReport_5.Location = new Point(16, 274);
      this._optReport_5.Name = "_optReport_5";
      this._optReport_5.RightToLeft = RightToLeft.No;
      this._optReport_5.Size = new Size(177, 49);
      this._optReport_5.TabIndex = 6;
      this._optReport_5.TabStop = true;
      this._optReport_5.Text = "DETAIL GUEST CARD ISSUED";
      this._optReport_5.UseVisualStyleBackColor = false;
      this._optReport_5.CheckedChanged += new EventHandler(this._optReport_5_CheckedChanged);
      this._optReport_4.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_4.Cursor = Cursors.Default;
      this._optReport_4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_4.ForeColor = SystemColors.ControlText;
      this._optReport_4.Location = new Point(16, 211);
      this._optReport_4.Name = "_optReport_4";
      this._optReport_4.RightToLeft = RightToLeft.No;
      this._optReport_4.Size = new Size(177, 49);
      this._optReport_4.TabIndex = 5;
      this._optReport_4.TabStop = true;
      this._optReport_4.Text = "GUEST HISTORY";
      this._optReport_4.UseVisualStyleBackColor = false;
      this._optReport_4.CheckedChanged += new EventHandler(this._optReport_4_CheckedChanged);
      this.Label3.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(12, 121);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(113, 25);
      this.Label3.TabIndex = 29;
      this.Label3.Text = "Building No. ";
      this.Label3.Visible = false;
      this.lblDay.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblDay.Cursor = Cursors.Default;
      this.lblDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDay.ForeColor = Color.White;
      this.lblDay.Location = new Point(706, 293);
      this.lblDay.Name = "lblDay";
      this.lblDay.RightToLeft = RightToLeft.No;
      this.lblDay.Size = new Size(65, 33);
      this.lblDay.TabIndex = 28;
      this.lblDay.Text = "Day";
      this.lblDay.Visible = false;
      this._optReport_0.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_0.Cursor = Cursors.Default;
      this._optReport_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_0.ForeColor = SystemColors.ControlText;
      this._optReport_0.Location = new Point(16, 24);
      this._optReport_0.Name = "_optReport_0";
      this._optReport_0.RightToLeft = RightToLeft.No;
      this._optReport_0.Size = new Size(177, 49);
      this._optReport_0.TabIndex = 1;
      this._optReport_0.TabStop = true;
      this._optReport_0.Text = "ROOM HISTORY";
      this._optReport_0.UseVisualStyleBackColor = false;
      this._optReport_0.CheckedChanged += new EventHandler(this._optReport_0_CheckedChanged);
      this._optReport_3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_3.Cursor = Cursors.Default;
      this._optReport_3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_3.ForeColor = SystemColors.ControlText;
      this._optReport_3.Location = new Point(16, 149);
      this._optReport_3.Name = "_optReport_3";
      this._optReport_3.RightToLeft = RightToLeft.No;
      this._optReport_3.Size = new Size(177, 49);
      this._optReport_3.TabIndex = 4;
      this._optReport_3.TabStop = true;
      this._optReport_3.Text = "GUEST RECORD DATE";
      this._optReport_3.UseVisualStyleBackColor = false;
      this._optReport_3.CheckedChanged += new EventHandler(this._optReport_3_CheckedChanged);
      this.Label2.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label2.BorderStyle = BorderStyle.Fixed3D;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(3, 2);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(793, 41);
      this.Label2.TabIndex = 41;
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this._optReport_2.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_2.Cursor = Cursors.Default;
      this._optReport_2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_2.ForeColor = SystemColors.ControlText;
      this._optReport_2.Location = new Point(16, 86);
      this._optReport_2.Name = "_optReport_2";
      this._optReport_2.RightToLeft = RightToLeft.No;
      this._optReport_2.Size = new Size(177, 49);
      this._optReport_2.TabIndex = 3;
      this._optReport_2.TabStop = true;
      this._optReport_2.Text = "GUEST ACCOUNT";
      this._optReport_2.UseVisualStyleBackColor = false;
      this._optReport_2.CheckedChanged += new EventHandler(this._optReport_2_CheckedChanged);
      this._optReport_1.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this._optReport_1.Cursor = Cursors.Default;
      this._optReport_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_1.ForeColor = SystemColors.ControlText;
      this._optReport_1.Location = new Point(216, 274);
      this._optReport_1.Name = "_optReport_1";
      this._optReport_1.RightToLeft = RightToLeft.No;
      this._optReport_1.Size = new Size(177, 49);
      this._optReport_1.TabIndex = 2;
      this._optReport_1.TabStop = true;
      this._optReport_1.Text = "ALL GUEST LIST";
      this._optReport_1.UseVisualStyleBackColor = false;
      this._optReport_1.CheckedChanged += new EventHandler(this._optReport_1_CheckedChanged);
      this.lblReportName.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblReportName.Cursor = Cursors.Default;
      this.lblReportName.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblReportName.ForeColor = Color.Blue;
      this.lblReportName.Location = new Point(3, 42);
      this.lblReportName.Name = "lblReportName";
      this.lblReportName.RightToLeft = RightToLeft.No;
      this.lblReportName.Size = new Size(793, 41);
      this.lblReportName.TabIndex = 46;
      this.lblReportName.TextAlign = ContentAlignment.TopCenter;
      this.Frame3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Frame3.Controls.Add((Control) this.optYear);
      this.Frame3.Controls.Add((Control) this.optMonth);
      this.Frame3.Controls.Add((Control) this.optDay);
      this.Frame3.Controls.Add((Control) this.Label1);
      this.Frame3.Cursor = Cursors.Default;
      this.Frame3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = Color.White;
      this.Frame3.Location = new Point(248, 24);
      this.Frame3.Name = "Frame3";
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(247, 241);
      this.Frame3.TabIndex = 18;
      this.optYear.BackColor = Color.FromArgb(192, 192, 192);
      this.optYear.Checked = true;
      this.optYear.Cursor = Cursors.Default;
      this.optYear.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optYear.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.optYear.Location = new Point(32, 176);
      this.optYear.Name = "optYear";
      this.optYear.RightToLeft = RightToLeft.No;
      this.optYear.Size = new Size(177, 41);
      this.optYear.TabIndex = 21;
      this.optYear.TabStop = true;
      this.optYear.Text = "By Year";
      this.optYear.UseVisualStyleBackColor = false;
      this.optYear.CheckedChanged += new EventHandler(this.optYear_CheckedChanged);
      this.optMonth.BackColor = Color.FromArgb(192, 192, 192);
      this.optMonth.Cursor = Cursors.Default;
      this.optMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optMonth.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.optMonth.Location = new Point(32, 120);
      this.optMonth.Name = "optMonth";
      this.optMonth.RightToLeft = RightToLeft.No;
      this.optMonth.Size = new Size(177, 41);
      this.optMonth.TabIndex = 20;
      this.optMonth.Text = "By Month";
      this.optMonth.UseVisualStyleBackColor = false;
      this.optMonth.CheckedChanged += new EventHandler(this.optMonth_CheckedChanged);
      this.optDay.BackColor = Color.FromArgb(192, 192, 192);
      this.optDay.Cursor = Cursors.Default;
      this.optDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optDay.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.optDay.Location = new Point(32, 64);
      this.optDay.Name = "optDay";
      this.optDay.RightToLeft = RightToLeft.No;
      this.optDay.Size = new Size(177, 41);
      this.optDay.TabIndex = 19;
      this.optDay.Text = "By Date";
      this.optDay.UseVisualStyleBackColor = false;
      this.optDay.CheckedChanged += new EventHandler(this.optDay_CheckedChanged);
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(8, 0);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(233, 49);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Report Options";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this._optReport_15.BackColor = Color.Cyan;
      this._optReport_15.Cursor = Cursors.Default;
      this._optReport_15.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_15.ForeColor = SystemColors.ControlText;
      this._optReport_15.Location = new Point(216, 149);
      this._optReport_15.Name = "_optReport_15";
      this._optReport_15.RightToLeft = RightToLeft.No;
      this._optReport_15.Size = new Size(177, 49);
      this._optReport_15.TabIndex = 35;
      this._optReport_15.TabStop = true;
      this._optReport_15.Text = "GUEST MAILING LIST";
      this._optReport_15.UseVisualStyleBackColor = false;
      this._optReport_15.CheckedChanged += new EventHandler(this._optReport_15_CheckedChanged);
      this._optReport_16.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this._optReport_16.Cursor = Cursors.Default;
      this._optReport_16.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optReport_16.ForeColor = SystemColors.ControlText;
      this._optReport_16.Location = new Point(216, 88);
      this._optReport_16.Name = "_optReport_16";
      this._optReport_16.RightToLeft = RightToLeft.No;
      this._optReport_16.Size = new Size(177, 49);
      this._optReport_16.TabIndex = 45;
      this._optReport_16.TabStop = true;
      this._optReport_16.Text = "BONUS ENTITLE CHECK";
      this._optReport_16.UseVisualStyleBackColor = false;
      this._optReport_16.CheckedChanged += new EventHandler(this._optReport_16_CheckedChanged);
      this._optChoice_1.BackColor = SystemColors.Control;
      this._optChoice_1.Cursor = Cursors.Default;
      this._optChoice_1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optChoice_1.ForeColor = SystemColors.ControlText;
      this._optChoice_1.Location = new Point(112, 16);
      this._optChoice_1.Name = "_optChoice_1";
      this._optChoice_1.RightToLeft = RightToLeft.No;
      this._optChoice_1.Size = new Size(81, 33);
      this._optChoice_1.TabIndex = 43;
      this._optChoice_1.Text = "Individual";
      this._optChoice_1.UseVisualStyleBackColor = false;
      this._optChoice_1.CheckedChanged += new EventHandler(this._optChoice_1_CheckedChanged);
      this.ViewFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.ViewFrame.Controls.Add((Control) this._optRecordView_0);
      this.ViewFrame.Controls.Add((Control) this._optRecordView_1);
      this.ViewFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ViewFrame.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.ViewFrame.Location = new Point(9, 278);
      this.ViewFrame.Name = "ViewFrame";
      this.ViewFrame.Padding = new Padding(0);
      this.ViewFrame.RightToLeft = RightToLeft.No;
      this.ViewFrame.Size = new Size(185, 81);
      this.ViewFrame.TabIndex = 47;
      this.ViewFrame.TabStop = false;
      this.ViewFrame.Text = "Record View By";
      this._optRecordView_0.BackColor = Color.Cyan;
      this._optRecordView_0.Checked = true;
      this._optRecordView_0.Cursor = Cursors.Default;
      this._optRecordView_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optRecordView_0.ForeColor = SystemColors.ControlText;
      this._optRecordView_0.Location = new Point(16, 16);
      this._optRecordView_0.Name = "_optRecordView_0";
      this._optRecordView_0.RightToLeft = RightToLeft.No;
      this._optRecordView_0.Size = new Size(153, 25);
      this._optRecordView_0.TabIndex = 38;
      this._optRecordView_0.TabStop = true;
      this._optRecordView_0.Text = "By Unlock Date";
      this._optRecordView_0.UseVisualStyleBackColor = false;
      this._optRecordView_0.CheckedChanged += new EventHandler(this._optRecordView_0_CheckedChanged);
      this._optRecordView_1.BackColor = Color.Cyan;
      this._optRecordView_1.Cursor = Cursors.Default;
      this._optRecordView_1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optRecordView_1.ForeColor = SystemColors.ControlText;
      this._optRecordView_1.Location = new Point(16, 48);
      this._optRecordView_1.Name = "_optRecordView_1";
      this._optRecordView_1.RightToLeft = RightToLeft.No;
      this._optRecordView_1.Size = new Size(153, 25);
      this._optRecordView_1.TabIndex = 37;
      this._optRecordView_1.TabStop = true;
      this._optRecordView_1.Text = "By Collect Date";
      this._optRecordView_1.UseVisualStyleBackColor = false;
      this._optRecordView_1.CheckedChanged += new EventHandler(this._optRecordView_1_CheckedChanged);
      this.lblbldno.BackColor = Color.FromArgb(192, 192, 192);
      this.lblbldno.Cursor = Cursors.Default;
      this.lblbldno.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblbldno.ForeColor = Color.Blue;
      this.lblbldno.Location = new Point(8, 72);
      this.lblbldno.Name = "lblbldno";
      this.lblbldno.RightToLeft = RightToLeft.No;
      this.lblbldno.Size = new Size(113, 25);
      this.lblbldno.TabIndex = 40;
      this.lblbldno.Text = "Building No. ";
      this.Frame_All_Ind_Choice.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Frame_All_Ind_Choice.Controls.Add((Control) this.cboBldNo);
      this.Frame_All_Ind_Choice.Controls.Add((Control) this.Frame5);
      this.Frame_All_Ind_Choice.Controls.Add((Control) this.lblbldno);
      this.Frame_All_Ind_Choice.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame_All_Ind_Choice.ForeColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame_All_Ind_Choice.Location = new Point(84, 234);
      this.Frame_All_Ind_Choice.Name = "Frame_All_Ind_Choice";
      this.Frame_All_Ind_Choice.Padding = new Padding(0);
      this.Frame_All_Ind_Choice.RightToLeft = RightToLeft.No;
      this.Frame_All_Ind_Choice.Size = new Size(217, 105);
      this.Frame_All_Ind_Choice.TabIndex = 48;
      this.Frame_All_Ind_Choice.TabStop = false;
      this.cboBldNo.BackColor = Color.White;
      this.cboBldNo.Cursor = Cursors.Default;
      this.cboBldNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBldNo.ForeColor = Color.Blue;
      this.cboBldNo.Location = new Point(128, 72);
      this.cboBldNo.Name = "cboBldNo";
      this.cboBldNo.RightToLeft = RightToLeft.No;
      this.cboBldNo.Size = new Size(65, 29);
      this.cboBldNo.TabIndex = 44;
      this.Frame5.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.Frame5.Controls.Add((Control) this._optChoice_1);
      this.Frame5.Controls.Add((Control) this._optChoice_0);
      this.Frame5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame5.ForeColor = SystemColors.ControlText;
      this.Frame5.Location = new Point(8, 8);
      this.Frame5.Name = "Frame5";
      this.Frame5.Padding = new Padding(0);
      this.Frame5.RightToLeft = RightToLeft.No;
      this.Frame5.Size = new Size(201, 57);
      this.Frame5.TabIndex = 41;
      this.Frame5.TabStop = false;
      this.Frame5.Text = "Select Building :";
      this._optChoice_0.BackColor = SystemColors.Control;
      this._optChoice_0.Checked = true;
      this._optChoice_0.Cursor = Cursors.Default;
      this._optChoice_0.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optChoice_0.ForeColor = SystemColors.ControlText;
      this._optChoice_0.Location = new Point(8, 16);
      this._optChoice_0.Name = "_optChoice_0";
      this._optChoice_0.RightToLeft = RightToLeft.No;
      this._optChoice_0.Size = new Size(81, 33);
      this._optChoice_0.TabIndex = 42;
      this._optChoice_0.TabStop = true;
      this._optChoice_0.Text = "All";
      this._optChoice_0.UseVisualStyleBackColor = false;
      this._optChoice_0.CheckedChanged += new EventHandler(this._optChoice_0_CheckedChanged);
      this.cmdPrint.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(179, 498);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(129, 49);
      this.cmdPrint.TabIndex = 45;
      this.cmdPrint.Text = "&Print";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.lblMonth.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblMonth.Cursor = Cursors.Default;
      this.lblMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMonth.ForeColor = Color.White;
      this.lblMonth.Location = new Point(706, 229);
      this.lblMonth.Name = "lblMonth";
      this.lblMonth.RightToLeft = RightToLeft.No;
      this.lblMonth.Size = new Size(105, 33);
      this.lblMonth.TabIndex = 27;
      this.lblMonth.Text = "Month";
      this.lblMonth.Visible = false;
      this.cmdBack.BackColor = Color.Yellow;
      this.cmdBack.Cursor = Cursors.Default;
      this.cmdBack.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdBack.ForeColor = SystemColors.ControlText;
      this.cmdBack.Image = (Image) componentResourceManager.GetObject("cmdBack.Image");
      this.cmdBack.Location = new Point(315, 498);
      this.cmdBack.Name = "cmdBack";
      this.cmdBack.RightToLeft = RightToLeft.No;
      this.cmdBack.Size = new Size(129, 49);
      this.cmdBack.TabIndex = 44;
      this.cmdBack.Text = "&Back";
      this.cmdBack.TextAlign = ContentAlignment.BottomCenter;
      this.cmdBack.UseVisualStyleBackColor = false;
      this.cmdBack.Click += new EventHandler(this.cmdBack_Click);
      this.ReportFrame.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.ReportFrame.Controls.Add((Control) this._optReport_16);
      this.ReportFrame.Controls.Add((Control) this._optReport_15);
      this.ReportFrame.Controls.Add((Control) this._optReport_14);
      this.ReportFrame.Controls.Add((Control) this._optReport_13);
      this.ReportFrame.Controls.Add((Control) this._optReport_12);
      this.ReportFrame.Controls.Add((Control) this._optReport_11);
      this.ReportFrame.Controls.Add((Control) this._optReport_10);
      this.ReportFrame.Controls.Add((Control) this._optReport_9);
      this.ReportFrame.Controls.Add((Control) this._optReport_8);
      this.ReportFrame.Controls.Add((Control) this._optReport_7);
      this.ReportFrame.Controls.Add((Control) this._optReport_6);
      this.ReportFrame.Controls.Add((Control) this._optReport_5);
      this.ReportFrame.Controls.Add((Control) this._optReport_4);
      this.ReportFrame.Controls.Add((Control) this._optReport_3);
      this.ReportFrame.Controls.Add((Control) this._optReport_2);
      this.ReportFrame.Controls.Add((Control) this._optReport_1);
      this.ReportFrame.Controls.Add((Control) this._optReport_0);
      this.ReportFrame.Font = new Font("Times New Roman", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ReportFrame.ForeColor = Color.Blue;
      this.ReportFrame.Location = new Point(91, 90);
      this.ReportFrame.Name = "ReportFrame";
      this.ReportFrame.Padding = new Padding(0);
      this.ReportFrame.RightToLeft = RightToLeft.No;
      this.ReportFrame.Size = new Size(609, 401);
      this.ReportFrame.TabIndex = 40;
      this.ReportFrame.TabStop = false;
      this.ReportFrame.Text = "SELECT  REPORT NAME :";
      this.lblYear.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblYear.Cursor = Cursors.Default;
      this.lblYear.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblYear.ForeColor = Color.White;
      this.lblYear.Location = new Point(706, 165);
      this.lblYear.Name = "lblYear";
      this.lblYear.RightToLeft = RightToLeft.No;
      this.lblYear.Size = new Size(65, 33);
      this.lblYear.TabIndex = 26;
      this.lblYear.Text = "Year";
      this.lblYear.Visible = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(451, 498);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(129, 49);
      this.cmdReturn.TabIndex = 43;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.DMYFrame.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.DMYFrame.Controls.Add((Control) this.dateTimePicker_ReportCalendar);
      this.DMYFrame.Controls.Add((Control) this.Frame3);
      this.DMYFrame.Cursor = Cursors.Default;
      this.DMYFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DMYFrame.ForeColor = Color.White;
      this.DMYFrame.Location = new Point(115, 90);
      this.DMYFrame.Name = "DMYFrame";
      this.DMYFrame.RightToLeft = RightToLeft.No;
      this.DMYFrame.Size = new Size(536, 302);
      this.DMYFrame.TabIndex = 42;
      this.DMYFrame.Text = "Machine Data";
      this.dateTimePicker_ReportCalendar.Checked = false;
      this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy";
      this.dateTimePicker_ReportCalendar.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_ReportCalendar.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_ReportCalendar.Location = new Point(25, 53);
      this.dateTimePicker_ReportCalendar.Name = "dateTimePicker_ReportCalendar";
      this.dateTimePicker_ReportCalendar.Size = new Size(200, 29);
      this.dateTimePicker_ReportCalendar.TabIndex = 165;
      this.dateTimePicker_cboYear.Checked = false;
      this.dateTimePicker_cboYear.CustomFormat = "yyyy";
      this.dateTimePicker_cboYear.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_cboYear.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_cboYear.Location = new Point(706, 201);
      this.dateTimePicker_cboYear.Name = "dateTimePicker_cboYear";
      this.dateTimePicker_cboYear.ShowUpDown = true;
      this.dateTimePicker_cboYear.Size = new Size(84, 29);
      this.dateTimePicker_cboYear.TabIndex = 166;
      this.dateTimePicker_cboYear.Visible = false;
      this.dateTimePicker_cboMonth.Checked = false;
      this.dateTimePicker_cboMonth.CustomFormat = "MMMM";
      this.dateTimePicker_cboMonth.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_cboMonth.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_cboMonth.Location = new Point(706, 265);
      this.dateTimePicker_cboMonth.Name = "dateTimePicker_cboMonth";
      this.dateTimePicker_cboMonth.ShowUpDown = true;
      this.dateTimePicker_cboMonth.Size = new Size(84, 29);
      this.dateTimePicker_cboMonth.TabIndex = 167;
      this.dateTimePicker_cboMonth.Visible = false;
      this.dateTimePicker_cboDay.Checked = false;
      this.dateTimePicker_cboDay.CustomFormat = "dd";
      this.dateTimePicker_cboDay.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_cboDay.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_cboDay.Location = new Point(703, 330);
      this.dateTimePicker_cboDay.Name = "dateTimePicker_cboDay";
      this.dateTimePicker_cboDay.ShowUpDown = true;
      this.dateTimePicker_cboDay.Size = new Size(84, 29);
      this.dateTimePicker_cboDay.TabIndex = 168;
      this.dateTimePicker_cboDay.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(799, 574);
      this.Controls.Add((Control) this.dateTimePicker_cboDay);
      this.Controls.Add((Control) this.cboBuildingNo);
      this.Controls.Add((Control) this.ViewFrame);
      this.Controls.Add((Control) this.dateTimePicker_cboMonth);
      this.Controls.Add((Control) this.Frame_All_Ind_Choice);
      this.Controls.Add((Control) this.dateTimePicker_cboYear);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.lblReportName);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.cmdBack);
      this.Controls.Add((Control) this.lblDay);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.lblMonth);
      this.Controls.Add((Control) this.lblYear);
      this.Controls.Add((Control) this.DMYFrame);
      this.Controls.Add((Control) this.ReportFrame);
      this.Name = "Form_OtherReportsDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_OtherReportsDMS_Load);
      this.Shown += new EventHandler(this.Form_OtherReportsDMS_Shown);
      this.VisibleChanged += new EventHandler(this.Form_OtherReportsDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_OtherReportsDMS_FormClosing);
      this.Frame3.ResumeLayout(false);
      this.ViewFrame.ResumeLayout(false);
      this.Frame_All_Ind_Choice.ResumeLayout(false);
      this.Frame5.ResumeLayout(false);
      this.ReportFrame.ResumeLayout(false);
      this.DMYFrame.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Form_OtherReportsDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 7)
        ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
      else
        ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
    }

    private void Form_OtherReportsDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void DMYSelection()
    {
      DateTimePicker dateTimePicker = new DateTimePicker();
      dateTimePicker.Format = DateTimePickerFormat.Custom;
      dateTimePicker.CustomFormat = "MM/dd/yyyy";
      if (this.optDay.Checked)
      {
        Global_Data.iPrint = (short) 1;
        this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy MMMM dd";
        this.dateTimePicker_ReportCalendar.ShowUpDown = false;
        dateTimePicker.Value = DateTime.Parse(this.dateTimePicker_ReportCalendar.Text);
        Global_Data.sRDate = dateTimePicker.Value.ToShortDateString();
        this.dateTimePicker_ReportCalendar.Size = new Size(200, 35);
        this.dateTimePicker_ReportCalendar.Focus();
      }
      else if (this.optMonth.Checked)
      {
        Global_Data.iPrint = (short) 2;
        this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy MMMM";
        this.dateTimePicker_ReportCalendar.ShowUpDown = true;
        this.dateTimePicker_ReportCalendar.Value = this.dateTimePicker_ReportCalendar.Value.AddDays((double) (-this.dateTimePicker_ReportCalendar.Value.Day + 1));
        this.dateTimePicker_ReportCalendar.Size = new Size(180, 35);
        this.dateTimePicker_ReportCalendar.Focus();
        dateTimePicker.Value = this.dateTimePicker_ReportCalendar.Value.AddDays((double) (-this.dateTimePicker_ReportCalendar.Value.Day + 1));
        Global_Data.sSDate = dateTimePicker.Value.ToShortDateString();
        dateTimePicker.Value = this.dateTimePicker_ReportCalendar.Value.AddDays((double) (-this.dateTimePicker_ReportCalendar.Value.Day + DateTime.DaysInMonth(this.dateTimePicker_ReportCalendar.Value.Year, this.dateTimePicker_ReportCalendar.Value.Month)));
        Global_Data.sEDate = dateTimePicker.Value.ToShortDateString();
      }
      else
      {
        if (!this.optYear.Checked)
          return;
        Global_Data.iPrint = (short) 3;
        this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy";
        this.dateTimePicker_ReportCalendar.ShowUpDown = true;
        this.dateTimePicker_ReportCalendar.Size = new Size(100, 35);
        this.dateTimePicker_ReportCalendar.Focus();
        Global_Data.sRYear = this.dateTimePicker_ReportCalendar.Value.Year.ToString();
      }
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo = (string) this.cboBldNo.SelectedItem;
      this.Check_All_or_Individual();
      this.DMYSelection();
      Global_Data.ReportCalendar_Text = this.dateTimePicker_ReportCalendar.Text;
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType < 4)
      {
        if (this._optReport_1.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          AccGuestList_ReportClass guestListReportClass = new AccGuestList_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) guestListReportClass.CHECK_GUESTLIST(Global_Data.bCurrent);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_2.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          AccGuestAccount_ReportClass accountReportClass = new AccGuestAccount_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) accountReportClass.CHECK_GUESTACCOUNT(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_3.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          AccGuestRecordDate_ReportClass recordDateReportClass = new AccGuestRecordDate_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) recordDateReportClass.CHECK_GUESTRECORDDATE(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_7.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          LossCard_ReportClass lossCardReportClass = new LossCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) lossCardReportClass.CHECK_LOSSCARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_8.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          ExtraCard_ReportClass extraCardReportClass = new ExtraCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) extraCardReportClass.CHECK_EXTRACARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_9.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          AccGracePeriodList_ReportClass periodListReportClass = new AccGracePeriodList_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) periodListReportClass.CHECK_GRACEPERIODLIST(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_11.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          RecycleCard_ReportClass recycleCardReportClass = new RecycleCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) recycleCardReportClass.CHECK_RECYCLECARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_12.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          CancelCard_ReportClass cancelCardReportClass = new CancelCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) cancelCardReportClass.CHECK_CANCELCARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_13.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          EmergencyCard_ReportClass emergencyCardReportClass = new EmergencyCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) emergencyCardReportClass.CHECK_EMERGENCYCARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_14.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          CancelWoCard_ReportClass woCardReportClass = new CancelWoCard_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) woCardReportClass.CHECK_CANCELWITHOUTCARD(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text, Global_Data.sBldNo);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_15.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          MailingList_ReportClass mailingListReportClass = new MailingList_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) mailingListReportClass.CHECK_MAILINGLIST(Global_Data.bCurrent);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_16.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ReportForm reportForm = new ReportForm();
          AccBonusEntitle_ReportClass entitleReportClass = new AccBonusEntitle_ReportClass();
          reportForm.crystalReportViewer1.ReportSource = (object) entitleReportClass.CHECK_ENTITLEBONUS(Global_Data.bCurrent);
          int num = (int) reportForm.ShowDialog();
        }
        else if (this._optReport_0.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ModDoorLockSystem.Form_SearchReportDMS_Ptr.Show((IWin32Window) this);
          this.Visible = false;
        }
        else if (this._optReport_4.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ModDoorLockSystem.Form_SearchReportDMS_Ptr.Show((IWin32Window) this);
          this.Visible = false;
        }
        else if (this._optReport_5.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ModDoorLockSystem.Form_SearchReportDMS_Ptr.Show((IWin32Window) this);
          this.Visible = false;
        }
        else if (this._optReport_6.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          this.Check_Record_View();
          ModDoorLockSystem.Form_SearchReportDMS_Ptr.Show((IWin32Window) this);
          this.Visible = false;
        }
        else if (this._optReport_10.Checked)
        {
          this.Check_All_or_Individual();
          Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
          ModDoorLockSystem.Form_SearchReportDMS_Ptr.Show((IWin32Window) this);
          this.Visible = false;
        }
        else
        {
          int num1 = (int) MessageBox.Show("Not Implemented!");
        }
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 4)
      {
        this.Check_All_or_Individual();
        Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
        this.cmdBack.Enabled = false;
        ReportForm reportForm = new ReportForm();
        ReportClass_ReservationList classReservationList = new ReportClass_ReservationList();
        reportForm.crystalReportViewer1.ReportSource = (object) classReservationList.CHECK_RESERVATIONLIST(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
        int num2 = (int) reportForm.ShowDialog();
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 5)
      {
        this.Check_All_or_Individual();
        Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
        this.cmdBack.Enabled = false;
        ReportForm reportForm = new ReportForm();
        ReportClass_RoomDetail reportClassRoomDetail = new ReportClass_RoomDetail();
        reportForm.crystalReportViewer1.ReportSource = (object) reportClassRoomDetail.CHECK_ORROOMSDETAIL(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
        int num3 = (int) reportForm.ShowDialog();
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 7)
      {
        this.Check_All_or_Individual();
        Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
        this.cmdBack.Enabled = false;
        ReportForm reportForm = new ReportForm();
        ReportClass_IssueCardHistory issueCardHistory = new ReportClass_IssueCardHistory();
        reportForm.crystalReportViewer1.ReportSource = (object) issueCardHistory.CHECK_ISSUECARDHISTORY(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
        int num4 = (int) reportForm.ShowDialog();
      }
      else
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType != 6)
          return;
        this.Check_All_or_Individual();
        Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBldNo.Text);
        this.cmdBack.Enabled = false;
        ReportForm reportForm = new ReportForm();
        ReportClass_RoomInformation classRoomInformation = new ReportClass_RoomInformation();
        reportForm.crystalReportViewer1.ReportSource = (object) classRoomInformation.CHECK_ROOMINFORMATION(Global_Data.bCurrent);
        int num5 = (int) reportForm.ShowDialog();
      }
    }

    private void Check_All_or_Individual()
    {
      if (this._optChoice_0.Checked)
        Global_Data.bCurrent = false;
      else
        Global_Data.bCurrent = true;
    }

    private void _optChoice_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_All_or_Individual();
    }

    private void _optChoice_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_All_or_Individual();
    }

    private void Form_OtherReportsDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBldNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.CheckBuilding(this.cboBuildingNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.optMonth.Checked = true;
      Global_Data.iPrint = (short) 2;
      this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy MMMM";
      this.dateTimePicker_ReportCalendar.ShowUpDown = false;
      this.dateTimePicker_ReportCalendar.Size = new Size(180, 35);
      this.dateTimePicker_ReportCalendar.Focus();
    }

    private void Change_Frame_All_Ind_Choice_Location(int para_x, int para_y)
    {
      this.Frame_All_Ind_Choice.Location = new Point(para_x, para_y);
    }

    private void Change_ViewFrame_Location(int para_x, int para_y)
    {
      this.ViewFrame.Location = new Point(para_x, para_y);
    }

    private void optYear_CheckedChanged(object sender, EventArgs e) => this.DMYSelection();

    private void optMonth_CheckedChanged(object sender, EventArgs e) => this.DMYSelection();

    private void optDay_CheckedChanged(object sender, EventArgs e) => this.DMYSelection();

    private void Check_For_Initialize()
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType < 4)
      {
        this.DMYFrame.Visible = false;
        this.ReportFrame.Visible = true;
        this.Frame_All_Ind_Choice.Visible = false;
        this.ViewFrame.Visible = false;
        this.Disable_All_optReport_RadioButtons();
        this.DMYSelection();
        this.lblReportName.Visible = false;
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 4 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 5 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 7)
      {
        this.cboBuildingNo.Visible = false;
        this.Label3.Visible = false;
        this.DMYFrame.Visible = true;
        this.dateTimePicker_ReportCalendar.Visible = true;
        this.Hide_All_optReport_RadioButtons();
        this.cmdPrint.Enabled = true;
        this.cmdBack.Enabled = false;
        this.ReportFrame.Visible = false;
        this.DMYFrame.Visible = true;
        this.ViewFrame.Visible = false;
        this.Frame_All_Ind_Choice.Visible = false;
        this.Frame5.Visible = true;
        this._optChoice_0.Checked = false;
        this._optChoice_1.Checked = true;
        Global_Data.bCurrent = true;
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 4)
        {
          this.lblReportName.Visible = true;
          this.lblReportName.Text = "Reservation List";
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 5)
        {
          this.lblReportName.Visible = true;
          this.lblReportName.Text = "Room Details";
        }
        else
        {
          if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType != 7)
            return;
          this.lblReportName.Visible = true;
          this.lblReportName.Text = "Issued Card History";
        }
      }
      else
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType != 6)
          return;
        this.cboBuildingNo.Visible = false;
        this.Label3.Visible = false;
        this.Hide_All_optReport_RadioButtons();
        this.ReportFrame.Visible = false;
        this.DMYFrame.Visible = false;
        this.Frame_All_Ind_Choice.Visible = false;
        this.Frame5.Visible = true;
        this.cboBldNo.Visible = false;
        this.lblbldno.Visible = false;
        this._optChoice_0.Checked = false;
        this._optChoice_1.Checked = true;
        Global_Data.bCurrent = true;
        this.ViewFrame.Visible = false;
        this.cmdBack.Enabled = false;
        this.lblReportName.Visible = true;
        this.lblReportName.Text = "Room Information";
      }
    }

    private void Form_OtherReportsDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Check_For_Initialize();
    }

    private void cmdBack_Click(object sender, EventArgs e)
    {
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = true;
      this.Frame_All_Ind_Choice.Visible = false;
      this.ViewFrame.Visible = false;
      this.Disable_All_optReport_RadioButtons();
      this.DMYSelection();
    }

    private void Hide_All_optReport_RadioButtons()
    {
      this._optReport_0.Visible = false;
      this._optReport_1.Visible = false;
      this._optReport_2.Visible = false;
      this._optReport_3.Visible = false;
      this._optReport_4.Visible = false;
      this._optReport_5.Visible = false;
      this._optReport_6.Visible = false;
      this._optReport_7.Visible = false;
      this._optReport_8.Visible = false;
      this._optReport_9.Visible = false;
      this._optReport_10.Visible = false;
      this._optReport_11.Visible = false;
      this._optReport_12.Visible = false;
      this._optReport_13.Visible = false;
      this._optReport_14.Visible = false;
      this._optReport_15.Visible = false;
      this._optReport_16.Visible = false;
      this._optReport_0.Checked = false;
      this._optReport_1.Checked = false;
      this._optReport_2.Checked = false;
      this._optReport_3.Checked = false;
      this._optReport_4.Checked = false;
      this._optReport_5.Checked = false;
      this._optReport_6.Checked = false;
      this._optReport_7.Checked = false;
      this._optReport_8.Checked = false;
      this._optReport_9.Checked = false;
      this._optReport_10.Checked = false;
      this._optReport_11.Checked = false;
      this._optReport_12.Checked = false;
      this._optReport_13.Checked = false;
      this._optReport_14.Checked = false;
      this._optReport_15.Checked = false;
      this._optReport_16.Checked = false;
    }

    private void Disable_All_optReport_RadioButtons()
    {
      this._optReport_0.Visible = true;
      this._optReport_1.Visible = true;
      this._optReport_2.Visible = true;
      this._optReport_3.Visible = true;
      this._optReport_4.Visible = true;
      this._optReport_5.Visible = true;
      this._optReport_6.Visible = true;
      this._optReport_7.Visible = true;
      this._optReport_8.Visible = true;
      this._optReport_9.Visible = true;
      this._optReport_10.Visible = true;
      this._optReport_11.Visible = true;
      this._optReport_12.Visible = true;
      this._optReport_13.Visible = true;
      this._optReport_14.Visible = true;
      this._optReport_15.Visible = true;
      this._optReport_16.Visible = true;
      this._optReport_0.Checked = false;
      this._optReport_1.Checked = false;
      this._optReport_2.Checked = false;
      this._optReport_3.Checked = false;
      this._optReport_4.Checked = false;
      this._optReport_5.Checked = false;
      this._optReport_6.Checked = false;
      this._optReport_7.Checked = false;
      this._optReport_8.Checked = false;
      this._optReport_9.Checked = false;
      this._optReport_10.Checked = false;
      this._optReport_11.Checked = false;
      this._optReport_12.Checked = false;
      this._optReport_13.Checked = false;
      this._optReport_14.Checked = false;
      this._optReport_15.Checked = false;
      this._optReport_16.Checked = false;
    }

    private void Form_OtherReportsDMS_Shown(object sender, EventArgs e)
    {
      this.Check_For_Initialize();
    }

    private void _optReport_0_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_0.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = false;
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 0;
    }

    private void _optReport_1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_1.Checked)
        return;
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = true;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 1;
    }

    private void _optReport_2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_2.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = true;
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 2;
    }

    private void _optReport_3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_3.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = true;
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 3;
    }

    private void _optReport_4_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_4.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = false;
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 4;
    }

    private void _optReport_5_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_5.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = false;
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 5;
    }

    private void _optReport_6_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_6.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(this.DMYFrame.Location.X + 8, 234);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Change_ViewFrame_Location(this.DMYFrame.Location.X + 8, this.ViewFrame.Location.Y);
      this.ViewFrame.Visible = true;
      Global_Data.iReport = (short) 6;
    }

    private void _optReport_7_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_7.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 7;
    }

    private void _optReport_8_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_8.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 8;
    }

    private void _optReport_9_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_9.Checked)
        return;
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = true;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 9;
    }

    private void _optReport_10_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_10.Checked)
        return;
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = true;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
      Global_Data.iReport = (short) 10;
    }

    private void _optReport_11_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_11.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void _optReport_12_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_12.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void _optReport_13_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_13.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void _optReport_14_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_14.Checked)
        return;
      this.DMYFrame.Visible = true;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = false;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void _optReport_15_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_15.Checked)
        return;
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = true;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void _optReport_16_CheckedChanged(object sender, EventArgs e)
    {
      if (!this._optReport_16.Checked)
        return;
      this.DMYFrame.Visible = false;
      this.ReportFrame.Visible = false;
      this.Change_Frame_All_Ind_Choice_Location(280, 200);
      this.Frame_All_Ind_Choice.Visible = true;
      this.Frame_All_Ind_Choice.BringToFront();
      this.ViewFrame.Visible = false;
    }

    private void Check_Record_View()
    {
      if (this._optRecordView_0.Checked)
      {
        Global_Data.iView = 1;
      }
      else
      {
        if (!this._optRecordView_1.Checked)
          return;
        Global_Data.iView = 2;
      }
    }

    private void _optRecordView_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Record_View();
    }

    private void _optRecordView_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Record_View();
    }
  }
}
