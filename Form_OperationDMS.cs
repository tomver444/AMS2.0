// Decompiled with JetBrains decompiler
// Type: AMS.Form_OperationDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_OperationDMS : Form
  {
    private IContainer components;
    public ToolStripMenuItem mnuGRecordDate;
    public Button cmdBackup;
    public ToolStripMenuItem mnuCurrentGByDateRange;
    public ToolTip ToolTip1;
    public Button cmdRoomDetail;
    public Button cmdRoomInformation;
    public ToolStripMenuItem mnuCurrentGByLevelNo;
    public ToolStripMenuItem mnuCurrentGByBldNo;
    public ToolStripMenuItem mnuGrace;
    public ToolStripMenuItem mnuCurrent;
    public ToolStripMenuItem mnuCurrentGAccount;
    public ToolStripMenuItem mnuCurrentGInfo;
    public ToolStripMenuItem mnuCurrentGRecordDate;
    public Button cmdReservationList;
    public Button cmdCancelReservation;
    public Button cmdViewGuest;
    public Button cmdReadCard;
    public Button cmdCancelGuestCard;
    public ToolStripMenuItem mnuByRoomNo;
    public Button cmdReturn;
    public Button cmdGenerate;
    public Button cmdChangePassword;
    public Button cmdReservation;
    public Button cmdView;
    public Button cmdGuestDetail;
    public Button cmdNewGuest;
    public Label Label1;
    public ToolStripMenuItem mnuByName;
    public ToolStripMenuItem mnuRoom;
    public ToolStripMenuItem mnuView;
    public ToolStripMenuItem mnuReservation;
    public ToolStripMenuItem mnuCancelReservation;
    public ToolStripMenuItem mnuOperator;
    public ToolStripMenuItem mnuChange;
    public ToolStripMenuItem mnuBackup;
    public ToolStripMenuItem mnuDetail;
    public ToolStripMenuItem mnuGuestTransaction;
    public MenuStrip MainMenu1;
    public ToolStripMenuItem mnuguest;
    public ToolStripMenuItem mnuIssue;
    public ToolStripMenuItem mnuRead;
    public ToolStripMenuItem mnuCancel;
    public ToolStripMenuItem mnuGenerate;
    public ToolStripMenuItem cmdDReport;
    public ToolStripMenuItem mnuName;
    public ToolStripMenuItem mnuRoomNo;
    public ToolStripMenuItem mnuBuilding;
    public ToolStripMenuItem mnuFloor;
    public ToolStripMenuItem mnuGRoom;
    public ToolStripMenuItem mnuReservationList;
    public ToolStripMenuItem mnuRoomHistory;
    public ToolStripMenuItem mnuRInformation;
    public ToolStripMenuItem mnuORRDetail;
    public ToolStripMenuItem mnuGuestList;
    public ToolStripMenuItem mnuGHistory;
    public Label Label_BuildigName;
    private Panel panel_CommStatus;
    public PictureBox pictureBox_COMM_Color;
    private Label label_CommState;
        private TextBox textBox1;
        private DB db;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.mnuGRecordDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdBackup = new System.Windows.Forms.Button();
            this.mnuCurrentGByDateRange = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdRoomDetail = new System.Windows.Forms.Button();
            this.cmdRoomInformation = new System.Windows.Forms.Button();
            this.mnuCurrentGByLevelNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentGByBldNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentGAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentGInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentGRecordDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdReservationList = new System.Windows.Forms.Button();
            this.cmdCancelReservation = new System.Windows.Forms.Button();
            this.cmdViewGuest = new System.Windows.Forms.Button();
            this.cmdReadCard = new System.Windows.Forms.Button();
            this.cmdCancelGuestCard = new System.Windows.Forms.Button();
            this.mnuByRoomNo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.cmdReservation = new System.Windows.Forms.Button();
            this.cmdView = new System.Windows.Forms.Button();
            this.cmdGuestDetail = new System.Windows.Forms.Button();
            this.cmdNewGuest = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.mnuByName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuestTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuguest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuilding = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFloor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservationList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuORRDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuestList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_BuildigName = new System.Windows.Forms.Label();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenu1.SuspendLayout();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuGRecordDate
            // 
            this.mnuGRecordDate.Name = "mnuGRecordDate";
            this.mnuGRecordDate.Size = new System.Drawing.Size(171, 22);
            this.mnuGRecordDate.Text = "Guest Record Date";
            // 
            // cmdBackup
            // 
            this.cmdBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBackup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBackup.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBackup.Location = new System.Drawing.Point(299, 456);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBackup.Size = new System.Drawing.Size(185, 73);
            this.cmdBackup.TabIndex = 28;
            this.cmdBackup.Text = "System &Backup";
            this.cmdBackup.UseVisualStyleBackColor = false;
            this.cmdBackup.Visible = false;
            this.cmdBackup.Click += new System.EventHandler(this.cmdBackup_Click);
            // 
            // mnuCurrentGByDateRange
            // 
            this.mnuCurrentGByDateRange.Name = "mnuCurrentGByDateRange";
            this.mnuCurrentGByDateRange.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGByDateRange.Text = "By Date Range";
            // 
            // cmdRoomDetail
            // 
            this.cmdRoomDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(158)))), ((int)(((byte)(201)))));
            this.cmdRoomDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRoomDetail.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRoomDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRoomDetail.Location = new System.Drawing.Point(507, 296);
            this.cmdRoomDetail.Name = "cmdRoomDetail";
            this.cmdRoomDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRoomDetail.Size = new System.Drawing.Size(185, 73);
            this.cmdRoomDetail.TabIndex = 31;
            this.cmdRoomDetail.Text = "Occ&upied/Reserved Rooms Detail";
            this.cmdRoomDetail.UseVisualStyleBackColor = false;
            this.cmdRoomDetail.Visible = false;
            this.cmdRoomDetail.Click += new System.EventHandler(this.cmdRoomDetail_Click);
            // 
            // cmdRoomInformation
            // 
            this.cmdRoomInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdRoomInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRoomInformation.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRoomInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRoomInformation.Location = new System.Drawing.Point(507, 216);
            this.cmdRoomInformation.Name = "cmdRoomInformation";
            this.cmdRoomInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRoomInformation.Size = new System.Drawing.Size(185, 73);
            this.cmdRoomInformation.TabIndex = 30;
            this.cmdRoomInformation.Text = "Room In&formation";
            this.cmdRoomInformation.UseVisualStyleBackColor = false;
            this.cmdRoomInformation.Visible = false;
            this.cmdRoomInformation.Click += new System.EventHandler(this.cmdRoomInformation_Click);
            // 
            // mnuCurrentGByLevelNo
            // 
            this.mnuCurrentGByLevelNo.Name = "mnuCurrentGByLevelNo";
            this.mnuCurrentGByLevelNo.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGByLevelNo.Text = "By Level No";
            // 
            // mnuCurrentGByBldNo
            // 
            this.mnuCurrentGByBldNo.Name = "mnuCurrentGByBldNo";
            this.mnuCurrentGByBldNo.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGByBldNo.Text = "By Building No";
            // 
            // mnuGrace
            // 
            this.mnuGrace.Name = "mnuGrace";
            this.mnuGrace.Size = new System.Drawing.Size(237, 22);
            this.mnuGrace.Text = "Staying Grace Period Guest List";
            // 
            // mnuCurrent
            // 
            this.mnuCurrent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentGAccount,
            this.mnuCurrentGInfo,
            this.mnuCurrentGRecordDate,
            this.mnuCurrentGByBldNo,
            this.mnuCurrentGByLevelNo,
            this.mnuCurrentGByDateRange});
            this.mnuCurrent.Name = "mnuCurrent";
            this.mnuCurrent.Size = new System.Drawing.Size(237, 22);
            this.mnuCurrent.Text = "Current Staying Guest";
            // 
            // mnuCurrentGAccount
            // 
            this.mnuCurrentGAccount.Name = "mnuCurrentGAccount";
            this.mnuCurrentGAccount.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGAccount.Text = "Guest Account";
            // 
            // mnuCurrentGInfo
            // 
            this.mnuCurrentGInfo.Name = "mnuCurrentGInfo";
            this.mnuCurrentGInfo.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGInfo.Text = "Guest Info";
            // 
            // mnuCurrentGRecordDate
            // 
            this.mnuCurrentGRecordDate.Name = "mnuCurrentGRecordDate";
            this.mnuCurrentGRecordDate.Size = new System.Drawing.Size(171, 22);
            this.mnuCurrentGRecordDate.Text = "Guest Record Date";
            // 
            // cmdReservationList
            // 
            this.cmdReservationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdReservationList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReservationList.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReservationList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReservationList.Location = new System.Drawing.Point(507, 136);
            this.cmdReservationList.Name = "cmdReservationList";
            this.cmdReservationList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReservationList.Size = new System.Drawing.Size(185, 73);
            this.cmdReservationList.TabIndex = 29;
            this.cmdReservationList.Text = "Reservation Li&st";
            this.cmdReservationList.UseVisualStyleBackColor = false;
            this.cmdReservationList.Visible = false;
            this.cmdReservationList.Click += new System.EventHandler(this.cmdReservationList_Click);
            // 
            // cmdCancelReservation
            // 
            this.cmdCancelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdCancelReservation.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelReservation.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelReservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelReservation.Location = new System.Drawing.Point(299, 296);
            this.cmdCancelReservation.Name = "cmdCancelReservation";
            this.cmdCancelReservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelReservation.Size = new System.Drawing.Size(185, 73);
            this.cmdCancelReservation.TabIndex = 26;
            this.cmdCancelReservation.Text = "Cance&l Reservation";
            this.cmdCancelReservation.UseVisualStyleBackColor = false;
            this.cmdCancelReservation.Visible = false;
            this.cmdCancelReservation.Click += new System.EventHandler(this.cmdCancelReservation_Click);
            // 
            // cmdViewGuest
            // 
            this.cmdViewGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(167)))));
            this.cmdViewGuest.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdViewGuest.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdViewGuest.Location = new System.Drawing.Point(91, 376);
            this.cmdViewGuest.Name = "cmdViewGuest";
            this.cmdViewGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdViewGuest.Size = new System.Drawing.Size(185, 73);
            this.cmdViewGuest.TabIndex = 22;
            this.cmdViewGuest.Text = "View Guest &Transactions";
            this.cmdViewGuest.UseVisualStyleBackColor = false;
            this.cmdViewGuest.Visible = false;
            this.cmdViewGuest.Click += new System.EventHandler(this.cmdViewGuest_Click);
            // 
            // cmdReadCard
            // 
            this.cmdReadCard.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdReadCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReadCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReadCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReadCard.Location = new System.Drawing.Point(299, 188);
            this.cmdReadCard.Name = "cmdReadCard";
            this.cmdReadCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReadCard.Size = new System.Drawing.Size(185, 73);
            this.cmdReadCard.TabIndex = 20;
            this.cmdReadCard.Text = "♲ Read / Recycle Guest Card";
            this.cmdReadCard.UseVisualStyleBackColor = false;
            this.cmdReadCard.Click += new System.EventHandler(this.cmdReadCard_Click);
            // 
            // cmdCancelGuestCard
            // 
            this.cmdCancelGuestCard.BackColor = System.Drawing.Color.Salmon;
            this.cmdCancelGuestCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelGuestCard.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelGuestCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelGuestCard.Location = new System.Drawing.Point(299, 279);
            this.cmdCancelGuestCard.Name = "cmdCancelGuestCard";
            this.cmdCancelGuestCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelGuestCard.Size = new System.Drawing.Size(185, 73);
            this.cmdCancelGuestCard.TabIndex = 21;
            this.cmdCancelGuestCard.Text = "Check Out Guest";
            this.cmdCancelGuestCard.UseVisualStyleBackColor = false;
            this.cmdCancelGuestCard.Click += new System.EventHandler(this.cmdCancelGuestCard_Click);
            // 
            // mnuByRoomNo
            // 
            this.mnuByRoomNo.Name = "mnuByRoomNo";
            this.mnuByRoomNo.Size = new System.Drawing.Size(171, 22);
            this.mnuByRoomNo.Text = "Guest Account";
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(507, 456);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(185, 73);
            this.cmdReturn.TabIndex = 33;
            this.cmdReturn.Text = "← Return";
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.BackColor = System.Drawing.Color.Yellow;
            this.cmdGenerate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGenerate.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGenerate.Location = new System.Drawing.Point(507, 376);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGenerate.Size = new System.Drawing.Size(185, 73);
            this.cmdGenerate.TabIndex = 32;
            this.cmdGenerate.Text = "&Other Reports";
            this.cmdGenerate.UseVisualStyleBackColor = false;
            this.cmdGenerate.Visible = false;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.BackColor = System.Drawing.Color.LightYellow;
            this.cmdChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdChangePassword.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdChangePassword.Location = new System.Drawing.Point(299, 370);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdChangePassword.Size = new System.Drawing.Size(185, 73);
            this.cmdChangePassword.TabIndex = 27;
            this.cmdChangePassword.Text = "Change &Password";
            this.cmdChangePassword.UseVisualStyleBackColor = false;
            this.cmdChangePassword.Click += new System.EventHandler(this.cmdChangePassword_Click);
            // 
            // cmdReservation
            // 
            this.cmdReservation.BackColor = System.Drawing.Color.Cyan;
            this.cmdReservation.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReservation.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReservation.Location = new System.Drawing.Point(299, 136);
            this.cmdReservation.Name = "cmdReservation";
            this.cmdReservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReservation.Size = new System.Drawing.Size(185, 73);
            this.cmdReservation.TabIndex = 24;
            this.cmdReservation.Text = "Room &Reservation";
            this.cmdReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReservation.UseVisualStyleBackColor = false;
            this.cmdReservation.Visible = false;
            this.cmdReservation.Click += new System.EventHandler(this.cmdReservation_Click);
            // 
            // cmdView
            // 
            this.cmdView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdView.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdView.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdView.Location = new System.Drawing.Point(299, 216);
            this.cmdView.Name = "cmdView";
            this.cmdView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdView.Size = new System.Drawing.Size(185, 73);
            this.cmdView.TabIndex = 25;
            this.cmdView.Text = "&View Room Status";
            this.cmdView.UseVisualStyleBackColor = false;
            this.cmdView.Visible = false;
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
            // 
            // cmdGuestDetail
            // 
            this.cmdGuestDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdGuestDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGuestDetail.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuestDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGuestDetail.Location = new System.Drawing.Point(91, 456);
            this.cmdGuestDetail.Name = "cmdGuestDetail";
            this.cmdGuestDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGuestDetail.Size = new System.Drawing.Size(185, 73);
            this.cmdGuestDetail.TabIndex = 23;
            this.cmdGuestDetail.Text = "Guest &Detail";
            this.cmdGuestDetail.UseVisualStyleBackColor = false;
            this.cmdGuestDetail.Visible = false;
            this.cmdGuestDetail.Click += new System.EventHandler(this.cmdGuestDetail_Click);
            // 
            // cmdNewGuest
            // 
            this.cmdNewGuest.BackColor = System.Drawing.Color.Yellow;
            this.cmdNewGuest.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdNewGuest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdNewGuest.Location = new System.Drawing.Point(299, 99);
            this.cmdNewGuest.Name = "cmdNewGuest";
            this.cmdNewGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNewGuest.Size = new System.Drawing.Size(185, 73);
            this.cmdNewGuest.TabIndex = 19;
            this.cmdNewGuest.Text = "Issue Guest Key";
            this.cmdNewGuest.UseVisualStyleBackColor = false;
            this.cmdNewGuest.Click += new System.EventHandler(this.cmdNewGuest_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label1.Location = new System.Drawing.Point(132, 26);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(539, 49);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Guest Mode ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnuByName
            // 
            this.mnuByName.Name = "mnuByName";
            this.mnuByName.Size = new System.Drawing.Size(171, 22);
            this.mnuByName.Text = "Guest List";
            // 
            // mnuRoom
            // 
            this.mnuRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView,
            this.mnuReservation,
            this.mnuCancelReservation});
            this.mnuRoom.Name = "mnuRoom";
            this.mnuRoom.Size = new System.Drawing.Size(75, 20);
            this.mnuRoom.Text = "Room In&fo";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(174, 22);
            this.mnuView.Text = "&View Room Status";
            // 
            // mnuReservation
            // 
            this.mnuReservation.Name = "mnuReservation";
            this.mnuReservation.Size = new System.Drawing.Size(174, 22);
            this.mnuReservation.Text = "Room &Reservation";
            // 
            // mnuCancelReservation
            // 
            this.mnuCancelReservation.Name = "mnuCancelReservation";
            this.mnuCancelReservation.Size = new System.Drawing.Size(174, 22);
            this.mnuCancelReservation.Text = "Cance&l Reservation";
            // 
            // mnuOperator
            // 
            this.mnuOperator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChange,
            this.mnuBackup});
            this.mnuOperator.Name = "mnuOperator";
            this.mnuOperator.Size = new System.Drawing.Size(66, 20);
            this.mnuOperator.Text = "&Operator";
            // 
            // mnuChange
            // 
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.Size = new System.Drawing.Size(168, 22);
            this.mnuChange.Text = "Change &Password";
            // 
            // mnuBackup
            // 
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(168, 22);
            this.mnuBackup.Text = "Data Bac&kup";
            // 
            // mnuDetail
            // 
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Size = new System.Drawing.Size(195, 22);
            this.mnuDetail.Text = "Guest &Detail ";
            // 
            // mnuGuestTransaction
            // 
            this.mnuGuestTransaction.Name = "mnuGuestTransaction";
            this.mnuGuestTransaction.Size = new System.Drawing.Size(195, 22);
            this.mnuGuestTransaction.Text = "View Gu&est Transaction";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuguest,
            this.mnuRoom,
            this.mnuOperator,
            this.mnuGenerate});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(790, 24);
            this.MainMenu1.TabIndex = 36;
            this.MainMenu1.Visible = false;
            // 
            // mnuguest
            // 
            this.mnuguest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIssue,
            this.mnuRead,
            this.mnuCancel,
            this.mnuGuestTransaction,
            this.mnuDetail});
            this.mnuguest.Name = "mnuguest";
            this.mnuguest.Size = new System.Drawing.Size(73, 20);
            this.mnuguest.Text = "G&uest Info";
            // 
            // mnuIssue
            // 
            this.mnuIssue.Name = "mnuIssue";
            this.mnuIssue.Size = new System.Drawing.Size(195, 22);
            this.mnuIssue.Text = "&Issue Guest Card";
            // 
            // mnuRead
            // 
            this.mnuRead.Name = "mnuRead";
            this.mnuRead.Size = new System.Drawing.Size(195, 22);
            this.mnuRead.Text = "Read Guest C&ard";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(195, 22);
            this.mnuCancel.Text = "&Cancel Guest Card";
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdDReport,
            this.mnuGRoom,
            this.mnuGuestList,
            this.mnuGrace,
            this.mnuCurrent});
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(109, 20);
            this.mnuGenerate.Text = "&Generate Reports";
            // 
            // cmdDReport
            // 
            this.cmdDReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuName,
            this.mnuRoomNo,
            this.mnuBuilding,
            this.mnuFloor});
            this.cmdDReport.Name = "cmdDReport";
            this.cmdDReport.Size = new System.Drawing.Size(237, 22);
            this.cmdDReport.Text = "D&etail Card Issued For Guest";
            // 
            // mnuName
            // 
            this.mnuName.Name = "mnuName";
            this.mnuName.Size = new System.Drawing.Size(169, 22);
            this.mnuName.Text = "&By Guest ID";
            // 
            // mnuRoomNo
            // 
            this.mnuRoomNo.Name = "mnuRoomNo";
            this.mnuRoomNo.Size = new System.Drawing.Size(169, 22);
            this.mnuRoomNo.Text = "By Room Nu&mber";
            // 
            // mnuBuilding
            // 
            this.mnuBuilding.Name = "mnuBuilding";
            this.mnuBuilding.Size = new System.Drawing.Size(169, 22);
            this.mnuBuilding.Text = "B&y Building ";
            // 
            // mnuFloor
            // 
            this.mnuFloor.Name = "mnuFloor";
            this.mnuFloor.Size = new System.Drawing.Size(169, 22);
            this.mnuFloor.Text = "By Fl&oor ";
            // 
            // mnuGRoom
            // 
            this.mnuGRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReservationList,
            this.mnuRoomHistory,
            this.mnuRInformation,
            this.mnuORRDetail});
            this.mnuGRoom.Name = "mnuGRoom";
            this.mnuGRoom.Size = new System.Drawing.Size(237, 22);
            this.mnuGRoom.Text = "General Room";
            // 
            // mnuReservationList
            // 
            this.mnuReservationList.Name = "mnuReservationList";
            this.mnuReservationList.Size = new System.Drawing.Size(245, 22);
            this.mnuReservationList.Text = "Reservation List";
            // 
            // mnuRoomHistory
            // 
            this.mnuRoomHistory.Name = "mnuRoomHistory";
            this.mnuRoomHistory.Size = new System.Drawing.Size(245, 22);
            this.mnuRoomHistory.Text = "Room History";
            // 
            // mnuRInformation
            // 
            this.mnuRInformation.Name = "mnuRInformation";
            this.mnuRInformation.Size = new System.Drawing.Size(245, 22);
            this.mnuRInformation.Text = "Room Information";
            // 
            // mnuORRDetail
            // 
            this.mnuORRDetail.Name = "mnuORRDetail";
            this.mnuORRDetail.Size = new System.Drawing.Size(245, 22);
            this.mnuORRDetail.Text = "Occupied/Reserved Room Detail";
            // 
            // mnuGuestList
            // 
            this.mnuGuestList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGHistory,
            this.mnuByName,
            this.mnuByRoomNo,
            this.mnuGRecordDate});
            this.mnuGuestList.Name = "mnuGuestList";
            this.mnuGuestList.Size = new System.Drawing.Size(237, 22);
            this.mnuGuestList.Text = "General Gue&st ";
            // 
            // mnuGHistory
            // 
            this.mnuGHistory.Name = "mnuGHistory";
            this.mnuGHistory.Size = new System.Drawing.Size(171, 22);
            this.mnuGHistory.Text = "Guest History";
            // 
            // Label_BuildigName
            // 
            this.Label_BuildigName.BackColor = System.Drawing.SystemColors.Control;
            this.Label_BuildigName.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_BuildigName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuildigName.ForeColor = System.Drawing.Color.Red;
            this.Label_BuildigName.Location = new System.Drawing.Point(3, 88);
            this.Label_BuildigName.Name = "Label_BuildigName";
            this.Label_BuildigName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_BuildigName.Size = new System.Drawing.Size(785, 33);
            this.Label_BuildigName.TabIndex = 34;
            this.Label_BuildigName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(671, 26);
            this.panel_CommStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CommStatus.Name = "panel_CommStatus";
            this.panel_CommStatus.Size = new System.Drawing.Size(119, 28);
            this.panel_CommStatus.TabIndex = 173;
            // 
            // pictureBox_COMM_Color
            // 
            this.pictureBox_COMM_Color.Image = global::AMS.Properties.Resources.COM_RED;
            this.pictureBox_COMM_Color.InitialImage = global::AMS.Properties.Resources.COM_YELLOW;
            this.pictureBox_COMM_Color.Location = new System.Drawing.Point(101, 3);
            this.pictureBox_COMM_Color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_COMM_Color.Name = "pictureBox_COMM_Color";
            this.pictureBox_COMM_Color.Size = new System.Drawing.Size(16, 16);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 468);
            this.textBox1.TabIndex = 174;
            // 
            // Form_OperationDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 576);
            this.Controls.Add(this.cmdReadCard);
            this.Controls.Add(this.cmdCancelGuestCard);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.cmdNewGuest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.cmdBackup);
            this.Controls.Add(this.cmdRoomDetail);
            this.Controls.Add(this.cmdRoomInformation);
            this.Controls.Add(this.cmdReservationList);
            this.Controls.Add(this.cmdCancelReservation);
            this.Controls.Add(this.cmdViewGuest);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.cmdReservation);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.cmdGuestDetail);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MainMenu1);
            this.Controls.Add(this.Label_BuildigName);
            this.Name = "Form_OperationDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
            this.Activated += new System.EventHandler(this.Form_OperationDMS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_OperationDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_OperationDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_OperationDMS_VisibleChanged);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form_OperationDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void Change_BkGolr_for_Disable_Buttons()
    {
      if (!this.cmdBackup.Enabled)
        this.cmdBackup.BackColor = SystemColors.Control;
      if (!this.cmdChangePassword.Enabled)
        this.cmdChangePassword.BackColor = SystemColors.Control;
      if (!this.cmdDReport.Enabled)
        this.cmdDReport.BackColor = SystemColors.Control;
      if (!this.cmdGenerate.Enabled)
        this.cmdGenerate.BackColor = SystemColors.Control;
      if (!this.cmdGuestDetail.Enabled)
        this.cmdGuestDetail.BackColor = SystemColors.Control;
      if (!this.cmdViewGuest.Enabled)
        this.cmdViewGuest.BackColor = SystemColors.Control;
      if (!this.cmdReservationList.Enabled)
        this.cmdReservationList.BackColor = SystemColors.Control;
      if (!this.cmdRoomInformation.Enabled)
        this.cmdRoomInformation.BackColor = SystemColors.Control;
      if (this.cmdRoomDetail.Enabled)
        return;
      this.cmdRoomDetail.BackColor = SystemColors.Control;
    }

    private void Form_OperationDMS_Load(object sender, EventArgs e)
    {
      this.Change_BkGolr_for_Disable_Buttons();
    }

    private void Form_OperationDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_OperationDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.SetTopLevel(true);
    }

    private void Form_OperationDMS_Activated(object sender, EventArgs e) => this.SetTopLevel(true);

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      this.db.UPDATE_LOGOUT(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
      ModDoorLockSystem.Form_MainDMS_Ptr.Visible = true;
    }

    private void cmdNewGuest_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_IssueGuestCard_Ptr.Show();
      this.Visible = false;
    }

    private void cmdReadCard_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ReadGuestCardDMS_Ptr.Show();
    }

    private void cmdCancelGuestCard_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_CancelGuestCardDMS_Ptr.Show();
    }

    private void cmdViewGuest_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ViewGuestTransDMS_Ptr.Show();
    }

    private void cmdGuestDetail_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_GuestDetailDMS_Ptr.Show();
    }

    private void cmdReservation_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_SHL_ViewRoomReservation_Ptr.Show();
      this.Visible = false;
    }

    private void cmdView_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_SHL_AvailableRoom_Ptr.Show();
      this.Visible = false;
    }

    private void cmdCancelReservation_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_CancelReservationDMS_Ptr.Show();
    }

    private void cmdChangePassword_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ChangePasswordDMS_Ptr.Show();
    }

    private void cmdBackup_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      int num = (int) new Form_BackupDMS().ShowDialog();
      this.Visible = true;
    }

    private void cmdReservationList_Click(object sender, EventArgs e)
    {
      Global_Data.sBuildingName = this.db.RetrieveBldName(Global_Data.sBldNo);
      ReportForm reportForm = new ReportForm();
      ReportClass_ReservationList classReservationList = new ReportClass_ReservationList();
      reportForm.crystalReportViewer1.ReportSource = (object) classReservationList.CHECK_RESERVATIONLIST(Global_Data.bCurrent, DateTime.Today.ToShortDateString());
      int num = (int) reportForm.ShowDialog();
    }

    private void cmdRoomInformation_Click(object sender, EventArgs e)
    {
      Global_Data.sBuildingName = this.db.RetrieveBldName(Global_Data.sBldNo);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sBldNo = Global_Data.sBldNo;
      ReportForm reportForm = new ReportForm();
      ReportClass_RoomInformation classRoomInformation = new ReportClass_RoomInformation();
      reportForm.crystalReportViewer1.ReportSource = (object) classRoomInformation.CHECK_ROOMINFORMATION(Global_Data.bCurrent);
      int num = (int) reportForm.ShowDialog();
    }

    private void cmdRoomDetail_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 5;
      ModDoorLockSystem.Form_OtherReportsDMS_Ptr.Show();
    }

    private void cmdGenerate_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 0;
      ModDoorLockSystem.Form_OtherReportsDMS_Ptr.Show();
    }
  }
}
