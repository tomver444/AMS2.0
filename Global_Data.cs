// Decompiled with JetBrains decompiler
// Type: AMS.Global_Data
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal static class Global_Data
  {
    private const string default_System_Pass_String = "8F39010146AA0101";
    public static bool NewDate_NewCheckIn_FirstPerson_Flag = false;
    public static COMM_Port_Setup1 Comm_Form_Ptr;
    public static byte COM_NUM = 0;
    public static int COM_PORTS_COUNT = 0;
    public static int OLD_COM_PORTS_COUNT = 0;
    public static int iView = 0;
    public static bool Card_Reader_Found_Flag = false;
    public static string Card_AutoNumber = "FFFFFFFFFFFFFFFF";
    public static string Card_HW_ID = "FFFFFFFFFFFFFFFF";
    public static string Card_Reader_ID = "FFFFFFFFFFFFFFFF";
    public static string CheckOut_Time = "12:45";
    public static bool bRecordSorting = false;
    public static bool bSummary = false;
    public static string Report_Form_Title = "";
    public static string System_Pas_String = "8F39010146AA0101";
    public static bool bCurrent = false;
    public static string sRDate = "";
    public static string sRYear = "";
    public static string sSDate = "";
    public static string sEDate = "";
    public static short iPrint = 1;
    public static short iReport = 0;
    public static string sBuildingName = "";
    public static string sBldNo;
    public static string ReportCalendar_Text = "";
    public static string gInTime = "";
    public static string gOutTime = "";

    public static void Set_Green_COM_Connection_StateColor()
    {
      ModDoorLockSystem.Form_MainDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      ModDoorLockSystem.Form_OperationDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      ModDoorLockSystem.Form_AdminDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      ModDoorLockSystem.Form_IssueGuestCard_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      ModDoorLockSystem.Form_IssueCardDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_Green;
      Global_Data.Card_Reader_Found_Flag = true;
    }

    public static void Set_Red_COM_Connection_StateColor()
    {
      ModDoorLockSystem.Form_MainDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      ModDoorLockSystem.Form_OperationDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      ModDoorLockSystem.Form_AdminDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      ModDoorLockSystem.Form_IssueGuestCard_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      ModDoorLockSystem.Form_IssueCardDMS_Ptr.pictureBox_COMM_Color.Image = (Image) Resources.COM_RED;
      Global_Data.Card_Reader_Found_Flag = false;
    }

    public static bool Auto_Select_COM_PORT_For_CardReader()
    {
      bool flag = false;
      Global_Data.COM_PORTS_COUNT = Global_Data.Comm_Form_Ptr.Get_Port_List_And_SetDefault();
      Global_Data.OLD_COM_PORTS_COUNT = Global_Data.COM_PORTS_COUNT;
      string comPort = Global_Data.Comm_Form_Ptr.COM_PORT;
      if (Global_Data.COM_PORTS_COUNT > 0)
      {
        if (Global_Data.Check_CardReader_Found())
        {
          if (Global_Data.Comm_Form_Ptr.COM_PORT != " ")
          {
            flag = true;
          }
          else
          {
            int num1 = (int) MessageBox.Show("Check_CardReader_Found success! but no COM_PORT name!");
          }
        }
        if (!flag && Global_Data.COM_PORTS_COUNT > 1)
        {
          for (int index = 0; index < Global_Data.Comm_Form_Ptr.COMM_Port_Names.Length; ++index)
          {
            if (comPort != Global_Data.Comm_Form_Ptr.COMM_Port_Names[index])
            {
              Global_Data.Comm_Form_Ptr.Select_COM_Port_Name(Global_Data.Comm_Form_Ptr.COMM_Port_Names[index]);
              if (Global_Data.Check_CardReader_Found())
              {
                if (Global_Data.Comm_Form_Ptr.COM_PORT != " ")
                {
                  flag = true;
                  break;
                }
                int num2 = (int) MessageBox.Show("Check_CardReader_Found success! but no COM_PORT name!");
              }
            }
          }
        }
        if (flag)
          return true;
      }
      return false;
    }

    public static bool Check_CardReader_Found()
    {
      if (!Global_Data.Check_COM_Port_Num())
        return false;
      try
      {
        return SmartCard_Procedures.ReadFKQscDate((int) Global_Data.COM_NUM) && SmartCard_Procedures.Card_Information_String.Length > 0;
      }
      catch
      {
        return false;
      }
    }

    public static bool Check_COM_Port_Num()
    {
      if (Global_Data.Comm_Form_Ptr.COM_NUM != (byte) 0)
      {
        Global_Data.COM_NUM = Global_Data.Comm_Form_Ptr.COM_NUM;
        return true;
      }
      Global_Data.COM_NUM = Global_Data.Comm_Form_Ptr.COM_NUM;
      return false;
    }
  }
}
