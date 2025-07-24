// Decompiled with JetBrains decompiler
// Type: AMS.Form_LogReportDMS
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
  public class Form_LogReportDMS : Form
  {
    private IContainer components;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public ComboBox cboBuilding;
    public Button cmdGenerate;
    public ComboBox cboMonth;
    public ComboBox cboDay;
    public Label lbBuilding;
    public Label Label3;
    public Label lblMonth;
    public Label lblDay;
    public Label Label5;
    public Label Label1;
    public RadioButton optDay;
    public GroupBox Frame8;
    public Panel Frame3;
    public RadioButton optMonth;
    public Label Label2;
    public Label Label4;
    public Panel Frame2;
    private DateTimePicker dateTimePicker_ReportCalendar;
    public ComboBox cboYear;
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
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdReturn = new Button();
      this.cboBuilding = new ComboBox();
      this.cmdGenerate = new Button();
      this.cboMonth = new ComboBox();
      this.cboDay = new ComboBox();
      this.lbBuilding = new Label();
      this.Label3 = new Label();
      this.lblMonth = new Label();
      this.lblDay = new Label();
      this.Label5 = new Label();
      this.Label1 = new Label();
      this.optDay = new RadioButton();
      this.Frame8 = new GroupBox();
      this.Frame3 = new Panel();
      this.optMonth = new RadioButton();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Frame2 = new Panel();
      this.cboYear = new ComboBox();
      this.dateTimePicker_ReportCalendar = new DateTimePicker();
      this.Frame8.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      this.cmdReturn.BackColor = SystemColors.Control;
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Location = new Point(240, 24);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(164, 57);
      this.cmdReturn.TabIndex = 9;
      this.cmdReturn.Text = "RETUR&N";
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cboBuilding.BackColor = SystemColors.Window;
      this.cboBuilding.Cursor = Cursors.Default;
      this.cboBuilding.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuilding.ForeColor = Color.Blue;
      this.cboBuilding.Location = new Point(36, 378);
      this.cboBuilding.Name = "cboBuilding";
      this.cboBuilding.RightToLeft = RightToLeft.No;
      this.cboBuilding.Size = new Size(49, 27);
      this.cboBuilding.TabIndex = 17;
      this.ToolTip1.SetToolTip((Control) this.cboBuilding, "Select Building");
      this.cboBuilding.Visible = false;
      this.cmdGenerate.BackColor = SystemColors.Control;
      this.cmdGenerate.Cursor = Cursors.Default;
      this.cmdGenerate.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdGenerate.ForeColor = SystemColors.ControlText;
      this.cmdGenerate.Location = new Point(37, 24);
      this.cmdGenerate.Name = "cmdGenerate";
      this.cmdGenerate.RightToLeft = RightToLeft.No;
      this.cmdGenerate.Size = new Size(164, 57);
      this.cmdGenerate.TabIndex = 8;
      this.cmdGenerate.Text = "&GENERATE";
      this.ToolTip1.SetToolTip((Control) this.cmdGenerate, "View Report");
      this.cmdGenerate.UseVisualStyleBackColor = false;
      this.cmdGenerate.Click += new EventHandler(this.cmdGenerate_Click);
      this.cboMonth.BackColor = SystemColors.Window;
      this.cboMonth.Cursor = Cursors.Default;
      this.cboMonth.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboMonth.ForeColor = SystemColors.WindowText;
      this.cboMonth.Location = new Point(36, 202);
      this.cboMonth.Name = "cboMonth";
      this.cboMonth.RightToLeft = RightToLeft.No;
      this.cboMonth.Size = new Size(137, 29);
      this.cboMonth.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.cboMonth, "To Select Month");
      this.cboMonth.Visible = false;
      this.cboDay.BackColor = SystemColors.Window;
      this.cboDay.Cursor = Cursors.Default;
      this.cboDay.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboDay.ForeColor = SystemColors.WindowText;
      this.cboDay.Location = new Point(35, 282);
      this.cboDay.Name = "cboDay";
      this.cboDay.RightToLeft = RightToLeft.No;
      this.cboDay.Size = new Size(89, 29);
      this.cboDay.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.cboDay, "To Select Day");
      this.cboDay.Visible = false;
      this.lbBuilding.BackColor = Color.FromArgb(0, 128, 0);
      this.lbBuilding.Cursor = Cursors.Default;
      this.lbBuilding.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbBuilding.ForeColor = Color.Black;
      this.lbBuilding.Location = new Point(12, 330);
      this.lbBuilding.Name = "lbBuilding";
      this.lbBuilding.RightToLeft = RightToLeft.No;
      this.lbBuilding.Size = new Size(97, 33);
      this.lbBuilding.TabIndex = 18;
      this.lbBuilding.Text = "Building No.";
      this.lbBuilding.TextAlign = ContentAlignment.TopRight;
      this.lbBuilding.Visible = false;
      this.Label3.BackColor = Color.FromArgb(0, 128, 0);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(36, 106);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(65, 33);
      this.Label3.TabIndex = 15;
      this.Label3.Text = "Year";
      this.Label3.Visible = false;
      this.lblMonth.BackColor = Color.FromArgb(0, 128, 0);
      this.lblMonth.Cursor = Cursors.Default;
      this.lblMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMonth.ForeColor = Color.White;
      this.lblMonth.Location = new Point(36, 170);
      this.lblMonth.Name = "lblMonth";
      this.lblMonth.RightToLeft = RightToLeft.No;
      this.lblMonth.Size = new Size(105, 33);
      this.lblMonth.TabIndex = 11;
      this.lblMonth.Text = "Month";
      this.lblMonth.Visible = false;
      this.lblDay.BackColor = Color.FromArgb(0, 128, 0);
      this.lblDay.Cursor = Cursors.Default;
      this.lblDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDay.ForeColor = Color.White;
      this.lblDay.Location = new Point(36, 250);
      this.lblDay.Name = "lblDay";
      this.lblDay.RightToLeft = RightToLeft.No;
      this.lblDay.Size = new Size(65, 33);
      this.lblDay.TabIndex = 10;
      this.lblDay.Text = "Day";
      this.lblDay.Visible = false;
      this.Label5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(0, 128, 0);
      this.Label5.Location = new Point(132, 58);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(519, 47);
      this.Label5.TabIndex = 18;
      this.Label5.Text = "LogIn/Out  Report";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label1.BorderStyle = BorderStyle.Fixed3D;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(588, 1);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(193, 49);
      this.Label1.TabIndex = 19;
      this.Label1.Text = "Admin Mode";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.optDay.BackColor = Color.FromArgb(0, 128, 0);
      this.optDay.Checked = true;
      this.optDay.Cursor = Cursors.Default;
      this.optDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optDay.ForeColor = Color.Yellow;
      this.optDay.Location = new Point(32, 136);
      this.optDay.Name = "optDay";
      this.optDay.RightToLeft = RightToLeft.No;
      this.optDay.Size = new Size(177, 41);
      this.optDay.TabIndex = 5;
      this.optDay.TabStop = true;
      this.optDay.Text = "By Date";
      this.optDay.UseVisualStyleBackColor = false;
      this.optDay.CheckedChanged += new EventHandler(this.optDay_CheckedChanged);
      this.Frame8.BackColor = Color.FromArgb(0, 128, 0);
      this.Frame8.Controls.Add((Control) this.cmdReturn);
      this.Frame8.Controls.Add((Control) this.cmdGenerate);
      this.Frame8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame8.ForeColor = SystemColors.ControlText;
      this.Frame8.Location = new Point(40, 264);
      this.Frame8.Name = "Frame8";
      this.Frame8.Padding = new Padding(0);
      this.Frame8.RightToLeft = RightToLeft.No;
      this.Frame8.Size = new Size(441, 99);
      this.Frame8.TabIndex = 7;
      this.Frame8.TabStop = false;
      this.Frame3.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame3.Controls.Add((Control) this.optDay);
      this.Frame3.Controls.Add((Control) this.optMonth);
      this.Frame3.Controls.Add((Control) this.Label2);
      this.Frame3.Cursor = Cursors.Default;
      this.Frame3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = Color.White;
      this.Frame3.Location = new Point(232, 24);
      this.Frame3.Name = "Frame3";
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(247, 225);
      this.Frame3.TabIndex = 3;
      this.optMonth.BackColor = Color.FromArgb(0, 128, 0);
      this.optMonth.Cursor = Cursors.Default;
      this.optMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optMonth.ForeColor = Color.Yellow;
      this.optMonth.Location = new Point(32, 80);
      this.optMonth.Name = "optMonth";
      this.optMonth.RightToLeft = RightToLeft.No;
      this.optMonth.Size = new Size(177, 41);
      this.optMonth.TabIndex = 4;
      this.optMonth.TabStop = true;
      this.optMonth.Text = "By Month";
      this.optMonth.UseVisualStyleBackColor = false;
      this.optMonth.CheckedChanged += new EventHandler(this.optMonth_CheckedChanged);
      this.Label2.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(8, 8);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(233, 49);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "Report Options";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label4.Location = new Point(-4, 1);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(809, 49);
      this.Label4.TabIndex = 20;
      this.Label4.TextAlign = ContentAlignment.TopCenter;
      this.Frame2.BackColor = Color.FromArgb(0, 128, 0);
      this.Frame2.Controls.Add((Control) this.dateTimePicker_ReportCalendar);
      this.Frame2.Controls.Add((Control) this.Frame8);
      this.Frame2.Controls.Add((Control) this.Frame3);
      this.Frame2.Cursor = Cursors.Default;
      this.Frame2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = Color.White;
      this.Frame2.Location = new Point(132, 114);
      this.Frame2.Name = "Frame2";
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(521, 384);
      this.Frame2.TabIndex = 17;
      this.Frame2.Text = "Machine Data";
      this.cboYear.BackColor = SystemColors.Window;
      this.cboYear.Cursor = Cursors.Default;
      this.cboYear.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboYear.ForeColor = SystemColors.WindowText;
      this.cboYear.Location = new Point(36, 138);
      this.cboYear.Name = "cboYear";
      this.cboYear.RightToLeft = RightToLeft.No;
      this.cboYear.Size = new Size(89, 29);
      this.cboYear.TabIndex = 14;
      this.ToolTip1.SetToolTip((Control) this.cboYear, "To Select Year");
      this.cboYear.Visible = false;
      this.dateTimePicker_ReportCalendar.Checked = false;
      this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy";
      this.dateTimePicker_ReportCalendar.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_ReportCalendar.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_ReportCalendar.Location = new Point(15, 60);
      this.dateTimePicker_ReportCalendar.Name = "dateTimePicker_ReportCalendar";
      this.dateTimePicker_ReportCalendar.Size = new Size(200, 29);
      this.dateTimePicker_ReportCalendar.TabIndex = 166;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(799, 578);
      this.Controls.Add((Control) this.cboBuilding);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.cboYear);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Frame2);
      this.Controls.Add((Control) this.cboMonth);
      this.Controls.Add((Control) this.lbBuilding);
      this.Controls.Add((Control) this.cboDay);
      this.Controls.Add((Control) this.lblDay);
      this.Controls.Add((Control) this.lblMonth);
      this.Controls.Add((Control) this.Label3);
      this.Name = "Form_LogReportDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_LogReportDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_LogReportDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_LogReportDMS_FormClosing);
      this.Frame8.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Form_LogReportDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_LogReportDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_LogReportDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBuilding, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.optMonth.Checked = true;
      Global_Data.iPrint = (short) 2;
      this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy MMMM";
      this.dateTimePicker_ReportCalendar.ShowUpDown = false;
      this.dateTimePicker_ReportCalendar.Focus();
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
        this.dateTimePicker_ReportCalendar.Size = new Size(200, 35);
        this.dateTimePicker_ReportCalendar.Focus();
        dateTimePicker.Update();
        Global_Data.sRDate = dateTimePicker.Value.ToShortDateString();
      }
      else
      {
        if (!this.optMonth.Checked)
          return;
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
    }

    private void optMonth_CheckedChanged(object sender, EventArgs e) => this.DMYSelection();

    private void optDay_CheckedChanged(object sender, EventArgs e) => this.DMYSelection();

    private void cmdGenerate_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo = (string) this.cboBuilding.SelectedItem;
      this.DMYSelection();
      Global_Data.ReportCalendar_Text = this.dateTimePicker_ReportCalendar.Text;
      ReportForm reportForm = new ReportForm();
      if (Global_Data.iPrint == (short) 1)
      {
        ReportClass_LogInOut_Dlog classLogInOutDlog = new ReportClass_LogInOut_Dlog();
        reportForm.crystalReportViewer1.ReportSource = (object) classLogInOutDlog.CHECK_LOG_DAILY(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
      }
      else
      {
        ReportClass_LogInOut_Mlog classLogInOutMlog = new ReportClass_LogInOut_Mlog();
        reportForm.crystalReportViewer1.ReportSource = (object) classLogInOutMlog.CHECK_LOG_MONTHLY(Global_Data.bCurrent, this.dateTimePicker_ReportCalendar.Text);
      }
      int num = (int) reportForm.ShowDialog();
    }

    private void Form_LogReportDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.DMYSelection();
    }
  }
}
