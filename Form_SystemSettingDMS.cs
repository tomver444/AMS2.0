// Decompiled with JetBrains decompiler
// Type: AMS.Form_SystemSettingDMS
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
  public class Form_SystemSettingDMS : Form
  {
    private IContainer components;
    public GroupBox Frame2;
    public Button cmdMRoomSetup;
    public Button cmdIRoomSetup;
    public Button cmdType;
    public Button cmdStatus;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public Button cmdSystemDescription;
    public Button cmdCreateRoom;
    public Button cmdCreateZone;
    public Label Label_Description;
    public ToolStripMenuItem mnuRoomType;
    public ToolStripMenuItem mnuZone;
    public ToolStripMenuItem mnuDescription;
    public ToolStripMenuItem mnuSetting;
    public ToolStripMenuItem mnuRoom;
    public MenuStrip MainMenu1;
    public ToolStripMenuItem mnuMaintenance;
    public ToolStripMenuItem mnuRoomSetup;
    public ToolStripMenuItem mnuIndividualRoom;
    public ToolStripMenuItem mnuMultipleRooms;
    public ToolStripMenuItem mnuRoomStatus;
    public Label Label2;
    private Panel panel_CommStatus;
    public PictureBox pictureBox_COMM_Color;
    private Label label_CommState;
    public Button button_ChangeSysCode;
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
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.cmdMRoomSetup = new System.Windows.Forms.Button();
            this.cmdIRoomSetup = new System.Windows.Forms.Button();
            this.cmdType = new System.Windows.Forms.Button();
            this.cmdStatus = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdSystemDescription = new System.Windows.Forms.Button();
            this.cmdCreateRoom = new System.Windows.Forms.Button();
            this.cmdCreateZone = new System.Windows.Forms.Button();
            this.Label_Description = new System.Windows.Forms.Label();
            this.mnuRoomType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIndividualRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMultipleRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.button_ChangeSysCode = new System.Windows.Forms.Button();
            this.Frame2.SuspendLayout();
            this.MainMenu1.SuspendLayout();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Frame2.Controls.Add(this.cmdMRoomSetup);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(663, 98);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(193, 161);
            this.Frame2.TabIndex = 21;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "ROOM SETUP :";
            this.Frame2.Visible = false;
            // 
            // cmdMRoomSetup
            // 
            this.cmdMRoomSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdMRoomSetup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdMRoomSetup.Enabled = false;
            this.cmdMRoomSetup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMRoomSetup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdMRoomSetup.Location = new System.Drawing.Point(20, 96);
            this.cmdMRoomSetup.Name = "cmdMRoomSetup";
            this.cmdMRoomSetup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMRoomSetup.Size = new System.Drawing.Size(153, 49);
            this.cmdMRoomSetup.TabIndex = 6;
            this.cmdMRoomSetup.Text = "&Multiple Rooms Setup";
            this.cmdMRoomSetup.UseVisualStyleBackColor = false;
            this.cmdMRoomSetup.Click += new System.EventHandler(this.cmdMRoomSetup_Click);
            // 
            // cmdIRoomSetup
            // 
            this.cmdIRoomSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(79)))));
            this.cmdIRoomSetup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdIRoomSetup.Font = new System.Drawing.Font("Arial", 13.5F);
            this.cmdIRoomSetup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIRoomSetup.Location = new System.Drawing.Point(67, 408);
            this.cmdIRoomSetup.Name = "cmdIRoomSetup";
            this.cmdIRoomSetup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdIRoomSetup.Size = new System.Drawing.Size(185, 73);
            this.cmdIRoomSetup.TabIndex = 5;
            this.cmdIRoomSetup.Text = "&Individual Room Setup";
            this.cmdIRoomSetup.UseVisualStyleBackColor = false;
            this.cmdIRoomSetup.Click += new System.EventHandler(this.cmdIRoomSetup_Click);
            // 
            // cmdType
            // 
            this.cmdType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdType.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdType.Location = new System.Drawing.Point(326, 408);
            this.cmdType.Name = "cmdType";
            this.cmdType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdType.Size = new System.Drawing.Size(185, 73);
            this.cmdType.TabIndex = 16;
            this.cmdType.Text = "Create Room &Type";
            this.cmdType.UseVisualStyleBackColor = false;
            this.cmdType.Click += new System.EventHandler(this.cmdType_Click);
            // 
            // cmdStatus
            // 
            this.cmdStatus.BackColor = System.Drawing.Color.Cyan;
            this.cmdStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdStatus.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdStatus.Location = new System.Drawing.Point(326, 293);
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdStatus.Size = new System.Drawing.Size(185, 73);
            this.cmdStatus.TabIndex = 17;
            this.cmdStatus.Text = "Room St&atus";
            this.cmdStatus.UseVisualStyleBackColor = false;
            this.cmdStatus.Click += new System.EventHandler(this.cmdStatus_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(589, 408);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(185, 73);
            this.cmdReturn.TabIndex = 18;
            this.cmdReturn.Text = "Retur&n";
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdSystemDescription
            // 
            this.cmdSystemDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdSystemDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSystemDescription.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSystemDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSystemDescription.Location = new System.Drawing.Point(67, 175);
            this.cmdSystemDescription.Name = "cmdSystemDescription";
            this.cmdSystemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSystemDescription.Size = new System.Drawing.Size(185, 73);
            this.cmdSystemDescription.TabIndex = 13;
            this.cmdSystemDescription.Text = "System &Description";
            this.cmdSystemDescription.UseVisualStyleBackColor = false;
            this.cmdSystemDescription.Click += new System.EventHandler(this.cmdSystemDescription_Click);
            // 
            // cmdCreateRoom
            // 
            this.cmdCreateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.cmdCreateRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCreateRoom.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreateRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCreateRoom.Location = new System.Drawing.Point(67, 293);
            this.cmdCreateRoom.Name = "cmdCreateRoom";
            this.cmdCreateRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCreateRoom.Size = new System.Drawing.Size(185, 73);
            this.cmdCreateRoom.TabIndex = 15;
            this.cmdCreateRoom.Text = "Create &Room";
            this.cmdCreateRoom.UseVisualStyleBackColor = false;
            this.cmdCreateRoom.Click += new System.EventHandler(this.cmdCreateRoom_Click);
            // 
            // cmdCreateZone
            // 
            this.cmdCreateZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCreateZone.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCreateZone.Enabled = false;
            this.cmdCreateZone.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreateZone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCreateZone.Location = new System.Drawing.Point(663, 49);
            this.cmdCreateZone.Name = "cmdCreateZone";
            this.cmdCreateZone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCreateZone.Size = new System.Drawing.Size(185, 73);
            this.cmdCreateZone.TabIndex = 14;
            this.cmdCreateZone.Text = "Create &Zone";
            this.cmdCreateZone.UseVisualStyleBackColor = false;
            this.cmdCreateZone.Visible = false;
            this.cmdCreateZone.Click += new System.EventHandler(this.cmdCreateZone_Click);
            // 
            // Label_Description
            // 
            this.Label_Description.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Description.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Description.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.ForeColor = System.Drawing.Color.Blue;
            this.Label_Description.Location = new System.Drawing.Point(99, 24);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Description.Size = new System.Drawing.Size(573, 41);
            this.Label_Description.TabIndex = 20;
            this.Label_Description.Text = "Contact Smart Card Door Lock System";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnuRoomType
            // 
            this.mnuRoomType.Name = "mnuRoomType";
            this.mnuRoomType.Size = new System.Drawing.Size(142, 22);
            this.mnuRoomType.Text = "Room &Type";
            // 
            // mnuZone
            // 
            this.mnuZone.Name = "mnuZone";
            this.mnuZone.Size = new System.Drawing.Size(175, 22);
            this.mnuZone.Text = "Create &Zone";
            // 
            // mnuDescription
            // 
            this.mnuDescription.Name = "mnuDescription";
            this.mnuDescription.Size = new System.Drawing.Size(175, 22);
            this.mnuDescription.Text = "System &Description";
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDescription,
            this.mnuZone,
            this.mnuRoom});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(56, 20);
            this.mnuSetting.Text = "&Setting";
            // 
            // mnuRoom
            // 
            this.mnuRoom.Name = "mnuRoom";
            this.mnuRoom.Size = new System.Drawing.Size(175, 22);
            this.mnuRoom.Text = "Create &Room";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetting,
            this.mnuMaintenance});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(792, 24);
            this.MainMenu1.TabIndex = 22;
            this.MainMenu1.Visible = false;
            // 
            // mnuMaintenance
            // 
            this.mnuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRoomSetup,
            this.mnuRoomStatus,
            this.mnuRoomType});
            this.mnuMaintenance.Name = "mnuMaintenance";
            this.mnuMaintenance.Size = new System.Drawing.Size(88, 20);
            this.mnuMaintenance.Text = "&Maintenance";
            // 
            // mnuRoomSetup
            // 
            this.mnuRoomSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIndividualRoom,
            this.mnuMultipleRooms});
            this.mnuRoomSetup.Name = "mnuRoomSetup";
            this.mnuRoomSetup.Size = new System.Drawing.Size(142, 22);
            this.mnuRoomSetup.Text = "Room Set&up ";
            // 
            // mnuIndividualRoom
            // 
            this.mnuIndividualRoom.Name = "mnuIndividualRoom";
            this.mnuIndividualRoom.Size = new System.Drawing.Size(161, 22);
            this.mnuIndividualRoom.Text = "&Individual Room";
            // 
            // mnuMultipleRooms
            // 
            this.mnuMultipleRooms.Name = "mnuMultipleRooms";
            this.mnuMultipleRooms.Size = new System.Drawing.Size(161, 22);
            this.mnuMultipleRooms.Text = "&Multiple Rooms";
            // 
            // mnuRoomStatus
            // 
            this.mnuRoomStatus.Name = "mnuRoomStatus";
            this.mnuRoomStatus.Size = new System.Drawing.Size(142, 22);
            this.mnuRoomStatus.Text = "Room St&atus";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(3, 80);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(785, 33);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "SYSTEM SETTING";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(673, 24);
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
            // button_ChangeSysCode
            // 
            this.button_ChangeSysCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ChangeSysCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_ChangeSysCode.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangeSysCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ChangeSysCode.Location = new System.Drawing.Point(326, 170);
            this.button_ChangeSysCode.Name = "button_ChangeSysCode";
            this.button_ChangeSysCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_ChangeSysCode.Size = new System.Drawing.Size(185, 73);
            this.button_ChangeSysCode.TabIndex = 174;
            this.button_ChangeSysCode.Text = "C&hange Authorization Code";
            this.button_ChangeSysCode.UseVisualStyleBackColor = false;
            this.button_ChangeSysCode.Click += new System.EventHandler(this.button_ChangeSysCode_Click);
            // 
            // Form_SystemSettingDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 569);
            this.Controls.Add(this.button_ChangeSysCode);
            this.Controls.Add(this.cmdIRoomSetup);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.cmdType);
            this.Controls.Add(this.cmdStatus);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.cmdSystemDescription);
            this.Controls.Add(this.cmdCreateRoom);
            this.Controls.Add(this.cmdCreateZone);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.MainMenu1);
            this.Controls.Add(this.Label2);
            this.Name = "Form_SystemSettingDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SystemSettingDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_SystemSettingDMS_Load);
            this.Frame2.ResumeLayout(false);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form_SystemSettingDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_MainDMS_Ptr.TopLevel = true;
      this.db.UPDATE_LOGOUT(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
      ModDoorLockSystem.Form_MainDMS_Ptr.Visible = true;
    }

    private void cmdSystemDescription_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_DescriptionDMS_Ptr.Show();
    }

    private void cmdCreateZone_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_CreateZoneDMS_Ptr.Show();
    }

    private void cmdCreateRoom_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_CreateRoomDMS_Ptr.Show();
    }

    private void cmdType_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Show();
    }

    private void cmdStatus_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr.Show();
    }

    private void cmdIRoomSetup_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr.Show();
    }

    private void cmdMRoomSetup_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_MRoomsSetupDMS_Ptr.Show();
    }

    private void Form_SystemSettingDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void button_ChangeSysCode_Click(object sender, EventArgs e)
    {
      if (!Global_Data.Card_Reader_Found_Flag)
      {
        int num = (int) MessageBox.Show("Card Reader Not Found!");
      }
      else
      {
        if (MessageBox.Show("Please comfirm Yes/No ?\n\rChange Authorization Code?", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes || !SmartCard_Procedures.ReadSysPasInformation((int) Global_Data.COM_NUM))
          return;
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Set_HotelCode(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
      }
    }

    private void Change_BkGolr_for_Disable_Buttons()
    {
      if (!this.cmdCreateRoom.Enabled)
        this.cmdCreateRoom.BackColor = SystemColors.Control;
      if (!this.cmdType.Enabled)
        this.cmdType.BackColor = SystemColors.Control;
      if (!this.cmdCreateZone.Enabled)
        this.cmdCreateZone.BackColor = SystemColors.Control;
      if (!this.cmdIRoomSetup.Enabled)
        this.cmdIRoomSetup.BackColor = SystemColors.Control;
      if (!this.cmdMRoomSetup.Enabled)
        this.cmdMRoomSetup.BackColor = SystemColors.Control;
      if (this.cmdStatus.Enabled)
        return;
      this.cmdStatus.BackColor = SystemColors.Control;
    }

    private void Form_SystemSettingDMS_Load(object sender, EventArgs e)
    {
      this.Change_BkGolr_for_Disable_Buttons();
    }
  }
}
