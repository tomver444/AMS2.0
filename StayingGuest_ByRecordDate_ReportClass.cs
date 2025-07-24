// Decompiled with JetBrains decompiler
// Type: AMS.StayingGuest_ByRecordDate_ReportClass
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
  internal class StayingGuest_ByRecordDate_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public guestrecorddate guestrecorddate1;

    public StayingGuest_ByRecordDate_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.guestrecorddate1 = new guestrecorddate();
    }

    public guestrecorddate CHECK_CURRENTGRECORDDATE(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public guestrecorddate Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.guestrecorddate1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestRecordDate";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestRecordDateTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByRecordDate_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestRecordDate(ClientID,RoomNo,GracePeriod,ContractStart,ContractEnd, ValidStart,ValidEnd,CheckInDate,CheckOutDate,BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select ClientAcc.ClientID,RoomStatus.RoomNo,ClientAcc.GracePeriod,ClientAcc.ContractStart,ClientAcc.ContractEnd,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Right(ClientAcc.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate);
      if (StayingGuest_ByRecordDate_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestRecordDateTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate);
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.guestrecorddate1;
    }

    public guestrecorddate Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.guestrecorddate1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestRecordDate";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestRecordDateTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByRecordDate_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestRecordDate(ClientID,RoomNo,GracePeriod,ContractStart,ContractEnd, ValidStart,ValidEnd,CheckInDate,CheckOutDate,BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select ClientAcc.ClientID,RoomStatus.RoomNo,ClientAcc.GracePeriod,ClientAcc.ContractStart,ClientAcc.ContractEnd,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Right(ClientAcc.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate);
      if (StayingGuest_ByRecordDate_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestRecordDateTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestRecordDate);
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guestrecorddate1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.guestrecorddate1;
    }
  }
}
