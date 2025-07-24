// Decompiled with JetBrains decompiler
// Type: AMS.StayingGuest_ByCurrentGByFloorNo_ReportClass
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
  internal class StayingGuest_ByCurrentGByFloorNo_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public currentgbyfloorno currentgbyfloorno1;

    public StayingGuest_ByCurrentGByFloorNo_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.currentgbyfloorno1 = new currentgbyfloorno();
    }

    public currentgbyfloorno CHECK_CURRENTGBYFLOORNO(
      bool para_bCurrent_Flag,
      string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public currentgbyfloorno Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.currentgbyfloorno1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from CurrentGByFloorNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGByFloorNoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentGByFloorNo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into CurrentGByFloorNo(ClientID,ForeName,SurName,RoomNo,CardNo,LastPayment,ValidStart,ValidEnd,CheckInDate,CheckOutDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand = this.db.Local_Command;
      localCommand.CommandText = localCommand.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,ClientAcc.CardNo,ClientAcc.LastPayment,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.RoomStart From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Mid(RoomStatus.RoomNo,2,2)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sFloorNo + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo);
      if (StayingGuest_ByCurrentGByFloorNo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGByFloorNoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo);
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sFloorNo + "\"";
      return this.currentgbyfloorno1;
    }

    public currentgbyfloorno Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.currentgbyfloorno1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from CurrentGByFloorNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGByFloorNoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentGByFloorNo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into CurrentGByFloorNo(ClientID,ForeName,SurName,RoomNo,CardNo,LastPayment,ValidStart,ValidEnd,CheckInDate,CheckOutDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand = this.db.Local_Command;
      localCommand.CommandText = localCommand.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,ClientAcc.CardNo,ClientAcc.LastPayment,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.RoomStart From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Mid(RoomStatus.RoomNo,2,2)='" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sFloorNo + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo);
      if (StayingGuest_ByCurrentGByFloorNo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGByFloorNoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGByFloorNo);
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[4].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.currentgbyfloorno1).DataDefinition.FormulaFields[3].Text = "\"" + ModDoorLockSystem.Form_SearchReportDMS_Ptr.sFloorNo + "\"";
      return this.currentgbyfloorno1;
    }
  }
}
