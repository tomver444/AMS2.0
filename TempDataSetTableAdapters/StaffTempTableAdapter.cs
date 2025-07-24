// Decompiled with JetBrains decompiler
// Type: AMS.TempDataSetTableAdapters.StaffTempTableAdapter
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
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class StaffTempTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public StaffTempTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "StaffTemp",
        ColumnMappings = {
          {
            "StaffID",
            "StaffID"
          },
          {
            "AccLevel",
            "AccLevel"
          },
          {
            "AccBuilding1",
            "AccBuilding1"
          },
          {
            "AccBuilding2",
            "AccBuilding2"
          },
          {
            "AccBuilding3",
            "AccBuilding3"
          },
          {
            "AccBuilding4",
            "AccBuilding4"
          },
          {
            "AccBuilding5",
            "AccBuilding5"
          },
          {
            "AccBuilding6",
            "AccBuilding6"
          },
          {
            "SForeName",
            "SForeName"
          },
          {
            "SSurName",
            "SSurName"
          },
          {
            "Identity",
            "Identity"
          },
          {
            "Password",
            "Password"
          },
          {
            "Update",
            "Update"
          }
        }
      });
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `StaffTemp` (`StaffID`, `AccLevel`, `AccBuilding1`, `AccBuilding2`, `AccBuilding3`, `AccBuilding4`, `AccBuilding5`, `AccBuilding6`, `SForeName`, `SSurName`, `Identity`, `Password`, `Update`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("StaffID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StaffID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccLevel", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccLevel", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding1", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding1", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding2", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding2", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding3", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding3", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding4", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding4", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding5", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding5", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AccBuilding6", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AccBuilding6", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("SForeName", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SForeName", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("SSurName", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SSurName", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Identity", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Identity", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Password", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Password", DataRowVersion.Current, false, (object) null));
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
      this._commandCollection[0].CommandText = "SELECT StaffID, AccLevel, AccBuilding1, AccBuilding2, AccBuilding3, AccBuilding4, AccBuilding5, AccBuilding6, SForeName, SSurName, [Identity], [Password], [Update] FROM StaffTemp";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(TempDataSet.StaffTempDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual TempDataSet.StaffTempDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      TempDataSet.StaffTempDataTable data = new TempDataSet.StaffTempDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(TempDataSet.StaffTempDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(TempDataSet dataSet)
    {
      return this.Adapter.Update((DataSet) dataSet, "StaffTemp");
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
      string StaffID,
      string AccLevel,
      bool AccBuilding1,
      bool AccBuilding2,
      bool AccBuilding3,
      bool AccBuilding4,
      bool AccBuilding5,
      bool AccBuilding6,
      string SForeName,
      string SSurName,
      string Identity,
      string Password,
      bool Update)
    {
      if (StaffID == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) StaffID;
      if (AccLevel == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) AccLevel;
      this.Adapter.InsertCommand.Parameters[2].Value = (object) AccBuilding1;
      this.Adapter.InsertCommand.Parameters[3].Value = (object) AccBuilding2;
      this.Adapter.InsertCommand.Parameters[4].Value = (object) AccBuilding3;
      this.Adapter.InsertCommand.Parameters[5].Value = (object) AccBuilding4;
      this.Adapter.InsertCommand.Parameters[6].Value = (object) AccBuilding5;
      this.Adapter.InsertCommand.Parameters[7].Value = (object) AccBuilding6;
      if (SForeName == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) SForeName;
      if (SSurName == null)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) SSurName;
      if (Identity == null)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) Identity;
      if (Password == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) Password;
      this.Adapter.InsertCommand.Parameters[12].Value = (object) Update;
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
