// Decompiled with JetBrains decompiler
// Type: AMS.DB
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class DB
  {
    public System_DB system_DB;
    public Temp_DB temp_DB;
    public Building_DB1 building_DB1;
    public OleDbCommand Local_Command;
    public Staff_DB staff_DB;
    public OleDbDataAdapter local_adaptor;
    public BankingDB bankingDB;
    public ErradjustDB erradjustDB;
    public Replacement_DB1 replacement_DB1;

    public DB()
    {
      this.system_DB = new System_DB();
      this.temp_DB = new Temp_DB();
      this.building_DB1 = new Building_DB1();
      this.Local_Command = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Local_Command;
      this.staff_DB = new Staff_DB();
      this.local_adaptor = new OleDbDataAdapter();
      this.bankingDB = new BankingDB();
      this.erradjustDB = new ErradjustDB();
      this.replacement_DB1 = new Replacement_DB1();
    }

    public int Get_DailyRate_From_MonthlyRate(Decimal para_MonthlyRate)
    {
      Decimal num = para_MonthlyRate * 0.0328767123287671232876712329M;
      int rateFromMonthlyRate = (int) num;
      if ((Decimal) rateFromMonthlyRate + 0.5M <= num)
        ++rateFromMonthlyRate;
      return rateFromMonthlyRate;
    }

    public int GetNew_TransID(string Para_Bld_Num)
    {
      int num1 = 0;
      switch (Para_Bld_Num)
      {
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
          this.building_DB1.cardTransTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.CardTrans);
          if (this.building_DB1.buildingDB1DataSet.CardTrans.Rows.Count <= 0)
            return num1 + 1;
          foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.CardTrans.Rows)
          {
            int int32 = Convert.ToInt32(row.TransID);
            if (int32 > num1)
              num1 = int32;
          }
          return num1 + 1;
        default:
          int num2 = (int) MessageBox.Show("This Building not Found!");
          return -1;
      }
    }

    public void Update_Date_Building_Roomstaus_Table(string para_sBuildingNo)
    {
      this.building_DB1.roomStatusTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.StartDate == row.EndDate)
        {
          row.StartDate = DateTime.Now.Date;
          row.EndDate = row.StartDate;
        }
      }
      if (this.building_DB1.roomStatusTableAdapter.Update(this.building_DB1.buildingDB1DataSet.RoomStatus) <= 0)
        return;
      this.Update_RoomStausXX_inSystemDB(para_sBuildingNo);
    }

    public bool Get_GViewRoom_Temp(string para_sBuildingNo, string para_Room_No)
    {
      string commandText = this.temp_DB.gViewRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
      this.temp_DB.gViewRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from GViewRoom_Temp";
      this.temp_DB.gViewRoom_TempTableAdapter.Delete((string) null);
      this.temp_DB.gViewRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText;
      this.Local_Command.CommandText = "Insert into GViewRoom_Temp (ClientID,ForeName,SurName,Description,StartDate ,EndDate ) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus.ClientID,Client.ForeName,Client.SurName,RoomStatus.Description,  RoomStatus.StartDate,RoomStatus.EndDate From ( RoomStatus INNER JOIN Client ON RoomStatus.ClientID=Client.ClientID ) Where (((RoomStatus.RoomNo)='" + para_Room_No + "'))";
      this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
      this.local_adaptor.SelectCommand = this.Local_Command;
      this.local_adaptor.Fill((DataTable) this.temp_DB.tempDataSet.GViewRoom_Temp);
      return this.temp_DB.gViewRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.GViewRoom_Temp) > 0;
    }

    public bool Update_RoomStausXX_inSystemDB(string para_sBuildingNo)
    {
      SystemDataSet systemDataSet = new SystemDataSet();
      int num1 = 0;
      int num2;
      switch (para_sBuildingNo)
      {
        case "1":
          string commandText1 = this.system_DB.roomStatus1TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus1TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus1";
          this.system_DB.roomStatus1TableAdapter.Delete((string) null);
          this.system_DB.roomStatus1TableAdapter.Adapter.DeleteCommand.CommandText = commandText1;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus1.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus1);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus1.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus1TableAdapter.Update(systemDataSet.RoomStatus1);
          break;
        case "2":
          string commandText2 = this.system_DB.roomStatus2TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus2TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus2";
          this.system_DB.roomStatus2TableAdapter.Delete((string) null);
          this.system_DB.roomStatus2TableAdapter.Adapter.DeleteCommand.CommandText = commandText2;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus2.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus2);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus2.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus2TableAdapter.Update(systemDataSet.RoomStatus2);
          break;
        case "3":
          string commandText3 = this.system_DB.roomStatus3TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus3TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus3";
          this.system_DB.roomStatus3TableAdapter.Delete((string) null);
          this.system_DB.roomStatus3TableAdapter.Adapter.DeleteCommand.CommandText = commandText3;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus3.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus3);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus3.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus3TableAdapter.Update(systemDataSet.RoomStatus3);
          break;
        case "4":
          string commandText4 = this.system_DB.roomStatus4TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus4TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus4";
          this.system_DB.roomStatus4TableAdapter.Delete((string) null);
          this.system_DB.roomStatus4TableAdapter.Adapter.DeleteCommand.CommandText = commandText4;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus4.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus4);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus4.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus4TableAdapter.Update(systemDataSet.RoomStatus4);
          break;
        case "5":
          string commandText5 = this.system_DB.roomStatus5TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus5TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus5";
          this.system_DB.roomStatus5TableAdapter.Delete((string) null);
          this.system_DB.roomStatus5TableAdapter.Adapter.DeleteCommand.CommandText = commandText5;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus5.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus5);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus5.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus5TableAdapter.Update(systemDataSet.RoomStatus5);
          break;
        case "6":
          string commandText6 = this.system_DB.roomStatus6TableAdapter.Adapter.DeleteCommand.CommandText;
          this.system_DB.roomStatus6TableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from RoomStatus6";
          this.system_DB.roomStatus6TableAdapter.Delete((string) null);
          this.system_DB.roomStatus6TableAdapter.Adapter.DeleteCommand.CommandText = commandText6;
          this.Local_Command.CommandText = "SELECT * FROM RoomStatus in '" + Application.UserAppDataPath + "\\\\BuildingDB" + para_sBuildingNo + ".mdb 'Where ((left(RoomStatus.RoomNo,1) = '" + para_sBuildingNo + "')) Order By RoomNo";
          this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
          this.local_adaptor.SelectCommand = this.Local_Command;
          systemDataSet.RoomStatus6.Clear();
          num2 = this.local_adaptor.Fill((DataTable) systemDataSet.RoomStatus6);
          foreach (DataRow row in (InternalDataCollectionBase) systemDataSet.RoomStatus6.Rows)
            row.SetAdded();
          num1 = this.system_DB.roomStatus6TableAdapter.Update(systemDataSet.RoomStatus6);
          break;
        default:
          int num3 = (int) MessageBox.Show("Need to Implement for this Building" + para_sBuildingNo + "!");
          break;
      }
      if (num1 > 0)
        return true;
      int num4 = (int) MessageBox.Show("Update_RoomStausXX_inSystemDB for Building " + para_sBuildingNo + " Failed");
      return false;
    }

    public void Get_AvailableRoom_Temp(string para_sBuildingNo, string para_ROOM_TYPE)
    {
      SystemDataSet systemDataSet = new SystemDataSet();
      this.Update_RoomStausXX_inSystemDB(para_sBuildingNo);
      switch (para_sBuildingNo)
      {
        case "1":
          string commandText1 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText1;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus1.RoomNo,RoomStatus1.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus1.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus1.RoomNo,RoomStatus1.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus1.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus1.RoomNo,RoomStatus1.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus1.RoomNo,RoomStatus1.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus1.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus1TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        case "2":
          string commandText2 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText2;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus2.RoomNo,RoomStatus2.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus2.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus2.RoomNo,RoomStatus2.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus2.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus2.RoomNo,RoomStatus2.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus2.RoomNo,RoomStatus2.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus2.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus2TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        case "3":
          string commandText3 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText3;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus3.RoomNo,RoomStatus3.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus3.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus3.RoomNo,RoomStatus3.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus3.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus3.RoomNo,RoomStatus3.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus3.RoomNo,RoomStatus3.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus3.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus3TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        case "4":
          string commandText4 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText4;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus4.RoomNo,RoomStatus4.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus4.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus4.RoomNo,RoomStatus4.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus4.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus4.RoomNo,RoomStatus4.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus4.RoomNo,RoomStatus4.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus4.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus4TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        case "5":
          string commandText5 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText5;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus5.RoomNo,RoomStatus5.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus5.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus5.RoomNo,RoomStatus5.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus5.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus5.RoomNo,RoomStatus5.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus5.RoomNo,RoomStatus5.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus5.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus5TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        case "6":
          string commandText6 = this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AvailableRoom_Temp";
          this.temp_DB.availableRoom_TempTableAdapter.Delete((string) null);
          this.temp_DB.availableRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText6;
          switch (para_ROOM_TYPE)
          {
            case "SINGLE":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus6.RoomNo,RoomStatus6.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus6.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "STUDIO":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus6.RoomNo,RoomStatus6.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where (((RoomType.RmDescription)= '" + para_ROOM_TYPE + "'))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus6.Status)<2 ))ORDER BY Room.RoomNo";
              break;
            case "ALLGUEST":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus6.RoomNo,RoomStatus6.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where (((NOT((RoomType.RmDescription)= 'OFFICE')) AND (NOT((RoomType.RmDescription)= 'STORE'))))AND (((Room.BuildingNo)= '" + para_sBuildingNo + "'))ORDER BY Room.RoomNo";
              break;
            case "ALLROOM":
              this.Local_Command.CommandText = "Insert into AvailableRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate,MonthlyRate,DailyRate2,WeeklyRate2,MonthlyRate2,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus6.RoomNo,RoomStatus6.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,Room.DailyRate2,Room.WeeklyRate2,Room.MonthlyRate2,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType) INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where (((Room.BuildingNo)= '" + para_sBuildingNo + "')) AND (((RoomStatus6.Status)<4 ))ORDER BY Room.RoomNo";
              break;
          }
          this.Local_Command.Connection = this.system_DB.roomStatus6TableAdapter.Connection;
          this.Local_Command.Connection.Open();
          this.Local_Command.ExecuteNonQuery();
          this.Local_Command.Connection.Close();
          this.temp_DB.availableRoom_TempTableAdapter.Fill(this.temp_DB.tempDataSet.AvailableRoom_Temp);
          break;
        default:
          int num = (int) MessageBox.Show("Need to Implement for this case!");
          break;
      }
    }

    public int GetRefNo_New(string para_BuildingNo)
    {
      try
      {
        this.building_DB1.reserveTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.Reserve);
        if (this.building_DB1.buildingDB1DataSet.Reserve.Rows.Count <= 0)
          this.building_DB1.reserveTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.Reserve);
      }
      catch
      {
        this.building_DB1.reserveTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.Reserve);
      }
      return this.building_DB1.buildingDB1DataSet.Reserve.Rows.Count <= 0 ? 1 : ((BuildingDB1DataSet.ReserveRow) this.building_DB1.buildingDB1DataSet.Reserve.Rows[this.building_DB1.buildingDB1DataSet.Reserve.Rows.Count - 1]).RefNo + 1;
    }

    public string GetReserveNo_New(string para_ClientType, string para_BuildingNo)
    {
      int num1;
      int num2;
      switch (para_BuildingNo)
      {
        case "0":
        case "1":
          num1 = 99999 + (int) Convert.ToInt16(para_BuildingNo) * 100000;
          num2 = 1 - 1;
          break;
        default:
          int num3 = (int) Convert.ToInt16(para_BuildingNo) * 100000;
          num1 = 99999 + num3;
          num2 = 1 + num3 - 1;
          break;
      }
      this.building_DB1.reserveTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.Reserve);
      string reserveNoNew;
      if (this.building_DB1.buildingDB1DataSet.Reserve.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ReserveRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.Reserve.Rows)
        {
          int int32 = Convert.ToInt32(row.ReserveRef.Substring(2));
          if (int32 > num2 && int32 < num1)
            num2 = int32;
        }
        reserveNoNew = (num2 + 1).ToString("D6");
      }
      else
        reserveNoNew = (num2 + 1).ToString("D6");
      return reserveNoNew;
    }

    public bool ClientEdit(string para_Client_ID)
    {
      bool flag = false;
      try
      {
        this.building_DB1.clientTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.Client);
        foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.Client.Rows)
        {
          if (row.ClientID == para_Client_ID)
          {
            row.ClientID = gClientProperty.ClientID;
            row.ClientType = gClientProperty.ClientType;
            row.ForeName = gClientProperty.ForeName;
            row.SurName = gClientProperty.SurName;
            row.Sex = gClientProperty.Sex;
            row.Identity = gClientProperty.Identity;
            row.Nationality = gClientProperty.Nationality;
            row.Address = gClientProperty.Address;
            row.Contact = gClientProperty.Contact;
            row.Country = gClientProperty.Country;
            row.Email = gClientProperty.Email;
            row.Update = false;
            if (this.building_DB1.clientTableAdapter.Update(this.building_DB1.buildingDB1DataSet.Client) > 0)
            {
              flag = true;
              break;
            }
            break;
          }
        }
        return flag;
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception Write Failed! ClientEdit()");
        return false;
      }
    }

    public bool ClientAccountEdit(string para_Client_ID)
    {
      try
      {
        bool flag = false;
        string transType = gClientProperty.TransType;
        this.building_DB1.clientAccTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.ClientAcc);
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        {
          if (row.ClientID == para_Client_ID)
          {
            if (Global_Data.NewDate_NewCheckIn_FirstPerson_Flag)
            {
              try
              {
                row.CheckInTime = gCardProperty.CheckInTime;
              }
              catch
              {
                row.CheckInTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
              }
            }
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = false;
            if (gClientProperty.Condition != "")
              row.Condition = gClientProperty.Condition;
            if (transType == "E" || transType == "EL" || transType == "NE")
            {
              if (gClientProperty.Bond != "0.00")
                row.Bond = Convert.ToDecimal(gClientProperty.Bond);
              if (Convert.ToDecimal(gClientProperty.BonusClaim) != 0M)
              {
                if (gClientProperty.BonusDate != "")
                {
                  row.BonusDate = gClientProperty.BonusDate;
                  if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready)
                    row.CheckInDate = DateTime.Parse(gClientProperty.BonusDate).Date;
                }
              }
              try
              {
                if (gClientProperty.ChargeType != "")
                  row.ChargeType = gClientProperty.ChargeType.Substring(0, 1);
              }
              catch
              {
              }
              try
              {
                row.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
              }
              catch
              {
              }
            }
            Decimal num;
            try
            {
              num = Convert.ToDecimal(row.KeyDeposit);
            }
            catch
            {
              num = 0M;
            }
            if (transType == "I" || transType == "IU")
            {
              if (num != 0M)
                row.KeyDeposit += Convert.ToDecimal(gClientProperty.KeyDeposit);
              else
                row.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
              row.Deposit = Convert.ToDecimal(gClientProperty.DEPOSIT);
              if (transType == "I" && Convert.ToDecimal(gClientProperty.BonusClaim) != 0M && gClientProperty.BonusDate != "")
              {
                row.BonusDate = gClientProperty.BonusDate;
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready)
                  row.CheckInDate = DateTime.Parse(gClientProperty.BonusDate).Date;
              }
            }
            if (transType == "IA" || transType == "EA" || transType == "TA" || transType == "AT" || transType == "TL" || transType == "IL" || Mod_UpdateData.bExtraLoss)
            {
              row.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
              row.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
              if (transType == "IA")
                row.KeyDeposit = num + Convert.ToDecimal(gClientProperty.KeyDeposit);
              if ((transType == "IL" || transType == "AL") && gCardProperty.CardNo != "")
                row.CardNo = gCardProperty.CardNo;
            }
            if ((transType == "E" || transType == "AE") && row.Condition == "Individual")
            {
              row.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
              row.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
              row.ContractEnd = DateTime.Parse(gClientProperty.ContractEnd).Date;
              row.ValidStart = DateTime.Parse(gClientProperty.ValidStart).Date;
              row.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd).Date;
              row.CheckOutDate = gCardProperty.CheckOutDate.Date;
              row.CheckOutTime = DateTime.Parse("1899-12-30 " + gClientProperty.CheckOutTime);
            }
            else if ((transType == "E" || transType == "AE") && row.Condition == "Unit" && Convert.ToDecimal(gClientProperty.LastPayment) > 0M)
            {
              if (gClientProperty.RoomNo != "")
                row.RoomNo = gClientProperty.RoomNo;
              if (gCardProperty.CardNo != "")
                row.CardNo = gCardProperty.CardNo;
              row.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
              row.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bUnitClientEdit)
              {
                row.ContractEnd = DateTime.Parse(gClientProperty.ContractEnd).Date;
                row.ValidStart = DateTime.Parse(gClientProperty.ValidStart).Date;
                row.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd).Date;
                row.CheckOutDate = gCardProperty.CheckOutDate.Date;
                row.CheckOutTime = DateTime.Parse("1899-12-30 " + gClientProperty.CheckOutTime);
              }
            }
            if (!(transType == "IU") && !(transType == "E") && !(transType == "IA") && !(transType == "AE") && !(transType == "EA") && !(transType == "TA") && !(transType == "TL"))
            {
              if (gCardProperty.CardNo != "")
                row.CardNo = gCardProperty.CardNo;
              if (Mod_UpdateData.sChkGuest != "A")
              {
                if (gClientProperty.RoomNo != "")
                  row.RoomNo = gClientProperty.RoomNo;
              }
              else if (Mod_UpdateData.sChkGuest == "A" && gCardProperty.CardType == "ServiceCard")
              {
                if (gClientProperty.RoomNo != "")
                  row.RoomNo = gClientProperty.RoomNo;
              }
              else if (Mod_UpdateData.sChkGuest == "A")
              {
                if (!(gCardProperty.CardType == "Emergency"))
                {
                  if (!(gCardProperty.CardType == "RoomCard"))
                    goto label_58;
                }
                if (gClientProperty.RoomNo != "")
                  row.RoomNo = gClientProperty.RoomNo;
              }
label_58:
              try
              {
                                if (gClientProperty.ChargeType != "" && gClientProperty.ChargeType != null)
                                {
                                    if (gClientProperty.ChargeType.Equals(null))
                                    {
                                        gClientProperty.ChargeType = "";
                                    } else { 

                                        row.ChargeType = gClientProperty.ChargeType.Substring(0, 1);
                                    }
                                
                                }
              }
              catch
              {
              }
              try
              {
                if (row.CheckInDate.ToShortDateString() == "" || row.NoOfPeople == (byte) 9)
                  row.CheckInDate = DateTime.Parse(gClientProperty.ValidStart).Date;
                else if (Convert.ToDecimal(gClientProperty.BonusClaim) != 0M)
                {
                  if (gClientProperty.BonusDate != "")
                  {
                    row.BonusDate = gClientProperty.BonusDate;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready)
                      row.CheckInDate = DateTime.Parse(gClientProperty.BonusDate).Date;
                  }
                }
              }
              catch
              {
                row.CheckInDate = DateTime.Parse(gClientProperty.ValidStart).Date;
              }
              try
              {
                DateTime checkInTime = row.CheckInTime;
                row.CheckInTime = checkInTime.ToShortTimeString() == "" || row.NoOfPeople == (byte) 9 ? gCardProperty.CheckInTime : gCardProperty.CheckInTime;
              }
              catch
              {
                row.CheckInTime = gCardProperty.CheckInTime;
              }
              row.NoOfPeople = Convert.ToByte(gClientProperty.People);
              if (gClientProperty.ClientType == "G")
              {
                if (Mod_UpdateData.sChkGuest == "N")
                  row.Bond = Convert.ToDecimal(gClientProperty.Bond);
                row.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
                row.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
                row.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
              }
              try
              {
                row.ContractStart = DateTime.Parse(gClientProperty.ContractStart).Date;
              }
              catch
              {
              }
              try
              {
                row.ContractEnd = DateTime.Parse(gClientProperty.ContractEnd).Date;
              }
              catch
              {
              }
              try
              {
                row.ValidStart = DateTime.Parse(gClientProperty.ValidStart).Date;
              }
              catch
              {
              }
              try
              {
                row.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd).Date;
              }
              catch
              {
              }
              try
              {
                row.CheckOutDate = gCardProperty.CheckOutDate.Date;
              }
              catch
              {
              }
              try
              {
                row.CheckOutTime = DateTime.Parse("1899-12-30 " + gClientProperty.CheckOutTime);
              }
              catch
              {
              }
            }
            if (!(transType == "E") && !(transType == "EA") && !(transType == "IL") && !(transType == "AL"))
            {
              if (gClientProperty.ClientType == "G")
                row.AdvancedPayment = Convert.ToDecimal(gClientProperty.Advance);
              if (gClientProperty.Remark != "")
                row.Remark = gClientProperty.Remark;
              if (transType != "IU")
              {
                try
                {
                  row.RoomStart = DateTime.Parse(gClientProperty.RoomStart).Date;
                }
                catch
                {
                }
                try
                {
                  row.LastRecDate = DateTime.Parse(gClientProperty.LastRecDate).Date;
                }
                catch
                {
                }
              }
            }
            else
            {
              if (!(transType == "E"))
              {
                if (!(transType == "EA"))
                  goto label_117;
              }
              if (row.Condition == "Unit" && Convert.ToDecimal(gClientProperty.LastPayment) > 0M)
              {
                if (gClientProperty.ClientType == "G")
                  row.AdvancedPayment = Convert.ToDecimal(gClientProperty.Advance);
                if (gClientProperty.Remark != "")
                  row.Remark = gClientProperty.Remark;
                if (Convert.ToDecimal(gClientProperty.BonusClaim) != 0M && gClientProperty.BonusDate != "")
                {
                  row.BonusDate = gClientProperty.BonusDate;
                  if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready)
                    row.CheckInDate = DateTime.Parse(gClientProperty.BonusDate).Date;
                }
                if (transType != "IU")
                {
                  row.RoomStart = DateTime.Parse(gClientProperty.RoomStart).Date;
                  row.LastRecDate = DateTime.Parse(gClientProperty.LastRecDate).Date;
                }
              }
              else if (row.Condition == "Individual")
              {
                if (gClientProperty.ClientType == "G")
                  row.AdvancedPayment = Convert.ToDecimal(gClientProperty.Advance);
                if (gClientProperty.Remark != "")
                  row.Remark = gClientProperty.Remark;
                if (Convert.ToDecimal(gClientProperty.BonusClaim) != 0M && gClientProperty.BonusDate != "")
                {
                  row.BonusDate = gClientProperty.BonusDate;
                  if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready)
                    row.CheckInDate = DateTime.Parse(gClientProperty.BonusDate).Date;
                }
                row.RoomStart = DateTime.Parse(gClientProperty.RoomStart).Date;
                row.LastRecDate = DateTime.Parse(gClientProperty.LastRecDate).Date;
              }
            }
