// Decompiled with JetBrains decompiler
// Type: AMS.Win32_CardReader
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System.Runtime.InteropServices;

#nullable disable
namespace AMS
{
  public class Win32_CardReader
  {
    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int OPEN_COM(int Port_Num);

    [DllImport("scRFwt7.dll")]
    public static extern int CLOSE_COM();

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int ReadSysPasCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int CardID16(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myReadCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int ReadCardID(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFroomCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFGuestCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFtmpCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFChiefCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFBuidingCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFfloorCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFFinaCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFEmerCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFlossCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFBackCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFareaCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFdefAreaCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFclearCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFQlossCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFRomStopCard(
      sbyte[] Para_Arr,
      sbyte[] Para_Arr2,
      sbyte[] Para_Arr3,
      sbyte[] Para_Arr4);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFRomStartCard(
      sbyte[] Para_Arr,
      sbyte[] Para_Arr2,
      sbyte[] Para_Arr3,
      sbyte[] Para_Arr4);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFGstStopCard(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int myRFtimeCard(sbyte[] Para_Arr, sbyte[] Para_Arr2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int makeSysPasCard(int Para_Int1, int Para_Int2);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int WriteCardXX(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int pasWriteCardXX(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int ReadFKQsc(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int ReadFKQscDate(sbyte[] Para_Arr);

    [DllImport("scRFwt7.dll", CharSet = CharSet.Auto)]
    public static extern int ReadFKQdate(sbyte[] Para_Arr);
  }
}
