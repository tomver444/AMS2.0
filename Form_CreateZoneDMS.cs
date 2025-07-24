// Decompiled with JetBrains decompiler
// Type: AMS.Form_CreateZoneDMS
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
  public class Form_CreateZoneDMS : Form
  {
    private IContainer components;
    public Label Data1;
    public ComboBox cboBuildingNo;
    public ToolTip ToolTip1;
    public Button cmdClear;
    public Button CmdPrint;
    public Button cmdReturn;
    public TextBox txtZoneNo;
    public Button cmdDelete;
    public Button cmdAddZone;
    public TextBox txtZoneName;
    public Label lblMessage;
    public Label Label16;
    public Label Label3;
    public Label lblZoneNo;
    public Label Label2;
    public Label Label1;

    public Form_CreateZoneDMS() => this.InitializeComponent();

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
    }

    private void Form_CreateZoneDMS_FormClosing(object sender, FormClosingEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_CreateZoneDMS));
      this.Data1 = new Label();
      this.cboBuildingNo = new ComboBox();
      this.cmdClear = new Button();
      this.CmdPrint = new Button();
      this.cmdReturn = new Button();
      this.txtZoneNo = new TextBox();
      this.cmdDelete = new Button();
      this.cmdAddZone = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.txtZoneName = new TextBox();
      this.lblMessage = new Label();
      this.Label16 = new Label();
      this.Label3 = new Label();
      this.lblZoneNo = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.SuspendLayout();
      this.Data1.BackColor = Color.Red;
      this.Data1.BorderStyle = BorderStyle.FixedSingle;
      this.Data1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Data1.ForeColor = Color.Black;
      this.Data1.Location = new Point(365, 372);
      this.Data1.Margin = new Padding(4, 0, 4, 0);
      this.Data1.Name = "Data1";
      this.Data1.Size = new Size(111, 30);
      this.Data1.TabIndex = 16;
      this.Data1.Text = "Data1";
      this.Data1.Visible = false;
      this.cboBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(163, 155);
      this.cboBuildingNo.Margin = new Padding(4, 4, 4, 4);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(64, 30);
      this.cboBuildingNo.TabIndex = 27;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building");
      this.cmdClear.BackColor = Color.Cyan;
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Location = new Point(141, 441);
      this.cmdClear.Margin = new Padding(4, 4, 4, 4);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(140, 48);
      this.cmdClear.TabIndex = 26;
      this.cmdClear.Text = "&Clear Screen";
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "Clear Screen");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.CmdPrint.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.CmdPrint.Cursor = Cursors.Default;
      this.CmdPrint.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdPrint.ForeColor = SystemColors.ControlText;
      this.CmdPrint.Image = (Image) componentResourceManager.GetObject("CmdPrint.Image");
      this.CmdPrint.Location = new Point(141, 500);
      this.CmdPrint.Margin = new Padding(4, 4, 4, 4);
      this.CmdPrint.Name = "CmdPrint";
      this.CmdPrint.RightToLeft = RightToLeft.No;
      this.CmdPrint.Size = new Size(140, 48);
      this.CmdPrint.TabIndex = 25;
      this.CmdPrint.Text = "&Print";
      this.CmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdPrint, "To Print");
      this.CmdPrint.UseVisualStyleBackColor = false;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(141, 559);
      this.cmdReturn.Margin = new Padding(4, 4, 4, 4);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(140, 48);
      this.cmdReturn.TabIndex = 20;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Swith to Main Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtZoneNo.AcceptsReturn = true;
      this.txtZoneNo.BackColor = SystemColors.Window;
      this.txtZoneNo.Cursor = Cursors.IBeam;
      this.txtZoneNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtZoneNo.ForeColor = SystemColors.WindowText;
      this.txtZoneNo.Location = new Point(163, 204);
      this.txtZoneNo.Margin = new Padding(4, 4, 4, 4);
      this.txtZoneNo.MaxLength = 20;
      this.txtZoneNo.Name = "txtZoneNo";
      this.txtZoneNo.RightToLeft = RightToLeft.No;
      this.txtZoneNo.Size = new Size(53, 26);
      this.txtZoneNo.TabIndex = 15;
      this.ToolTip1.SetToolTip((Control) this.txtZoneNo, "Enter Zone No.");
      this.cmdDelete.BackColor = Color.FromArgb(0, 192, 0);
      this.cmdDelete.Cursor = Cursors.Default;
      this.cmdDelete.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDelete.ForeColor = SystemColors.ControlText;
      this.cmdDelete.Location = new Point(141, 382);
      this.cmdDelete.Margin = new Padding(4, 4, 4, 4);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.RightToLeft = RightToLeft.No;
      this.cmdDelete.Size = new Size(140, 48);
      this.cmdDelete.TabIndex = 19;
      this.cmdDelete.Text = "&Delete Zone";
      this.ToolTip1.SetToolTip((Control) this.cmdDelete, "To Delete Selected Zone");
      this.cmdDelete.UseVisualStyleBackColor = false;
      this.cmdAddZone.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdAddZone.Cursor = Cursors.Default;
      this.cmdAddZone.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdAddZone.ForeColor = SystemColors.ControlText;
      this.cmdAddZone.Location = new Point(141, 322);
      this.cmdAddZone.Margin = new Padding(4, 4, 4, 4);
      this.cmdAddZone.Name = "cmdAddZone";
      this.cmdAddZone.RightToLeft = RightToLeft.No;
      this.cmdAddZone.Size = new Size(140, 48);
      this.cmdAddZone.TabIndex = 18;
      this.cmdAddZone.Text = "&Add Zone";
      this.ToolTip1.SetToolTip((Control) this.cmdAddZone, "To Add Zone");
      this.cmdAddZone.UseVisualStyleBackColor = false;
      this.txtZoneName.AcceptsReturn = true;
      this.txtZoneName.BackColor = SystemColors.Window;
      this.txtZoneName.Cursor = Cursors.IBeam;
      this.txtZoneName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtZoneName.ForeColor = SystemColors.WindowText;
      this.txtZoneName.Location = new Point(163, 263);
      this.txtZoneName.Margin = new Padding(4, 4, 4, 4);
      this.txtZoneName.MaxLength = 20;
      this.txtZoneName.Name = "txtZoneName";
      this.txtZoneName.RightToLeft = RightToLeft.No;
      this.txtZoneName.Size = new Size(320, 23);
      this.txtZoneName.TabIndex = 17;
      this.ToolTip1.SetToolTip((Control) this.txtZoneName, "Enter Zone Name");
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(3, 618);
      this.lblMessage.Margin = new Padding(4, 0, 4, 0);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(1015, 50);
      this.lblMessage.TabIndex = 29;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label16.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Red;
      this.Label16.Location = new Point(24, 155);
      this.Label16.Margin = new Padding(4, 0, 4, 0);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(119, 31);
      this.Label16.TabIndex = 28;
      this.Label16.Text = "Building ";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(24, 263);
      this.Label3.Margin = new Padding(4, 0, 4, 0);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(119, 31);
      this.Label3.TabIndex = 24;
      this.Label3.Text = "Zone Name ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.lblZoneNo.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblZoneNo.Cursor = Cursors.Default;
      this.lblZoneNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblZoneNo.ForeColor = SystemColors.ControlText;
      this.lblZoneNo.Location = new Point(24, 204);
      this.lblZoneNo.Margin = new Padding(4, 0, 4, 0);
      this.lblZoneNo.Name = "lblZoneNo";
      this.lblZoneNo.RightToLeft = RightToLeft.No;
      this.lblZoneNo.Size = new Size(119, 31);
      this.lblZoneNo.TabIndex = 23;
      this.lblZoneNo.Text = "Zone No. ";
      this.lblZoneNo.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.FromArgb(192, 192, 0);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(3, 86);
      this.Label2.Margin = new Padding(4, 0, 4, 0);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(1047, 41);
      this.Label2.TabIndex = 22;
      this.Label2.Text = "CREATE ZONE";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.FromArgb(192, 192, 0);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(3, 7);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(1047, 60);
      this.Label1.TabIndex = 21;
      this.Label1.Text = "System Mode";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1060, 721);
      this.Controls.Add((Control) this.Data1);
      this.Controls.Add((Control) this.cboBuildingNo);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.CmdPrint);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.txtZoneNo);
      this.Controls.Add((Control) this.cmdDelete);
      this.Controls.Add((Control) this.cmdAddZone);
      this.Controls.Add((Control) this.txtZoneName);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblZoneNo);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Margin = new Padding(4, 4, 4, 4);
      this.Name = "Form_CreateZoneDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.FormClosing += new FormClosingEventHandler(this.Form_CreateZoneDMS_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
