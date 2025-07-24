// Decompiled with JetBrains decompiler
// Type: AMS.ADMIN_ReportClass_Extra
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
  internal class ADMIN_ReportClass_Extra
  {
    private static bool Temp_MDB_SaveFlag = true;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public extra extra1;

    public ADMIN_ReportClass_Extra()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.extra1 = new extra();
    }

    public extra CHECK_EXTRA_MONTHLY(
      bool para_bCurrent_Flag,
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.Check_Report_Individual(para_ToCheck_StartDate, para_ToCheck_EndDate, para_ReportType, para_ReportTitle);
    }

    public extra Check_Report_All(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      return this.extra1;
    }

    public extra Check_Report_Individual(
      string para_ToCheck_StartDate,
      string para_ToCheck_EndDate,
      string para_ReportType,
      string para_ReportTitle)
    {
      ((ReportDocument) this.extra1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Extra.DataSet);
      this.start_Date = para_ToCheck_StartDate;
      this.End_date = para_ToCheck_EndDate;
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.CommandText = "DELETE * FROM Extra";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraTableAdapter.Connection;
      oleDbCommand.Connection.Open();
      oleDbCommand.ExecuteNonQuery();
      oleDbCommand.Connection.Close();
      if (ADMIN_ReportClass_Extra.Temp_MDB_SaveFlag)
        oleDbCommand.CommandText = "Insert into Extra(RoomNo,ReceiptID,ClientID,ExDescription,ExtraCharge, TransDate,TransTime,TransType) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select CardTrans.RoomNo,ExtraCharge.ReceiptID,ExtraCharge.ClientID,ExtraCharge.ExDescription,ExtraCharge.ExtraCharge,CardTrans.TransDate,CardTrans.TransTime,CardTrans.TransType From ( ExtraCharge INNER JOIN CardTrans ON ExtraCharge.ReceiptID=CardTrans.TransID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(ExtraCharge.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ExtraCharge.ClientID,1)= '0'))ORDER BY ExtraCharge.ReceiptID";
      else
        oleDbCommand.CommandText = "Select CardTrans.RoomNo,ExtraCharge.ReceiptID,ExtraCharge.ClientID,ExtraCharge.ExDescription,ExtraCharge.ExtraCharge,CardTrans.TransDate,CardTrans.TransTime,CardTrans.TransType From ( ExtraCharge INNER JOIN CardTrans ON ExtraCharge.ReceiptID=CardTrans.TransID)Where CardTrans.TransDate  Between # " + this.start_Date + " # AND # " + this.End_date + "#AND ((Left(ExtraCharge.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ExtraCharge.ClientID,1)= '0'))ORDER BY ExtraCharge.ReceiptID";
      oleDbCommand.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Extra.Clear();
      new OleDbDataAdapter()
      {
        SelectCommand = oleDbCommand
      }.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Extra);
      if (ADMIN_ReportClass_Extra.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Extra);
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[1].Text = "\"" + para_ReportTitle + "\"";
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[2].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[3].Text = "\"" + para_ReportType + "\"";
      switch (para_ReportType)
      {
        case "REPORT DATE":
          if (!para_ReportTitle.Contains("Date Range"))
          {
            ((ReportDocument) this.extra1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + "\"";
            break;
          }
          ((ReportDocument) this.extra1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
        case "REPORT YEAR":
          ((ReportDocument) this.extra1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate.Substring(0, 4) + "\"";
          break;
        default:
          ((ReportDocument) this.extra1).DataDefinition.FormulaFields[4].Text = "\"" + para_ToCheck_StartDate + " To " + para_ToCheck_EndDate + "\"";
          break;
      }
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[5].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.extra1).DataDefinition.FormulaFields[6].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      return this.extra1;
    }
  }
}
