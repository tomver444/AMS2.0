// Decompiled with JetBrains decompiler
// Type: AMS.Form_ViewReserveListDMS
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
  public class Form_ViewReserveListDMS : Form
  {
    private IContainer components;
    public ToolTip ToolTip1;
    public Button cmdOK;
    public Label Label1;
    private DataGridView dataGridView1;
    private TempDataSet tempDataSet;
    private BindingSource accReservationListBindingSource;
    private AccReservationListTableAdapter accReservationListTableAdapter;
    private DataGridViewTextBoxColumn reserveRefDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn foreNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    public Button button_Cancel;
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
      this.ToolTip1 = new ToolTip(this.components);
      this.cmdOK = new Button();
      this.Label1 = new Label();
      this.dataGridView1 = new DataGridView();
      this.reserveRefDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.foreNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.surNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.depositDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.accReservationListBindingSource = new BindingSource(this.components);
      this.tempDataSet = new TempDataSet();
      this.accReservationListTableAdapter = new AccReservationListTableAdapter();
      this.button_Cancel = new Button();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.accReservationListBindingSource).BeginInit();
      this.tempDataSet.BeginInit();
      this.SuspendLayout();
      this.cmdOK.BackColor = SystemColors.Control;
      this.cmdOK.Cursor = Cursors.Default;
      this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdOK.ForeColor = SystemColors.ControlText;
      this.cmdOK.Location = new Point(408, 515);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.RightToLeft = RightToLeft.No;
      this.cmdOK.Size = new Size(109, 40);
      this.cmdOK.TabIndex = 5;
      this.cmdOK.Text = "&OK";
      this.cmdOK.UseVisualStyleBackColor = false;
      this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
      this.Label1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Red;
      this.Label1.Location = new Point(11, 31);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(680, 33);
      this.Label1.TabIndex = 4;
      this.Label1.Text = "RESERVATION LIST";
      this.Label1.TextAlign = ContentAlignment.TopCenter;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.CausesValidation = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.reserveRefDataGridViewTextBoxColumn, (DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.clientIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.foreNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.surNameDataGridViewTextBoxColumn, (DataGridViewColumn) this.depositDataGridViewTextBoxColumn, (DataGridViewColumn) this.startDateDataGridViewTextBoxColumn, (DataGridViewColumn) this.endDateDataGridViewTextBoxColumn);
      this.dataGridView1.DataSource = (object) this.accReservationListBindingSource;
      this.dataGridView1.EnableHeadersVisualStyles = false;
      this.dataGridView1.Location = new Point(1, 67);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.ShowCellToolTips = false;
      this.dataGridView1.ShowEditingIcon = false;
      this.dataGridView1.Size = new Size(834, 424);
      this.dataGridView1.TabIndex = 6;
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
      this.dataGridView1.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
      this.reserveRefDataGridViewTextBoxColumn.DataPropertyName = "ReserveRef";
      this.reserveRefDataGridViewTextBoxColumn.HeaderText = "ReserveRef";
      this.reserveRefDataGridViewTextBoxColumn.Name = "reserveRefDataGridViewTextBoxColumn";
      this.reserveRefDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
      this.clientIDDataGridViewTextBoxColumn.HeaderText = "Gues ID";
      this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
      this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.foreNameDataGridViewTextBoxColumn.DataPropertyName = "ForeName";
      this.foreNameDataGridViewTextBoxColumn.HeaderText = "First Name";
      this.foreNameDataGridViewTextBoxColumn.Name = "foreNameDataGridViewTextBoxColumn";
      this.foreNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
      this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
      this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
      this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
      this.depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
      this.depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
      this.depositDataGridViewTextBoxColumn.ReadOnly = true;
      this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
      this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
      this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
      this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
      this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
      this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
      this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
      this.accReservationListBindingSource.DataMember = "AccReservationList";
      this.accReservationListBindingSource.DataSource = (object) this.tempDataSet;
      this.tempDataSet.DataSetName = "TempDataSet";
      this.tempDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.accReservationListTableAdapter.ClearBeforeFill = true;
      this.button_Cancel.BackColor = SystemColors.Control;
      this.button_Cancel.Cursor = Cursors.Default;
      this.button_Cancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button_Cancel.ForeColor = SystemColors.ControlText;
      this.button_Cancel.Location = new Point(603, 515);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.RightToLeft = RightToLeft.No;
      this.button_Cancel.Size = new Size(109, 40);
      this.button_Cancel.TabIndex = 7;
      this.button_Cancel.Text = "&Cancel";
      this.button_Cancel.UseVisualStyleBackColor = false;
      this.button_Cancel.Click += new EventHandler(this.button_Cancel_Click);
      this.AutoScaleDimensions = new SizeF(6f, 14f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.ClientSize = new Size(834, 582);
      this.Controls.Add((Control) this.button_Cancel);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.cmdOK);
      this.Controls.Add((Control) this.Label1);
      this.Font = new Font("Arial", 8f);
      this.Name = "Form_ViewReserveListDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
      this.Load += new EventHandler(this.Form_ViewReserveListDMS_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.accReservationListBindingSource).EndInit();
      this.tempDataSet.EndInit();
      this.ResumeLayout(false);
    }

    public Form_ViewReserveListDMS() => this.InitializeComponent();

    private void Form_ViewReserveListDMS_Load(object sender, EventArgs e)
    {
      this.accReservationListBindingSource.DataSource = (object) this.db.temp_DB.tempDataSet;
      this.selected_rowindex = 0;
    }

    private void OK_Click_Process()
    {
      this.Visible = false;
      if (this.db.temp_DB.tempDataSet.AccReservationList.Rows.Count > 0)
      {
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Reserve_Client_OK_flag = true;
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Reserve_Client_RefID = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.reserveRefDataGridViewTextBoxColumn.Name].Value;
        ModDoorLockSystem.Form_CancelReservationDMS_Ptr.Reserve_Client_OK_flag = true;
        ModDoorLockSystem.Form_CancelReservationDMS_Ptr.Reserve_Client_RefID = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.reserveRefDataGridViewTextBoxColumn.Name].Value;
      }
      else
      {
        ModDoorLockSystem.Form_IssueGuestCard_Ptr.Reserve_Client_OK_flag = false;
        ModDoorLockSystem.Form_CancelReservationDMS_Ptr.Reserve_Client_OK_flag = false;
      }
      this.Close();
    }

    private void cmdOK_Click(object sender, EventArgs e) => this.OK_Click_Process();

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
    }

    private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
      this.OK_Click_Process();
    }

    private void dataGridView1_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.temp_DB.tempDataSet.AccReservationList.Rows.Count || this.dataGridView1.Rows.Count != this.db.temp_DB.tempDataSet.AccReservationList.Rows.Count)
        return;
      this.selected_rowindex = e.Row.Index;
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_IssueGuestCard_Ptr.Reserve_Client_OK_flag = false;
      ModDoorLockSystem.Form_CancelReservationDMS_Ptr.Reserve_Client_OK_flag = false;
      this.Close();
    }
  }
}
