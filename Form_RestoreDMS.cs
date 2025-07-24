// Decompiled with JetBrains decompiler
// Type: AMS.Form_RestoreDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using java.io;
using java.util;
using java.util.zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_RestoreDMS : Form
  {
    private IContainer components;
    public CheckBox chkOwner;
    public ToolTip ToolTip1;
    public Button cmdReturn;
    public Button cmdRestore;
    public CheckBox chkSystemInfo;
    public CheckBox chkTransaction;
    public CheckBox chkStaff;
    public ComboBox cboSourceDir;
    public ComboBox cboBuildingNo;
    public RadioButton _optBuilding_1;
    public RadioButton _optBuilding_0;
    public GroupBox Frame2;
    public GroupBox RestoreFrame;
    public GroupBox BuildingFrame;
    public Label Label3;
    public Label lblBuilding;
    public Label lblMessage;
    public Label Label6;
    public Label Label5;
    private OpenFileDialog openFileDialog1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.chkOwner = new CheckBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdReturn = new Button();
      this.cmdRestore = new Button();
      this.chkSystemInfo = new CheckBox();
      this.chkTransaction = new CheckBox();
      this.chkStaff = new CheckBox();
      this.cboSourceDir = new ComboBox();
      this.cboBuildingNo = new ComboBox();
      this._optBuilding_1 = new RadioButton();
      this._optBuilding_0 = new RadioButton();
      this.Frame2 = new GroupBox();
      this.RestoreFrame = new GroupBox();
      this.BuildingFrame = new GroupBox();
      this.lblBuilding = new Label();
      this.Label3 = new Label();
      this.lblMessage = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.openFileDialog1 = new OpenFileDialog();
      this.Frame2.SuspendLayout();
      this.RestoreFrame.SuspendLayout();
      this.BuildingFrame.SuspendLayout();
      this.SuspendLayout();
      this.chkOwner.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.chkOwner.Cursor = Cursors.Default;
      this.chkOwner.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkOwner.ForeColor = Color.Blue;
      this.chkOwner.Location = new Point(697, 188);
      this.chkOwner.Name = "chkOwner";
      this.chkOwner.RightToLeft = RightToLeft.No;
      this.chkOwner.Size = new Size(81, 49);
      this.chkOwner.TabIndex = 17;
      this.chkOwner.Text = "Owner";
      this.chkOwner.UseVisualStyleBackColor = false;
      this.chkOwner.Visible = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Location = new Point(199, 21);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(153, 47);
      this.cmdReturn.TabIndex = 8;
      this.cmdReturn.Text = "RETUR&N";
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Admin Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdRestore.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdRestore.Cursor = Cursors.Default;
      this.cmdRestore.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdRestore.ForeColor = SystemColors.ControlText;
      this.cmdRestore.Location = new Point(32, 21);
      this.cmdRestore.Name = "cmdRestore";
      this.cmdRestore.RightToLeft = RightToLeft.No;
      this.cmdRestore.Size = new Size(153, 47);
      this.cmdRestore.TabIndex = 7;
      this.cmdRestore.Text = "&RESTORE";
      this.ToolTip1.SetToolTip((Control) this.cmdRestore, "Confirm Restore");
      this.cmdRestore.UseVisualStyleBackColor = false;
      this.cmdRestore.Click += new EventHandler(this.cmdRestore_Click);
      this.chkSystemInfo.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.chkSystemInfo.Cursor = Cursors.Default;
      this.chkSystemInfo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkSystemInfo.ForeColor = Color.Blue;
      this.chkSystemInfo.Location = new Point(83, 73);
      this.chkSystemInfo.Name = "chkSystemInfo";
      this.chkSystemInfo.RightToLeft = RightToLeft.No;
      this.chkSystemInfo.Size = new Size(138, 49);
      this.chkSystemInfo.TabIndex = 16;
      this.chkSystemInfo.Text = "System Info";
      this.ToolTip1.SetToolTip((Control) this.chkSystemInfo, "Tick to Select System Information Data");
      this.chkSystemInfo.UseVisualStyleBackColor = false;
      this.chkTransaction.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.chkTransaction.Cursor = Cursors.Default;
      this.chkTransaction.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkTransaction.ForeColor = Color.Blue;
      this.chkTransaction.Location = new Point(331, 73);
      this.chkTransaction.Name = "chkTransaction";
      this.chkTransaction.RightToLeft = RightToLeft.No;
      this.chkTransaction.Size = new Size(146, 49);
      this.chkTransaction.TabIndex = 15;
      this.chkTransaction.Text = "Transactions";
      this.ToolTip1.SetToolTip((Control) this.chkTransaction, "Click to Select Transactions Data");
      this.chkTransaction.UseVisualStyleBackColor = false;
      this.chkStaff.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.chkStaff.Cursor = Cursors.Default;
      this.chkStaff.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkStaff.ForeColor = Color.Blue;
      this.chkStaff.Location = new Point(227, 73);
      this.chkStaff.Name = "chkStaff";
      this.chkStaff.RightToLeft = RightToLeft.No;
      this.chkStaff.Size = new Size(98, 49);
      this.chkStaff.TabIndex = 14;
      this.chkStaff.Text = "Staff";
      this.ToolTip1.SetToolTip((Control) this.chkStaff, "Tick to Select Staff Data");
      this.chkStaff.UseVisualStyleBackColor = false;
      this.cboSourceDir.BackColor = SystemColors.Window;
      this.cboSourceDir.Cursor = Cursors.Default;
      this.cboSourceDir.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboSourceDir.ForeColor = SystemColors.WindowText;
      this.cboSourceDir.Location = new Point(680, 72);
      this.cboSourceDir.Name = "cboSourceDir";
      this.cboSourceDir.RightToLeft = RightToLeft.No;
      this.cboSourceDir.Size = new Size(78, 27);
      this.cboSourceDir.TabIndex = 5;
      this.ToolTip1.SetToolTip((Control) this.cboSourceDir, "Source Drive Selection");
      this.cboSourceDir.Visible = false;
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = SystemColors.WindowText;
      this.cboBuildingNo.Location = new Point(344, 216);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(73, 30);
      this.cboBuildingNo.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building");
      this.cboBuildingNo.Visible = false;
      this._optBuilding_1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this._optBuilding_1.Cursor = Cursors.Default;
      this._optBuilding_1.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuilding_1.ForeColor = Color.Blue;
      this._optBuilding_1.Location = new Point(184, 32);
      this._optBuilding_1.Name = "_optBuilding_1";
      this._optBuilding_1.RightToLeft = RightToLeft.No;
      this._optBuilding_1.Size = new Size(97, 33);
      this._optBuilding_1.TabIndex = 3;
      this._optBuilding_1.TabStop = true;
      this._optBuilding_1.Text = "All";
      this.ToolTip1.SetToolTip((Control) this._optBuilding_1, "Select for All Buildings");
      this._optBuilding_1.UseVisualStyleBackColor = false;
      this._optBuilding_0.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this._optBuilding_0.Cursor = Cursors.Default;
      this._optBuilding_0.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuilding_0.ForeColor = Color.Blue;
      this._optBuilding_0.Location = new Point(32, 32);
      this._optBuilding_0.Name = "_optBuilding_0";
      this._optBuilding_0.RightToLeft = RightToLeft.No;
      this._optBuilding_0.Size = new Size(121, 33);
      this._optBuilding_0.TabIndex = 2;
      this._optBuilding_0.TabStop = true;
      this._optBuilding_0.Text = "Individual";
      this.ToolTip1.SetToolTip((Control) this._optBuilding_0, "Select for Individual");
      this._optBuilding_0.UseVisualStyleBackColor = false;
      this.Frame2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Frame2.Controls.Add((Control) this.cmdReturn);
      this.Frame2.Controls.Add((Control) this.cmdRestore);
      this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = SystemColors.ControlText;
      this.Frame2.Location = new Point(88, 262);
      this.Frame2.Name = "Frame2";
      this.Frame2.Padding = new Padding(0);
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(373, 83);
      this.Frame2.TabIndex = 6;
      this.Frame2.TabStop = false;
      this.RestoreFrame.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.RestoreFrame.Controls.Add((Control) this.chkSystemInfo);
      this.RestoreFrame.Controls.Add((Control) this.chkTransaction);
      this.RestoreFrame.Controls.Add((Control) this.chkStaff);
      this.RestoreFrame.Controls.Add((Control) this.Frame2);
      this.RestoreFrame.Controls.Add((Control) this.cboBuildingNo);
      this.RestoreFrame.Controls.Add((Control) this.BuildingFrame);
      this.RestoreFrame.Controls.Add((Control) this.lblBuilding);
      this.RestoreFrame.Font = new Font("Arial", 13.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.RestoreFrame.ForeColor = Color.Blue;
      this.RestoreFrame.Location = new Point(115, 104);
      this.RestoreFrame.Name = "RestoreFrame";
      this.RestoreFrame.Padding = new Padding(0);
      this.RestoreFrame.RightToLeft = RightToLeft.No;
      this.RestoreFrame.Size = new Size(561, 360);
      this.RestoreFrame.TabIndex = 14;
      this.RestoreFrame.TabStop = false;
      this.RestoreFrame.Text = "Choose Database Files To Restore";
      this.BuildingFrame.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.BuildingFrame.Controls.Add((Control) this._optBuilding_1);
      this.BuildingFrame.Controls.Add((Control) this._optBuilding_0);
      this.BuildingFrame.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BuildingFrame.ForeColor = Color.FromArgb(0, 0, 128);
      this.BuildingFrame.Location = new Point(120, 128);
      this.BuildingFrame.Name = "BuildingFrame";
      this.BuildingFrame.Padding = new Padding(0);
      this.BuildingFrame.RightToLeft = RightToLeft.No;
      this.BuildingFrame.Size = new Size(297, 73);
      this.BuildingFrame.TabIndex = 1;
      this.BuildingFrame.TabStop = false;
      this.BuildingFrame.Text = "Restore Building Data";
      this.BuildingFrame.Visible = false;
      this.lblBuilding.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblBuilding.Cursor = Cursors.Default;
      this.lblBuilding.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuilding.ForeColor = Color.Blue;
      this.lblBuilding.Location = new Point(120, 215);
      this.lblBuilding.Name = "lblBuilding";
      this.lblBuilding.RightToLeft = RightToLeft.No;
      this.lblBuilding.Size = new Size(153, 33);
      this.lblBuilding.TabIndex = 9;
      this.lblBuilding.Text = "Building No";
      this.lblBuilding.Visible = false;
      this.Label3.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(598, 36);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(190, 33);
      this.Label3.TabIndex = 10;
      this.Label3.Text = "Source Drive ";
      this.Label3.Visible = false;
      this.lblMessage.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(115, 466);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(561, 73);
      this.lblMessage.TabIndex = 17;
      this.lblMessage.Text = "  ";
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label6.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Times New Roman", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Blue;
      this.Label6.Location = new Point(175, 58);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(417, 44);
      this.Label6.TabIndex = 16;
      this.Label6.Text = "Restore  Data";
      this.Label6.TextAlign = ContentAlignment.TopCenter;
      this.Label5.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 26.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(3, 2);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(785, 41);
      this.Label5.TabIndex = 15;
      this.Label5.Text = "Accommodation Management System";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "zip files|*.zip|All files|*.*";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(790, 586);
      this.ControlBox = false;
      this.Controls.Add((Control) this.chkOwner);
      this.Controls.Add((Control) this.RestoreFrame);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.cboSourceDir);
      this.Controls.Add((Control) this.Label3);
      this.Name = "Form_RestoreDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.FormClosing += new FormClosingEventHandler(this.Form_RestoreDMS_FormClosing);
      this.Frame2.ResumeLayout(false);
      this.RestoreFrame.ResumeLayout(false);
      this.BuildingFrame.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Form_RestoreDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Close();
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_RestoreDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private List<ZipEntry> GetZipFiles(ZipFile zipfil)
    {
      List<ZipEntry> zipFiles = new List<ZipEntry>();
      Enumeration enumeration = zipfil.entries();
      while (enumeration.hasMoreElements())
      {
        ZipEntry zipEntry = (ZipEntry) enumeration.nextElement();
        zipFiles.Add(zipEntry);
      }
      return zipFiles;
    }

    private void cmdRestore_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      FileInfo fileInfo = new FileInfo(this.openFileDialog1.FileName);
      ZipFile zipfil = new ZipFile(this.openFileDialog1.FileName);
      List<ZipEntry> zipFiles = this.GetZipFiles(zipfil);
      foreach (ZipEntry ze in zipFiles)
      {
        bool flag = false;
        string fileName = Path.GetFileName(ze.getName());
        switch (fileName)
        {
          case "system_2007.accdb":
            if (this.chkSystemInfo.Checked)
            {
              flag = !System.IO.File.Exists(Application.UserAppDataPath + "\\" + fileName) || DialogResult.Yes == MessageBox.Show("System Info Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
              break;
            }
            break;
          case "Staff_2007.accdb":
            if (this.chkStaff.Checked)
            {
              flag = !System.IO.File.Exists(Application.UserAppDataPath + "\\" + fileName) || DialogResult.Yes == MessageBox.Show("Staff Database Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
              break;
            }
            break;
          default:
            flag = this.chkTransaction.Checked && (!System.IO.File.Exists(Application.UserAppDataPath + "\\" + fileName) || DialogResult.Yes == MessageBox.Show("Transaction Database (" + fileName + ") Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation));
            break;
        }
        if (flag && !ze.isDirectory())
        {
          InputStream inputStream = zipfil.getInputStream(ze);
          try
          {
            Directory.CreateDirectory(Application.UserAppDataPath + "\\" + Path.GetDirectoryName(ze.getName()));
            FileOutputStream fileOutputStream = new FileOutputStream(Path.Combine(Application.UserAppDataPath + "\\" + Path.GetDirectoryName(ze.getName()), Path.GetFileName(ze.getName())));
            try
            {
              sbyte[] numArray = new sbyte[8000];
              int count;
              while ((count = inputStream.read(numArray)) >= 0)
                fileOutputStream.write(numArray, 0, count);
            }
            finally
            {
              fileOutputStream.close();
            }
          }
          finally
          {
            inputStream.close();
          }
          ++num1;
        }
      }
      if (num1 > 0)
      {
        int num2 = (int) MessageBox.Show("Restore Already!");
      }
      else if (!this.chkStaff.Checked && !this.chkSystemInfo.Checked && !this.chkTransaction.Checked)
      {
        int num3 = (int) MessageBox.Show("No Selection to restore!");
      }
      else
      {
        int num4 = (int) MessageBox.Show("No file restored!");
      }
    }
  }
}
