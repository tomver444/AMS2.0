// Decompiled with JetBrains decompiler
// Type: AMS.Form_BackupDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using java.io;
using java.util.zip;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_BackupDMS : Form
  {
    private FolderBrowserDialog folderBrowserDialog1;
    private OpenFileDialog openFileDialog1;
    private IContainer components;
    public RadioButton _optBuilding_1;
    public ToolTip ToolTip1;
    public ComboBox cboBuildingNo;
    public RadioButton _optBuilding_0;
    public Button cmdEmail;
    public CheckBox chkStaff;
    public CheckBox chkTransaction;
    public CheckBox chkSystemInfo;
    public ComboBox cboTargetDir;
    public Button cmdReturn;
    public Button cmdBackup;
    public CheckBox chkOwner;
    public GroupBox BuildingFrame;
    public Label Label3;
    public Label lblBuilding;
    public Label Label1;
    public Label Label4;
    public Label lblMessage;
    public GroupBox BackUpFrame;
    private SaveFileDialog saveFileDialog1;

    public Form_BackupDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Close();
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
    }

    private void Form_BackupDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void cmdBackup_Click(object sender, EventArgs e)
    {
      int index1 = 0;
      if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = new string[70];
      if (this.chkSystemInfo.Checked)
      {
        strArray[index1] = Application.UserAppDataPath + "\\system_2007.accdb";
        ++index1;
      }
      if (this.chkStaff.Checked)
      {
        strArray[index1] = Application.UserAppDataPath + "\\Staff_2007.accdb";
        ++index1;
      }
      if (this.chkTransaction.Checked)
      {
        strArray[index1] = Application.UserAppDataPath + "\\BuildingDB" + Global_Data.sBldNo + ".mdb";
        int index2 = index1 + 1;
        strArray[index2] = Application.UserAppDataPath + "\\ErradjustDB" + Global_Data.sBldNo + ".accdb";
        int index3 = index2 + 1;
        strArray[index3] = Application.UserAppDataPath + "\\BankingDB" + Global_Data.sBldNo + ".accdb";
        int index4 = index3 + 1;
        strArray[index4] = Application.UserAppDataPath + "\\ReplacementDB" + Global_Data.sBldNo + ".mdb";
        index1 = index4 + 1;
      }
      FileOutputStream @out = new FileOutputStream(this.saveFileDialog1.FileName);
      ZipOutputStream zipOutputStream = new ZipOutputStream((OutputStream) @out);
      FileInputStream fileInputStream = (FileInputStream) null;
      foreach (string path in strArray)
      {
        try
        {
          if (path.Length > 0)
          {
            fileInputStream = new FileInputStream(path);
            ZipEntry ze = new ZipEntry(Path.GetFileName(path));
            zipOutputStream.putNextEntry(ze);
            sbyte[] numArray = new sbyte[1024];
            int count;
            while ((count = fileInputStream.read(numArray)) >= 0)
              zipOutputStream.write(numArray, 0, count);
          }
        }
        catch
        {
        }
      }
      zipOutputStream.closeEntry();
      fileInputStream.close();
      zipOutputStream.close();
      @out.close();
      if (index1 <= 0)
        return;
      int num = (int) MessageBox.Show("Backup Already!");
    }

    public void Initialize()
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL == "0")
      {
        this.chkSystemInfo.Enabled = true;
        this.chkStaff.Enabled = true;
        try
        {
          if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gOwnerID == "0")
            this.chkOwner.Enabled = true;
          else
            this.chkOwner.Enabled = false;
        }
        catch
        {
          this.chkOwner.Enabled = false;
        }
      }
      else if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL == "1")
      {
        this.chkSystemInfo.Enabled = false;
        this.chkStaff.Enabled = true;
        this.chkOwner.Enabled = false;
      }
      else
      {
        this.chkSystemInfo.Enabled = false;
        this.chkStaff.Enabled = false;
        this.chkOwner.Enabled = false;
      }
    }

    private void Form_BackupDMS_Load(object sender, EventArgs e) => this.Initialize();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_BackupDMS));
      this._optBuilding_1 = new RadioButton();
      this.cboBuildingNo = new ComboBox();
      this._optBuilding_0 = new RadioButton();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdEmail = new Button();
      this.chkStaff = new CheckBox();
      this.chkTransaction = new CheckBox();
      this.chkSystemInfo = new CheckBox();
      this.cboTargetDir = new ComboBox();
      this.cmdReturn = new Button();
      this.cmdBackup = new Button();
      this.chkOwner = new CheckBox();
      this.BuildingFrame = new GroupBox();
      this.Label3 = new Label();
      this.lblBuilding = new Label();
      this.Label1 = new Label();
      this.Label4 = new Label();
      this.lblMessage = new Label();
      this.BackUpFrame = new GroupBox();
      this.saveFileDialog1 = new SaveFileDialog();
      this.BuildingFrame.SuspendLayout();
      this.BackUpFrame.SuspendLayout();
      this.SuspendLayout();
      this._optBuilding_1.BackColor = Color.Cyan;
      this._optBuilding_1.Cursor = Cursors.Default;
      this._optBuilding_1.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuilding_1.ForeColor = Color.Blue;
      this._optBuilding_1.Location = new Point(176, 32);
      this._optBuilding_1.Name = "_optBuilding_1";
      this._optBuilding_1.RightToLeft = RightToLeft.No;
      this._optBuilding_1.Size = new Size(113, 33);
      this._optBuilding_1.TabIndex = 3;
      this._optBuilding_1.TabStop = true;
      this._optBuilding_1.Text = "All";
      this.ToolTip1.SetToolTip((Control) this._optBuilding_1, "Select for All Buildings");
      this._optBuilding_1.UseVisualStyleBackColor = false;
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = SystemColors.WindowText;
      this.cboBuildingNo.Location = new Point(320, 216);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(73, 30);
      this.cboBuildingNo.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Building Select");
      this.cboBuildingNo.Visible = false;
      this._optBuilding_0.BackColor = Color.Cyan;
      this._optBuilding_0.Cursor = Cursors.Default;
      this._optBuilding_0.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuilding_0.ForeColor = Color.Blue;
      this._optBuilding_0.Location = new Point(24, 32);
      this._optBuilding_0.Name = "_optBuilding_0";
      this._optBuilding_0.RightToLeft = RightToLeft.No;
      this._optBuilding_0.Size = new Size(113, 33);
      this._optBuilding_0.TabIndex = 2;
      this._optBuilding_0.TabStop = true;
      this._optBuilding_0.Text = "Individual";
      this.ToolTip1.SetToolTip((Control) this._optBuilding_0, "Select for Individual Building");
      this._optBuilding_0.UseVisualStyleBackColor = false;
      this.cmdEmail.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdEmail.Cursor = Cursors.Default;
      this.cmdEmail.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdEmail.ForeColor = SystemColors.ControlText;
      this.cmdEmail.Image = (Image) componentResourceManager.GetObject("cmdEmail.Image");
      this.cmdEmail.Location = new Point(663, 395);
      this.cmdEmail.Name = "cmdEmail";
      this.cmdEmail.RightToLeft = RightToLeft.No;
      this.cmdEmail.Size = new Size(129, 49);
      this.cmdEmail.TabIndex = 16;
      this.cmdEmail.Text = "&EMAIL";
      this.cmdEmail.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdEmail, "Compose Email");
      this.cmdEmail.UseVisualStyleBackColor = false;
      this.cmdEmail.Visible = false;
      this.chkStaff.BackColor = Color.Cyan;
      this.chkStaff.Cursor = Cursors.Default;
      this.chkStaff.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkStaff.ForeColor = Color.Blue;
      this.chkStaff.Location = new Point(236, 65);
      this.chkStaff.Name = "chkStaff";
      this.chkStaff.RightToLeft = RightToLeft.No;
      this.chkStaff.Size = new Size(77, 49);
      this.chkStaff.TabIndex = 15;
      this.chkStaff.Text = "Staff";
      this.ToolTip1.SetToolTip((Control) this.chkStaff, "Click to Select Staff Data");
      this.chkStaff.UseVisualStyleBackColor = false;
      this.chkTransaction.BackColor = Color.Cyan;
      this.chkTransaction.Cursor = Cursors.Default;
      this.chkTransaction.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkTransaction.ForeColor = Color.Blue;
      this.chkTransaction.Location = new Point(344, 65);
      this.chkTransaction.Name = "chkTransaction";
      this.chkTransaction.RightToLeft = RightToLeft.No;
      this.chkTransaction.Size = new Size(148, 49);
      this.chkTransaction.TabIndex = 14;
      this.chkTransaction.Text = "Transactions";
      this.ToolTip1.SetToolTip((Control) this.chkTransaction, "Click to Select Transactions Data");
      this.chkTransaction.UseVisualStyleBackColor = false;
      this.chkSystemInfo.BackColor = Color.Cyan;
      this.chkSystemInfo.Cursor = Cursors.Default;
      this.chkSystemInfo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkSystemInfo.ForeColor = Color.Blue;
      this.chkSystemInfo.Location = new Point(88, 65);
      this.chkSystemInfo.Name = "chkSystemInfo";
      this.chkSystemInfo.RightToLeft = RightToLeft.No;
      this.chkSystemInfo.Size = new Size(142, 49);
      this.chkSystemInfo.TabIndex = 13;
      this.chkSystemInfo.Text = "System Info";
      this.ToolTip1.SetToolTip((Control) this.chkSystemInfo, "Tick to Select System Information Data");
      this.chkSystemInfo.UseVisualStyleBackColor = false;
      this.cboTargetDir.BackColor = SystemColors.Window;
      this.cboTargetDir.Cursor = Cursors.Default;
      this.cboTargetDir.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboTargetDir.ForeColor = Color.Black;
      this.cboTargetDir.Location = new Point(694, 151);
      this.cboTargetDir.Name = "cboTargetDir";
      this.cboTargetDir.RightToLeft = RightToLeft.No;
      this.cboTargetDir.Size = new Size(81, 29);
      this.cboTargetDir.TabIndex = 7;
      this.ToolTip1.SetToolTip((Control) this.cboTargetDir, "Target Drive Selection");
      this.cboTargetDir.Visible = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(376, 280);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(129, 49);
      this.cmdReturn.TabIndex = 6;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Operation");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdBackup.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdBackup.Cursor = Cursors.Default;
      this.cmdBackup.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdBackup.ForeColor = SystemColors.ControlText;
      this.cmdBackup.Image = (Image) componentResourceManager.GetObject("cmdBackup.Image");
      this.cmdBackup.Location = new Point(72, 280);
      this.cmdBackup.Name = "cmdBackup";
      this.cmdBackup.RightToLeft = RightToLeft.No;
      this.cmdBackup.Size = new Size(129, 49);
      this.cmdBackup.TabIndex = 5;
      this.cmdBackup.Text = "&BACK UP";
      this.cmdBackup.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdBackup, "Confirm BackUp");
      this.cmdBackup.UseVisualStyleBackColor = false;
      this.cmdBackup.Click += new EventHandler(this.cmdBackup_Click);
      this.chkOwner.BackColor = Color.Cyan;
      this.chkOwner.Cursor = Cursors.Default;
      this.chkOwner.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkOwner.ForeColor = Color.Blue;
      this.chkOwner.Location = new Point(694, 243);
      this.chkOwner.Name = "chkOwner";
      this.chkOwner.RightToLeft = RightToLeft.No;
      this.chkOwner.Size = new Size(110, 49);
      this.chkOwner.TabIndex = 23;
      this.chkOwner.Text = "Owner";
      this.chkOwner.UseVisualStyleBackColor = false;
      this.chkOwner.Visible = false;
      this.BuildingFrame.BackColor = Color.Cyan;
      this.BuildingFrame.Controls.Add((Control) this._optBuilding_1);
      this.BuildingFrame.Controls.Add((Control) this._optBuilding_0);
      this.BuildingFrame.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BuildingFrame.ForeColor = Color.FromArgb(0, 0, 128);
      this.BuildingFrame.Location = new Point(136, 120);
      this.BuildingFrame.Name = "BuildingFrame";
      this.BuildingFrame.Padding = new Padding(0);
      this.BuildingFrame.RightToLeft = RightToLeft.No;
      this.BuildingFrame.Size = new Size(297, 73);
      this.BuildingFrame.TabIndex = 1;
      this.BuildingFrame.TabStop = false;
      this.BuildingFrame.Text = "BackUp Building Transactions";
      this.BuildingFrame.Visible = false;
      this.Label3.BackColor = Color.Cyan;
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(694, 207);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(93, 33);
      this.Label3.TabIndex = 9;
      this.Label3.Text = "Target Drive   ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label3.Visible = false;
      this.lblBuilding.BackColor = Color.Cyan;
      this.lblBuilding.Cursor = Cursors.Default;
      this.lblBuilding.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuilding.ForeColor = Color.Blue;
      this.lblBuilding.Location = new Point(144, 215);
      this.lblBuilding.Name = "lblBuilding";
      this.lblBuilding.RightToLeft = RightToLeft.No;
      this.lblBuilding.Size = new Size(153, 33);
      this.lblBuilding.TabIndex = 8;
      this.lblBuilding.Text = "Building No";
      this.lblBuilding.Visible = false;
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(15, 71);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(777, 41);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "System Backup ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 26.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Red;
      this.Label4.Location = new Point(7, 7);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(785, 49);
      this.Label4.TabIndex = 21;
      this.Label4.Text = "Accommodation Management System ";
      this.Label4.TextAlign = ContentAlignment.TopCenter;
      this.lblMessage.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(15, 487);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(777, 49);
      this.lblMessage.TabIndex = 20;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.BackUpFrame.BackColor = Color.Cyan;
      this.BackUpFrame.Controls.Add((Control) this.chkStaff);
      this.BackUpFrame.Controls.Add((Control) this.chkTransaction);
      this.BackUpFrame.Controls.Add((Control) this.chkSystemInfo);
      this.BackUpFrame.Controls.Add((Control) this.cmdReturn);
      this.BackUpFrame.Controls.Add((Control) this.cmdBackup);
      this.BackUpFrame.Controls.Add((Control) this.cboBuildingNo);
      this.BackUpFrame.Controls.Add((Control) this.BuildingFrame);
      this.BackUpFrame.Controls.Add((Control) this.lblBuilding);
      this.BackUpFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.BackUpFrame.ForeColor = SystemColors.ControlText;
      this.BackUpFrame.Location = new Point(103, (int) sbyte.MaxValue);
      this.BackUpFrame.Name = "BackUpFrame";
      this.BackUpFrame.Padding = new Padding(0);
      this.BackUpFrame.RightToLeft = RightToLeft.No;
      this.BackUpFrame.Size = new Size(585, 353);
      this.BackUpFrame.TabIndex = 19;
      this.BackUpFrame.TabStop = false;
      this.BackUpFrame.Text = "Choose Database Files To Backup";
      this.saveFileDialog1.AddExtension = false;
      this.saveFileDialog1.DefaultExt = "zip";
      this.saveFileDialog1.FileName = "AMS2017_Data_Backup.zip";
      this.saveFileDialog1.Filter = "zip files|*.zip|All files|*.*";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(799, 582);
      this.ControlBox = false;
      this.Controls.Add((Control) this.cmdEmail);
      this.Controls.Add((Control) this.chkOwner);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.cboTargetDir);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.BackUpFrame);
      this.Controls.Add((Control) this.Label3);
      this.Name = "Form_BackupDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_BackupDMS_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form_BackupDMS_FormClosing);
      this.BuildingFrame.ResumeLayout(false);
      this.BackUpFrame.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
