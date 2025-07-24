// Decompiled with JetBrains decompiler
// Type: AMS.Staff_DB
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.StaffDataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class Staff_DB
  {
    public StaffDataSet staffDataSet;
    public StaffTableAdapter staffTableAdapter;

    public Staff_DB()
    {
      this.staffDataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.staffDataSet;
      this.staffTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.staffTableAdapter;
    }
  }
}
