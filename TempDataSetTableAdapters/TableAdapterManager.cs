// Decompiled with JetBrains decompiler
// Type: AMS.TempDataSetTableAdapters.TableAdapterManager
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
namespace AMS.TempDataSetTableAdapters
{
  [ToolboxItem(true)]
  [HelpKeyword("vs.data.TableAdapterManager")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private AccBonusEntitleListTableAdapter _accBonusEntitleListTableAdapter;
    private AccCurrentGByFloorNoTableAdapter _accCurrentGByFloorNoTableAdapter;
    private AccCurrentGInfoTableAdapter _accCurrentGInfoTableAdapter;
    private AccErrorRecordsTableAdapter _accErrorRecordsTableAdapter;
    private AccExtraTableAdapter _accExtraTableAdapter;
    private AccGInfo_TempTableAdapter _accGInfo_TempTableAdapter;
    private AccGracePeriodListTableAdapter _accGracePeriodListTableAdapter;
    private AccGuestAccountTableAdapter _accGuestAccountTableAdapter;
    private AccGuestHistoryTableAdapter _accGuestHistoryTableAdapter;
    private AccGuestListTableAdapter _accGuestListTableAdapter;
    private AccGuestRecordDateTableAdapter _accGuestRecordDateTableAdapter;
    private AccReservationListTableAdapter _accReservationListTableAdapter;
    private AccRoomDetailTableAdapter _accRoomDetailTableAdapter;
    private AccRoomInformationTableAdapter _accRoomInformationTableAdapter;
    private AccSalesTableAdapter _accSalesTableAdapter;
    private AccTransTableAdapter _accTransTableAdapter;
    private AvailableRoom_TempTableAdapter _availableRoom_TempTableAdapter;
    private Banking_TempTableAdapter _banking_TempTableAdapter;
    private BonusEntitleListTableAdapter _bonusEntitleListTableAdapter;
    private BonusTempTableAdapter _bonusTempTableAdapter;
    private CheckRoom_TempTableAdapter _checkRoom_TempTableAdapter;
    private CurrentGByFloorNoTableAdapter _currentGByFloorNoTableAdapter;
    private CurrentGInfoTableAdapter _currentGInfoTableAdapter;
    private DetailGuestIssuedTableAdapter _detailGuestIssuedTableAdapter;
    private DisplayRooms_TempTableAdapter _displayRooms_TempTableAdapter;
    private DLogTableAdapter _dLogTableAdapter;
    private DTransactionsTableAdapter _dTransactionsTableAdapter;
    private ErrorRecordsTableAdapter _errorRecordsTableAdapter;
    private ExtraTableAdapter _extraTableAdapter;
    private ExtraCardTableAdapter _extraCardTableAdapter;
    private ExtraCharge_TempTableAdapter _extraCharge_TempTableAdapter;
    private GData_TempTableAdapter _gData_TempTableAdapter;
    private GDSalesTableAdapter _gDSalesTableAdapter;
    private GInfo_TempTableAdapter _gInfo_TempTableAdapter;
    private GracePeriodListTableAdapter _gracePeriodListTableAdapter;
    private GTransactions_TempTableAdapter _gTransactions_TempTableAdapter;
    private GuestAccountTableAdapter _guestAccountTableAdapter;
    private GuestHistoryTableAdapter _guestHistoryTableAdapter;
    private GuestIssuedByBldNoTableAdapter _guestIssuedByBldNoTableAdapter;
    private GuestIssuedByFloorNoTableAdapter _guestIssuedByFloorNoTableAdapter;
    private GuestIssuedByGuestIDTableAdapter _guestIssuedByGuestIDTableAdapter;
    private GuestIssuedByRoomNoTableAdapter _guestIssuedByRoomNoTableAdapter;
    private GuestListTableAdapter _guestListTableAdapter;
    private GuestRecordDateTableAdapter _guestRecordDateTableAdapter;
    private GViewRoom_TempTableAdapter _gViewRoom_TempTableAdapter;
    private IssueCardHistoryTableAdapter _issueCardHistoryTableAdapter;
    private KeyChargesTempTableAdapter _keyChargesTempTableAdapter;
    private LossCardTableAdapter _lossCardTableAdapter;
    private MLogTableAdapter _mLogTableAdapter;
    private ReceiptTableAdapter _receiptTableAdapter;
    private ReservationListTableAdapter _reservationListTableAdapter;
    private RoomDetailTableAdapter _roomDetailTableAdapter;
    private RoomHistoryTableAdapter _roomHistoryTableAdapter;
    private RoomInformationTableAdapter _roomInformationTableAdapter;
    private RoomTypeTempTableAdapter _roomTypeTempTableAdapter;
    private StaffTempTableAdapter _staffTempTableAdapter;
    private SystemSetTempTableAdapter _systemSetTempTableAdapter;
    private UnLockDoorByRoomNoTableAdapter _unLockDoorByRoomNoTableAdapter;
    private UnlockDoorHistoryTableAdapter _unlockDoorHistoryTableAdapter;
    private UploadDataTableAdapter _uploadDataTableAdapter;
    private VacantStatus_TempTableAdapter _vacantStatus_TempTableAdapter;
    private ZoneTempTableAdapter _zoneTempTableAdapter;
    private AccIssuedCardHistoryTableAdapter _accIssuedCardHistoryTableAdapter;
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
    public AccBonusEntitleListTableAdapter AccBonusEntitleListTableAdapter
    {
      get => this._accBonusEntitleListTableAdapter;
      set => this._accBonusEntitleListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccCurrentGByFloorNoTableAdapter AccCurrentGByFloorNoTableAdapter
    {
      get => this._accCurrentGByFloorNoTableAdapter;
      set => this._accCurrentGByFloorNoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccCurrentGInfoTableAdapter AccCurrentGInfoTableAdapter
    {
      get => this._accCurrentGInfoTableAdapter;
      set => this._accCurrentGInfoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccErrorRecordsTableAdapter AccErrorRecordsTableAdapter
    {
      get => this._accErrorRecordsTableAdapter;
      set => this._accErrorRecordsTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccExtraTableAdapter AccExtraTableAdapter
    {
      get => this._accExtraTableAdapter;
      set => this._accExtraTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccGInfo_TempTableAdapter AccGInfo_TempTableAdapter
    {
      get => this._accGInfo_TempTableAdapter;
      set => this._accGInfo_TempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccGracePeriodListTableAdapter AccGracePeriodListTableAdapter
    {
      get => this._accGracePeriodListTableAdapter;
      set => this._accGracePeriodListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccGuestAccountTableAdapter AccGuestAccountTableAdapter
    {
      get => this._accGuestAccountTableAdapter;
      set => this._accGuestAccountTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccGuestHistoryTableAdapter AccGuestHistoryTableAdapter
    {
      get => this._accGuestHistoryTableAdapter;
      set => this._accGuestHistoryTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccGuestListTableAdapter AccGuestListTableAdapter
    {
      get => this._accGuestListTableAdapter;
      set => this._accGuestListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccGuestRecordDateTableAdapter AccGuestRecordDateTableAdapter
    {
      get => this._accGuestRecordDateTableAdapter;
      set => this._accGuestRecordDateTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccReservationListTableAdapter AccReservationListTableAdapter
    {
      get => this._accReservationListTableAdapter;
      set => this._accReservationListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccRoomDetailTableAdapter AccRoomDetailTableAdapter
    {
      get => this._accRoomDetailTableAdapter;
      set => this._accRoomDetailTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AccRoomInformationTableAdapter AccRoomInformationTableAdapter
    {
      get => this._accRoomInformationTableAdapter;
      set => this._accRoomInformationTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccSalesTableAdapter AccSalesTableAdapter
    {
      get => this._accSalesTableAdapter;
      set => this._accSalesTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccTransTableAdapter AccTransTableAdapter
    {
      get => this._accTransTableAdapter;
      set => this._accTransTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public AvailableRoom_TempTableAdapter AvailableRoom_TempTableAdapter
    {
      get => this._availableRoom_TempTableAdapter;
      set => this._availableRoom_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public Banking_TempTableAdapter Banking_TempTableAdapter
    {
      get => this._banking_TempTableAdapter;
      set => this._banking_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public BonusEntitleListTableAdapter BonusEntitleListTableAdapter
    {
      get => this._bonusEntitleListTableAdapter;
      set => this._bonusEntitleListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public BonusTempTableAdapter BonusTempTableAdapter
    {
      get => this._bonusTempTableAdapter;
      set => this._bonusTempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public CheckRoom_TempTableAdapter CheckRoom_TempTableAdapter
    {
      get => this._checkRoom_TempTableAdapter;
      set => this._checkRoom_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public CurrentGByFloorNoTableAdapter CurrentGByFloorNoTableAdapter
    {
      get => this._currentGByFloorNoTableAdapter;
      set => this._currentGByFloorNoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public CurrentGInfoTableAdapter CurrentGInfoTableAdapter
    {
      get => this._currentGInfoTableAdapter;
      set => this._currentGInfoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public DetailGuestIssuedTableAdapter DetailGuestIssuedTableAdapter
    {
      get => this._detailGuestIssuedTableAdapter;
      set => this._detailGuestIssuedTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public DisplayRooms_TempTableAdapter DisplayRooms_TempTableAdapter
    {
      get => this._displayRooms_TempTableAdapter;
      set => this._displayRooms_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public DLogTableAdapter DLogTableAdapter
    {
      get => this._dLogTableAdapter;
      set => this._dLogTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public DTransactionsTableAdapter DTransactionsTableAdapter
    {
      get => this._dTransactionsTableAdapter;
      set => this._dTransactionsTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ErrorRecordsTableAdapter ErrorRecordsTableAdapter
    {
      get => this._errorRecordsTableAdapter;
      set => this._errorRecordsTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ExtraTableAdapter ExtraTableAdapter
    {
      get => this._extraTableAdapter;
      set => this._extraTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public ExtraCardTableAdapter ExtraCardTableAdapter
    {
      get => this._extraCardTableAdapter;
      set => this._extraCardTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public ExtraCharge_TempTableAdapter ExtraCharge_TempTableAdapter
    {
      get => this._extraCharge_TempTableAdapter;
      set => this._extraCharge_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GData_TempTableAdapter GData_TempTableAdapter
    {
      get => this._gData_TempTableAdapter;
      set => this._gData_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GDSalesTableAdapter GDSalesTableAdapter
    {
      get => this._gDSalesTableAdapter;
      set => this._gDSalesTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GInfo_TempTableAdapter GInfo_TempTableAdapter
    {
      get => this._gInfo_TempTableAdapter;
      set => this._gInfo_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GracePeriodListTableAdapter GracePeriodListTableAdapter
    {
      get => this._gracePeriodListTableAdapter;
      set => this._gracePeriodListTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GTransactions_TempTableAdapter GTransactions_TempTableAdapter
    {
      get => this._gTransactions_TempTableAdapter;
      set => this._gTransactions_TempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GuestAccountTableAdapter GuestAccountTableAdapter
    {
      get => this._guestAccountTableAdapter;
      set => this._guestAccountTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GuestHistoryTableAdapter GuestHistoryTableAdapter
    {
      get => this._guestHistoryTableAdapter;
      set => this._guestHistoryTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GuestIssuedByBldNoTableAdapter GuestIssuedByBldNoTableAdapter
    {
      get => this._guestIssuedByBldNoTableAdapter;
      set => this._guestIssuedByBldNoTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GuestIssuedByFloorNoTableAdapter GuestIssuedByFloorNoTableAdapter
    {
      get => this._guestIssuedByFloorNoTableAdapter;
      set => this._guestIssuedByFloorNoTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GuestIssuedByGuestIDTableAdapter GuestIssuedByGuestIDTableAdapter
    {
      get => this._guestIssuedByGuestIDTableAdapter;
      set => this._guestIssuedByGuestIDTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public GuestIssuedByRoomNoTableAdapter GuestIssuedByRoomNoTableAdapter
    {
      get => this._guestIssuedByRoomNoTableAdapter;
      set => this._guestIssuedByRoomNoTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GuestListTableAdapter GuestListTableAdapter
    {
      get => this._guestListTableAdapter;
      set => this._guestListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GuestRecordDateTableAdapter GuestRecordDateTableAdapter
    {
      get => this._guestRecordDateTableAdapter;
      set => this._guestRecordDateTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public GViewRoom_TempTableAdapter GViewRoom_TempTableAdapter
    {
      get => this._gViewRoom_TempTableAdapter;
      set => this._gViewRoom_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public IssueCardHistoryTableAdapter IssueCardHistoryTableAdapter
    {
      get => this._issueCardHistoryTableAdapter;
      set => this._issueCardHistoryTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public KeyChargesTempTableAdapter KeyChargesTempTableAdapter
    {
      get => this._keyChargesTempTableAdapter;
      set => this._keyChargesTempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public LossCardTableAdapter LossCardTableAdapter
    {
      get => this._lossCardTableAdapter;
      set => this._lossCardTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public MLogTableAdapter MLogTableAdapter
    {
      get => this._mLogTableAdapter;
      set => this._mLogTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public ReceiptTableAdapter ReceiptTableAdapter
    {
      get => this._receiptTableAdapter;
      set => this._receiptTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public ReservationListTableAdapter ReservationListTableAdapter
    {
      get => this._reservationListTableAdapter;
      set => this._reservationListTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomDetailTableAdapter RoomDetailTableAdapter
    {
      get => this._roomDetailTableAdapter;
      set => this._roomDetailTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public RoomHistoryTableAdapter RoomHistoryTableAdapter
    {
      get => this._roomHistoryTableAdapter;
      set => this._roomHistoryTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomInformationTableAdapter RoomInformationTableAdapter
    {
      get => this._roomInformationTableAdapter;
      set => this._roomInformationTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public RoomTypeTempTableAdapter RoomTypeTempTableAdapter
    {
      get => this._roomTypeTempTableAdapter;
      set => this._roomTypeTempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public StaffTempTableAdapter StaffTempTableAdapter
    {
      get => this._staffTempTableAdapter;
      set => this._staffTempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SystemSetTempTableAdapter SystemSetTempTableAdapter
    {
      get => this._systemSetTempTableAdapter;
      set => this._systemSetTempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public UnLockDoorByRoomNoTableAdapter UnLockDoorByRoomNoTableAdapter
    {
      get => this._unLockDoorByRoomNoTableAdapter;
      set => this._unLockDoorByRoomNoTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public UnlockDoorHistoryTableAdapter UnlockDoorHistoryTableAdapter
    {
      get => this._unlockDoorHistoryTableAdapter;
      set => this._unlockDoorHistoryTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public UploadDataTableAdapter UploadDataTableAdapter
    {
      get => this._uploadDataTableAdapter;
      set => this._uploadDataTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public VacantStatus_TempTableAdapter VacantStatus_TempTableAdapter
    {
      get => this._vacantStatus_TempTableAdapter;
      set => this._vacantStatus_TempTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public ZoneTempTableAdapter ZoneTempTableAdapter
    {
      get => this._zoneTempTableAdapter;
      set => this._zoneTempTableAdapter = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public AccIssuedCardHistoryTableAdapter AccIssuedCardHistoryTableAdapter
    {
      get => this._accIssuedCardHistoryTableAdapter;
      set => this._accIssuedCardHistoryTableAdapter = value;
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
        if (this._accBonusEntitleListTableAdapter != null && this._accBonusEntitleListTableAdapter.Connection != null)
          return (IDbConnection) this._accBonusEntitleListTableAdapter.Connection;
        if (this._accCurrentGByFloorNoTableAdapter != null && this._accCurrentGByFloorNoTableAdapter.Connection != null)
          return (IDbConnection) this._accCurrentGByFloorNoTableAdapter.Connection;
        if (this._accCurrentGInfoTableAdapter != null && this._accCurrentGInfoTableAdapter.Connection != null)
          return (IDbConnection) this._accCurrentGInfoTableAdapter.Connection;
        if (this._accErrorRecordsTableAdapter != null && this._accErrorRecordsTableAdapter.Connection != null)
          return (IDbConnection) this._accErrorRecordsTableAdapter.Connection;
        if (this._accExtraTableAdapter != null && this._accExtraTableAdapter.Connection != null)
          return (IDbConnection) this._accExtraTableAdapter.Connection;
        if (this._accGInfo_TempTableAdapter != null && this._accGInfo_TempTableAdapter.Connection != null)
          return (IDbConnection) this._accGInfo_TempTableAdapter.Connection;
        if (this._accGracePeriodListTableAdapter != null && this._accGracePeriodListTableAdapter.Connection != null)
          return (IDbConnection) this._accGracePeriodListTableAdapter.Connection;
        if (this._accGuestAccountTableAdapter != null && this._accGuestAccountTableAdapter.Connection != null)
          return (IDbConnection) this._accGuestAccountTableAdapter.Connection;
        if (this._accGuestHistoryTableAdapter != null && this._accGuestHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._accGuestHistoryTableAdapter.Connection;
        if (this._accGuestListTableAdapter != null && this._accGuestListTableAdapter.Connection != null)
          return (IDbConnection) this._accGuestListTableAdapter.Connection;
        if (this._accGuestRecordDateTableAdapter != null && this._accGuestRecordDateTableAdapter.Connection != null)
          return (IDbConnection) this._accGuestRecordDateTableAdapter.Connection;
        if (this._accReservationListTableAdapter != null && this._accReservationListTableAdapter.Connection != null)
          return (IDbConnection) this._accReservationListTableAdapter.Connection;
        if (this._accRoomDetailTableAdapter != null && this._accRoomDetailTableAdapter.Connection != null)
          return (IDbConnection) this._accRoomDetailTableAdapter.Connection;
        if (this._accRoomInformationTableAdapter != null && this._accRoomInformationTableAdapter.Connection != null)
          return (IDbConnection) this._accRoomInformationTableAdapter.Connection;
        if (this._accSalesTableAdapter != null && this._accSalesTableAdapter.Connection != null)
          return (IDbConnection) this._accSalesTableAdapter.Connection;
        if (this._accTransTableAdapter != null && this._accTransTableAdapter.Connection != null)
          return (IDbConnection) this._accTransTableAdapter.Connection;
        if (this._availableRoom_TempTableAdapter != null && this._availableRoom_TempTableAdapter.Connection != null)
          return (IDbConnection) this._availableRoom_TempTableAdapter.Connection;
        if (this._banking_TempTableAdapter != null && this._banking_TempTableAdapter.Connection != null)
          return (IDbConnection) this._banking_TempTableAdapter.Connection;
        if (this._bonusEntitleListTableAdapter != null && this._bonusEntitleListTableAdapter.Connection != null)
          return (IDbConnection) this._bonusEntitleListTableAdapter.Connection;
        if (this._bonusTempTableAdapter != null && this._bonusTempTableAdapter.Connection != null)
          return (IDbConnection) this._bonusTempTableAdapter.Connection;
        if (this._checkRoom_TempTableAdapter != null && this._checkRoom_TempTableAdapter.Connection != null)
          return (IDbConnection) this._checkRoom_TempTableAdapter.Connection;
        if (this._currentGByFloorNoTableAdapter != null && this._currentGByFloorNoTableAdapter.Connection != null)
          return (IDbConnection) this._currentGByFloorNoTableAdapter.Connection;
        if (this._currentGInfoTableAdapter != null && this._currentGInfoTableAdapter.Connection != null)
          return (IDbConnection) this._currentGInfoTableAdapter.Connection;
        if (this._detailGuestIssuedTableAdapter != null && this._detailGuestIssuedTableAdapter.Connection != null)
          return (IDbConnection) this._detailGuestIssuedTableAdapter.Connection;
        if (this._displayRooms_TempTableAdapter != null && this._displayRooms_TempTableAdapter.Connection != null)
          return (IDbConnection) this._displayRooms_TempTableAdapter.Connection;
        if (this._dLogTableAdapter != null && this._dLogTableAdapter.Connection != null)
          return (IDbConnection) this._dLogTableAdapter.Connection;
        if (this._dTransactionsTableAdapter != null && this._dTransactionsTableAdapter.Connection != null)
          return (IDbConnection) this._dTransactionsTableAdapter.Connection;
        if (this._errorRecordsTableAdapter != null && this._errorRecordsTableAdapter.Connection != null)
          return (IDbConnection) this._errorRecordsTableAdapter.Connection;
        if (this._extraTableAdapter != null && this._extraTableAdapter.Connection != null)
          return (IDbConnection) this._extraTableAdapter.Connection;
        if (this._extraCardTableAdapter != null && this._extraCardTableAdapter.Connection != null)
          return (IDbConnection) this._extraCardTableAdapter.Connection;
        if (this._extraCharge_TempTableAdapter != null && this._extraCharge_TempTableAdapter.Connection != null)
          return (IDbConnection) this._extraCharge_TempTableAdapter.Connection;
        if (this._gData_TempTableAdapter != null && this._gData_TempTableAdapter.Connection != null)
          return (IDbConnection) this._gData_TempTableAdapter.Connection;
        if (this._gDSalesTableAdapter != null && this._gDSalesTableAdapter.Connection != null)
          return (IDbConnection) this._gDSalesTableAdapter.Connection;
        if (this._gInfo_TempTableAdapter != null && this._gInfo_TempTableAdapter.Connection != null)
          return (IDbConnection) this._gInfo_TempTableAdapter.Connection;
        if (this._gracePeriodListTableAdapter != null && this._gracePeriodListTableAdapter.Connection != null)
          return (IDbConnection) this._gracePeriodListTableAdapter.Connection;
        if (this._gTransactions_TempTableAdapter != null && this._gTransactions_TempTableAdapter.Connection != null)
          return (IDbConnection) this._gTransactions_TempTableAdapter.Connection;
        if (this._guestAccountTableAdapter != null && this._guestAccountTableAdapter.Connection != null)
          return (IDbConnection) this._guestAccountTableAdapter.Connection;
        if (this._guestHistoryTableAdapter != null && this._guestHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._guestHistoryTableAdapter.Connection;
        if (this._guestIssuedByBldNoTableAdapter != null && this._guestIssuedByBldNoTableAdapter.Connection != null)
          return (IDbConnection) this._guestIssuedByBldNoTableAdapter.Connection;
        if (this._guestIssuedByFloorNoTableAdapter != null && this._guestIssuedByFloorNoTableAdapter.Connection != null)
          return (IDbConnection) this._guestIssuedByFloorNoTableAdapter.Connection;
        if (this._guestIssuedByGuestIDTableAdapter != null && this._guestIssuedByGuestIDTableAdapter.Connection != null)
          return (IDbConnection) this._guestIssuedByGuestIDTableAdapter.Connection;
        if (this._guestIssuedByRoomNoTableAdapter != null && this._guestIssuedByRoomNoTableAdapter.Connection != null)
          return (IDbConnection) this._guestIssuedByRoomNoTableAdapter.Connection;
        if (this._guestListTableAdapter != null && this._guestListTableAdapter.Connection != null)
          return (IDbConnection) this._guestListTableAdapter.Connection;
        if (this._guestRecordDateTableAdapter != null && this._guestRecordDateTableAdapter.Connection != null)
          return (IDbConnection) this._guestRecordDateTableAdapter.Connection;
        if (this._gViewRoom_TempTableAdapter != null && this._gViewRoom_TempTableAdapter.Connection != null)
          return (IDbConnection) this._gViewRoom_TempTableAdapter.Connection;
        if (this._issueCardHistoryTableAdapter != null && this._issueCardHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._issueCardHistoryTableAdapter.Connection;
        if (this._keyChargesTempTableAdapter != null && this._keyChargesTempTableAdapter.Connection != null)
          return (IDbConnection) this._keyChargesTempTableAdapter.Connection;
        if (this._lossCardTableAdapter != null && this._lossCardTableAdapter.Connection != null)
          return (IDbConnection) this._lossCardTableAdapter.Connection;
        if (this._mLogTableAdapter != null && this._mLogTableAdapter.Connection != null)
          return (IDbConnection) this._mLogTableAdapter.Connection;
        if (this._receiptTableAdapter != null && this._receiptTableAdapter.Connection != null)
          return (IDbConnection) this._receiptTableAdapter.Connection;
        if (this._reservationListTableAdapter != null && this._reservationListTableAdapter.Connection != null)
          return (IDbConnection) this._reservationListTableAdapter.Connection;
        if (this._roomDetailTableAdapter != null && this._roomDetailTableAdapter.Connection != null)
          return (IDbConnection) this._roomDetailTableAdapter.Connection;
        if (this._roomHistoryTableAdapter != null && this._roomHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._roomHistoryTableAdapter.Connection;
        if (this._roomInformationTableAdapter != null && this._roomInformationTableAdapter.Connection != null)
          return (IDbConnection) this._roomInformationTableAdapter.Connection;
        if (this._roomTypeTempTableAdapter != null && this._roomTypeTempTableAdapter.Connection != null)
          return (IDbConnection) this._roomTypeTempTableAdapter.Connection;
        if (this._staffTempTableAdapter != null && this._staffTempTableAdapter.Connection != null)
          return (IDbConnection) this._staffTempTableAdapter.Connection;
        if (this._systemSetTempTableAdapter != null && this._systemSetTempTableAdapter.Connection != null)
          return (IDbConnection) this._systemSetTempTableAdapter.Connection;
        if (this._unLockDoorByRoomNoTableAdapter != null && this._unLockDoorByRoomNoTableAdapter.Connection != null)
          return (IDbConnection) this._unLockDoorByRoomNoTableAdapter.Connection;
        if (this._unlockDoorHistoryTableAdapter != null && this._unlockDoorHistoryTableAdapter.Connection != null)
          return (IDbConnection) this._unlockDoorHistoryTableAdapter.Connection;
        if (this._uploadDataTableAdapter != null && this._uploadDataTableAdapter.Connection != null)
          return (IDbConnection) this._uploadDataTableAdapter.Connection;
        if (this._vacantStatus_TempTableAdapter != null && this._vacantStatus_TempTableAdapter.Connection != null)
          return (IDbConnection) this._vacantStatus_TempTableAdapter.Connection;
        if (this._zoneTempTableAdapter != null && this._zoneTempTableAdapter.Connection != null)
          return (IDbConnection) this._zoneTempTableAdapter.Connection;
        return this._accIssuedCardHistoryTableAdapter != null && this._accIssuedCardHistoryTableAdapter.Connection != null ? (IDbConnection) this._accIssuedCardHistoryTableAdapter.Connection : (IDbConnection) null;
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
        if (this._accBonusEntitleListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accCurrentGByFloorNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accCurrentGInfoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accErrorRecordsTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accExtraTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGInfo_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGracePeriodListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGuestAccountTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGuestHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGuestListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accGuestRecordDateTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accReservationListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accRoomDetailTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accRoomInformationTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accSalesTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accTransTableAdapter != null)
          ++adapterInstanceCount;
        if (this._availableRoom_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._banking_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonusEntitleListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._bonusTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._checkRoom_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._currentGByFloorNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._currentGInfoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._detailGuestIssuedTableAdapter != null)
          ++adapterInstanceCount;
        if (this._displayRooms_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._dLogTableAdapter != null)
          ++adapterInstanceCount;
        if (this._dTransactionsTableAdapter != null)
          ++adapterInstanceCount;
        if (this._errorRecordsTableAdapter != null)
          ++adapterInstanceCount;
        if (this._extraTableAdapter != null)
          ++adapterInstanceCount;
        if (this._extraCardTableAdapter != null)
          ++adapterInstanceCount;
        if (this._extraCharge_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gData_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gDSalesTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gInfo_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gracePeriodListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gTransactions_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestAccountTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestIssuedByBldNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestIssuedByFloorNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestIssuedByGuestIDTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestIssuedByRoomNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._guestRecordDateTableAdapter != null)
          ++adapterInstanceCount;
        if (this._gViewRoom_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._issueCardHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._keyChargesTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._lossCardTableAdapter != null)
          ++adapterInstanceCount;
        if (this._mLogTableAdapter != null)
          ++adapterInstanceCount;
        if (this._receiptTableAdapter != null)
          ++adapterInstanceCount;
        if (this._reservationListTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomDetailTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomInformationTableAdapter != null)
          ++adapterInstanceCount;
        if (this._roomTypeTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._staffTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._systemSetTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._unLockDoorByRoomNoTableAdapter != null)
          ++adapterInstanceCount;
        if (this._unlockDoorHistoryTableAdapter != null)
          ++adapterInstanceCount;
        if (this._uploadDataTableAdapter != null)
          ++adapterInstanceCount;
        if (this._vacantStatus_TempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._zoneTempTableAdapter != null)
          ++adapterInstanceCount;
        if (this._accIssuedCardHistoryTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    private int UpdateUpdatedRows(
      TempDataSet dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._guestListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestIssuedByRoomNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestIssuedByRoomNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestIssuedByRoomNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestIssuedByGuestIDTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestIssuedByGuestID.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestIssuedByGuestIDTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestRecordDateTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestRecordDate.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestRecordDateTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._keyChargesTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.KeyChargesTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._keyChargesTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._issueCardHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.IssueCardHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._issueCardHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gViewRoom_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GViewRoom_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gViewRoom_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestIssuedByFloorNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestIssuedByFloorNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestIssuedByFloorNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gracePeriodListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GracePeriodList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gracePeriodListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gInfo_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GInfo_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gInfo_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gDSalesTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GDSales.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gDSalesTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gTransactions_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GTransactions_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gTransactions_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestIssuedByBldNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestIssuedByBldNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestIssuedByBldNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._guestAccountTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GuestAccount.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._guestAccountTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._lossCardTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.LossCard.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._lossCardTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._unlockDoorHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.UnlockDoorHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._unlockDoorHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._unLockDoorByRoomNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.UnLockDoorByRoomNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._unLockDoorByRoomNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._systemSetTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.SystemSetTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._systemSetTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._uploadDataTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.UploadData.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._uploadDataTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accIssuedCardHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccIssuedCardHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accIssuedCardHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._zoneTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ZoneTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._zoneTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._vacantStatus_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.VacantStatus_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._vacantStatus_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._staffTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.StaffTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._staffTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._reservationListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ReservationList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._reservationListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._receiptTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Receipt.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._receiptTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._mLogTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.MLog.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._mLogTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomDetailTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomDetail.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomDetailTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomTypeTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomTypeTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomTypeTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomInformationTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomInformation.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomInformationTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._roomHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.RoomHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._roomHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._gData_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.GData_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._gData_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGuestRecordDateTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGuestRecordDate.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGuestRecordDateTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGuestListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGuestList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGuestListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGuestHistoryTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGuestHistory.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGuestHistoryTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accReservationListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccReservationList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accReservationListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accSalesTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccSales.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accSalesTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accRoomInformationTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccRoomInformation.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accRoomInformationTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accRoomDetailTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccRoomDetail.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accRoomDetailTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGuestAccountTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGuestAccount.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGuestAccountTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accCurrentGInfoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccCurrentGInfo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accCurrentGInfoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accCurrentGByFloorNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccCurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accCurrentGByFloorNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accBonusEntitleListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccBonusEntitleList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accBonusEntitleListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accErrorRecordsTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccErrorRecords.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accErrorRecordsTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGracePeriodListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGracePeriodList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGracePeriodListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accGInfo_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccGInfo_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accGInfo_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accExtraTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccExtra.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accExtraTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._accTransTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AccTrans.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._accTransTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._dTransactionsTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.DTransactions.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._dTransactionsTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._dLogTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.DLog.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._dLogTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._displayRooms_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.DisplayRooms_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._displayRooms_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._errorRecordsTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ErrorRecords.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._errorRecordsTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._extraCharge_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ExtraCharge_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._extraCharge_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._extraCardTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.ExtraCard.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._extraCardTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._extraTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Extra.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._extraTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._detailGuestIssuedTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.DetailGuestIssued.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._detailGuestIssuedTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonusEntitleListTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.BonusEntitleList.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonusEntitleListTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._banking_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Banking_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._banking_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._availableRoom_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.AvailableRoom_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._availableRoom_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._bonusTempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.BonusTemp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._bonusTempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._currentGInfoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.CurrentGInfo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._currentGInfoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._currentGByFloorNoTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.CurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._currentGByFloorNoTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._checkRoom_TempTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.CheckRoom_Temp.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._checkRoom_TempTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateInsertedRows(TempDataSet dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._guestListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByRoomNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByRoomNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByRoomNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByGuestIDTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByGuestID.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByGuestIDTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestRecordDateTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestRecordDate.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestRecordDateTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._keyChargesTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.KeyChargesTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._keyChargesTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._issueCardHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.IssueCardHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._issueCardHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gViewRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GViewRoom_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gViewRoom_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByFloorNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByFloorNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gracePeriodListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GracePeriodList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gracePeriodListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gInfo_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GInfo_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gInfo_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gDSalesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GDSales.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gDSalesTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gTransactions_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GTransactions_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gTransactions_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByBldNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByBldNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByBldNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestAccountTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestAccount.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestAccountTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lossCardTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LossCard.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lossCardTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unlockDoorHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnlockDoorHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unlockDoorHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unLockDoorByRoomNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnLockDoorByRoomNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unLockDoorByRoomNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSetTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSetTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSetTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._uploadDataTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UploadData.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._uploadDataTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accIssuedCardHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccIssuedCardHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accIssuedCardHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._zoneTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ZoneTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._zoneTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._vacantStatus_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.VacantStatus_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._vacantStatus_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._staffTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.StaffTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._staffTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._reservationListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ReservationList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._reservationListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._receiptTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Receipt.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._receiptTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._mLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.MLog.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._mLogTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomDetailTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomDetail.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomDetailTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTypeTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomTypeTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTypeTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomInformationTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomInformation.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomInformationTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gData_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GData_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gData_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestRecordDateTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestRecordDate.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestRecordDateTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestHistory.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestHistoryTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accReservationListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccReservationList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accReservationListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accSalesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccSales.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accSalesTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accRoomInformationTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccRoomInformation.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accRoomInformationTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accRoomDetailTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccRoomDetail.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accRoomDetailTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestAccountTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestAccount.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestAccountTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accCurrentGInfoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccCurrentGInfo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accCurrentGInfoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accCurrentGByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccCurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accCurrentGByFloorNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accBonusEntitleListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccBonusEntitleList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accBonusEntitleListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accErrorRecordsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccErrorRecords.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accErrorRecordsTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGracePeriodListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGracePeriodList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGracePeriodListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGInfo_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGInfo_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGInfo_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accExtraTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccExtra.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accExtraTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccTrans.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accTransTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._dTransactionsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DTransactions.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._dTransactionsTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._dLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DLog.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._dLogTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._displayRooms_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DisplayRooms_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._displayRooms_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._errorRecordsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ErrorRecords.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._errorRecordsTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraCharge_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCharge_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraCharge_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraCardTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCard.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraCardTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Extra.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._detailGuestIssuedTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DetailGuestIssued.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._detailGuestIssuedTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusEntitleListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.BonusEntitleList.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusEntitleListTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._banking_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Banking_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._banking_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._availableRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AvailableRoom_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._availableRoom_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.BonusTemp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusTempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._currentGInfoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CurrentGInfo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._currentGInfoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._currentGByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._currentGByFloorNoTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._checkRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CheckRoom_Temp.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._checkRoom_TempTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateDeletedRows(TempDataSet dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._checkRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CheckRoom_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._checkRoom_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._currentGByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._currentGByFloorNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._currentGInfoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.CurrentGInfo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._currentGInfoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.BonusTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._availableRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AvailableRoom_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._availableRoom_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._banking_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Banking_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._banking_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._bonusEntitleListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.BonusEntitleList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._bonusEntitleListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._detailGuestIssuedTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DetailGuestIssued.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._detailGuestIssuedTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Extra.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraCardTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCard.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraCardTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._extraCharge_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ExtraCharge_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._extraCharge_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._errorRecordsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ErrorRecords.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._errorRecordsTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._displayRooms_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DisplayRooms_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._displayRooms_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._dLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DLog.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._dLogTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._dTransactionsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.DTransactions.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._dTransactionsTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accTransTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccTrans.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accTransTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accExtraTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccExtra.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accExtraTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGInfo_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGInfo_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGInfo_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGracePeriodListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGracePeriodList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGracePeriodListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accErrorRecordsTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccErrorRecords.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accErrorRecordsTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accBonusEntitleListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccBonusEntitleList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accBonusEntitleListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accCurrentGByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccCurrentGByFloorNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accCurrentGByFloorNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accCurrentGInfoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccCurrentGInfo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accCurrentGInfoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestAccountTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestAccount.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestAccountTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accRoomDetailTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccRoomDetail.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accRoomDetailTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accRoomInformationTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccRoomInformation.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accRoomInformationTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accSalesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccSales.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accSalesTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accReservationListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccReservationList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accReservationListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accGuestRecordDateTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccGuestRecordDate.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accGuestRecordDateTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gData_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GData_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gData_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomInformationTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomInformation.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomInformationTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomTypeTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomTypeTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomTypeTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._roomDetailTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.RoomDetail.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._roomDetailTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._mLogTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.MLog.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._mLogTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._receiptTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Receipt.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._receiptTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._reservationListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ReservationList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._reservationListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._staffTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.StaffTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._staffTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._vacantStatus_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.VacantStatus_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._vacantStatus_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._zoneTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.ZoneTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._zoneTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._accIssuedCardHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.AccIssuedCardHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._accIssuedCardHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._uploadDataTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UploadData.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._uploadDataTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._systemSetTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.SystemSetTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._systemSetTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unLockDoorByRoomNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnLockDoorByRoomNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unLockDoorByRoomNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._unlockDoorHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.UnlockDoorHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._unlockDoorHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._lossCardTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.LossCard.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._lossCardTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestAccountTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestAccount.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestAccountTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByBldNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByBldNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByBldNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gTransactions_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GTransactions_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gTransactions_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gDSalesTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GDSales.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gDSalesTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gInfo_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GInfo_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gInfo_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gracePeriodListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GracePeriodList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gracePeriodListTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByFloorNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByFloorNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByFloorNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._gViewRoom_TempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GViewRoom_Temp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._gViewRoom_TempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._issueCardHistoryTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.IssueCardHistory.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._issueCardHistoryTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._keyChargesTempTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.KeyChargesTemp.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._keyChargesTempTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestRecordDateTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestRecordDate.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestRecordDateTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByGuestIDTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByGuestID.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByGuestIDTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestIssuedByRoomNoTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestIssuedByRoomNo.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestIssuedByRoomNoTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      if (this._guestListTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.GuestList.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._guestListTableAdapter.Update(dataRowArray);
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
    public virtual int UpdateAll(TempDataSet dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._accBonusEntitleListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accBonusEntitleListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accCurrentGByFloorNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accCurrentGByFloorNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accCurrentGInfoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accCurrentGInfoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accErrorRecordsTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accErrorRecordsTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accExtraTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accExtraTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGInfo_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGInfo_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGracePeriodListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGracePeriodListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGuestAccountTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGuestAccountTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGuestHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGuestHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGuestListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGuestListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accGuestRecordDateTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accGuestRecordDateTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accReservationListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accReservationListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accRoomDetailTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accRoomDetailTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accRoomInformationTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accRoomInformationTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accSalesTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accSalesTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accTransTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accTransTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._availableRoom_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._availableRoom_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._banking_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._banking_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonusEntitleListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonusEntitleListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._bonusTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._bonusTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._checkRoom_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._checkRoom_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._currentGByFloorNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._currentGByFloorNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._currentGInfoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._currentGInfoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._detailGuestIssuedTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._detailGuestIssuedTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._displayRooms_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._displayRooms_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._dLogTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._dLogTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._dTransactionsTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._dTransactionsTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._errorRecordsTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._errorRecordsTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._extraTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._extraTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._extraCardTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._extraCardTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._extraCharge_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._extraCharge_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gData_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gData_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gDSalesTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gDSalesTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gInfo_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gInfo_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gracePeriodListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gracePeriodListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gTransactions_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gTransactions_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestAccountTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestAccountTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestIssuedByBldNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestIssuedByBldNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestIssuedByFloorNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestIssuedByFloorNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestIssuedByGuestIDTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestIssuedByGuestIDTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestIssuedByRoomNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestIssuedByRoomNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._guestRecordDateTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._guestRecordDateTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._gViewRoom_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._gViewRoom_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._issueCardHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._issueCardHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._keyChargesTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._keyChargesTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._lossCardTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._lossCardTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._mLogTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._mLogTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._receiptTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._receiptTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._reservationListTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._reservationListTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomDetailTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomDetailTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomInformationTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomInformationTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._roomTypeTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._roomTypeTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._staffTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._staffTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._systemSetTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._systemSetTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._unLockDoorByRoomNoTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._unLockDoorByRoomNoTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._unlockDoorHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._unlockDoorHistoryTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._uploadDataTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._uploadDataTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._vacantStatus_TempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._vacantStatus_TempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._zoneTempTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._zoneTempTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      if (this._accIssuedCardHistoryTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._accIssuedCardHistoryTableAdapter.Connection))
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
        if (this._accBonusEntitleListTableAdapter != null)
        {
          dictionary.Add((object) this._accBonusEntitleListTableAdapter, (IDbConnection) this._accBonusEntitleListTableAdapter.Connection);
          this._accBonusEntitleListTableAdapter.Connection = (OleDbConnection) connection;
          this._accBonusEntitleListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accBonusEntitleListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accBonusEntitleListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accBonusEntitleListTableAdapter.Adapter);
          }
        }
        if (this._accCurrentGByFloorNoTableAdapter != null)
        {
          dictionary.Add((object) this._accCurrentGByFloorNoTableAdapter, (IDbConnection) this._accCurrentGByFloorNoTableAdapter.Connection);
          this._accCurrentGByFloorNoTableAdapter.Connection = (OleDbConnection) connection;
          this._accCurrentGByFloorNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accCurrentGByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accCurrentGByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accCurrentGByFloorNoTableAdapter.Adapter);
          }
        }
        if (this._accCurrentGInfoTableAdapter != null)
        {
          dictionary.Add((object) this._accCurrentGInfoTableAdapter, (IDbConnection) this._accCurrentGInfoTableAdapter.Connection);
          this._accCurrentGInfoTableAdapter.Connection = (OleDbConnection) connection;
          this._accCurrentGInfoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accCurrentGInfoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accCurrentGInfoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accCurrentGInfoTableAdapter.Adapter);
          }
        }
        if (this._accErrorRecordsTableAdapter != null)
        {
          dictionary.Add((object) this._accErrorRecordsTableAdapter, (IDbConnection) this._accErrorRecordsTableAdapter.Connection);
          this._accErrorRecordsTableAdapter.Connection = (OleDbConnection) connection;
          this._accErrorRecordsTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accErrorRecordsTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accErrorRecordsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accErrorRecordsTableAdapter.Adapter);
          }
        }
        if (this._accExtraTableAdapter != null)
        {
          dictionary.Add((object) this._accExtraTableAdapter, (IDbConnection) this._accExtraTableAdapter.Connection);
          this._accExtraTableAdapter.Connection = (OleDbConnection) connection;
          this._accExtraTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accExtraTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accExtraTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accExtraTableAdapter.Adapter);
          }
        }
        if (this._accGInfo_TempTableAdapter != null)
        {
          dictionary.Add((object) this._accGInfo_TempTableAdapter, (IDbConnection) this._accGInfo_TempTableAdapter.Connection);
          this._accGInfo_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._accGInfo_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGInfo_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGInfo_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGInfo_TempTableAdapter.Adapter);
          }
        }
        if (this._accGracePeriodListTableAdapter != null)
        {
          dictionary.Add((object) this._accGracePeriodListTableAdapter, (IDbConnection) this._accGracePeriodListTableAdapter.Connection);
          this._accGracePeriodListTableAdapter.Connection = (OleDbConnection) connection;
          this._accGracePeriodListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGracePeriodListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGracePeriodListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGracePeriodListTableAdapter.Adapter);
          }
        }
        if (this._accGuestAccountTableAdapter != null)
        {
          dictionary.Add((object) this._accGuestAccountTableAdapter, (IDbConnection) this._accGuestAccountTableAdapter.Connection);
          this._accGuestAccountTableAdapter.Connection = (OleDbConnection) connection;
          this._accGuestAccountTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGuestAccountTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGuestAccountTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGuestAccountTableAdapter.Adapter);
          }
        }
        if (this._accGuestHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._accGuestHistoryTableAdapter, (IDbConnection) this._accGuestHistoryTableAdapter.Connection);
          this._accGuestHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._accGuestHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGuestHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGuestHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGuestHistoryTableAdapter.Adapter);
          }
        }
        if (this._accGuestListTableAdapter != null)
        {
          dictionary.Add((object) this._accGuestListTableAdapter, (IDbConnection) this._accGuestListTableAdapter.Connection);
          this._accGuestListTableAdapter.Connection = (OleDbConnection) connection;
          this._accGuestListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGuestListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGuestListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGuestListTableAdapter.Adapter);
          }
        }
        if (this._accGuestRecordDateTableAdapter != null)
        {
          dictionary.Add((object) this._accGuestRecordDateTableAdapter, (IDbConnection) this._accGuestRecordDateTableAdapter.Connection);
          this._accGuestRecordDateTableAdapter.Connection = (OleDbConnection) connection;
          this._accGuestRecordDateTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accGuestRecordDateTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accGuestRecordDateTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accGuestRecordDateTableAdapter.Adapter);
          }
        }
        if (this._accReservationListTableAdapter != null)
        {
          dictionary.Add((object) this._accReservationListTableAdapter, (IDbConnection) this._accReservationListTableAdapter.Connection);
          this._accReservationListTableAdapter.Connection = (OleDbConnection) connection;
          this._accReservationListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accReservationListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accReservationListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accReservationListTableAdapter.Adapter);
          }
        }
        if (this._accRoomDetailTableAdapter != null)
        {
          dictionary.Add((object) this._accRoomDetailTableAdapter, (IDbConnection) this._accRoomDetailTableAdapter.Connection);
          this._accRoomDetailTableAdapter.Connection = (OleDbConnection) connection;
          this._accRoomDetailTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accRoomDetailTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accRoomDetailTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accRoomDetailTableAdapter.Adapter);
          }
        }
        if (this._accRoomInformationTableAdapter != null)
        {
          dictionary.Add((object) this._accRoomInformationTableAdapter, (IDbConnection) this._accRoomInformationTableAdapter.Connection);
          this._accRoomInformationTableAdapter.Connection = (OleDbConnection) connection;
          this._accRoomInformationTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accRoomInformationTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accRoomInformationTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accRoomInformationTableAdapter.Adapter);
          }
        }
        if (this._accSalesTableAdapter != null)
        {
          dictionary.Add((object) this._accSalesTableAdapter, (IDbConnection) this._accSalesTableAdapter.Connection);
          this._accSalesTableAdapter.Connection = (OleDbConnection) connection;
          this._accSalesTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accSalesTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accSalesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accSalesTableAdapter.Adapter);
          }
        }
        if (this._accTransTableAdapter != null)
        {
          dictionary.Add((object) this._accTransTableAdapter, (IDbConnection) this._accTransTableAdapter.Connection);
          this._accTransTableAdapter.Connection = (OleDbConnection) connection;
          this._accTransTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accTransTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accTransTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accTransTableAdapter.Adapter);
          }
        }
        if (this._availableRoom_TempTableAdapter != null)
        {
          dictionary.Add((object) this._availableRoom_TempTableAdapter, (IDbConnection) this._availableRoom_TempTableAdapter.Connection);
          this._availableRoom_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._availableRoom_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._availableRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._availableRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._availableRoom_TempTableAdapter.Adapter);
          }
        }
        if (this._banking_TempTableAdapter != null)
        {
          dictionary.Add((object) this._banking_TempTableAdapter, (IDbConnection) this._banking_TempTableAdapter.Connection);
          this._banking_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._banking_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._banking_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._banking_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._banking_TempTableAdapter.Adapter);
          }
        }
        if (this._bonusEntitleListTableAdapter != null)
        {
          dictionary.Add((object) this._bonusEntitleListTableAdapter, (IDbConnection) this._bonusEntitleListTableAdapter.Connection);
          this._bonusEntitleListTableAdapter.Connection = (OleDbConnection) connection;
          this._bonusEntitleListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonusEntitleListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonusEntitleListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonusEntitleListTableAdapter.Adapter);
          }
        }
        if (this._bonusTempTableAdapter != null)
        {
          dictionary.Add((object) this._bonusTempTableAdapter, (IDbConnection) this._bonusTempTableAdapter.Connection);
          this._bonusTempTableAdapter.Connection = (OleDbConnection) connection;
          this._bonusTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._bonusTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._bonusTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._bonusTempTableAdapter.Adapter);
          }
        }
        if (this._checkRoom_TempTableAdapter != null)
        {
          dictionary.Add((object) this._checkRoom_TempTableAdapter, (IDbConnection) this._checkRoom_TempTableAdapter.Connection);
          this._checkRoom_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._checkRoom_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._checkRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._checkRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._checkRoom_TempTableAdapter.Adapter);
          }
        }
        if (this._currentGByFloorNoTableAdapter != null)
        {
          dictionary.Add((object) this._currentGByFloorNoTableAdapter, (IDbConnection) this._currentGByFloorNoTableAdapter.Connection);
          this._currentGByFloorNoTableAdapter.Connection = (OleDbConnection) connection;
          this._currentGByFloorNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._currentGByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._currentGByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._currentGByFloorNoTableAdapter.Adapter);
          }
        }
        if (this._currentGInfoTableAdapter != null)
        {
          dictionary.Add((object) this._currentGInfoTableAdapter, (IDbConnection) this._currentGInfoTableAdapter.Connection);
          this._currentGInfoTableAdapter.Connection = (OleDbConnection) connection;
          this._currentGInfoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._currentGInfoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._currentGInfoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._currentGInfoTableAdapter.Adapter);
          }
        }
        if (this._detailGuestIssuedTableAdapter != null)
        {
          dictionary.Add((object) this._detailGuestIssuedTableAdapter, (IDbConnection) this._detailGuestIssuedTableAdapter.Connection);
          this._detailGuestIssuedTableAdapter.Connection = (OleDbConnection) connection;
          this._detailGuestIssuedTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._detailGuestIssuedTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._detailGuestIssuedTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._detailGuestIssuedTableAdapter.Adapter);
          }
        }
        if (this._displayRooms_TempTableAdapter != null)
        {
          dictionary.Add((object) this._displayRooms_TempTableAdapter, (IDbConnection) this._displayRooms_TempTableAdapter.Connection);
          this._displayRooms_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._displayRooms_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._displayRooms_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._displayRooms_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._displayRooms_TempTableAdapter.Adapter);
          }
        }
        if (this._dLogTableAdapter != null)
        {
          dictionary.Add((object) this._dLogTableAdapter, (IDbConnection) this._dLogTableAdapter.Connection);
          this._dLogTableAdapter.Connection = (OleDbConnection) connection;
          this._dLogTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._dLogTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._dLogTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._dLogTableAdapter.Adapter);
          }
        }
        if (this._dTransactionsTableAdapter != null)
        {
          dictionary.Add((object) this._dTransactionsTableAdapter, (IDbConnection) this._dTransactionsTableAdapter.Connection);
          this._dTransactionsTableAdapter.Connection = (OleDbConnection) connection;
          this._dTransactionsTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._dTransactionsTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._dTransactionsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._dTransactionsTableAdapter.Adapter);
          }
        }
        if (this._errorRecordsTableAdapter != null)
        {
          dictionary.Add((object) this._errorRecordsTableAdapter, (IDbConnection) this._errorRecordsTableAdapter.Connection);
          this._errorRecordsTableAdapter.Connection = (OleDbConnection) connection;
          this._errorRecordsTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._errorRecordsTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._errorRecordsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._errorRecordsTableAdapter.Adapter);
          }
        }
        if (this._extraTableAdapter != null)
        {
          dictionary.Add((object) this._extraTableAdapter, (IDbConnection) this._extraTableAdapter.Connection);
          this._extraTableAdapter.Connection = (OleDbConnection) connection;
          this._extraTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._extraTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._extraTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._extraTableAdapter.Adapter);
          }
        }
        if (this._extraCardTableAdapter != null)
        {
          dictionary.Add((object) this._extraCardTableAdapter, (IDbConnection) this._extraCardTableAdapter.Connection);
          this._extraCardTableAdapter.Connection = (OleDbConnection) connection;
          this._extraCardTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._extraCardTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._extraCardTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._extraCardTableAdapter.Adapter);
          }
        }
        if (this._extraCharge_TempTableAdapter != null)
        {
          dictionary.Add((object) this._extraCharge_TempTableAdapter, (IDbConnection) this._extraCharge_TempTableAdapter.Connection);
          this._extraCharge_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._extraCharge_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._extraCharge_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._extraCharge_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._extraCharge_TempTableAdapter.Adapter);
          }
        }
        if (this._gData_TempTableAdapter != null)
        {
          dictionary.Add((object) this._gData_TempTableAdapter, (IDbConnection) this._gData_TempTableAdapter.Connection);
          this._gData_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._gData_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gData_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gData_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gData_TempTableAdapter.Adapter);
          }
        }
        if (this._gDSalesTableAdapter != null)
        {
          dictionary.Add((object) this._gDSalesTableAdapter, (IDbConnection) this._gDSalesTableAdapter.Connection);
          this._gDSalesTableAdapter.Connection = (OleDbConnection) connection;
          this._gDSalesTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gDSalesTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gDSalesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gDSalesTableAdapter.Adapter);
          }
        }
        if (this._gInfo_TempTableAdapter != null)
        {
          dictionary.Add((object) this._gInfo_TempTableAdapter, (IDbConnection) this._gInfo_TempTableAdapter.Connection);
          this._gInfo_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._gInfo_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gInfo_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gInfo_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gInfo_TempTableAdapter.Adapter);
          }
        }
        if (this._gracePeriodListTableAdapter != null)
        {
          dictionary.Add((object) this._gracePeriodListTableAdapter, (IDbConnection) this._gracePeriodListTableAdapter.Connection);
          this._gracePeriodListTableAdapter.Connection = (OleDbConnection) connection;
          this._gracePeriodListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gracePeriodListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gracePeriodListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gracePeriodListTableAdapter.Adapter);
          }
        }
        if (this._gTransactions_TempTableAdapter != null)
        {
          dictionary.Add((object) this._gTransactions_TempTableAdapter, (IDbConnection) this._gTransactions_TempTableAdapter.Connection);
          this._gTransactions_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._gTransactions_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gTransactions_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gTransactions_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gTransactions_TempTableAdapter.Adapter);
          }
        }
        if (this._guestAccountTableAdapter != null)
        {
          dictionary.Add((object) this._guestAccountTableAdapter, (IDbConnection) this._guestAccountTableAdapter.Connection);
          this._guestAccountTableAdapter.Connection = (OleDbConnection) connection;
          this._guestAccountTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestAccountTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestAccountTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestAccountTableAdapter.Adapter);
          }
        }
        if (this._guestHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._guestHistoryTableAdapter, (IDbConnection) this._guestHistoryTableAdapter.Connection);
          this._guestHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._guestHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestHistoryTableAdapter.Adapter);
          }
        }
        if (this._guestIssuedByBldNoTableAdapter != null)
        {
          dictionary.Add((object) this._guestIssuedByBldNoTableAdapter, (IDbConnection) this._guestIssuedByBldNoTableAdapter.Connection);
          this._guestIssuedByBldNoTableAdapter.Connection = (OleDbConnection) connection;
          this._guestIssuedByBldNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestIssuedByBldNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestIssuedByBldNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestIssuedByBldNoTableAdapter.Adapter);
          }
        }
        if (this._guestIssuedByFloorNoTableAdapter != null)
        {
          dictionary.Add((object) this._guestIssuedByFloorNoTableAdapter, (IDbConnection) this._guestIssuedByFloorNoTableAdapter.Connection);
          this._guestIssuedByFloorNoTableAdapter.Connection = (OleDbConnection) connection;
          this._guestIssuedByFloorNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestIssuedByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestIssuedByFloorNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestIssuedByFloorNoTableAdapter.Adapter);
          }
        }
        if (this._guestIssuedByGuestIDTableAdapter != null)
        {
          dictionary.Add((object) this._guestIssuedByGuestIDTableAdapter, (IDbConnection) this._guestIssuedByGuestIDTableAdapter.Connection);
          this._guestIssuedByGuestIDTableAdapter.Connection = (OleDbConnection) connection;
          this._guestIssuedByGuestIDTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestIssuedByGuestIDTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestIssuedByGuestIDTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestIssuedByGuestIDTableAdapter.Adapter);
          }
        }
        if (this._guestIssuedByRoomNoTableAdapter != null)
        {
          dictionary.Add((object) this._guestIssuedByRoomNoTableAdapter, (IDbConnection) this._guestIssuedByRoomNoTableAdapter.Connection);
          this._guestIssuedByRoomNoTableAdapter.Connection = (OleDbConnection) connection;
          this._guestIssuedByRoomNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestIssuedByRoomNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestIssuedByRoomNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestIssuedByRoomNoTableAdapter.Adapter);
          }
        }
        if (this._guestListTableAdapter != null)
        {
          dictionary.Add((object) this._guestListTableAdapter, (IDbConnection) this._guestListTableAdapter.Connection);
          this._guestListTableAdapter.Connection = (OleDbConnection) connection;
          this._guestListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestListTableAdapter.Adapter);
          }
        }
        if (this._guestRecordDateTableAdapter != null)
        {
          dictionary.Add((object) this._guestRecordDateTableAdapter, (IDbConnection) this._guestRecordDateTableAdapter.Connection);
          this._guestRecordDateTableAdapter.Connection = (OleDbConnection) connection;
          this._guestRecordDateTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._guestRecordDateTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._guestRecordDateTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._guestRecordDateTableAdapter.Adapter);
          }
        }
        if (this._gViewRoom_TempTableAdapter != null)
        {
          dictionary.Add((object) this._gViewRoom_TempTableAdapter, (IDbConnection) this._gViewRoom_TempTableAdapter.Connection);
          this._gViewRoom_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._gViewRoom_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._gViewRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._gViewRoom_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._gViewRoom_TempTableAdapter.Adapter);
          }
        }
        if (this._issueCardHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._issueCardHistoryTableAdapter, (IDbConnection) this._issueCardHistoryTableAdapter.Connection);
          this._issueCardHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._issueCardHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._issueCardHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._issueCardHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._issueCardHistoryTableAdapter.Adapter);
          }
        }
        if (this._keyChargesTempTableAdapter != null)
        {
          dictionary.Add((object) this._keyChargesTempTableAdapter, (IDbConnection) this._keyChargesTempTableAdapter.Connection);
          this._keyChargesTempTableAdapter.Connection = (OleDbConnection) connection;
          this._keyChargesTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._keyChargesTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._keyChargesTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._keyChargesTempTableAdapter.Adapter);
          }
        }
        if (this._lossCardTableAdapter != null)
        {
          dictionary.Add((object) this._lossCardTableAdapter, (IDbConnection) this._lossCardTableAdapter.Connection);
          this._lossCardTableAdapter.Connection = (OleDbConnection) connection;
          this._lossCardTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._lossCardTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._lossCardTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._lossCardTableAdapter.Adapter);
          }
        }
        if (this._mLogTableAdapter != null)
        {
          dictionary.Add((object) this._mLogTableAdapter, (IDbConnection) this._mLogTableAdapter.Connection);
          this._mLogTableAdapter.Connection = (OleDbConnection) connection;
          this._mLogTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._mLogTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._mLogTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._mLogTableAdapter.Adapter);
          }
        }
        if (this._receiptTableAdapter != null)
        {
          dictionary.Add((object) this._receiptTableAdapter, (IDbConnection) this._receiptTableAdapter.Connection);
          this._receiptTableAdapter.Connection = (OleDbConnection) connection;
          this._receiptTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._receiptTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._receiptTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._receiptTableAdapter.Adapter);
          }
        }
        if (this._reservationListTableAdapter != null)
        {
          dictionary.Add((object) this._reservationListTableAdapter, (IDbConnection) this._reservationListTableAdapter.Connection);
          this._reservationListTableAdapter.Connection = (OleDbConnection) connection;
          this._reservationListTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._reservationListTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._reservationListTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._reservationListTableAdapter.Adapter);
          }
        }
        if (this._roomDetailTableAdapter != null)
        {
          dictionary.Add((object) this._roomDetailTableAdapter, (IDbConnection) this._roomDetailTableAdapter.Connection);
          this._roomDetailTableAdapter.Connection = (OleDbConnection) connection;
          this._roomDetailTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomDetailTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomDetailTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomDetailTableAdapter.Adapter);
          }
        }
        if (this._roomHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._roomHistoryTableAdapter, (IDbConnection) this._roomHistoryTableAdapter.Connection);
          this._roomHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._roomHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomHistoryTableAdapter.Adapter);
          }
        }
        if (this._roomInformationTableAdapter != null)
        {
          dictionary.Add((object) this._roomInformationTableAdapter, (IDbConnection) this._roomInformationTableAdapter.Connection);
          this._roomInformationTableAdapter.Connection = (OleDbConnection) connection;
          this._roomInformationTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomInformationTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomInformationTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomInformationTableAdapter.Adapter);
          }
        }
        if (this._roomTypeTempTableAdapter != null)
        {
          dictionary.Add((object) this._roomTypeTempTableAdapter, (IDbConnection) this._roomTypeTempTableAdapter.Connection);
          this._roomTypeTempTableAdapter.Connection = (OleDbConnection) connection;
          this._roomTypeTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._roomTypeTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._roomTypeTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._roomTypeTempTableAdapter.Adapter);
          }
        }
        if (this._staffTempTableAdapter != null)
        {
          dictionary.Add((object) this._staffTempTableAdapter, (IDbConnection) this._staffTempTableAdapter.Connection);
          this._staffTempTableAdapter.Connection = (OleDbConnection) connection;
          this._staffTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._staffTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._staffTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._staffTempTableAdapter.Adapter);
          }
        }
        if (this._systemSetTempTableAdapter != null)
        {
          dictionary.Add((object) this._systemSetTempTableAdapter, (IDbConnection) this._systemSetTempTableAdapter.Connection);
          this._systemSetTempTableAdapter.Connection = (OleDbConnection) connection;
          this._systemSetTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._systemSetTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._systemSetTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._systemSetTempTableAdapter.Adapter);
          }
        }
        if (this._unLockDoorByRoomNoTableAdapter != null)
        {
          dictionary.Add((object) this._unLockDoorByRoomNoTableAdapter, (IDbConnection) this._unLockDoorByRoomNoTableAdapter.Connection);
          this._unLockDoorByRoomNoTableAdapter.Connection = (OleDbConnection) connection;
          this._unLockDoorByRoomNoTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._unLockDoorByRoomNoTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._unLockDoorByRoomNoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._unLockDoorByRoomNoTableAdapter.Adapter);
          }
        }
        if (this._unlockDoorHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._unlockDoorHistoryTableAdapter, (IDbConnection) this._unlockDoorHistoryTableAdapter.Connection);
          this._unlockDoorHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._unlockDoorHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._unlockDoorHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._unlockDoorHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._unlockDoorHistoryTableAdapter.Adapter);
          }
        }
        if (this._uploadDataTableAdapter != null)
        {
          dictionary.Add((object) this._uploadDataTableAdapter, (IDbConnection) this._uploadDataTableAdapter.Connection);
          this._uploadDataTableAdapter.Connection = (OleDbConnection) connection;
          this._uploadDataTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._uploadDataTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._uploadDataTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._uploadDataTableAdapter.Adapter);
          }
        }
        if (this._vacantStatus_TempTableAdapter != null)
        {
          dictionary.Add((object) this._vacantStatus_TempTableAdapter, (IDbConnection) this._vacantStatus_TempTableAdapter.Connection);
          this._vacantStatus_TempTableAdapter.Connection = (OleDbConnection) connection;
          this._vacantStatus_TempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._vacantStatus_TempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._vacantStatus_TempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._vacantStatus_TempTableAdapter.Adapter);
          }
        }
        if (this._zoneTempTableAdapter != null)
        {
          dictionary.Add((object) this._zoneTempTableAdapter, (IDbConnection) this._zoneTempTableAdapter.Connection);
          this._zoneTempTableAdapter.Connection = (OleDbConnection) connection;
          this._zoneTempTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._zoneTempTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._zoneTempTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._zoneTempTableAdapter.Adapter);
          }
        }
        if (this._accIssuedCardHistoryTableAdapter != null)
        {
          dictionary.Add((object) this._accIssuedCardHistoryTableAdapter, (IDbConnection) this._accIssuedCardHistoryTableAdapter.Connection);
          this._accIssuedCardHistoryTableAdapter.Connection = (OleDbConnection) connection;
          this._accIssuedCardHistoryTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._accIssuedCardHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._accIssuedCardHistoryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._accIssuedCardHistoryTableAdapter.Adapter);
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
        if (this._accBonusEntitleListTableAdapter != null)
        {
          this._accBonusEntitleListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accBonusEntitleListTableAdapter];
          this._accBonusEntitleListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accCurrentGByFloorNoTableAdapter != null)
        {
          this._accCurrentGByFloorNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accCurrentGByFloorNoTableAdapter];
          this._accCurrentGByFloorNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accCurrentGInfoTableAdapter != null)
        {
          this._accCurrentGInfoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accCurrentGInfoTableAdapter];
          this._accCurrentGInfoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accErrorRecordsTableAdapter != null)
        {
          this._accErrorRecordsTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accErrorRecordsTableAdapter];
          this._accErrorRecordsTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accExtraTableAdapter != null)
        {
          this._accExtraTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accExtraTableAdapter];
          this._accExtraTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGInfo_TempTableAdapter != null)
        {
          this._accGInfo_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGInfo_TempTableAdapter];
          this._accGInfo_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGracePeriodListTableAdapter != null)
        {
          this._accGracePeriodListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGracePeriodListTableAdapter];
          this._accGracePeriodListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGuestAccountTableAdapter != null)
        {
          this._accGuestAccountTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGuestAccountTableAdapter];
          this._accGuestAccountTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGuestHistoryTableAdapter != null)
        {
          this._accGuestHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGuestHistoryTableAdapter];
          this._accGuestHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGuestListTableAdapter != null)
        {
          this._accGuestListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGuestListTableAdapter];
          this._accGuestListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accGuestRecordDateTableAdapter != null)
        {
          this._accGuestRecordDateTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accGuestRecordDateTableAdapter];
          this._accGuestRecordDateTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accReservationListTableAdapter != null)
        {
          this._accReservationListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accReservationListTableAdapter];
          this._accReservationListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accRoomDetailTableAdapter != null)
        {
          this._accRoomDetailTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accRoomDetailTableAdapter];
          this._accRoomDetailTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accRoomInformationTableAdapter != null)
        {
          this._accRoomInformationTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accRoomInformationTableAdapter];
          this._accRoomInformationTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accSalesTableAdapter != null)
        {
          this._accSalesTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accSalesTableAdapter];
          this._accSalesTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accTransTableAdapter != null)
        {
          this._accTransTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accTransTableAdapter];
          this._accTransTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._availableRoom_TempTableAdapter != null)
        {
          this._availableRoom_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._availableRoom_TempTableAdapter];
          this._availableRoom_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._banking_TempTableAdapter != null)
        {
          this._banking_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._banking_TempTableAdapter];
          this._banking_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonusEntitleListTableAdapter != null)
        {
          this._bonusEntitleListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonusEntitleListTableAdapter];
          this._bonusEntitleListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._bonusTempTableAdapter != null)
        {
          this._bonusTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._bonusTempTableAdapter];
          this._bonusTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._checkRoom_TempTableAdapter != null)
        {
          this._checkRoom_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._checkRoom_TempTableAdapter];
          this._checkRoom_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._currentGByFloorNoTableAdapter != null)
        {
          this._currentGByFloorNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._currentGByFloorNoTableAdapter];
          this._currentGByFloorNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._currentGInfoTableAdapter != null)
        {
          this._currentGInfoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._currentGInfoTableAdapter];
          this._currentGInfoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._detailGuestIssuedTableAdapter != null)
        {
          this._detailGuestIssuedTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._detailGuestIssuedTableAdapter];
          this._detailGuestIssuedTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._displayRooms_TempTableAdapter != null)
        {
          this._displayRooms_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._displayRooms_TempTableAdapter];
          this._displayRooms_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._dLogTableAdapter != null)
        {
          this._dLogTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._dLogTableAdapter];
          this._dLogTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._dTransactionsTableAdapter != null)
        {
          this._dTransactionsTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._dTransactionsTableAdapter];
          this._dTransactionsTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._errorRecordsTableAdapter != null)
        {
          this._errorRecordsTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._errorRecordsTableAdapter];
          this._errorRecordsTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._extraTableAdapter != null)
        {
          this._extraTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._extraTableAdapter];
          this._extraTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._extraCardTableAdapter != null)
        {
          this._extraCardTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._extraCardTableAdapter];
          this._extraCardTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._extraCharge_TempTableAdapter != null)
        {
          this._extraCharge_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._extraCharge_TempTableAdapter];
          this._extraCharge_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gData_TempTableAdapter != null)
        {
          this._gData_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gData_TempTableAdapter];
          this._gData_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gDSalesTableAdapter != null)
        {
          this._gDSalesTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gDSalesTableAdapter];
          this._gDSalesTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gInfo_TempTableAdapter != null)
        {
          this._gInfo_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gInfo_TempTableAdapter];
          this._gInfo_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gracePeriodListTableAdapter != null)
        {
          this._gracePeriodListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gracePeriodListTableAdapter];
          this._gracePeriodListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gTransactions_TempTableAdapter != null)
        {
          this._gTransactions_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gTransactions_TempTableAdapter];
          this._gTransactions_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestAccountTableAdapter != null)
        {
          this._guestAccountTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestAccountTableAdapter];
          this._guestAccountTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestHistoryTableAdapter != null)
        {
          this._guestHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestHistoryTableAdapter];
          this._guestHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestIssuedByBldNoTableAdapter != null)
        {
          this._guestIssuedByBldNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestIssuedByBldNoTableAdapter];
          this._guestIssuedByBldNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestIssuedByFloorNoTableAdapter != null)
        {
          this._guestIssuedByFloorNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestIssuedByFloorNoTableAdapter];
          this._guestIssuedByFloorNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestIssuedByGuestIDTableAdapter != null)
        {
          this._guestIssuedByGuestIDTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestIssuedByGuestIDTableAdapter];
          this._guestIssuedByGuestIDTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestIssuedByRoomNoTableAdapter != null)
        {
          this._guestIssuedByRoomNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestIssuedByRoomNoTableAdapter];
          this._guestIssuedByRoomNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestListTableAdapter != null)
        {
          this._guestListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestListTableAdapter];
          this._guestListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._guestRecordDateTableAdapter != null)
        {
          this._guestRecordDateTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._guestRecordDateTableAdapter];
          this._guestRecordDateTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._gViewRoom_TempTableAdapter != null)
        {
          this._gViewRoom_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._gViewRoom_TempTableAdapter];
          this._gViewRoom_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._issueCardHistoryTableAdapter != null)
        {
          this._issueCardHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._issueCardHistoryTableAdapter];
          this._issueCardHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._keyChargesTempTableAdapter != null)
        {
          this._keyChargesTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._keyChargesTempTableAdapter];
          this._keyChargesTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._lossCardTableAdapter != null)
        {
          this._lossCardTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._lossCardTableAdapter];
          this._lossCardTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._mLogTableAdapter != null)
        {
          this._mLogTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._mLogTableAdapter];
          this._mLogTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._receiptTableAdapter != null)
        {
          this._receiptTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._receiptTableAdapter];
          this._receiptTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._reservationListTableAdapter != null)
        {
          this._reservationListTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._reservationListTableAdapter];
          this._reservationListTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomDetailTableAdapter != null)
        {
          this._roomDetailTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomDetailTableAdapter];
          this._roomDetailTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomHistoryTableAdapter != null)
        {
          this._roomHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomHistoryTableAdapter];
          this._roomHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomInformationTableAdapter != null)
        {
          this._roomInformationTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomInformationTableAdapter];
          this._roomInformationTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._roomTypeTempTableAdapter != null)
        {
          this._roomTypeTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._roomTypeTempTableAdapter];
          this._roomTypeTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._staffTempTableAdapter != null)
        {
          this._staffTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._staffTempTableAdapter];
          this._staffTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._systemSetTempTableAdapter != null)
        {
          this._systemSetTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._systemSetTempTableAdapter];
          this._systemSetTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._unLockDoorByRoomNoTableAdapter != null)
        {
          this._unLockDoorByRoomNoTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._unLockDoorByRoomNoTableAdapter];
          this._unLockDoorByRoomNoTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._unlockDoorHistoryTableAdapter != null)
        {
          this._unlockDoorHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._unlockDoorHistoryTableAdapter];
          this._unlockDoorHistoryTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._uploadDataTableAdapter != null)
        {
          this._uploadDataTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._uploadDataTableAdapter];
          this._uploadDataTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._vacantStatus_TempTableAdapter != null)
        {
          this._vacantStatus_TempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._vacantStatus_TempTableAdapter];
          this._vacantStatus_TempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._zoneTempTableAdapter != null)
        {
          this._zoneTempTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._zoneTempTableAdapter];
          this._zoneTempTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (this._accIssuedCardHistoryTableAdapter != null)
        {
          this._accIssuedCardHistoryTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._accIssuedCardHistoryTableAdapter];
          this._accIssuedCardHistoryTableAdapter.Transaction = (OleDbTransaction) null;
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
