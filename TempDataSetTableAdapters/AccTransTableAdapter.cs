// Decompiled with JetBrains decompiler
// Type: AMS.TempDataSetTableAdapters.AccTransTableAdapter
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
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class AccTransTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public AccTransTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "AccTrans",
        ColumnMappings = {
          {
            "TransID",
            "TransID"
          },
          {
            "ClientID",
            "ClientID"
          },
          {
            "CardNo",
            "CardNo"
          },
          {
            "CardType",
            "CardType"
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
            "TempBld",
            "TempBld"
          },
          {
            "ReserveRef",
            "ReserveRef"
          },
          {
            "OldRoom",
            "OldRoom"
          },
          {
            "PreviousAdvance",
            "PreviousAdvance"
          },
          {
            "AdvancedPayment",
            "AdvancedPayment"
          },
          {
            "Balance",
            "Balance"
          },
          {
            "Bond",
            "Bond"
          },
          {
            "RBA",
            "RBA"
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
            "ExtraCharge",
            "ExtraCharge"
          },
          {
            "ExDescription",
            "ExDescription"
          },
          {
            "RoomCharge",
            "RoomCharge"
          },
          {
            "TransType",
            "TransType"
          },
          {
            "TransDate",
            "TransDate"
          },
          {
            "TransTime",
            "TransTime"
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
            "CheckInDate",
            "CheckInDate"
          },
          {
            "CheckInTime",
            "CheckInTime"
          },
          {
            "CheckOutTime",
            "CheckOutTime"
          },
          {
            "CheckOutDate",
            "CheckOutDate"
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
            "BonusClaim",
            "BonusClaim"
          },
          {
            "GST",
            "GST"
          },
          {
            "LastPayment",
            "LastPayment"
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
      this._adapter.InsertCommand.CommandText = "INSERT INTO `AccTrans` (`TransID`, `ClientID`, `CardNo`, `CardType`, `RoomNo`, `Condition`, `TempBld`, `ReserveRef`, `OldRoom`, `PreviousAdvance`, `AdvancedPayment`, `Balance`, `Bond`, `RBA`, `Deposit`, `KeyDeposit`, `ExtraCharge`, `ExDescription`, `RoomCharge`, `TransType`, `TransDate`, `TransTime`, `ValidStart`, `ValidEnd`, `CheckInDate`, `CheckInTime`, `CheckOutTime`, `CheckOutDate`, `ChargeType`, `GracePeriod`, `BonusClaim`, `GST`, `LastPayment`, `StaffID`, `Update`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TransID", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TransID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ClientID", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ClientID", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CardNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CardNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CardType", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CardType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomNo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomNo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Condition", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Condition", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TempBld", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TempBld", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ReserveRef", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ReserveRef", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("OldRoom", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "OldRoom", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("PreviousAdvance", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PreviousAdvance", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("AdvancedPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AdvancedPayment", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Balance", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Balance", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Bond", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Bond", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RBA", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RBA", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Deposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Deposit", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("KeyDeposit", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "KeyDeposit", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ExtraCharge", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ExtraCharge", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ExDescription", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ExDescription", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("RoomCharge", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RoomCharge", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TransType", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TransType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TransDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TransDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("TransTime", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "TransTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ValidStart", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidStart", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ValidEnd", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ValidEnd", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckInDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckInTime", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckInTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckOutTime", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutTime", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CheckOutDate", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CheckOutDate", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ChargeType", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ChargeType", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("GracePeriod", OleDbType.SmallInt, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GracePeriod", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("BonusClaim", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BonusClaim", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("GST", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GST", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("LastPayment", OleDbType.Currency, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LastPayment", DataRowVersion.Current, false, (object) null));
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
      this._commandCollection[0].CommandText = "SELECT TransID, ClientID, CardNo, CardType, RoomNo, Condition, TempBld, ReserveRef, OldRoom, PreviousAdvance, AdvancedPayment, Balance, Bond, RBA, Deposit, KeyDeposit, ExtraCharge, ExDescription, RoomCharge, TransType, TransDate, TransTime, ValidStart, ValidEnd, CheckInDate, CheckInTime, CheckOutTime, CheckOutDate, ChargeType, GracePeriod, BonusClaim, GST, LastPayment, StaffID, [Update] FROM AccTrans";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(TempDataSet.AccTransDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    public virtual TempDataSet.AccTransDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      TempDataSet.AccTransDataTable data = new TempDataSet.AccTransDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(TempDataSet.AccTransDataTable dataTable)
    {
      return this.Adapter.Update((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(TempDataSet dataSet)
    {
      return this.Adapter.Update((DataSet) dataSet, "AccTrans");
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
      int? TransID,
      string ClientID,
      string CardNo,
      string CardType,
      string RoomNo,
      string Condition,
      string TempBld,
      string ReserveRef,
      string OldRoom,
      Decimal? PreviousAdvance,
      Decimal? AdvancedPayment,
      Decimal? Balance,
      Decimal? Bond,
      Decimal? RBA,
      Decimal? Deposit,
      Decimal? KeyDeposit,
      Decimal? ExtraCharge,
      string ExDescription,
      Decimal? RoomCharge,
      string TransType,
      DateTime? TransDate,
      string TransTime,
      DateTime? ValidStart,
      DateTime? ValidEnd,
      DateTime? CheckInDate,
      string CheckInTime,
      string CheckOutTime,
      DateTime? CheckOutDate,
      string ChargeType,
      short? GracePeriod,
      Decimal? BonusClaim,
      Decimal? GST,
      Decimal? LastPayment,
      string StaffID,
      bool Update)
    {
      if (TransID.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) TransID.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (ClientID == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) ClientID;
      if (CardNo == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) CardNo;
      if (CardType == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) CardType;
      if (RoomNo == null)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) RoomNo;
      if (Condition == null)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) Condition;
      if (TempBld == null)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) TempBld;
      if (ReserveRef == null)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) ReserveRef;
      if (OldRoom == null)
        this.Adapter.InsertCommand.Parameters[8].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[8].Value = (object) OldRoom;
      if (PreviousAdvance.HasValue)
        this.Adapter.InsertCommand.Parameters[9].Value = (object) PreviousAdvance.Value;
      else
        this.Adapter.InsertCommand.Parameters[9].Value = (object) DBNull.Value;
      if (AdvancedPayment.HasValue)
        this.Adapter.InsertCommand.Parameters[10].Value = (object) AdvancedPayment.Value;
      else
        this.Adapter.InsertCommand.Parameters[10].Value = (object) DBNull.Value;
      if (Balance.HasValue)
        this.Adapter.InsertCommand.Parameters[11].Value = (object) Balance.Value;
      else
        this.Adapter.InsertCommand.Parameters[11].Value = (object) DBNull.Value;
      if (Bond.HasValue)
        this.Adapter.InsertCommand.Parameters[12].Value = (object) Bond.Value;
      else
        this.Adapter.InsertCommand.Parameters[12].Value = (object) DBNull.Value;
      if (RBA.HasValue)
        this.Adapter.InsertCommand.Parameters[13].Value = (object) RBA.Value;
      else
        this.Adapter.InsertCommand.Parameters[13].Value = (object) DBNull.Value;
      if (Deposit.HasValue)
        this.Adapter.InsertCommand.Parameters[14].Value = (object) Deposit.Value;
      else
        this.Adapter.InsertCommand.Parameters[14].Value = (object) DBNull.Value;
      if (KeyDeposit.HasValue)
        this.Adapter.InsertCommand.Parameters[15].Value = (object) KeyDeposit.Value;
      else
        this.Adapter.InsertCommand.Parameters[15].Value = (object) DBNull.Value;
      if (ExtraCharge.HasValue)
        this.Adapter.InsertCommand.Parameters[16].Value = (object) ExtraCharge.Value;
      else
        this.Adapter.InsertCommand.Parameters[16].Value = (object) DBNull.Value;
      if (ExDescription == null)
        this.Adapter.InsertCommand.Parameters[17].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[17].Value = (object) ExDescription;
      if (RoomCharge.HasValue)
        this.Adapter.InsertCommand.Parameters[18].Value = (object) RoomCharge.Value;
      else
        this.Adapter.InsertCommand.Parameters[18].Value = (object) DBNull.Value;
      if (TransType == null)
        this.Adapter.InsertCommand.Parameters[19].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[19].Value = (object) TransType;
      if (TransDate.HasValue)
        this.Adapter.InsertCommand.Parameters[20].Value = (object) TransDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[20].Value = (object) DBNull.Value;
      if (TransTime == null)
        this.Adapter.InsertCommand.Parameters[21].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[21].Value = (object) TransTime;
      if (ValidStart.HasValue)
        this.Adapter.InsertCommand.Parameters[22].Value = (object) ValidStart.Value;
      else
        this.Adapter.InsertCommand.Parameters[22].Value = (object) DBNull.Value;
      if (ValidEnd.HasValue)
        this.Adapter.InsertCommand.Parameters[23].Value = (object) ValidEnd.Value;
      else
        this.Adapter.InsertCommand.Parameters[23].Value = (object) DBNull.Value;
      if (CheckInDate.HasValue)
        this.Adapter.InsertCommand.Parameters[24].Value = (object) CheckInDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[24].Value = (object) DBNull.Value;
      if (CheckInTime == null)
        this.Adapter.InsertCommand.Parameters[25].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[25].Value = (object) CheckInTime;
      if (CheckOutTime == null)
        this.Adapter.InsertCommand.Parameters[26].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[26].Value = (object) CheckOutTime;
      if (CheckOutDate.HasValue)
        this.Adapter.InsertCommand.Parameters[27].Value = (object) CheckOutDate.Value;
      else
        this.Adapter.InsertCommand.Parameters[27].Value = (object) DBNull.Value;
      if (ChargeType == null)
        this.Adapter.InsertCommand.Parameters[28].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[28].Value = (object) ChargeType;
      if (GracePeriod.HasValue)
        this.Adapter.InsertCommand.Parameters[29].Value = (object) GracePeriod.Value;
      else
        this.Adapter.InsertCommand.Parameters[29].Value = (object) DBNull.Value;
      if (BonusClaim.HasValue)
        this.Adapter.InsertCommand.Parameters[30].Value = (object) BonusClaim.Value;
      else
        this.Adapter.InsertCommand.Parameters[30].Value = (object) DBNull.Value;
      if (GST.HasValue)
        this.Adapter.InsertCommand.Parameters[31].Value = (object) GST.Value;
      else
        this.Adapter.InsertCommand.Parameters[31].Value = (object) DBNull.Value;
      if (LastPayment.HasValue)
        this.Adapter.InsertCommand.Parameters[32].Value = (object) LastPayment.Value;
      else
        this.Adapter.InsertCommand.Parameters[32].Value = (object) DBNull.Value;
      if (StaffID == null)
        this.Adapter.InsertCommand.Parameters[33].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[33].Value = (object) StaffID;
      this.Adapter.InsertCommand.Parameters[34].Value = (object) Update;
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
