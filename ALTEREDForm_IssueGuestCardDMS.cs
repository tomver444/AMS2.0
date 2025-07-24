// Decompiled with JetBrains decompiler
// Type: AMS.Form_IssueGuestCardDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

#nullable disable
namespace AMS
{
    public class Form_IssueGuestCardDMS : Form
    {
        private DateTime sCurrValidStart = DateTime.Now.Date;
        private DateTime Other_Person_ValidEndDate;
        private DateTime Other_Person_ValidStartDate;
        private string Old_CheckIn_Date = "";
        private string backup_txtKeyDeposit = "";
        private bool cmdIssue_Ready_Flag;
        private bool Spare_Card_Scanned_Flag;

        public string Old_Client_ID = "";
        public bool Old_Client_OK_flag;
        private DateTime Old_Valid_End_Date = new DateTime();
        private DateTime Old_Valid_Start_Date = new DateTime();
        private DateTime Old_Contract_Start = new DateTime();
        private DateTime Old_Contract_End = new DateTime();
        private DateTime Old_Client_Valid_StartDate = new DateTime();
        private DateTime Old_Client_Valid_EndDate = new DateTime();
        private DateTime Old_Client_CheckOut_Date = new DateTime();
        private DateTime Old_Client_Contract_End_Date = new DateTime();
        private string Old_Client_ExtraDays = "";
        private string Old_Client_ExtraKey = "";
        private bool Old_Client_2ndKey_AlreadyIssued;
        private bool Others_Person_Extended_Flag;
        public string Reserve_Client_RefID = "";
        public bool Reserve_Client_OK_flag;
        private string Reserve_RoomNo_Select = "";
        private string Old_Reserved_RoomNo = "";
        private string Reserve_ClientID_Select = "";
        private DateTime Reserve_Contract_End = DateTime.Now;
        private bool bool_Invalid_Date_Error;
        private int TimeOut_Message_Cnt;
        private bool dateTime_Auto_InsertingFlag;
        private bool ChargeFrame_InsertingFlag;
        private bool ChargeType_Event_Disable;
        private DB db;
        private bool bRmPriceAdjust;
        private bool _1st_Time_Flag;
        private Decimal iDayRate;
        private Decimal iWeekRate;
        private Decimal iMonthRate;
        private int iRoomType;
        private int iOldDays;
        private int iLastDays;
        private Decimal iDayRate1;
        private Decimal iDayRate2;
        private Decimal iWeekRate1;
        private Decimal iWeekRate2;
        private Decimal iMonthRate1;
        private Decimal iMonthRate2;
        private bool bSecondClick;
        private bool bNoCharge;
        private bool bTwoPeople;
        private bool bSecond;
        private bool bExtKey;
        private bool bAvailableCont;
        private bool bCardExtra;
        private string sOldCardNo = "";
        private string sClientType;
        private string sCardType;
        private string sBuildingNo;
        private string sBuildingType;
        private string sAdvance = "";
        private string sTempAmountDue = "";
        private string sTempCurRoomCharge = "";
        private string sTransferType = "";
        private string sChkTotalStay = "";
        private string sCurAdvance;
        private string sNewGSTRate;
        private string sOldGSTRate;
        private string sTransDate;
        private string sAdvancedCalculated;
        private int iBonusTotal;
        private bool bOtherUnitKey;
        private bool bNewExisting;
        private string sNewRoom = "";
        private string sRoomNo = "";
        private string sOldPeople = "";
        private bool[] bExAmount = new bool[5];
        private SystemDataSet local_SystemDataSet = new SystemDataSet();
        public int sTotalDays;
        public int iNoOfWeek;
        public int iWExtraDays;
        public string sNextDay;
        public string sLastDay;
        public string sBalance;
        public string sOldChargeType;
        public string sTotalPaid;
        public string sTotalBuffer = "0";
        public Decimal sTotalExtra;
        private IContainer components;
        public ComboBox cboCountry;
        public TextBox txtCountry;
        public TextBox txtRemark;
        public TextBox txtNoOfDays;
        public TextBox txtContact;
        public TextBox txtGracePeriod;
        public TextBox txtNationality;
        public TextBox txtSurName;
        public TextBox txtCardNo;
        public TextBox txtNoOfMonth;
        public TextBox txtRoomType;
        public TextBox txtReserve;
        public ComboBox cboSex;
        public TextBox txtFirstName;
        public TextBox txtIdentity;
        public TextBox txtAddress;
        public Label Label3;
        public Label Label4;
        public Label Label5;
        public TextBox txtNoOfWeek;
        public Label Label6;
        public Label _Label7_0;
        public TextBox txtEarlyStart;
        public Label Label8;
        public TextBox txtCheckInDate;
        public Button cmdReservedGuest;
        public ToolTip ToolTip1;
        public Label Label9;
        public Label lblBonus;
        public Label Label10;
        public Label Label11;
        public System.Windows.Forms.Timer Timer1;
        public Label Label14;
        public Label lblUnit;
        public Button cmdNew;
        public Button cmdOld;
        public Label lblDiffBond;
        public Label Label33;
        public Label lbEarlyStart;
        public Label Label1;
        public Label Label16;
        public Label LabelRoom;
        public Label lblRoomNo;
        public Label Label30;
        public Label Label29;
        public Label Label13;
        public Label lbCardType;
        public Label Label28;
        public Label Label27;
        public Label lbNoOfDays;
        public Label Label25;
        public Label Label24;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label lblAvailableRooms;
        public Label Label12;
        public RadioButton _optOldGuest_3;
        public Button cmdViewReserveList;
        public GroupBox UnitFrame2;
        public Button cmdUnitKey;
        public Button cmdViewClient;
        public GroupBox ExtraChargeFrame;
        public TextBox _txtDesExtra_0;
        public TextBox _txtExtraAmount_0;
        public TextBox _txtDesExtra_1;
        public TextBox _txtExtraAmount_1;
        public TextBox _txtExtraAmount_2;
        public TextBox _txtExtraAmount_3;
        public TextBox _txtExtraAmount_4;
        public TextBox _txtDesExtra_2;
        public TextBox _txtDesExtra_3;
        public TextBox _txtDesExtra_4;
        public TextBox txtExtraTotal;
        public Button cmdOK;
        public Label lblMessage3;
        public Label lblExtraTotal;
        public GroupBox ChargesFrame;
        public TextBox txtAmountPaid;
        public TextBox txtAdvance;
        public TextBox txtBond;
        public TextBox txtDeposit;
        public TextBox txtRoomCharge;
        public TextBox txtToCollect;
        public TextBox txtCurrRoomCharge;
        public TextBox txtExtraKeyCharge;
        public TextBox txtExtraDescription;
        public TextBox txtExtra;
        public TextBox txtPrevious;
        public TextBox txtReceived;
        public TextBox txtKeyDeposit;
        public TextBox txtDisplayAmount;
        public TextBox txtDiffBond;
        public CheckBox chkBondDiff;
        public TextBox txtBonus;
        public Label Label23;
        public Label Label22;
        public Label Label21;
        public Label Label15;
        public Label Label20;
        public Label Label31;
        public Label Label26;
        public Label lbExtraKeyCharge;
        public Label Label34;
        public Label Label35;
        public Label lbPrevious;
        public Label Label36;
        public TextBox txtClientID;
        public Panel OldGuestFrame;
        public CheckBox chkExtendNewCard;
        public RadioButton _optOldGuest_2;
        public RadioButton _optOldGuest_1;
        public RadioButton _optOldGuest_0;
        public TextBox txtReservationRef;
        public ComboBox cboRoomType;
        public Button cmdReturn;
        public ComboBox cboRoomNo;
        public Button cmdIssue;
        public ComboBox cboChargeType;
        public GroupBox RegistrationFrame;
        public TextBox txtIssuedCard;
        public ComboBox cboBuildingNo;
        public Button cmdLoss;
        public Label Label37;
        public Panel ClientFrame;
        public Button cmdClear;
        public Button cmdPrint;
        public Label lblMessage2;
        public Label lblMessage1;
        public Label lblMessage;
        public Label Label2;
        private DateTimePicker dateTimePicker_ContractStart;
        private DateTimePicker dateTimePicker_ContractEnd;
        private DateTimePicker dateTimePicker_ValidStart;
        private DateTimePicker dateTimePicker_ValidEnd;
        private DateTimePicker dateTimePicker_CheckOutDate;
        private PictureBox pictureBox_pdf;
        public GroupBox StayingPeopleFrame;
        public CheckBox chkSecond;
        public RadioButton _optPeople_1;
        public RadioButton _optPeople_0;
        public Label Label32;
        public GroupBox UnitFrame;
        public TextBox txtUnitNo;
        public RadioButton _optUnit_1;
        public RadioButton _optUnit_0;
        public ComboBox cboUnitNo;
        public Label Label38;
        public Label Label39;
        private PictureBox pictureBox1;
        private Panel panel_CommStatus;
        private Label label_CommState;
        public PictureBox pictureBox_COMM_Color;
        public Label label7;
        public TextBox textBox_Email;
        public Button cmdReadCard;
        public CheckBox checkBox_Replace;
        private DateTimePicker dateTimePicker_CheckInTime;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        public Button button3;
        private Button button5;
        private Panel panel1;
        private Button button4;
        private DateTimePicker dateTo;
        private DateTimePicker dateFrom;
        private Label label41;
        private Button button6;
        private TextBox txtFloorBuildingValue;
        private Label label42;
        private Button button7;
        private TextBox buildingValue;
        private Label label43;
        private TextBox textBox2;
        private Button button8;
        private TextBox textBox3;
        private Label label44;
        public Label label40;
        
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        int buildingNumber = 1;
        public int[] floorRoomCounts;
        private Label label45;
        private TextBox textBox4;
        private TextBox textBox5;
        public RoomRange[] floorRoomRanges;
        public class RoomRange
        {
            public int Start { get; set; }
            public int End { get; set; }
        }

        public Form_IssueGuestCardDMS()
        {
            this.InitializeComponent();
            this.db = new DB();
        }

        private void Reset_to_IDLE_Default_Screen()
        {

            this.Configure_Controls_for_New();
            this.Reset_Controls_Value_ForNew();
            this.Refresh();
            this.cmdNew.Enabled = true;
            this.cmdReservedGuest.Enabled = true;
            this.cmdOld.Enabled = true;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest = 0U;
            this.Check_Cmd_And_SetBackColor();
            this.ClientFrame.Enabled = false;
            this.RegistrationFrame.Enabled = false;
            this.ChargesFrame.Enabled = false;
            this.cmdReadCard.Enabled = true;
            this.lblMessage.Text = "";
            this.ExtraChargeFrame.Visible = false;
        }
        private void cmdReturn_Click(object sender, EventArgs e)
        {
            ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
            this.Visible = false;
            this.Reset_to_IDLE_Default_Screen();
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = false;
        }

        private bool DisplayRoomNo()
        {
            if (this.sBuildingType != "Apartment")
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboCheckRoomNo(this.cboRoomNo);
            else
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboCheckUnitNoRs(this.cboUnitNo);
            return true;
        }

        private bool SearchRoomDisplay(uint para_GuestType)
        {
            switch (para_GuestType)
            {
                case 0:
                case 3:
                    this.SearchRoomDisplay_forNewGuest((string)this.cboBuildingNo.SelectedItem);
                    break;
                case 2:
                    this.SearchRoomDisplay_forReserveGuest((string)this.cboBuildingNo.SelectedItem);
                    break;
            }
            return true;
        }

        private bool SearchRoomDisplay_forReserveGuest(string para_BuildingNo)
        {
            if (((string)this.cboRoomType.SelectedItem).ToUpper().Contains("STUDIO") || ((string)this.cboRoomType.SelectedItem).ToUpper().Contains("TWIN"))
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                {
                    this._optPeople_0.Enabled = true;
                    this._optPeople_1.Enabled = true;
                    this.chkSecond.Checked = false;
                    this.chkSecond.Enabled = false;
                }
                this.Enable_StayingPeople_Frame();
            }
            else
                this.Disable_StayingPeople_Frame();
            this.cboRoomNo.Items.Clear();
            this.cboRoomNo.Items.Add((object)this.Reserve_RoomNo_Select);
            return true;
        }

