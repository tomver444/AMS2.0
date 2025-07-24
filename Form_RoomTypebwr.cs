// Decompiled with JetBrains decompiler
// Type: AMS.Form_RoomTypebwr
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
  public class Form_RoomTypebwr : Form
  {
    private DB db = new DB();
    private string ord = "";
    private string Cond = "";
    private IContainer components;
    public ComboBox cboOrder;
    public TextBox txtSearch;
    public Button cmdSelect;
    public Button cmdCancel;
    public ComboBox cboSearch;
    public Label Label1;
    public Label Label2;
    private DataGridView dataGridView1;
    private SystemDataSet systemDataSet;
    private BindingSource roomTypeBindingSource;
    private RoomTypeTableAdapter roomTypeTableAdapter;
    private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn rmDescriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn maxCardDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn minCardDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn updateDataGridViewCheckBoxColumn;

    public Form_RoomTypebwr() => this.InitializeComponent();

    private void Form_RmStatusbwr_Load(object sender, EventArgs e)
    {
      this.Initialize_ComboRmType(this.cboSearch);
      this.Initialize_ComboRmType(this.cboOrder);
      this.roomTypeBindingSource.DataSource = (object) ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet;
      this.Check_Selected_Order();
      this.Check_Selected_Search();
      this.Load_RoomType_Data();
      this.dataGridView1.Focus();
      this.dataGridView1.Select();
    }

    public bool Initialize_ComboRmType(ComboBox para_ComboBox)
    {
      para_ComboBox.Items.Clear();
      para_ComboBox.Items.Add((object) "RoomType");
      para_ComboBox.Items.Add((object) "RmDescription");
      para_ComboBox.SelectedIndex = 0;
      return true;
    }

    private void Load_RoomType_Data()
    {
      try
      {
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.RoomTypeTableAdapter_1.Fill(ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet.RoomType);
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.RoomTypeTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from RoomType " + this.Cond + this.ord;
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.RoomTypeTableAdapter_1.Fill(ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet.RoomType);
        this.dataGridView1.Refresh();
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.selected_rowindex = 0;
      }
      catch
      {
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.RoomTypeTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from RoomType";
      }
    }

    private void Check_Selected_Order()
    {
      this.ord = "";
      switch (this.cboOrder.SelectedIndex)
      {
        case 0:
          this.ord = " ORDER BY RoomType";
          break;
        case 1:
          this.ord = " ORDER BY RmDescription";
          break;
      }
    }

    private void Check_Selected_Search()
    {
      this.Cond = "";
      if (this.txtSearch.Text.Length <= 0)
        return;
      switch (this.cboSearch.SelectedIndex)
      {
        case 0:
          this.Cond = " WHERE RoomType LIKE " + this.txtSearch.Text;
          break;
        case 1:
          this.Cond = " WHERE RmDescription LIKE '" + this.txtSearch.Text + "'";
          break;
      }
    }

    private void cmdSelect_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.dataGridView1.Rows.Count <= 0 || ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet.RoomType.Rows.Count <= 0)
        {
          ModDoorLockSystem.Form_RoomTypeDMS_Ptr.OK_Flag = false;
        }
        else
        {
          ModDoorLockSystem.Form_RoomTypeDMS_Ptr.OK_Flag = true;
          ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Selected_Room_Type = (byte) this.dataGridView1.Rows[ModDoorLockSystem.Form_RoomTypeDMS_Ptr.selected_rowindex].Cells[this.roomTypeDataGridViewTextBoxColumn.Name].Value;
        }
      }
      catch
      {
        ModDoorLockSystem.Form_RoomTypeDMS_Ptr.OK_Flag = false;
      }
      this.Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      ModDoorLockSystem.Form_RoomTypeDMS_Ptr.OK_Flag = false;
      this.Close();
    }

    private void dataGridView1_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet.RoomType.Rows.Count || this.dataGridView1.Rows.Count != ModDoorLockSystem.Form_RoomTypeDMS_Ptr.Browse_RoomType_DataSet.RoomType.Rows.Count)
        return;
      ModDoorLockSystem.Form_RoomTypeDMS_Ptr.selected_rowindex = e.Row.Index;
    }

    private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Check_Selected_Order();
      this.Check_Selected_Search();
      this.Load_RoomType_Data();
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      this.Check_Selected_Order();
      this.Check_Selected_Search();
      this.Load_RoomType_Data();
    }

    private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.txtSearch.Text = "";
    }

    private void cboSearch_KeyDown(object sender, KeyEventArgs e) => e.Handled = true;

    private void cboSearch_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    private void cboOrder_KeyDown(object sender, KeyEventArgs e) => e.Handled = true;

    private void cboOrder_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

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
      this.cboOrder = new ComboBox();
      this.txtSearch = new TextBox();
      this.cmdSelect = new Button();
      this.cmdCancel = new Button();
      this.cboSearch = new ComboBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.dataGridView1 = new DataGridView();
      this.roomTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.rmDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.maxCardDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.minCardDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.staffIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.updateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      this.roomTypeBindingSource = new BindingSource(this.components);
      this.systemDataSet = new SystemDataSet();
      this.roomTypeTableAdapter = new RoomTypeTableAdapter();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.roomTypeBindingSource).BeginInit();
      this.systemDataSet.BeginInit();
      this.SuspendLayout();
      this.cboOrder.BackColor = SystemColors.Window;
      this.cboOrder.Cursor = Cursors.Default;
      this.cboOrder.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboOrder.ForeColor = SystemColors.WindowText;
      this.cboOrder.Location = new Point(85, 490);
      this.cboOrder.Name = "cboOrder";
      this.cboOrder.RightToLeft = RightToLeft.No;
      this.cboOrder.Size = new Size(145, 22);
      this.cboOrder.TabIndex = 13;
      this.cboOrder.SelectedIndexChanged += new EventHandler(this.cboOrder_SelectedIndexChanged);
      this.cboOrder.KeyPress += new KeyPressEventHandler(this.cboOrder_KeyPress);
      this.cboOrder.KeyDown += new KeyEventHandler(this.cboOrder_KeyDown);
      this.txtSearch.AcceptsReturn = true;
      this.txtSearch.BackColor = SystemColors.Window;
      this.txtSearch.Cursor = Cursors.IBeam;
      this.txtSearch.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtSearch.ForeColor = SystemColors.WindowText;
      this.txtSearch.Location = new Point(245, 458);
      this.txtSearch.MaxLength = 0;
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.RightToLeft = RightToLeft.No;
      this.txtSearch.Size = new Size(145, 20);
      this.txtSearch.TabIndex = 12;
      this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
      this.cmdSelect.BackColor = SystemColors.Control;
      this.cmdSelect.Cursor = Cursors.Default;
      this.cmdSelect.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdSelect.ForeColor = SystemColors.ControlText;
      this.cmdSelect.Location = new Point(173, 530);
      this.cmdSelect.Name = "cmdSelect";
      this.cmdSelect.RightToLeft = RightToLeft.No;
      this.cmdSelect.Size = new Size(73, 25);
      this.cmdSelect.TabIndex = 11;
      this.cmdSelect.Text = "&Select";
      this.cmdSelect.UseVisualStyleBackColor = false;
      this.cmdSelect.Click += new EventHandler(this.cmdSelect_Click);
      this.cmdCancel.BackColor = SystemColors.Control;
      this.cmdCancel.Cursor = Cursors.Default;
      this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdCancel.ForeColor = SystemColors.ControlText;
      this.cmdCancel.Location = new Point(285, 530);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.RightToLeft = RightToLeft.No;
      this.cmdCancel.Size = new Size(73, 25);
      this.cmdCancel.TabIndex = 10;
      this.cmdCancel.Text = "&Cancel";
      this.cmdCancel.UseVisualStyleBackColor = false;
      this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
      this.cboSearch.BackColor = SystemColors.Window;
      this.cboSearch.Cursor = Cursors.Default;
      this.cboSearch.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboSearch.ForeColor = SystemColors.WindowText;
      this.cboSearch.Location = new Point(85, 458);
      this.cboSearch.Name = "cboSearch";
      this.cboSearch.RightToLeft = RightToLeft.No;
      this.cboSearch.Size = new Size(145, 22);
      this.cboSearch.TabIndex = 9;
      this.cboSearch.SelectedIndexChanged += new EventHandler(this.cboSearch_SelectedIndexChanged);
      this.cboSearch.KeyPress += new KeyPressEventHandler(this.cboSearch_KeyPress);
      this.cboSearch.KeyDown += new KeyEventHandler(this.cboSearch_KeyDown);
      this.Label1.BackColor = SystemColors.Control;
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ControlText;
      this.Label1.Location = new Point(13, 458);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(73, 21);
      this.Label1.TabIndex = 15;
      this.Label1.Text = "Search For:";
      this.Label2.BackColor = SystemColors.Control;
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(13, 490);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(81, 21);
      this.Label2.TabIndex = 14;
      this.Label2.Text = "Order By:";
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.roomTypeDataGridViewTextBoxColumn, (DataGridViewColumn) this.rmDescriptionDataGridViewTextBoxColumn, (DataGridViewColumn) this.maxCardDataGridViewTextBoxColumn, (DataGridViewColumn) this.minCardDataGridViewTextBoxColumn, (DataGridViewColumn) this.staffIDDataGridViewTextBoxColumn, (DataGridViewColumn) this.updateDataGridViewCheckBoxColumn);
      this.dataGridView1.DataSource = (object) this.roomTypeBindingSource;
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle.BackColor = Color.FromArgb(155, 183, 225);
      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle.ForeColor = Color.Red;
      gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle.WrapMode = DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = gridViewCellStyle;
      this.dataGridView1.Location = new Point(-2, 0);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(783, 434);
      this.dataGridView1.TabIndex = 16;
      this.dataGridView1.RowStateChanged += new DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
      this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
      this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
      this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
      this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.rmDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RmDescription";
      this.rmDescriptionDataGridViewTextBoxColumn.FillWeight = 300f;
      this.rmDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
      this.rmDescriptionDataGridViewTextBoxColumn.Name = "rmDescriptionDataGridViewTextBoxColumn";
      this.rmDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
      this.rmDescriptionDataGridViewTextBoxColumn.Width = 300;
      this.maxCardDataGridViewTextBoxColumn.DataPropertyName = "MaxCard";
      this.maxCardDataGridViewTextBoxColumn.HeaderText = "MaxCard";
      this.maxCardDataGridViewTextBoxColumn.Name = "maxCardDataGridViewTextBoxColumn";
      this.maxCardDataGridViewTextBoxColumn.ReadOnly = true;
      this.maxCardDataGridViewTextBoxColumn.Visible = false;
      this.minCardDataGridViewTextBoxColumn.DataPropertyName = "MinCard";
      this.minCardDataGridViewTextBoxColumn.HeaderText = "MinCard";
      this.minCardDataGridViewTextBoxColumn.Name = "minCardDataGridViewTextBoxColumn";
      this.minCardDataGridViewTextBoxColumn.ReadOnly = true;
      this.minCardDataGridViewTextBoxColumn.Visible = false;
      this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
      this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
      this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.staffIDDataGridViewTextBoxColumn.Visible = false;
      this.updateDataGridViewCheckBoxColumn.DataPropertyName = "Update";
      this.updateDataGridViewCheckBoxColumn.HeaderText = "Update";
      this.updateDataGridViewCheckBoxColumn.Name = "updateDataGridViewCheckBoxColumn";
      this.updateDataGridViewCheckBoxColumn.ReadOnly = true;
      this.updateDataGridViewCheckBoxColumn.Visible = false;
      this.roomTypeBindingSource.DataMember = "RoomType";
      this.roomTypeBindingSource.DataSource = (object) this.systemDataSet;
      this.systemDataSet.DataSetName = "SystemDataSet";
      this.systemDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.roomTypeTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.White;
      this.ClientSize = new Size(793, 573);
      this.ControlBox = false;
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.cboOrder);
      this.Controls.Add((Control) this.txtSearch);
      this.Controls.Add((Control) this.cmdSelect);
      this.Controls.Add((Control) this.cmdCancel);
      this.Controls.Add((Control) this.cboSearch);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label2);
      this.Name = "Form_RoomTypebwr";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Room Type Browser";
      this.Load += new EventHandler(this.Form_RmStatusbwr_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.roomTypeBindingSource).EndInit();
      this.systemDataSet.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
