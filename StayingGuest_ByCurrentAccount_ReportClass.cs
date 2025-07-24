// Decompiled with JetBrains decompiler
// Type: AMS.StayingGuest_ByCurrentAccount_ReportClass
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
  internal class StayingGuest_ByCurrentAccount_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public guestaccount guestaccount1;

    public StayingGuest_ByCurrentAccount_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.guestaccount1 = new guestaccount();
    }

    public guestaccount CHECK_CURRENTGACCOUNT(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public guestaccount Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.guestaccount1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestAccount";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestAccountTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentAccount_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestAccount(ClientID,ForeName,SurName,RoomNo,CardNo,Deposit,Bond, ChargeType,LastPayment,AmountPaid) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,ClientAcc.CardNo,ClientAcc.Deposit,ClientAcc.Bond,ClientAcc.ChargeType,ClientAcc.LastPayment,ClientAcc.AmountPaid From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Right(ClientAcc.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount);
      if (StayingGuest_ByCurrentAccount_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestAccountTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount);
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.guestaccount1;
    }

    public guestaccount Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.guestaccount1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount.DataSet);
      this.db.Local_Command.CommandText = "Delete * from GuestAccount";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestAccountTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentAccount_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GuestAccount(ClientID,ForeName,SurName,RoomNo,CardNo,Deposit,Bond, ChargeType,LastPayment,AmountPaid) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,ClientAcc.CardNo,ClientAcc.Deposit,ClientAcc.Bond,ClientAcc.ChargeType,ClientAcc.LastPayment,ClientAcc.AmountPaid From ( RoomStatus INNER JOIN ClientAcc ON RoomStatus.ClientID=ClientAcc.ClientID)INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID Where ((Right(ClientAcc.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount);
      if (StayingGuest_ByCurrentAccount_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestAccountTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestAccount);
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.guestaccount1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.guestaccount1;
    }
  }
}
