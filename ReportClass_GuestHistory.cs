// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_GuestHistory
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
  internal class ReportClass_GuestHistory
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public guesthistory guesthistory1;

    public ReportClass_GuestHistory()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.guesthistory1 = new guesthistory();
    }

    public guesthistory CHECK_GUESTHISTORY(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public guesthistory Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.guesthistory1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestHistory";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestHistoryTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_GuestHistory.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestHistory(ClientID,ForeName,SurName,CardNo,RoomNo,ReserveRef, TransType,TransDate,TransTime,LastPayment,CheckInDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "Select CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.CardNo,CardTrans.RoomNo,CardTrans.ReserveRef, CardTrans.TransType,CardTrans.TransDate,CardTrans.TransTime,CardTrans.LastPayment,ClientAcc.CheckInDate,ClientAcc.RoomStart From ( CardTrans INNER JOIN ClientAcc ON CardTrans.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(CardTrans.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "') )AND (((CardTrans.ClientID)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sClientID + "'))";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((CardTrans.TransDate) = # " + Global_Data.sRDate + "#))";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND CardTrans.TransDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND CardTrans.TransDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory);
      if (ReportClass_GuestHistory.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestHistoryTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory);
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sClientID + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[5].Text = "\"" + para_ReportType + "\"";
      return this.guesthistory1;
    }

    public guesthistory Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.guesthistory1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestHistory";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestHistoryTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_GuestHistory.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestHistory(ClientID,ForeName,SurName,CardNo,RoomNo,ReserveRef, TransType,TransDate,TransTime,LastPayment,CheckInDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "Select CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.CardNo,CardTrans.RoomNo,CardTrans.ReserveRef, CardTrans.TransType,CardTrans.TransDate,CardTrans.TransTime,CardTrans.LastPayment,ClientAcc.CheckInDate,ClientAcc.RoomStart From ( CardTrans INNER JOIN ClientAcc ON CardTrans.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where (((CardTrans.ClientID)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sClientID + "'))AND Left(CardTrans.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((CardTrans.TransDate) = # " + Global_Data.sRDate + "#))";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND CardTrans.TransDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND CardTrans.TransDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory);
      if (ReportClass_GuestHistory.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestHistoryTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestHistory);
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sClientID + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guesthistory1).DataDefinition.FormulaFields[5].Text = "\"" + para_ReportType + "\"";
      return this.guesthistory1;
    }
  }
}