label_117:
            try
            {
              row.RmPriceAdjust = gClientProperty.RmPrice;
            }
            catch
            {
            }
            row.Update = false;
            if (this.building_DB1.clientAccTableAdapter.Update(this.building_DB1.buildingDB1DataSet.ClientAcc) > 0)
            {
              flag = true;
              break;
            }
            break;
          }
        }
        return flag;
      }
      catch
      {
        int num = (int) MessageBox.Show("Exception Write Failed! ClientAccountEdit()");
        return false;
      }
    }

    public void Get_AccReservationList()
    {
      string commandText1 = this.temp_DB.accReservationListTableAdapter.Adapter.DeleteCommand.CommandText;
      this.temp_DB.accReservationListTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from AccReservationList";
      this.temp_DB.accReservationListTableAdapter.Delete((string) null);
      this.temp_DB.accReservationListTableAdapter.Adapter.DeleteCommand.CommandText = commandText1;
      string commandText2 = this.temp_DB.reservationListTableAdapter.Adapter.DeleteCommand.CommandText;
      this.temp_DB.reservationListTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from ReservationList";
      this.temp_DB.reservationListTableAdapter.Delete((string) null);
      this.temp_DB.reservationListTableAdapter.Adapter.DeleteCommand.CommandText = commandText2;
      this.Local_Command.CommandText = "Insert into ReservationList (ReserveRef,RoomNo,ClientID,ForeName, SurName,Deposit,ReserveType,StartDate,EndDate) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select Reserve.ReserveRef,Reserve.RoomNo,Reserve.ClientID,Client.ForeName,Client.SurName,ClientAcc.Deposit,Reserve.ReserveType,Reserve.StartDate,Reserve.EndDate From ( ClientAcc INNER JOIN Reserve ON ClientAcc.ClientID=Reserve.ClientID)INNER JOIN Client ON Reserve.ClientID=Client.ClientID Where ((Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 + "') Or (Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 + "') Or (Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 + "') Or (Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 + "') Or (Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 + "') Or (Left(Reserve.RoomNo,1)= '" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 + "'))ORDER BY Reserve.RoomNo";
      this.Local_Command.Connection = this.building_DB1.clientTableAdapter.Connection;
      this.Local_Command.Connection.Open();
      this.Local_Command.ExecuteNonQuery();
      this.Local_Command.Connection.Close();
      this.Local_Command.CommandText = "Insert into AccReservationList  in'" + Application.UserAppDataPath + "\\Temp.mdb'SELECT * FROM ReservationList in '" + Application.UserAppDataPath + "\\Temp.mdb 'ORDER BY ReservationList.ClientID";
      this.Local_Command.Connection = this.temp_DB.reservationListTableAdapter.Connection;
      this.Local_Command.Connection.Open();
      this.Local_Command.ExecuteNonQuery();
      this.Local_Command.Connection.Close();
      this.temp_DB.accReservationListTableAdapter.Fill(this.temp_DB.tempDataSet.AccReservationList);
    }

    public bool CardDataUpdate(
      string para_Card_No,
      string para_Card_AutoNumber,
      string par_Card_HW_ID)
    {
      bool flag = false;
      this.building_DB1.cardNoTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        if (row.CardNo == para_Card_No && row.Card_AutoNumber == para_Card_AutoNumber && row.Card_HW_ID == par_Card_HW_ID)
        {
          row.CardStatus = Convert.ToByte(gClientProperty.ExtraKey);
          row.RecordDate = DateTime.Parse(gClientProperty.LastRecDate).Date;
          row.RecordTime = gCardProperty.CheckInTime.ToShortTimeString();
          row.Update = gClientProperty.Update;
          row.Card_AutoNumber = para_Card_AutoNumber;
          row.ReaderID = Global_Data.Card_Reader_ID;
          row.Card_HW_ID = par_Card_HW_ID;
          flag = true;
          break;
        }
      }
      return flag && this.building_DB1.cardNoTableAdapter.Update(this.building_DB1.buildingDB1DataSet.CardNo) > 0;
    }

    public bool CardDataUpdate_WoCard(string para_Card_No)
    {
      bool flag = false;
      this.building_DB1.cardNoTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        if (row.CardNo == para_Card_No)
        {
          row.CardStatus = Convert.ToByte(gClientProperty.ExtraKey);
          row.RecordDate = DateTime.Parse(gClientProperty.LastRecDate).Date;
          row.RecordTime = gCardProperty.CheckInTime.ToShortTimeString();
          row.Update = gClientProperty.Update;
          row.ReaderID = Global_Data.Card_Reader_ID;
          flag = true;
          break;
        }
      }
      return flag && this.building_DB1.cardNoTableAdapter.Update(this.building_DB1.buildingDB1DataSet.CardNo) > 0;
    }

    public bool TransactionAdd()
    {
      Issue_Card_Class issueCardClass = new Issue_Card_Class();
      string transType = gClientProperty.TransType;
      issueCardClass.CardTrans_Row_Buffer.Balance = 0M;
      issueCardClass.CardTrans_Row_Buffer.RBA = 0M;
      issueCardClass.CardTrans_Row_Buffer.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      try
      {
        issueCardClass.CardTrans_Row_Buffer.ClientID = gClientProperty.ClientID;
      }
      catch
      {
      }
      issueCardClass.CardTrans_Row_Buffer.CardNo = Mod_UpdateData.iChkCardStatus != (byte) 1 ? gCardProperty.CardNo : gCardProperty.CardNo;
      try
      {
        issueCardClass.CardTrans_Row_Buffer.AdvancedPayment = Convert.ToDecimal(gClientProperty.CurAdvance);
      }
      catch
      {
      }
      switch (transType)
      {
        case "T":
        case "TL":
          try
          {
            issueCardClass.CardTrans_Row_Buffer.OldRoom = Mod_UpdateData.sOldRoom;
          }
          catch
          {
          }
          try
          {
            issueCardClass.CardTrans_Row_Buffer.Bond = Convert.ToDecimal(gClientProperty.Bond);
          }
          catch
          {
          }
          try
          {
            issueCardClass.CardTrans_Row_Buffer.RoomCharge = Convert.ToDecimal(gClientProperty.RoomCharge);
          }
          catch
          {
          }
          try
          {
            issueCardClass.CardTrans_Row_Buffer.Balance = Convert.ToDecimal(gClientProperty.Balance);
          }
          catch
          {
          }
          try
          {
            if (gClientProperty.RBA != "0")
            {
              try
              {
                issueCardClass.CardTrans_Row_Buffer.RBA = Convert.ToDecimal(gClientProperty.RBA);
                break;
              }
              catch
              {
                break;
              }
            }
            else
              break;
          }
          catch
          {
            break;
          }
        case "AT":
          try
          {
            issueCardClass.CardTrans_Row_Buffer.OldRoom = Mod_UpdateData.sOldRoom;
            break;
          }
          catch
          {
            break;
          }
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.CardType = gCardProperty.CardType;
      }
      catch
      {
      }
      if (Mod_UpdateData.sChkGuest != "A")
      {
        try
        {
          issueCardClass.CardTrans_Row_Buffer.RoomNo = gClientProperty.RoomNo;
        }
        catch
        {
        }
      }
      else if (Mod_UpdateData.sChkGuest == "A")
      {
        if (!(gCardProperty.CardType == "Emergency"))
        {
          if (!(gCardProperty.CardType == "RoomCard"))
            goto label_31;
        }
        try
        {
          issueCardClass.CardTrans_Row_Buffer.RoomNo = gClientProperty.RoomNo;
        }
        catch
        {
        }
      }
label_31:
      if (Mod_UpdateData.sChkGuest == "N")
      {
        try
        {
          issueCardClass.CardTrans_Row_Buffer.Bond = Convert.ToDecimal(gClientProperty.Bond);
        }
        catch
        {
        }
        try
        {
          issueCardClass.CardTrans_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
        }
        catch
        {
        }
      }
      if (!(transType == "CC"))
      {
        if (!(transType == "CN"))
          goto label_45;
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.Bond = Convert.ToDecimal(gClientProperty.Bond);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
      try
      {
        if (Convert.ToDouble(gClientProperty.RBA) != 0.0)
          issueCardClass.CardTrans_Row_Buffer.RBA = Convert.ToDecimal(gClientProperty.RBA);
      }
      catch
      {
      }
label_45:
      if (!(transType == "I"))
      {
        if (!(transType == "IU"))
          goto label_52;
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.DEPOSIT != "0")
          issueCardClass.CardTrans_Row_Buffer.Deposit = -Convert.ToDecimal(gClientProperty.DEPOSIT);
      }
      catch
      {
      }
label_52:
      if (!(transType == "IS"))
      {
        if (!(transType == "NE"))
        {
          if (!(transType == "IA"))
          {
            if (!(transType == "IL"))
            {
              if (!(transType == "AL"))
              {
                if (!(transType == "EL"))
                {
                  if (!(transType == "EA"))
                  {
                    if (!(transType == "TA"))
                    {
                      if (!(transType == "TL"))
                        goto label_63;
                    }
                  }
                }
              }
            }
          }
        }
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
label_63:
      try
      {
        issueCardClass.CardTrans_Row_Buffer.ChargeType = gClientProperty.ChargeType.Substring(0, 1);
      }
      catch
      {
      }
      if (!(transType == "I"))
      {
        if (!(transType == "E"))
        {
          if (!(transType == "EL"))
          {
            if (!(transType == "NE"))
              goto label_74;
          }
        }
      }
      try
      {
        if (gClientProperty.People == "1")
          issueCardClass.CardTrans_Row_Buffer.RoomCharge = Convert.ToDecimal(gClientProperty.RoomCharge);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.Bond = Convert.ToDecimal(gClientProperty.Bond);
      }
      catch
      {
      }
label_74:
      try
      {
        if (!(gClientProperty.ExtraCharge != "0"))
        {
          if (!(gClientProperty.ExtraCharge != ""))
            goto label_81;
        }
        try
        {
          issueCardClass.CardTrans_Row_Buffer.ExtraCharge = Convert.ToDecimal(Mod_UpdateData.sChkExtraCharge);
        }
        catch
        {
        }
        try
        {
          issueCardClass.CardTrans_Row_Buffer.ExDescription = !(gClientProperty.ExDesp != "") ? "Extra Charges" : gClientProperty.ExDesp;
        }
        catch
        {
          issueCardClass.CardTrans_Row_Buffer.ExDescription = "Extra Charges";
        }
      }
      catch
      {
      }
label_81:
      try
      {
        issueCardClass.CardTrans_Row_Buffer.PreviousAdvance = Convert.ToDecimal(gClientProperty.PrevAdvance);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.BonusClaim = Convert.ToDecimal(gClientProperty.BonusClaim);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.Condition = gClientProperty.Condition;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.GST = Convert.ToDecimal(gClientProperty.TransGST);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.TransType = gClientProperty.TransType;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.TransDate = DateTime.Now.Date;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.TransTime = DateTime.Now.ToShortTimeString();
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd);
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.CheckInDate = gCardProperty.CheckInDate;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.CheckInTime = gCardProperty.CheckInTime.ToShortTimeString();
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.CheckOutDate = gCardProperty.CheckOutDate;
      }
      catch
      {
      }
      try
      {
        issueCardClass.CardTrans_Row_Buffer.CheckOutTime = gCardProperty.CheckOutTime.ToShortTimeString();
      }
      catch
      {
      }
      issueCardClass.CardTrans_Row_Buffer.ReserveRef = (string) null;
      issueCardClass.CardTrans_Row_Buffer.Update = false;
      if (issueCardClass.Write_CardTrans_Table())
        return true;
      int num = (int) MessageBox.Show("Write_CardTrans_Table Failed!");
      return false;
    }

    public bool LastTransAdd()
    {
      string transType = gClientProperty.TransType;
      this.building_DB1.lastTransTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.LastTrans);
      while (this.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count > 0)
      {
        this.building_DB1.lastTransTableAdapter.Delete(new int?(((BuildingDB1DataSet.LastTransRow) this.building_DB1.buildingDB1DataSet.LastTrans.Rows[0]).TransID));
        this.building_DB1.lastTransTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.LastTrans);
        if (this.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count == 0)
          break;
      }
      this.building_DB1.lastTransTableAdapter.Update(this.building_DB1.buildingDB1DataSet.LastTrans);
      BuildingDB1DataSet.LastTransRow row = this.building_DB1.buildingDB1DataSet.LastTrans.NewLastTransRow();
      row.RBA = 0M;
      row.Balance = 0M;
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bTracking)
        row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      if (Mod_UpdateData.sChkGuest == "N")
      {
        try
        {
          row.Bond = Convert.ToDecimal(gClientProperty.Bond);
        }
        catch
        {
        }
        try
        {
          row.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
        }
        catch
        {
        }
      }
      if (!(transType == "CC"))
      {
        if (!(transType == "CN"))
          goto label_19;
      }
      try
      {
        row.Bond = Convert.ToDecimal(gClientProperty.Bond);
      }
      catch
      {
      }
      try
      {
        row.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.RBA != "0")
          row.RBA = Convert.ToDecimal(gClientProperty.RBA);
      }
      catch
      {
      }
