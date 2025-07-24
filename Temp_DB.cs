// Decompiled with JetBrains decompiler
// Type: AMS.Temp_DB
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.TempDataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class Temp_DB
  {
    public TempDataSet tempDataSet;
    public AccBonusEntitleListTableAdapter accBonusEntitleListTableAdapter;
    public AccCurrentGByFloorNoTableAdapter accCurrentGByFloorNoTableAdapter;
    public AccCurrentGInfoTableAdapter accCurrentGInfoTableAdapter;
    public AccErrorRecordsTableAdapter accErrorRecordsTableAdapter;
    public AccExtraTableAdapter accExtraTableAdapter;
    public AccGInfo_TempTableAdapter accGInfo_TempTableAdapter;
    public AccGracePeriodListTableAdapter accGracePeriodListTableAdapter;
    public AccGuestAccountTableAdapter accGuestAccountTableAdapter;
    public AccGuestHistoryTableAdapter accGuestHistoryTableAdapter;
    public AccGuestListTableAdapter accGuestListTableAdapter;
    public AccGuestRecordDateTableAdapter accGuestRecordDateTableAdapter;
    public AccIssuedCardHistoryTableAdapter accIssuedCardHistoryTableAdapter;
    public AccReservationListTableAdapter accReservationListTableAdapter;
    public AccRoomDetailTableAdapter accRoomDetailTableAdapter;
    public AccRoomInformationTableAdapter accRoomInformationTableAdapter;
    public AccSalesTableAdapter accSalesTableAdapter;
    public AccTransTableAdapter accTransTableAdapter;
    public AvailableRoom_TempTableAdapter availableRoom_TempTableAdapter;
    public Banking_TempTableAdapter banking_TempTableAdapter;
    public BonusEntitleListTableAdapter bonusEntitleListTableAdapter;
    public BonusTempTableAdapter bonusTempTableAdapter;
    public CheckRoom_TempTableAdapter checkRoom_TempTableAdapter;
    public CurrentGByFloorNoTableAdapter currentGByFloorNoTableAdapter;
    public CurrentGInfoTableAdapter currentGInfoTableAdapter;
    public DetailGuestIssuedTableAdapter detailGuestIssuedTableAdapter;
    public DisplayRooms_TempTableAdapter displayRooms_TempTableAdapter;
    public DLogTableAdapter dLogTableAdapter;
    public DTransactionsTableAdapter dTransactionsTableAdapter;
    public ErrorRecordsTableAdapter errorRecordsTableAdapter;
    public ExtraCardTableAdapter extraCardTableAdapter;
    public ExtraCharge_TempTableAdapter extraCharge_TempTableAdapter;
    public ExtraTableAdapter extraTableAdapter;
    public GData_TempTableAdapter gData_TempTableAdapter;
    public GDSalesTableAdapter gDSalesTableAdapter;
    public GInfo_TempTableAdapter gInfo_TempTableAdapter;
    public GracePeriodListTableAdapter gracePeriodListTableAdapter;
    public GTransactions_TempTableAdapter gTransactions_TempTableAdapter;
    public GuestAccountTableAdapter guestAccountTableAdapter;
    public GuestHistoryTableAdapter guestHistoryTableAdapter;
    public GuestIssuedByBldNoTableAdapter guestIssuedByBldNoTableAdapter;
    public GuestIssuedByFloorNoTableAdapter guestIssuedByFloorNoTableAdapter;
    public GuestIssuedByGuestIDTableAdapter guestIssuedByGuestIDTableAdapter;
    public GuestIssuedByRoomNoTableAdapter guestIssuedByRoomNoTableAdapter;
    public GuestListTableAdapter guestListTableAdapter;
    public GuestRecordDateTableAdapter guestRecordDateTableAdapter;
    public GViewRoom_TempTableAdapter gViewRoom_TempTableAdapter;
    public IssueCardHistoryTableAdapter issueCardHistoryTableAdapter;
    public KeyChargesTempTableAdapter keyChargesTempTableAdapter;
    public LossCardTableAdapter lossCardTableAdapter;
    public MLogTableAdapter mLogTableAdapter;
    public ReceiptTableAdapter receiptTableAdapter;
    public ReservationListTableAdapter reservationListTableAdapter;
    public RoomDetailTableAdapter roomDetailTableAdapter;
    public RoomHistoryTableAdapter roomHistoryTableAdapter;
    public RoomInformationTableAdapter roomInformationTableAdapter;
    public RoomTypeTempTableAdapter roomTypeTempTableAdapter;
    public StaffTempTableAdapter staffTempTableAdapter;
    public SystemSetTempTableAdapter systemSetTempTableAdapter;
    public TableAdapterManager tableAdapterManager;
    public UnLockDoorByRoomNoTableAdapter unLockDoorByRoomNoTableAdapter;
    public UnlockDoorHistoryTableAdapter unlockDoorHistoryTableAdapter;
    public UploadDataTableAdapter uploadDataTableAdapter;
    public VacantStatus_TempTableAdapter vacantStatus_TempTableAdapter;
    public ZoneTempTableAdapter zoneTempTableAdapter;

    public Temp_DB()
    {
      this.tempDataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet;
      this.accBonusEntitleListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accBonusEntitleListTableAdapter;
      this.accCurrentGByFloorNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accCurrentGByFloorNoTableAdapter;
      this.accCurrentGInfoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accCurrentGInfoTableAdapter;
      this.accErrorRecordsTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accErrorRecordsTableAdapter;
      this.accExtraTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accExtraTableAdapter;
      this.accGInfo_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGInfo_TempTableAdapter;
      this.accGracePeriodListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGracePeriodListTableAdapter;
      this.accGuestAccountTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestAccountTableAdapter;
      this.accGuestHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestHistoryTableAdapter;
      this.accGuestListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestListTableAdapter;
      this.accGuestRecordDateTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accGuestRecordDateTableAdapter;
      this.accIssuedCardHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accIssuedCardHistoryTableAdapter;
      this.accReservationListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accReservationListTableAdapter;
      this.accRoomDetailTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accRoomDetailTableAdapter;
      this.accRoomInformationTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accRoomInformationTableAdapter;
      this.accSalesTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accSalesTableAdapter;
      this.accTransTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.accTransTableAdapter;
      this.availableRoom_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.availableRoom_TempTableAdapter;
      this.banking_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.banking_TempTableAdapter;
      this.bonusEntitleListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bonusEntitleListTableAdapter;
      this.bonusTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bonusTempTableAdapter;
      this.checkRoom_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.checkRoom_TempTableAdapter;
      this.currentGByFloorNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGByFloorNoTableAdapter;
      this.currentGInfoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.currentGInfoTableAdapter;
      this.detailGuestIssuedTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.detailGuestIssuedTableAdapter;
      this.displayRooms_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.displayRooms_TempTableAdapter;
      this.dLogTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dLogTableAdapter;
      this.dTransactionsTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter;
      this.errorRecordsTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.errorRecordsTableAdapter;
      this.extraCardTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraCardTableAdapter;
      this.extraCharge_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraCharge_TempTableAdapter;
      this.extraTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraTableAdapter;
      this.gData_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gData_TempTableAdapter;
      this.gDSalesTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDSalesTableAdapter;
      this.gInfo_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gInfo_TempTableAdapter;
      this.gracePeriodListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gracePeriodListTableAdapter;
      this.gTransactions_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gTransactions_TempTableAdapter;
      this.guestAccountTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestAccountTableAdapter;
      this.guestHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestHistoryTableAdapter;
      this.guestIssuedByBldNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByBldNoTableAdapter;
      this.guestIssuedByFloorNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByFloorNoTableAdapter;
      this.guestIssuedByGuestIDTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByGuestIDTableAdapter;
      this.guestIssuedByRoomNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestIssuedByRoomNoTableAdapter;
      this.guestListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestListTableAdapter;
      this.guestRecordDateTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.guestRecordDateTableAdapter;
      this.gViewRoom_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gViewRoom_TempTableAdapter;
      this.issueCardHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.issueCardHistoryTableAdapter;
      this.keyChargesTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.keyChargesTempTableAdapter;
      this.lossCardTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.lossCardTableAdapter;
      this.mLogTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.mLogTableAdapter;
      this.receiptTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.receiptTableAdapter;
      this.reservationListTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.reservationListTableAdapter;
      this.roomDetailTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomDetailTableAdapter;
      this.roomHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomHistoryTableAdapter;
      this.roomInformationTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomInformationTableAdapter;
      this.roomTypeTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomTypeTempTableAdapter;
      this.staffTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.staffTempTableAdapter;
      this.systemSetTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.systemSetTempTableAdapter;
      this.tableAdapterManager = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tableAdapterManager;
      this.unLockDoorByRoomNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.unLockDoorByRoomNoTableAdapter;
      this.unlockDoorHistoryTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.unlockDoorHistoryTableAdapter;
      this.uploadDataTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.uploadDataTableAdapter;
      this.vacantStatus_TempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.vacantStatus_TempTableAdapter;
      this.zoneTempTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.zoneTempTableAdapter;
    }
  }
}
