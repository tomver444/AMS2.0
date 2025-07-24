// Decompiled with JetBrains decompiler
// Type: AMS.Form_CancelReservationDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_CancelReservationDMS : Form
  {
    public string Reserve_Client_RefID = "";
    public bool Reserve_Client_OK_flag;
    private DB db = new DB();
    private Decimal sRefundAmount;
    private Decimal sDepositAmount;
    private IContainer components;
    public Button cmdPrint;
    public ToolTip ToolTip1;
    public Label Data1;
    public Button cmdViewReserveList;
    public TextBox txtReserve;
    public Button cmdReturn;
    public Button cmdClear;
    public Button cmdConfirm;
    public TextBox txtRefundAmount;
    public TextBox txtCancellationCharge;
    public TextBox txtDeposit;
    public TextBox txtClientID;
    public TextBox txtReservationRef;
    public TextBox txtBuildingNo;
    public Label Label12;
    public Label lblBuildingType;
    public Label Label11;
    public Label lblRType;
    public Label lblMessage;
    public Label lblRoomType;
    public Label lblRoomNo;
    public Label Label10;
    public Label Label9;
    public Label Label21;
    public Label Label18;
    public Label Label17;
    public Label lblFirstName;
    public Label Label4;
    public Label Label5;
    public Label lblSurName;
    public Label Label7;
    public Label Label8;
    public Label Label3;
    public Label Label2;
    public Label Label1;
    public Label Label6;
    public MaskedTextBox mskContractEnd;
    public MaskedTextBox mskContractStart;
    private PictureBox pictureBox1;

    public Form_CancelReservationDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
    }

    private void Form_CancelReservationDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void cmdViewReserveList_Click(object sender, EventArgs e)
    {
      this.db.Get_AccReservationList();
      int num = (int) new Form_ViewReserveListDMS().ShowDialog();
      this.Refresh();
      if (!this.Reserve_Client_OK_flag)
        return;
      this.txtReservationRef.Text = this.Reserve_Client_RefID;
      foreach (TempDataSet.AccReservationListRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.AccReservationList.Rows)
      {
        if (row.ReserveRef == this.Reserve_Client_RefID)
        {
          this.lblRoomNo.Text = row.RoomNo;
          this.txtBuildingNo.Text = this.lblRoomNo.Text.Substring(0, 1);
          this.lblBuildingType.Text = this.CheckBuildingType(this.txtBuildingNo.Text);
          this.txtClientID.Text = row.ClientID;
          this.lblFirstName.Text = row.ForeName;
          this.lblSurName.Text = row.SurName;
          this.txtDeposit.Text = row.Deposit.ToString();
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType = row.ReserveType;
          break;
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      }
      catch
      {
        this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      }
      if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
        {
          if (this.txtClientID.Text == row.ClientID)
            break;
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
          this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      catch
      {
        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      }
      if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
      {
        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
        {
          if (this.txtClientID.Text == row.ClientID)
          {
            this.mskContractEnd.Text = row.ContractEnd.ToShortDateString();
            this.mskContractStart.Text = row.ContractStart.ToShortDateString();
            break;
          }
        }
      }
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count <= 0)
          this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      catch
      {
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == this.lblRoomNo.Text)
        {
          this.lblRoomType.Text = this.Get_Room_Type_Description(row.RoomType);
          break;
        }
      }
      this.txtRefundAmount.Text = this.txtDeposit.Text;
      this.txtCancellationCharge.Text = "";
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType == "UNIT")
      {
        this.lblRType.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType;
        this.lblRType.Visible = true;
        this.Label12.Visible = true;
      }
      else
      {
        this.lblRType.Text = "";
        this.lblRType.Visible = false;
        this.Label12.Visible = false;
      }
      this.cmdConfirm.Enabled = true;
      this.cmdPrint.Enabled = false;
    }

    private string Get_Room_Type_Description(byte para_roomtype_num)
    {
      string roomTypeDescription = "";
      bool flag = false;
      this.db.system_DB.roomTypeTableAdapter.Fill(this.db.system_DB.systemDataSet.RoomType);
      foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.RoomType.Rows)
      {
        if ((int) row.RoomType == (int) para_roomtype_num)
        {
          roomTypeDescription = row.RmDescription;
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        int num = (int) MessageBox.Show("RoomType Table not Found!");
      }
      return roomTypeDescription;
    }

    public string CheckBuildingType(string para_BuildingNo)
    {
      string str = "";
      try
      {
        if (this.db.system_DB.systemDataSet.Building.Rows.Count <= 0)
          this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      catch
      {
        this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == para_BuildingNo)
        {
          str = row.BuildingType;
          break;
        }
      }
      return str;
    }

    private void txtCancellationCharge_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '.')
      {
        if (this.txtDeposit.Text.Contains("."))
          e.Handled = true;
        else
          e.Handled = false;
      }
      else
        e.Handled = true;
    }

    private void txtCancellationCharge_TextChanged(object sender, EventArgs e)
    {
      double num1;
      try
      {
        num1 = Convert.ToDouble(this.txtDeposit.Text);
      }
      catch
      {
        num1 = 0.0;
      }
      double num2;
      try
      {
        num2 = Convert.ToDouble(this.txtCancellationCharge.Text);
      }
      catch
      {
        num2 = 0.0;
      }
      this.txtRefundAmount.Text = (num1 - num2).ToString("F2");
    }

    private bool RoomStatusUpdate(string para_RoomNo)
    {
      int num1 = 0;
      bool flag1 = false;
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
      {
        if (((BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index]).RoomNo == para_RoomNo)
          ++num1;
      }
      int count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
      if (num1 > 1)
      {
        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
        {
          BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
          bool flag2;
          try
          {
            flag2 = row.ClientID == null;
          }
          catch
          {
            flag2 = true;
          }
          if (!flag2 && Mod_UpdateData.sChkClient == row.ClientID && para_RoomNo == row.RoomNo)
          {
            if (this.db.building_DB1.roomStatusTableAdapter.Delete(row.RoomNo) > 0)
            {
              flag1 = true;
              this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
              count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
              break;
            }
            flag1 = false;
            break;
          }
        }
        if (!flag1)
        {
          int num2 = (int) MessageBox.Show("Cannot delete duplicate RoomStatus row!");
          return false;
        }
      }
      bool flag3 = false;
      for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
      {
        BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
        bool flag4;
        try
        {
          flag4 = row.ClientID == null;
        }
        catch
        {
          flag4 = true;
        }
        if (!flag4 && row.ClientID == Mod_UpdateData.sChkClient)
        {
          if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType == "Unit")
          {
            if (para_RoomNo.Substring(1, 2) == row.RoomNo.Substring(1, 2))
            {
              row.Status = (byte) 0;
              row.Description = "Vacant";
              row.StartDate = DateTime.Now.Date;
              row.EndDate = DateTime.Now.Date;
              row.ClientID = "";
              row.Condition = "";
              row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
              row.Update = false;
              if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
              {
                if (!this.db.Update_RoomStausXX_inSystemDB(this.txtBuildingNo.Text))
                {
                  flag3 = false;
                  break;
                }
                flag3 = true;
              }
              else
                flag3 = false;
            }
          }
          else if (para_RoomNo == row.RoomNo)
          {
            row.Status = (byte) 0;
            row.Description = "Vacant";
            row.StartDate = DateTime.Now.Date;
            row.EndDate = DateTime.Now.Date;
            row.ClientID = "";
            row.Condition = "";
            row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
            row.Update = false;
            flag3 = this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0 && this.db.Update_RoomStausXX_inSystemDB(this.txtBuildingNo.Text);
            break;
          }
        }
      }
      if (flag3)
        return true;
      int num3 = (int) MessageBox.Show("Cannot Update RoomStatus row!");
      return false;
    }

    private bool Update_CardTrans_Table()
    {
      BuildingDB1DataSet.CardTransRow row = this.db.building_DB1.buildingDB1DataSet.CardTrans.NewCardTransRow();
      row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      row.ClientID = this.txtClientID.Text;
      row.RoomNo = this.lblRoomNo.Text;
      row.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType;
      row.ReserveRef = this.txtReservationRef.Text;
      row.TransType = "RC";
      row.TransDate = DateTime.Now.Date;
      row.TransTime = DateTime.Now.ToShortTimeString();
      row.ValidStart = DateTime.Parse(this.mskContractStart.Text).Date;
      row.ValidEnd = DateTime.Parse(this.mskContractEnd.Text).Date;
      try
      {
        row.ExtraCharge = Convert.ToDecimal(this.txtCancellationCharge.Text);
      }
      catch
      {
        row.ExtraCharge = 0M;
      }
      if (row.ExtraCharge != 0M)
        row.ExDescription = "Cancellation Charge";
      try
      {
        row.Deposit = Convert.ToDecimal(this.txtDeposit.Text) * -1M;
      }
      catch
      {
        row.Deposit = 0M;
      }
      try
      {
        row.LastPayment = Convert.ToDecimal(this.txtRefundAmount.Text) * -1M;
      }
      catch
      {
        row.LastPayment = 0M;
      }
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      row.Update = false;
      this.db.building_DB1.buildingDB1DataSet.CardTrans.AddCardTransRow(row);
      if (this.db.building_DB1.cardTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.CardTrans) > 0)
        return true;
      int num = (int) MessageBox.Show("CardTrans Table can not be updated!");
      return false;
    }

    private bool Update_LastTrans_Table()
    {
      this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      while (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count > 0)
      {
        this.db.building_DB1.lastTransTableAdapter.Delete(new int?(((BuildingDB1DataSet.LastTransRow) this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows[0]).TransID));
        this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
        if (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count == 0)
          break;
      }
      this.db.building_DB1.lastTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      BuildingDB1DataSet.LastTransRow row = this.db.building_DB1.buildingDB1DataSet.LastTrans.NewLastTransRow();
      row.RBA = 0M;
      row.Balance = 0M;
      row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      row.ClientID = this.txtClientID.Text;
      row.RoomNo = this.lblRoomNo.Text;
      row.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType;
      row.ReserveRef = this.txtReservationRef.Text;
      row.TransType = "RC";
      row.TransDate = DateTime.Now.Date;
      row.TransTime = DateTime.Now.ToShortTimeString();
      row.ValidStart = DateTime.Parse(this.mskContractStart.Text).Date;
      row.ValidEnd = DateTime.Parse(this.mskContractEnd.Text).Date;
      try
      {
        row.ExtraCharge = Convert.ToDecimal(this.txtCancellationCharge.Text);
      }
      catch
      {
        row.ExtraCharge = 0M;
      }
      if (row.ExtraCharge != 0M)
        row.ExDescription = "Cancellation Charge";
      try
      {
        row.Deposit = Convert.ToDecimal(this.txtDeposit.Text);
      }
      catch
      {
        row.Deposit = 0M;
      }
      try
      {
        row.LastPayment = Convert.ToDecimal(this.txtRefundAmount.Text);
      }
      catch
      {
        row.LastPayment = 0M;
      }
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.db.building_DB1.buildingDB1DataSet.LastTrans.AddLastTransRow(row);
      if (this.db.building_DB1.lastTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.LastTrans) > 0)
        return true;
      int num = (int) MessageBox.Show("LastTrans Table can not be updated!");
      return false;
    }

    private bool UPDATE_DATABASE()
    {
      if (!this.RoomStatusUpdate(Mod_UpdateData.sChkRoom))
      {
        int num = (int) MessageBox.Show("Sorry! Data Not Updated");
        return false;
      }
      if (!this.Update_CardTrans_Table())
      {
        int num = (int) MessageBox.Show("Sorry! Transaction Update Fail!");
        return false;
      }
      if (!this.Update_LastTrans_Table())
      {
        int num = (int) MessageBox.Show("Sorry! Last Transaction Update Fail!");
        return false;
      }
      bool flag1 = false;
      this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
      foreach (BuildingDB1DataSet.ReserveRow reserveRow in this.db.building_DB1.buildingDB1DataSet.Reserve)
      {
        if (reserveRow.ReserveRef == this.txtReservationRef.Text && reserveRow.RoomNo == this.lblRoomNo.Text)
        {
          if (this.db.building_DB1.reserveTableAdapter.Delete(this.txtReservationRef.Text) > 0)
          {
            flag1 = true;
            this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
            break;
          }
          flag1 = false;
          break;
        }
      }
      if (!flag1)
      {
        int num = (int) MessageBox.Show("Reserve Table Update Failed!");
        return false;
      }
      bool flag2 = false;
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          row.RoomNo = "";
          row.CardNo = "";
          row.Bond = 0M;
          row.Deposit = 0M;
          row.Remark = "";
          row.OldRoom = "";
          row.AdvancedPayment = 0M;
          row.LastPayment = 0M;
          row.AmountPaid = 0M;
          row.CheckOutDate = DateTime.Now.Date;
          row.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
          row.LastRecDate = DateTime.Now.Date;
          row.Update = false;
          flag2 = this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) > 0;
          break;
        }
      }
      if (!flag2)
      {
        int num = (int) MessageBox.Show("ClientAcc Table Update Failed!");
        return false;
      }
      Decimal num1;
      try
      {
        num1 = Convert.ToDecimal(this.txtCancellationCharge.Text);
      }
      catch
      {
        num1 = 0M;
      }
      if (num1 > 0M)
      {
        this.db.building_DB1.extraChargeTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ExtraCharge);
        BuildingDB1DataSet.ExtraChargeRow row = this.db.building_DB1.buildingDB1DataSet.ExtraCharge.NewExtraChargeRow();
        row.ReceiptID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
        row.ClientID = this.txtClientID.Text;
        row.ExDescription = "Cancellation Charge";
        row.ExtraCharge = num1;
        this.db.building_DB1.buildingDB1DataSet.ExtraCharge.AddExtraChargeRow(row);
        if (this.db.building_DB1.extraChargeTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ExtraCharge) <= 0)
        {
          int num2 = (int) MessageBox.Show("ExtraCharge Table Update Failed!");
          return false;
        }
      }
      return true;
    }

    private void cmdConfirm_Click(object sender, EventArgs e)
    {
      Mod_UpdateData.iChkStatus = 2;
      Mod_UpdateData.sChkRoom = this.lblRoomNo.Text;
      Mod_UpdateData.sChkClient = this.txtClientID.Text;
      if (this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || this.txtBuildingNo.Text == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
      {
        if (MessageBox.Show(" Check to make sure all Entries are Correct...", "COMFIRMATION ! Cancel Reservation   ", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.Refresh();
        int newTransId = this.db.GetNew_TransID(this.txtBuildingNo.Text);
        if (newTransId == -1)
        {
          int num1 = (int) MessageBox.Show("Can't Get TransID!");
        }
        else
        {
          bool flag = this.db.Backup_Before_Transact(this.txtBuildingNo.Text);
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
          if (this.UPDATE_DATABASE())
          {
            int num2 = (int) MessageBox.Show("Reserved Guest is successfully cancelled!");
            this.cmdConfirm.Enabled = false;
            this.cmdPrint.Enabled = true;
            this.cmdPrint.Focus();
            this.ClearScreen();
            this.cmdPrint.Enabled = true;
            this.cmdConfirm.Enabled = false;
          }
          else
          {
            int num3 = (int) MessageBox.Show("Reserved Guest Cancellation Failed!");
            if (!flag)
              return;
            this.db.Restore_For_FailedTransact(this.txtBuildingNo.Text);
          }
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Not Allow To Cancel Other's Building Reservation!");
      }
    }

    private void ClearScreen()
    {
      this.txtReservationRef.Text = "";
      this.txtClientID.Text = "";
      this.lblFirstName.Text = "";
      this.lblSurName.Text = "";
      this.lblRoomNo.Text = "";
      this.lblRoomType.Text = "";
      this.mskContractStart.Text = "____-__-__";
      this.mskContractEnd.Text = "____-__-__";
      this.txtDeposit.Text = "";
      this.txtCancellationCharge.Text = "";
      this.txtRefundAmount.Text = "";
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      if (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count <= 0)
        return;
      BuildingDB1DataSet.LastTransRow lastTran = this.db.building_DB1.buildingDB1DataSet.LastTrans[this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count - 1];
      string transType = lastTran.TransType;
      int transId = lastTran.TransID;
      this.Refresh();
      ReportForm reportForm = new ReportForm();
      ReportClass_Receipt_CancelReservation cancelReservation = new ReportClass_Receipt_CancelReservation();
      reportForm.crystalReportViewer1.ReportSource = cancelReservation.CHECK_TransType(transType, transId, Global_Data.sBldNo);
      int num = (int) reportForm.ShowDialog();
    }

    private void Form_CancelReservationDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.ClearScreen();
      this.cmdPrint.Enabled = false;
      this.cmdConfirm.Enabled = false;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      this.ClearScreen();
      this.cmdPrint.Enabled = false;
      this.cmdConfirm.Enabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_CancelReservationDMS));
      this.cmdPrint = new Button();
      this.Data1 = new Label();
      this.cmdViewReserveList = new Button();
      this.txtReserve = new TextBox();
      this.cmdReturn = new Button();
      this.cmdClear = new Button();
      this.cmdConfirm = new Button();
      this.txtRefundAmount = new TextBox();
      this.txtCancellationCharge = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtClientID = new TextBox();
      this.txtReservationRef = new TextBox();
      this.txtBuildingNo = new TextBox();
      this.Label12 = new Label();
      this.lblBuildingType = new Label();
      this.Label11 = new Label();
      this.lblRType = new Label();
      this.lblMessage = new Label();
      this.lblRoomType = new Label();
      this.lblRoomNo = new Label();
      this.Label10 = new Label();
      this.Label9 = new Label();
      this.Label21 = new Label();
      this.Label18 = new Label();
      this.Label17 = new Label();
      this.lblFirstName = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.lblSurName = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Label6 = new Label();
      this.mskContractEnd = new MaskedTextBox();
      this.mskContractStart = new MaskedTextBox();
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.cmdPrint.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(249, 460);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(105, 40);
      this.cmdPrint.TabIndex = 70;
      this.cmdPrint.Text = "&PRINT RECEIPT";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdPrint, "Click to Print Receipt");
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.Data1.BackColor = Color.Red;
      this.Data1.BorderStyle = BorderStyle.FixedSingle;
      this.Data1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Data1.ForeColor = Color.Black;
      this.Data1.Location = new Point(652, 476);
      this.Data1.Name = "Data1";
      this.Data1.Size = new Size(76, 23);
      this.Data1.TabIndex = 71;
      this.Data1.Text = "Data1";
      this.Data1.Visible = false;
      this.cmdViewReserveList.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdViewReserveList.Cursor = Cursors.Default;
      this.cmdViewReserveList.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdViewReserveList.ForeColor = SystemColors.ControlText;
      this.cmdViewReserveList.Image = (Image) componentResourceManager.GetObject("cmdViewReserveList.Image");
      this.cmdViewReserveList.Location = new Point(354, 140);
      this.cmdViewReserveList.Name = "cmdViewReserveList";
      this.cmdViewReserveList.RightToLeft = RightToLeft.No;
      this.cmdViewReserveList.Size = new Size(84, 65);
      this.cmdViewReserveList.TabIndex = 68;
      this.cmdViewReserveList.Text = "View Reserve List";
      this.cmdViewReserveList.TextAlign = ContentAlignment.BottomCenter;
      this.cmdViewReserveList.UseVisualStyleBackColor = false;
      this.cmdViewReserveList.Click += new EventHandler(this.cmdViewReserveList_Click);
      this.txtReserve.AcceptsReturn = true;
      this.txtReserve.BackColor = SystemColors.Window;
      this.txtReserve.Cursor = Cursors.IBeam;
      this.txtReserve.Enabled = false;
      this.txtReserve.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtReserve.ForeColor = Color.Red;
      this.txtReserve.Location = new Point(236, 148);
      this.txtReserve.MaxLength = 8;
      this.txtReserve.Name = "txtReserve";
      this.txtReserve.RightToLeft = RightToLeft.No;
      this.txtReserve.Size = new Size(33, 29);
      this.txtReserve.TabIndex = 67;
      this.txtReserve.Text = "R-";
      this.txtReserve.TextAlign = HorizontalAlignment.Center;
      this.txtReserve.Visible = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(484, 460);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(105, 40);
      this.cmdReturn.TabIndex = 66;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Operation Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdClear.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Location = new Point(367, 460);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(105, 40);
      this.cmdClear.TabIndex = 65;
      this.cmdClear.Text = "&CLEAR";
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "To Clear Screen Data");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.cmdConfirm.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdConfirm.Cursor = Cursors.Default;
      this.cmdConfirm.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdConfirm.ForeColor = SystemColors.ControlText;
      this.cmdConfirm.Location = new Point(132, 460);
      this.cmdConfirm.Name = "cmdConfirm";
      this.cmdConfirm.RightToLeft = RightToLeft.No;
      this.cmdConfirm.Size = new Size(105, 40);
      this.cmdConfirm.TabIndex = 61;
      this.cmdConfirm.Text = "CON&FIRM";
      this.ToolTip1.SetToolTip((Control) this.cmdConfirm, "Click Confirm to Cancel Reservation");
      this.cmdConfirm.UseVisualStyleBackColor = false;
      this.cmdConfirm.Click += new EventHandler(this.cmdConfirm_Click);
      this.txtRefundAmount.AcceptsReturn = true;
      this.txtRefundAmount.BackColor = SystemColors.Window;
      this.txtRefundAmount.Cursor = Cursors.IBeam;
      this.txtRefundAmount.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRefundAmount.ForeColor = Color.Red;
      this.txtRefundAmount.Location = new Point(540, 372);
      this.txtRefundAmount.MaxLength = 0;
      this.txtRefundAmount.Name = "txtRefundAmount";
      this.txtRefundAmount.ReadOnly = true;
      this.txtRefundAmount.RightToLeft = RightToLeft.No;
      this.txtRefundAmount.Size = new Size(73, 26);
      this.txtRefundAmount.TabIndex = 60;
      this.txtRefundAmount.TextAlign = HorizontalAlignment.Center;
      this.txtCancellationCharge.AcceptsReturn = true;
      this.txtCancellationCharge.BackColor = SystemColors.Window;
      this.txtCancellationCharge.Cursor = Cursors.IBeam;
      this.txtCancellationCharge.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCancellationCharge.ForeColor = Color.Blue;
      this.txtCancellationCharge.Location = new Point(220, 372);
      this.txtCancellationCharge.MaxLength = 0;
      this.txtCancellationCharge.Name = "txtCancellationCharge";
      this.txtCancellationCharge.RightToLeft = RightToLeft.No;
      this.txtCancellationCharge.Size = new Size(65, 26);
      this.txtCancellationCharge.TabIndex = 58;
      this.txtCancellationCharge.TextAlign = HorizontalAlignment.Center;
      this.txtCancellationCharge.TextChanged += new EventHandler(this.txtCancellationCharge_TextChanged);
      this.txtCancellationCharge.KeyPress += new KeyPressEventHandler(this.txtCancellationCharge_KeyPress);
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = SystemColors.Window;
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = SystemColors.WindowText;
      this.txtDeposit.Location = new Point(220, 324);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.ReadOnly = true;
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(65, 26);
      this.txtDeposit.TabIndex = 51;
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.txtClientID.Location = new Point(540, 148);
      this.txtClientID.MaxLength = 8;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(105, 29);
      this.txtClientID.TabIndex = 43;
      this.txtClientID.TextAlign = HorizontalAlignment.Center;
      this.txtReservationRef.AcceptsReturn = true;
      this.txtReservationRef.BackColor = SystemColors.Window;
      this.txtReservationRef.Cursor = Cursors.IBeam;
      this.txtReservationRef.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtReservationRef.ForeColor = Color.Red;
      this.txtReservationRef.Location = new Point(268, 148);
      this.txtReservationRef.MaxLength = 8;
      this.txtReservationRef.Name = "txtReservationRef";
      this.txtReservationRef.RightToLeft = RightToLeft.No;
      this.txtReservationRef.Size = new Size(81, 29);
      this.txtReservationRef.TabIndex = 39;
      this.txtReservationRef.TextAlign = HorizontalAlignment.Center;
      this.txtBuildingNo.AcceptsReturn = true;
      this.txtBuildingNo.BackColor = SystemColors.Window;
      this.txtBuildingNo.Cursor = Cursors.IBeam;
      this.txtBuildingNo.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingNo.ForeColor = SystemColors.WindowText;
      this.txtBuildingNo.Location = new Point(540, 308);
      this.txtBuildingNo.MaxLength = 0;
      this.txtBuildingNo.Name = "txtBuildingNo";
      this.txtBuildingNo.RightToLeft = RightToLeft.No;
      this.txtBuildingNo.Size = new Size(41, 26);
      this.txtBuildingNo.TabIndex = 73;
      this.txtBuildingNo.TextAlign = HorizontalAlignment.Center;
      this.Label12.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(436, 340);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(81, 33);
      this.Label12.TabIndex = 76;
      this.Label12.Text = "Reserve Type. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.Label12.Visible = false;
      this.lblBuildingType.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lblBuildingType.Cursor = Cursors.Default;
      this.lblBuildingType.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuildingType.ForeColor = Color.Blue;
      this.lblBuildingType.Location = new Point(588, 308);
      this.lblBuildingType.Name = "lblBuildingType";
      this.lblBuildingType.RightToLeft = RightToLeft.No;
      this.lblBuildingType.Size = new Size(121, 24);
      this.lblBuildingType.TabIndex = 75;
      this.Label11.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = SystemColors.ControlText;
      this.Label11.Location = new Point(460, 308);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(65, 17);
      this.Label11.TabIndex = 74;
      this.Label11.Text = "Building.  ";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.lblRType.BackColor = Color.Transparent;
      this.lblRType.Cursor = Cursors.Default;
      this.lblRType.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRType.ForeColor = Color.Yellow;
      this.lblRType.Location = new Point(537, 336);
      this.lblRType.Name = "lblRType";
      this.lblRType.RightToLeft = RightToLeft.No;
      this.lblRType.Size = new Size(73, 25);
      this.lblRType.TabIndex = 72;
      this.lblRType.Visible = false;
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(68, 412);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(649, 33);
      this.lblMessage.TabIndex = 64;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.lblRoomType.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lblRoomType.Cursor = Cursors.Default;
      this.lblRoomType.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomType.ForeColor = Color.Red;
      this.lblRoomType.Location = new Point(220, 276);
      this.lblRoomType.Name = "lblRoomType";
      this.lblRoomType.RightToLeft = RightToLeft.No;
      this.lblRoomType.Size = new Size(113, 17);
      this.lblRoomType.TabIndex = 63;
      this.lblRoomNo.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lblRoomNo.Cursor = Cursors.Default;
      this.lblRoomNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomNo.ForeColor = Color.Red;
      this.lblRoomNo.Location = new Point(548, 276);
      this.lblRoomNo.Name = "lblRoomNo";
      this.lblRoomNo.RightToLeft = RightToLeft.No;
      this.lblRoomNo.Size = new Size(73, 17);
      this.lblRoomNo.TabIndex = 62;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.Blue;
      this.Label10.Location = new Point(388, 372);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(145, 17);
      this.Label10.TabIndex = 59;
      this.Label10.Text = "Refund Amount : ";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.Label9.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(76, 372);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(121, 17);
      this.Label9.TabIndex = 57;
      this.Label9.Text = "Cancellation Charge";
      this.Label9.TextAlign = ContentAlignment.TopRight;
      this.Label21.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label21.Cursor = Cursors.Default;
      this.Label21.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = SystemColors.ControlText;
      this.Label21.Location = new Point(132, 324);
      this.Label21.Name = "Label21";
      this.Label21.RightToLeft = RightToLeft.No;
      this.Label21.Size = new Size(65, 17);
      this.Label21.TabIndex = 56;
      this.Label21.Text = "Deposit";
      this.Label21.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(436, 236);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(81, 17);
      this.Label18.TabIndex = 55;
      this.Label18.Text = "End Date ";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(116, 236);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 54;
      this.Label17.Text = "Start Date ";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.lblFirstName.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lblFirstName.Cursor = Cursors.Default;
      this.lblFirstName.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFirstName.ForeColor = Color.Blue;
      this.lblFirstName.Location = new Point(220, 188);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.RightToLeft = RightToLeft.No;
      this.lblFirstName.Size = new Size(153, 17);
      this.lblFirstName.TabIndex = 50;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(116, 188);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 17);
      this.Label4.TabIndex = 49;
      this.Label4.Text = "First Name";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(452, 188);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(65, 17);
      this.Label5.TabIndex = 48;
      this.Label5.Text = "SurName ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.lblSurName.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.lblSurName.Cursor = Cursors.Default;
      this.lblSurName.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblSurName.ForeColor = Color.Blue;
      this.lblSurName.Location = new Point(540, 188);
      this.lblSurName.Name = "lblSurName";
      this.lblSurName.RightToLeft = RightToLeft.No;
      this.lblSurName.Size = new Size(161, 17);
      this.lblSurName.TabIndex = 47;
      this.Label7.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = SystemColors.ControlText;
      this.Label7.Location = new Point(460, 276);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(65, 17);
      this.Label7.TabIndex = 46;
      this.Label7.Text = "Room No.";
      this.Label7.TextAlign = ContentAlignment.TopRight;
      this.Label8.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(132, 276);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(65, 17);
      this.Label8.TabIndex = 45;
      this.Label8.Text = "Room Type ";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial Black", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(0, 128, 0);
      this.Label3.Location = new Point(412, 148);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(105, 17);
      this.Label3.TabIndex = 44;
      this.Label3.Text = "Guest ID ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.White;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(-4, 60);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 33);
      this.Label2.TabIndex = 42;
      this.Label2.Text = "CANCEL RESERVATION ";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.White;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(-4, -4);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 49);
      this.Label1.TabIndex = 41;
      this.Label1.Text = "Operation Mode ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.Label6.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Blue;
      this.Label6.Location = new Point(76, 148);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(145, 25);
      this.Label6.TabIndex = 40;
      this.Label6.Text = "Reservation Reference : ";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this.mskContractEnd.AllowPromptAsInput = false;
      this.mskContractEnd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskContractEnd.ForeColor = Color.Blue;
      this.mskContractEnd.Location = new Point(540, 236);
      this.mskContractEnd.Mask = "####-##-##";
      this.mskContractEnd.Name = "mskContractEnd";
      this.mskContractEnd.Size = new Size(81, 20);
      this.mskContractEnd.TabIndex = 53;
      this.mskContractStart.AllowPromptAsInput = false;
      this.mskContractStart.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskContractStart.ForeColor = Color.Blue;
      this.mskContractStart.Location = new Point(220, 236);
      this.mskContractStart.Mask = "####-##-##";
      this.mskContractStart.Name = "mskContractStart";
      this.mskContractStart.Size = new Size(81, 20);
      this.mskContractStart.TabIndex = 52;
      this.pictureBox1.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox1.Location = new Point(65, 115);
      this.pictureBox1.Margin = new Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(652, 294);
      this.pictureBox1.TabIndex = 77;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(793, 571);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.Data1);
      this.Controls.Add((Control) this.cmdViewReserveList);
      this.Controls.Add((Control) this.txtReserve);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.cmdConfirm);
      this.Controls.Add((Control) this.txtRefundAmount);
      this.Controls.Add((Control) this.txtCancellationCharge);
      this.Controls.Add((Control) this.txtDeposit);
      this.Controls.Add((Control) this.txtClientID);
      this.Controls.Add((Control) this.txtReservationRef);
      this.Controls.Add((Control) this.mskContractStart);
      this.Controls.Add((Control) this.mskContractEnd);
      this.Controls.Add((Control) this.txtBuildingNo);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.lblBuildingType);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.lblRType);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.lblRoomType);
      this.Controls.Add((Control) this.lblRoomNo);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label21);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.lblFirstName);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.lblSurName);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.pictureBox1);
      this.Name = "Form_CancelReservationDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.VisibleChanged += new EventHandler(this.Form_CancelReservationDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_CancelReservationDMS_FormClosing);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
