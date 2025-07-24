// Decompiled with JetBrains decompiler
// Type: AMS.AccBonusEntitle_ReportClass
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
  internal class AccBonusEntitle_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public accbonuslist accbonuslist1;

    public AccBonusEntitle_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.accbonuslist1 = new accbonuslist();
    }

    public accbonuslist CHECK_ENTITLEBONUS(bool para_bCurrent_Flag)
    {
      return para_bCurrent_Flag ? this.Check_GuestList_Report_Individual() : this.Check_GuestList_Report_All();
    }

    public accbonuslist Check_GuestList_Report_All()
    {
      ((ReportDocument) this.accbonuslist1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccBonusEntitleList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accBonusEntitleListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (AccBonusEntitle_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccBonusEntitleList(ClientID,RoomNo,ChargeType,ValidStart,ValidEnd,CheckInDate, BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.ChargeType,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople=1)ORDER BY ClientAcc.RoomNo";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.ChargeType,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople=1)ORDER BY ClientAcc.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList);
      if (AccBonusEntitle_ReportClass.Temp_MDB_SaveFlag)
      {
        int num = (int) MessageBox.Show(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accBonusEntitleListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList).ToString());
      }
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accbonuslist1;
    }

    public accbonuslist Check_GuestList_Report_Individual()
    {
      ((ReportDocument) this.accbonuslist1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccBonusEntitleList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accBonusEntitleListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (AccBonusEntitle_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccBonusEntitleList(ClientID,RoomNo,ChargeType,ValidStart,ValidEnd,CheckInDate, BonusDate,RoomStart) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.ChargeType,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0'))AND (ClientAcc.NoOfPeople=1)ORDER BY ClientAcc.RoomNo";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,ClientAcc.RoomNo,ClientAcc.ChargeType,ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckInDate,ClientAcc.BonusDate,ClientAcc.RoomStart From ClientAcc Where ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0'))AND (ClientAcc.NoOfPeople=1)ORDER BY ClientAcc.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList);
      if (AccBonusEntitle_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accBonusEntitleListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccBonusEntitleList);
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accbonuslist1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accbonuslist1;
    }
  }
}
