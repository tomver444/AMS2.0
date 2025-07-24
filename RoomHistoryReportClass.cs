// Decompiled with JetBrains decompiler
// Type: AMS.RoomHistoryReportClass
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
  internal class RoomHistoryReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public roomhistory roomhistory1;

    public RoomHistoryReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.roomhistory1 = new roomhistory();
    }

    public roomhistory CHECK_ROOMHISTORY(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType);
    }

    public roomhistory Check_Report_All(string para_ReportType) => this.roomhistory1;

    public roomhistory Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.roomhistory1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomHistory.DataSet);
      this.db.Local_Command.CommandText = "Delete * from RoomHistory";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomHistoryTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (RoomHistoryReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into RoomHistory(ClientID,ForeName,SurName,CardNo,RoomNo,ReserveRef, TransType,TransDate,TransTime,LastPayment) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select CardTrans.ClientID,Client.ForeName,Client.SurName,CardTrans.CardNo,CardTrans.RoomNo, CardTrans.ReserveRef,CardTrans.TransType,CardTrans.TransDate,CardTrans.TransTime,CardTrans.LastPayment From (CardTrans INNER JOIN Client ON CardTrans.ClientID=Client.ClientID) ";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand1 = this.db.Local_Command;
          localCommand1.CommandText = localCommand1.CommandText + "Where (((CardTrans.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))AND Left(CardTrans.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'AND (((CardTrans.TransDate) = # " + Global_Data.sRDate + "#))ORDER BY CardTrans.ClientID";
          break;
        case 2:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "Where (((CardTrans.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))AND Left(CardTrans.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'AND CardTrans.TransDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY CardTrans.ClientID";
          break;
        case 3:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "Where (((CardTrans.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))AND Left(CardTrans.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'AND CardTrans.TransDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY CardTrans.ClientID";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomHistory.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomHistory);
      if (RoomHistoryReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomHistoryTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomHistory);
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[3].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "\"";
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.roomhistory1).DataDefinition.FormulaFields[5].Text = "\"" + para_ReportType + "\"";
      return this.roomhistory1;
    }
  }
}
