// Decompiled with JetBrains decompiler
// Type: AMS.ClsRoomType
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Data;

#nullable disable
namespace AMS
{
  internal static class ClsRoomType
  {
    public static byte RoomType = 0;
    public static string RmDescription = "";
    public static byte MaxCard = 0;
    public static byte MinCard = 0;
    public static string StaffID = "";

    public static bool FoundIt(DB para_DB, byte para_RoomType)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) para_DB.system_DB.systemDataSet.RoomType.Rows)
        {
          if ((int) row.RoomType == (int) para_RoomType)
          {
            flag = true;
            break;
          }
        }
      }
      return flag;
    }

    public static bool SaveIt(DB para_DB, byte para_RoomType)
    {
      bool flag1 = false;
      bool flag2 = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) para_DB.system_DB.systemDataSet.RoomType.Rows)
        {
          if ((int) row.RoomType == (int) para_RoomType)
          {
            row.RoomType = Convert.ToByte(ClsRoomType.RoomType);
            row.RmDescription = ClsRoomType.RmDescription;
            row.MaxCard = Convert.ToByte(ClsRoomType.MaxCard);
            row.MinCard = Convert.ToByte(ClsRoomType.MinCard);
            row.StaffID = ClsRoomType.StaffID;
            flag1 = true;
            break;
          }
        }
      }
      if (!flag1)
      {
        SystemDataSet.RoomTypeRow row = para_DB.system_DB.systemDataSet.RoomType.NewRoomTypeRow();
        row.RoomType = Convert.ToByte(ClsRoomType.RoomType);
        row.RmDescription = ClsRoomType.RmDescription;
        row.MaxCard = Convert.ToByte(ClsRoomType.MaxCard);
        row.MinCard = Convert.ToByte(ClsRoomType.MinCard);
        row.StaffID = ClsRoomType.StaffID;
        para_DB.system_DB.systemDataSet.RoomType.AddRoomTypeRow(row);
      }
      if (para_DB.system_DB.roomTypeTableAdapter.Update(para_DB.system_DB.systemDataSet.RoomType) > 0)
        flag2 = true;
      return flag2;
    }

    public static bool DeleteIt(DB para_DB, byte para_RoomType)
    {
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) para_DB.system_DB.systemDataSet.RoomType.Rows)
        {
          if ((int) row.RoomType == (int) para_RoomType)
            return para_DB.system_DB.roomTypeTableAdapter.Delete(new byte?(para_RoomType)) > 0;
        }
      }
      return false;
    }

    public static bool ReadIt(DB para_DB, byte para_RoomType)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) para_DB.system_DB.systemDataSet.RoomType.Rows)
        {
          if ((int) row.RoomType == (int) para_RoomType)
          {
            ClsRoomType.RoomType = row.RoomType;
            ClsRoomType.RmDescription = row.RmDescription;
            ClsRoomType.MaxCard = row.MaxCard;
            ClsRoomType.MinCard = row.MinCard;
            ClsRoomType.StaffID = row.StaffID;
            flag = true;
            break;
          }
        }
      }
      return flag;
    }

    public static bool MovePrevious1(DB para_DB, byte para_currentRoomType)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        for (int index = 0; index < para_DB.system_DB.systemDataSet.RoomType.Rows.Count; ++index)
        {
          if ((int) ((SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[index]).RoomType == (int) para_currentRoomType)
          {
            if (index > 0)
            {
              SystemDataSet.RoomTypeRow row = (SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[index - 1];
              ClsRoomType.RoomType = row.RoomType;
              ClsRoomType.RmDescription = row.RmDescription;
              ClsRoomType.MaxCard = row.MaxCard;
              ClsRoomType.MinCard = row.MinCard;
              ClsRoomType.StaffID = row.StaffID;
              flag = true;
              break;
            }
            break;
          }
        }
      }
      return flag;
    }

    public static bool MoveNext(DB para_DB, byte para_currentRoomType)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        for (int index = 0; index < para_DB.system_DB.systemDataSet.RoomType.Rows.Count; ++index)
        {
          if ((int) ((SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[index]).RoomType == (int) para_currentRoomType)
          {
            if (index < para_DB.system_DB.systemDataSet.RoomType.Rows.Count - 1)
            {
              SystemDataSet.RoomTypeRow row = (SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[index + 1];
              ClsRoomType.RoomType = row.RoomType;
              ClsRoomType.RmDescription = row.RmDescription;
              ClsRoomType.MaxCard = row.MaxCard;
              ClsRoomType.MinCard = row.MinCard;
              ClsRoomType.StaffID = row.StaffID;
              flag = true;
              break;
            }
            break;
          }
        }
      }
      return flag;
    }

    public static bool MoveFirst(DB para_DB)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        SystemDataSet.RoomTypeRow row = (SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[0];
        ClsRoomType.RoomType = row.RoomType;
        ClsRoomType.RmDescription = row.RmDescription;
        ClsRoomType.MaxCard = row.MaxCard;
        ClsRoomType.MinCard = row.MinCard;
        ClsRoomType.StaffID = row.StaffID;
        flag = true;
      }
      return flag;
    }

    public static bool MoveLast1(DB para_DB)
    {
      bool flag = false;
      para_DB.system_DB.roomTypeTableAdapter.Fill(para_DB.system_DB.systemDataSet.RoomType);
      if (para_DB.system_DB.systemDataSet.RoomType.Count > 0)
      {
        SystemDataSet.RoomTypeRow row = (SystemDataSet.RoomTypeRow) para_DB.system_DB.systemDataSet.RoomType.Rows[para_DB.system_DB.systemDataSet.RoomType.Count - 1];
        ClsRoomType.RoomType = row.RoomType;
        ClsRoomType.RmDescription = row.RmDescription;
        ClsRoomType.MaxCard = row.MaxCard;
        ClsRoomType.MinCard = row.MinCard;
        ClsRoomType.StaffID = row.StaffID;
        flag = true;
      }
      return flag;
    }
  }
}
