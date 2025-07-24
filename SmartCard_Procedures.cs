// Decompiled with JetBrains decompiler
// Type: AMS.SmartCard_Procedures
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class SmartCard_Procedures
  {
    public static string[] Card_Code_String_Arr = new string[18]
    {
      Card_Type_Code.Authorization_card,
      Card_Type_Code.Guest_card_limit_card,
      Card_Type_Code.Room_setting_card,
      Card_Type_Code.Times_setting_card,
      Card_Type_Code.Region_setting_card,
      Card_Type_Code.Cleaning_Card,
      Card_Type_Code.Loss_card,
      Card_Type_Code.Loss_recovery_card,
      Card_Type_Code.Limited_room_card,
      Card_Type_Code.Recovery_room_card,
      Card_Type_Code.Acquisition_Card,
      Card_Type_Code.Guest_card,
      Card_Type_Code.Floor_card,
      Card_Type_Code.Area_Region_card,
      Card_Type_Code.Chief_card,
      Card_Type_Code.Emergency_card,
      Card_Type_Code.Building_card,
      Card_Type_Code.Spare_Card
    };
    public static ulong Card_ID16_Data;
    public static string Card_ID_String;
    public static ulong Card_Number_Data;
    public static string Card_Number_String;
    public static string Card_Information_String;

    public static bool ReadSysPasInformation(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      if (Win32_CardReader.ReadSysPasCard(Para_Arr) != 0)
      {
        Win32_CardReader.CLOSE_COM();
        int num = (int) MessageBox.Show("Authorization Card Is Not Found!");
        return false;
      }
      ulong num1 = 0;
      for (int index = 0; index < 16; ++index)
        num1 = num1 << 4 | Convert.ToUInt64(Convert.ToChar(Para_Arr[index]).ToString(), 16);
      Global_Data.System_Pas_String = string.Format("{0:X}", (object) num1);
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool ReadCardID(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[17];
      try
      {
        if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
          return false;
      }
      catch
      {
        int num = (int) MessageBox.Show("Can Not OPEN_COM!");
      }
      try
      {
        if (Win32_CardReader.CardID16(Para_Arr) != 0)
        {
          Win32_CardReader.CLOSE_COM();
          return false;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("CardID16 Failed! May be COM Port Error!");
      }
      ulong num1 = 0;
      for (int index = 0; index < 16; ++index)
        num1 = num1 << 4 | Convert.ToUInt64(Convert.ToChar(Para_Arr[index]).ToString(), 16);
      SmartCard_Procedures.Card_ID_String = string.Format("{0:X}", (object) num1);
      Win32_CardReader.CLOSE_COM();
      SmartCard_Procedures.Card_ID16_Data = num1;
      return true;
    }

    public static bool ReadCardNumber(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      if (Win32_CardReader.ReadCardID(Para_Arr) != 0)
      {
        Win32_CardReader.CLOSE_COM();
        return false;
      }
      ulong num = 0;
      for (int index = 0; index < 16; ++index)
        num = num << 4 | Convert.ToUInt64(Convert.ToChar(Para_Arr[index]).ToString(), 16);
      SmartCard_Procedures.Card_Number_String = string.Format("{0:X16}", (object) num);
      Win32_CardReader.CLOSE_COM();
      SmartCard_Procedures.Card_Number_Data = num;
      return true;
    }

    public static bool ReadCard_Information(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[52];
      Para_Arr[50] = Convert.ToSByte('$');
      Para_Arr[51] = Convert.ToSByte('$');
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      if (Win32_CardReader.myReadCard(Para_Arr) != 0)
      {
        Win32_CardReader.CLOSE_COM();
        return false;
      }
      string str = "";
      for (int index = 0; index < 52; ++index)
        str += Convert.ToChar(Para_Arr[index]).ToString();
      SmartCard_Procedures.Card_Information_String = str;
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_RoomSettings_Card(int Para_COM_Port_Num, string para_string)
    {
      sbyte[] Para_Arr = new sbyte[80];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string.ToCharArray()[index]);
      if (Win32_CardReader.myRFroomCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
        return false;
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Guest_Card(int Para_COM_Port_Num, string para_string)
    {
      sbyte[] Para_Arr = new sbyte[80];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string.ToCharArray()[index]);
      bool flag = Win32_CardReader.myRFGuestCard(Para_Arr) == 0;
      Win32_CardReader.CLOSE_COM();
      return flag;
    }

    public static bool Make_Time_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[11];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFtimeCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Chief_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFChiefCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Clean_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFclearCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Emergency_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFEmerCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_LimitGuest_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFGstStopCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Loss_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFlossCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Building_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[11];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFBuidingCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Floor_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[61];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFfloorCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_AreaRegion_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[37];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFareaCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Acquisition_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFFinaCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_LossRecovery_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFQlossCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Spare_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      if (Win32_CardReader.myRFBackCard(Para_Arr) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_RegionSetting_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      if (Win32_CardReader.myRFdefAreaCard(Para_Arr, Para_Arr2) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_RecoveryRoom_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2,
      string para_string3,
      string para_string4)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[3];
      sbyte[] Para_Arr3 = new sbyte[4];
      sbyte[] Para_Arr4 = new sbyte[5];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      for (int index = 0; index < para_string3.Length; ++index)
        Para_Arr3[index] = Convert.ToSByte(para_string3.ToCharArray()[index]);
      for (int index = 0; index < para_string4.Length; ++index)
        Para_Arr4[index] = Convert.ToSByte(para_string4.ToCharArray()[index]);
      if (Win32_CardReader.myRFRomStartCard(Para_Arr, Para_Arr2, Para_Arr3, Para_Arr4) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_LimitedRoom_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2,
      string para_string3,
      string para_string4)
    {
      sbyte[] Para_Arr = new sbyte[17];
      sbyte[] Para_Arr2 = new sbyte[3];
      sbyte[] Para_Arr3 = new sbyte[4];
      sbyte[] Para_Arr4 = new sbyte[5];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      for (int index = 0; index < para_string2.Length; ++index)
        Para_Arr2[index] = Convert.ToSByte(para_string2.ToCharArray()[index]);
      for (int index = 0; index < para_string3.Length; ++index)
        Para_Arr3[index] = Convert.ToSByte(para_string3.ToCharArray()[index]);
      for (int index = 0; index < para_string4.Length; ++index)
        Para_Arr4[index] = Convert.ToSByte(para_string4.ToCharArray()[index]);
      if (Win32_CardReader.myRFRomStopCard(Para_Arr, Para_Arr2, Para_Arr3, Para_Arr4) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Authorization_Card(
      int Para_COM_Port_Num,
      string para_string1,
      string para_string2)
    {
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      if (Win32_CardReader.makeSysPasCard((int) Convert.ToInt16(para_string1), (int) Convert.ToInt16(para_string2)) != 0)
      {
        int num = (int) MessageBox.Show("Failed!");
      }
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool Make_Empty_Card(int Para_COM_Port_Num, string para_string1)
    {
      sbyte[] Para_Arr = new sbyte[17];
      if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
        return false;
      for (int index = 0; index < para_string1.Length; ++index)
        Para_Arr[index] = Convert.ToSByte(para_string1.ToCharArray()[index]);
      bool flag;
      if (Win32_CardReader.WriteCardXX(Para_Arr) == 0)
      {
        flag = true;
      }
      else
      {
        int num = (int) MessageBox.Show("Failed!");
        flag = false;
      }
      Win32_CardReader.CLOSE_COM();
      return flag;
    }

    public static bool ReadFKQsc(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[65];
      try
      {
        if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
          return false;
      }
      catch
      {
        int num = (int) MessageBox.Show("Can Not OPEN_COM!");
      }
      try
      {
        if (Win32_CardReader.ReadFKQsc(Para_Arr) != 0)
        {
          Win32_CardReader.CLOSE_COM();
          return false;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("ReadFKQsc Failed! May be COM Port Error!");
      }
      ulong num1 = 0;
      int index = 0;
      while (Para_Arr[index] != (sbyte) 0)
      {
        try
        {
          num1 = num1 << 4 | Convert.ToUInt64(Convert.ToChar(Para_Arr[index]).ToString(), 16);
          ++index;
        }
        catch
        {
          break;
        }
      }
      string str;
      try
      {
        str = string.Format("{0:X}", (object) num1);
      }
      catch
      {
        str = "Not success!";
      }
      SmartCard_Procedures.Card_Information_String = str;
      Win32_CardReader.CLOSE_COM();
      SmartCard_Procedures.Card_ID16_Data = num1;
      return true;
    }

    public static bool ReadFKQscDate(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[65];
      string str = "";
      try
      {
        if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
          return false;
      }
      catch
      {
        int num = (int) MessageBox.Show("Can Not OPEN_COM!");
      }
      try
      {
        if (Win32_CardReader.ReadFKQscDate(Para_Arr) != 0)
        {
          SmartCard_Procedures.Card_Information_String = "";
          Win32_CardReader.CLOSE_COM();
          return true;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("ReadFKQscDate Failed! May be COM Port Error!");
      }
      int index = 0;
      while (Para_Arr[index] != (sbyte) 0)
      {
        try
        {
          str += Convert.ToChar(Para_Arr[index]).ToString();
          ++index;
        }
        catch
        {
          break;
        }
      }
      SmartCard_Procedures.Card_Information_String = str.Length <= 0 ? "Reader Not Connected In this Port" : str;
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public static bool ReadFKQDate(int Para_COM_Port_Num)
    {
      sbyte[] Para_Arr = new sbyte[65];
      string str = "";
      try
      {
        if (Win32_CardReader.OPEN_COM(Para_COM_Port_Num) != 0)
          return false;
      }
      catch
      {
        int num = (int) MessageBox.Show("Can Not OPEN_COM!");
      }
      try
      {
        if (Win32_CardReader.ReadFKQdate(Para_Arr) != 0)
        {
          SmartCard_Procedures.Card_Information_String = "";
          Win32_CardReader.CLOSE_COM();
          return true;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("ReadFKQDate Failed! May be COM Port Error!");
      }
      int index = 0;
      while (Para_Arr[index] != (sbyte) 0)
      {
        try
        {
          str += Convert.ToChar(Para_Arr[index]).ToString();
          ++index;
        }
        catch
        {
          break;
        }
      }
      SmartCard_Procedures.Card_Information_String = str;
      Win32_CardReader.CLOSE_COM();
      return true;
    }

    public enum Card_Type_Index
    {
      Authorization_card,
      Guest_card_limit_card,
      Room_setting_card,
      Times_setting_card,
      Region_setting_card,
      Cleaning_Card,
      Loss_card,
      Loss_recovery_card,
      Limited_room_card,
      Recovery_room_card,
      Acquisition_Card,
      Guest_card,
      Floor_card,
      Area_Region_card,
      Chief_card,
      Emergency_card,
      Building_card,
      Spare_Card,
    }
  }
}
