// Decompiled with JetBrains decompiler
// Type: AMS.Form_StartDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_StartDMS : Form
  {
    private IContainer components;
    private Label label_CompanyProduct;
    private Label label_ProductName;
    private PictureBox pictureBox1;
    private Button button_Continue;
    private Button button_Quit;
    public ComboBox cboBuildingNo;
    private GroupBox groupBox_BuildingFrame;
    private Label label_Continue;
    public Label lblCopyright;
    public Label lblCompany;
    public Label lblVersion;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.label_CompanyProduct = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Continue = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.cboBuildingNo = new System.Windows.Forms.ComboBox();
            this.groupBox_BuildingFrame = new System.Windows.Forms.GroupBox();
            this.label_Continue = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_BuildingFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CompanyProduct
            // 
            this.label_CompanyProduct.AutoSize = true;
            this.label_CompanyProduct.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CompanyProduct.Location = new System.Drawing.Point(293, 65);
            this.label_CompanyProduct.Name = "label_CompanyProduct";
            this.label_CompanyProduct.Size = new System.Drawing.Size(200, 29);
            this.label_CompanyProduct.TabIndex = 0;
            this.label_CompanyProduct.Text = "TV/AV Solutions";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProductName.Location = new System.Drawing.Point(109, 121);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(559, 32);
            this.label_ProductName.TabIndex = 1;
            this.label_ProductName.Text = "Accommodation Management System 2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 84);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_Continue
            // 
            this.button_Continue.BackColor = System.Drawing.Color.LightGreen;
            this.button_Continue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Continue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Continue.Location = new System.Drawing.Point(138, 28);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(182, 70);
            this.button_Continue.TabIndex = 3;
            this.button_Continue.Text = "Continue";
            this.button_Continue.UseVisualStyleBackColor = false;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.LightCoral;
            this.button_Quit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Quit.Location = new System.Drawing.Point(156, 128);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(150, 51);
            this.button_Quit.TabIndex = 4;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // cboBuildingNo
            // 
            this.cboBuildingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuildingNo.FormattingEnabled = true;
            this.cboBuildingNo.Location = new System.Drawing.Point(171, 65);
            this.cboBuildingNo.Name = "cboBuildingNo";
            this.cboBuildingNo.Size = new System.Drawing.Size(95, 24);
            this.cboBuildingNo.TabIndex = 5;
            this.cboBuildingNo.Visible = false;
            // 
            // groupBox_BuildingFrame
            // 
            this.groupBox_BuildingFrame.Controls.Add(this.cboBuildingNo);
            this.groupBox_BuildingFrame.Controls.Add(this.button_Quit);
            this.groupBox_BuildingFrame.Controls.Add(this.button_Continue);
            this.groupBox_BuildingFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_BuildingFrame.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_BuildingFrame.Location = new System.Drawing.Point(173, 193);
            this.groupBox_BuildingFrame.Name = "groupBox_BuildingFrame";
            this.groupBox_BuildingFrame.Size = new System.Drawing.Size(436, 212);
            this.groupBox_BuildingFrame.TabIndex = 6;
            this.groupBox_BuildingFrame.TabStop = false;
            // 
            // label_Continue
            // 
            this.label_Continue.AutoSize = true;
            this.label_Continue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Continue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_Continue.Location = new System.Drawing.Point(272, 429);
            this.label_Continue.Name = "label_Continue";
            this.label_Continue.Size = new System.Drawing.Size(257, 19);
            this.label_Continue.TabIndex = 7;
            this.label_Continue.Text = "Please wait, program loading ......";
            this.label_Continue.Visible = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.SystemColors.Control;
            this.lblCopyright.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCopyright.Location = new System.Drawing.Point(566, 474);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCopyright.Size = new System.Drawing.Size(161, 17);
            this.lblCopyright.TabIndex = 9;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.SystemColors.Control;
            this.lblCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCompany.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompany.Location = new System.Drawing.Point(566, 488);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCompany.Size = new System.Drawing.Size(161, 17);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Transicom Engineering Pte Ltd";
            this.lblCompany.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.SystemColors.Control;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(565, 441);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(119, 19);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "AMS 2025 v2.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form_StartDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 518);
            this.ControlBox = false;
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label_Continue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_CompanyProduct);
            this.Controls.Add(this.groupBox_BuildingFrame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_StartDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
            this.Load += new System.EventHandler(this.Form_StartDMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_BuildingFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form_StartDMS() => this.InitializeComponent();

    private void button_Quit_Click(object sender, EventArgs e) => this.Close();

    private void Form_StartDMS_Load(object sender, EventArgs e)
    {
      Settings.Default.BuildingDB1ConnectionString = Settings.Default.BuildingDB1ConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.Staff_2007ConnectionString = Settings.Default.Staff_2007ConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.System_2007ConnectionString = Settings.Default.System_2007ConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.TempConnectionString = Settings.Default.TempConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.BankingDBConnectionString = Settings.Default.BankingDBConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.ErradjustDBConnectionString = Settings.Default.ErradjustDBConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      Settings.Default.ReplacementDB1ConnectionString = Settings.Default.ReplacementDB1ConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
      if (!File.Exists(Application.UserAppDataPath + "\\system_2007.accdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\resSystem_2007.accdb"))
        {
          int num = (int) MessageBox.Show("System Database is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\resSystem_2007.accdb", Application.UserAppDataPath + "\\system_2007.accdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("System Info Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\resSystem_2007.accdb", Application.UserAppDataPath + "\\system_2007.accdb", true);
        }
      }
      if (!File.Exists(Application.UserAppDataPath + "\\Staff_2007.accdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\Staff_2007.accdb"))
        {
          int num = (int) MessageBox.Show("Staff_2007.accdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\Staff_2007.accdb", Application.UserAppDataPath + "\\Staff_2007.accdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Staff Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\Staff_2007.accdb", Application.UserAppDataPath + "\\Staff_2007.accdb", true);
        }
      }
      if (!File.Exists(Application.UserAppDataPath + "\\temp.mdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\temp.mdb"))
        {
          int num = (int) MessageBox.Show("temp.mdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\temp.mdb", Application.UserAppDataPath + "\\temp.mdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Temp Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\temp.mdb", Application.UserAppDataPath + "\\temp.mdb", true);
        }
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB = "0";
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Main();
      if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.CheckBuilding_Found(this.cboBuildingNo))
      {
        int num = (int) new Form_Building_Setting_SHL().ShowDialog((IWin32Window) this);
        this.CheckBuilding();
      }
      try
      {
        short int16 = Convert.ToInt16(Global_Data.sBldNo);
        switch (int16)
        {
          case 1:
          case 2:
          case 3:
          case 4:
          case 5:
          case 6:
            if (this.Check_N_CreateBuilding(Convert.ToString(int16)))
            {
              string newValue1 = "BuildingDB" + Convert.ToString(int16) + ".mdb";
              string newValue2 = "BankingDB" + Convert.ToString(int16) + ".accdb";
              string newValue3 = "ErradjustDB" + Convert.ToString(int16) + ".accdb";
              string newValue4 = "ReplacementDB" + Convert.ToString(int16) + ".mdb";
              Settings.Default.BuildingDB1ConnectionString = Settings.Default.BuildingDB1ConnectionString.Replace("BuildingDB1.mdb", newValue1);
              Settings.Default.BankingDBConnectionString = Settings.Default.BankingDBConnectionString.Replace("BankingDB.accdb", newValue2);
              Settings.Default.ErradjustDBConnectionString = Settings.Default.ErradjustDBConnectionString.Replace("ErradjustDB.accdb", newValue3);
              Settings.Default.ReplacementDB1ConnectionString = Settings.Default.ReplacementDB1ConnectionString.Replace("ReplacementDB1.mdb", newValue4);
              break;
            }
            int num1 = (int) MessageBox.Show("Can not Create Building Database");
            Application.Exit();
            break;
          default:
            int num2 = (int) MessageBox.Show("Invalid Building Number!");
            Application.Exit();
            break;
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Invalid Building Number!");
        Application.Exit();
      }
      Settings.Default.BuildingDB1ConnectionString = Settings.Default.BuildingDB1ConnectionString.Replace("|DataDirectory|", Application.UserAppDataPath);
    }

    private bool Check_N_CreateBuilding(string para_BuildingNo)
    {
      if (!File.Exists(Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\resDatabase.mdb"))
        {
          int num = (int) MessageBox.Show("resDatabase.mdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\resDatabase.mdb", Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Transaction Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\resDatabase.mdb", Application.UserAppDataPath + "\\BuildingDB" + para_BuildingNo + ".mdb", true);
        }
      }
      if (!File.Exists(Application.UserAppDataPath + "\\BankingDB" + para_BuildingNo + ".accdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\resBankingDB.accdb"))
        {
          int num = (int) MessageBox.Show("resBankingDB.accdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\resBankingDB.accdb", Application.UserAppDataPath + "\\BankingDB" + para_BuildingNo + ".accdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Banking Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\resBankingDB.accdb", Application.UserAppDataPath + "\\BankingDB" + para_BuildingNo + ".accdb", true);
        }
      }
      if (!File.Exists(Application.UserAppDataPath + "\\ErradjustDB" + para_BuildingNo + ".accdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\resErradjustDB.accdb"))
        {
          int num = (int) MessageBox.Show("resErradjustDB.accdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\resErradjustDB.accdb", Application.UserAppDataPath + "\\ErradjustDB" + para_BuildingNo + ".accdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Error Adjust Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\resErradjustDB.accdb", Application.UserAppDataPath + "\\ErradjustDB" + para_BuildingNo + ".accdb", true);
        }
      }
      if (!File.Exists(Application.UserAppDataPath + "\\ReplacementDB" + para_BuildingNo + ".mdb"))
      {
        if (!File.Exists(Application.StartupPath + "\\resRepacement.mdb"))
        {
          int num = (int) MessageBox.Show("resRepacement.mdb is not found!");
          Application.Exit();
        }
        try
        {
          File.Copy(Application.StartupPath + "\\resRepacement.mdb", Application.UserAppDataPath + "\\ReplacementDB" + para_BuildingNo + ".mdb");
        }
        catch
        {
          if (DialogResult.Yes == MessageBox.Show("Transaction Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            File.Copy(Application.StartupPath + "\\resRepacement.mdb", Application.UserAppDataPath + "\\ReplacementDB" + para_BuildingNo + ".mdb", true);
        }
      }
      return true;
    }

    private void CheckBuilding()
    {
      bool flag = false;
      DB db = new DB();
      db.system_DB.buildingTableAdapter.Fill(db.system_DB.systemDataSet.Building);
      IEnumerator enumerator = db.system_DB.systemDataSet.Building.Rows.GetEnumerator();
      try
      {
        if (enumerator.MoveNext())
        {
          SystemDataSet.BuildingRow current = (SystemDataSet.BuildingRow) enumerator.Current;
          this.cboBuildingNo.Items.Add((object) current.BuildingNo);
          flag = true;
          Global_Data.sBldNo = current.BuildingNo;
        }
      }
      finally
      {
        if (enumerator is IDisposable disposable)
          disposable.Dispose();
      }
      if (!flag)
      {
        int num = (int) MessageBox.Show("Need to Configure System Setting by Owner...");
        Application.Exit();
      }
      else
        this.cboBuildingNo.SelectedIndex = 0;
    }

    private void button_Continue_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Continue_flag = true;
      this.groupBox_BuildingFrame.Enabled = false;
      this.groupBox_BuildingFrame.Refresh();
      this.label_Continue.Visible = true;
      this.label_Continue.Refresh();
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo = (string) this.cboBuildingNo.SelectedItem;
      Mod_UpdateData.sBldNoChk = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      DB db = new DB();
      db.system_DB.buildingTableAdapter.Fill(db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) db.system_DB.systemDataSet.Building.Rows)
      {
        if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo)
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingName = row.BldName;
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gBuildingNo = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetSystemInfo();
      ModDoorLockSystem.Form_StartDMS_Ptr = this;
      Global_Data.sBldNo = this.cboBuildingNo.Text;
      Global_Data.sBuildingName = db.RetrieveBldName(Global_Data.sBldNo);
      ModDoorLockSystem.Form_OperationDMS_Ptr = new Form_OperationDMS();
      ModDoorLockSystem.Form_AdminDMS_Ptr = new Form_AdminDMS();
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr = new Form_SystemSettingDMS();
      ModDoorLockSystem.Form_AvailableRoomsDMS_Ptr = new Form_AvailableRoomsDMS();
      ModDoorLockSystem.Form_BackupDMS_Ptr = new Form_BackupDMS();
      ModDoorLockSystem.Form_BankingDMS_Ptr = new Form_BankingDMS();
      ModDoorLockSystem.Form_CancelCardDMS_Ptr = new Form_CancelCardDMS();
      ModDoorLockSystem.Form_CancelGuestCardDMS_Ptr = new Form_CancelGuestCardDMS();
      ModDoorLockSystem.Form_CancelReservationDMS_Ptr = new Form_CancelReservationDMS();
      ModDoorLockSystem.Form_ChangePasswordDMS_Ptr = new Form_ChangePasswordDMS();
      ModDoorLockSystem.Form_CreateRoomDMS_Ptr = new Form_CreateRoomDMS();
      ModDoorLockSystem.Form_CreateZoneDMS_Ptr = new Form_CreateZoneDMS();
      ModDoorLockSystem.Form_DescriptionDMS_Ptr = new Form_DescriptionDMS();
      ModDoorLockSystem.Form_EditDMS_Ptr = new Form_EditDMS();
      ModDoorLockSystem.Form_GuestDetailDMS_Ptr = new Form_GuestDetailDMS();
      ModDoorLockSystem.Form_IRoomSetupDMS_Ptr = new Form_IRoomSetupDMS();
      ModDoorLockSystem.Form_IssueCardDMS_Ptr = new Form_IssueCardDMS();
      ModDoorLockSystem.Form_IssueGuestCard_Ptr = new Form_IssueGuestCardDMS();
      //ModDoorLockSystem.Form_LogReportDMS_Ptr = new Form_LogReportDMS();
      ModDoorLockSystem.Form_MRoomsSetupDMS_Ptr = new Form_MRoomsSetupDMS();
      //ModDoorLockSystem.Form_OtherReportsDMS_Ptr = new Form_OtherReportsDMS();
      ModDoorLockSystem.Form_ReadCardDMS_Ptr = new Form_ReadCardDMS();
      ModDoorLockSystem.Form_ReadDataCardDMS_Ptr = new Form_ReadDataCardDMS();
      ModDoorLockSystem.Form_ReadGuestCardDMS_Ptr = new Form_ReadGuestCardDMS();
      ModDoorLockSystem.Form_ReservationDMS_Ptr = new Form_ReservationDMS();
      ModDoorLockSystem.Form_RestoreDMS_Ptr = new Form_RestoreDMS();
      ModDoorLockSystem.Form_RoomStatusDMS_Ptr = new Form_RoomStatusDMS();
      ModDoorLockSystem.Form_RoomTypeDMS_Ptr = new Form_RoomTypeDMS();
      ModDoorLockSystem.Form_StaffDMS_Ptr = new Form_StaffDMS();
      ModDoorLockSystem.Form_ViewGuestTransDMS_Ptr = new Form_ViewGuestTransDMS();
      ModDoorLockSystem.Form_LoginDMS_Ptr = new Form_LoginDMS();
      ModDoorLockSystem.Form_MainDMS_Ptr = new Form_MainDMS();
      ModDoorLockSystem.Form_GuestBrowserDMS_Ptr = new Form_GuestBrowserDMS();
      ModDoorLockSystem.Form_SHL_ViewRoomReservation_Ptr = new Form_SHL_ViewRoomReservation();
      ModDoorLockSystem.Form_SHL_AvailableRoom_Ptr = new Form_SHL_AvailableRooms();
      //ModDoorLockSystem.Form_SearchReportDMS_Ptr = new Form_SearchReportDMS();
      //ReportForm reportForm = new ReportForm();
      //ReportClass_Dummy reportClassDummy = new ReportClass_Dummy();
      /*reportForm.crystalReportViewer1.ReportSource = reportClassDummy.Dummy_Show();
      reportForm.SendToBack();
      reportForm.Visible = false;
      reportForm.CreateControl();
      reportForm.Close();
      */
      try
      {
        db.Backup_Before_Transact((string) this.cboBuildingNo.SelectedItem);
      }
      catch
      {
      }
      this.Close();
    }
  }
}
