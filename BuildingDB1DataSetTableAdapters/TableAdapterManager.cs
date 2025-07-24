// Decompiled with JetBrains decompiler
// Type: AMS.BuildingDB1DataSetTableAdapters.TableAdapterManager
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

#nullable disable
namespace AMS.BuildingDB1DataSetTableAdapters
{
  [HelpKeyword("vs.data.TableAdapterManager")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private CardNoTableAdapter _cardNoTableAdapter;
    private CardTransTableAdapter _cardTransTableAdapter;
    private AllLockedRecordTableAdapter _allLockedRecordTableAdapter;
    private EventLogTableAdapter _eventLogTableAdapter;
    private ExtraChargeTableAdapter _extraChargeTableAdapter;
    private KeyChargesTableAdapter _keyChargesTableAdapter;
    private LastTransTableAdapter _lastTransTableAdapter;
    private LockedRecordTableAdapter _lockedRecordTableAdapter;
    private LogInOutTableAdapter _logInOutTableAdapter;
    private ReserveTableAdapter _reserveTableAdapter;
    private RoomStatusTableAdapter _roomStatusTableAdapter;
    private UnitRefTableAdapter _unitRefTableAdapter;
    private ClientAccTableAdapter _clientAccTableAdapter;
    private ClientTableAdapter _clientTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public CardNoTableAdapter CardNoTableAdapter
    {
      get => this._cardNoTableAdapter;
      set => this._cardNoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public CardTransTableAdapter CardTransTableAdapter
    {
      get => this._cardTransTableAdapter;
      set => this._cardTransTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AllLockedRecordTableAdapter AllLockedRecordTableAdapter
    {
      get => this._allLockedRecordTableAdapter;
      set => this._allLockedRecordTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public EventLogTableAdapter EventLogTableAdapter
    {
      get => this._eventLogTableAdapter;
      set => this._eventLogTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ExtraChargeTableAdapter ExtraChargeTableAdapter
    {
      get => this._extraChargeTableAdapter;
      set => this._extraChargeTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public KeyChargesTableAdapter KeyChargesTableAdapter
    {
      get => this._keyChargesTableAdapter;
      set => this._keyChargesTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public LastTransTableAdapter LastTransTableAdapter
    {
      get => this._lastTransTableAdapter;
      set => this._lastTransTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public LockedRecordTableAdapter LockedRecordTableAdapter
    {
      get => this._lockedRecordTableAdapter;
      set => this._lockedRecordTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public LogInOutTableAdapter LogInOutTableAdapter
    {
      get => this._logInOutTableAdapter;
      set => this._logInOutTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ReserveTableAdapter ReserveTableAdapter
    {
      get => this._reserveTableAdapter;
      set => this._reserveTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomStatusTableAdapter RoomStatusTableAdapter
    {
      get => this._roomStatusTableAdapter;
      set => this._roomStatusTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public UnitRefTableAdapter UnitRefTableAdapter
    {
      get => this._unitRefTableAdapter;
      set => this._unitRefTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public ClientAccTableAdapter ClientAccTableAdapter
    {
      get => this._clientAccTableAdapter;
      set => this._clientAccTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ClientTableAdapter ClientTableAdapter
    {
      get => this._clientTableAdapter;
      set => this._clientTableAdapter = value;
    }

    [DebuggerNonUserCode]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        if (this._cardNoTableAdapter != null && this._cardNoTableAdapter.Connection != null)
          return (IDbConnection) this._cardNoTableAdapter.Connection;
        if (this._cardTransTableAdapter != null && this._cardTransTableAdapter.Connection != null)
          return (IDbConnection) this._cardTransTableAdapter.Connection;
        if (this._allLockedRecordTableAdapter != null && this._allLockedRecordTableAdapter.Connection != null)
          return (IDbConnection) this._allLockedRecordTableAdapter.Connection;
        if (this._eventLogTableAdapter != null && this._eventLogTableAdapter.Connection != null)
          return (IDbConnection) this._eventLogTableAdapter.Connection;
        if (this._extraChargeTableAdapter != null && this._extraChargeTableAdapter.Connection != null)
          return (IDbConnection) this._extraChargeTableAdapter.Connection;
        if (this._keyChargesTableAdapter != null && this._keyChargesTableAdapter.Connection != null)
          return (IDbConnection) this._keyChargesTableAdapter.Connection;
        if (this._lastTransTableAdapter != null && this._lastTransTableAdapter.Connection != null)
          return (IDbConnection) this._lastTransTableAdapter.Connection;
        if (this._lockedRecordTableAdapter != null && this._lockedRecordTableAdapter.Connection != null)
          return (IDbConnection) this._lockedRecordTableAdapter.Connection;
        if (this._logInOutTableAdapter != null && this._logInOutTableAdapter.Connection != null)
          return (IDbConnection) this._logInOutTableAdapter.Connection;
        if (this._reserveTableAdapter != null && this._reserveTableAdapter.Connection != null)
          return (IDbConnection) this._reserveTableAdapter.Connection;
        if (this._roomStatusTableAdapter != null && this._roomStatusTableAdapter.Connection != null)
          return (IDbConnection) this._roomStatusTableAdapter.Connection;
        if (this._unitRefTableAdapter != null && this._unitRefTableAdapter.Connection != null)
          return (IDbConnection) this._unitRefTableAdapter.Connection;
        if (this._clientAccTableAdapter != null && this._clientAccTableAdapter.Connection != null)
          return (IDbConnection) this._clientAccTableAdapter.Connection;
        return this._clientTableAdapter != null && this._clientTableAdapter.Connection != null ? (IDbConnection) this._clientTableAdapter.Connection : (IDbConnection) null;
      }
      set => this._connection = value;
    }

    [DebuggerNonUserCode]
    [Browsable(false)]
    public int TableAdapterInstanceCount
    {
      get
      {
        int adapterInstanceCount = 0;
        if (this._cardNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._cardTransTableAdapter != null)
          ++adapterInstanceCount;
        if (this._allLockedRecordTableAdapter != null)
          ++adapterInstanceCount;
        if (this._eventLogTableAdapter != null)
          ++adapterInstanceCount;
        if (this._extraChargeTableAdapter != null)
          ++adapterInstanceCount;
        if (this._keyChargesTableAdapter != null)
          ++adapterInstanceCount;
        if (this._lastTransTableAdapter != null)
          ++adapterInstanceCount;
        if (this._lockedRecordTableAdapter != null)
          ++adapterInstanceCount;
        if (this._logInOutTableAdapter != null)
          ++adapterInstanceCount;
        if (this._reserveTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatusTableAdapter != null)
          ++adapterInstanceCount;
        if (this._unitRefTableAdapter != null)
          ++adapterInstanceCount;
        if (this._clientAccTableAdapter != null)
          ++adapterInstanceCount;
        if (this._clientTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    private int UpdateUpdatedRows(
      BuildingDB1DataSet dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._reserveTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Reserve.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._reserveTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._logInOutTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.LogInOut.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._logInOutTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._lockedRecordTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.LockedRecord.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._lockedRecordTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatusTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatusTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._clientTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Client.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._clientTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._clientAccTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ClientAcc.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._clientAccTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._unitRefTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.UnitRef.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._unitRefTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._allLockedRecordTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AllLockedRecord.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._allLockedRecordTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._cardTransTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.CardTrans.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._cardTransTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._cardNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.CardNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._cardNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._eventLogTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.EventLog.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._eventLogTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._lastTransTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.LastTrans.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._lastTransTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._keyChargesTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.KeyCharges.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._keyChargesTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._extraChargeTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ExtraCharge.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._extraChargeTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateInsertedRows(BuildingDB1DataSet dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._reserveTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Reserve.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._reserveTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._logInOutTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LogInOut.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._logInOutTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lockedRecordTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LockedRecord.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lockedRecordTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatusTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatusTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._clientTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Client.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._clientTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._clientAccTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ClientAcc.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._clientAccTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unitRefTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnitRef.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unitRefTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._allLockedRecordTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AllLockedRecord.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._allLockedRecordTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._cardTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CardTrans.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._cardTransTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._cardNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CardNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._cardNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._eventLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.EventLog.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._eventLogTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lastTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LastTrans.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lastTransTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._keyChargesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.KeyCharges.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._keyChargesTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraChargeTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCharge.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraChargeTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateDeletedRows(BuildingDB1DataSet dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._extraChargeTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCharge.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraChargeTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._keyChargesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.KeyCharges.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._keyChargesTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lastTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LastTrans.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lastTransTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._eventLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.EventLog.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._eventLogTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._cardNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CardNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._cardNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._cardTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CardTrans.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._cardTransTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._allLockedRecordTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AllLockedRecord.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._allLockedRecordTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unitRefTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnitRef.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unitRefTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._clientAccTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ClientAcc.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._clientAccTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._clientTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Client.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._clientTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatusTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatusTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lockedRecordTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LockedRecord.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lockedRecordTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._logInOutTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LogInOut.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._logInOutTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._reserveTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Reserve.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._reserveTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      if (updatedRows == null || updatedRows.Length < 1 || allAddedRows == null || allAddedRows.Count < 1)
        return updatedRows;
      List<DataRow> dataRowList = new List<DataRow>();
      for (int index = 0; index < updatedRows.Length; ++index)
      {
        DataRow updatedRow = updatedRows[index];
        if (!allAddedRows.Contains(updatedRow))
          dataRowList.Add(updatedRow);
      }
      return dataRowList.ToArray();
    }

    [DebuggerNonUserCode]
    public virtual int UpdateAll(BuildingDB1DataSet dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._cardNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._cardNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._cardTransTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._cardTransTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._allLockedRecordTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._allLockedRecordTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._eventLogTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._eventLogTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._extraChargeTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._extraChargeTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._keyChargesTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._keyChargesTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._lastTransTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._lastTransTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._lockedRecordTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._lockedRecordTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._logInOutTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._logInOutTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._reserveTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._reserveTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatusTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatusTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._unitRefTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._unitRefTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._clientAccTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._clientAccTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._clientTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._clientTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      IDbConnection connection = this.Connection;
      if (connection == null)
        throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
      bool flag = false;
      if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        connection.Close();
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
        flag = true;
      }
      IDbTransaction dbTransaction = connection.BeginTransaction();
      if (dbTransaction == null)
        throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
      List<DataRow> allChangedRows = new List<DataRow>();
      List<DataRow> allAddedRows = new List<DataRow>();
      List<DataAdapter> dataAdapterList = new List<DataAdapter>();
      Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
      int num = 0;
      DataSet dataSet1 = (DataSet) null;
      if (this.BackupDataSetBeforeUpdate)
      {
        dataSet1 = new DataSet();
        dataSet1.Merge((DataSet) dataSet);
      }
      try
      {
        if (this._cardNoTableAdapter != null)
        {
          dictionary.Add((object) this._cardNoTableAdapter, (IDbConnection) this._cardNoTableAdapter.Connection);
          this._cardNoTableAdapter.Connection = (OleDbConnection) connection;
          this._cardNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._cardNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._cardNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._cardNoTableAdapter.Adapter);
          }
        }
        if (this._cardTransTableAdapter != null)
        {
          dictionary.Add((object) this._cardTransTableAdapter, (IDbConnection) this._cardTransTableAdapter.Connection);
          this._cardTransTableAdapter.Connection = (OleDbConnection) connection;
          this._cardTransTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._cardTransTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._cardTransTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._cardTransTableAdapter.Adapter);
          }
        }
        if (this._allLockedRecordTableAdapter != null)
        {
          dictionary.Add((object) this._allLockedRecordTableAdapter, (IDbConnection) this._allLockedRecordTableAdapter.Connection);
          this._allLockedRecordTableAdapter.Connection = (OleDbConnection) connection;
          this._allLockedRecordTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._allLockedRecordTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._allLockedRecordTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._allLockedRecordTableAdapter.Adapter);
          }
        }
        if (this._eventLogTableAdapter != null)
        {
          dictionary.Add((object) this._eventLogTableAdapter, (IDbConnection) this._eventLogTableAdapter.Connection);
          this._eventLogTableAdapter.Connection = (OleDbConnection) connection;
          this._eventLogTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._eventLogTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._eventLogTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._eventLogTableAdapter.Adapter);
          }
        }
        if (this._extraChargeTableAdapter != null)
        {
          dictionary.Add((object) this._extraChargeTableAdapter, (IDbConnection) this._extraChargeTableAdapter.Connection);
          this._extraChargeTableAdapter.Connection = (OleDbConnection) connection;
          this._extraChargeTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._extraChargeTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._extraChargeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._extraChargeTableAdapter.Adapter);
          }
        }
        if (this._keyChargesTableAdapter != null)
        {
          dictionary.Add((object) this._keyChargesTableAdapter, (IDbConnection) this._keyChargesTableAdapter.Connection);
          this._keyChargesTableAdapter.Connection = (OleDbConnection) connection;
          this._keyChargesTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._keyChargesTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._keyChargesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._keyChargesTableAdapter.Adapter);
          }
        }
        if (this._lastTransTableAdapter != null)
        {
          dictionary.Add((object) this._lastTransTableAdapter, (IDbConnection) this._lastTransTableAdapter.Connection);
          this._lastTransTableAdapter.Connection = (OleDbConnection) connection;
          this._lastTransTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._lastTransTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._lastTransTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._lastTransTableAdapter.Adapter);
          }
        }
        if (this._lockedRecordTableAdapter != null)
        {
          dictionary.Add((object) this._lockedRecordTableAdapter, (IDbConnection) this._lockedRecordTableAdapter.Connection);
          this._lockedRecordTableAdapter.Connection = (OleDbConnection) connection;
          this._lockedRecordTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._lockedRecordTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._lockedRecordTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._lockedRecordTableAdapter.Adapter);
          }
        }
        if (this._logInOutTableAdapter != null)
        {
          dictionary.Add((object) this._logInOutTableAdapter, (IDbConnection) this._logInOutTableAdapter.Connection);
          this._logInOutTableAdapter.Connection = (OleDbConnection) connection;
          this._logInOutTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._logInOutTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._logInOutTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._logInOutTableAdapter.Adapter);
          }
        }
        if (this._reserveTableAdapter != null)
        {
          dictionary.Add((object) this._reserveTableAdapter, (IDbConnection) this._reserveTableAdapter.Connection);
          this._reserveTableAdapter.Connection = (OleDbConnection) connection;
          this._reserveTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._reserveTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._reserveTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._reserveTableAdapter.Adapter);
          }
        }
        if (this._roomStatusTableAdapter != null)
        {
          dictionary.Add((object) this._roomStatusTableAdapter, (IDbConnection) this._roomStatusTableAdapter.Connection);
          this._roomStatusTableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatusTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatusTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatusTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatusTableAdapter.Adapter);
          }
        }
        if (this._unitRefTableAdapter != null)
        {
          dictionary.Add((object) this._unitRefTableAdapter, (IDbConnection) this._unitRefTableAdapter.Connection);
          this._unitRefTableAdapter.Connection = (OleDbConnection) connection;
          this._unitRefTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._unitRefTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._unitRefTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._unitRefTableAdapter.Adapter);
          }
        }
        if (this._clientAccTableAdapter != null)
        {
          dictionary.Add((object) this._clientAccTableAdapter, (IDbConnection) this._clientAccTableAdapter.Connection);
          this._clientAccTableAdapter.Connection = (OleDbConnection) connection;
          this._clientAccTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._clientAccTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._clientAccTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._clientAccTableAdapter.Adapter);
          }
        }
        if (this._clientTableAdapter != null)
        {
          dictionary.Add((object) this._clientTableAdapter, (IDbConnection) this._clientTableAdapter.Connection);
          this._clientTableAdapter.Connection = (OleDbConnection) connection;
          this._clientTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._clientTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._clientTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._clientTableAdapter.Adapter);
          }
        }
        if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
        {
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
        }
        else
        {
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
        }
        num += this.UpdateDeletedRows(dataSet, allChangedRows);
        dbTransaction.Commit();
        if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
        if (0 < allChangedRows.Count)
        {
          DataRow[] array = new DataRow[allChangedRows.Count];
          allChangedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
      }
      catch (Exception ex)
      {
        dbTransaction.Rollback();
        if (this.BackupDataSetBeforeUpdate)
        {
          dataSet.Clear();
          dataSet.Merge(dataSet1);
        }
        else if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
          {
            DataRow dataRow = array[index];
            dataRow.AcceptChanges();
            dataRow.SetAdded();
          }
        }
        throw ex;
      }
      finally
      {
        if (flag)
          connection.Close();
        if (this._cardNoTableAdapter != null)
        {
          this._cardNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._cardNoTableAdapter];
          this._cardNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._cardTransTableAdapter != null)
        {
          this._cardTransTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._cardTransTableAdapter];
          this._cardTransTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._allLockedRecordTableAdapter != null)
        {
          this._allLockedRecordTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._allLockedRecordTableAdapter];
          this._allLockedRecordTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._eventLogTableAdapter != null)
        {
          this._eventLogTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._eventLogTableAdapter];
          this._eventLogTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._extraChargeTableAdapter != null)
        {
          this._extraChargeTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._extraChargeTableAdapter];
          this._extraChargeTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._keyChargesTableAdapter != null)
        {
          this._keyChargesTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._keyChargesTableAdapter];
          this._keyChargesTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._lastTransTableAdapter != null)
        {
          this._lastTransTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._lastTransTableAdapter];
          this._lastTransTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._lockedRecordTableAdapter != null)
        {
          this._lockedRecordTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._lockedRecordTableAdapter];
          this._lockedRecordTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._logInOutTableAdapter != null)
        {
          this._logInOutTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._logInOutTableAdapter];
          this._logInOutTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._reserveTableAdapter != null)
        {
          this._reserveTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._reserveTableAdapter];
          this._reserveTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatusTableAdapter != null)
        {
          this._roomStatusTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatusTableAdapter];
          this._roomStatusTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._unitRefTableAdapter != null)
        {
          this._unitRefTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._unitRefTableAdapter];
          this._unitRefTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._clientAccTableAdapter != null)
        {
          this._clientAccTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._clientAccTableAdapter];
          this._clientAccTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._clientTableAdapter != null)
        {
          this._clientTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._clientTableAdapter];
          this._clientTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (0 < dataAdapterList.Count)
        {
          DataAdapter[] array = new DataAdapter[dataAdapterList.Count];
          dataAdapterList.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChangesDuringUpdate = true;
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    protected virtual void SortSelfReferenceRows(
      DataRow[] rows,
      DataRelation relation,
      bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
    {
      return this._connection != null || this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [DebuggerNonUserCode]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      private bool IsChildAndParent(DataRow child, DataRow parent)
      {
        DataRow parentRow = child.GetParentRow(this._relation, DataRowVersion.Default);
        while (parentRow != null && !object.ReferenceEquals((object) parentRow, (object) child) && !object.ReferenceEquals((object) parentRow, (object) parent))
          parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default);
        if (parentRow == null)
        {
          parentRow = child.GetParentRow(this._relation, DataRowVersion.Original);
          while (parentRow != null && !object.ReferenceEquals((object) parentRow, (object) child) && !object.ReferenceEquals((object) parentRow, (object) parent))
            parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original);
        }
        return object.ReferenceEquals((object) parentRow, (object) parent);
      }

      [DebuggerNonUserCode]
      public int Compare(DataRow row1, DataRow row2)
      {
        if (object.ReferenceEquals((object) row1, (object) row2))
          return 0;
        if (row1 == null)
          return -1;
        if (row2 == null)
          return 1;
        if (this.IsChildAndParent(row1, row2))
          return this._childFirst;
        return this.IsChildAndParent(row2, row1) ? -1 * this._childFirst : 0;
      }
    }
  }
}
