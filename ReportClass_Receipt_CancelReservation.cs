// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_Receipt_CancelReservation
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
  internal class ReportClass_Receipt_CancelReservation
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private Decimal iDayRate;
    private Decimal iWeekRate;
    private Decimal iMonthRate;
    private string sDataFile = "";
    private string sReportFile = "";
    private string sStaffName = "";
    private string sLine1 = "";
    private string sLine2 = "";
    private string sLine3 = "";
    private string sLine4 = "";
    private string sPrevAdvance = "";
    private string sPrevAdvanceAmount = "";
    private string sBalanceAdvance = "";
    private string sTransGST = "";
    private string sDepositRpt = "";
    private string sBond = "";
    private string sKeyCharge = "";
    private string sExtraCharge = "";
    private string sExtraDisplay = "";
    private string sRoomCharge = "";
    private string sAmountDueRpt = "";
    private string sKeyDepositRpt = "";
    private string sTransCode = "";
    private string sTransDesc = "";
    private string sRBA = "";
    private string sBonusDesc = "";
    private string sBonusClaim = "";
    private string sTotalPaidRpt = "";
    private string sAdvancedPayment = "";
    private string sExDescription = "";
    private string GSTonTotalPaid = "";
    private string GSTDisplay = "";
    private string sName1 = "";
    private string sName2 = "";
    private string sName3 = "";
    private string sName4 = "";
    private string sName5 = "";
    private string sName6 = "";
    private string sName7 = "";
    private string sName8 = "";
    private string sKeyName = "";
    private string sChargeType = "";
    private string sChargeTypeDesc = "";
    private string sCheckInDate = "";
    private string sCheckInDateDesc = "";
    private string sNewGSTRate = "";
    private string sOldGSTRate = "";
    private string sAdvancedCalculated = "";
    private string sGSTRoomCharge = "";
    private string sGSTKeyCharge = "";
    private string sGSTExtraCharge = "";
    private string sGSTAdvancedPayment = "";
    private string sAmountDueDesc = "";
    private string sTotalPaidDesc = "";
    private string sCurrentStartDay = "";
    private string sCurrentEndDay = "";
    private string sLastStartDay = "";
    private string sLastEndDay = "";
    private string sRoomNoRpt = "";
    private string sCurrentAmount = "";
    private string sLastAmount = "";
    private string sMiddleAmount = "";
    private string sRoomStartDays = "";
    private string sRoomEndDays = "";
    private string sTotal = "";
    private Decimal iCurrent;
    private Decimal iExtraLast;
    private int iTotal;
    private string sOldRoomNo = "";
    private string sOldRoomName = "";
    private string sPrevBalance = "";
    private string sPrevBalanceAmount = "";
    private string sCondition = "";
    private bool bPrintReceipt;
    private string sReceiptID = "";
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public receipt2_shl receipt2_1;
    public checkoutreceipt checkoutreceipt_1;
    public receipt1_shl receipt1_1;
    public paymentnote paymentnote_1;

    public ReportClass_Receipt_CancelReservation()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.receipt2_1 = new receipt2_shl();
      this.checkoutreceipt_1 = new checkoutreceipt();
      this.receipt1_1 = new receipt1_shl();
      this.paymentnote_1 = new paymentnote();
    }

    public object CHECK_TransType(
      string para_sTransCode,
      int para_iTransID,
      string para_BuildingNo)
    {
      this.DATA_INITIALISE();
      return (object) this.Check_Report_TransCode_RC(para_iTransID, para_BuildingNo);
    }

    private void DATA_INITIALISE()
    {
      this.sName1 = "Deposit";
      this.sName2 = "Bond";
      this.sName3 = "Key Charge";
      this.sName4 = "";
      this.sName6 = "Current Advanced Payment";
      this.sName7 = ":";
      this.sName8 = ":";
      this.sKeyName = " Key Deposit";
      this.GSTDisplay = "GST Amount";
      this.sChargeTypeDesc = "Charge Type";
      this.sCheckInDateDesc = "Check In Date";
      this.sAmountDueDesc = "AMOUNT DUE";
      this.sTotalPaidDesc = "TOTAL PAID";
      this.sDepositRpt = "0";
      this.sKeyDepositRpt = "0";
      this.sBond = "0";
      this.sKeyCharge = "0";
      this.sExtraCharge = "0";
      this.sExDescription = "";
      this.sTotalPaidRpt = "0";
      this.sAdvancedPayment = "0";
      this.sAmountDueRpt = "0";
      this.GSTonTotalPaid = "0";
      this.sChargeType = "";
      this.sCheckInDate = "";
      this.sNewGSTRate = "0";
      this.sOldGSTRate = "0";
      this.sAdvancedCalculated = "0";
      this.sGSTAdvancedPayment = "0";
      this.sGSTKeyCharge = "0";
      this.sGSTRoomCharge = "0";
      this.sGSTExtraCharge = "0";
      this.sRBA = "";
      this.sPrevBalance = "Previous Room Balance";
      this.sPrevBalanceAmount = "0";
      this.sCurrentAmount = "0";
      this.sMiddleAmount = "0";
      this.sLastAmount = "0";
      this.sRoomCharge = "0";
      this.sRoomNoRpt = "";
      this.sName5 = "Room Charge Difference";
      this.sRoomStartDays = "";
      this.sRoomEndDays = "";
      this.sTotal = "";
      this.sCurrentStartDay = "";
      this.sCurrentEndDay = "";
      this.sLastStartDay = "";
      this.sLastEndDay = "";
      this.iCurrent = 0M;
      this.iExtraLast = 0M;
      this.iTotal = 0;
      this.sTransCode = "";
      this.sTransDesc = "";
      this.sStaffName = "";
      this.sLine1 = "";
      this.sLine2 = "";
      this.sLine3 = "";
      this.sPrevAdvance = "Previous Advanced Payment";
      this.sPrevAdvanceAmount = "0";
      this.sBalanceAdvance = "0";
      this.sTransGST = "0";
      this.sExtraDisplay = "";
      for (int index = 0; index <= 4; ++index)
      {
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index] = "";
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index] = "0";
      }
      this.sBonusDesc = "";
      this.sBonusClaim = "0";
      this.sCondition = "";
      this.sOldRoomNo = "";
      this.sOldRoomName = "";
    }

    private checkoutreceipt Check_Report_TransCode_RC(int para_iTransID, string para_BuildingNo)
    {
      ((ReportDocument) this.checkoutreceipt_1).SetDataSource(this.db.temp_DB.tempDataSet.Receipt.DataSet);
      this.db.Local_Command.CommandText = "Delete * from Receipt";
      this.db.Local_Command.Connection = this.db.temp_DB.receiptTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_Receipt_CancelReservation.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into Receipt(TransID,ClientID,ForeName,SurName,CardNo,OldRoom,ReserveRef,RoomNo,Condition,PreviousAdvance,AdvancedPayment,Balance,Bond,RBA,Deposit,KeyDeposit,ExtraCharge,ExDescription,RoomCharge,TransType,TransDate,TransTime,ValidStart,ValidEnd,CheckInDate,ChargeType,BonusClaim,GST,LastPayment,StaffID)in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select LastTrans.TransID,LastTrans.ClientID,Client.ForeName,Client.SurName,LastTrans.CardNo,LastTrans.OldRoom,LastTrans.ReserveRef,LastTrans.RoomNo,LastTrans.Condition,LastTrans.PreviousAdvance,LastTrans.AdvancedPayment,LastTrans.Balance,LastTrans.Bond,LastTrans.RBA,LastTrans.Deposit,LastTrans.KeyDeposit,LastTrans.ExtraCharge,LastTrans.ExDescription,LastTrans.RoomCharge,LastTrans.TransType,LastTrans.TransDate,LastTrans.TransTime,LastTrans.ValidStart,LastTrans.ValidEnd,LastTrans.CheckInDate,LastTrans.ChargeType,LastTrans.BonusClaim,LastTrans.GST,LastTrans.LastPayment,LastTrans.StaffID From ( LastTrans INNER JOIN Client ON LastTrans.ClientID=Client.ClientID) Where ((Right(LastTrans.ClientID,4)>'5000'))";
      this.db.Local_Command.Connection = this.db.building_DB1.clientAccTableAdapter.Connection;
      this.db.temp_DB.tempDataSet.Receipt.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) this.db.temp_DB.tempDataSet.Receipt);
      if (ReportClass_Receipt_CancelReservation.Temp_MDB_SaveFlag)
        this.db.temp_DB.receiptTableAdapter.Fill(this.db.temp_DB.tempDataSet.Receipt);
      this.CHECK_NULL(para_BuildingNo);
      this.TOTAL_AMOUNTDUE();
      ((ReportDocument) this.checkoutreceipt_1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.checkoutreceipt_1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName + "\"";
      ((ReportDocument) this.checkoutreceipt_1).DataDefinition.FormulaFields["StaffName"].Text = "\"" + this.sStaffName + "\"";
      this.FORMULAR_ASSIGNMENT_checkoutreceipt((ReportClass) this.checkoutreceipt_1);
      this.Check_ExtraCharge_Details((ReportClass) this.checkoutreceipt_1);
      return this.checkoutreceipt_1;
    }

    private void FORMULAR_ASSIGNMENT_checkoutreceipt(ReportClass para_ReportClass_checkoutreceipt)
    {
      try
      {
        if (Convert.ToDecimal(this.sDepositRpt) != 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[3].Text = "\"" + this.sName1 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[10].Text = "\"" + Convert.ToDecimal(this.sDepositRpt).ToString() + "\"";
        }
        else
        {
          this.sName1 = "";
          this.sDepositRpt = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[3].Text = "\"" + this.sName1 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[10].Text = "\"" + this.sDepositRpt + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sBond) != 0M)
        {
          if (Convert.ToDecimal(this.sBond) > 0M)
            this.sName2 = this.sTransCode == "E" || this.sTransCode == "EL" || this.sTransCode == "NE" ? "Bond Add" : "Bond";
          else if (Convert.ToDecimal(this.sBond) < 0M)
            this.sName2 = this.sTransCode == "E" || this.sTransCode == "EL" || this.sTransCode == "NE" ? "Bond Reduce" : "Bond Refund";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[4].Text = "\"" + this.sName2 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[11].Text = "\"" + Convert.ToDecimal(this.sBond).ToString() + "\"";
        }
        else if (Convert.ToDecimal(this.sRBA) != 0M)
        {
          this.sName2 = "Bond to Refund By RTBA";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[4].Text = "\"" + this.sName2 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[11].Text = "\"" + Convert.ToDecimal(this.sRBA).ToString() + "\"";
        }
        else
        {
          this.sName2 = "";
          this.sRBA = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[4].Text = "\"" + this.sName2 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[11].Text = "\"" + this.sRBA + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sExtraCharge) != 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[13].Text = "\"" + Convert.ToDecimal(this.sExtraCharge).ToString() + "\"";
          if (this.sExDescription != "")
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[17].Text = "\"" + this.sExDescription + "\"";
        }
        else
        {
          this.sExtraCharge = "";
          this.sExDescription = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[13].Text = "\"" + this.sExtraCharge + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[17].Text = "\"" + this.sExDescription + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (!(this.sTransCode == "T"))
        {
          if (!(this.sTransCode == "TL"))
            goto label_28;
        }
        if (Convert.ToDecimal(this.sRoomCharge) > 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[7].Text = "\"" + this.sName5 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[14].Text = "\"" + Convert.ToDecimal(this.sRoomCharge).ToString() + "\"";
        }
        else
        {
          this.sName5 = "";
          this.sRoomCharge = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[7].Text = "\"" + this.sName5 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[14].Text = "\"" + this.sRoomCharge + "\"";
        }
        if (Convert.ToDecimal(this.sRBA) != 0M)
        {
          this.sName2 = "Bond to Refund By RTBA";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[4].Text = "\"" + this.sName2 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[11].Text = "\"" + Convert.ToDecimal(this.sRBA).ToString() + "\"";
        }
        else
        {
          this.sName2 = "";
          this.sRBA = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[4].Text = "\"" + this.sName2 + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[11].Text = "\"" + this.sRBA + "\"";
        }
      }
      catch
      {
      }
