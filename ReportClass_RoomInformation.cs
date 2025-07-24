// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_RoomInformation
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
  internal class ReportClass_RoomInformation
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public roominformation roominformation1;

    public ReportClass_RoomInformation()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.roominformation1 = new roominformation();
    }

    public roominformation CHECK_ROOMINFORMATION(bool para_bCurrent_Flag)
    {
      return this.Check_Report_Individual();
    }

    public roominformation Check_Report_All() => this.roominformation1;

    public roominformation Check_Report_Individual()
    {
      this.db.Update_RoomStausXX_inSystemDB(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
      ((ReportDocument) this.roominformation1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomInformation.DataSet);
      this.db.Local_Command.CommandText = "Delete * from RoomInformation";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomInformationTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_RoomInformation.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into RoomInformation (RoomNo,RmDescription,Description,ClientID,BuildingNo,FloorNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,IssuedCard) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      switch (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo)
      {
        case "1":
          OleDbCommand localCommand1 = this.db.Local_Command;
          localCommand1.CommandText = localCommand1.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus1.Description,RoomStatus1.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        case "2":
          OleDbCommand localCommand2 = this.db.Local_Command;
          localCommand2.CommandText = localCommand2.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus2.Description,RoomStatus2.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        case "3":
          OleDbCommand localCommand3 = this.db.Local_Command;
          localCommand3.CommandText = localCommand3.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus3.Description,RoomStatus3.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        case "4":
          OleDbCommand localCommand4 = this.db.Local_Command;
          localCommand4.CommandText = localCommand4.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus4.Description,RoomStatus4.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        case "5":
          OleDbCommand localCommand5 = this.db.Local_Command;
          localCommand5.CommandText = localCommand5.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus5.Description,RoomStatus5.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        case "6":
          OleDbCommand localCommand6 = this.db.Local_Command;
          localCommand6.CommandText = localCommand6.CommandText + "Select Room.RoomNo,RoomType.RmDescription,RoomStatus6.Description,RoomStatus6.ClientID,Room.BuildingNo,Room.FloorNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,Room.IssuedCard From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where Left(Room.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'ORDER BY Room.RoomNo";
          break;
        default:
          int num = (int) MessageBox.Show("Need to implement for this case!");
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomInformation.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomInformation);
      if (ReportClass_RoomInformation.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomInformationTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomInformation);
      ((ReportDocument) this.roominformation1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.roominformation1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.roominformation1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.roominformation1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      return this.roominformation1;
    }
  }
}
