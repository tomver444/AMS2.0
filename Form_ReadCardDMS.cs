// Decompiled with JetBrains decompiler
// Type: AMS.Form_ReadCardDMS
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
  public class Form_ReadCardDMS : Form
  {
    private bool Init_Flag;
    private bool Mng_TimeCard;
    private string HW_ID = "";
    private string Card_AutoNumber = "";
    private DB db;
    private string bld_no = "";
    private string floor_no = "";
    private string room_no = "";
    private string Begin_Date = "";
    private string End_Date;
    private string Room_No_Calculated = "";
    private string CardRecordDate = "";
    private string CardRecordTime = "";
    private IContainer components;
    public TextBox txtEndTime;
    public TextBox txtEndDate;
    public ToolTip ToolTip1;
    public TextBox txtStartTime;
    public TextBox txtStartDate;
    public TextBox txtCountry;
    public GroupBox IssueCardFrame;
    public TextBox txtSex;
    public TextBox txtClientID;
    public TextBox txtRemark;
    public TextBox txtContact;
    public TextBox txtAddress;
    public TextBox txtNationality;
    public TextBox txtIdentity;
    public TextBox txtSurName;
    public TextBox txtFirstName;
    public TextBox txtCardNo;
    public Label Label3;
    public Label lbInTime;
    public Label lbOutTime;
    public Label Label27;
    public Label Label11;
    public Label Label10;
    public Label Label9;
    public Label Label8;
    public Label _Label7_0;
    public Label Label6;
    public Label lbValidEnd;
    public Label lbValidStart;
    public Label Label4;
    public Label Label5;
    public Label Label28;
    public Label lbBuilding;
    public Label Label1;
    public Label lblMessage;
    public Label Label14;
    public Label lbReadCardHeader;
    public Label lbFloor;
    public GroupBox Frame2;
    public Button cmdReturn;
    public Timer Timer1;
    public GroupBox Frame1;
    public GroupBox ZoneFrame;
    public TextBox txtZoneNo;
    public Label lbZoneNo;
    public TextBox txtBuilding;
    public TextBox txtCardType;
    public GroupBox RoomFrame;
    public TextBox txtRoomNo;
    public Label Label2;
    public GroupBox FloorFrame;
    public TextBox txtFloorNo;
    public Button cmdCancel;
        private RichTextBox richTextBox1;
        public Button cmdReadCard;

    public Form_ReadCardDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
      this.ClearScreen(true);
    }

    private void Form_ReadCardDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_ReadCardDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Timer1.Start();
      this.Timer1.Interval = 200;
      this.Init_Flag = true;
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1")
        this.cmdCancel.Enabled = true;
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
        this.cmdCancel.Enabled = true;
      else
        this.cmdCancel.Enabled = true;
    }

    private void Check_CancleVisable()
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1")
      {
        if (this.Mng_TimeCard)
          this.cmdCancel.Enabled = true;
        else
          this.cmdCancel.Enabled = true;
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
        this.cmdCancel.Enabled = true;
      else
        this.cmdCancel.Enabled = true;
    }

    private bool CheckClientData(string para_BuildingNo)
    {
      bool flag = false;
      BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
      this.db.Local_Command.CommandText = "SELECT * FROM CardNo in'" + Application.UserAppDataPath + "\\\\BuildingDB" + para_BuildingNo + ".mdb 'ORDER BY CardNo.CardNo DESC";
      this.db.Local_Command.Connection = this.db.building_DB1.cardNoTableAdapter.Connection;
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) buildingDb1DataSet.CardNo);
      foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) buildingDb1DataSet.CardNo.Rows)
      {
        string str;
        try
        {
          str = row.Card_AutoNumber;
        }
        catch
        {
          str = "";
        }
        try
        {
          string cardNo = row.CardNo;
          if (this.Card_AutoNumber.Contains(str))
          {
            if (row.Card_HW_ID == this.HW_ID)
            {
              this.txtCardNo.Text = row.CardNo;
              this.txtClientID.Text = row.ClientID;
              this.CardRecordDate = row.RecordDate.ToShortDateString();
              this.CardRecordTime = row.RecordTime;
              flag = true;
              break;
            }
          }
        }
        catch
        {
        }
      }
      return flag;
    }

    private bool GetClientData(string para_BuildingNo)
    {
      DateTime now = DateTime.Now;
      BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
      this.db.Local_Command.CommandText = "SELECT * FROM ClientAcc in'" + Application.UserAppDataPath + "\\\\BuildingDB" + para_BuildingNo + ".mdb 'ORDER BY ClientAcc.ClientID DESC";
      this.db.Local_Command.Connection = this.db.building_DB1.clientAccTableAdapter.Connection;
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) buildingDb1DataSet.ClientAcc);
      this.lblMessage.Text = "";
      foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase) buildingDb1DataSet.ClientAcc.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          if (!(this.txtCardType.Text == "Guest Card"))
          {
            if (!(this.txtCardType.Text == "Guest"))
            {
              if (!this.txtCardType.Text.Contains("ECard"))
              {
                if (!this.txtCardType.Text.Contains("Emergency"))
                {
                  if (!this.txtCardType.Text.Contains("RoomCard"))
                  {
                    if (this.txtCardType.Text == "Floor Card")
                    {
                      try
                      {
                        this.txtStartDate.Text = row.ValidStart.ToShortDateString();
                        this.txtEndDate.Text = row.ValidEnd.ToShortDateString();
                        this.txtStartTime.Text = row.CheckInTime.ToShortTimeString();
                        this.txtEndTime.Text = row.CheckOutTime.ToShortTimeString();
                        this.txtStartDate.Visible = true;
                        this.txtEndDate.Visible = true;
                        this.txtStartTime.Visible = true;
                        this.txtEndTime.Visible = true;
                        this.lbValidEnd.Text = "Valid End Date";
                        this.lbValidStart.Text = "Valid Start Date";
                        this.lbInTime.Text = "Valid Start Time";
                        this.lbOutTime.Text = "Valid End Time";
                        goto label_19;
                      }
                      catch
                      {
                        goto label_19;
                      }
                    }
                    else if (this.txtCardType.Text == "Region Card")
                    {
                      try
                      {
                        this.txtStartDate.Text = row.ValidStart.ToShortDateString();
                        this.txtEndDate.Text = row.ValidEnd.ToShortDateString();
                        this.txtStartTime.Text = row.CheckInTime.ToShortTimeString();
                        this.txtEndTime.Text = row.CheckOutTime.ToShortTimeString();
                        this.txtStartDate.Visible = true;
                        this.txtEndDate.Visible = true;
                        this.txtStartTime.Visible = true;
                        this.txtEndTime.Visible = true;
                        this.lbValidEnd.Text = "Valid End Date";
                        this.lbValidStart.Text = "Valid Start Date";
                        this.lbInTime.Text = "Valid Start Time";
                        this.lbOutTime.Text = "Valid End Time";
                        goto label_19;
                      }
                      catch
                      {
                        goto label_19;
                      }
                    }
                    else if (!(this.txtCardType.Text == "Room setting Card"))
                    {
                      if (!(this.txtCardType.Text == "Times setting Card"))
                      {
                        this.txtStartDate.Text = this.CardRecordDate;
                        this.txtStartTime.Text = this.CardRecordTime;
                        this.txtStartDate.Visible = true;
                        this.txtStartTime.Visible = true;
                        this.lbValidStart.Text = "Issue Date";
                        this.lbInTime.Text = "Issue Time";
                        goto label_19;
                      }
                      else
                        goto label_19;
                    }
                    else
                      goto label_19;
                  }
                }
              }
            }
          }
          try
          {
            this.txtStartDate.Text = row.ValidStart.ToShortDateString();
            this.txtEndDate.Text = row.ValidEnd.ToShortDateString();
            this.txtStartTime.Text = row.CheckInTime.ToShortTimeString();
            this.txtEndTime.Text = row.CheckOutTime.ToShortTimeString();
            this.txtStartDate.Visible = true;
            this.txtEndDate.Visible = true;
            this.txtStartTime.Visible = true;
            this.txtEndTime.Visible = true;
            this.lbValidEnd.Text = "Valid End Date";
            this.lbValidStart.Text = "Valid Start Date";
            this.lbInTime.Text = "Valid Start Time";
            this.lbOutTime.Text = "Valid End Time";
          }
          catch
          {
          }
