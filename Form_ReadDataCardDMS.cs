// Decompiled with JetBrains decompiler
// Type: AMS.Form_ReadDataCardDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_ReadDataCardDMS : Form
  {
    private IContainer components;
    public TextBox txtCollectTime;
    public GroupBox Frame1;
    public Button cmdReturn;
    public ToolTip ToolTip1;
    public Button CmdPrint;
    public Button CmdSave;
    public Button CmdRead;
    public Label Data1;
    public Panel PicMsg;
    public TextBox TxtCollectSDate;
    public TextBox TxtRecordCount;
    public TextBox TxtShortRoomNumber;
    public Label Label6;
    public Label Label5;
    public Label Label4;
    public Label Label3;
    public Label Label2;
    public Label Label1;

    public Form_ReadDataCardDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_ReadDataCardDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_ReadDataCardDMS));
      this.txtCollectTime = new TextBox();
      this.Frame1 = new GroupBox();
      this.cmdReturn = new Button();
      this.CmdPrint = new Button();
      this.CmdSave = new Button();
      this.CmdRead = new Button();
      this.Data1 = new Label();
      this.PicMsg = new Panel();
      this.TxtCollectSDate = new TextBox();
      this.TxtRecordCount = new TextBox();
      this.TxtShortRoomNumber = new TextBox();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this.txtCollectTime.AcceptsReturn = true;
      this.txtCollectTime.BackColor = SystemColors.Window;
      this.txtCollectTime.Cursor = Cursors.IBeam;
      this.txtCollectTime.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCollectTime.ForeColor = SystemColors.WindowText;
      this.txtCollectTime.Location = new Point(515, 171);
      this.txtCollectTime.Margin = new Padding(4, 4, 4, 4);
      this.txtCollectTime.MaxLength = 0;
      this.txtCollectTime.Name = "txtCollectTime";
      this.txtCollectTime.ReadOnly = true;
      this.txtCollectTime.RightToLeft = RightToLeft.No;
      this.txtCollectTime.Size = new Size(128, 23);
      this.txtCollectTime.TabIndex = 25;
      this.Frame1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Frame1.Controls.Add((Control) this.cmdReturn);
      this.Frame1.Controls.Add((Control) this.CmdPrint);
      this.Frame1.Controls.Add((Control) this.CmdSave);
      this.Frame1.Controls.Add((Control) this.CmdRead);
      this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(653, 102);
      this.Frame1.Margin = new Padding(4, 4, 4, 4);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(396, 100);
      this.Frame1.TabIndex = 23;
      this.Frame1.TabStop = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(299, 20);
      this.cmdReturn.Margin = new Padding(4, 4, 4, 4);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(80, 68);
      this.cmdReturn.TabIndex = 16;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Retun to Admin Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.CmdPrint.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.CmdPrint.Cursor = Cursors.Default;
      this.CmdPrint.Enabled = false;
      this.CmdPrint.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdPrint.ForeColor = SystemColors.ControlText;
      this.CmdPrint.Image = (Image) componentResourceManager.GetObject("CmdPrint.Image");
      this.CmdPrint.Location = new Point(203, 20);
      this.CmdPrint.Margin = new Padding(4, 4, 4, 4);
      this.CmdPrint.Name = "CmdPrint";
      this.CmdPrint.RightToLeft = RightToLeft.No;
      this.CmdPrint.Size = new Size(80, 68);
      this.CmdPrint.TabIndex = 11;
      this.CmdPrint.Text = "&Print";
      this.CmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdPrint, "To Print");
      this.CmdPrint.UseVisualStyleBackColor = false;
      this.CmdSave.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.CmdSave.Cursor = Cursors.Default;
      this.CmdSave.Enabled = false;
      this.CmdSave.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdSave.ForeColor = SystemColors.ControlText;
      this.CmdSave.Image = (Image) componentResourceManager.GetObject("CmdSave.Image");
      this.CmdSave.Location = new Point(107, 20);
      this.CmdSave.Margin = new Padding(4, 4, 4, 4);
      this.CmdSave.Name = "CmdSave";
      this.CmdSave.RightToLeft = RightToLeft.No;
      this.CmdSave.Size = new Size(80, 68);
      this.CmdSave.TabIndex = 10;
      this.CmdSave.Text = "&Save";
      this.CmdSave.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdSave, "To Save Uploaded  Data");
      this.CmdSave.UseVisualStyleBackColor = false;
      this.CmdRead.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.CmdRead.Cursor = Cursors.Default;
      this.CmdRead.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdRead.ForeColor = SystemColors.ControlText;
      this.CmdRead.Image = (Image) componentResourceManager.GetObject("CmdRead.Image");
      this.CmdRead.Location = new Point(11, 20);
      this.CmdRead.Margin = new Padding(4, 4, 4, 4);
      this.CmdRead.Name = "CmdRead";
      this.CmdRead.RightToLeft = RightToLeft.No;
      this.CmdRead.Size = new Size(80, 68);
      this.CmdRead.TabIndex = 9;
      this.CmdRead.Text = "&Read";
      this.CmdRead.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdRead, "To Read/Upload  Data Card");
      this.CmdRead.UseVisualStyleBackColor = false;
      this.Data1.BackColor = Color.Red;
      this.Data1.BorderStyle = BorderStyle.FixedSingle;
      this.Data1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Data1.ForeColor = Color.Black;
      this.Data1.Location = new Point(152, 634);
      this.Data1.Margin = new Padding(4, 0, 4, 0);
      this.Data1.Name = "Data1";
      this.Data1.Size = new Size(139, 29);
      this.Data1.TabIndex = 26;
      this.Data1.Text = "Data1";
      this.Data1.Visible = false;
      this.PicMsg.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.PicMsg.Cursor = Cursors.Default;
      this.PicMsg.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.PicMsg.ForeColor = Color.Red;
      this.PicMsg.Location = new Point(24, 624);
      this.PicMsg.Margin = new Padding(4, 4, 4, 4);
      this.PicMsg.Name = "PicMsg";
      this.PicMsg.RightToLeft = RightToLeft.No;
      this.PicMsg.Size = new Size(1015, 31);
      this.PicMsg.TabIndex = 22;
      this.PicMsg.TabStop = true;
      this.TxtCollectSDate.AcceptsReturn = true;
      this.TxtCollectSDate.BackColor = SystemColors.Window;
      this.TxtCollectSDate.Cursor = Cursors.IBeam;
      this.TxtCollectSDate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TxtCollectSDate.ForeColor = SystemColors.WindowText;
      this.TxtCollectSDate.Location = new Point(205, 171);
      this.TxtCollectSDate.Margin = new Padding(4, 4, 4, 4);
      this.TxtCollectSDate.MaxLength = 0;
      this.TxtCollectSDate.Name = "TxtCollectSDate";
      this.TxtCollectSDate.ReadOnly = true;
      this.TxtCollectSDate.RightToLeft = RightToLeft.No;
      this.TxtCollectSDate.Size = new Size(128, 23);
      this.TxtCollectSDate.TabIndex = 21;
      this.TxtRecordCount.AcceptsReturn = true;
      this.TxtRecordCount.BackColor = SystemColors.Window;
      this.TxtRecordCount.Cursor = Cursors.IBeam;
      this.TxtRecordCount.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TxtRecordCount.ForeColor = SystemColors.WindowText;
      this.TxtRecordCount.Location = new Point(515, 122);
      this.TxtRecordCount.Margin = new Padding(4, 4, 4, 4);
      this.TxtRecordCount.MaxLength = 0;
      this.TxtRecordCount.Name = "TxtRecordCount";
      this.TxtRecordCount.ReadOnly = true;
      this.TxtRecordCount.RightToLeft = RightToLeft.No;
      this.TxtRecordCount.Size = new Size(64, 23);
      this.TxtRecordCount.TabIndex = 19;
      this.TxtShortRoomNumber.AcceptsReturn = true;
      this.TxtShortRoomNumber.BackColor = SystemColors.Window;
      this.TxtShortRoomNumber.Cursor = Cursors.IBeam;
      this.TxtShortRoomNumber.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TxtShortRoomNumber.ForeColor = SystemColors.WindowText;
      this.TxtShortRoomNumber.Location = new Point(205, 122);
      this.TxtShortRoomNumber.Margin = new Padding(4, 4, 4, 4);
      this.TxtShortRoomNumber.MaxLength = 0;
      this.TxtShortRoomNumber.Name = "TxtShortRoomNumber";
      this.TxtShortRoomNumber.ReadOnly = true;
      this.TxtShortRoomNumber.RightToLeft = RightToLeft.No;
      this.TxtShortRoomNumber.Size = new Size(128, 26);
      this.TxtShortRoomNumber.TabIndex = 17;
      this.ToolTip1.SetToolTip((Control) this.TxtShortRoomNumber, "Lock No.");
      this.Label6.BackColor = Color.Transparent;
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Red;
      this.Label6.Location = new Point(3, 53);
      this.Label6.Margin = new Padding(4, 0, 4, 0);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(1047, 41);
      this.Label6.TabIndex = 28;
      this.Label6.Text = "Upload Room Unlock Transaction from Data Card";
      this.Label6.TextAlign = ContentAlignment.TopCenter;
      this.Label5.BackColor = Color.Transparent;
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Blue;
      this.Label5.Location = new Point(3, 4);
      this.Label5.Margin = new Padding(4, 0, 4, 0);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(1047, 50);
      this.Label5.TabIndex = 27;
      this.Label5.Text = "Admin Mode";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(355, 171);
      this.Label4.Margin = new Padding(4, 0, 4, 0);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(140, 31);
      this.Label4.TabIndex = 24;
      this.Label4.Text = "Collect Time";
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(24, 171);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(172, 31);
      this.Label3.TabIndex = 20;
      this.Label3.Text = "Collect Date";
      this.Label2.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(355, 122);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(140, 31);
      this.Label2.TabIndex = 18;
      this.Label2.Text = "Total Records";
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ControlText;
      this.Label1.Location = new Point(24, 122);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(172, 31);
      this.Label1.TabIndex = 16;
      this.Label1.Text = "Room(Lock) No";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1064, 719);
      this.Controls.Add((Control) this.txtCollectTime);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Data1);
      this.Controls.Add((Control) this.PicMsg);
      this.Controls.Add((Control) this.TxtCollectSDate);
      this.Controls.Add((Control) this.TxtRecordCount);
      this.Controls.Add((Control) this.TxtShortRoomNumber);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Margin = new Padding(4, 4, 4, 4);
      this.Name = "Form_ReadDataCardDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.FormClosing += new FormClosingEventHandler(this.Form_ReadDataCardDMS_FormClosing);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
