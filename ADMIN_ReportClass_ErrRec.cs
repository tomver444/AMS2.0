// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_ErrRec
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
  internal class ADMIN_ReportClass_ErrRec
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public errrec errrec1;

    public ADMIN_ReportClass_ErrRec()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.errrec1 = new errrec();
    }

    public errrec CHECK_ERRREC_MONTHLY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_Individual(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public errrec Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.errrec1;
    }

    public errrec Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.errrec1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM ErrorRecords";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.errorRecordsTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_ErrRec.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into ErrorRecords  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM Erradjust in '" + Application.UserAppDataPath + "\\ErradjustDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Erradjust.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(Erradjust.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY Erradjust.PaymentNoteNo";
      else
        oleDbCommand.CommandText = "SELECT * FROM Erradjust in '" + Application.UserAppDataPath + "\\ErradjustDB" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + ".accdb 'Where Erradjust.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(Erradjust.RoomNo,1) = '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'))ORDER BY Erradjust.PaymentNoteNo";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.erradjustTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords);
      if (ADMIN_ReportClass_ErrRec.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.errorRecordsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ErrorRecords);
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[5].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[6].Text = "\"" + para_ReportType + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[3].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[3].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[3].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[3].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.errrec1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      return this.errrec1;
    }
  }
}
