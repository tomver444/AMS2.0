// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_IssueCardHistory
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class ReportClass_IssueCardHistory
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private string AdminNewIssued = "0";
    private string GuestNewIssued = "0";
    private string AdminLoss = "0";
    private string GuestLoss = "0";
    private string AdminExtra = "0";
    private string GuestExtra = "0";
    private string TotalAdminNewIssued = "0";
    private string TotalGuestNewIssued = "0";
    private string TotalAdminLoss = "0";
    private string TotalGuestLoss = "0";
    private string TotalAdminExtra = "0";
    private string TotalGuestExtra = "0";
    private string TotalAdmin = "0";
    private string TotalGuest = "0";
    private string AdminLogOut = "0";
    private string GuestLogOut = "0";
    private string TotalAdminLogOut = "0";
    private string TotalGuestLogOut = "0";
    private string TotalLogOut = "0";
    private string sDeposit = "0";
    private string sBond = "0";
    private string sKeyCharge = "0";
    private string sExtraCharge = "0";
    private string sRoomCharge = "0";
    private string sAmountDue = "0";
    private string sTotalPaid = "0";
    private string sAdvancedPayment = "0";
    private string sExDescription = "0";
    private string GSTonTotalPaid = "0";
    private string GSTDisplay = "0";
    private string sName1 = "0";
    private string sName2 = "0";
    private string sName3 = "0";
    private string sName4 = "0";
    private string sName5 = "0";
    private string sName6 = "0";
    private string sName7 = "0";
    private string sName8 = "0";
    private bool bPrintReceipt;
    private string sChargeType = "0";
    private string sChargeTypeDesc = "0";
    private string sCheckInDate = "0";
    private string sCheckInDateDesc = "0";
    private string sNewGSTRate = "0";
    private string sOldGSTRate = "0";
    private string sTransDate = "0";
    private string sAdvancedCalculated = "0";
    private string sGSTRoomCharge = "0";
    private string sGSTKeyCharge = "0";
    private string sGSTExtraCharge = "0";
    private string sGSTAdvancedPayment = "0";
    private string sAmountDueDesc = "0";
    private string sTotalPaidDesc = "0";
    private string sReportType = "0";
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public issuedcardhistory issuedcardhistory1;

    public ReportClass_IssueCardHistory()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.issuedcardhistory1 = new issuedcardhistory();
    }

    private void DATA_INITIALISE1()
    {
      this.AdminNewIssued = "";
      this.GuestNewIssued = "";
      this.AdminLoss = "";
      this.GuestLoss = "";
      this.AdminExtra = "";
      this.GuestExtra = "";
      this.AdminLogOut = "";
      this.GuestLogOut = "";
      this.TotalAdminNewIssued = "";
      this.TotalGuestNewIssued = "";
      this.TotalAdminLoss = "";
      this.TotalGuestLoss = "";
      this.TotalAdminExtra = "";
      this.TotalGuestExtra = "";
      this.TotalAdminLogOut = "";
      this.TotalGuestLogOut = "";
      this.TotalLogOut = "";
      this.TotalGuest = "";
      this.TotalAdmin = "";
      this.sReportType = "";
    }

    public issuedcardhistory CHECK_ISSUECARDHISTORY(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType);
    }

    public issuedcardhistory Check_Report_All(string para_ReportType) => this.issuedcardhistory1;

    public issuedcardhistory Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.issuedcardhistory1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.IssueCardHistory.DataSet);
      this.db.Local_Command.CommandText = "Delete * from IssueCardHistory";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.issueCardHistoryTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_IssueCardHistory.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into IssueCardHistory (CardNo, RoomNo, CardType, ClientID, CardStatus, KeyCharge, ReaderID, RecordDate, RecordTime, [Update] ) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "SELECT CardNo, RoomNo, CardType, ClientID, CardStatus, KeyCharge, ReaderID, RecordDate, RecordTime, [Update]  From CardNo Where Left(CardNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((CardNo.RecordDate) = # " + Global_Data.sRDate + "#))";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.IssueCardHistory.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.IssueCardHistory);
      if (ReportClass_IssueCardHistory.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.issueCardHistoryTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.IssueCardHistory);
      this.CHECK_ISSUED_DETAILS();
      this.TOTALCALCULATION();
      this.ASSIGN_REPORT_FORMULAR((ReportClass) this.issuedcardhistory1);
      ((ReportDocument) this.issuedcardhistory1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.issuedcardhistory1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.issuedcardhistory1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.issuedcardhistory1).DataDefinition.FormulaFields[13].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.issuedcardhistory1).DataDefinition.FormulaFields[14].Text = "\"" + para_ReportType + "\"";
      return this.issuedcardhistory1;
    }

    private void CHECK_ISSUED_DETAILS()
    {
      foreach (TempDataSet.IssueCardHistoryRow row in (InternalDataCollectionBase) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.IssueCardHistory.Rows)
      {
        switch (row.CardStatus)
        {
          case 0:
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) < 5000L)
            {
              this.AdminNewIssued = (Convert.ToInt32(this.AdminNewIssued) + 1).ToString();
              continue;
            }
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) > 5000L)
            {
              this.GuestNewIssued = (Convert.ToInt32(this.GuestNewIssued) + 1).ToString();
              continue;
            }
            continue;
          case 1:
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) < 5000L)
            {
              this.AdminExtra = (Convert.ToInt32(this.AdminExtra) + 1).ToString();
              continue;
            }
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) > 5000L)
            {
              this.GuestExtra = (Convert.ToInt32(this.GuestExtra) + 1).ToString();
              continue;
            }
            continue;
          case 2:
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) < 5000L)
            {
              this.AdminLoss = (Convert.ToInt32(this.AdminLoss) + 1).ToString();
              continue;
            }
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) > 5000L)
            {
              this.GuestLoss = (Convert.ToInt32(this.GuestLoss) + 1).ToString();
              continue;
            }
            continue;
          case 3:
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) < 5000L)
            {
              this.AdminLogOut = (Convert.ToInt32(this.AdminLogOut) + 1).ToString();
              continue;
            }
            if (Convert.ToInt64(row.ClientID.Substring(row.ClientID.Length - 4, 4)) > 5000L)
            {
              this.GuestLogOut = (Convert.ToInt32(this.GuestLogOut) + 1).ToString();
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }

    private void TOTALCALCULATION()
    {
      int num1;
      try
      {
        num1 = Convert.ToInt32(this.AdminNewIssued);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalAdminNewIssued = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.GuestNewIssued);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalGuestNewIssued = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.AdminExtra);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalAdminExtra = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.GuestExtra);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalGuestExtra = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.AdminLoss);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalAdminLoss = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.GuestLoss);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalGuestLoss = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.AdminLogOut);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalAdminLogOut = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.GuestLogOut);
      }
      catch
      {
        num1 = 0;
      }
      this.TotalGuestLogOut = num1.ToString();
      try
      {
        num1 = Convert.ToInt32(this.TotalAdminLogOut);
      }
      catch
      {
        num1 = 0;
      }
      int num2;
      try
      {
        num2 = Convert.ToInt32(this.TotalGuestLogOut);
      }
      catch
      {
        num2 = 0;
      }
      this.TotalLogOut = (num1 + num2).ToString();
      int num3;
      try
      {
        num3 = Convert.ToInt32(this.TotalAdminNewIssued);
      }
      catch
      {
        num3 = 0;
      }
      int num4;
      try
      {
        num4 = Convert.ToInt32(this.TotalAdminExtra);
      }
      catch
      {
        num4 = 0;
      }
      int num5;
      try
      {
        num5 = Convert.ToInt32(this.TotalAdminLoss);
      }
      catch
      {
        num5 = 0;
      }
      this.TotalAdmin = (num3 + num4 + num5).ToString();
      int num6;
      try
      {
        num6 = Convert.ToInt32(this.TotalGuestNewIssued);
      }
      catch
      {
        num6 = 0;
      }
      int num7;
      try
      {
        num7 = Convert.ToInt32(this.TotalGuestExtra);
      }
      catch
      {
        num7 = 0;
      }
      int num8;
      try
      {
        num8 = Convert.ToInt32(this.TotalGuestLoss);
      }
      catch
      {
        num8 = 0;
      }
      this.TotalGuest = (num6 + num7 + num8).ToString();
    }

    private void ASSIGN_REPORT_FORMULAR(ReportClass para_ReportClass)
    {
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalAdminNewIssued"].Text = "\"" + this.TotalAdminNewIssued + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalAdminLoss"].Text = "\"" + this.TotalAdminLoss + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalAdminExtra"].Text = "\"" + this.TotalAdminExtra + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalAdmin"].Text = "\"" + this.TotalAdmin + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalGuestNewIssued"].Text = "\"" + this.TotalGuestNewIssued + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalGuestLoss"].Text = "\"" + this.TotalGuestLoss + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalGuestExtra"].Text = "\"" + this.TotalGuestExtra + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalGuest"].Text = "\"" + this.TotalGuest + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalAdminLogOut"].Text = "\"" + this.TotalAdminLogOut + "\"";
      ((ReportDocument) para_ReportClass).DataDefinition.FormulaFields["TotalGuestLogOut"].Text = "\"" + this.TotalGuestLogOut + "\"";
    }
  }
}
