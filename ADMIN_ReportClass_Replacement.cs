// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_Replacement
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

#nullable disable
namespace AMS
{
  internal class ADMIN_ReportClass_Replacement
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private ReplacementDB1DataSet replacementDB1DataSet;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public Replacement Replacement1;

    public ADMIN_ReportClass_Replacement()
    {
      this.InitializeComponent();
      this.db = new DB();
      this.replacementDB1DataSet = new ReplacementDB1DataSet();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.Replacement1 = new Replacement();
    }

    public Replacement CHECK_REPLACEMENT_MONTHLY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_Individual(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public Replacement Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Replacement1;
    }

    public Replacement Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.Replacement1).SetDataSource(this.replacementDB1DataSet.Replacement.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "Select * From Replacement Where Replacement.TransactionDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(Replacement.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(Replacement.ClientID,1)= '0'))ORDER BY Replacement.ReceiptID";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.replacementTableAdapter.Connection;
      this.replacementDB1DataSet.Replacement.Clear();
      int num = new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) this.replacementDB1DataSet.Replacement);
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[1].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[2].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[3].Text = "\"" + para_ReportType + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[5].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields[6].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.Replacement1).DataDefinition.FormulaFields["TReplacement"].Text = "\"" + num.ToString() + "\"";
      return this.Replacement1;
    }
  }
}
