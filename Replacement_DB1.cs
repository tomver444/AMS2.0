// Decompiled with JetBrains decompiler
// Type: AMS.Replacement_DB1
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.ReplacementDB1DataSetTableAdapters;

#nullable disable
namespace AMS
{
  internal class Replacement_DB1
  {
    public ReplacementDB1DataSet replacementDB1DataSet;
    public ReplacementTableAdapter replacementTableAdapter;

    public Replacement_DB1()
    {
      this.replacementDB1DataSet = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.replacementDB1DataSet;
      this.replacementTableAdapter = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.replacementTableAdapter;
    }
  }
}
