// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_GSALES_YEARLY_SUMMARY
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
  internal class ADMIN_ReportClass_GSALES_YEARLY_SUMMARY
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public summary summary_1;

    public ADMIN_ReportClass_GSALES_YEARLY_SUMMARY()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.summary_1 = new summary();
    }

    public summary CHECK_YEARLY_SUMMARY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_All(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public summary Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.summary_1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM GDSales";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_GSALES_YEARLY_SUMMARY.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into GDSales(TransID,ClientID,ForeName,SurName,RoomNo,CardNo,ReserveRef,TransType,TransDate, ChargeType,PreviousAdvance,AdvancedPayment,Bond,Deposit,KeyDeposit,ExtraCharge,RoomCharge,BonusClaim,GST,LastPayment,StaffID) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID From ( CardTrans INNER JOIN Client ON CardTrans.ClientID=Client.ClientID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY CardTrans.TransID";
      else
        oleDbCommand.CommandText = "Select CardTrans.TransID,CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.RoomNo,CardTrans.CardNo,CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.ChargeType,CardTrans.PreviousAdvance,CardTrans.AdvancedPayment,CardTrans.Bond,CardTrans.Deposit,CardTrans.KeyDeposit,CardTrans.ExtraCharge,CardTrans.RoomCharge,CardTrans.BonusClaim,CardTrans.GST,CardTrans.LastPayment,CardTrans.StaffID From ( CardTrans INNER JOIN Client ON CardTrans.ClientID=Client.ClientID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY CardTrans.TransID";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      if (ADMIN_ReportClass_GSALES_YEARLY_SUMMARY.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GDSales);
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[10].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[23].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[24].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.summary_1).DataDefinition.FormulaFields[25].Text = "\"" + para_ReportType + "\"";
      this.Delete_All_Sales_Record();
      return this.summary_1;
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

    public summary Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.summary_1;
    }
  }
}
