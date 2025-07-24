// Decompiled with JetBrains decompiler
// Type: AMS.UnLockDoorByRoomNo_ReportClass
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
  internal class UnLockDoorByRoomNo_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public unlockdoorbyroomno unlockdoorbyroomno1;

    public UnLockDoorByRoomNo_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.unlockdoorbyroomno1 = new unlockdoorbyroomno();
    }

    public unlockdoorbyroomno CHECK_UNLOCKDOORBYROOMNO(
      bool para_bCurrent_Flag,
      string para_ReportType,
      string para_BuildingNo)
    {
      return this.Check_Report_Individual(para_ReportType, para_BuildingNo);
    }

    public unlockdoorbyroomno Check_Report_All(string para_ReportType) => this.unlockdoorbyroomno1;

    public unlockdoorbyroomno Check_Report_Individual(
      string para_ReportType,
      string para_BuildingNo)
    {
      ((ReportDocument) this.unlockdoorbyroomno1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.UnLockDoorByRoomNo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from UnLockDoorByRoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.unLockDoorByRoomNoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (UnLockDoorByRoomNo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into UnLockDoorByRoomNo  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "SELECT * FROM AllLockedRecord in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb '";
      if (Global_Data.iView == 1)
      {
        switch (Global_Data.iPrint)
        {
          case 1:
            OleDbCommand localCommand2 = this.db.Local_Command;
            localCommand2.CommandText = localCommand2.CommandText + "Where (((AllLockedRecord.UnlockSDate) = # " + Global_Data.sRDate + "#))AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
          case 2:
            OleDbCommand localCommand3 = this.db.Local_Command;
            localCommand3.CommandText = localCommand3.CommandText + "Where AllLockedRecord.UnlockSDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
          case 3:
            OleDbCommand localCommand4 = this.db.Local_Command;
            localCommand4.CommandText = localCommand4.CommandText + "Where AllLockedRecord.UnlockSDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
        }
      }
      else
      {
        switch (Global_Data.iPrint)
        {
          case 1:
            OleDbCommand localCommand5 = this.db.Local_Command;
            localCommand5.CommandText = localCommand5.CommandText + "Where (((AllLockedRecord.CollectionSDate) = # " + Global_Data.sRDate + "#))AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
          case 2:
            OleDbCommand localCommand6 = this.db.Local_Command;
            localCommand6.CommandText = localCommand6.CommandText + "Where AllLockedRecord.CollectionSDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
          case 3:
            OleDbCommand localCommand7 = this.db.Local_Command;
            localCommand7.CommandText = localCommand7.CommandText + "Where AllLockedRecord.CollectionSDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#AND (((AllLockedRecord.RoomNo)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sRoomNo + "'))ORDER BY RoomNo";
            break;
        }
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.UnLockDoorByRoomNo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.UnLockDoorByRoomNo);
      if (UnLockDoorByRoomNo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.unLockDoorByRoomNoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.UnLockDoorByRoomNo);
      ((ReportDocument) this.unlockdoorbyroomno1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.unlockdoorbyroomno1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.unlockdoorbyroomno1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.unlockdoorbyroomno1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.unlockdoorbyroomno1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.unlockdoorbyroomno1;
    }
  }
}
