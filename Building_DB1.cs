// Decompiled with JetBrains decompiler
// Type: AMS.Building_DB1
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.BuildingDB1DataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class Building_DB1
  {
    public BuildingDB1DataSet buildingDB1DataSet;
    public CardTransTableAdapter cardTransTableAdapter;
    public CardNoTableAdapter cardNoTableAdapter;
    public ClientTableAdapter clientTableAdapter;
    public ClientAccTableAdapter clientAccTableAdapter;
    public AllLockedRecordTableAdapter allLockedRecordTableAdapter;
    public EventLogTableAdapter eventLogTableAdapter;
    public ExtraChargeTableAdapter extraChargeTableAdapter;
    public KeyChargesTableAdapter keyChargesTableAdapter;
    public LastTransTableAdapter lastTransTableAdapter;
    public LockedRecordTableAdapter lockedRecordTableAdapter;
    public LogInOutTableAdapter logInOutTableAdapter;
    public ReserveTableAdapter reserveTableAdapter;
    public RoomStatusTableAdapter roomStatusTableAdapter;
    public UnitRefTableAdapter unitRefTableAdapter;

    public Building_DB1()
    {
      this.buildingDB1DataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.buildingDB1DataSet;
      this.cardTransTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardTransTableAdapter;
      this.cardNoTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.cardNoTableAdapter;
      this.clientTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientTableAdapter;
      this.clientAccTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter;
      this.allLockedRecordTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.allLockedRecordTableAdapter;
      this.eventLogTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.eventLogTableAdapter;
      this.extraChargeTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.extraChargeTableAdapter;
      this.keyChargesTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.keyChargesTableAdapter;
      this.lastTransTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.lastTransTableAdapter;
      this.lockedRecordTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.lockedRecordTableAdapter;
      this.logInOutTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.logInOutTableAdapter;
      this.reserveTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.reserveTableAdapter;
      this.roomStatusTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.roomStatusTableAdapter;
      this.unitRefTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.unitRefTableAdapter;
    }
  }
}
