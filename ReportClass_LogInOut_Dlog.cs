// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_LogInOut_Dlog
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
  internal class ReportClass_LogInOut_Dlog
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public DLOG DLOG1;

    public ReportClass_LogInOut_Dlog()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.DLOG1 = new DLOG();
    }

    public DLOG CHECK_LOG_DAILY(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType, Global_Data.sBldNo);
    }

    public DLOG Check_Report_All(string para_ReportType) => this.DLOG1;

    public DLOG Check_Report_Individual(string para_ReportType, string para_BuildingNo)
    {
      ((ReportDocument) this.DLOG1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DLog.DataSet);
      this.db.Local_Command.CommandText = "Delete * from DLog";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dLogTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_LogInOut_Dlog.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into DLog  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "SELECT * FROM LogInOut in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb '";
      if (Global_Data.iPrint == (short) 1)
      {
        OleDbCommand localCommand2 = this.db.Local_Command;
        localCommand2.CommandText = localCommand2.CommandText + "Where (((LogInOut.LogDate) = # " + Global_Data.sRDate + "#))ORDER BY InTime";
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DLog.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DLog);
      if (ReportClass_LogInOut_Dlog.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dLogTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DLog);
      ((ReportDocument) this.DLOG1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.DLOG1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.DLOG1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.DLOG1).DataDefinition.FormulaFields[0].Text = "\"" + para_ReportType + "\"";
      return this.DLOG1;
    }
  }
}
