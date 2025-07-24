// Decompiled with JetBrains decompiler
// Type: AMS.SystemDataSetTableAdapters.TableAdapterManager
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
namespace AMS.SystemDataSetTableAdapters
{
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.TableAdapterManager")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private BonusTableAdapter _bonusTableAdapter;
    private Bonus1TableAdapter _bonus1TableAdapter;
    private Bonus2TableAdapter _bonus2TableAdapter;
    private Bonus3TableAdapter _bonus3TableAdapter;
    private Bonus4TableAdapter _bonus4TableAdapter;
    private Bonus5TableAdapter _bonus5TableAdapter;
    private Bonus6TableAdapter _bonus6TableAdapter;
    private BuildingTableAdapter _buildingTableAdapter;
    private CountryTableAdapter _countryTableAdapter;
    private FloorTableAdapter _floorTableAdapter;
    private GSTHistoryTableAdapter _gSTHistoryTableAdapter;
    private GSTHistory1TableAdapter _gSTHistory1TableAdapter;
    private GSTHistory2TableAdapter _gSTHistory2TableAdapter;
    private GSTHistory3TableAdapter _gSTHistory3TableAdapter;
    private GSTHistory4TableAdapter _gSTHistory4TableAdapter;
    private GSTHistory5TableAdapter _gSTHistory5TableAdapter;
    private GSTHistory6TableAdapter _gSTHistory6TableAdapter;
    private RoomTableAdapter _roomTableAdapter;
    private RoomStatus1TableAdapter _roomStatus1TableAdapter;
    private RoomStatus2TableAdapter _roomStatus2TableAdapter;
    private RoomStatus3TableAdapter _roomStatus3TableAdapter;
    private RoomStatus4TableAdapter _roomStatus4TableAdapter;
    private RoomStatus5TableAdapter _roomStatus5TableAdapter;
    private RoomStatus6TableAdapter _roomStatus6TableAdapter;
    private RoomTypeTableAdapter _roomTypeTableAdapter;
    private SystemSet1TableAdapter _systemSet1TableAdapter;
    private ZoneTableAdapter _zoneTableAdapter;
    private SystemSet2TableAdapter _systemSet2TableAdapter;
    private SystemSet3TableAdapter _systemSet3TableAdapter;
    private SystemSet4TableAdapter _systemSet4TableAdapter;
    private SystemSet5TableAdapter _systemSet5TableAdapter;
    private SystemSet6TableAdapter _systemSet6TableAdapter;
    private SystemSetTableAdapter _systemSetTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public BonusTableAdapter BonusTableAdapter
    {
      get => this._bonusTableAdapter;
      set => this._bonusTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public Bonus1TableAdapter Bonus1TableAdapter
    {
      get => this._bonus1TableAdapter;
      set => this._bonus1TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public Bonus2TableAdapter Bonus2TableAdapter
    {
      get => this._bonus2TableAdapter;
      set => this._bonus2TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public Bonus3TableAdapter Bonus3TableAdapter
    {
      get => this._bonus3TableAdapter;
      set => this._bonus3TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public Bonus4TableAdapter Bonus4TableAdapter
    {
      get => this._bonus4TableAdapter;
      set => this._bonus4TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public Bonus5TableAdapter Bonus5TableAdapter
    {
      get => this._bonus5TableAdapter;
      set => this._bonus5TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public Bonus6TableAdapter Bonus6TableAdapter
    {
      get => this._bonus6TableAdapter;
      set => this._bonus6TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public BuildingTableAdapter BuildingTableAdapter
    {
      get => this._buildingTableAdapter;
      set => this._buildingTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public CountryTableAdapter CountryTableAdapter
    {
      get => this._countryTableAdapter;
      set => this._countryTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public FloorTableAdapter FloorTableAdapter
    {
      get => this._floorTableAdapter;
      set => this._floorTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistoryTableAdapter GSTHistoryTableAdapter
    {
      get => this._gSTHistoryTableAdapter;
      set => this._gSTHistoryTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistory1TableAdapter GSTHistory1TableAdapter
    {
      get => this._gSTHistory1TableAdapter;
      set => this._gSTHistory1TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistory2TableAdapter GSTHistory2TableAdapter
    {
      get => this._gSTHistory2TableAdapter;
      set => this._gSTHistory2TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistory3TableAdapter GSTHistory3TableAdapter
    {
      get => this._gSTHistory3TableAdapter;
      set => this._gSTHistory3TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistory4TableAdapter GSTHistory4TableAdapter
    {
      get => this._gSTHistory4TableAdapter;
      set => this._gSTHistory4TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GSTHistory5TableAdapter GSTHistory5TableAdapter
    {
      get => this._gSTHistory5TableAdapter;
      set => this._gSTHistory5TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GSTHistory6TableAdapter GSTHistory6TableAdapter
    {
      get => this._gSTHistory6TableAdapter;
      set => this._gSTHistory6TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomTableAdapter RoomTableAdapter
    {
      get => this._roomTableAdapter;
      set => this._roomTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomStatus1TableAdapter RoomStatus1TableAdapter
    {
      get => this._roomStatus1TableAdapter;
      set => this._roomStatus1TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomStatus2TableAdapter RoomStatus2TableAdapter
    {
      get => this._roomStatus2TableAdapter;
      set => this._roomStatus2TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomStatus3TableAdapter RoomStatus3TableAdapter
    {
      get => this._roomStatus3TableAdapter;
      set => this._roomStatus3TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomStatus4TableAdapter RoomStatus4TableAdapter
    {
      get => this._roomStatus4TableAdapter;
      set => this._roomStatus4TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomStatus5TableAdapter RoomStatus5TableAdapter
    {
      get => this._roomStatus5TableAdapter;
      set => this._roomStatus5TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomStatus6TableAdapter RoomStatus6TableAdapter
    {
      get => this._roomStatus6TableAdapter;
      set => this._roomStatus6TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomTypeTableAdapter RoomTypeTableAdapter
    {
      get => this._roomTypeTableAdapter;
      set => this._roomTypeTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public SystemSet1TableAdapter SystemSet1TableAdapter
    {
      get => this._systemSet1TableAdapter;
      set => this._systemSet1TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ZoneTableAdapter ZoneTableAdapter
    {
      get => this._zoneTableAdapter;
      set => this._zoneTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSet2TableAdapter SystemSet2TableAdapter
    {
      get => this._systemSet2TableAdapter;
      set => this._systemSet2TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSet3TableAdapter SystemSet3TableAdapter
    {
      get => this._systemSet3TableAdapter;
      set => this._systemSet3TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSet4TableAdapter SystemSet4TableAdapter
    {
      get => this._systemSet4TableAdapter;
      set => this._systemSet4TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSet5TableAdapter SystemSet5TableAdapter
    {
      get => this._systemSet5TableAdapter;
      set => this._systemSet5TableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public SystemSet6TableAdapter SystemSet6TableAdapter
    {
      get => this._systemSet6TableAdapter;
      set => this._systemSet6TableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSetTableAdapter SystemSetTableAdapter
    {
      get => this._systemSetTableAdapter;
      set => this._systemSetTableAdapter = value;
    }

    [DebuggerNonUserCode]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [DebuggerNonUserCode]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        if (this._bonusTableAdapter != null && this._bonusTableAdapter.Connection != null)
          return (IDbConnection) this._bonusTableAdapter.Connection;
        if (this._bonus1TableAdapter != null && this._bonus1TableAdapter.Connection != null)
          return (IDbConnection) this._bonus1TableAdapter.Connection;
        if (this._bonus2TableAdapter != null && this._bonus2TableAdapter.Connection != null)
          return (IDbConnection) this._bonus2TableAdapter.Connection;
        if (this._bonus3TableAdapter != null && this._bonus3TableAdapter.Connection != null)
          return (IDbConnection) this._bonus3TableAdapter.Connection;
        if (this._bonus4TableAdapter != null && this._bonus4TableAdapter.Connection != null)
          return (IDbConnection) this._bonus4TableAdapter.Connection;
        if (this._bonus5TableAdapter != null && this._bonus5TableAdapter.Connection != null)
          return (IDbConnection) this._bonus5TableAdapter.Connection;
        if (this._bonus6TableAdapter != null && this._bonus6TableAdapter.Connection != null)
          return (IDbConnection) this._bonus6TableAdapter.Connection;
        if (this._buildingTableAdapter != null && this._buildingTableAdapter.Connection != null)
          return (IDbConnection) this._buildingTableAdapter.Connection;
        if (this._countryTableAdapter != null && this._countryTableAdapter.Connection != null)
          return (IDbConnection) this._countryTableAdapter.Connection;
        if (this._floorTableAdapter != null && this._floorTableAdapter.Connection != null)
          return (IDbConnection) this._floorTableAdapter.Connection;
        if (this._gSTHistoryTableAdapter != null && this._gSTHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistoryTableAdapter.Connection;
        if (this._gSTHistory1TableAdapter != null && this._gSTHistory1TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory1TableAdapter.Connection;
        if (this._gSTHistory2TableAdapter != null && this._gSTHistory2TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory2TableAdapter.Connection;
        if (this._gSTHistory3TableAdapter != null && this._gSTHistory3TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory3TableAdapter.Connection;
        if (this._gSTHistory4TableAdapter != null && this._gSTHistory4TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory4TableAdapter.Connection;
        if (this._gSTHistory5TableAdapter != null && this._gSTHistory5TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory5TableAdapter.Connection;
        if (this._gSTHistory6TableAdapter != null && this._gSTHistory6TableAdapter.Connection != null)
          return (IDbConnection) this._gSTHistory6TableAdapter.Connection;
        if (this._roomTableAdapter != null && this._roomTableAdapter.Connection != null)
          return (IDbConnection) this._roomTableAdapter.Connection;
        if (this._roomStatus1TableAdapter != null && this._roomStatus1TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus1TableAdapter.Connection;
        if (this._roomStatus2TableAdapter != null && this._roomStatus2TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus2TableAdapter.Connection;
        if (this._roomStatus3TableAdapter != null && this._roomStatus3TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus3TableAdapter.Connection;
        if (this._roomStatus4TableAdapter != null && this._roomStatus4TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus4TableAdapter.Connection;
        if (this._roomStatus5TableAdapter != null && this._roomStatus5TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus5TableAdapter.Connection;
        if (this._roomStatus6TableAdapter != null && this._roomStatus6TableAdapter.Connection != null)
          return (IDbConnection) this._roomStatus6TableAdapter.Connection;
        if (this._roomTypeTableAdapter != null && this._roomTypeTableAdapter.Connection != null)
          return (IDbConnection) this._roomTypeTableAdapter.Connection;
        if (this._systemSet1TableAdapter != null && this._systemSet1TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet1TableAdapter.Connection;
        if (this._zoneTableAdapter != null && this._zoneTableAdapter.Connection != null)
          return (IDbConnection) this._zoneTableAdapter.Connection;
        if (this._systemSet2TableAdapter != null && this._systemSet2TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet2TableAdapter.Connection;
        if (this._systemSet3TableAdapter != null && this._systemSet3TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet3TableAdapter.Connection;
        if (this._systemSet4TableAdapter != null && this._systemSet4TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet4TableAdapter.Connection;
        if (this._systemSet5TableAdapter != null && this._systemSet5TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet5TableAdapter.Connection;
        if (this._systemSet6TableAdapter != null && this._systemSet6TableAdapter.Connection != null)
          return (IDbConnection) this._systemSet6TableAdapter.Connection;
        return this._systemSetTableAdapter != null && this._systemSetTableAdapter.Connection != null ? (IDbConnection) this._systemSetTableAdapter.Connection : (IDbConnection) null;
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
        if (this._bonusTableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus1TableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus3TableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus4TableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus5TableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonus6TableAdapter != null)
          ++adapterInstanceCount;
        if (this._buildingTableAdapter != null)
          ++adapterInstanceCount;
        if (this._countryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._floorTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory1TableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory3TableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory4TableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory5TableAdapter != null)
          ++adapterInstanceCount;
        if (this._gSTHistory6TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus1TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus3TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus4TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus5TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomStatus6TableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomTypeTableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet1TableAdapter != null)
          ++adapterInstanceCount;
        if (this._zoneTableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet2TableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet3TableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet4TableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet5TableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSet6TableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSetTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    private int UpdateUpdatedRows(
      SystemDataSet dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._roomStatus5TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus5.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus5TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatus4TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus4.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus4TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomTypeTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomType.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomTypeTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatus6TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus6.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus6TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatus1TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus1.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus1TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Room.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatus3TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus3.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus3TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomStatus2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomStatus2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomStatus2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet5TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet5.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet5TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet4TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet4.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet4TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSetTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSetTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet6TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet6.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet6TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._zoneTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Zone.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._zoneTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet1TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet1.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet1TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet3TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet3.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet3TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSet2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSet2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSet2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory6TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory6.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory6TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus5TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus5.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus5TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus4TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus4.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus4TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._buildingTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Building.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._buildingTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus6TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus6.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus6TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus1TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus1.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus1TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonusTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonusTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus3TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus3.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus3TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonus2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Bonus2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonus2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory3TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory3.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory3TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory2TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory2.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory2TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory5TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory5.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory5TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory4TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory4.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory4TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._floorTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Floor.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._floorTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._countryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Country.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._countryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistory1TableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory1.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistory1TableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gSTHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GSTHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gSTHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateInsertedRows(SystemDataSet dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._roomStatus5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus5.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus5TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus4.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus4TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTypeTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomType.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTypeTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus6.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus6TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus1.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus1TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Room.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus3.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus3TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet5.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet5TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet4.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet4TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSetTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSetTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet6.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet6TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._zoneTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Zone.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._zoneTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet1.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet1TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet3.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet3TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory6.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory6TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus5.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus5TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus4.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus4TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._buildingTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Building.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._buildingTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus6.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus6TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus1.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus1TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus3.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus3TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory3.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory3TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory2.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory2TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory5.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory5TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory4.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory4TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._floorTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Floor.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._floorTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._countryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Country.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._countryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory1.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory1TableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateDeletedRows(SystemDataSet dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._gSTHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory1.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory1TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._countryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Country.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._countryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._floorTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Floor.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._floorTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory4.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory4TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory5.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory5TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory3.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory3TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus3.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus3TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus1.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus1TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus6.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus6TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._buildingTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Building.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._buildingTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus4.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus4TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonus5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Bonus5.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonus5TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gSTHistory6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GSTHistory6.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gSTHistory6TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet3.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet3TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet1.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet1TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._zoneTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Zone.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._zoneTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet6.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet6TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSetTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSetTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet4.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet4TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSet5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSet5.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSet5TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus2TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus2.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus2TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus3TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus3.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus3TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Room.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus1TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus1.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus1TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus6TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus6.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus6TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTypeTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomType.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTypeTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus4TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus4.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus4TableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomStatus5TableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomStatus5.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomStatus5TableAdapter.Update(dataRowArray);
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
    public virtual int UpdateAll(SystemDataSet dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._bonusTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonusTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus1TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus1TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus2TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus3TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus3TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus4TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus4TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus5TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus5TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonus6TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonus6TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._buildingTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._buildingTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._countryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._countryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._floorTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._floorTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory1TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory1TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory2TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory3TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory3TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory4TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory4TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory5TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory5TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gSTHistory6TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gSTHistory6TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus1TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus1TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus2TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus3TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus3TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus4TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus4TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus5TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus5TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomStatus6TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomStatus6TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomTypeTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomTypeTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet1TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet1TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._zoneTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._zoneTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet2TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet2TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet3TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet3TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet4TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet4TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet5TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet5TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSet6TableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSet6TableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSetTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSetTableAdapter.Connection))
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
        if (this._bonusTableAdapter != null)
        {
          dictionary.Add((object) this._bonusTableAdapter, (IDbConnection) this._bonusTableAdapter.Connection);
          this._bonusTableAdapter.Connection = (OleDbConnection) connection;
          this._bonusTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonusTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonusTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonusTableAdapter.Adapter);
          }
        }
        if (this._bonus1TableAdapter != null)
        {
          dictionary.Add((object) this._bonus1TableAdapter, (IDbConnection) this._bonus1TableAdapter.Connection);
          this._bonus1TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus1TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus1TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus1TableAdapter.Adapter);
          }
        }
        if (this._bonus2TableAdapter != null)
        {
          dictionary.Add((object) this._bonus2TableAdapter, (IDbConnection) this._bonus2TableAdapter.Connection);
          this._bonus2TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus2TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus2TableAdapter.Adapter);
          }
        }
        if (this._bonus3TableAdapter != null)
        {
          dictionary.Add((object) this._bonus3TableAdapter, (IDbConnection) this._bonus3TableAdapter.Connection);
          this._bonus3TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus3TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus3TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus3TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus3TableAdapter.Adapter);
          }
        }
        if (this._bonus4TableAdapter != null)
        {
          dictionary.Add((object) this._bonus4TableAdapter, (IDbConnection) this._bonus4TableAdapter.Connection);
          this._bonus4TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus4TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus4TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus4TableAdapter.Adapter);
          }
        }
        if (this._bonus5TableAdapter != null)
        {
          dictionary.Add((object) this._bonus5TableAdapter, (IDbConnection) this._bonus5TableAdapter.Connection);
          this._bonus5TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus5TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus5TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus5TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus5TableAdapter.Adapter);
          }
        }
        if (this._bonus6TableAdapter != null)
        {
          dictionary.Add((object) this._bonus6TableAdapter, (IDbConnection) this._bonus6TableAdapter.Connection);
          this._bonus6TableAdapter.Connection = (OleDbConnection) connection;
          this._bonus6TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonus6TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonus6TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonus6TableAdapter.Adapter);
          }
        }
        if (this._buildingTableAdapter != null)
        {
          dictionary.Add((object) this._buildingTableAdapter, (IDbConnection) this._buildingTableAdapter.Connection);
          this._buildingTableAdapter.Connection = (OleDbConnection) connection;
          this._buildingTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._buildingTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._buildingTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._buildingTableAdapter.Adapter);
          }
        }
        if (this._countryTableAdapter != null)
        {
          dictionary.Add((object) this._countryTableAdapter, (IDbConnection) this._countryTableAdapter.Connection);
          this._countryTableAdapter.Connection = (OleDbConnection) connection;
          this._countryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._countryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._countryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._countryTableAdapter.Adapter);
          }
        }
        if (this._floorTableAdapter != null)
        {
          dictionary.Add((object) this._floorTableAdapter, (IDbConnection) this._floorTableAdapter.Connection);
          this._floorTableAdapter.Connection = (OleDbConnection) connection;
          this._floorTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._floorTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._floorTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._floorTableAdapter.Adapter);
          }
        }
        if (this._gSTHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistoryTableAdapter, (IDbConnection) this._gSTHistoryTableAdapter.Connection);
          this._gSTHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistoryTableAdapter.Adapter);
          }
        }
        if (this._gSTHistory1TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory1TableAdapter, (IDbConnection) this._gSTHistory1TableAdapter.Connection);
          this._gSTHistory1TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory1TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory1TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory1TableAdapter.Adapter);
          }
        }
        if (this._gSTHistory2TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory2TableAdapter, (IDbConnection) this._gSTHistory2TableAdapter.Connection);
          this._gSTHistory2TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory2TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory2TableAdapter.Adapter);
          }
        }
        if (this._gSTHistory3TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory3TableAdapter, (IDbConnection) this._gSTHistory3TableAdapter.Connection);
          this._gSTHistory3TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory3TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory3TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory3TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory3TableAdapter.Adapter);
          }
        }
        if (this._gSTHistory4TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory4TableAdapter, (IDbConnection) this._gSTHistory4TableAdapter.Connection);
          this._gSTHistory4TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory4TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory4TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory4TableAdapter.Adapter);
          }
        }
        if (this._gSTHistory5TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory5TableAdapter, (IDbConnection) this._gSTHistory5TableAdapter.Connection);
          this._gSTHistory5TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory5TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory5TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory5TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory5TableAdapter.Adapter);
          }
        }
        if (this._gSTHistory6TableAdapter != null)
        {
          dictionary.Add((object) this._gSTHistory6TableAdapter, (IDbConnection) this._gSTHistory6TableAdapter.Connection);
          this._gSTHistory6TableAdapter.Connection = (OleDbConnection) connection;
          this._gSTHistory6TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gSTHistory6TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gSTHistory6TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gSTHistory6TableAdapter.Adapter);
          }
        }
        if (this._roomTableAdapter != null)
        {
          dictionary.Add((object) this._roomTableAdapter, (IDbConnection) this._roomTableAdapter.Connection);
          this._roomTableAdapter.Connection = (OleDbConnection) connection;
          this._roomTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomTableAdapter.Adapter);
          }
        }
        if (this._roomStatus1TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus1TableAdapter, (IDbConnection) this._roomStatus1TableAdapter.Connection);
          this._roomStatus1TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus1TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus1TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus1TableAdapter.Adapter);
          }
        }
        if (this._roomStatus2TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus2TableAdapter, (IDbConnection) this._roomStatus2TableAdapter.Connection);
          this._roomStatus2TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus2TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus2TableAdapter.Adapter);
          }
        }
        if (this._roomStatus3TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus3TableAdapter, (IDbConnection) this._roomStatus3TableAdapter.Connection);
          this._roomStatus3TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus3TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus3TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus3TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus3TableAdapter.Adapter);
          }
        }
        if (this._roomStatus4TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus4TableAdapter, (IDbConnection) this._roomStatus4TableAdapter.Connection);
          this._roomStatus4TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus4TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus4TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus4TableAdapter.Adapter);
          }
        }
        if (this._roomStatus5TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus5TableAdapter, (IDbConnection) this._roomStatus5TableAdapter.Connection);
          this._roomStatus5TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus5TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus5TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus5TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus5TableAdapter.Adapter);
          }
        }
        if (this._roomStatus6TableAdapter != null)
        {
          dictionary.Add((object) this._roomStatus6TableAdapter, (IDbConnection) this._roomStatus6TableAdapter.Connection);
          this._roomStatus6TableAdapter.Connection = (OleDbConnection) connection;
          this._roomStatus6TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomStatus6TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomStatus6TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomStatus6TableAdapter.Adapter);
          }
        }
        if (this._roomTypeTableAdapter != null)
        {
          dictionary.Add((object) this._roomTypeTableAdapter, (IDbConnection) this._roomTypeTableAdapter.Connection);
          this._roomTypeTableAdapter.Connection = (OleDbConnection) connection;
          this._roomTypeTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomTypeTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomTypeTableAdapter.Adapter);
          }
        }
        if (this._systemSet1TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet1TableAdapter, (IDbConnection) this._systemSet1TableAdapter.Connection);
          this._systemSet1TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet1TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet1TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet1TableAdapter.Adapter);
          }
        }
        if (this._zoneTableAdapter != null)
        {
          dictionary.Add((object) this._zoneTableAdapter, (IDbConnection) this._zoneTableAdapter.Connection);
          this._zoneTableAdapter.Connection = (OleDbConnection) connection;
          this._zoneTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._zoneTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._zoneTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._zoneTableAdapter.Adapter);
          }
        }
        if (this._systemSet2TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet2TableAdapter, (IDbConnection) this._systemSet2TableAdapter.Connection);
          this._systemSet2TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet2TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet2TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet2TableAdapter.Adapter);
          }
        }
        if (this._systemSet3TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet3TableAdapter, (IDbConnection) this._systemSet3TableAdapter.Connection);
          this._systemSet3TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet3TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet3TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet3TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet3TableAdapter.Adapter);
          }
        }
        if (this._systemSet4TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet4TableAdapter, (IDbConnection) this._systemSet4TableAdapter.Connection);
          this._systemSet4TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet4TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet4TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet4TableAdapter.Adapter);
          }
        }
        if (this._systemSet5TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet5TableAdapter, (IDbConnection) this._systemSet5TableAdapter.Connection);
          this._systemSet5TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet5TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet5TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet5TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet5TableAdapter.Adapter);
          }
        }
        if (this._systemSet6TableAdapter != null)
        {
          dictionary.Add((object) this._systemSet6TableAdapter, (IDbConnection) this._systemSet6TableAdapter.Connection);
          this._systemSet6TableAdapter.Connection = (OleDbConnection) connection;
          this._systemSet6TableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSet6TableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSet6TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSet6TableAdapter.Adapter);
          }
        }
        if (this._systemSetTableAdapter != null)
        {
          dictionary.Add((object) this._systemSetTableAdapter, (IDbConnection) this._systemSetTableAdapter.Connection);
          this._systemSetTableAdapter.Connection = (OleDbConnection) connection;
          this._systemSetTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSetTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSetTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSetTableAdapter.Adapter);
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
        if (this._bonusTableAdapter != null)
        {
          this._bonusTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonusTableAdapter];
          this._bonusTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus1TableAdapter != null)
        {
          this._bonus1TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus1TableAdapter];
          this._bonus1TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus2TableAdapter != null)
        {
          this._bonus2TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus2TableAdapter];
          this._bonus2TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus3TableAdapter != null)
        {
          this._bonus3TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus3TableAdapter];
          this._bonus3TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus4TableAdapter != null)
        {
          this._bonus4TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus4TableAdapter];
          this._bonus4TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus5TableAdapter != null)
        {
          this._bonus5TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus5TableAdapter];
          this._bonus5TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonus6TableAdapter != null)
        {
          this._bonus6TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonus6TableAdapter];
          this._bonus6TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._buildingTableAdapter != null)
        {
          this._buildingTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._buildingTableAdapter];
          this._buildingTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._countryTableAdapter != null)
        {
          this._countryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._countryTableAdapter];
          this._countryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._floorTableAdapter != null)
        {
          this._floorTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._floorTableAdapter];
          this._floorTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistoryTableAdapter != null)
        {
          this._gSTHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistoryTableAdapter];
          this._gSTHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory1TableAdapter != null)
        {
          this._gSTHistory1TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory1TableAdapter];
          this._gSTHistory1TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory2TableAdapter != null)
        {
          this._gSTHistory2TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory2TableAdapter];
          this._gSTHistory2TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory3TableAdapter != null)
        {
          this._gSTHistory3TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory3TableAdapter];
          this._gSTHistory3TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory4TableAdapter != null)
        {
          this._gSTHistory4TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory4TableAdapter];
          this._gSTHistory4TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory5TableAdapter != null)
        {
          this._gSTHistory5TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory5TableAdapter];
          this._gSTHistory5TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gSTHistory6TableAdapter != null)
        {
          this._gSTHistory6TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gSTHistory6TableAdapter];
          this._gSTHistory6TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomTableAdapter != null)
        {
          this._roomTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomTableAdapter];
          this._roomTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus1TableAdapter != null)
        {
          this._roomStatus1TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus1TableAdapter];
          this._roomStatus1TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus2TableAdapter != null)
        {
          this._roomStatus2TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus2TableAdapter];
          this._roomStatus2TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus3TableAdapter != null)
        {
          this._roomStatus3TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus3TableAdapter];
          this._roomStatus3TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus4TableAdapter != null)
        {
          this._roomStatus4TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus4TableAdapter];
          this._roomStatus4TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus5TableAdapter != null)
        {
          this._roomStatus5TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus5TableAdapter];
          this._roomStatus5TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomStatus6TableAdapter != null)
        {
          this._roomStatus6TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomStatus6TableAdapter];
          this._roomStatus6TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomTypeTableAdapter != null)
        {
          this._roomTypeTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomTypeTableAdapter];
          this._roomTypeTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet1TableAdapter != null)
        {
          this._systemSet1TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet1TableAdapter];
          this._systemSet1TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._zoneTableAdapter != null)
        {
          this._zoneTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._zoneTableAdapter];
          this._zoneTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet2TableAdapter != null)
        {
          this._systemSet2TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet2TableAdapter];
          this._systemSet2TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet3TableAdapter != null)
        {
          this._systemSet3TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet3TableAdapter];
          this._systemSet3TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet4TableAdapter != null)
        {
          this._systemSet4TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet4TableAdapter];
          this._systemSet4TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet5TableAdapter != null)
        {
          this._systemSet5TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet5TableAdapter];
          this._systemSet5TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSet6TableAdapter != null)
        {
          this._systemSet6TableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSet6TableAdapter];
          this._systemSet6TableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSetTableAdapter != null)
        {
          this._systemSetTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSetTableAdapter];
          this._systemSetTableAdapter.Transaction = (OleDbTransaction) null;
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
