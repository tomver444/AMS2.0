// Decompiled with JetBrains decompiler
// Type: AMS.D1
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System.Runtime.InteropServices;

#nullable disable
namespace AMS
{
  public class D1
  {
    public static byte[] data = new byte[1]{ (byte) 170 };

    [DllImport("d1.dll", CharSet = CharSet.Auto)]
    public static extern void encrypt(byte[] para_PlainText);

    [DllImport("d1.dll", CharSet = CharSet.Auto)]
    public static extern void decrypt(byte[] para_PlainText);
  }
}
