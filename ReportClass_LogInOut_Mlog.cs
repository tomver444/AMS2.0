// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_LogInOut_Mlog
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
  internal class ReportClass_LogInOut_Mlog
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public MLOG MLOG1;

    public ReportClass_LogInOut_Mlog()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.MLOG1 = new MLOG();
    }

    public MLOG CHECK_LOG_MONTHLY(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType, Global_Data.sBldNo);
    }

    public MLOG Check_Report_All(string para_ReportType) => this.MLOG1;

    public MLOG Check_Report_Individual(string para_ReportType, string para_BuildingNo)
    {
      ((ReportDocument) this.MLOG1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.MLog.DataSet);
      this.db.Local_Command.CommandText = "Delete * from MLog";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.mLogTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_LogInOut_Mlog.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into MLog  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      string commandText = localCommand1.CommandText;
      OleDbCommand localCommand2 = this.db.Local_Command;
      string[] strArray = new string[6]
      {
        localCommand2.CommandText,
        "SELECT * FROM LogInOut in '",
        Application.UserAppDataPath,
        "\\BuildingDB",
        para_BuildingNo,
        ".mdb '"
      };
      string str1;
      string str2 = str1 = string.Concat(strArray);
      localCommand2.CommandText = str1;
      string str3 = str2;
      localCommand1.CommandText = commandText + str3;
      if (Global_Data.iPrint == (short) 2)
      {
        OleDbCommand localCommand3 = this.db.Local_Command;
        localCommand3.CommandText = localCommand3.CommandText + "Where LogInOut.LogDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY InTime";
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.MLog.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.MLog);
      if (ReportClass_LogInOut_Mlog.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.mLogTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.MLog);
      ((ReportDocument) this.MLOG1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.MLOG1).DataDefinition.FormulaFields[0].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.MLOG1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.MLOG1).DataDefinition.FormulaFields[3].Text = "\"" + para_ReportType + "\"";
      return this.MLOG1;
    }
  }
}
