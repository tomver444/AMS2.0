// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_RoomDetail
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
  internal class ReportClass_RoomDetail
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public roomdetail roomdetail1;

    public ReportClass_RoomDetail()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.roomdetail1 = new roomdetail();
    }

    public roomdetail CHECK_ORROOMSDETAIL(bool para_bCurrent_Flag, string para_ReportType)
    {
      return this.Check_Report_Individual(para_ReportType);
    }

    public roomdetail Check_Report_All(string para_ReportType) => this.roomdetail1;

    private void Check_For_GuestName(string para_BuildingNo)
    {
      this.db.Local_Command.CommandText = "Delete * from GuestList";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestListTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      this.db.Local_Command.CommandText = "Insert into GuestList  in '" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM Client in '" + Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb 'Where ((Client.ClientType)='G')ORDER BY Client.ClientID";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestList.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestList);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestListTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestList);
      foreach (TempDataSet.RoomDetailRow row1 in (InternalDataCollectionBase) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail.Rows)
      {
        for (int index = 0; index < ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestList.Rows.Count; ++index)
        {
          TempDataSet.GuestListRow row2 = (TempDataSet.GuestListRow) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.GuestList.Rows[index];
          if (row1.ClientID == row2.ClientID)
          {
            row1.ForeName = row2.ForeName;
            row1.SurName = row2.SurName;
          }
        }
      }
    }

    public roomdetail Check_Report_Individual(string para_ReportType)
    {
      this.db.Update_RoomStausXX_inSystemDB(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
      ((ReportDocument) this.roomdetail1).SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail.DataSet);
      this.db.Local_Command.CommandText = "Delete * from RoomDetail";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomDetailTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (ReportClass_RoomDetail.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into RoomDetail (RoomNo,RmDescription,Description,ClientID, StartDate,EndDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      switch (Global_Data.iPrint)
      {
        case 1:
          switch (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo)
          {
            case "1":
              OleDbCommand localCommand1 = this.db.Local_Command;
              localCommand1.CommandText = localCommand1.CommandText + "Select RoomStatus1.RoomNo,RoomType.RmDescription,RoomStatus1.Description,RoomStatus1.ClientID,RoomStatus1.StartDate,RoomStatus1.EndDate From ( RoomType INNER JOIN RoomStatus1 ON RoomType.RoomType=RoomStatus1.RoomType)Where ((RoomStatus1.Status = 2 OR RoomStatus1.Status=3))AND Left(RoomStatus1.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand2 = this.db.Local_Command;
              localCommand2.CommandText = localCommand2.CommandText + "AND (((RoomStatus1.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus1.RoomNo";
              break;
            case "2":
              OleDbCommand localCommand3 = this.db.Local_Command;
              localCommand3.CommandText = localCommand3.CommandText + "Select RoomStatus2.RoomNo,RoomType.RmDescription,RoomStatus2.Description,RoomStatus2.ClientID,RoomStatus2.StartDate,RoomStatus2.EndDate From ( RoomType INNER JOIN RoomStatus2 ON RoomType.RoomType=RoomStatus2.RoomType)Where ((RoomStatus2.Status = 2 OR RoomStatus2.Status=3))AND Left(RoomStatus2.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand4 = this.db.Local_Command;
              localCommand4.CommandText = localCommand4.CommandText + "AND (((RoomStatus2.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus2.RoomNo";
              break;
            case "3":
              OleDbCommand localCommand5 = this.db.Local_Command;
              localCommand5.CommandText = localCommand5.CommandText + "Select RoomStatus3.RoomNo,RoomType.RmDescription,RoomStatus3.Description,RoomStatus3.ClientID,RoomStatus3.StartDate,RoomStatus3.EndDate From ( RoomType INNER JOIN RoomStatus3 ON RoomType.RoomType=RoomStatus3.RoomType)Where ((RoomStatus3.Status = 2 OR RoomStatus3.Status=3))AND Left(RoomStatus3.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand6 = this.db.Local_Command;
              localCommand6.CommandText = localCommand6.CommandText + "AND (((RoomStatus3.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus3.RoomNo";
              break;
            case "4":
              OleDbCommand localCommand7 = this.db.Local_Command;
              localCommand7.CommandText = localCommand7.CommandText + "Select RoomStatus4.RoomNo,RoomType.RmDescription,RoomStatus4.Description,RoomStatus4.ClientID,RoomStatus4.StartDate,RoomStatus4.EndDate From ( RoomType INNER JOIN RoomStatus4 ON RoomType.RoomType=RoomStatus4.RoomType)Where ((RoomStatus4.Status = 2 OR RoomStatus4.Status=3))AND Left(RoomStatus4.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand8 = this.db.Local_Command;
              localCommand8.CommandText = localCommand8.CommandText + "AND (((RoomStatus4.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus4.RoomNo";
              break;
            case "5":
              OleDbCommand localCommand9 = this.db.Local_Command;
              localCommand9.CommandText = localCommand9.CommandText + "Select RoomStatus5.RoomNo,RoomType.RmDescription,RoomStatus5.Description,RoomStatus5.ClientID,RoomStatus5.StartDate,RoomStatus5.EndDate From ( RoomType INNER JOIN RoomStatus5 ON RoomType.RoomType=RoomStatus5.RoomType)Where ((RoomStatus5.Status = 2 OR RoomStatus5.Status=3))AND Left(RoomStatus5.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand10 = this.db.Local_Command;
              localCommand10.CommandText = localCommand10.CommandText + "AND (((RoomStatus5.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus5.RoomNo";
              break;
            case "6":
              OleDbCommand localCommand11 = this.db.Local_Command;
              localCommand11.CommandText = localCommand11.CommandText + "Select RoomStatus6.RoomNo,RoomType.RmDescription,RoomStatus6.Description,RoomStatus6.ClientID,RoomStatus6.StartDate,RoomStatus6.EndDate From ( RoomType INNER JOIN RoomStatus6 ON RoomType.RoomType=RoomStatus6.RoomType)Where ((RoomStatus6.Status = 2 OR RoomStatus6.Status=3))AND Left(RoomStatus6.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand12 = this.db.Local_Command;
              localCommand12.CommandText = localCommand12.CommandText + "AND (((RoomStatus6.StartDate) = # " + Global_Data.sRDate + "#))ORDER BY RoomStatus6.RoomNo";
              break;
            default:
              int num1 = (int) MessageBox.Show("Need to implement for this case!");
              break;
          }
          break;
        case 2:
          switch (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo)
          {
            case "1":
              OleDbCommand localCommand13 = this.db.Local_Command;
              localCommand13.CommandText = localCommand13.CommandText + "Select RoomStatus1.RoomNo,RoomType.RmDescription,RoomStatus1.Description,RoomStatus1.ClientID,RoomStatus1.StartDate,RoomStatus1.EndDate From ( RoomType INNER JOIN RoomStatus1 ON RoomType.RoomType=RoomStatus1.RoomType)Where ((RoomStatus1.Status = 2 OR RoomStatus1.Status=3))AND Left(RoomStatus1.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand14 = this.db.Local_Command;
              localCommand14.CommandText = localCommand14.CommandText + "AND RoomStatus1.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus1.RoomNo";
              break;
            case "2":
              OleDbCommand localCommand15 = this.db.Local_Command;
              localCommand15.CommandText = localCommand15.CommandText + "Select RoomStatus2.RoomNo,RoomType.RmDescription,RoomStatus2.Description,RoomStatus2.ClientID,RoomStatus2.StartDate,RoomStatus2.EndDate From ( RoomType INNER JOIN RoomStatus2 ON RoomType.RoomType=RoomStatus2.RoomType)Where ((RoomStatus2.Status = 2 OR RoomStatus2.Status=3))AND Left(RoomStatus2.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand16 = this.db.Local_Command;
              localCommand16.CommandText = localCommand16.CommandText + "AND RoomStatus2.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus2.RoomNo";
              break;
            case "3":
              OleDbCommand localCommand17 = this.db.Local_Command;
              localCommand17.CommandText = localCommand17.CommandText + "Select RoomStatus3.RoomNo,RoomType.RmDescription,RoomStatus3.Description,RoomStatus3.ClientID,RoomStatus3.StartDate,RoomStatus3.EndDate From ( RoomType INNER JOIN RoomStatus3 ON RoomType.RoomType=RoomStatus3.RoomType)Where ((RoomStatus3.Status = 2 OR RoomStatus3.Status=3))AND Left(RoomStatus3.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand18 = this.db.Local_Command;
              localCommand18.CommandText = localCommand18.CommandText + "AND RoomStatus3.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus3.RoomNo";
              break;
            case "4":
              OleDbCommand localCommand19 = this.db.Local_Command;
              localCommand19.CommandText = localCommand19.CommandText + "Select RoomStatus4.RoomNo,RoomType.RmDescription,RoomStatus4.Description,RoomStatus4.ClientID,RoomStatus4.StartDate,RoomStatus4.EndDate From ( RoomType INNER JOIN RoomStatus4 ON RoomType.RoomType=RoomStatus4.RoomType)Where ((RoomStatus4.Status = 2 OR RoomStatus4.Status=3))AND Left(RoomStatus4.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand20 = this.db.Local_Command;
              localCommand20.CommandText = localCommand20.CommandText + "AND RoomStatus4.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus4.RoomNo";
              break;
            case "5":
              OleDbCommand localCommand21 = this.db.Local_Command;
              localCommand21.CommandText = localCommand21.CommandText + "Select RoomStatus5.RoomNo,RoomType.RmDescription,RoomStatus5.Description,RoomStatus5.ClientID,RoomStatus5.StartDate,RoomStatus5.EndDate From ( RoomType INNER JOIN RoomStatus5 ON RoomType.RoomType=RoomStatus5.RoomType)Where ((RoomStatus5.Status = 2 OR RoomStatus5.Status=3))AND Left(RoomStatus5.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand22 = this.db.Local_Command;
              localCommand22.CommandText = localCommand22.CommandText + "AND RoomStatus5.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus5.RoomNo";
              break;
            case "6":
              OleDbCommand localCommand23 = this.db.Local_Command;
              localCommand23.CommandText = localCommand23.CommandText + "Select RoomStatus6.RoomNo,RoomType.RmDescription,RoomStatus6.Description,RoomStatus6.ClientID,RoomStatus6.StartDate,RoomStatus6.EndDate From ( RoomType INNER JOIN RoomStatus6 ON RoomType.RoomType=RoomStatus6.RoomType)Where ((RoomStatus6.Status = 2 OR RoomStatus6.Status=3))AND Left(RoomStatus6.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand24 = this.db.Local_Command;
              localCommand24.CommandText = localCommand24.CommandText + "AND RoomStatus6.StartDate  Between # " + Global_Data.sSDate + " # AND # " + Global_Data.sEDate + "#ORDER BY RoomStatus6.RoomNo";
              break;
            default:
              int num2 = (int) MessageBox.Show("Need to implement for this case!");
              break;
          }
          break;
        case 3:
          switch (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo)
          {
            case "1":
              OleDbCommand localCommand25 = this.db.Local_Command;
              localCommand25.CommandText = localCommand25.CommandText + "Select RoomStatus1.RoomNo,RoomType.RmDescription,RoomStatus1.Description,RoomStatus1.ClientID,RoomStatus1.StartDate,RoomStatus1.EndDate From ( RoomType INNER JOIN RoomStatus1 ON RoomType.RoomType=RoomStatus1.RoomType)Where ((RoomStatus1.Status = 2 OR RoomStatus1.Status=3))AND Left(RoomStatus1.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand26 = this.db.Local_Command;
              localCommand26.CommandText = localCommand26.CommandText + "AND RoomStatus1.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus1.RoomNo";
              break;
            case "2":
              OleDbCommand localCommand27 = this.db.Local_Command;
              localCommand27.CommandText = localCommand27.CommandText + "Select RoomStatus2.RoomNo,RoomType.RmDescription,RoomStatus2.Description,RoomStatus2.ClientID,RoomStatus2.StartDate,RoomStatus2.EndDate From ( RoomType INNER JOIN RoomStatus2 ON RoomType.RoomType=RoomStatus2.RoomType)Where ((RoomStatus2.Status = 2 OR RoomStatus2.Status=3))AND Left(RoomStatus2.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand28 = this.db.Local_Command;
              localCommand28.CommandText = localCommand28.CommandText + "AND RoomStatus2.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus2.RoomNo";
              break;
            case "3":
              OleDbCommand localCommand29 = this.db.Local_Command;
              localCommand29.CommandText = localCommand29.CommandText + "Select RoomStatus3.RoomNo,RoomType.RmDescription,RoomStatus3.Description,RoomStatus3.ClientID,RoomStatus3.StartDate,RoomStatus3.EndDate From ( RoomType INNER JOIN RoomStatus3 ON RoomType.RoomType=RoomStatus3.RoomType)Where ((RoomStatus3.Status = 2 OR RoomStatus3.Status=3))AND Left(RoomStatus3.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand30 = this.db.Local_Command;
              localCommand30.CommandText = localCommand30.CommandText + "AND RoomStatus3.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus3.RoomNo";
              break;
            case "4":
              OleDbCommand localCommand31 = this.db.Local_Command;
              localCommand31.CommandText = localCommand31.CommandText + "Select RoomStatus4.RoomNo,RoomType.RmDescription,RoomStatus4.Description,RoomStatus4.ClientID,RoomStatus4.StartDate,RoomStatus4.EndDate From ( RoomType INNER JOIN RoomStatus4 ON RoomType.RoomType=RoomStatus4.RoomType)Where ((RoomStatus4.Status = 2 OR RoomStatus4.Status=3))AND Left(RoomStatus4.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand32 = this.db.Local_Command;
              localCommand32.CommandText = localCommand32.CommandText + "AND RoomStatus4.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus4.RoomNo";
              break;
            case "5":
              OleDbCommand localCommand33 = this.db.Local_Command;
              localCommand33.CommandText = localCommand33.CommandText + "Select RoomStatus5.RoomNo,RoomType.RmDescription,RoomStatus5.Description,RoomStatus5.ClientID,RoomStatus5.StartDate,RoomStatus5.EndDate From ( RoomType INNER JOIN RoomStatus5 ON RoomType.RoomType=RoomStatus5.RoomType)Where ((RoomStatus5.Status = 2 OR RoomStatus5.Status=3))AND Left(RoomStatus5.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand34 = this.db.Local_Command;
              localCommand34.CommandText = localCommand34.CommandText + "AND RoomStatus5.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus5.RoomNo";
              break;
            case "6":
              OleDbCommand localCommand35 = this.db.Local_Command;
              localCommand35.CommandText = localCommand35.CommandText + "Select RoomStatus6.RoomNo,RoomType.RmDescription,RoomStatus6.Description,RoomStatus6.ClientID,RoomStatus6.StartDate,RoomStatus6.EndDate From ( RoomType INNER JOIN RoomStatus6 ON RoomType.RoomType=RoomStatus6.RoomType)Where ((RoomStatus6.Status = 2 OR RoomStatus6.Status=3))AND Left(RoomStatus6.RoomNo,1)=  '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
              OleDbCommand localCommand36 = this.db.Local_Command;
              localCommand36.CommandText = localCommand36.CommandText + "AND RoomStatus6.StartDate  Between # " + Global_Data.sRYear + "-01-01 # AND # " + Global_Data.sRYear + "-12-31#ORDER BY RoomStatus6.RoomNo";
              break;
            default:
              int num3 = (int) MessageBox.Show("Need to implement for this case!");
              break;
          }
          break;
      }
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomStatus1TableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail);
      if (ReportClass_RoomDetail.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomDetailTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail);
      this.Check_For_GuestName(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo);
      if (ReportClass_RoomDetail.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomDetailTableAdapter.Update(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.RoomDetail);
      ((ReportDocument) this.roomdetail1).DataDefinition.FormulaFields[1].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID + "\"";
      ((ReportDocument) this.roomdetail1).DataDefinition.FormulaFields[2].Text = "\"" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\"";
      ((ReportDocument) this.roomdetail1).DataDefinition.FormulaFields[0].Text = "\"" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription + "\"";
      ((ReportDocument) this.roomdetail1).DataDefinition.FormulaFields[3].Text = "\"" + Global_Data.sBuildingName + "\"";
      ((ReportDocument) this.roomdetail1).DataDefinition.FormulaFields[4].Text = "\"" + para_ReportType + "\"";
      return this.roomdetail1;
    }
  }
}
