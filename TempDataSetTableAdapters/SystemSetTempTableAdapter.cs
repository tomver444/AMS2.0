// Decompiled with JetBrains decompiler
// Type: AMS.TempDataSetTableAdapters.SystemSetTempTableAdapter
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
namespace AMS.TempDataSetTableAdapters
{
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [ToolboxItem(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class SystemSetTempTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public SystemSetTempTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "SystemSetTemp",
        ColumnMappings = {
          {
            "SystemID",
            "SystemID"
          },
          {
            "Description",
            "Description"
          },
          {
            "BuildingType",
            "BuildingType"
          },
          {
            "Comport",
            "Comport"
          },
          {
            "GSTRate",
            "GSTRate"
          },
          {
            "Bonus",
            "Bonus"
          },
          {
            "CheckOutTime",
            "CheckOutTime"
          },
          {
            "MGraceDefault",
            "MGraceDefault"
          },
          {
            "WGraceDefault",
            "WGraceDefault"
          },
          {
            "DGraceDefault",
            "DGraceDefault"
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
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `SystemSetTemp` (`SystemID`, `Description`, `BuildingType`, `Comport`, `GSTRate`, `Bonus`, `CheckOutTime`, `MGraceDefault`, `WGraceDefault`, `DGraceDefault`, `StaffID`, `Update`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("SystemID", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SystemID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Description", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Description", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("BuildingType", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BuildingType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Comport", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Comport", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("GSTRate", OleDbType.Double, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GSTRate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Bonus", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bonus", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckOutTime", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("MGraceDefault", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "MGraceDefault", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("WGraceDefault", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "WGraceDefault", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("DGraceDefault", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DGraceDefault", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("StaffID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StaffID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Update", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Update", DataRowVersion.Current, false, (object) null));
    }

    [DebuggerNonUserCode]
    private void InitConnection()
    {
      this._connection = new OleDbConnection();
      this._connection.ConnectionString = Settings.Default.TempConnectionString;
    }

    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new OleDbCommand[1];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT SystemID, Description, BuildingType, Comport, GSTRate, Bonus, CheckOutTime, MGraceDefault, WGraceDefault, DGraceDefault, StaffID, [Update] FROM SystemSetTemp";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(TempDataSet.SystemSetTempDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual TempDataSet.SystemSetTempDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      TempDataSet.SystemSetTempDataTable data = new TempDataSet.SystemSetTempDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(TempDataSet.SystemSetTempDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(TempDataSet dataSet)
    {
      return this.Adapter.Update((DataSet) dataSet, "SystemSetTemp");
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow)
    {
      return this.Adapter.Update(new DataRow[1]{ dataRow });
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(
      short? SystemID,
      string Description,
      string BuildingType,
      byte? Comport,
      double? GSTRate,
      bool Bonus,
      string CheckOutTime,
      int? MGraceDefault,
      int? WGraceDefault,
      int? DGraceDefault,
      string StaffID,
      bool Update)
    {
      if (SystemID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) SystemID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (Description == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) Description;
      if (BuildingType == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) BuildingType;
      if (Comport.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) Comport.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (GSTRate.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) GSTRate.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[5].Value = (object) Bonus;
      if (CheckOutTime == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) CheckOutTime;
      if (MGraceDefault.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) MGraceDefault.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (WGraceDefault.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) WGraceDefault.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (DGraceDefault.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DGraceDefault.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (StaffID == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) StaffID;
      this.Adapter.InsertCommand.Parameters[11].Value = (object) Update;
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
  }
}
