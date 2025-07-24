// Decompiled with JetBrains decompiler
// Type: AMS.Form_BankingDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_BankingDMS : Form
  {
    private DB db;
    private string sCodeDescription = "";
    private IContainer components;
    public TextBox txtChequeNo;
    public TextBox txtAmount;
    public Label Label4;
    public Label lblMessage;
    public Label Label3;
    public Label lblChequeNo;
    public Label Label2;
    public Label Label1;
    public ToolTip ToolTip1;
    public Button cmdClear;
    public ComboBox cboBuildingNo;
    public Button cmdIssue;
    public Button cmdReturn;
    public ComboBox cboDescription;
    public MaskedTextBox mskTime;
    public Label lbInTime;
    public Label Label16;
    private DateTimePicker dateTimePicker_mskDate;

    public Form_BankingDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_BankingDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_BankingDMS_Load(object sender, EventArgs e)
    {
      this.dateTimePicker_mskDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskDate.CustomFormat = "yyyy-MM-dd";
      this.mskTime.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
      if (this.cboDescription.Items.Count > 0)
        this.cboDescription.SelectedIndex = 0;
      this.CheckBuilding();
    }

    private void cboBuildingNo_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cboDescription_Enter(object sender, EventArgs e)
    {
      this.lblMessage.Text = "Select Banking Information Descripton !";
    }

    private void cboDescription_Leave(object sender, EventArgs e) => this.lblMessage.Text = "";

    private void CheckBuilding()
    {
      this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel != "0")
        {
          if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
            this.cboBuildingNo.Items.Add((object) row.BuildingNo);
        }
        else
          this.cboBuildingNo.Items.Add((object) row.BuildingNo);
      }
      if (this.cboBuildingNo.Items.Count <= 0)
        return;
      this.cboBuildingNo.SelectedIndex = this.cboBuildingNo.Items.IndexOf((object) Global_Data.sBldNo);
    }

    private void cmdIssue_Click(object sender, EventArgs e)
    {
      try
      {
        this.db.bankingDB.bankingTableAdapter.Fill(this.db.bankingDB.bankingDBDataSet.Banking);
      }
      catch
      {
        int num = (int) MessageBox.Show("Banking Data Opening fail.");
        return;
      }
      if (((string) this.cboDescription.SelectedItem).Contains("Online"))
        this.sCodeDescription = "Online";
      if (((string) this.cboDescription.SelectedItem).Contains("Cash"))
        this.sCodeDescription = "Cash";
      else if (((string) this.cboDescription.SelectedItem).Contains("Management Fee"))
        this.sCodeDescription = "MngFee";
      else if (((string) this.cboDescription.SelectedItem).Contains("Other Expenses"))
        this.sCodeDescription = "OtherFee";
      else if (((string) this.cboDescription.SelectedItem).Contains("Bank"))
        this.sCodeDescription = "Bank";
      BankingDBDataSet.BankingRow row = this.db.bankingDB.bankingDBDataSet.Banking.NewBankingRow();
      row.CodeDesc = this.sCodeDescription;
      row.ChequeNo = this.txtChequeNo.Text;
      row.Amount = Convert.ToDecimal(this.txtAmount.Text);
      row.Date = this.dateTimePicker_mskDate.Value.Date;
      row.Time = this.mskTime.Text;
      row.Operator = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.db.bankingDB.bankingDBDataSet.Banking.AddBankingRow(row);
      if (this.db.bankingDB.bankingTableAdapter.Update(this.db.bankingDB.bankingDBDataSet.Banking) <= 0)
        return;
      this.lblMessage.Text = "Data Updated..Ready For Next Record.";
      int num1 = (int) MessageBox.Show("Data Updated!");
      this.Set_To_Default();
    }

    private void cboDescription_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lblMessage.Text = "Select Banking Information Descripton !";
      if (((string) this.cboDescription.SelectedItem).Contains("Online"))
      {
        this.txtChequeNo.Visible = true;
        this.lblChequeNo.Visible = true;
        this.txtChequeNo.Text = "";
        this.cmdIssue.Enabled = false;
      }
      else
      {
        this.txtChequeNo.Visible = false;
        this.lblChequeNo.Visible = false;
        this.txtChequeNo.Text = "";
        this.cmdIssue.Enabled = false;
      }
      this.txtAmount.Text = "";
    }

    private void txtChequeNo_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Filter_Keys_N_Dot(e, this.txtAmount.Text);
    }

    private void Filter_Keys_N_Dot(KeyPressEventArgs e, string para_string)
    {
      if (para_string.Contains(".") && e.KeyChar == '.')
        e.Handled = true;
      else if (para_string.Contains("-") && e.KeyChar == '-')
        e.Handled = true;
      else if (e.KeyChar == '-')
        e.Handled = false;
      else if (e.KeyChar == '.')
        e.Handled = false;
      else if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void Set_To_Default()
    {
      this.lblMessage.Text = "";
      this.cboDescription.SelectedIndex = 0;
      this.txtChequeNo.Text = "";
      this.txtAmount.Text = "";
      this.dateTimePicker_mskDate.Value = DateTime.Now.Date;
      this.mskTime.Text = DateTime.Now.ToLongTimeString();
      this.cmdIssue.Enabled = false;
      if (((string) this.cboDescription.SelectedItem).Contains("Online"))
        this.lblMessage.Text = "Select Banking Information Descripton !";
      else
        this.lblMessage.Text = "";
    }

    private void cmdClear_Click(object sender, EventArgs e) => this.Set_To_Default();

    private void cboDescription_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void cboDescription_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void Form_BankingDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Set_To_Default();
    }

    private void txtAmount_KeyUp(object sender, KeyEventArgs e)
    {
      if (this.txtAmount.Text.Length > 0)
        this.cmdIssue.Enabled = true;
      else
        this.cmdIssue.Enabled = false;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_BankingDMS));
      this.txtChequeNo = new TextBox();
      this.txtAmount = new TextBox();
      this.Label4 = new Label();
      this.lblMessage = new Label();
      this.Label3 = new Label();
      this.lblChequeNo = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdClear = new Button();
      this.cboBuildingNo = new ComboBox();
      this.cmdIssue = new Button();
      this.cmdReturn = new Button();
      this.cboDescription = new ComboBox();
      this.mskTime = new MaskedTextBox();
      this.lbInTime = new Label();
      this.Label16 = new Label();
      this.dateTimePicker_mskDate = new DateTimePicker();
      this.SuspendLayout();
      this.txtChequeNo.AcceptsReturn = true;
      this.txtChequeNo.BackColor = SystemColors.Window;
      this.txtChequeNo.Cursor = Cursors.IBeam;
      this.txtChequeNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtChequeNo.ForeColor = SystemColors.WindowText;
      this.txtChequeNo.Location = new Point(324, 121);
      this.txtChequeNo.MaxLength = 30;
      this.txtChequeNo.Name = "txtChequeNo";
      this.txtChequeNo.RightToLeft = RightToLeft.No;
      this.txtChequeNo.Size = new Size(305, 20);
      this.txtChequeNo.TabIndex = 19;
      this.txtChequeNo.KeyPress += new KeyPressEventHandler(this.txtChequeNo_KeyPress);
      this.txtAmount.AcceptsReturn = true;
      this.txtAmount.BackColor = SystemColors.Window;
      this.txtAmount.Cursor = Cursors.IBeam;
      this.txtAmount.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmount.ForeColor = SystemColors.WindowText;
      this.txtAmount.Location = new Point(188, 169);
      this.txtAmount.MaxLength = 0;
      this.txtAmount.Name = "txtAmount";
      this.txtAmount.RightToLeft = RightToLeft.No;
      this.txtAmount.Size = new Size(89, 20);
      this.txtAmount.TabIndex = 20;
      this.txtAmount.KeyUp += new KeyEventHandler(this.txtAmount_KeyUp);
      this.txtAmount.KeyPress += new KeyPressEventHandler(this.txtAmount_KeyPress);
      this.Label4.BackColor = Color.Cyan;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Red;
      this.Label4.Location = new Point(92, 81);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(81, 25);
      this.Label4.TabIndex = 33;
      this.Label4.Text = "Building ";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.lblMessage.BackColor = SystemColors.Control;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(12, 289);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(649, 33);
      this.lblMessage.TabIndex = 32;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.Label3.BackColor = SystemColors.Control;
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 13.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(12, 9);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(649, 49);
      this.Label3.TabIndex = 31;
      this.Label3.Text = "BANKING INFORMATION ";
      this.Label3.TextAlign = ContentAlignment.TopCenter;
      this.lblChequeNo.BackColor = Color.Cyan;
      this.lblChequeNo.Cursor = Cursors.Default;
      this.lblChequeNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblChequeNo.ForeColor = Color.Red;
      this.lblChequeNo.Location = new Point(324, 89);
      this.lblChequeNo.Name = "lblChequeNo";
      this.lblChequeNo.RightToLeft = RightToLeft.No;
      this.lblChequeNo.Size = new Size(112, 25);
      this.lblChequeNo.TabIndex = 30;
      this.lblChequeNo.Text = "Online Details";
      this.lblChequeNo.TextAlign = ContentAlignment.TopCenter;
      this.Label2.BackColor = Color.Cyan;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(100, 121);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(73, 25);
      this.Label2.TabIndex = 29;
      this.Label2.Text = "Description";
      this.Label2.TextAlign = ContentAlignment.TopRight;
      this.Label1.BackColor = Color.Cyan;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Red;
      this.Label1.Location = new Point(100, 169);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(73, 25);
      this.Label1.TabIndex = 28;
      this.Label1.Text = "Amount ";
      this.Label1.TextAlign = ContentAlignment.TopRight;
      this.cmdClear.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Location = new Point(268, 345);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(113, 40);
      this.cmdClear.TabIndex = 24;
      this.cmdClear.Text = "C&lear ";
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "Comfirm to issue card.");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.cboBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Enabled = false;
      this.cboBuildingNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(188, 81);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 21);
      this.cboBuildingNo.TabIndex = 17;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building No.");
      this.cboBuildingNo.SelectedIndexChanged += new EventHandler(this.cboBuildingNo_SelectedIndexChanged);
      this.cmdIssue.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdIssue.Cursor = Cursors.Default;
      this.cmdIssue.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdIssue.ForeColor = SystemColors.ControlText;
      this.cmdIssue.Location = new Point(124, 345);
      this.cmdIssue.Name = "cmdIssue";
      this.cmdIssue.RightToLeft = RightToLeft.No;
      this.cmdIssue.Size = new Size(113, 40);
      this.cmdIssue.TabIndex = 23;
      this.cmdIssue.Text = "&Confirm";
      this.ToolTip1.SetToolTip((Control) this.cmdIssue, "Comfirm to issue card.");
      this.cmdIssue.UseVisualStyleBackColor = false;
      this.cmdIssue.Click += new EventHandler(this.cmdIssue_Click);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(412, 345);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(113, 40);
      this.cmdReturn.TabIndex = 25;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Admin Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cboDescription.BackColor = SystemColors.Window;
      this.cboDescription.Cursor = Cursors.Default;
      this.cboDescription.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboDescription.ForeColor = SystemColors.WindowText;
      this.cboDescription.Items.AddRange(new object[4]
      {
        (object) "Online",
        (object) "Cash",
        (object) "Management Fee",
        (object) "Other Expenses"
      });
      this.cboDescription.Location = new Point(188, 121);
      this.cboDescription.Name = "cboDescription";
      this.cboDescription.RightToLeft = RightToLeft.No;
      this.cboDescription.Size = new Size(129, 22);
      this.cboDescription.TabIndex = 18;
      this.ToolTip1.SetToolTip((Control) this.cboDescription, "Select Building");
      this.cboDescription.SelectedIndexChanged += new EventHandler(this.cboDescription_SelectedIndexChanged);
      this.cboDescription.Leave += new EventHandler(this.cboDescription_Leave);
      this.cboDescription.Enter += new EventHandler(this.cboDescription_Enter);
      this.cboDescription.KeyPress += new KeyPressEventHandler(this.cboDescription_KeyPress);
      this.cboDescription.KeyDown += new KeyEventHandler(this.cboDescription_KeyDown);
      this.mskTime.AllowPromptAsInput = false;
      this.mskTime.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskTime.ForeColor = Color.Blue;
      this.mskTime.Location = new Point(188, 241);
      this.mskTime.Mask = "##:##:##";
      this.mskTime.Name = "mskTime";
      this.mskTime.Size = new Size(89, 20);
      this.mskTime.TabIndex = 22;
      this.ToolTip1.SetToolTip((Control) this.mskTime, "Valid Start Time");
      this.lbInTime.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lbInTime.Cursor = Cursors.Default;
      this.lbInTime.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbInTime.ForeColor = SystemColors.ControlText;
      this.lbInTime.Location = new Point(76, 242);
      this.lbInTime.Name = "lbInTime";
      this.lbInTime.RightToLeft = RightToLeft.No;
      this.lbInTime.Size = new Size(97, 24);
      this.lbInTime.TabIndex = 27;
      this.lbInTime.Text = "Time ";
      this.lbInTime.TextAlign = ContentAlignment.TopRight;
      this.Label16.BackColor = Color.Cyan;
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Red;
      this.Label16.Location = new Point(100, 209);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(73, 25);
      this.Label16.TabIndex = 26;
      this.Label16.Text = "Date";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.dateTimePicker_mskDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_mskDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_mskDate.Location = new Point(188, 209);
      this.dateTimePicker_mskDate.Name = "dateTimePicker_mskDate";
      this.dateTimePicker_mskDate.Size = new Size(98, 20);
      this.dateTimePicker_mskDate.TabIndex = 181;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(799, 405);
      this.Controls.Add((Control) this.dateTimePicker_mskDate);
      this.Controls.Add((Control) this.txtChequeNo);
      this.Controls.Add((Control) this.txtAmount);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lblChequeNo);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.cboBuildingNo);
      this.Controls.Add((Control) this.cmdIssue);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cboDescription);
      this.Controls.Add((Control) this.mskTime);
      this.Controls.Add((Control) this.lbInTime);
      this.Controls.Add((Control) this.Label16);
      this.Name = "Form_BankingDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_BankingDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_BankingDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_BankingDMS_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
