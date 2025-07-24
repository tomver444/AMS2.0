// Decompiled with JetBrains decompiler
// Type: AMS.Issue_Card_Class
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  internal class Issue_Card_Class
  {
    public DB db;
    private IContainer components;
    public BuildingDB1DataSet.CardNoRow CardNo_Row_Buffer;
    public BuildingDB1DataSet.ClientRow Client_Row_Buffer;
    public BuildingDB1DataSet.ClientAccRow ClientAcc_Row_Buffer;
    public BuildingDB1DataSet.CardTransRow CardTrans_Row_Buffer;

    public Issue_Card_Class()
    {
      this.InitializeComponent();
      this.db = new DB();
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      this.db.building_DB1.cardTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardTrans);
      this.CardNo_Row_Buffer = this.db.building_DB1.buildingDB1DataSet.CardNo.NewCardNoRow();
      this.Client_Row_Buffer = this.db.building_DB1.buildingDB1DataSet.Client.NewClientRow();
      this.ClientAcc_Row_Buffer = this.db.building_DB1.buildingDB1DataSet.ClientAcc.NewClientAccRow();
      this.CardTrans_Row_Buffer = this.db.building_DB1.buildingDB1DataSet.CardTrans.NewCardTransRow();
    }

    public bool Write_CardNo_Table()
    {
      bool flag = false;
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
      {
        if (row.CardNo == this.CardNo_Row_Buffer.CardNo)
        {
          foreach (DataColumn column in (InternalDataCollectionBase) this.CardNo_Row_Buffer.Table.Columns)
            row[column] = this.CardNo_Row_Buffer[column];
          flag = true;
          int num = (int) MessageBox.Show("This CardNo already existed!");
        }
      }
      if (flag)
        return false;
      this.db.building_DB1.buildingDB1DataSet.CardNo.AddCardNoRow(this.CardNo_Row_Buffer);
      return this.db.building_DB1.cardNoTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.CardNo) > 0;
    }

    public bool Write_Client_Table()
    {
      try
      {
        this.db.building_DB1.buildingDB1DataSet.Client.AddClientRow(this.Client_Row_Buffer);
        return this.db.building_DB1.clientTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.Client) > 0;
      }
      catch
      {
        int num = (int) MessageBox.Show("Client Table Update Failed!");
        return false;
      }
    }

    public bool Write_ClientAcc_Table()
    {
      try
      {
        this.db.building_DB1.buildingDB1DataSet.ClientAcc.AddClientAccRow(this.ClientAcc_Row_Buffer);
        return this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) > 0;
      }
      catch
      {
        int num = (int) MessageBox.Show("ClientAcc Table Update Failed!");
        return false;
      }
    }

    public bool Write_CardTrans_Table()
    {
      this.db.building_DB1.buildingDB1DataSet.CardTrans.AddCardTransRow(this.CardTrans_Row_Buffer);
      return this.db.building_DB1.cardTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.CardTrans) > 0;
    }

    public string GetNew_CardNo(ComboBox para_ComboBox, bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999;
            num3 = 1001 - 1;
          }
          else
          {
            num2 = 900;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000;
          if (para_GuestFlag)
          {
            num2 = 9999 + num4;
            num3 = 501 + num4 - 1;
            break;
          }
          num2 = 400 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
        para_ComboBox.Items.Add((object) row.CardNo);
      para_ComboBox.SelectedIndex = 0;
      string newCardNo;
      if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
        {
          int int32 = Convert.ToInt32(row.CardNo);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newCardNo = num5.ToString("D5");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Card No." + newCardNo + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newCardNo = (num3 + 1).ToString("D5");
      return newCardNo;
    }

    public string GetNew_CardNo(bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999;
            num3 = 1001 - 1;
          }
          else
          {
            num2 = 900;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000;
          if (para_GuestFlag)
          {
            num2 = 9999 + num4;
            num3 = 501 + num4 - 1;
            break;
          }
          num2 = 400 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
      string newCardNo;
      if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
        {
          int int32 = Convert.ToInt32(row.CardNo);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newCardNo = num5.ToString("D5");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Card No." + newCardNo + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newCardNo = (num3 + 1).ToString("D5");
      return newCardNo;
    }

    public string GetNew_ClientID(ComboBox para_ComboBox, bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999999;
            num3 = 5001 - 1;
          }
          else
          {
            num2 = 4000;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000000;
          if (para_GuestFlag)
          {
            num2 = 9999999 + num4;
            num3 = 5001 + num4 - 1;
            break;
          }
          num2 = 4000 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        para_ComboBox.Items.Add((object) row.ClientID);
      para_ComboBox.SelectedIndex = 0;
      string newClientId;
      if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        {
          int int32 = Convert.ToInt32(row.ClientID);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newClientId = num5.ToString("D8");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Client ID " + newClientId + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newClientId = (num3 + 1).ToString("D8");
      return newClientId;
    }

    public string GetNew_ClientID(bool para_GuestFlag, int Para_Bld_Num)
    {
      int num1 = 0;
      int num2;
      int num3;
      switch (Para_Bld_Num)
      {
        case 0:
        case 1:
          if (para_GuestFlag)
          {
            num2 = 19999999;
            num3 = 5001 - 1;
          }
          else
          {
            num2 = 4000;
            num3 = 1 - 1;
          }
          num1 = 0;
          break;
        default:
          int num4 = Para_Bld_Num * 10000000;
          if (para_GuestFlag)
          {
            num2 = 9999999 + num4;
            num3 = 5001 + num4 - 1;
            break;
          }
          num2 = 4000 + num4;
          num3 = 1 + num4 - 1;
          break;
      }
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      string newClientId;
      if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        {
          int int32 = Convert.ToInt32(row.ClientID);
          if (int32 > num3 && int32 < num2)
            num3 = int32;
        }
        int num5 = num3 + 1;
        newClientId = num5.ToString("D8");
        if (num5 > num2)
        {
          int num6 = (int) MessageBox.Show("Out of Limit Error! Client ID " + newClientId + " is > " + num2.ToString());
          Application.Exit();
        }
      }
      else
        newClientId = (num3 + 1).ToString("D8");
      return newClientId;
    }

    public int GetNew_TransID(ComboBox para_ComboBox, int Para_Bld_Num)
    {
      int num = 0;
      this.db.building_DB1.cardTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardTrans);
      foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows)
        para_ComboBox.Items.Add((object) row.TransID);
      para_ComboBox.SelectedIndex = 0;
      int newTransId;
      if (this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows)
        {
          int int32 = Convert.ToInt32(row.TransID);
          if (int32 > num)
            num = int32;
        }
        newTransId = num + 1;
      }
      else
        newTransId = num + 1;
      return newTransId;
    }

    public int GetNew_TransID(int Para_Bld_Num)
    {
      int num = 0;
      this.db.building_DB1.cardTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardTrans);
      int newTransId;
      if (this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows)
        {
          int int32 = Convert.ToInt32(row.TransID);
          if (int32 > num)
            num = int32;
        }
        newTransId = num + 1;
      }
      else
        newTransId = num + 1;
      return newTransId;
    }

    public bool Write_Card() => true;

    private void InitializeComponent()
    {
    }
  }
}
