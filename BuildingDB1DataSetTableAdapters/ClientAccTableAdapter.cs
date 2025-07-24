// Decompiled with JetBrains decompiler
// Type: AMS.BuildingDB1DataSetTableAdapters.ClientAccTableAdapter
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
namespace AMS.BuildingDB1DataSetTableAdapters
{
  [HelpKeyword("vs.data.TableAdapter")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class ClientAccTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public ClientAccTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "ClientAcc",
        ColumnMappings = {
          {
            "ClientID",
            "ClientID"
          },
          {
            "RoomNo",
            "RoomNo"
          },
          {
            "Condition",
            "Condition"
          },
          {
            "OldRoom",
            "OldRoom"
          },
          {
            "CardNo",
            "CardNo"
          },
          {
            "Deposit",
            "Deposit"
          },
          {
            "KeyDeposit",
            "KeyDeposit"
          },
          {
            "Bond",
            "Bond"
          },
          {
            "NoOfPeople",
            "NoOfPeople"
          },
          {
            "ContractStart",
            "ContractStart"
          },
          {
            "ContractEnd",
            "ContractEnd"
          },
          {
            "ChargeType",
            "ChargeType"
          },
          {
            "GracePeriod",
            "GracePeriod"
          },
          {
            "ValidStart",
            "ValidStart"
          },
          {
            "ValidEnd",
            "ValidEnd"
          },
          {
            "LastPayment",
            "LastPayment"
          },
          {
            "AmountPaid",
            "AmountPaid"
          },
          {
            "AdvancedPayment",
            "AdvancedPayment"
          },
          {
            "CheckInDate",
            "CheckInDate"
          },
          {
            "CheckInTime",
            "CheckInTime"
          },
          {
            "CheckOutDate",
            "CheckOutDate"
          },
          {
            "CheckOutTime",
            "CheckOutTime"
          },
          {
            "LastRecDate",
            "LastRecDate"
          },
          {
            "BonusDate",
            "BonusDate"
          },
          {
            "RoomStart",
            "RoomStart"
          },
          {
            "Remark",
            "Remark"
          },
          {
            "RmPriceAdjust",
            "RmPriceAdjust"
          },
          {
            "Update",
            "Update"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM ClientAcc\r\nWHERE  (ClientID = ?)";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("ClientID", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "ClientID", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `ClientAcc` (`ClientID`, `RoomNo`, `Condition`, `OldRoom`, `CardNo`, `Deposit`, `KeyDeposit`, `Bond`, `NoOfPeople`, `ContractStart`, `ContractEnd`, `ChargeType`, `GracePeriod`, `ValidStart`, `ValidEnd`, `LastPayment`, `AmountPaid`, `AdvancedPayment`, `CheckInDate`, `CheckInTime`, `CheckOutDate`, `CheckOutTime`, `LastRecDate`, `BonusDate`, `RoomStart`, `Remark`, `RmPriceAdjust`, `Update`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ClientID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ClientID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Condition", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Condition", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("OldRoom", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OldRoom", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CardNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CardNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Deposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Deposit", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("KeyDeposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KeyDeposit", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Bond", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bond", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("NoOfPeople", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NoOfPeople", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ContractStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ContractStart", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ContractEnd", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ContractEnd", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ChargeType", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ChargeType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("GracePeriod", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GracePeriod", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ValidStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidStart", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ValidEnd", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidEnd", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("LastPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LastPayment", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AmountPaid", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AmountPaid", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AdvancedPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AdvancedPayment", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckInDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckInTime", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckOutDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckOutTime", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("LastRecDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LastRecDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("BonusDate", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BonusDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomStart", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Remark", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Remark", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RmPriceAdjust", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RmPriceAdjust", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Update", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Update", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE ClientAcc\r\nSET          ClientID = ?, RoomNo = ?, Condition = ?, OldRoom = ?, CardNo = ?, Deposit = ?, KeyDeposit = ?, Bond = ?, NoOfPeople = ?, ContractStart = ?, ContractEnd = ?, ChargeType = ?, \r\n                  GracePeriod = ?, ValidStart = ?, ValidEnd = ?, LastPayment = ?, AmountPaid = ?, AdvancedPayment = ?, CheckInDate = ?, CheckInTime = ?, CheckOutDate = ?, \r\n                  CheckOutTime = ?, LastRecDate = ?, BonusDate = ?, RoomStart = ?, Remark = ?, RmPriceAdjust = ?, [Update] = ?\r\nWHERE  (ClientID = ?)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ClientID", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "ClientID", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Condition", OleDbType.WChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, "Condition", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("OldRoom", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "OldRoom", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CardNo", OleDbType.WChar, 5, ParameterDirection.Input, (byte) 0, (byte) 0, "CardNo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Deposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "Deposit", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("KeyDeposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "KeyDeposit", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Bond", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "Bond", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NoOfPeople", OleDbType.UnsignedTinyInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NoOfPeople", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ContractStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ContractStart", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ContractEnd", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ContractEnd", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ChargeType", OleDbType.WChar, 1, ParameterDirection.Input, (byte) 0, (byte) 0, "ChargeType", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("GracePeriod", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GracePeriod", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ValidStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidStart", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ValidEnd", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidEnd", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LastPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "LastPayment", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("AmountPaid", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "AmountPaid", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("AdvancedPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 19, (byte) 0, "AdvancedPayment", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CheckInDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInDate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CheckInTime", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInTime", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CheckOutDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutDate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CheckOutTime", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutTime", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("LastRecDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LastRecDate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("BonusDate", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "BonusDate", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RoomStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomStart", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Remark", OleDbType.WChar, 40, ParameterDirection.Input, (byte) 0, (byte) 0, "Remark", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("RmPriceAdjust", OleDbType.Boolean, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "RmPriceAdjust", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Update", OleDbType.Boolean, 2, ParameterDirection.Input, (byte) 0, (byte) 0, "Update", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ClientID", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "ClientID", DataRowVersion.Original, false, (object) null));
    }

    [DebuggerNonUserCode]
    private void InitConnection()
    {
      this._connection = new OleDbConnection();
      this._connection.ConnectionString = Settings.Default.BuildingDB1ConnectionString;
    }

    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new OleDbCommand[1];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT ClientID, RoomNo, Condition, OldRoom, CardNo, Deposit, KeyDeposit, Bond, NoOfPeople, ContractStart, ContractEnd, ChargeType, GracePeriod, ValidStart, ValidEnd, LastPayment, AmountPaid, AdvancedPayment, CheckInDate, CheckInTime, CheckOutDate, CheckOutTime, LastRecDate, BonusDate, RoomStart, Remark, RmPriceAdjust, [Update] FROM ClientAcc";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(BuildingDB1DataSet.ClientAccDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual BuildingDB1DataSet.ClientAccDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      BuildingDB1DataSet.ClientAccDataTable data = new BuildingDB1DataSet.ClientAccDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(BuildingDB1DataSet.ClientAccDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(BuildingDB1DataSet dataSet)
    {
      return this.Adapter.Update((DataSet) dataSet, "ClientAcc");
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

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(string ClientID)
    {
      if (ClientID == null)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) ClientID;
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

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(
      string ClientID,
      string RoomNo,
      string Condition,
      string OldRoom,
      string CardNo,
      Decimal? Deposit,
      Decimal? KeyDeposit,
      Decimal? Bond,
      byte? NoOfPeople,
      DateTime? ContractStart,
      DateTime? ContractEnd,
      string ChargeType,
      short? GracePeriod,
      DateTime? ValidStart,
      DateTime? ValidEnd,
      Decimal? LastPayment,
      Decimal? AmountPaid,
      Decimal? AdvancedPayment,
      DateTime? CheckInDate,
      DateTime? CheckInTime,
      DateTime? CheckOutDate,
      DateTime? CheckOutTime,
      DateTime? LastRecDate,
      string BonusDate,
      DateTime? RoomStart,
      string Remark,
      bool RmPriceAdjust,
      bool Update)
    {
      if (ClientID == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) ClientID;
      if (RoomNo == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) RoomNo;
      if (Condition == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) Condition;
      if (OldRoom == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) OldRoom;
      if (CardNo == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) CardNo;
      if (Deposit.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) Deposit.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (KeyDeposit.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) KeyDeposit.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (Bond.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) Bond.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      if (NoOfPeople.HasValue)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) NoOfPeople.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      if (ContractStart.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) ContractStart.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (ContractEnd.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) ContractEnd.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (ChargeType == null)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) ChargeType;
      if (GracePeriod.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) GracePeriod.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (ValidStart.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) ValidStart.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (ValidEnd.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) ValidEnd.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (LastPayment.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) LastPayment.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (AmountPaid.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) AmountPaid.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (AdvancedPayment.HasValue)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) AdvancedPayment.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      if (CheckInDate.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) CheckInDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (CheckInTime.HasValue)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) CheckInTime.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      if (CheckOutDate.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) CheckOutDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (CheckOutTime.HasValue)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) CheckOutTime.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      if (LastRecDate.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) LastRecDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (BonusDate == null)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) BonusDate;
      if (RoomStart.HasValue)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) RoomStart.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      if (Remark == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) Remark;
      this.Adapter.InsertCommand.Parameters[26].Value = (object) RmPriceAdjust;
      this.Adapter.InsertCommand.Parameters[27].Value = (object) Update;
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
      string ClientID,
      string RoomNo,
      string Condition,
      string OldRoom,
      string CardNo,
      Decimal? Deposit,
      Decimal? KeyDeposit,
      Decimal? Bond,
      byte? NoOfPeople,
      DateTime? ContractStart,
      DateTime? ContractEnd,
      string ChargeType,
      short? GracePeriod,
      DateTime? ValidStart,
      DateTime? ValidEnd,
      Decimal? LastPayment,
      Decimal? AmountPaid,
      Decimal? AdvancedPayment,
      DateTime? CheckInDate,
      DateTime? CheckInTime,
      DateTime? CheckOutDate,
      DateTime? CheckOutTime,
      DateTime? LastRecDate,
      string BonusDate,
      DateTime? RoomStart,
      string Remark,
      bool RmPriceAdjust,
      bool Update1,
      string Original_ClientID)
    {
      if (ClientID == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) ClientID;
      if (RoomNo == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) RoomNo;
      if (Condition == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) Condition;
      if (OldRoom == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) OldRoom;
      if (CardNo == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) CardNo;
      if (Deposit.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) Deposit.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (KeyDeposit.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) KeyDeposit.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (Bond.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) Bond.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (NoOfPeople.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) NoOfPeople.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
      if (ContractStart.HasValue)
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) ContractStart.Value;
      else
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) DBNull.Value;
      if (ContractEnd.HasValue)
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) ContractEnd.Value;
      else
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      if (ChargeType == null)
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[11].Value = (object) ChargeType;
      if (GracePeriod.HasValue)
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) GracePeriod.Value;
      else
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) DBNull.Value;
      if (ValidStart.HasValue)
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) ValidStart.Value;
      else
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      if (ValidEnd.HasValue)
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) ValidEnd.Value;
      else
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) DBNull.Value;
      if (LastPayment.HasValue)
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) LastPayment.Value;
      else
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      if (AmountPaid.HasValue)
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) AmountPaid.Value;
      else
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) DBNull.Value;
      if (AdvancedPayment.HasValue)
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) AdvancedPayment.Value;
      else
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      if (CheckInDate.HasValue)
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) CheckInDate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[18].Value = (object) DBNull.Value;
      if (CheckInTime.HasValue)
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) CheckInTime.Value;
      else
        this.Adapter.UpdateCommand.Parameters[19].Value = (object) DBNull.Value;
      if (CheckOutDate.HasValue)
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) CheckOutDate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[20].Value = (object) DBNull.Value;
      if (CheckOutTime.HasValue)
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) CheckOutTime.Value;
      else
        this.Adapter.UpdateCommand.Parameters[21].Value = (object) DBNull.Value;
      if (LastRecDate.HasValue)
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) LastRecDate.Value;
      else
        this.Adapter.UpdateCommand.Parameters[22].Value = (object) DBNull.Value;
      if (BonusDate == null)
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[23].Value = (object) BonusDate;
      if (RoomStart.HasValue)
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) RoomStart.Value;
      else
        this.Adapter.UpdateCommand.Parameters[24].Value = (object) DBNull.Value;
      if (Remark == null)
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[25].Value = (object) Remark;
      this.Adapter.UpdateCommand.Parameters[26].Value = (object) RmPriceAdjust;
      this.Adapter.UpdateCommand.Parameters[27].Value = (object) Update1;
      if (Original_ClientID == null)
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[28].Value = (object) Original_ClientID;
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
