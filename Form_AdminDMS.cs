// Decompiled with JetBrains decompiler
// Type: AMS.Form_AdminDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_AdminDMS : Form
  {
    private IContainer components;
    public Button cmdExtraReport;
    public Button cmdReturn;
    public Button cmdEdit;
    public Button cmdOwnerReport;
    public ToolStripMenuItem mnuLogInOut;
    public Button cmdCheckOutReport;
    public Button cmdBonusReport;
    public Button cmdBankingInfo;
    public Button cmdAdminTransRpt;
    public Button cmdSalesRpt;
    public Button cmdTransactionRpt;
    public Button cmdICHistory;
    public Button cmdStaffDetail;
    public ToolStripMenuItem mnuSYearly;
    public Button cmdBackup;
    public Button cmdIssueCard;
    public Button cmdReadCard;
    public Button cmdCancelCard;
    public Button cmdUpload;
    public Button cmdChangePassword;
    public Button cmdLogInOut;
    public Label Label1;
    public ToolStripMenuItem mnuSMonthly;
    public ToolStripMenuItem mnuSDaily;
    public ToolStripMenuItem mnuUpload;
    public ToolStripMenuItem mnuAdmin;
    public ToolStripMenuItem mnuRestore;
    public ToolStripMenuItem mnuStaff;
    public ToolStripMenuItem mnuChangePassword;
    public ToolStripMenuItem mnuCancelCard;
    public ToolStripMenuItem mnuIssueCard;
    public ToolTip ToolTip1;
    public MenuStrip MainMenu1;
    public ToolStripMenuItem mnuManagement;
    public ToolStripMenuItem mnuReadCard;
    public ToolStripMenuItem mnuGenerate;
    public ToolStripMenuItem mnuTransaction;
    public ToolStripMenuItem mnuGuestTrans;
    public ToolStripMenuItem mnuDate;
    public ToolStripMenuItem mnuMonth;
    public ToolStripMenuItem mnuGYear;
    public ToolStripMenuItem mnuAdminCards;
    public ToolStripMenuItem mnuADaily;
    public ToolStripMenuItem mnuAMonthly;
    public ToolStripMenuItem mnuAYearly;
    public ToolStripMenuItem mnuSales;
    public Label Label_BuildigName;
    private Panel panel_CommStatus;
    public PictureBox pictureBox_COMM_Color;
    private Label label_CommState;
    public Button cmdReplacementReport;
    private DB db;
        private TextBox textBox1;
        private Form_TransactionReportDMS Form_TransactionReportDMS_Ptr;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.cmdExtraReport = new System.Windows.Forms.Button();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdOwnerReport = new System.Windows.Forms.Button();
            this.mnuLogInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCheckOutReport = new System.Windows.Forms.Button();
            this.cmdBonusReport = new System.Windows.Forms.Button();
            this.cmdBankingInfo = new System.Windows.Forms.Button();
            this.cmdAdminTransRpt = new System.Windows.Forms.Button();
            this.cmdSalesRpt = new System.Windows.Forms.Button();
            this.cmdTransactionRpt = new System.Windows.Forms.Button();
            this.cmdICHistory = new System.Windows.Forms.Button();
            this.cmdStaffDetail = new System.Windows.Forms.Button();
            this.mnuSYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdBackup = new System.Windows.Forms.Button();
            this.cmdIssueCard = new System.Windows.Forms.Button();
            this.cmdReadCard = new System.Windows.Forms.Button();
            this.cmdCancelCard = new System.Windows.Forms.Button();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.cmdLogInOut = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.mnuSMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIssueCard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReadCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuestTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdminCards = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuADaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_BuildigName = new System.Windows.Forms.Label();
            this.panel_CommStatus = new System.Windows.Forms.Panel();
            this.pictureBox_COMM_Color = new System.Windows.Forms.PictureBox();
            this.label_CommState = new System.Windows.Forms.Label();
            this.cmdReplacementReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenu1.SuspendLayout();
            this.panel_CommStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExtraReport
            // 
            this.cmdExtraReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdExtraReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExtraReport.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExtraReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExtraReport.Location = new System.Drawing.Point(399, 212);
            this.cmdExtraReport.Name = "cmdExtraReport";
            this.cmdExtraReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExtraReport.Size = new System.Drawing.Size(177, 73);
            this.cmdExtraReport.TabIndex = 40;
            this.cmdExtraReport.Text = "E&xtra Charges Report";
            this.cmdExtraReport.UseVisualStyleBackColor = false;
            this.cmdExtraReport.Visible = false;
            this.cmdExtraReport.Click += new System.EventHandler(this.cmdExtraReport_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(487, 480);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(181, 73);
            this.cmdReturn.TabIndex = 39;
            this.cmdReturn.Text = "← Return";
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEdit.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdEdit.Location = new System.Drawing.Point(399, 292);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEdit.Size = new System.Drawing.Size(177, 73);
            this.cmdEdit.TabIndex = 38;
            this.cmdEdit.Text = "&Error Adjustment ";
            this.cmdEdit.UseVisualStyleBackColor = false;
            this.cmdEdit.Visible = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdOwnerReport
            // 
            this.cmdOwnerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdOwnerReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOwnerReport.Enabled = false;
            this.cmdOwnerReport.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOwnerReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOwnerReport.Location = new System.Drawing.Point(195, 534);
            this.cmdOwnerReport.Name = "cmdOwnerReport";
            this.cmdOwnerReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOwnerReport.Size = new System.Drawing.Size(16, 17);
            this.cmdOwnerReport.TabIndex = 37;
            this.cmdOwnerReport.Text = "&Owner Transactions Report";
            this.cmdOwnerReport.UseVisualStyleBackColor = false;
            this.cmdOwnerReport.Visible = false;
            // 
            // mnuLogInOut
            // 
            this.mnuLogInOut.Name = "mnuLogInOut";
            this.mnuLogInOut.Size = new System.Drawing.Size(167, 22);
            this.mnuLogInOut.Text = "LogInOut Detail";
            // 
            // cmdCheckOutReport
            // 
            this.cmdCheckOutReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCheckOutReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCheckOutReport.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheckOutReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCheckOutReport.Location = new System.Drawing.Point(206, 371);
            this.cmdCheckOutReport.Name = "cmdCheckOutReport";
            this.cmdCheckOutReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCheckOutReport.Size = new System.Drawing.Size(177, 73);
            this.cmdCheckOutReport.TabIndex = 43;
            this.cmdCheckOutReport.Text = "Check &Out Report ";
            this.cmdCheckOutReport.UseVisualStyleBackColor = false;
            this.cmdCheckOutReport.Visible = false;
            this.cmdCheckOutReport.Click += new System.EventHandler(this.cmdCheckOutReport_Click);
            // 
            // cmdBonusReport
            // 
            this.cmdBonusReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBonusReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBonusReport.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBonusReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBonusReport.Location = new System.Drawing.Point(376, 531);
            this.cmdBonusReport.Name = "cmdBonusReport";
            this.cmdBonusReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBonusReport.Size = new System.Drawing.Size(18, 22);
            this.cmdBonusReport.TabIndex = 42;
            this.cmdBonusReport.Text = "&Bonus Claimed Report";
            this.cmdBonusReport.UseVisualStyleBackColor = false;
            this.cmdBonusReport.Visible = false;
            this.cmdBonusReport.Click += new System.EventHandler(this.cmdBonusReport_Click);
            // 
            // cmdBankingInfo
            // 
            this.cmdBankingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdBankingInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBankingInfo.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBankingInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBankingInfo.Location = new System.Drawing.Point(399, 372);
            this.cmdBankingInfo.Name = "cmdBankingInfo";
            this.cmdBankingInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBankingInfo.Size = new System.Drawing.Size(177, 72);
            this.cmdBankingInfo.TabIndex = 41;
            this.cmdBankingInfo.Text = "&Banking Information";
            this.cmdBankingInfo.UseVisualStyleBackColor = false;
            this.cmdBankingInfo.Visible = false;
            this.cmdBankingInfo.Click += new System.EventHandler(this.cmdBankingInfo_Click);
            // 
            // cmdAdminTransRpt
            // 
            this.cmdAdminTransRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdAdminTransRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAdminTransRpt.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdminTransRpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAdminTransRpt.Location = new System.Drawing.Point(206, 292);
            this.cmdAdminTransRpt.Name = "cmdAdminTransRpt";
            this.cmdAdminTransRpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAdminTransRpt.Size = new System.Drawing.Size(177, 73);
            this.cmdAdminTransRpt.TabIndex = 32;
            this.cmdAdminTransRpt.Text = "&Admin Transactions Report";
            this.cmdAdminTransRpt.UseVisualStyleBackColor = false;
            this.cmdAdminTransRpt.Visible = false;
            this.cmdAdminTransRpt.Click += new System.EventHandler(this.cmdAdminTransRpt_Click);
            // 
            // cmdSalesRpt
            // 
            this.cmdSalesRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmdSalesRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSalesRpt.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalesRpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSalesRpt.Location = new System.Drawing.Point(399, 132);
            this.cmdSalesRpt.Name = "cmdSalesRpt";
            this.cmdSalesRpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSalesRpt.Size = new System.Drawing.Size(177, 73);
            this.cmdSalesRpt.TabIndex = 33;
            this.cmdSalesRpt.Text = "Sa&les Report";
            this.cmdSalesRpt.UseVisualStyleBackColor = false;
            this.cmdSalesRpt.Visible = false;
            this.cmdSalesRpt.Click += new System.EventHandler(this.cmdSalesRpt_Click);
            // 
            // cmdTransactionRpt
            // 
            this.cmdTransactionRpt.BackColor = System.Drawing.Color.Cyan;
            this.cmdTransactionRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdTransactionRpt.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTransactionRpt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdTransactionRpt.Location = new System.Drawing.Point(206, 452);
            this.cmdTransactionRpt.Name = "cmdTransactionRpt";
            this.cmdTransactionRpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTransactionRpt.Size = new System.Drawing.Size(177, 73);
            this.cmdTransactionRpt.TabIndex = 31;
            this.cmdTransactionRpt.Text = "&Guest Transactions Report";
            this.cmdTransactionRpt.UseVisualStyleBackColor = false;
            this.cmdTransactionRpt.Visible = false;
            this.cmdTransactionRpt.Click += new System.EventHandler(this.cmdTransactionRpt_Click);
            // 
            // cmdICHistory
            // 
            this.cmdICHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdICHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdICHistory.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdICHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdICHistory.Location = new System.Drawing.Point(206, 132);
            this.cmdICHistory.Name = "cmdICHistory";
            this.cmdICHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdICHistory.Size = new System.Drawing.Size(177, 73);
            this.cmdICHistory.TabIndex = 27;
            this.cmdICHistory.Text = "Issued Card &History";
            this.cmdICHistory.UseVisualStyleBackColor = false;
            this.cmdICHistory.Visible = false;
            this.cmdICHistory.Click += new System.EventHandler(this.cmdICHistory_Click);
            // 
            // cmdStaffDetail
            // 
            this.cmdStaffDetail.BackColor = System.Drawing.Color.Turquoise;
            this.cmdStaffDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdStaffDetail.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaffDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdStaffDetail.Location = new System.Drawing.Point(308, 285);
            this.cmdStaffDetail.Name = "cmdStaffDetail";
            this.cmdStaffDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdStaffDetail.Size = new System.Drawing.Size(177, 73);
            this.cmdStaffDetail.TabIndex = 30;
            this.cmdStaffDetail.Text = "Staff Detail";
            this.cmdStaffDetail.UseVisualStyleBackColor = false;
            this.cmdStaffDetail.Click += new System.EventHandler(this.cmdStaffDetail_Click);
            // 
            // mnuSYearly
            // 
            this.mnuSYearly.Name = "mnuSYearly";
            this.mnuSYearly.Size = new System.Drawing.Size(126, 22);
            this.mnuSYearly.Text = "By Year";
            // 
            // cmdBackup
            // 
            this.cmdBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdBackup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBackup.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBackup.Location = new System.Drawing.Point(143, 493);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBackup.Size = new System.Drawing.Size(177, 73);
            this.cmdBackup.TabIndex = 29;
            this.cmdBackup.Text = "R&estore Data";
            this.cmdBackup.UseVisualStyleBackColor = false;
            this.cmdBackup.Visible = false;
            this.cmdBackup.Click += new System.EventHandler(this.cmdBackup_Click);
            // 
            // cmdIssueCard
            // 
            this.cmdIssueCard.BackColor = System.Drawing.Color.Yellow;
            this.cmdIssueCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdIssueCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIssueCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIssueCard.Location = new System.Drawing.Point(308, 109);
            this.cmdIssueCard.Name = "cmdIssueCard";
            this.cmdIssueCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdIssueCard.Size = new System.Drawing.Size(177, 73);
            this.cmdIssueCard.TabIndex = 23;
            this.cmdIssueCard.Text = "Issue Setting Card";
            this.cmdIssueCard.UseVisualStyleBackColor = false;
            this.cmdIssueCard.Click += new System.EventHandler(this.cmdIssueCard_Click);
            // 
            // cmdReadCard
            // 
            this.cmdReadCard.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdReadCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReadCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReadCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReadCard.Location = new System.Drawing.Point(308, 196);
            this.cmdReadCard.Name = "cmdReadCard";
            this.cmdReadCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReadCard.Size = new System.Drawing.Size(177, 73);
            this.cmdReadCard.TabIndex = 25;
            this.cmdReadCard.Text = "♲ Read / Recycle Any Card";
            this.cmdReadCard.UseVisualStyleBackColor = false;
            this.cmdReadCard.Click += new System.EventHandler(this.cmdReadCard_Click);
            // 
            // cmdCancelCard
            // 
            this.cmdCancelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdCancelCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancelCard.Enabled = false;
            this.cmdCancelCard.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancelCard.Location = new System.Drawing.Point(300, 531);
            this.cmdCancelCard.Name = "cmdCancelCard";
            this.cmdCancelCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancelCard.Size = new System.Drawing.Size(20, 18);
            this.cmdCancelCard.TabIndex = 26;
            this.cmdCancelCard.Text = "&Cancel Card";
            this.cmdCancelCard.UseVisualStyleBackColor = false;
            this.cmdCancelCard.Visible = false;
            this.cmdCancelCard.Click += new System.EventHandler(this.cmdCancelCard_Click);
            // 
            // cmdUpload
            // 
            this.cmdUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdUpload.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpload.Enabled = false;
            this.cmdUpload.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUpload.Location = new System.Drawing.Point(335, 532);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpload.Size = new System.Drawing.Size(18, 21);
            this.cmdUpload.TabIndex = 24;
            this.cmdUpload.Text = "&Upload Data Card";
            this.cmdUpload.UseVisualStyleBackColor = false;
            this.cmdUpload.Visible = false;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.BackColor = System.Drawing.Color.LightYellow;
            this.cmdChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdChangePassword.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdChangePassword.Location = new System.Drawing.Point(308, 374);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdChangePassword.Size = new System.Drawing.Size(177, 73);
            this.cmdChangePassword.TabIndex = 28;
            this.cmdChangePassword.Text = "Change Password";
            this.cmdChangePassword.UseVisualStyleBackColor = false;
            this.cmdChangePassword.Click += new System.EventHandler(this.cmdChangePassword_Click);
            // 
            // cmdLogInOut
            // 
            this.cmdLogInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdLogInOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLogInOut.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogInOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLogInOut.Location = new System.Drawing.Point(206, 212);
            this.cmdLogInOut.Name = "cmdLogInOut";
            this.cmdLogInOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLogInOut.Size = new System.Drawing.Size(177, 73);
            this.cmdLogInOut.TabIndex = 34;
            this.cmdLogInOut.Text = "&Log In/ Out Report ";
            this.cmdLogInOut.UseVisualStyleBackColor = false;
            this.cmdLogInOut.Visible = false;
            this.cmdLogInOut.Click += new System.EventHandler(this.cmdLogInOut_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(294, 26);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(208, 41);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Admin Mode";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnuSMonthly
            // 
            this.mnuSMonthly.Name = "mnuSMonthly";
            this.mnuSMonthly.Size = new System.Drawing.Size(126, 22);
            this.mnuSMonthly.Text = "&By Month";
            // 
            // mnuSDaily
            // 
            this.mnuSDaily.Name = "mnuSDaily";
            this.mnuSDaily.Size = new System.Drawing.Size(126, 22);
            this.mnuSDaily.Text = "By Date ";
            // 
            // mnuUpload
            // 
            this.mnuUpload.Name = "mnuUpload";
            this.mnuUpload.Size = new System.Drawing.Size(139, 22);
            this.mnuUpload.Text = "Data &Upload";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRestore,
            this.mnuStaff,
            this.mnuChangePassword});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "&Admin";
            // 
            // mnuRestore
            // 
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Size = new System.Drawing.Size(168, 22);
            this.mnuRestore.Text = "Rest&ore Data";
            // 
            // mnuStaff
            // 
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.Size = new System.Drawing.Size(168, 22);
            this.mnuStaff.Text = "&Staff Detail";
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuChangePassword.Text = "Change &Password";
            // 
            // mnuCancelCard
            // 
            this.mnuCancelCard.Name = "mnuCancelCard";
            this.mnuCancelCard.Size = new System.Drawing.Size(139, 22);
            this.mnuCancelCard.Text = "&Cancel Card";
            // 
            // mnuIssueCard
            // 
            this.mnuIssueCard.Name = "mnuIssueCard";
            this.mnuIssueCard.Size = new System.Drawing.Size(139, 22);
            this.mnuIssueCard.Text = "&Issue Card";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManagement,
            this.mnuAdmin,
            this.mnuGenerate});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(780, 24);
            this.MainMenu1.TabIndex = 44;
            this.MainMenu1.Visible = false;
            // 
            // mnuManagement
            // 
            this.mnuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReadCard,
            this.mnuIssueCard,
            this.mnuCancelCard,
            this.mnuUpload});
            this.mnuManagement.Name = "mnuManagement";
            this.mnuManagement.Size = new System.Drawing.Size(118, 20);
            this.mnuManagement.Text = "Card &Management";
            // 
            // mnuReadCard
            // 
            this.mnuReadCard.Name = "mnuReadCard";
            this.mnuReadCard.Size = new System.Drawing.Size(139, 22);
            this.mnuReadCard.Text = "&Read Card";
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransaction,
            this.mnuSales,
            this.mnuLogInOut});
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(104, 20);
            this.mnuGenerate.Text = "&Generate Report";
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGuestTrans,
            this.mnuAdminCards});
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(167, 22);
            this.mnuTransaction.Text = "&Transaction Detail";
            // 
            // mnuGuestTrans
            // 
            this.mnuGuestTrans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDate,
            this.mnuMonth,
            this.mnuGYear});
            this.mnuGuestTrans.Name = "mnuGuestTrans";
            this.mnuGuestTrans.Size = new System.Drawing.Size(113, 22);
            this.mnuGuestTrans.Text = "&Guest ";
            // 
            // mnuDate
            // 
            this.mnuDate.Name = "mnuDate";
            this.mnuDate.Size = new System.Drawing.Size(126, 22);
            this.mnuDate.Text = "By D&ate";
            // 
            // mnuMonth
            // 
            this.mnuMonth.Name = "mnuMonth";
            this.mnuMonth.Size = new System.Drawing.Size(126, 22);
            this.mnuMonth.Text = "By &Month";
            // 
            // mnuGYear
            // 
            this.mnuGYear.Name = "mnuGYear";
            this.mnuGYear.Size = new System.Drawing.Size(126, 22);
            this.mnuGYear.Text = "By &Year";
            // 
            // mnuAdminCards
            // 
            this.mnuAdminCards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuADaily,
            this.mnuAMonthly,
            this.mnuAYearly});
            this.mnuAdminCards.Name = "mnuAdminCards";
            this.mnuAdminCards.Size = new System.Drawing.Size(113, 22);
            this.mnuAdminCards.Text = "Ad&min ";
            // 
            // mnuADaily
            // 
            this.mnuADaily.Name = "mnuADaily";
            this.mnuADaily.Size = new System.Drawing.Size(126, 22);
            this.mnuADaily.Text = "By Date";
            // 
            // mnuAMonthly
            // 
            this.mnuAMonthly.Name = "mnuAMonthly";
            this.mnuAMonthly.Size = new System.Drawing.Size(126, 22);
            this.mnuAMonthly.Text = "By Month";
            // 
            // mnuAYearly
            // 
            this.mnuAYearly.Name = "mnuAYearly";
            this.mnuAYearly.Size = new System.Drawing.Size(126, 22);
            this.mnuAYearly.Text = "By Year";
            // 
            // mnuSales
            // 
            this.mnuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSDaily,
            this.mnuSMonthly,
            this.mnuSYearly});
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Size = new System.Drawing.Size(167, 22);
            this.mnuSales.Text = "Sal&es";
            // 
            // Label_BuildigName
            // 
            this.Label_BuildigName.BackColor = System.Drawing.SystemColors.Control;
            this.Label_BuildigName.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_BuildigName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuildigName.ForeColor = System.Drawing.Color.Red;
            this.Label_BuildigName.Location = new System.Drawing.Point(-5, 73);
            this.Label_BuildigName.Name = "Label_BuildigName";
            this.Label_BuildigName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_BuildigName.Size = new System.Drawing.Size(785, 33);
            this.Label_BuildigName.TabIndex = 36;
            this.Label_BuildigName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_CommStatus
            // 
            this.panel_CommStatus.BackColor = System.Drawing.SystemColors.Control;
            this.panel_CommStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CommStatus.Controls.Add(this.pictureBox_COMM_Color);
            this.panel_CommStatus.Controls.Add(this.label_CommState);
            this.panel_CommStatus.Location = new System.Drawing.Point(661, 26);
            this.panel_CommStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panel_CommStatus.Name = "panel_CommStatus";
            this.panel_CommStatus.Size = new System.Drawing.Size(119, 28);
            this.panel_CommStatus.TabIndex = 172;
            // 
            // pictureBox_COMM_Color
            // 
            this.pictureBox_COMM_Color.Image = global::AMS.Properties.Resources.COM_RED;
            this.pictureBox_COMM_Color.InitialImage = global::AMS.Properties.Resources.COM_YELLOW;
            this.pictureBox_COMM_Color.Location = new System.Drawing.Point(101, 3);
            this.pictureBox_COMM_Color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_COMM_Color.Name = "pictureBox_COMM_Color";
            this.pictureBox_COMM_Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_COMM_Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_COMM_Color.TabIndex = 1;
            this.pictureBox_COMM_Color.TabStop = false;
            // 
            // label_CommState
            // 
            this.label_CommState.AutoSize = true;
            this.label_CommState.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CommState.ForeColor = System.Drawing.Color.Blue;
            this.label_CommState.Location = new System.Drawing.Point(4, 6);
            this.label_CommState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CommState.Name = "label_CommState";
            this.label_CommState.Size = new System.Drawing.Size(96, 13);
            this.label_CommState.TabIndex = 0;
            this.label_CommState.Text = "Connected State";
            // 
            // cmdReplacementReport
            // 
            this.cmdReplacementReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdReplacementReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReplacementReport.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReplacementReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReplacementReport.Location = new System.Drawing.Point(491, 151);
            this.cmdReplacementReport.Name = "cmdReplacementReport";
            this.cmdReplacementReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReplacementReport.Size = new System.Drawing.Size(177, 73);
            this.cmdReplacementReport.TabIndex = 173;
            this.cmdReplacementReport.Text = "Re&placement Report";
            this.cmdReplacementReport.UseVisualStyleBackColor = false;
            this.cmdReplacementReport.Visible = false;
            this.cmdReplacementReport.Click += new System.EventHandler(this.cmdReplacementReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Salmon;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(99, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(582, 493);
            this.textBox1.TabIndex = 174;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_AdminDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 603);
            this.ControlBox = false;
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.cmdStaffDetail);
            this.Controls.Add(this.cmdIssueCard);
            this.Controls.Add(this.cmdReadCard);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdReplacementReport);
            this.Controls.Add(this.panel_CommStatus);
            this.Controls.Add(this.cmdExtraReport);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdOwnerReport);
            this.Controls.Add(this.cmdCheckOutReport);
            this.Controls.Add(this.cmdBonusReport);
            this.Controls.Add(this.cmdBankingInfo);
            this.Controls.Add(this.cmdAdminTransRpt);
            this.Controls.Add(this.cmdSalesRpt);
            this.Controls.Add(this.cmdTransactionRpt);
            this.Controls.Add(this.cmdICHistory);
            this.Controls.Add(this.cmdBackup);
            this.Controls.Add(this.cmdCancelCard);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.cmdLogInOut);
            this.Controls.Add(this.MainMenu1);
            this.Controls.Add(this.Label_BuildigName);
            this.Name = "Form_AdminDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
            this.Activated += new System.EventHandler(this.Form_AdminDMS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AdminDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_AdminDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_AdminDMS_VisibleChanged);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.panel_CommStatus.ResumeLayout(false);
            this.panel_CommStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form_AdminDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void Restores_Buttons_EnablesState()
    {
      this.cmdAdminTransRpt.Enabled = true;
      this.cmdTransactionRpt.Enabled = true;
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      this.Restores_Buttons_EnablesState();
      ModDoorLockSystem.Form_MainDMS_Ptr.TopLevel = true;
      this.db.UPDATE_LOGOUT(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
      ModDoorLockSystem.Form_MainDMS_Ptr.Visible = true;
    }

    private void Form_AdminDMS_Activated(object sender, EventArgs e) => this.SetTopLevel(true);

    private void cmdIssueCard_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_IssueCardDMS_Ptr.Show();
    }

    private void cmdUpload_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ReadDataCardDMS_Ptr.Show();
    }

    private void cmdReadCard_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ReadCardDMS_Ptr.Show();
    }

    private void cmdCancelCard_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_CancelCardDMS_Ptr.Show();
    }

    private void cmdICHistory_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 7;
      ModDoorLockSystem.Form_OtherReportsDMS_Ptr.Show();
    }

    private void cmdChangePassword_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_ChangePasswordDMS_Ptr.Show();
    }

    private void cmdBackup_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      int num = (int) new Form_RestoreDMS().ShowDialog();
      this.Visible = true;
    }

    private void cmdStaffDetail_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_StaffDMS_Ptr.Show();
    }

    private void cmdLogInOut_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_LogReportDMS_Ptr.Show();
    }

    private void cmdSalesRpt_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 3;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS(true);
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

    private void cmdExtraReport_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 9;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

    private void cmdBonusReport_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 11;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

    private void cmdTransactionRpt_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 1;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog((IWin32Window) this);
    }

    private void cmdAdminTransRpt_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 2;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

    private void cmdCheckOutReport_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 12;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

    private void cmdEdit_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_EditDMS_Ptr.Show();
    }

    private void cmdBankingInfo_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_BankingDMS_Ptr.Show();
    }

    private void Form_AdminDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Change_BkGolr_for_Disable_Buttons()
    {
      this.cmdExtraReport.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.cmdEdit.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.cmdOwnerReport.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdCheckOutReport.BackColor = Color.FromArgb(0, 128, 128);
      this.cmdBonusReport.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdBankingInfo.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdAdminTransRpt.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cmdSalesRpt.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.cmdTransactionRpt.BackColor = Color.Cyan;
      this.cmdICHistory.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.cmdStaffDetail.BackColor = Color.FromArgb(192, 192, 0);
      this.cmdBackup.BackColor = Color.FromArgb((int) byte.MaxValue, 192, (int) byte.MaxValue);
      this.cmdIssueCard.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdReadCard.BackColor = Color.Green;
      this.cmdCancelCard.BackColor = Color.FromArgb(0, 192, 0);
      this.cmdUpload.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.cmdChangePassword.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.cmdLogInOut.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cmdReplacementReport.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      if (!this.cmdExtraReport.Enabled)
        this.cmdExtraReport.BackColor = SystemColors.Control;
      if (!this.cmdEdit.Enabled)
        this.cmdEdit.BackColor = SystemColors.Control;
      if (!this.cmdOwnerReport.Enabled)
        this.cmdOwnerReport.BackColor = SystemColors.Control;
      if (!this.cmdCheckOutReport.Enabled)
        this.cmdCheckOutReport.BackColor = SystemColors.Control;
      if (!this.cmdBonusReport.Enabled)
        this.cmdBonusReport.BackColor = SystemColors.Control;
      if (!this.cmdBankingInfo.Enabled)
        this.cmdBankingInfo.BackColor = SystemColors.Control;
      if (!this.cmdAdminTransRpt.Enabled)
        this.cmdAdminTransRpt.BackColor = SystemColors.Control;
      if (!this.cmdSalesRpt.Enabled)
        this.cmdSalesRpt.BackColor = SystemColors.Control;
      if (!this.cmdTransactionRpt.Enabled)
        this.cmdTransactionRpt.BackColor = SystemColors.Control;
      if (!this.cmdICHistory.Enabled)
        this.cmdICHistory.BackColor = SystemColors.Control;
      if (!this.cmdStaffDetail.Enabled)
        this.cmdStaffDetail.BackColor = SystemColors.Control;
      if (!this.cmdBackup.Enabled)
        this.cmdBackup.BackColor = SystemColors.Control;
      if (!this.cmdIssueCard.Enabled)
        this.cmdIssueCard.BackColor = SystemColors.Control;
      if (!this.cmdReadCard.Enabled)
        this.cmdReadCard.BackColor = SystemColors.Control;
      if (!this.cmdCancelCard.Enabled)
        this.cmdCancelCard.BackColor = SystemColors.Control;
      if (!this.cmdUpload.Enabled)
        this.cmdUpload.BackColor = SystemColors.Control;
      if (!this.cmdChangePassword.Enabled)
        this.cmdChangePassword.BackColor = SystemColors.Control;
      if (!this.cmdLogInOut.Enabled)
        this.cmdLogInOut.BackColor = SystemColors.Control;
      if (this.cmdReplacementReport.Enabled)
        return;
      this.cmdReplacementReport.BackColor = SystemColors.Control;
    }

    private void Check_for_bAdminOnly()
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdminOnly)
      {
        this.cmdStaffDetail.Enabled = false;
        this.cmdLogInOut.Enabled = false;
        this.cmdBackup.Enabled = false;
        this.cmdICHistory.Enabled = false;
        this.cmdSalesRpt.Enabled = false;
        this.cmdAdminTransRpt.Enabled = false;
        this.cmdTransactionRpt.Enabled = false;
        this.cmdCancelCard.Enabled = false;
        this.cmdReadCard.Enabled = false;
        this.cmdChangePassword.Enabled = false;
        this.cmdCheckOutReport.Enabled = false;
        this.cmdExtraReport.Enabled = false;
        this.cmdBonusReport.Enabled = false;
        this.cmdEdit.Enabled = false;
        this.cmdBankingInfo.Enabled = false;
        this.cmdUpload.Enabled = false;
        this.cmdIssueCard.Enabled = true;
        this.cmdReplacementReport.Enabled = false;
      }
      else
      {
        this.cmdStaffDetail.Enabled = true;
        this.cmdLogInOut.Enabled = true;
        this.cmdBackup.Enabled = true;
        this.cmdICHistory.Enabled = true;
        this.cmdSalesRpt.Enabled = true;
        this.cmdAdminTransRpt.Enabled = true;
        this.cmdTransactionRpt.Enabled = true;
        this.cmdCancelCard.Enabled = true;
        this.cmdReadCard.Enabled = true;
        this.cmdChangePassword.Enabled = true;
        this.cmdCheckOutReport.Enabled = true;
        this.cmdExtraReport.Enabled = true;
        this.cmdBonusReport.Enabled = true;
        this.cmdEdit.Enabled = true;
        this.cmdBankingInfo.Enabled = true;
        this.cmdUpload.Enabled = true;
        this.cmdIssueCard.Enabled = true;
        this.cmdReplacementReport.Enabled = true;
      }
    }

    private void Form_AdminDMS_Load(object sender, EventArgs e)
    {
      this.Check_for_bAdminOnly();
      this.Change_BkGolr_for_Disable_Buttons();
    }

    private void Form_AdminDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Check_for_bAdminOnly();
      this.Change_BkGolr_for_Disable_Buttons();
    }

    private void cmdReplacementReport_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iType = 13;
      this.Form_TransactionReportDMS_Ptr = new Form_TransactionReportDMS();
      int num = (int) this.Form_TransactionReportDMS_Ptr.ShowDialog();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