label_19:
          try
          {
            if (row.Remark != "")
            {
              this.txtRemark.Text = row.Remark;
              break;
            }
            break;
          }
          catch
          {
            break;
          }
        }
      }
      this.db.Local_Command.CommandText = "SELECT * FROM Client in'" + Application.UserAppDataPath + "\\\\BuildingDB" + para_BuildingNo + ".mdb 'ORDER BY Client.ClientID DESC";
      this.db.local_adaptor.Fill((DataTable) buildingDb1DataSet.Client);
      foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) buildingDb1DataSet.Client.Rows)
      {
        if (row.ClientID == this.txtClientID.Text)
        {
          this.txtFirstName.Text = row.ForeName;
          this.txtSurName.Text = row.SurName;
          this.txtSex.Text = row.Sex;
          this.txtIdentity.Text = row.Identity;
          this.txtNationality.Text = row.Nationality;
          this.txtAddress.Text = row.Address;
          this.txtContact.Text = row.Contact;
          this.txtCountry.Text = row.Country;
          break;
        }
      }
      return true;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (!this.Visible || !this.Init_Flag)
        return;
      this.Init_Flag = false;
      this.Timer1.Interval = 500;
      if (Global_Data.Card_Reader_Found_Flag)
      {
        this.Disable_DateTime_Informations();
        if (this.Mng_TimeCard)
          this.cmdCancel.Enabled = true;
        else
          this.cmdCancel.Enabled = true;
        if (this.Read_CardInformattion())
        {
          if (!this.CheckClientData(Global_Data.sBldNo))
          {
            //int num = (int) MessageBox.Show("Invalid Card!");
          }
          else
            this.GetClientData(Global_Data.sBldNo);
        }
        else
          this.ClearScreen(false);
      }
      else
      {
        int num = (int) MessageBox.Show("Card Reader Not Found!");
        this.ClearScreen(false);
      }
    }

    private bool Read_CardInformattion()
    {
      if (!SmartCard_Procedures.ReadCard_Information((int) Global_Data.COM_NUM))
        return false;
            richTextBox1.Text = "";
            richTextBox1.Update();
         richTextBox1.Text += "\r\nCard_ID_String:\r\n " + SmartCard_Procedures.Card_ID_String + "\r\n\r\n";
            richTextBox1.Text += "\r\nCard_Number_Data:\r\n " + SmartCard_Procedures.Card_Number_Data + "\r\n\r\n";
            richTextBox1.Text += "\r\nCard_Information_String: " + SmartCard_Procedures.Card_Information_String + "\r\n\r\n";
            richTextBox1.Text += "\r\nCard_Number_String:\r\n " + SmartCard_Procedures.Card_Number_String + "\r\n\r\n";
            string str = SmartCard_Procedures.Card_Information_String.Substring(2, 2);
      int int32 = Convert.ToInt32(str);
      if (!SmartCard_Procedures.ReadCardID((int) Global_Data.COM_NUM))
        return false;
      this.HW_ID = SmartCard_Procedures.Card_ID_String;
      if (!SmartCard_Procedures.ReadCardNumber((int) Global_Data.COM_NUM))
        return false;
      this.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
      this.FloorFrame.Visible = false;
      this.ZoneFrame.Visible = false;
      this.RoomFrame.Visible = false;
      this.Mng_TimeCard = false;
      if (str == Card_Type_Code.Guest_card)
      {
        this.txtCardType.Text = "Guest Card";
        try
        {
          this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
          foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
          {
            if (row.Card_AutoNumber == this.Card_AutoNumber && row.Card_HW_ID == this.HW_ID)
            {
              this.txtCardType.Text = row.CardType;
              break;
            }
          }
        }
        catch
        {
        }
      }
      else
      {
        if (int32 == 0 || int32 > 18)
        {
          this.txtCardType.Text = "Empty Card";
          return false;
        }
        if (str == Card_Type_Code.Acquisition_Card)
          this.txtCardType.Text = "Acquisition Card";
        else if (str == Card_Type_Code.Area_Region_card)
        {
          this.txtCardType.Text = "Region Card";
          this.ZoneFrame.Visible = true;
        }
        else
        {
          if (str == Card_Type_Code.Authorization_card)
          {
            this.txtCardType.Text = "Authorization Card";
            return false;
          }
          if (str == Card_Type_Code.Building_card)
            this.txtCardType.Text = "Building Card";
          else if (str == Card_Type_Code.Chief_card)
            this.txtCardType.Text = "Chief Card";
          else if (str == Card_Type_Code.Cleaning_Card)
            this.txtCardType.Text = "Cleared Card";
          else if (str == Card_Type_Code.Emergency_card)
            this.txtCardType.Text = "Emergency Card";
          else if (str == Card_Type_Code.Floor_card)
          {
            this.txtCardType.Text = "Floor Card";
            this.FloorFrame.Visible = true;
          }
          else if (str == Card_Type_Code.Guest_card_limit_card)
            this.txtCardType.Text = "Guest Card limit";
          else if (str == Card_Type_Code.Limited_room_card)
            this.txtCardType.Text = "Limited room Card";
          else if (str == Card_Type_Code.Loss_card)
            this.txtCardType.Text = "Loss Card";
          else if (str == Card_Type_Code.Loss_recovery_card)
            this.txtCardType.Text = "Loss recovery Card";
          else if (str == Card_Type_Code.Recovery_room_card)
            this.txtCardType.Text = "Recovery room Card";
          else if (str == Card_Type_Code.Region_setting_card)
          {
            this.txtCardType.Text = "Region setting Card";
            this.ZoneFrame.Visible = true;
          }
          else if (str == Card_Type_Code.Room_setting_card)
            this.txtCardType.Text = "Room setting Card";
          else if (str == Card_Type_Code.Spare_Card)
            this.txtCardType.Text = "Spare Card";
          else if (str == Card_Type_Code.Times_setting_card)
          {
            this.txtCardType.Text = "Times setting Card";
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1")
              this.Mng_TimeCard = true;
          }
        }
      }


      this.Check_CancleVisable();
      if (str == Card_Type_Code.Room_setting_card || str == Card_Type_Code.Limited_room_card || str == Card_Type_Code.Recovery_room_card || str == Card_Type_Code.Guest_card || str == Card_Type_Code.Floor_card || str == Card_Type_Code.Area_Region_card || str == Card_Type_Code.Building_card)
      {
        this.bld_no = SmartCard_Procedures.Card_Information_String.Substring(8, 2);
        this.txtBuilding.Text = this.bld_no.Substring(1, 1);
      }
      if (str == Card_Type_Code.Room_setting_card || str == Card_Type_Code.Limited_room_card || str == Card_Type_Code.Recovery_room_card || str == Card_Type_Code.Guest_card || str == Card_Type_Code.Floor_card)
      {
        this.floor_no = SmartCard_Procedures.Card_Information_String.Substring(10, 2);
        this.txtFloorNo.Text = this.floor_no;
      }
      if (str == Card_Type_Code.Limited_room_card || str == Card_Type_Code.Recovery_room_card || str == Card_Type_Code.Guest_card)
      {
        this.room_no = SmartCard_Procedures.Card_Information_String.Substring(12, 2);
        this.Room_No_Calculated = this.bld_no.Substring(1, 1) + this.floor_no + this.room_no;
        this.txtRoomNo.Text = this.Room_No_Calculated;
        this.RoomFrame.Visible = true;
      }
      if (str == Card_Type_Code.Room_setting_card)
      {
        this.room_no = SmartCard_Procedures.Card_Information_String.Substring(12, 2);
        if (this.room_no == "F8")
        {
          this.txtBuilding.Visible = true;
          this.txtCardType.Text = "Building Setting Card";
        }
        else if (this.room_no == "F9")
        {
          this.FloorFrame.Visible = true;
          this.txtCardType.Text = "Floor Setting Card";
        }
        else
        {
          this.Room_No_Calculated = this.bld_no.Substring(1, 1) + this.floor_no + this.room_no;
          this.txtRoomNo.Text = this.Room_No_Calculated;
          this.txtCardType.Text = "Room setting Card";
          this.RoomFrame.Visible = true;
        }
      }
      if (str == Card_Type_Code.Area_Region_card)
        this.txtZoneNo.Text = SmartCard_Procedures.Card_Information_String.Substring(10, 2);
      else if (str == Card_Type_Code.Region_setting_card)
        this.txtZoneNo.Text = SmartCard_Procedures.Card_Information_String.Substring(8, 2);
      if (str == Card_Type_Code.Room_setting_card || str == Card_Type_Code.Times_setting_card)
      {
        this.txtStartDate.Text = SmartCard_Procedures.Card_Information_String.Substring(18, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(20, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(22, 2);
        this.txtStartTime.Text = SmartCard_Procedures.Card_Information_String.Substring(24, 2) + ":" + SmartCard_Procedures.Card_Information_String.Substring(26, 2) + ":" + SmartCard_Procedures.Card_Information_String.Substring(28, 2);
        this.txtStartDate.Visible = true;
        this.txtStartTime.Visible = true;
        this.lbValidStart.Text = "Setting Date";
        this.lbInTime.Text = "Setting Time";
      }
      return true;
    }

    private void ClearScreen(bool para_all_flag)
    {
      if (para_all_flag)
        this.txtCardType.Text = "";
      this.txtCardNo.Text = "";
      this.txtFloorNo.Text = "";
      this.txtSex.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.txtIdentity.Text = "";
      this.txtNationality.Text = "";
      this.txtContact.Text = "";
      this.txtAddress.Text = "";
      this.txtCountry.Text = "";
      this.txtBuilding.Text = "";
      this.txtStartDate.Text = "";
      this.txtEndDate.Text = "";
      this.txtStartTime.Text = "";
      this.txtEndTime.Text = "";
      this.txtClientID.Text = "";
      this.txtRemark.Text = "";
    }

    private void Disable_DateTime_Informations()
    {
      this.txtStartDate.Text = "";
      this.txtEndDate.Text = "";
      this.txtStartTime.Text = "";
      this.txtEndTime.Text = "";
      this.txtStartDate.Visible = false;
      this.txtEndDate.Visible = false;
      this.txtStartTime.Visible = false;
      this.txtEndTime.Visible = false;
      this.lbInTime.Text = "";
      this.lbOutTime.Text = "";
      this.lbValidEnd.Text = "";
      this.lbValidStart.Text = "";
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      if (Global_Data.COM_NUM == (byte) 0)
      {
        int num1 = (int) MessageBox.Show("Card Reader Not Found!");
      }
      else
      {
        if (MessageBox.Show("Are you sure erasing? \r\nPlease comfirm Yes/No ", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        if (this.Mng_TimeCard)
        {
          this.Read_CardInformattion();
          if (!this.Mng_TimeCard)
          {
            int num2 = (int) MessageBox.Show("No Time Setting Card at Reader!");
            return;
          }
        }
        this.Refresh();
        if (!SmartCard_Procedures.Make_Empty_Card((int) Global_Data.COM_NUM, Global_Data.System_Pas_String))
          return;
        int num3 = (int) MessageBox.Show("Make Empty Card Success!");
      }
    }

    private void cmdReadCard_Click(object sender, EventArgs e)
    {
      if (Global_Data.Card_Reader_Found_Flag)
      {
        this.ClearScreen(true);
        this.Refresh();
        this.Disable_DateTime_Informations();
        if (this.Read_CardInformattion())
        {
          //if (!this.CheckClientData(Global_Data.sBldNo))
          //{
            //int num = (int) MessageBox.Show("Invalid Card!");
          //}
          //else
            //this.GetClientData(Global_Data.sBldNo);
        }
        else
          this.ClearScreen(false);
      }
      else
      {
        int num = (int) MessageBox.Show("Card Reader Not Found!");
        this.ClearScreen(false);
      }
    }

    private void Form_ReadCardDMS_Load(object sender, EventArgs e)
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1")
        this.cmdCancel.Enabled = true;
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
        this.cmdCancel.Enabled = true;
      else
        this.cmdCancel.Enabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.IssueCardFrame = new System.Windows.Forms.GroupBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbInTime = new System.Windows.Forms.Label();
            this.lbOutTime = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this._Label7_0 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lbValidEnd = new System.Windows.Forms.Label();
            this.lbValidStart = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.lbBuilding = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lbReadCardHeader = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.cmdReadCard = new System.Windows.Forms.Button();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.RoomFrame = new System.Windows.Forms.GroupBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.FloorFrame = new System.Windows.Forms.GroupBox();
            this.txtFloorNo = new System.Windows.Forms.TextBox();
            this.ZoneFrame = new System.Windows.Forms.GroupBox();
            this.txtZoneNo = new System.Windows.Forms.TextBox();
            this.lbZoneNo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.IssueCardFrame.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.RoomFrame.SuspendLayout();
            this.FloorFrame.SuspendLayout();
            this.ZoneFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEndTime
            // 
            this.txtEndTime.AcceptsReturn = true;
            this.txtEndTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndTime.Location = new System.Drawing.Point(632, 82);
            this.txtEndTime.MaxLength = 0;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndTime.Size = new System.Drawing.Size(81, 22);
            this.txtEndTime.TabIndex = 46;
            // 
            // txtEndDate
            // 
            this.txtEndDate.AcceptsReturn = true;
            this.txtEndDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEndDate.Location = new System.Drawing.Point(632, 50);
            this.txtEndDate.MaxLength = 0;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndDate.Size = new System.Drawing.Size(81, 22);
            this.txtEndDate.TabIndex = 45;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancel.Location = new System.Drawing.Point(443, 16);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(103, 47);
            this.cmdCancel.TabIndex = 71;
            this.cmdCancel.Text = "Recycle Card";
            this.ToolTip1.SetToolTip(this.cmdCancel, "Click to Recycle Invalid Card Data");
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.AcceptsReturn = true;
            this.txtStartTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartTime.Location = new System.Drawing.Point(424, 82);
            this.txtStartTime.MaxLength = 0;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartTime.Size = new System.Drawing.Size(89, 22);
            this.txtStartTime.TabIndex = 44;
            // 
            // txtStartDate
            // 
            this.txtStartDate.AcceptsReturn = true;
            this.txtStartDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStartDate.Location = new System.Drawing.Point(424, 50);
            this.txtStartDate.MaxLength = 0;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStartDate.Size = new System.Drawing.Size(89, 22);
            this.txtStartDate.TabIndex = 43;
            // 
            // txtCountry
            // 
            this.txtCountry.AcceptsReturn = true;
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCountry.Location = new System.Drawing.Point(424, 192);
            this.txtCountry.MaxLength = 0;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.Size = new System.Drawing.Size(153, 20);
            this.txtCountry.TabIndex = 42;
            // 
            // IssueCardFrame
            // 
            this.IssueCardFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IssueCardFrame.Controls.Add(this.txtEndTime);
            this.IssueCardFrame.Controls.Add(this.txtEndDate);
            this.IssueCardFrame.Controls.Add(this.txtStartTime);
            this.IssueCardFrame.Controls.Add(this.txtStartDate);
            this.IssueCardFrame.Controls.Add(this.txtCountry);
            this.IssueCardFrame.Controls.Add(this.txtSex);
            this.IssueCardFrame.Controls.Add(this.txtClientID);
            this.IssueCardFrame.Controls.Add(this.txtRemark);
            this.IssueCardFrame.Controls.Add(this.txtContact);
            this.IssueCardFrame.Controls.Add(this.txtAddress);
            this.IssueCardFrame.Controls.Add(this.txtNationality);
            this.IssueCardFrame.Controls.Add(this.txtIdentity);
            this.IssueCardFrame.Controls.Add(this.txtSurName);
            this.IssueCardFrame.Controls.Add(this.txtFirstName);
            this.IssueCardFrame.Controls.Add(this.txtCardNo);
            this.IssueCardFrame.Controls.Add(this.Label3);
            this.IssueCardFrame.Controls.Add(this.lbInTime);
            this.IssueCardFrame.Controls.Add(this.lbOutTime);
            this.IssueCardFrame.Controls.Add(this.Label27);
            this.IssueCardFrame.Controls.Add(this.Label11);
            this.IssueCardFrame.Controls.Add(this.Label10);
            this.IssueCardFrame.Controls.Add(this.Label9);
            this.IssueCardFrame.Controls.Add(this.Label8);
            this.IssueCardFrame.Controls.Add(this._Label7_0);
            this.IssueCardFrame.Controls.Add(this.Label6);
            this.IssueCardFrame.Controls.Add(this.lbValidEnd);
            this.IssueCardFrame.Controls.Add(this.lbValidStart);
            this.IssueCardFrame.Controls.Add(this.Label4);
            this.IssueCardFrame.Controls.Add(this.Label5);
            this.IssueCardFrame.Controls.Add(this.Label28);
            this.IssueCardFrame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueCardFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IssueCardFrame.Location = new System.Drawing.Point(12, 184);
            this.IssueCardFrame.Name = "IssueCardFrame";
            this.IssueCardFrame.Padding = new System.Windows.Forms.Padding(0);
            this.IssueCardFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IssueCardFrame.Size = new System.Drawing.Size(737, 289);
            this.IssueCardFrame.TabIndex = 34;
            this.IssueCardFrame.TabStop = false;
            this.IssueCardFrame.Text = "READ DATA :";
            // 
            // txtSex
            // 
            this.txtSex.AcceptsReturn = true;
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSex.Location = new System.Drawing.Point(104, 64);
            this.txtSex.MaxLength = 0;
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSex.Size = new System.Drawing.Size(49, 20);
            this.txtSex.TabIndex = 41;
            // 
            // txtClientID
            // 
            this.txtClientID.AcceptsReturn = true;
            this.txtClientID.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClientID.Location = new System.Drawing.Point(104, 24);
            this.txtClientID.MaxLength = 8;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientID.Size = new System.Drawing.Size(89, 20);
            this.txtClientID.TabIndex = 34;
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemark.Location = new System.Drawing.Point(424, 232);
            this.txtRemark.MaxLength = 0;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemark.Size = new System.Drawing.Size(193, 37);
            this.txtRemark.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.AcceptsReturn = true;
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContact.Location = new System.Drawing.Point(104, 199);
            this.txtContact.MaxLength = 20;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContact.Size = new System.Drawing.Size(153, 20);
            this.txtContact.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(104, 232);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.Size = new System.Drawing.Size(153, 49);
            this.txtAddress.TabIndex = 8;
            // 
            // txtNationality
            // 
            this.txtNationality.AcceptsReturn = true;
            this.txtNationality.BackColor = System.Drawing.SystemColors.Window;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNationality.Location = new System.Drawing.Point(424, 161);
            this.txtNationality.MaxLength = 20;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.ReadOnly = true;
            this.txtNationality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationality.Size = new System.Drawing.Size(153, 20);
            this.txtNationality.TabIndex = 9;
            // 
            // txtIdentity
            // 
            this.txtIdentity.AcceptsReturn = true;
            this.txtIdentity.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdentity.Location = new System.Drawing.Point(104, 167);
            this.txtIdentity.MaxLength = 20;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.ReadOnly = true;
            this.txtIdentity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentity.Size = new System.Drawing.Size(153, 20);
            this.txtIdentity.TabIndex = 6;
            // 
            // txtSurName
            // 
            this.txtSurName.AcceptsReturn = true;
            this.txtSurName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSurName.Location = new System.Drawing.Point(104, 130);
            this.txtSurName.MaxLength = 20;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.ReadOnly = true;
            this.txtSurName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurName.Size = new System.Drawing.Size(153, 20);
            this.txtSurName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = true;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(104, 98);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(153, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtCardNo
            // 
            this.txtCardNo.AcceptsReturn = true;
            this.txtCardNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.ForeColor = System.Drawing.Color.Red;
            this.txtCardNo.Location = new System.Drawing.Point(424, 21);
            this.txtCardNo.MaxLength = 0;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCardNo.Size = new System.Drawing.Size(81, 20);
            this.txtCardNo.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(24, 27);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Client ID";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbInTime
            // 
            this.lbInTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbInTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbInTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInTime.Location = new System.Drawing.Point(302, 85);
            this.lbInTime.Name = "lbInTime";
            this.lbInTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInTime.Size = new System.Drawing.Size(116, 17);
            this.lbInTime.TabIndex = 26;
            this.lbInTime.Text = "Valid Start Time";
            this.lbInTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbOutTime
            // 
            this.lbOutTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOutTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOutTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOutTime.Location = new System.Drawing.Point(520, 85);
            this.lbOutTime.Name = "lbOutTime";
            this.lbOutTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOutTime.Size = new System.Drawing.Size(106, 17);
            this.lbOutTime.TabIndex = 25;
            this.lbOutTime.Text = "Valid End Time";
            this.lbOutTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbOutTime.Click += new System.EventHandler(this.lbOutTime_Click);
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.Red;
            this.Label27.Location = new System.Drawing.Point(368, 232);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(41, 17);
            this.Label27.TabIndex = 22;
            this.Label27.Text = "Note: ";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(336, 195);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(73, 17);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "Country";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(8, 202);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(81, 17);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "Contact No.";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(16, 234);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(65, 17);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "Address";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(328, 162);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(81, 17);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Nationality";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label7_0
            // 
            this._Label7_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._Label7_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label7_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label7_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label7_0.Location = new System.Drawing.Point(8, 170);
            this._Label7_0.Name = "_Label7_0";
            this._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label7_0.Size = new System.Drawing.Size(81, 17);
            this._Label7_0.TabIndex = 15;
            this._Label7_0.Text = "Passport No.";
            this._Label7_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(48, 66);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(33, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Sex";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbValidEnd
            // 
            this.lbValidEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbValidEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbValidEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValidEnd.Location = new System.Drawing.Point(529, 55);
            this.lbValidEnd.Name = "lbValidEnd";
            this.lbValidEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbValidEnd.Size = new System.Drawing.Size(97, 17);
            this.lbValidEnd.TabIndex = 13;
            this.lbValidEnd.Text = "Valid End Date";
            this.lbValidEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbValidStart
            // 
            this.lbValidStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbValidStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbValidStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValidStart.Location = new System.Drawing.Point(321, 55);
            this.lbValidStart.Name = "lbValidStart";
            this.lbValidStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbValidStart.Size = new System.Drawing.Size(97, 17);
            this.lbValidStart.TabIndex = 12;
            this.lbValidStart.Text = "Valid Start Date";
            this.lbValidStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(8, 103);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "First Name";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(16, 135);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(65, 17);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Surname";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label28.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label28.Location = new System.Drawing.Point(336, 24);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(73, 17);
            this.Label28.TabIndex = 3;
            this.Label28.Text = "Card No.";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBuilding
            // 
            this.lbBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbBuilding.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbBuilding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuilding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBuilding.Location = new System.Drawing.Point(272, 25);
            this.lbBuilding.Name = "lbBuilding";
            this.lbBuilding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBuilding.Size = new System.Drawing.Size(73, 17);
            this.lbBuilding.TabIndex = 24;
            this.lbBuilding.Text = "Building No.";
            this.lbBuilding.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(12, 8);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(737, 41);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Admin Mode";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(20, 152);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(729, 25);
            this.lblMessage.TabIndex = 35;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(16, 24);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(65, 17);
            this.Label14.TabIndex = 36;
            this.Label14.Text = "Card Type";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbReadCardHeader
            // 
            this.lbReadCardHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbReadCardHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbReadCardHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadCardHeader.ForeColor = System.Drawing.Color.Red;
            this.lbReadCardHeader.Location = new System.Drawing.Point(12, 48);
            this.lbReadCardHeader.Name = "lbReadCardHeader";
            this.lbReadCardHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbReadCardHeader.Size = new System.Drawing.Size(737, 33);
            this.lbReadCardHeader.TabIndex = 33;
            this.lbReadCardHeader.Text = "READ  CARD";
            this.lbReadCardHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbFloor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFloor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFloor.Location = new System.Drawing.Point(8, 16);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFloor.Size = new System.Drawing.Size(57, 17);
            this.lbFloor.TabIndex = 28;
            this.lbFloor.Text = "Level No.";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Frame2.Controls.Add(this.cmdReadCard);
            this.Frame2.Controls.Add(this.cmdCancel);
            this.Frame2.Controls.Add(this.cmdReturn);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(12, 472);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(737, 73);
            this.Frame2.TabIndex = 38;
            this.Frame2.TabStop = false;
            // 
            // cmdReadCard
            // 
            this.cmdReadCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdReadCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReadCard.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdReadCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReadCard.Location = new System.Drawing.Point(275, 16);
            this.cmdReadCard.Name = "cmdReadCard";
            this.cmdReadCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReadCard.Size = new System.Drawing.Size(109, 47);
            this.cmdReadCard.TabIndex = 73;
            this.cmdReadCard.Text = "Read Card";
            this.cmdReadCard.UseVisualStyleBackColor = false;
            this.cmdReadCard.Click += new System.EventHandler(this.cmdReadCard_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(595, 16);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(113, 47);
            this.cmdReturn.TabIndex = 33;
            this.cmdReturn.Text = "Return";
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Frame1.Controls.Add(this.txtBuilding);
            this.Frame1.Controls.Add(this.txtCardType);
            this.Frame1.Controls.Add(this.RoomFrame);
            this.Frame1.Controls.Add(this.FloorFrame);
            this.Frame1.Controls.Add(this.Label14);
            this.Frame1.Controls.Add(this.lbBuilding);
            this.Frame1.Controls.Add(this.ZoneFrame);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 88);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(737, 57);
            this.Frame1.TabIndex = 36;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "READ DATA :";
            // 
            // txtBuilding
            // 
            this.txtBuilding.AcceptsReturn = true;
            this.txtBuilding.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuilding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuilding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuilding.Location = new System.Drawing.Point(360, 24);
            this.txtBuilding.MaxLength = 0;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.ReadOnly = true;
            this.txtBuilding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuilding.Size = new System.Drawing.Size(41, 20);
            this.txtBuilding.TabIndex = 38;
            // 
            // txtCardType
            // 
            this.txtCardType.AcceptsReturn = true;
            this.txtCardType.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCardType.Location = new System.Drawing.Point(104, 24);
            this.txtCardType.MaxLength = 0;
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.ReadOnly = true;
            this.txtCardType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCardType.Size = new System.Drawing.Size(129, 20);
            this.txtCardType.TabIndex = 37;
            // 
            // RoomFrame
            // 
            this.RoomFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RoomFrame.Controls.Add(this.txtRoomNo);
            this.RoomFrame.Controls.Add(this.Label2);
            this.RoomFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RoomFrame.Location = new System.Drawing.Point(584, 8);
            this.RoomFrame.Name = "RoomFrame";
            this.RoomFrame.Padding = new System.Windows.Forms.Padding(0);
            this.RoomFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomFrame.Size = new System.Drawing.Size(137, 41);
            this.RoomFrame.TabIndex = 30;
            this.RoomFrame.TabStop = false;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AcceptsReturn = true;
            this.txtRoomNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRoomNo.Location = new System.Drawing.Point(64, 16);
            this.txtRoomNo.MaxLength = 0;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRoomNo.Size = new System.Drawing.Size(65, 20);
            this.txtRoomNo.TabIndex = 40;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 17);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(41, 17);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Room";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FloorFrame
            // 
            this.FloorFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FloorFrame.Controls.Add(this.txtFloorNo);
            this.FloorFrame.Controls.Add(this.lbFloor);
            this.FloorFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FloorFrame.Location = new System.Drawing.Point(432, 8);
            this.FloorFrame.Name = "FloorFrame";
            this.FloorFrame.Padding = new System.Windows.Forms.Padding(0);
            this.FloorFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FloorFrame.Size = new System.Drawing.Size(129, 41);
            this.FloorFrame.TabIndex = 27;
            this.FloorFrame.TabStop = false;
            // 
            // txtFloorNo
            // 
            this.txtFloorNo.AcceptsReturn = true;
            this.txtFloorNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtFloorNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloorNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFloorNo.Location = new System.Drawing.Point(80, 16);
            this.txtFloorNo.MaxLength = 0;
            this.txtFloorNo.Name = "txtFloorNo";
            this.txtFloorNo.ReadOnly = true;
            this.txtFloorNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFloorNo.Size = new System.Drawing.Size(41, 20);
            this.txtFloorNo.TabIndex = 39;
            // 
            // ZoneFrame
            // 
            this.ZoneFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ZoneFrame.Controls.Add(this.txtZoneNo);
            this.ZoneFrame.Controls.Add(this.lbZoneNo);
            this.ZoneFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoneFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZoneFrame.Location = new System.Drawing.Point(432, 8);
            this.ZoneFrame.Name = "ZoneFrame";
            this.ZoneFrame.Padding = new System.Windows.Forms.Padding(0);
            this.ZoneFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZoneFrame.Size = new System.Drawing.Size(137, 41);
            this.ZoneFrame.TabIndex = 47;
            this.ZoneFrame.TabStop = false;
            // 
            // txtZoneNo
            // 
            this.txtZoneNo.AcceptsReturn = true;
            this.txtZoneNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtZoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZoneNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoneNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtZoneNo.Location = new System.Drawing.Point(88, 16);
            this.txtZoneNo.MaxLength = 0;
            this.txtZoneNo.Name = "txtZoneNo";
            this.txtZoneNo.ReadOnly = true;
            this.txtZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtZoneNo.Size = new System.Drawing.Size(33, 20);
            this.txtZoneNo.TabIndex = 48;
            // 
            // lbZoneNo
            // 
            this.lbZoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbZoneNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbZoneNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZoneNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbZoneNo.Location = new System.Drawing.Point(16, 16);
            this.lbZoneNo.Name = "lbZoneNo";
            this.lbZoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbZoneNo.Size = new System.Drawing.Size(57, 17);
            this.lbZoneNo.TabIndex = 49;
            this.lbZoneNo.Text = "Zone No. ";
            this.lbZoneNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(756, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 532);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form_ReadCardDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 557);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.IssueCardFrame);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbReadCardHeader);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Name = "Form_ReadCardDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReadCardDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_ReadCardDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_ReadCardDMS_VisibleChanged);
            this.IssueCardFrame.ResumeLayout(false);
            this.IssueCardFrame.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.RoomFrame.ResumeLayout(false);
            this.RoomFrame.PerformLayout();
            this.FloorFrame.ResumeLayout(false);
            this.FloorFrame.PerformLayout();
            this.ZoneFrame.ResumeLayout(false);
            this.ZoneFrame.PerformLayout();
            this.ResumeLayout(false);

    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbOutTime_Click(object sender, EventArgs e)
        {

        }
    }
}
