// Decompiled with JetBrains decompiler
// Type: AMS.Program
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Global_Data.Comm_Form_Ptr = new COMM_Port_Setup1();
      Application.Run((Form) new Form_StartDMS());
      if (!ModDoorLockSystem.Continue_flag)
        return;
      Application.Run((Form) ModDoorLockSystem.Form_LoginDMS_Ptr);
    }
  }
}
