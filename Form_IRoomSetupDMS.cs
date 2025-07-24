// Decompiled with JetBrains decompiler
// Type: AMS.Form_IRoomSetupDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.SystemDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_IRoomSetupDMS : Form
  {
    private IContainer components;
    public Button cmdWPlus2;
    public TextBox txtWRateChange2;
    public TextBox txtWRateChange;
    public Button cmdWPlus;
    public Button cmdWMinus;
    public TextBox txtMRateChange;
    public Button cmdMPlus;
    public Button cmdMMinus;
    public Button cmdDMinus;
    public Button cmdDPlus;
    public TextBox txtDRateChange;
    public TextBox txtRmType;
    public ComboBox cboFloorNo;
    public Label lblBuildingType;
    public Label lblStudio2;
    public Label lblStudio1;
    public Label Label8;
    public Label Label5;
    public Label Label3;
    public Label Label14;
    public Label Label12;
    public Label Label4;
    public Label lblFloorNo;
    public Label Label7;
    public ToolTip ToolTip1;
    public TextBox txtDRate2;
    public TextBox txtMRate2;
    public TextBox txtWRate2;
    public Button cmdReturn;
    public TextBox txtWRate;
    public TextBox txtMRate;
    public TextBox txtDRate;
    public ComboBox cboRmType;
    public ComboBox cboBuildingNo;
    public TextBox txtRmNo;
    public Button cmdNew;
    public Button cmdAdd;
    public Button cmdRmNoBrowse;
    public Button cmdPrevious;
    public Button cmdFirst;
    public Button cmdNext;
    public Button cmdLast;
    public TextBox txtDRateChange2;
    public Button cmdDPlus2;
    public Button cmdDMinus2;
    public Button cmdMMinus2;
    public Button cmdMPlus2;
    public TextBox txtMRateChange2;
    public Button cmdWMinus2;
    public Label Label2;
    public Label Label1;
    private Panel panel1;
    private DB db;
    public SystemDataSet Browse_Room_SystemDataSet;
    public RoomTableAdapter RoomTableAdapter_1;
    public int selected_rowindex;
    public bool OK_Flag;
    public string Selected_Room_No = "";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_IRoomSetupDMS));
      this.cmdWPlus2 = new Button();
      this.txtWRateChange2 = new TextBox();
      this.txtWRateChange = new TextBox();
      this.cmdWPlus = new Button();
      this.cmdWMinus = new Button();
      this.txtMRateChange = new TextBox();
      this.cmdMPlus = new Button();
      this.cmdMMinus = new Button();
      this.cmdDMinus = new Button();
      this.cmdDPlus = new Button();
      this.txtDRateChange = new TextBox();
      this.txtRmType = new TextBox();
      this.cboFloorNo = new ComboBox();
      this.lblBuildingType = new Label();
      this.lblStudio2 = new Label();
      this.lblStudio1 = new Label();
      this.Label8 = new Label();
      this.Label5 = new Label();
      this.Label3 = new Label();
      this.Label14 = new Label();
      this.Label12 = new Label();
      this.Label4 = new Label();
      this.lblFloorNo = new Label();
      this.Label7 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.txtDRate2 = new TextBox();
      this.txtMRate2 = new TextBox();
      this.txtWRate2 = new TextBox();
      this.cmdReturn = new Button();
      this.txtWRate = new TextBox();
      this.txtMRate = new TextBox();
      this.txtDRate = new TextBox();
      this.cboRmType = new ComboBox();
      this.cboBuildingNo = new ComboBox();
      this.txtRmNo = new TextBox();
      this.cmdNew = new Button();
      this.cmdAdd = new Button();
      this.cmdRmNoBrowse = new Button();
      this.cmdPrevious = new Button();
      this.cmdFirst = new Button();
      this.cmdNext = new Button();
      this.cmdLast = new Button();
      this.txtDRateChange2 = new TextBox();
      this.cmdDPlus2 = new Button();
      this.cmdDMinus2 = new Button();
      this.cmdMMinus2 = new Button();
      this.cmdMPlus2 = new Button();
      this.txtMRateChange2 = new TextBox();
      this.cmdWMinus2 = new Button();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.panel1 = new Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.cmdWPlus2.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdWPlus2.Cursor = Cursors.Default;
      this.cmdWPlus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdWPlus2.ForeColor = SystemColors.ControlText;
      this.cmdWPlus2.Location = new Point(413, 212);
      this.cmdWPlus2.Name = "cmdWPlus2";
      this.cmdWPlus2.RightToLeft = RightToLeft.No;
      this.cmdWPlus2.Size = new Size(33, 24);
      this.cmdWPlus2.TabIndex = 91;
      this.cmdWPlus2.Text = "+";
      this.cmdWPlus2.UseVisualStyleBackColor = false;
      this.cmdWPlus2.Click += new EventHandler(this.cmdWPlus2_Click);
      this.txtWRateChange2.AcceptsReturn = true;
      this.txtWRateChange2.BackColor = SystemColors.Window;
      this.txtWRateChange2.Cursor = Cursors.IBeam;
      this.txtWRateChange2.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtWRateChange2.ForeColor = Color.Blue;
      this.txtWRateChange2.Location = new Point(453, 212);
      this.txtWRateChange2.MaxLength = 0;
      this.txtWRateChange2.Name = "txtWRateChange2";
      this.txtWRateChange2.RightToLeft = RightToLeft.No;
      this.txtWRateChange2.Size = new Size(41, 24);
      this.txtWRateChange2.TabIndex = 65;
      this.txtWRateChange2.TextAlign = HorizontalAlignment.Center;
      this.txtWRateChange2.KeyPress += new KeyPressEventHandler(this.txtWRateChange2_KeyPress);
      this.txtWRateChange.AcceptsReturn = true;
      this.txtWRateChange.BackColor = SystemColors.Window;
      this.txtWRateChange.Cursor = Cursors.IBeam;
      this.txtWRateChange.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtWRateChange.ForeColor = Color.Blue;
      this.txtWRateChange.Location = new Point(285, 212);
      this.txtWRateChange.MaxLength = 0;
      this.txtWRateChange.Name = "txtWRateChange";
      this.txtWRateChange.RightToLeft = RightToLeft.No;
      this.txtWRateChange.Size = new Size(41, 24);
      this.txtWRateChange.TabIndex = 62;
      this.txtWRateChange.TextAlign = HorizontalAlignment.Center;
      this.txtWRateChange.KeyPress += new KeyPressEventHandler(this.txtWRateChange_KeyPress);
      this.cmdWPlus.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdWPlus.Cursor = Cursors.Default;
      this.cmdWPlus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdWPlus.ForeColor = SystemColors.ControlText;
      this.cmdWPlus.Location = new Point(245, 212);
      this.cmdWPlus.Name = "cmdWPlus";
      this.cmdWPlus.RightToLeft = RightToLeft.No;
      this.cmdWPlus.Size = new Size(33, 24);
      this.cmdWPlus.TabIndex = 87;
      this.cmdWPlus.Text = "+";
      this.cmdWPlus.UseVisualStyleBackColor = false;
      this.cmdWPlus.Click += new EventHandler(this.cmdWPlus_Click);
      this.cmdWMinus.BackColor = SystemColors.Control;
      this.cmdWMinus.Cursor = Cursors.Default;
      this.cmdWMinus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdWMinus.ForeColor = SystemColors.ControlText;
      this.cmdWMinus.Location = new Point(245, 236);
      this.cmdWMinus.Name = "cmdWMinus";
      this.cmdWMinus.RightToLeft = RightToLeft.No;
      this.cmdWMinus.Size = new Size(33, 24);
      this.cmdWMinus.TabIndex = 86;
      this.cmdWMinus.Text = "-";
      this.cmdWMinus.UseVisualStyleBackColor = false;
      this.cmdWMinus.Click += new EventHandler(this.cmdWMinus_Click);
      this.txtMRateChange.AcceptsReturn = true;
      this.txtMRateChange.BackColor = SystemColors.Window;
      this.txtMRateChange.Cursor = Cursors.IBeam;
      this.txtMRateChange.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtMRateChange.ForeColor = Color.Blue;
      this.txtMRateChange.Location = new Point(285, 268);
      this.txtMRateChange.MaxLength = 0;
      this.txtMRateChange.Name = "txtMRateChange";
      this.txtMRateChange.RightToLeft = RightToLeft.No;
      this.txtMRateChange.Size = new Size(41, 24);
      this.txtMRateChange.TabIndex = 63;
      this.txtMRateChange.TextAlign = HorizontalAlignment.Center;
      this.txtMRateChange.KeyPress += new KeyPressEventHandler(this.txtMRateChange_KeyPress);
      this.cmdMPlus.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdMPlus.Cursor = Cursors.Default;
      this.cmdMPlus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdMPlus.ForeColor = SystemColors.ControlText;
      this.cmdMPlus.Location = new Point(245, 268);
      this.cmdMPlus.Name = "cmdMPlus";
      this.cmdMPlus.RightToLeft = RightToLeft.No;
      this.cmdMPlus.Size = new Size(33, 24);
      this.cmdMPlus.TabIndex = 84;
      this.cmdMPlus.Text = "+";
      this.cmdMPlus.UseVisualStyleBackColor = false;
      this.cmdMPlus.Click += new EventHandler(this.cmdMPlus_Click);
      this.cmdMMinus.BackColor = SystemColors.Control;
      this.cmdMMinus.Cursor = Cursors.Default;
      this.cmdMMinus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdMMinus.ForeColor = SystemColors.ControlText;
      this.cmdMMinus.Location = new Point(245, 292);
      this.cmdMMinus.Name = "cmdMMinus";
      this.cmdMMinus.RightToLeft = RightToLeft.No;
      this.cmdMMinus.Size = new Size(33, 24);
      this.cmdMMinus.TabIndex = 83;
      this.cmdMMinus.Text = "-";
      this.cmdMMinus.UseVisualStyleBackColor = false;
      this.cmdMMinus.Click += new EventHandler(this.cmdMMinus_Click);
      this.cmdDMinus.BackColor = SystemColors.Control;
      this.cmdDMinus.Cursor = Cursors.Default;
      this.cmdDMinus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDMinus.ForeColor = SystemColors.ControlText;
      this.cmdDMinus.Location = new Point(245, 180);
      this.cmdDMinus.Name = "cmdDMinus";
      this.cmdDMinus.RightToLeft = RightToLeft.No;
      this.cmdDMinus.Size = new Size(33, 24);
      this.cmdDMinus.TabIndex = 68;
      this.cmdDMinus.Text = "-";
      this.cmdDMinus.UseVisualStyleBackColor = false;
      this.cmdDMinus.Click += new EventHandler(this.cmdDMinus_Click);
      this.cmdDPlus.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdDPlus.Cursor = Cursors.Default;
      this.cmdDPlus.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDPlus.ForeColor = SystemColors.ControlText;
      this.cmdDPlus.Location = new Point(245, 156);
      this.cmdDPlus.Name = "cmdDPlus";
      this.cmdDPlus.RightToLeft = RightToLeft.No;
      this.cmdDPlus.Size = new Size(33, 24);
      this.cmdDPlus.TabIndex = 67;
      this.cmdDPlus.Text = "+";
      this.cmdDPlus.UseVisualStyleBackColor = false;
      this.cmdDPlus.Click += new EventHandler(this.cmdDPlus_Click);
      this.txtDRateChange.AcceptsReturn = true;
      this.txtDRateChange.BackColor = SystemColors.Window;
      this.txtDRateChange.Cursor = Cursors.IBeam;
      this.txtDRateChange.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDRateChange.ForeColor = Color.Blue;
      this.txtDRateChange.Location = new Point(285, 156);
      this.txtDRateChange.MaxLength = 0;
      this.txtDRateChange.Name = "txtDRateChange";
      this.txtDRateChange.RightToLeft = RightToLeft.No;
      this.txtDRateChange.Size = new Size(41, 24);
      this.txtDRateChange.TabIndex = 61;
      this.txtDRateChange.TextAlign = HorizontalAlignment.Center;
      this.txtDRateChange.KeyPress += new KeyPressEventHandler(this.txtDRateChange_KeyPress);
      this.txtRmType.AcceptsReturn = true;
      this.txtRmType.BackColor = SystemColors.Window;
      this.txtRmType.Cursor = Cursors.IBeam;
      this.txtRmType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRmType.ForeColor = Color.Blue;
      this.txtRmType.Location = new Point(485, 92);
      this.txtRmType.MaxLength = 0;
      this.txtRmType.Name = "txtRmType";
      this.txtRmType.RightToLeft = RightToLeft.No;
      this.txtRmType.Size = new Size(41, 20);
      this.txtRmType.TabIndex = 77;
      this.txtRmType.Visible = false;
      this.cboFloorNo.BackColor = SystemColors.Window;
      this.cboFloorNo.Cursor = Cursors.Default;
      this.cboFloorNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboFloorNo.ForeColor = Color.Blue;
      this.cboFloorNo.Location = new Point(173, 52);
      this.cboFloorNo.Name = "cboFloorNo";
      this.cboFloorNo.RightToLeft = RightToLeft.No;
      this.cboFloorNo.Size = new Size(49, 22);
      this.cboFloorNo.TabIndex = 52;
      this.cboFloorNo.Visible = false;
      this.lblBuildingType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblBuildingType.Cursor = Cursors.Default;
      this.lblBuildingType.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuildingType.ForeColor = Color.Red;
      this.lblBuildingType.Location = new Point(237, 20);
      this.lblBuildingType.Name = "lblBuildingType";
      this.lblBuildingType.RightToLeft = RightToLeft.No;
      this.lblBuildingType.Size = new Size(217, 25);
      this.lblBuildingType.TabIndex = 99;
      this.lblStudio2.BackColor = Color.Blue;
      this.lblStudio2.Cursor = Cursors.Default;
      this.lblStudio2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblStudio2.ForeColor = Color.White;
      this.lblStudio2.Location = new Point(341, 140);
      this.lblStudio2.Name = "lblStudio2";
      this.lblStudio2.RightToLeft = RightToLeft.No;
      this.lblStudio2.Size = new Size(105, 17);
      this.lblStudio2.TabIndex = 98;
      this.lblStudio2.Text = "For Two Persons";
      this.lblStudio1.BackColor = Color.Blue;
      this.lblStudio1.Cursor = Cursors.Default;
      this.lblStudio1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblStudio1.ForeColor = Color.White;
      this.lblStudio1.Location = new Point(173, 140);
      this.lblStudio1.Name = "lblStudio1";
      this.lblStudio1.RightToLeft = RightToLeft.No;
      this.lblStudio1.Size = new Size(89, 17);
      this.lblStudio1.TabIndex = 97;
      this.lblStudio1.Text = "For One Person";
      this.Label8.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.Blue;
      this.Label8.Location = new Point(29, 132);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(89, 25);
      this.Label8.TabIndex = 89;
      this.Label8.Text = "ROOM RATE :";
      this.Label5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(109, 212);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(49, 25);
      this.Label5.TabIndex = 88;
      this.Label5.Text = "Weekly ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Red;
      this.Label3.Location = new Point(109, 268);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(58, 25);
      this.Label3.TabIndex = 85;
      this.Label3.Text = "Monthly ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label14.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.Red;
      this.Label14.Location = new Point(109, 156);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(49, 25);
      this.Label14.TabIndex = 82;
      this.Label14.Text = "Daily ";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(69, 92);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(89, 25);
      this.Label12.TabIndex = 81;
      this.Label12.Text = "Room No.";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label4.Location = new Point(277, 92);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(89, 25);
      this.Label4.TabIndex = 80;
      this.Label4.Text = "Room Type";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.lblFloorNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblFloorNo.Cursor = Cursors.Default;
      this.lblFloorNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFloorNo.ForeColor = SystemColors.ControlText;
      this.lblFloorNo.Location = new Point(61, 52);
      this.lblFloorNo.Name = "lblFloorNo";
      this.lblFloorNo.RightToLeft = RightToLeft.No;
      this.lblFloorNo.Size = new Size(89, 25);
      this.lblFloorNo.TabIndex = 79;
      this.lblFloorNo.Text = "Floor No.";
      this.lblFloorNo.TextAlign = ContentAlignment.TopRight;
      this.lblFloorNo.Visible = false;
      this.Label7.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(0, 128, 0);
      this.Label7.Location = new Point(69, 20);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(89, 25);
      this.Label7.TabIndex = 78;
      this.Label7.Text = "Building No.";
      this.Label7.TextAlign = ContentAlignment.TopRight;
      this.txtDRate2.AcceptsReturn = true;
      this.txtDRate2.BackColor = SystemColors.Window;
      this.txtDRate2.Cursor = Cursors.IBeam;
      this.txtDRate2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDRate2.ForeColor = Color.Blue;
      this.txtDRate2.Location = new Point(341, 156);
      this.txtDRate2.MaxLength = 0;
      this.txtDRate2.Name = "txtDRate2";
      this.txtDRate2.RightToLeft = RightToLeft.No;
      this.txtDRate2.Size = new Size(65, 20);
      this.txtDRate2.TabIndex = 57;
      this.txtDRate2.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtDRate2, "Enter Room No.");
      this.txtDRate2.KeyPress += new KeyPressEventHandler(this.txtDRate2_KeyPress);
      this.txtMRate2.AcceptsReturn = true;
      this.txtMRate2.BackColor = SystemColors.Window;
      this.txtMRate2.Cursor = Cursors.IBeam;
      this.txtMRate2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMRate2.ForeColor = Color.Blue;
      this.txtMRate2.Location = new Point(341, 268);
      this.txtMRate2.MaxLength = 0;
      this.txtMRate2.Name = "txtMRate2";
      this.txtMRate2.RightToLeft = RightToLeft.No;
      this.txtMRate2.Size = new Size(65, 20);
      this.txtMRate2.TabIndex = 59;
      this.txtMRate2.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtMRate2, "Enter Room No.");
      this.txtMRate2.KeyPress += new KeyPressEventHandler(this.txtMRate2_KeyPress);
      this.txtWRate2.AcceptsReturn = true;
      this.txtWRate2.BackColor = SystemColors.Window;
      this.txtWRate2.Cursor = Cursors.IBeam;
      this.txtWRate2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtWRate2.ForeColor = Color.Blue;
      this.txtWRate2.Location = new Point(341, 212);
      this.txtWRate2.MaxLength = 0;
      this.txtWRate2.Name = "txtWRate2";
      this.txtWRate2.RightToLeft = RightToLeft.No;
      this.txtWRate2.Size = new Size(65, 20);
      this.txtWRate2.TabIndex = 58;
      this.txtWRate2.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtWRate2, "Enter Room No.");
      this.txtWRate2.KeyPress += new KeyPressEventHandler(this.txtWRate2_KeyPress);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(409, 452);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(73, 41);
      this.cmdReturn.TabIndex = 90;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "To Return Main Setting Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtWRate.AcceptsReturn = true;
      this.txtWRate.BackColor = SystemColors.Window;
      this.txtWRate.Cursor = Cursors.IBeam;
      this.txtWRate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtWRate.ForeColor = Color.Blue;
      this.txtWRate.Location = new Point(173, 212);
      this.txtWRate.MaxLength = 0;
      this.txtWRate.Name = "txtWRate";
      this.txtWRate.RightToLeft = RightToLeft.No;
      this.txtWRate.Size = new Size(65, 20);
      this.txtWRate.TabIndex = 55;
      this.txtWRate.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtWRate, "Enter Room No.");
      this.txtWRate.KeyPress += new KeyPressEventHandler(this.txtWRate_KeyPress);
      this.txtMRate.AcceptsReturn = true;
      this.txtMRate.BackColor = SystemColors.Window;
      this.txtMRate.Cursor = Cursors.IBeam;
      this.txtMRate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMRate.ForeColor = Color.Blue;
      this.txtMRate.Location = new Point(173, 268);
      this.txtMRate.MaxLength = 0;
      this.txtMRate.Name = "txtMRate";
      this.txtMRate.RightToLeft = RightToLeft.No;
      this.txtMRate.Size = new Size(65, 20);
      this.txtMRate.TabIndex = 56;
      this.txtMRate.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtMRate, "Enter Room No.");
      this.txtMRate.KeyPress += new KeyPressEventHandler(this.txtMRate_KeyPress);
      this.txtDRate.AcceptsReturn = true;
      this.txtDRate.BackColor = SystemColors.Window;
      this.txtDRate.Cursor = Cursors.IBeam;
      this.txtDRate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDRate.ForeColor = Color.Blue;
      this.txtDRate.Location = new Point(173, 156);
      this.txtDRate.MaxLength = 0;
      this.txtDRate.Name = "txtDRate";
      this.txtDRate.RightToLeft = RightToLeft.No;
      this.txtDRate.Size = new Size(65, 20);
      this.txtDRate.TabIndex = 54;
      this.txtDRate.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtDRate, "Enter Room No.");
      this.txtDRate.KeyPress += new KeyPressEventHandler(this.txtDRate_KeyPress);
      this.cboRmType.BackColor = SystemColors.Window;
      this.cboRmType.Cursor = Cursors.Default;
      this.cboRmType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboRmType.ForeColor = Color.Blue;
      this.cboRmType.Location = new Point(381, 92);
      this.cboRmType.Name = "cboRmType";
      this.cboRmType.RightToLeft = RightToLeft.No;
      this.cboRmType.Size = new Size(105, 22);
      this.cboRmType.TabIndex = 53;
      this.ToolTip1.SetToolTip((Control) this.cboRmType, "Select Room Type");
      this.cboRmType.SelectedIndexChanged += new EventHandler(this.cboRmType_SelectedIndexChanged);
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(173, 20);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 22);
      this.cboBuildingNo.TabIndex = 51;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building");
      this.txtRmNo.AcceptsReturn = true;
      this.txtRmNo.BackColor = SystemColors.Window;
      this.txtRmNo.Cursor = Cursors.IBeam;
      this.txtRmNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRmNo.ForeColor = Color.Blue;
      this.txtRmNo.Location = new Point(173, 92);
      this.txtRmNo.MaxLength = 0;
      this.txtRmNo.Name = "txtRmNo";
      this.txtRmNo.ReadOnly = true;
      this.txtRmNo.RightToLeft = RightToLeft.No;
      this.txtRmNo.Size = new Size(65, 20);
      this.txtRmNo.TabIndex = 50;
      this.txtRmNo.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtRmNo, "Enter Room No.");
      this.txtRmNo.VisibleChanged += new EventHandler(this.txtRmNo_VisibleChanged);
      this.cmdNew.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdNew.Cursor = Cursors.Default;
      this.cmdNew.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNew.ForeColor = SystemColors.ControlText;
      this.cmdNew.Location = new Point(265, 452);
      this.cmdNew.Name = "cmdNew";
      this.cmdNew.RightToLeft = RightToLeft.No;
      this.cmdNew.Size = new Size(73, 41);
      this.cmdNew.TabIndex = 70;
      this.cmdNew.Text = "&CLEAR";
      this.ToolTip1.SetToolTip((Control) this.cmdNew, "Click to Clear Screen");
      this.cmdNew.UseVisualStyleBackColor = false;
      this.cmdNew.Click += new EventHandler(this.cmdNew_Click);
      this.cmdAdd.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdAdd.Cursor = Cursors.Default;
      this.cmdAdd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdAdd.ForeColor = SystemColors.ControlText;
      this.cmdAdd.Location = new Point(337, 452);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.RightToLeft = RightToLeft.No;
      this.cmdAdd.Size = new Size(73, 41);
      this.cmdAdd.TabIndex = 69;
      this.cmdAdd.Text = "&SAVE";
      this.ToolTip1.SetToolTip((Control) this.cmdAdd, "Click to Confirm Update");
      this.cmdAdd.UseVisualStyleBackColor = false;
      this.cmdAdd.Click += new EventHandler(this.cmdAdd_Click);
      this.cmdRmNoBrowse.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdRmNoBrowse.Cursor = Cursors.Default;
      this.cmdRmNoBrowse.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdRmNoBrowse.ForeColor = SystemColors.ControlText;
      this.cmdRmNoBrowse.Image = (Image) componentResourceManager.GetObject("cmdRmNoBrowse.Image");
      this.cmdRmNoBrowse.Location = new Point(245, 92);
      this.cmdRmNoBrowse.Name = "cmdRmNoBrowse";
      this.cmdRmNoBrowse.RightToLeft = RightToLeft.No;
      this.cmdRmNoBrowse.Size = new Size(25, 25);
      this.cmdRmNoBrowse.TabIndex = 60;
      this.cmdRmNoBrowse.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdRmNoBrowse, "Click to View/Select Room");
      this.cmdRmNoBrowse.UseVisualStyleBackColor = false;
      this.cmdRmNoBrowse.Click += new EventHandler(this.cmdRmNoBrowse_Click);
      this.cmdPrevious.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.cmdPrevious.Cursor = Cursors.Default;
      this.cmdPrevious.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrevious.ForeColor = SystemColors.ControlText;
      this.cmdPrevious.Location = new Point(233, 452);
      this.cmdPrevious.Name = "cmdPrevious";
      this.cmdPrevious.RightToLeft = RightToLeft.No;
      this.cmdPrevious.Size = new Size(33, 33);
      this.cmdPrevious.TabIndex = 71;
      this.cmdPrevious.Text = "<";
      this.ToolTip1.SetToolTip((Control) this.cmdPrevious, "Go to Previous Record");
      this.cmdPrevious.UseVisualStyleBackColor = false;
      this.cmdPrevious.Click += new EventHandler(this.cmdPrevious_Click);
      this.cmdFirst.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.cmdFirst.Cursor = Cursors.Default;
      this.cmdFirst.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdFirst.ForeColor = SystemColors.ControlText;
      this.cmdFirst.Location = new Point(201, 452);
      this.cmdFirst.Name = "cmdFirst";
      this.cmdFirst.RightToLeft = RightToLeft.No;
      this.cmdFirst.Size = new Size(33, 33);
      this.cmdFirst.TabIndex = 72;
      this.cmdFirst.Text = "<|";
      this.ToolTip1.SetToolTip((Control) this.cmdFirst, "Go to First Record");
      this.cmdFirst.UseVisualStyleBackColor = false;
      this.cmdFirst.Click += new EventHandler(this.cmdFirst_Click);
      this.cmdNext.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.cmdNext.Cursor = Cursors.Default;
      this.cmdNext.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNext.ForeColor = SystemColors.ControlText;
      this.cmdNext.Location = new Point(481, 452);
      this.cmdNext.Name = "cmdNext";
      this.cmdNext.RightToLeft = RightToLeft.No;
      this.cmdNext.Size = new Size(33, 33);
      this.cmdNext.TabIndex = 73;
      this.cmdNext.Text = ">";
      this.ToolTip1.SetToolTip((Control) this.cmdNext, "Go to Next Record");
      this.cmdNext.UseVisualStyleBackColor = false;
      this.cmdNext.Click += new EventHandler(this.cmdNext_Click);
      this.cmdLast.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.cmdLast.Cursor = Cursors.Default;
      this.cmdLast.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdLast.ForeColor = SystemColors.ControlText;
      this.cmdLast.Location = new Point(513, 452);
      this.cmdLast.Name = "cmdLast";
      this.cmdLast.RightToLeft = RightToLeft.No;
      this.cmdLast.Size = new Size(33, 33);
      this.cmdLast.TabIndex = 74;
      this.cmdLast.Text = "|>";
      this.ToolTip1.SetToolTip((Control) this.cmdLast, "Go to Last Record");
      this.cmdLast.UseVisualStyleBackColor = false;
      this.cmdLast.Click += new EventHandler(this.cmdLast_Click);
      this.txtDRateChange2.AcceptsReturn = true;
      this.txtDRateChange2.BackColor = SystemColors.Window;
      this.txtDRateChange2.Cursor = Cursors.IBeam;
      this.txtDRateChange2.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDRateChange2.ForeColor = Color.Blue;
      this.txtDRateChange2.Location = new Point(453, 156);
      this.txtDRateChange2.MaxLength = 0;
      this.txtDRateChange2.Name = "txtDRateChange2";
      this.txtDRateChange2.RightToLeft = RightToLeft.No;
      this.txtDRateChange2.Size = new Size(41, 24);
      this.txtDRateChange2.TabIndex = 64;
      this.txtDRateChange2.TextAlign = HorizontalAlignment.Center;
      this.txtDRateChange2.KeyPress += new KeyPressEventHandler(this.txtDRateChange2_KeyPress);
      this.cmdDPlus2.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdDPlus2.Cursor = Cursors.Default;
      this.cmdDPlus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDPlus2.ForeColor = SystemColors.ControlText;
      this.cmdDPlus2.Location = new Point(413, 156);
      this.cmdDPlus2.Name = "cmdDPlus2";
      this.cmdDPlus2.RightToLeft = RightToLeft.No;
      this.cmdDPlus2.Size = new Size(33, 24);
      this.cmdDPlus2.TabIndex = 96;
      this.cmdDPlus2.Text = "+";
      this.cmdDPlus2.UseVisualStyleBackColor = false;
      this.cmdDPlus2.Click += new EventHandler(this.cmdDPlus2_Click);
      this.cmdDMinus2.BackColor = SystemColors.Control;
      this.cmdDMinus2.Cursor = Cursors.Default;
      this.cmdDMinus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDMinus2.ForeColor = SystemColors.ControlText;
      this.cmdDMinus2.Location = new Point(413, 180);
      this.cmdDMinus2.Name = "cmdDMinus2";
      this.cmdDMinus2.RightToLeft = RightToLeft.No;
      this.cmdDMinus2.Size = new Size(33, 24);
      this.cmdDMinus2.TabIndex = 95;
      this.cmdDMinus2.Text = "-";
      this.cmdDMinus2.UseVisualStyleBackColor = false;
      this.cmdDMinus2.Click += new EventHandler(this.cmdDMinus2_Click);
      this.cmdMMinus2.BackColor = SystemColors.Control;
      this.cmdMMinus2.Cursor = Cursors.Default;
      this.cmdMMinus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdMMinus2.ForeColor = SystemColors.ControlText;
      this.cmdMMinus2.Location = new Point(413, 292);
      this.cmdMMinus2.Name = "cmdMMinus2";
      this.cmdMMinus2.RightToLeft = RightToLeft.No;
      this.cmdMMinus2.Size = new Size(33, 24);
      this.cmdMMinus2.TabIndex = 94;
      this.cmdMMinus2.Text = "-";
      this.cmdMMinus2.UseVisualStyleBackColor = false;
      this.cmdMMinus2.Click += new EventHandler(this.cmdMMinus2_Click);
      this.cmdMPlus2.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdMPlus2.Cursor = Cursors.Default;
      this.cmdMPlus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdMPlus2.ForeColor = SystemColors.ControlText;
      this.cmdMPlus2.Location = new Point(413, 268);
      this.cmdMPlus2.Name = "cmdMPlus2";
      this.cmdMPlus2.RightToLeft = RightToLeft.No;
      this.cmdMPlus2.Size = new Size(33, 24);
      this.cmdMPlus2.TabIndex = 93;
      this.cmdMPlus2.Text = "+";
      this.cmdMPlus2.UseVisualStyleBackColor = false;
      this.cmdMPlus2.Click += new EventHandler(this.cmdMPlus2_Click);
      this.txtMRateChange2.AcceptsReturn = true;
      this.txtMRateChange2.BackColor = SystemColors.Window;
      this.txtMRateChange2.Cursor = Cursors.IBeam;
      this.txtMRateChange2.Font = new Font("Tahoma", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtMRateChange2.ForeColor = Color.Blue;
      this.txtMRateChange2.Location = new Point(453, 268);
      this.txtMRateChange2.MaxLength = 0;
      this.txtMRateChange2.Name = "txtMRateChange2";
      this.txtMRateChange2.RightToLeft = RightToLeft.No;
      this.txtMRateChange2.Size = new Size(41, 24);
      this.txtMRateChange2.TabIndex = 66;
      this.txtMRateChange2.TextAlign = HorizontalAlignment.Center;
      this.txtMRateChange2.KeyPress += new KeyPressEventHandler(this.txtMRateChange2_KeyPress);
      this.cmdWMinus2.BackColor = SystemColors.Control;
      this.cmdWMinus2.Cursor = Cursors.Default;
      this.cmdWMinus2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdWMinus2.ForeColor = SystemColors.ControlText;
      this.cmdWMinus2.Location = new Point(413, 236);
      this.cmdWMinus2.Name = "cmdWMinus2";
      this.cmdWMinus2.RightToLeft = RightToLeft.No;
      this.cmdWMinus2.Size = new Size(33, 24);
      this.cmdWMinus2.TabIndex = 92;
      this.cmdWMinus2.Text = "-";
      this.cmdWMinus2.UseVisualStyleBackColor = false;
      this.cmdWMinus2.Click += new EventHandler(this.cmdWMinus2_Click);
      this.Label2.BackColor = Color.White;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(1, 60);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 33);
      this.Label2.TabIndex = 76;
      this.Label2.Text = "INDIVIDUAL ROOM SETUP";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.White;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(1, 4);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 41);
      this.Label1.TabIndex = 75;
      this.Label1.Text = "System Mode";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.panel1.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel1.Controls.Add((Control) this.cmdWPlus2);
      this.panel1.Controls.Add((Control) this.txtWRateChange2);
      this.panel1.Controls.Add((Control) this.txtWRateChange);
      this.panel1.Controls.Add((Control) this.cmdWPlus);
      this.panel1.Controls.Add((Control) this.cmdWMinus);
      this.panel1.Controls.Add((Control) this.txtMRateChange);
      this.panel1.Controls.Add((Control) this.cmdMPlus);
      this.panel1.Controls.Add((Control) this.cmdMMinus);
      this.panel1.Controls.Add((Control) this.cmdDMinus);
      this.panel1.Controls.Add((Control) this.cmdDPlus);
      this.panel1.Controls.Add((Control) this.txtDRateChange);
      this.panel1.Controls.Add((Control) this.txtRmType);
      this.panel1.Controls.Add((Control) this.cboFloorNo);
      this.panel1.Controls.Add((Control) this.lblBuildingType);
      this.panel1.Controls.Add((Control) this.lblStudio2);
      this.panel1.Controls.Add((Control) this.lblStudio1);
      this.panel1.Controls.Add((Control) this.Label8);
      this.panel1.Controls.Add((Control) this.Label5);
      this.panel1.Controls.Add((Control) this.Label3);
      this.panel1.Controls.Add((Control) this.Label14);
      this.panel1.Controls.Add((Control) this.Label12);
      this.panel1.Controls.Add((Control) this.Label4);
      this.panel1.Controls.Add((Control) this.lblFloorNo);
      this.panel1.Controls.Add((Control) this.Label7);
      this.panel1.Controls.Add((Control) this.txtDRate2);
      this.panel1.Controls.Add((Control) this.txtDRateChange2);
      this.panel1.Controls.Add((Control) this.cmdDPlus2);
      this.panel1.Controls.Add((Control) this.cmdDMinus2);
      this.panel1.Controls.Add((Control) this.cmdMMinus2);
      this.panel1.Controls.Add((Control) this.cmdMPlus2);
      this.panel1.Controls.Add((Control) this.txtMRateChange2);
      this.panel1.Controls.Add((Control) this.txtMRate2);
      this.panel1.Controls.Add((Control) this.cmdWMinus2);
      this.panel1.Controls.Add((Control) this.txtWRate2);
      this.panel1.Controls.Add((Control) this.txtWRate);
      this.panel1.Controls.Add((Control) this.txtMRate);
      this.panel1.Controls.Add((Control) this.txtDRate);
      this.panel1.Controls.Add((Control) this.cboRmType);
      this.panel1.Controls.Add((Control) this.cboBuildingNo);
      this.panel1.Controls.Add((Control) this.txtRmNo);
      this.panel1.Controls.Add((Control) this.cmdRmNoBrowse);
      this.panel1.Location = new Point(116, 112);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(569, 328);
      this.panel1.TabIndex = 100;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(792, 578);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cmdNew);
      this.Controls.Add((Control) this.cmdAdd);
      this.Controls.Add((Control) this.cmdPrevious);
      this.Controls.Add((Control) this.cmdFirst);
      this.Controls.Add((Control) this.cmdNext);
      this.Controls.Add((Control) this.cmdLast);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Name = "Form_IRoomSetupDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_IRoomSetupDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_IRoomSetupDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_IRoomSetupDMS_FormClosing);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_IRoomSetupDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
      this.Browse_Room_SystemDataSet = new SystemDataSet();
      this.RoomTableAdapter_1 = new RoomTableAdapter();
      this.RoomTableAdapter_1.ClearBeforeFill = true;
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
    }

    private void Form_IRoomSetupDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_IRoomSetupDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBuildingNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.ComboFloorCheck(this.cboFloorNo, Global_Data.sBldNo);
      if (this.cboFloorNo.Items.Count > 0)
        this.cboFloorNo.SelectedIndex = 0;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmType(this.cboRmType);
      this.Make_Clear();
      this.cmdRmNoBrowse.Focus();
      this.cmdRmNoBrowse.Select();
    }

    private void Check_RoomType_N_ChangeDisplay(byte para_RoomType_Num)
    {
      string roomTypeDescription = this.db.Get_RoomType_Description(para_RoomType_Num);
      if (roomTypeDescription.ToUpper().Contains("STUDIO") || roomTypeDescription.ToUpper().Contains("TWIN"))
      {
        this.lblStudio1.Visible = true;
        this.lblStudio2.Visible = true;
        this.lblStudio1.Text = "For One Person";
        this.lblStudio2.Text = "For Two Persons";
        this.txtDRate2.Visible = true;
        this.txtWRate2.Visible = true;
        this.txtMRate2.Visible = true;
        this.cmdDPlus2.Visible = true;
        this.cmdWPlus2.Visible = true;
        this.cmdMPlus2.Visible = true;
        this.cmdDMinus2.Visible = true;
        this.cmdWMinus2.Visible = true;
        this.cmdMMinus2.Visible = true;
        this.txtDRateChange2.Visible = true;
        this.txtWRateChange2.Visible = true;
        this.txtMRateChange2.Visible = true;
      }
      else
      {
        this.lblStudio1.Visible = false;
        this.lblStudio2.Visible = false;
        this.txtDRate2.Visible = false;
        this.txtWRate2.Visible = false;
        this.txtMRate2.Visible = false;
        this.cmdDPlus2.Visible = false;
        this.cmdWPlus2.Visible = false;
        this.cmdMPlus2.Visible = false;
        this.cmdDMinus2.Visible = false;
        this.cmdWMinus2.Visible = false;
        this.cmdMMinus2.Visible = false;
        this.txtDRateChange2.Visible = false;
        this.txtWRateChange2.Visible = false;
        this.txtMRateChange2.Visible = false;
      }
    }

    private void cboRmType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_RoomType_N_ChangeDisplay(this.db.Get_Room_Type_Num((string) this.cboRmType.SelectedItem));
    }

    private void Form_IRoomSetupDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Initialize_ComboRmType(this.cboRmType);
      this.Check_RoomType_N_ChangeDisplay(this.db.Get_Room_Type_Num((string) this.cboRmType.SelectedItem));
    }

    private bool CheckBuilding_N_DisplayBrowser(string para_BuildingNo) => true;

    private void Get_N_Set_SelectedRowData(int para_Selected_Index)
    {
      SystemDataSet.RoomRow row = (SystemDataSet.RoomRow) this.Browse_Room_SystemDataSet.Room.Rows[this.selected_rowindex];
      this.txtRmNo.Text = row.RoomNo;
      this.txtDRate.Text = row.DailyRate.ToString("F00");
      this.txtWRate.Text = row.WeeklyRate.ToString("F00");
      this.txtMRate.Text = row.MonthlyRate.ToString("F00");
      this.txtDRate2.Text = row.DailyRate2.ToString("F00");
      this.txtWRate2.Text = row.WeeklyRate2.ToString("F00");
      this.txtMRate2.Text = row.MonthlyRate2.ToString("F00");
      this.cboRmType.SelectedIndex = 0;
      this.cboRmType.SelectedItem = (object) this.db.Get_RoomType_Description(row.RoomType);
      this.cboFloorNo.SelectedItem = (object) Convert.ToByte(row.FloorNo).ToString();
      this.cboBuildingNo.SelectedItem = (object) row.BuildingNo;
      this.txtRmType.Text = this.db.Get_RoomType_Description(row.RoomType);
      this.Check_RoomType_N_ChangeDisplay(row.RoomType);
    }

    private void cmdRmNoBrowse_Click(object sender, EventArgs e)
    {
      if (!this.CheckBuilding_N_DisplayBrowser((string) this.cboBuildingNo.SelectedItem))
        return;
      int num = (int) new Form_Roombwr().ShowDialog();
      if (!this.OK_Flag)
        return;
      this.Make_Clear();
      this.txtRmNo.Text = this.Selected_Room_No;
      this.Enable_Controls();
      this.Get_N_Set_SelectedRowData(this.selected_rowindex);
    }

    private void Check_N_FilterFor_Number(string para_string, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '.')
      {
        if (para_string.Contains("."))
          e.Handled = true;
        else
          e.Handled = false;
      }
      else
        e.Handled = true;
    }

    private void txtDRate_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtDRate.Text, e);
    }

    private void txtWRate_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtWRate.Text, e);
    }

    private void txtMRate_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtMRate.Text, e);
    }

    private void txtDRate2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtDRate2.Text, e);
    }

    private void txtWRate2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtWRate2.Text, e);
    }

    private void txtMRate2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtMRate2.Text, e);
    }

    private void txtDRateChange_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtDRateChange.Text, e);
    }

    private void txtWRateChange_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtWRateChange.Text, e);
    }

    private void txtMRateChange_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtMRateChange.Text, e);
    }

    private void txtDRateChange2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtDRateChange2.Text, e);
    }

    private void txtWRateChange2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtWRateChange2.Text, e);
    }

    private void txtMRateChange2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Check_N_FilterFor_Number(this.txtMRateChange2.Text, e);
    }

    private string Add_Rate(string para_Org, string para_increate)
    {
      Decimal num1;
      try
      {
        num1 = Convert.ToDecimal(para_Org);
      }
      catch
      {
        num1 = 0M;
      }
      Decimal num2;
      try
      {
        num2 = Convert.ToDecimal(para_increate);
      }
      catch
      {
        num2 = 0M;
      }
      Decimal num3 = num1 + num2;
      return !(num3 > Convert.ToDecimal((int) num3)) ? num3.ToString("F00") : num3.ToString("F02");
    }

    private string Subtract_Rate(string para_Org, string para_decrease)
    {
      Decimal num1;
      try
      {
        num1 = Convert.ToDecimal(para_Org);
      }
      catch
      {
        num1 = 0M;
      }
      Decimal num2;
      try
      {
        num2 = Convert.ToDecimal(para_decrease);
      }
      catch
      {
        num2 = 0M;
      }
      string str;
      if (num2 <= num1)
      {
        Decimal num3 = num1 - num2;
        str = !(num3 > Convert.ToDecimal((int) num3)) ? num3.ToString("F00") : num3.ToString("F02");
      }
      else
      {
        int num4 = (int) MessageBox.Show("Can not Subtract!", "ALARM");
        str = para_Org;
      }
      return str;
    }

    private void cmdDPlus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtDRate.Text = this.Add_Rate(this.txtDRate.Text, this.txtDRateChange.Text);
    }

    private void cmdDMinus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtDRate.Text = this.Subtract_Rate(this.txtDRate.Text, this.txtDRateChange.Text);
    }

    private void cmdWPlus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtWRate.Text = this.Add_Rate(this.txtWRate.Text, this.txtWRateChange.Text);
    }

    private void cmdWMinus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtWRate.Text = this.Subtract_Rate(this.txtWRate.Text, this.txtWRateChange.Text);
    }

    private void cmdMPlus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtMRate.Text = this.Add_Rate(this.txtMRate.Text, this.txtMRateChange.Text);
    }

    private void cmdMMinus_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtMRate.Text = this.Subtract_Rate(this.txtMRate.Text, this.txtMRateChange.Text);
    }

    private void cmdDPlus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtDRate2.Text = this.Add_Rate(this.txtDRate2.Text, this.txtDRateChange2.Text);
    }

    private void cmdDMinus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtDRate2.Text = this.Subtract_Rate(this.txtDRate2.Text, this.txtDRateChange2.Text);
    }

    private void cmdWPlus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtWRate2.Text = this.Add_Rate(this.txtWRate2.Text, this.txtWRateChange2.Text);
    }

    private void cmdWMinus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtWRate2.Text = this.Subtract_Rate(this.txtWRate2.Text, this.txtWRateChange2.Text);
    }

    private void cmdMPlus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtMRate2.Text = this.Add_Rate(this.txtMRate2.Text, this.txtMRateChange2.Text);
    }

    private void cmdMMinus2_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      this.txtMRate2.Text = this.Subtract_Rate(this.txtMRate2.Text, this.txtMRateChange2.Text);
    }

    private void cmdPrevious_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      if (this.Browse_Room_SystemDataSet.Room.Rows.Count <= 0)
      {
        int num1 = (int) MessageBox.Show("No Recrod Found!", "ALARM!");
      }
      else if (this.selected_rowindex <= 0)
      {
        int num2 = (int) MessageBox.Show("No Previous Record!");
      }
      else
      {
        --this.selected_rowindex;
        this.Get_N_Set_SelectedRowData(this.selected_rowindex);
      }
    }

    private void cmdNext_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      if (this.Browse_Room_SystemDataSet.Room.Rows.Count <= 0)
      {
        int num1 = (int) MessageBox.Show("No Recrod Found!", "ALARM!");
      }
      else if (this.selected_rowindex == this.Browse_Room_SystemDataSet.Room.Rows.Count - 1)
      {
        int num2 = (int) MessageBox.Show("No Next Record!");
      }
      else
      {
        ++this.selected_rowindex;
        this.Get_N_Set_SelectedRowData(this.selected_rowindex);
      }
    }

    private void cmdLast_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      if (this.Browse_Room_SystemDataSet.Room.Rows.Count <= 0)
      {
        int num1 = (int) MessageBox.Show("No Recrod Found!", "ALARM!");
      }
      else if (this.selected_rowindex == this.Browse_Room_SystemDataSet.Room.Rows.Count - 1)
      {
        int num2 = (int) MessageBox.Show("Already at end of records!");
      }
      else
      {
        this.selected_rowindex = this.Browse_Room_SystemDataSet.Room.Rows.Count - 1;
        this.Get_N_Set_SelectedRowData(this.selected_rowindex);
      }
    }

    private void cmdFirst_Click(object sender, EventArgs e)
    {
      Console.Beep(600, 300);
      if (this.Browse_Room_SystemDataSet.Room.Rows.Count <= 0)
      {
        int num1 = (int) MessageBox.Show("No Recrod Found!", "ALARM!");
      }
      else if (this.selected_rowindex <= 0)
      {
        int num2 = (int) MessageBox.Show("Already at beginning of records!");
      }
      else
      {
        this.selected_rowindex = 0;
        this.Get_N_Set_SelectedRowData(this.selected_rowindex);
      }
    }

    private void Disable_Controls()
    {
      this.cmdAdd.Enabled = false;
      this.cmdPrevious.Enabled = false;
      this.cmdFirst.Enabled = false;
      this.cmdNext.Enabled = false;
      this.cmdLast.Enabled = false;
      this.cmdDMinus.Enabled = false;
      this.cmdDMinus2.Enabled = false;
      this.cmdDPlus.Enabled = false;
      this.cmdDPlus2.Enabled = false;
      this.cmdWMinus.Enabled = false;
      this.cmdWMinus2.Enabled = false;
      this.cmdWPlus.Enabled = false;
      this.cmdWPlus2.Enabled = false;
      this.cmdMMinus.Enabled = false;
      this.cmdMMinus2.Enabled = false;
      this.cmdMPlus.Enabled = false;
      this.cmdMPlus2.Enabled = false;
    }

    private void Enable_Controls()
    {
      this.cmdAdd.Enabled = true;
      this.cmdPrevious.Enabled = true;
      this.cmdFirst.Enabled = true;
      this.cmdNext.Enabled = true;
      this.cmdLast.Enabled = true;
      this.cmdDMinus.Enabled = true;
      this.cmdDMinus2.Enabled = true;
      this.cmdDPlus.Enabled = true;
      this.cmdDPlus2.Enabled = true;
      this.cmdWMinus.Enabled = true;
      this.cmdWMinus2.Enabled = true;
      this.cmdWPlus.Enabled = true;
      this.cmdWPlus2.Enabled = true;
      this.cmdMMinus.Enabled = true;
      this.cmdMMinus2.Enabled = true;
      this.cmdMPlus.Enabled = true;
      this.cmdMPlus2.Enabled = true;
    }

    private void Make_Clear()
    {
      this.txtRmNo.Text = "";
      this.txtDRate.Text = "";
      this.txtDRate2.Text = "";
      this.txtDRateChange.Text = "";
      this.txtDRateChange2.Text = "";
      this.txtWRate.Text = "";
      this.txtWRate2.Text = "";
      this.txtWRateChange.Text = "";
      this.txtWRateChange2.Text = "";
      this.txtMRate.Text = "";
      this.txtMRate2.Text = "";
      this.txtMRateChange.Text = "";
      this.txtMRateChange2.Text = "";
      this.Disable_Controls();
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
      this.Make_Clear();
      this.cmdRmNoBrowse.Focus();
      this.cmdRmNoBrowse.Select();
    }

    private bool RC_Room_Update(string para_RoomNo)
    {
      bool flag = false;
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          row.RoomNo = para_RoomNo;
          row.RoomID = para_RoomNo.Substring(3, 2);
          byte roomTypeNum = this.db.Get_Room_Type_Num((string) this.cboRmType.SelectedItem);
          row.RoomType = roomTypeNum;
          row.FloorNo = para_RoomNo.Substring(1, 2);
          row.BuildingNo = this.cboBuildingNo.Text;
          row.DailyRate = Convert.ToDecimal(this.txtDRate.Text);
          row.WeeklyRate = Convert.ToDecimal(this.txtWRate.Text);
          row.MonthlyRate = Convert.ToDecimal(this.txtMRate.Text);
          if (((string) this.cboRmType.SelectedItem).ToUpper().Contains("STUDIO") || ((string) this.cboRmType.SelectedItem).ToUpper().Contains("TWIN"))
          {
            row.DailyRate2 = Convert.ToDecimal(this.txtDRate2.Text);
            row.WeeklyRate2 = Convert.ToDecimal(this.txtWRate2.Text);
            row.MonthlyRate2 = Convert.ToDecimal(this.txtMRate2.Text);
          }
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag = true;
        }
      }
      if (flag)
      {
        if (this.db.system_DB.roomTableAdapter.Update(this.db.system_DB.systemDataSet.Room) > 0)
          return true;
        int num = (int) MessageBox.Show("***Record Not Updated***!", "ALARM");
        return false;
      }
      int num1 = (int) MessageBox.Show("***Record Not Saved***");
      return false;
    }

    private bool UpdateRoomStatus(string para_BuildingNo, string para_RoomNo)
    {
      bool flag1 = false;
      bool flag2 = false;
      string str;
      if ((str = para_BuildingNo) != null)
      {
        int num = str == "1" ? 1 : 0;
      }
      this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_RoomNo)
        {
          row.RoomNo = para_RoomNo;
          byte roomTypeNum = this.db.Get_Room_Type_Num((string) this.cboRmType.SelectedItem);
          row.RoomType = roomTypeNum;
          row.StartDate = DateTime.Now.Date;
          row.EndDate = DateTime.Now.Date;
          row.Status = (byte) 0;
          row.Description = "Vacant";
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag1 = true;
          break;
        }
      }
      if (flag1)
      {
        if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
        {
          this.db.Update_RoomStausXX_inSystemDB((string) this.cboBuildingNo.SelectedItem);
          flag2 = true;
        }
      }
      else
      {
        BuildingDB1DataSet.RoomStatusRow row = this.db.building_DB1.buildingDB1DataSet.RoomStatus.NewRoomStatusRow();
        row.RoomNo = para_RoomNo;
        byte roomTypeNum = this.db.Get_Room_Type_Num((string) this.cboRmType.SelectedItem);
        row.RoomType = roomTypeNum;
        row.StartDate = DateTime.Now.Date;
        row.EndDate = DateTime.Now.Date;
        row.Status = (byte) 0;
        row.Description = "Vacant";
        row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
        row.Update = false;
        this.db.building_DB1.buildingDB1DataSet.RoomStatus.AddRoomStatusRow(row);
        if (this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) > 0)
        {
          this.db.Update_RoomStausXX_inSystemDB((string) this.cboBuildingNo.SelectedItem);
          flag2 = true;
        }
      }
      return flag2;
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Overwrite Old Data", "COMFIRMATION !", MessageBoxButtons.YesNo) != DialogResult.Yes || !this.RC_Room_Update(this.txtRmNo.Text) || !this.UpdateRoomStatus((string) this.cboBuildingNo.SelectedItem, this.txtRmNo.Text))
        return;
      int num = (int) MessageBox.Show("Save Room No." + this.txtRmNo.Text + " Successfully!");
    }

    private void txtRmNo_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Make_Clear();
      this.cmdRmNoBrowse.Focus();
      this.cmdRmNoBrowse.Select();
    }
  }
}
