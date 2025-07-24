// Decompiled with JetBrains decompiler
// Type: AMS.BankingDB
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.BankingDBDataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class BankingDB
  {
    public BankingDBDataSet bankingDBDataSet;
    public BankingTableAdapter bankingTableAdapter;

    public BankingDB()
    {
      this.bankingDBDataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bankingDBDataSet;
      this.bankingTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bankingTableAdapter;
    }
  }
}
