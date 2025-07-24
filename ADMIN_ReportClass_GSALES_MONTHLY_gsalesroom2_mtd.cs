// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd
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
  internal class ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private string sTmp;
    private string sTmp1;
    private string sTmp2;
    private string sTmp3;
    private string sTmp4;
    private string sTmp5;
    private string sTmp6;
    private string sTmp7;
    private string sRptDate;
    private string sRptMonth;
    private string sTmpYear;
    private string sStartDate;
    private string sEndDate;
    private string sReportFile;
    private string sDataFile;
    private Decimal Extra;
    private Decimal Loss;
    private Decimal Reserve;
    private Decimal CancelCard;
    private Decimal CancelReserve;
    private Decimal NormalIssue;
    private Decimal NKeyDeposit;
    private Decimal TExtra;
    private Decimal TLoss;
    private Decimal TReserve;
    private Decimal TCancelCard;
    private Decimal TCancelReserve;
    private Decimal TNormalIssue;
    private Decimal TKeyDeposit;
    private Decimal TAll;
    private int TReplacement;
    private Decimal sDeposit;
    private Decimal sBond;
    private Decimal sKeyCharge;
    private Decimal sExtraCharge;
    private Decimal sRoomCharge;
    private Decimal sAdvancedPayment;
    private Decimal TDeposit;
    private Decimal TBond;
    private Decimal TKeyCharge;
    private Decimal TExtraCharge;
    private Decimal TRoomCharge;
    private Decimal TAdvancedPayment;
    private Decimal SDepositRefund;
    private Decimal sBondRefund;
    private Decimal sAdvancedRefund;
    private Decimal sAdvancedRefundAmount;
    private Decimal TDepositRefund;
    private Decimal TBondRefund;
    private Decimal TAdvancedRefund;
    private Decimal TNonGSTwithoutBond;
    private Decimal TBankInReceived;
    private Decimal TBondReceived;
    private Decimal TExtraReceived;
    private Decimal TRentalReceived;
    private Decimal GSTAmount;
    private Decimal sGSTAdjust;
    private Decimal sGST;
    private Decimal sNewGSTRate;
    private Decimal sOldGSTRate;
    private Decimal sTransDate;
    private Decimal sLastPayment;
    private Decimal sTLastPayment;
    private Decimal sGSTRoomCharge;
    private Decimal sGSTKeyCharge;
    private Decimal sGSTExtraCharge;
    private Decimal sGSTAdvancedPayment;
    private Decimal sGSTAdvancedRefund;
    private Decimal sGSTAccRoom;
    private Decimal sGSTAccKey;
    private Decimal sGSTAccExtra;
    private Decimal sGSTAccAdvanced;
    private Decimal sGSTAccAdvancedRefund;
    private Decimal sRoomChargeReceived;
    private Decimal sAccRoomChargeReceived;
    private Decimal TRoomChargeReceived;
    private Decimal Test1;
    private Decimal Test2;
    private Decimal Test3;
    private Decimal Test4;
    private Decimal sKeyDeposit;
    private Decimal sRefundKeyDeposit;
    private Decimal sRBA;
    private Decimal sTActualBond;
    private Decimal sTransKRE;
    private Decimal sGSTAccTransKRE;
    private Decimal sTotalTransKRE;
    private Decimal sTSalesGST;
    private Decimal sTotalField;
    private Decimal sAdvancedField;
    private Decimal sError;
    private Decimal sTError;
    private Decimal sErrAmount;
    private Decimal sBondErrAmount;
    private Decimal sTBondErrAmount;
    private Decimal sTErrAmount;
    private Decimal sTotalActualFunds;
    private Decimal sBuildingName;
    private Decimal sMonthName;
    private string sReportTitle;
    private string sReportType;
    private string sTransType;
    private Decimal sStartDay;
    private Decimal sStartMonth;
    private Decimal sStartYear;
    private Decimal sEndDay;
    private Decimal sEndMonth;
    private Decimal sEndYear;
    private string sCodeDesc;
    private Decimal sChequeDisplay;
    private Decimal sActualGST;
    private Decimal sActualTotal;
    private Decimal sCash;
    private Decimal sManagementFee;
    private Decimal sOtherFee;
    private Decimal sTCash;
    private Decimal sTManagementFee;
    private Decimal sTOtherFee;
    private Decimal TCheque;
    private Decimal TCash;
    private Decimal TBanking;
    private Decimal sOnline;
    private Decimal TOnline;
    private string[] sChequeNo = new string[36]
    {
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      "",
      ""
    };
    private Decimal[] sCheque = new Decimal[36];
    private Decimal sTReceivedAmountActual;
    private Decimal TAccManagerShouldPay;
    private Decimal sRTActualBond;
    private Decimal sBalanceDepositAdvance;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public gsalesroom_MTD_Nov06_mod gsalesroom_MTD_1;

    public ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.gsalesroom_MTD_1 = new gsalesroom_MTD_Nov06_mod();
    }

    public gsalesroom_MTD_Nov06_mod CHECK_GSALES_MONTHLY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_All(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public gsalesroom_MTD_Nov06_mod Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.gsalesroom_MTD_1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM GDSales";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into GDSales(TransID,ClientID,ForeName,SurName,RoomNo,CardNo,ReserveRef,TransType,TransDate, ChargeType,PreviousAdvance,AdvancedPayment,Bond,RBA,Deposit,KeyDeposit,ExtraCharge,RoomCharge,BonusClaim,GST,LastPayment,StaffID) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.RBA,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID From ( CardTrans INNER JOIN Client ON CardTrans.ClientID=Client.ClientID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY CardTrans.RoomNo";
      else
        oleDbCommand.CommandText = "Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.RBA,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID From ( CardTrans INNER JOIN Client ON CardTrans.ClientID=Client.ClientID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY CardTrans.RoomNo";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      if (ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      foreach (TempDataSet.GDSalesRow row in (InternalDataCollectionBase) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.Rows)
      {
        try
        {
          if (row.RBA.ToString() == "0")
            row.RBA = 0.00M;
        }
        catch
        {
          row.RBA = 0.00M;
        }
        try
        {
          if (row.Deposit.ToString() == "0")
            row.Deposit = 0.00M;
        }
        catch
        {
          row.Deposit = 0.00M;
        }
        try
        {
          if (row.KeyDeposit.ToString() == "0")
            row.KeyDeposit = 0.00M;
        }
        catch
        {
          row.KeyDeposit = 0.00M;
        }
        try
        {
          if (row.ExtraCharge.ToString() == "0")
            row.ExtraCharge = 0.00M;
        }
        catch
        {
          row.ExtraCharge = 0.00M;
        }
        try
        {
          if (row.Bond.ToString() == "0")
            row.Bond = 0.00M;
        }
        catch
        {
          row.Bond = 0.00M;
        }
        try
        {
          if (row.RoomCharge.ToString() == "0")
            row.RoomCharge = 0.00M;
        }
        catch
        {
          row.RoomCharge = 0.00M;
        }
        try
        {
          if (row.AdvancedPayment.ToString() == "0")
            row.AdvancedPayment = 0.00M;
        }
        catch
        {
          row.AdvancedPayment = 0.00M;
        }
        try
        {
          if (row.LastPayment.ToString() == "0")
            row.LastPayment = 0.00M;
        }
        catch
        {
          row.LastPayment = 0.00M;
        }
      }
      this.Insert_ErrorRecords();
      this.Insert_Banking_Temp();
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[23].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[24].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields[25].Text = "\"" + para_ReportType + "\"";
      this.CHECK_MONTHLY_DETAIL();
      this.CHECK_ERROR_RECORDS();
      this.TOTALCALCULATION();
      this.ASSIGN_REPORT_FORMULAR();
      this.INSERT_CHEQUE_FORMULAR();
      this.Delete_All_Sales_Record();
      return this.gsalesroom_MTD_1;
    }

    public gsalesroom_MTD_Nov06_mod Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.gsalesroom_MTD_1;
    }

    private void Delete_All_Sales_Record()
    {
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM GDSales";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
    }

    private void INSERT_CHEQUE_FORMULAR()
    {
      bool flag = false;
      for (int index = 0; index < 36; ++index)
      {
        if (this.sChequeNo[index] != "" || this.sCheque[index] != 0M)
        {
          flag = true;
          ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["ChequeNo" + (index + 1).ToString()].Text = "\"" + this.sChequeNo[index] + "\"";
          ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["Cheque" + (index + 1).ToString()].Text = "\"" + this.sCheque[index].ToString("F2") + "\"";
        }
      }
      if (!flag)
        return;
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["ChequeDetail"].Text = "\"Online Details..\"";
    }

    private void Insert_ErrorRecords()
    {
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM ErrorRecords";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.errorRecordsTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into ErrorRecords  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM Erradjust in '" + Application.UserAppDataPath + "\\ErradjustDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Erradjust.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(Erradjust.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY Erradjust.PaymentNoteNo";
      else
        oleDbCommand.CommandText = "SELECT * FROM Erradjust in '" + Application.UserAppDataPath + "\\ErradjustDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Erradjust.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(Erradjust.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY Erradjust.PaymentNoteNo";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.erradjustTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords);
      if (!ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        return;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.errorRecordsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords);
    }

    private void Insert_Banking_Temp()
    {
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM Banking_Temp";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.banking_TempTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into Banking_Temp  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM Banking in '" + Application.UserAppDataPath + "\\BankingDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Banking.Date  Between # " + this.start_Date + " # AND # " + this.End_date + "#";
      else
        oleDbCommand.CommandText = "SELECT * FROM Banking in '" + Application.UserAppDataPath + "\\BankingDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Banking.Date  Between # " + this.start_Date + " # AND # " + this.End_date + "#";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bankingTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Banking_Temp.Clear();
      int num = new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Banking_Temp);
      if (ADMIN_ReportClass_GSALES_MONTHLY_gsalesroom2_mtd.Temp_MDB_SaveFlag)
        num = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.banking_TempTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Banking_Temp);
      int index = 0;
      this.sOnline = 0M;
      this.sCash = 0M;
      this.sManagementFee = 0M;
      this.sOtherFee = 0M;
      foreach (TempDataSet.Banking_TempRow row in (InternalDataCollectionBase) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Banking_Temp.Rows)
      {
        this.sCodeDesc = row.CodeDesc;
        if (this.sCodeDesc == "Online")
        {
          this.sChequeNo[index] = row.ChequeNo;
          this.sCheque[index] = row.Amount;
          ++index;
        }
        else if (this.sCodeDesc == "Cash")
          this.sCash += row.Amount;
        else if (this.sCodeDesc == "Bank")
          this.sCash += row.Amount;
        else if (this.sCodeDesc == "MngFee")
          this.sManagementFee += row.Amount;
        else if (this.sCodeDesc == "OtherFee")
          this.sOtherFee += row.Amount;
      }
    }

    private void CHECK_MONTHLY_DETAIL()
    {
      int replacementCardCount = this.db.Get_Replacement_CardCount();
      this.TReplacement = 0;
      foreach (TempDataSet.GDSalesRow row1 in (InternalDataCollectionBase) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.Rows)
      {
        if (replacementCardCount > 0)
        {
          foreach (ReplacementDB1DataSet.ReplacementRow row2 in (InternalDataCollectionBase) this.db.replacement_DB1.replacementDB1DataSet.Replacement.Rows)
          {
            if (row2.ReceiptID == row1.TransID && row2.CardNo == row1.CardNo)
            {
              ++this.TReplacement;
              break;
            }
          }
        }
        this.sTransType = row1.TransType;
        if (this.sTransType == "IA")
        {
          ++this.Extra;
          this.NKeyDeposit += row1.KeyDeposit;
        }
        else if (this.sTransType == "R")
          ++this.Reserve;
        else if (this.sTransType == "IL" || this.sTransType == "AL" || this.sTransType == "TL" || this.sTransType == "EL" || this.sTransType == "EA" || this.sTransType == "TA")
        {
          ++this.Loss;
          this.NKeyDeposit += row1.KeyDeposit;
        }
        else if (this.sTransType == "CC")
          ++this.CancelCard;
        else if (this.sTransType == "RC")
          ++this.CancelReserve;
        else if (this.sTransType == "I")
        {
          ++this.NormalIssue;
          this.NKeyDeposit += row1.KeyDeposit;
        }
        else if (this.sTransType == "NE" || this.sTransType == "IS" || this.sTransType == "IU")
          this.NKeyDeposit += row1.KeyDeposit;
        switch (this.sTransType)
        {
          case "R":
            if (row1.Deposit != 0M)
              this.sDeposit += row1.Deposit;
            if (row1.LastPayment != 0M)
            {
              this.sLastPayment += row1.LastPayment;
              break;
            }
            break;
          case "RC":
            if (row1.Deposit != 0M)
              this.SDepositRefund += row1.Deposit;
            if (row1.LastPayment != 0M)
              this.sLastPayment += row1.LastPayment;
            if (row1.ExtraCharge != 0M)
            {
              this.sExtraCharge += row1.ExtraCharge;
              break;
            }
            break;
          case "CC":
            if (row1.Bond != 0M)
              this.sBondRefund += row1.Bond;
            if (row1.LastPayment != 0M)
              this.sLastPayment += row1.LastPayment;
            if (row1.KeyDeposit != 0M)
              this.sRefundKeyDeposit += row1.KeyDeposit;
            if (row1.RBA != 0M)
              this.sRBA += row1.RBA;
            if (row1.ExtraCharge != 0M)
              this.sExtraCharge += row1.ExtraCharge;
            if (row1.AdvancedPayment != 0M)
            {
              this.sAdvancedRefund = row1.AdvancedPayment;
              this.sAdvancedRefundAmount = -this.sAdvancedRefund;
              break;
            }
            break;
          case "CN":
            if (row1.Bond != 0M)
              this.sBondRefund += row1.Bond;
            if (row1.LastPayment != 0M)
              this.sLastPayment += row1.LastPayment;
            if (row1.RBA != 0M)
              this.sRBA += row1.RBA;
            if (row1.ExtraCharge != 0M)
              this.sExtraCharge += row1.ExtraCharge;
            if (row1.AdvancedPayment != 0M)
            {
              this.sAdvancedRefund += row1.AdvancedPayment;
              this.sAdvancedRefundAmount = -this.sAdvancedRefund;
              break;
            }
            break;
          default:
            if (row1.Bond != 0M)
              this.sBond += row1.Bond;
            if (row1.Deposit != 0M)
              this.sDeposit += row1.Deposit;
            if (row1.RoomCharge != 0M)
              this.sRoomCharge += row1.RoomCharge;
            if (row1.ExtraCharge != 0M)
              this.sExtraCharge += row1.ExtraCharge;
            if (row1.LastPayment != 0M)
              this.sLastPayment += row1.LastPayment;
            if (row1.AdvancedPayment != 0M)
            {
              this.sAdvancedPayment += row1.AdvancedPayment;
              break;
            }
            break;
        }
        if (row1.GST != 0M)
          this.GSTAmount += row1.GST;
      }
    }

    private void CHECK_ERROR_RECORDS()
    {
      this.sErrAmount = 0M;
      this.sError = 0M;
      this.sBondErrAmount = 0M;
      foreach (TempDataSet.ErrorRecordsRow errorRecord in ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords)
      {
        try
        {
          if (errorRecord.ErrAmount != 0M)
            this.sErrAmount += errorRecord.ErrAmount;
        }
        catch
        {
        }
        try
        {
          if (errorRecord.BondErrAmount != 0M)
            this.sBondErrAmount += errorRecord.BondErrAmount;
        }
        catch
        {
        }
        ++this.sError;
      }
    }

    private void TOTALCALCULATION()
    {
      this.TExtra = this.Extra;
      this.TLoss = this.Loss;
      this.TReserve = this.Reserve;
      this.TCancelCard = this.CancelCard;
      this.TCancelReserve = this.CancelReserve;
      this.TNormalIssue = this.NormalIssue;
      this.TKeyDeposit = this.NKeyDeposit;
      this.TAll = this.TExtra + this.TLoss + this.TNormalIssue;
      this.TDeposit = this.sDeposit + this.SDepositRefund;
      this.TBond = this.sBond;
      this.sKeyDeposit = !(this.NKeyDeposit != 0M) ? 0M : this.NKeyDeposit + this.sRefundKeyDeposit;
      this.TExtraCharge = this.sExtraCharge;
      this.TRoomCharge = this.sRoomCharge;
      this.TDepositRefund = this.SDepositRefund + this.sAdvancedRefund;
      this.TBondRefund = this.sBondRefund;
      this.TExtraReceived = this.TKeyCharge + this.TExtraCharge;
      this.sTLastPayment = this.sLastPayment;
      this.TBondReceived = this.TBond + this.TBondRefund;
      this.TRentalReceived = this.TRoomCharge + this.TKeyCharge;
      this.sTSalesGST = this.TExtraCharge + this.TRentalReceived;
      this.GSTAmount = this.sTSalesGST;
      this.sTError = this.sError;
      this.sTErrAmount = this.sErrAmount;
      Decimal num1 = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent);
      Decimal num2 = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gConstantGST);
      if (num1 != 0M)
      {
        this.sNewGSTRate = num1 + num2;
        this.sGSTAdjust = this.sErrAmount * num1 / this.sNewGSTRate;
      }
      else
        this.sGSTAdjust = 0M;
      this.GSTAmount = this.GSTAmount;
      this.TBankInReceived = this.sLastPayment - this.TBondReceived;
      this.sTotalActualFunds = this.TBankInReceived + this.sTErrAmount;
      if (this.sGSTAdjust < 0M)
        this.sGSTAdjust = -this.sGSTAdjust;
      this.sGST = this.GSTAmount + this.sErrAmount;
      this.sTBondErrAmount = this.sBondErrAmount;
      if (this.sAdvancedPayment < 0M && this.TDeposit < 0M)
      {
        this.sTReceivedAmountActual = this.sGST + this.sAdvancedPayment + this.TDeposit;
        this.sBalanceDepositAdvance = this.sAdvancedPayment + this.TDeposit;
      }
      else if (this.sAdvancedPayment < 0M && this.TDeposit >= 0M)
      {
        this.sTReceivedAmountActual = this.sGST + this.sAdvancedPayment;
        this.sBalanceDepositAdvance = this.sAdvancedPayment;
      }
      else if (this.sAdvancedPayment >= 0M && this.TDeposit < 0M)
      {
        this.sTReceivedAmountActual = this.sGST + this.TDeposit;
        this.sBalanceDepositAdvance = this.TDeposit;
      }
      else
      {
        this.sTReceivedAmountActual = this.sGST;
        this.sBalanceDepositAdvance = 0M;
      }
      this.sTActualBond = this.TBondReceived + this.sTBondErrAmount;
      this.sNewGSTRate = num1 + num2;
      this.sActualGST = this.sGST * num1 / this.sNewGSTRate;
      this.sActualTotal = this.sTotalActualFunds + this.sTActualBond;
      this.TCash = this.sCash;
      this.TCheque = 0M;
      for (int index = 0; index < 36; ++index)
        this.TCheque += this.sCheque[index];
      this.TOnline = this.sOnline;
      this.TNonGSTwithoutBond = this.sKeyDeposit + this.TDeposit + this.sAdvancedPayment;
      this.TBanking = this.TCash + this.TCheque;
    }

    private void ASSIGN_REPORT_FORMULAR()
    {
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TExtra"].Text = "\"" + Convert.ToInt16(this.TExtra).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TLoss"].Text = "\"" + Convert.ToInt16(this.TLoss).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TReserve"].Text = "\"" + Convert.ToInt16(this.TReserve).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TCancelCard"].Text = "\"" + Convert.ToInt16(this.TCancelCard).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TCancelReserve"].Text = "\"" + Convert.ToInt16(this.TCancelReserve).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TNormalIssue"].Text = "\"" + Convert.ToInt16(this.TNormalIssue).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TAll"].Text = "\"" + Convert.ToInt16(this.TAll).ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TReplacement"].Text = "\"" + this.TReplacement.ToString() + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TDeposit"].Text = "\"" + this.TDeposit.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBond"].Text = "\"" + this.TBond.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TExtraReceived"].Text = "\"" + this.TExtraReceived.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TRentalReceived"].Text = "\"" + this.TRentalReceived.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TDepositRefund"].Text = "\"" + this.TDepositRefund.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBondRefund"].Text = "\"" + this.TBondRefund.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBankInReceived"].Text = "\"" + this.TBankInReceived.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBondReceived"].Text = "\"" + this.TBondReceived.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["GSTAmount"].Text = "\"" + this.GSTAmount.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TKeyDeposit"].Text = "\"" + this.sKeyDeposit.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TAdvancedReceived"].Text = "\"" + this.sAdvancedPayment.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TSalesReceived"].Text = "\"" + this.sTLastPayment.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TotalError"].Text = "\"" + this.sTError.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TErrorAdjust"].Text = "\"" + this.sTErrAmount.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TotalActualFunds"].Text = "\"" + this.sTotalActualFunds.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["GSTAdjust"].Text = "\"" + this.sGSTAdjust.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["GST"].Text = "\"" + this.sGST.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBondAdjust"].Text = "\"" + this.sTBondErrAmount.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TActualBond"].Text = "\"" + this.sTActualBond.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TSalesGST"].Text = "\"" + this.sTSalesGST.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["ActualGST"].Text = "\"" + this.sActualGST.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["ActualTotal"].Text = "\"" + this.sActualTotal.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["ManagementFee"].Text = "\"" + this.sManagementFee.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["OtherFee"].Text = "\"" + this.sOtherFee.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TCheque"].Text = "\"" + this.TCheque.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TCash"].Text = "\"" + this.TCash.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TBanking"].Text = "\"" + this.TBanking.ToString("F2") + "\"";
      this.TAccManagerShouldPay = this.sActualTotal - (this.sManagementFee + this.sOtherFee) - this.sTActualBond;
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["sTReceivedAmountActual"].Text = "\"" + this.sTReceivedAmountActual.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TAccManagerShouldPay"].Text = "\"" + this.TAccManagerShouldPay.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["sRTActualBond"].Text = "\"" + this.sTActualBond.ToString("F2") + "\"";
      ((ReportDocument) this.gsalesroom_MTD_1).DataDefinition.FormulaFields["TNonGSTwithoutBond"].Text = "\"" + this.TNonGSTwithoutBond.ToString("F2") + "\"";
    }
  }
}
