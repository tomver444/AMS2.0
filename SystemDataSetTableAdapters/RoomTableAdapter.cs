// Decompiled with JetBrains decompiler
// Type: AMS.SystemDataSetTableAdapters.RoomTableAdapter
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

#nullable disable
namespace AMS.SystemDataSetTableAdapters
{
  [ToolboxItem(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class RoomTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public RoomTableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    protected internal OleDbDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    internal OleDbConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [DebuggerNonUserCode]
    internal OleDbTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [DebuggerNonUserCode]
    protected OleDbCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    private void InitAdapter()
    {
      this._adapter = new OleDbDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Room",
        ColumnMappings = {
          {
            "RoomNo",
            "RoomNo"
          },
          {
            "RoomID",
            "RoomID"
          },
          {
            "RoomType",
            "RoomType"
          },
          {
            "FloorNo",
            "FloorNo"
          },
          {
            "BuildingNo",
            "BuildingNo"
          },
          {
            "DailyRate",
            "DailyRate"
          },
          {
            "WeeklyRate",
            "WeeklyRate"
          },
          {
            "MonthlyRate",
            "MonthlyRate"
          },
          {
            "DailyRate2",
            "DailyRate2"
          },
          {
            "WeeklyRate2",
            "WeeklyRate2"
          },
          {
            "MonthlyRate2",
            "MonthlyRate2"
          },
          {
            "IssuedCard",
            "IssuedCard"
          },
          {
            "TotalStay",
            "TotalStay"
          },
          {
            "StaffID",
            "StaffID"
          },
          {
            "Update",
            "Update"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM Room\r\nWHERE  (RoomNo = ?)";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Room` (`RoomNo`, `RoomID`, `RoomType`, `FloorNo`, `BuildingNo`, `DailyRate`, `WeeklyRate`, `MonthlyRate`, `DailyRate2`, `WeeklyRate2`, `MonthlyRate2`, `IssuedCard`, `TotalStay`, `StaffID`, `Update`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomType", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("FloorNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FloorNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("BuildingNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BuildingNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("DailyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DailyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("WeeklyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WeeklyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("MonthlyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MonthlyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("DailyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DailyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("WeeklyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WeeklyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("MonthlyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MonthlyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("IssuedCard", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IssuedCard", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TotalStay", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TotalStay", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("StaffID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StaffID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Update", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Update", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE Room\r\nSET          RoomNo = ?, RoomID = ?, RoomType = ?, FloorNo = ?, BuildingNo = ?, DailyRate = ?, WeeklyRate = ?, MonthlyRate = ?, DailyRate2 = ?, WeeklyRate2 = ?, MonthlyRate2 = ?, \r\n                  IssuedCard = ?, TotalStay = ?, StaffID = ?, [Update] = ?\r\nWHERE  (RoomNo = ?)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RoomID", OleDbType.WChar, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomID", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RoomType", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomType", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("FloorNo", OleDbType.WChar, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "FloorNo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BuildingNo", OleDbType.WChar, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "BuildingNo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DailyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "DailyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("WeeklyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "WeeklyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MonthlyRate", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "MonthlyRate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DailyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "DailyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("WeeklyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "WeeklyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("MonthlyRate2", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "MonthlyRate2", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IssuedCard", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IssuedCard", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("TotalStay", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TotalStay", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("StaffID", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "StaffID", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Update", OleDbType.Boolean, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "Update", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_RoomNo", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Original, false, (object) null));
    }

    [DebuggerNonUserCode]
    private void InitConnection()
    {
      this._connection = new OleDbConnection();
      this._connection.ConnectionString = Settings.Default.System_2007ConnectionString;
    }

    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new OleDbCommand[1];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT  RoomNo, RoomID, RoomType, FloorNo, BuildingNo, DailyRate, WeeklyRate, MonthlyRate, DailyRate2, WeeklyRate2, MonthlyRate2, IssuedCard, TotalStay, StaffID, [Update]\r\nFROM     Room\r\nORDER BY RoomNo";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Fill(SystemDataSet.RoomDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    public virtual SystemDataSet.RoomDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      SystemDataSet.RoomDataTable data = new SystemDataSet.RoomDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(SystemDataSet.RoomDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(SystemDataSet dataSet)
    {
      return this.Adapter.Update((DataSet) dataSet, "Room");
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(DataRow dataRow)
    {
      return this.Adapter.Update(new DataRow[1]{ dataRow });
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(string RoomNo)
    {
      if (RoomNo == null)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) RoomNo;
      ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
      if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.DeleteCommand.Connection.Open();
      try
      {
        return this.Adapter.DeleteCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.DeleteCommand.Connection.Close();
      }
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Insert(
      string RoomNo,
      string RoomID,
      byte? RoomType,
      string FloorNo,
      string BuildingNo,
      Decimal? DailyRate,
      Decimal? WeeklyRate,
      Decimal? MonthlyRate,
      Decimal? DailyRate2,
      Decimal? WeeklyRate2,
      Decimal? MonthlyRate2,
      short? IssuedCard,
      byte? TotalStay,
      string StaffID,
      bool Update)
    {
      if (RoomNo == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) RoomNo;
      if (RoomID == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) RoomID;
      if (RoomType.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) RoomType.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (FloorNo == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) FloorNo;
      if (BuildingNo == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) BuildingNo;
      if (DailyRate.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DailyRate.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (WeeklyRate.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) WeeklyRate.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MonthlyRate.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) MonthlyRate.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (DailyRate2.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DailyRate2.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (WeeklyRate2.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) WeeklyRate2.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (MonthlyRate2.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) MonthlyRate2.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (IssuedCard.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) IssuedCard.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (TotalStay.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) TotalStay.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (StaffID == null)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) StaffID;
      this.Adapter.InsertCommand.Parameters[14].Value = (object) Update;
      ConnectionState state = this.Adapter.InsertCommand.Connection.State;
      if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.InsertCommand.Connection.Open();
      try
      {
        return this.Adapter.InsertCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.InsertCommand.Connection.Close();
      }
    }

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(
      string RoomNo,
      string RoomID,
      byte? RoomType,
      string FloorNo,
      string BuildingNo,
      Decimal? DailyRate,
      Decimal? WeeklyRate,
      Decimal? MonthlyRate,
      Decimal? DailyRate2,
      Decimal? WeeklyRate2,
      Decimal? MonthlyRate2,
      short? IssuedCard,
      byte? TotalStay,
      string StaffID,
      bool Update1,
      string Original_RoomNo)
    {
      if (RoomNo == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) RoomNo;
      if (RoomID == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) RoomID;
      if (RoomType.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) RoomType.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (FloorNo == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) FloorNo;
      if (BuildingNo == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) BuildingNo;
      if (DailyRate.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DailyRate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (WeeklyRate.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) WeeklyRate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (MonthlyRate.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) MonthlyRate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (DailyRate2.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DailyRate2.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (WeeklyRate2.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) WeeklyRate2.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (MonthlyRate2.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) MonthlyRate2.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (IssuedCard.HasValue)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) IssuedCard.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      if (TotalStay.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) TotalStay.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (StaffID == null)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) StaffID;
      this.Adapter.UpdateCommand.Parameters[14].Value = (object) Update1;
      if (Original_RoomNo == null)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_RoomNo;
      ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
      if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.UpdateCommand.Connection.Open();
      try
      {
        return this.Adapter.UpdateCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.UpdateCommand.Connection.Close();
      }
    }
  }
}
