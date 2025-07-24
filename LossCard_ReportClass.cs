// Decompiled with JetBrains decompiler
// Type: AMS.LossCard_ReportClass
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
  internal class LossCard_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public losscard losscard1;

    public LossCard_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.losscard1 = new losscard();
    }

    public losscard CHECK_LOSSCARD(
      bool para_bCurrent_Flag,
      string para_ReportType,
      string para_BuildingNo)
    {
      return this.Check_Report_Individual(para_ReportType, para_BuildingNo);
    }

    public losscard Check_Report_All(string para_ReportType) => this.losscard1;

    public losscard Check_Report_Individual(string para_ReportType, string para_BuildingNo)
    {
      ((ReportDocument) this.losscard1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.LossCard.DataSet);
      this.db.Local_Command.CommandText = "Delete * from LossCard";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.lossCardTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (LossCard_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into LossCard  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "SELECT * FROM CardNo in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb 'Where ((CardNo.CardStatus)=2)AND Left(CardNo.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((CardNo.RecordDate) = # " + Global_Data.sRDate + "#))ORDER BY CardNo";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY CardNo";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND CardNo.RecordDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY CardNo";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.LossCard.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.LossCard);
      if (LossCard_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.lossCardTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.LossCard);
      ((ReportDocument) this.losscard1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.losscard1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.losscard1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.losscard1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.losscard1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.losscard1;
    }
  }
}
