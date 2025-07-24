// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_ReservationList
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class ReportClass_ReservationList
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public reservationlist reservationlist1;

    public ReportClass_ReservationList()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.reservationlist1 = new reservationlist();
    }

    public reservationlist CHECK_RESERVATIONLIST(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType);
    }

    public reservationlist Check_Report_All(string para_ReportType) => this.reservationlist1;

    public reservationlist Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.reservationlist1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ReservationList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from ReservationList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.reservationListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_ReservationList.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into ReservationList (ReserveRef,RoomNo,ClientID,ForeName, SurName,Deposit,StartDate,EndDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select Reserve.ReserveRef,Reserve.RoomNo,Reserve.ClientID,Client.ForeName,Client.SurName,ClientAcc.Deposit,Reserve.StartDate,Reserve.EndDate From ( ClientAcc INNER JOIN Reserve ON ClientAcc.ClientID=Reserve.ClientID)INNER JOIN Client ON Reserve.ClientID=Client.ClientID ";
      this.db.Local_Command.CommandText += "ORDER BY Reserve.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ReservationList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ReservationList);
      if (ReportClass_ReservationList.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.reservationListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.ReservationList);
      ((ReportDocument) this.reservationlist1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.reservationlist1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.reservationlist1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.reservationlist1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.reservationlist1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.reservationlist1;
    }
  }
}
