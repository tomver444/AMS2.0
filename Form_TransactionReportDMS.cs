// Decompiled with JetBrains decompiler
// Type: AMS.Form_TransactionReportDMS
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
  public class Form_TransactionReportDMS : Form
  {
    private DB db;
    public string start_Date = "";
    public string End_date = "";
    private IContainer components;
    public ComboBox cboDay;
    public Label Label2;
    public GroupBox Frame8;
    public Button cmdGenerate;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public RadioButton optYear;
    public RadioButton optMonth;
    public RadioButton optDay;
    public ComboBox cboYear;
    public ComboBox cboBuildingNo1;
    public ComboBox cboMonth;
    public GroupBox SortFrame;
    public RadioButton _optRecordSort_1;
    public RadioButton _optRecordSort_0;
    public Panel Frame3;
    public RadioButton optRange;
    public Label lblDay;
    public Label lblMonth;
    public Label lblYear;
    public Label Label5;
    public Label _Label1_1;
    public Label Label3;
    public Label lblBuildingNo1;
    public RadioButton _optCurrent_1;
    public RadioButton _optCurrent_0;
    public Panel Frame2;
    public GroupBox DateRangeFrame;
    public Label lblMessage;
    public Label Label4;
    public Label _Label1_0;
    public GroupBox ChoiceFrame;
    public RadioButton _optChoice_1;
    public RadioButton _optChoice_0;
    public GroupBox BuildingFrame;
    public Panel CurrentFrame;
    private DateTimePicker dateTimePicker_mskEndDate;
    private DateTimePicker dateTimePicker_mskStartDate;
    public Label label_Progress;
    private DateTimePicker dateTimePicker_ReportCalendar;

    public Form_TransactionReportDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    public Form_TransactionReportDMS(bool bool_Sort_RoomNo)
    {
      this.InitializeComponent();
      this.db = new DB();
      if (bool_Sort_RoomNo)
      {
        this._optRecordSort_0.Checked = false;
        this._optRecordSort_1.Checked = true;
      }
      else
      {
        this._optRecordSort_0.Checked = true;
        this._optRecordSort_1.Checked = false;
      }
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 10)
        ModDoorLockSystem.Form_EditDMS_Ptr.Visible = true;
      else
        ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
      this.Close();
    }

    private void Form_TransactionReportDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void Initialize_Check_Options_And_Frames()
    {
      this.dateTimePicker_ReportCalendar.Location = new Point(this.Frame2.Location.X + 40, 164);
      this.dateTimePicker_ReportCalendar.BringToFront();
      this.Check_Report_Options();
      this.Check_All_or_Individual();
      this.Check_RecordSorting();
      this.Check_Choice_Summery_Or_Details();
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 1)
      {
        this.SortFrame.Visible = false;
        this.Label5.Text = " Guest Transactions Report ";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 2)
      {
        this.SortFrame.Visible = false;
        this.Label5.Text = " Admin Transactions Report ";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 3)
      {
        this.SortFrame.Visible = true;
        this.Label5.Text = " Sales Report ";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 9)
      {
        this.SortFrame.Visible = false;
        this.Label5.Text = "Extra Charges Report";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 13)
      {
        this.SortFrame.Visible = false;
        this.Label5.Text = "Replacement Report";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 10)
      {
        this.SortFrame.Visible = false;
        this.Label5.Text = "Error Adjustment Records";
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 11)
      {
        this.SortFrame.Visible = true;
        this.Label5.Text = " Bonus Claimed Report ";
      }
      else
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType != 12)
          return;
        this.SortFrame.Visible = true;
        this.Label5.Text = " Check Out Report ";
      }
    }

    private void Form_TransactionReportDMS_Load(object sender, EventArgs e)
    {
      this.label_Progress.Text = "";
      this.db.CheckBuilding(this.cboBuildingNo1, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.BuildingFrame.Visible = false;
      this.Initialize_Check_Options_And_Frames();
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
        this._Label1_1.Text = "Admin Mode";
      else
        this._Label1_1.Text = "";
    }

    private void Check_RecordSorting()
    {
      if (this._optRecordSort_0.Checked)
      {
        Global_Data.bRecordSorting = false;
      }
      else
      {
        if (!this._optRecordSort_1.Checked)
          return;
        Global_Data.bRecordSorting = true;
      }
    }

    private void _optRecordSort_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_RecordSorting();
    }

    private void _optRecordSort_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_RecordSorting();
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
        this.ChoiceFrame.Visible = false;
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
        this.ChoiceFrame.Visible = false;
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
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType != 3)
          return;
        this.ChoiceFrame.Visible = true;
      }
    }

    private void Check_Report_Options()
    {
      if (this.optRange.Checked)
      {
        this.DateRangeFrame.Visible = true;
        this.dateTimePicker_ReportCalendar.Visible = false;
        this.ChoiceFrame.Visible = false;
      }
      else
      {
        this.DateRangeFrame.Visible = false;
        this.DMYSelection();
        this.dateTimePicker_ReportCalendar.Visible = true;
      }
    }

    private void optRange_CheckedChanged(object sender, EventArgs e) => this.Check_Report_Options();

    private void optDay_CheckedChanged(object sender, EventArgs e) => this.Check_Report_Options();

    private void optMonth_CheckedChanged(object sender, EventArgs e) => this.Check_Report_Options();

    private void optYear_CheckedChanged(object sender, EventArgs e) => this.Check_Report_Options();

    private void Check_All_or_Individual()
    {
      if (this._optChoice_0.Checked)
        Global_Data.bCurrent = false;
      else
        Global_Data.bCurrent = true;
    }

    private void _optCurrent_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_All_or_Individual();
    }

    private void _optCurrent_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_All_or_Individual();
    }

    private void Check_Choice_Summery_Or_Details()
    {
      if (this._optChoice_0.Checked)
      {
        Global_Data.bSummary = false;
        this.SortFrame.Visible = true;
      }
      else
      {
        if (!this._optChoice_1.Checked)
          return;
        Global_Data.bSummary = true;
        this.SortFrame.Visible = false;
      }
    }

    private void _optChoice_0_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Choice_Summery_Or_Details();
    }

    private void _optChoice_1_CheckedChanged(object sender, EventArgs e)
    {
      this.Check_Choice_Summery_Or_Details();
    }

    private void Form_TransactionReportDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Initialize_Check_Options_And_Frames();
    }

    private void cmdGenerate_Click(object sender, EventArgs e)
    {
      this.Frame2.Visible = false;
      string para_ReportType = "";
      this.label_Progress.Text = " Pls. Wait ...";
      this.label_Progress.BringToFront();
      this.Refresh();
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo = this.cboBuildingNo1.Text;
      this.Check_All_or_Individual();
      Global_Data.ReportCalendar_Text = this.dateTimePicker_ReportCalendar.Text;
      Global_Data.sBuildingName = this.db.RetrieveBldName(this.cboBuildingNo1.Text);
      ReportForm reportForm = new ReportForm();
      if (this.optDay.Checked || this.optMonth.Checked || this.optYear.Checked)
      {
        if (this.optDay.Checked)
        {
          this.DMYSelection();
          this.start_Date = Global_Data.sRDate;
          this.End_date = Global_Data.sRDate;
          Global_Data.Report_Form_Title = "Daily ";
          para_ReportType = "REPORT DATE";
        }
        else if (this.optMonth.Checked)
        {
          this.DMYSelection();
          this.start_Date = Global_Data.sSDate;
          this.End_date = Global_Data.sEDate;
          Global_Data.Report_Form_Title = "Monthly ";
          para_ReportType = "REPORT MONTH";
        }
        else if (this.optYear.Checked)
        {
          this.DMYSelection();
          this.start_Date = Global_Data.sRYear + "-01-01";
          this.End_date = Global_Data.sRYear + "-12-31";
          Global_Data.Report_Form_Title = "Yearly ";
          para_ReportType = "REPORT YEAR";
        }
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 1)
        {
          Global_Data.Report_Form_Title += "Guest Transactions Report";
          ADMIN_ReportClass_GuestTRANSACTIONS_MONTHLY transactionsMonthly = new ADMIN_ReportClass_GuestTRANSACTIONS_MONTHLY();
          reportForm.crystalReportViewer1.ReportSource = (object) transactionsMonthly.CHECK_TRANSACTIONS_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 2)
        {
          Global_Data.Report_Form_Title += "Admin Transactions Report";
          ADMIN_ReportClass_ADMINTRANSACTIONS_MONTHLY admintransactionsMonthly = new ADMIN_ReportClass_ADMINTRANSACTIONS_MONTHLY();
          reportForm.crystalReportViewer1.ReportSource = (object) admintransactionsMonthly.CHECK_ADMINTRANSACTIONS_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title, Global_Data.sBldNo);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 3)
        {
          if (this.optYear.Checked && Global_Data.bSummary)
          {
            Global_Data.Report_Form_Title = "Yearly Sales Summary Report";
            ADMIN_ReportClass_GSALES_YEARLY_SUMMARY gsalesYearlySummary = new ADMIN_ReportClass_GSALES_YEARLY_SUMMARY();
            reportForm.crystalReportViewer1.ReportSource = (object) gsalesYearlySummary.CHECK_YEARLY_SUMMARY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
          else if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title += "Sales Report";
            ADMIN_ReportClass_GSALES_MONTHLY_gsale2_mtd monthlyGsale2Mtd = new ADMIN_ReportClass_GSALES_MONTHLY_gsale2_mtd();
            reportForm.crystalReportViewer1.ReportSource = (object) monthlyGsale2Mtd.CHECK_GSALES_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title += "Sales Report";
            ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd monthlyGsalesroom2Mtd = new ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd();
            reportForm.crystalReportViewer1.ReportSource = (object) monthlyGsalesroom2Mtd.CHECK_GSALES_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 9)
        {
          Global_Data.Report_Form_Title += "Extra Charges Report";
          ADMIN_ReportClass_Extra reportClassExtra = new ADMIN_ReportClass_Extra();
          reportForm.crystalReportViewer1.ReportSource = (object) reportClassExtra.CHECK_EXTRA_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 13)
        {
          Global_Data.Report_Form_Title += "Replacement Report";
          ADMIN_ReportClass_Replacement classReplacement = new ADMIN_ReportClass_Replacement();
          reportForm.crystalReportViewer1.ReportSource = (object) classReplacement.CHECK_REPLACEMENT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 10)
        {
          Global_Data.Report_Form_Title += "Error Adjustment Report";
          ADMIN_ReportClass_ErrRec reportClassErrRec = new ADMIN_ReportClass_ErrRec();
          reportForm.crystalReportViewer1.ReportSource = (object) reportClassErrRec.CHECK_ERRREC_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 11)
        {
          if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title += "Bonus Claimed Report";
            ADMIN_ReportClass_BONUSCLAIMED classBonusclaimed = new ADMIN_ReportClass_BONUSCLAIMED();
            reportForm.crystalReportViewer1.ReportSource = (object) classBonusclaimed.CHECK_BONUSCLAIMED_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title += "Bonus Claimed Report";
            ADMIN_ReportClass_BONUSCLAIMED_room bonusclaimedRoom = new ADMIN_ReportClass_BONUSCLAIMED_room();
            reportForm.crystalReportViewer1.ReportSource = (object) bonusclaimedRoom.CHECK_BONUSCLAIMED_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 12)
        {
          if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title += "Check Out Report";
            ADMIN_ReportClass_GCheckOut reportClassGcheckOut = new ADMIN_ReportClass_GCheckOut();
            reportForm.crystalReportViewer1.ReportSource = (object) reportClassGcheckOut.CHECK_CHECKOUT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title += "Check Out Report";
            ADMIN_ReportClass_GCheckOutRoom classGcheckOutRoom = new ADMIN_ReportClass_GCheckOutRoom();
            reportForm.crystalReportViewer1.ReportSource = (object) classGcheckOutRoom.CHECK_CHECKOUT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, para_ReportType, Global_Data.Report_Form_Title);
          }
        }
      }
      else if (this.optRange.Checked)
      {
        this.start_Date = this.dateTimePicker_mskStartDate.Value.ToShortDateString();
        this.End_date = this.dateTimePicker_mskEndDate.Value.ToShortDateString();
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 1)
        {
          Global_Data.Report_Form_Title = "Guest Transactions Report By Date Range";
          ADMIN_ReportClass_GuestTRANSACTIONS_MONTHLY transactionsMonthly = new ADMIN_ReportClass_GuestTRANSACTIONS_MONTHLY();
          reportForm.crystalReportViewer1.ReportSource = (object) transactionsMonthly.CHECK_TRANSACTIONS_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 2)
        {
          Global_Data.Report_Form_Title = "Admin Transactions Report By Date Range";
          ADMIN_ReportClass_ADMINTRANSACTIONS_MONTHLY admintransactionsMonthly = new ADMIN_ReportClass_ADMINTRANSACTIONS_MONTHLY();
          reportForm.crystalReportViewer1.ReportSource = (object) admintransactionsMonthly.CHECK_ADMINTRANSACTIONS_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title, Global_Data.sBldNo);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 3)
        {
          if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title = "Sales Report by Date Range";
            ADMIN_ReportClass_GSALES_MONTHLY_gsale2_mtd monthlyGsale2Mtd = new ADMIN_ReportClass_GSALES_MONTHLY_gsale2_mtd();
            reportForm.crystalReportViewer1.ReportSource = (object) monthlyGsale2Mtd.CHECK_GSALES_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title = "Sales Report by Date Range";
            ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd monthlyGsalesroom2Mtd = new ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd();
            reportForm.crystalReportViewer1.ReportSource = (object) monthlyGsalesroom2Mtd.CHECK_GSALES_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 9)
        {
          Global_Data.Report_Form_Title = "Extra Charges Report By Date Range";
          ADMIN_ReportClass_Extra reportClassExtra = new ADMIN_ReportClass_Extra();
          reportForm.crystalReportViewer1.ReportSource = (object) reportClassExtra.CHECK_EXTRA_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 13)
        {
          Global_Data.Report_Form_Title = "Replacement Report By Date Range";
          ADMIN_ReportClass_Replacement classReplacement = new ADMIN_ReportClass_Replacement();
          reportForm.crystalReportViewer1.ReportSource = (object) classReplacement.CHECK_REPLACEMENT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 10)
        {
          Global_Data.Report_Form_Title = "Error Adjustment Report By Date Range";
          ADMIN_ReportClass_ErrRec reportClassErrRec = new ADMIN_ReportClass_ErrRec();
          reportForm.crystalReportViewer1.ReportSource = (object) reportClassErrRec.CHECK_ERRREC_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 11)
        {
          if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title = "Bonus Claimed Report by Date Range";
            ADMIN_ReportClass_BONUSCLAIMED classBonusclaimed = new ADMIN_ReportClass_BONUSCLAIMED();
            reportForm.crystalReportViewer1.ReportSource = (object) classBonusclaimed.CHECK_BONUSCLAIMED_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title = "Bonus Claimed Report by Date Range";
            ADMIN_ReportClass_BONUSCLAIMED_room bonusclaimedRoom = new ADMIN_ReportClass_BONUSCLAIMED_room();
            reportForm.crystalReportViewer1.ReportSource = (object) bonusclaimedRoom.CHECK_BONUSCLAIMED_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
        }
        else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType == 12)
        {
          if (!Global_Data.bRecordSorting)
          {
            Global_Data.Report_Form_Title = "Check Out Report by Date Range";
            ADMIN_ReportClass_GCheckOut reportClassGcheckOut = new ADMIN_ReportClass_GCheckOut();
            reportForm.crystalReportViewer1.ReportSource = (object) reportClassGcheckOut.CHECK_CHECKOUT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
          else
          {
            Global_Data.Report_Form_Title = "Check Out Report by Date Range";
            ADMIN_ReportClass_GCheckOutRoom classGcheckOutRoom = new ADMIN_ReportClass_GCheckOutRoom();
            reportForm.crystalReportViewer1.ReportSource = (object) classGcheckOutRoom.CHECK_CHECKOUT_MONTHLY(Global_Data.bCurrent, this.start_Date, this.End_date, "REPORT DATE", Global_Data.Report_Form_Title);
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Not Implemented Yet!");
        }
      }
      int num1 = (int) reportForm.ShowDialog();
      this.Frame2.Visible = true;
      this.label_Progress.SendToBack();
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
      this.cboDay = new ComboBox();
      this.Label2 = new Label();
      this.Frame8 = new GroupBox();
      this.cmdGenerate = new Button();
      this.cmdReturn = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.optYear = new RadioButton();
      this.optMonth = new RadioButton();
      this.optDay = new RadioButton();
      this.cboYear = new ComboBox();
      this.cboBuildingNo1 = new ComboBox();
      this.cboMonth = new ComboBox();
      this.SortFrame = new GroupBox();
      this._optRecordSort_1 = new RadioButton();
      this._optRecordSort_0 = new RadioButton();
      this.Frame3 = new Panel();
      this.optRange = new RadioButton();
      this.lblDay = new Label();
      this.lblMonth = new Label();
      this.lblYear = new Label();
      this.Label5 = new Label();
      this._Label1_1 = new Label();
      this.Label3 = new Label();
      this.lblBuildingNo1 = new Label();
      this._optCurrent_1 = new RadioButton();
      this._optCurrent_0 = new RadioButton();
      this.Frame2 = new Panel();
      this.BuildingFrame = new GroupBox();
      this.CurrentFrame = new Panel();
      this.ChoiceFrame = new GroupBox();
      this._optChoice_1 = new RadioButton();
      this._optChoice_0 = new RadioButton();
      this.DateRangeFrame = new GroupBox();
      this.dateTimePicker_mskEndDate = new DateTimePicker();
      this.dateTimePicker_mskStartDate = new DateTimePicker();
      this.lblMessage = new Label();
      this.Label4 = new Label();
      this._Label1_0 = new Label();
      this.label_Progress = new Label();
      this.dateTimePicker_ReportCalendar = new DateTimePicker();
      this.Frame8.SuspendLayout();
      this.SortFrame.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.BuildingFrame.SuspendLayout();
      this.CurrentFrame.SuspendLayout();
      this.ChoiceFrame.SuspendLayout();
      this.DateRangeFrame.SuspendLayout();
      this.SuspendLayout();
      this.cboDay.BackColor = SystemColors.Window;
      this.cboDay.Cursor = Cursors.Default;
      this.cboDay.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboDay.ForeColor = SystemColors.WindowText;
      this.cboDay.Location = new Point(691, 284);
      this.cboDay.Name = "cboDay";
      this.cboDay.RightToLeft = RightToLeft.No;
      this.cboDay.Size = new Size(89, 29);
      this.cboDay.TabIndex = 17;
      this.cboDay.Visible = false;
      this.Label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(128, 128, 128);
      this.Label2.Location = new Point(8, -8);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(233, 49);
      this.Label2.TabIndex = 6;
      this.Label2.Text = "Report Options";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Frame8.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Frame8.Controls.Add((Control) this.cmdGenerate);
      this.Frame8.Controls.Add((Control) this.cmdReturn);
      this.Frame8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame8.ForeColor = SystemColors.ControlText;
      this.Frame8.Location = new Point(48, 344);
      this.Frame8.Name = "Frame8";
      this.Frame8.Padding = new Padding(0);
      this.Frame8.RightToLeft = RightToLeft.No;
      this.Frame8.Size = new Size(441, 75);
      this.Frame8.TabIndex = 2;
      this.Frame8.TabStop = false;
      this.cmdGenerate.BackColor = SystemColors.Control;
      this.cmdGenerate.Cursor = Cursors.Default;
      this.cmdGenerate.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdGenerate.ForeColor = SystemColors.ControlText;
      this.cmdGenerate.Location = new Point(48, 16);
      this.cmdGenerate.Name = "cmdGenerate";
      this.cmdGenerate.RightToLeft = RightToLeft.No;
      this.cmdGenerate.Size = new Size(148, 49);
      this.cmdGenerate.TabIndex = 16;
      this.cmdGenerate.Text = "&GENERATE";
      this.ToolTip1.SetToolTip((Control) this.cmdGenerate, "View Report");
      this.cmdGenerate.UseVisualStyleBackColor = false;
      this.cmdGenerate.Click += new EventHandler(this.cmdGenerate_Click);
      this.cmdReturn.BackColor = SystemColors.Control;
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Location = new Point(240, 16);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(148, 49);
      this.cmdReturn.TabIndex = 18;
      this.cmdReturn.Text = "RETUR&N";
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Admin Screen ");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.optYear.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.optYear.Cursor = Cursors.Default;
      this.optYear.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optYear.ForeColor = Color.White;
      this.optYear.Location = new Point(32, 142);
      this.optYear.Name = "optYear";
      this.optYear.RightToLeft = RightToLeft.No;
      this.optYear.Size = new Size(177, 41);
      this.optYear.TabIndex = 24;
      this.optYear.Text = "By Year";
      this.ToolTip1.SetToolTip((Control) this.optYear, "To View Report By Yearly");
      this.optYear.UseVisualStyleBackColor = false;
      this.optYear.CheckedChanged += new EventHandler(this.optYear_CheckedChanged);
      this.optMonth.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.optMonth.Cursor = Cursors.Default;
      this.optMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optMonth.ForeColor = Color.White;
      this.optMonth.Location = new Point(32, 91);
      this.optMonth.Name = "optMonth";
      this.optMonth.RightToLeft = RightToLeft.No;
      this.optMonth.Size = new Size(177, 41);
      this.optMonth.TabIndex = 5;
      this.optMonth.TabStop = true;
      this.optMonth.Text = "By Month";
      this.ToolTip1.SetToolTip((Control) this.optMonth, "To View Report By Monthly");
      this.optMonth.UseVisualStyleBackColor = false;
      this.optMonth.CheckedChanged += new EventHandler(this.optMonth_CheckedChanged);
      this.optDay.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.optDay.Cursor = Cursors.Default;
      this.optDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optDay.ForeColor = Color.White;
      this.optDay.Location = new Point(32, 40);
      this.optDay.Name = "optDay";
      this.optDay.RightToLeft = RightToLeft.No;
      this.optDay.Size = new Size(177, 41);
      this.optDay.TabIndex = 4;
      this.optDay.TabStop = true;
      this.optDay.Text = "By Date";
      this.ToolTip1.SetToolTip((Control) this.optDay, "To View Report By Daily");
      this.optDay.UseVisualStyleBackColor = false;
      this.optDay.CheckedChanged += new EventHandler(this.optDay_CheckedChanged);
      this.cboYear.BackColor = SystemColors.Window;
      this.cboYear.Cursor = Cursors.Default;
      this.cboYear.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboYear.ForeColor = SystemColors.WindowText;
      this.cboYear.Location = new Point(692, 156);
      this.cboYear.Name = "cboYear";
      this.cboYear.RightToLeft = RightToLeft.No;
      this.cboYear.Size = new Size(89, 29);
      this.cboYear.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.cboYear, "To Select Year");
      this.cboYear.Visible = false;
      this.cboBuildingNo1.BackColor = Color.White;
      this.cboBuildingNo1.Cursor = Cursors.Default;
      this.cboBuildingNo1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo1.ForeColor = Color.Blue;
      this.cboBuildingNo1.Location = new Point(136, 96);
      this.cboBuildingNo1.Name = "cboBuildingNo1";
      this.cboBuildingNo1.RightToLeft = RightToLeft.No;
      this.cboBuildingNo1.Size = new Size(65, 29);
      this.cboBuildingNo1.TabIndex = 12;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo1, "Select Building");
      this.cboMonth.BackColor = SystemColors.Window;
      this.cboMonth.Cursor = Cursors.Default;
      this.cboMonth.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboMonth.ForeColor = SystemColors.WindowText;
      this.cboMonth.Location = new Point(692, 220);
      this.cboMonth.Name = "cboMonth";
      this.cboMonth.RightToLeft = RightToLeft.No;
      this.cboMonth.Size = new Size(137, 29);
      this.cboMonth.TabIndex = 15;
      this.ToolTip1.SetToolTip((Control) this.cboMonth, "To Select Month");
      this.cboMonth.Visible = false;
      this.SortFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.SortFrame.Controls.Add((Control) this._optRecordSort_1);
      this.SortFrame.Controls.Add((Control) this._optRecordSort_0);
      this.SortFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SortFrame.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.SortFrame.Location = new Point(264, 264);
      this.SortFrame.Name = "SortFrame";
      this.SortFrame.Padding = new Padding(0);
      this.SortFrame.RightToLeft = RightToLeft.No;
      this.SortFrame.Size = new Size(185, 81);
      this.SortFrame.TabIndex = 26;
      this.SortFrame.TabStop = false;
      this.SortFrame.Text = "Record Sort By";
      this._optRecordSort_1.BackColor = Color.Cyan;
      this._optRecordSort_1.Cursor = Cursors.Default;
      this._optRecordSort_1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optRecordSort_1.ForeColor = SystemColors.ControlText;
      this._optRecordSort_1.Location = new Point(16, 48);
      this._optRecordSort_1.Name = "_optRecordSort_1";
      this._optRecordSort_1.RightToLeft = RightToLeft.No;
      this._optRecordSort_1.Size = new Size(129, 25);
      this._optRecordSort_1.TabIndex = 14;
      this._optRecordSort_1.Text = "Room No.";
      this._optRecordSort_1.UseVisualStyleBackColor = false;
      this._optRecordSort_1.CheckedChanged += new EventHandler(this._optRecordSort_1_CheckedChanged);
      this._optRecordSort_0.BackColor = Color.Cyan;
      this._optRecordSort_0.Checked = true;
      this._optRecordSort_0.Cursor = Cursors.Default;
      this._optRecordSort_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optRecordSort_0.ForeColor = SystemColors.ControlText;
      this._optRecordSort_0.Location = new Point(16, 16);
      this._optRecordSort_0.Name = "_optRecordSort_0";
      this._optRecordSort_0.RightToLeft = RightToLeft.No;
      this._optRecordSort_0.Size = new Size(161, 25);
      this._optRecordSort_0.TabIndex = 13;
      this._optRecordSort_0.TabStop = true;
      this._optRecordSort_0.Text = "Payment Note No.";
      this._optRecordSort_0.UseVisualStyleBackColor = false;
      this._optRecordSort_0.CheckedChanged += new EventHandler(this._optRecordSort_0_CheckedChanged);
      this.Frame3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Frame3.Controls.Add((Control) this.optRange);
      this.Frame3.Controls.Add((Control) this.optYear);
      this.Frame3.Controls.Add((Control) this.optMonth);
      this.Frame3.Controls.Add((Control) this.optDay);
      this.Frame3.Controls.Add((Control) this.Label2);
      this.Frame3.Cursor = Cursors.Default;
      this.Frame3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = Color.White;
      this.Frame3.Location = new Point(264, 16);
      this.Frame3.Name = "Frame3";
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(247, 241);
      this.Frame3.TabIndex = 3;
      this.optRange.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.optRange.Checked = true;
      this.optRange.Cursor = Cursors.Default;
      this.optRange.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.optRange.ForeColor = Color.Blue;
      this.optRange.Location = new Point(32, 192);
      this.optRange.Name = "optRange";
      this.optRange.RightToLeft = RightToLeft.No;
      this.optRange.Size = new Size(177, 41);
      this.optRange.TabIndex = 7;
      this.optRange.TabStop = true;
      this.optRange.Text = "By Date Range";
      this.optRange.UseVisualStyleBackColor = false;
      this.optRange.CheckedChanged += new EventHandler(this.optRange_CheckedChanged);
      this.lblDay.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblDay.Cursor = Cursors.Default;
      this.lblDay.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDay.ForeColor = Color.Red;
      this.lblDay.Location = new Point(692, 252);
      this.lblDay.Name = "lblDay";
      this.lblDay.RightToLeft = RightToLeft.No;
      this.lblDay.Size = new Size(65, 33);
      this.lblDay.TabIndex = 21;
      this.lblDay.Text = "Day";
      this.lblDay.Visible = false;
      this.lblMonth.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblMonth.Cursor = Cursors.Default;
      this.lblMonth.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMonth.ForeColor = Color.Red;
      this.lblMonth.Location = new Point(692, 188);
      this.lblMonth.Name = "lblMonth";
      this.lblMonth.RightToLeft = RightToLeft.No;
      this.lblMonth.Size = new Size(105, 33);
      this.lblMonth.TabIndex = 20;
      this.lblMonth.Text = "Month";
      this.lblMonth.Visible = false;
      this.lblYear.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblYear.Cursor = Cursors.Default;
      this.lblYear.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblYear.ForeColor = Color.Red;
      this.lblYear.Location = new Point(692, 124);
      this.lblYear.Name = "lblYear";
      this.lblYear.RightToLeft = RightToLeft.No;
      this.lblYear.Size = new Size(65, 33);
      this.lblYear.TabIndex = 19;
      this.lblYear.Text = "Year";
      this.lblYear.Visible = false;
      this.Label5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label5.Location = new Point(-5, 59);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(791, 47);
      this.Label5.TabIndex = 28;
      this.Label5.Text = "Transactions Report";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this._Label1_1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this._Label1_1.BorderStyle = BorderStyle.Fixed3D;
      this._Label1_1.Cursor = Cursors.Default;
      this._Label1_1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this._Label1_1.ForeColor = Color.Blue;
      this._Label1_1.Location = new Point(522, 3);
      this._Label1_1.Name = "_Label1_1";
      this._Label1_1.RightToLeft = RightToLeft.No;
      this._Label1_1.Size = new Size(242, 41);
      this._Label1_1.TabIndex = 27;
      this._Label1_1.Text = "Admin Mode";
      this._Label1_1.TextAlign = ContentAlignment.TopCenter;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Red;
      this.Label3.Location = new Point(3, 3);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(777, 49);
      this.Label3.TabIndex = 29;
      this.Label3.TextAlign = ContentAlignment.TopCenter;
      this.lblBuildingNo1.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.lblBuildingNo1.Cursor = Cursors.Default;
      this.lblBuildingNo1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuildingNo1.ForeColor = Color.Blue;
      this.lblBuildingNo1.Location = new Point(24, 96);
      this.lblBuildingNo1.Name = "lblBuildingNo1";
      this.lblBuildingNo1.RightToLeft = RightToLeft.No;
      this.lblBuildingNo1.Size = new Size(105, 25);
      this.lblBuildingNo1.TabIndex = 29;
      this.lblBuildingNo1.Text = "Building No. ";
      this._optCurrent_1.BackColor = Color.FromArgb(0, 128, 0);
      this._optCurrent_1.Checked = true;
      this._optCurrent_1.Cursor = Cursors.Default;
      this._optCurrent_1.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCurrent_1.ForeColor = Color.White;
      this._optCurrent_1.Location = new Point(16, 40);
      this._optCurrent_1.Name = "_optCurrent_1";
      this._optCurrent_1.RightToLeft = RightToLeft.No;
      this._optCurrent_1.Size = new Size(161, 25);
      this._optCurrent_1.TabIndex = 11;
      this._optCurrent_1.TabStop = true;
      this._optCurrent_1.Text = "Individual";
      this._optCurrent_1.UseVisualStyleBackColor = false;
      this._optCurrent_1.CheckedChanged += new EventHandler(this._optCurrent_1_CheckedChanged);
      this._optCurrent_0.BackColor = Color.FromArgb(0, 128, 0);
      this._optCurrent_0.Cursor = Cursors.Default;
      this._optCurrent_0.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optCurrent_0.ForeColor = Color.White;
      this._optCurrent_0.Location = new Point(16, 8);
      this._optCurrent_0.Name = "_optCurrent_0";
      this._optCurrent_0.RightToLeft = RightToLeft.No;
      this._optCurrent_0.Size = new Size(161, 25);
      this._optCurrent_0.TabIndex = 10;
      this._optCurrent_0.TabStop = true;
      this._optCurrent_0.Text = "All ";
      this._optCurrent_0.UseVisualStyleBackColor = false;
      this._optCurrent_0.CheckedChanged += new EventHandler(this._optCurrent_0_CheckedChanged);
      this.Frame2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Frame2.Controls.Add((Control) this.BuildingFrame);
      this.Frame2.Controls.Add((Control) this.SortFrame);
      this.Frame2.Controls.Add((Control) this.Frame3);
      this.Frame2.Controls.Add((Control) this.Frame8);
      this.Frame2.Controls.Add((Control) this.ChoiceFrame);
      this.Frame2.Controls.Add((Control) this.DateRangeFrame);
      this.Frame2.Cursor = Cursors.Default;
      this.Frame2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = Color.White;
      this.Frame2.Location = new Point(123, 108);
      this.Frame2.Name = "Frame2";
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(536, 424);
      this.Frame2.TabIndex = 26;
      this.Frame2.Text = "Machine Data";
      this.BuildingFrame.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.BuildingFrame.Controls.Add((Control) this.CurrentFrame);
      this.BuildingFrame.Controls.Add((Control) this.cboBuildingNo1);
      this.BuildingFrame.Controls.Add((Control) this.lblBuildingNo1);
      this.BuildingFrame.Enabled = false;
      this.BuildingFrame.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BuildingFrame.ForeColor = Color.Red;
      this.BuildingFrame.Location = new Point(40, 216);
      this.BuildingFrame.Name = "BuildingFrame";
      this.BuildingFrame.Padding = new Padding(0);
      this.BuildingFrame.RightToLeft = RightToLeft.No;
      this.BuildingFrame.Size = new Size(209, 129);
      this.BuildingFrame.TabIndex = 27;
      this.BuildingFrame.TabStop = false;
      this.BuildingFrame.Text = "Select Building :";
      this.CurrentFrame.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.CurrentFrame.Controls.Add((Control) this._optCurrent_1);
      this.CurrentFrame.Controls.Add((Control) this._optCurrent_0);
      this.CurrentFrame.Cursor = Cursors.Default;
      this.CurrentFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CurrentFrame.ForeColor = SystemColors.ControlText;
      this.CurrentFrame.Location = new Point(8, 22);
      this.CurrentFrame.Name = "CurrentFrame";
      this.CurrentFrame.RightToLeft = RightToLeft.No;
      this.CurrentFrame.Size = new Size(185, 73);
      this.CurrentFrame.TabIndex = 28;
      this.ChoiceFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.ChoiceFrame.Controls.Add((Control) this._optChoice_1);
      this.ChoiceFrame.Controls.Add((Control) this._optChoice_0);
      this.ChoiceFrame.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ChoiceFrame.ForeColor = Color.White;
      this.ChoiceFrame.Location = new Point(40, 144);
      this.ChoiceFrame.Name = "ChoiceFrame";
      this.ChoiceFrame.Padding = new Padding(0);
      this.ChoiceFrame.RightToLeft = RightToLeft.No;
      this.ChoiceFrame.Size = new Size(209, 65);
      this.ChoiceFrame.TabIndex = 30;
      this.ChoiceFrame.TabStop = false;
      this.ChoiceFrame.Text = "View For :";
      this._optChoice_1.BackColor = Color.Yellow;
      this._optChoice_1.Cursor = Cursors.Default;
      this._optChoice_1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optChoice_1.ForeColor = SystemColors.ControlText;
      this._optChoice_1.Location = new Point(112, 22);
      this._optChoice_1.Name = "_optChoice_1";
      this._optChoice_1.RightToLeft = RightToLeft.No;
      this._optChoice_1.Size = new Size(89, 33);
      this._optChoice_1.TabIndex = 32;
      this._optChoice_1.TabStop = true;
      this._optChoice_1.Text = "Summary";
      this._optChoice_1.UseVisualStyleBackColor = false;
      this._optChoice_1.CheckedChanged += new EventHandler(this._optChoice_1_CheckedChanged);
      this._optChoice_0.BackColor = Color.Yellow;
      this._optChoice_0.Checked = true;
      this._optChoice_0.Cursor = Cursors.Default;
      this._optChoice_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optChoice_0.ForeColor = SystemColors.ControlText;
      this._optChoice_0.Location = new Point(8, 22);
      this._optChoice_0.Name = "_optChoice_0";
      this._optChoice_0.RightToLeft = RightToLeft.No;
      this._optChoice_0.Size = new Size(89, 33);
      this._optChoice_0.TabIndex = 31;
      this._optChoice_0.TabStop = true;
      this._optChoice_0.Text = "Details";
      this._optChoice_0.UseVisualStyleBackColor = false;
      this._optChoice_0.CheckedChanged += new EventHandler(this._optChoice_0_CheckedChanged);
      this.DateRangeFrame.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.DateRangeFrame.Controls.Add((Control) this.dateTimePicker_mskEndDate);
      this.DateRangeFrame.Controls.Add((Control) this.dateTimePicker_mskStartDate);
      this.DateRangeFrame.Controls.Add((Control) this.lblMessage);
      this.DateRangeFrame.Controls.Add((Control) this.Label4);
      this.DateRangeFrame.Controls.Add((Control) this._Label1_0);
      this.DateRangeFrame.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DateRangeFrame.ForeColor = Color.Black;
      this.DateRangeFrame.Location = new Point(40, 16);
      this.DateRangeFrame.Name = "DateRangeFrame";
      this.DateRangeFrame.Padding = new Padding(0);
      this.DateRangeFrame.RightToLeft = RightToLeft.No;
      this.DateRangeFrame.Size = new Size(209, 193);
      this.DateRangeFrame.TabIndex = 33;
      this.DateRangeFrame.TabStop = false;
      this.DateRangeFrame.Text = "Select Date Range :";
      this.dateTimePicker_mskEndDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskEndDate.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_mskEndDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskEndDate.Location = new Point(95, 80);
      this.dateTimePicker_mskEndDate.Name = "dateTimePicker_mskEndDate";
      this.dateTimePicker_mskEndDate.Size = new Size(98, 21);
      this.dateTimePicker_mskEndDate.TabIndex = 169;
      this.dateTimePicker_mskStartDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskStartDate.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_mskStartDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskStartDate.Location = new Point(95, 40);
      this.dateTimePicker_mskStartDate.Name = "dateTimePicker_mskStartDate";
      this.dateTimePicker_mskStartDate.Size = new Size(98, 21);
      this.dateTimePicker_mskStartDate.TabIndex = 168;
      this.lblMessage.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(8, 112);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(193, 65);
      this.lblMessage.TabIndex = 36;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Blue;
      this.Label4.Location = new Point(16, 80);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 17);
      this.Label4.TabIndex = 35;
      this.Label4.Text = "End Date";
      this._Label1_0.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this._Label1_0.Cursor = Cursors.Default;
      this._Label1_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._Label1_0.ForeColor = Color.Blue;
      this._Label1_0.Location = new Point(16, 40);
      this._Label1_0.Name = "_Label1_0";
      this._Label1_0.RightToLeft = RightToLeft.No;
      this._Label1_0.Size = new Size(81, 17);
      this._Label1_0.TabIndex = 34;
      this._Label1_0.Text = "Start Date";
      this.label_Progress.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.label_Progress.Cursor = Cursors.Default;
      this.label_Progress.Font = new Font("Times New Roman", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label_Progress.ForeColor = Color.Red;
      this.label_Progress.Location = new Point(28, 354);
      this.label_Progress.Name = "label_Progress";
      this.label_Progress.RightToLeft = RightToLeft.No;
      this.label_Progress.Size = new Size(729, 48);
      this.label_Progress.TabIndex = 156;
      this.label_Progress.Text = "asdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffff";
      this.label_Progress.TextAlign = ContentAlignment.TopCenter;
      this.dateTimePicker_ReportCalendar.Checked = false;
      this.dateTimePicker_ReportCalendar.CustomFormat = "yyyy";
      this.dateTimePicker_ReportCalendar.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker_ReportCalendar.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_ReportCalendar.Location = new Point(1, 164);
      this.dateTimePicker_ReportCalendar.Name = "dateTimePicker_ReportCalendar";
      this.dateTimePicker_ReportCalendar.Size = new Size(200, 29);
      this.dateTimePicker_ReportCalendar.TabIndex = 166;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.ClientSize = new Size(792, 559);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this._Label1_1);
      this.Controls.Add((Control) this.cboDay);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.cboMonth);
      this.Controls.Add((Control) this.Frame2);
      this.Controls.Add((Control) this.label_Progress);
      this.Controls.Add((Control) this.cboYear);
      this.Controls.Add((Control) this.lblYear);
      this.Controls.Add((Control) this.lblDay);
      this.Controls.Add((Control) this.lblMonth);
      this.Controls.Add((Control) this.dateTimePicker_ReportCalendar);
      this.Name = "Form_TransactionReportDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_TransactionReportDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_TransactionReportDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_TransactionReportDMS_FormClosing);
      this.Frame8.ResumeLayout(false);
      this.SortFrame.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.BuildingFrame.ResumeLayout(false);
      this.CurrentFrame.ResumeLayout(false);
      this.ChoiceFrame.ResumeLayout(false);
      this.DateRangeFrame.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
