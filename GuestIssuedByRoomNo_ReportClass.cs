// Decompiled with JetBrains decompiler
// Type: AMS.GuestIssuedByRoomNo_ReportClass
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
  internal class GuestIssuedByRoomNo_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public guestissuedbyroomno guestissuedbyroomno1;

    public GuestIssuedByRoomNo_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.guestissuedbyroomno1 = new guestissuedbyroomno();
    }

    public guestissuedbyroomno CHECK_GUESTISSUEDBYROOMNO(
      bool para_bCurrent_Flag,
      string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType);
    }

    public guestissuedbyroomno Check_Report_All(string para_ReportType)
    {
      return this.guestissuedbyroomno1;
    }

    public guestissuedbyroomno Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.guestissuedbyroomno1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestIssuedByRoomNo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestIssuedByRoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByRoomNoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (GuestIssuedByRoomNo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestIssuedByRoomNo(CardNo,CardType,RoomNo,ClientID,ForeName,SurName, CardStatus,ReaderID,RecordDate,RecordTime,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "Select CardNo.CardNo,CardNo.CardType,ClientAcc.RoomNo,CardNo.ClientID,Client.ForeName,Client.SurName, CardNo.CardStatus,CardNo.ReaderID,CardNo.RecordDate,CardNo.RecordTime,ClientAcc.ValidStart,ClientAcc.ValidEnd From ( CardNo INNER JOIN ClientAcc ON CardNo.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where (((ClientAcc.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))AND ((Right(CardNo.ClientID,4)>'5000'))AND Left(CardNo.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((CardNo.RecordDate) = # " + Global_Data.sRDate + "#))ORDER BY CardNo.CardNo";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY CardNo.CardNo";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY CardNo.CardNo";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestIssuedByRoomNo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestIssuedByRoomNo);
      if (GuestIssuedByRoomNo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByRoomNoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestIssuedByRoomNo);
      ((ReportDocument) this.guestissuedbyroomno1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guestissuedbyroomno1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guestissuedbyroomno1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guestissuedbyroomno1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guestissuedbyroomno1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.guestissuedbyroomno1;
    }
  }
}
