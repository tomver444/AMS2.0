// Decompiled with JetBrains decompiler
// Type: AMS.ErradjustDB
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.ErradjustDBDataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class ErradjustDB
  {
    public ErradjustDBDataSet erradjustDBDataSet;
    public ErradjustTableAdapter erradjustTableAdapter;

    public ErradjustDB()
    {
      this.erradjustDBDataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.erradjustDBDataSet;
      this.erradjustTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.erradjustTableAdapter;
    }
  }
}
