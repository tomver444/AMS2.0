// Decompiled with JetBrains decompiler
// Type: AMS.ModDoorLockSystem_Object
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.BankingDBDataSetTableAdapters;
using AMS.BuildingDB1DataSetTableAdapters;
using AMS.ErradjustDBDataSetTableAdapters;
using AMS.ReplacementDB1DataSetTableAdapters;
using AMS.StaffDataSetTableAdapters;
using AMS.SystemDataSetTableAdapters;
using AMS.TempDataSetTableAdapters;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class ModDoorLockSystem_Object
  {
    public bool bCurrent;
    public bool bTimeChecking;
    public bool bDate;
    public bool bReader;
    public bool bAdmin;
    public bool bAdminOnly;
    public bool bVacantDateCheckFlag;
    public string gSelectBld;
    public string sBldNo;
    public string gsTimeGap;
    public bool bReservedDataOK;
    public string gsReserveType = "";
    public string gsOldReserveType = "";
    public string gsUnitNo = "";
    public string gsRoomNo = "";
    public bool bWholeUnit;
    public bool bUnitFlag;
    public bool bUnitClientEdit;
    public string gsCondition = "";
    public string sCharge = "";
    public string giKeyDeposit = "";
    public string giExtraKeyCharge = "";
    public string gGST = "0.00";
    public string gConstantGST = "0.00";
    public string gGSTPercent = "0.00";
    public string gSystemID = "";
    public string gDescription = "";
    public int giMGraceDefault;
    public int giWGraceDefault;
    public int giDGraceDefault;
    public string gBuildingNo = "";
    public string gAccessBuildingNo = "";
    public string gBuildingName = "";
    public string gsComPort = "";
    public uint iRoomNo;
    public uint iBrowser;
    public uint iGuest;
    public bool bClientDataFlag;
    public bool bCompactFlag;
    public bool bSystemSetting;
    public bool bViewOKFlg;
    public bool bNewEdit;
    public string[] sExAmount;
    public string[] sExDesc;
    public string sReceiptID = "";
    public bool gBonus;
    public string gsMStayType = "";
    public string gsWStayType = "";
    public string gsMBonusType = "";
    public string gsWBonusType = "";
    public string giMTotalStay = "";
    public string giMBonusLength = "";
    public string giWTotalStay = "";
    public string giWBonusLength = "";
    public string gsMBonusStart = "";
    public string gsWBonusStart = "";
    public string gDisableBonusDate = "";
    public string gStartDate;
    public string gEndDate;
    public string gsStartday;
    public string gsEndday;
    public string gsStartmonth;
    public string gsStartyear;
    public string gsEndmonth;
    public string gsEndyear;
    public string gBookingStart;
    public string gBookingEnd;
    public string sStartDateSubtract;
    public string sEndDateAdd;
    public string gsClientID;
    public string gsClientName1;
    public string gsClientName2;
    public string gs1;
    public string gs2;
    public string gs3;
    public string gsTempDB;
    public string gsTempDBS;
    public string gsMainDB;
    public string gsResDB;
    public string gsTrackDB;
    public string sCardSerialNo;
    public string iTrackTransID;
    public string iRefNo;
    public string sTrackingFile;
    public string sTrackingFile1;
    public string sTrackingFile2;
    public string sTrackingFile3;
    public string sTrackingFile4;
    public string sTrackingFile5;
    public string sTrackingFile6;
    public string gFORENAME;
    public string gSURNAME;
    public string gUSERID;
    public string gACCLEVEL;
    public string gPASSWORD;
    public string gAccBuilding;
    public string gAccBuilding1;
    public string gAccBuilding2;
    public string gAccBuilding3;
    public string gAccBuilding4;
    public string gAccBuilding5;
    public string gAccBuilding6;
    public string gsStaffDB;
    public string myUser;
    public string myPass;
    public string myAccLevel;
    public string plaintext;
    public string strtemp;
    public int iDifference;
    public int sBuffCont;
    public int iErrCount;
    public string gsMachineID;
    public string gdbPassword;
    public bool bTYPE;
    public bool bSystemMode;
    public string sLoginFile;
    public string sBackDoorFile;
    public string sSourceDataFile;
    public string sTargetFile;
    public string sCompactFile;
    public string Bakfilename;
    public string sTargetBakFile;
    public string TargetPathBak;
    public string BackDoorPath;
    public string gsReportDB;
    public int iType;
    public string dbName;
    public string dbName1;
    public string sActiveDB;
    public string sActiveDB1;
    public string sActiveDB2;
    public string sActiveDB3;
    public string sActiveDB4;
    public string sActiveDB5;
    public string sActiveDB6;
    public string gOwnerID;
    public bool bBonusAlready;
    public bool bTracking;
    private IContainer components;
    public TempDataSet tempDataSet;
    public BindingSource availableRoomTempBindingSource;
    public BindingSource checkRoomTempBindingSource;
    public BindingSource displayRoomsTempBindingSource;
    public BindingSource gInfoTempBindingSource;
    public BindingSource receiptBindingSource;
    public BindingSource vacantStatusTempBindingSource;
    public BindingSource reservationListBindingSource;
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
    public AMS.TempDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    public UnLockDoorByRoomNoTableAdapter unLockDoorByRoomNoTableAdapter;
    public UnlockDoorHistoryTableAdapter unlockDoorHistoryTableAdapter;
    public UploadDataTableAdapter uploadDataTableAdapter;
    public VacantStatus_TempTableAdapter vacantStatus_TempTableAdapter;
    public ZoneTempTableAdapter zoneTempTableAdapter;
    public SystemDataSet systemDataSet;
    public BindingSource countryBindingSource;
    public CountryTableAdapter countryTableAdapter;
    public BindingSource roomTypeBindingSource;
    public RoomTypeTableAdapter roomTypeTableAdapter;
    public BindingSource bonusBindingSource;
    public BonusTableAdapter bonusTableAdapter;
    public BindingSource bonus1BindingSource;
    public Bonus1TableAdapter bonus1TableAdapter;
    public Bonus2TableAdapter bonus2TableAdapter;
    public Bonus3TableAdapter bonus3TableAdapter;
    public Bonus4TableAdapter bonus4TableAdapter;
    public Bonus5TableAdapter bonus5TableAdapter;
    public Bonus6TableAdapter bonus6TableAdapter;
    public BindingSource buildingBindingSource;
    public BuildingTableAdapter buildingTableAdapter;
    public BindingSource floorBindingSource;
    public FloorTableAdapter floorTableAdapter;
    public BindingSource gSTHistoryBindingSource;
    public GSTHistoryTableAdapter gSTHistoryTableAdapter;
    public BindingSource gSTHistory1BindingSource;
    public GSTHistory1TableAdapter gSTHistory1TableAdapter;
    public GSTHistory2TableAdapter gSTHistory2TableAdapter;
    public GSTHistory3TableAdapter gSTHistory3TableAdapter;
    public GSTHistory4TableAdapter gSTHistory4TableAdapter;
    public GSTHistory5TableAdapter gSTHistory5TableAdapter;
    public GSTHistory6TableAdapter gSTHistory6TableAdapter;
    public BindingSource roomBindingSource;
    public RoomTableAdapter roomTableAdapter;
    public BindingSource roomStatus1BindingSource;
    public RoomStatus1TableAdapter roomStatus1TableAdapter;
    public RoomStatus2TableAdapter roomStatus2TableAdapter;
    public RoomStatus3TableAdapter roomStatus3TableAdapter;
    public RoomStatus4TableAdapter roomStatus4TableAdapter;
    public RoomStatus5TableAdapter roomStatus5TableAdapter;
    public RoomStatus6TableAdapter roomStatus6TableAdapter;
    public BindingSource systemSetBindingSource;
    public SystemSetTableAdapter systemSetTableAdapter;
    public BindingSource systemSet1BindingSource;
    public SystemSet1TableAdapter systemSet1TableAdapter;
    public BindingSource systemSet2BindingSource;
    public SystemSet2TableAdapter systemSet2TableAdapter;
    public BindingSource systemSet3BindingSource;
    public SystemSet3TableAdapter systemSet3TableAdapter;
    public BindingSource systemSet4BindingSource;
    public SystemSet4TableAdapter systemSet4TableAdapter;
    public BindingSource systemSet5BindingSource;
    public SystemSet5TableAdapter systemSet5TableAdapter;
    public BindingSource systemSet6BindingSource;
    public SystemSet6TableAdapter systemSet6TableAdapter;
    public BindingSource zoneBindingSource;
    public ZoneTableAdapter zoneTableAdapter;
    public BuildingDB1DataSet buildingDB1DataSet;
    public BindingSource cardTransBindingSource;
    public CardTransTableAdapter cardTransTableAdapter;
    public BindingSource cardNoBindingSource;
    public CardNoTableAdapter cardNoTableAdapter;
    public BindingSource clientBindingSource;
    public ClientTableAdapter clientTableAdapter;
    public BindingSource clientAccBindingSource;
    public ClientAccTableAdapter clientAccTableAdapter;
    public BindingSource allLockedRecordBindingSource;
    public AllLockedRecordTableAdapter allLockedRecordTableAdapter;
    public BindingSource eventLogBindingSource;
    public EventLogTableAdapter eventLogTableAdapter;
    public BindingSource extraChargeBindingSource;
    public ExtraChargeTableAdapter extraChargeTableAdapter;
    public BindingSource keyChargesBindingSource;
    public KeyChargesTableAdapter keyChargesTableAdapter;
    public BindingSource lastTransBindingSource;
    public LastTransTableAdapter lastTransTableAdapter;
    public BindingSource lockedRecordBindingSource;
    public LockedRecordTableAdapter lockedRecordTableAdapter;
    public BindingSource logInOutBindingSource;
    public LogInOutTableAdapter logInOutTableAdapter;
    public BindingSource reserveBindingSource;
    public ReserveTableAdapter reserveTableAdapter;
    public BindingSource roomStatusBindingSource;
    public RoomStatusTableAdapter roomStatusTableAdapter;
    public BindingSource unitRefBindingSource;
    public UnitRefTableAdapter unitRefTableAdapter;
    public BankingDBDataSet bankingDBDataSet;
    public BankingTableAdapter bankingTableAdapter;
    public ErradjustDBDataSet erradjustDBDataSet;
    public ErradjustTableAdapter erradjustTableAdapter;
    public OleDbCommand Local_Command;
    public StaffDataSet staffDataSet;
    public BindingSource staffBindingSource;
    public StaffTableAdapter staffTableAdapter;
    public BindingSource accReservationListBindingSource;
    public ReplacementDB1DataSet replacementDB1DataSet;
    public BindingSource replacementBindingSource;
    public ReplacementTableAdapter replacementTableAdapter;

    public ModDoorLockSystem_Object()
    {
      this.InitializeComponent();
      this.sExAmount = new string[5];
      this.sExDesc = new string[5];
      this.Local_Command = new OleDbCommand();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.tempDataSet = new TempDataSet();
      this.accBonusEntitleListTableAdapter = new AccBonusEntitleListTableAdapter();
      this.accCurrentGByFloorNoTableAdapter = new AccCurrentGByFloorNoTableAdapter();
      this.accCurrentGInfoTableAdapter = new AccCurrentGInfoTableAdapter();
      this.accErrorRecordsTableAdapter = new AccErrorRecordsTableAdapter();
      this.accExtraTableAdapter = new AccExtraTableAdapter();
      this.accGInfo_TempTableAdapter = new AccGInfo_TempTableAdapter();
      this.accGracePeriodListTableAdapter = new AccGracePeriodListTableAdapter();
      this.accGuestAccountTableAdapter = new AccGuestAccountTableAdapter();
      this.accGuestHistoryTableAdapter = new AccGuestHistoryTableAdapter();
      this.accGuestListTableAdapter = new AccGuestListTableAdapter();
      this.accGuestRecordDateTableAdapter = new AccGuestRecordDateTableAdapter();
      this.accIssuedCardHistoryTableAdapter = new AccIssuedCardHistoryTableAdapter();
      this.accReservationListTableAdapter = new AccReservationListTableAdapter();
      this.accRoomDetailTableAdapter = new AccRoomDetailTableAdapter();
      this.accRoomInformationTableAdapter = new AccRoomInformationTableAdapter();
      this.accSalesTableAdapter = new AccSalesTableAdapter();
      this.accTransTableAdapter = new AccTransTableAdapter();
      this.availableRoom_TempTableAdapter = new AvailableRoom_TempTableAdapter();
      this.banking_TempTableAdapter = new Banking_TempTableAdapter();
      this.bonusEntitleListTableAdapter = new BonusEntitleListTableAdapter();
      this.bonusTempTableAdapter = new BonusTempTableAdapter();
      this.checkRoom_TempTableAdapter = new CheckRoom_TempTableAdapter();
      this.currentGByFloorNoTableAdapter = new CurrentGByFloorNoTableAdapter();
      this.currentGInfoTableAdapter = new CurrentGInfoTableAdapter();
      this.detailGuestIssuedTableAdapter = new DetailGuestIssuedTableAdapter();
      this.displayRooms_TempTableAdapter = new DisplayRooms_TempTableAdapter();
      this.dLogTableAdapter = new DLogTableAdapter();
      this.dTransactionsTableAdapter = new DTransactionsTableAdapter();
      this.errorRecordsTableAdapter = new ErrorRecordsTableAdapter();
      this.extraCardTableAdapter = new ExtraCardTableAdapter();
      this.extraCharge_TempTableAdapter = new ExtraCharge_TempTableAdapter();
      this.extraTableAdapter = new ExtraTableAdapter();
      this.gData_TempTableAdapter = new GData_TempTableAdapter();
      this.gDSalesTableAdapter = new GDSalesTableAdapter();
      this.gInfo_TempTableAdapter = new GInfo_TempTableAdapter();
      this.gracePeriodListTableAdapter = new GracePeriodListTableAdapter();
      this.gTransactions_TempTableAdapter = new GTransactions_TempTableAdapter();
      this.guestAccountTableAdapter = new GuestAccountTableAdapter();
      this.guestHistoryTableAdapter = new GuestHistoryTableAdapter();
      this.guestIssuedByBldNoTableAdapter = new GuestIssuedByBldNoTableAdapter();
      this.guestIssuedByFloorNoTableAdapter = new GuestIssuedByFloorNoTableAdapter();
      this.guestIssuedByGuestIDTableAdapter = new GuestIssuedByGuestIDTableAdapter();
      this.guestIssuedByRoomNoTableAdapter = new GuestIssuedByRoomNoTableAdapter();
      this.guestListTableAdapter = new GuestListTableAdapter();
      this.guestRecordDateTableAdapter = new GuestRecordDateTableAdapter();
      this.gViewRoom_TempTableAdapter = new GViewRoom_TempTableAdapter();
      this.issueCardHistoryTableAdapter = new IssueCardHistoryTableAdapter();
      this.keyChargesTempTableAdapter = new KeyChargesTempTableAdapter();
      this.lossCardTableAdapter = new LossCardTableAdapter();
      this.mLogTableAdapter = new MLogTableAdapter();
      this.receiptTableAdapter = new ReceiptTableAdapter();
      this.reservationListTableAdapter = new ReservationListTableAdapter();
      this.roomDetailTableAdapter = new RoomDetailTableAdapter();
      this.roomHistoryTableAdapter = new RoomHistoryTableAdapter();
      this.roomInformationTableAdapter = new RoomInformationTableAdapter();
      this.roomTypeTempTableAdapter = new RoomTypeTempTableAdapter();
      this.staffTempTableAdapter = new StaffTempTableAdapter();
      this.systemSetTempTableAdapter = new SystemSetTempTableAdapter();
      this.tableAdapterManager = new AMS.TempDataSetTableAdapters.TableAdapterManager();
      this.unLockDoorByRoomNoTableAdapter = new UnLockDoorByRoomNoTableAdapter();
      this.unlockDoorHistoryTableAdapter = new UnlockDoorHistoryTableAdapter();
      this.uploadDataTableAdapter = new UploadDataTableAdapter();
      this.vacantStatus_TempTableAdapter = new VacantStatus_TempTableAdapter();
      this.zoneTempTableAdapter = new ZoneTempTableAdapter();
      this.availableRoomTempBindingSource = new BindingSource(this.components);
      this.checkRoomTempBindingSource = new BindingSource(this.components);
      this.displayRoomsTempBindingSource = new BindingSource(this.components);
      this.gInfoTempBindingSource = new BindingSource(this.components);
      this.receiptBindingSource = new BindingSource(this.components);
      this.vacantStatusTempBindingSource = new BindingSource(this.components);
      this.tempDataSet.BeginInit();
      ((ISupportInitialize) this.availableRoomTempBindingSource).BeginInit();
      ((ISupportInitialize) this.checkRoomTempBindingSource).BeginInit();
      ((ISupportInitialize) this.displayRoomsTempBindingSource).BeginInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).BeginInit();
      ((ISupportInitialize) this.receiptBindingSource).BeginInit();
      ((ISupportInitialize) this.vacantStatusTempBindingSource).BeginInit();
      this.tempDataSet.DataSetName = "TempDataSet";
      this.tempDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dTransactionsTableAdapter.ClearBeforeFill = true;
      this.availableRoomTempBindingSource.DataMember = "AvailableRoom_Temp";
      this.availableRoomTempBindingSource.DataSource = (object) this.tempDataSet;
      this.availableRoom_TempTableAdapter.ClearBeforeFill = true;
      this.checkRoomTempBindingSource.DataMember = "CheckRoom_Temp";
      this.checkRoomTempBindingSource.DataSource = (object) this.tempDataSet;
      this.checkRoom_TempTableAdapter.ClearBeforeFill = true;
      this.displayRoomsTempBindingSource.DataMember = "DisplayRooms_Temp";
      this.displayRoomsTempBindingSource.DataSource = (object) this.tempDataSet;
      this.displayRooms_TempTableAdapter.ClearBeforeFill = true;
      this.gInfoTempBindingSource.DataMember = "GInfo_Temp";
      this.gInfoTempBindingSource.DataSource = (object) this.tempDataSet;
      this.gInfo_TempTableAdapter.ClearBeforeFill = true;
      this.receiptBindingSource.DataMember = "Receipt";
      this.receiptBindingSource.DataSource = (object) this.tempDataSet;
      this.receiptTableAdapter.ClearBeforeFill = true;
      this.vacantStatusTempBindingSource.DataMember = "VacantStatus_Temp";
      this.vacantStatusTempBindingSource.DataSource = (object) this.tempDataSet;
      this.vacantStatus_TempTableAdapter.ClearBeforeFill = true;
      this.tempDataSet.EndInit();
      ((ISupportInitialize) this.availableRoomTempBindingSource).EndInit();
      ((ISupportInitialize) this.checkRoomTempBindingSource).EndInit();
      ((ISupportInitialize) this.displayRoomsTempBindingSource).EndInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).EndInit();
      ((ISupportInitialize) this.receiptBindingSource).EndInit();
      ((ISupportInitialize) this.vacantStatusTempBindingSource).EndInit();
      this.reservationListBindingSource = new BindingSource(this.components);
      this.tempDataSet.BeginInit();
      ((ISupportInitialize) this.reservationListBindingSource).BeginInit();
      this.reservationListBindingSource.DataMember = "ReservationList";
      this.reservationListBindingSource.DataSource = (object) this.tempDataSet;
      this.reservationListTableAdapter.ClearBeforeFill = true;
      ((ISupportInitialize) this.reservationListBindingSource).EndInit();
      this.accReservationListBindingSource = new BindingSource(this.components);
      ((ISupportInitialize) this.accReservationListBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.accReservationListBindingSource.DataMember = "AccReservationList";
      this.accReservationListBindingSource.DataSource = (object) this.tempDataSet;
      this.accReservationListTableAdapter.ClearBeforeFill = true;
      ((ISupportInitialize) this.accReservationListBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.systemDataSet = new SystemDataSet();
      this.countryBindingSource = new BindingSource(this.components);
      this.countryTableAdapter = new CountryTableAdapter();
      this.roomTypeBindingSource = new BindingSource(this.components);
      this.roomTypeTableAdapter = new RoomTypeTableAdapter();
      this.bonusBindingSource = new BindingSource(this.components);
      this.bonusTableAdapter = new BonusTableAdapter();
      this.bonus1BindingSource = new BindingSource(this.components);
      this.bonus1TableAdapter = new Bonus1TableAdapter();
      this.bonus2TableAdapter = new Bonus2TableAdapter();
      this.bonus3TableAdapter = new Bonus3TableAdapter();
      this.bonus4TableAdapter = new Bonus4TableAdapter();
      this.bonus5TableAdapter = new Bonus5TableAdapter();
      this.bonus6TableAdapter = new Bonus6TableAdapter();
      this.buildingBindingSource = new BindingSource(this.components);
      this.buildingTableAdapter = new BuildingTableAdapter();
      this.floorBindingSource = new BindingSource(this.components);
      this.floorTableAdapter = new FloorTableAdapter();
      this.gSTHistoryBindingSource = new BindingSource(this.components);
      this.gSTHistoryTableAdapter = new GSTHistoryTableAdapter();
      this.gSTHistory1BindingSource = new BindingSource(this.components);
      this.gSTHistory1TableAdapter = new GSTHistory1TableAdapter();
      this.gSTHistory2TableAdapter = new GSTHistory2TableAdapter();
      this.gSTHistory3TableAdapter = new GSTHistory3TableAdapter();
      this.gSTHistory4TableAdapter = new GSTHistory4TableAdapter();
      this.gSTHistory5TableAdapter = new GSTHistory5TableAdapter();
      this.gSTHistory6TableAdapter = new GSTHistory6TableAdapter();
      this.roomBindingSource = new BindingSource(this.components);
      this.roomTableAdapter = new RoomTableAdapter();
      this.roomStatus1BindingSource = new BindingSource(this.components);
      this.roomStatus1TableAdapter = new RoomStatus1TableAdapter();
      this.roomStatus2TableAdapter = new RoomStatus2TableAdapter();
      this.roomStatus3TableAdapter = new RoomStatus3TableAdapter();
      this.roomStatus4TableAdapter = new RoomStatus4TableAdapter();
      this.roomStatus5TableAdapter = new RoomStatus5TableAdapter();
      this.roomStatus6TableAdapter = new RoomStatus6TableAdapter();
      this.bankingDBDataSet = new BankingDBDataSet();
      this.bankingTableAdapter = new BankingTableAdapter();
      this.bankingDBDataSet.BeginInit();
      this.bankingDBDataSet.DataSetName = "BankingDBDataSet";
      this.bankingDBDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.bankingTableAdapter.ClearBeforeFill = true;
      this.bankingDBDataSet.EndInit();
      this.erradjustDBDataSet = new ErradjustDBDataSet();
      this.erradjustTableAdapter = new ErradjustTableAdapter();
      this.erradjustDBDataSet.BeginInit();
      this.erradjustDBDataSet.DataSetName = "ErradjustDBDataSet";
      this.erradjustDBDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.erradjustTableAdapter.ClearBeforeFill = true;
      this.erradjustDBDataSet.EndInit();
      this.systemSetBindingSource = new BindingSource(this.components);
      this.systemSetTableAdapter = new SystemSetTableAdapter();
      this.systemSet1BindingSource = new BindingSource(this.components);
      this.systemSet1TableAdapter = new SystemSet1TableAdapter();
      this.zoneBindingSource = new BindingSource(this.components);
      this.zoneTableAdapter = new ZoneTableAdapter();
      this.buildingDB1DataSet = new BuildingDB1DataSet();
      this.cardTransBindingSource = new BindingSource(this.components);
      this.cardTransTableAdapter = new CardTransTableAdapter();
      this.cardNoBindingSource = new BindingSource(this.components);
      this.cardNoTableAdapter = new CardNoTableAdapter();
      this.clientBindingSource = new BindingSource(this.components);
      this.clientTableAdapter = new ClientTableAdapter();
      this.clientAccBindingSource = new BindingSource(this.components);
      this.clientAccTableAdapter = new ClientAccTableAdapter();
      this.allLockedRecordBindingSource = new BindingSource(this.components);
      this.allLockedRecordTableAdapter = new AllLockedRecordTableAdapter();
      this.eventLogBindingSource = new BindingSource(this.components);
      this.eventLogTableAdapter = new EventLogTableAdapter();
      this.extraChargeBindingSource = new BindingSource(this.components);
      this.extraChargeTableAdapter = new ExtraChargeTableAdapter();
      this.keyChargesBindingSource = new BindingSource(this.components);
      this.keyChargesTableAdapter = new KeyChargesTableAdapter();
      this.lastTransBindingSource = new BindingSource(this.components);
      this.lastTransTableAdapter = new LastTransTableAdapter();
      this.lockedRecordBindingSource = new BindingSource(this.components);
      this.lockedRecordTableAdapter = new LockedRecordTableAdapter();
      this.logInOutBindingSource = new BindingSource(this.components);
      this.logInOutTableAdapter = new LogInOutTableAdapter();
      this.reserveBindingSource = new BindingSource(this.components);
      this.reserveTableAdapter = new ReserveTableAdapter();
      this.roomStatusBindingSource = new BindingSource(this.components);
      this.roomStatusTableAdapter = new RoomStatusTableAdapter();
      this.unitRefBindingSource = new BindingSource(this.components);
      this.unitRefTableAdapter = new UnitRefTableAdapter();
      this.systemDataSet.BeginInit();
      ((ISupportInitialize) this.countryBindingSource).BeginInit();
      ((ISupportInitialize) this.roomTypeBindingSource).BeginInit();
      ((ISupportInitialize) this.bonusBindingSource).BeginInit();
      ((ISupportInitialize) this.bonus1BindingSource).BeginInit();
      ((ISupportInitialize) this.buildingBindingSource).BeginInit();
      ((ISupportInitialize) this.floorBindingSource).BeginInit();
      ((ISupportInitialize) this.gSTHistoryBindingSource).BeginInit();
      ((ISupportInitialize) this.gSTHistory1BindingSource).BeginInit();
      ((ISupportInitialize) this.roomBindingSource).BeginInit();
      ((ISupportInitialize) this.roomStatus1BindingSource).BeginInit();
      ((ISupportInitialize) this.systemSetBindingSource).BeginInit();
      ((ISupportInitialize) this.systemSet1BindingSource).BeginInit();
      ((ISupportInitialize) this.zoneBindingSource).BeginInit();
      this.buildingDB1DataSet.BeginInit();
      ((ISupportInitialize) this.cardTransBindingSource).BeginInit();
      ((ISupportInitialize) this.cardNoBindingSource).BeginInit();
      ((ISupportInitialize) this.clientBindingSource).BeginInit();
      ((ISupportInitialize) this.clientAccBindingSource).BeginInit();
      ((ISupportInitialize) this.allLockedRecordBindingSource).BeginInit();
      ((ISupportInitialize) this.eventLogBindingSource).BeginInit();
      ((ISupportInitialize) this.extraChargeBindingSource).BeginInit();
      ((ISupportInitialize) this.keyChargesBindingSource).BeginInit();
      ((ISupportInitialize) this.lastTransBindingSource).BeginInit();
      ((ISupportInitialize) this.lockedRecordBindingSource).BeginInit();
      ((ISupportInitialize) this.logInOutBindingSource).BeginInit();
      ((ISupportInitialize) this.reserveBindingSource).BeginInit();
      ((ISupportInitialize) this.roomStatusBindingSource).BeginInit();
      ((ISupportInitialize) this.unitRefBindingSource).BeginInit();
      this.systemDataSet.DataSetName = "SystemDataSet";
      this.systemDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.countryBindingSource.DataMember = "Country";
      this.countryBindingSource.DataSource = (object) this.systemDataSet;
      this.countryTableAdapter.ClearBeforeFill = true;
      this.roomTypeBindingSource.DataMember = "RoomType";
      this.roomTypeBindingSource.DataSource = (object) this.systemDataSet;
      this.roomTypeTableAdapter.ClearBeforeFill = true;
      this.bonusBindingSource.DataMember = "Bonus";
      this.bonusBindingSource.DataSource = (object) this.systemDataSet;
      this.bonusTableAdapter.ClearBeforeFill = true;
      this.bonus1BindingSource.DataMember = "Bonus1";
      this.bonus1BindingSource.DataSource = (object) this.systemDataSet;
      this.bonus1TableAdapter.ClearBeforeFill = true;
      this.bonus2TableAdapter.ClearBeforeFill = true;
      this.bonus3TableAdapter.ClearBeforeFill = true;
      this.bonus4TableAdapter.ClearBeforeFill = true;
      this.bonus5TableAdapter.ClearBeforeFill = true;
      this.bonus6TableAdapter.ClearBeforeFill = true;
      this.buildingBindingSource.DataMember = "Building";
      this.buildingBindingSource.DataSource = (object) this.systemDataSet;
      this.buildingTableAdapter.ClearBeforeFill = true;
      this.floorBindingSource.DataMember = "Floor";
      this.floorBindingSource.DataSource = (object) this.systemDataSet;
      this.floorTableAdapter.ClearBeforeFill = true;
      this.gSTHistoryBindingSource.DataMember = "GSTHistory";
      this.gSTHistoryBindingSource.DataSource = (object) this.systemDataSet;
      this.gSTHistoryTableAdapter.ClearBeforeFill = true;
      this.gSTHistory1BindingSource.DataMember = "GSTHistory1";
      this.gSTHistory1BindingSource.DataSource = (object) this.systemDataSet;
      this.gSTHistory1TableAdapter.ClearBeforeFill = true;
      this.gSTHistory2TableAdapter.ClearBeforeFill = true;
      this.gSTHistory3TableAdapter.ClearBeforeFill = true;
      this.gSTHistory4TableAdapter.ClearBeforeFill = true;
      this.gSTHistory5TableAdapter.ClearBeforeFill = true;
      this.gSTHistory6TableAdapter.ClearBeforeFill = true;
      this.roomBindingSource.DataMember = "Room";
      this.roomBindingSource.DataSource = (object) this.systemDataSet;
      this.roomTableAdapter.ClearBeforeFill = true;
      this.roomStatus1BindingSource.DataMember = "RoomStatus1";
      this.roomStatus1BindingSource.DataSource = (object) this.systemDataSet;
      this.roomStatus1TableAdapter.ClearBeforeFill = true;
      this.roomStatus2TableAdapter.ClearBeforeFill = true;
      this.roomStatus3TableAdapter.ClearBeforeFill = true;
      this.roomStatus4TableAdapter.ClearBeforeFill = true;
      this.roomStatus5TableAdapter.ClearBeforeFill = true;
      this.roomStatus6TableAdapter.ClearBeforeFill = true;
      this.systemSetBindingSource.DataMember = "SystemSet";
      this.systemSetBindingSource.DataSource = (object) this.systemDataSet;
      this.systemSetTableAdapter.ClearBeforeFill = true;
      this.systemSet1BindingSource.DataMember = "SystemSet1";
      this.systemSet1BindingSource.DataSource = (object) this.systemDataSet;
      this.systemSet1TableAdapter.ClearBeforeFill = true;
      this.zoneBindingSource.DataMember = "Zone";
      this.zoneBindingSource.DataSource = (object) this.systemDataSet;
      this.zoneTableAdapter.ClearBeforeFill = true;
      this.buildingDB1DataSet.DataSetName = "BuildingDB1DataSet";
      this.buildingDB1DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.cardTransBindingSource.DataMember = "CardTrans";
      this.cardTransBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.cardTransTableAdapter.ClearBeforeFill = true;
      this.cardNoBindingSource.DataMember = "CardNo";
      this.cardNoBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.cardNoTableAdapter.ClearBeforeFill = true;
      this.clientBindingSource.DataMember = "Client";
      this.clientBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.clientTableAdapter.ClearBeforeFill = true;
      this.clientAccBindingSource.DataMember = "ClientAcc";
      this.clientAccBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.clientAccTableAdapter.ClearBeforeFill = true;
      this.allLockedRecordBindingSource.DataMember = "AllLockedRecord";
      this.allLockedRecordBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.allLockedRecordTableAdapter.ClearBeforeFill = true;
      this.eventLogBindingSource.DataMember = "EventLog";
      this.eventLogBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.eventLogTableAdapter.ClearBeforeFill = true;
      this.extraChargeBindingSource.DataMember = "ExtraCharge";
      this.extraChargeBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.extraChargeTableAdapter.ClearBeforeFill = true;
      this.keyChargesBindingSource.DataMember = "KeyCharges";
      this.keyChargesBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.keyChargesTableAdapter.ClearBeforeFill = true;
      this.lastTransBindingSource.DataMember = "LastTrans";
      this.lastTransBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.lastTransTableAdapter.ClearBeforeFill = true;
      this.lockedRecordBindingSource.DataMember = "LockedRecord";
      this.lockedRecordBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.lockedRecordTableAdapter.ClearBeforeFill = true;
      this.logInOutBindingSource.DataMember = "LogInOut";
      this.logInOutBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.logInOutTableAdapter.ClearBeforeFill = true;
      this.reserveBindingSource.DataMember = "Reserve";
      this.reserveBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.reserveTableAdapter.ClearBeforeFill = true;
      this.roomStatusBindingSource.DataMember = "RoomStatus";
      this.roomStatusBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.roomStatusTableAdapter.ClearBeforeFill = true;
      this.unitRefBindingSource.DataMember = "UnitRef";
      this.unitRefBindingSource.DataSource = (object) this.buildingDB1DataSet;
      this.unitRefTableAdapter.ClearBeforeFill = true;
      this.systemDataSet.EndInit();
      ((ISupportInitialize) this.countryBindingSource).EndInit();
      ((ISupportInitialize) this.roomTypeBindingSource).EndInit();
      ((ISupportInitialize) this.bonusBindingSource).EndInit();
      ((ISupportInitialize) this.bonus1BindingSource).EndInit();
      ((ISupportInitialize) this.buildingBindingSource).EndInit();
      ((ISupportInitialize) this.floorBindingSource).EndInit();
      ((ISupportInitialize) this.gSTHistoryBindingSource).EndInit();
      ((ISupportInitialize) this.gSTHistory1BindingSource).EndInit();
      ((ISupportInitialize) this.roomBindingSource).EndInit();
      ((ISupportInitialize) this.roomStatus1BindingSource).EndInit();
      ((ISupportInitialize) this.systemSetBindingSource).EndInit();
      ((ISupportInitialize) this.systemSet1BindingSource).EndInit();
      ((ISupportInitialize) this.zoneBindingSource).EndInit();
      this.buildingDB1DataSet.EndInit();
      ((ISupportInitialize) this.cardTransBindingSource).EndInit();
      ((ISupportInitialize) this.cardNoBindingSource).EndInit();
      ((ISupportInitialize) this.clientBindingSource).EndInit();
      ((ISupportInitialize) this.clientAccBindingSource).EndInit();
      ((ISupportInitialize) this.allLockedRecordBindingSource).EndInit();
      ((ISupportInitialize) this.eventLogBindingSource).EndInit();
      ((ISupportInitialize) this.extraChargeBindingSource).EndInit();
      ((ISupportInitialize) this.keyChargesBindingSource).EndInit();
      ((ISupportInitialize) this.lastTransBindingSource).EndInit();
      ((ISupportInitialize) this.lockedRecordBindingSource).EndInit();
      ((ISupportInitialize) this.logInOutBindingSource).EndInit();
      ((ISupportInitialize) this.reserveBindingSource).EndInit();
      ((ISupportInitialize) this.roomStatusBindingSource).EndInit();
      ((ISupportInitialize) this.unitRefBindingSource).EndInit();
      this.systemSet2BindingSource = new BindingSource(this.components);
      this.systemSet2TableAdapter = new SystemSet2TableAdapter();
      this.systemSet3BindingSource = new BindingSource(this.components);
      this.systemSet3TableAdapter = new SystemSet3TableAdapter();
      this.systemSet4BindingSource = new BindingSource(this.components);
      this.systemSet4TableAdapter = new SystemSet4TableAdapter();
      this.systemSet5BindingSource = new BindingSource(this.components);
      this.systemSet5TableAdapter = new SystemSet5TableAdapter();
      this.systemSet6BindingSource = new BindingSource(this.components);
      this.systemSet6TableAdapter = new SystemSet6TableAdapter();
      ((ISupportInitialize) this.systemSet2BindingSource).BeginInit();
      ((ISupportInitialize) this.systemSet3BindingSource).BeginInit();
      ((ISupportInitialize) this.systemSet4BindingSource).BeginInit();
      ((ISupportInitialize) this.systemSet5BindingSource).BeginInit();
      ((ISupportInitialize) this.systemSet6BindingSource).BeginInit();
      this.systemSet2TableAdapter.ClearBeforeFill = true;
      this.systemSet3TableAdapter.ClearBeforeFill = true;
      this.systemSet4TableAdapter.ClearBeforeFill = true;
      this.systemSet5TableAdapter.ClearBeforeFill = true;
      this.systemSet6TableAdapter.ClearBeforeFill = true;
      ((ISupportInitialize) this.systemSet2BindingSource).EndInit();
      ((ISupportInitialize) this.systemSet3BindingSource).EndInit();
      ((ISupportInitialize) this.systemSet4BindingSource).EndInit();
      ((ISupportInitialize) this.systemSet5BindingSource).EndInit();
      ((ISupportInitialize) this.systemSet6BindingSource).EndInit();
      this.staffDataSet = new StaffDataSet();
      this.staffBindingSource = new BindingSource(this.components);
      this.staffTableAdapter = new StaffTableAdapter();
      this.staffDataSet.BeginInit();
      ((ISupportInitialize) this.staffBindingSource).BeginInit();
      this.staffDataSet.DataSetName = "StaffDataSet";
      this.staffDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.staffBindingSource.DataMember = "Staff";
      this.staffBindingSource.DataSource = (object) this.staffDataSet;
      this.staffTableAdapter.ClearBeforeFill = true;
      this.staffDataSet.EndInit();
      ((ISupportInitialize) this.staffBindingSource).EndInit();
      this.replacementBindingSource = new BindingSource(this.components);
      this.replacementDB1DataSet = new ReplacementDB1DataSet();
      this.replacementTableAdapter = new ReplacementTableAdapter();
      ((ISupportInitialize) this.replacementBindingSource).BeginInit();
      this.replacementDB1DataSet.BeginInit();
      this.replacementBindingSource.DataMember = "Replacement";
      this.replacementBindingSource.DataSource = (object) this.replacementDB1DataSet;
      this.replacementDB1DataSet.DataSetName = "ReplacementDB1DataSet";
      this.replacementDB1DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.replacementTableAdapter.ClearBeforeFill = true;
      ((ISupportInitialize) this.replacementBindingSource).EndInit();
      this.replacementDB1DataSet.EndInit();
    }

    public void ReinitialiseForm()
    {
      this.bAdmin = false;
      this.bAdminOnly = false;
      this.bSystemMode = false;
      this.bVacantDateCheckFlag = false;
      this.iBrowser = 0U;
      this.bClientDataFlag = false;
      this.bSystemSetting = false;
      this.sCharge = "8";
      this.gConstantGST = "1";
      Global_Data.iPrint = (short) 0;
      Global_Data.sRYear = "";
      Global_Data.sRDate = "";
      Global_Data.sSDate = "";
      Global_Data.sEDate = "";
      this.sBldNo = "";
    }

    public void Main()
    {
      this.bAdmin = false;
      this.bAdminOnly = false;
      this.bSystemMode = false;
      this.bVacantDateCheckFlag = false;
      this.iBrowser = 0U;
      this.bClientDataFlag = false;
      this.bSystemSetting = false;
      this.bCurrent = false;
      this.bWholeUnit = false;
      this.bUnitFlag = false;
      this.bUnitClientEdit = false;
      this.bTracking = false;
      this.bTimeChecking = false;
      this.bDate = false;
      this.bBonusAlready = false;
      this.bReader = false;
      this.sCharge = "8";
      this.gConstantGST = "1";
      this.gsReserveType = "";
      this.gsOldReserveType = "";
      this.gsUnitNo = "";
      this.gsRoomNo = "";
      this.gsCondition = "";
      this.gOwnerID = "";
      this.gDisableBonusDate = "";
      Global_Data.iPrint = (short) 0;
      this.iType = 0;
      Global_Data.iView = 0;
      Global_Data.sRYear = "";
      Global_Data.sRDate = "";
      Global_Data.sSDate = "";
      Global_Data.sEDate = "";
      this.sBldNo = "";
      this.gsClientID = "";
      this.gsClientName1 = "";
      this.gsClientName2 = "";
      this.sCardSerialNo = "SSSSS";
      this.gUSERID = "SSSSSSSSSS";
      this.iTrackTransID = "0";
      this.iRefNo = "0";
    }

    public bool Initialze_ComboCountry(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.countryTableAdapter.Fill(this.systemDataSet.Country);
      foreach (SystemDataSet.CountryRow row in (InternalDataCollectionBase) this.systemDataSet.Country.Rows)
        para_ComboBox.Items.Add((object) row.CountryDesc);
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboStatus(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "Vacant");
      para_ComboBox.Items.Add((object) "Vacant Clean");
      para_ComboBox.Items.Add((object) "Reserved");
      para_ComboBox.Items.Add((object) "Occupied");
      para_ComboBox.Items.Add((object) "Out of Order");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboSex(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "M");
      para_ComboBox.Items.Add((object) "F");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboChargeType(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "Daily");
      para_ComboBox.Items.Add((object) "Weekly");
      para_ComboBox.Items.Add((object) "Monthly");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRmTypeSearch(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "RoomType");
      para_ComboBox.Items.Add((object) "RmDescription");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRoomSearch(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "RoomNo");
      para_ComboBox.Items.Add((object) "RoomID");
      para_ComboBox.Items.Add((object) "RoomType");
      para_ComboBox.Items.Add((object) "FloorNo");
      para_ComboBox.Items.Add((object) "BuildingNo");
      para_ComboBox.Items.Add((object) "DailyRate");
      para_ComboBox.Items.Add((object) "WeeklyRate");
      para_ComboBox.Items.Add((object) "MonthlyRate");
      para_ComboBox.Items.Add((object) "DailyRate2");
      para_ComboBox.Items.Add((object) "WeeklyRate2");
      para_ComboBox.Items.Add((object) "MonthlyRate2");
      para_ComboBox.Items.Add((object) "IssuedCard");
      para_ComboBox.Items.Add((object) "TotalStay");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRmStatusSearch(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "Room No");
      para_ComboBox.Items.Add((object) "Status");
      para_ComboBox.Items.Add((object) "Start Date");
      para_ComboBox.Items.Add((object) "End Date");
      para_ComboBox.Items.Add((object) "Staff ID");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRmType(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.systemDataSet.RoomType.Rows)
        para_ComboBox.Items.Add((object) row.RmDescription);
      if (para_ComboBox.Items.Count > 0)
        para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRmType_Others(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.systemDataSet.RoomType.Rows)
      {
        if (row.RmDescription.Contains("OFFICE") || row.RmDescription.Contains("STORE"))
          para_ComboBox.Items.Add((object) row.RmDescription);
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboRoomType_ForGuest(ComboBox para_ComboBox, string para_BuildingType)
    {
      para_ComboBox.Items.Clear();
      this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.systemDataSet.RoomType.Rows)
      {
        if (!row.RmDescription.Contains("OFFICE") && !row.RmDescription.Contains("STORE"))
          para_ComboBox.Items.Add((object) row.RmDescription);
      }
      if (this.systemDataSet.RoomType.Rows.Count > 0)
        para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public string Get_RoomType_Description(byte para_RoomType)
    {
      string roomTypeDescription = "";
      this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      try
      {
        if (this.systemDataSet.RoomType.Rows.Count <= 0)
          this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      }
      catch
      {
        this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      }
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.systemDataSet.RoomType.Rows)
      {
        if ((int) para_RoomType == (int) row.RoomType)
        {
          roomTypeDescription = row.RmDescription;
          break;
        }
      }
      return roomTypeDescription;
    }

    public bool Initialize_ComboRmReserveType(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.roomTypeTableAdapter.Fill(this.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.systemDataSet.RoomType.Rows)
      {
        string roomTypeDescription = this.Get_RoomType_Description(row.RoomType);
        if (!roomTypeDescription.Contains("STORE") && !roomTypeDescription.Contains("OFFICE"))
          para_ComboBox.Items.Add((object) row.RmDescription);
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboAvailableRoomNo(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.availableRoom_TempTableAdapter.Fill(this.tempDataSet.AvailableRoom_Temp);
      foreach (TempDataSet.AvailableRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.AvailableRoom_Temp.Rows)
        para_ComboBox.Items.Add((object) row.RoomNo);
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckRoomNo(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.checkRoom_TempTableAdapter.Fill(this.tempDataSet.CheckRoom_Temp);
      foreach (TempDataSet.CheckRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.CheckRoom_Temp.Rows)
        para_ComboBox.Items.Add((object) row.RoomNo);
      if (this.tempDataSet.CheckRoom_Temp.Rows.Count > 0)
        para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckUnitNo(ComboBox para_ComboBox)
    {
      string str = "";
      para_ComboBox.Items.Clear();
      this.checkRoom_TempTableAdapter.Fill(this.tempDataSet.CheckRoom_Temp);
      foreach (TempDataSet.CheckRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.CheckRoom_Temp.Rows)
      {
        if (str != row.RoomNo.Substring(1, 2))
        {
          str = row.RoomNo.Substring(1, 2);
          para_ComboBox.Items.Add((object) str);
        }
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckUnitNoRs(ComboBox para_ComboBox)
    {
      string str = "";
      para_ComboBox.Items.Clear();
      this.checkRoom_TempTableAdapter.Fill(this.tempDataSet.CheckRoom_Temp);
      foreach (TempDataSet.CheckRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.CheckRoom_Temp.Rows)
      {
        if (str != row.RoomNo.Substring(1, 2))
        {
          str = row.RoomNo.Substring(1, 2);
          if (row.RmDescription != "Reserved")
            para_ComboBox.Items.Add((object) row.RoomNo.Substring(1, 2));
          else if (row.RmDescription == "Reserved")
          {
            if (this.gsUnitNo != str)
            {
              if (row.Condition != "Unit")
                para_ComboBox.Items.Add((object) str);
            }
            else if (this.gsUnitNo == str)
              para_ComboBox.Items.Add((object) str);
          }
        }
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckURoomNo(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.checkRoom_TempTableAdapter.Fill(this.tempDataSet.CheckRoom_Temp);
      foreach (TempDataSet.CheckRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.CheckRoom_Temp.Rows)
      {
        if (this.gsUnitNo == row.RoomNo.Substring(1, 2))
          para_ComboBox.Items.Add((object) row.RoomNo);
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckUnitRef(ComboBox para_ComboBox) => true;

    public bool Initialize_ComboCheckSpareRoomNo(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.dTransactionsTableAdapter.Fill(this.tempDataSet.DTransactions);
      foreach (TempDataSet.DTransactionsRow row in (InternalDataCollectionBase) this.tempDataSet.DTransactions.Rows)
        para_ComboBox.Items.Add((object) row.RoomNo);
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckStatusRoomNo(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      this.vacantStatus_TempTableAdapter.Fill(this.tempDataSet.VacantStatus_Temp);
      foreach (TempDataSet.VacantStatus_TempRow row in (InternalDataCollectionBase) this.tempDataSet.VacantStatus_Temp.Rows)
        para_ComboBox.Items.Add((object) row.RoomNo);
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckStatusUnitNo(ComboBox para_ComboBox)
    {
      string str = "";
      para_ComboBox.Items.Clear();
      this.vacantStatus_TempTableAdapter.Fill(this.tempDataSet.VacantStatus_Temp);
      foreach (TempDataSet.VacantStatus_TempRow row in (InternalDataCollectionBase) this.tempDataSet.VacantStatus_Temp.Rows)
      {
        if (str != row.RoomNo.Substring(1, 2))
        {
          str = row.RoomNo.Substring(1, 2);
          para_ComboBox.Items.Add((object) str);
        }
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Initialize_ComboCheckVacantUnitNo(ComboBox para_ComboBox)
    {
      string str1 = "";
      int num = 0;
      bool flag = false;
      para_ComboBox.Items.Clear();
      this.checkRoom_TempTableAdapter.Fill(this.tempDataSet.CheckRoom_Temp);
      foreach (TempDataSet.CheckRoom_TempRow row in (InternalDataCollectionBase) this.tempDataSet.CheckRoom_Temp.Rows)
      {
        if (str1 != row.RoomNo.Substring(1, 2))
        {
          str1 = row.RoomNo.Substring(1, 2);
          this.bUnitFlag = false;
          if (!(row.RmDescription == "Reserved") && !(row.RmDescription == "Occupied"))
          {
            para_ComboBox.Items.Add((object) str1);
            string str2 = (string) para_ComboBox.Items[para_ComboBox.Items.Count - 1];
            ++num;
          }
          else if (row.RmDescription == "Reserved" || row.RmDescription == "Occupied")
          {
            if (this.gsUnitNo != str1)
            {
              if (row.Condition == "")
              {
                para_ComboBox.Items.Add((object) str1);
                ++num;
              }
              else
                flag = true;
            }
            else if (this.gsUnitNo == str1)
            {
              para_ComboBox.Items.Add((object) str1);
              ++num;
            }
          }
        }
        else if (str1 == row.RoomNo.Substring(1, 2))
        {
          if (this.iGuest == 1U)
          {
            if (this.bWholeUnit && this.gsCondition == "Individual")
            {
              if (!this.bUnitFlag && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "")
              {
                for (int index = 0; index < num; ++index)
                {
                  if ((string) para_ComboBox.Items[index] == str1)
                  {
                    para_ComboBox.Items.RemoveAt(index);
                    num = para_ComboBox.Items.Count;
                    this.bUnitFlag = true;
                    break;
                  }
                }
              }
            }
            else if (str1 != this.gsUnitNo)
            {
              if (!this.bUnitFlag && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && !flag && row.Condition != "" && num > 0)
              {
                for (int index = 0; index < num; ++index)
                {
                  if ((string) para_ComboBox.Items[index] == str1)
                  {
                    para_ComboBox.Items.RemoveAt(index);
                    num = para_ComboBox.Items.Count;
                    this.bUnitFlag = true;
                    break;
                  }
                }
              }
            }
            else if (str1 == this.gsUnitNo && !this.bUnitFlag && row.RoomNo != this.gsRoomNo && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "")
            {
              for (int index = 0; index < num; ++index)
              {
                if ((string) para_ComboBox.Items[index] == str1)
                {
                  para_ComboBox.Items.RemoveAt(index);
                  num = para_ComboBox.Items.Count;
                  this.bUnitFlag = true;
                  break;
                }
              }
            }
          }
          else if (this.iGuest == 2U)
          {
            if (str1 != this.gsUnitNo)
            {
              if (!this.bUnitFlag && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "" && num > 0)
              {
                for (int index = 0; index < num; ++index)
                {
                  if ((string) para_ComboBox.Items[index] == str1)
                  {
                    para_ComboBox.Items.RemoveAt(index);
                    num = para_ComboBox.Items.Count;
                    this.bUnitFlag = true;
                    break;
                  }
                }
              }
            }
            else if (!this.bUnitFlag && str1 != this.gsRoomNo.Substring(1, 2) && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "" && num > 0)
            {
              for (int index = 0; index < num; ++index)
              {
                if ((string) para_ComboBox.Items[index] == str1)
                {
                  para_ComboBox.Items.RemoveAt(index);
                  num = para_ComboBox.Items.Count;
                  this.bUnitFlag = true;
                  break;
                }
              }
            }
          }
          else if (this.iGuest == 3U)
          {
            if (str1 != this.gsUnitNo)
            {
              if (!this.bUnitFlag && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "" && num > 0)
              {
                for (int index = 0; index < num; ++index)
                {
                  if ((string) para_ComboBox.Items[index] == str1)
                  {
                    para_ComboBox.Items.RemoveAt(index);
                    num = para_ComboBox.Items.Count;
                    this.bUnitFlag = true;
                    break;
                  }
                }
              }
            }
            else if (!this.bUnitFlag && row.RoomNo != this.gsRoomNo && (row.RmDescription == "Reserved" || row.RmDescription == "Occupied") && row.Condition != "" && num > 0)
            {
              for (int index = 0; index < num; ++index)
              {
                if ((string) para_ComboBox.Items[index] == str1)
                {
                  para_ComboBox.Items.RemoveAt(index);
                  num = para_ComboBox.Items.Count;
                  this.bUnitFlag = true;
                  break;
                }
              }
            }
          }
        }
      }
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool CheckBuilding_Found(ComboBox para_ComboBox)
    {
      bool flag = false;
      this.buildingTableAdapter.Fill(this.systemDataSet.Building);
      IEnumerator enumerator = this.systemDataSet.Building.Rows.GetEnumerator();
      try
      {
        if (enumerator.MoveNext())
        {
          SystemDataSet.BuildingRow current = (SystemDataSet.BuildingRow) enumerator.Current;
          para_ComboBox.Items.Add((object) current.BuildingNo);
          flag = true;
          Global_Data.sBldNo = current.BuildingNo;
        }
      }
      finally
      {
        if (enumerator is IDisposable disposable)
          disposable.Dispose();
      }
      if (!flag)
        return false;
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    public bool Create_Building(string para_BldNo, string para_BldName, string para_BldType)
    {
      this.buildingTableAdapter.Fill(this.systemDataSet.Building);
      SystemDataSet.BuildingRow row = this.systemDataSet.Building.NewBuildingRow();
      row.BuildingNo = para_BldNo;
      row.BldName = para_BldName;
      row.BuildingType = para_BldType;
      this.systemDataSet.Building.AddBuildingRow(row);
      if (this.buildingTableAdapter.Update(this.systemDataSet.Building) > 0)
        return true;
      int num = (int) MessageBox.Show("Can not Create New Building!");
      return false;
    }

    public string CheckBuildingType(string para_string)
    {
      string str = "";
      this.buildingTableAdapter.Fill(this.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow buildingRow in this.systemDataSet.Building)
      {
        if (buildingRow.BuildingNo == para_string)
        {
          str = buildingRow.BuildingType;
          break;
        }
      }
      if (str == "")
        str = "Normal";
      return str;
    }

    public void Set_HotelCode(string para_Building_No)
    {
      switch (para_Building_No)
      {
        case "1":
          this.systemSet1TableAdapter.Fill(this.systemDataSet.SystemSet1);
          if (this.systemDataSet.SystemSet1.Rows.Count <= 0)
            break;
          IEnumerator enumerator1 = this.systemDataSet.SystemSet1.Rows.GetEnumerator();
          try
          {
            if (!enumerator1.MoveNext())
              break;
            SystemDataSet.SystemSet1Row current = (SystemDataSet.SystemSet1Row) enumerator1.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet1TableAdapter.Update(this.systemDataSet.SystemSet1) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num1 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.systemSet2TableAdapter.Fill(this.systemDataSet.SystemSet2);
          if (this.systemDataSet.SystemSet2.Rows.Count <= 0)
            break;
          IEnumerator enumerator2 = this.systemDataSet.SystemSet2.Rows.GetEnumerator();
          try
          {
            if (!enumerator2.MoveNext())
              break;
            SystemDataSet.SystemSet2Row current = (SystemDataSet.SystemSet2Row) enumerator2.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet2TableAdapter.Update(this.systemDataSet.SystemSet2) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num2 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.systemSet3TableAdapter.Fill(this.systemDataSet.SystemSet3);
          if (this.systemDataSet.SystemSet3.Rows.Count <= 0)
            break;
          IEnumerator enumerator3 = this.systemDataSet.SystemSet3.Rows.GetEnumerator();
          try
          {
            if (!enumerator3.MoveNext())
              break;
            SystemDataSet.SystemSet3Row current = (SystemDataSet.SystemSet3Row) enumerator3.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet3TableAdapter.Update(this.systemDataSet.SystemSet3) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num3 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.systemSet4TableAdapter.Fill(this.systemDataSet.SystemSet4);
          if (this.systemDataSet.SystemSet4.Rows.Count <= 0)
            break;
          IEnumerator enumerator4 = this.systemDataSet.SystemSet4.Rows.GetEnumerator();
          try
          {
            if (!enumerator4.MoveNext())
              break;
            SystemDataSet.SystemSet4Row current = (SystemDataSet.SystemSet4Row) enumerator4.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet4TableAdapter.Update(this.systemDataSet.SystemSet4) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num4 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.systemSet5TableAdapter.Fill(this.systemDataSet.SystemSet5);
          if (this.systemDataSet.SystemSet5.Rows.Count <= 0)
            break;
          IEnumerator enumerator5 = this.systemDataSet.SystemSet5.Rows.GetEnumerator();
          try
          {
            if (!enumerator5.MoveNext())
              break;
            SystemDataSet.SystemSet5Row current = (SystemDataSet.SystemSet5Row) enumerator5.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet5TableAdapter.Update(this.systemDataSet.SystemSet5) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num5 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.systemSet6TableAdapter.Fill(this.systemDataSet.SystemSet6);
          if (this.systemDataSet.SystemSet6.Rows.Count <= 0)
            break;
          IEnumerator enumerator6 = this.systemDataSet.SystemSet6.Rows.GetEnumerator();
          try
          {
            if (!enumerator6.MoveNext())
              break;
            SystemDataSet.SystemSet6Row current = (SystemDataSet.SystemSet6Row) enumerator6.Current;
            try
            {
              if (current.HotelCode == Global_Data.System_Pas_String)
              {
                int num = (int) MessageBox.Show("Same Authorization Code. Do not need to update!");
                break;
              }
            }
            catch
            {
            }
            current.HotelCode = Global_Data.System_Pas_String;
            if (this.systemSet6TableAdapter.Update(this.systemDataSet.SystemSet6) <= 0)
            {
              int num = (int) MessageBox.Show("Authorization Code Update Failed!");
              break;
            }
            int num6 = (int) MessageBox.Show("Authorization Code is Successfully Updated!");
            break;
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
      }
    }

    public void Set_System_Setting(string para_Building_No)
    {
      switch (para_Building_No)
      {
        case "1":
          this.systemSet1TableAdapter.Fill(this.systemDataSet.SystemSet1);
          if (this.systemDataSet.SystemSet1.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet1.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet1Row current = (SystemDataSet.SystemSet1Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet1TableAdapter.Update(this.systemDataSet.SystemSet1) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet1Row row = (SystemDataSet.SystemSet1Row) this.systemDataSet.SystemSet1.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet1.AddSystemSet1Row(row);
            if (this.systemSet1TableAdapter.Update(this.systemDataSet.SystemSet1) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        case "2":
          this.systemSet2TableAdapter.Fill(this.systemDataSet.SystemSet2);
          if (this.systemDataSet.SystemSet2.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet2.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet2Row current = (SystemDataSet.SystemSet2Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet2TableAdapter.Update(this.systemDataSet.SystemSet2) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet2Row row = (SystemDataSet.SystemSet2Row) this.systemDataSet.SystemSet2.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet2.AddSystemSet2Row(row);
            if (this.systemSet2TableAdapter.Update(this.systemDataSet.SystemSet2) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        case "3":
          this.systemSet3TableAdapter.Fill(this.systemDataSet.SystemSet3);
          if (this.systemDataSet.SystemSet3.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet3.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet3Row current = (SystemDataSet.SystemSet3Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet3TableAdapter.Update(this.systemDataSet.SystemSet3) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet3Row row = (SystemDataSet.SystemSet3Row) this.systemDataSet.SystemSet3.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet3.AddSystemSet3Row(row);
            if (this.systemSet3TableAdapter.Update(this.systemDataSet.SystemSet3) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        case "4":
          this.systemSet4TableAdapter.Fill(this.systemDataSet.SystemSet4);
          if (this.systemDataSet.SystemSet4.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet4.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet4Row current = (SystemDataSet.SystemSet4Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet4TableAdapter.Update(this.systemDataSet.SystemSet4) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet4Row row = (SystemDataSet.SystemSet4Row) this.systemDataSet.SystemSet4.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet4.AddSystemSet4Row(row);
            if (this.systemSet4TableAdapter.Update(this.systemDataSet.SystemSet4) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        case "5":
          this.systemSet5TableAdapter.Fill(this.systemDataSet.SystemSet5);
          if (this.systemDataSet.SystemSet5.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet5.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet5Row current = (SystemDataSet.SystemSet5Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet5TableAdapter.Update(this.systemDataSet.SystemSet5) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet5Row row = (SystemDataSet.SystemSet5Row) this.systemDataSet.SystemSet5.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet5.AddSystemSet5Row(row);
            if (this.systemSet5TableAdapter.Update(this.systemDataSet.SystemSet5) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        case "6":
          this.systemSet6TableAdapter.Fill(this.systemDataSet.SystemSet6);
          if (this.systemDataSet.SystemSet6.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet6.Rows.GetEnumerator();
            try
            {
              if (!enumerator.MoveNext())
                break;
              SystemDataSet.SystemSet6Row current = (SystemDataSet.SystemSet6Row) enumerator.Current;
              current.Comport = Global_Data.COM_NUM;
              try
              {
                current.SystemID = Convert.ToInt16(this.gSystemID);
              }
              catch
              {
                current.SystemID = (short) 1;
              }
              current.CheckOutTime = Global_Data.CheckOut_Time;
              current.Description = this.gDescription;
              current.GSTRate = Convert.ToDouble(this.gGST);
              current.Bonus = this.gBonus;
              current.BuildingType = this.CheckBuildingType(para_Building_No);
              current.MGraceDefault = this.giMGraceDefault;
              current.WGraceDefault = this.giWGraceDefault;
              current.DGraceDefault = this.giDGraceDefault;
              current.HotelCode = Global_Data.System_Pas_String;
              if (this.systemSet6TableAdapter.Update(this.systemDataSet.SystemSet6) > 0)
                break;
              int num = (int) MessageBox.Show("System Data Update Failed!");
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            SystemDataSet.SystemSet6Row row = (SystemDataSet.SystemSet6Row) this.systemDataSet.SystemSet6.NewRow();
            row.Comport = Global_Data.COM_NUM;
            try
            {
              row.SystemID = Convert.ToInt16(this.gSystemID);
            }
            catch
            {
              row.SystemID = (short) 1;
            }
            row.CheckOutTime = Global_Data.CheckOut_Time;
            row.Description = " ";
            row.GSTRate = Convert.ToDouble(this.gGST);
            row.Bonus = this.gBonus;
            row.BuildingType = this.CheckBuildingType(para_Building_No);
            row.MGraceDefault = this.giMGraceDefault;
            row.WGraceDefault = this.giWGraceDefault;
            row.DGraceDefault = this.giDGraceDefault;
            row.HotelCode = Global_Data.System_Pas_String;
            this.systemDataSet.SystemSet6.AddSystemSet6Row(row);
            if (this.systemSet6TableAdapter.Update(this.systemDataSet.SystemSet6) > 0)
              break;
            int num = (int) MessageBox.Show("System Data Update Failed!");
            break;
          }
        default:
          int num1 = (int) MessageBox.Show("Not Implemented for this case! in Set_System_Setting()");
          break;
      }
    }

    public void Get_Hotel_Code()
    {
      switch (this.gBuildingNo)
      {
        case "1":
          this.systemSet1TableAdapter.Fill(this.systemDataSet.SystemSet1);
          if (this.systemDataSet.SystemSet1.Rows.Count <= 0)
            break;
          IEnumerator enumerator1 = this.systemDataSet.SystemSet1.Rows.GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet1Row) enumerator1.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.systemSet2TableAdapter.Fill(this.systemDataSet.SystemSet2);
          if (this.systemDataSet.SystemSet2.Rows.Count <= 0)
            break;
          IEnumerator enumerator2 = this.systemDataSet.SystemSet2.Rows.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet2Row) enumerator2.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.systemSet3TableAdapter.Fill(this.systemDataSet.SystemSet3);
          if (this.systemDataSet.SystemSet3.Rows.Count <= 0)
            break;
          IEnumerator enumerator3 = this.systemDataSet.SystemSet3.Rows.GetEnumerator();
          try
          {
            while (enumerator3.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet3Row) enumerator3.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.systemSet4TableAdapter.Fill(this.systemDataSet.SystemSet4);
          if (this.systemDataSet.SystemSet4.Rows.Count <= 0)
            break;
          IEnumerator enumerator4 = this.systemDataSet.SystemSet4.Rows.GetEnumerator();
          try
          {
            while (enumerator4.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet4Row) enumerator4.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.systemSet5TableAdapter.Fill(this.systemDataSet.SystemSet5);
          if (this.systemDataSet.SystemSet5.Rows.Count <= 0)
            break;
          IEnumerator enumerator5 = this.systemDataSet.SystemSet5.Rows.GetEnumerator();
          try
          {
            while (enumerator5.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet5Row) enumerator5.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.systemSet6TableAdapter.Fill(this.systemDataSet.SystemSet6);
          if (this.systemDataSet.SystemSet6.Rows.Count <= 0)
            break;
          IEnumerator enumerator6 = this.systemDataSet.SystemSet6.Rows.GetEnumerator();
          try
          {
            while (enumerator6.MoveNext())
              Global_Data.System_Pas_String = ((SystemDataSet.SystemSet6Row) enumerator6.Current).HotelCode;
            break;
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
        default:
          this.systemSetTableAdapter.Fill(this.systemDataSet.SystemSet);
          if (this.systemDataSet.SystemSet.Rows.Count <= 0)
            break;
          IEnumerator enumerator7 = this.systemDataSet.SystemSet.Rows.GetEnumerator();
          try
          {
            while (enumerator7.MoveNext())
            {
              SystemDataSet.SystemSetRow current = (SystemDataSet.SystemSetRow) enumerator7.Current;
            }
            break;
          }
          finally
          {
            if (enumerator7 is IDisposable disposable)
              disposable.Dispose();
          }
      }
    }

    public void GetSystemSetting()
    {
      switch (this.gBuildingNo)
      {
        case "1":
          this.systemSet1TableAdapter.Fill(this.systemDataSet.SystemSet1);
          if (this.systemDataSet.SystemSet1.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet1.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet1Row current = (SystemDataSet.SystemSet1Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        case "2":
          this.systemSet2TableAdapter.Fill(this.systemDataSet.SystemSet2);
          if (this.systemDataSet.SystemSet2.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet2.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet2Row current = (SystemDataSet.SystemSet2Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        case "3":
          this.systemSet3TableAdapter.Fill(this.systemDataSet.SystemSet3);
          if (this.systemDataSet.SystemSet3.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet3.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet3Row current = (SystemDataSet.SystemSet3Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        case "4":
          this.systemSet4TableAdapter.Fill(this.systemDataSet.SystemSet4);
          if (this.systemDataSet.SystemSet4.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet4.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet4Row current = (SystemDataSet.SystemSet4Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        case "5":
          this.systemSet5TableAdapter.Fill(this.systemDataSet.SystemSet5);
          if (this.systemDataSet.SystemSet5.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet5.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet5Row current = (SystemDataSet.SystemSet5Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        case "6":
          this.systemSet6TableAdapter.Fill(this.systemDataSet.SystemSet6);
          if (this.systemDataSet.SystemSet6.Rows.Count > 0)
          {
            IEnumerator enumerator = this.systemDataSet.SystemSet6.Rows.GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                SystemDataSet.SystemSet6Row current = (SystemDataSet.SystemSet6Row) enumerator.Current;
                Global_Data.COM_NUM = current.Comport;
                Global_Data.System_Pas_String = current.HotelCode;
                Global_Data.CheckOut_Time = current.CheckOutTime;
                this.gsComPort = current.Comport.ToString();
                this.gSystemID = current.SystemID.ToString();
                this.gDescription = current.Description;
                this.gGST = current.GSTRate.ToString();
                this.gBonus = current.Bonus;
                this.giMGraceDefault = current.MGraceDefault;
                this.giWGraceDefault = current.WGraceDefault;
                this.giDGraceDefault = current.DGraceDefault;
                if (this.gGST != "0")
                  this.gGSTPercent = (Convert.ToDouble(this.gGST) / 100.0).ToString();
              }
              break;
            }
            finally
            {
              if (enumerator is IDisposable disposable)
                disposable.Dispose();
            }
          }
          else
          {
            Global_Data.COM_NUM = (byte) 3;
            this.gsComPort = Global_Data.COM_NUM.ToString();
            break;
          }
        default:
          int num = (int) MessageBox.Show("Need to implement for this case");
          break;
      }
    }

    public void GetGSTHistory()
    {
    }

    public void GetBonusInfo()
    {
      bool flag1 = false;
      switch (this.gBuildingNo)
      {
        case "1":
          this.bonus1TableAdapter.Fill(this.systemDataSet.Bonus1);
          foreach (SystemDataSet.Bonus1Row bonus1Row in this.systemDataSet.Bonus1)
          {
            if (bonus1Row.StayType == "M")
            {
              this.gsMStayType = bonus1Row.StayType;
              this.giMTotalStay = bonus1Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus1Row.BonusType == null ? "" : bonus1Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus1Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus1Row.BonusStart == null ? "" : bonus1Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag2 = false;
          foreach (SystemDataSet.Bonus1Row bonus1Row in this.systemDataSet.Bonus1)
          {
            if (bonus1Row.StayType == "W")
            {
              this.gsWStayType = bonus1Row.StayType;
              this.giWTotalStay = bonus1Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus1Row.BonusType == null ? "" : bonus1Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus1Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus1Row.BonusStart == null ? "" : bonus1Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag2)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        case "2":
          this.bonus2TableAdapter.Fill(this.systemDataSet.Bonus2);
          foreach (SystemDataSet.Bonus2Row bonus2Row in this.systemDataSet.Bonus2)
          {
            if (bonus2Row.StayType == "M")
            {
              this.gsMStayType = bonus2Row.StayType;
              this.giMTotalStay = bonus2Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus2Row.BonusType == null ? "" : bonus2Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus2Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus2Row.BonusStart == null ? "" : bonus2Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag3 = false;
          foreach (SystemDataSet.Bonus2Row bonus2Row in this.systemDataSet.Bonus2)
          {
            if (bonus2Row.StayType == "W")
            {
              this.gsWStayType = bonus2Row.StayType;
              this.giWTotalStay = bonus2Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus2Row.BonusType == null ? "" : bonus2Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus2Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus2Row.BonusStart == null ? "" : bonus2Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag3)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        case "3":
          this.bonus3TableAdapter.Fill(this.systemDataSet.Bonus3);
          foreach (SystemDataSet.Bonus3Row bonus3Row in this.systemDataSet.Bonus3)
          {
            if (bonus3Row.StayType == "M")
            {
              this.gsMStayType = bonus3Row.StayType;
              this.giMTotalStay = bonus3Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus3Row.BonusType == null ? "" : bonus3Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus3Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus3Row.BonusStart == null ? "" : bonus3Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag4 = false;
          foreach (SystemDataSet.Bonus3Row bonus3Row in this.systemDataSet.Bonus3)
          {
            if (bonus3Row.StayType == "W")
            {
              this.gsWStayType = bonus3Row.StayType;
              this.giWTotalStay = bonus3Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus3Row.BonusType == null ? "" : bonus3Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus3Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus3Row.BonusStart == null ? "" : bonus3Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag4)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        case "4":
          this.bonus4TableAdapter.Fill(this.systemDataSet.Bonus4);
          foreach (SystemDataSet.Bonus4Row bonus4Row in this.systemDataSet.Bonus4)
          {
            if (bonus4Row.StayType == "M")
            {
              this.gsMStayType = bonus4Row.StayType;
              this.giMTotalStay = bonus4Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus4Row.BonusType == null ? "" : bonus4Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus4Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus4Row.BonusStart == null ? "" : bonus4Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag5 = false;
          foreach (SystemDataSet.Bonus4Row bonus4Row in this.systemDataSet.Bonus4)
          {
            if (bonus4Row.StayType == "W")
            {
              this.gsWStayType = bonus4Row.StayType;
              this.giWTotalStay = bonus4Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus4Row.BonusType == null ? "" : bonus4Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus4Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus4Row.BonusStart == null ? "" : bonus4Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag5)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        case "5":
          this.bonus5TableAdapter.Fill(this.systemDataSet.Bonus5);
          foreach (SystemDataSet.Bonus5Row bonus5Row in this.systemDataSet.Bonus5)
          {
            if (bonus5Row.StayType == "M")
            {
              this.gsMStayType = bonus5Row.StayType;
              this.giMTotalStay = bonus5Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus5Row.BonusType == null ? "" : bonus5Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus5Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus5Row.BonusStart == null ? "" : bonus5Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag6 = false;
          foreach (SystemDataSet.Bonus5Row bonus5Row in this.systemDataSet.Bonus5)
          {
            if (bonus5Row.StayType == "W")
            {
              this.gsWStayType = bonus5Row.StayType;
              this.giWTotalStay = bonus5Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus5Row.BonusType == null ? "" : bonus5Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus5Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus5Row.BonusStart == null ? "" : bonus5Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag6)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        case "6":
          this.bonus6TableAdapter.Fill(this.systemDataSet.Bonus6);
          foreach (SystemDataSet.Bonus6Row bonus6Row in this.systemDataSet.Bonus6)
          {
            if (bonus6Row.StayType == "M")
            {
              this.gsMStayType = bonus6Row.StayType;
              this.giMTotalStay = bonus6Row.StayLength.ToString();
              try
              {
                this.gsMBonusType = bonus6Row.BonusType == null ? "" : bonus6Row.BonusType;
              }
              catch
              {
                this.gsMBonusType = "";
              }
              this.giMBonusLength = bonus6Row.BonusLength.ToString();
              try
              {
                this.gsMBonusStart = bonus6Row.BonusStart == null ? "" : bonus6Row.BonusStart;
              }
              catch
              {
                this.gsMBonusStart = "";
              }
              flag1 = true;
              break;
            }
          }
          if (!flag1)
          {
            this.gsMStayType = "";
            this.giMTotalStay = "0";
            this.gsMBonusType = "";
            this.giMBonusLength = "0";
            this.gsMBonusStart = "";
          }
          bool flag7 = false;
          foreach (SystemDataSet.Bonus6Row bonus6Row in this.systemDataSet.Bonus6)
          {
            if (bonus6Row.StayType == "W")
            {
              this.gsWStayType = bonus6Row.StayType;
              this.giWTotalStay = bonus6Row.StayLength.ToString();
              try
              {
                this.gsWBonusType = bonus6Row.BonusType == null ? "" : bonus6Row.BonusType;
              }
              catch
              {
                this.gsWBonusType = "";
              }
              this.giWBonusLength = bonus6Row.BonusLength.ToString();
              try
              {
                this.gsWBonusStart = bonus6Row.BonusStart == null ? "" : bonus6Row.BonusStart;
              }
              catch
              {
                this.gsWBonusStart = "";
              }
            }
          }
          if (flag7)
            break;
          this.gsWStayType = "";
          this.giWTotalStay = "0";
          this.gsWBonusType = "";
          this.giWBonusLength = "0";
          this.gsWBonusStart = "";
          break;
        default:
          int num = (int) MessageBox.Show("Need to Implement for this case!");
          break;
      }
    }

    public void GetBonusDisableDate()
    {
      switch (this.gBuildingNo)
      {
        case "1":
          this.bonus1TableAdapter.Fill(this.systemDataSet.Bonus1);
          IEnumerator enumerator1 = this.systemDataSet.Bonus1.GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
            {
              SystemDataSet.Bonus1Row current = (SystemDataSet.Bonus1Row) enumerator1.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.bonus2TableAdapter.Fill(this.systemDataSet.Bonus2);
          IEnumerator enumerator2 = this.systemDataSet.Bonus2.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              SystemDataSet.Bonus2Row current = (SystemDataSet.Bonus2Row) enumerator2.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.bonus3TableAdapter.Fill(this.systemDataSet.Bonus3);
          IEnumerator enumerator3 = this.systemDataSet.Bonus3.GetEnumerator();
          try
          {
            while (enumerator3.MoveNext())
            {
              SystemDataSet.Bonus3Row current = (SystemDataSet.Bonus3Row) enumerator3.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.bonus4TableAdapter.Fill(this.systemDataSet.Bonus4);
          IEnumerator enumerator4 = this.systemDataSet.Bonus4.GetEnumerator();
          try
          {
            while (enumerator4.MoveNext())
            {
              SystemDataSet.Bonus4Row current = (SystemDataSet.Bonus4Row) enumerator4.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.bonus5TableAdapter.Fill(this.systemDataSet.Bonus5);
          IEnumerator enumerator5 = this.systemDataSet.Bonus5.GetEnumerator();
          try
          {
            while (enumerator5.MoveNext())
            {
              SystemDataSet.Bonus5Row current = (SystemDataSet.Bonus5Row) enumerator5.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.bonus6TableAdapter.Fill(this.systemDataSet.Bonus6);
          IEnumerator enumerator6 = this.systemDataSet.Bonus6.GetEnumerator();
          try
          {
            while (enumerator6.MoveNext())
            {
              SystemDataSet.Bonus6Row current = (SystemDataSet.Bonus6Row) enumerator6.Current;
              if (current.StayType == "X")
              {
                if (current.BonusStart != null)
                {
                  this.gDisableBonusDate = current.BonusStart;
                  break;
                }
                this.gDisableBonusDate = "";
                break;
              }
            }
            break;
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
        default:
          int num = (int) MessageBox.Show("Need to Implement for this case!");
          break;
      }
    }

    public void GetSystemInfo()
    {
      this.GetSystemSetting();
      this.GetGSTHistory();
      if (this.gBonus)
      {
        this.GetBonusInfo();
      }
      else
      {
        this.GetBonusDisableDate();
        this.gsMStayType = "";
        this.gsWStayType = "";
        this.giMTotalStay = "0";
        this.giWTotalStay = "0";
        this.gsMBonusType = "";
        this.gsWBonusType = "";
        this.giMBonusLength = "0";
        this.giWBonusLength = "0";
      }
      this.INIT();
    }

    public void GetKeyCharges()
    {
      switch (this.gBuildingNo)
      {
        case "1":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator1 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator1.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator1.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case "2":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator2 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator2.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator2.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case "3":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator3 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator3.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator3.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case "4":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator4 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator4.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator4.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case "5":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator5 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator5.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator5.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator5 is IDisposable disposable)
              disposable.Dispose();
          }
        case "6":
          this.keyChargesTableAdapter.Fill(this.buildingDB1DataSet.KeyCharges);
          IEnumerator enumerator6 = this.buildingDB1DataSet.KeyCharges.Rows.GetEnumerator();
          try
          {
            if (!enumerator6.MoveNext())
              break;
            BuildingDB1DataSet.KeyChargesRow current = (BuildingDB1DataSet.KeyChargesRow) enumerator6.Current;
            this.giExtraKeyCharge = current.SpareKeyCharge.ToString("F2");
            this.giKeyDeposit = current.KeyDeposit.ToString("F2");
            break;
          }
          finally
          {
            if (enumerator6 is IDisposable disposable)
              disposable.Dispose();
          }
        default:
          int num = (int) MessageBox.Show("Not Implemented for this building keyCharges!");
          break;
      }
    }

    private void INIT()
    {
    }

    public string GetNew_CardNo(ComboBox para_ComboBox, bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999;
            num3 = 1001 - 1;
          }
          else
          {
            num2 = 900;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000;
          if (para_GuestFlag)
          {
            num2 = 9999 + num4;
            num3 = 501 + num4 - 1;
            break;
          }
          num2 = 400 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.cardNoTableAdapter.Fill(this.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardNo.Rows)
        para_ComboBox.Items.Add((object) row.CardNo);
      para_ComboBox.SelectedIndex = 0;
      string newCardNo;
      if (this.buildingDB1DataSet.CardNo.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardNo.Rows)
        {
          int int32 = Convert.ToInt32(row.CardNo);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newCardNo = num5.ToString("D5");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Card No." + newCardNo + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newCardNo = (num3 + 1).ToString("D5");
      return newCardNo;
    }

    public string GetNew_CardNo(bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999;
            num3 = 1001 - 1;
          }
          else
          {
            num2 = 900;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000;
          if (para_GuestFlag)
          {
            num2 = 9999 + num4;
            num3 = 501 + num4 - 1;
            break;
          }
          num2 = 400 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.cardNoTableAdapter.Fill(this.buildingDB1DataSet.CardNo);
      string newCardNo;
      if (this.buildingDB1DataSet.CardNo.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardNo.Rows)
        {
          int int32 = Convert.ToInt32(row.CardNo);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newCardNo = num5.ToString("D5");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Card No." + newCardNo + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newCardNo = (num3 + 1).ToString("D5");
      return newCardNo;
    }

    public string GetNew_ClientID(ComboBox para_ComboBox, bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999999;
            num3 = 5001 - 1;
          }
          else
          {
            num2 = 4000;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000000;
          if (para_GuestFlag)
          {
            num2 = 9999999 + num4;
            num3 = 5001 + num4 - 1;
            break;
          }
          num2 = 4000 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.clientTableAdapter.Fill(this.buildingDB1DataSet.Client);
      this.clientAccTableAdapter.Fill(this.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.ClientAcc.Rows)
        para_ComboBox.Items.Add((object) row.ClientID);
      para_ComboBox.SelectedIndex = 0;
      string newClientId;
      if (this.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.ClientAcc.Rows)
        {
          int int32 = Convert.ToInt32(row.ClientID);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newClientId = num5.ToString("D8");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Client ID " + newClientId + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newClientId = (num3 + 1).ToString("D8");
      return newClientId;
    }

    public string GetNew_ClientID(bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999999;
            num3 = 5001 - 1;
          }
          else
          {
            num2 = 4000;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000000;
          if (para_GuestFlag)
          {
            num2 = 9999999 + num4;
            num3 = 5001 + num4 - 1;
            break;
          }
          num2 = 4000 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.clientTableAdapter.Fill(this.buildingDB1DataSet.Client);
      this.clientAccTableAdapter.Fill(this.buildingDB1DataSet.ClientAcc);
      string newClientId;
      if (this.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.ClientAcc.Rows)
        {
          int int32 = Convert.ToInt32(row.ClientID);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newClientId = num5.ToString("D8");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Client ID " + newClientId + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newClientId = (num3 + 1).ToString("D8");
      return newClientId;
    }

    public int GetNew_TransID(ComboBox para_ComboBox, int Para_Bld_Num)
    {
      int num = 0;
      this.cardTransTableAdapter.Fill(this.buildingDB1DataSet.CardTrans);
      foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardTrans.Rows)
        para_ComboBox.Items.Add((object) row.TransID);
      para_ComboBox.SelectedIndex = 0;
      int newTransId;
      if (this.buildingDB1DataSet.CardTrans.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardTrans.Rows)
        {
          int int32 = Convert.ToInt32(row.TransID);
          if (int32 > num)
            num = int32;
        }
        newTransId = num + 1;
      }
      else
        newTransId = num + 1;
      return newTransId;
    }

    public int GetNew_TransID(int Para_Bld_Num)
    {
      int num = 0;
      this.cardTransTableAdapter.Fill(this.buildingDB1DataSet.CardTrans);
      int newTransId;
      if (this.buildingDB1DataSet.CardTrans.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardTrans.Rows)
        {
          int int32 = Convert.ToInt32(row.TransID);
          if (int32 > num)
            num = int32;
        }
        newTransId = num + 1;
      }
      else
        newTransId = num + 1;
      return newTransId;
    }

    public int GetNew_TransID(string Para_Bld_Num)
    {
      int num = 0;
      this.cardTransTableAdapter.Fill(this.buildingDB1DataSet.CardTrans);
      int newTransId;
      if (this.buildingDB1DataSet.CardTrans.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.buildingDB1DataSet.CardTrans.Rows)
        {
          int int32 = Convert.ToInt32(row.TransID);
          if (int32 > num)
            num = int32;
        }
        newTransId = num + 1;
      }
      else
        newTransId = num + 1;
      return newTransId;
    }
  }
}
