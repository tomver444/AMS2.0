// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_GCheckOutRoom
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
  internal class ADMIN_ReportClass_GCheckOutRoom
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public gcheckoutroom_shl gcheckoutroom_shl1;

    public ADMIN_ReportClass_GCheckOutRoom()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.gcheckoutroom_shl1 = new gcheckoutroom_shl();
    }

    public gcheckoutroom_shl CHECK_CHECKOUT_MONTHLY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_Individual(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public gcheckoutroom_shl Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.gcheckoutroom_shl1;
    }

    public gcheckoutroom_shl Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.gcheckoutroom_shl1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM GDSales";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_GCheckOutRoom.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into GDSales(TransID,ClientID,ForeName,SurName,RoomNo,CardNo,ReserveRef,TransType,TransDate,CheckInDate, ChargeType,PreviousAdvance,AdvancedPayment,Bond,RBA,Deposit,KeyDeposit,ExtraCharge,RoomCharge,BonusClaim,GST,LastPayment,StaffID,ContractStart,ContractEnd,CheckOutDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.CheckInDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.RBA,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID,ClientAcc.ContractStart,ClientAcc.ContractEnd,CardTrans.CheckOutDate From ( CardTrans INNER JOIN ClientAcc ON CardTrans.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))AND (Left(CardTrans.TransType,1)='C')ORDER BY CardTrans.RoomNo";
      else
        oleDbCommand.CommandText = "Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.CheckInDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.RBA,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID,ClientAcc.ContractStart,ClientAcc.ContractEnd,CardTrans.CheckOutDate From ( CardTrans INNER JOIN ClientAcc ON CardTrans.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))AND (Left(CardTrans.TransType,1)='C')ORDER BY CardTrans.RoomNo";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      if (ADMIN_ReportClass_GCheckOutRoom.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[23].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[24].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.gcheckoutroom_shl1).DataDefinition.FormulaFields[25].Text = "\"" + para_ReportType + "\"";
      return this.gcheckoutroom_shl1;
    }
  }
}