label_19:
      if (!(transType == "I"))
      {
        if (!(transType == "IU"))
          goto label_27;
      }
      try
      {
        row.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.DEPOSIT != "0")
        {
          try
          {
            row.Deposit = -Convert.ToDecimal(gClientProperty.DEPOSIT);
          }
          catch
          {
            row.Deposit = 0M;
          }
        }
      }
      catch
      {
      }
label_27:
      if (!(transType == "IS"))
      {
        if (!(transType == "NE"))
        {
          if (!(transType == "IA"))
          {
            if (!(transType == "IL"))
            {
              if (!(transType == "AL"))
              {
                if (!(transType == "EL"))
                {
                  if (!(transType == "EA"))
                  {
                    if (!(transType == "TA"))
                    {
                      if (!(transType == "TL"))
                        goto label_38;
                    }
                  }
                }
              }
            }
          }
        }
      }
      try
      {
        row.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
      }
      catch
      {
      }
label_38:
      if (transType == "T" || transType == "TL")
      {
        row.OldRoom = Mod_UpdateData.sOldRoom;
        try
        {
          row.Bond = Convert.ToDecimal(gClientProperty.Bond);
        }
        catch
        {
        }
        try
        {
          row.RoomCharge = Convert.ToDecimal(gClientProperty.RoomCharge);
        }
        catch
        {
        }
        try
        {
          row.Balance = Convert.ToDecimal(gClientProperty.Balance);
        }
        catch
        {
        }
        try
        {
          if (gClientProperty.RBA != "0")
            row.RBA = Convert.ToDecimal(gClientProperty.RBA);
        }
        catch
        {
        }
      }
      if (!(transType == "I"))
      {
        if (!(transType == "E"))
        {
          if (!(transType == "EL"))
          {
            if (!(transType == "NE"))
              goto label_59;
          }
        }
      }
      try
      {
        if (gClientProperty.People == "1")
          row.RoomCharge = Convert.ToDecimal(gClientProperty.RoomCharge);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.Bond != "0")
          row.Bond = Convert.ToDecimal(gClientProperty.Bond);
      }
      catch
      {
      }
