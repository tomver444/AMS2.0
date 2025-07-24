// Decompiled with JetBrains decompiler
// Type: AMS.StayingGuest_ByCurrentGInfo_ReportClass
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
  internal class StayingGuest_ByCurrentGInfo_ReportClass
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public currentginfo currentginfo1;

    public StayingGuest_ByCurrentGInfo_ReportClass()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.currentginfo1 = new currentginfo();
    }

    public currentginfo CHECK_CURRENTGINFO(bool para_bCurrent_Flag, string para_ReportType)
    {
      return para_bCurrent_Flag ? this.Check_Report_Individual(para_ReportType) : this.Check_Report_All(para_ReportType);
    }

    public currentginfo Check_Report_All(string para_ReportType)
    {
      ((ReportDocument) this.currentginfo1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from CurrentGInfo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGInfoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentGInfo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into CurrentGInfo(ClientID,ForeName,SurName,RoomNo,Sex,Identity,Nationality, Address,Country,Contact) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select Client.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From ( Client INNER JOIN RoomStatus ON Client.ClientID=RoomStatus.ClientID)Where ((Right(Client.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY Client.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo);
      if (StayingGuest_ByCurrentGInfo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGInfoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo);
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.currentginfo1;
    }

    public currentginfo Check_Report_Individual(string para_ReportType)
    {
      ((ReportDocument) this.currentginfo1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo.DataSet);
      this.db.Local_Command.CommandText = "Delete * from CurrentGInfo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGInfoTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (StayingGuest_ByCurrentGInfo_ReportClass.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into CurrentGInfo(ClientID,ForeName,SurName,RoomNo,Sex,Identity,Nationality, Address,Country,Contact) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      this.db.Local_Command.CommandText += "Select Client.ClientID,Client.ForeName,Client.SurName,RoomStatus.RoomNo,Client.Sex,Client.Identity,Client.Nationality,Client.Address,Client.Country,Client.Contact From ( Client INNER JOIN RoomStatus ON Client.ClientID=RoomStatus.ClientID)Where ((Right(Client.ClientID,4)>'5000')) AND (((RoomStatus.Status)=3 ))ORDER BY Client.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo);
      if (StayingGuest_ByCurrentGInfo_ReportClass.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGInfoTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.CurrentGInfo);
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.currentginfo1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.currentginfo1;
    }
  }
}