        private bool SearchRoomDisplay_forNewGuest(string para_BuildingNo)
        {
            DateTime dateTime1 = this.dateTimePicker_ContractStart.Value.AddDays(-1.0);
            DateTime dateTime2 = this.dateTimePicker_ContractEnd.Value.AddDays(1.0);
            if (dateTime2.CompareTo(dateTime1) <= 0)
                return false;
            this.iRoomType = this.Get_iRoom_Type((string)this.cboRoomType.SelectedItem);
            if (((string)this.cboRoomType.SelectedItem).ToUpper().Contains("STUDIO") || ((string)this.cboRoomType.SelectedItem).ToUpper().Contains("TWIN"))
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U)
                {
                    this._optPeople_0.Enabled = true;
                    this._optPeople_1.Enabled = true;
                    this.chkSecond.Checked = false;
                    this.chkSecond.Enabled = false;
                }
                this.Enable_StayingPeople_Frame();
            }
            else
                this.Disable_StayingPeople_Frame();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsTempDBS = Application.UserAppDataPath + "\\\\System.mdb";
            this.sBuildingNo = this.cboBuildingNo.Text;
            this.db.Update_RoomStausXX_inSystemDB(this.sBuildingNo);
            switch (this.sBuildingNo)
            {
                case "1":
                    string commandText1 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText1;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus1.RoomNo,RoomStatus1.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus1 ON Room.RoomNo=RoomStatus1.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus1.Status)<2 ))AND RoomStatus1.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus1.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus1TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                case "2":
                    string commandText2 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText2;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus2.RoomNo,RoomStatus2.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus2 ON Room.RoomNo=RoomStatus2.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus2.Status)<2 ))AND RoomStatus2.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus2.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus2TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                case "3":
                    string commandText3 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText3;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus3.RoomNo,RoomStatus3.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus3 ON Room.RoomNo=RoomStatus3.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus3.Status)<2 ))AND RoomStatus3.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus3.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus3TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                case "4":
                    string commandText4 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText4;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus4.RoomNo,RoomStatus4.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus4 ON Room.RoomNo=RoomStatus4.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus4.Status)<2 ))AND RoomStatus4.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus4.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus4TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                case "5":
                    string commandText5 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText5;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus5.RoomNo,RoomStatus5.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus5 ON Room.RoomNo=RoomStatus5.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus5.Status)<2 ))AND RoomStatus5.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus5.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus5TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                case "6":
                    string commandText6 = this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText;
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from CheckRoom_Temp";
                    this.db.temp_DB.checkRoom_TempTableAdapter.Delete((string)null);
                    this.db.temp_DB.checkRoom_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText6;
                    this.db.Local_Command.CommandText = "Insert into CheckRoom_Temp (RoomNo,RmDescription,FloorNo,BuildingNo, DailyRate,WeeklyRate, MonthlyRate,Description) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select RoomStatus6.RoomNo,RoomStatus6.Description,Room.FloorNo,Room.BuildingNo,Room.DailyRate,Room.WeeklyRate,Room.MonthlyRate,RoomType.RmDescription From ( RoomType INNER JOIN Room ON RoomType.RoomType=Room.RoomType)INNER JOIN RoomStatus6 ON Room.RoomNo=RoomStatus6.RoomNo Where (((RoomType.RoomType)= " + (object)this.iRoomType + "))AND (((Room.BuildingNo)= '" + this.sBuildingNo + "')) AND (((RoomStatus6.Status)<2 ))AND RoomStatus6.StartDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#AND RoomStatus6.EndDate  Between # " + (object)dateTime1 + " # AND # " + (object)dateTime2 + "#ORDER BY Room.RoomNo";
                    this.db.Local_Command.Connection = this.db.system_DB.roomStatus6TableAdapter.Connection;
                    this.db.Local_Command.Connection.Open();
                    this.db.Local_Command.ExecuteNonQuery();
                    this.db.Local_Command.Connection.Close();
                    break;
                default:
                    int num = (int)MessageBox.Show("Need to implement for this case!");
                    break;
            }
            this.cboRoomNo.Text = "";
            this.cboRoomNo.Items.Clear();
            this.cboRoomNo.Refresh();
            this.DisplayRoomNo();
            this.cboRoomNo.Refresh();
            if (this.cboRoomNo.Items.Count <= 0)
            {
                this.ClientFrame.Enabled = false;
                this.lblRoomNo.Text = "";
                this.lblMessage.Text = "No Room Available for selected Type!";
                Console.Beep(700, 300);
            }
            else
                this.ClientFrame.Enabled = true;
            return true;
        }

        private void Set_Dates_Auto(string para_Charge_Type)
        {
            DateTime dateTime1 = new DateTime();
            switch (para_Charge_Type)
            {
                case "Monthly":
                    DateTime dateTime2;
                    if (this.dateTimePicker_ValidStart.Value.Day == 1)
                    {
                        dateTime2 = this.dateTimePicker_ValidStart.Value.AddMonths(1);
                        this.txtNoOfMonth.Text = "1";
                    }
                    else
                    {
                        this.txtEarlyStart.Text = (DateTime.DaysInMonth(this.dateTimePicker_ValidStart.Value.Year, this.dateTimePicker_ValidStart.Value.Month) - this.dateTimePicker_ValidStart.Value.Day + 1).ToString();
                        dateTime2 = this.dateTimePicker_ValidStart.Value.AddMonths(1);
                        dateTime2 = dateTime2.AddDays((double)-(dateTime2.Day - 1));
                        this.txtNoOfMonth.Text = "0";
                    }
                    this.lbNoOfDays.Text = "No of Month";
                    this.txtNoOfMonth.Visible = true;
                    this.txtNoOfDays.Visible = false;
                    this.txtNoOfWeek.Visible = false;
                    this.txtEarlyStart.Visible = true;
                    this.lbEarlyStart.Visible = true;
                    this.dateTimePicker_ValidEnd.Value = dateTime2;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U && this._optOldGuest_3.Checked && this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) > 0)
                        this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
                    if (Global_Data.NewDate_NewCheckIn_FirstPerson_Flag)
                        this.txtCheckInDate.Text = this.dateTimePicker_ValidStart.Text;
                    else if (this.txtCheckInDate.Text.Length <= 0)
                    {
                        int num = (int)MessageBox.Show("Check In Date is Empty!");
                    }
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giMGraceDefault.ToString();
                    else
                        this.txtGracePeriod.Text = "0";
                    this.dateTimePicker_CheckOutDate.Value = dateTime2.AddDays((double)Convert.ToInt16(this.txtGracePeriod.Text));
                    break;
                case "Weekly":
                    this.txtNoOfWeek.Text = "1";
                    this.txtNoOfMonth.Visible = false;
                    this.txtNoOfDays.Visible = false;
                    this.txtNoOfWeek.Visible = true;
                    this.lbNoOfDays.Text = "No Of Week";
                    this.txtEarlyStart.Visible = true;
                    this.lbEarlyStart.Visible = true;
                    this.sTotalDays = 7;
                    DateTime dateTime3 = this.dateTimePicker_ValidStart.Value.AddDays((double)this.sTotalDays);
                    this.dateTimePicker_ValidEnd.Value = dateTime3;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U && this._optOldGuest_3.Checked && this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) > 0)
                        this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
                    this.iNoOfWeek = this.sTotalDays / 7;
                    this.iWExtraDays = this.sTotalDays % 7;
                    this.txtNoOfWeek.Text = this.iNoOfWeek.ToString();
                    this.txtEarlyStart.Text = this.iWExtraDays.ToString();
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giWGraceDefault.ToString();
                    this.dateTimePicker_CheckOutDate.Value = dateTime3.AddDays((double)Convert.ToInt16(this.txtGracePeriod.Text));
                    break;
                case "Daily":
                    this.txtNoOfDays.Text = "1";
                    this.txtNoOfDays.Visible = true;
                    this.lbNoOfDays.Text = "No Of Days";
                    this.txtNoOfMonth.Visible = false;
                    this.txtNoOfWeek.Visible = false;
                    this.dateTimePicker_ValidEnd.Enabled = true;
                    this.txtEarlyStart.Visible = false;
                    this.lbEarlyStart.Visible = false;
                    DateTime dateTime4 = this.dateTimePicker_ValidStart.Value.AddDays(1.0);
                    this.dateTimePicker_ValidEnd.Value = dateTime4;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U && this._optOldGuest_3.Checked && this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) > 0)
                        this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giDGraceDefault.ToString();
                    this.dateTimePicker_CheckOutDate.Value = dateTime4.AddDays((double)Convert.ToInt16(this.txtGracePeriod.Text));
                    break;
            }
        }

        private bool Set_Dates_Check(string para_Charge_Type)
        {
            int num1 = 0;
            int num2 = 0;
            bool flag = false;
            if (this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ValidStart.Value) <= 0)
                return false;
            DateTime dateTime1 = this.dateTimePicker_ValidEnd.Value;
            DateTime dateTime2;
            if (this.dateTimePicker_ValidEnd.Value.Year == this.dateTimePicker_ValidStart.Value.Year)
                dateTime1 = this.dateTimePicker_ValidEnd.Value;
            else if (this.dateTimePicker_ValidEnd.Value.Year > this.dateTimePicker_ValidStart.Value.Year)
            {
                for (dateTime2 = new DateTime(this.dateTimePicker_ValidStart.Value.AddYears(1).Year, 1, 1); dateTime2.Year < this.dateTimePicker_ValidEnd.Value.Year; dateTime2 = dateTime2.AddYears(1))
                {
                    num1 += 12;
                    if (dateTime2.Year % 4 == 0)
                        num2 += 366;
                    else
                        num2 += 365;
                }
                if (para_Charge_Type == "Monthly")
                {
                    num1 += this.dateTimePicker_ValidEnd.Value.Month - 1;
                    num2 = this.dateTimePicker_ValidEnd.Value.Day;
                }
                else
                {
                    for (; dateTime2.CompareTo(this.dateTimePicker_ValidEnd.Value) <= 0; dateTime2 = dateTime2.AddMonths(1))
                    {
                        if (dateTime2.Month < this.dateTimePicker_ValidEnd.Value.Month)
                            num2 += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
                        else if (dateTime2.Month == this.dateTimePicker_ValidEnd.Value.Month)
                            num2 += this.dateTimePicker_ValidEnd.Value.Day;
                    }
                }
                dateTime1 = new DateTime(this.dateTimePicker_ValidStart.Value.Year, 12, 31);
                flag = true;
            }
            else if (this.dateTimePicker_ValidEnd.Value.Year > this.dateTimePicker_ValidStart.Value.Year + 1)
            {
                int num3 = (int)MessageBox.Show("So long date range!");
                return false;
            }
            if (para_Charge_Type == "Monthly")
            {
                if (dateTime1.Year == this.dateTimePicker_ValidStart.Value.Year)
                {
                    int num4;
                    if (dateTime1.Month > this.dateTimePicker_ValidStart.Value.Month)
                    {
                        if (dateTime1.Day >= this.dateTimePicker_ValidStart.Value.Day)
                        {
                            if (this.dateTimePicker_ValidStart.Value.Day > num2)
                            {
                                this.txtNoOfMonth.Text = (dateTime1.Month - this.dateTimePicker_ValidStart.Value.Month + num1).ToString();
                                num4 = flag ? DateTime.DaysInMonth(this.dateTimePicker_ValidStart.Value.Year, this.dateTimePicker_ValidStart.Value.Month) - this.dateTimePicker_ValidStart.Value.Day + num2 : dateTime1.Day - this.dateTimePicker_ValidStart.Value.Day + num2;
                            }
                            else
                            {
                                this.txtNoOfMonth.Text = (dateTime1.Month - this.dateTimePicker_ValidStart.Value.Month + num1 + 1).ToString();
                                num4 = num2 - this.dateTimePicker_ValidStart.Value.Day;
                            }
                        }
                        else
                        {
                            this.txtNoOfMonth.Text = (dateTime1.Month - this.dateTimePicker_ValidStart.Value.Month - 1 + num1).ToString();
                            num4 = DateTime.DaysInMonth(this.dateTimePicker_ValidStart.Value.Year, this.dateTimePicker_ValidStart.Value.Month) - this.dateTimePicker_ValidStart.Value.Day + dateTime1.Day + num2;
                        }
                    }
                    else if (dateTime1.Month == this.dateTimePicker_ValidStart.Value.Month)
                    {
                        if (this.dateTimePicker_ValidStart.Value.Day > num2)
                        {
                            num4 = dateTime1.Day - this.dateTimePicker_ValidStart.Value.Day + num2;
                            this.txtNoOfMonth.Text = num1.ToString();
                        }
                        else
                        {
                            this.txtNoOfMonth.Text = (num1 + 1).ToString();
                            num4 = num2 - this.dateTimePicker_ValidStart.Value.Day;
                        }
                    }
                    else
                    {
                        int num5 = (int)MessageBox.Show("Code Error Found! Pls. Check!");
                        return false;
                    }
                    this.txtEarlyStart.Text = num4.ToString();
                    this.lbNoOfDays.Text = "No of Month";
                    this.txtNoOfMonth.Visible = true;
                    this.txtNoOfDays.Visible = false;
                    this.txtNoOfWeek.Visible = false;
                    this.txtEarlyStart.Visible = true;
                    this.lbEarlyStart.Visible = true;
                    if (Global_Data.NewDate_NewCheckIn_FirstPerson_Flag)
                        this.txtCheckInDate.Text = this.dateTimePicker_ValidStart.Text;
                    else if (this.txtCheckInDate.Text.Length <= 0)
                    {
                        int num6 = (int)MessageBox.Show("Check In Date is Empty!");
                    }
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giMGraceDefault.ToString();
                    else
                        this.txtGracePeriod.Text = "0";
                }
                else
                {
                    int num7 = (int)MessageBox.Show("Code Error Found! Pls. Check!");
                    return false;
                }
            }
            else
            {
                if (dateTime1.Month == this.dateTimePicker_ValidStart.Value.Month)
                {
                    this.sTotalDays = dateTime1.Day - this.dateTimePicker_ValidStart.Value.Day;
                    this.sTotalDays += num2;
                }
                else
                {
                    this.sTotalDays = DateTime.DaysInMonth(this.dateTimePicker_ValidStart.Value.Year, this.dateTimePicker_ValidStart.Value.Month) - this.dateTimePicker_ValidStart.Value.Day;
                    for (dateTime2 = this.dateTimePicker_ValidStart.Value.AddMonths(1); dateTime2.CompareTo(dateTime1) < 0 && dateTime2.Month < dateTime1.Month; dateTime2 = dateTime2.AddMonths(1))
                        this.sTotalDays += DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month);
                    this.sTotalDays += dateTime1.Day;
                    this.sTotalDays += num2;
                }
                switch (para_Charge_Type)
                {
                    case "Weekly":
                        this.txtNoOfMonth.Visible = false;
                        this.txtNoOfDays.Visible = false;
                        this.txtNoOfWeek.Visible = true;
                        this.lbNoOfDays.Text = "No Of Week";
                        this.txtEarlyStart.Visible = true;
                        this.lbEarlyStart.Visible = true;
                        this.iNoOfWeek = this.sTotalDays / 7;
                        this.iWExtraDays = this.sTotalDays % 7;
                        this.txtNoOfWeek.Text = this.iNoOfWeek.ToString();
                        this.txtEarlyStart.Text = this.iWExtraDays.ToString();
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        {
                            this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giWGraceDefault.ToString();
                            break;
                        }
                        break;
                    case "Daily":
                        this.txtNoOfDays.Text = this.sTotalDays.ToString();
                        this.txtNoOfDays.Visible = true;
                        this.lbNoOfDays.Text = "No Of Days";
                        this.txtNoOfMonth.Visible = false;
                        this.txtNoOfWeek.Visible = false;
                        this.dateTimePicker_ValidEnd.Enabled = true;
                        this.txtEarlyStart.Visible = false;
                        this.lbEarlyStart.Visible = false;
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest >= 1U)
                        {
                            this.txtGracePeriod.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giDGraceDefault.ToString();
                            break;
                        }
                        break;
                }
            }
            this.dateTimePicker_CheckOutDate.Value = this.dateTimePicker_ValidEnd.Value.AddDays((double)Convert.ToInt16(this.txtGracePeriod.Text));
            return true;
        }

        private int Get_iRoom_Type(string para_string)
        {
            int iRoomType = 1;
            bool flag = false;
            this.db.system_DB.roomTypeTableAdapter.Fill(this.db.system_DB.systemDataSet.RoomType);
            foreach (SystemDataSet.RoomTypeRow row in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.RoomType.Rows)
            {
                if (row.RmDescription == para_string)
                {
                    iRoomType = (int)row.RoomType;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                int num = (int)MessageBox.Show("RoomType Table not Found!");
            }
            return iRoomType;
        }

        private void CheckBuilding()
        {
            this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
            foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.Building.Rows)
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel != "0")
                {
                    if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
                        this.cboBuildingNo.Items.Add((object)row.BuildingNo);
                }
                else
                    this.cboBuildingNo.Items.Add((object)row.BuildingNo);
            }
            if (this.cboBuildingNo.Items.Count > 0)
                this.cboBuildingNo.SelectedIndex = 0;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo = (string)this.cboBuildingNo.SelectedItem;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetSystemInfo();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetKeyCharges();
        }

        private void Initialize_1st_Time()
        {
            
            this.cboChargeType.Items.Add((object)"Daily");
            this.cboChargeType.Items.Add((object)"Weekly");
            this.cboChargeType.Items.Add((object)"Monthly");
            this.cboChargeType.SelectedItem = (object)"Monthly";
            this.cboSex.Items.Add((object)"M");
            this.cboSex.Items.Add((object)"F");
            this.cboSex.SelectedItem = (object)"M";
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialze_ComboCountry(this.cboCountry);
            this.CheckBuilding();
            this.db.Update_Date_Building_Roomstaus_Table((string)this.cboBuildingNo.SelectedItem);
            this.sBuildingType = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.CheckBuildingType((string)this.cboBuildingNo.SelectedItem);
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRoomType_ForGuest(this.cboRoomType, this.sBuildingType);
            this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
            this.SearchRoomDisplay(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest);
        }

        private void Form_IssueGuestCardDMS_Load(object sender, EventArgs e)
        {

            string filePath = "dropdowns.txt";
            int buildingNumber = 0;
            int maxFloor = 0;

            // Create a class to hold room range information


            // Read all lines from the file
            var lines = File.ReadAllLines(filePath);

            // First pass: Determine the maximum floor number
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    if (parts[0] == "b" && int.TryParse(parts[1], out int number))
                    {
                        buildingNumber = number;
                    }
                    else if (int.TryParse(parts[0], out int floor))
                    {
                        if (floor > maxFloor)
                            maxFloor = floor;
                    }
                }
            }

            // Create arrays to store start and end room numbers for each floor
            floorRoomRanges = new RoomRange[maxFloor + 1];

            // Second pass: Parse the room ranges for each floor
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && parts[0] != "b" && int.TryParse(parts[0], out int floor))
                {
                    if (parts[1].Contains("-"))
                    {
                        var rangeParts = parts[1].Split('-');
                        if (rangeParts.Length == 2 && 
                            int.TryParse(rangeParts[0], out int start) && 
                            int.TryParse(rangeParts[1], out int end))
                        {
                            floorRoomRanges[floor] = new RoomRange { Start = start, End = end };
                        }
                    }
                }
            }

            // Populate UI components
            // For comboBox1: display the building number
            comboBox1.Items.Clear();
            comboBox1.Items.Add($"{buildingNumber}");
            comboBox1.SelectedIndex = 0;

            // For comboBox2: list the floor numbers (from 1 to maxFloor)
            comboBox2.Items.Clear();
            for (int floor = 1; floor <= maxFloor; floor++)
            {
                comboBox2.Items.Add($"{floor}");
            }
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }

            // For comboBox3: populate with room numbers for floor 1 (if available)
            if (floorRoomRanges[1] != null)
            {
                PopulateComboBox3WithRange(floorRoomRanges[1].Start, floorRoomRanges[1].End);
            }

            // For comboBox4: display the building number
            comboBox4.Items.Clear();
            comboBox4.Items.Add($"{buildingNumber}");
            comboBox4.SelectedIndex = 0;

            // For comboBox5: list the floor numbers
            comboBox5.Items.Clear();
            for (int floor = 1; floor <= maxFloor; floor++)
            {
                comboBox5.Items.Add($"{floor}");
            }
            if (comboBox5.Items.Count > 0)
            {
                comboBox5.SelectedIndex = 0;
            }

            this._1st_Time_Flag = true;
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = true;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest = 0U;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = false;
            this.cmdIssue.BackColor = SystemColors.InactiveCaption;
            this.sClientType = "G";
            this.sCardType = "G";
            this.sAdvance = "0";
            this.sTempAmountDue = "0";
            this.sTempCurRoomCharge = "0";
            this.sTransferType = "";
            this.sChkTotalStay = "";
            AccessCard.sCardNo = "NA";
            Mod_UpdateData.bExtraLoss = false;
            this._txtExtraAmount_0.Text = "0";
            this._txtExtraAmount_1.Text = "0";
            this._txtExtraAmount_2.Text = "0";
            this._txtExtraAmount_4.Text = "0";
            this._txtExtraAmount_3.Text = "0";
            this._txtDesExtra_0.Text = "";
            this._txtDesExtra_1.Text = "";
            this._txtDesExtra_2.Text = "";
            this._txtDesExtra_3.Text = "";
            this._txtDesExtra_4.Text = "";
            this.txtExtraTotal.Text = "0";
            for (int index = 0; index < 4; ++index)
            {
                this.bExAmount[index] = false;
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index] = "0";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index] = (string)null;
            }
            this.lbCardType.Text = "Guest";
        }

        private void PopulateComboBox3(int roomCount)
        {
            comboBox3.Items.Clear();
            for (int roomNumber = 1; roomNumber <= roomCount; roomNumber++)
            {
                comboBox3.Items.Add($"{roomNumber}");
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
        }

        private void PopulateComboBox6(int roomCount)
        {
            comboBox6.Items.Clear();
            for (int roomNumber = 1; roomNumber <= roomCount; roomNumber++)
            {
                comboBox6.Items.Add($"{roomNumber}");
            }
            if (comboBox6.Items.Count > 0)
            {
                comboBox6.SelectedIndex = 0;
            }
        }

        private void mskContractStart_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_pdf_Click(object sender, EventArgs e)
        {
        }

        private void Form_IssueGuestCardDMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void Disable_StayingPeople_Frame()
        {
            this.StayingPeopleFrame.Visible = false;
            this.StayingPeopleFrame.Enabled = false;
        }

        public void Enable_StayingPeople_Frame()
        {
            this.StayingPeopleFrame.Visible = true;
            this.StayingPeopleFrame.Enabled = true;
        }

        private void Check_Cmd_And_SetBackColor()
        {
            if (!this.cmdOld.Enabled)
                this.cmdOld.BackColor = SystemColors.InactiveCaption;
            else
                this.cmdOld.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            if (!this.cmdReservedGuest.Enabled)
                this.cmdReservedGuest.BackColor = SystemColors.InactiveCaption;
            else
                this.cmdReservedGuest.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            if (!this.cmdNew.Enabled)
                this.cmdNew.BackColor = SystemColors.InactiveCaption;
            else
                this.cmdNew.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
        }

        public void Configure_Controls_for_New()
        {
            this.Reservation_Frame_Disabled();
            this.OldGuestFrame.Visible = false;
            this.OldGuestFrame.Enabled = false;
            this.chkExtendNewCard.Visible = false;
            this.chkExtendNewCard.Checked = false;
            this.checkBox_Replace.Visible = false;
            this.cmdLoss.Visible = false;
            this.cmdLoss.Enabled = false;
            this.ClientFrame.Enabled = true;
            this.ChargesFrame.Enabled = true;
            this.RegistrationFrame.Enabled = true;
            this.chkBondDiff.Visible = false;
            this.txtDiffBond.Visible = false;
            this.chkBondDiff.Enabled = false;
            this.lblDiffBond.Visible = false;
            this.Clear_Charge_Frame_Value();
            this.Disable_StayingPeople_Frame();
            this.cmdViewClient.Visible = false;
            this.cmdViewClient.Enabled = false;
            this.cboRoomNo.Visible = true;
            this.cboRoomNo.Enabled = true;
            this.lblAvailableRooms.Visible = true;
            this.cboRoomType.Enabled = true;
            this.cmdNew.BackColor = SystemColors.InactiveCaption;
            this.cmdNew.Enabled = false;
            if (!this.cmdOld.Enabled)
            {
                this.cmdOld.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                this.cmdOld.Enabled = true;
            }
            if (this.cmdReservedGuest.Enabled)
                return;
            this.cmdReservedGuest.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.cmdReservedGuest.Enabled = true;
        }

        public void Configure_Controls_for_Reserved()
        {
            this.Reservation_Frame_Enabled();
            this.OldGuestFrame.Visible = false;
            this.OldGuestFrame.Enabled = false;
            this.cmdLoss.Visible = false;
            this.cmdLoss.Enabled = false;
            this.ClientFrame.Enabled = true;
            this.ChargesFrame.Enabled = true;
            this.RegistrationFrame.Enabled = false;
            this.chkBondDiff.Visible = false;
            this.txtDiffBond.Visible = false;
            this.chkBondDiff.Enabled = false;
            this.lblDiffBond.Visible = false;
            this.cmdViewClient.Visible = false;
            this.cmdViewClient.Enabled = false;
            this.cboRoomNo.Visible = false;
            this.cboRoomNo.Enabled = false;
            this.lblAvailableRooms.Visible = false;
            this.cboRoomType.Enabled = false;
            if (!this.cmdNew.Enabled)
            {
                this.cmdNew.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                this.cmdNew.Enabled = true;
            }
            if (!this.cmdOld.Enabled)
            {
                this.cmdOld.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                this.cmdOld.Enabled = true;
            }
            this.cmdReservedGuest.Enabled = false;
            this.cmdReservedGuest.BackColor = SystemColors.InactiveCaption;
            this.txtBond.Enabled = true;
        }

        public void Configure_Controls_for_Old()
        {
            this.Reservation_Frame_Disabled();
            this._optOldGuest_0.Checked = true;
            this._optOldGuest_1.Checked = false;
            this._optOldGuest_3.Checked = false;
            this._optOldGuest_1.Enabled = false;
            this._optOldGuest_3.Enabled = false;
            this.cmdLoss.Enabled = false;
            this.OldGuestFrame.Visible = true;
            this.ClientFrame.Enabled = true;
            this.ChargesFrame.Enabled = true;
            this.RegistrationFrame.Enabled = false;
            this.cmdViewClient.Visible = true;
            this.cmdViewClient.Enabled = true;
            this.cboRoomNo.Visible = false;
            this.cboRoomNo.Enabled = false;
            this.lblAvailableRooms.Visible = false;
            this.cboRoomType.Enabled = false;
            if (!this.cmdNew.Enabled)
            {
                this.cmdNew.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                this.cmdNew.Enabled = true;
            }
            this.cmdOld.BackColor = SystemColors.InactiveCaption;
            this.cmdOld.Enabled = false;
            if (!this.cmdReservedGuest.Enabled)
            {
                this.cmdReservedGuest.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                this.cmdReservedGuest.Enabled = true;
            }
            this.txtBond.Enabled = false;
        }

        public void Configure_Control_For_Default()
        {
        }

        private void Clear_Client_Frame_Value()
        {
            this.txtClientID.Text = "";
            this.txtFirstName.Text = "";
            this.txtIdentity.Text = "";
            this.txtAddress.Text = "";
            this.txtSurName.Text = "";
            this.txtNationality.Text = "";
            this.txtContact.Text = "";
            this.textBox_Email.Text = "";
            this.cboCountry.SelectedIndex = 0;
            this.cboSex.SelectedItem = (object)"M";
        }

        private void Clear_Charge_Frame_Value()
        {
            this.ChargeFrame_InsertingFlag = true;
            this.txtRoomCharge.Text = "0.00";
            this.txtCurrRoomCharge.Text = "0.00";
            this.txtDeposit.Text = "0.00";
            this.txtAmountPaid.Text = "0.00";
            this.txtAdvance.Text = "0.00";
            this.txtKeyDeposit.Text = "0.00";
            this.txtExtraKeyCharge.Text = "0.00";
            this.txtBond.Text = "0.00";
            this.txtDiffBond.Text = "0.00";
            this.txtPrevious.Text = "0.00";
            this.txtReceived.Text = "0.00";
            this.txtToCollect.Text = "0.00";
            this.txtDisplayAmount.Text = "0.00";
            this.txtDiffBond.Text = "0.00";
            this.ChargeFrame_InsertingFlag = false;
        }

        private void Reset_Controls_Value()
        {
            this.Reset_Calendar_Limits();
            this.Clear_Client_Frame_Value();
            this.lblRoomNo.Text = "";
            this.txtIssuedCard.Text = "0";
            this.txtEarlyStart.Text = "0";
            this.lbCardType.Text = "";
            this.txtCardNo.Text = "";
            this.txtRemark.Text = "";
            this.Clear_Charge_Frame_Value();
            this.Clear_Extra_Frame_values();
            gCardProperty.LossLog = 0;
            this.cmdLoss.Text = "Inform Key Loss";
            try
            {
                this.cboChargeType.SelectedItem = (object)"Monthly";
            }
            catch
            {
            }
        }

        private void Clear_Extra_Frame_values()
        {
            this._txtDesExtra_0.Text = "";
            this._txtDesExtra_1.Text = "";
            this._txtDesExtra_2.Text = "";
            this._txtDesExtra_3.Text = "";
            this._txtDesExtra_4.Text = "";
            this._txtDesExtra_1.Visible = false;
            this._txtDesExtra_2.Visible = false;
            this._txtDesExtra_3.Visible = false;
            this._txtDesExtra_4.Visible = false;
            this._txtDesExtra_1.Enabled = false;
            this._txtDesExtra_2.Enabled = false;
            this._txtDesExtra_3.Enabled = false;
            this._txtDesExtra_4.Enabled = false;
            this._txtExtraAmount_0.Text = "0.00";
            this._txtExtraAmount_1.Text = "0.00";
            this._txtExtraAmount_2.Text = "0.00";
            this._txtExtraAmount_3.Text = "0.00";
            this._txtExtraAmount_4.Text = "0.00";
            this._txtExtraAmount_1.Visible = false;
            this._txtExtraAmount_2.Visible = false;
            this._txtExtraAmount_3.Visible = false;
            this._txtExtraAmount_4.Visible = false;
            this._txtExtraAmount_1.Enabled = false;
            this._txtExtraAmount_2.Enabled = false;
            this._txtExtraAmount_3.Enabled = false;
            this._txtExtraAmount_4.Enabled = false;
            this.txtExtraTotal.Text = "0.00";
            this.txtExtraDescription.Text = "";
            this.txtExtra.Text = "0.00";
        }

        private void Reset_Calendar_Limits()
        {
            this.dateTimePicker_ContractEnd.MinDate = DateTime.Parse("1753-01-01");
            this.dateTimePicker_ContractEnd.MaxDate = DateTime.Parse("9998-12-31");
            this.dateTimePicker_ContractStart.MinDate = DateTime.Parse("1753-01-01");
            this.dateTimePicker_ContractStart.MaxDate = DateTime.Parse("9998-12-31");
            this.dateTimePicker_ValidEnd.MinDate = DateTime.Parse("1753-01-01");
            this.dateTimePicker_ValidEnd.MaxDate = DateTime.Parse("9998-12-31");
            this.dateTimePicker_ValidStart.MinDate = DateTime.Parse("1753-01-01");
            this.dateTimePicker_ValidStart.MaxDate = DateTime.Parse("9998-12-31");
        }

        private void Reset_Controls_Value_ForNew()
        {
            this.Clear_Client_Frame_Value();
            this.lblRoomNo.Text = "";
            this.txtIssuedCard.Text = "0";
            this.txtEarlyStart.Text = "0";
            this.lbCardType.Text = "Guest";
            this.txtCardNo.Text = "";
            this.txtRemark.Text = "";
            this.Clear_Extra_Frame_values();
            this.dateTime_Auto_InsertingFlag = true;
            this.Reset_Calendar_Limits();
            this.dateTimePicker_ContractStart.Value = DateTime.Now;
            this.dateTimePicker_ValidStart.Value = DateTime.Now;
            this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
            this.dateTime_Auto_InsertingFlag = false;
            gCardProperty.LossLog = 0;
            this.cmdLoss.Text = "Inform Key Loss";
            this.txtBond.Enabled = true;
            try
            {
                this.cboChargeType.SelectedItem = (object)"Monthly";
            }
            catch
            {
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {

            this.dateTimePicker_CheckInTime.Enabled = true;
            this.lblMessage.Text = "";
            this.lblMessage2.Text = "Enter First Name ...";
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = true;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = false;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest = 3U;
            this.cmdNew.BackColor = SystemColors.InactiveCaption;
            this.cmdNew.Enabled = false;
            this.cmdPrint.Enabled = false;
            this.Configure_Controls_for_New();
            this.Reset_Controls_Value_ForNew();
            this.Refresh();
            this.dateTimePicker_ContractStart.Enabled = true;
            this.dateTimePicker_ContractEnd.Enabled = true;
            this.SearchRoomDisplay(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest);
            Mod_UpdateData.iChkCardStatus = (byte)0;
            this.txtExtraKeyCharge.Text = "0.00";
            this.lbExtraKeyCharge.Text = "Key Deposit";
            this.txtKeyDeposit.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giKeyDeposit;
            this.txtKeyDeposit.Visible = true;
            this.txtExtraKeyCharge.Visible = false;
            this.txtKeyDeposit.Enabled = true;
            this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
            this.txtClientID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_ClientID(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
            this.Refresh();
            this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            this.txtFirstName.Focus();
            this.dateTimePicker_ContractStart.Enabled = true;
            this.dateTimePicker_ContractEnd.Enabled = true;
            this.dateTimePicker_ValidEnd.Enabled = true;
            this.dateTimePicker_ValidStart.Enabled = true;
            this.txtExtraDescription.Enabled = true;
            if (this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) > 0)
                this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
            try
            {
                this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
            }
            catch
            {
            }
            try
            {
                this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + DateTime.Now.ToShortTimeString());
                this.dateTimePicker_ValidEnd.Value = (this.dateTimePicker_CheckInTime.Value).AddMonths(6);
                this.txtFirstName.Text = " ";
                this.txtSurName.Text = " ";
                this.txtNationality.Text = " ";
                this.textBox_Email.Text = "a@b.com";
                this.txtIdentity.Text = "   ";
                this.txtReceived.Text = "10000";
                this.txtCheckInDate.Enabled = true;
            }
            catch
            {
            }

        }

        private void cmdReservedGuest_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = "";
            this.lblMessage2.Text = "Select Reservation Ref.No from Browser..";
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = true;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = false;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest = 2U;
            this.cmdPrint.Enabled = false;
            this.txtReservationRef.Clear();
            this.Configure_Controls_for_Reserved();
            this.Reset_Controls_Value();
            this.cmdViewReserveList.Select();
            try
            {
                this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
            }
            catch
            {
            }
            try
            {
                this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + DateTime.Now.ToShortTimeString());
            }
            catch
            {
            }

        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblMessage.Text = "";
            if (!this._1st_Time_Flag && ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
            {
                this.cboRoomType.Refresh();
                this.cboRoomNo.Items.Clear();
                this.SearchRoomDisplay(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest);
                this.cboRoomNo.Refresh();
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                    this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                else
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 0U)
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            }
            if (((string)this.cboRoomType.SelectedItem).ToUpper().Contains("STUDIO") || ((string)this.cboRoomType.SelectedItem).ToUpper().Contains("TWIN"))
                this.Enable_StayingPeople_Frame();
            else
                this.Disable_StayingPeople_Frame();
        }

        private void cboBuildingNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._1st_Time_Flag)
                return;
            this.db.Update_Date_Building_Roomstaus_Table((string)this.cboBuildingNo.SelectedItem);
            this.sBuildingType = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.CheckBuildingType((string)this.cboBuildingNo.SelectedItem);
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRoomType_ForGuest(this.cboRoomType, this.sBuildingType);
            this.SearchRoomDisplay(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest);
        }

        private void ClearValue()
        {
            this.txtDeposit.Text = "0.00";
            this.txtCurrRoomCharge.Text = "0.00";
        }

        private void CalculateRoomCharge(string para_Room_No)
        {
            this.GetRoomRate(para_Room_No);
            Decimal num1 = 0M;
            if (this.bNoCharge)
                return;
            switch ((string)this.cboChargeType.SelectedItem)
            {
                case "Daily":
                    num1 = this.iDayRate * (Decimal)Convert.ToInt16(this.txtNoOfDays.Text);
                    this.txtRoomCharge.Text = this.iDayRate.ToString("F2");
                    break;
                case "Weekly":
                    double num2 = (double)this.iWeekRate * (52.0 / 365.0);
                    int num3 = (int)num2;
                    if ((double)num3 + 0.5 <= num2)
                        ++num3;
                    Decimal num4 = (Decimal)(num3 * (int)Convert.ToInt16(this.txtEarlyStart.Text));
                    num1 = this.iWeekRate * (Decimal)Convert.ToInt16(this.txtNoOfWeek.Text) + num4;
                    this.txtRoomCharge.Text = this.iWeekRate.ToString("F2");
                    break;
                case "Monthly":
                    double num5 = (double)this.iMonthRate * (12.0 / 365.0);
                    int num6 = (int)num5;
                    if ((double)num6 + 0.5 <= num5)
                        ++num6;
                    Decimal num7 = (Decimal)(num6 * (int)Convert.ToInt16(this.txtEarlyStart.Text));
                    num1 = this.iMonthRate * (Decimal)Convert.ToInt16(this.txtNoOfMonth.Text) + num7;
                    this.txtRoomCharge.Text = this.iMonthRate.ToString("F2");
                    break;
            }
            this.txtCurrRoomCharge.Text = num1.ToString("F2");
        }

        private void CalculateRoomCharge_ForExtension(string para_Room_No)
        {
            this.GetRoomRate(para_Room_No);
            if (this.bNoCharge)
                return;
            switch ((string)this.cboChargeType.SelectedItem)
            {
                case "Daily":
                    this.CalculateRoomCharge_forDailyMode(1, (int)this.iDayRate);
                    break;
                case "Weekly":
                    this.CalculateRoomCharge_forWeeklyMode(1, (int)this.iWeekRate, 0);
                    break;
                case "Monthly":
                    this.CalculateRoomCharge_forMonthlyMode(1, (int)this.iMonthRate, 0);
                    break;
            }
        }

        private void CalculateRoomCharge_forDailyMode(int para_no_of_days, int para_Dailyrate)
        {
            this.txtCurrRoomCharge.Text = (para_Dailyrate * para_no_of_days).ToString("F2");
        }

        private void CalculateRoomCharge_forWeeklyMode(
          int para_no_of_Weeks,
          int para_Weeklyrate,
          int para_extra_days)
        {
            double num1 = (double)para_Weeklyrate * (52.0 / 365.0);
            int num2 = (int)num1;
            if ((double)num2 + 0.5 <= num1)
                ++num2;
            int num3 = num2 * para_extra_days;
            this.txtCurrRoomCharge.Text = (para_Weeklyrate * para_no_of_Weeks + num3).ToString("F2");
        }

        private void CalculateRoomCharge_forMonthlyMode(
          int para_no_of_Months,
          int para_Monthlyrate,
          int para_extra_days)
        {
            double num1 = (double)para_Monthlyrate * (12.0 / 365.0);
            int num2 = (int)num1;
            if ((double)num2 + 0.5 <= num1)
                ++num2;
            int num3 = num2 * para_extra_days;
            this.txtCurrRoomCharge.Text = (para_Monthlyrate * para_no_of_Months + num3).ToString("F2");
        }

        private void Display_Others_Relative_Money(Decimal para_Caculated_Room_Charge)
        {
            this.txtCurrRoomCharge.Text = para_Caculated_Room_Charge.ToString("F2");
            this.txtToCollect.Text = this.sTotalBuffer;
            Decimal num1;
            try
            {
                num1 = Convert.ToDecimal(this.txtBond.Text);
            }
            catch
            {
                num1 = 0M;
            }
            Decimal num2;
            try
            {
                num2 = Convert.ToDecimal(this.txtExtra.Text);
            }
            catch
            {
                num2 = 0M;
            }
            Decimal num3;
            try
            {
                num3 = Convert.ToDecimal(this.txtKeyDeposit.Text);
            }
            catch
            {
                num3 = 0M;
            }
            Decimal num4;
            try
            {
                num4 = Convert.ToDecimal(this.txtDeposit.Text);
            }
            catch
            {
                num4 = 0M;
            }
            Decimal num5;
            try
            {
                num5 = Convert.ToDecimal(this.txtReceived.Text);
            }
            catch
            {
                num5 = 0M;
            }
            Decimal num6 = num4 + num5;
            Decimal num7;
            Decimal num8;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U)
            {
                num7 = para_Caculated_Room_Charge + num1 + num2 + num3;
                if (num7 < num6)
                {
                    num8 = num6 - num7;
                    this.sTotalBuffer = "0";
                }
                else
                {
                    this.sTotalBuffer = (num7 - num6).ToString();
                    num8 = 0M;
                }
                this.sCurAdvance = num8.ToString();
            }
            else
            {
                this.sTotalExtra = num2 + Convert.ToDecimal(this.txtExtraKeyCharge.Text) + num3;
                try
                {
                    Convert.ToDecimal(this.txtDiffBond.Text);
                }
                catch
                {
                    int num9 = (int)MessageBox.Show("Incorrect Input Number in Bond Diff!");
                }
                if (this._optOldGuest_3.Checked && Convert.ToDecimal(this.txtDiffBond.Text) != 0M)
                {
                    if (Convert.ToDecimal(this.sAdvance) + num5 - (para_Caculated_Room_Charge + this.sTotalExtra + Convert.ToDecimal(this.txtDiffBond.Text)) >= 0M)
                    {
                        this.sTotalBuffer = "0";
                        num8 = Convert.ToDecimal(this.sAdvance) + num5 - (para_Caculated_Room_Charge + this.sTotalExtra + Convert.ToDecimal(this.txtDiffBond.Text));
                    }
                    else
                    {
                        this.sTotalBuffer = (para_Caculated_Room_Charge + this.sTotalExtra + Convert.ToDecimal(this.txtDiffBond.Text) - (Convert.ToDecimal(this.sAdvance) + num5)).ToString();
                        num8 = 0M;
                    }
                    this.sCurAdvance = num8.ToString();
                }
                else
                {
                    if (Convert.ToDecimal(this.sAdvance) + num5 - (para_Caculated_Room_Charge + this.sTotalExtra) >= 0M)
                    {
                        this.sTotalBuffer = "0";
                        num8 = Convert.ToDecimal(this.sAdvance) + num5 - (para_Caculated_Room_Charge + this.sTotalExtra);
                    }
                    else
                    {
                        this.sTotalBuffer = (para_Caculated_Room_Charge + this.sTotalExtra - (Convert.ToDecimal(this.sAdvance) + num5)).ToString();
                        num8 = 0M;
                    }
                    this.sCurAdvance = num8.ToString();
                }
                if (this._optOldGuest_3.Checked && Convert.ToDecimal(this.txtDiffBond.Text) != 0M)
                {
                    num7 = para_Caculated_Room_Charge + this.sTotalExtra + Convert.ToDecimal(this.txtDiffBond.Text);
                    this.sCurAdvance = (num5 - num7).ToString();
                }
                else
                {
                    num7 = para_Caculated_Room_Charge + this.sTotalExtra;
                    this.sCurAdvance = (num5 - num7).ToString();
                }
            }
            this.txtAdvance.Text = num8.ToString("F2");
            this.txtToCollect.Text = this.sTotalBuffer;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U)
            {
                Decimal num10 = Convert.ToDecimal(this.txtDeposit.Text);
                if (num10 > 0M)
                    num7 -= num10;
            }
            else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
            {
                Decimal num11 = Convert.ToDecimal(this.sAdvance);
                if (num11 > 0M)
                    num7 -= num11;
            }
            if (num7 > 0M)
                this.txtDisplayAmount.Text = num7.ToString();
            else
                this.txtDisplayAmount.Text = "0.00";
            this.sTotalPaid = (Convert.ToDecimal(this.txtAmountPaid.Text) + Convert.ToDecimal(this.txtReceived.Text)).ToString();
        }

        private int GetRoomType(string para_Room_No)
        {
            int roomType = 0;
            bool flag = false;
            try
            {
                this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
                if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
                    this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
            }
            catch
            {
                this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
            }
            if (this.db.system_DB.systemDataSet.Room.Rows.Count > 0)
            {
                foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.Room.Rows)
                {
                    if (row.RoomNo == para_Room_No)
                    {
                        roomType = (int)row.RoomType;
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("GetRoomType fail! No rooms in System Database's Room Table!");
            }
            if (!flag)
            {
                int num2 = (int)MessageBox.Show("GetRoomType fail! RoomType not found for room " + para_Room_No + " in  Room Table!");
            }
            return roomType;
        }

        private byte GetRoomType_ForReserve(string para_Room_No)
        {
            byte roomTypeForReserve = 0;
            bool flag = false;
            try
            {
                this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
                if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count <= 0)
                    this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
            }
            catch
            {
                this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
            }
            if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count > 0)
            {
                foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
                {
                    if (row.RoomNo == para_Room_No)
                    {
                        roomTypeForReserve = row.RoomType;
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("GetRoomType fail! No rooms in System Database's Room Table!");
            }
            if (!flag)
            {
                int num2 = (int)MessageBox.Show("GetRoomType fail! RoomType not found for room " + para_Room_No + " in  Room Table!");
            }
            return roomTypeForReserve;
        }

        private bool GetRoomRate(string para_Room_No)
        {
            bool roomRate = false;
            try
            {
                this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
                if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
                    this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
            }
            catch
            {
                this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
            }
            if (this.db.system_DB.systemDataSet.Room.Rows.Count > 0)
            {
                foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.Room.Rows)
                {
                    if (row.RoomNo == para_Room_No)
                    {
                        this.iDayRate1 = row.DailyRate;
                        this.iWeekRate1 = row.WeeklyRate;
                        this.iMonthRate1 = row.MonthlyRate;
                        this.iDayRate2 = row.DailyRate2;
                        this.iWeekRate2 = row.WeeklyRate2;
                        this.iMonthRate2 = row.MonthlyRate2;
                        this.lblRoomNo.Text = row.RoomNo;
                        roomRate = true;
                        break;
                    }
                }
                if (roomRate && this.sBuildingType == "Normal")
                {
                    if (this._optPeople_1.Checked && (this.StayingPeopleFrame.Enabled || this.StayingPeopleFrame.Visible))
                    {
                        this.iDayRate = this.iDayRate2;
                        this.iWeekRate = this.iWeekRate2;
                        this.iMonthRate = this.iMonthRate2;
                    }
                    else
                    {
                        this.iDayRate = this.iDayRate1;
                        this.iWeekRate = this.iWeekRate1;
                        this.iMonthRate = this.iMonthRate1;
                    }
                }
            }
            else
            {
                int num = (int)MessageBox.Show("No rooms in System Database's Room Table!");
            }
            return roomRate;
        }

        private void chkSecond_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cboChargeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateTime_Auto_InsertingFlag = true;
            this.Reset_Calendar_Limits();
            if (!this.Others_Person_Extended_Flag)
            {
                if (this.ChargeType_Event_Disable)
                    return;
                this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                    this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
                    this.Change_For_OldGuest_Extension();
                else
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U)
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            }
            this.dateTime_Auto_InsertingFlag = false;
        }

        private void dateTimePicker_ValidEnd_ValueChanged(object sender, EventArgs e)
        {

            if (this.dateTime_Auto_InsertingFlag || this._1st_Time_Flag)
                return;
            if (!this.Set_Dates_Check((string)this.cboChargeType.SelectedItem))
            {
                try
                {
                    this.bool_Invalid_Date_Error = true;
                    this.TimeOut_Message_Cnt = 3;
                    this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                    this.lblMessage2.Text = "Can Not Select End Date Earlier Than " + this.dateTimePicker_ValidStart.Value.AddDays(1.0).Date.ToShortDateString() + "!";
                    this.lblMessage2.Refresh();
                    SystemSounds.Exclamation.Play();
                    this.Timer1.Start();
                    this.dateTimePicker_ValidEnd.MinDate = this.dateTimePicker_ValidStart.Value;
                    this.dateTimePicker_ValidEnd.Update();
                    this.dateTimePicker_ValidEnd.Refresh();
                    this.dateTimePicker_ValidEnd.ResumeLayout();
                    this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
                }
                catch
                {
                    this.dateTimePicker_ValidEnd.Value = this.dateTimePicker_ValidStart.Value.AddDays(1.0);
                    this.dateTimePicker_ValidEnd.Refresh();
                    this.bool_Invalid_Date_Error = true;
                    this.TimeOut_Message_Cnt = 3;
                    this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                    this.lblMessage2.Text = "Can Not Select End Date Earlier Than " + this.dateTimePicker_ValidStart.Value.AddDays(1.0).Date.ToShortDateString() + "!";
                    this.lblMessage2.Refresh();
                    SystemSounds.Exclamation.Play();
                    this.Timer1.Start();
                    this.dateTimePicker_ValidEnd.MinDate = this.dateTimePicker_ValidStart.Value;
                    this.dateTimePicker_ValidEnd.Update();
                    this.dateTimePicker_ValidEnd.Refresh();
                    this.dateTimePicker_ValidEnd.ResumeLayout();
                }
            }
            else if (this.dateTimePicker_ValidEnd.Value.Date.ToShortDateString() == this.dateTimePicker_ValidStart.Value.Date.ToShortDateString())
            {
                this.dateTimePicker_ValidEnd.Value = this.Old_Valid_End_Date;
                this.bool_Invalid_Date_Error = true;
                this.TimeOut_Message_Cnt = 3;
                this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                this.lblMessage2.Text = "Can Not Select End Date Earlier Than " + this.dateTimePicker_ValidStart.Value.AddDays(1.0).Date.ToShortDateString() + "!";
                this.lblMessage2.Refresh();
                SystemSounds.Exclamation.Play();
                this.Timer1.Start();
                this.dateTimePicker_ValidEnd.MinDate = this.dateTimePicker_ValidStart.Value;
                this.dateTimePicker_ValidEnd.Update();
                this.dateTimePicker_ValidEnd.Refresh();
                this.dateTimePicker_ValidEnd.ResumeLayout();
            }
            else
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                    this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                else
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 1U || !this._optOldGuest_3.Checked || this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) <= 0)
                return;
            this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
        }

        private void dateTimePicker_ValidEnd_MouseDown(object sender, MouseEventArgs e)
        {
            this.Old_Valid_End_Date = this.dateTimePicker_ValidEnd.Value;
        }

        private void cboRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest <= 0U)
                return;
            this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
            this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
            {
                this._optOldGuest_0.Enabled = false;
                this._optOldGuest_1.Enabled = false;
                this._optOldGuest_3.Enabled = false;
                this.cmdLoss.Enabled = false;
            }
            if (this.txtReceived.Text.Length > 0)
            {
                this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                this.Check_for_cmdIssue_Enable();
            }
            else
                this.txtReceived.Text = "0.00";
        }

        private void Check_for_cmdIssue_Enable()
        {
            cmdIssue.Enabled = true;
            this.Refresh();
            return;


            if (Convert.ToDouble(this.txtToCollect.Text) == 0.0 && this.txtClientID.Text.Length == 8 && this.txtFirstName.Text.Length > 0 && this.txtIdentity.Text.Length > 0 && this.txtAddress.Text.Length > 0 && this.txtSurName.Text.Length > 0 && this.txtNationality.Text.Length > 0 && this.txtContact.Text.Length > 0 && this.txtCardNo.Text.Length > 0)
            {
                this.cmdIssue_Ready_Flag = true;
                this.lblMessage.Text = "Click to Check Card!";
                this.cmdIssue.BackColor = System.Drawing.Color.FromArgb(128, 128, 0);
            }
            else
            {
                this.cmdIssue.Enabled = false;
                this.cmdIssue_Ready_Flag = false;
                this.cmdIssue.BackColor = SystemColors.InactiveCaption;
            }
            this.cmdIssue_Ready_Flag = true;
            this.lblMessage.Text = "Click to Check Card!";
            this.cmdIssue.BackColor = System.Drawing.Color.FromArgb(128, 128, 0);
        }

        private void ClearScreen()
        {
            Mod_UpdateData.bEExtend = false;
            this.bTwoPeople = false;
            this.bSecondClick = false;
            this.txtReservationRef.Text = "";
            this.txtClientID.Text = "";
            this.txtCardNo.Text = "";
            this.txtFirstName.Text = "";
            this.txtSurName.Text = "";
            this.cboSex.SelectedIndex = 0;
            if (this.cboRoomType.Items.Count > 0)
                this.cboRoomType.SelectedIndex = 0;
            this.cboCountry.SelectedIndex = 0;
            this._optOldGuest_0.Checked = true;
            this._optOldGuest_1.Enabled = false;
            this._optOldGuest_2.Enabled = false;
            this._optOldGuest_3.Enabled = false;
            this.lbPrevious.Visible = false;
            this.txtPrevious.Visible = false;
            this.txtPrevious.Text = "0";
            this.txtEarlyStart.Text = "0";
            this.txtDeposit.Text = "0";
            this.txtKeyDeposit.Text = "0";
            this.txtBond.Text = "0";
            this.txtRoomCharge.Text = "0";
            this.txtAmountPaid.Text = "0";
            this.txtToCollect.Text = "0";
            this.txtCurrRoomCharge.Text = "0";
            this.txtExtraKeyCharge.Text = "0";
            this.txtExtraDescription.Text = "";
            this.txtExtra.Text = "0";
            this.txtReceived.Text = "0";
            this.txtDisplayAmount.Text = "0";
            this.sAdvance = "0";
            this.txtAdvance.Text = "0";
            this.txtCheckInDate.Text = DateTime.Now.Date.ToShortDateString();
            try
            {
                this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
            }
            catch
            {
            }
            try
            {
                this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + DateTime.Now.ToShortTimeString());
            }
            catch
            {
            }
            this.lblRoomNo.Text = "";
            this.cboRoomNo.Text = "";
            this.LabelRoom.Visible = false;
            this.lblRoomNo.Visible = false;
            this.lblAvailableRooms.Visible = true;
            this.lbExtraKeyCharge.Visible = false;
            this.txtExtraKeyCharge.Visible = false;
            gCardProperty.LossLog = 0;
            this.cmdLoss.Text = "    Inform    Key Loss";
            this.chkExtendNewCard.Visible = false;
            this.chkExtendNewCard.Checked = false;
            this.checkBox_Replace.Visible = false;
            this.txtIdentity.Text = "";
            this.txtNationality.Text = "";
            this.txtAddress.Text = "";
            this.txtContact.Text = "";
            this.txtIssuedCard.Text = "0";
            this.txtRemark.Text = "";
            this.chkBondDiff.Visible = false;
            this.chkBondDiff.Checked = false;
            this.txtDiffBond.Visible = false;
            this.txtDiffBond.Text = "0";
            this.lblDiffBond.Visible = false;
            this.UnitFrame2.Visible = false;
            this.lblBonus.Visible = false;
            this.txtBonus.Visible = false;
            this.txtBonus.Text = "0";
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void txtSurName_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            this.Check_for_cmdIssue_Enable();
        }

        private void GetCardPropertyValue()
        {
            gCardProperty.CardNo = this.txtCardNo.Text;
            gCardProperty.CardType = "Guest";
            gCardProperty.CheckInDate = DateTime.Parse(this.txtCheckInDate.Text).Date;
            gCardProperty.CheckOutDate = this.dateTimePicker_CheckOutDate.Value.Date;
            if (Global_Data.NewDate_NewCheckIn_FirstPerson_Flag)
            {
                gCardProperty.CheckInTime = DateTime.Parse(this.txtCheckInDate.Text + " " + this.dateTimePicker_CheckInTime.Value.ToShortTimeString());
            }
            else
            {
                try
                {
                    DateTime checkInTime = gCardProperty.CheckInTime;
                }
                catch
                {
                    gCardProperty.CheckInTime = DateTime.Parse(this.txtCheckInDate.Text + " " + this.dateTimePicker_CheckInTime.Value.ToShortTimeString());
                    int num = (int)MessageBox.Show("Check In Time Error For Existing Guest!");
                }
            }
            try
            {
                gCardProperty.CheckOutTime = DateTime.Parse(this.dateTimePicker_CheckOutDate.Value.ToShortDateString() + " " + Global_Data.CheckOut_Time + ":00");
            }
            catch
            {
                gCardProperty.CheckOutTime = DateTime.Parse("1899-12-30 " + DateTime.Now.ToShortTimeString());
            }
            gCardProperty.BuildingNo = (string)this.cboBuildingNo.SelectedItem;
            gCardProperty.FloorNo = this.lblRoomNo.Text.Substring(1, 2);
            gCardProperty.RoomNo = this.lblRoomNo.Text.Substring(3, 2);
            gCardProperty.Account = "000000";
        }

        private bool IssuedCardUpdate()
        {
            bool flag = false;
            this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
            foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.Room.Rows)
            {
                if (row.RoomNo == Mod_UpdateData.sChkRoom)
                {
                    if (Mod_UpdateData.sChkGuest == "N")
                        row.IssuedCard = (short)1;
                    else
                        ++row.IssuedCard;
                    row.TotalStay = Convert.ToByte(gClientProperty.TotalStay);
                    flag = true;
                    break;
                }
            }
            return flag && this.db.system_DB.roomTableAdapter.Update(this.db.system_DB.systemDataSet.Room) > 0;
        }

        private bool RoomStatusNew()
        {
            bool flag = false;
            this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
            for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
            {
                BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
                if (gClientProperty.Condition != "Unit")
                {
                    if (Mod_UpdateData.sChkRoom == row.RoomNo && row.Status < (byte)2)
                    {
                        row.StartDate = DateTime.Parse(gClientProperty.ContractStart);
                        row.EndDate = DateTime.Parse(gClientProperty.ContractEnd);
                        row.Status = (byte)3;
                        row.Description = "Occupied";
                        row.ClientID = gClientProperty.ClientID;
                        row.Condition = gClientProperty.Condition;
                        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                        row.Update = gClientProperty.Update;
                        flag = true;
                        break;
                    }
                }
                else if (Mod_UpdateData.sChkRoom.Substring(1, 2) == row.RoomNo.Substring(1, 2) && Convert.ToInt16(row.Status) < (short)3)
                {
                    row.StartDate = DateTime.Parse(gClientProperty.ContractStart);
                    row.EndDate = DateTime.Parse(gClientProperty.ContractEnd);
                    row.Status = (byte)3;
                    row.Description = "Occupied";
                    row.ClientID = gClientProperty.ClientID;
                    row.Condition = gClientProperty.Condition;
                    row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                    row.Update = gClientProperty.Update;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                int num = (int)MessageBox.Show("RoomStatusNew() failed");
                return false;
            }
            return this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0 && this.db.Update_RoomStausXX_inSystemDB((string)this.cboBuildingNo.SelectedItem);
        }

        private bool IssueNewCard()
        {
            if (gCardProperty.LossLog != 1)
            {
                if (!this.Check_Empty_Card())
                {
                    this.lblMessage.Text = "Incorrect Card Type!";
                    this.lblMessage.Refresh();
                    Console.Beep(700, 300);
                    Thread.Sleep(500);
                    this.lblMessage.Text = "";
                    return false;
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Loss Replacement Card!");
            }
            try
            {
                if (this.Make_Guest_Card(Convert.ToInt32(this.lblRoomNo.Text.Substring(0, 1)), Convert.ToInt32(this.lblRoomNo.Text.Substring(1, 2)), Convert.ToInt32(this.lblRoomNo.Text.Substring(3, 2)), gCardProperty.CheckInTime.TimeOfDay.ToString(), gCardProperty.CheckOutTime.TimeOfDay.ToString()))
                {
                    if (!SmartCard_Procedures.ReadCardNumber((int)Global_Data.COM_NUM))
                        return false;
                    Global_Data.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Write Failed!");
                    return false;
                }
            }
            catch
            {
                int num3 = (int)MessageBox.Show("Write Failed!");
                return false;
            }
            Issue_Card_Class issueCardClass = new Issue_Card_Class();
            issueCardClass.CardNo_Row_Buffer.CardNo = gCardProperty.CardNo;
            issueCardClass.CardNo_Row_Buffer.CardStatus = Convert.ToByte(gClientProperty.ExtraKey);
            issueCardClass.CardNo_Row_Buffer.CardType = gCardProperty.CardType;
            issueCardClass.CardNo_Row_Buffer.ClientID = gClientProperty.ClientID;
            if (gClientProperty.KeyDeposit != "0")
                issueCardClass.CardNo_Row_Buffer.KeyCharge = Convert.ToDecimal(gClientProperty.KeyDeposit);
            else if (gClientProperty.TransType == "NE")
                issueCardClass.CardNo_Row_Buffer.KeyCharge = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giExtraKeyCharge);
            issueCardClass.CardNo_Row_Buffer.RecordDate = DateTime.Parse(gClientProperty.LastRecDate);
            issueCardClass.CardNo_Row_Buffer.RecordTime = DateTime.Now.ToShortTimeString();
            issueCardClass.CardNo_Row_Buffer.RoomNo = gClientProperty.RoomNo;
            issueCardClass.CardNo_Row_Buffer.Update = gClientProperty.Update;
            issueCardClass.CardNo_Row_Buffer.Card_AutoNumber = Global_Data.Card_AutoNumber;
            issueCardClass.CardNo_Row_Buffer.Card_HW_ID = Global_Data.Card_HW_ID;
            issueCardClass.CardNo_Row_Buffer.ReaderID = Global_Data.Card_Reader_ID;
            if (issueCardClass.Write_CardNo_Table())
                return true;
            int num4 = (int)MessageBox.Show("Write Failed!");
            return false;
        }

        private bool ClientAdd()
        {
            if (new Issue_Card_Class()
            {
                Client_Row_Buffer = {
          Address = gClientProperty.Address,
          ClientID = gClientProperty.ClientID,
          ClientType = gClientProperty.ClientType,
          Contact = gClientProperty.Contact,
          Country = gClientProperty.Country,
          ForeName = gClientProperty.ForeName,
          Identity = gClientProperty.Identity,
          Nationality = gClientProperty.Nationality,
          Sex = gClientProperty.Sex,
          SurName = gClientProperty.SurName,
          Email = gClientProperty.Email,
          Update = false
        }
            }.Write_Client_Table())
                return true;
            int num = (int)MessageBox.Show("Write_Client_Table Failed! ClientAdd()");
            return false;
        }

        private bool ClientAccountAdd()
        {
            Issue_Card_Class issueCardClass = new Issue_Card_Class();
            issueCardClass.ClientAcc_Row_Buffer.CardNo = gCardProperty.CardNo;
            issueCardClass.ClientAcc_Row_Buffer.ChargeType = gClientProperty.ChargeType;
            issueCardClass.ClientAcc_Row_Buffer.ClientID = gClientProperty.ClientID;
            issueCardClass.ClientAcc_Row_Buffer.Condition = gClientProperty.Condition;
            issueCardClass.ClientAcc_Row_Buffer.ContractEnd = DateTime.Parse(gClientProperty.ContractEnd);
            issueCardClass.ClientAcc_Row_Buffer.ContractStart = DateTime.Parse(gClientProperty.ContractStart);
            switch (Mod_UpdateData.sChkGuest)
            {
                case "N":
                    issueCardClass.ClientAcc_Row_Buffer.Deposit = Convert.ToDecimal(gClientProperty.DEPOSIT);
                    issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
                    issueCardClass.ClientAcc_Row_Buffer.Bond = Convert.ToInt16(gClientProperty.People) != (short)1 ? 0M : Convert.ToDecimal(gClientProperty.Bond);
                    break;
                case "S":
                    issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = Convert.ToDecimal(gClientProperty.KeyDeposit);
                    issueCardClass.ClientAcc_Row_Buffer.Deposit = 0M;
                    issueCardClass.ClientAcc_Row_Buffer.Bond = 0M;
                    break;
                default:
                    issueCardClass.ClientAcc_Row_Buffer.Deposit = 0M;
                    issueCardClass.ClientAcc_Row_Buffer.KeyDeposit = 0M;
                    issueCardClass.ClientAcc_Row_Buffer.Bond = 0M;
                    break;
            }
            issueCardClass.ClientAcc_Row_Buffer.GracePeriod = Convert.ToInt16(gClientProperty.GracePeriod);
            issueCardClass.ClientAcc_Row_Buffer.NoOfPeople = Convert.ToByte(gClientProperty.People);
            issueCardClass.ClientAcc_Row_Buffer.OldRoom = (string)null;
            issueCardClass.ClientAcc_Row_Buffer.Remark = gClientProperty.Remark;
            issueCardClass.ClientAcc_Row_Buffer.RoomNo = gClientProperty.RoomNo;
            issueCardClass.ClientAcc_Row_Buffer.ValidEnd = DateTime.Parse(gClientProperty.ValidEnd);
            issueCardClass.ClientAcc_Row_Buffer.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
            if (Mod_UpdateData.sChkGuest != "A")
            {
                issueCardClass.ClientAcc_Row_Buffer.AdvancedPayment = Convert.ToDecimal(gClientProperty.Advance);
                issueCardClass.ClientAcc_Row_Buffer.LastPayment = Convert.ToDecimal(gClientProperty.LastPayment);
                issueCardClass.ClientAcc_Row_Buffer.AmountPaid = Convert.ToDecimal(gClientProperty.AmountPaid);
            }
            else
            {
                issueCardClass.ClientAcc_Row_Buffer.AdvancedPayment = 0M;
                issueCardClass.ClientAcc_Row_Buffer.LastPayment = 0M;
                issueCardClass.ClientAcc_Row_Buffer.AmountPaid = 0M;
            }
            if (gClientProperty.BonusClaim != "0")
            {
                if (gClientProperty.BonusDate != "")
                {
                    issueCardClass.ClientAcc_Row_Buffer.BonusDate = gClientProperty.BonusDate;
                    issueCardClass.ClientAcc_Row_Buffer.CheckInDate = !ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready ? gCardProperty.CheckInDate : DateTime.Parse(gClientProperty.BonusDate);
                }
            }
            else
                issueCardClass.ClientAcc_Row_Buffer.CheckInDate = gCardProperty.CheckInDate;
            issueCardClass.ClientAcc_Row_Buffer.CheckOutTime = DateTime.Parse("1899-12-30 " + gClientProperty.CheckOutTime);
            issueCardClass.ClientAcc_Row_Buffer.CheckInTime = DateTime.Parse("1899-12-30 " + gCardProperty.CheckInTime.ToShortTimeString());
            issueCardClass.ClientAcc_Row_Buffer.CheckOutDate = gCardProperty.CheckOutDate;
            issueCardClass.ClientAcc_Row_Buffer.RmPriceAdjust = gClientProperty.RmPrice;
            issueCardClass.ClientAcc_Row_Buffer.Update = gClientProperty.Update;
            issueCardClass.ClientAcc_Row_Buffer.RoomStart = DateTime.Parse(gClientProperty.RoomStart);
            issueCardClass.ClientAcc_Row_Buffer.LastRecDate = DateTime.Parse(gClientProperty.LastRecDate);
            if (Mod_UpdateData.sChkGuest != "A")
            {
                if (gClientProperty.RoomNo != "")
                    issueCardClass.ClientAcc_Row_Buffer.RoomNo = gClientProperty.RoomNo;
            }
            else if (Mod_UpdateData.sChkGuest == "A" && (gCardProperty.CardType == "Emergency" || gCardProperty.CardType == "RoomCard") && gClientProperty.RoomNo != "")
                issueCardClass.ClientAcc_Row_Buffer.RoomNo = gClientProperty.RoomNo;
            if (issueCardClass.Write_ClientAcc_Table())
                return true;
            int num = (int)MessageBox.Show("Write_ClientAcc_Table Failed! ClientAccountAdd()");
            return false;
        }

        private bool UpdateNewData()
        {
            this.sRoomNo = (string)this.cboRoomNo.SelectedItem;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bTracking && !this.IssuedCardUpdate())
                return false;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            return this.RoomStatusNew() && this.ClientAdd() && this.ClientAccountAdd() && this.db.TransactionAdd();
        }

        private bool ExtraCharge()
        {
            bool flag = false;
            this.db.building_DB1.extraChargeTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ExtraCharge);
            for (int index = 0; index <= 4; ++index)
            {
                Decimal num;
                try
                {
                    num = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index]);
                }
                catch
                {
                    num = 0M;
                }
                if (num != 0M)
                {
                    BuildingDB1DataSet.ExtraChargeRow row = this.db.building_DB1.buildingDB1DataSet.ExtraCharge.NewExtraChargeRow();
                    row.ReceiptID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
                    row.ClientID = gClientProperty.ClientID;
                    row.ExDescription = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index];
                    row.ExtraCharge = Convert.ToDecimal(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index]);
                    this.db.building_DB1.buildingDB1DataSet.ExtraCharge.AddExtraChargeRow(row);
                    flag = true;
                }
            }
            return !flag || this.db.building_DB1.extraChargeTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ExtraCharge) > 0;
        }

        private bool UnitRef()
        {
            bool flag = false;
            this.db.building_DB1.unitRefTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.UnitRef);
            if (Mod_UpdateData.sChkGuest == "N")
            {
                BuildingDB1DataSet.UnitRefRow row = this.db.building_DB1.buildingDB1DataSet.UnitRef.NewUnitRefRow();
                row.ClientID = gClientProperty.ClientID;
                row.CardNo = gClientProperty.CardNo;
                row.RoomNo = gClientProperty.RoomNo;
                row.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
                row.ValidEnd = DateTime.Parse(gClientProperty.CheckOutDate);
                this.db.building_DB1.buildingDB1DataSet.UnitRef.AddUnitRefRow(row);
            }
            else
            {
                switch (gClientProperty.TransType)
                {
                    case "I":
                    case "IA":
                    case "IU":
                    case "IL":
                    case "AL":
                    case "TL":
                    case "TA":
                    case "NE":
                        BuildingDB1DataSet.UnitRefRow row1 = this.db.building_DB1.buildingDB1DataSet.UnitRef.NewUnitRefRow();
                        row1.ClientID = gClientProperty.ClientID;
                        row1.CardNo = gClientProperty.CardNo;
                        row1.RoomNo = gClientProperty.RoomNo;
                        row1.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
                        row1.ValidEnd = DateTime.Parse(gClientProperty.CheckOutDate);
                        this.db.building_DB1.buildingDB1DataSet.UnitRef.AddUnitRefRow(row1);
                        flag = true;
                        break;
                    case "T":
                    case "AT":
                    case "E":
                    case "EL":
                    case "AE":
                    case "EA":
                        IEnumerator enumerator = this.db.building_DB1.buildingDB1DataSet.UnitRef.Rows.GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                BuildingDB1DataSet.UnitRefRow current = (BuildingDB1DataSet.UnitRefRow)enumerator.Current;
                                if (gClientProperty.ClientID == current.ClientID && gClientProperty.CardNo == current.CardNo)
                                {
                                    current.CardNo = gClientProperty.CardNo;
                                    current.RoomNo = gClientProperty.RoomNo;
                                    current.ValidStart = DateTime.Parse(gClientProperty.ValidStart);
                                    current.ValidEnd = DateTime.Parse(gClientProperty.CheckOutDate);
                                    flag = true;
                                    break;
                                }
                            }
                            break;
                        }
                        finally
                        {
                            if (enumerator is IDisposable disposable)
                                disposable.Dispose();
                        }
                    case "RE":
                    case "CC":
                    case "CN":
                        for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.UnitRef.Rows.Count; ++index)
                        {
                            BuildingDB1DataSet.UnitRefRow row2 = (BuildingDB1DataSet.UnitRefRow)this.db.building_DB1.buildingDB1DataSet.UnitRef.Rows[index];
                            if (gClientProperty.ClientID == row2.ClientID && gClientProperty.CardNo == row2.CardNo && gClientProperty.RoomNo == row2.RoomNo)
                            {
                                if (this.db.building_DB1.unitRefTableAdapter.Delete(row2.ClientID) == 0)
                                {
                                    int num = (int)MessageBox.Show("Delete failed in UnitRef()");
                                    return false;
                                }
                                this.db.building_DB1.unitRefTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.UnitRef);
                                flag = true;
                                break;
                            }
                        }
                        break;
                }
                if (flag && this.db.building_DB1.unitRefTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet) <= 0)
                {
                    int num = (int)MessageBox.Show("UnitRef() failed!");
                    return false;
                }
            }
            return true;
        }

        private void gGetClientPropertyOld()
        {
            gClientProperty.ClientID = this.txtClientID.Text;
            gClientProperty.ClientType = "G";
            gClientProperty.ForeName = this.txtFirstName.Text;
            gClientProperty.SurName = this.txtSurName.Text;
            gClientProperty.Sex = (string)this.cboSex.SelectedItem;
            gClientProperty.Identity = this.txtIdentity.Text;
            gClientProperty.Nationality = this.txtNationality.Text;
            gClientProperty.Address = this.txtAddress.Text;
            gClientProperty.Contact = this.txtContact.Text;
            gClientProperty.Country = (string)this.cboCountry.SelectedItem;
            gClientProperty.RoomNo = this.lblRoomNo.Text;
            gClientProperty.Email = this.textBox_Email.Text;
            gClientProperty.Bond = this.txtBond.Text;
            gClientProperty.ExtraCharge = this.txtExtra.Text;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U)
            {
                gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
                gClientProperty.TransType = "I";
                gClientProperty.RoomStart = DateTime.Now.ToShortDateString();
            }
            else
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 1U)
                    return;
                if (this.bCardExtra)
                {
                    if (this._optOldGuest_3.Checked)
                    {
                        if (gCardProperty.LossLog == 0)
                        {
                            gClientProperty.TransType = "AE";
                        }
                        else
                        {
                            gClientProperty.TransType = !Mod_UpdateData.bExtraLoss ? "EL" : "EA";
                            gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                        }
                    }
                    else if (this._optOldGuest_0.Checked)
                    {
                        gClientProperty.TransType = !Mod_UpdateData.bExtraLoss ? "IL" : "AL";
                        gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                    }
                    else if (this._optOldGuest_1.Checked)
                    {
                        gClientProperty.TransType = "IA";
                        gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                    }
                }
                else if (this._optOldGuest_3.Checked)
                {
                    if (gCardProperty.LossLog == 0 && !this.chkExtendNewCard.Checked)
                        gClientProperty.TransType = "E";
                    else if (this.chkExtendNewCard.Checked)
                    {
                        gClientProperty.TransType = "NE";
                        gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
                        gClientProperty.CardNo = this.txtCardNo.Text;
                    }
                    else if (gCardProperty.LossLog == 1)
                    {
                        gClientProperty.TransType = !Mod_UpdateData.bExtraLoss ? "EL" : "EA";
                        gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                    }
                }
                else if (this._optOldGuest_1.Checked)
                {
                    gClientProperty.TransType = "IA";
                    gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                }
                else if (this._optOldGuest_0.Checked)
                {
                    if (gCardProperty.LossLog == 0)
                    {
                        if (this.sBuildingType != "Apartment")
                        {
                            if (Mod_UpdateData.sChkGuest == "S" && this.bSecond && this.chkSecond.Checked)
                            {
                                gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
                                gClientProperty.TransType = "IS";
                                gClientProperty.RoomStart = DateTime.Now.ToShortDateString();
                            }
                            else
                                gClientProperty.TransType = "I";
                        }
                        else if (Mod_UpdateData.sChkGuest == "U")
                        {
                            gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
                            gClientProperty.TransType = "IU";
                            gClientProperty.RoomStart = DateTime.Now.ToShortDateString();
                        }
                        else
                        {
                            gClientProperty.TransType = "I";
                            gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
                        }
                    }
                    else
                    {
                        gClientProperty.TransType = !Mod_UpdateData.bExtraLoss ? "IL" : "AL";
                        gClientProperty.KeyDeposit = this.txtExtraKeyCharge.Text;
                    }
                }
                gClientProperty.RoomStart = Mod_UpdateData.sOldRoomStart;
                if (this.iBonusTotal > 0)
                {
                    gClientProperty.BonusDate = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
                    gClientProperty.BonusClaim = (-this.iBonusTotal).ToString("F2");
                    if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBonus)
                    {
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = true;
                        gClientProperty.CheckInDate = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
                    }
                }
                gClientProperty.CardNo = !(this.sBuildingType == "Normal") ? (gClientProperty.TransType == "AE" || gClientProperty.TransType == "EA" || gClientProperty.TransType == "AT" ? this.sOldCardNo : this.txtCardNo.Text) : (gClientProperty.TransType == "IA" || gClientProperty.TransType == "AE" || gClientProperty.TransType == "AL" || gClientProperty.TransType == "EA" || gClientProperty.TransType == "TA" || gClientProperty.TransType == "AT" ? this.sOldCardNo : this.txtCardNo.Text);
                gClientProperty.ContractStart = !(Mod_UpdateData.sOldContractStart != this.dateTimePicker_ContractStart.Value.ToShortDateString()) ? Mod_UpdateData.sOldContractStart : this.dateTimePicker_ContractStart.Value.ToShortDateString();
                gClientProperty.ContractEnd = this.dateTimePicker_ContractEnd.Value.ToShortDateString();
                gClientProperty.RmPrice = false;
                if (((string)this.cboRoomType.SelectedItem).ToUpper().Contains("STUDIO") || ((string)this.cboRoomType.SelectedItem).ToUpper().Contains("TWIN"))
                {
                    if (this._optPeople_0.Checked)
                    {
                        gClientProperty.TotalStay = "1";
                        gClientProperty.People = "1";
                    }
                    else if (this.chkSecond.Checked)
                    {
                        gClientProperty.TotalStay = "2";
                        gClientProperty.People = "2";
                    }
                    else
                    {
                        gClientProperty.TotalStay = "2";
                        gClientProperty.People = "1";
                    }
                }
                else
                {
                    gClientProperty.TotalStay = "1";
                    gClientProperty.People = "1";
                }
                gClientProperty.Condition = "Individual";
                gClientProperty.ChargeType = this.cboChargeType.Text.Substring(0, 1);
                gClientProperty.GracePeriod = this.txtGracePeriod.Text;
                gClientProperty.ValidStart = this.dateTimePicker_ValidStart.Value.ToShortDateString();
                gClientProperty.ValidEnd = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
                gClientProperty.Advance = this.txtAdvance.Text;
                gClientProperty.CurAdvance = this.sCurAdvance;
                gClientProperty.PrevAdvance = this.sAdvance;
                gClientProperty.LastPayment = this.txtReceived.Text;
                gClientProperty.ExDesp = this.txtExtraDescription.Text;
                gClientProperty.ExtraCharge = this.txtExtra.Text;
                if (this.sBuildingType != "Apartment")
                {
                    if (!this.chkSecond.Checked)
                    {
                        gClientProperty.AmountPaid = this.sTotalPaid;
                        gClientProperty.RoomCharge = this.txtCurrRoomCharge.Text;
                        gClientProperty.DEPOSIT = this.txtDeposit.Text;
                    }
                    else if (this.chkSecond.Checked)
                    {
                        gClientProperty.AmountPaid = (Convert.ToDecimal(this.txtAmountPaid.Text) + Convert.ToDecimal(this.txtKeyDeposit.Text) + Convert.ToDecimal(this.txtExtraKeyCharge.Text) + Convert.ToDecimal(this.txtExtra.Text)).ToString("F2");
                        gClientProperty.RoomCharge = "0.00";
                        gClientProperty.DEPOSIT = "0.00";
                    }
                }
                else if ((this._optUnit_1.Checked = true) && (this.bOtherUnitKey = true))
                {
                    gClientProperty.AmountPaid = (Convert.ToDecimal(this.txtAmountPaid.Text) + Convert.ToDecimal(this.txtKeyDeposit.Text) + Convert.ToDecimal(this.txtExtraKeyCharge.Text) + Convert.ToDecimal(this.txtExtra.Text)).ToString("F2");
                    gClientProperty.RoomCharge = "0.00";
                    gClientProperty.DEPOSIT = "0.00";
                }
                else if ((this._optUnit_0.Checked = true) && (this.bOtherUnitKey = false) || (this._optUnit_1.Checked = true) && (this.bOtherUnitKey = false))
                {
                    gClientProperty.AmountPaid = this.sTotalPaid;
                    gClientProperty.RoomCharge = this.txtCurrRoomCharge.Text;
                    gClientProperty.DEPOSIT = this.txtDeposit.Text;
                }
                gClientProperty.CheckOutDate = this.dateTimePicker_CheckOutDate.Value.ToShortDateString();
                gClientProperty.CheckOutTime = gCardProperty.CheckOutTime.ToShortTimeString();
                gClientProperty.LastRecDate = DateTime.Now.ToShortDateString();
                gClientProperty.Remark = this.txtRemark.Text;
                double num1 = Convert.ToDouble(gClientProperty.RoomCharge) + Convert.ToDouble(gClientProperty.ExtraCharge);
                gClientProperty.TransGST = num1.ToString();
                if (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) != 0.0)
                {
                    double num2 = Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) + Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gConstantGST);
                    this.sNewGSTRate = num2.ToString();
                    gClientProperty.TransGST = (num1 * (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) / num2)).ToString();
                }
                else
                    gClientProperty.TransGST = "0";
                gClientProperty.Update = false;
            }
        }

        private bool RoomStatusOldUpdate(string para_RoomNo)
        {
            bool flag = false;
            this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
            foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
            {
                if (row.RoomNo == para_RoomNo && row.Status == (byte)3 && row.ClientID == Mod_UpdateData.sChkClient)
                {
                    if (Mod_UpdateData.sOldContractStart != gClientProperty.ContractStart)
                        row.StartDate = DateTime.Parse(gClientProperty.ContractStart).Date;
                    if (Mod_UpdateData.sOldContractEnd != gClientProperty.ContractEnd)
                        row.EndDate = DateTime.Parse(gClientProperty.ContractEnd).Date;
                    row.Condition = gClientProperty.Condition;
                    row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                    row.Update = gClientProperty.Update;
                    if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
                    {
                        flag = this.db.Update_RoomStausXX_inSystemDB((string)this.cboBuildingNo.SelectedItem);
                        break;
                    }
                    int num = (int)MessageBox.Show("RoomStatusOldUpdate Failed!");
                    return false;
                }
            }
            return flag;
        }

        private bool UpdateOldData()
        {
            if (!Mod_UpdateData.bEExtend && !Mod_UpdateData.bExtraLoss && gCardProperty.LossLog == 0 && Mod_UpdateData.sOldRoom == this.lblRoomNo.Text)
            {
                this.sRoomNo = this.lblRoomNo.Text;
                Mod_UpdateData.sChkRoom = this.sRoomNo;
                Mod_UpdateData.sChkClient = this.txtClientID.Text;
                if (!this.RoomStatusOldUpdate(this.lblRoomNo.Text))
                {
                    int num = (int)MessageBox.Show("RoomStatusOldUpdate() Failed!");
                    return false;
                }
            }
            if (gClientProperty.TransType == "NE")
            {
                this.sRoomNo = this.lblRoomNo.Text;
                Mod_UpdateData.sChkRoom = this.sRoomNo;
                if (!this.IssuedCardUpdate())
                {
                    int num = (int)MessageBox.Show("IssuedCardUpdate() Failed!");
                    return false;
                }
            }
            if (!Mod_UpdateData.bEExtend && !Mod_UpdateData.bExtraLoss && !this.db.ClientEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientEdit() Failed!");
                return false;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U && this._optOldGuest_3.Checked)
                gClientProperty.Bond = this.bNoCharge ? "0.00" : (Convert.ToDecimal(this.txtDiffBond.Text) + Convert.ToDecimal(this.txtBond.Text)).ToString("F2");
            if (!this.db.ClientAccountEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientAccountEdit() Failed!");
                return false;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U && this._optOldGuest_3.Checked)
                gClientProperty.Bond = this.bNoCharge ? "0.00" : (!(Convert.ToDecimal(this.txtDiffBond.Text) != 0M) ? "0.00" : this.txtDiffBond.Text);
            if (this.db.TransactionAdd())
                return true;
            int num1 = (int)MessageBox.Show("TransactionAdd() Failed!");
            return false;
        }

        private bool Update_Replacement()
        {
            try
            {
                this.db.replacement_DB1.replacementTableAdapter.Fill(this.db.replacement_DB1.replacementDB1DataSet.Replacement);
                ReplacementDB1DataSet.ReplacementRow row = this.db.replacement_DB1.replacementDB1DataSet.Replacement.NewReplacementRow();
                row.ReceiptID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
                row.ClientID = gClientProperty.ClientID;
                row.CardNo = gCardProperty.CardNo;
                row.RoomNo = gClientProperty.RoomNo;
                row.TransType = gClientProperty.TransType;
                row.TransactionDate = DateTime.Now.Date;
                row.TransactionTime = DateTime.Now.ToShortTimeString();
                this.db.replacement_DB1.replacementDB1DataSet.Replacement.AddReplacementRow(row);
                return this.db.replacement_DB1.replacementTableAdapter.Update(this.db.replacement_DB1.replacementDB1DataSet.Replacement) > 0;
            }
            catch
            {
                return false;
            }
        }

        private bool UpdateExtraKey()
        {
            this.sRoomNo = this.lblRoomNo.Text;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!this.IssuedCardUpdate())
            {
                int num = (int)MessageBox.Show("IssuedCardUpdate() Failed!");
                return false;
            }
            if (!this.db.ClientAccountEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientAccountEdit() Failed!");
                return false;
            }
            if (this.db.TransactionAdd())
                return true;
            int num1 = (int)MessageBox.Show("TransactionAdd() Failed!");
            return false;
        }

        private bool IssueSecondKey()
        {
            this.sRoomNo = this.lblRoomNo.Text;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!this.IssuedCardUpdate())
            {
                int num = (int)MessageBox.Show("IssuedCardUpdate() Failed!");
                return false;
            }
            if (!this.ClientAdd())
            {
                int num = (int)MessageBox.Show("ClientAdd() Failed!");
                return false;
            }
            if (!this.ClientAccountAdd())
            {
                int num = (int)MessageBox.Show("ClientAccountAdd() Failed!");
                return false;
            }
            if (this.db.TransactionAdd())
                return true;
            int num1 = (int)MessageBox.Show("TransactionAdd() Failed!");
            return false;
        }

        private bool UpdateOldClient()
        {
            gClientProperty.People = !this.chkSecond.Checked ? "1" : "2";
            this.sRoomNo = this.cboRoomNo.Text;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!this.IssuedCardUpdate())
            {
                int num = (int)MessageBox.Show("IssuedCardUpdate() Failed!");
                return false;
            }
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!this.RoomStatusNew())
            {
                int num = (int)MessageBox.Show("RoomStatusNew() Failed!");
                return false;
            }
            if (!this.db.ClientEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientEdit() Failed!");
                return false;
            }
            if (!this.db.ClientAccountEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientAccountEdit() Failed!");
                return false;
            }
            if (this.db.TransactionAdd())
                return true;
            int num1 = (int)MessageBox.Show("TransactionAdd() Failed!");
            return false;
        }

        private bool UpdateOldUnitData()
        {
            int num = (int)MessageBox.Show("Sorry! Not Implemented for UpdateOldUnitData() currently!");
            return false;
        }

        private bool RoomStatusUpdate_ToVacant(string para_RoomNo)
        {
            int num1 = 0;
            bool flag1 = false;
            this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
            for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
            {
                if (((BuildingDB1DataSet.RoomStatusRow)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index]).RoomNo == para_RoomNo)
                    ++num1;
            }
            int count = this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count;
            if (num1 > 1)
            {
                for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
                {
                    BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
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
                    int num2 = (int)MessageBox.Show("Cannot delete duplicate RoomStatus row!");
                    return false;
                }
            }
            bool flag3 = false;
            for (int index = 0; index < this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count; ++index)
            {
                BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow)this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows[index];
                bool flag4;
                try
                {
                    flag4 = row.ClientID == null;
                }
                catch
                {
                    flag4 = true;
                }
                flag3 = false;
                if (!flag4 && row.ClientID == Mod_UpdateData.sChkClient)
                {
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gsReserveType == "Unit")
                    {
                        if (para_RoomNo.Substring(1, 2) == row.RoomNo.Substring(1, 2))
                        {
                            row.Status = (byte)0;
                            row.Description = "Vacant";
                            row.StartDate = DateTime.Now.Date;
                            row.EndDate = DateTime.Now.Date;
                            row.ClientID = "";
                            row.Condition = "";
                            row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                            row.Update = false;
                            if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
                            {
                                if (!this.db.Update_RoomStausXX_inSystemDB((string)this.cboBuildingNo.SelectedItem))
                                {
                                    flag3 = false;
                                    break;
                                }
                                flag3 = true;
                            }
                            else
                            {
                                flag3 = false;
                                break;
                            }
                        }
                    }
                    else if (para_RoomNo == row.RoomNo)
                    {
                        row.Status = (byte)0;
                        row.Description = "Vacant";
                        row.StartDate = DateTime.Now.Date;
                        row.EndDate = DateTime.Now.Date;
                        row.ClientID = "";
                        row.Condition = "";
                        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
                        row.Update = false;
                        flag3 = this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0 && this.db.Update_RoomStausXX_inSystemDB((string)this.cboBuildingNo.SelectedItem);
                        break;
                    }
                }
            }
            if (flag3)
                return true;
            int num3 = (int)MessageBox.Show("Cannot Update RoomStatus row!");
            return false;
        }

        private bool UpdateReserveData()
        {
            this.sRoomNo = this.lblRoomNo.Text;
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            if (!this.IssuedCardUpdate())
            {
                int num = (int)MessageBox.Show("IssuedCardUpdate() Failed!");
                return false;
            }
            if (this.Old_Reserved_RoomNo != (string)this.cboRoomNo.SelectedItem)
            {
                Mod_UpdateData.sChkClient = gClientProperty.ClientID;
                Mod_UpdateData.sChkRoom = this.Old_Reserved_RoomNo;
                Mod_UpdateData.iChkStatus = 2;
                if (!this.RoomStatusUpdate_ToVacant(this.Old_Reserved_RoomNo))
                {
                    int num = (int)MessageBox.Show("RoomStatusUpdate_ToVacant() Failed!");
                    return false;
                }
            }
            Mod_UpdateData.sChkRoom = this.sRoomNo;
            Mod_UpdateData.sChkClient = gClientProperty.ClientID;
            if (!this.RoomStatusNew())
            {
                int num = (int)MessageBox.Show("RoomStatusNew() Failed!");
                return false;
            }
            Mod_UpdateData.sChkClient = this.txtClientID.Text;
            if (!this.db.ClientEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientEdit() Failed!");
                return false;
            }
            Mod_UpdateData.sChkRoom = gClientProperty.RoomNo;
            Mod_UpdateData.sChkGuest = "N";
            gClientProperty.DEPOSIT = "0.00";
            if (!this.db.ClientAccountEdit(this.txtClientID.Text))
            {
                int num = (int)MessageBox.Show("ClientAccountEdit() Failed!");
                return false;
            }
            bool flag = false;
            this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
            foreach (BuildingDB1DataSet.ReserveRow reserveRow in this.db.building_DB1.buildingDB1DataSet.Reserve)
            {
                if (reserveRow.ReserveRef == this.txtReservationRef.Text && reserveRow.RoomNo == this.lblRoomNo.Text)
                {
                    if (this.db.building_DB1.reserveTableAdapter.Delete(this.txtReservationRef.Text) > 0)
                    {
                        flag = true;
                        this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
                        break;
                    }
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                int num = (int)MessageBox.Show("Reserved Record Delete Failed!");
                return false;
            }
            gClientProperty.DEPOSIT = this.txtDeposit.Text;
            if (this.db.TransactionAdd())
                return true;
            int num1 = (int)MessageBox.Show("TransactionAdd() Failed!");
            return false;
        }

        private bool UpdateData()
        {
            Mod_UpdateData.sChkExtraCharge = this.txtExtra.Text;
            Mod_UpdateData.sChkKeyCharge = this.txtExtraKeyCharge.Text;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U)
            {
                Mod_UpdateData.sChkGuest = "N";
                this.gGetClientPropertyNew();
            }
            else
            {
                Mod_UpdateData.sChkGuest = !(this.sBuildingType != "Apartment") ? (!this.bOtherUnitKey ? "O" : "U") : (!this.bSecond ? "O" : "S");
                this.gGetClientPropertyOld();
                if (gCardProperty.LossLog == 1)
                {
                    Mod_UpdateData.sChkCardNo = !Mod_UpdateData.bExtraLoss ? this.sOldCardNo : Mod_UpdateData.sLossCard;
                    if (!this.Check_Empty_Card())
                    {
                        int num = (int)MessageBox.Show("Not Empty Card!");
                        return false;
                    }
                    if (!this.db.CardDataUpdate(Mod_UpdateData.sChkCardNo, gClientProperty.Card_AutoNumber, gClientProperty.Card_HW_ID))
                    {
                        int num = (int)MessageBox.Show("CardDataUpdate Failed!");
                        return false;
                    }
                }
            }
            if (gCardProperty.LossLog == 1 || this._optOldGuest_1.Checked || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U || this.bSecond && this.chkSecond.Checked)
            {
                gClientProperty.ExtraKey = !this._optOldGuest_1.Checked ? (Mod_UpdateData.bExtraLoss ? "1" : "0") : "1";
                if (!this.IssueNewCard())
                {
                    int num = (int)MessageBox.Show("Issue Failed!");
                    return false;
                }
            }
            else if (this._optOldGuest_3.Checked && this.chkExtendNewCard.Checked)
            {
                gClientProperty.ExtraKey = "0";
                if (!this.IssueNewCard())
                {
                    int num = (int)MessageBox.Show("Issue Failed!");
                    return false;
                }
            }
            else if (this._optOldGuest_0.Checked && this.sBuildingType == "Apartment" && this._optUnit_1.Checked && this.bOtherUnitKey)
            {
                gClientProperty.ExtraKey = "0";
                if (!this.IssueNewCard())
                {
                    int num = (int)MessageBox.Show("IssueNewCard Failed!");
                    return false;
                }
            }
            else
            {
                if (Global_Data.Card_HW_ID != gClientProperty.Card_HW_ID)
                {
                    this.lblMessage.Text = "Not Correct Card to Update!";
                    this.lblMessage.Refresh();
                    Console.Beep(700, 300);
                    Thread.Sleep(500);
                    this.lblMessage.Text = "";
                    return false;
                }
                if (!this.Make_Guest_Card(Convert.ToInt32(this.lblRoomNo.Text.Substring(0, 1)), Convert.ToInt32(this.lblRoomNo.Text.Substring(1, 2)), Convert.ToInt32(this.lblRoomNo.Text.Substring(3, 2)), gCardProperty.CheckInTime.TimeOfDay.ToString(), gCardProperty.CheckOutTime.TimeOfDay.ToString()))
                {
                    int num = (int)MessageBox.Show("Issue Failed!");
                    return false;
                }
                if (!SmartCard_Procedures.ReadCardNumber((int)Global_Data.COM_NUM))
                    return false;
                this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
                {
                    if (row.CardNo == gCardProperty.CardNo && row.Card_HW_ID == Global_Data.Card_HW_ID && row.Card_AutoNumber == Global_Data.Card_AutoNumber)
                    {
                        row.RecordDate = DateTime.Parse(gClientProperty.LastRecDate);
                        row.RecordTime = DateTime.Now.ToShortTimeString();
                        row.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
                        if (this.db.building_DB1.cardNoTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.CardNo) <= 0)
                        {
                            int num = (int)MessageBox.Show("Card AutoNumber Update Failed!");
                            return false;
                        }
                    }
                }
            }
            switch (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest)
            {
                case 1:
                    if (this._optOldGuest_3.Checked || this._optOldGuest_0.Checked && gCardProperty.LossLog == 1)
                    {
                        if (!this.UpdateOldData())
                        {
                            int num = (int)MessageBox.Show("UpdateOldData Failed!");
                            return false;
                        }
                    }
                    else if (this._optOldGuest_1.Checked)
                    {
                        if (!this.UpdateExtraKey())
                        {
                            int num = (int)MessageBox.Show("UpdateExtraKey Failed!");
                            return false;
                        }
                    }
                    else if (this.bSecond && this.chkSecond.Checked)
                    {
                        if (!this.IssueSecondKey())
                        {
                            int num = (int)MessageBox.Show("IssueSecondKey Failed!");
                            return false;
                        }
                    }
                    else if (this._optOldGuest_0.Checked && this.bNewExisting)
                    {
                        if (!this.UpdateOldClient())
                        {
                            int num = (int)MessageBox.Show("UpdateOldClient Failed!");
                            return false;
                        }
                    }
                    else if (this._optOldGuest_0.Checked && this.sBuildingType == "Apartment" && this._optUnit_1.Checked && this.bOtherUnitKey)
                    {
                        if (!this.UpdateOldUnitData())
                        {
                            int num = (int)MessageBox.Show("UpdateOldUnitData Failed!");
                            return false;
                        }
                    }
                    else
                    {
                        int num1 = (int)MessageBox.Show("Other Case for Old Card!");
                    }
                    if (this.checkBox_Replace.Visible)
                    {
                        if (this.checkBox_Replace.Checked)
                        {
                            if (!this.Update_Replacement())
                            {
                                int num2 = (int)MessageBox.Show("Update_Replacement Failed!");
                                return false;
                            }
                            break;
                        }
                        break;
                    }
                    break;
                case 2:
                    if (!this.UpdateReserveData())
                    {
                        int num3 = (int)MessageBox.Show("UpdateReserveData Failed!");
                        return false;
                    }
                    break;
                case 3:
                    if (!this.UpdateNewData())
                    {
                        int num4 = (int)MessageBox.Show("UpdateNewData Failed!");
                        return false;
                    }
                    break;
            }
            try
            {
                if (Convert.ToDecimal(Mod_UpdateData.sChkExtraCharge) != 0M)
                {
                    if (!this.ExtraCharge())
                    {
                        int num5 = (int)MessageBox.Show("ExtraCharge Failed!");
                        return false;
                    }
                }
            }
            catch
            {
            }
            if (this.sBuildingType == "Apartment" && this._optUnit_1.Checked && !this.UnitRef())
            {
                int num6 = (int)MessageBox.Show("bUpdate Failed!");
                return false;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U)
                gClientProperty.DEPOSIT = Mod_UpdateData.sReservedDeposit;
            if (this.db.LastTransAdd())
                return true;
            int num7 = (int)MessageBox.Show("LastTransAdd Failed!");
            return false;
        }

        private void gGetClientPropertyNew()
        {
            gClientProperty.ClientID = this.txtClientID.Text;
            gClientProperty.Sex = this.cboSex.Text;
            gClientProperty.ClientType = this.sClientType;
            gClientProperty.ForeName = this.txtFirstName.Text;
            gClientProperty.SurName = this.txtSurName.Text;
            gClientProperty.Contact = this.txtContact.Text;
            gClientProperty.Address = this.txtAddress.Text;
            gClientProperty.Country = this.cboCountry.Text;
            gClientProperty.Identity = this.txtIdentity.Text;
            gClientProperty.Nationality = this.txtNationality.Text;
            gClientProperty.Email = this.textBox_Email.Text;
            gClientProperty.CardNo = this.txtCardNo.Text;
            gClientProperty.TransType = "I";
            gClientProperty.ExtraKey = "0";
            gClientProperty.KeyDeposit = this.txtKeyDeposit.Text;
            gClientProperty.RoomNo = this.lblRoomNo.Text;
            gClientProperty.DEPOSIT = "0";
            gClientProperty.Bond = this.txtBond.Text;
            gClientProperty.ContractStart = this.dateTimePicker_ContractStart.Value.Date.ToShortDateString();
            gClientProperty.ContractEnd = this.dateTimePicker_ContractEnd.Value.Date.ToShortDateString();
            gClientProperty.ChargeType = ((string)this.cboChargeType.SelectedItem).Substring(0, 1);
            gClientProperty.GracePeriod = this.txtGracePeriod.Text;
            gClientProperty.ValidStart = this.dateTimePicker_ValidStart.Value.Date.ToShortDateString();
            gClientProperty.ValidEnd = this.dateTimePicker_ValidEnd.Value.Date.ToShortDateString();
            gClientProperty.Advance = this.txtAdvance.Text;
            gClientProperty.CurAdvance = this.sCurAdvance;
            gClientProperty.PrevAdvance = "0";
            gClientProperty.LastPayment = this.txtReceived.Text;
            gClientProperty.AmountPaid = this.sTotalPaid;
            gClientProperty.ExDesp = this.txtExtraDescription.Text;
            gClientProperty.ExtraCharge = this.txtExtra.Text;
            gClientProperty.RoomCharge = this.txtCurrRoomCharge.Text;
            gClientProperty.DEPOSIT = this.txtDeposit.Text;
            gClientProperty.CheckOutDate = this.dateTimePicker_CheckOutDate.Value.Date.ToShortDateString();
            gClientProperty.CheckOutTime = gCardProperty.CheckOutTime.ToShortTimeString();
            gClientProperty.CheckInDate = DateTime.Now.Date.ToShortDateString();
            gClientProperty.CheckInTime = gCardProperty.CheckInTime.ToShortTimeString();
            gClientProperty.LastRecDate = DateTime.Now.Date.ToShortDateString();
            gClientProperty.RoomStart = DateTime.Now.Date.ToShortDateString();
            if (this.cboRoomType.Text.ToUpper().Contains("STUDIO") || this.cboRoomType.Text.ToUpper().Contains("TWIN"))
            {
                if (this._optPeople_0.Checked)
                {
                    gClientProperty.TotalStay = "1";
                    gClientProperty.People = "1";
                }
                else if (this.chkSecond.Checked)
                {
                    gClientProperty.TotalStay = "2";
                    gClientProperty.People = "2";
                }
                else
                {
                    gClientProperty.TotalStay = "2";
                    gClientProperty.People = "1";
                }
            }
            else
            {
                gClientProperty.TotalStay = "1";
                gClientProperty.People = "1";
            }
            gClientProperty.Condition = "Individual";
            gClientProperty.Remark = this.txtRemark.Text;
            double num1 = Convert.ToDouble(gClientProperty.RoomCharge) + Convert.ToDouble(gClientProperty.ExtraCharge);
            gClientProperty.TransGST = num1.ToString();
            if (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) != 0.0)
            {
                double num2 = Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) + Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gConstantGST);
                this.sNewGSTRate = num2.ToString();
                gClientProperty.TransGST = (num1 * (Convert.ToDouble(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gGSTPercent) / num2)).ToString();
            }
            else
                gClientProperty.TransGST = "0";
            if (this.iBonusTotal > 0)
            {
                gClientProperty.BonusDate = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
                gClientProperty.BonusClaim = string.Format("{0:F1}", (object)-this.iBonusTotal);
                if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBonus)
                {
                    ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = true;
                    gClientProperty.CheckInDate = this.dateTimePicker_ValidEnd.Value.ToShortDateString();
                }
            }
            gClientProperty.RmPrice = false;
            gClientProperty.Update = false;
        }

        private bool IssueCardRoutine()
        {
            int newTransId = this.db.GetNew_TransID((string)this.cboBuildingNo.SelectedItem);
            if (newTransId == -1)
            {
                int num = (int)MessageBox.Show("Can't Get TransID!");
                return false;
            }
            bool flag = this.db.Backup_Before_Transact((string)this.cboBuildingNo.SelectedItem);
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bTracking = false;
            if (this.UpdateData())
            {
                this.cmdIssue.Enabled = false;
                this.cmdIssue_Ready_Flag = false;
                this.cmdPrint.Enabled = true;
                this.cmdReturn.Enabled = true;
                return true;
            }
            if (flag)
                this.db.Restore_For_FailedTransact((string)this.cboBuildingNo.SelectedItem);
            return false;
        }

        private bool Check_Empty_Card()
        {
            if (!SmartCard_Procedures.ReadCard_Information((int)Global_Data.COM_NUM))
                return false;
            int int32 = Convert.ToInt32(SmartCard_Procedures.Card_Information_String.Substring(2, 2));
            return int32 == 0 || int32 > 18;
        }

        private bool Make_Guest_Card(
          int para_bld_no,
          int para_flr_no,
          int para_rm_no,
          string para_CheckInTime,
          string para_CheckOutTime)
        {
            string para_string = Global_Data.System_Pas_String + para_bld_no.ToString("D2") + para_flr_no.ToString("D2") + para_rm_no.ToString("D2") + gCardProperty.CheckInDate.Date.ToShortDateString().Substring(2, 2) + gCardProperty.CheckInDate.Date.ToShortDateString().Substring(5, 2) + gCardProperty.CheckInDate.Date.ToShortDateString().Substring(8, 2) + para_CheckInTime.Substring(0, 2) + para_CheckInTime.Substring(3, 2) + this.dateTimePicker_CheckOutDate.Text.Substring(2, 2) + this.dateTimePicker_CheckOutDate.Text.Substring(5, 2) + this.dateTimePicker_CheckOutDate.Text.Substring(8, 2) + para_CheckOutTime.Substring(0, 2) + para_CheckOutTime.Substring(3, 2) + "DEDEDEDE";
            return SmartCard_Procedures.Make_Guest_Card((int)Global_Data.COM_NUM, para_string);
        }

        private void cmdIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCheckInDate.Text.Length != 10)
                {
                    //int num = (int) MessageBox.Show("Invalid Check In Date");
                    //return;
                }
                DateTime.Parse(this.txtCheckInDate.Text);
            }
            catch
            {
                //int num = (int) MessageBox.Show("Invalid Check In Date");
                //return;
            }
            this.lblMessage2.Text = "";
            if (!Global_Data.Card_Reader_Found_Flag)
            {
                int num1 = (int)MessageBox.Show("Card Reader Not Found!");
            }
            else
            {
                this.Refresh();
                if (SmartCard_Procedures.ReadCardID((int)Global_Data.COM_NUM))
                {
                    if (Global_Data.Card_HW_ID != SmartCard_Procedures.Card_ID_String)
                    {
                        this.lblMessage.Text = "Card Changed!";
                        this.lblMessage.Refresh();
                        Console.Beep(700, 300);
                        //return;
                    }
                    this.lblMessage.ForeColor = System.Drawing.ColorTranslator.FromOle((int)byte.MaxValue);
                    this.lblMessage.Text = "Please wait, Writing Data to Key Card .....";
                    this.lblMessage.ForeColor = System.Drawing.ColorTranslator.FromOle((int)byte.MaxValue);
                    this.lblMessage.Refresh();
                    this.GetCardPropertyValue();
                    if (this.IssueCardRoutine())
                    {
                        this.lblMessage.Text = "Key Card Successfully Issued!";
                        int num2 = (int)MessageBox.Show("Finished");
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = false;
                        this.Check_OldGuest_Options_And_Process();
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
                        {
                            this._optOldGuest_0.Checked = true;
                            this.cmdReadCard.Enabled = true;
                            this.ChargesFrame.Enabled = true;
                            this.OldGuestFrame.Enabled = true;
                        }
                        //this.Reset_to_IDLE_Default_Screen();
                        //this.lblMessage2.Text = "Click \"Existing\" or \"Reserved\" or \"New\" Guest Type Choice";
                    }
                }
                else
                {
                    this.lblMessage.Text = "No Card Found!";
                    this.lblMessage.Refresh();
                    Console.Beep(700, 300);
                    Thread.Sleep(500);
                    this.lblMessage.Text = "";
                    return;
                }
                this.lblMessage.Text = "";
            }
        }

        private void txtExtraDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void Check_Extra_textBoxs()
        {
            this._txtDesExtra_0.Enabled = true;
            this._txtDesExtra_0.Visible = true;
            this._txtExtraAmount_0.Enabled = true;
            this._txtExtraAmount_0.Visible = true;
            if (this._txtDesExtra_0.Text.Length > 0)
            {
                this._txtDesExtra_1.Enabled = true;
                this._txtDesExtra_1.Visible = true;
                this._txtExtraAmount_1.Enabled = true;
                this._txtExtraAmount_1.Visible = true;
                this._txtDesExtra_1.Focus();
                this._txtDesExtra_1.Select();
            }
            else
            {
                this._txtDesExtra_0.Focus();
                this._txtDesExtra_0.Select();
            }
            if (this._txtDesExtra_1.Text.Length > 0)
            {
                this._txtDesExtra_2.Enabled = true;
                this._txtDesExtra_2.Visible = true;
                this._txtExtraAmount_2.Enabled = true;
                this._txtExtraAmount_2.Visible = true;
                this._txtDesExtra_2.Focus();
                this._txtDesExtra_2.Select();
            }
            if (this._txtDesExtra_2.Text.Length > 0)
            {
                this._txtDesExtra_3.Enabled = true;
                this._txtDesExtra_3.Visible = true;
                this._txtExtraAmount_3.Enabled = true;
                this._txtExtraAmount_3.Visible = true;
                this._txtDesExtra_3.Focus();
                this._txtDesExtra_3.Select();
            }
            if (this._txtDesExtra_3.Text.Length > 0)
            {
                this._txtDesExtra_4.Enabled = true;
                this._txtDesExtra_4.Visible = true;
                this._txtExtraAmount_4.Enabled = true;
                this._txtExtraAmount_4.Visible = true;
                this._txtDesExtra_4.Focus();
                this._txtDesExtra_4.Select();
            }
            if (this._txtDesExtra_4.Text.Length <= 0)
                return;
            this._txtExtraAmount_4.Focus();
            this._txtExtraAmount_4.Select();
        }

        private void txtExtraDescription_MouseClick(object sender, MouseEventArgs e)
        {
            this.ExtraChargeFrame.Enabled = true;
            this.ExtraChargeFrame.Visible = true;
            this.ExtraChargeFrame.BringToFront();
            this.txtExtraDescription.Enabled = false;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
            {
                this._optOldGuest_0.Enabled = false;
                this._optOldGuest_1.Enabled = false;
                this._optOldGuest_3.Enabled = false;
                this.cmdLoss.Enabled = false;
            }
            this.Check_Extra_textBoxs();
        }

        private Decimal Check_Extra_Values()
        {
            Decimal num1 = 0M;
            for (int index = 0; index <= 4; ++index)
            {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[index] = "0";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[index] = "";
            }
            if (this._txtDesExtra_4.Text.Length > 0)
            {
                if (this._txtExtraAmount_4.Text.Length > 0)
                {
                    try
                    {
                        Decimal num2 = Convert.ToDecimal(this._txtExtraAmount_4.Text);
                        num1 += num2;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[4] = this._txtExtraAmount_4.Text;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[4] = this._txtDesExtra_4.Text;
                    }
                    catch
                    {
                        int num3 = (int)MessageBox.Show("Incorrect Input Number in ExtraAmount 5!");
                    }
                }
            }
            if (this._txtDesExtra_3.Text.Length > 0)
            {
                if (this._txtExtraAmount_3.Text.Length > 0)
                {
                    try
                    {
                        Decimal num4 = Convert.ToDecimal(this._txtExtraAmount_3.Text);
                        num1 += num4;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[3] = this._txtExtraAmount_3.Text;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[3] = this._txtDesExtra_3.Text;
                    }
                    catch
                    {
                        int num5 = (int)MessageBox.Show("Incorrect Input Number in ExtraAmount 4!");
                    }
                }
            }
            if (this._txtDesExtra_2.Text.Length > 0)
            {
                if (this._txtExtraAmount_2.Text.Length > 0)
                {
                    try
                    {
                        Decimal num6 = Convert.ToDecimal(this._txtExtraAmount_2.Text);
                        num1 += num6;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[2] = this._txtExtraAmount_2.Text;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[2] = this._txtDesExtra_2.Text;
                    }
                    catch
                    {
                        int num7 = (int)MessageBox.Show("Incorrect Input Number in ExtraAmount 3!");
                    }
                }
            }
            if (this._txtDesExtra_1.Text.Length > 0)
            {
                if (this._txtExtraAmount_1.Text.Length > 0)
                {
                    try
                    {
                        Decimal num8 = Convert.ToDecimal(this._txtExtraAmount_1.Text);
                        num1 += num8;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[1] = this._txtExtraAmount_1.Text;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[1] = this._txtDesExtra_1.Text;
                    }
                    catch
                    {
                        int num9 = (int)MessageBox.Show("Incorrect Input Number in ExtraAmount 2!");
                    }
                }
            }
            if (this._txtDesExtra_0.Text.Length > 0)
            {
                if (this._txtExtraAmount_0.Text.Length > 0)
                {
                    try
                    {
                        Decimal num10 = Convert.ToDecimal(this._txtExtraAmount_0.Text);
                        num1 += num10;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExAmount[0] = this._txtExtraAmount_0.Text;
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sExDesc[0] = this._txtDesExtra_0.Text;
                    }
                    catch
                    {
                        int num11 = (int)MessageBox.Show("Incorrect Input Number in ExtraAmount 1!");
                    }
                }
            }
            return num1;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.txtExtra.Text = "0";
            this.txtExtraDescription.Text = "";
            Decimal num = this.Check_Extra_Values();
            this.ExtraChargeFrame.Enabled = false;
            this.ExtraChargeFrame.Visible = false;
            this.ExtraChargeFrame.SendToBack();
            this.txtExtraDescription.Enabled = true;
            this.txtExtra.Text = num.ToString("F2");
            this.txtExtraDescription.Text = "Total Extra Charges";
            if (this._txtDesExtra_0.Text.Length == 0 && this._txtDesExtra_1.Text.Length == 0 && this._txtDesExtra_2.Text.Length == 0 && this._txtDesExtra_3.Text.Length == 0 && this._txtDesExtra_4.Text.Length == 0)
                this.txtExtraDescription.Text = "";
            this.lblMessage.Text = "";
        }

        private void Filter_Keys_N_Dot(KeyPressEventArgs e, string para_string)
        {
            if (para_string.Contains(".") && e.KeyChar == '.')
                e.Handled = true;
            else if (para_string.Contains("-") && e.KeyChar == '-')
                e.Handled = true;
            else if (e.KeyChar == '-')
                e.Handled = false;
            else if (e.KeyChar == '.')
                e.Handled = false;
            else if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void _txtExtraAmount_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._txtDesExtra_0.Text.Length == 0)
            {
                int num = (int)MessageBox.Show("Pls. include description first!");
                e.Handled = true;
            }
            else if (e.KeyChar == '\r')
            {
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
                this._txtDesExtra_1.Enabled = true;
                this._txtDesExtra_1.Visible = true;
                this._txtExtraAmount_1.Enabled = true;
                this._txtExtraAmount_1.Visible = true;
                e.Handled = true;
                this._txtDesExtra_1.Focus();
                this._txtDesExtra_1.Select();
            }
            else
                this.Filter_Keys_N_Dot(e, this._txtExtraAmount_0.Text);
        }

        private void _txtExtraAmount_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._txtDesExtra_1.Text.Length == 0)
            {
                int num = (int)MessageBox.Show("Pls. include description first!");
                e.Handled = true;
            }
            else if (e.KeyChar == '\r')
            {
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
                this._txtDesExtra_2.Enabled = true;
                this._txtDesExtra_2.Visible = true;
                this._txtExtraAmount_2.Enabled = true;
                this._txtExtraAmount_2.Visible = true;
                e.Handled = true;
                this._txtDesExtra_2.Focus();
                this._txtDesExtra_2.Select();
            }
            else
                this.Filter_Keys_N_Dot(e, this._txtExtraAmount_1.Text);
        }

        private void _txtExtraAmount_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._txtDesExtra_2.Text.Length == 0)
            {
                int num = (int)MessageBox.Show("Pls. include description first!");
                e.Handled = true;
            }
            else if (e.KeyChar == '\r')
            {
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
                this._txtDesExtra_3.Enabled = true;
                this._txtDesExtra_3.Visible = true;
                this._txtExtraAmount_3.Enabled = true;
                this._txtExtraAmount_3.Visible = true;
                e.Handled = true;
                this._txtDesExtra_3.Focus();
                this._txtDesExtra_3.Select();
            }
            else
                this.Filter_Keys_N_Dot(e, this._txtExtraAmount_2.Text);
        }

        private void _txtExtraAmount_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._txtDesExtra_3.Text.Length == 0)
            {
                int num = (int)MessageBox.Show("Pls. include description first!");
                e.Handled = true;
            }
            else if (e.KeyChar == '\r')
            {
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
                this._txtDesExtra_4.Enabled = true;
                this._txtDesExtra_4.Visible = true;
                this._txtExtraAmount_4.Enabled = true;
                this._txtExtraAmount_4.Visible = true;
                e.Handled = true;
                this._txtDesExtra_4.Focus();
                this._txtDesExtra_4.Select();
            }
            else
                this.Filter_Keys_N_Dot(e, this._txtExtraAmount_3.Text);
        }

        private void _txtExtraAmount_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._txtDesExtra_4.Text.Length == 0)
            {
                int num = (int)MessageBox.Show("Pls. include description first!");
                e.Handled = true;
            }
            else if (e.KeyChar == '\r')
            {
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
                e.Handled = true;
                this.cmdOK.Focus();
                this.cmdOK.Select();
            }
            else
                this.Filter_Keys_N_Dot(e, this._txtExtraAmount_4.Text);
        }

        private void _txtExtraAmount_0_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._txtExtraAmount_0.Text.Length > 0)
            {
                this.txtExtraTotal.Text = "0";
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
            }
            else
                this._txtExtraAmount_0.Text = "0.00";
        }

        private void _txtExtraAmount_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._txtExtraAmount_1.Text.Length > 0)
            {
                this.txtExtraTotal.Text = "0";
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
            }
            else
                this._txtExtraAmount_1.Text = "0.00";
        }

        private void _txtExtraAmount_2_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._txtExtraAmount_2.Text.Length > 0)
            {
                this.txtExtraTotal.Text = "0";
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
            }
            else
                this._txtExtraAmount_2.Text = "0.00";
        }

        private void _txtExtraAmount_3_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._txtExtraAmount_3.Text.Length > 0)
            {
                this.txtExtraTotal.Text = "0";
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
            }
            else
                this._txtExtraAmount_3.Text = "0.00";
        }

        private void _txtExtraAmount_4_KeyUp(object sender, KeyEventArgs e)
        {
            if (this._txtExtraAmount_4.Text.Length > 0)
            {
                this.txtExtraTotal.Text = "0";
                this.txtExtraTotal.Text = this.Check_Extra_Values().ToString();
            }
            else
                this._txtExtraAmount_4.Text = "0.00";
        }

        private void txtExtra_TextChanged(object sender, EventArgs e)
        {
            this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            this.Check_for_cmdIssue_Enable();
        }

        private void txtExtraKeyCharge_TextChanged(object sender, EventArgs e)
        {
            if (this.ChargeFrame_InsertingFlag)
                return;
            this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
            this.Check_for_cmdIssue_Enable();
        }

        private void txtKeyDeposit_TextChanged(object sender, EventArgs e)
        {
            if (this.ChargeFrame_InsertingFlag)
                return;
            if (this.txtKeyDeposit.Text.Length > 0)
            {
                this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                this.Check_for_cmdIssue_Enable();
            }
            else
                this.txtKeyDeposit.Text = "0.00";
        }

        private void txtKeyDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Filter_Keys_N_Dot(e, this.txtKeyDeposit.Text);
        }

        private void txtReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Filter_Keys_N_Dot(e, this.txtReceived.Text);
        }

        private void Check_OldGuest_Options_And_Process()
        {
            string commandText = this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText;
            this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = "Delete * from GInfo_Temp";
            this.db.temp_DB.gInfo_TempTableAdapter.Delete((string)null);
            this.db.temp_DB.gInfo_TempTableAdapter.Adapter.DeleteCommand.CommandText = commandText;
            this.db.Local_Command.CommandText = "Insert into GInfo_Temp(ClientID,ForeName,SurName,RoomNo,CardNo,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople<>9)AND (len(ClientAcc.RoomNo)=5)AND (len(ClientAcc.CardNo)=5)ORDER BY ClientAcc.RoomNo";
            this.db.Local_Command.Connection = this.db.building_DB1.clientTableAdapter.Connection;
            this.db.Local_Command.Connection.Open();
            this.db.Local_Command.ExecuteNonQuery();
            this.db.Local_Command.Connection.Close();
            this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
        }

        private void cmdOld_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_ContractEnd.Enabled = false;
            this.txtCheckInDate.Enabled = false;
            this.dateTimePicker_CheckInTime.Enabled = false;
            this.lblMessage.Text = "";
            this.cmdReadCard.Enabled = true;
            this.Check_OldGuest_Options_And_Process();
            this.lblMessage2.Text = "Click Guest List Browser to Choose Old Guest ID";
            Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = false;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bBonusAlready = false;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest = 1U;
            this.cmdPrint.Enabled = false;
            this.Configure_Controls_for_Old();
            this.Reset_Controls_Value();
            this.cmdViewClient.Select();
        }

        private bool ClientAccountCheck(bool Old_Modify_Flag, string para_ClientID)
        {
            bool flag = false;
            foreach (TempDataSet.GInfo_TempRow row1 in (InternalDataCollectionBase)this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
            {
                if (row1.ClientID == para_ClientID)
                {
                    this.txtFirstName.Text = row1.ForeName;
                    this.txtSurName.Text = row1.SurName;
                    this.lblRoomNo.Text = row1.RoomNo;
                    this.txtCardNo.Text = row1.CardNo;
                    this.sOldCardNo = this.txtCardNo.Text;
                    this.lbCardType.Text = "Guest";
                    this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                    if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count <= 0)
                        this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                    if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.CardNoRow row2 in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
                        {
                            if (row2.CardNo == row1.CardNo)
                            {
                                Mod_UpdateData.iChkCardStatus = row2.CardStatus;
                                try
                                {
                                    gClientProperty.Card_AutoNumber = row2.Card_AutoNumber;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    gClientProperty.Card_HW_ID = row2.Card_HW_ID;
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                    if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
                        this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                    if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.ClientRow row3 in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.Client.Rows)
                        {
                            if (row3.ClientID == row1.ClientID)
                            {
                                this.txtIdentity.Text = row3.Identity;
                                this.txtAddress.Text = row3.Address;
                                this.txtNationality.Text = row3.Nationality;
                                this.txtContact.Text = row3.Contact;
                                try
                                {
                                    this.textBox_Email.Text = row3.Email;
                                }
                                catch
                                {
                                    this.textBox_Email.Text = "";
                                }
                                this.cboSex.SelectedItem = (object)row3.Sex;
                                this.cboCountry.SelectedItem = (object)row3.Country;
                                break;
                            }
                        }
                    }
                    this.bNewExisting = false;
                    this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                    if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
                        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                    if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.ClientAccRow row4 in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
                        {
                            if (row4.ClientID == row1.ClientID)
                            {
                                this.dateTimePicker_ContractStart.Value = row4.ContractStart;
                                this.dateTimePicker_ContractEnd.Value = row4.ContractEnd;
                                this.dateTimePicker_ValidStart.Value = row4.ValidStart;
                                this.dateTimePicker_ValidEnd.Value = row4.ValidEnd;
                                this.Old_Client_Valid_StartDate = row4.ValidStart;
                                this.Old_Client_Valid_EndDate = row4.ValidEnd;
                                this.Old_Client_CheckOut_Date = row4.CheckOutDate;
                                gClientProperty.People = row4.NoOfPeople.ToString();
                                this.sOldPeople = row4.NoOfPeople.ToString();
                                if (row4.NoOfPeople != (byte)9)
                                    this.bNewExisting = false;
                                else if (row4.RoomNo != "CN")
                                    this.bNewExisting = true;
                                Mod_UpdateData.sOldRoomStart = row4.RoomStart.ToShortDateString();
                                Mod_UpdateData.sOldContractStart = row4.ContractStart.ToShortDateString();
                                Mod_UpdateData.sOldContractEnd = row4.ContractEnd.ToShortDateString();
                                this.bRmPriceAdjust = row4.RmPriceAdjust;
                                if (!Old_Modify_Flag)
                                {
                                    this.ChargeType_Event_Disable = true;
                                    if (row4.ChargeType == "M")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Monthly";
                                        this.lbNoOfDays.Text = "No of Month";
                                        this.txtNoOfMonth.Visible = true;
                                        this.txtNoOfWeek.Visible = false;
                                        this.txtNoOfDays.Visible = false;
                                    }
                                    else if (row4.ChargeType == "W")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Weekly";
                                        this.lbNoOfDays.Text = "No of Week";
                                        this.txtNoOfMonth.Visible = false;
                                        this.txtNoOfWeek.Visible = true;
                                        this.txtNoOfDays.Visible = false;
                                    }
                                    else if (row4.ChargeType == "D")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Daily";
                                        this.lbNoOfDays.Text = "No of Days";
                                        this.txtNoOfMonth.Visible = false;
                                        this.txtNoOfWeek.Visible = false;
                                        this.txtNoOfDays.Visible = true;
                                    }
                                    this.ChargeType_Event_Disable = false;
                                }
                                try
                                {
                                    this.txtAmountPaid.Text = row4.AmountPaid.ToString("F2");
                                }
                                catch
                                {
                                    this.txtAmountPaid.Text = "0.00";
                                }
                                try
                                {
                                    this.txtAdvance.Text = row4.AdvancedPayment.ToString("F2");
                                    this.sAdvance = this.txtAdvance.Text;
                                }
                                catch
                                {
                                    this.txtAdvance.Text = "0.00";
                                    this.sAdvance = "0.00";
                                }
                                this.Set_Dates_Check((string)this.cboChargeType.SelectedItem);
                                this.Old_Client_ExtraDays = this.txtEarlyStart.Text;
                                this.dateTimePicker_CheckOutDate.Value = row4.CheckOutDate;
                                this.txtCheckInDate.Text = row4.CheckInDate.ToShortDateString();
                                try
                                {
                                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                                }
                                catch
                                {
                                }
                                this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + row4.CheckInTime.ToShortTimeString());
                                gCardProperty.CheckInTime = row4.CheckInTime;
                                this.Old_Client_Contract_End_Date = row4.ContractEnd;
                                try
                                {
                                    this.txtRemark.Text = row4.Remark;
                                }
                                catch
                                {
                                }
                                this.txtGracePeriod.Text = row4.GracePeriod.ToString();
                                this.txtBond.Text = row4.Bond.ToString("F2");
                                break;
                            }
                        }
                    }
                    this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
                    if (this.db.system_DB.systemDataSet.Room.Rows.Count <= 0)
                        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
                    if (this.db.system_DB.systemDataSet.Room.Rows.Count > 0)
                    {
                        foreach (SystemDataSet.RoomRow row5 in (InternalDataCollectionBase)this.db.system_DB.systemDataSet.Room.Rows)
                        {
                            if (row5.RoomNo == row1.RoomNo)
                            {
                                string roomTypeDescription = this.db.Get_RoomType_Description(row5.RoomType);
                                if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
                                {
                                    this.StayingPeopleFrame.Visible = true;
                                    this.StayingPeopleFrame.Enabled = true;
                                    if (row5.TotalStay == (byte)2)
                                    {
                                        this._optPeople_1.Checked = true;
                                        this._optPeople_0.Enabled = false;
                                        if (gClientProperty.People == "2")
                                        {
                                            this.bSecond = false;
                                            this.chkSecond.Enabled = false;
                                            this.chkSecond.Checked = true;
                                            this.dateTimePicker_ValidEnd.Enabled = false;
                                            this.StayingPeopleFrame.Enabled = false;
                                        }
                                        else
                                        {
                                            this.bSecond = true;
                                            this.chkSecond.Enabled = true;
                                            this.chkSecond.Checked = false;
                                            this.Old_Client_2ndKey_AlreadyIssued = false;
                                            foreach (BuildingDB1DataSet.ClientAccRow row6 in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
                                            {
                                                try
                                                {
                                                    if (this.lblRoomNo.Text == row6.RoomNo)
                                                    {
                                                        if (row6.NoOfPeople == (byte)2)
                                                        {
                                                            this.Old_Client_2ndKey_AlreadyIssued = true;
                                                            break;
                                                        }
                                                    }
                                                }
                                                catch
                                                {
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        this._optPeople_1.Enabled = false;
                                        this._optPeople_0.Enabled = true;
                                        this._optPeople_0.Checked = true;
                                        this.chkSecond.Enabled = false;
                                    }
                                }
                                else
                                {
                                    this.StayingPeopleFrame.Visible = false;
                                    this.StayingPeopleFrame.Enabled = false;
                                }
                                this.cboRoomType.SelectedItem = (object)this.db.Get_RoomType_Description(row5.RoomType);
                                this.txtIssuedCard.Text = row5.IssuedCard.ToString();
                                break;
                            }
                        }
                    }
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private bool Process_For_OldClientID_Data(string para_ClientID)
            {
                this.RegistrationFrame.Enabled = false;
                this.bSecond = false;
                this.Configure_Controls_for_Old();
                this.Reset_Controls_Value();
                this.txtClientID.Text = para_ClientID;
                this.dateTime_Auto_InsertingFlag = true;
                this.Reset_Calendar_Limits();
                if (!this.ClientAccountCheck(false, para_ClientID))
                {
                    this.dateTime_Auto_InsertingFlag = false;
                    return false;
                }
                this.CalculateRoomCharge(this.lblRoomNo.Text);
                this.txtCurrRoomCharge.Text = "0.00";
                this.RegistrationFrame.Enabled = true;
                this._optOldGuest_0.Enabled = true;
                this._optOldGuest_1.Enabled = true;
                this._optOldGuest_3.Enabled = true;
                this.OldGuestFrame.Enabled = true;
                this.chkBondDiff.Visible = false;
                this.chkBondDiff.Enabled = false;
                this.lblDiffBond.Visible = false;
                this.txtDiffBond.Visible = false;
                this.txtDiffBond.Enabled = false;
                gCardProperty.LossLog = 0;
                this.cmdLoss.Text = "Inform Key Loss";
                this.cmdLoss.Enabled = true;
                this.ChargesFrame.Enabled = false;
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                this.lblMessage2.Text = "Select Spare Key Or Extension Option.\r\nFor Inform Key Loss,Insert New Card..";
                this.dateTime_Auto_InsertingFlag = false;
                return true;
            }

            private void cmdViewClient_Click(object sender, EventArgs e)
            {
                this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
                int num = (int)new Form_GuestBrowserDMS().ShowDialog();
                this.Refresh();
                if (ModDoorLockSystem.Form_IssueGuestCard_Ptr.Old_Client_OK_flag)
                {
                    this.Process_For_OldClientID_Data(this.Old_Client_ID);
                    this.cmdReadCard.Enabled = true;
                    this.txtExtraDescription.Enabled = true;
                }
                this.dateTime_Auto_InsertingFlag = false;
                if (!(gClientProperty.People == "2") || this.bSecond)
                    return;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.StayingPeopleFrame.Enabled = false;
            }

            private void _optOldGuest_1_CheckedChanged(object sender, EventArgs e)
            {

                if (this._optOldGuest_1.Checked)
                {
                    if (this.txtClientID.Text == this.Old_Client_ID)
                        this.ClientAccountCheck(false, this.Old_Client_ID);
                    this.chkExtendNewCard.Visible = false;
                    this.chkExtendNewCard.Checked = false;
                    this.cmdLoss.Enabled = false;
                    this.lbExtraKeyCharge.Visible = true;
                    this.txtExtraKeyCharge.Visible = true;
                    this.txtKeyDeposit.Visible = false;
                    this.lbExtraKeyCharge.Text = "Spare Key Deposit";
                    this.txtExtraKeyCharge.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giExtraKeyCharge;
                    this.checkBox_Replace.Checked = false;
                    this.checkBox_Replace.Visible = true;
                    this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                    this.dateTime_Auto_InsertingFlag = true;
                    this.Reset_Calendar_Limits();
                    this.dateTimePicker_ValidEnd.Value = this.Old_Client_Valid_EndDate;
                    this.dateTimePicker_ContractEnd.Value = this.Old_Client_Contract_End_Date;
                    this.dateTimePicker_CheckOutDate.Value = this.Old_Client_CheckOut_Date;
                    this.txtEarlyStart.Text = this.Old_Client_ExtraDays;
                    this.dateTimePicker_ValidStart.Enabled = false;
                    this.dateTimePicker_ValidEnd.Enabled = false;
                    this.dateTimePicker_ContractStart.Enabled = false;
                    this.dateTimePicker_ContractEnd.Enabled = false;
                    this.dateTimePicker_CheckOutDate.Enabled = false;
                    this.dateTime_Auto_InsertingFlag = false;
                    this.txtCurrRoomCharge.Text = "0.00";
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                    this.Check_for_cmdIssue_Enable();
                    this.chkSecond.Enabled = false;
                    this.chkBondDiff.Visible = false;
                    this.chkBondDiff.Enabled = false;
                    this.lblDiffBond.Visible = false;
                    this.txtDiffBond.Visible = false;
                    this.txtDiffBond.Enabled = false;
                    this.ChargesFrame.Enabled = true;
                }
                else
                    this.checkBox_Replace.Visible = false;
            }

            private void Select_For_Spare_Card_Extension(string para_Client_ID)
            {
                this.ClientAccountCheck(false, para_Client_ID);
                this.chkExtendNewCard.Visible = false;
                this.chkExtendNewCard.Checked = false;
                this.checkBox_Replace.Visible = false;
                this.cmdLoss.Enabled = true;
                this.lbExtraKeyCharge.Text = "Key Deposit";
                this.txtExtraKeyCharge.Visible = false;
                this.txtKeyDeposit.Visible = true;
                this.txtKeyDeposit.Text = "0.00";
                this.txtExtraKeyCharge.Text = "0.00";
                this.txtCardNo.Text = this.sOldCardNo;
                this.lblDiffBond.Visible = false;
                this.txtDiffBond.Visible = false;
                this.txtDiffBond.Enabled = false;
                this.dateTime_Auto_InsertingFlag = true;
                this.Reset_Calendar_Limits();
                this.dateTimePicker_ValidEnd.Value = this.Old_Client_Valid_EndDate;
                this.dateTimePicker_ContractEnd.Value = this.Old_Client_Contract_End_Date;
                this.dateTimePicker_CheckOutDate.Value = this.Old_Client_CheckOut_Date;
                this.txtAdvance.Text = this.sAdvance;
                this.txtEarlyStart.Text = this.Old_Client_ExtraDays;
                this.dateTime_Auto_InsertingFlag = false;
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                this.txtCurrRoomCharge.Text = "0.00";
                this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                if (!this._optPeople_1.Checked || this.Old_Client_2ndKey_AlreadyIssued)
                    return;
                this.chkSecond.Enabled = true;
            }

            private void _optOldGuest_0_CheckedChanged(object sender, EventArgs e)
            {
                if (!this.OldGuestFrame.Visible || !this._optOldGuest_0.Checked)
                    return;
                if (this.txtClientID.Text == this.Old_Client_ID)
                    this.ClientAccountCheck(false, this.Old_Client_ID);
                this.chkExtendNewCard.Visible = false;
                this.chkExtendNewCard.Checked = false;
                this.checkBox_Replace.Visible = false;
                this.ChargesFrame.Enabled = false;
                this.cmdLoss.Enabled = true;
                this.lbExtraKeyCharge.Text = "Key Deposit";
                this.txtExtraKeyCharge.Visible = false;
                this.txtKeyDeposit.Visible = true;
                this.txtKeyDeposit.Text = "0.00";
                this.txtExtraKeyCharge.Text = "0.00";
                this.txtCardNo.Text = this.sOldCardNo;
                this.lblDiffBond.Visible = false;
                this.txtDiffBond.Visible = false;
                this.txtDiffBond.Enabled = false;
                this.dateTime_Auto_InsertingFlag = true;
                this.Reset_Calendar_Limits();
                //this.dateTimePicker_ValidEnd.Value = this.Old_Client_Valid_EndDate;
                //this.dateTimePicker_ContractEnd.Value = this.Old_Client_Contract_End_Date;
                //this.dateTimePicker_CheckOutDate.Value = this.Old_Client_CheckOut_Date;
                this.txtAdvance.Text = this.sAdvance;
                //this.txtEarlyStart.Text = this.Old_Client_ExtraDays;
                this.dateTime_Auto_InsertingFlag = false;
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                this.txtCurrRoomCharge.Text = "0.00";
                this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                this.Check_for_cmdIssue_Enable();
                if (this._optPeople_1.Checked && !this.Old_Client_2ndKey_AlreadyIssued)
                    this.chkSecond.Enabled = true;
                this.cmdReadCard.Enabled = true;
                this.dateTimePicker_ContractEnd.Enabled = false;
            }

            private void KeyExtensionRoutine()
            {
            }

            private bool Check_CanExtendAuto(
              DateTime para_ValidEnd_Date,
              string para_RoomNo,
              string para_ClientID,
              bool para_2ndPerson)
            {
                this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
                foreach (TempDataSet.GInfo_TempRow row in (InternalDataCollectionBase)this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
                {
                    if (row.RoomNo == para_RoomNo && row.ClientID != para_ClientID)
                        return para_ValidEnd_Date.CompareTo(row.ValidEnd) >= 0;
                }
                return true;
            }

            private bool Get_OtherPerson_Extension_Data(string para_ClientID)
            {
                bool personExtensionData = false;
                foreach (TempDataSet.GInfo_TempRow row1 in (InternalDataCollectionBase)this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
                {
                    if (row1.ClientID == para_ClientID)
                    {
                        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
                            this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
                        {
                            foreach (BuildingDB1DataSet.ClientAccRow row2 in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
                            {
                                if (row2.ClientID == row1.ClientID)
                                {
                                    this.dateTimePicker_ContractStart.Value = row2.ContractStart;
                                    this.dateTimePicker_ContractEnd.Value = row2.ContractEnd;
                                    this.dateTimePicker_ValidStart.Value = row2.ValidStart;
                                    this.dateTimePicker_ValidEnd.Value = row2.ValidEnd;
                                    if (row2.ChargeType == "M")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Monthly";
                                        this.lbNoOfDays.Text = "No of Month";
                                        this.txtNoOfMonth.Visible = true;
                                        this.txtNoOfWeek.Visible = false;
                                        this.txtNoOfDays.Visible = false;
                                    }
                                    else if (row2.ChargeType == "W")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Weekly";
                                        this.lbNoOfDays.Text = "No of Week";
                                        this.txtNoOfMonth.Visible = false;
                                        this.txtNoOfWeek.Visible = true;
                                        this.txtNoOfDays.Visible = false;
                                    }
                                    else if (row2.ChargeType == "D")
                                    {
                                        this.cboChargeType.SelectedItem = (object)"Daily";
                                        this.lbNoOfDays.Text = "No of Days";
                                        this.txtNoOfMonth.Visible = false;
                                        this.txtNoOfWeek.Visible = false;
                                        this.txtNoOfDays.Visible = true;
                                    }
                                    this.Set_Dates_Check((string)this.cboChargeType.SelectedItem);
                                    this.txtCheckInDate.Text = row2.CheckInDate.ToShortDateString();
                                    try
                                    {
                                        this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                                        this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                                    }
                                    catch
                                    {
                                    }
                                    this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + row2.CheckInTime.ToShortTimeString());
                                    this.dateTimePicker_CheckOutDate.Value = row2.CheckOutDate;
                                    this.txtGracePeriod.Text = row2.GracePeriod.ToString();
                                    break;
                                }
                            }
                        }
                        personExtensionData = true;
                        break;
                    }
                }
                return personExtensionData;
            }

            private bool Get_OtherPersonSameRoomValidDate(
              DateTime para_ValidEnd_Date,
              string para_RoomNo,
              string para_ClientID,
              bool para_2ndPerson)
            {
                bool sameRoomValidDate = false;
                this.db.temp_DB.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
                foreach (TempDataSet.GInfo_TempRow row in (InternalDataCollectionBase)this.db.temp_DB.tempDataSet.GInfo_Temp.Rows)
                {
                    if (row.RoomNo == para_RoomNo && row.ClientID != para_ClientID)
                    {
                        this.Other_Person_ValidEndDate = row.ValidEnd;
                        this.Other_Person_ValidStartDate = row.ValidStart;
                        if (this.Other_Person_ValidEndDate.CompareTo(this.Old_Client_Valid_EndDate) == 0)
                        {
                            Console.Beep(700, 300);
                            this.lblMessage.Text = "Major Card Owner not Extended!";
                            return true;
                        }
                        this.lblMessage.Text = "Other Person Already Extended!";
                        this.lblMessage.Refresh();
                        Console.Beep(700, 300);
                        Thread.Sleep(500);
                        this.Others_Person_Extended_Flag = true;
                        return this.Get_OtherPerson_Extension_Data(row.ClientID);
                    }
                }
                return sameRoomValidDate;
            }

            private string Get_Spare_Card_CardNo(string Client_ID)
            {
                this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
                {
                    if (Client_ID == row.ClientID && Global_Data.Card_HW_ID == row.Card_HW_ID && Global_Data.Card_AutoNumber == row.Card_AutoNumber)
                        return row.CardNo;
                }
                return "";
            }

            private void Change_For_OldGuest_Extension()
            {
                bool flag = false;
                Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = false;
                this.chkExtendNewCard.Visible = true;
                this.chkExtendNewCard.Checked = false;
                this.checkBox_Replace.Visible = false;
                this.cmdLoss.Enabled = false;
                this.txtKeyDeposit.Text = "0.00";
                this.txtExtraKeyCharge.Text = "0.00";
                this.txtCardNo.Text = this.sOldCardNo;
                this.lbExtraKeyCharge.Visible = false;
                this.txtExtraKeyCharge.Visible = false;
                this.txtKeyDeposit.Visible = false;
                this.lblDiffBond.Visible = true;
                this.txtDiffBond.Visible = true;
                this.txtDiffBond.Enabled = true;
                this.ChargesFrame.Enabled = true;
                this.ClientAccountCheck(true, this.Old_Client_ID);
                this.KeyExtensionRoutine();
                this.dateTime_Auto_InsertingFlag = true;
                this.Reset_Calendar_Limits();
                this.sCurrValidStart = this.dateTimePicker_ValidEnd.Value.Date;
                this.dateTimePicker_ValidStart.Value = this.sCurrValidStart;
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                if (this._optPeople_1.Checked && this.StayingPeopleFrame.Visible)
                {
                    if (this.Check_CanExtendAuto(this.dateTimePicker_ValidEnd.Value, this.lblRoomNo.Text, this.txtClientID.Text, this.chkSecond.Checked))
                    {
                        this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
                        this.Set_Dates_Check((string)this.cboChargeType.SelectedItem);
                        flag = true;
                    }
                    else if (this.Get_OtherPersonSameRoomValidDate(this.dateTimePicker_ValidEnd.Value, this.lblRoomNo.Text, this.txtClientID.Text, this.chkSecond.Checked))
                    {
                        this.dateTimePicker_ValidEnd.Value = this.Other_Person_ValidEndDate;
                        this.dateTimePicker_ValidStart.Value = this.Other_Person_ValidStartDate;
                    }
                    else
                    {
                        Console.Beep(700, 300);
                        int num = (int)MessageBox.Show("Can't get other person Dates!");
                    }
                }
                else
                {
                    this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
                    this.Set_Dates_Check((string)this.cboChargeType.SelectedItem);
                    flag = true;
                }
                if (flag)
                {
                    this.dateTimePicker_ValidEnd.Enabled = true;
                    this.dateTimePicker_ContractEnd.Enabled = true;
                }
                this.dateTime_Auto_InsertingFlag = false;
                if (flag)
                {
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                }
                this.Check_for_cmdIssue_Enable();
                this.txtDiffBond.Focus();
                this.dateTimePicker_ValidStart.Enabled = false;
            }

            private void _optOldGuest_3_CheckedChanged(object sender, EventArgs e)
            {
                if (this._optOldGuest_3.Checked)
                {
                    this.Others_Person_Extended_Flag = false;
                    this.Change_For_OldGuest_Extension();
                    Console.Beep(700, 300);
                    this.lblMessage.Text = "Click Check Card before Top Up!";
                    this.Others_Person_Extended_Flag = false;
                    this.cmdReadCard.Select();
                    this.dateTimePicker_ContractEnd.Enabled = true;
                }
                else
                {
                    this.chkExtendNewCard.Visible = false;
                    this.chkExtendNewCard.Checked = false;
                    this.checkBox_Replace.Visible = false;
                }
            }

            private void Form_IssueGuestCardDMS_Shown(object sender, EventArgs e)
            {
                this.Refresh();
                if (!this._1st_Time_Flag)
                    return;
                this.Initialize_1st_Time();
                this._1st_Time_Flag = false;
            }

            private void Reservation_Frame_Enabled()
            {
                this.cmdViewReserveList.Visible = true;
                this.txtReservationRef.Visible = true;
                this.txtReserve.Visible = true;
                this.Label14.Visible = true;
                this.cmdViewReserveList.Enabled = true;
                this.txtReservationRef.Enabled = true;
                this.txtReserve.Enabled = true;
                this.Label14.Enabled = true;
            }

            private void Reservation_Frame_Disabled()
            {
                this.cmdViewReserveList.Visible = false;
                this.txtReservationRef.Visible = false;
                this.txtReserve.Visible = false;
                this.Label14.Visible = false;
                this.Refresh();
                this.cmdViewReserveList.Enabled = false;
                this.txtReservationRef.Enabled = false;
                this.txtReserve.Enabled = false;
                this.Label14.Enabled = false;
            }

            private void cmdViewReserveList_Click(object sender, EventArgs e)
            {
                this.db.Get_AccReservationList();
                int num = (int)new Form_ViewReserveListDMS().ShowDialog();
                this.Refresh();
                this.dateTime_Auto_InsertingFlag = true;
                this.Reset_Calendar_Limits();
                this.ChargeFrame_InsertingFlag = true;
                if (this.Reserve_Client_OK_flag)
                {
                    this.txtCheckInDate.Enabled = true;
                    this.dateTimePicker_CheckInTime.Enabled = true;
                    this.txtReservationRef.Text = this.Reserve_Client_RefID;
                    this.RegistrationFrame.Enabled = true;
                    foreach (TempDataSet.AccReservationListRow row in (InternalDataCollectionBase)this.db.temp_DB.tempDataSet.AccReservationList.Rows)
                    {
                        if (row.ReserveRef == this.Reserve_Client_RefID)
                        {
                            this.Reserve_RoomNo_Select = row.RoomNo;
                            this.Old_Reserved_RoomNo = row.RoomNo;
                            this.Reserve_ClientID_Select = row.ClientID;
                            this.txtFirstName.Text = row.ForeName;
                            this.txtSurName.Text = row.SurName;
                            this.txtDeposit.Text = row.Deposit.ToString("F2");
                            break;
                        }
                    }
                    try
                    {
                        this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                        if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
                            this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                    }
                    catch
                    {
                        this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                    }
                    if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.Client.Rows)
                        {
                            if (this.Reserve_ClientID_Select == row.ClientID)
                            {
                                try
                                {
                                    this.txtIdentity.Text = row.Identity;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    this.txtAddress.Text = row.Address;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    this.txtNationality.Text = row.Nationality;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    this.txtContact.Text = row.Contact;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    this.cboSex.SelectedItem = (object)row.Sex;
                                }
                                catch
                                {
                                }
                                try
                                {
                                    this.cboCountry.SelectedItem = (object)row.Country;
                                }
                                catch
                                {
                                }
                                this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
                                IEnumerator enumerator = this.db.building_DB1.buildingDB1DataSet.Client.Rows.GetEnumerator();
                                try
                                {
                                    while (enumerator.MoveNext())
                                    {
                                        BuildingDB1DataSet.ClientRow current = (BuildingDB1DataSet.ClientRow)enumerator.Current;
                                        if (current.ClientID == this.Reserve_ClientID_Select)
                                        {
                                            try
                                            {
                                                this.textBox_Email.Text = current.Email;
                                                break;
                                            }
                                            catch
                                            {
                                                this.textBox_Email.Text = "";
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                }
                                finally
                                {
                                    if (enumerator is IDisposable disposable)
                                        disposable.Dispose();
                                }
                            }
                        }
                    }
                    try
                    {
                        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                        if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
                            this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                    }
                    catch
                    {
                        this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
                    }
                    if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.ClientAccRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows)
                        {
                            if (this.Reserve_ClientID_Select == row.ClientID)
                            {
                                this.Reserve_Contract_End = row.ContractEnd;
                                break;
                            }
                        }
                    }
                    this.lblRoomNo.Text = this.Reserve_RoomNo_Select;
                    this.txtClientID.Text = this.Reserve_ClientID_Select;
                    this.iRoomType = (int)this.GetRoomType_ForReserve(this.Reserve_RoomNo_Select);
                    this.cboRoomType.SelectedItem = (object)this.db.Get_RoomType_Description((byte)this.iRoomType);
                    this.SearchRoomDisplay(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest);
                    this.cboChargeType.SelectedItem = (object)"Monthly";
                    this.dateTimePicker_ValidStart.Value = DateTime.Now;
                    this.dateTimePicker_ContractStart.Value = DateTime.Now;
                    this.Set_Dates_Auto((string)this.cboChargeType.SelectedItem);
                    this.dateTimePicker_ContractEnd.Value = this.Reserve_Contract_End;
                    Mod_UpdateData.iChkCardStatus = (byte)0;
                    this.txtExtraKeyCharge.Text = "0.00";
                    this.lbExtraKeyCharge.Text = "Key Deposit";
                    this.txtKeyDeposit.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giKeyDeposit;
                    this.txtKeyDeposit.Visible = true;
                    this.txtExtraKeyCharge.Visible = false;
                    this.txtKeyDeposit.Enabled = true;
                    this.lbCardType.Text = "Guest";
                    this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                    this.dateTime_Auto_InsertingFlag = false;
                    this.ChargeFrame_InsertingFlag = false;
                    this.dateTimePicker_ContractStart.Enabled = true;
                    this.dateTimePicker_ContractEnd.Enabled = true;
                    this.txtExtraDescription.Enabled = true;
                    this.dateTimePicker_ValidEnd.Enabled = true;
                    this.dateTimePicker_ValidStart.Enabled = true;
                }
                this.ChargeFrame_InsertingFlag = false;
            }

            private void txtUnitNo_TextChanged(object sender, EventArgs e)
            {
            }

            private void KeyLossComFirm()
            {
                gCardProperty.LossLog = 1;
                this.cmdLoss.Text = "Previous Key Lossed";
                this.lbExtraKeyCharge.Visible = true;
                this.lbExtraKeyCharge.Text = "Loss Key Charges";
                this.txtExtraKeyCharge.Visible = true;
                this.txtKeyDeposit.Visible = false;
                this.txtExtraKeyCharge.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giExtraKeyCharge;
                this.Old_Client_ExtraKey = gClientProperty.ExtraKey;
                gClientProperty.ExtraKey = "2";
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_ContractEnd.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                this._optOldGuest_1.Enabled = false;
                this._optOldGuest_3.Enabled = false;
                this.ChargesFrame.Enabled = true;
            }

            private void KeyLossNotComFirm()
            {
                gCardProperty.LossLog = 0;
                this.cmdLoss.Text = "Inform Key Loss";
                this.lbExtraKeyCharge.Visible = true;
                this.lbExtraKeyCharge.Text = "Key Deposit";
                this.txtExtraKeyCharge.Visible = false;
                this.txtKeyDeposit.Visible = true;
                this.txtExtraKeyCharge.Text = "0.00";
                gClientProperty.ExtraKey = this.Old_Client_ExtraKey;
                this.dateTimePicker_ValidStart.Enabled = false;
                this.dateTimePicker_ValidEnd.Enabled = false;
                this.dateTimePicker_ContractStart.Enabled = false;
                this.dateTimePicker_ContractEnd.Enabled = false;
                this.dateTimePicker_CheckOutDate.Enabled = false;
                this.txtCardNo.Text = this.sOldCardNo;
                this._optOldGuest_1.Enabled = true;
                this._optOldGuest_3.Enabled = true;
                this.ChargesFrame.Enabled = false;
            }

            private void cmdLoss_Click(object sender, EventArgs e)
            {
                string text = "Please comfirm Yes/No ?";
                string caption = " Comfirm Loss Key Card !";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (gCardProperty.LossLog == 0)
                {
                    if (MessageBox.Show(text, caption, buttons) != DialogResult.Yes)
                        return;
                    this.KeyLossComFirm();
                }
                else
                {
                    if (MessageBox.Show("Are you sure Do not Loss Card?  ", "Alarm!", buttons) != DialogResult.Yes)
                        return;
                    this.KeyLossNotComFirm();
                }
            }

            private void dateTimePicker_ValidStart_ValueChanged(object sender, EventArgs e)
            {
                if (!this.dateTime_Auto_InsertingFlag && !this._1st_Time_Flag)
                {
                    if (!this.Set_Dates_Check((string)this.cboChargeType.SelectedItem))
                    {
                        try
                        {
                            this.bool_Invalid_Date_Error = true;
                            this.TimeOut_Message_Cnt = 3;
                            this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                            this.lblMessage2.Text = "Can Not Select Start Date Later Than " + this.dateTimePicker_ValidEnd.Value.AddDays(-1.0).Date.ToShortDateString() + "!";
                            this.lblMessage2.Refresh();
                            SystemSounds.Exclamation.Play();
                            this.Timer1.Start();
                            this.dateTimePicker_ValidStart.MaxDate = this.dateTimePicker_ValidEnd.Value;
                            this.dateTimePicker_ValidStart.Update();
                            this.dateTimePicker_ValidStart.Refresh();
                            this.dateTimePicker_ValidStart.ResumeLayout();
                            this.dateTimePicker_ValidStart.Value = this.Old_Valid_Start_Date;
                        }
                        catch
                        {
                            this.dateTimePicker_ValidStart.Value = this.dateTimePicker_ValidEnd.Value.AddDays(-1.0);
                            this.bool_Invalid_Date_Error = true;
                            this.TimeOut_Message_Cnt = 3;
                            this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                            this.lblMessage2.Text = "Can Not Select Start Date Later Than " + this.dateTimePicker_ValidEnd.Value.AddDays(-1.0).Date.ToShortDateString() + "!";
                            this.lblMessage2.Refresh();
                            SystemSounds.Exclamation.Play();
                            this.Timer1.Start();
                            this.dateTimePicker_ValidStart.MaxDate = this.dateTimePicker_ValidEnd.Value;
                            this.dateTimePicker_ValidStart.Update();
                            this.dateTimePicker_ValidStart.Refresh();
                            this.dateTimePicker_ValidStart.ResumeLayout();
                        }
                    }
                    else if (this.dateTimePicker_ValidEnd.Value.Date.ToShortDateString() == this.dateTimePicker_ValidStart.Value.Date.ToShortDateString())
                    {
                        this.dateTimePicker_ValidStart.Value = this.Old_Valid_Start_Date;
                        this.bool_Invalid_Date_Error = true;
                        this.TimeOut_Message_Cnt = 3;
                        this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                        this.lblMessage2.Text = "Can Not Select Start Date Later Than " + this.dateTimePicker_ValidEnd.Value.AddDays(-1.0).Date.ToShortDateString() + "!";
                        this.lblMessage2.Refresh();
                        SystemSounds.Exclamation.Play();
                        this.Timer1.Start();
                        this.dateTimePicker_ValidStart.MaxDate = this.dateTimePicker_ValidEnd.Value;
                        this.dateTimePicker_ValidStart.Update();
                        this.dateTimePicker_ValidStart.Refresh();
                        this.dateTimePicker_ValidStart.ResumeLayout();
                    }
                    else
                    {
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                            this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                        else
                            this.CalculateRoomCharge(this.lblRoomNo.Text);
                        this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                        if (Global_Data.NewDate_NewCheckIn_FirstPerson_Flag)
                            this.txtCheckInDate.Text = this.dateTimePicker_ValidStart.Text;
                    }
                }
                if (this.dateTimePicker_ValidStart.Value.CompareTo(this.dateTimePicker_ContractStart.Value) >= 0)
                    return;
                this.dateTimePicker_ContractStart.Value = this.dateTimePicker_ValidStart.Value;
                this.dateTimePicker_ValidEnd.Refresh();
                this.dateTimePicker_ValidEnd.Value = this.dateTimePicker_ValidStart.Value.AddMonths(6);
            }

            private void dateTimePicker_ValidStart_MouseDown(object sender, MouseEventArgs e)
            {
                this.Old_Valid_Start_Date = this.dateTimePicker_ValidStart.Value;
            }

            private void chkSecond_Click(object sender, EventArgs e)
            {
                if (this.chkSecond.Checked)
                {
                    if (this.Old_Client_2ndKey_AlreadyIssued)
                    {
                        this.chkSecond.Checked = false;
                        this.chkSecond.Enabled = false;
                        this.chkSecond.Refresh();
                        int num = (int)MessageBox.Show("Already issue second key !");
                    }
                    else
                    {
                        this.ChargesFrame.Enabled = true;
                        this.bSecondClick = true;
                        this.OldGuestFrame.Enabled = false;
                        this.cmdLoss.Enabled = false;
                        this.chkSecond.Enabled = false;
                        this.Clear_Client_Frame_Value();
                        this.txtClientID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_ClientID(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                        this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                        this.ChargeFrame_InsertingFlag = true;
                        this.sAdvance = "0.00";
                        this.txtAmountPaid.Text = "0.00";
                        this.txtAdvance.Text = "0.00";
                        this.lbExtraKeyCharge.Text = "Key Deposit";
                        this.txtExtraKeyCharge.Visible = false;
                        this.ChargesFrame.Refresh();
                        this.ChargeFrame_InsertingFlag = false;
                        this.txtKeyDeposit.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giKeyDeposit;
                        this.txtKeyDeposit.Visible = true;
                    }
                }
                else
                    this.bSecondClick = false;
            }

            private void txtDiffBond_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.Filter_Keys_N_Dot(e, this.txtDiffBond.Text);
            }

            private void txtDiffBond_TextChanged(object sender, EventArgs e)
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
                {
                    this._optOldGuest_0.Enabled = false;
                    this._optOldGuest_1.Enabled = false;
                    this._optOldGuest_3.Enabled = false;
                    this.cmdLoss.Enabled = false;
                }
                if (this.txtDiffBond.Text.Length > 0)
                {
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                    this.Check_for_cmdIssue_Enable();
                }
                else
                    this.txtDiffBond.Text = "0.00";
            }

            private void _optPeople_0_Click(object sender, EventArgs e)
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                {
                    this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                }
                else
                {
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 2U)
                        return;
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                }
            }

            private void _optPeople_1_Click(object sender, EventArgs e)
            {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                {
                    this.CalculateRoomCharge((string)this.cboRoomNo.SelectedItem);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                }
                else
                {
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 2U)
                        return;
                    this.CalculateRoomCharge(this.lblRoomNo.Text);
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                }
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
                ReportClass_Receipt_LastTrans receiptLastTrans = new ReportClass_Receipt_LastTrans();
                reportForm.crystalReportViewer1.ReportSource = receiptLastTrans.CHECK_TransType(transType, transId, Global_Data.sBldNo);
                int num = (int)reportForm.ShowDialog();
            }

            private void Form_IssueGuestCardDMS_VisibleChanged(object sender, EventArgs e)
            {
                if (!this.Visible)
                    return;
                this.lblMessage2.Text = "Click \"Existing\" or \"Reserved\" or \"New\" Guest Type Choice";
                this.cmdPrint.Enabled = false;
            }

            private void txtClientID_Click(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboSex_Click(object sender, EventArgs e) => this.lblMessage2.Text = "Select Sex..";

            private void cboCountry_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Select Country";
            }

            private void txtContact_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Contact No..";
            }

            private void txtNationality_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Guest's Nationality..";
            }

            private void txtSurName_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter SurName..";
            }

            private void txtFirstName_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter First Name..";
            }

            private void txtIdentity_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Passport No.";
            }

            private void txtAddress_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Address..";
            }

            private void txtCheckInDate_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
                if (this.txtCheckInDate.Text.Length != 10)
                    return;
                this.Old_CheckIn_Date = this.txtCheckInDate.Text;
            }

            private void txtRemark_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboRoomType_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboRoomNo_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtGracePeriod_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtNoOfWeek_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void dateTimePicker_CheckOutDate_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
            }

            private void StayingPeopleFrame_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void lblRoomNo_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboChargeType_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtExtraDescription_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
            }

            private void txtReceived_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void ChargesFrame_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cmdClear_Click(object sender, EventArgs e)
            {
                this.Reset_to_IDLE_Default_Screen();
                this.lblMessage2.Text = "Click \"Existing\" or \"Reserved\" or \"New\" Guest Type Choice";
                try
                {
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                }
                catch
                {
                }
                try
                {
                    this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + DateTime.Now.ToShortTimeString());
                    this.dateTimePicker_ValidEnd.Value = this.dateTimePicker_ValidStart.Value.AddMonths(6);
                }
                catch
                {
                }
            }

            private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.Filter_For_Email_Address(e, this.textBox_Email.Text);
            }

            private void Filter_For_Email_Address(KeyPressEventArgs e, string para_string)
            {
                if (para_string.Contains("@") && e.KeyChar == '@')
                {
                    this.lblMessage.Text = "Enter valid email format !";
                    this.lblMessage.Refresh();
                    Console.Beep(200, 300);
                    e.Handled = true;
                    this.lblMessage.Text = "";
                }
                else if (e.KeyChar == '@')
                {
                    if (para_string.Length == 0)
                    {
                        this.lblMessage.Text = "Enter valid email format !";
                        this.lblMessage.Refresh();
                        Console.Beep(200, 300);
                        e.Handled = true;
                        this.lblMessage.Text = "";
                    }
                    else
                        e.Handled = false;
                }
                else
                {
                    if (para_string.Contains("."))
                    {
                        if (para_string.IndexOf('.') != para_string.LastIndexOf('.'))
                        {
                            if (e.KeyChar == '.')
                            {
                                this.lblMessage.Text = "Enter valid email format !";
                                this.lblMessage.Refresh();
                                Console.Beep(200, 300);
                                e.Handled = true;
                                this.lblMessage.Text = "";
                                return;
                            }
                        }
                        else if (para_string.Length == para_string.LastIndexOf('.') + 1)
                        {
                            if (e.KeyChar == '.')
                            {
                                this.lblMessage.Text = "Enter valid email format !";
                                this.lblMessage.Refresh();
                                Console.Beep(200, 300);
                                e.Handled = true;
                                this.lblMessage.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            e.Handled = false;
                            return;
                        }
                    }
                    if (e.KeyChar == '.')
                    {
                        if (para_string.Length == 0)
                        {
                            this.lblMessage.Text = "Enter valid email format !";
                            this.lblMessage.Refresh();
                            Console.Beep(200, 300);
                            e.Handled = true;
                            this.lblMessage.Text = "";
                        }
                        else if (!para_string.Contains("@"))
                        {
                            this.lblMessage.Text = "Enter valid email format !";
                            this.lblMessage.Refresh();
                            Console.Beep(200, 300);
                            e.Handled = true;
                            this.lblMessage.Text = "";
                        }
                        else if (para_string.Length == para_string.LastIndexOf('@') + 1)
                        {
                            this.lblMessage.Text = "Enter valid email format !";
                            this.lblMessage.Refresh();
                            Console.Beep(200, 300);
                            e.Handled = true;
                            this.lblMessage.Text = "";
                        }
                        else
                            e.Handled = false;
                    }
                    else if (char.IsNumber(e.KeyChar))
                        e.Handled = false;
                    else if (char.IsLetterOrDigit(e.KeyChar))
                        e.Handled = false;
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        this.lblMessage.Text = "Enter valid email format !";
                        this.lblMessage.Refresh();
                        Console.Beep(200, 300);
                        e.Handled = true;
                        this.lblMessage.Text = "";
                    }
                }
            }

            private bool Check_SameCardID_Exist(string para_CardID) => false;

            private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r')
                {
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U)
                    {
                        if (this.txtClientID.Text.Length < 8)
                        {
                            //Console.Beep(700, 300);
                            //this.lblMessage.Text = "Invalid Card ID!";
                        }
                        else if (this.Check_SameCardID_Exist(this.txtClientID.Text))
                        {
                            Console.Beep(700, 300);
                            this.lblMessage.Text = "Same Card ID Already Exist!";
                        }
                        else
                            this.txtFirstName.Focus();
                    }
                    else
                    {
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 1U)
                            return;
                        if (this.txtClientID.Text.Length >= 8)
                        {
                            this.cmdReadCard.Enabled = true;
                            this.Check_OldGuest_Options_And_Process();
                            if (!this.Process_For_OldClientID_Data(this.txtClientID.Text))
                            {
                                this.dateTime_Auto_InsertingFlag = false;
                                Console.Beep(700, 300);
                                this.lblMessage.Text = "ClientID " + this.txtClientID.Text + " is not exist!";
                                this.txtClientID.Text = "";
                            }
                            else
                            {
                                this.Old_Client_ID = this.txtClientID.Text;
                                this.dateTimePicker_ContractStart.Enabled = true;
                                this.txtExtraDescription.Enabled = true;
                            }
                        }
                        else
                        {
                            this.lblMessage.Text = "ClientID " + this.txtClientID.Text + " is not exist!";
                            this.Reset_Controls_Value();
                        }
                    }
                }
                else if ((char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) && ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
                {
                    e.Handled = false;
                    Console.Beep(700, 100);
                    this.lblMessage.Text = "Enter Guest ID and Press Enter!";
                }
                else
                    e.Handled = true;
            }

            private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.txtSurName.Focus();
            }

            private void txtSurName_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.txtIdentity.Focus();
            }

            private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.txtNationality.Focus();
            }

            private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.txtAddress.Focus();
            }

            private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.txtContact.Focus();
                e.Handled = true;
            }

            private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != '\r')
                    return;
                this.cboSex.Focus();
            }

            private void cboSex_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r')
                    this.cboCountry.Focus();
                e.Handled = true;
            }

            private void cboCountry_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r')
                    this.textBox_Email.Focus();
                e.Handled = true;
            }

            private void txtBond_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.Filter_Keys_N_Dot(e, this.txtBond.Text);
            }

            private void txtBond_TextChanged(object sender, EventArgs e)
            {
                if (this.ChargeFrame_InsertingFlag)
                    return;
                if (this.txtBond.Text.Length > 0)
                {
                    this.Display_Others_Relative_Money(Convert.ToDecimal(this.txtCurrRoomCharge.Text));
                    this.Check_for_cmdIssue_Enable();
                }
                else
                    this.txtBond.Text = "0.00";
            }

            private void textBox_Email_Click(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Email Adress..";
            }

            private void textBox_Email_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Email Adress..";
            }

            private void textBox_Email_Leave(object sender, EventArgs e)
            {
                /*
          if (this.textBox_Email.Text.Length > 0)
          {
            try
            {
              this.lblMessage.Text = "";
              MailAddress mailAddress = new MailAddress(this.textBox_Email.Text);
            }
            catch (FormatException ex)
            {
              string message = ex.Message;
              this.lblMessage.Text = "Please enter correct email address";
              int num = (int) MessageBox.Show("Please Enter A Valid Email");
              this.textBox_Email.Focus();
              this.textBox_Email.Select();
            }
          }
          else
          {
            this.lblMessage2.Text = "";
            this.lblMessage.Text = "";
          }*/
            }

            private void txtFirstName_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter First Name..";
            }

            private void txtFirstName_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtSurName_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter SurName..";
            }

            private void txtSurName_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtIdentity_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Passport No.";
            }

            private void txtIdentity_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtNationality_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Guest's Nationality..";
            }

            private void txtNationality_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtAddress_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Address..";
            }

            private void txtAddress_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void txtContact_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Enter Contact No..";
            }

            private void txtContact_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboSex_Enter(object sender, EventArgs e) => this.lblMessage2.Text = "Select Sex..";

            private void cboSex_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void cboCountry_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "Select Country";
            }

            private void cboCountry_Leave(object sender, EventArgs e) => this.lblMessage2.Text = "";

            private void chkExtendNewCard_CheckedChanged(object sender, EventArgs e)
            {
                if (this.chkExtendNewCard.Checked)
                {
                    if (!this.chkSecond.Checked && !this.OldGuestFrame.Visible)
                        return;
                    this.txtKeyDeposit.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giKeyDeposit;
                    this.txtKeyDeposit.Visible = true;
                    this.txtCardNo.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_CardNo(true, (int)Convert.ToInt16((string)this.cboBuildingNo.SelectedItem));
                    this.lbExtraKeyCharge.Text = "Key Deposit";
                    this.lbExtraKeyCharge.Visible = true;
                    this.checkBox_Replace.Checked = false;
                    this.checkBox_Replace.Visible = true;
                }
                else
                {
                    if (!this.chkSecond.Checked && !this.OldGuestFrame.Visible)
                        return;
                    this.txtKeyDeposit.Text = "0.00";
                    this.txtKeyDeposit.Visible = false;
                    this.txtCardNo.Text = this.sOldCardNo;
                    this.lbExtraKeyCharge.Visible = false;
                    this.checkBox_Replace.Visible = false;
                }
            }

            private void chkExtendNewCard_CheckStateChanged(object sender, EventArgs e)
            {
                if (this.chkExtendNewCard.Checked)
                {
                    if (!this.chkSecond.Checked && !this.OldGuestFrame.Visible)
                        return;
                    this.txtKeyDeposit.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.giKeyDeposit;
                    this.txtKeyDeposit.Visible = true;
                }
                else
                {
                    if (!this.chkSecond.Checked && !this.OldGuestFrame.Visible)
                        return;
                    this.txtKeyDeposit.Text = "0.00";
                    this.txtKeyDeposit.Visible = false;
                }
            }

            private void chkSecond_CheckedChanged_1(object sender, EventArgs e)
            {
                if (this.chkSecond.Checked)
                {
                    this.chkExtendNewCard.Visible = true;
                    this.chkExtendNewCard.Checked = false;
                    this.checkBox_Replace.Visible = false;
                }
                else
                {
                    this.chkExtendNewCard.Visible = false;
                    this.chkExtendNewCard.Checked = false;
                    this.checkBox_Replace.Visible = false;
                }
            }

            private void chkSecond_CheckStateChanged(object sender, EventArgs e)
            {
                if (this.chkSecond.Checked)
                {
                    this.chkExtendNewCard.Visible = true;
                    this.chkExtendNewCard.Checked = false;
                    this.checkBox_Replace.Visible = false;
                }
                else
                {
                    this.chkExtendNewCard.Visible = false;
                    this.chkExtendNewCard.Checked = false;
                    this.checkBox_Replace.Visible = false;
                }
            }

            private int CheckCard(string para_ClientID, string para_Room_Num, string para_CardNo)
            {
                try
                {
                    this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                    if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
                        {
                            if (row.Card_HW_ID == Global_Data.Card_HW_ID && row.Card_AutoNumber == Global_Data.Card_AutoNumber)
                            {
                                if (row.CardNo == para_CardNo && row.RoomNo == para_Room_Num && row.ClientID == para_ClientID)
                                {
                                    if (this.chkSecond.Checked)
                                    {
                                        this.lblMessage.Text = "2nd Major Card";
                                        return 2;
                                    }
                                    this.lblMessage.Text = "Major Card";
                                    return 1;
                                }
                                if (row.RoomNo == para_Room_Num && row.ClientID == para_ClientID && row.CardStatus == (byte)1)
                                {
                                    this.lblMessage.Text = "Spare Card";
                                    return 3;
                                }
                            }
                        }
                        //this.lblMessage.Text = "Invalid Card!";
                        return 0;
                    }
                    //.lblMessage.Text = "Invalid Card!";
                    return 0;
                }
                catch
                {
                    this.lblMessage.Text = "Building Database Error!";
                    return -1;
                }
            }

            private string CheckCard_and_FindGuestRoom(string para_Card_HW_ID, string para_Card_AutoNumber)
            {
                try
                {
                    this.db.building_DB1.cardNoTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardNo);
                    if (this.db.building_DB1.buildingDB1DataSet.CardNo.Rows.Count > 0)
                    {
                        foreach (BuildingDB1DataSet.CardNoRow row in (InternalDataCollectionBase)this.db.building_DB1.buildingDB1DataSet.CardNo.Rows)
                        {
                            if (row.Card_HW_ID == para_Card_HW_ID && row.Card_AutoNumber == para_Card_AutoNumber)
                                return row.ClientID;
                        }
                        //this.lblMessage.Text = "Invalid Card!";
                        return "";
                    }
                    this.lblMessage.Text = "Invalid Card!";
                    return "";
                }
                catch
                {
                    this.lblMessage.Text = "Building Database Error!";
                    return "";
                }
            }

            private void cmdReadCard_Click(object sender, EventArgs e)
            {
                this.lblMessage.Text = "";
                this.Spare_Card_Scanned_Flag = true;
                this.lblMessage.Refresh();
                this.cmdIssue.Enabled = true;
                if (this.Check_Empty_Card())
                {
                    if (SmartCard_Procedures.ReadCardID((int)Global_Data.COM_NUM))
                    {
                        Global_Data.Card_HW_ID = SmartCard_Procedures.Card_ID_String;
                        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                        {
                            if (this.cmdIssue_Ready_Flag)
                            {
                                this.cmdIssue.Enabled = true;
                                this.lblMessage.Text = "New Card! Ready to issue!";
                            }
                            else
                            {
                                this.cmdIssue.Enabled = false;
                                this.lblMessage.Text = "New Card!";
                            }
                        }
                        else if (gCardProperty.LossLog == 1 || this._optOldGuest_1.Checked || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest > 1U || this.bSecond && this.chkSecond.Checked)
                        {
                            if (this.cmdIssue_Ready_Flag)
                            {
                                this.cmdIssue.Enabled = true;
                                this.lblMessage.Text = "New Card! Ready to issue!";
                            }
                            else
                                this.lblMessage.Text = "New Card";
                        }
                        else if (this._optOldGuest_3.Checked && this.chkExtendNewCard.Checked)
                        {
                            if (this.cmdIssue_Ready_Flag)
                            {
                                this.cmdIssue.Enabled = true;
                                this.lblMessage.Text = "New Card! Click Issue Key to Comfirm Extension ... ";
                            }
                            else
                                this.lblMessage.Text = "New Card";
                        }
                        else
                            this.lblMessage.Text = "New Card";
                    }
                    else
                    {
                        int num1 = (int)MessageBox.Show("Can not read Card ID!");
                    }
                }
                else if (SmartCard_Procedures.ReadCardID((int)Global_Data.COM_NUM))
                {
                    Global_Data.Card_HW_ID = SmartCard_Procedures.Card_ID_String;
                    Global_Data.Card_AutoNumber = "";
                    if (SmartCard_Procedures.ReadCardNumber((int)Global_Data.COM_NUM))
                        Global_Data.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
                    if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 2U || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 3U)
                    {
                        this.cmdIssue.Enabled = true;
                        this.lblMessage.Text = "Not New Card! Insert New Card to issue New Key Card. " +
                                      "Or go an recyle the card in Admin";

                    }
                    else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest == 1U)
                    {
                        string str1 = SmartCard_Procedures.Card_Information_String.Substring(30, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(32, 2) + "-" + SmartCard_Procedures.Card_Information_String.Substring(34, 2);
                        if (this._optOldGuest_0.Checked && this.bSecond && this.chkSecond.Checked)
                        {
                            if (this.cmdIssue_Ready_Flag)
                                this.lblMessage.Text = "Insert New Card to issue Second Key Card.";
                            else
                                this.lblMessage.Text = "Not New Card to issue Second Key Card!";
                        }
                        else if (this._optOldGuest_3.Checked && this.chkExtendNewCard.Checked)
                        {
                            if (this.cmdIssue_Ready_Flag)
                                this.lblMessage.Text = "Insert New Card to issue Key Extension";
                            else
                                this.lblMessage.Text = "Not New Card to issue Key Extension!";
                        }
                        else if (this._optOldGuest_1.Checked)
                        {
                            if (this.cmdIssue_Ready_Flag)
                                this.lblMessage.Text = "Insert New Card to issue Spare Card";
                            else
                                this.lblMessage.Text = "Not New Card to issue Spare Card!";
                        }
                        else if (this.txtClientID.Text.Length == 8)
                        {
                            int num2 = this.CheckCard(this.txtClientID.Text, this.lblRoomNo.Text, this.txtCardNo.Text);
                            if (this._optOldGuest_3.Checked)
                            {
                                if (this._optOldGuest_3.Checked && (num2 == 1 || num2 == 2))
                                {
                                    this.dateTimePicker_ValidEnd.Enabled = true;
                                    this.dateTimePicker_ContractStart.Enabled = true;
                                    this.dateTimePicker_ContractEnd.Enabled = true;
                                    if (this.cmdIssue_Ready_Flag)
                                    {
                                        if (num2 == 1)
                                            this.lblMessage.Text = "Ready To Extend Major Card!";
                                        else
                                            this.lblMessage.Text = "Ready To Extend 2nd Major Card!";
                                        Console.Beep(700, 300);
                                        this.ChargesFrame.Enabled = false;
                                        this.OldGuestFrame.Enabled = false;
                                        gClientProperty.Card_AutoNumber = Global_Data.Card_AutoNumber;
                                        gClientProperty.Card_HW_ID = Global_Data.Card_HW_ID;
                                        this.cmdIssue.Enabled = true;
                                        this.cmdReadCard.Enabled = false;
                                    }
                                    else
                                    {
                                        if (num2 == 1)
                                            this.lblMessage.Text = "Major Card!";
                                        else
                                            this.lblMessage.Text = "2nd Major Card!";
                                        this.lblMessage.Refresh();
                                        Console.Beep(700, 300);
                                        Thread.Sleep(500);
                                        Console.Beep(700, 300);
                                        this.lblMessage.Text = "Pls. Top Up for Amount Due!";
                                        this.txtReceived.Select();
                                        this.cmdIssue.Enabled = false;
                                    }
                                }
                                else if (this._optOldGuest_3.Checked && num2 == 3)
                                {
                                    string spareCardCardNo = this.Get_Spare_Card_CardNo(this.txtClientID.Text);
                                    if (spareCardCardNo.Length == 5)
                                    {
                                        string str2 = this.Old_Client_CheckOut_Date.ToShortDateString().Substring(2);
                                        if (str1 != str2)
                                        {
                                            this.dateTimePicker_ValidStart.Value = this.Old_Client_Valid_StartDate;
                                            this.dateTimePicker_ValidEnd.Value = this.Old_Client_Valid_EndDate;
                                            this.dateTimePicker_CheckOutDate.Value = this.Old_Client_CheckOut_Date;
                                            this.Spare_Card_Scanned_Flag = true;
                                            this.Select_For_Spare_Card_Extension(this.txtClientID.Text);
                                            Decimal num3 = Convert.ToDecimal(this.txtDisplayAmount.Text);
                                            Decimal num4 = Convert.ToDecimal(this.txtReceived.Text);
                                            if (num4 > 0M && num4 > num3)
                                            {
                                                this.lblMessage.Text = "No Need To Pay for Spare Card";
                                                Console.Beep(700, 300);
                                                this.txtReceived.Select();
                                            }
                                            else
                                            {
                                                Global_Data.NewDate_NewCheckIn_FirstPerson_Flag = false;
                                                this.lblMessage.Text = "Spare Card! Ready to Extend";
                                                this.ChargesFrame.Enabled = false;
                                                this.OldGuestFrame.Enabled = false;
                                                this.txtCardNo.Text = spareCardCardNo;
                                                gClientProperty.Card_AutoNumber = Global_Data.Card_AutoNumber;
                                                gClientProperty.Card_HW_ID = Global_Data.Card_HW_ID;
                                                this.cmdIssue.Enabled = true;
                                                this.cmdReadCard.Enabled = false;
                                            }
                                        }
                                        else
                                        {
                                            this._optOldGuest_0.Checked = true;
                                            this.lblMessage.Text = "Spare Card has same Date as Major";
                                            this.lblMessage.Refresh();
                                            Console.Beep(700, 300);
                                            Console.Beep(700, 300);
                                            Thread.Sleep(500);
                                            this.lblMessage.Text = "Major Card must be extended fisrt!";
                                        }
                                    }
                                    else
                                        this.lblMessage.Text = "Invalid Spare Card No!";
                                }
                                else
                                {
                                    this.dateTimePicker_ValidEnd.Enabled = false;
                                    this.dateTimePicker_ContractStart.Enabled = false;
                                    this.lblMessage.Text = "Invalid Card to Extend!";
                                    this.cmdIssue.Enabled = false;
                                }
                            }
                            else if (this._optOldGuest_0.Checked && (num2 == 1 || num2 == 2 || num2 == 3))
                            {
                                switch (num2)
                                {
                                    case 1:
                                        if (!this.chkSecond.Checked)
                                        {
                                            this.lblMessage.Text = "Major Card of This Person!";
                                            break;
                                        }
                                        Console.Beep(700, 300);
                                        this.lblMessage.Text = "Major Card of 1st Person!";
                                        break;
                                    case 2:
                                        if (!this.chkSecond.Checked)
                                        {
                                            Console.Beep(700, 300);
                                            this.lblMessage.Text = "Major Card of 2nd Person";
                                            break;
                                        }
                                        this.lblMessage.Text = "Major Card of this 2nd person!";
                                        break;
                                    case 3:
                                        this.lblMessage.Text = "Spare Card! CardNo: " + this.Get_Spare_Card_CardNo(this.txtClientID.Text);
                                        break;
                                }
                            }
                            else
                                this.lblMessage.Text = "Invalid Card for this Person";
                        }
                        else
                        {
                            this.txtClientID.Text = this.CheckCard_and_FindGuestRoom(Global_Data.Card_HW_ID, Global_Data.Card_AutoNumber);
                            if (this.txtClientID.Text.Length >= 8)
                            {
                                this.cmdReadCard.Enabled = true;
                                this.Check_OldGuest_Options_And_Process();
                                if (!this.Process_For_OldClientID_Data(this.txtClientID.Text))
                                {
                                    this.dateTime_Auto_InsertingFlag = false;
                                    Console.Beep(700, 300);
                                    this.lblMessage.Text = "ClientID " + this.txtClientID.Text + " is not exist!";
                                    this.txtClientID.Text = "";
                                }
                                else
                                {
                                    this.Old_Client_ID = this.txtClientID.Text;
                                    this.dateTimePicker_ContractStart.Enabled = true;
                                    this.txtExtraDescription.Enabled = true;
                                    int num5 = this.CheckCard(this.txtClientID.Text, this.lblRoomNo.Text, this.txtCardNo.Text);
                                    if (!this._optOldGuest_0.Checked || num5 != 1 && num5 != 2 && num5 != 3)
                                        return;
                                    switch (num5)
                                    {
                                        case 1:
                                            if (!this.chkSecond.Checked)
                                            {
                                                this.lblMessage.Text = "Major Card of This Person!";
                                                break;
                                            }
                                            Console.Beep(700, 300);
                                            this.lblMessage.Text = "Major Card of 1st Person!";
                                            break;
                                        case 2:
                                            if (!this.chkSecond.Checked)
                                            {
                                                Console.Beep(700, 300);
                                                this.lblMessage.Text = "Major Card of 2nd Person";
                                                break;
                                            }
                                            this.lblMessage.Text = "Major Card of this 2nd person!";
                                            break;
                                        case 3:
                                            this.lblMessage.Text = "Spare Card! CardNo: " + this.Get_Spare_Card_CardNo(this.txtClientID.Text);
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                this.lblMessage.Text = "ClientID " + this.txtClientID.Text + " is not exist!";
                                this.Reset_Controls_Value();
                            }
                        }
                    }
                    else
                        this.lblMessage.Text = "Not New Card!";
                }
                else
                    this.lblMessage.Text = "No Card Found!";
            }

            private void _txtDesExtra_0_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.lblMessage.Text = "Click OK after finish!";
                if (e.KeyChar != '\r')
                    return;
                this._txtExtraAmount_0.Select();
                this._txtExtraAmount_0.Focus();
                e.Handled = true;
            }

            private void _txtDesExtra_1_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.lblMessage.Text = "Click OK after finish!";
                if (e.KeyChar != '\r')
                    return;
                this._txtExtraAmount_1.Select();
                this._txtExtraAmount_1.Focus();
                e.Handled = true;
            }

            private void _txtDesExtra_2_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.lblMessage.Text = "Click OK after finish!";
                if (e.KeyChar != '\r')
                    return;
                this._txtExtraAmount_2.Select();
                this._txtExtraAmount_2.Focus();
                e.Handled = true;
            }

            private void _txtDesExtra_3_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.lblMessage.Text = "Click OK after finish!";
                if (e.KeyChar != '\r')
                    return;
                this._txtExtraAmount_3.Select();
                this._txtExtraAmount_3.Focus();
                e.Handled = true;
            }

            private void _txtDesExtra_4_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.lblMessage.Text = "Click OK after finish!";
                if (e.KeyChar != '\r')
                    return;
                this._txtExtraAmount_4.Select();
                this._txtExtraAmount_4.Focus();
                e.Handled = true;
            }

            private void ExtraChargeFrame_Enter_Process()
            {
                int num = this.ExtraChargeFrame.Visible ? 1 : 0;
            }

            private void ExtraChargeFrame_Exit_Process()
            {
            }

            private void ExtraChargeFrame_Enter(object sender, EventArgs e)
            {
                this.ExtraChargeFrame_Enter_Process();
            }

            private void txtCheckInDate_Leave(object sender, EventArgs e)
            {
                if (this.txtCheckInDate.Text.Length != 10)
                {
                    int num = (int)MessageBox.Show("Invalid Check In Date! Date Format must be \"YYYY-MM-DD\"");
                    if (this.Old_CheckIn_Date.Length == 10)
                        this.txtCheckInDate.Text = this.Old_CheckIn_Date;
                }
                if (DateTime.Parse(this.txtCheckInDate.Text).CompareTo(this.dateTimePicker_ContractStart.Value) < 0)
                {
                    int num = (int)MessageBox.Show("Invalid Check In Date! Check In Date may not earlier than Contract Start");
                    if (this.Old_CheckIn_Date.Length == 10)
                        this.txtCheckInDate.Text = this.Old_CheckIn_Date;
                }
                if (DateTime.Parse(this.txtCheckInDate.Text).CompareTo(this.dateTimePicker_ContractEnd.Value) <= 0)
                    return;
                int num1 = (int)MessageBox.Show("Invalid Check In Date! Check In Date may not later than Contract End");
                if (this.Old_CheckIn_Date.Length != 10)
                    return;
                this.txtCheckInDate.Text = this.Old_CheckIn_Date;
            }

            private void checkBox_Replace_CheckedChanged(object sender, EventArgs e)
            {
                if (!this.checkBox_Replace.Visible)
                    return;
                if (this.checkBox_Replace.Checked)
                {
                    if (this._optOldGuest_1.Checked)
                    {
                        this.backup_txtKeyDeposit = this.txtExtraKeyCharge.Text;
                        this.txtExtraKeyCharge.Text = "0.00";
                    }
                    else
                    {
                        this.backup_txtKeyDeposit = this.txtKeyDeposit.Text;
                        this.txtKeyDeposit.Text = "0.00";
                    }
                }
                else if (this._optOldGuest_1.Checked)
                    this.txtExtraKeyCharge.Text = this.backup_txtKeyDeposit;
                else
                    this.txtKeyDeposit.Text = this.backup_txtKeyDeposit;
            }

            private void Timer1_Tick(object sender, EventArgs e)
            {
                if (!this.bool_Invalid_Date_Error)
                    return;
                if (this.TimeOut_Message_Cnt > 0)
                {
                    --this.TimeOut_Message_Cnt;
                }
                else
                {
                    this.bool_Invalid_Date_Error = false;
                    this.lblMessage2.Text = "";
                    this.lblMessage2.Refresh();
                    this.Timer1.Stop();
                    this.lblMessage2.ForeColor = System.Drawing.Color.Blue;
                }
            }

            private void dateTimePicker_ValidStart_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
                this.dateTimePicker_ValidStart.MaxDate = this.dateTimePicker_ValidEnd.Value;
                this.dateTimePicker_ValidStart.Update();
                this.dateTimePicker_ValidStart.Refresh();
                this.dateTimePicker_ValidStart.ResumeLayout();
                this.Old_Valid_Start_Date = this.dateTimePicker_ValidStart.Value;
            }

            private void dateTimePicker_ValidStart_DropDown(object sender, EventArgs e)
            {
                this.Old_Valid_Start_Date = this.dateTimePicker_ValidStart.Value;
                this.dateTime_Auto_InsertingFlag = false;
            }

            private void dateTimePicker_ValidStart_CloseUp(object sender, EventArgs e)
            {
                if (this.dateTimePicker_ValidEnd.Value.Date.ToShortDateString() == this.dateTimePicker_ValidStart.Value.Date.ToShortDateString())
                {
                    this.dateTimePicker_ValidStart.Value = this.dateTimePicker_ValidEnd.Value.AddDays(-1.0);
                    if (!this.bool_Invalid_Date_Error)
                    {
                        this.bool_Invalid_Date_Error = true;
                        this.TimeOut_Message_Cnt = 3;
                        this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                        this.lblMessage2.Text = "Can Not Select Start Date Same As End Date!";
                        this.lblMessage2.Refresh();
                        SystemSounds.Exclamation.Play();
                        this.Timer1.Start();
                        this.dateTimePicker_ValidStart.MaxDate = this.dateTimePicker_ValidEnd.Value;
                        this.dateTimePicker_ValidStart.Update();
                        this.dateTimePicker_ValidStart.Refresh();
                        this.dateTimePicker_ValidStart.ResumeLayout();
                    }
                }
                if (this.dateTimePicker_ValidStart.Value.CompareTo(this.dateTimePicker_ContractStart.Value) >= 0)
                    return;
                this.dateTimePicker_ContractStart.Value = this.dateTimePicker_ValidStart.Value;
            }

            private void dateTimePicker_ValidEnd_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
                this.dateTimePicker_ValidEnd.MinDate = this.dateTimePicker_ValidStart.Value;
                this.dateTimePicker_ValidEnd.Update();
                this.dateTimePicker_ValidEnd.Refresh();
                this.dateTimePicker_ValidEnd.ResumeLayout();
                this.Old_Valid_End_Date = this.dateTimePicker_ValidEnd.Value;
            }

            private void dateTimePicker_ValidEnd_DropDown(object sender, EventArgs e)
            {
                this.Old_Valid_End_Date = this.dateTimePicker_ValidEnd.Value;
                this.dateTime_Auto_InsertingFlag = false;
            }

            private void dateTimePicker_ValidEnd_CloseUp(object sender, EventArgs e)
            {
                if (this.dateTimePicker_ValidEnd.Value.Date.ToShortDateString() == this.dateTimePicker_ValidStart.Value.Date.ToShortDateString())
                {
                    this.dateTimePicker_ValidEnd.Value = this.dateTimePicker_ValidStart.Value.AddDays(1.0);
                    if (!this.bool_Invalid_Date_Error)
                    {
                        this.bool_Invalid_Date_Error = true;
                        this.TimeOut_Message_Cnt = 3;
                        this.lblMessage2.ForeColor = System.Drawing.Color.Red;
                        this.lblMessage2.Text = "Can Not Select End Date Same As Start Date!";
                        this.lblMessage2.Refresh();
                        SystemSounds.Exclamation.Play();
                        this.Timer1.Start();
                        this.dateTimePicker_ValidEnd.MinDate = this.dateTimePicker_ValidStart.Value;
                        this.dateTimePicker_ValidEnd.Update();
                        this.dateTimePicker_ValidEnd.Refresh();
                        this.dateTimePicker_ValidEnd.ResumeLayout();
                    }
                }
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iGuest != 1U || !this._optOldGuest_3.Checked || this.dateTimePicker_ValidEnd.Value.CompareTo(this.dateTimePicker_ContractEnd.Value) <= 0)
                    return;
                this.dateTimePicker_ContractEnd.Value = this.dateTimePicker_ValidEnd.Value;
            }

            private void dateTimePicker_ContractStart_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
                this.dateTimePicker_ContractStart.MaxDate = this.dateTimePicker_ValidStart.Value.Date;
                this.Old_Contract_Start = this.dateTimePicker_ContractStart.Value;
            }

            private void dateTimePicker_ContractStart_DropDown(object sender, EventArgs e)
            {
                this.Old_Contract_Start = this.dateTimePicker_ContractStart.Value;
                this.dateTimePicker_ContractStart.MaxDate = this.dateTimePicker_ValidStart.Value.Date;
                this.dateTime_Auto_InsertingFlag = false;
            }

            private void dateTimePicker_ContractStart_CloseUp(object sender, EventArgs e)
            {
                if (this.dateTimePicker_ValidStart.Value.CompareTo(this.dateTimePicker_ContractStart.Value) >= 0)
                    return;
                int num = (int)MessageBox.Show("Contract Start Date Can Not Be Later Than Valid Start Date!");
                try
                {
                    this.dateTimePicker_ContractStart.Value = this.Old_Contract_Start;
                }
                catch
                {
                    this.dateTimePicker_ContractStart.Value = this.dateTimePicker_ValidStart.Value;
                }
            }

            private void dateTimePicker_ContractEnd_Enter(object sender, EventArgs e)
            {
                this.lblMessage2.Text = "";
                this.Old_Contract_End = this.dateTimePicker_ContractEnd.Value;
                this.dateTimePicker_ContractEnd.MinDate = this.dateTimePicker_ValidEnd.Value.Date;
            }

            private void dateTimePicker_ContractEnd_DropDown(object sender, EventArgs e)
            {
                this.Old_Contract_End = this.dateTimePicker_ContractEnd.Value;
                this.dateTimePicker_ContractEnd.MinDate = this.dateTimePicker_ValidEnd.Value.Date;
                this.dateTime_Auto_InsertingFlag = false;
            }

            private void dateTimePicker_ContractEnd_CloseUp(object sender, EventArgs e)
            {
            }

            private void dateTimePicker_CheckInTime_DropDown(object sender, EventArgs e)
            {
                try
                {
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                }
                catch
                {
                }
                try
                {
                    string shortTimeString = this.dateTimePicker_CheckInTime.Value.ToShortTimeString();
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse(this.txtCheckInDate.Text + " 00:00:00");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse(this.txtCheckInDate.Text + " 23:59:59");
                    this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + shortTimeString);
                }
                catch
                {
                }
            }

            private void dateTimePicker_CheckInTime_Enter(object sender, EventArgs e)
            {
                try
                {
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                }
                catch
                {
                }
                try
                {
                    string shortTimeString = this.dateTimePicker_CheckInTime.Value.ToShortTimeString();
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse(this.txtCheckInDate.Text + " 00:00:00");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse(this.txtCheckInDate.Text + " 23:59:59");
                    this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + shortTimeString);
                }
                catch
                {
                }
            }

            private void txtCheckInDate_TextChanged(object sender, EventArgs e)
            {
                if (this.txtCheckInDate.Text.Length != 10)
                    return;
                try
                {
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse("1753-01-01");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse("9998-12-31");
                }
                catch
                {
                }
                try
                {
                    string shortTimeString = this.dateTimePicker_CheckInTime.Value.ToShortTimeString();
                    this.dateTimePicker_CheckInTime.MinDate = DateTime.Parse(this.txtCheckInDate.Text + " 00:00:00");
                    this.dateTimePicker_CheckInTime.MaxDate = DateTime.Parse(this.txtCheckInDate.Text + " 23:59:59");
                    this.dateTimePicker_CheckInTime.Value = DateTime.Parse(this.txtCheckInDate.Text + " " + shortTimeString);
                }
                catch
                {
                }
            }
        
    

    private void dateTimePicker_CheckInTime_CloseUp(object sender, EventArgs e)
    {
    }

    private void dateTimePicker_CheckInTime_Leave(object sender, EventArgs e)
    {
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
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtNoOfMonth = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtReserve = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtNoOfWeek = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this._Label7_0 = new System.Windows.Forms.Label();
            this.txtEarlyStart = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label14 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDiffBond = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.lbEarlyStart = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.LabelRoom = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lbCardType = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.lbNoOfDays = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this._optOldGuest_3 = new System.Windows.Forms.RadioButton();
            this.UnitFrame2 = new System.Windows.Forms.GroupBox();
            this.cmdUnitKey = new System.Windows.Forms.Button();
            this.ExtraChargeFrame = new System.Windows.Forms.GroupBox();
            this._txtDesExtra_0 = new System.Windows.Forms.TextBox();
            this._txtExtraAmount_0 = new System.Windows.Forms.TextBox();
            this._txtDesExtra_1 = new System.Windows.Forms.TextBox();
            this._txtExtraAmount_1 = new System.Windows.Forms.TextBox();
            this._txtExtraAmount_2 = new System.Windows.Forms.TextBox();
            this._txtExtraAmount_3 = new System.Windows.Forms.TextBox();
            this._txtExtraAmount_4 = new System.Windows.Forms.TextBox();
            this._txtDesExtra_2 = new System.Windows.Forms.TextBox();
            this._txtDesExtra_3 = new System.Windows.Forms.TextBox();
            this._txtDesExtra_4 = new System.Windows.Forms.TextBox();
            this.txtExtraTotal = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.lblExtraTotal = new System.Windows.Forms.Label();
            this.ChargesFrame = new System.Windows.Forms.GroupBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtBond = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.txtToCollect = new System.Windows.Forms.TextBox();
            this.txtCurrRoomCharge = new System.Windows.Forms.TextBox();
            this.txtExtraDescription = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtKeyDeposit = new System.Windows.Forms.TextBox();
            this.txtDisplayAmount = new System.Windows.Forms.TextBox();
            this.txtDiffBond = new System.Windows.Forms.TextBox();
            this.chkBondDiff = new System.Windows.Forms.CheckBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.lbExtraKeyCharge = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.lbPrevious = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.txtExtraKeyCharge = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.OldGuestFrame = new System.Windows.Forms.Panel();
            this.checkBox_Replace = new System.Windows.Forms.CheckBox();
            this.chkExtendNewCard = new System.Windows.Forms.CheckBox();
            this._optOldGuest_1 = new System.Windows.Forms.RadioButton();
            this._optOldGuest_0 = new System.Windows.Forms.RadioButton();
            this.cmdLoss = new System.Windows.Forms.Button();
            this._optOldGuest_2 = new System.Windows.Forms.RadioButton();
            this.txtReservationRef = new System.Windows.Forms.TextBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            this.cboChargeType = new System.Windows.Forms.ComboBox();
            this.RegistrationFrame = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.dateTimePicker_CheckInTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ValidEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ValidStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ContractEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ContractStart = new System.Windows.Forms.DateTimePicker();
            this.txtIssuedCard = new System.Windows.Forms.TextBox();
            this.cboBuildingNo = new System.Windows.Forms.ComboBox();
            this.StayingPeopleFrame = new System.Windows.Forms.GroupBox();
            this.chkSecond = new System.Windows.Forms.CheckBox();
            this._optPeople_1 = new System.Windows.Forms.RadioButton();
            this._optPeople_0 = new System.Windows.Forms.RadioButton();
            this.Label32 = new System.Windows.Forms.Label();
            this.UnitFrame = new System.Windows.Forms.GroupBox();
            this.txtUnitNo = new System.Windows.Forms.TextBox();
            this._optUnit_1 = new System.Windows.Forms.RadioButton();
            this._optUnit_0 = new System.Windows.Forms.RadioButton();
            this.cboUnitNo = new System.Windows.Forms.ComboBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.ClientFrame = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.cmdViewReserveList = new System.Windows.Forms.Button();
            this.cmdViewClient = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdReservedGuest = new System.Windows.Forms.Button();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdOld = new System.Windows.Forms.Button();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdIssue = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.pictureBox_pdf = new System.Windows.Forms.PictureBox();
            this.cmdReadCard = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtFloorBuildingValue = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.buildingValue = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ExtraChargeFrame.SuspendLayout();
            this.ChargesFrame.SuspendLayout();
            this.OldGuestFrame.SuspendLayout();
            this.RegistrationFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StayingPeopleFrame.SuspendLayout();
            this.UnitFrame.SuspendLayout();
            this.ClientFrame.SuspendLayout();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pdf)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCountry
            // 
            this.cboCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboCountry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCountry.Location = new System.Drawing.Point(376, 133);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCountry.Size = new System.Drawing.Size(105, 22);
            this.cboCountry.TabIndex = 9;
            this.cboCountry.Click += new System.EventHandler(this.cboCountry_Click);
            this.cboCountry.Enter += new System.EventHandler(this.cboCountry_Enter);
            this.cboCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCountry_KeyPress);
            this.cboCountry.Leave += new System.EventHandler(this.cboCountry_Leave);
            // 
            // txtCountry
            // 
            this.txtCountry.AcceptsReturn = true;
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCountry.Location = new System.Drawing.Point(480, 133);
            this.txtCountry.MaxLength = 0;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.Size = new System.Drawing.Size(25, 20);
            this.txtCountry.TabIndex = 80;
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountry.Visible = false;
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemark.Location = new System.Drawing.Point(104, 224);
            this.txtRemark.MaxLength = 40;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemark.Size = new System.Drawing.Size(217, 29);
            this.txtRemark.TabIndex = 18;
            this.txtRemark.Enter += new System.EventHandler(this.txtRemark_Enter);
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.AcceptsReturn = true;
            this.txtNoOfDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoOfDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfDays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfDays.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoOfDays.Location = new System.Drawing.Point(292, 148);
            this.txtNoOfDays.MaxLength = 3;
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.ReadOnly = true;
            this.txtNoOfDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoOfDays.Size = new System.Drawing.Size(41, 20);
            this.txtNoOfDays.TabIndex = 39;
            this.txtNoOfDays.Text = "1";
            this.txtNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContact
            // 
            this.txtContact.AcceptsReturn = true;
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContact.Location = new System.Drawing.Point(376, 88);
            this.txtContact.MaxLength = 20;
            this.txtContact.Name = "txtContact";
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContact.Size = new System.Drawing.Size(177, 26);
            this.txtContact.TabIndex = 7;
            this.txtContact.Click += new System.EventHandler(this.txtContact_Click);
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.Enter += new System.EventHandler(this.txtContact_Enter);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.AcceptsReturn = true;
            this.txtGracePeriod.BackColor = System.Drawing.SystemColors.Window;
            this.txtGracePeriod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGracePeriod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracePeriod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGracePeriod.Location = new System.Drawing.Point(290, 119);
            this.txtGracePeriod.MaxLength = 0;
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.ReadOnly = true;
            this.txtGracePeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGracePeriod.Size = new System.Drawing.Size(41, 21);
            this.txtGracePeriod.TabIndex = 16;
            this.txtGracePeriod.Text = "0";
            this.txtGracePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGracePeriod.Enter += new System.EventHandler(this.txtGracePeriod_Enter);
            // 
            // txtNationality
            // 
            this.txtNationality.AcceptsReturn = true;
            this.txtNationality.BackColor = System.Drawing.SystemColors.Window;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNationality.Location = new System.Drawing.Point(376, 56);
            this.txtNationality.MaxLength = 20;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationality.Size = new System.Drawing.Size(177, 26);
            this.txtNationality.TabIndex = 5;
            this.txtNationality.Click += new System.EventHandler(this.txtNationality_Click);
            this.txtNationality.TextChanged += new System.EventHandler(this.txtNationality_TextChanged);
            this.txtNationality.Enter += new System.EventHandler(this.txtNationality_Enter);
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationality_KeyPress);
            this.txtNationality.Leave += new System.EventHandler(this.txtNationality_Leave);
            // 
            // txtSurName
            // 
            this.txtSurName.AcceptsReturn = true;
            this.txtSurName.BackColor = System.Drawing.Color.White;
            this.txtSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSurName.Location = new System.Drawing.Point(376, 32);
            this.txtSurName.MaxLength = 20;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurName.Size = new System.Drawing.Size(177, 26);
            this.txtSurName.TabIndex = 3;
            this.txtSurName.Click += new System.EventHandler(this.txtSurName_Click);
            this.txtSurName.TextChanged += new System.EventHandler(this.txtSurName_TextChanged);
            this.txtSurName.Enter += new System.EventHandler(this.txtSurName_Enter);
            this.txtSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurName_KeyPress);
            this.txtSurName.Leave += new System.EventHandler(this.txtSurName_Leave);
            // 
            // txtCardNo
            // 
            this.txtCardNo.AcceptsReturn = true;
            this.txtCardNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.ForeColor = System.Drawing.Color.Red;
            this.txtCardNo.Location = new System.Drawing.Point(488, 220);
            this.txtCardNo.MaxLength = 0;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCardNo.Size = new System.Drawing.Size(81, 20);
            this.txtCardNo.TabIndex = 32;
            this.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoOfMonth
            // 
            this.txtNoOfMonth.AcceptsReturn = true;
            this.txtNoOfMonth.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoOfMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfMonth.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoOfMonth.Location = new System.Drawing.Point(292, 148);
            this.txtNoOfMonth.MaxLength = 2;
            this.txtNoOfMonth.Name = "txtNoOfMonth";
            this.txtNoOfMonth.ReadOnly = true;
            this.txtNoOfMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoOfMonth.Size = new System.Drawing.Size(41, 20);
            this.txtNoOfMonth.TabIndex = 29;
            this.txtNoOfMonth.Text = "1";
            this.txtNoOfMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRoomType
            // 
            this.txtRoomType.AcceptsReturn = true;
            this.txtRoomType.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRoomType.Location = new System.Drawing.Point(144, 16);
            this.txtRoomType.MaxLength = 0;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRoomType.Size = new System.Drawing.Size(17, 20);
            this.txtRoomType.TabIndex = 57;
            this.txtRoomType.Visible = false;
            // 
            // txtReserve
            // 
            this.txtReserve.AcceptsReturn = true;
            this.txtReserve.BackColor = System.Drawing.SystemColors.Window;
            this.txtReserve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReserve.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserve.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReserve.Location = new System.Drawing.Point(408, 8);
            this.txtReserve.MaxLength = 0;
            this.txtReserve.Name = "txtReserve";
            this.txtReserve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReserve.Size = new System.Drawing.Size(25, 22);
            this.txtReserve.TabIndex = 63;
            this.txtReserve.Text = "R-";
            this.txtReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.SystemColors.Window;
            this.cboSex.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboSex.Location = new System.Drawing.Point(376, 112);
            this.cboSex.Name = "cboSex";
            this.cboSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSex.Size = new System.Drawing.Size(41, 22);
            this.cboSex.TabIndex = 8;
            this.cboSex.Text = "M";
            this.cboSex.Click += new System.EventHandler(this.cboSex_Click);
            this.cboSex.Enter += new System.EventHandler(this.cboSex_Enter);
            this.cboSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSex_KeyPress);
            this.cboSex.Leave += new System.EventHandler(this.cboSex_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(112, 32);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(169, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtIdentity
            // 
            this.txtIdentity.AcceptsReturn = true;
            this.txtIdentity.BackColor = System.Drawing.Color.White;
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdentity.Location = new System.Drawing.Point(112, 60);
            this.txtIdentity.MaxLength = 20;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentity.Size = new System.Drawing.Size(169, 26);
            this.txtIdentity.TabIndex = 4;
            this.txtIdentity.Click += new System.EventHandler(this.txtIdentity_Click);
            this.txtIdentity.TextChanged += new System.EventHandler(this.txtIdentity_TextChanged);
            this.txtIdentity.Enter += new System.EventHandler(this.txtIdentity_Enter);
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_KeyPress);
            this.txtIdentity.Leave += new System.EventHandler(this.txtIdentity_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(112, 88);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(169, 60);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(8, 8);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(97, 17);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Guest ID ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(8, 32);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(97, 17);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "First Name ";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(288, 32);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(81, 17);
            this.Label5.TabIndex = 67;
            this.Label5.Text = "SurName";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNoOfWeek
            // 
            this.txtNoOfWeek.AcceptsReturn = true;
            this.txtNoOfWeek.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoOfWeek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfWeek.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfWeek.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoOfWeek.Location = new System.Drawing.Point(292, 146);
            this.txtNoOfWeek.MaxLength = 2;
            this.txtNoOfWeek.Name = "txtNoOfWeek";
            this.txtNoOfWeek.ReadOnly = true;
            this.txtNoOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoOfWeek.Size = new System.Drawing.Size(41, 21);
            this.txtNoOfWeek.TabIndex = 52;
            this.txtNoOfWeek.Text = "1";
            this.txtNoOfWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoOfWeek.Enter += new System.EventHandler(this.txtNoOfWeek_Enter);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(288, 112);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(81, 17);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "Sex ";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label7_0
            // 
            this._Label7_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Label7_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label7_0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label7_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Label7_0.Location = new System.Drawing.Point(8, 60);
            this._Label7_0.Name = "_Label7_0";
            this._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label7_0.Size = new System.Drawing.Size(97, 17);
            this._Label7_0.TabIndex = 65;
            this._Label7_0.Text = "Passport No. ";
            this._Label7_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEarlyStart
            // 
            this.txtEarlyStart.AcceptsReturn = true;
            this.txtEarlyStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtEarlyStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEarlyStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEarlyStart.ForeColor = System.Drawing.Color.Blue;
            this.txtEarlyStart.Location = new System.Drawing.Point(488, 156);
            this.txtEarlyStart.MaxLength = 0;
            this.txtEarlyStart.Name = "txtEarlyStart";
            this.txtEarlyStart.ReadOnly = true;
            this.txtEarlyStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEarlyStart.Size = new System.Drawing.Size(41, 21);
            this.txtEarlyStart.TabIndex = 53;
            this.txtEarlyStart.Text = "0";
            this.txtEarlyStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(288, 56);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(81, 17);
            this.Label8.TabIndex = 64;
            this.Label8.Text = "Nationality ";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.AcceptsReturn = true;
            this.txtCheckInDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtCheckInDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckInDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCheckInDate.Location = new System.Drawing.Point(104, 172);
            this.txtCheckInDate.MaxLength = 0;
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCheckInDate.Size = new System.Drawing.Size(81, 21);
            this.txtCheckInDate.TabIndex = 23;
            this.txtCheckInDate.TextChanged += new System.EventHandler(this.txtCheckInDate_TextChanged);
            this.txtCheckInDate.Enter += new System.EventHandler(this.txtCheckInDate_Enter);
            this.txtCheckInDate.Leave += new System.EventHandler(this.txtCheckInDate_Leave);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(8, 88);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(97, 17);
            this.Label9.TabIndex = 62;
            this.Label9.Text = "Address  ";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBonus
            // 
            this.lblBonus.BackColor = System.Drawing.Color.Green;
            this.lblBonus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBonus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBonus.Location = new System.Drawing.Point(8, 336);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBonus.Size = new System.Drawing.Size(81, 17);
            this.lblBonus.TabIndex = 110;
            this.lblBonus.Text = "** Bonus";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBonus.Visible = false;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(288, 88);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(81, 17);
            this.Label10.TabIndex = 61;
            this.Label10.Text = "Contact No.";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(288, 133);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(81, 17);
            this.Label11.TabIndex = 60;
            this.Label11.Text = "Country ";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(320, 0);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(81, 33);
            this.Label14.TabIndex = 59;
            this.Label14.Text = "Reservation Reference : ";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUnit
            // 
            this.lblUnit.BackColor = System.Drawing.Color.Cyan;
            this.lblUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Red;
            this.lblUnit.Location = new System.Drawing.Point(320, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUnit.Size = new System.Drawing.Size(241, 33);
            this.lblUnit.TabIndex = 137;
            // 
            // lblDiffBond
            // 
            this.lblDiffBond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDiffBond.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDiffBond.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffBond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblDiffBond.Location = new System.Drawing.Point(8, 208);
            this.lblDiffBond.Name = "lblDiffBond";
            this.lblDiffBond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiffBond.Size = new System.Drawing.Size(81, 17);
            this.lblDiffBond.TabIndex = 112;
            this.lblDiffBond.Text = "Bond Diff ";
            this.lblDiffBond.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label33.Location = new System.Drawing.Point(14, 174);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(82, 14);
            this.Label33.TabIndex = 78;
            this.Label33.Text = "Check In Date";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEarlyStart
            // 
            this.lbEarlyStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbEarlyStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbEarlyStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEarlyStart.ForeColor = System.Drawing.Color.Yellow;
            this.lbEarlyStart.Location = new System.Drawing.Point(399, 156);
            this.lbEarlyStart.Name = "lbEarlyStart";
            this.lbEarlyStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEarlyStart.Size = new System.Drawing.Size(81, 17);
            this.lbEarlyStart.TabIndex = 74;
            this.lbEarlyStart.Text = "Extra Days ";
            this.lbEarlyStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(399, 92);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(81, 17);
            this.Label1.TabIndex = 71;
            this.Label1.Text = "Issued Card  ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(399, 124);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(81, 17);
            this.Label16.TabIndex = 73;
            this.Label16.Text = "Charge Type ";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelRoom
            // 
            this.LabelRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRoom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoom.ForeColor = System.Drawing.Color.Black;
            this.LabelRoom.Location = new System.Drawing.Point(399, 60);
            this.LabelRoom.Name = "LabelRoom";
            this.LabelRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRoom.Size = new System.Drawing.Size(73, 17);
            this.LabelRoom.TabIndex = 72;
            this.LabelRoom.Text = "Room No. ";
            this.LabelRoom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.BackColor = System.Drawing.Color.White;
            this.lblRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoomNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoomNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.ForeColor = System.Drawing.Color.Red;
            this.lblRoomNo.Location = new System.Drawing.Point(488, 55);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomNo.Size = new System.Drawing.Size(81, 25);
            this.lblRoomNo.TabIndex = 27;
            this.lblRoomNo.Enter += new System.EventHandler(this.lblRoomNo_Enter);
            // 
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label30.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label30.Location = new System.Drawing.Point(160, 16);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label30.Size = new System.Drawing.Size(81, 17);
            this.Label30.TabIndex = 56;
            this.Label30.Text = "Room Type. ";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label29.Location = new System.Drawing.Point(399, 188);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label29.Size = new System.Drawing.Size(81, 17);
            this.Label29.TabIndex = 55;
            this.Label29.Text = "Card Type  ";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(205, 178);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(81, 31);
            this.Label13.TabIndex = 54;
            this.Label13.Text = "Valid End Inc. Grace ";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCardType
            // 
            this.lbCardType.BackColor = System.Drawing.Color.White;
            this.lbCardType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCardType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCardType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardType.ForeColor = System.Drawing.Color.Blue;
            this.lbCardType.Location = new System.Drawing.Point(488, 188);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCardType.Size = new System.Drawing.Size(81, 21);
            this.lbCardType.TabIndex = 30;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label28.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label28.Location = new System.Drawing.Point(399, 220);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(81, 17);
            this.Label28.TabIndex = 51;
            this.Label28.Text = "Card No. ";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label27.Location = new System.Drawing.Point(8, 224);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(73, 14);
            this.Label27.TabIndex = 49;
            this.Label27.Text = "Note: ";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbNoOfDays
            // 
            this.lbNoOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbNoOfDays.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNoOfDays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoOfDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNoOfDays.Location = new System.Drawing.Point(204, 148);
            this.lbNoOfDays.Name = "lbNoOfDays";
            this.lbNoOfDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNoOfDays.Size = new System.Drawing.Size(81, 17);
            this.lbNoOfDays.TabIndex = 48;
            this.lbNoOfDays.Text = "No Of Days ";
            this.lbNoOfDays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label25
            // 
            this.Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label25.Location = new System.Drawing.Point(14, 148);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(76, 14);
            this.Label25.TabIndex = 47;
            this.Label25.Text = "Valid End ";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label24.Location = new System.Drawing.Point(14, 120);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(76, 17);
            this.Label24.TabIndex = 46;
            this.Label24.Text = "Valid Start ";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label19.Location = new System.Drawing.Point(204, 119);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(81, 17);
            this.Label19.TabIndex = 45;
            this.Label19.Text = "Grace Period ";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(205, 94);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(81, 17);
            this.Label18.TabIndex = 44;
            this.Label18.Text = "Contract End ";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(5, 92);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(92, 18);
            this.Label17.TabIndex = 43;
            this.Label17.Text = "Contract Start ";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAvailableRooms.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvailableRooms.Location = new System.Drawing.Point(377, 16);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAvailableRooms.Size = new System.Drawing.Size(89, 17);
            this.lblAvailableRooms.TabIndex = 42;
            this.lblAvailableRooms.Text = "Available Room ";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(16, 16);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(81, 17);
            this.Label12.TabIndex = 41;
            this.Label12.Text = "Building No. ";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _optOldGuest_3
            // 
            this._optOldGuest_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._optOldGuest_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._optOldGuest_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optOldGuest_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optOldGuest_3.Location = new System.Drawing.Point(128, 32);
            this._optOldGuest_3.Name = "_optOldGuest_3";
            this._optOldGuest_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optOldGuest_3.Size = new System.Drawing.Size(105, 25);
            this._optOldGuest_3.TabIndex = 36;
            this._optOldGuest_3.TabStop = true;
            this._optOldGuest_3.Text = "Key Extension";
            this.ToolTip1.SetToolTip(this._optOldGuest_3, "Select for Key Extension");
            this._optOldGuest_3.UseVisualStyleBackColor = false;
            this._optOldGuest_3.CheckedChanged += new System.EventHandler(this._optOldGuest_3_CheckedChanged);
            // 
            // UnitFrame2
            // 
            this.UnitFrame2.BackColor = System.Drawing.SystemColors.Control;
            this.UnitFrame2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitFrame2.ForeColor = System.Drawing.Color.Red;
            this.UnitFrame2.Location = new System.Drawing.Point(8, 13);
            this.UnitFrame2.Name = "UnitFrame2";
            this.UnitFrame2.Padding = new System.Windows.Forms.Padding(0);
            this.UnitFrame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnitFrame2.Size = new System.Drawing.Size(14, 20);
            this.UnitFrame2.TabIndex = 162;
            this.UnitFrame2.TabStop = false;
            this.UnitFrame2.Visible = false;
            // 
            // cmdUnitKey
            // 
            this.cmdUnitKey.BackColor = System.Drawing.Color.White;
            this.cmdUnitKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUnitKey.Enabled = false;
            this.cmdUnitKey.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnitKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUnitKey.Location = new System.Drawing.Point(598, 31);
            this.cmdUnitKey.Name = "cmdUnitKey";
            this.cmdUnitKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUnitKey.Size = new System.Drawing.Size(80, 47);
            this.cmdUnitKey.TabIndex = 136;
            this.cmdUnitKey.Text = "Unit ";
            this.cmdUnitKey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdUnitKey.UseVisualStyleBackColor = false;
            this.cmdUnitKey.Visible = false;
            // 
            // ExtraChargeFrame
            // 
            this.ExtraChargeFrame.BackColor = System.Drawing.SystemColors.Control;
            this.ExtraChargeFrame.Controls.Add(this._txtDesExtra_0);
            this.ExtraChargeFrame.Controls.Add(this._txtExtraAmount_0);
            this.ExtraChargeFrame.Controls.Add(this._txtDesExtra_1);
            this.ExtraChargeFrame.Controls.Add(this._txtExtraAmount_1);
            this.ExtraChargeFrame.Controls.Add(this._txtExtraAmount_2);
            this.ExtraChargeFrame.Controls.Add(this._txtExtraAmount_3);
            this.ExtraChargeFrame.Controls.Add(this._txtExtraAmount_4);
            this.ExtraChargeFrame.Controls.Add(this._txtDesExtra_2);
            this.ExtraChargeFrame.Controls.Add(this._txtDesExtra_3);
            this.ExtraChargeFrame.Controls.Add(this._txtDesExtra_4);
            this.ExtraChargeFrame.Controls.Add(this.txtExtraTotal);
            this.ExtraChargeFrame.Controls.Add(this.cmdOK);
            this.ExtraChargeFrame.Controls.Add(this.lblMessage3);
            this.ExtraChargeFrame.Controls.Add(this.lblExtraTotal);
            this.ExtraChargeFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtraChargeFrame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraChargeFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.ExtraChargeFrame.Location = new System.Drawing.Point(67, 67);
            this.ExtraChargeFrame.Name = "ExtraChargeFrame";
            this.ExtraChargeFrame.Padding = new System.Windows.Forms.Padding(0);
            this.ExtraChargeFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraChargeFrame.Size = new System.Drawing.Size(511, 321);
            this.ExtraChargeFrame.TabIndex = 160;
            this.ExtraChargeFrame.TabStop = false;
            this.ExtraChargeFrame.Text = "Other Charges List";
            this.ExtraChargeFrame.Visible = false;
            this.ExtraChargeFrame.Enter += new System.EventHandler(this.ExtraChargeFrame_Enter);
            // 
            // _txtDesExtra_0
            // 
            this._txtDesExtra_0.AcceptsReturn = true;
            this._txtDesExtra_0.BackColor = System.Drawing.SystemColors.Window;
            this._txtDesExtra_0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDesExtra_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDesExtra_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDesExtra_0.Location = new System.Drawing.Point(16, 32);
            this._txtDesExtra_0.MaxLength = 50;
            this._txtDesExtra_0.Name = "_txtDesExtra_0";
            this._txtDesExtra_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDesExtra_0.Size = new System.Drawing.Size(393, 20);
            this._txtDesExtra_0.TabIndex = 94;
            this._txtDesExtra_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtDesExtra_0_KeyPress);
            // 
            // _txtExtraAmount_0
            // 
            this._txtExtraAmount_0.AcceptsReturn = true;
            this._txtExtraAmount_0.BackColor = System.Drawing.SystemColors.Window;
            this._txtExtraAmount_0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtExtraAmount_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraAmount_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtExtraAmount_0.Location = new System.Drawing.Point(416, 32);
            this._txtExtraAmount_0.MaxLength = 0;
            this._txtExtraAmount_0.Name = "_txtExtraAmount_0";
            this._txtExtraAmount_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtExtraAmount_0.Size = new System.Drawing.Size(89, 20);
            this._txtExtraAmount_0.TabIndex = 96;
            this._txtExtraAmount_0.Text = "0";
            this._txtExtraAmount_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtExtraAmount_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtExtraAmount_0_KeyPress);
            this._txtExtraAmount_0.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtExtraAmount_0_KeyUp);
            // 
            // _txtDesExtra_1
            // 
            this._txtDesExtra_1.AcceptsReturn = true;
            this._txtDesExtra_1.BackColor = System.Drawing.SystemColors.Window;
            this._txtDesExtra_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDesExtra_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDesExtra_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDesExtra_1.Location = new System.Drawing.Point(16, 64);
            this._txtDesExtra_1.MaxLength = 50;
            this._txtDesExtra_1.Name = "_txtDesExtra_1";
            this._txtDesExtra_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDesExtra_1.Size = new System.Drawing.Size(393, 20);
            this._txtDesExtra_1.TabIndex = 98;
            this._txtDesExtra_1.Visible = false;
            this._txtDesExtra_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtDesExtra_1_KeyPress);
            // 
            // _txtExtraAmount_1
            // 
            this._txtExtraAmount_1.AcceptsReturn = true;
            this._txtExtraAmount_1.BackColor = System.Drawing.SystemColors.Window;
            this._txtExtraAmount_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtExtraAmount_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraAmount_1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtExtraAmount_1.Location = new System.Drawing.Point(416, 64);
            this._txtExtraAmount_1.MaxLength = 0;
            this._txtExtraAmount_1.Name = "_txtExtraAmount_1";
            this._txtExtraAmount_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtExtraAmount_1.Size = new System.Drawing.Size(89, 20);
            this._txtExtraAmount_1.TabIndex = 100;
            this._txtExtraAmount_1.Text = "0";
            this._txtExtraAmount_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtExtraAmount_1.Visible = false;
            this._txtExtraAmount_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtExtraAmount_1_KeyPress);
            this._txtExtraAmount_1.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtExtraAmount_1_KeyUp);
            // 
            // _txtExtraAmount_2
            // 
            this._txtExtraAmount_2.AcceptsReturn = true;
            this._txtExtraAmount_2.BackColor = System.Drawing.SystemColors.Window;
            this._txtExtraAmount_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtExtraAmount_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraAmount_2.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtExtraAmount_2.Location = new System.Drawing.Point(416, 96);
            this._txtExtraAmount_2.MaxLength = 0;
            this._txtExtraAmount_2.Name = "_txtExtraAmount_2";
            this._txtExtraAmount_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtExtraAmount_2.Size = new System.Drawing.Size(89, 20);
            this._txtExtraAmount_2.TabIndex = 104;
            this._txtExtraAmount_2.Text = "0";
            this._txtExtraAmount_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtExtraAmount_2.Visible = false;
            this._txtExtraAmount_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtExtraAmount_2_KeyPress);
            this._txtExtraAmount_2.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtExtraAmount_2_KeyUp);
            // 
            // _txtExtraAmount_3
            // 
            this._txtExtraAmount_3.AcceptsReturn = true;
            this._txtExtraAmount_3.BackColor = System.Drawing.SystemColors.Window;
            this._txtExtraAmount_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtExtraAmount_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraAmount_3.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtExtraAmount_3.Location = new System.Drawing.Point(416, 128);
            this._txtExtraAmount_3.MaxLength = 0;
            this._txtExtraAmount_3.Name = "_txtExtraAmount_3";
            this._txtExtraAmount_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtExtraAmount_3.Size = new System.Drawing.Size(89, 20);
            this._txtExtraAmount_3.TabIndex = 107;
            this._txtExtraAmount_3.Text = "0";
            this._txtExtraAmount_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtExtraAmount_3.Visible = false;
            this._txtExtraAmount_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtExtraAmount_3_KeyPress);
            this._txtExtraAmount_3.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtExtraAmount_3_KeyUp);
            // 
            // _txtExtraAmount_4
            // 
            this._txtExtraAmount_4.AcceptsReturn = true;
            this._txtExtraAmount_4.BackColor = System.Drawing.SystemColors.Window;
            this._txtExtraAmount_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtExtraAmount_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExtraAmount_4.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtExtraAmount_4.Location = new System.Drawing.Point(416, 160);
            this._txtExtraAmount_4.MaxLength = 0;
            this._txtExtraAmount_4.Name = "_txtExtraAmount_4";
            this._txtExtraAmount_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtExtraAmount_4.Size = new System.Drawing.Size(89, 20);
            this._txtExtraAmount_4.TabIndex = 111;
            this._txtExtraAmount_4.Text = "0";
            this._txtExtraAmount_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtExtraAmount_4.Visible = false;
            this._txtExtraAmount_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtExtraAmount_4_KeyPress);
            this._txtExtraAmount_4.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtExtraAmount_4_KeyUp);
            // 
            // _txtDesExtra_2
            // 
            this._txtDesExtra_2.AcceptsReturn = true;
            this._txtDesExtra_2.BackColor = System.Drawing.SystemColors.Window;
            this._txtDesExtra_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDesExtra_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDesExtra_2.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDesExtra_2.Location = new System.Drawing.Point(16, 96);
            this._txtDesExtra_2.MaxLength = 50;
            this._txtDesExtra_2.Name = "_txtDesExtra_2";
            this._txtDesExtra_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDesExtra_2.Size = new System.Drawing.Size(393, 20);
            this._txtDesExtra_2.TabIndex = 102;
            this._txtDesExtra_2.Visible = false;
            this._txtDesExtra_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtDesExtra_2_KeyPress);
            // 
            // _txtDesExtra_3
            // 
            this._txtDesExtra_3.AcceptsReturn = true;
            this._txtDesExtra_3.BackColor = System.Drawing.SystemColors.Window;
            this._txtDesExtra_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDesExtra_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDesExtra_3.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDesExtra_3.Location = new System.Drawing.Point(16, 128);
            this._txtDesExtra_3.MaxLength = 50;
            this._txtDesExtra_3.Name = "_txtDesExtra_3";
            this._txtDesExtra_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDesExtra_3.Size = new System.Drawing.Size(393, 20);
            this._txtDesExtra_3.TabIndex = 106;
            this._txtDesExtra_3.Visible = false;
            this._txtDesExtra_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtDesExtra_3_KeyPress);
            // 
            // _txtDesExtra_4
            // 
            this._txtDesExtra_4.AcceptsReturn = true;
            this._txtDesExtra_4.BackColor = System.Drawing.SystemColors.Window;
            this._txtDesExtra_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDesExtra_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDesExtra_4.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDesExtra_4.Location = new System.Drawing.Point(16, 160);
            this._txtDesExtra_4.MaxLength = 50;
            this._txtDesExtra_4.Name = "_txtDesExtra_4";
            this._txtDesExtra_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDesExtra_4.Size = new System.Drawing.Size(393, 20);
            this._txtDesExtra_4.TabIndex = 109;
            this._txtDesExtra_4.Visible = false;
            this._txtDesExtra_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtDesExtra_4_KeyPress);
            // 
            // txtExtraTotal
            // 
            this.txtExtraTotal.AcceptsReturn = true;
            this.txtExtraTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtExtraTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtExtraTotal.Location = new System.Drawing.Point(416, 200);
            this.txtExtraTotal.MaxLength = 0;
            this.txtExtraTotal.Name = "txtExtraTotal";
            this.txtExtraTotal.ReadOnly = true;
            this.txtExtraTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExtraTotal.Size = new System.Drawing.Size(89, 22);
            this.txtExtraTotal.TabIndex = 113;
            this.txtExtraTotal.Text = "0";
            this.txtExtraTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOK.Location = new System.Drawing.Point(416, 240);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(89, 33);
            this.cmdOK.TabIndex = 115;
            this.cmdOK.Text = "OK";
            this.ToolTip1.SetToolTip(this.cmdOK, "Click to back Issue Screen");
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lblMessage3
            // 
            this.lblMessage3.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage3.ForeColor = System.Drawing.Color.Red;
            this.lblMessage3.Location = new System.Drawing.Point(16, 272);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage3.Size = new System.Drawing.Size(489, 41);
            this.lblMessage3.TabIndex = 83;
            this.lblMessage3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExtraTotal
            // 
            this.lblExtraTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtraTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExtraTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblExtraTotal.Location = new System.Drawing.Point(208, 208);
            this.lblExtraTotal.Name = "lblExtraTotal";
            this.lblExtraTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExtraTotal.Size = new System.Drawing.Size(201, 25);
            this.lblExtraTotal.TabIndex = 82;
            this.lblExtraTotal.Text = "Total Extra Charges  ";
            this.lblExtraTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ChargesFrame
            // 
            this.ChargesFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChargesFrame.Controls.Add(this.txtAmountPaid);
            this.ChargesFrame.Controls.Add(this.txtAdvance);
            this.ChargesFrame.Controls.Add(this.txtBond);
            this.ChargesFrame.Controls.Add(this.txtDeposit);
            this.ChargesFrame.Controls.Add(this.txtRoomCharge);
            this.ChargesFrame.Controls.Add(this.txtToCollect);
            this.ChargesFrame.Controls.Add(this.txtCurrRoomCharge);
            this.ChargesFrame.Controls.Add(this.txtExtraDescription);
            this.ChargesFrame.Controls.Add(this.txtExtra);
            this.ChargesFrame.Controls.Add(this.txtPrevious);
            this.ChargesFrame.Controls.Add(this.txtReceived);
            this.ChargesFrame.Controls.Add(this.txtKeyDeposit);
            this.ChargesFrame.Controls.Add(this.txtDisplayAmount);
            this.ChargesFrame.Controls.Add(this.txtDiffBond);
            this.ChargesFrame.Controls.Add(this.chkBondDiff);
            this.ChargesFrame.Controls.Add(this.txtBonus);
            this.ChargesFrame.Controls.Add(this.Label23);
            this.ChargesFrame.Controls.Add(this.Label22);
            this.ChargesFrame.Controls.Add(this.Label21);
            this.ChargesFrame.Controls.Add(this.Label15);
            this.ChargesFrame.Controls.Add(this.Label20);
            this.ChargesFrame.Controls.Add(this.Label31);
            this.ChargesFrame.Controls.Add(this.Label26);
            this.ChargesFrame.Controls.Add(this.lbExtraKeyCharge);
            this.ChargesFrame.Controls.Add(this.Label34);
            this.ChargesFrame.Controls.Add(this.Label35);
            this.ChargesFrame.Controls.Add(this.lbPrevious);
            this.ChargesFrame.Controls.Add(this.Label36);
            this.ChargesFrame.Controls.Add(this.lblDiffBond);
            this.ChargesFrame.Controls.Add(this.lblBonus);
            this.ChargesFrame.Controls.Add(this.txtExtraKeyCharge);
            this.ChargesFrame.Enabled = false;
            this.ChargesFrame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargesFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChargesFrame.Location = new System.Drawing.Point(587, 75);
            this.ChargesFrame.Name = "ChargesFrame";
            this.ChargesFrame.Padding = new System.Windows.Forms.Padding(0);
            this.ChargesFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChargesFrame.Size = new System.Drawing.Size(201, 377);
            this.ChargesFrame.TabIndex = 161;
            this.ChargesFrame.TabStop = false;
            this.ChargesFrame.Text = "Charges";
            this.ChargesFrame.Enter += new System.EventHandler(this.ChargesFrame_Enter);
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.AcceptsReturn = true;
            this.txtAmountPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountPaid.Enabled = false;
            this.txtAmountPaid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.ForeColor = System.Drawing.Color.Red;
            this.txtAmountPaid.Location = new System.Drawing.Point(104, 88);
            this.txtAmountPaid.MaxLength = 0;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmountPaid.Size = new System.Drawing.Size(81, 20);
            this.txtAmountPaid.TabIndex = 108;
            this.txtAmountPaid.Text = "0";
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtAmountPaid, "Total amount received upto date .");
            // 
            // txtAdvance
            // 
            this.txtAdvance.AcceptsReturn = true;
            this.txtAdvance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdvance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdvance.Enabled = false;
            this.txtAdvance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdvance.Location = new System.Drawing.Point(104, 120);
            this.txtAdvance.MaxLength = 0;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdvance.Size = new System.Drawing.Size(81, 20);
            this.txtAdvance.TabIndex = 105;
            this.txtAdvance.Text = "0";
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtAdvance, "Total Contract amount on current room and charge type.");
            // 
            // txtBond
            // 
            this.txtBond.AcceptsReturn = true;
            this.txtBond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBond.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBond.ForeColor = System.Drawing.Color.Red;
            this.txtBond.Location = new System.Drawing.Point(104, 184);
            this.txtBond.MaxLength = 0;
            this.txtBond.Name = "txtBond";
            this.txtBond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBond.Size = new System.Drawing.Size(81, 20);
            this.txtBond.TabIndex = 103;
            this.txtBond.Text = "0";
            this.txtBond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtBond, "Bond amount on contract.");
            this.txtBond.TextChanged += new System.EventHandler(this.txtBond_TextChanged);
            this.txtBond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBond_KeyPress);
            // 
            // txtDeposit
            // 
            this.txtDeposit.AcceptsReturn = true;
            this.txtDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.Enabled = false;
            this.txtDeposit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.ForeColor = System.Drawing.Color.Red;
            this.txtDeposit.Location = new System.Drawing.Point(104, 64);
            this.txtDeposit.MaxLength = 0;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeposit.Size = new System.Drawing.Size(81, 20);
            this.txtDeposit.TabIndex = 101;
            this.txtDeposit.Text = "0";
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtDeposit, "Deposit received from reservation.");
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.AcceptsReturn = true;
            this.txtRoomCharge.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomCharge.Enabled = false;
            this.txtRoomCharge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCharge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRoomCharge.Location = new System.Drawing.Point(104, 16);
            this.txtRoomCharge.MaxLength = 0;
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRoomCharge.Size = new System.Drawing.Size(81, 20);
            this.txtRoomCharge.TabIndex = 99;
            this.txtRoomCharge.Text = "0";
            this.txtRoomCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtRoomCharge, "Room Price for current charge type.");
            // 
            // txtToCollect
            // 
            this.txtToCollect.AcceptsReturn = true;
            this.txtToCollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtToCollect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToCollect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCollect.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtToCollect.Location = new System.Drawing.Point(104, 296);
            this.txtToCollect.MaxLength = 0;
            this.txtToCollect.Name = "txtToCollect";
            this.txtToCollect.ReadOnly = true;
            this.txtToCollect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToCollect.Size = new System.Drawing.Size(89, 22);
            this.txtToCollect.TabIndex = 97;
            this.txtToCollect.Text = "0";
            this.txtToCollect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrRoomCharge
            // 
            this.txtCurrRoomCharge.AcceptsReturn = true;
            this.txtCurrRoomCharge.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrRoomCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrRoomCharge.Enabled = false;
            this.txtCurrRoomCharge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrRoomCharge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrRoomCharge.Location = new System.Drawing.Point(104, 40);
            this.txtCurrRoomCharge.MaxLength = 0;
            this.txtCurrRoomCharge.Name = "txtCurrRoomCharge";
            this.txtCurrRoomCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrRoomCharge.Size = new System.Drawing.Size(81, 20);
            this.txtCurrRoomCharge.TabIndex = 95;
            this.txtCurrRoomCharge.Text = "0";
            this.txtCurrRoomCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtCurrRoomCharge, "Room charges for valid period.");
            // 
            // txtExtraDescription
            // 
            this.txtExtraDescription.AcceptsReturn = true;
            this.txtExtraDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtExtraDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtExtraDescription.Location = new System.Drawing.Point(8, 248);
            this.txtExtraDescription.MaxLength = 30;
            this.txtExtraDescription.Name = "txtExtraDescription";
            this.txtExtraDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExtraDescription.Size = new System.Drawing.Size(89, 20);
            this.txtExtraDescription.TabIndex = 92;
            this.txtExtraDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtExtraDescription_MouseClick);
            this.txtExtraDescription.Enter += new System.EventHandler(this.txtExtraDescription_Enter);
            // 
            // txtExtra
            // 
            this.txtExtra.AcceptsReturn = true;
            this.txtExtra.BackColor = System.Drawing.SystemColors.Window;
            this.txtExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtra.Enabled = false;
            this.txtExtra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtExtra.Location = new System.Drawing.Point(104, 248);
            this.txtExtra.MaxLength = 0;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExtra.Size = new System.Drawing.Size(81, 20);
            this.txtExtra.TabIndex = 91;
            this.txtExtra.Text = "0";
            this.txtExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtra.TextChanged += new System.EventHandler(this.txtExtra_TextChanged);
            // 
            // txtPrevious
            // 
            this.txtPrevious.AcceptsReturn = true;
            this.txtPrevious.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrevious.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrevious.Enabled = false;
            this.txtPrevious.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrevious.Location = new System.Drawing.Point(104, 272);
            this.txtPrevious.MaxLength = 0;
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrevious.Size = new System.Drawing.Size(81, 20);
            this.txtPrevious.TabIndex = 90;
            this.txtPrevious.Text = "0";
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrevious.Visible = false;
            // 
            // txtReceived
            // 
            this.txtReceived.AcceptsReturn = true;
            this.txtReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceived.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReceived.Location = new System.Drawing.Point(104, 352);
            this.txtReceived.MaxLength = 0;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReceived.Size = new System.Drawing.Size(89, 20);
            this.txtReceived.TabIndex = 117;
            this.txtReceived.Text = "0";
            this.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtReceived, "Key-In Received Amount.");
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            this.txtReceived.Enter += new System.EventHandler(this.txtReceived_Enter);
            this.txtReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceived_KeyPress);
            // 
            // txtKeyDeposit
            // 
            this.txtKeyDeposit.AcceptsReturn = true;
            this.txtKeyDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyDeposit.Enabled = false;
            this.txtKeyDeposit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyDeposit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKeyDeposit.Location = new System.Drawing.Point(104, 152);
            this.txtKeyDeposit.MaxLength = 0;
            this.txtKeyDeposit.Name = "txtKeyDeposit";
            this.txtKeyDeposit.ReadOnly = true;
            this.txtKeyDeposit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKeyDeposit.Size = new System.Drawing.Size(81, 20);
            this.txtKeyDeposit.TabIndex = 89;
            this.txtKeyDeposit.Text = "0";
            this.txtKeyDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKeyDeposit.Visible = false;
            this.txtKeyDeposit.TextChanged += new System.EventHandler(this.txtKeyDeposit_TextChanged);
            this.txtKeyDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyDeposit_KeyPress);
            // 
            // txtDisplayAmount
            // 
            this.txtDisplayAmount.AcceptsReturn = true;
            this.txtDisplayAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDisplayAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDisplayAmount.Location = new System.Drawing.Point(8, 312);
            this.txtDisplayAmount.MaxLength = 0;
            this.txtDisplayAmount.Name = "txtDisplayAmount";
            this.txtDisplayAmount.ReadOnly = true;
            this.txtDisplayAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplayAmount.Size = new System.Drawing.Size(81, 22);
            this.txtDisplayAmount.TabIndex = 88;
            this.txtDisplayAmount.Text = "0";
            this.txtDisplayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiffBond
            // 
            this.txtDiffBond.AcceptsReturn = true;
            this.txtDiffBond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDiffBond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiffBond.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiffBond.ForeColor = System.Drawing.Color.Blue;
            this.txtDiffBond.Location = new System.Drawing.Point(104, 208);
            this.txtDiffBond.MaxLength = 0;
            this.txtDiffBond.Name = "txtDiffBond";
            this.txtDiffBond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiffBond.Size = new System.Drawing.Size(81, 20);
            this.txtDiffBond.TabIndex = 87;
            this.txtDiffBond.Text = "0";
            this.txtDiffBond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtDiffBond, "Bond amount on contract.");
            this.txtDiffBond.TextChanged += new System.EventHandler(this.txtDiffBond_TextChanged);
            this.txtDiffBond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiffBond_KeyPress);
            // 
            // chkBondDiff
            // 
            this.chkBondDiff.BackColor = System.Drawing.Color.Cyan;
            this.chkBondDiff.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBondDiff.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBondDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.chkBondDiff.Location = new System.Drawing.Point(8, 201);
            this.chkBondDiff.Name = "chkBondDiff";
            this.chkBondDiff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBondDiff.Size = new System.Drawing.Size(89, 25);
            this.chkBondDiff.TabIndex = 86;
            this.chkBondDiff.Text = "Bond Diff (Refund) ";
            this.chkBondDiff.UseVisualStyleBackColor = false;
            // 
            // txtBonus
            // 
            this.txtBonus.AcceptsReturn = true;
            this.txtBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBonus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBonus.Location = new System.Drawing.Point(104, 328);
            this.txtBonus.MaxLength = 0;
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBonus.Size = new System.Drawing.Size(81, 22);
            this.txtBonus.TabIndex = 85;
            this.txtBonus.Text = "0";
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBonus.Visible = false;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.Black;
            this.Label23.Location = new System.Drawing.Point(8, 88);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(81, 27);
            this.Label23.TabIndex = 127;
            this.Label23.Text = "Total Received ";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.Black;
            this.Label22.Location = new System.Drawing.Point(8, 120);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(81, 27);
            this.Label22.TabIndex = 126;
            this.Label22.Text = "Advanced Amount ";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.Red;
            this.Label21.Location = new System.Drawing.Point(8, 184);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(81, 17);
            this.Label21.TabIndex = 125;
            this.Label21.Text = "Bond Amount ";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(8, 64);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(81, 17);
            this.Label15.TabIndex = 124;
            this.Label15.Text = "Deposit ";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.Location = new System.Drawing.Point(8, 16);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(81, 17);
            this.Label20.TabIndex = 123;
            this.Label20.Text = "Room Rate ";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label31
            // 
            this.Label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label31.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.ForeColor = System.Drawing.Color.Blue;
            this.Label31.Location = new System.Drawing.Point(8, 296);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label31.Size = new System.Drawing.Size(89, 17);
            this.Label31.TabIndex = 122;
            this.Label31.Text = "Amount Due ->";
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.Color.Black;
            this.Label26.Location = new System.Drawing.Point(8, 40);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(81, 21);
            this.Label26.TabIndex = 121;
            this.Label26.Text = "Room Charge ";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbExtraKeyCharge
            // 
            this.lbExtraKeyCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbExtraKeyCharge.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbExtraKeyCharge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraKeyCharge.ForeColor = System.Drawing.Color.Blue;
            this.lbExtraKeyCharge.Location = new System.Drawing.Point(8, 152);
            this.lbExtraKeyCharge.Name = "lbExtraKeyCharge";
            this.lbExtraKeyCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbExtraKeyCharge.Size = new System.Drawing.Size(81, 27);
            this.lbExtraKeyCharge.TabIndex = 120;
            this.lbExtraKeyCharge.Text = "Spare Key Deposit";
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label34.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label34.Location = new System.Drawing.Point(8, 232);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(89, 17);
            this.Label34.TabIndex = 119;
            this.Label34.Text = "Others Charges  ";
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label35.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label35.Location = new System.Drawing.Point(104, 232);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label35.Size = new System.Drawing.Size(81, 17);
            this.Label35.TabIndex = 118;
            this.Label35.Text = "Amount";
            // 
            // lbPrevious
            // 
            this.lbPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbPrevious.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPrevious.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrevious.ForeColor = System.Drawing.Color.Black;
            this.lbPrevious.Location = new System.Drawing.Point(8, 272);
            this.lbPrevious.Name = "lbPrevious";
            this.lbPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrevious.Size = new System.Drawing.Size(89, 17);
            this.lbPrevious.TabIndex = 116;
            this.lbPrevious.Text = "Previous Balance";
            this.lbPrevious.Visible = false;
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.Color.Red;
            this.Label36.Location = new System.Drawing.Point(8, 352);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label36.Size = new System.Drawing.Size(89, 17);
            this.Label36.TabIndex = 114;
            this.Label36.Text = "Received  -> ";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtExtraKeyCharge
            // 
            this.txtExtraKeyCharge.AcceptsReturn = true;
            this.txtExtraKeyCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtExtraKeyCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraKeyCharge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKeyCharge.ForeColor = System.Drawing.Color.Red;
            this.txtExtraKeyCharge.Location = new System.Drawing.Point(104, 152);
            this.txtExtraKeyCharge.MaxLength = 0;
            this.txtExtraKeyCharge.Name = "txtExtraKeyCharge";
            this.txtExtraKeyCharge.ReadOnly = true;
            this.txtExtraKeyCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExtraKeyCharge.Size = new System.Drawing.Size(81, 20);
            this.txtExtraKeyCharge.TabIndex = 93;
            this.txtExtraKeyCharge.Text = "0";
            this.txtExtraKeyCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtExtraKeyCharge, "Additional Key Charges");
            this.txtExtraKeyCharge.TextChanged += new System.EventHandler(this.txtExtraKeyCharge_TextChanged);
            // 
            // txtClientID
            // 
            this.txtClientID.AcceptsReturn = true;
            this.txtClientID.BackColor = System.Drawing.Color.White;
            this.txtClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.Color.Blue;
            this.txtClientID.Location = new System.Drawing.Point(112, 8);
            this.txtClientID.MaxLength = 8;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientID.Size = new System.Drawing.Size(89, 26);
            this.txtClientID.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.txtClientID, "Guest ID");
            this.txtClientID.Click += new System.EventHandler(this.txtClientID_Click);
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            this.txtClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientID_KeyPress);
            // 
            // OldGuestFrame
            // 
            this.OldGuestFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OldGuestFrame.Controls.Add(this.checkBox_Replace);
            this.OldGuestFrame.Controls.Add(this.chkExtendNewCard);
            this.OldGuestFrame.Controls.Add(this._optOldGuest_3);
            this.OldGuestFrame.Controls.Add(this._optOldGuest_1);
            this.OldGuestFrame.Controls.Add(this._optOldGuest_0);
            this.OldGuestFrame.Controls.Add(this.cmdLoss);
            this.OldGuestFrame.Cursor = System.Windows.Forms.Cursors.Default;
            this.OldGuestFrame.Enabled = false;
            this.OldGuestFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldGuestFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OldGuestFrame.Location = new System.Drawing.Point(7, 35);
            this.OldGuestFrame.Name = "OldGuestFrame";
            this.OldGuestFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OldGuestFrame.Size = new System.Drawing.Size(375, 57);
            this.OldGuestFrame.TabIndex = 158;
            // 
            // checkBox_Replace
            // 
            this.checkBox_Replace.BackColor = System.Drawing.Color.PaleTurquoise;
            this.checkBox_Replace.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_Replace.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Replace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Replace.Location = new System.Drawing.Point(193, 3);
            this.checkBox_Replace.Name = "checkBox_Replace";
            this.checkBox_Replace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Replace.Size = new System.Drawing.Size(73, 25);
            this.checkBox_Replace.TabIndex = 153;
            this.checkBox_Replace.Text = "Replace";
            this.ToolTip1.SetToolTip(this.checkBox_Replace, "Tick to Extend with New Card");
            this.checkBox_Replace.UseVisualStyleBackColor = false;
            this.checkBox_Replace.Visible = false;
            this.checkBox_Replace.CheckedChanged += new System.EventHandler(this.checkBox_Replace_CheckedChanged);
            // 
            // chkExtendNewCard
            // 
            this.chkExtendNewCard.BackColor = System.Drawing.Color.Yellow;
            this.chkExtendNewCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkExtendNewCard.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtendNewCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkExtendNewCard.Location = new System.Drawing.Point(128, 3);
            this.chkExtendNewCard.Name = "chkExtendNewCard";
            this.chkExtendNewCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkExtendNewCard.Size = new System.Drawing.Size(57, 25);
            this.chkExtendNewCard.TabIndex = 37;
            this.chkExtendNewCard.Text = "New Card";
            this.ToolTip1.SetToolTip(this.chkExtendNewCard, "Tick to Extend with New Card");
            this.chkExtendNewCard.UseVisualStyleBackColor = false;
            this.chkExtendNewCard.Visible = false;
            this.chkExtendNewCard.CheckedChanged += new System.EventHandler(this.chkExtendNewCard_CheckedChanged);
            this.chkExtendNewCard.CheckStateChanged += new System.EventHandler(this.chkExtendNewCard_CheckStateChanged);
            // 
            // _optOldGuest_1
            // 
            this._optOldGuest_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._optOldGuest_1.Checked = true;
            this._optOldGuest_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._optOldGuest_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optOldGuest_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optOldGuest_1.Location = new System.Drawing.Point(16, 32);
            this._optOldGuest_1.Name = "_optOldGuest_1";
            this._optOldGuest_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optOldGuest_1.Size = new System.Drawing.Size(100, 25);
            this._optOldGuest_1.TabIndex = 34;
            this._optOldGuest_1.TabStop = true;
            this._optOldGuest_1.Text = "Spare Key";
            this.ToolTip1.SetToolTip(this._optOldGuest_1, "Select for Spare Key");
            this._optOldGuest_1.UseVisualStyleBackColor = false;
            this._optOldGuest_1.CheckedChanged += new System.EventHandler(this._optOldGuest_1_CheckedChanged);
            // 
            // _optOldGuest_0
            // 
            this._optOldGuest_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._optOldGuest_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._optOldGuest_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optOldGuest_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optOldGuest_0.Location = new System.Drawing.Point(16, 0);
            this._optOldGuest_0.Name = "_optOldGuest_0";
            this._optOldGuest_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optOldGuest_0.Size = new System.Drawing.Size(100, 25);
            this._optOldGuest_0.TabIndex = 33;
            this._optOldGuest_0.Text = "No Selection";
            this.ToolTip1.SetToolTip(this._optOldGuest_0, "Select for Unselect Others");
            this._optOldGuest_0.UseVisualStyleBackColor = false;
            this._optOldGuest_0.CheckedChanged += new System.EventHandler(this._optOldGuest_0_CheckedChanged);
            // 
            // cmdLoss
            // 
            this.cmdLoss.BackColor = System.Drawing.Color.Yellow;
            this.cmdLoss.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLoss.Enabled = false;
            this.cmdLoss.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLoss.Location = new System.Drawing.Point(272, 0);
            this.cmdLoss.Name = "cmdLoss";
            this.cmdLoss.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLoss.Size = new System.Drawing.Size(73, 57);
            this.cmdLoss.TabIndex = 152;
            this.cmdLoss.Text = "    Inform    Key Loss";
            this.ToolTip1.SetToolTip(this.cmdLoss, "Loss Key");
            this.cmdLoss.UseVisualStyleBackColor = false;
            this.cmdLoss.Visible = false;
            this.cmdLoss.Click += new System.EventHandler(this.cmdLoss_Click);
            // 
            // _optOldGuest_2
            // 
            this._optOldGuest_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._optOldGuest_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._optOldGuest_2.Enabled = false;
            this._optOldGuest_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optOldGuest_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optOldGuest_2.Location = new System.Drawing.Point(694, 43);
            this._optOldGuest_2.Name = "_optOldGuest_2";
            this._optOldGuest_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optOldGuest_2.Size = new System.Drawing.Size(105, 25);
            this._optOldGuest_2.TabIndex = 35;
            this._optOldGuest_2.TabStop = true;
            this._optOldGuest_2.Text = "Transfer Room";
            this.ToolTip1.SetToolTip(this._optOldGuest_2, "Select for Transfer Room");
            this._optOldGuest_2.UseVisualStyleBackColor = false;
            this._optOldGuest_2.Visible = false;
            // 
            // txtReservationRef
            // 
            this.txtReservationRef.AcceptsReturn = true;
            this.txtReservationRef.BackColor = System.Drawing.SystemColors.Window;
            this.txtReservationRef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReservationRef.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationRef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReservationRef.Location = new System.Drawing.Point(432, 8);
            this.txtReservationRef.MaxLength = 6;
            this.txtReservationRef.Name = "txtReservationRef";
            this.txtReservationRef.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReservationRef.Size = new System.Drawing.Size(73, 22);
            this.txtReservationRef.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.txtReservationRef, "Reservation Reference number");
            // 
            // cboRoomType
            // 
            this.cboRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboRoomType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRoomType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomType.Location = new System.Drawing.Point(248, 16);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomType.Size = new System.Drawing.Size(105, 22);
            this.cboRoomType.TabIndex = 11;
            this.ToolTip1.SetToolTip(this.cboRoomType, "Select Room Type");
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            this.cboRoomType.Enter += new System.EventHandler(this.cboRoomType_Enter);
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboRoomNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRoomNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.ForeColor = System.Drawing.Color.Blue;
            this.cboRoomNo.Location = new System.Drawing.Point(473, 16);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomNo.Size = new System.Drawing.Size(65, 24);
            this.cboRoomNo.TabIndex = 12;
            this.ToolTip1.SetToolTip(this.cboRoomNo, "Select Available Room No.");
            this.cboRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboRoomNo_SelectedIndexChanged);
            this.cboRoomNo.Enter += new System.EventHandler(this.cboRoomNo_Enter);
            // 
            // cboChargeType
            // 
            this.cboChargeType.BackColor = System.Drawing.SystemColors.Window;
            this.cboChargeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboChargeType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChargeType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboChargeType.Location = new System.Drawing.Point(488, 124);
            this.cboChargeType.Name = "cboChargeType";
            this.cboChargeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChargeType.Size = new System.Drawing.Size(73, 22);
            this.cboChargeType.TabIndex = 17;
            this.cboChargeType.Text = "Monthly";
            this.ToolTip1.SetToolTip(this.cboChargeType, "Select Payment Type.");
            this.cboChargeType.SelectedIndexChanged += new System.EventHandler(this.cboChargeType_SelectedIndexChanged);
            this.cboChargeType.Enter += new System.EventHandler(this.cboChargeType_Enter);
            // 
            // RegistrationFrame
            // 
            this.RegistrationFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RegistrationFrame.Controls.Add(this.label40);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_CheckInTime);
            this.RegistrationFrame.Controls.Add(this.pictureBox1);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_CheckOutDate);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_ValidEnd);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_ValidStart);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_ContractEnd);
            this.RegistrationFrame.Controls.Add(this.dateTimePicker_ContractStart);
            this.RegistrationFrame.Controls.Add(this.txtCheckInDate);
            this.RegistrationFrame.Controls.Add(this.txtEarlyStart);
            this.RegistrationFrame.Controls.Add(this.cboChargeType);
            this.RegistrationFrame.Controls.Add(this.txtNoOfWeek);
            this.RegistrationFrame.Controls.Add(this.txtNoOfMonth);
            this.RegistrationFrame.Controls.Add(this.txtIssuedCard);
            this.RegistrationFrame.Controls.Add(this.txtRoomType);
            this.RegistrationFrame.Controls.Add(this.cboRoomType);
            this.RegistrationFrame.Controls.Add(this.txtCardNo);
            this.RegistrationFrame.Controls.Add(this.txtRemark);
            this.RegistrationFrame.Controls.Add(this.txtNoOfDays);
            this.RegistrationFrame.Controls.Add(this.txtGracePeriod);
            this.RegistrationFrame.Controls.Add(this.cboRoomNo);
            this.RegistrationFrame.Controls.Add(this.cboBuildingNo);
            this.RegistrationFrame.Controls.Add(this.Label33);
            this.RegistrationFrame.Controls.Add(this.lbEarlyStart);
            this.RegistrationFrame.Controls.Add(this.Label16);
            this.RegistrationFrame.Controls.Add(this.LabelRoom);
            this.RegistrationFrame.Controls.Add(this.Label1);
            this.RegistrationFrame.Controls.Add(this.lblRoomNo);
            this.RegistrationFrame.Controls.Add(this.Label30);
            this.RegistrationFrame.Controls.Add(this.Label29);
            this.RegistrationFrame.Controls.Add(this.Label13);
            this.RegistrationFrame.Controls.Add(this.lbCardType);
            this.RegistrationFrame.Controls.Add(this.Label28);
            this.RegistrationFrame.Controls.Add(this.Label27);
            this.RegistrationFrame.Controls.Add(this.lbNoOfDays);
            this.RegistrationFrame.Controls.Add(this.Label25);
            this.RegistrationFrame.Controls.Add(this.Label24);
            this.RegistrationFrame.Controls.Add(this.Label19);
            this.RegistrationFrame.Controls.Add(this.Label18);
            this.RegistrationFrame.Controls.Add(this.Label17);
            this.RegistrationFrame.Controls.Add(this.lblAvailableRooms);
            this.RegistrationFrame.Controls.Add(this.Label12);
            this.RegistrationFrame.Controls.Add(this.StayingPeopleFrame);
            this.RegistrationFrame.Controls.Add(this.UnitFrame);
            this.RegistrationFrame.Enabled = false;
            this.RegistrationFrame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrationFrame.Location = new System.Drawing.Point(8, 279);
            this.RegistrationFrame.Margin = new System.Windows.Forms.Padding(0);
            this.RegistrationFrame.Name = "RegistrationFrame";
            this.RegistrationFrame.Padding = new System.Windows.Forms.Padding(0);
            this.RegistrationFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationFrame.Size = new System.Drawing.Size(573, 257);
            this.RegistrationFrame.TabIndex = 154;
            this.RegistrationFrame.TabStop = false;
            this.RegistrationFrame.Text = "Registration :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label40.Cursor = System.Windows.Forms.Cursors.Default;
            this.label40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label40.Location = new System.Drawing.Point(8, 198);
            this.label40.Name = "label40";
            this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label40.Size = new System.Drawing.Size(86, 14);
            this.label40.TabIndex = 171;
            this.label40.Text = "Check In Time";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker_CheckInTime
            // 
            this.dateTimePicker_CheckInTime.CustomFormat = "HH:mm:ss tt";
            this.dateTimePicker_CheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CheckInTime.Location = new System.Drawing.Point(98, 197);
            this.dateTimePicker_CheckInTime.Name = "dateTimePicker_CheckInTime";
            this.dateTimePicker_CheckInTime.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker_CheckInTime.TabIndex = 170;
            this.dateTimePicker_CheckInTime.CloseUp += new System.EventHandler(this.dateTimePicker_CheckInTime_CloseUp);
            this.dateTimePicker_CheckInTime.DropDown += new System.EventHandler(this.dateTimePicker_CheckInTime_DropDown);
            this.dateTimePicker_CheckInTime.Enter += new System.EventHandler(this.dateTimePicker_CheckInTime_Enter);
            this.dateTimePicker_CheckInTime.Leave += new System.EventHandler(this.dateTimePicker_CheckInTime_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(535, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dateTimePicker_CheckOutDate
            // 
            this.dateTimePicker_CheckOutDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_CheckOutDate.Enabled = false;
            this.dateTimePicker_CheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CheckOutDate.Location = new System.Drawing.Point(290, 174);
            this.dateTimePicker_CheckOutDate.Name = "dateTimePicker_CheckOutDate";
            this.dateTimePicker_CheckOutDate.Size = new System.Drawing.Size(98, 22);
            this.dateTimePicker_CheckOutDate.TabIndex = 168;
            this.dateTimePicker_CheckOutDate.Enter += new System.EventHandler(this.dateTimePicker_CheckOutDate_Enter);
            // 
            // dateTimePicker_ValidEnd
            // 
            this.dateTimePicker_ValidEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ValidEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ValidEnd.Location = new System.Drawing.Point(96, 146);
            this.dateTimePicker_ValidEnd.Name = "dateTimePicker_ValidEnd";
            this.dateTimePicker_ValidEnd.Size = new System.Drawing.Size(98, 22);
            this.dateTimePicker_ValidEnd.TabIndex = 167;
            this.dateTimePicker_ValidEnd.CloseUp += new System.EventHandler(this.dateTimePicker_ValidEnd_CloseUp);
            this.dateTimePicker_ValidEnd.ValueChanged += new System.EventHandler(this.dateTimePicker_ValidEnd_ValueChanged);
            this.dateTimePicker_ValidEnd.DropDown += new System.EventHandler(this.dateTimePicker_ValidEnd_DropDown);
            this.dateTimePicker_ValidEnd.Enter += new System.EventHandler(this.dateTimePicker_ValidEnd_Enter);
            this.dateTimePicker_ValidEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker_ValidEnd_MouseDown);
            // 
            // dateTimePicker_ValidStart
            // 
            this.dateTimePicker_ValidStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ValidStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ValidStart.Location = new System.Drawing.Point(98, 119);
            this.dateTimePicker_ValidStart.Name = "dateTimePicker_ValidStart";
            this.dateTimePicker_ValidStart.Size = new System.Drawing.Size(98, 22);
            this.dateTimePicker_ValidStart.TabIndex = 166;
            this.dateTimePicker_ValidStart.CloseUp += new System.EventHandler(this.dateTimePicker_ValidStart_CloseUp);
            this.dateTimePicker_ValidStart.ValueChanged += new System.EventHandler(this.dateTimePicker_ValidStart_ValueChanged);
            this.dateTimePicker_ValidStart.DropDown += new System.EventHandler(this.dateTimePicker_ValidStart_DropDown);
            this.dateTimePicker_ValidStart.Enter += new System.EventHandler(this.dateTimePicker_ValidStart_Enter);
            this.dateTimePicker_ValidStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker_ValidStart_MouseDown);
            // 
            // dateTimePicker_ContractEnd
            // 
            this.dateTimePicker_ContractEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ContractEnd.Enabled = false;
            this.dateTimePicker_ContractEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ContractEnd.Location = new System.Drawing.Point(290, 92);
            this.dateTimePicker_ContractEnd.Name = "dateTimePicker_ContractEnd";
            this.dateTimePicker_ContractEnd.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker_ContractEnd.TabIndex = 165;
            this.dateTimePicker_ContractEnd.CloseUp += new System.EventHandler(this.dateTimePicker_ContractEnd_CloseUp);
            this.dateTimePicker_ContractEnd.DropDown += new System.EventHandler(this.dateTimePicker_ContractEnd_DropDown);
            this.dateTimePicker_ContractEnd.Enter += new System.EventHandler(this.dateTimePicker_ContractEnd_Enter);
            // 
            // dateTimePicker_ContractStart
            // 
            this.dateTimePicker_ContractStart.Checked = false;
            this.dateTimePicker_ContractStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ContractStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ContractStart.Location = new System.Drawing.Point(96, 91);
            this.dateTimePicker_ContractStart.Name = "dateTimePicker_ContractStart";
            this.dateTimePicker_ContractStart.Size = new System.Drawing.Size(98, 22);
            this.dateTimePicker_ContractStart.TabIndex = 164;
            this.dateTimePicker_ContractStart.CloseUp += new System.EventHandler(this.dateTimePicker_ContractStart_CloseUp);
            this.dateTimePicker_ContractStart.ValueChanged += new System.EventHandler(this.dateTimePicker_ContractStart_ValueChanged);
            this.dateTimePicker_ContractStart.DropDown += new System.EventHandler(this.dateTimePicker_ContractStart_DropDown);
            this.dateTimePicker_ContractStart.Enter += new System.EventHandler(this.dateTimePicker_ContractStart_Enter);
            // 
            // txtIssuedCard
            // 
            this.txtIssuedCard.AcceptsReturn = true;
            this.txtIssuedCard.BackColor = System.Drawing.SystemColors.Window;
            this.txtIssuedCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIssuedCard.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedCard.ForeColor = System.Drawing.Color.Red;
            this.txtIssuedCard.Location = new System.Drawing.Point(488, 92);
            this.txtIssuedCard.MaxLength = 0;
            this.txtIssuedCard.Name = "txtIssuedCard";
            this.txtIssuedCard.ReadOnly = true;
            this.txtIssuedCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIssuedCard.Size = new System.Drawing.Size(41, 21);
            this.txtIssuedCard.TabIndex = 28;
            this.txtIssuedCard.Text = "0";
            this.txtIssuedCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtIssuedCard, "Total number of card issued for room.");
            // 
            // cboBuildingNo
            // 
            this.cboBuildingNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuildingNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBuildingNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildingNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBuildingNo.Location = new System.Drawing.Point(104, 16);
            this.cboBuildingNo.Name = "cboBuildingNo";
            this.cboBuildingNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboBuildingNo.Size = new System.Drawing.Size(41, 22);
            this.cboBuildingNo.TabIndex = 10;
            this.ToolTip1.SetToolTip(this.cboBuildingNo, "Select Building No.");
            this.cboBuildingNo.SelectedIndexChanged += new System.EventHandler(this.cboBuildingNo_SelectedIndexChanged);
            // 
            // StayingPeopleFrame
            // 
            this.StayingPeopleFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StayingPeopleFrame.Controls.Add(this.chkSecond);
            this.StayingPeopleFrame.Controls.Add(this._optPeople_1);
            this.StayingPeopleFrame.Controls.Add(this._optPeople_0);
            this.StayingPeopleFrame.Controls.Add(this.Label32);
            this.StayingPeopleFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayingPeopleFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StayingPeopleFrame.Location = new System.Drawing.Point(16, 40);
            this.StayingPeopleFrame.Name = "StayingPeopleFrame";
            this.StayingPeopleFrame.Padding = new System.Windows.Forms.Padding(0);
            this.StayingPeopleFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StayingPeopleFrame.Size = new System.Drawing.Size(345, 49);
            this.StayingPeopleFrame.TabIndex = 75;
            this.StayingPeopleFrame.TabStop = false;
            this.StayingPeopleFrame.Enter += new System.EventHandler(this.StayingPeopleFrame_Enter);
            // 
            // chkSecond
            // 
            this.chkSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkSecond.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSecond.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSecond.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSecond.Location = new System.Drawing.Point(240, 16);
            this.chkSecond.Name = "chkSecond";
            this.chkSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSecond.Size = new System.Drawing.Size(97, 25);
            this.chkSecond.TabIndex = 15;
            this.chkSecond.Text = "Second Key";
            this.chkSecond.UseVisualStyleBackColor = false;
            this.chkSecond.CheckedChanged += new System.EventHandler(this.chkSecond_CheckedChanged_1);
            this.chkSecond.CheckStateChanged += new System.EventHandler(this.chkSecond_CheckStateChanged);
            this.chkSecond.Click += new System.EventHandler(this.chkSecond_Click);
            // 
            // _optPeople_1
            // 
            this._optPeople_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._optPeople_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._optPeople_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optPeople_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optPeople_1.Location = new System.Drawing.Point(168, 16);
            this._optPeople_1.Name = "_optPeople_1";
            this._optPeople_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optPeople_1.Size = new System.Drawing.Size(57, 24);
            this._optPeople_1.TabIndex = 14;
            this._optPeople_1.TabStop = true;
            this._optPeople_1.Text = "Two";
            this._optPeople_1.UseVisualStyleBackColor = false;
            this._optPeople_1.Click += new System.EventHandler(this._optPeople_1_Click);
            // 
            // _optPeople_0
            // 
            this._optPeople_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._optPeople_0.Checked = true;
            this._optPeople_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._optPeople_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optPeople_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optPeople_0.Location = new System.Drawing.Point(96, 16);
            this._optPeople_0.Name = "_optPeople_0";
            this._optPeople_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optPeople_0.Size = new System.Drawing.Size(57, 24);
            this._optPeople_0.TabIndex = 13;
            this._optPeople_0.TabStop = true;
            this._optPeople_0.Text = "One ";
            this._optPeople_0.UseVisualStyleBackColor = false;
            this._optPeople_0.Click += new System.EventHandler(this._optPeople_0_Click);
            // 
            // Label32
            // 
            this.Label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.Color.Black;
            this.Label32.Location = new System.Drawing.Point(8, 16);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(81, 17);
            this.Label32.TabIndex = 76;
            this.Label32.Text = "Staying ";
            this.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UnitFrame
            // 
            this.UnitFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UnitFrame.Controls.Add(this.txtUnitNo);
            this.UnitFrame.Controls.Add(this._optUnit_1);
            this.UnitFrame.Controls.Add(this._optUnit_0);
            this.UnitFrame.Controls.Add(this.cboUnitNo);
            this.UnitFrame.Controls.Add(this.Label38);
            this.UnitFrame.Controls.Add(this.Label39);
            this.UnitFrame.Enabled = false;
            this.UnitFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnitFrame.Location = new System.Drawing.Point(16, 40);
            this.UnitFrame.Name = "UnitFrame";
            this.UnitFrame.Padding = new System.Windows.Forms.Padding(0);
            this.UnitFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnitFrame.Size = new System.Drawing.Size(361, 49);
            this.UnitFrame.TabIndex = 128;
            this.UnitFrame.TabStop = false;
            this.UnitFrame.Visible = false;
            // 
            // txtUnitNo
            // 
            this.txtUnitNo.AcceptsReturn = true;
            this.txtUnitNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUnitNo.Location = new System.Drawing.Point(352, 16);
            this.txtUnitNo.MaxLength = 0;
            this.txtUnitNo.Name = "txtUnitNo";
            this.txtUnitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnitNo.Size = new System.Drawing.Size(17, 20);
            this.txtUnitNo.TabIndex = 134;
            this.txtUnitNo.TextChanged += new System.EventHandler(this.txtUnitNo_TextChanged);
            // 
            // _optUnit_1
            // 
            this._optUnit_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._optUnit_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUnit_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUnit_1.ForeColor = System.Drawing.Color.Yellow;
            this._optUnit_1.Location = new System.Drawing.Point(176, 16);
            this._optUnit_1.Name = "_optUnit_1";
            this._optUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUnit_1.Size = new System.Drawing.Size(89, 24);
            this._optUnit_1.TabIndex = 131;
            this._optUnit_1.TabStop = true;
            this._optUnit_1.Text = "Whole Unit";
            this._optUnit_1.UseVisualStyleBackColor = false;
            // 
            // _optUnit_0
            // 
            this._optUnit_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._optUnit_0.Checked = true;
            this._optUnit_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUnit_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUnit_0.ForeColor = System.Drawing.Color.Yellow;
            this._optUnit_0.Location = new System.Drawing.Point(88, 16);
            this._optUnit_0.Name = "_optUnit_0";
            this._optUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUnit_0.Size = new System.Drawing.Size(81, 24);
            this._optUnit_0.TabIndex = 130;
            this._optUnit_0.TabStop = true;
            this._optUnit_0.Text = "Individual";
            this._optUnit_0.UseVisualStyleBackColor = false;
            // 
            // cboUnitNo
            // 
            this.cboUnitNo.BackColor = System.Drawing.SystemColors.Window;
            this.cboUnitNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboUnitNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitNo.ForeColor = System.Drawing.Color.Blue;
            this.cboUnitNo.Location = new System.Drawing.Point(312, 16);
            this.cboUnitNo.Name = "cboUnitNo";
            this.cboUnitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboUnitNo.Size = new System.Drawing.Size(41, 24);
            this.cboUnitNo.TabIndex = 129;
            this.ToolTip1.SetToolTip(this.cboUnitNo, "Select Available Room No.");
            // 
            // Label38
            // 
            this.Label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label38.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.ForeColor = System.Drawing.Color.Black;
            this.Label38.Location = new System.Drawing.Point(8, 16);
            this.Label38.Name = "Label38";
            this.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label38.Size = new System.Drawing.Size(73, 21);
            this.Label38.TabIndex = 133;
            this.Label38.Text = "Stay  Type:   ";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label39
            // 
            this.Label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label39.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label39.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.Color.Blue;
            this.Label39.Location = new System.Drawing.Point(264, 16);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label39.Size = new System.Drawing.Size(49, 24);
            this.Label39.TabIndex = 132;
            this.Label39.Text = "Unit No. ";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Label37.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label37.Location = new System.Drawing.Point(697, 562);
            this.Label37.Name = "Label37";
            this.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label37.Size = new System.Drawing.Size(75, 17);
            this.Label37.TabIndex = 168;
            this.Label37.Text = "Cal.Configure_Control_For_New ";
            this.Label37.Visible = false;
            // 
            // ClientFrame
            // 
            this.ClientFrame.BackColor = System.Drawing.Color.Cyan;
            this.ClientFrame.Controls.Add(this.label7);
            this.ClientFrame.Controls.Add(this.textBox_Email);
            this.ClientFrame.Controls.Add(this.txtCountry);
            this.ClientFrame.Controls.Add(this.cboCountry);
            this.ClientFrame.Controls.Add(this.txtContact);
            this.ClientFrame.Controls.Add(this.txtNationality);
            this.ClientFrame.Controls.Add(this.txtSurName);
            this.ClientFrame.Controls.Add(this.cmdViewReserveList);
            this.ClientFrame.Controls.Add(this.cmdViewClient);
            this.ClientFrame.Controls.Add(this.txtReserve);
            this.ClientFrame.Controls.Add(this.cboSex);
            this.ClientFrame.Controls.Add(this.txtClientID);
            this.ClientFrame.Controls.Add(this.txtFirstName);
            this.ClientFrame.Controls.Add(this.txtIdentity);
            this.ClientFrame.Controls.Add(this.txtAddress);
            this.ClientFrame.Controls.Add(this.txtReservationRef);
            this.ClientFrame.Controls.Add(this.Label3);
            this.ClientFrame.Controls.Add(this.Label4);
            this.ClientFrame.Controls.Add(this.Label5);
            this.ClientFrame.Controls.Add(this.Label6);
            this.ClientFrame.Controls.Add(this._Label7_0);
            this.ClientFrame.Controls.Add(this.Label8);
            this.ClientFrame.Controls.Add(this.Label9);
            this.ClientFrame.Controls.Add(this.Label10);
            this.ClientFrame.Controls.Add(this.Label11);
            this.ClientFrame.Controls.Add(this.Label14);
            this.ClientFrame.Controls.Add(this.lblUnit);
            this.ClientFrame.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientFrame.Enabled = false;
            this.ClientFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClientFrame.Location = new System.Drawing.Point(7, 91);
            this.ClientFrame.Name = "ClientFrame";
            this.ClientFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClientFrame.Size = new System.Drawing.Size(570, 185);
            this.ClientFrame.TabIndex = 156;
            this.ClientFrame.Text = "Frame2";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 158);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 139;
            this.label7.Text = "Email ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Email
            // 
            this.textBox_Email.AcceptsReturn = true;
            this.textBox_Email.BackColor = System.Drawing.Color.White;
            this.textBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Email.Location = new System.Drawing.Point(113, 155);
            this.textBox_Email.MaxLength = 30;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Email.Size = new System.Drawing.Size(265, 26);
            this.textBox_Email.TabIndex = 10;
            this.textBox_Email.Click += new System.EventHandler(this.textBox_Email_Click);
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            this.textBox_Email.Enter += new System.EventHandler(this.textBox_Email_Enter);
            this.textBox_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Email_KeyPress);
            this.textBox_Email.Leave += new System.EventHandler(this.textBox_Email_Leave);
            // 
            // cmdViewReserveList
            // 
            this.cmdViewReserveList.BackColor = System.Drawing.Color.Blue;
            this.cmdViewReserveList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdViewReserveList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewReserveList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdViewReserveList.Location = new System.Drawing.Point(512, 8);
            this.cmdViewReserveList.Name = "cmdViewReserveList";
            this.cmdViewReserveList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdViewReserveList.Size = new System.Drawing.Size(25, 25);
            this.cmdViewReserveList.TabIndex = 24;
            this.cmdViewReserveList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdViewReserveList, "Click to View Reservation List");
            this.cmdViewReserveList.UseVisualStyleBackColor = false;
            this.cmdViewReserveList.Click += new System.EventHandler(this.cmdViewReserveList_Click);
            // 
            // cmdViewClient
            // 
            this.cmdViewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdViewClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdViewClient.Enabled = false;
            this.cmdViewClient.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdViewClient.Location = new System.Drawing.Point(208, 8);
            this.cmdViewClient.Name = "cmdViewClient";
            this.cmdViewClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdViewClient.Size = new System.Drawing.Size(25, 25);
            this.cmdViewClient.TabIndex = 25;
            this.cmdViewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdViewClient, "Click to View Guest List");
            this.cmdViewClient.UseVisualStyleBackColor = false;
            this.cmdViewClient.Click += new System.EventHandler(this.cmdViewClient_Click);
            // 
            // cmdReservedGuest
            // 
            this.cmdReservedGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cmdReservedGuest.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReservedGuest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReservedGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReservedGuest.Location = new System.Drawing.Point(459, 35);
            this.cmdReservedGuest.Name = "cmdReservedGuest";
            this.cmdReservedGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReservedGuest.Size = new System.Drawing.Size(61, 54);
            this.cmdReservedGuest.TabIndex = 164;
            this.cmdReservedGuest.Text = "&Reserved";
            this.cmdReservedGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdReservedGuest, "Reserved Guest Selection");
            this.cmdReservedGuest.UseVisualStyleBackColor = false;
            this.cmdReservedGuest.Click += new System.EventHandler(this.cmdReservedGuest_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdNew.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdNew.Location = new System.Drawing.Point(523, 35);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNew.Size = new System.Drawing.Size(61, 54);
            this.cmdNew.TabIndex = 166;
            this.cmdNew.Text = "&New";
            this.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdNew, "New Guest Selection");
            this.cmdNew.UseVisualStyleBackColor = false;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdOld
            // 
            this.cmdOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdOld.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOld.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOld.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOld.Location = new System.Drawing.Point(395, 35);
            this.cmdOld.Name = "cmdOld";
            this.cmdOld.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOld.Size = new System.Drawing.Size(61, 54);
            this.cmdOld.TabIndex = 165;
            this.cmdOld.Text = "&Existing";
            this.cmdOld.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdOld, "Existing Guest Selection");
            this.cmdOld.UseVisualStyleBackColor = false;
            this.cmdOld.Click += new System.EventHandler(this.cmdOld_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(716, 499);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(75, 41);
            this.cmdReturn.TabIndex = 151;
            this.cmdReturn.Text = "Retur&n";
            this.cmdReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdReturn, "Return to Operation Menu");
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdIssue
            // 
            this.cmdIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdIssue.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdIssue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIssue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIssue.Location = new System.Drawing.Point(587, 451);
            this.cmdIssue.Name = "cmdIssue";
            this.cmdIssue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdIssue.Size = new System.Drawing.Size(97, 40);
            this.cmdIssue.TabIndex = 148;
            this.cmdIssue.Text = "&ISSUE KEY";
            this.cmdIssue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdIssue, "Comfirm to issue card.");
            this.cmdIssue.UseVisualStyleBackColor = false;
            this.cmdIssue.Click += new System.EventHandler(this.cmdIssue_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClear.Location = new System.Drawing.Point(747, 451);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClear.Size = new System.Drawing.Size(44, 47);
            this.cmdClear.TabIndex = 150;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdClear, "Clear Screen Data");
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPrint.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPrint.Location = new System.Drawing.Point(681, 451);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPrint.Size = new System.Drawing.Size(57, 47);
            this.cmdPrint.TabIndex = 149;
            this.cmdPrint.Text = "&Print Recipt";
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdPrint, "Click to Print Receipt");
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(7, 538);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(58, 36);
            this.button3.TabIndex = 175;
            this.button3.Text = "&Recycle Card";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.button3, "Clear Screen Data");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMessage2
            // 
            this.lblMessage2.BackColor = System.Drawing.Color.White;
            this.lblMessage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage2.Location = new System.Drawing.Point(332, 538);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage2.Size = new System.Drawing.Size(353, 41);
            this.lblMessage2.TabIndex = 159;
            this.lblMessage2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMessage1
            // 
            this.lblMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage1.Location = new System.Drawing.Point(595, 43);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage1.Size = new System.Drawing.Size(193, 25);
            this.lblMessage1.TabIndex = 157;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(67, 538);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(270, 41);
            this.lblMessage.TabIndex = 155;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Enabled = false;
            this.Label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(3, 3);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(785, 25);
            this.Label2.TabIndex = 153;
            this.Label2.Text = "ISSUE ROOM KEY CARD";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Visible = false;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(681, 3);
            this.panel_CommStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CommStatus.Name = "panel_CommStatus";
            this.panel_CommStatus.Size = new System.Drawing.Size(118, 27);
            this.panel_CommStatus.TabIndex = 170;
            // 
            // pictureBox_COMM_Color
            // 
            this.pictureBox_COMM_Color.Location = new System.Drawing.Point(98, 2);
            this.pictureBox_COMM_Color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_COMM_Color.Name = "pictureBox_COMM_Color";
            this.pictureBox_COMM_Color.Size = new System.Drawing.Size(16, 17);
            this.pictureBox_COMM_Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_COMM_Color.TabIndex = 1;
            this.pictureBox_COMM_Color.TabStop = false;
            // 
            // label_CommState
            // 
            this.label_CommState.AutoSize = true;
            this.label_CommState.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CommState.ForeColor = System.Drawing.Color.Blue;
            this.label_CommState.Location = new System.Drawing.Point(4, 6);
            this.label_CommState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CommState.Name = "label_CommState";
            this.label_CommState.Size = new System.Drawing.Size(96, 13);
            this.label_CommState.TabIndex = 0;
            this.label_CommState.Text = "Connected State";
            // 
            // pictureBox_pdf
            // 
            this.pictureBox_pdf.ErrorImage = null;
            this.pictureBox_pdf.InitialImage = null;
            this.pictureBox_pdf.Location = new System.Drawing.Point(716, 538);
            this.pictureBox_pdf.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_pdf.Name = "pictureBox_pdf";
            this.pictureBox_pdf.Size = new System.Drawing.Size(22, 20);
            this.pictureBox_pdf.TabIndex = 169;
            this.pictureBox_pdf.TabStop = false;
            this.pictureBox_pdf.Visible = false;
            this.pictureBox_pdf.Click += new System.EventHandler(this.pictureBox_pdf_Click);
            // 
            // cmdReadCard
            // 
            this.cmdReadCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdReadCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReadCard.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdReadCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReadCard.Location = new System.Drawing.Point(587, 503);
            this.cmdReadCard.Name = "cmdReadCard";
            this.cmdReadCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReadCard.Size = new System.Drawing.Size(98, 36);
            this.cmdReadCard.TabIndex = 171;
            this.cmdReadCard.Text = "Check Card";
            this.cmdReadCard.UseVisualStyleBackColor = false;
            this.cmdReadCard.Click += new System.EventHandler(this.cmdReadCard_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 172;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 173;
            this.button1.Text = "Pull info from google doc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1184, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 125);
            this.button2.TabIndex = 174;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(577, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 177;
            this.button5.Text = "Go to admin center";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.txtFloorBuildingValue);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buildingValue);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Location = new System.Drawing.Point(805, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 576);
            this.panel1.TabIndex = 178;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(7, 88);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(55, 21);
            this.comboBox4.TabIndex = 206;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(68, 88);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(59, 21);
            this.comboBox5.TabIndex = 205;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(133, 88);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(60, 21);
            this.comboBox6.TabIndex = 204;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 203;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(133, 61);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 21);
            this.comboBox3.TabIndex = 202;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 201;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(7, 450);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(237, 121);
            this.textBox2.TabIndex = 199;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 420);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 198;
            this.button8.Text = "Check";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 395);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 197;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(4, 373);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 13);
            this.label44.TabIndex = 196;
            this.label44.Text = "Room Checker";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(6, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 195;
            this.button6.Text = "Create";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtFloorBuildingValue
            // 
            this.txtFloorBuildingValue.Enabled = false;
            this.txtFloorBuildingValue.Location = new System.Drawing.Point(6, 311);
            this.txtFloorBuildingValue.Name = "txtFloorBuildingValue";
            this.txtFloorBuildingValue.Size = new System.Drawing.Size(226, 20);
            this.txtFloorBuildingValue.TabIndex = 194;
            this.txtFloorBuildingValue.Visible = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Enabled = false;
            this.label42.Location = new System.Drawing.Point(3, 288);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(55, 13);
            this.label42.TabIndex = 193;
            this.label42.Text = "Floor Card";
            this.label42.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 192;
            this.button7.Text = "Create";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buildingValue
            // 
            this.buildingValue.Location = new System.Drawing.Point(6, 226);
            this.buildingValue.Name = "buildingValue";
            this.buildingValue.Size = new System.Drawing.Size(226, 20);
            this.buildingValue.TabIndex = 191;
            this.buildingValue.TextChanged += new System.EventHandler(this.buildingValue_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 203);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(69, 13);
            this.label43.TabIndex = 190;
            this.label43.Text = "Building Card";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 188;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(6, 143);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 187;
            this.dateTo.Value = new System.DateTime(2026, 2, 21, 0, 0, 0, 0);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(6, 117);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 186;
            this.dateFrom.Value = new System.DateTime(2025, 8, 21, 0, 0, 0, 0);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 45);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(98, 13);
            this.label41.TabIndex = 183;
            this.label41.Text = "Bulk GUEST Cards";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(56, 10);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(137, 20);
            this.label45.TabIndex = 207;
            this.label45.Text = "GUEST CARDS";
            this.label45.Click += new System.EventHandler(this.label45_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Moccasin;
            this.textBox4.Location = new System.Drawing.Point(587, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 417);
            this.textBox4.TabIndex = 179;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Moccasin;
            this.textBox5.Location = new System.Drawing.Point(7, 12);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(792, 576);
            this.textBox5.TabIndex = 180;
            // 
            // Form_IssueGuestCardDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1081, 586);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdUnitKey);
            this.Controls.Add(this.cmdReadCard);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.pictureBox_pdf);
            this.Controls.Add(this._optOldGuest_2);
            this.Controls.Add(this.cmdReservedGuest);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.cmdOld);
            this.Controls.Add(this.UnitFrame2);
            this.Controls.Add(this.ChargesFrame);
            this.Controls.Add(this.OldGuestFrame);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.cmdIssue);
            this.Controls.Add(this.Label37);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.RegistrationFrame);
            this.Controls.Add(this.ClientFrame);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ExtraChargeFrame);
            this.Name = "Form_IssueGuestCardDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_IssueGuestCardDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_IssueGuestCardDMS_Load);
            this.Shown += new System.EventHandler(this.Form_IssueGuestCardDMS_Shown);
            this.VisibleChanged += new System.EventHandler(this.Form_IssueGuestCardDMS_VisibleChanged);
            this.ExtraChargeFrame.ResumeLayout(false);
            this.ExtraChargeFrame.PerformLayout();
            this.ChargesFrame.ResumeLayout(false);
            this.ChargesFrame.PerformLayout();
            this.OldGuestFrame.ResumeLayout(false);
            this.RegistrationFrame.ResumeLayout(false);
            this.RegistrationFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StayingPeopleFrame.ResumeLayout(false);
            this.UnitFrame.ResumeLayout(false);
            this.UnitFrame.PerformLayout();
            this.ClientFrame.ResumeLayout(false);
            this.ClientFrame.PerformLayout();
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pdf)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
            string ApplicationName = "Google Sheets API .NET";

            // Authenticate and load credentials
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None).Result;
            }

            // Initialize the Sheets API service
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters
            string spreadsheetId = "1cW3VGIXYh-1HuGH_rJWKUF1UsN4uQT141-Y8GeaxViY"; // Replace with your actual spreadsheet ID
            string range = "Sheet1!A1:A2"; // Replace with your actual range

            // Fetch the data
            var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<object>> values = response.Values;

            // Process and display data using MessageBox
            if (values != null && values.Count > 0)
            {
                string data = "";
                foreach (var row in values)
                {
                    data += string.Join(", ", row) + "\n";
                }
                MessageBox.Show(data, "Google Sheets Data");
            }
            else
            {
                MessageBox.Show("No data found.", "Google Sheets Data");
            }
        }

        private void dateTimePicker_ContractStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!SmartCard_Procedures.Make_Empty_Card((int)Global_Data.COM_NUM, Global_Data.System_Pas_String))
            {
                int num24 = (int)MessageBox.Show("FAILURE report to andy!");
            }
            int num3 = (int)MessageBox.Show("Make Empty Card Success!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
            this.Visible = false;
            ModDoorLockSystem.Form_IssueCardDMS_Ptr.Show();
            //this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
            //ModDoorLockSystem.Form_OperationDMS_Ptr.Show();
            //this.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mssg = "failed";
            int n22222222 = int.Parse(comboBox1.Text + comboBox2.Text.PadLeft(2, '0') + comboBox3.Text.PadLeft(2, '0'));
            int n213213 = int.Parse(comboBox4.Text + comboBox5.Text.PadLeft(2, '0') + comboBox6.Text.PadLeft(2, '0'));
            for (int n = int.Parse(comboBox1.Text + comboBox2.Text.PadLeft(2, '0') + comboBox3.Text.PadLeft(2, '0'));
                 n <= int.Parse(comboBox4.Text + comboBox5.Text.PadLeft(2, '0') + comboBox6.Text.PadLeft(2, '0'));
                 n++)
            {
                var room = Convert.ToInt32(n.ToString().Substring(3, 2));
                var floor = Convert.ToInt32(n.ToString().Substring(1, 2));

                // Check if room is within the valid range for this floor
                if (floorRoomRanges[floor] == null ||
                    room < floorRoomRanges[floor].Start ||
                    room > floorRoomRanges[floor].End)
                {
                    continue;
                }

                //room0 not exist
                if (room == 0) continue;

                if (!SmartCard_Procedures.Make_Empty_Card((int)Global_Data.COM_NUM, Global_Data.System_Pas_String))
                {
                    int num24 = (int)MessageBox.Show("FAILURE report to andy@salen.io - " + n.ToString());
                }

                string para_string = Global_Data.System_Pas_String +
                       "0" + n.ToString().Substring(0, 1) +
                       n.ToString().Substring(1, 2) +
                       n.ToString().Substring(3, 2) +
                       (this.dateFrom.Value).Year.ToString().Substring(2, 2) +
                       (this.dateFrom.Value).Month.ToString("D2") +
                       (this.dateFrom.Value).Day.ToString("D2") +
                       "00" +
                       "01" +
                       (this.dateTo.Value).Year.ToString().Substring(2, 2) +
                       (this.dateTo.Value).Month.ToString("D2") +
                       (this.dateTo.Value).Day.ToString("D2") +
                       "00" +
                       "00" + "DEDEDEDE";

                bool reswrite = SmartCard_Procedures.Make_Guest_Card((int)Global_Data.COM_NUM, para_string);
                if (reswrite)
                {
                    if (!SmartCard_Procedures.ReadCardNumber((int)Global_Data.COM_NUM))
                    {
                        int numb999 = (int)MessageBox.Show("Failure writing card (read failed): " + n.ToString());
                    }
                    else
                    {
                        mssg = "success";
                    }

                    Global_Data.Card_AutoNumber = SmartCard_Procedures.Card_Number_String;
                    AMS.CardCheck.AddLogEntry(SmartCard_Procedures.Card_Number_String, n.ToString(),
                        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID,
                        this.dateFrom.Value,
                        this.dateTo.Value
                    );
                }
                else
                {
                    int num9992 = (int)MessageBox.Show("Write Failed!" + n.ToString());
                }

                int nu9s99m3 = (int)MessageBox.Show(mssg + " card: " + n.ToString() + " change card or fin");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //building card
            string buildingAndFloor = buildingValue.Text;
            if (buildingAndFloor.Length != 1)
            {
                int aaa = (int)MessageBox.Show("Failure: " + buildingAndFloor);
                return;
            }
            int num1 = int.Parse(buildingAndFloor.Substring(0, 1)); //4;//build #
            //int num2 = int.Parse(buildingAndFloor.Substring(1, 2)); ;//flr #
            //int num3 = int.Parse(Convert.ToString(n).Substring(3, 2));// rm#
            //string para_string = Global_Data.System_Pas_String + num1.ToString("D2") + "DEF8" + this.dateTimePicker_SettingDate.Text.Substring(2, 2) + this.dateTimePicker_SettingDate.Text.Substring(5, 2) + this.dateTimePicker_SettingDate.Text.Substring(8, 2) + this.mskSettingTime.Text.Substring(0, 2) + this.mskSettingTime.Text.Substring(3, 2);
            if (SmartCard_Procedures.Make_Building_Card((int)Global_Data.COM_NUM, Global_Data.System_Pas_String, num1.ToString("D2")))
            {
                int aaa = (int)MessageBox.Show("Success bld card: " + buildingAndFloor);
                //success
            }
            else
            {
                int aaa = (int)MessageBox.Show("Failure bld card: " + buildingAndFloor);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buildingValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 5)
            {
                int aaa = (int)MessageBox.Show("Wrong format of room number for cehcking");
                return;
            }

            var res = AMS.CardCheck.GetRecentLogEntriesByRoomId(textBox3.Text);
            textBox2.Text = "";
            foreach (var r in res)
            {
                textBox2.Text += r.todays_date.Year + "-" + r.todays_date.Month + "-" + r.todays_date.Day + " | " 
                        + r.user + " | " 
                        + r.from_date.Year + "-" + r.from_date.Month + "-" + r.to_date.Day + " -> " 
                        + r.to_date.Year +"-" + r.to_date.Month + "-" + r.to_date.Day + "\r\n";
            }

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.Value = new DateTime(dateFrom.Value.Year + 1, 2, 21);
        }
        /*
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curFloor = Convert.ToInt32(comboBox2.Text);
            PopulateComboBox3(floorRoomCounts[curFloor]);

        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curFloor = Convert.ToInt32(comboBox5.Text);
            PopulateComboBox6(floorRoomCounts[curFloor]);
        }*/
        private void PopulateComboBox3WithRange(int start, int end)
        {
            comboBox3.Items.Clear();
            for (int room = start; room <= end; room++)
            {
                comboBox3.Items.Add($"{room}");
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
        }

        // Event handler for when the selected floor changes
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedFloor))
            {
                if (floorRoomRanges[selectedFloor] != null)
                {
                    PopulateComboBox3WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
                }
                else
                {
                    comboBox3.Items.Clear();
                }
            }
        }

        // Similarly for comboBox5
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null && int.TryParse(comboBox5.SelectedItem.ToString(), out int selectedFloor))
            {
                if (floorRoomRanges[selectedFloor] != null)
                {
                    PopulateComboBox6WithRange(floorRoomRanges[selectedFloor].Start, floorRoomRanges[selectedFloor].End);
                }
                else
                {
                    comboBox6.Items.Clear();
                }
            }
        }

        // Helper method to populate comboBox6 with a range of room numbers
        private void PopulateComboBox6WithRange(int start, int end)
        {
            comboBox6.Items.Clear();
            for (int room = start; room <= end; room++)
            {
                comboBox6.Items.Add($"{room}");
            }
            if (comboBox6.Items.Count > 0)
            {
                comboBox6.SelectedIndex = 0;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