label_59:
      try
      {
        if (!(Convert.ToDecimal(gClientProperty.ExtraCharge) == 0M))
        {
          if (!(gClientProperty.ExtraCharge == ""))
            row.ExtraCharge = Convert.ToDecimal(Mod_UpdateData.sChkExtraCharge);
        }
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.ExDesp != "")
          row.ExDescription = gClientProperty.ExDesp;
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.ClientID != "")
          row.ClientID = gClientProperty.ClientID;
      }
      catch
      {
      }
      if (Mod_UpdateData.iChkCardStatus == (byte) 1)
      {
        if (AccessCard.sCardNo != "")
          row.CardNo = AccessCard.sCardNo;
      }
      else
      {
        try
        {
          if (gCardProperty.CardNo != "")
            row.CardNo = gCardProperty.CardNo;
        }
        catch
        {
        }
      }
      try
      {
        if (gCardProperty.CardType != "")
          row.CardType = gCardProperty.CardType;
      }
      catch
      {
      }
      if (Mod_UpdateData.sChkGuest != "A")
      {
        try
        {
          if (gClientProperty.RoomNo != "")
            row.RoomNo = gClientProperty.RoomNo;
        }
        catch
        {
        }
      }
      try
      {
        if (Mod_UpdateData.sChkGuest != "A")
        {
          if (!(gCardProperty.CardType == "Emergency"))
          {
            if (!(gCardProperty.CardType == "RoomCard"))
              goto label_88;
          }
          if (gClientProperty.RoomNo != "")
            row.RoomNo = gClientProperty.RoomNo;
        }
      }
      catch
      {
      }
