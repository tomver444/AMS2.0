// Decompiled with JetBrains decompiler
// Type: AMS.AccGracePeriodList_ReportClass
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
  internal class AccGracePeriodList_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public accgraceperiodlist accgraceperiodlist1;

    public AccGracePeriodList_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.accgraceperiodlist1 = new accgraceperiodlist();
    }

    public accgraceperiodlist CHECK_GRACEPERIODLIST(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public accgraceperiodlist Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.accgraceperiodlist1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGuestRecordDate.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGracePeriodList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGracePeriodListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (AccGracePeriodList_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGracePeriodList(ClientID,ForeName,SurName,RoomNo,GracePeriod,ValidStart,ValidEnd,CheckOutDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand = this.db.Local_Command;
      localCommand.CommandText = localCommand.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.GracePeriod, ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckOutDate From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding + "') Or(Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))AND ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Client.ClientType)='G') AND (((ClientAcc.NoOfPeople)< 9 )) AND (((ClientAcc.GracePeriod)>0 ))AND (((ClientAcc.ValidEnd) < # " + DateTime.Now.ToShortDateString() + "#))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList);
      if (AccGracePeriodList_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGracePeriodListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList);
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accgraceperiodlist1;
    }

    public accgraceperiodlist Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.accgraceperiodlist1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList.DataSet);
      this.db.Local_Command.CommandText = "Delete * from AccGracePeriodList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGracePeriodListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (AccGracePeriodList_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into AccGracePeriodList(ClientID,ForeName,SurName,RoomNo,GracePeriod,ValidStart,ValidEnd,CheckOutDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand = this.db.Local_Command;
      localCommand.CommandText = localCommand.CommandText + "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.GracePeriod, ClientAcc.ValidStart,ClientAcc.ValidEnd,ClientAcc.CheckOutDate From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))AND ((Left(ClientAcc.ClientID,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "') Or(Left(ClientAcc.ClientID,1)= '0')) AND (((ClientAcc.NoOfPeople)< 9 )) AND (((ClientAcc.GracePeriod)>0 ))AND (((ClientAcc.ValidEnd) < # " + DateTime.Now.ToShortDateString() + "#))ORDER BY ClientAcc.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList);
      if (AccGracePeriodList_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGracePeriodListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.AccGracePeriodList);
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.accgraceperiodlist1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.accgraceperiodlist1;
    }
  }
}