label_28:
      try
      {
        if (Convert.ToDecimal(this.sBalanceAdvance) > 0M)
        {
          if (!(this.sTotalPaidRpt == "0") || !(this.sPrevAdvanceAmount == this.sBalanceAdvance))
          {
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[9].Text = "\"" + this.sName6 + "\"";
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[16].Text = "\"" + Convert.ToDecimal(this.sBalanceAdvance).ToString() + "\"";
          }
          else
          {
            this.sName6 = "";
            this.sBalanceAdvance = "";
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[9].Text = "\"" + this.sName6 + "\"";
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[16].Text = "\"" + this.sBalanceAdvance + "\"";
          }
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sTotalPaidRpt) != 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[15].Text = "\"" + Convert.ToDecimal(this.sTotalPaidRpt).ToString() + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[26].Text = "\"" + this.sTotalPaidDesc + "\"";
        }
        else
        {
          this.sTotalPaidRpt = "";
          this.sTotalPaidDesc = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[15].Text = "\"" + this.sTotalPaidRpt + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[26].Text = "\"" + this.sTotalPaidDesc + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sTransGST) > 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[8].Text = "\"" + Convert.ToDecimal(this.sTransGST).ToString() + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[18].Text = "\"" + this.GSTDisplay + "\"";
        }
        else
        {
          this.sTransGST = "";
          this.GSTDisplay = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[8].Text = "\"" + this.sTransGST + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[18].Text = "\"" + this.GSTDisplay + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (this.sChargeType != "")
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeType"].Text = "\"" + this.sChargeType + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeTypeDesc"].Text = "\"" + this.sChargeTypeDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeTypeColon"].Text = "\"" + this.sName7 + "\"";
        }
        else
        {
          this.sChargeType = "";
          this.sChargeTypeDesc = "";
          this.sName7 = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeType"].Text = "\"" + this.sChargeType + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeTypeDesc"].Text = "\"" + this.sChargeTypeDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields["ChargeTypeColon"].Text = "\"" + this.sName7 + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (this.sCheckInDate != "")
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[20].Text = "\"" + this.sCheckInDate + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[22].Text = "\"" + this.sCheckInDateDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[24].Text = "\"" + this.sName8 + "\"";
        }
        else
        {
          this.sCheckInDate = "";
          this.sCheckInDateDesc = "";
          this.sName8 = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[20].Text = "\"" + this.sCheckInDate + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[22].Text = "\"" + this.sCheckInDateDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[24].Text = "\"" + this.sName8 + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sAmountDueRpt) != 0M)
        {
          this.sLine1 = "______________";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[25].Text = "\"" + this.sAmountDueDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[2].Text = "\"" + Convert.ToDecimal(this.sAmountDueRpt).ToString() + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[27].Text = "\"" + this.sLine1 + "\"";
        }
        else
        {
          this.sAmountDueRpt = "";
          this.sAmountDueDesc = "";
          this.sLine1 = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[25].Text = "\"" + this.sAmountDueDesc + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[2].Text = "\"" + Convert.ToDecimal(this.sAmountDueRpt).ToString() + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[27].Text = "\"" + this.sLine1 + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDecimal(this.sKeyDepositRpt) != 0M)
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[28].Text = "\"" + this.sKeyName + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[29].Text = "\"" + Convert.ToDecimal(this.sKeyDepositRpt).ToString() + "\"";
        }
        else
        {
          this.sKeyName = "";
          this.sKeyDepositRpt = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[28].Text = "\"" + this.sKeyName + "\"";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[29].Text = "\"" + this.sKeyDepositRpt + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (this.sTransDesc != "")
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[31].Text = "\"" + this.sTransDesc + "\"";
        }
        else
        {
          this.sTransDesc = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[31].Text = "\"" + this.sTransDesc + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (this.sOldRoomNo != "")
        {
          if (this.sTransDesc == "Reservation")
          {
            this.sOldRoomName = "Previous Reserved Room No.";
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[34].Text = "\"" + this.sOldRoomName + "\"";
            ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[35].Text = "\"" + this.sOldRoomNo + "\"";
          }
        }
      }
      catch
      {
      }
      try
      {
        if (this.sCondition.Contains("Unit"))
        {
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[33].Text = "\"" + this.sCondition + "\"";
        }
        else
        {
          this.sCondition = "";
          ((ReportDocument) para_ReportClass_checkoutreceipt).DataDefinition.FormulaFields[33].Text = "\"" + this.sCondition + "\"";
        }
      }
      catch
      {
      }
    }

    private void Check_ExtraCharge_Details(ReportClass para_CrystalReport1)
    {
      try
      {
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] == "") || !(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0] == "0"))
        {
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[43].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[44].Text = "\"" + Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0]).ToString() + "\"";
        }
        else
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] = "";
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0] = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[43].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[44].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0] + "\"";
        }
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] == "") || !(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1] == "0"))
        {
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[45].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[46].Text = "\"" + Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1]).ToString() + "\"";
        }
        else
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] = "";
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1] = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[45].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[46].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1] + "\"";
        }
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] == "") || !(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2] == "0"))
        {
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[47].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[48].Text = "\"" + Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2]).ToString() + "\"";
        }
        else
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] = "";
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2] = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[47].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[48].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2] + "\"";
        }
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] == "") || !(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3] == "0"))
        {
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[49].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[50].Text = "\"" + Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3]).ToString() + "\"";
        }
        else
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] = "";
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3] = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[49].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[50].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3] + "\"";
        }
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] == "") || !(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4] == "0"))
        {
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[51].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[52].Text = "\"" + Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4]).ToString() + "\"";
        }
        else
        {
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] = "";
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4] = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[51].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[52].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4] + "\"";
        }
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] != "" || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] != "" || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] != "" || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] != "" || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] != "")
        {
          this.sExtraDisplay = "Extra Charges Details..";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[53].Text = "\"" + this.sExtraDisplay + "\"";
        }
        else
        {
          this.sExtraDisplay = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[53].Text = "\"" + this.sExtraDisplay + "\"";
        }
      }
      catch
      {
      }
      try
      {
        if (!(Convert.ToDecimal(this.sBonusClaim) == 0M))
        {
          this.sBonusDesc = "Entitled Bonus**";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[54].Text = "\"" + this.sBonusDesc + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[55].Text = "\"" + Convert.ToDecimal(this.sBonusClaim).ToString() + "\"";
        }
        else
        {
          this.sBonusDesc = "";
          this.sBonusClaim = "";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[54].Text = "\"" + this.sBonusDesc + "\"";
          ((ReportDocument) para_CrystalReport1).DataDefinition.FormulaFields[55].Text = "\"" + this.sBonusClaim + "\"";
        }
      }
      catch
      {
      }
    }

    private string Get_StaffName()
    {
      string staffName = "";
      TempDataSet.ReceiptRow row1 = (TempDataSet.ReceiptRow) this.db.temp_DB.tempDataSet.Receipt.Rows[0];
      if (this.db.staff_DB.staffDataSet.Staff.Rows.Count <= 0)
        this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
      foreach (StaffDataSet.StaffRow row2 in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        if (row2.StaffID == row1.StaffID)
        {
          staffName = row2.SForeName + "  " + row2.SSurName;
          break;
        }
      }
      return staffName;
    }

    private string SELECT_MONTH(string para_Month_Num)
    {
      string str = "";
      switch (para_Month_Num)
      {
        case "01":
          str = "January";
          break;
        case "02":
          str = "February";
          break;
        case "03":
          str = "March";
          break;
        case "04":
          str = "April";
          break;
        case "05":
          str = "May";
          break;
        case "06":
          str = "June";
          break;
        case "07":
          str = "July";
          break;
        case "08":
          str = "August";
          break;
        case "09":
          str = "September";
          break;
        case "10":
          str = "October";
          break;
        case "11":
          str = "November";
          break;
        case "12":
          str = "December";
          break;
      }
      return str;
    }

    private void CHECK_NULL(string para_BuildingNo)
    {
      this.sStaffName = this.Get_StaffName();
      TempDataSet.ReceiptRow row1 = (TempDataSet.ReceiptRow) this.db.temp_DB.tempDataSet.Receipt.Rows[0];
      try
      {
        this.sDepositRpt = !(row1.Deposit != 0M) ? "0" : row1.Deposit.ToString();
      }
      catch
      {
        this.sDepositRpt = "0";
      }
      try
      {
        this.sKeyDepositRpt = !(row1.KeyDeposit != 0M) ? "0" : row1.KeyDeposit.ToString();
      }
      catch
      {
        this.sKeyDepositRpt = "0";
      }
      try
      {
        this.sBond = !(row1.Bond != 0M) ? "0" : row1.Bond.ToString();
      }
      catch
      {
        this.sBond = "0";
      }
      try
      {
        this.sRBA = !(row1.RBA != 0M) ? "0" : row1.RBA.ToString();
      }
      catch
      {
        this.sRBA = "0";
      }
      try
      {
        this.sPrevBalanceAmount = !(row1.Balance != 0M) ? "0" : row1.Balance.ToString();
      }
      catch
      {
        this.sPrevBalanceAmount = "0";
      }
      try
      {
        this.sExtraCharge = !(row1.ExtraCharge != 0M) ? "0" : row1.ExtraCharge.ToString();
      }
      catch
      {
        this.sExtraCharge = "0";
      }
      try
      {
        this.sRoomCharge = !(row1.RoomCharge != 0M) ? "0" : row1.RoomCharge.ToString();
      }
      catch
      {
        this.sRoomCharge = "0";
      }
      try
      {
        this.sTotalPaidRpt = !(row1.LastPayment != 0M) ? "0" : row1.LastPayment.ToString();
      }
      catch
      {
        this.sTotalPaidRpt = "0";
      }
      try
      {
        this.sPrevAdvanceAmount = !(row1.PreviousAdvance != 0M) ? "0" : row1.PreviousAdvance.ToString();
      }
      catch
      {
        this.sPrevAdvanceAmount = "0";
      }
      try
      {
        this.sAdvancedPayment = !(row1.AdvancedPayment != 0M) ? "0" : row1.AdvancedPayment.ToString();
      }
      catch
      {
        this.sAdvancedPayment = "0";
      }
      this.sBalanceAdvance = (Convert.ToDecimal(this.sPrevAdvanceAmount) + Convert.ToDecimal(this.sAdvancedPayment)).ToString();
      try
      {
        this.sTransGST = !(row1.GST != 0M) ? "0" : row1.GST.ToString();
      }
      catch
      {
        this.sTransGST = "0";
      }
      try
      {
        this.sBonusClaim = !(row1.BonusClaim != 0M) ? "0" : row1.BonusClaim.ToString();
      }
      catch
      {
        this.sBonusClaim = "0";
      }
      try
      {
        this.sExDescription = !(row1.ExDescription != "") ? "" : row1.ExDescription;
      }
      catch
      {
        this.sExDescription = "";
      }
      try
      {
        this.sChargeType = !(row1.ChargeType != "") ? "" : row1.ChargeType;
      }
      catch
      {
        this.sChargeType = "";
      }
      try
      {
        if (row1.Condition != "")
        {
          this.sCondition = row1.Condition;
          this.sCondition = this.sCondition + "-" + (!(row1.RoomNo != "") ? "" : row1.RoomNo.Substring(1, 2));
        }
        else
          this.sCondition = "";
      }
      catch
      {
        this.sCondition = "";
      }
      try
      {
        this.sOldRoomNo = !(row1.OldRoom != "") ? "" : row1.OldRoom;
      }
      catch
      {
        this.sOldRoomNo = "";
      }
      try
      {
        this.sCheckInDate = row1.CheckInDate.ToShortDateString();
      }
      catch
      {
        this.sCheckInDate = "";
      }
      int num1 = row1.TransID;
      this.sReceiptID = num1.ToString();
      if (!(row1.TransType == "I"))
      {
        if (!(row1.TransType == "E"))
        {
          if (!(row1.TransType == "NE"))
          {
            if (!(row1.TransType == "EL"))
            {
              if (!(row1.TransType == "T"))
              {
                if (!(row1.TransType == "TL"))
                  goto label_46;
              }
            }
          }
        }
      }
      try
      {
        this.sRoomNoRpt = !(row1.RoomNo != "") ? "" : row1.RoomNo;
      }
      catch
      {
        this.sRoomNoRpt = "";
      }
label_46:
      if (this.sRoomNoRpt.Length > 0)
      {
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
        foreach (SystemDataSet.RoomRow row2 in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
        {
          if (row2.RoomNo == this.sRoomNoRpt)
          {
            string roomTypeDescription = this.db.Get_RoomType_Description(row2.RoomType);
            if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
            {
              if (row2.TotalStay == (byte) 1)
              {
                this.iDayRate = row2.DailyRate;
                this.iWeekRate = row2.WeeklyRate;
                this.iMonthRate = row2.MonthlyRate;
                break;
              }
              if (row2.TotalStay == (byte) 2)
              {
                this.iDayRate = row2.DailyRate2;
                this.iWeekRate = row2.WeeklyRate2;
                this.iMonthRate = row2.MonthlyRate2;
                break;
              }
              break;
            }
            this.iDayRate = row2.DailyRate;
            this.iWeekRate = row2.WeeklyRate;
            this.iMonthRate = row2.MonthlyRate;
            break;
          }
        }
      }
      if (!(row1.TransType == "T"))
      {
        if (!(row1.TransType == "TL"))
        {
          try
          {
            this.sCurrentStartDay = row1.ValidStart.ToShortDateString();
            goto label_65;
          }
          catch
          {
            goto label_65;
          }
        }
      }
      this.sCurrentStartDay = DateTime.Now.ToShortDateString();
label_65:
      try
      {
        this.sLastEndDay = row1.ValidEnd.ToShortDateString();
      }
      catch
      {
      }
      this.iCurrent = 0M;
      this.iExtraLast = 0M;
      this.iTotal = 0;
      try
      {
        switch (row1.ChargeType)
        {
          case "D":
            this.iTotal = this.db.Get_No_Of_Days(DateTime.Parse(this.sCurrentStartDay), DateTime.Parse(this.sLastEndDay));
            this.sTotal = this.iTotal == 0 ? "" : (this.iTotal != 1 ? "Total ( " + this.iTotal.ToString() + " ) Days Rental" : "Total ( " + this.iTotal.ToString() + " ) Day Rental");
            this.sCurrentAmount = "";
            this.sMiddleAmount = (this.iDayRate * (Decimal) this.iTotal).ToString();
            this.sLastAmount = "";
            this.sRoomStartDays = "";
            this.sRoomEndDays = "";
            break;
          case "W":
            this.iTotal = this.db.Get_No_Of_Days(DateTime.Parse(this.sCurrentStartDay), DateTime.Parse(this.sLastEndDay));
            this.iExtraLast = (Decimal) (this.iTotal % 7);
            this.iTotal /= 7;
            if (this.iTotal != 0)
            {
              if (this.iTotal == 1)
                this.sTotal = "From :" + this.sCurrentStartDay + " For ( " + this.iTotal.ToString() + " ) Week Rental";
              else
                this.sTotal = "From :" + this.sCurrentStartDay + " For ( " + this.iTotal.ToString() + " ) Weeks Rental";
            }
            else
              this.sTotal = "";
            this.sCurrentAmount = "";
            this.sRoomStartDays = "";
            this.sMiddleAmount = ((Decimal) this.iTotal * this.iWeekRate).ToString();
            if (this.iExtraLast == 0M)
            {
              this.sRoomEndDays = "";
              this.sLastAmount = "";
              break;
            }
            if (this.iTotal == 0 && this.iExtraLast == 1M)
              this.sRoomEndDays = "From " + this.sCurrentStartDay + " To " + this.sLastEndDay + "( " + (object) this.iExtraLast + "Day )";
            else if (this.iTotal == 0 && this.iExtraLast > 1M)
              this.sRoomEndDays = "From " + this.sCurrentStartDay + " To " + this.sLastEndDay + "( " + (object) this.iExtraLast + "Days )";
            else if (this.iTotal > 0)
            {
              int num2 = this.iTotal * 7;
              this.sLastStartDay = DateTime.Parse(this.sCurrentStartDay).AddDays((double) num2).ToShortDateString();
              if (this.iExtraLast == 1M)
                this.sRoomEndDays = "From " + this.sLastStartDay + " To " + this.sLastEndDay + "( " + (object) this.iExtraLast + "Day )";
              else
                this.sRoomEndDays = "From " + this.sLastStartDay + " To " + this.sLastEndDay + "( " + (object) this.iExtraLast + "Days )";
            }
            this.sLastAmount = 0M.ToString();
            this.sLastAmount = (Convert.ToDecimal(this.sLastAmount) * this.iExtraLast).ToString();
            break;
          case "M":
            DateTime para_Start_Date1 = DateTime.Parse(this.sCurrentStartDay);
            DateTime now = DateTime.Now;
            DateTime para_End_Date1 = DateTime.Parse(this.sLastEndDay);
            if (DateTime.Parse(this.sCurrentStartDay).Year == para_End_Date1.Year)
            {
              if (DateTime.Parse(this.sCurrentStartDay).Day != 1 && DateTime.Parse(this.sCurrentStartDay).Month < para_End_Date1.Month)
              {
                if (DateTime.Parse(this.sCurrentStartDay).Month == 12)
                {
                  this.iCurrent = (Decimal) this.db.Get_No_Of_Days(para_Start_Date1, DateTime.Parse((para_Start_Date1.Year + 1).ToString("D4") + "/01/01"));
                  this.sCurrentEndDay = (para_Start_Date1.Year + 1).ToString() + "/01/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                else
                {
                  this.iCurrent = (Decimal) this.db.Get_No_Of_Days(para_Start_Date1, DateTime.Parse(para_Start_Date1.Year.ToString("D4") + "/" + (para_Start_Date1.Month + 1).ToString("D2") + "/01"));
                  this.sCurrentEndDay = para_Start_Date1.Year.ToString("D4") + "/" + (para_Start_Date1.Month + 1).ToString("D2") + "/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                this.iExtraLast = para_End_Date1.Day <= 1 ? 0M : (Decimal) this.db.Get_No_Of_Days(DateTime.Parse(para_End_Date1.Year.ToString("D4") + "/" + para_End_Date1.Month.ToString("D2") + "/01"), para_End_Date1);
                this.iTotal = this.db.Get_Num_of_M_D_W(now, para_End_Date1, "Monthly");
              }
              else if (para_Start_Date1.Day != 1 || para_Start_Date1.Month != para_End_Date1.Month)
                this.iCurrent = (Decimal) this.db.Get_Num_of_M_D_W(para_Start_Date1, para_End_Date1, "Daily");
              else if (para_Start_Date1.Day == 1 && para_End_Date1.Day == 1)
                this.iTotal = this.db.Get_Num_of_M_D_W(para_Start_Date1, para_End_Date1, "Monthly");
              else if (para_Start_Date1.Day == 1 && para_End_Date1.Day > 1)
              {
                this.iTotal = this.db.Get_Num_of_M_D_W(para_Start_Date1, para_End_Date1, "Monthly");
                this.iExtraLast = (Decimal) this.db.Get_Num_of_M_D_W(DateTime.Parse(para_End_Date1.Year.ToString() + "/" + para_End_Date1.Month.ToString("D2") + "/01"), para_End_Date1, "Daily");
              }
            }
            else if (para_Start_Date1.Year < para_End_Date1.Year)
            {
              if (para_Start_Date1.Day != 1 || para_Start_Date1.Month <= para_End_Date1.Month)
              {
                if (para_Start_Date1.Month == 12)
                {
                  DB db = this.db;
                  DateTime para_Start_Date2 = para_Start_Date1;
                  num1 = para_Start_Date1.Year + 1;
                  DateTime para_End_Date2 = DateTime.Parse(num1.ToString() + "/01/01");
                  this.iCurrent = (Decimal) db.Get_No_Of_Days(para_Start_Date2, para_End_Date2);
                  num1 = para_Start_Date1.Year + 1;
                  this.sCurrentEndDay = num1.ToString() + "/01/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                else
                {
                  DB db = this.db;
                  DateTime para_Start_Date3 = para_Start_Date1;
                  num1 = para_Start_Date1.Year;
                  string str1 = num1.ToString();
                  num1 = para_Start_Date1.Month + 1;
                  string str2 = num1.ToString("D2");
                  DateTime para_End_Date3 = DateTime.Parse(str1 + "/" + str2 + "/01");
                  this.iCurrent = (Decimal) db.Get_No_Of_Days(para_Start_Date3, para_End_Date3);
                  num1 = para_Start_Date1.Year;
                  string str3 = num1.ToString();
                  num1 = para_Start_Date1.Month + 1;
                  string str4 = num1.ToString("D2");
                  this.sCurrentEndDay = str3 + "/" + str4 + "/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                if (para_End_Date1.Day > 1)
                {
                  DB db = this.db;
                  num1 = para_End_Date1.Year;
                  string str5 = num1.ToString();
                  num1 = para_End_Date1.Month;
                  string str6 = num1.ToString("D2");
                  DateTime para_Start_Date4 = DateTime.Parse(str5 + "/" + str6 + "/01");
                  DateTime para_End_Date4 = para_End_Date1;
                  this.iExtraLast = (Decimal) db.Get_No_Of_Days(para_Start_Date4, para_End_Date4);
                }
                else
                  this.iExtraLast = 0M;
                this.iTotal = this.db.Get_Num_of_M_D_W(now, para_End_Date1, "Monthly");
              }
              else if (para_Start_Date1.Day != 1 || para_Start_Date1.Month >= para_End_Date1.Month)
              {
                if (para_Start_Date1.Month == 12)
                {
                  DB db = this.db;
                  DateTime para_Start_Date5 = para_Start_Date1;
                  num1 = para_Start_Date1.Year + 1;
                  DateTime para_End_Date5 = DateTime.Parse(num1.ToString() + "/01/01");
                  this.iCurrent = (Decimal) db.Get_No_Of_Days(para_Start_Date5, para_End_Date5);
                  num1 = para_Start_Date1.Year + 1;
                  this.sCurrentEndDay = num1.ToString() + "/01/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                else
                {
                  DB db = this.db;
                  DateTime para_Start_Date6 = para_Start_Date1;
                  num1 = para_Start_Date1.Year;
                  string str7 = num1.ToString();
                  num1 = para_Start_Date1.Month + 1;
                  string str8 = num1.ToString("D2");
                  DateTime para_End_Date6 = DateTime.Parse(str7 + "/" + str8 + "/01");
                  this.iCurrent = (Decimal) db.Get_No_Of_Days(para_Start_Date6, para_End_Date6);
                  num1 = para_Start_Date1.Year;
                  string str9 = num1.ToString();
                  num1 = para_Start_Date1.Month + 1;
                  string str10 = num1.ToString("D2");
                  this.sCurrentEndDay = str9 + "/" + str10 + "/01";
                  now = DateTime.Parse(this.sCurrentEndDay);
                }
                if (para_End_Date1.Day > 1)
                {
                  DB db = this.db;
                  num1 = para_End_Date1.Year;
                  string str11 = num1.ToString();
                  num1 = para_End_Date1.Month;
                  string str12 = num1.ToString();
                  DateTime para_Start_Date7 = DateTime.Parse(str11 + "/" + str12 + "/01");
                  DateTime para_End_Date7 = para_End_Date1;
                  this.iExtraLast = (Decimal) db.Get_No_Of_Days(para_Start_Date7, para_End_Date7);
                }
                else
                  this.iExtraLast = 0M;
                this.iTotal = this.db.Get_Num_of_M_D_W(now, para_End_Date1, "Monthly");
              }
              else if (para_Start_Date1.Day != 1 || para_Start_Date1.Month != para_End_Date1.Month)
                this.iCurrent = (Decimal) this.db.Get_No_Of_Days(para_Start_Date1, para_End_Date1);
              else if (para_Start_Date1.Day == 1 && para_End_Date1.Day == 1)
                this.iTotal = this.db.Get_Num_of_M_D_W(para_Start_Date1, para_End_Date1, "Monthly");
              else if (para_Start_Date1.Day == 1 && para_End_Date1.Day > 1)
              {
                this.iTotal = this.db.Get_Num_of_M_D_W(para_Start_Date1, para_End_Date1, "Monthly");
                DB db = this.db;
                num1 = para_End_Date1.Year;
                string str13 = num1.ToString();
                num1 = para_End_Date1.Month;
                string str14 = num1.ToString();
                DateTime para_Start_Date8 = DateTime.Parse(str13 + "/" + str14 + "/01");
                DateTime para_End_Date8 = para_End_Date1;
                this.iExtraLast = (Decimal) db.Get_No_Of_Days(para_Start_Date8, para_End_Date8);
              }
            }
            string para_Month_Num1;
            if (this.iCurrent > 0M && this.iTotal > 0)
            {
              num1 = now.Month;
              para_Month_Num1 = num1.ToString();
            }
            else
            {
              num1 = para_Start_Date1.Month;
              para_Month_Num1 = num1.ToString();
            }
            if (para_Month_Num1.Length == 1)
              para_Month_Num1 = "0" + para_Month_Num1;
            string str15 = this.SELECT_MONTH(para_Month_Num1);
            num1 = para_End_Date1.Month;
            string para_Month_Num2 = num1.ToString();
            if (para_Month_Num2.Length == 1)
              para_Month_Num2 = "0" + para_Month_Num2;
            string str16 = this.SELECT_MONTH(para_Month_Num2);
            if (this.iTotal != 0)
            {
              if (this.iTotal == 1)
                this.sTotal = "For " + str15 + "( " + (object) this.iTotal + " ) Month Rental";
              else if (para_Start_Date1.Year == para_End_Date1.Year)
                this.sTotal = str15 + " To " + str16 + "( " + (object) this.iTotal + " ) Months Rental";
              else if (para_Start_Date1.Year < para_End_Date1.Year)
              {
                object[] objArray1 = new object[10]
                {
                  (object) str15,
                  (object) " ",
                  (object) para_Start_Date1.Year,
                  (object) " To ",
                  (object) str16,
                  (object) " ",
                  null,
                  null,
                  null,
                  null
                };
                object[] objArray2 = objArray1;
                num1 = para_End_Date1.Year;
                string str17 = num1.ToString();
                objArray2[6] = (object) str17;
                objArray1[7] = (object) "( ";
                objArray1[8] = (object) this.iTotal;
                objArray1[9] = (object) " ) Months Rental";
                this.sTotal = string.Concat(objArray1);
              }
            }
            else
              this.sTotal = "";
            this.sMiddleAmount = ((Decimal) this.iTotal * this.iMonthRate).ToString();
            if (this.iCurrent >= 1M)
            {
              this.sCurrentAmount = (Convert.ToDecimal(this.db.Get_DailyRate_From_MonthlyRate(this.iMonthRate)) * this.iCurrent).ToString();
              if (this.iCurrent == 1M && this.iTotal == 0)
                this.sRoomStartDays = "From " + this.sCurrentStartDay + " To " + this.sLastEndDay + "(" + (object) this.iCurrent + "Day)";
              else if (this.iCurrent == 1M && this.iTotal > 0)
                this.sRoomStartDays = "From " + this.sCurrentStartDay + " To " + this.sCurrentEndDay + "(" + (object) this.iCurrent + "Day)";
              else if (this.iCurrent > 1M && this.iTotal == 0)
              {
                if (this.iExtraLast == 0M)
                  this.sRoomStartDays = "From " + this.sCurrentStartDay + " To " + this.sLastEndDay + "(" + (object) this.iCurrent + "Days)";
                else
                  this.sRoomStartDays = "From " + this.sCurrentStartDay + " To " + this.sCurrentEndDay + "(" + (object) this.iCurrent + "Days)";
              }
              else if (this.iCurrent > 1M && this.iTotal > 0)
                this.sRoomStartDays = "From " + this.sCurrentStartDay + " To " + this.sCurrentEndDay + "(" + (object) this.iCurrent + "Days)";
            }
            if (this.iExtraLast == 0M)
            {
              this.sRoomEndDays = "";
              this.sLastAmount = "";
              break;
            }
            if (this.iExtraLast >= 1M)
            {
              this.sLastAmount = (Convert.ToDecimal(this.db.Get_DailyRate_From_MonthlyRate(this.iMonthRate)) * this.iExtraLast).ToString();
              if (para_End_Date1.Day == 1)
                this.sLastStartDay = this.sLastEndDay;
              else if (para_End_Date1.Day > 1)
              {
                num1 = para_End_Date1.Year;
                string str18 = num1.ToString();
                num1 = para_End_Date1.Month;
                string str19 = num1.ToString("D2");
                this.sLastStartDay = str18 + "/" + str19 + "/01";
              }
              if (this.iTotal == 0 && this.iExtraLast == 1M)
              {
                this.sRoomEndDays = "From " + this.sLastStartDay + " To " + this.sLastEndDay + "(" + (object) this.iExtraLast + "Day)";
                break;
              }
              if (this.iTotal == 0 && this.iExtraLast > 1M)
              {
                this.sRoomEndDays = "From " + this.sLastStartDay + " To " + this.sLastEndDay + "(" + (object) this.iExtraLast + "Days)";
                break;
              }
              if (this.iTotal > 0 && this.iExtraLast == 1M)
              {
                object[] objArray3 = new object[4]
                {
                  (object) "From 01/",
                  null,
                  null,
                  null
                };
                object[] objArray4 = objArray3;
                num1 = DateTime.Parse(this.sLastStartDay).Month;
                string str20 = num1.ToString("D2");
                objArray4[1] = (object) str20;
                objArray3[2] = (object) "/";
                object[] objArray5 = objArray3;
                object[] objArray6 = new object[6];
                object[] objArray7 = objArray6;
                num1 = para_End_Date1.Year;
                string str21 = num1.ToString();
                objArray7[0] = (object) str21;
                objArray6[1] = (object) " To ";
                objArray6[2] = (object) this.sLastEndDay;
                objArray6[3] = (object) "(";
                objArray6[4] = (object) this.iExtraLast;
                objArray6[5] = (object) "Day)";
                // ISSUE: variable of a boxed type
                DateTime local = DateTime.Parse(string.Concat(objArray6));
                objArray5[3] = (object) local;
                this.sRoomEndDays = string.Concat(objArray3);
                break;
              }
              if (this.iTotal > 0)
              {
                if (this.iExtraLast > 1M)
                {
                  object[] objArray8 = new object[4]
                  {
                    (object) "From 01/",
                    null,
                    null,
                    null
                  };
                  object[] objArray9 = objArray8;
                  num1 = DateTime.Parse(this.sLastStartDay).Month;
                  string str22 = num1.ToString("D2");
                  objArray9[1] = (object) str22;
                  objArray8[2] = (object) "/";
                  object[] objArray10 = objArray8;
                  object[] objArray11 = new object[6];
                  object[] objArray12 = objArray11;
                  num1 = para_End_Date1.Year;
                  string str23 = num1.ToString();
                  objArray12[0] = (object) str23;
                  objArray11[1] = (object) " To ";
                  objArray11[2] = (object) this.sLastEndDay;
                  objArray11[3] = (object) "(";
                  objArray11[4] = (object) this.iExtraLast;
                  objArray11[5] = (object) "Days)";
                  // ISSUE: variable of a boxed type
                  DateTime local = DateTime.Parse(string.Concat(objArray11));
                  objArray10[3] = (object) local;
                  this.sRoomEndDays = string.Concat(objArray8);
                  break;
                }
                break;
              }
              break;
            }
            break;
        }
      }
      catch
      {
      }
      if (row1.TransType != "")
        this.sTransCode = row1.TransType;
      switch (this.sTransCode)
      {
        case "I":
          this.sTransDesc = "Issued Major Key";
          break;
        case "IA":
          this.sTransDesc = "Issue Additional/Spare Key";
          break;
        case "L":
          this.sTransDesc = "Loss Major Key Replacement";
          break;
        case "AL":
          this.sTransDesc = "Loss Spare Key Replacement";
          break;
        case "E":
          this.sTransDesc = "Major Key Extension";
          break;
        case "EL":
          this.sTransDesc = "Major Key Extension + Loss Replacement";
          break;
        case "AE":
          this.sTransDesc = "Additionl/Spare Key Extension";
          break;
        case "EA":
          this.sTransDesc = "Spare Key Entension + Loss Replacement";
          break;
        case "T":
          this.sTransDesc = "Major Key Transfer";
          break;
        case "TL":
          this.sTransDesc = "Major Key Transfer + Loss Replacement";
          break;
        case "AT":
          this.sTransDesc = "Spare Key Transfer";
          break;
        case "TA":
          this.sTransDesc = "Spare Key Transfer + Loss Replacement";
          break;
        case "NE":
          this.sTransDesc = "Key Extension With New Card";
          break;
        case "IS":
          this.sTransDesc = "Issue Second Major Key";
          break;
        case "RE":
          this.sTransDesc = "Recycle Card";
          break;
        case "R":
          this.sTransDesc = "Reservation";
          break;
        case "RC":
          this.sTransDesc = "Reservaton Cancel";
          break;
        case "CC":
          this.sTransDesc = "CheckOut/Cancel Card";
          break;
        case "CN":
          this.sTransDesc = "CheckOut/Cancel Without Card";
          break;
        default:
          this.sTransDesc = "";
          break;
      }
      this.db.Local_Command.CommandText = "Delete * from ExtraCharge_Temp";
      this.db.Local_Command.Connection = this.db.temp_DB.extraCharge_TempTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_Receipt_CancelReservation.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into ExtraCharge_Temp  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == "1")
      {
        OleDbCommand localCommand = this.db.Local_Command;
        localCommand.CommandText = localCommand.CommandText + "SELECT * FROM ExtraCharge in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb 'Where ReceiptID=  " + this.sReceiptID + " ";
        this.db.Local_Command.Connection = this.db.building_DB1.clientAccTableAdapter.Connection;
        this.db.temp_DB.tempDataSet.ExtraCharge_Temp.Clear();
        this.db.local_adaptor.SelectCommand = this.db.Local_Command;
        this.db.local_adaptor.Fill((DataTable) this.db.temp_DB.tempDataSet.ExtraCharge_Temp);
        if (ReportClass_Receipt_CancelReservation.Temp_MDB_SaveFlag)
          this.db.temp_DB.extraCharge_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.ExtraCharge_Temp);
        try
        {
          int index = 0;
          foreach (TempDataSet.ExtraCharge_TempRow row3 in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.ExtraCharge_Temp.Rows)
          {
            string sReceiptId = this.sReceiptID;
            num1 = row3.ReceiptID;
            string str = num1.ToString();
            if (sReceiptId == str && index <= 4)
            {
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index] = row3.ExDescription;
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index] = row3.ExtraCharge.ToString();
            }
            ++index;
          }
        }
        catch
        {
        }
      }
      else
      {
        OleDbCommand localCommand = this.db.Local_Command;
        localCommand.CommandText = localCommand.CommandText + "SELECT * FROM ExtraCharge in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb 'Where ReceiptID=  " + this.sReceiptID + " ";
      }
    }

    private void TOTAL_AMOUNTDUE()
    {
      this.db.temp_DB.receiptTableAdapter.Fill(this.db.temp_DB.tempDataSet.Receipt);
      foreach (TempDataSet.ReceiptRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.Receipt.Rows)
        this.sAmountDueRpt = !(row.TransType == "I") ? (row.TransType == "T" || row.TransType == "TL" || row.TransType == "IA" ? (Convert.ToDecimal(this.sTotalPaidRpt) == 0M ? "0.00" : (Convert.ToDecimal(this.sBalanceAdvance) == 0M ? Convert.ToDecimal(this.sTotalPaidRpt).ToString() : (Convert.ToDecimal(this.sTotalPaidRpt) - Convert.ToDecimal(this.sBalanceAdvance)).ToString())) : (row.TransType == "E" || row.TransType == "EL" || row.TransType == "NE" ? (Convert.ToDecimal(this.sTotalPaidRpt) == 0M ? "0.00" : (!(Convert.ToDecimal(this.sPrevAdvanceAmount) != 0M) ? (Convert.ToDecimal(this.sRoomCharge) + Convert.ToDecimal(this.sExtraCharge) + Convert.ToDecimal(this.sBond)).ToString() : (Convert.ToDecimal(this.sRoomCharge) + Convert.ToDecimal(this.sExtraCharge) + Convert.ToDecimal(this.sBond) - Convert.ToDecimal(this.sPrevAdvanceAmount)).ToString())) : (row.TransType == "CC" || row.TransType == "CN" ? (!(Convert.ToDecimal(this.sRBA) == 0M) ? (Convert.ToDecimal(this.sKeyDepositRpt) + Convert.ToDecimal(this.sAdvancedPayment) + Convert.ToDecimal(this.sExtraCharge)).ToString() : this.sTotalPaidRpt) : this.sTotalPaidRpt))) : (!(Convert.ToDecimal(this.sDepositRpt) != 0M) ? (Convert.ToDecimal(this.sBond) + Convert.ToDecimal(this.sExtraCharge) + Convert.ToDecimal(this.sRoomCharge) + Convert.ToDecimal(this.sKeyDepositRpt)).ToString() : (Convert.ToDecimal(this.sBond) + Convert.ToDecimal(this.sExtraCharge) + Convert.ToDecimal(this.sRoomCharge) + Convert.ToDecimal(this.sKeyDepositRpt) + Convert.ToDecimal(this.sDepositRpt)).ToString());
    }
  }
}