label_88:
      try
      {
        if (gClientProperty.TransType != "")
          row.TransType = gClientProperty.TransType;
      }
      catch
      {
      }
      row.TransDate = DateTime.Now.Date;
      row.TransTime = DateTime.Now.ToShortTimeString();
      try
      {
        row.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.ChargeType != "")
          row.ChargeType = gClientProperty.ChargeType.Substring(0, 1);
      }
      catch
      {
      }
      try
      {
        row.ValidStart = DateTime.Parse(gClientProperty.ValidStart).Date;
      }
      catch
      {
      }
      try
      {
        row.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd).Date;
      }
      catch
      {
      }
      try
      {
        row.CheckInTime = gCardProperty.CheckInTime.ToShortTimeString();
      }
      catch
      {
      }
      try
      {
        row.CheckOutDate = gCardProperty.CheckOutDate;
      }
      catch
      {
      }
      try
      {
        row.CheckInDate = gCardProperty.CheckInDate;
      }
      catch
      {
      }
      try
      {
        row.CheckOutTime = gCardProperty.CheckOutTime.ToShortTimeString();
      }
      catch
      {
      }
      try
      {
        row.AdvancedPayment = Convert.ToDecimal(gClientProperty.CurAdvance);
      }
      catch
      {
      }
      try
      {
        row.PreviousAdvance = Convert.ToDecimal(gClientProperty.PrevAdvance);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.BonusClaim != "0")
          row.BonusClaim = Convert.ToDecimal(gClientProperty.BonusClaim);
      }
      catch
      {
      }
      try
      {
        if (gClientProperty.Condition != "")
          row.Condition = gClientProperty.Condition;
      }
      catch
      {
      }
      try
      {
        row.GST = Convert.ToDecimal(gClientProperty.TransGST);
      }
      catch
      {
      }
      try
      {
        row.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
      }
      catch
      {
      }
      row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID != "")
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.building_DB1.buildingDB1DataSet.LastTrans.AddLastTransRow(row);
      return this.building_DB1.lastTransTableAdapter.Update(this.building_DB1.buildingDB1DataSet.LastTrans) > 0;
    }

    public byte Get_Room_Status_Num(string para_string)
    {
      switch (para_string)
      {
        case "Vacant":
          return 0;
        case "Vacant Clean":
          return 1;
        case "Reserved":
          return 2;
        case "Occupied":
          return 3;
        default:
          return 4;
      }
    }

    public byte Get_Room_Type_Num(string para_string)
    {
      byte roomTypeNum = 1;
      bool flag = false;
      this.system_DB.roomTypeTableAdapter.Fill(this.system_DB.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.system_DB.systemDataSet.RoomType.Rows)
      {
        if (row.RmDescription == para_string)
        {
          roomTypeNum = row.RoomType;
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        int num = (int) MessageBox.Show("RoomType Table not Found!");
      }
      return roomTypeNum;
    }

    public string Get_RoomType_Description(byte para_RoomType)
    {
      string roomTypeDescription = "";
      try
      {
        if (this.system_DB.systemDataSet.RoomType.Rows.Count <= 0)
          this.system_DB.roomTypeTableAdapter.Fill(this.system_DB.systemDataSet.RoomType);
      }
      catch
      {
        this.system_DB.roomTypeTableAdapter.Fill(this.system_DB.systemDataSet.RoomType);
      }
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.system_DB.systemDataSet.RoomType.Rows)
      {
        if ((int) para_RoomType == (int) row.RoomType)
        {
          roomTypeDescription = row.RmDescription;
          break;
        }
      }
      return roomTypeDescription;
    }

    public void CheckBuilding(ComboBox para_ComboBox, string para_myAccLevel)
    {
      para_ComboBox.Items.Clear();
      try
      {
        if (this.system_DB.systemDataSet.Building.Rows.Count <= 0)
          this.system_DB.buildingTableAdapter.Fill(this.system_DB.systemDataSet.Building);
      }
      catch
      {
        this.system_DB.buildingTableAdapter.Fill(this.system_DB.systemDataSet.Building);
      }
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.system_DB.systemDataSet.Building.Rows)
      {
        if (para_myAccLevel != "0")
        {
          if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
            para_ComboBox.Items.Add((object) row.BuildingNo);
        }
        else
          para_ComboBox.Items.Add((object) row.BuildingNo);
        if (para_ComboBox.Items.Count > 0)
          para_ComboBox.SelectedItem = (object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      }
    }

    public void ComboSelectedRooms(ComboBox para_ComboBox)
    {
      this.building_DB1.buildingDB1DataSet.RoomStatus.Clear();
      this.Local_Command.CommandText = "SELECT * FROM RoomStatus WHERE left(RoomNo,1)='" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'Order By RoomNo";
      this.Local_Command.Connection = this.building_DB1.roomStatusTableAdapter.Connection;
      this.local_adaptor.SelectCommand = this.Local_Command;
      this.local_adaptor.Fill((DataTable) this.building_DB1.buildingDB1DataSet.RoomStatus);
      para_ComboBox.Items.Clear();
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
        para_ComboBox.Items.Add((object) row.RoomNo);
      if (para_ComboBox.Items.Count > 0)
        para_ComboBox.SelectedIndex = 0;
      this.building_DB1.buildingDB1DataSet.RoomStatus.Clear();
    }

    public void ComboAddClientID(ComboBox para_ComboBox, string para_BuildingNo)
    {
      this.building_DB1.buildingDB1DataSet.ClientAcc.Clear();
      this.Local_Command.CommandText = "SELECT * FROM ClientAcc WHERE Right(ClientID,4)> '5000' AND left(RoomNo,1)='" + ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo + "'";
      this.Local_Command.Connection = this.building_DB1.clientAccTableAdapter.Connection;
      this.local_adaptor.SelectCommand = this.Local_Command;
      this.local_adaptor.Fill((DataTable) this.building_DB1.buildingDB1DataSet.ClientAcc);
      para_ComboBox.Items.Clear();
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        para_ComboBox.Items.Add((object) row.ClientID);
      if (para_ComboBox.Items.Count > 0)
        para_ComboBox.SelectedIndex = 0;
      this.building_DB1.buildingDB1DataSet.ClientAcc.Clear();
    }

    public byte[] PASSWORDENCRYPT(string para_PlainText)
    {
      byte[] para_PlainText1 = new byte[para_PlainText.Length];
      char[] charArray = para_PlainText.ToCharArray();
      for (int index = 0; index < para_PlainText.Length; ++index)
        para_PlainText1[index] = Convert.ToByte(charArray[index]);
      D1.encrypt(para_PlainText1);
      para_PlainText.ToCharArray();
      return para_PlainText1;
    }

    public void ComboFloorCheck(ComboBox para_ComboBox, string para_BuildingNo)
    {
      para_ComboBox.Items.Clear();
      this.system_DB.floorTableAdapter.Fill(this.system_DB.systemDataSet.Floor);
      foreach (SystemDataSet.FloorRow row in (InternalDataCollectionBase) this.system_DB.systemDataSet.Floor.Rows)
      {
        if (para_BuildingNo == row.BuildingNo)
          para_ComboBox.Items.Add((object) row.FloorNo);
      }
      if (para_ComboBox.Items.Count <= 0)
        return;
      para_ComboBox.SelectedIndex = 0;
    }

    public string RetrieveBldName(string para_BuildingNo)
    {
      string str = "";
      this.system_DB.buildingTableAdapter.Fill(this.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == para_BuildingNo)
          str = row.BldName;
      }
      return str;
    }

    public bool UPDATE_LOGIN(string para_Building_No)
    {
      bool flag = false;
      this.building_DB1.logInOutTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.LogInOut);
      BuildingDB1DataSet.LogInOutRow row = this.building_DB1.buildingDB1DataSet.LogInOut.NewLogInOutRow();
      row.LogDate = DateTime.Now.Date;
      row.InTime = Global_Data.gInTime;
      row.OutTime = "NA";
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.building_DB1.buildingDB1DataSet.LogInOut.AddLogInOutRow(row);
      if (this.building_DB1.logInOutTableAdapter.Update(this.building_DB1.buildingDB1DataSet.LogInOut) > 0)
        flag = true;
      return flag;
    }

    public bool UPDATE_LOGOUT(string para_Building_No)
    {
      bool flag1 = false;
      bool flag2 = false;
      this.building_DB1.logInOutTableAdapter.Fill(this.building_DB1.buildingDB1DataSet.LogInOut);
      DateTime date = DateTime.Now.Date;
      foreach (BuildingDB1DataSet.LogInOutRow row in (InternalDataCollectionBase) this.building_DB1.buildingDB1DataSet.LogInOut.Rows)
      {
        if (row.InTime == Global_Data.gInTime && row.LogDate.ToShortDateString() == date.ToShortDateString())
        {
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.OutTime = DateTime.Now.ToString("HH:mm:ss");
          flag1 = true;
          break;
        }
      }
      if (flag1 && this.building_DB1.logInOutTableAdapter.Update(this.building_DB1.buildingDB1DataSet.LogInOut) > 0)
        flag2 = true;
      return flag2;
    }

    public int Get_No_Of_Days(DateTime para_Start_Date, DateTime para_End_Date)
    {
      int num1 = 0;
      int num2 = 0;
      if (para_End_Date.CompareTo(para_Start_Date) <= 0)
      {
        int num3 = (int) MessageBox.Show("Not Valid Date Range!");
        return 0;
      }
      DateTime dateTime1 = para_End_Date;
      DateTime dateTime2;
      if (para_End_Date.Year == para_Start_Date.Year)
        dateTime1 = para_End_Date;
      else if (para_End_Date.Year > para_Start_Date.Year)
      {
        for (dateTime2 = new DateTime(para_Start_Date.AddYears(1).Year, 1, 1); dateTime2.Year < para_End_Date.Year; dateTime2 = dateTime2.AddYears(1))
        {
          num1 += 12;
          if (dateTime2.Year % 4 == 0)
            num2 += 366;
          else
            num2 += 365;
        }
        for (; dateTime2.CompareTo(para_End_Date) <= 0; dateTime2 = dateTime2.AddMonths(1))
        {
          if (dateTime2.Month < para_End_Date.Month)
            num2 += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
          else if (dateTime2.Month == para_End_Date.Month)
            num2 += para_End_Date.Day;
        }
        dateTime1 = new DateTime(para_Start_Date.Year, 12, 31);
      }
      else if (para_End_Date.Year > para_Start_Date.Year + 1)
      {
        int num4 = (int) MessageBox.Show("So long date range!");
        return 0;
      }
      int noOfDays;
      if (dateTime1.Month == para_Start_Date.Month)
      {
        noOfDays = dateTime1.Day - para_Start_Date.Day + num2;
      }
      else
      {
        int num5 = DateTime.DaysInMonth(para_Start_Date.Year, para_Start_Date.Month) - para_Start_Date.Day;
        for (dateTime2 = para_Start_Date.AddMonths(1); dateTime2.CompareTo(dateTime1) < 0 && dateTime2.Month < dateTime1.Month; dateTime2 = dateTime2.AddMonths(1))
          num5 += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
        noOfDays = num5 + dateTime1.Day + num2;
      }
      return noOfDays;
    }

    public int Get_Num_of_M_D_W(
      DateTime para_Start_Date,
      DateTime para_End_Date,
      string para_Charge_Type)
    {
      string str = "0";
      int numOfMDW1 = 0;
      int num1 = 0;
      int num2 = 0;
      bool flag = false;
      int numOfMDW2 = 0;
      DateTime dateTime1 = para_End_Date;
      if (para_End_Date.CompareTo(para_Start_Date) < 0)
      {
        int num3 = (int) MessageBox.Show("Not Valid Date Range!");
        return -1;
      }
      DateTime dateTime2;
      if (para_End_Date.Year == para_Start_Date.Year)
        dateTime1 = para_End_Date;
      else if (para_End_Date.Year > para_Start_Date.Year)
      {
        for (dateTime2 = new DateTime(para_Start_Date.AddYears(1).Year, 1, 1); dateTime2.Year < para_End_Date.Year; dateTime2 = dateTime2.AddYears(1))
        {
          num1 += 12;
          if (dateTime2.Year % 4 == 0)
            num2 += 366;
          else
            num2 += 365;
        }
        if (para_Charge_Type == "Monthly")
        {
          num1 += para_End_Date.Month - 1;
          num2 = para_End_Date.Day;
        }
        else
        {
          for (; dateTime2.CompareTo(para_End_Date) <= 0; dateTime2 = dateTime2.AddMonths(1))
          {
            if (dateTime2.Month < para_End_Date.Month)
              num2 += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
            else if (dateTime2.Month == para_End_Date.Month)
              num2 += para_End_Date.Day;
          }
        }
        dateTime1 = new DateTime(para_Start_Date.Year, 12, 31);
        flag = true;
      }
      else if (para_End_Date.Year > para_Start_Date.Year + 1)
      {
        int num4 = (int) MessageBox.Show("So long date range!");
        return -1;
      }
      if (para_Charge_Type == "Monthly")
      {
        if (dateTime1.Year == para_Start_Date.Year)
        {
          int num5;
          if (dateTime1.Month > para_Start_Date.Month)
          {
            if (dateTime1.Day >= para_Start_Date.Day)
            {
              if (para_Start_Date.Day > num2)
              {
                str = (dateTime1.Month - para_Start_Date.Month + num1).ToString();
                num5 = flag ? DateTime.DaysInMonth(para_Start_Date.Year, para_Start_Date.Month) - para_Start_Date.Day + num2 : dateTime1.Day - para_Start_Date.Day + num2;
              }
              else
              {
                str = (dateTime1.Month - para_Start_Date.Month + num1 + 1).ToString();
                num5 = num2 - para_Start_Date.Day;
              }
            }
            else
            {
              str = (dateTime1.Month - para_Start_Date.Month - 1 + num1).ToString();
              num5 = DateTime.DaysInMonth(para_Start_Date.Year, para_Start_Date.Month) - para_Start_Date.Day + dateTime1.Day + num2;
            }
          }
          else if (dateTime1.Month == para_Start_Date.Month)
          {
            if (para_Start_Date.Day > num2)
            {
              num5 = dateTime1.Day - para_Start_Date.Day + num2;
              str = num1.ToString();
            }
            else
            {
              str = (num1 + 1).ToString();
              num5 = num2 - para_Start_Date.Day;
            }
          }
          else
          {
            int num6 = (int) MessageBox.Show("Code Error Found! Pls. Check!");
            return -1;
          }
          num5.ToString();
        }
        else
        {
          int num7 = (int) MessageBox.Show("Code Error Found! Pls. Check!");
          return -1;
        }
      }
      else
      {
        if (dateTime1.Month == para_Start_Date.Month)
        {
          numOfMDW1 = dateTime1.Day - para_Start_Date.Day + num2;
        }
        else
        {
          int num8 = DateTime.DaysInMonth(para_Start_Date.Year, para_Start_Date.Month) - para_Start_Date.Day;
          for (dateTime2 = para_Start_Date.AddMonths(1); dateTime2.CompareTo(dateTime1) < 0 && dateTime2.Month < dateTime1.Month; dateTime2 = dateTime2.AddMonths(1))
            num8 += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
          numOfMDW1 = num8 + dateTime1.Day + num2;
        }
        if (para_Charge_Type == "Weekly")
        {
          if (numOfMDW1 < 7)
            return 0;
          numOfMDW2 = numOfMDW1 / 7;
          int num9 = numOfMDW1 % 7;
          numOfMDW2.ToString();
          num9.ToString();
        }
        else if (para_Charge_Type == "Daily")
          numOfMDW1.ToString();
      }
      if (para_Charge_Type == "Daily")
        return numOfMDW1;
      if (para_Charge_Type == "Weekly")
        return numOfMDW2;
      return para_Charge_Type == "Monthly" ? Convert.ToInt32(str) : -1;
    }

    public bool Backup_Before_Transact(string para_BldNo)
    {
      short int16 = Convert.ToInt16(Global_Data.sBldNo);
      switch (int16)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
          File.Delete(Application.UserAppDataPath + "\\system_2007_bak.accdb");
          File.Delete(Application.UserAppDataPath + "\\BuildingDB" + Convert.ToString(int16) + "_bak.mdb");
          File.Delete(Application.UserAppDataPath + "\\ReplacementDB" + Convert.ToString(int16) + "_bak.mdb");
          string str1 = "BuildingDB" + Convert.ToString(int16) + ".mdb";
          if (File.Exists(Application.UserAppDataPath + "\\" + str1))
          {
            try
            {
              File.Copy(Application.UserAppDataPath + "\\" + str1, Application.UserAppDataPath + "\\BuildingDB" + Convert.ToString(int16) + "_bak.mdb", true);
            }
            catch
            {
              return false;
            }
            string str2 = "ReplacementDB" + Convert.ToString(int16) + ".mdb";
            if (File.Exists(Application.UserAppDataPath + "\\" + str2))
            {
              try
              {
                File.Copy(Application.UserAppDataPath + "\\" + str2, Application.UserAppDataPath + "\\ReplacementDB" + Convert.ToString(int16) + "_bak.mdb", true);
              }
              catch
              {
                return false;
              }
              if (File.Exists(Application.UserAppDataPath + "\\System_2007.accdb"))
              {
                try
                {
                  File.Copy(Application.UserAppDataPath + "\\System_2007.accdb", Application.UserAppDataPath + "\\system_2007_bak.accdb", true);
                }
                catch
                {
                  return false;
                }
                return true;
              }
              int num = (int) MessageBox.Show(Application.UserAppDataPath + "\\System_2007.accdb is not found to backup!");
              return false;
            }
            int num1 = (int) MessageBox.Show(Application.UserAppDataPath + "\\" + str2 + " is not found to backup!");
            return false;
          }
          int num2 = (int) MessageBox.Show(Application.UserAppDataPath + "\\" + str1 + " is not found to backup!");
          return false;
        default:
          int num3 = (int) MessageBox.Show("Unvalid Building No. to backup!");
          return false;
      }
    }

    public bool Restore_For_FailedTransact(string para_BldNo)
    {
      short int16 = Convert.ToInt16(Global_Data.sBldNo);
      switch (int16)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
          string str1 = "BuildingDB" + Convert.ToString(int16) + ".mdb";
          if (File.Exists(Application.UserAppDataPath + "\\BuildingDB" + Convert.ToString(int16) + "_bak.mdb"))
          {
            try
            {
              File.Copy(Application.UserAppDataPath + "\\BuildingDB" + Convert.ToString(int16) + "_bak.mdb", Application.UserAppDataPath + "\\" + str1, true);
            }
            catch
            {
              return false;
            }
            string str2 = "ReplacementDB" + Convert.ToString(int16) + ".mdb";
            if (File.Exists(Application.UserAppDataPath + "\\ReplacementDB" + Convert.ToString(int16) + "_bak.mdb"))
            {
              try
              {
                File.Copy(Application.UserAppDataPath + "\\ReplacementDB" + Convert.ToString(int16) + "_bak.mdb", Application.UserAppDataPath + "\\" + str2, true);
              }
              catch
              {
                return false;
              }
              if (File.Exists(Application.UserAppDataPath + "\\system_2007_bak.accdb"))
              {
                try
                {
                  File.Copy(Application.UserAppDataPath + "\\system_2007_bak.accdb", Application.UserAppDataPath + "\\System_2007.accdb", true);
                }
                catch
                {
                  return false;
                }
                return true;
              }
              int num = (int) MessageBox.Show(Application.UserAppDataPath + "\\system_2007_bak.accdb is not found to restore!");
              return false;
            }
            int num1 = (int) MessageBox.Show(Application.UserAppDataPath + "\\ReplacementDB" + Convert.ToString(int16) + "_bak.mdb is not found to restore");
            return false;
          }
          int num2 = (int) MessageBox.Show(Application.UserAppDataPath + "\\BuildingDB" + Convert.ToString(int16) + "_bak.mdb is not found to restore");
          return false;
        default:
          int num3 = (int) MessageBox.Show("Unvalid Building No. To Restore!");
          return false;
      }
    }

    public int Get_Replacement_CardCount()
    {
      return this.replacement_DB1.replacementTableAdapter.Fill(this.replacement_DB1.replacementDB1DataSet.Replacement);
    }
  }
}
