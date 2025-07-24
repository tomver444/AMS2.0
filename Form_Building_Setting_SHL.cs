// Decompiled with JetBrains decompiler
// Type: AMS.Form_Building_Setting_SHL
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
  public class Form_Building_Setting_SHL : Form
  {
    private IContainer components;
    public GroupBox Frame1;
    public Button cmdExit;
    public TextBox txtBuildingName;
    public Button cmdSet;
    public ComboBox cboBuildingNo;
    public Label Label4;
    public Label lblBuilding;
    public Label Label5;
    public ToolTip ToolTip1;
    public Label label1;
    public ComboBox cboBuildingType;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.Frame1 = new GroupBox();
      this.txtBuildingName = new TextBox();
      this.cboBuildingNo = new ComboBox();
      this.Label4 = new Label();
      this.lblBuilding = new Label();
      this.cmdExit = new Button();
      this.cmdSet = new Button();
      this.Label5 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.label1 = new Label();
      this.cboBuildingType = new ComboBox();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this.Frame1.BackColor = Color.Pink;
      this.Frame1.Controls.Add((Control) this.cboBuildingType);
      this.Frame1.Controls.Add((Control) this.label1);
      this.Frame1.Controls.Add((Control) this.txtBuildingName);
      this.Frame1.Controls.Add((Control) this.cboBuildingNo);
      this.Frame1.Controls.Add((Control) this.Label4);
      this.Frame1.Controls.Add((Control) this.lblBuilding);
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(26, 96);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(523, 223);
      this.Frame1.TabIndex = 51;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "DEFINE BUILIDING";
      this.txtBuildingName.AcceptsReturn = true;
      this.txtBuildingName.BackColor = SystemColors.Window;
      this.txtBuildingName.Cursor = Cursors.IBeam;
      this.txtBuildingName.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBuildingName.ForeColor = Color.Red;
      this.txtBuildingName.Location = new Point(192, 104);
      this.txtBuildingName.MaxLength = 20;
      this.txtBuildingName.Name = "txtBuildingName";
      this.txtBuildingName.RightToLeft = RightToLeft.No;
      this.txtBuildingName.Size = new Size(313, 22);
      this.txtBuildingName.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.txtBuildingName, "Enter Building Name");
      this.cboBuildingNo.BackColor = SystemColors.Window;
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = SystemColors.WindowText;
      this.cboBuildingNo.FormatString = "N2";
      this.cboBuildingNo.FormattingEnabled = true;
      this.cboBuildingNo.Location = new Point(192, 50);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(57, 24);
      this.cboBuildingNo.TabIndex = 0;
      this.cboBuildingNo.Tag = (object) "";
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building No");
      this.Label4.BackColor = Color.Pink;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Blue;
      this.Label4.Location = new Point(16, 104);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(161, 25);
      this.Label4.TabIndex = 44;
      this.Label4.Text = "BUILDING NAME";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.lblBuilding.BackColor = Color.Pink;
      this.lblBuilding.Cursor = Cursors.Default;
      this.lblBuilding.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblBuilding.ForeColor = Color.Blue;
      this.lblBuilding.Location = new Point(40, 50);
      this.lblBuilding.Name = "lblBuilding";
      this.lblBuilding.RightToLeft = RightToLeft.No;
      this.lblBuilding.Size = new Size(137, 25);
      this.lblBuilding.TabIndex = 40;
      this.lblBuilding.Text = "BUILDING";
      this.lblBuilding.TextAlign = ContentAlignment.TopRight;
      this.cmdExit.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdExit.Cursor = Cursors.Default;
      this.cmdExit.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdExit.ForeColor = SystemColors.ControlText;
      this.cmdExit.Location = new Point(418, 339);
      this.cmdExit.Name = "cmdExit";
      this.cmdExit.RightToLeft = RightToLeft.No;
      this.cmdExit.Size = new Size(113, 47);
      this.cmdExit.TabIndex = 32;
      this.cmdExit.Text = "EXIT";
      this.cmdExit.UseVisualStyleBackColor = false;
      this.cmdExit.Click += new EventHandler(this.cmdExit_Click);
      this.cmdSet.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cmdSet.Cursor = Cursors.Default;
      this.cmdSet.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdSet.ForeColor = SystemColors.ControlText;
      this.cmdSet.Location = new Point(207, 339);
      this.cmdSet.Name = "cmdSet";
      this.cmdSet.RightToLeft = RightToLeft.No;
      this.cmdSet.Size = new Size(113, 47);
      this.cmdSet.TabIndex = 30;
      this.cmdSet.Text = "SET";
      this.cmdSet.UseVisualStyleBackColor = false;
      this.cmdSet.Click += new EventHandler(this.cmdSet_Click);
      this.Label5.BackColor = Color.Thistle;
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(22, 26);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(520, 41);
      this.Label5.TabIndex = 52;
      this.Label5.Text = "BUILDING SETTING";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.label1.BackColor = Color.Pink;
      this.label1.Cursor = Cursors.Default;
      this.label1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Blue;
      this.label1.Location = new Point(16, 160);
      this.label1.Name = "label1";
      this.label1.RightToLeft = RightToLeft.No;
      this.label1.Size = new Size(161, 25);
      this.label1.TabIndex = 46;
      this.label1.Text = "BUILDING TYPE";
      this.label1.TextAlign = ContentAlignment.TopRight;
      this.cboBuildingType.BackColor = SystemColors.Window;
      this.cboBuildingType.Cursor = Cursors.Default;
      this.cboBuildingType.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingType.ForeColor = SystemColors.WindowText;
      this.cboBuildingType.FormatString = "N2";
      this.cboBuildingType.FormattingEnabled = true;
      this.cboBuildingType.Location = new Point(192, 157);
      this.cboBuildingType.Name = "cboBuildingType";
      this.cboBuildingType.RightToLeft = RightToLeft.No;
      this.cboBuildingType.Size = new Size(313, 24);
      this.cboBuildingType.TabIndex = 47;
      this.cboBuildingType.Tag = (object) "";
      this.ToolTip1.SetToolTip((Control) this.cboBuildingType, "Select Building No");
      this.cboBuildingType.KeyPress += new KeyPressEventHandler(this.cboBuildingType_KeyPress);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(575, 398);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.cmdExit);
      this.Controls.Add((Control) this.cmdSet);
      this.Controls.Add((Control) this.Frame1);
      this.Name = "Form_Building_Setting_SHL";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_Building_Setting_SHL_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
    }

    public Form_Building_Setting_SHL() => this.InitializeComponent();

    private void Form_Building_Setting_SHL_Load(object sender, EventArgs e)
    {
      for (int index = 1; index <= 6; ++index)
        this.cboBuildingNo.Items.Add((object) index.ToString());
      this.cboBuildingNo.SelectedIndex = 0;
      this.cboBuildingNo.Focus();
      this.cboBuildingNo.Select();
      this.cboBuildingType.Items.Add((object) "Normal");
      this.cboBuildingType.SelectedIndex = 0;
    }

    private void cmdExit_Click(object sender, EventArgs e) => Application.Exit();

    private void cmdSet_Click(object sender, EventArgs e)
    {
      if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Create_Building((string) this.cboBuildingNo.SelectedItem, this.txtBuildingName.Text, (string) this.cboBuildingType.SelectedItem))
        Application.Exit();
      try
      {
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.Set_System_Setting((string) this.cboBuildingNo.SelectedItem);
      }
      catch
      {
      }
      this.Close();
    }

    private void cboBuildingType_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
  }
}
