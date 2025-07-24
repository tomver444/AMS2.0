// Decompiled with JetBrains decompiler
// Type: AMS.AccGuestAccount_ReportClass
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
  internal class AccGuestAccount_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public accguestaccount accguestaccount1;

    public AccGuestAccount_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.accguestaccount1 = new accguestaccount();
    }

    public accguestaccount CHECK_GUESTACCOUNT(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_GuestAccount_Report_All(para_ReportType);
    }

    public accguestaccount Check_GuestAccount_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.accguestaccount1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestAccount.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGuestAccount";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestAccountTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (AccGuestAccount_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGuestAccount(ClientID,ForeName,SurName,RoomNo,CardNo,Deposit,Bond, ChargeType,LastPayment,AmountPaid) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand1 = this.db.Local_Command;
          localCommand1.CommandText = localCommand1.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.Deposit,ClientAcc.Bond,ClientAcc.ChargeType,ClientAcc.LastPayment,ClientAcc.AmountPaid From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND (((ClientAcc.ContractStart) = # " + Global_Data.sRDate + "#))ORDER BY ClientAcc.ClientID";
          break;
        case 2:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.Deposit,ClientAcc.Bond,ClientAcc.ChargeType,ClientAcc.LastPayment,ClientAcc.AmountPaid From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ClientAcc.ContractStart  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY ClientAcc.ClientID";
          break;
        case 3:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.Deposit,ClientAcc.Bond,ClientAcc.ChargeType,ClientAcc.LastPayment,ClientAcc.AmountPaid From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ClientAcc.ContractStart  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY ClientAcc.ClientID";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestAccount.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestAccount);
      if (AccGuestAccount_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestAccountTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestAccount);
      ((ReportDocument) this.accguestaccount1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accguestaccount1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accguestaccount1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accguestaccount1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.accguestaccount1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.accguestaccount1;
    }

    public accguestaccount Check_GuestAccount_Report_Individual(string para_ReportType)
    {
      return this.accguestaccount1;
    }
  }
}
