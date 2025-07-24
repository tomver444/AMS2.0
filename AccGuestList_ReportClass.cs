// Decompiled with JetBrains decompiler
// Type: AMS.AccGuestList_ReportClass
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
  internal class AccGuestList_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public accguestlist accguestList1;

    public AccGuestList_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.accguestList1 = new accguestlist();
    }

    public accguestlist CHECK_GUESTLIST(bool para_bCurrent_Flag)
    {
      return para_bCurrent_Flag ? this.Check_GuestList_Report_Individual() : this.Check_GuestList_Report_All();
    }

    public accguestlist Check_GuestList_Report_All()
    {
      ((ReportDocument) this.accguestList1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGuestList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (AccGuestList_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGuestList(ClientID,ClientType,ForeName,SurName,Sex,Identity,Nationality, Address,Country,Contact) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ClientType,Client.ForeName,Client.SurName,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From (Client INNER JOIN ClientAcc ON Client.ClientID=ClientAcc.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Client.ClientType)='G')ORDER BY Client.ClientID";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,Client.ClientType,Client.ForeName,Client.SurName,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From (Client INNER JOIN ClientAcc ON Client.ClientID=ClientAcc.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Client.ClientType)='G')ORDER BY Client.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList);
      if (AccGuestList_ReportClass.Temp_MDB_SaveFlag)
      {
        int num = (int) MessageBox.Show(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList).ToString());
      }
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accguestList1;
    }

    public accguestlist Check_GuestList_Report_Individual()
    {
      ((ReportDocument) this.accguestList1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGuestList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (AccGuestList_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGuestList(ClientID,ClientType,ForeName,SurName,Sex,Identity,Nationality, Address,Country,Contact) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ClientType,Client.ForeName,Client.SurName,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From (Client INNER JOIN ClientAcc ON Client.ClientID=ClientAcc.ClientID) Where ((Client.ClientType)='G')AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0'))ORDER BY Client.ClientID";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,Client.ClientType,Client.ForeName,Client.SurName,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From (Client INNER JOIN ClientAcc ON Client.ClientID=ClientAcc.ClientID) Where ((Client.ClientType)='G')AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0'))ORDER BY Client.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList);
      if (AccGuestList_ReportClass.Temp_MDB_SaveFlag)
      {
        int num = (int) MessageBox.Show(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestList).ToString());
      }
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accguestList1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accguestList1;
    }
  }
}
