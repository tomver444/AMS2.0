// Decompiled with JetBrains decompiler
// Type: AMS.Form_GuestBrowserDMS
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
  public class Form_GuestBrowserDMS : Form
  {
    private IContainer components;
    public Button cmdOk;
    public ToolTip ToolTip1;
    public Label Label1;
    private DataGridView dataGridView_GuestInfo;
    private TempDataSet tempDataSet;
    private BindingSource gInfoTempBindingSource;
    private GInfo_TempTableAdapter gInfo_TempTableAdapter;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn foreNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validStartDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn validEndDataGridViewTextBoxColumn;
    public Button button1_Cancel;
    private int selected_rowindex;
    private DB db = new DB();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.cmdOk = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.button1_Cancel = new Button();
      this.Label1 = new Label();
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
      this.gInfo_TempTableAdapter = new GInfo_TempTableAdapter();
      ((ISupportInitialize) this.dataGridView_GuestInfo).BeginInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.SuspendLayout();
      this.cmdOk.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.cmdOk.Cursor = Cursors.Default;
      this.cmdOk.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOk.ForeColor = SystemColors.ControlText;
      this.cmdOk.Location = new Point(269, 414);
      this.cmdOk.Margin = new Padding(2);
      this.cmdOk.Name = "cmdOk";
      this.cmdOk.RightToLeft = RightToLeft.No;
      this.cmdOk.Size = new Size(94, 32);
      this.cmdOk.TabIndex = 5;
      this.cmdOk.Text = "&OK";
      this.ToolTip1.SetToolTip((Control) this.cmdOk, "Click OK to return to main screen");
      this.cmdOk.UseVisualStyleBackColor = false;
      this.cmdOk.Click += new EventHandler(this.cmdOk_Click);
      this.button1_Cancel.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.button1_Cancel.Cursor = Cursors.Default;
      this.button1_Cancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1_Cancel.ForeColor = SystemColors.ControlText;
      this.button1_Cancel.Location = new Point(500, 414);
      this.button1_Cancel.Margin = new Padding(2);
      this.button1_Cancel.Name = "button1_Cancel";
      this.button1_Cancel.RightToLeft = RightToLeft.No;
      this.button1_Cancel.Size = new Size(86, 32);
      this.button1_Cancel.TabIndex = 7;
      this.button1_Cancel.Text = "&Cancel";
      this.ToolTip1.SetToolTip((Control) this.button1_Cancel, "Click OK to return to main screen");
      this.button1_Cancel.UseVisualStyleBackColor = false;
      this.button1_Cancel.Click += new EventHandler(this.button1_Cancel_Click);
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label1.Location = new Point(43, 7);
      this.Label1.Margin = new Padding(2, 0, 2, 0);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(481, 27);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "GUEST DATA";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.dataGridView_GuestInfo.AllowUserToAddRows = false;
      this.dataGridView_GuestInfo.AllowUserToDeleteRows = false;
      this.dataGridView_GuestInfo.AllowUserToResizeColumns = false;
      this.dataGridView_GuestInfo.AllowUserToResizeRows = false;
      this.dataGridView_GuestInfo.AutoGenerateColumns = false;
      this.dataGridView_GuestInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView_GuestInfo.CausesValidation = false;
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle.BackColor = SystemColors.Control;
      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle.ForeColor = SystemColors.WindowText;
      gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle.WrapMode = DataGridViewTriState.False;
      this.dataGridView_GuestInfo.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
      this.dataGridView_GuestInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_GuestInfo.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.foreNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.surNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.cardNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.validStartDataGridViewTextBoxColumn, (DataGridViewColumn) this.validEndDataGridViewTextBoxColumn);
      this.dataGridView_GuestInfo.DataSource = (object) this.gInfoTempBindingSource;
      this.dataGridView_GuestInfo.EnableHeadersVisualStyles = false;
      this.dataGridView_GuestInfo.GridColor = SystemColors.GrayText;
      this.dataGridView_GuestInfo.Location = new Point(2, 55);
      this.dataGridView_GuestInfo.Margin = new Padding(2);
      this.dataGridView_GuestInfo.MultiSelect = false;
      this.dataGridView_GuestInfo.Name = "dataGridView_GuestInfo";
      this.dataGridView_GuestInfo.ReadOnly = true;
      this.dataGridView_GuestInfo.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.dataGridView_GuestInfo.RowTemplate.Height = 24;
      this.dataGridView_GuestInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView_GuestInfo.ShowCellToolTips = false;
      this.dataGridView_GuestInfo.ShowEditingIcon = false;
      this.dataGridView_GuestInfo.Size = new Size(583, 322);
      this.dataGridView_GuestInfo.TabIndex = 6;
      this.dataGridView_GuestInfo.TabStop = false;
      this.dataGridView_GuestInfo.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_GuestInfo_CellDoubleClick);
      this.dataGridView_GuestInfo.CellClick += new DataGridViewCellEventHandler(this.dataGridView_GuestInfo_CellClick);
      this.dataGridView_GuestInfo.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView_GuestInfo_CellMouseDoubleClick);
      this.dataGridView_GuestInfo.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView_GuestInfo_RowStateChanged);
      this.roomNoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.FillWeight = 593.401f;
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "Room No";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn.Width = 77;
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
      this.gInfo_TempTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.ClientSize = new Size(594, 466);
      this.ControlBox = false;
      this.Controls.Add((Control) this.button1_Cancel);
      this.Controls.Add((Control) this.dataGridView_GuestInfo);
      this.Controls.Add((Control) this.cmdOk);
      this.Controls.Add((Control) this.Label1);
      this.Margin = new Padding(2);
      this.Name = "Form_GuestBrowserDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Form_GuestBrowser";
      this.TopMost = true;
      this.Load += new EventHandler(this.Form_GuestBrowser_Load);
      this.VisibleChanged += new EventHandler(this.Form_GuestBrowserDMS_VisibleChanged);
      ((ISupportInitialize) this.dataGridView_GuestInfo).EndInit();
      ((ISupportInitialize) this.gInfoTempBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.ResumeLayout(false);
    }

    public Form_GuestBrowserDMS() => this.InitializeComponent();

    private void Form_GuestBrowser_Load(object sender, EventArgs e)
    {
      this.gInfoTempBindingSource.DataSource = (object) this.db.temp_DB.tempDataSet;
      this.selected_rowindex = 0;
    }

    private void OK_Click_Process()
    {
      this.Visible = false;
      if (this.db.temp_DB.tempDataSet.GInfo_Temp.Rows.Count > 0)
      {
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Old_Client_OK_flag = true;
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Old_Client_ID = (string) this.dataGridView_GuestInfo.Rows[this.selected_rowindex].Cells[this.clientIDDataGridViewTextBoxColumn.Name].Value;
        ModDoorLockSystem.Form_IssueCardDMS_Ptr.Old_Client_OK_flag = true;
        ModDoorLockSystem.Form_IssueCardDMS_Ptr.Old_Client_ID = (string) this.dataGridView_GuestInfo.Rows[this.selected_rowindex].Cells[this.clientIDDataGridViewTextBoxColumn.Name].Value;
        ModDoorLockSystem.Form_GuestDetailDMS_Ptr.Old_Client_OK_flag = true;
        ModDoorLockSystem.Form_GuestDetailDMS_Ptr.Old_Client_ID = (string) this.dataGridView_GuestInfo.Rows[this.selected_rowindex].Cells[this.clientIDDataGridViewTextBoxColumn.Name].Value;
      }
      else
      {
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Old_Client_OK_flag = false;
        ModDoorLockSystem.Form_IssueCardDMS_Ptr.Old_Client_OK_flag = false;
        ModDoorLockSystem.Form_GuestDetailDMS_Ptr.Old_Client_OK_flag = false;
      }
      this.Close();
    }

    private void cmdOk_Click(object sender, EventArgs e) => this.OK_Click_Process();

    private void Form_GuestBrowserDMS_VisibleChanged(object sender, EventArgs e)
    {
    }

    private void dataGridView_GuestInfo_CellMouseDoubleClick(
      object sender,
      DataGridViewCellMouseEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
    }

    private void dataGridView_GuestInfo_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
    }

    private void button1_Cancel_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_IssueGuestCard_Ptr.Old_Client_OK_flag = false;
      ModDoorLockSystem.Form_IssueCardDMS_Ptr.Old_Client_OK_flag = false;
      ModDoorLockSystem.Form_GuestDetailDMS_Ptr.Old_Client_OK_flag = false;
      this.Close();
    }

    private void dataGridView_GuestInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
      this.OK_Click_Process();
    }

    private void dataGridView_GuestInfo_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.temp_DB.tempDataSet.GInfo_Temp.Rows.Count || this.dataGridView_GuestInfo.Rows.Count != this.db.temp_DB.tempDataSet.GInfo_Temp.Rows.Count)
        return;
      this.selected_rowindex = e.Row.Index;
    }
  }
}
