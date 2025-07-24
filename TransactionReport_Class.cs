// Decompiled with JetBrains decompiler
// Type: AMS.TransactionReport_Class
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
  internal class TransactionReport_Class
  {
    private static bool Temp_MDB_SaveFlag;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public ReportDocument reportDocument1;
    public downertrans downertrans1;

    public TransactionReport_Class() => this.InitializeComponent();

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.reportDocument1 = new ReportDocument();
      this.downertrans1 = new downertrans();
    }

    public downertrans Check_AdminReport_Content_ByDateRange(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate)
    {
      ((ReportDocument) this.downertrans1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM DTransactions";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (TransactionReport_Class.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into DTransactions  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM CardTrans Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND((Right(CardTrans.ClientID,4)<'5000'))AND ((Left(CardTrans.ClientID,1) = '0'))ORDER BY CardTrans.TransID";
      else
        oleDbCommand.CommandText = "SELECT * FROM CardTrans Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND((Right(CardTrans.ClientID,4)<'5000'))AND ((Left(CardTrans.ClientID,1) = '0'))ORDER BY CardTrans.TransID";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      if (TransactionReport_Class.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[1].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[3].Text = "\"Accommodation Management System - 1\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[4].Text = "\"Hawthorn House\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[5].Text = "\"Admin Transactions Report By Date Range\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[6].Text = "\"Report Date\"";
      return this.downertrans1;
    }

    public downertrans Check_GuestReport_Content_ByDateRange(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string Para_Bld_No)
    {
      ((ReportDocument) this.downertrans1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM DTransactions";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (TransactionReport_Class.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into DTransactions  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM CardTrans Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + Para_Bld_No + "'))ORDER BY CardTrans.TransID";
      else
        oleDbCommand.CommandText = "SELECT * FROM CardTrans Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND((Right(CardTrans.ClientID,4)>'5000'))AND ((Left(CardTrans.RoomNo,1) = '" + Para_Bld_No + "'))ORDER BY CardTrans.TransID";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
      oleDbDataAdapter.SelectCommand = oleDbCommand;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.Clear();
      oleDbDataAdapter.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      if (TransactionReport_Class.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[1].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[4].Text = "\"Hawthorn House" + Para_Bld_No + "\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[5].Text = "\"Guest Transactions Report By Date Range\"";
      ((ReportDocument) this.downertrans1).DataDefinition.FormulaFields[6].Text = "\"Report Date\"";
      return this.downertrans1;
    }
  }
}
