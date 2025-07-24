// Decompiled with JetBrains decompiler
// Type: AMS.Form_MainDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using AMS.SystemDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_MainDMS : Form
  {
    private DB db;
    private bool _1stTime_Flag = true;
    private bool Init_Flag;
    private IContainer components;
    private Label label_Description;
    private Button button_Operation;
    private Button button_Exit;
    private Button button_System;
    private Button button_Admin;
    private Label label_BuildingName;
    private SystemDataSet SystemDataSet;
    private BindingSource countryBindingSource;
    private CountryTableAdapter countryTableAdapter;
    public Label lblMessage;
    private Panel panel_CommStatus;
    public PictureBox pictureBox_COMM_Color;
    private Label label_CommState;
    private System.Windows.Forms.Timer timer1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem optionsToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private ToolStripMenuItem selectCOMPortToolStripMenuItem;

    public Form_MainDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void button_Exit_Click(object sender, EventArgs e) => Application.Exit();

    private void Check_Account_N_Setup()
    {
      if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0"))
        return;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 = "1";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding = "0";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB1 = "1";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 = "2";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB2 = "2";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 = "3";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB3 = "3";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 = "4";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB4 = "4";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 = "5";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB5 = "5";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 = "6";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB6 = "6";
    }

    private void button_Operation_Click(object sender, EventArgs e)
    {
            this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
            ModDoorLockSystem.Form_OperationDMS_Ptr.Show();
            this.Visible = false;
            /*ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin = false;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bSystemMode = false;
            ModDoorLockSystem.Form_LoginDMS_Ptr.lblLogin.Text = "Operator Login";
            ModDoorLockSystem.Form_LoginDMS_Ptr.Show((IWin32Window) this);
            this.Visible = false;*/
        }

    private void button_Admin_Click(object sender, EventArgs e)
    {
            this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
            ModDoorLockSystem.Form_AdminDMS_Ptr.Show();
            this.Visible = false;
            /*ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin = true;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bSystemMode = false;
            ModDoorLockSystem.Form_LoginDMS_Ptr.lblLogin.Text = "Admin Login";
            ModDoorLockSystem.Form_LoginDMS_Ptr.Show((IWin32Window) this);
            this.Visible = false;*/
        }

    private void button_System_Click(object sender, EventArgs e)
    {
        this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
        ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Show();
        this.Visible = false;
        /*ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin = true;
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bSystemMode = true;
        ModDoorLockSystem.Form_LoginDMS_Ptr.lblLogin.Text = "System Login";
        ModDoorLockSystem.Form_LoginDMS_Ptr.Show((IWin32Window) this);
        this.Visible = false;*/
        }

    private void Building_Checking()
    {
      this.label_BuildingName.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName;
      ModDoorLockSystem.Form_LoginDMS_Ptr.Label_BuildigName.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Label_BuildigName.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Label_BuildigName.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName;
      this.label_Description.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription;
      ModDoorLockSystem.Form_LoginDMS_Ptr.Label_Description.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Label_Description.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gDescription;
    }

    private void Form_MainDMS_Load(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.ReinitialiseForm();
      this.Building_Checking();
      this.countryTableAdapter.Fill(this.SystemDataSet.Country);
      this.lblMessage.Text = "Pls Wait Checking Card Reader!";
    }

    private void Form_MainDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_MainDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      if (this._1stTime_Flag)
      {
        this.Init_Flag = true;
        this.timer1.Start();
        this._1stTime_Flag = false;
      }
      this.SetTopLevel(true);
    }

    private void Form_MainDMS_Activated(object sender, EventArgs e)
    {
    }

    private void Find_Card_Reader()
    {
      bool flag1 = false;
      int comNum = (int) Global_Data.COM_NUM;
      bool flag2 = true;
      if (flag2)
        this.lblMessage.Text = "Finding Card Reader ";
      this.lblMessage.Refresh();
      if (Global_Data.Auto_Select_COM_PORT_For_CardReader())
      {
        Global_Data.Set_Green_COM_Connection_StateColor();
        if (flag2)
          this.lblMessage.Text = "Finding Success  COM" + Global_Data.COM_NUM.ToString() + " is selected";
        this.lblMessage.Refresh();
        Global_Data.Card_Reader_ID = !SmartCard_Procedures.ReadFKQsc((int) Global_Data.COM_NUM) ? "XXXXXXXXXXXXXXXX" : (SmartCard_Procedures.Card_Information_String.Length != 16 ? "XXXXXXXXXXXXXXXX" : SmartCard_Procedures.Card_Information_String);
        Thread.Sleep(1500);
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Set_System_Setting(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
        if (!flag2)
          return;
        this.lblMessage.Text = "";
      }
      else
      {
        flag1 = true;
        Global_Data.Set_Red_COM_Connection_StateColor();
        this.lblMessage.Text = "Card Reader not Found!";
        this.lblMessage.Refresh();
        Thread.Sleep(1500);
        this.lblMessage.Text = "";
      }
    }

    private void Form_MainDMS_Validated(object sender, EventArgs e)
    {
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!this.Visible || !this.Init_Flag)
        return;
      this.Init_Flag = false;
      this.Find_Card_Reader();
      this.Enable_All_Buttons();
    }

    private void Enable_All_Buttons()
    {
      this.button_Operation.Enabled = true;
      this.button_Admin.Enabled = true;
      this.button_Exit.Enabled = true;
      this.button_System.Enabled = true;
    }

    private void selectCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
    {
      byte comNum = Global_Data.COM_NUM;
      Global_Data.COM_PORTS_COUNT = Global_Data.Comm_Form_Ptr.Get_Port_List_And_SetDefault();
      if (Global_Data.COM_PORTS_COUNT > 0)
      {
        if (Global_Data.OLD_COM_PORTS_COUNT != Global_Data.COM_PORTS_COUNT)
        {
          int num1 = (int) MessageBox.Show("COM Ports List Changed!");
        }
        Global_Data.OLD_COM_PORTS_COUNT = Global_Data.COM_PORTS_COUNT;
        try
        {
          int num2 = (int) Global_Data.Comm_Form_Ptr.ShowDialog();
        }
        catch
        {
          int num3 = (int) MessageBox.Show("Show Failed!");
        }
        this.Refresh();
        if (Global_Data.Comm_Form_Ptr.COM_PORT != " ")
        {
          this.lblMessage.Text = Global_Data.Comm_Form_Ptr.COM_PORT + " is Selected!";
          if (Global_Data.Check_CardReader_Found())
          {
            this.lblMessage.Text = Global_Data.Comm_Form_Ptr.COM_PORT + " is Connected!";
            Global_Data.Set_Green_COM_Connection_StateColor();
            if ((int) comNum != (int) Global_Data.COM_NUM)
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Set_System_Setting(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
          }
          else
          {
            Global_Data.Set_Red_COM_Connection_StateColor();
            Global_Data.Comm_Form_Ptr.COM_PORT += " connection failed!";
          }
          this.lblMessage.Refresh();
          Thread.Sleep(1500);
          this.lblMessage.Text = "";
        }
        else
        {
          int num4 = (int) MessageBox.Show("No COM Port Selected!");
          Global_Data.Set_Red_COM_Connection_StateColor();
        }
      }
      else
      {
        this.lblMessage.Text = "No COM Port is Found!";
        this.lblMessage.Refresh();
        Thread.Sleep(1500);
        this.lblMessage.Text = "";
        Global_Data.Set_Red_COM_Connection_StateColor();
      }
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
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Operation = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_System = new System.Windows.Forms.Button();
            this.button_Admin = new System.Windows.Forms.Button();
            this.label_BuildingName = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemDataSet = new AMS.SystemDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new AMS.SystemDataSetTableAdapters.CountryTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_Description.Location = new System.Drawing.Point(161, 73);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(466, 36);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "Door Lock Management System";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Description.Visible = false;
            // 
            // button_Operation
            // 
            this.button_Operation.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Operation.Enabled = false;
            this.button_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Operation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_Operation.Location = new System.Drawing.Point(289, 147);
            this.button_Operation.Name = "button_Operation";
            this.button_Operation.Size = new System.Drawing.Size(235, 66);
            this.button_Operation.TabIndex = 1;
            this.button_Operation.Text = "Guest Mode";
            this.button_Operation.UseVisualStyleBackColor = false;
            this.button_Operation.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.button_Exit.Enabled = false;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(289, 469);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(235, 66);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_System
            // 
            this.button_System.BackColor = System.Drawing.Color.Cornsilk;
            this.button_System.Enabled = false;
            this.button_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_System.Location = new System.Drawing.Point(289, 356);
            this.button_System.Name = "button_System";
            this.button_System.Size = new System.Drawing.Size(235, 75);
            this.button_System.TabIndex = 3;
            this.button_System.Text = "System Setting";
            this.button_System.UseVisualStyleBackColor = false;
            this.button_System.Click += new System.EventHandler(this.button_System_Click);
            // 
            // button_Admin
            // 
            this.button_Admin.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Admin.Enabled = false;
            this.button_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Admin.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_Admin.Location = new System.Drawing.Point(289, 248);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(235, 72);
            this.button_Admin.TabIndex = 4;
            this.button_Admin.Text = "Admin Mode";
            this.button_Admin.UseVisualStyleBackColor = false;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // label_BuildingName
            // 
            this.label_BuildingName.AutoSize = true;
            this.label_BuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BuildingName.ForeColor = System.Drawing.Color.Red;
            this.label_BuildingName.Location = new System.Drawing.Point(289, 249);
            this.label_BuildingName.Name = "label_BuildingName";
            this.label_BuildingName.Size = new System.Drawing.Size(220, 29);
            this.label_BuildingName.TabIndex = 5;
            this.label_BuildingName.Text = "System Description";
            this.label_BuildingName.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(221, 587);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(338, 36);
            this.lblMessage.TabIndex = 156;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(684, 26);
            this.panel_CommStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CommStatus.Name = "panel_CommStatus";
            this.panel_CommStatus.Size = new System.Drawing.Size(119, 22);
            this.panel_CommStatus.TabIndex = 171;
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
            this.pictureBox_COMM_Color.Click += new System.EventHandler(this.pictureBox_COMM_Color_Click);
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
            this.label_CommState.Click += new System.EventHandler(this.label_CommState_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 172;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCOMPortToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // selectCOMPortToolStripMenuItem
            // 
            this.selectCOMPortToolStripMenuItem.Name = "selectCOMPortToolStripMenuItem";
            this.selectCOMPortToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.selectCOMPortToolStripMenuItem.Text = "Select COM Port";
            this.selectCOMPortToolStripMenuItem.Click += new System.EventHandler(this.selectCOMPortToolStripMenuItem_Click);
            // 
            // SystemDataSet
            // 
            this.SystemDataSet.DataSetName = "SystemDataSet";
            this.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.SystemDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(274, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 418);
            this.textBox1.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(161, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 36);
            this.label1.TabIndex = 174;
            this.label1.Text = "Door Lock Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_MainDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(803, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.button_System);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Operation);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_BuildingName);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MainDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
            this.Activated += new System.EventHandler(this.Form_MainDMS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MainDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_MainDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_MainDMS_VisibleChanged);
            this.Validated += new System.EventHandler(this.Form_MainDMS_Validated);
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void label_CommState_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_COMM_Color_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
