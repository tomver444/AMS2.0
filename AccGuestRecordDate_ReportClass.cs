// Decompiled with JetBrains decompiler
// Type: AMS.AccGuestRecordDate_ReportClass
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
  internal class AccGuestRecordDate_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public accguestrecorddate accguestrecorddate1;

    public AccGuestRecordDate_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.accguestrecorddate1 = new accguestrecorddate();
    }

    public accguestrecorddate CHECK_GUESTRECORDDATE(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public accguestrecorddate Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.accguestrecorddate1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGuestRecordDate";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestRecordDateTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (AccGuestRecordDate_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGuestRecordDate(ClientID,RoomNo,GracePeriod,ContractStart,ContractEnd, ValidStart,ValidEnd,CheckInDate,CheckOutDate,BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.GracePeriod,ClientAcc.ContractStart,ClientAcc.ContractEnd,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((ClientAcc.ContractStart) = # " + Global_Data.sRDate + "#))ORDER BY ClientAcc.ClientID";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND ClientAcc.ContractStart  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY ClientAcc.ClientID";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND ClientAcc.ContractStart  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY ClientAcc.ClientID";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate);
      if (AccGuestRecordDate_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestRecordDateTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate);
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[1].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[2].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.accguestrecorddate1;
    }

    public accguestrecorddate Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.accguestrecorddate1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGuestRecordDate";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestRecordDateTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (AccGuestRecordDate_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGuestRecordDate(ClientID,RoomNo,GracePeriod,ContractStart,ContractEnd, ValidStart,ValidEnd,CheckInDate,CheckOutDate,BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand1 = this.db.Local_Command;
      localCommand1.CommandText = localCommand1.CommandText + "Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.GracePeriod,ClientAcc.ContractStart,ClientAcc.ContractEnd,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.CheckOutDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0'))";
      switch (Global_Data.iPrint)
      {
        case 1:
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "AND (((ClientAcc.ContractStart) = # " + Global_Data.sRDate + "#))ORDER BY ClientAcc.ClientID";
          break;
        case 2:
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "AND ClientAcc.ContractStart  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY ClientAcc.ClientID";
          break;
        case 3:
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "AND ClientAcc.ContractStart  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY ClientAcc.ClientID";
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate);
      if (AccGuestRecordDate_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestRecordDateTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate);
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.accguestrecorddate1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.accguestrecorddate1;
    }
  }
}
