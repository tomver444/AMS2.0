// Decompiled with JetBrains decompiler
// Type: AMS.Form_EditDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.TempDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_EditDMS : Form
  {
    private IContainer components;
    public MaskedTextBox mskValidStart;
    public MaskedTextBox mskValidEnd;
    public MaskedTextBox mskTransDate;
    public Label Label19;
    public Label Label18;
    public Label Label17;
    public Label Label13;
    public Label Label24;
    public Label Label25;
    public Label Label12;
    public Label Label10;
    public Label Label11;
    public ToolTip ToolTip1;
    public TextBox txtErrDescription;
    public TextBox txtErrAmount;
    public Button cmdConfirm;
    public TextBox txtPaymentNoteNo;
    public TextBox txtTransTime;
    public TextBox txtBondErrDescription;
    public TextBox txtBonusClaim;
    public TextBox txtTransType;
    public TextBox txtBalance;
    public TextBox txtGST;
    public Button cmdPrint;
    public TextBox txtCardNo;
    public TextBox txtLastPayment;
    public TextBox txtExtraCharge;
    public TextBox txtBondErrAmount;
    public Button cmdReturn;
    public TextBox txtRBA;
    public Button cmdView;
    public Button cmdAdjust;
    public Button cmdClear;
    public TextBox txtPreviousAdvance;
    public TextBox txtKeyDeposit;
    public TextBox txtRoomCharge;
    public TextBox txtDeposit;
    public TextBox txtBond;
    public TextBox txtAdvance;
    public TextBox txtClientID;
    public TextBox txtRoomNo;
    public ComboBox cboBuildingNo;
    public Label Label6;
    public Label Label9;
    public Label Label20;
    public Label Label5;
    public Label Label8;
    public Label Label14;
    public Label Label7;
    public Label Label16;
    public Label Label2;
    public Label Label1;
    public Label Label4;
    public Label lbPrevious;
    public Label Label23;
    public Label lbExtraKeyCharge;
    public Label Label26;
    public Label Label15;
    public Label Label21;
    public Label Label22;
    public Label Label3;
    public GroupBox OthersFrame;
    public Panel AdjustFrame;
    public GroupBox BondFrame;
    public GroupBox DataFrame;
    public Button cmdOk;
    public GroupBox DetailFrame;
    public Label lblMessage;
    private DataGridView dataGridView_DTransaction;
    private TempDataSet tempDataSet;
    private BindingSource dTransactionsBindingSource;
    private DTransactionsTableAdapter dTransactionsTableAdapter;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn previousAdvanceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn advancedPaymentDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bondDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn rBADataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn keyDepositDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn extraChargeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomChargeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bonusClaimDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn lastPaymentDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn transTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validStartDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validEndDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn checkInTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn checkOutTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn chargeTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gracePeriodDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cardTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn reserveRefDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn oldRoomDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn exDescriptionDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn updateDataGridViewCheckBoxColumn;
    private DB db;
    private Form_TransactionReportDMS Form_TransactionReportDMS_Ptr;
    private int selected_rowindex;
    private bool Temp_MDB_SaveFlag;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_EditDMS));
      this.mskValidStart = new MaskedTextBox();
      this.mskValidEnd = new MaskedTextBox();
      this.mskTransDate = new MaskedTextBox();
      this.Label19 = new Label();
      this.Label18 = new Label();
      this.Label17 = new Label();
      this.Label13 = new Label();
      this.Label24 = new Label();
      this.Label25 = new Label();
      this.Label12 = new Label();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.txtErrDescription = new TextBox();
      this.txtErrAmount = new TextBox();
      this.cmdConfirm = new Button();
      this.txtPaymentNoteNo = new TextBox();
      this.txtTransTime = new TextBox();
      this.txtBondErrDescription = new TextBox();
      this.txtBonusClaim = new TextBox();
      this.txtTransType = new TextBox();
      this.txtBalance = new TextBox();
      this.txtGST = new TextBox();
      this.cmdPrint = new Button();
      this.txtCardNo = new TextBox();
      this.txtLastPayment = new TextBox();
      this.txtExtraCharge = new TextBox();
      this.txtBondErrAmount = new TextBox();
      this.cmdReturn = new Button();
      this.txtRBA = new TextBox();
      this.cmdView = new Button();
      this.cmdAdjust = new Button();
      this.cmdClear = new Button();
      this.txtPreviousAdvance = new TextBox();
      this.txtKeyDeposit = new TextBox();
      this.txtRoomCharge = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtBond = new TextBox();
      this.txtAdvance = new TextBox();
      this.txtClientID = new TextBox();
      this.txtRoomNo = new TextBox();
      this.cboBuildingNo = new ComboBox();
      this.Label6 = new Label();
      this.Label9 = new Label();
      this.Label20 = new Label();
      this.Label5 = new Label();
      this.Label8 = new Label();
      this.Label14 = new Label();
      this.Label7 = new Label();
      this.Label16 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Label4 = new Label();
      this.lbPrevious = new Label();
      this.Label23 = new Label();
      this.lbExtraKeyCharge = new Label();
      this.Label26 = new Label();
      this.Label15 = new Label();
      this.Label21 = new Label();
      this.Label22 = new Label();
      this.Label3 = new Label();
      this.OthersFrame = new GroupBox();
      this.AdjustFrame = new Panel();
      this.BondFrame = new GroupBox();
      this.DataFrame = new GroupBox();
      this.dataGridView_DTransaction = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.cardNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.previousAdvanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.advancedPaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bondDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.rBADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.keyDepositDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.extraChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bonusClaimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.lastPaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.transTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.validStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.validEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.checkInDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.checkInTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.checkOutTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.checkOutDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.chargeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gracePeriodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gSTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.cardTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.conditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.reserveRefDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.oldRoomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.depositDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.exDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.updateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      this.dTransactionsBindingSource = new BindingSource(this.components);
      this.tempDataSet = new TempDataSet();
      this.cmdOk = new Button();
      this.DetailFrame = new GroupBox();
      this.lblMessage = new Label();
      this.dTransactionsTableAdapter = new DTransactionsTableAdapter();
      this.OthersFrame.SuspendLayout();
      this.AdjustFrame.SuspendLayout();
      this.BondFrame.SuspendLayout();
      this.DataFrame.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_DTransaction).BeginInit();
      ((ISupportInitialize) this.dTransactionsBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.DetailFrame.SuspendLayout();
      this.SuspendLayout();
      this.mskValidStart.AllowPromptAsInput = false;
      this.mskValidStart.Enabled = false;
      this.mskValidStart.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidStart.ForeColor = Color.Blue;
      this.mskValidStart.Location = new Point(208, 72);
      this.mskValidStart.Mask = "####/##/##";
      this.mskValidStart.Name = "mskValidStart";
      this.mskValidStart.Size = new Size(81, 20);
      this.mskValidStart.TabIndex = 50;
      this.mskValidEnd.AllowPromptAsInput = false;
      this.mskValidEnd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskValidEnd.ForeColor = Color.Blue;
      this.mskValidEnd.Location = new Point(208, 112);
      this.mskValidEnd.Mask = "####/##/##";
      this.mskValidEnd.Name = "mskValidEnd";
      this.mskValidEnd.Size = new Size(81, 20);
      this.mskValidEnd.TabIndex = 51;
      this.mskTransDate.AllowPromptAsInput = false;
      this.mskTransDate.Enabled = false;
      this.mskTransDate.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mskTransDate.ForeColor = Color.Blue;
      this.mskTransDate.Location = new Point(208, 216);
      this.mskTransDate.Mask = "####/##/##";
      this.mskTransDate.Name = "mskTransDate";
      this.mskTransDate.Size = new Size(81, 20);
      this.mskTransDate.TabIndex = 56;
      this.Label19.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label19.Cursor = Cursors.Default;
      this.Label19.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label19.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label19.Location = new Point(208, 280);
      this.Label19.Name = "Label19";
      this.Label19.RightToLeft = RightToLeft.No;
      this.Label19.Size = new Size(105, 25);
      this.Label19.TabIndex = 60;
      this.Label19.Text = "Transaction Type ";
      this.Label19.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label18.Location = new Point(208, 240);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(81, 17);
      this.Label18.TabIndex = 59;
      this.Label18.Text = "Time ";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label17.Location = new Point(208, 200);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 57;
      this.Label17.Text = "Date ";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label13.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label13.Location = new Point(208, 144);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(73, 25);
      this.Label13.TabIndex = 55;
      this.Label13.Text = "Payment Note No. ";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.Label24.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label24.Cursor = Cursors.Default;
      this.Label24.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label24.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label24.Location = new Point(208, 56);
      this.Label24.Name = "Label24";
      this.Label24.RightToLeft = RightToLeft.No;
      this.Label24.Size = new Size(81, 17);
      this.Label24.TabIndex = 53;
      this.Label24.Text = "Valid Start ";
      this.Label24.TextAlign = ContentAlignment.TopRight;
      this.Label25.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label25.Cursor = Cursors.Default;
      this.Label25.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label25.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label25.Location = new Point(208, 96);
      this.Label25.Name = "Label25";
      this.Label25.RightToLeft = RightToLeft.No;
      this.Label25.Size = new Size(81, 17);
      this.Label25.TabIndex = 52;
      this.Label25.Text = "Valid End ";
      this.Label25.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label12.Location = new Point(16, 304);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(97, 17);
      this.Label12.TabIndex = 49;
      this.Label12.Text = "Bonus Claim  ";
      this.Label12.TextAlign = ContentAlignment.TopRight;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label10.Location = new Point(208, 328);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(49, 19);
      this.Label10.TabIndex = 44;
      this.Label10.Text = "GST ";
      this.Label10.TextAlign = ContentAlignment.TopRight;
      this.Label11.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label11.Cursor = Cursors.Default;
      this.Label11.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label11.Location = new Point(16, 279);
      this.Label11.Name = "Label11";
      this.Label11.RightToLeft = RightToLeft.No;
      this.Label11.Size = new Size(97, 17);
      this.Label11.TabIndex = 46;
      this.Label11.Text = "Balance";
      this.Label11.TextAlign = ContentAlignment.TopRight;
      this.txtErrDescription.AcceptsReturn = true;
      this.txtErrDescription.BackColor = Color.White;
      this.txtErrDescription.BorderStyle = BorderStyle.FixedSingle;
      this.txtErrDescription.Cursor = Cursors.IBeam;
      this.txtErrDescription.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtErrDescription.ForeColor = Color.Blue;
      this.txtErrDescription.Location = new Point(96, 16);
      this.txtErrDescription.MaxLength = 100;
      this.txtErrDescription.Multiline = true;
      this.txtErrDescription.Name = "txtErrDescription";
      this.txtErrDescription.RightToLeft = RightToLeft.No;
      this.txtErrDescription.Size = new Size(313, 69);
      this.txtErrDescription.TabIndex = 10;
      this.ToolTip1.SetToolTip((Control) this.txtErrDescription, "Error Adjustment Description");
      this.txtErrAmount.AcceptsReturn = true;
      this.txtErrAmount.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.txtErrAmount.Cursor = Cursors.IBeam;
      this.txtErrAmount.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtErrAmount.ForeColor = Color.Red;
      this.txtErrAmount.Location = new Point(96, 96);
      this.txtErrAmount.MaxLength = 8;
      this.txtErrAmount.Name = "txtErrAmount";
      this.txtErrAmount.RightToLeft = RightToLeft.No;
      this.txtErrAmount.Size = new Size(89, 26);
      this.txtErrAmount.TabIndex = 11;
      this.ToolTip1.SetToolTip((Control) this.txtErrAmount, "Adjust Amount");
      this.txtErrAmount.KeyPress += new KeyPressEventHandler(this.txtErrAmount_KeyPress);
      this.cmdConfirm.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.cmdConfirm.Cursor = Cursors.Default;
      this.cmdConfirm.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdConfirm.ForeColor = SystemColors.ControlText;
      this.cmdConfirm.Image = (Image) componentResourceManager.GetObject("cmdConfirm.Image");
      this.cmdConfirm.Location = new Point(504, 296);
      this.cmdConfirm.Name = "cmdConfirm";
      this.cmdConfirm.RightToLeft = RightToLeft.No;
      this.cmdConfirm.Size = new Size(73, 57);
      this.cmdConfirm.TabIndex = 14;
      this.cmdConfirm.Text = "&Confirm";
      this.cmdConfirm.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdConfirm, "Confirm to Update Info");
      this.cmdConfirm.UseVisualStyleBackColor = false;
      this.cmdConfirm.Click += new EventHandler(this.cmdConfirm_Click);
      this.txtPaymentNoteNo.AcceptsReturn = true;
      this.txtPaymentNoteNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtPaymentNoteNo.Cursor = Cursors.IBeam;
      this.txtPaymentNoteNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPaymentNoteNo.ForeColor = Color.Blue;
      this.txtPaymentNoteNo.Location = new Point(216, 168);
      this.txtPaymentNoteNo.MaxLength = 0;
      this.txtPaymentNoteNo.Name = "txtPaymentNoteNo";
      this.txtPaymentNoteNo.ReadOnly = true;
      this.txtPaymentNoteNo.RightToLeft = RightToLeft.No;
      this.txtPaymentNoteNo.Size = new Size(65, 20);
      this.txtPaymentNoteNo.TabIndex = 54;
      this.txtPaymentNoteNo.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtPaymentNoteNo, "Last Payment");
      this.txtTransTime.AcceptsReturn = true;
      this.txtTransTime.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtTransTime.Cursor = Cursors.IBeam;
      this.txtTransTime.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTransTime.ForeColor = Color.Red;
      this.txtTransTime.Location = new Point(208, 256);
      this.txtTransTime.MaxLength = 0;
      this.txtTransTime.Name = "txtTransTime";
      this.txtTransTime.ReadOnly = true;
      this.txtTransTime.RightToLeft = RightToLeft.No;
      this.txtTransTime.Size = new Size(81, 20);
      this.txtTransTime.TabIndex = 58;
      this.txtTransTime.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtTransTime, "Balance Amount");
      this.txtBondErrDescription.AcceptsReturn = true;
      this.txtBondErrDescription.BackColor = Color.White;
      this.txtBondErrDescription.BorderStyle = BorderStyle.FixedSingle;
      this.txtBondErrDescription.Cursor = Cursors.IBeam;
      this.txtBondErrDescription.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBondErrDescription.ForeColor = Color.Blue;
      this.txtBondErrDescription.Location = new Point(96, 16);
      this.txtBondErrDescription.MaxLength = 100;
      this.txtBondErrDescription.Multiline = true;
      this.txtBondErrDescription.Name = "txtBondErrDescription";
      this.txtBondErrDescription.RightToLeft = RightToLeft.No;
      this.txtBondErrDescription.Size = new Size(313, 65);
      this.txtBondErrDescription.TabIndex = 12;
      this.ToolTip1.SetToolTip((Control) this.txtBondErrDescription, "Error Adjustment Description");
      this.txtBonusClaim.AcceptsReturn = true;
      this.txtBonusClaim.BackColor = Color.White;
      this.txtBonusClaim.Cursor = Cursors.IBeam;
      this.txtBonusClaim.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBonusClaim.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtBonusClaim.Location = new Point(120, 302);
      this.txtBonusClaim.MaxLength = 0;
      this.txtBonusClaim.Name = "txtBonusClaim";
      this.txtBonusClaim.ReadOnly = true;
      this.txtBonusClaim.RightToLeft = RightToLeft.No;
      this.txtBonusClaim.Size = new Size(81, 20);
      this.txtBonusClaim.TabIndex = 48;
      this.txtBonusClaim.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtBonusClaim, "Last Payment");
      this.txtTransType.AcceptsReturn = true;
      this.txtTransType.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.txtTransType.Cursor = Cursors.IBeam;
      this.txtTransType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTransType.ForeColor = Color.Blue;
      this.txtTransType.Location = new Point(208, 304);
      this.txtTransType.MaxLength = 0;
      this.txtTransType.Name = "txtTransType";
      this.txtTransType.ReadOnly = true;
      this.txtTransType.RightToLeft = RightToLeft.No;
      this.txtTransType.Size = new Size(81, 20);
      this.txtTransType.TabIndex = 47;
      this.txtTransType.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtTransType, "Card Number");
      this.txtBalance.AcceptsReturn = true;
      this.txtBalance.BackColor = Color.White;
      this.txtBalance.Cursor = Cursors.IBeam;
      this.txtBalance.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBalance.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtBalance.Location = new Point(120, 276);
      this.txtBalance.MaxLength = 0;
      this.txtBalance.Name = "txtBalance";
      this.txtBalance.ReadOnly = true;
      this.txtBalance.RightToLeft = RightToLeft.No;
      this.txtBalance.Size = new Size(81, 20);
      this.txtBalance.TabIndex = 45;
      this.txtBalance.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtBalance, "Balance Amount");
      this.txtGST.AcceptsReturn = true;
      this.txtGST.BackColor = Color.White;
      this.txtGST.Cursor = Cursors.IBeam;
      this.txtGST.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtGST.ForeColor = Color.Red;
      this.txtGST.Location = new Point(256, 328);
      this.txtGST.MaxLength = 0;
      this.txtGST.Name = "txtGST";
      this.txtGST.ReadOnly = true;
      this.txtGST.RightToLeft = RightToLeft.No;
      this.txtGST.Size = new Size(81, 20);
      this.txtGST.TabIndex = 43;
      this.txtGST.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtGST, "GST Amount");
      this.cmdPrint.BackColor = Color.Cyan;
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(333, 107);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(89, 41);
      this.cmdPrint.TabIndex = 27;
      this.cmdPrint.Text = "&Print ";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdPrint, "Confirm to Update Info");
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.txtCardNo.AcceptsReturn = true;
      this.txtCardNo.BackColor = Color.White;
      this.txtCardNo.Cursor = Cursors.IBeam;
      this.txtCardNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCardNo.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtCardNo.Location = new Point(216, 32);
      this.txtCardNo.MaxLength = 0;
      this.txtCardNo.Name = "txtCardNo";
      this.txtCardNo.ReadOnly = true;
      this.txtCardNo.RightToLeft = RightToLeft.No;
      this.txtCardNo.Size = new Size(57, 20);
      this.txtCardNo.TabIndex = 41;
      this.txtCardNo.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtCardNo, "Card Number");
      this.txtLastPayment.AcceptsReturn = true;
      this.txtLastPayment.BackColor = Color.White;
      this.txtLastPayment.Cursor = Cursors.IBeam;
      this.txtLastPayment.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtLastPayment.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtLastPayment.Location = new Point(120, 328);
      this.txtLastPayment.MaxLength = 0;
      this.txtLastPayment.Name = "txtLastPayment";
      this.txtLastPayment.ReadOnly = true;
      this.txtLastPayment.RightToLeft = RightToLeft.No;
      this.txtLastPayment.Size = new Size(81, 20);
      this.txtLastPayment.TabIndex = 39;
      this.txtLastPayment.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtLastPayment, "Last Payment");
      this.txtExtraCharge.AcceptsReturn = true;
      this.txtExtraCharge.BackColor = Color.White;
      this.txtExtraCharge.Cursor = Cursors.IBeam;
      this.txtExtraCharge.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtExtraCharge.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtExtraCharge.Location = new Point(120, 249);
      this.txtExtraCharge.MaxLength = 0;
      this.txtExtraCharge.Name = "txtExtraCharge";
      this.txtExtraCharge.ReadOnly = true;
      this.txtExtraCharge.RightToLeft = RightToLeft.No;
      this.txtExtraCharge.Size = new Size(81, 20);
      this.txtExtraCharge.TabIndex = 37;
      this.txtExtraCharge.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtExtraCharge, "Extra Charge Amount");
      this.txtBondErrAmount.AcceptsReturn = true;
      this.txtBondErrAmount.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.txtBondErrAmount.Cursor = Cursors.IBeam;
      this.txtBondErrAmount.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBondErrAmount.ForeColor = Color.Red;
      this.txtBondErrAmount.Location = new Point(96, 88);
      this.txtBondErrAmount.MaxLength = 8;
      this.txtBondErrAmount.Name = "txtBondErrAmount";
      this.txtBondErrAmount.RightToLeft = RightToLeft.No;
      this.txtBondErrAmount.Size = new Size(89, 26);
      this.txtBondErrAmount.TabIndex = 13;
      this.ToolTip1.SetToolTip((Control) this.txtBondErrAmount, "Adjust Amount");
      this.txtBondErrAmount.KeyPress += new KeyPressEventHandler(this.txtBondErrAmount_KeyPress);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(437, 107);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(89, 41);
      this.cmdReturn.TabIndex = 28;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "To Return Main Setting Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.txtRBA.AcceptsReturn = true;
      this.txtRBA.BackColor = Color.White;
      this.txtRBA.Cursor = Cursors.IBeam;
      this.txtRBA.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRBA.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtRBA.Location = new Point(120, 170);
      this.txtRBA.MaxLength = 0;
      this.txtRBA.Name = "txtRBA";
      this.txtRBA.ReadOnly = true;
      this.txtRBA.RightToLeft = RightToLeft.No;
      this.txtRBA.Size = new Size(81, 20);
      this.txtRBA.TabIndex = 34;
      this.txtRBA.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtRBA, "Refund Bond Authority");
      this.cmdView.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdView.Cursor = Cursors.Default;
      this.cmdView.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdView.ForeColor = SystemColors.ControlText;
      this.cmdView.Image = (Image) componentResourceManager.GetObject("cmdView.Image");
      this.cmdView.Location = new Point(221, 107);
      this.cmdView.Name = "cmdView";
      this.cmdView.RightToLeft = RightToLeft.No;
      this.cmdView.Size = new Size(89, 41);
      this.cmdView.TabIndex = 26;
      this.cmdView.Text = "&SEARCH";
      this.cmdView.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdView, "Click to View/Select Room");
      this.cmdView.UseVisualStyleBackColor = false;
      this.cmdView.Click += new EventHandler(this.cmdView_Click);
      this.cmdAdjust.BackColor = Color.FromArgb(0, 128, 0);
      this.cmdAdjust.Cursor = Cursors.Default;
      this.cmdAdjust.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdAdjust.ForeColor = SystemColors.ControlText;
      this.cmdAdjust.Image = (Image) componentResourceManager.GetObject("cmdAdjust.Image");
      this.cmdAdjust.Location = new Point(416, 296);
      this.cmdAdjust.Name = "cmdAdjust";
      this.cmdAdjust.RightToLeft = RightToLeft.No;
      this.cmdAdjust.Size = new Size(73, 57);
      this.cmdAdjust.TabIndex = 9;
      this.cmdAdjust.Text = "&Adjust";
      this.cmdAdjust.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdAdjust, "Click to Enable Edit");
      this.cmdAdjust.UseVisualStyleBackColor = false;
      this.cmdAdjust.Click += new EventHandler(this.cmdAdjust_Click);
      this.cmdClear.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Image = (Image) componentResourceManager.GetObject("cmdClear.Image");
      this.cmdClear.Location = new Point(592, 296);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(73, 57);
      this.cmdClear.TabIndex = 67;
      this.cmdClear.Text = "&Clear";
      this.cmdClear.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdClear, "Click to Clear Screen");
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.txtPreviousAdvance.AcceptsReturn = true;
      this.txtPreviousAdvance.BackColor = SystemColors.Window;
      this.txtPreviousAdvance.Cursor = Cursors.IBeam;
      this.txtPreviousAdvance.Enabled = false;
      this.txtPreviousAdvance.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPreviousAdvance.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtPreviousAdvance.Location = new Point(120, 196);
      this.txtPreviousAdvance.MaxLength = 0;
      this.txtPreviousAdvance.Name = "txtPreviousAdvance";
      this.txtPreviousAdvance.ReadOnly = true;
      this.txtPreviousAdvance.RightToLeft = RightToLeft.No;
      this.txtPreviousAdvance.Size = new Size(81, 20);
      this.txtPreviousAdvance.TabIndex = 27;
      this.txtPreviousAdvance.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtPreviousAdvance, "Previous Advanced Amount");
      this.txtKeyDeposit.AcceptsReturn = true;
      this.txtKeyDeposit.BackColor = Color.White;
      this.txtKeyDeposit.Cursor = Cursors.IBeam;
      this.txtKeyDeposit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtKeyDeposit.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtKeyDeposit.Location = new Point(120, 117);
      this.txtKeyDeposit.MaxLength = 0;
      this.txtKeyDeposit.Name = "txtKeyDeposit";
      this.txtKeyDeposit.ReadOnly = true;
      this.txtKeyDeposit.RightToLeft = RightToLeft.No;
      this.txtKeyDeposit.Size = new Size(81, 20);
      this.txtKeyDeposit.TabIndex = 26;
      this.txtKeyDeposit.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtKeyDeposit, "Key Deposit");
      this.txtRoomCharge.AcceptsReturn = true;
      this.txtRoomCharge.BackColor = SystemColors.Window;
      this.txtRoomCharge.Cursor = Cursors.IBeam;
      this.txtRoomCharge.Enabled = false;
      this.txtRoomCharge.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomCharge.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtRoomCharge.Location = new Point(120, 64);
      this.txtRoomCharge.MaxLength = 0;
      this.txtRoomCharge.Name = "txtRoomCharge";
      this.txtRoomCharge.ReadOnly = true;
      this.txtRoomCharge.RightToLeft = RightToLeft.No;
      this.txtRoomCharge.Size = new Size(81, 20);
      this.txtRoomCharge.TabIndex = 25;
      this.txtRoomCharge.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtRoomCharge, "Room charges for valid period.");
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = Color.White;
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Enabled = false;
      this.txtDeposit.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtDeposit.Location = new Point(120, 91);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.ReadOnly = true;
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(81, 20);
      this.txtDeposit.TabIndex = 24;
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtDeposit, "Deposit received from reservation.");
      this.txtBond.AcceptsReturn = true;
      this.txtBond.BackColor = Color.White;
      this.txtBond.Cursor = Cursors.IBeam;
      this.txtBond.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBond.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtBond.Location = new Point(120, 144);
      this.txtBond.MaxLength = 0;
      this.txtBond.Name = "txtBond";
      this.txtBond.ReadOnly = true;
      this.txtBond.RightToLeft = RightToLeft.No;
      this.txtBond.Size = new Size(81, 20);
      this.txtBond.TabIndex = 23;
      this.txtBond.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtBond, "Bond amount on contract.");
      this.txtAdvance.AcceptsReturn = true;
      this.txtAdvance.BackColor = SystemColors.Window;
      this.txtAdvance.Cursor = Cursors.IBeam;
      this.txtAdvance.Enabled = false;
      this.txtAdvance.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtAdvance.ForeColor = Color.FromArgb(64, 64, 64);
      this.txtAdvance.Location = new Point(120, 223);
      this.txtAdvance.MaxLength = 0;
      this.txtAdvance.Name = "txtAdvance";
      this.txtAdvance.ReadOnly = true;
      this.txtAdvance.RightToLeft = RightToLeft.No;
      this.txtAdvance.Size = new Size(81, 20);
      this.txtAdvance.TabIndex = 22;
      this.txtAdvance.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtAdvance, "Advanced Payment");
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = Color.White;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.Blue;
      this.txtClientID.Location = new Point(120, 32);
      this.txtClientID.MaxLength = 8;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.ReadOnly = true;
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(89, 26);
      this.txtClientID.TabIndex = 20;
      this.ToolTip1.SetToolTip((Control) this.txtClientID, "Guest ID");
      this.txtRoomNo.AcceptsReturn = true;
      this.txtRoomNo.BackColor = SystemColors.Window;
      this.txtRoomNo.Cursor = Cursors.IBeam;
      this.txtRoomNo.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.ForeColor = Color.Blue;
      this.txtRoomNo.Location = new Point(149, 123);
      this.txtRoomNo.MaxLength = 5;
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.RightToLeft = RightToLeft.No;
      this.txtRoomNo.Size = new Size(65, 22);
      this.txtRoomNo.TabIndex = 25;
      this.ToolTip1.SetToolTip((Control) this.txtRoomNo, "Room No");
      this.txtRoomNo.KeyPress += new KeyPressEventHandler(this.txtRoomNo_KeyPress);
      this.cboBuildingNo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.cboBuildingNo.Cursor = Cursors.Default;
      this.cboBuildingNo.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cboBuildingNo.ForeColor = Color.Blue;
      this.cboBuildingNo.Location = new Point(149, 91);
      this.cboBuildingNo.Name = "cboBuildingNo";
      this.cboBuildingNo.RightToLeft = RightToLeft.No;
      this.cboBuildingNo.Size = new Size(49, 26);
      this.cboBuildingNo.TabIndex = 24;
      this.ToolTip1.SetToolTip((Control) this.cboBuildingNo, "Select Building No.");
      this.Label6.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.Blue;
      this.Label6.Location = new Point(8, 88);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(81, 17);
      this.Label6.TabIndex = 63;
      this.Label6.Text = "Amount ";
      this.Label6.TextAlign = ContentAlignment.TopRight;
      this.Label9.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.Blue;
      this.Label9.Location = new Point(216, 16);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(57, 19);
      this.Label9.TabIndex = 42;
      this.Label9.Text = "Card No. ";
      this.Label20.BackColor = Color.Cyan;
      this.Label20.Cursor = Cursors.Default;
      this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label20.ForeColor = Color.Blue;
      this.Label20.Location = new Point(8, 96);
      this.Label20.Name = "Label20";
      this.Label20.RightToLeft = RightToLeft.No;
      this.Label20.Size = new Size(81, 17);
      this.Label20.TabIndex = 65;
      this.Label20.Text = "Amount ";
      this.Label20.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(8, 16);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(81, 49);
      this.Label5.TabIndex = 62;
      this.Label5.Text = "Error Description ";
      this.Label5.TextAlign = ContentAlignment.TopRight;
      this.Label8.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label8.Location = new Point(16, 328);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(97, 17);
      this.Label8.TabIndex = 40;
      this.Label8.Text = "Last Payment ";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      this.Label14.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label14.Cursor = Cursors.Default;
      this.Label14.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = Color.FromArgb(0, 192, 0);
      this.Label14.Location = new Point(61, 123);
      this.Label14.Name = "Label14";
      this.Label14.RightToLeft = RightToLeft.No;
      this.Label14.Size = new Size(73, 17);
      this.Label14.TabIndex = 30;
      this.Label14.Text = "Room No.";
      this.Label14.TextAlign = ContentAlignment.TopRight;
      this.Label7.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label7.Location = new Point(16, 254);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(97, 17);
      this.Label7.TabIndex = 38;
      this.Label7.Text = "Extra Charge";
      this.Label7.TextAlign = ContentAlignment.TopRight;
      this.Label16.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label16.Cursor = Cursors.Default;
      this.Label16.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = Color.FromArgb(0, 192, 0);
      this.Label16.Location = new Point(45, 91);
      this.Label16.Name = "Label16";
      this.Label16.RightToLeft = RightToLeft.No;
      this.Label16.Size = new Size(89, 25);
      this.Label16.TabIndex = 29;
      this.Label16.Text = "Building ";
      this.Label16.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Red;
      this.Label2.Location = new Point(5, 51);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(785, 25);
      this.Label2.TabIndex = 23;
      this.Label2.Text = "ERROR ADJUSTMENT RECORD ";
      this.Label2.TextAlign = ContentAlignment.TopCenter;
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Blue;
      this.Label1.Location = new Point(5, 3);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(785, 41);
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Admin Mode ";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label4.Location = new Point(16, 164);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(97, 17);
      this.Label4.TabIndex = 35;
      this.Label4.Text = "RBA ";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.lbPrevious.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.lbPrevious.Cursor = Cursors.Default;
      this.lbPrevious.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbPrevious.ForeColor = Color.FromArgb(64, 64, 64);
      this.lbPrevious.Location = new Point(16, 188);
      this.lbPrevious.Name = "lbPrevious";
      this.lbPrevious.RightToLeft = RightToLeft.No;
      this.lbPrevious.Size = new Size(97, 25);
      this.lbPrevious.TabIndex = 33;
      this.lbPrevious.Text = "Previous Advance";
      this.lbPrevious.TextAlign = ContentAlignment.TopRight;
      this.Label23.BackColor = Color.Cyan;
      this.Label23.Cursor = Cursors.Default;
      this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label23.ForeColor = Color.Red;
      this.Label23.Location = new Point(8, 16);
      this.Label23.Name = "Label23";
      this.Label23.RightToLeft = RightToLeft.No;
      this.Label23.Size = new Size(81, 49);
      this.Label23.TabIndex = 66;
      this.Label23.Text = "Error Description ";
      this.Label23.TextAlign = ContentAlignment.TopRight;
      this.lbExtraKeyCharge.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.lbExtraKeyCharge.Cursor = Cursors.Default;
      this.lbExtraKeyCharge.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbExtraKeyCharge.ForeColor = Color.FromArgb(64, 64, 64);
      this.lbExtraKeyCharge.Location = new Point(16, 114);
      this.lbExtraKeyCharge.Name = "lbExtraKeyCharge";
      this.lbExtraKeyCharge.RightToLeft = RightToLeft.No;
      this.lbExtraKeyCharge.Size = new Size(97, 17);
      this.lbExtraKeyCharge.TabIndex = 32;
      this.lbExtraKeyCharge.Text = "Key Deposit ";
      this.lbExtraKeyCharge.TextAlign = ContentAlignment.TopRight;
      this.Label26.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label26.Cursor = Cursors.Default;
      this.Label26.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label26.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label26.Location = new Point(16, 64);
      this.Label26.Name = "Label26";
      this.Label26.RightToLeft = RightToLeft.No;
      this.Label26.Size = new Size(97, 17);
      this.Label26.TabIndex = 31;
      this.Label26.Text = "Room Charge ";
      this.Label26.TextAlign = ContentAlignment.TopRight;
      this.Label15.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label15.Cursor = Cursors.Default;
      this.Label15.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label15.Location = new Point(16, 89);
      this.Label15.Name = "Label15";
      this.Label15.RightToLeft = RightToLeft.No;
      this.Label15.Size = new Size(97, 17);
      this.Label15.TabIndex = 30;
      this.Label15.Text = "Deposit ";
      this.Label15.TextAlign = ContentAlignment.TopRight;
      this.Label21.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label21.Cursor = Cursors.Default;
      this.Label21.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label21.Location = new Point(16, 139);
      this.Label21.Name = "Label21";
      this.Label21.RightToLeft = RightToLeft.No;
      this.Label21.Size = new Size(97, 17);
      this.Label21.TabIndex = 29;
      this.Label21.Text = "Bond Amount ";
      this.Label21.TextAlign = ContentAlignment.TopRight;
      this.Label22.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label22.Cursor = Cursors.Default;
      this.Label22.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label22.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label22.Location = new Point(16, 221);
      this.Label22.Name = "Label22";
      this.Label22.RightToLeft = RightToLeft.No;
      this.Label22.Size = new Size(97, 25);
      this.Label22.TabIndex = 28;
      this.Label22.Text = "Advanced Amount ";
      this.Label22.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label3.Location = new Point(16, 32);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(97, 17);
      this.Label3.TabIndex = 21;
      this.Label3.Text = "Guest ID ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.OthersFrame.BackColor = Color.Cyan;
      this.OthersFrame.Controls.Add((Control) this.txtErrDescription);
      this.OthersFrame.Controls.Add((Control) this.txtErrAmount);
      this.OthersFrame.Controls.Add((Control) this.Label23);
      this.OthersFrame.Controls.Add((Control) this.Label20);
      this.OthersFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.OthersFrame.ForeColor = SystemColors.ControlText;
      this.OthersFrame.Location = new Point(8, 8);
      this.OthersFrame.Name = "OthersFrame";
      this.OthersFrame.Padding = new Padding(0);
      this.OthersFrame.RightToLeft = RightToLeft.No;
      this.OthersFrame.Size = new Size(417, 129);
      this.OthersFrame.TabIndex = 64;
      this.OthersFrame.TabStop = false;
      this.OthersFrame.Text = "Others Adjustment :";
      this.AdjustFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.AdjustFrame.Controls.Add((Control) this.OthersFrame);
      this.AdjustFrame.Controls.Add((Control) this.BondFrame);
      this.AdjustFrame.Cursor = Cursors.Default;
      this.AdjustFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AdjustFrame.ForeColor = SystemColors.ControlText;
      this.AdjustFrame.Location = new Point(320, 16);
      this.AdjustFrame.Name = "AdjustFrame";
      this.AdjustFrame.RightToLeft = RightToLeft.No;
      this.AdjustFrame.Size = new Size(433, 273);
      this.AdjustFrame.TabIndex = 36;
      this.BondFrame.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.BondFrame.Controls.Add((Control) this.txtBondErrAmount);
      this.BondFrame.Controls.Add((Control) this.txtBondErrDescription);
      this.BondFrame.Controls.Add((Control) this.Label6);
      this.BondFrame.Controls.Add((Control) this.Label5);
      this.BondFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BondFrame.ForeColor = SystemColors.ControlText;
      this.BondFrame.Location = new Point(8, 144);
      this.BondFrame.Name = "BondFrame";
      this.BondFrame.Padding = new Padding(0);
      this.BondFrame.RightToLeft = RightToLeft.No;
      this.BondFrame.Size = new Size(417, 121);
      this.BondFrame.TabIndex = 61;
      this.BondFrame.TabStop = false;
      this.BondFrame.Text = "Bond Adjustment :";
      this.DataFrame.BackColor = SystemColors.Control;
      this.DataFrame.Controls.Add((Control) this.dataGridView_DTransaction);
      this.DataFrame.Controls.Add((Control) this.cmdOk);
      this.DataFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DataFrame.ForeColor = SystemColors.ControlText;
      this.DataFrame.Location = new Point(13, 155);
      this.DataFrame.Name = "DataFrame";
      this.DataFrame.Padding = new Padding(0);
      this.DataFrame.RightToLeft = RightToLeft.No;
      this.DataFrame.Size = new Size(777, 361);
      this.DataFrame.TabIndex = 31;
      this.DataFrame.TabStop = false;
      this.DataFrame.Text = "View All Transactions";
      this.dataGridView_DTransaction.AllowUserToAddRows = false;
      this.dataGridView_DTransaction.AllowUserToDeleteRows = false;
      this.dataGridView_DTransaction.AllowUserToResizeColumns = false;
      this.dataGridView_DTransaction.AllowUserToResizeRows = false;
      this.dataGridView_DTransaction.AutoGenerateColumns = false;
      this.dataGridView_DTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      this.dataGridView_DTransaction.CausesValidation = false;
      this.dataGridView_DTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_DTransaction.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.transIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.cardNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.previousAdvanceDataGridViewTextBoxColumn, (DataGridViewColumn) this.advancedPaymentDataGridViewTextBoxColumn, (DataGridViewColumn) this.bondDataGridViewTextBoxColumn, (DataGridViewColumn) this.rBADataGridViewTextBoxColumn, (DataGridViewColumn) this.keyDepositDataGridViewTextBoxColumn, (DataGridViewColumn) this.extraChargeDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomChargeDataGridViewTextBoxColumn, (DataGridViewColumn) this.bonusClaimDataGridViewTextBoxColumn, (DataGridViewColumn) this.lastPaymentDataGridViewTextBoxColumn, (DataGridViewColumn) this.transTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.transDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.transTimeDataGridViewTextBoxColumn, (DataGridViewColumn) this.validStartDataGridViewTextBoxColumn, (DataGridViewColumn) this.validEndDataGridViewTextBoxColumn, (DataGridViewColumn) this.checkInDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.checkInTimeDataGridViewTextBoxColumn, (DataGridViewColumn) this.checkOutTimeDataGridViewTextBoxColumn, (DataGridViewColumn) this.checkOutDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.chargeTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.gracePeriodDataGridViewTextBoxColumn, (DataGridViewColumn) this.gSTDataGridViewTextBoxColumn, (DataGridViewColumn) this.staffIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.cardTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.conditionDataGridViewTextBoxColumn, (DataGridViewColumn) this.reserveRefDataGridViewTextBoxColumn, (DataGridViewColumn) this.oldRoomDataGridViewTextBoxColumn, (DataGridViewColumn) this.balanceDataGridViewTextBoxColumn, (DataGridViewColumn) this.depositDataGridViewTextBoxColumn, (DataGridViewColumn) this.exDescriptionDataGridViewTextBoxColumn, (DataGridViewColumn) this.updateDataGridViewCheckBoxColumn);
      this.dataGridView_DTransaction.DataSource = (object) this.dTransactionsBindingSource;
      this.dataGridView_DTransaction.EnableHeadersVisualStyles = false;
      this.dataGridView_DTransaction.Location = new Point(8, 25);
      this.dataGridView_DTransaction.MultiSelect = false;
      this.dataGridView_DTransaction.Name = "dataGridView_DTransaction";
      this.dataGridView_DTransaction.ReadOnly = true;
      this.dataGridView_DTransaction.RowHeadersWidth = 30;
      this.dataGridView_DTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView_DTransaction.ShowCellToolTips = false;
      this.dataGridView_DTransaction.ShowEditingIcon = false;
      this.dataGridView_DTransaction.Size = new Size(761, 299);
      this.dataGridView_DTransaction.TabIndex = 19;
      this.dataGridView_DTransaction.TabStop = false;
      this.dataGridView_DTransaction.Visible = false;
      this.dataGridView_DTransaction.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_DTransaction_CellDoubleClick);
      this.dataGridView_DTransaction.KeyDown += new KeyEventHandler(this.dataGridView_DTransaction_KeyDown);
      this.dataGridView_DTransaction.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView_DTransaction_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room No";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn.Width = 81;
      this.transIDDataGridViewTextBoxColumn.DataPropertyName = "TransID";
      this.transIDDataGridViewTextBoxColumn.HeaderText = "Payment No ";
      this.transIDDataGridViewTextBoxColumn.Name = "transIDDataGridViewTextBoxColumn";
      this.transIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.HeaderText = "Guest ID";
      this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
      this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.clientIDDataGridViewTextBoxColumn.Width = 78;
      this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
      this.cardNoDataGridViewTextBoxColumn.HeaderText = "CardNo";
      this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
      this.cardNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.cardNoDataGridViewTextBoxColumn.Width = 72;
      this.previousAdvanceDataGridViewTextBoxColumn.DataPropertyName = "PreviousAdvance";
      this.previousAdvanceDataGridViewTextBoxColumn.HeaderText = "Prev.Advance";
      this.previousAdvanceDataGridViewTextBoxColumn.Name = "previousAdvanceDataGridViewTextBoxColumn";
      this.previousAdvanceDataGridViewTextBoxColumn.ReadOnly = true;
      this.previousAdvanceDataGridViewTextBoxColumn.Width = 106;
      this.advancedPaymentDataGridViewTextBoxColumn.DataPropertyName = "AdvancedPayment";
      this.advancedPaymentDataGridViewTextBoxColumn.HeaderText = "Advanced";
      this.advancedPaymentDataGridViewTextBoxColumn.Name = "advancedPaymentDataGridViewTextBoxColumn";
      this.advancedPaymentDataGridViewTextBoxColumn.ReadOnly = true;
      this.advancedPaymentDataGridViewTextBoxColumn.Width = 86;
      this.bondDataGridViewTextBoxColumn.DataPropertyName = "Bond";
      this.bondDataGridViewTextBoxColumn.HeaderText = "Bond";
      this.bondDataGridViewTextBoxColumn.Name = "bondDataGridViewTextBoxColumn";
      this.bondDataGridViewTextBoxColumn.ReadOnly = true;
      this.bondDataGridViewTextBoxColumn.Width = 60;
      this.rBADataGridViewTextBoxColumn.DataPropertyName = "RBA";
      this.rBADataGridViewTextBoxColumn.HeaderText = "RBA";
      this.rBADataGridViewTextBoxColumn.Name = "rBADataGridViewTextBoxColumn";
      this.rBADataGridViewTextBoxColumn.ReadOnly = true;
      this.rBADataGridViewTextBoxColumn.Width = 54;
      this.keyDepositDataGridViewTextBoxColumn.DataPropertyName = "KeyDeposit";
      this.keyDepositDataGridViewTextBoxColumn.HeaderText = "KeyDeposit";
      this.keyDepositDataGridViewTextBoxColumn.Name = "keyDepositDataGridViewTextBoxColumn";
      this.keyDepositDataGridViewTextBoxColumn.ReadOnly = true;
      this.keyDepositDataGridViewTextBoxColumn.Width = 94;
      this.extraChargeDataGridViewTextBoxColumn.DataPropertyName = "ExtraCharge";
      this.extraChargeDataGridViewTextBoxColumn.HeaderText = "ExtraCharge";
      this.extraChargeDataGridViewTextBoxColumn.Name = "extraChargeDataGridViewTextBoxColumn";
      this.extraChargeDataGridViewTextBoxColumn.ReadOnly = true;
      this.extraChargeDataGridViewTextBoxColumn.Width = 99;
      this.roomChargeDataGridViewTextBoxColumn.DataPropertyName = "RoomCharge";
      this.roomChargeDataGridViewTextBoxColumn.HeaderText = "RoomCharge";
      this.roomChargeDataGridViewTextBoxColumn.Name = "roomChargeDataGridViewTextBoxColumn";
      this.roomChargeDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomChargeDataGridViewTextBoxColumn.Width = 104;
      this.bonusClaimDataGridViewTextBoxColumn.DataPropertyName = "BonusClaim";
      this.bonusClaimDataGridViewTextBoxColumn.HeaderText = "BonusClaim";
      this.bonusClaimDataGridViewTextBoxColumn.Name = "bonusClaimDataGridViewTextBoxColumn";
      this.bonusClaimDataGridViewTextBoxColumn.ReadOnly = true;
      this.bonusClaimDataGridViewTextBoxColumn.Width = 98;
      this.lastPaymentDataGridViewTextBoxColumn.DataPropertyName = "LastPayment";
      this.lastPaymentDataGridViewTextBoxColumn.HeaderText = "LastPayment";
      this.lastPaymentDataGridViewTextBoxColumn.Name = "lastPaymentDataGridViewTextBoxColumn";
      this.lastPaymentDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastPaymentDataGridViewTextBoxColumn.Width = 104;
      this.transTypeDataGridViewTextBoxColumn.DataPropertyName = "TransType";
      this.transTypeDataGridViewTextBoxColumn.HeaderText = "TransType";
      this.transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
      this.transTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.transTypeDataGridViewTextBoxColumn.Width = 89;
      this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
      this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
      this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
      this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.transDateDataGridViewTextBoxColumn.Width = 87;
      this.transTimeDataGridViewTextBoxColumn.DataPropertyName = "TransTime";
      this.transTimeDataGridViewTextBoxColumn.HeaderText = "TransTime";
      this.transTimeDataGridViewTextBoxColumn.Name = "transTimeDataGridViewTextBoxColumn";
      this.transTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.transTimeDataGridViewTextBoxColumn.Width = 91;
      this.validStartDataGridViewTextBoxColumn.DataPropertyName = "ValidStart";
      this.validStartDataGridViewTextBoxColumn.HeaderText = "ValidStart";
      this.validStartDataGridViewTextBoxColumn.Name = "validStartDataGridViewTextBoxColumn";
      this.validStartDataGridViewTextBoxColumn.ReadOnly = true;
      this.validStartDataGridViewTextBoxColumn.Width = 84;
      this.validEndDataGridViewTextBoxColumn.DataPropertyName = "ValidEnd";
      this.validEndDataGridViewTextBoxColumn.HeaderText = "ValidEnd";
      this.validEndDataGridViewTextBoxColumn.Name = "validEndDataGridViewTextBoxColumn";
      this.validEndDataGridViewTextBoxColumn.ReadOnly = true;
      this.validEndDataGridViewTextBoxColumn.Width = 78;
      this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
      this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckIn";
      this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
      this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.checkInDateDataGridViewTextBoxColumn.Width = 77;
      this.checkInTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckInTime";
      this.checkInTimeDataGridViewTextBoxColumn.HeaderText = "CheckInTime";
      this.checkInTimeDataGridViewTextBoxColumn.Name = "checkInTimeDataGridViewTextBoxColumn";
      this.checkInTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.checkInTimeDataGridViewTextBoxColumn.Width = 105;
      this.checkOutTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckOutTime";
      this.checkOutTimeDataGridViewTextBoxColumn.HeaderText = "CheckOutTime";
      this.checkOutTimeDataGridViewTextBoxColumn.Name = "checkOutTimeDataGridViewTextBoxColumn";
      this.checkOutTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.checkOutTimeDataGridViewTextBoxColumn.Width = 114;
      this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
      this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOut";
      this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
      this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.checkOutDateDataGridViewTextBoxColumn.Width = 86;
      this.chargeTypeDataGridViewTextBoxColumn.DataPropertyName = "ChargeType";
      this.chargeTypeDataGridViewTextBoxColumn.HeaderText = "Pay Type";
      this.chargeTypeDataGridViewTextBoxColumn.Name = "chargeTypeDataGridViewTextBoxColumn";
      this.chargeTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.chargeTypeDataGridViewTextBoxColumn.Width = 80;
      this.gracePeriodDataGridViewTextBoxColumn.DataPropertyName = "GracePeriod";
      this.gracePeriodDataGridViewTextBoxColumn.HeaderText = "GracePeriod";
      this.gracePeriodDataGridViewTextBoxColumn.Name = "gracePeriodDataGridViewTextBoxColumn";
      this.gracePeriodDataGridViewTextBoxColumn.ReadOnly = true;
      this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
      this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
      this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
      this.gSTDataGridViewTextBoxColumn.ReadOnly = true;
      this.gSTDataGridViewTextBoxColumn.Width = 54;
      this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
      this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.staffIDDataGridViewTextBoxColumn.Width = 67;
      this.cardTypeDataGridViewTextBoxColumn.DataPropertyName = "CardType";
      this.cardTypeDataGridViewTextBoxColumn.HeaderText = "CardType";
      this.cardTypeDataGridViewTextBoxColumn.Name = "cardTypeDataGridViewTextBoxColumn";
      this.cardTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.cardTypeDataGridViewTextBoxColumn.Visible = false;
      this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
      this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
      this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
      this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
      this.conditionDataGridViewTextBoxColumn.Visible = false;
      this.reserveRefDataGridViewTextBoxColumn.DataPropertyName = "ReserveRef";
      this.reserveRefDataGridViewTextBoxColumn.HeaderText = "ReserveRef";
      this.reserveRefDataGridViewTextBoxColumn.Name = "reserveRefDataGridViewTextBoxColumn";
      this.reserveRefDataGridViewTextBoxColumn.ReadOnly = true;
      this.reserveRefDataGridViewTextBoxColumn.Visible = false;
      this.oldRoomDataGridViewTextBoxColumn.DataPropertyName = "OldRoom";
      this.oldRoomDataGridViewTextBoxColumn.HeaderText = "OldRoom";
      this.oldRoomDataGridViewTextBoxColumn.Name = "oldRoomDataGridViewTextBoxColumn";
      this.oldRoomDataGridViewTextBoxColumn.ReadOnly = true;
      this.oldRoomDataGridViewTextBoxColumn.Visible = false;
      this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
      this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
      this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
      this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
      this.balanceDataGridViewTextBoxColumn.Visible = false;
      this.depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
      this.depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
      this.depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
      this.depositDataGridViewTextBoxColumn.ReadOnly = true;
      this.depositDataGridViewTextBoxColumn.Visible = false;
      this.exDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExDescription";
      this.exDescriptionDataGridViewTextBoxColumn.HeaderText = "ExDescription";
      this.exDescriptionDataGridViewTextBoxColumn.Name = "exDescriptionDataGridViewTextBoxColumn";
      this.exDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
      this.exDescriptionDataGridViewTextBoxColumn.Visible = false;
      this.updateDataGridViewCheckBoxColumn.DataPropertyName = "Update";
      this.updateDataGridViewCheckBoxColumn.HeaderText = "Update";
      this.updateDataGridViewCheckBoxColumn.Name = "updateDataGridViewCheckBoxColumn";
      this.updateDataGridViewCheckBoxColumn.ReadOnly = true;
      this.updateDataGridViewCheckBoxColumn.Visible = false;
      this.dTransactionsBindingSource.DataMember = "DTransactions";
      this.dTransactionsBindingSource.DataSource = (object) this.tempDataSet;
      this.tempDataSet.DataSetName = "TempDataSet";
      this.tempDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.cmdOk.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdOk.Cursor = Cursors.Default;
      this.cmdOk.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdOk.ForeColor = SystemColors.ControlText;
      this.cmdOk.Location = new Point(679, 328);
      this.cmdOk.Name = "cmdOk";
      this.cmdOk.RightToLeft = RightToLeft.No;
      this.cmdOk.Size = new Size(91, 29);
      this.cmdOk.TabIndex = 18;
      this.cmdOk.Text = "&OK";
      this.cmdOk.UseVisualStyleBackColor = false;
      this.cmdOk.Click += new EventHandler(this.cmdOk_Click);
      this.DetailFrame.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.DetailFrame.Controls.Add((Control) this.cmdConfirm);
      this.DetailFrame.Controls.Add((Control) this.txtTransTime);
      this.DetailFrame.Controls.Add((Control) this.txtPaymentNoteNo);
      this.DetailFrame.Controls.Add((Control) this.txtBonusClaim);
      this.DetailFrame.Controls.Add((Control) this.txtTransType);
      this.DetailFrame.Controls.Add((Control) this.txtBalance);
      this.DetailFrame.Controls.Add((Control) this.txtGST);
      this.DetailFrame.Controls.Add((Control) this.txtCardNo);
      this.DetailFrame.Controls.Add((Control) this.txtLastPayment);
      this.DetailFrame.Controls.Add((Control) this.txtExtraCharge);
      this.DetailFrame.Controls.Add((Control) this.AdjustFrame);
      this.DetailFrame.Controls.Add((Control) this.cmdAdjust);
      this.DetailFrame.Controls.Add((Control) this.cmdClear);
      this.DetailFrame.Controls.Add((Control) this.txtRBA);
      this.DetailFrame.Controls.Add((Control) this.txtPreviousAdvance);
      this.DetailFrame.Controls.Add((Control) this.txtKeyDeposit);
      this.DetailFrame.Controls.Add((Control) this.txtRoomCharge);
      this.DetailFrame.Controls.Add((Control) this.txtDeposit);
      this.DetailFrame.Controls.Add((Control) this.txtBond);
      this.DetailFrame.Controls.Add((Control) this.txtAdvance);
      this.DetailFrame.Controls.Add((Control) this.txtClientID);
      this.DetailFrame.Controls.Add((Control) this.mskValidStart);
      this.DetailFrame.Controls.Add((Control) this.mskValidEnd);
      this.DetailFrame.Controls.Add((Control) this.mskTransDate);
      this.DetailFrame.Controls.Add((Control) this.Label19);
      this.DetailFrame.Controls.Add((Control) this.Label18);
      this.DetailFrame.Controls.Add((Control) this.Label17);
      this.DetailFrame.Controls.Add((Control) this.Label13);
      this.DetailFrame.Controls.Add((Control) this.Label24);
      this.DetailFrame.Controls.Add((Control) this.Label25);
      this.DetailFrame.Controls.Add((Control) this.Label12);
      this.DetailFrame.Controls.Add((Control) this.Label11);
      this.DetailFrame.Controls.Add((Control) this.Label10);
      this.DetailFrame.Controls.Add((Control) this.Label9);
      this.DetailFrame.Controls.Add((Control) this.Label8);
      this.DetailFrame.Controls.Add((Control) this.Label7);
      this.DetailFrame.Controls.Add((Control) this.Label4);
      this.DetailFrame.Controls.Add((Control) this.lbPrevious);
      this.DetailFrame.Controls.Add((Control) this.lbExtraKeyCharge);
      this.DetailFrame.Controls.Add((Control) this.Label26);
      this.DetailFrame.Controls.Add((Control) this.Label15);
      this.DetailFrame.Controls.Add((Control) this.Label21);
      this.DetailFrame.Controls.Add((Control) this.Label22);
      this.DetailFrame.Controls.Add((Control) this.Label3);
      this.DetailFrame.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.DetailFrame.ForeColor = SystemColors.ControlText;
      this.DetailFrame.Location = new Point(21, 155);
      this.DetailFrame.Name = "DetailFrame";
      this.DetailFrame.Padding = new Padding(0);
      this.DetailFrame.RightToLeft = RightToLeft.No;
      this.DetailFrame.Size = new Size(761, 361);
      this.DetailFrame.TabIndex = 32;
      this.DetailFrame.TabStop = false;
      this.DetailFrame.Text = "Transaction Detail...";
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(5, 515);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(785, 25);
      this.lblMessage.TabIndex = 21;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.dTransactionsTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.ClientSize = new Size(795, 584);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cmdView);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.txtRoomNo);
      this.Controls.Add((Control) this.cboBuildingNo);
      this.Controls.Add((Control) this.DetailFrame);
      this.Controls.Add((Control) this.DataFrame);
      this.Name = "Form_EditDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_EditDMS_Load);
      this.VisibleChanged += new EventHandler(this.Form_EditDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_EditDMS_FormClosing);
      this.OthersFrame.ResumeLayout(false);
      this.OthersFrame.PerformLayout();
      this.AdjustFrame.ResumeLayout(false);
      this.BondFrame.ResumeLayout(false);
      this.BondFrame.PerformLayout();
      this.DataFrame.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_DTransaction).EndInit();
      ((ISupportInitialize) this.dTransactionsBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.DetailFrame.ResumeLayout(false);
      this.DetailFrame.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form_EditDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_EditDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_EditDMS_Load(object sender, EventArgs e)
    {
      this.CheckBuilding();
      this.AdjustFrame.Visible = false;
    }

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

    private void cmdView_Click(object sender, EventArgs e)
    {
      this.DataFrame.Visible = true;
      this.dataGridView_DTransaction.Visible = true;
      this.DetailFrame.Visible = false;
      this.db.Local_Command.CommandText = "Delete * from DTransactions";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Connection;
      this.db.Local_Command.Connection.Open();
      this.db.Local_Command.ExecuteNonQuery();
      this.db.Local_Command.Connection.Close();
      this.db.Local_Command.CommandText = "";
      if (this.Temp_MDB_SaveFlag)
        this.db.Local_Command.CommandText = "Insert into DTransactions  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
      OleDbCommand localCommand = this.db.Local_Command;
      localCommand.CommandText = localCommand.CommandText + "SELECT * FROM CardTrans in '" + Application.UserAppDataPath + "\\BuildingDB" + (string) this.cboBuildingNo.SelectedItem + ".mdb 'Where ((Right(ClientID,4)>'5000'))ORDER BY RoomNo";
      this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.Clear();
      this.db.local_adaptor.SelectCommand = this.db.Local_Command;
      this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      if (this.Temp_MDB_SaveFlag)
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
      this.dTransactionsBindingSource.DataSource = (object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet;
      this.dataGridView_DTransaction.Focus();
      this.selected_rowindex = 0;
    }

    private void cmdOk_Click(object sender, EventArgs e)
    {
      this.dataGridView_DTransaction.Visible = false;
      this.DetailFrame.Visible = true;
      this.Process_Selected_Row();
    }

    private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r')
      {
        if (this.txtRoomNo.Text.Length != 5)
          return;
        this.db.Local_Command.CommandText = "Delete * from DTransactions";
        this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Connection;
        this.db.Local_Command.Connection.Open();
        this.db.Local_Command.ExecuteNonQuery();
        this.db.Local_Command.Connection.Close();
        this.db.Local_Command.CommandText = "";
        if (this.Temp_MDB_SaveFlag)
          this.db.Local_Command.CommandText = "Insert into DTransactions  in'" + Application.UserAppDataPath + "\\Temp.mdb'";
        OleDbCommand localCommand = this.db.Local_Command;
        localCommand.CommandText = localCommand.CommandText + "SELECT * FROM CardTrans in '" + Application.UserAppDataPath + "\\BuildingDB" + (string) this.cboBuildingNo.SelectedItem + ".mdb 'Where CardTrans.RoomNo='" + this.txtRoomNo.Text + "'ORDER BY TransID";
        this.db.Local_Command.Connection = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.clientAccTableAdapter.Connection;
        ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions.Clear();
        this.db.local_adaptor.SelectCommand = this.db.Local_Command;
        this.db.local_adaptor.Fill((DataTable) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
        if (this.Temp_MDB_SaveFlag)
          ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.dTransactionsTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.DTransactions);
        this.dTransactionsBindingSource.DataSource = (object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet;
        this.dataGridView_DTransaction.Focus();
        this.dataGridView_DTransaction.Select();
        this.selected_rowindex = 0;
        this.DataFrame.Visible = true;
        this.dataGridView_DTransaction.Visible = true;
        this.DetailFrame.Visible = false;
      }
      else
      {
        if (!char.IsLetter(e.KeyChar))
          return;
        e.Handled = true;
      }
    }

    private void dataGridView_DTransaction_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      this.Process_Selected_Row();
      this.DetailFrame.Visible = true;
    }

    private void dataGridView_DTransaction_CellDoubleClick(
      object sender,
      DataGridViewCellEventArgs e)
    {
      this.Process_Selected_Row();
      this.DetailFrame.Visible = true;
    }

    private void Process_Selected_Row()
    {
      TempDataSet.DTransactionsRow dtransactionsRow = (TempDataSet.DTransactionsRow) null;
      foreach (TempDataSet.DTransactionsRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.DTransactions.Rows)
      {
        if (row.TransID == (int) this.dataGridView_DTransaction.Rows[this.selected_rowindex].Cells[this.transIDDataGridViewTextBoxColumn.Name].Value)
        {
          dtransactionsRow = row;
          break;
        }
      }
      if (dtransactionsRow == null)
        return;
      try
      {
        this.txtPaymentNoteNo.Text = dtransactionsRow.TransID.ToString();
      }
      catch
      {
        this.txtPaymentNoteNo.Text = "";
      }
      try
      {
        this.txtCardNo.Text = dtransactionsRow.CardNo;
      }
      catch
      {
        this.txtCardNo.Text = "";
      }
      try
      {
        this.txtRoomCharge.Text = dtransactionsRow.RoomCharge.ToString("F2");
      }
      catch
      {
        this.txtRoomCharge.Text = "0.00";
      }
      try
      {
        this.txtExtraCharge.Text = dtransactionsRow.ExtraCharge.ToString("F2");
      }
      catch
      {
        this.txtExtraCharge.Text = "0.00";
      }
      try
      {
        this.txtBond.Text = dtransactionsRow.Bond.ToString("F2");
      }
      catch
      {
        this.txtBond.Text = "0.00";
      }
      try
      {
        this.txtAdvance.Text = dtransactionsRow.AdvancedPayment.ToString("F2");
      }
      catch
      {
        this.txtAdvance.Text = "0.00";
      }
      try
      {
        this.txtPreviousAdvance.Text = dtransactionsRow.PreviousAdvance.ToString("F2");
      }
      catch
      {
        this.txtPreviousAdvance.Text = "0.00";
      }
      try
      {
        this.txtBalance.Text = dtransactionsRow.Balance.ToString("F2");
      }
      catch
      {
        this.txtBalance.Text = "0.00";
      }
      try
      {
        this.txtRBA.Text = dtransactionsRow.RBA.ToString("F2");
      }
      catch
      {
        this.txtRBA.Text = "0.00";
      }
      try
      {
        this.txtDeposit.Text = dtransactionsRow.Deposit.ToString("F2");
      }
      catch
      {
        this.txtDeposit.Text = "0.00";
      }
      try
      {
        this.txtTransType.Text = dtransactionsRow.TransType;
      }
      catch
      {
        this.txtTransType.Text = "";
      }
      try
      {
        this.txtKeyDeposit.Text = dtransactionsRow.KeyDeposit.ToString("F2");
      }
      catch
      {
        this.txtKeyDeposit.Text = "0.00";
      }
      try
      {
        this.txtGST.Text = dtransactionsRow.GST.ToString("F2");
      }
      catch
      {
        this.txtGST.Text = "0.00";
      }
      try
      {
        this.txtLastPayment.Text = dtransactionsRow.LastPayment.ToString("F2");
      }
      catch
      {
        this.txtLastPayment.Text = "0.00";
      }
      try
      {
        this.txtBonusClaim.Text = dtransactionsRow.BonusClaim.ToString("F2");
      }
      catch
      {
        this.txtBonusClaim.Text = "0.00";
      }
      try
      {
        this.mskValidStart.Text = dtransactionsRow.ValidStart.ToShortDateString();
      }
      catch
      {
        this.mskValidStart.Text = "";
      }
      try
      {
        this.mskValidEnd.Text = dtransactionsRow.ValidEnd.ToShortDateString();
      }
      catch
      {
        this.mskValidEnd.Text = "";
      }
      try
      {
        this.mskTransDate.Text = dtransactionsRow.TransDate.ToShortDateString();
      }
      catch
      {
        this.mskTransDate.Text = "";
      }
      try
      {
        this.txtTransTime.Text = dtransactionsRow.TransTime;
      }
      catch
      {
        this.txtTransTime.Text = "";
      }
      try
      {
        this.txtClientID.Text = dtransactionsRow.ClientID;
      }
      catch
      {
        this.txtClientID.Text = "";
      }
      try
      {
        this.txtRoomNo.Text = dtransactionsRow.RoomNo;
      }
      catch
      {
        this.txtRoomNo.Text = "";
      }
      this.DataFrame.Visible = false;
      this.cmdAdjust.Enabled = true;
      this.cmdConfirm.Enabled = false;
      this.cmdAdjust.Focus();
    }

    private void dataGridView_DTransaction_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.temp_DB.tempDataSet.DTransactions.Rows.Count || this.dataGridView_DTransaction.Rows.Count != this.db.temp_DB.tempDataSet.DTransactions.Rows.Count)
        return;
      this.selected_rowindex = e.Row.Index;
    }

    private void Form_EditDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.DataFrame.Visible = false;
      this.DetailFrame.Visible = false;
      this.AdjustFrame.Visible = false;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      this.DetailFrame.Visible = false;
      this.AdjustFrame.Visible = false;
      this.DataFrame.Visible = false;
      this.txtRoomNo.Text = "";
      this.txtRoomNo.Focus();
      this.lblMessage.Text = "";
    }

    private void cmdAdjust_Click(object sender, EventArgs e)
    {
      this.AdjustFrame.Visible = true;
      this.ClearAdjustScreen();
      this.cmdConfirm.Enabled = true;
      this.cmdAdjust.Enabled = false;
      this.txtErrDescription.Focus();
    }

    private void ClearAdjustScreen()
    {
      this.txtErrDescription.Text = "";
      this.txtErrAmount.Text = "";
      this.txtBondErrDescription.Text = "";
      this.txtBondErrAmount.Text = "";
    }

    private void cmdConfirm_Click(object sender, EventArgs e)
    {
      if ((this.txtErrAmount.Text == "" || this.txtBondErrAmount.Text == "") && DialogResult.No == MessageBox.Show(" Make sure All Entries are Correct..", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Hand))
        return;
      this.db.erradjustDB.erradjustTableAdapter.Fill(this.db.erradjustDB.erradjustDBDataSet.Erradjust);
      ErradjustDBDataSet.ErradjustRow row = this.db.erradjustDB.erradjustDBDataSet.Erradjust.NewErradjustRow();
      row.PaymentNoteNo = Convert.ToInt32(this.txtPaymentNoteNo.Text);
      row.RoomNo = this.txtRoomNo.Text;
      try
      {
        row.ErrDescription = this.txtErrDescription.Text;
      }
      catch
      {
      }
      try
      {
        row.ErrAmount = Convert.ToDecimal(this.txtErrAmount.Text);
      }
      catch
      {
      }
      try
      {
        row.BondErrDescription = this.txtBondErrDescription.Text;
      }
      catch
      {
      }
      try
      {
        row.BondErrAmount = Convert.ToDecimal(this.txtBondErrAmount.Text);
      }
      catch
      {
      }
      row.TransType = this.txtTransType.Text;
      try
      {
        row.TransDate = DateTime.Parse(this.mskTransDate.Text).Date;
      }
      catch
      {
      }
      row.TransTime = this.txtTransTime.Text;
      row.CurrDate = DateTime.Now.Date;
      row.CurrTime = DateTime.Now.ToLongTimeString();
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.db.erradjustDB.erradjustDBDataSet.Erradjust.AddErradjustRow(row);
      if (this.db.erradjustDB.erradjustTableAdapter.Update(this.db.erradjustDB.erradjustDBDataSet.Erradjust) > 0)
        this.lblMessage.Text = "Record Adjustment Updated..";
      this.cmdAdjust.Enabled = false;
      this.AdjustFrame.Visible = false;
      this.cmdConfirm.Enabled = false;
    }

    private void txtErrAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void txtBondErrAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 10;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }
  }
}
