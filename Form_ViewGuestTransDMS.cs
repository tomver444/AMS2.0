// Decompiled with JetBrains decompiler
// Type: AMS.Form_ViewGuestTransDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.TempDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_ViewGuestTransDMS : Form
  {
    private IContainer components;
    public TextBox txtChargeType;
    public TextBox txtCardNo;
    public TextBox txtGracePeriod;
    public TextBox txtDeposit;
    public TextBox txtAmountPaid;
    public TextBox txtNoOfDays;
    public Label Label1;
    public TextBox txtLastPayment;
    public MaskedTextBox mskContractStart;
    public MaskedTextBox mskContractEnd;
    public Label lblMessage;
    public Label lblFirstName;
    public Label Label2;
    public MaskedTextBox mskValidStart;
    public Label Label3;
    public Label Label4;
    public GroupBox Frame1;
    public MaskedTextBox mskValidEnd;
    public Label lblRoomType;
    public Label lblFloorNo;
    public Label lblBuildingNo;
    public Label lblRoomNo;
    public Label Label28;
    public Label Label12;
    public Label Label13;
    public Label Label14;
    public Label Label15;
    public Label Label16;
    public Label Label17;
    public Label Label18;
    public Label Label19;
    public Label Label21;
    public Label Label22;
    public Label Label23;
    public Label Label24;
    public Label Label25;
    public Label Label26;
    public Button cmdCurrent;
    public ToolTip ToolTip1;
    public Button cmdClear;
    public ComboBox cboBldNo;
    public Button cmdPrint;
    public Button cmdClientBrowser;
    public Button cmdOK;
    public Button cmdReturn;
    public TextBox txtClientID;
    public GroupBox ClientFrame;
    public Label Data1;
    public RadioButton _optBuildingCheck_0;
    public RadioButton _optBuildingCheck_1;
    public GroupBox BuildingSelectFrame;
    private TempDataSet tempDataSet;
    private BindingSource gInfoTempBindingSource;
    private GInfo_TempTableAdapter gInfo_TempTableAdapter;
    private DataGridView dataGridView_GuestInfo;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn foreNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validStartDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validEndDataGridViewTextBoxColumn;
    private DataGridView dataGridView_GTransaction_Temp;
    private BindingSource gTransactionsTempBindingSource;
    private GTransactions_TempTableAdapter gTransactions_TempTableAdapter;
    private DataGridViewTextBoxColumn transIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn lastPaymentDataGridViewTextBoxColumn;
    private DB db;
    private int selected_rowindex;
    private int selected_rowindex_2;
    private bool Temp_MDB_SaveFlag = true;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_ViewGuestTransDMS));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.txtChargeType = new TextBox();
      this.txtCardNo = new TextBox();
      this.txtGracePeriod = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtAmountPaid = new TextBox();
      this.txtNoOfDays = new TextBox();
      this.Label1 = new Label();
      this.txtLastPayment = new TextBox();
      this.mskContractStart = new MaskedTextBox();
      this.mskContractEnd = new MaskedTextBox();
      this.lblMessage = new Label();
      this.lblFirstName = new Label();
      this.Label2 = new Label();
      this.mskValidStart = new MaskedTextBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Frame1 = new GroupBox();
      this.mskValidEnd = new MaskedTextBox();
      this.lblRoomType = new Label();
      this.lblFloorNo = new Label();
      this.lblBuildingNo = new Label();
      this.lblRoomNo = new Label();
      this.Label28 = new Label();
      this.Label12 = new Label();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.Label21 = new Label();
      this.Label22 = new Label();
      this.Label23 = new Label();
      this.Label24 = new Label();
      this.Label25 = new Label();
      this.Label26 = new Label();
      this.cmdCurrent = new Button();
      this.cmdClear = new Button();
      this.cboBldNo = new ComboBox();
      this.cmdPrint = new Button();
      this.cmdClientBrowser = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdOK = new Button();
      this.cmdReturn = new Button();
      this.txtClientID = new TextBox();
      this.ClientFrame = new GroupBox();
      this.dataGridView_GuestInfo = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.foreNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.surNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.cardNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.validStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.validEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gInfoTempBindingSource = new BindingSource(this.components);
      this.tempDataSet = new TempDataSet();
      this.Data1 = new Label();
      this._optBuildingCheck_0 = new RadioButton();
      this._optBuildingCheck_1 = new RadioButton();
      this.BuildingSelectFrame = new GroupBox();
      this.gInfo_TempTableAdapter = new GInfo_TempTableAdapter();
      this.dataGridView_GTransaction_Temp = new DataGridView();
      this.transIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomNoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.lastPaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gTransactionsTempBindingSource = new BindingSource(this.components);
      this.gTransactions_TempTableAdapter = new GTransactions_TempTableAdapter();
      this.Frame1.SuspendLayout();
      this.ClientFrame.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_GuestInfo).BeginInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.BuildingSelectFrame.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_GTransaction_Temp).BeginInit();
      ((ISupportInitialize) this.gTransactionsTempBindingSource).BeginInit();
      this.SuspendLayout();
      this.txtChargeType.AcceptsReturn = true;
      this.txtChargeType.BackColor = SystemColors.Window;
      this.txtChargeType.Cursor = Cursors.IBeam;
      this.txtChargeType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtChargeType.ForeColor = Color.Red;
      this.txtChargeType.Location = new Point(328, 40);
      this.txtChargeType.MaxLength = 0;
      this.txtChargeType.Name = "txtChargeType";
      this.txtChargeType.ReadOnly = true;
      this.txtChargeType.RightToLeft = RightToLeft.No;
      this.txtChargeType.Size = new Size(81, 20);
      this.txtChargeType.TabIndex = 34;
      this.txtChargeType.TextAlign = HorizontalAlignment.Center;
      this.txtCardNo.AcceptsReturn = true;
      this.txtCardNo.BackColor = SystemColors.Window;
      this.txtCardNo.Cursor = Cursors.IBeam;
      this.txtCardNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCardNo.ForeColor = Color.Red;
      this.txtCardNo.Location = new Point(528, 40);
      this.txtCardNo.MaxLength = 0;
      this.txtCardNo.Name = "txtCardNo";
      this.txtCardNo.ReadOnly = true;
      this.txtCardNo.RightToLeft = RightToLeft.No;
      this.txtCardNo.Size = new Size(81, 20);
      this.txtCardNo.TabIndex = 32;
      this.txtCardNo.TextAlign = HorizontalAlignment.Center;
      this.txtGracePeriod.AcceptsReturn = true;
      this.txtGracePeriod.BackColor = SystemColors.Window;
      this.txtGracePeriod.Cursor = Cursors.IBeam;
      this.txtGracePeriod.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGracePeriod.ForeColor = SystemColors.WindowText;
      this.txtGracePeriod.Location = new Point(528, 72);
      this.txtGracePeriod.MaxLength = 0;
      this.txtGracePeriod.Name = "txtGracePeriod";
      this.txtGracePeriod.RightToLeft = RightToLeft.No;
      this.txtGracePeriod.Size = new Size(41, 20);
      this.txtGracePeriod.TabIndex = 11;
      this.txtGracePeriod.TextAlign = HorizontalAlignment.Center;
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = SystemColors.Window;
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = SystemColors.WindowText;
      this.txtDeposit.Location = new Point(120, 136);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(65, 20);
      this.txtDeposit.TabIndex = 10;
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.txtAmountPaid.AcceptsReturn = true;
      this.txtAmountPaid.BackColor = SystemColors.Window;
      this.txtAmountPaid.Cursor = Cursors.IBeam;
      this.txtAmountPaid.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAmountPaid.ForeColor = SystemColors.WindowText;
      this.txtAmountPaid.Location = new Point(528, 136);
      this.txtAmountPaid.MaxLength = 0;
      this.txtAmountPaid.Name = "txtAmountPaid";
      this.txtAmountPaid.RightToLeft = RightToLeft.No;
      this.txtAmountPaid.Size = new Size(81, 20);
      this.txtAmountPaid.TabIndex = 8;
      this.txtAmountPaid.TextAlign = HorizontalAlignment.Center;
      this.txtNoOfDays.AcceptsReturn = true;
      this.txtNoOfDays.BackColor = SystemColors.Window;
      this.txtNoOfDays.Cursor = Cursors.IBeam;
      this.txtNoOfDays.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNoOfDays.ForeColor = SystemColors.WindowText;
      this.txtNoOfDays.Location = new Point(120, 104);
      this.txtNoOfDays.MaxLength = 0;
      this.txtNoOfDays.Name = "txtNoOfDays";
      this.txtNoOfDays.RightToLeft = RightToLeft.No;
      this.txtNoOfDays.Size = new Size(41, 20);
      this.txtNoOfDays.TabIndex = 7;
      this.txtNoOfDays.TextAlign = HorizontalAlignment.Center;
      this.Label1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(-5, 0);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 41);
      this.Label1.TabIndex = 54;
      this.Label1.Text = "Operation Mode ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.txtLastPayment.AcceptsReturn = true;
      this.txtLastPayment.BackColor = SystemColors.Window;
      this.txtLastPayment.Cursor = Cursors.IBeam;
      this.txtLastPayment.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLastPayment.ForeColor = SystemColors.WindowText;
      this.txtLastPayment.Location = new Point(328, 136);
      this.txtLastPayment.MaxLength = 0;
      this.txtLastPayment.Name = "txtLastPayment";
      this.txtLastPayment.RightToLeft = RightToLeft.No;
      this.txtLastPayment.Size = new Size(81, 20);
      this.txtLastPayment.TabIndex = 9;
      this.txtLastPayment.TextAlign = HorizontalAlignment.Center;
      this.mskContractStart.AllowPromptAsInput = false;
      this.mskContractStart.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskContractStart.ForeColor = Color.Blue;
      this.mskContractStart.Location = new Point(120, 72);
      this.mskContractStart.Mask = "####-##-##";
      this.mskContractStart.Name = "mskContractStart";
      this.mskContractStart.Size = new Size(81, 20);
      this.mskContractStart.TabIndex = 12;
      this.mskContractEnd.AllowPromptAsInput = false;
      this.mskContractEnd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskContractEnd.ForeColor = Color.Blue;
      this.mskContractEnd.Location = new Point(328, 72);
      this.mskContractEnd.Mask = "####-##-##";
      this.mskContractEnd.Name = "mskContractEnd";
      this.mskContractEnd.Size = new Size(81, 20);
      this.mskContractEnd.TabIndex = 13;
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(-5, 512);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(785, 25);
      this.lblMessage.TabIndex = 62;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.lblFirstName.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.lblFirstName.Cursor = Cursors.Default;
      this.lblFirstName.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFirstName.ForeColor = Color.Blue;
      this.lblFirstName.Location = new Point(419, 136);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.RightToLeft = RightToLeft.No;
      this.lblFirstName.Size = new Size(281, 17);
      this.lblFirstName.TabIndex = 55;
      this.Label2.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(-5, 48);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 25);
      this.Label2.TabIndex = 53;
      this.Label2.Text = "VIEW GUEST TRANSACTION";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.mskValidStart.AllowPromptAsInput = false;
      this.mskValidStart.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskValidStart.ForeColor = Color.Blue;
      this.mskValidStart.Location = new Point(328, 104);
      this.mskValidStart.Mask = "####-##-##";
      this.mskValidStart.Name = "mskValidStart";
      this.mskValidStart.Size = new Size(81, 20);
      this.mskValidStart.TabIndex = 14;
      this.Label3.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label3.Location = new Point(307, 96);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(97, 17);
      this.Label3.TabIndex = 52;
      this.Label3.Text = "Guest ID : ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label4.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label4.Location = new Point(307, 136);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(97, 17);
      this.Label4.TabIndex = 51;
      this.Label4.Text = "Guest Name : ";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Frame1.BackColor = Color.FromArgb(0, 192, 0);
      this.Frame1.Controls.Add((Control) this.txtChargeType);
      this.Frame1.Controls.Add((Control) this.txtCardNo);
      this.Frame1.Controls.Add((Control) this.txtGracePeriod);
      this.Frame1.Controls.Add((Control) this.txtDeposit);
      this.Frame1.Controls.Add((Control) this.txtLastPayment);
      this.Frame1.Controls.Add((Control) this.txtAmountPaid);
      this.Frame1.Controls.Add((Control) this.txtNoOfDays);
      this.Frame1.Controls.Add((Control) this.mskContractStart);
      this.Frame1.Controls.Add((Control) this.mskContractEnd);
      this.Frame1.Controls.Add((Control) this.mskValidStart);
      this.Frame1.Controls.Add((Control) this.mskValidEnd);
      this.Frame1.Controls.Add((Control) this.lblRoomType);
      this.Frame1.Controls.Add((Control) this.lblFloorNo);
      this.Frame1.Controls.Add((Control) this.lblBuildingNo);
      this.Frame1.Controls.Add((Control) this.lblRoomNo);
      this.Frame1.Controls.Add((Control) this.Label28);
      this.Frame1.Controls.Add((Control) this.Label12);
      this.Frame1.Controls.Add((Control) this.Label13);
      this.Frame1.Controls.Add((Control) this.Label14);
      this.Frame1.Controls.Add((Control) this.Label15);
      this.Frame1.Controls.Add((Control) this.Label16);
      this.Frame1.Controls.Add((Control) this.Label17);
      this.Frame1.Controls.Add((Control) this.Label18);
      this.Frame1.Controls.Add((Control) this.Label19);
      this.Frame1.Controls.Add((Control) this.Label21);
      this.Frame1.Controls.Add((Control) this.Label22);
      this.Frame1.Controls.Add((Control) this.Label23);
      this.Frame1.Controls.Add((Control) this.Label24);
      this.Frame1.Controls.Add((Control) this.Label25);
      this.Frame1.Controls.Add((Control) this.Label26);
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(11, 168);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(697, 169);
      this.Frame1.TabIndex = 56;
      this.Frame1.TabStop = false;
      this.mskValidEnd.AllowPromptAsInput = false;
      this.mskValidEnd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mskValidEnd.ForeColor = Color.Blue;
      this.mskValidEnd.Location = new Point(528, 104);
      this.mskValidEnd.Mask = "####-##-##";
      this.mskValidEnd.Name = "mskValidEnd";
      this.mskValidEnd.Size = new Size(81, 20);
      this.mskValidEnd.TabIndex = 15;
      this.lblRoomType.BackColor = Color.FromArgb(0, 192, 0);
      this.lblRoomType.Cursor = Cursors.Default;
      this.lblRoomType.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomType.ForeColor = Color.Blue;
      this.lblRoomType.Location = new Point(528, 16);
      this.lblRoomType.Name = "lblRoomType";
      this.lblRoomType.RightToLeft = RightToLeft.No;
      this.lblRoomType.Size = new Size(105, 25);
      this.lblRoomType.TabIndex = 37;
      this.lblFloorNo.BackColor = Color.FromArgb(0, 192, 0);
      this.lblFloorNo.Cursor = Cursors.Default;
      this.lblFloorNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFloorNo.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.lblFloorNo.Location = new Point(336, 16);
      this.lblFloorNo.Name = "lblFloorNo";
      this.lblFloorNo.RightToLeft = RightToLeft.No;
      this.lblFloorNo.Size = new Size(57, 25);
      this.lblFloorNo.TabIndex = 36;
      this.lblBuildingNo.BackColor = Color.FromArgb(0, 192, 0);
      this.lblBuildingNo.Cursor = Cursors.Default;
      this.lblBuildingNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuildingNo.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.lblBuildingNo.Location = new Point(128, 16);
      this.lblBuildingNo.Name = "lblBuildingNo";
      this.lblBuildingNo.RightToLeft = RightToLeft.No;
      this.lblBuildingNo.Size = new Size(57, 25);
      this.lblBuildingNo.TabIndex = 35;
      this.lblRoomNo.BackColor = Color.FromArgb(0, 192, 0);
      this.lblRoomNo.Cursor = Cursors.Default;
      this.lblRoomNo.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblRoomNo.ForeColor = Color.Red;
      this.lblRoomNo.Location = new Point(128, 40);
      this.lblRoomNo.Name = "lblRoomNo";
      this.lblRoomNo.RightToLeft = RightToLeft.No;
      this.lblRoomNo.Size = new Size(81, 25);
      this.lblRoomNo.TabIndex = 33;
      this.Label28.BackColor = Color.FromArgb(0, 192, 0);
      this.Label28.Cursor = Cursors.Default;
      this.Label28.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label28.ForeColor = Color.White;
      this.Label28.Location = new Point(448, 40);
      this.Label28.Name = "Label28";
      this.Label28.RightToLeft = RightToLeft.No;
      this.Label28.Size = new Size(73, 17);
      this.Label28.TabIndex = 31;
      this.Label28.Text = "Card No.";
      this.Label28.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb(0, 192, 0);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.Yellow;
      this.Label12.Location = new Point(16, 16);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(97, 17);
      this.Label12.TabIndex = 29;
      this.Label12.Text = "Building No. ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.Label13.BackColor = Color.FromArgb(0, 192, 0);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.Yellow;
      this.Label13.Location = new Point(256, 16);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(65, 17);
      this.Label13.TabIndex = 28;
      this.Label13.Text = "Floor No.";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.Label14.BackColor = Color.FromArgb(0, 192, 0);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.White;
      this.Label14.Location = new Point(48, 40);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(65, 17);
      this.Label14.TabIndex = 27;
      this.Label14.Text = "Room No.";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.Label15.BackColor = Color.FromArgb(0, 192, 0);
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.Yellow;
      this.Label15.Location = new Point(456, 16);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(65, 17);
      this.Label15.TabIndex = 26;
      this.Label15.Text = "Room Type ";
      this.Label15.TextAlign = ContentAlignment.TopRight;
      this.Label16.BackColor = Color.FromArgb(0, 192, 0);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.Blue;
      this.Label16.Location = new Point(208, 40);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(105, 17);
      this.Label16.TabIndex = 25;
      this.Label16.Text = "Charge Type";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb(0, 192, 0);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.White;
      this.Label17.Location = new Point(40, 72);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 24;
      this.Label17.Text = "Contract Start";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb(0, 192, 0);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = Color.White;
      this.Label18.Location = new Point(232, 72);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(81, 17);
      this.Label18.TabIndex = 23;
      this.Label18.Text = "Contract End";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label19.BackColor = Color.FromArgb(0, 192, 0);
      this.Label19.Cursor = Cursors.Default;
      this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.Blue;
      this.Label19.Location = new Point(432, 72);
      this.Label19.Name = "Label19";
      this.Label19.RightToLeft = RightToLeft.No;
      this.Label19.Size = new Size(89, 17);
      this.Label19.TabIndex = 22;
      this.Label19.Text = "Grace Period";
      this.Label19.TextAlign = ContentAlignment.TopRight;
      this.Label21.BackColor = Color.FromArgb(0, 192, 0);
      this.Label21.Cursor = Cursors.Default;
      this.Label21.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = Color.Blue;
      this.Label21.Location = new Point(40, 136);
      this.Label21.Name = "Label21";
      this.Label21.RightToLeft = RightToLeft.No;
      this.Label21.Size = new Size(65, 17);
      this.Label21.TabIndex = 21;
      this.Label21.Text = "Deposit";
      this.Label21.TextAlign = ContentAlignment.TopRight;
      this.Label22.BackColor = Color.FromArgb(0, 192, 0);
      this.Label22.Cursor = Cursors.Default;
      this.Label22.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = Color.Blue;
      this.Label22.Location = new Point(192, 136);
      this.Label22.Name = "Label22";
      this.Label22.RightToLeft = RightToLeft.No;
      this.Label22.Size = new Size(121, 17);
      this.Label22.TabIndex = 20;
      this.Label22.Text = "Last Payment";
      this.Label22.TextAlign = ContentAlignment.TopRight;
      this.Label23.BackColor = Color.FromArgb(0, 192, 0);
      this.Label23.Cursor = Cursors.Default;
      this.Label23.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = Color.Blue;
      this.Label23.Location = new Point(424, 136);
      this.Label23.Name = "Label23";
      this.Label23.RightToLeft = RightToLeft.No;
      this.Label23.Size = new Size(97, 17);
      this.Label23.TabIndex = 19;
      this.Label23.Text = "Total Received ";
      this.Label23.TextAlign = ContentAlignment.TopRight;
      this.Label24.BackColor = Color.FromArgb(0, 192, 0);
      this.Label24.Cursor = Cursors.Default;
      this.Label24.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = Color.White;
      this.Label24.Location = new Point(208, 104);
      this.Label24.Name = "Label24";
      this.Label24.RightToLeft = RightToLeft.No;
      this.Label24.Size = new Size(113, 17);
      this.Label24.TabIndex = 18;
      this.Label24.Text = "Valid Start Date";
      this.Label24.TextAlign = ContentAlignment.TopRight;
      this.Label25.BackColor = Color.FromArgb(0, 192, 0);
      this.Label25.Cursor = Cursors.Default;
      this.Label25.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = Color.White;
      this.Label25.Location = new Point(424, 104);
      this.Label25.Name = "Label25";
      this.Label25.RightToLeft = RightToLeft.No;
      this.Label25.Size = new Size(97, 17);
      this.Label25.TabIndex = 17;
      this.Label25.Text = "Valid End Date";
      this.Label25.TextAlign = ContentAlignment.TopRight;
      this.Label26.BackColor = Color.FromArgb(0, 192, 0);
      this.Label26.Cursor = Cursors.Default;
      this.Label26.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.Blue;
      this.Label26.Location = new Point(16, 104);
      this.Label26.Name = "Label26";
      this.Label26.RightToLeft = RightToLeft.No;
      this.Label26.Size = new Size(105, 17);
      this.Label26.TabIndex = 16;
      this.Label26.Text = "No Of Days";
      this.Label26.TextAlign = ContentAlignment.TopRight;
      this.cmdCurrent.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdCurrent.Cursor = Cursors.Default;
      this.cmdCurrent.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdCurrent.ForeColor = SystemColors.ControlText;
      this.cmdCurrent.Image = (Image) componentResourceManager.GetObject("cmdCurrent.Image");
      this.cmdCurrent.Location = new Point(235, 88);
      this.cmdCurrent.Name = "cmdCurrent";
      this.cmdCurrent.RightToLeft = RightToLeft.No;
      this.cmdCurrent.Size = new Size(57, 33);
      this.cmdCurrent.TabIndex = 63;
      this.cmdCurrent.Text = "C&urrent ";
      this.cmdCurrent.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdCurrent, "Click to View Current Staying Guest's Transactions ");
      this.cmdCurrent.UseVisualStyleBackColor = false;
      this.cmdCurrent.Click += new EventHandler(this.cmdCurrent_Click);
      this.cmdClear.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Image = (Image) componentResourceManager.GetObject("cmdClear.Image");
      this.cmdClear.Location = new Point(731, 368);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(44, 47);
      this.cmdClear.TabIndex = 61;
      this.cmdClear.Text = "&Clear";
      this.cmdClear.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "To Clear Screen Data");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.cboBldNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.cboBldNo.Cursor = Cursors.Default;
      this.cboBldNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBldNo.ForeColor = Color.Blue;
      this.cboBldNo.Location = new Point(152, 22);
      this.cboBldNo.Name = "cboBldNo";
      this.cboBldNo.RightToLeft = RightToLeft.No;
      this.cboBldNo.Size = new Size(49, 22);
      this.cboBldNo.TabIndex = 50;
      this.ToolTip1.SetToolTip((Control) this.cboBldNo, "Select Building");
      this.cmdPrint.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(731, 416);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(44, 47);
      this.cmdPrint.TabIndex = 60;
      this.cmdPrint.Text = "&Print Recipt";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdPrint, "To Print Out Receipt");
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.cmdClientBrowser.BackColor = Color.Yellow;
      this.cmdClientBrowser.Cursor = Cursors.Default;
      this.cmdClientBrowser.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClientBrowser.ForeColor = SystemColors.ControlText;
      this.cmdClientBrowser.Image = (Image) componentResourceManager.GetObject("cmdClientBrowser.Image");
      this.cmdClientBrowser.Location = new Point(235, 128);
      this.cmdClientBrowser.Name = "cmdClientBrowser";
      this.cmdClientBrowser.RightToLeft = RightToLeft.No;
      this.cmdClientBrowser.Size = new Size(57, 33);
      this.cmdClientBrowser.TabIndex = 58;
      this.cmdClientBrowser.Text = "&All";
      this.cmdClientBrowser.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdClientBrowser, "Click To View All Guest's Transactions");
      this.cmdClientBrowser.UseVisualStyleBackColor = false;
      this.cmdClientBrowser.Click += new EventHandler(this.cmdClientBrowser_Click);
      this.cmdOK.BackColor = SystemColors.Control;
      this.cmdOK.Cursor = Cursors.Default;
      this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOK.ForeColor = SystemColors.ControlText;
      this.cmdOK.Location = new Point(576, 304);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.RightToLeft = RightToLeft.No;
      this.cmdOK.Size = new Size(65, 25);
      this.cmdOK.TabIndex = 42;
      this.cmdOK.Text = "&OK";
      this.ToolTip1.SetToolTip((Control) this.cmdOK, "Click OK to Return to View Guest Screen ");
      this.cmdOK.UseVisualStyleBackColor = false;
      this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(731, 464);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(44, 47);
      this.cmdReturn.TabIndex = 57;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Operation Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = SystemColors.WindowText;
      this.txtClientID.Location = new Point(419, 96);
      this.txtClientID.MaxLength = 8;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(81, 22);
      this.txtClientID.TabIndex = 50;
      this.txtClientID.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtClientID, "Guest ID");
      this.ClientFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.ClientFrame.Controls.Add((Control) this.dataGridView_GuestInfo);
      this.ClientFrame.Controls.Add((Control) this.cmdOK);
      this.ClientFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ClientFrame.ForeColor = Color.FromArgb(64, 64, 64);
      this.ClientFrame.Location = new Point(11, 168);
      this.ClientFrame.Name = "ClientFrame";
      this.ClientFrame.Padding = new Padding(0);
      this.ClientFrame.RightToLeft = RightToLeft.No;
      this.ClientFrame.Size = new Size(697, 345);
      this.ClientFrame.TabIndex = 59;
      this.ClientFrame.TabStop = false;
      this.ClientFrame.Text = "GUEST INFO :";
      this.dataGridView_GuestInfo.AllowUserToAddRows = false;
      this.dataGridView_GuestInfo.AllowUserToDeleteRows = false;
      this.dataGridView_GuestInfo.AllowUserToResizeColumns = false;
      this.dataGridView_GuestInfo.AllowUserToResizeRows = false;
      this.dataGridView_GuestInfo.AutoGenerateColumns = false;
      this.dataGridView_GuestInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView_GuestInfo.CausesValidation = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.dataGridView_GuestInfo.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dataGridView_GuestInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_GuestInfo.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.foreNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.surNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.cardNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.validStartDataGridViewTextBoxColumn, (DataGridViewColumn) this.validEndDataGridViewTextBoxColumn);
      this.dataGridView_GuestInfo.DataSource = (object) this.gInfoTempBindingSource;
      this.dataGridView_GuestInfo.EnableHeadersVisualStyles = false;
      this.dataGridView_GuestInfo.GridColor = SystemColors.GrayText;
      this.dataGridView_GuestInfo.Location = new Point(16, 16);
      this.dataGridView_GuestInfo.Margin = new Padding(2);
      this.dataGridView_GuestInfo.MultiSelect = false;
      this.dataGridView_GuestInfo.Name = "dataGridView_GuestInfo";
      this.dataGridView_GuestInfo.ReadOnly = true;
      this.dataGridView_GuestInfo.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.dataGridView_GuestInfo.RowTemplate.Height = 24;
      this.dataGridView_GuestInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView_GuestInfo.ShowCellToolTips = false;
      this.dataGridView_GuestInfo.ShowEditingIcon = false;
      this.dataGridView_GuestInfo.Size = new Size(662, 279);
      this.dataGridView_GuestInfo.TabIndex = 43;
      this.dataGridView_GuestInfo.TabStop = false;
      this.dataGridView_GuestInfo.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_GuestInfo_CellDoubleClick);
      this.dataGridView_GuestInfo.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView_GuestInfo_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.FillWeight = 593.401f;
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room No";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn.Width = 81;
      this.foreNameDataGridViewTextBoxColumn.DataPropertyName = "ForeName";
      this.foreNameDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.foreNameDataGridViewTextBoxColumn.HeaderText = "ForeName";
      this.foreNameDataGridViewTextBoxColumn.Name = "foreNameDataGridViewTextBoxColumn";
      this.foreNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
      this.surNameDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
      this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
      this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
      this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
      this.cardNoDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.cardNoDataGridViewTextBoxColumn.HeaderText = "CardNo";
      this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
      this.cardNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.validStartDataGridViewTextBoxColumn.DataPropertyName = "ValidStart";
      this.validStartDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.validStartDataGridViewTextBoxColumn.HeaderText = "ValidStart";
      this.validStartDataGridViewTextBoxColumn.Name = "validStartDataGridViewTextBoxColumn";
      this.validStartDataGridViewTextBoxColumn.ReadOnly = true;
      this.validEndDataGridViewTextBoxColumn.DataPropertyName = "ValidEnd";
      this.validEndDataGridViewTextBoxColumn.FillWeight = 17.7665f;
      this.validEndDataGridViewTextBoxColumn.HeaderText = "ValidEnd";
      this.validEndDataGridViewTextBoxColumn.Name = "validEndDataGridViewTextBoxColumn";
      this.validEndDataGridViewTextBoxColumn.ReadOnly = true;
      this.gInfoTempBindingSource.DataMember = "GInfo_Temp";
      this.gInfoTempBindingSource.DataSource = (object) this.tempDataSet;
      this.tempDataSet.DataSetName = "TempDataSet";
      this.tempDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.Data1.BackColor = Color.Red;
      this.Data1.BorderStyle = BorderStyle.FixedSingle;
      this.Data1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Data1.ForeColor = Color.Black;
      this.Data1.Location = new Point(715, 512);
      this.Data1.Name = "Data1";
      this.Data1.Size = new Size(76, 23);
      this.Data1.TabIndex = 66;
      this.Data1.Text = "Data1";
      this.Data1.Visible = false;
      this._optBuildingCheck_0.BackColor = Color.Cyan;
      this._optBuildingCheck_0.Checked = true;
      this._optBuildingCheck_0.Cursor = Cursors.Default;
      this._optBuildingCheck_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuildingCheck_0.ForeColor = Color.Red;
      this._optBuildingCheck_0.Location = new Point(16, 20);
      this._optBuildingCheck_0.Name = "_optBuildingCheck_0";
      this._optBuildingCheck_0.RightToLeft = RightToLeft.No;
      this._optBuildingCheck_0.Size = new Size(129, 25);
      this._optBuildingCheck_0.TabIndex = 48;
      this._optBuildingCheck_0.TabStop = true;
      this._optBuildingCheck_0.Text = "View Individual";
      this._optBuildingCheck_0.UseVisualStyleBackColor = false;
      this._optBuildingCheck_1.BackColor = Color.Cyan;
      this._optBuildingCheck_1.Cursor = Cursors.Default;
      this._optBuildingCheck_1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this._optBuildingCheck_1.ForeColor = Color.Red;
      this._optBuildingCheck_1.Location = new Point(16, 47);
      this._optBuildingCheck_1.Name = "_optBuildingCheck_1";
      this._optBuildingCheck_1.RightToLeft = RightToLeft.No;
      this._optBuildingCheck_1.Size = new Size(129, 25);
      this._optBuildingCheck_1.TabIndex = 49;
      this._optBuildingCheck_1.TabStop = true;
      this._optBuildingCheck_1.Text = "View All";
      this._optBuildingCheck_1.UseVisualStyleBackColor = false;
      this.BuildingSelectFrame.BackColor = Color.Cyan;
      this.BuildingSelectFrame.Controls.Add((Control) this.cboBldNo);
      this.BuildingSelectFrame.Controls.Add((Control) this._optBuildingCheck_1);
      this.BuildingSelectFrame.Controls.Add((Control) this._optBuildingCheck_0);
      this.BuildingSelectFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BuildingSelectFrame.ForeColor = Color.Black;
      this.BuildingSelectFrame.Location = new Point(11, 80);
      this.BuildingSelectFrame.Name = "BuildingSelectFrame";
      this.BuildingSelectFrame.Padding = new Padding(0);
      this.BuildingSelectFrame.RightToLeft = RightToLeft.No;
      this.BuildingSelectFrame.Size = new Size(217, 81);
      this.BuildingSelectFrame.TabIndex = 64;
      this.BuildingSelectFrame.TabStop = false;
      this.BuildingSelectFrame.Text = "Building :";
      this.gInfo_TempTableAdapter.ClearBeforeFill = true;
      this.dataGridView_GTransaction_Temp.AllowUserToAddRows = false;
      this.dataGridView_GTransaction_Temp.AutoGenerateColumns = false;
      this.dataGridView_GTransaction_Temp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView_GTransaction_Temp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      this.dataGridView_GTransaction_Temp.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      this.dataGridView_GTransaction_Temp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_GTransaction_Temp.Columns.AddRange((DataGridViewColumn) this.transIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.transTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.transDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.transTimeDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn1, (DataGridViewColumn) this.lastPaymentDataGridViewTextBoxColumn);
      this.dataGridView_GTransaction_Temp.DataSource = (object) this.gTransactionsTempBindingSource;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.dataGridView_GTransaction_Temp.DefaultCellStyle = gridViewCellStyle3;
      this.dataGridView_GTransaction_Temp.Location = new Point(54, 331);
      this.dataGridView_GTransaction_Temp.MultiSelect = false;
      this.dataGridView_GTransaction_Temp.Name = "dataGridView_GTransaction_Temp";
      this.dataGridView_GTransaction_Temp.ReadOnly = true;
      this.dataGridView_GTransaction_Temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView_GTransaction_Temp.Size = new Size(697, 166);
      this.dataGridView_GTransaction_Temp.TabIndex = 67;
      this.dataGridView_GTransaction_Temp.Visible = false;
      this.dataGridView_GTransaction_Temp.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView_GTransaction_Temp_RowStateChanged);
      this.transIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.transIDDataGridViewTextBoxColumn.DataPropertyName = "TransID";
      this.transIDDataGridViewTextBoxColumn.HeaderText = "Payment Note No.";
      this.transIDDataGridViewTextBoxColumn.Name = "transIDDataGridViewTextBoxColumn";
      this.transIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.transIDDataGridViewTextBoxColumn.Width = 119;
      this.transTypeDataGridViewTextBoxColumn.DataPropertyName = "TransType";
      this.transTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
      this.transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
      this.transTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
      this.transDateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
      this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.transTimeDataGridViewTextBoxColumn.DataPropertyName = "TransTime";
      this.transTimeDataGridViewTextBoxColumn.HeaderText = "Time";
      this.transTimeDataGridViewTextBoxColumn.Name = "transTimeDataGridViewTextBoxColumn";
      this.transTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn1.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn1.HeaderText = "Room No.";
      this.roomNoDataGridViewTextBoxColumn1.Name = "roomNoDataGridViewTextBoxColumn1";
      this.roomNoDataGridViewTextBoxColumn1.ReadOnly = true;
      this.lastPaymentDataGridViewTextBoxColumn.DataPropertyName = "LastPayment";
      this.lastPaymentDataGridViewTextBoxColumn.HeaderText = "Amount";
      this.lastPaymentDataGridViewTextBoxColumn.Name = "lastPaymentDataGridViewTextBoxColumn";
      this.lastPaymentDataGridViewTextBoxColumn.ReadOnly = true;
      this.gTransactionsTempBindingSource.DataMember = "GTransactions_Temp";
      this.gTransactionsTempBindingSource.DataSource = (object) this.tempDataSet;
      this.gTransactions_TempTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(792, 588);
      this.Controls.Add((Control) this.dataGridView_GTransaction_Temp);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.lblFirstName);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.cmdCurrent);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.cmdClientBrowser);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.Data1);
      this.Controls.Add((Control) this.BuildingSelectFrame);
      this.Controls.Add((Control) this.txtClientID);
      this.Controls.Add((Control) this.ClientFrame);
      this.Name = "Form_ViewGuestTransDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_ViewGuestTransDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_ViewGuestTransDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_ViewGuestTransDMS_FormClosing);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ClientFrame.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_GuestInfo).EndInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.BuildingSelectFrame.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_GTransaction_Temp).EndInit();
      ((ISupportInitialize) this.gTransactionsTempBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form_ViewGuestTransDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
    }

    private void Form_ViewGuestTransDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_ViewGuestTransDMS_Load(object sender, EventArgs e)
    {
      this.db.CheckBuilding(this.cboBldNo, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.dataGridView_GTransaction_Temp.Location = new Point(14, 343);
      this.gTransactionsTempBindingSource.DataSource = (object) this.db.temp_DB.tempDataSet;
      this.gInfoTempBindingSource.DataSource = (object) this.db.temp_DB.tempDataSet;
    }

    private void cmdCurrent_Click(object sender, EventArgs e)
    {
      this.ClientFrame.Visible = true;
      this.Frame1.Visible = false;
      this.cmdPrint.Enabled = false;
      this.dataGridView_GTransaction_Temp.Visible = false;
      this.db.Local_Command.CommandText = "Delete * from GInfo_Temp";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gInfo_TempTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (this.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GInfo_Temp(ClientID,ForeName,SurName,RoomNo,CardNo,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople<>9)ORDER BY ClientAcc.RoomNo";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))AND (ClientAcc.NoOfPeople<>9)ORDER BY ClientAcc.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      this.db.temp_DB.tempDataSet.GInfo_Temp.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) this.db.temp_DB.tempDataSet.GInfo_Temp);
      if (this.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
      this.dataGridView_GuestInfo.Refresh();
      this.selected_rowindex = 0;
      this.dataGridView_GuestInfo.Select();
      if (this.dataGridView_GuestInfo.Rows.Count <= 0)
        this.cmdOK.Enabled = false;
      else
        this.cmdOK.Enabled = true;
    }

    private void cmdClientBrowser_Click(object sender, EventArgs e)
    {
      this.ClientFrame.Visible = true;
      this.Frame1.Visible = false;
      this.cmdPrint.Enabled = false;
      this.dataGridView_GTransaction_Temp.Visible = false;
      this.db.Local_Command.CommandText = "Delete * from GInfo_Temp";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gInfo_TempTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (this.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GInfo_Temp(ClientID,ForeName,SurName,RoomNo,CardNo,ValidStart,ValidEnd) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))ORDER BY ClientAcc.RoomNo";
      else
        this.db.Local_Command.CommandText = "Select ClientAcc.ClientID,Client.ForeName,Client.SurName,ClientAcc.RoomNo,ClientAcc.CardNo,ClientAcc.ValidStart,ClientAcc.ValidEnd From (ClientAcc INNER JOIN Client ON ClientAcc.ClientID=Client.ClientID) Where ((Right(ClientAcc.ClientID,4)>'5000'))ORDER BY ClientAcc.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      this.db.temp_DB.tempDataSet.GInfo_Temp.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) this.db.temp_DB.tempDataSet.GInfo_Temp);
      if (this.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gInfo_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GInfo_Temp);
      this.dataGridView_GuestInfo.Refresh();
      this.selected_rowindex = 0;
      this.dataGridView_GuestInfo.Focus();
      this.dataGridView_GuestInfo.Select();
      if (this.dataGridView_GuestInfo.Rows.Count <= 0)
        this.cmdOK.Enabled = false;
      else
        this.cmdOK.Enabled = true;
    }

    private void dataGridView_GuestInfo_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.temp_DB.tempDataSet.GInfo_Temp.Rows.Count || this.dataGridView_GuestInfo.Rows.Count != this.db.temp_DB.tempDataSet.GInfo_Temp.Rows.Count)
        return;
      this.selected_rowindex = e.Row.Index;
    }

    private void dataGridView_GuestInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
      this.OK_Click_Process();
    }

    private void Get_Client_Data_From_Building(string para_BuildingNo, string para_ClientID)
    {
      bool flag1 = false;
      this.db.building_DB1.cardTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.CardTrans);
      foreach (BuildingDB1DataSet.CardTransRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.CardTrans.Rows)
      {
        if (row.ClientID == para_ClientID)
        {
          this.lblRoomNo.Text = row.RoomNo;
          try
          {
            string cardNo = row.CardNo;
          }
          catch
          {
          }
          flag1 = true;
          break;
        }
      }
      if (!flag1)
      {
        int num1 = (int) MessageBox.Show("Wrong ID!");
      }
      else
      {
        bool flag2 = false;
        this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
        foreach (SystemDataSet.RoomRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Room.Rows)
        {
          if (row.RoomNo == this.lblRoomNo.Text)
          {
            this.lblBuildingNo.Text = row.BuildingNo;
            this.lblFloorNo.Text = row.FloorNo;
            this.lblRoomType.Text = this.db.Get_RoomType_Description(row.RoomType);
            flag2 = true;
            break;
          }
        }
        if (!flag2)
        {
          int num2 = (int) MessageBox.Show("Invalid Room No!");
        }
        else
        {
          bool flag3 = false;
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
          foreach (BuildingDB1DataSet.ClientRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Client.Rows)
          {
            if (row.ClientID == para_ClientID)
            {
              this.lblFirstName.Text = row.ForeName + "  " + row.SurName;
              flag3 = true;
              break;
            }
          }
          if (!flag3)
          {
            int num3 = (int) MessageBox.Show("Invalid Guest ID!");
          }
          else
          {
            bool flag4 = false;
            this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
            foreach (BuildingDB1DataSet.ClientAccRow clientAccRow in this.db.building_DB1.buildingDB1DataSet.ClientAcc)
            {
              if (clientAccRow.ClientID == para_ClientID)
              {
                try
                {
                  Decimal deposit = clientAccRow.Deposit;
                  this.txtDeposit.Text = clientAccRow.Deposit.ToString();
                }
                catch
                {
                }
                try
                {
                  if (clientAccRow.ChargeType != null)
                  {
                    if (clientAccRow.ChargeType == "D")
                      this.txtChargeType.Text = "Daily";
                    else if (clientAccRow.ChargeType == "W")
                      this.txtChargeType.Text = "Weekly";
                    else if (clientAccRow.ChargeType == "M")
                      this.txtChargeType.Text = "Monthly";
                    else
                      this.txtChargeType.Text = "";
                  }
                }
                catch
                {
                  this.txtChargeType.Text = "";
                }
                try
                {
                  int gracePeriod = (int) clientAccRow.GracePeriod;
                  this.txtGracePeriod.Text = clientAccRow.GracePeriod.ToString();
                }
                catch
                {
                }
                try
                {
                  DateTime contractStart = clientAccRow.ContractStart;
                  this.mskContractStart.Text = clientAccRow.ContractStart.ToShortDateString();
                }
                catch
                {
                }
                try
                {
                  DateTime contractEnd = clientAccRow.ContractEnd;
                  this.mskContractEnd.Text = clientAccRow.ContractEnd.ToShortDateString();
                }
                catch
                {
                }
                try
                {
                  DateTime validStart = clientAccRow.ValidStart;
                  this.mskValidStart.Text = clientAccRow.ValidStart.ToShortDateString();
                }
                catch
                {
                }
                try
                {
                  DateTime validEnd = clientAccRow.ValidEnd;
                  this.mskValidEnd.Text = clientAccRow.ValidEnd.ToShortDateString();
                }
                catch
                {
                }
                if (this.mskValidStart.Text.Length == 10 && this.mskValidEnd.Text.Length == 10)
                  this.txtNoOfDays.Text = this.db.Get_No_Of_Days(clientAccRow.ValidStart, clientAccRow.ValidEnd).ToString();
                else if (this.mskContractStart.Text.Length == 10)
                {
                  if (this.mskContractEnd.Text.Length == 10)
                    this.txtNoOfDays.Text = this.db.Get_No_Of_Days(clientAccRow.ContractStart, clientAccRow.ContractEnd).ToString();
                }
                try
                {
                  Decimal lastPayment = clientAccRow.LastPayment;
                  this.txtLastPayment.Text = clientAccRow.LastPayment.ToString();
                }
                catch
                {
                }
                try
                {
                  Decimal amountPaid = clientAccRow.AmountPaid;
                  this.txtAmountPaid.Text = clientAccRow.AmountPaid.ToString();
                }
                catch
                {
                }
                flag4 = true;
                break;
              }
            }
            if (flag4)
              return;
            int num4 = (int) MessageBox.Show("Can't find ClientID!");
          }
        }
      }
    }

    private void Get_Client_Data(string para_BuildingNo, string para_ClientID)
    {
      this.Get_Client_Data_From_Building(para_BuildingNo, para_ClientID);
    }

    private void Load_GTransaction_Temp(string para_ClientID)
    {
      this.db.Local_Command.CommandText = "Delete * from GTransactions_Temp";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gTransactions_TempTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      if (this.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into GTransactions_Temp (TransID,TransType,TransDate,TransTime,RoomNo, LastPayment) in'" + Application.UserAppDataPath + "\\Temp.mdb'Select CardTrans.TransID,CardTrans.TransType,CardTrans.TransDate,CardTrans.TransTime,CardTrans.RoomNo,CardTrans.LastPayment From  CardTrans  Where (((CardTrans.ClientID)='" + para_ClientID + "'))ORDER BY CardTrans.RoomNo";
      else
        this.db.Local_Command.CommandText = "Select CardTrans.TransID,CardTrans.TransType,CardTrans.TransDate,CardTrans.TransTime,CardTrans.RoomNo,CardTrans.LastPayment From  CardTrans  Where (((CardTrans.ClientID)='" + para_ClientID + "'))ORDER BY CardTrans.RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      this.db.temp_DB.tempDataSet.GTransactions_Temp.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) this.db.temp_DB.tempDataSet.GTransactions_Temp);
      if (this.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gTransactions_TempTableAdapter.Fill(this.db.temp_DB.tempDataSet.GTransactions_Temp);
      this.dataGridView_GTransaction_Temp.Refresh();
      this.selected_rowindex_2 = 0;
    }

    private void Clear_Data()
    {
      this.lblBuildingNo.Text = "";
      this.lblFloorNo.Text = "";
      this.lblRoomType.Text = "";
      this.lblRoomNo.Text = "";
      this.txtChargeType.Text = "";
      this.txtLastPayment.Text = "";
      this.txtAmountPaid.Text = "";
      this.txtNoOfDays.Text = "";
      this.mskContractStart.Text = "";
      this.mskContractEnd.Text = "";
      this.mskValidStart.Text = "";
      this.mskValidEnd.Text = "";
      this.txtDeposit.Text = "";
      this.txtCardNo.Text = "";
      this.txtGracePeriod.Text = "";
    }

    private void OK_Click_Process()
    {
      this.ClientFrame.Visible = false;
      this.Frame1.Visible = true;
      string para_ClientID = (string) this.dataGridView_GuestInfo.Rows[this.selected_rowindex].Cells[this.clientIDDataGridViewTextBoxColumn.Name].Value;
      this.txtClientID.Text = para_ClientID;
      this.Clear_Data();
      this.Refresh();
      try
      {
        this.txtCardNo.Text = (string) this.dataGridView_GuestInfo.Rows[this.selected_rowindex].Cells[this.cardNoDataGridViewTextBoxColumn.Name].Value;
      }
      catch
      {
        this.txtCardNo.Text = "";
      }
      this.Get_Client_Data(this.cboBldNo.Text, para_ClientID);
      this.Load_GTransaction_Temp(para_ClientID);
      this.dataGridView_GTransaction_Temp.Visible = true;
      if (this.dataGridView_GTransaction_Temp.Rows.Count <= 0)
        this.cmdPrint.Enabled = false;
      else
        this.cmdPrint.Enabled = true;
    }

    private void cmdOK_Click(object sender, EventArgs e) => this.OK_Click_Process();

    private void dataGridView_GTransaction_Temp_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.temp_DB.tempDataSet.GTransactions_Temp.Rows.Count || this.dataGridView_GTransaction_Temp.Rows.Count != this.db.temp_DB.tempDataSet.GTransactions_Temp.Rows.Count)
        return;
      this.selected_rowindex_2 = e.Row.Index;
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      string para_sTransCode = (string) this.dataGridView_GTransaction_Temp.Rows[this.selected_rowindex_2].Cells[this.transTypeDataGridViewTextBoxColumn.Name].Value;
      int para_iTransID = (int) this.dataGridView_GTransaction_Temp.Rows[this.selected_rowindex_2].Cells[this.transIDDataGridViewTextBoxColumn.Name].Value;
      this.Refresh();
      ReportForm reportForm = new ReportForm();
      ReportClass_ViewGuestTransDMS viewGuestTransDms = new ReportClass_ViewGuestTransDMS();
      reportForm.crystalReportViewer1.ReportSource = viewGuestTransDms.CHECK_TransType(para_sTransCode, para_iTransID, Global_Data.sBldNo);
      int num = (int) reportForm.ShowDialog();
    }

    private void ClearScreen()
    {
      this.dataGridView_GTransaction_Temp.Visible = false;
      this.dataGridView_GuestInfo.Visible = true;
      this.txtClientID.Text = "";
      this.lblFirstName.Text = "";
      this.lblBuildingNo.Text = "";
      this.lblFloorNo.Text = "";
      this.lblRoomType.Text = "";
      this.lblRoomNo.Text = "";
      this.txtChargeType.Text = "";
      this.txtLastPayment.Text = "";
      this.txtAmountPaid.Text = "";
      this.txtNoOfDays.Text = "";
      this.mskContractStart.Text = "";
      this.mskContractEnd.Text = "";
      this.mskValidStart.Text = "";
      this.mskValidEnd.Text = "";
      this.txtDeposit.Text = "";
      this.txtCardNo.Text = "";
      this.txtGracePeriod.Text = "";
      this.ClientFrame.Visible = false;
      this.cmdPrint.Enabled = false;
    }

    private void Screen_Clean()
    {
      this.ClearScreen();
      this.BuildingSelectFrame.Visible = true;
      this.cmdClientBrowser.Focus();
    }

    private void cmdClear_Click(object sender, EventArgs e) => this.Screen_Clean();

    private void Form_ViewGuestTransDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Screen_Clean();
    }
  }
}
