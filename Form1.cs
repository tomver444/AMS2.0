// Decompiled with JetBrains decompiler
// Type: AMS.Form1
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
  public class Form1 : Form
  {
    private IContainer components;
    private DataGridView dataGridView1;
    private SystemDataSet systemDataSet;
    private BindingSource roomBindingSource;
    private RoomTableAdapter roomTableAdapter;
    private DataGridViewTextBoxColumn RoomTextBoxColumn1;
    private DataGridViewTextBoxColumn RoomTextBoxColumn2;
    private DataGridViewTextBoxColumn RoomTextBoxColumn3;
    public DataGridView dataGridView2;
    private DataGridView dataGridView3;
    private TabControl tabControl1;
    private TabPage Level1;
    private TabPage Level2;
    private DataGridView dataGridView4;
    private TabPage Level3;
    private DataGridView dataGridView5;
    private TabPage Level4;
    private DataGridView dataGridView6;
    private TabPage All_Level;
    private DataGridView dataGridView7;
    private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dailyRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weeklyRateDataGridViewTextBoxColumn;
    private Button button1;
    private Color Reserved_Back_Color = Color.FromArgb((int) byte.MaxValue, 128, 128);
    private Color Occupied_Back_Color = Color.Red;
    private Color Vacant_Back_Color = Color.Cyan;
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.dataGridView1 = new DataGridView();
      this.roomNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.dailyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.weeklyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.roomBindingSource = new BindingSource(this.components);
      this.systemDataSet = new SystemDataSet();
      this.roomTableAdapter = new RoomTableAdapter();
      this.dataGridView2 = new DataGridView();
      this.dataGridView3 = new DataGridView();
      this.tabControl1 = new TabControl();
      this.Level1 = new TabPage();
      this.Level2 = new TabPage();
      this.dataGridView4 = new DataGridView();
      this.Level3 = new TabPage();
      this.dataGridView5 = new DataGridView();
      this.Level4 = new TabPage();
      this.dataGridView6 = new DataGridView();
      this.All_Level = new TabPage();
      this.dataGridView7 = new DataGridView();
      this.button1 = new Button();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.roomBindingSource).BeginInit();
      this.systemDataSet.BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      ((ISupportInitialize) this.dataGridView3).BeginInit();
      this.tabControl1.SuspendLayout();
      this.Level1.SuspendLayout();
      this.Level2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView4).BeginInit();
      this.Level3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView5).BeginInit();
      this.Level4.SuspendLayout();
      ((ISupportInitialize) this.dataGridView6).BeginInit();
      this.All_Level.SuspendLayout();
      ((ISupportInitialize) this.dataGridView7).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.roomNoDataGridViewTextBoxColumn, (DataGridViewColumn) this.dailyRateDataGridViewTextBoxColumn, (DataGridViewColumn) this.weeklyRateDataGridViewTextBoxColumn);
      this.dataGridView1.Cursor = Cursors.Hand;
      this.dataGridView1.DataSource = (object) this.roomBindingSource;
      this.dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView1.GridColor = SystemColors.AppWorkspace;
      this.dataGridView1.Location = new Point(573, 28);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 120;
      this.dataGridView1.RowTemplate.DividerHeight = 5;
      this.dataGridView1.RowTemplate.Height = 50;
      this.dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView1.ShowEditingIcon = false;
      this.dataGridView1.Size = new Size(398, 574);
      this.dataGridView1.TabIndex = 0;
      this.roomNoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle1.ForeColor = SystemColors.ControlText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
      gridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.roomNoDataGridViewTextBoxColumn.DefaultCellStyle = gridViewCellStyle1;
      this.roomNoDataGridViewTextBoxColumn.DividerWidth = 5;
      this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
      this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
      this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
      this.roomNoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
      this.roomNoDataGridViewTextBoxColumn.Width = 120;
      this.dailyRateDataGridViewTextBoxColumn.DataPropertyName = "DailyRate";
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = Color.Transparent;
      gridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.dailyRateDataGridViewTextBoxColumn.DefaultCellStyle = gridViewCellStyle2;
      this.dailyRateDataGridViewTextBoxColumn.DividerWidth = 5;
      this.dailyRateDataGridViewTextBoxColumn.HeaderText = "DailyRate";
      this.dailyRateDataGridViewTextBoxColumn.Name = "dailyRateDataGridViewTextBoxColumn";
      this.dailyRateDataGridViewTextBoxColumn.ReadOnly = true;
      this.dailyRateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
      this.dailyRateDataGridViewTextBoxColumn.Width = 120;
      this.weeklyRateDataGridViewTextBoxColumn.DataPropertyName = "WeeklyRate";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = Color.Transparent;
      gridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.weeklyRateDataGridViewTextBoxColumn.DefaultCellStyle = gridViewCellStyle3;
      this.weeklyRateDataGridViewTextBoxColumn.HeaderText = "WeeklyRate";
      this.weeklyRateDataGridViewTextBoxColumn.Name = "weeklyRateDataGridViewTextBoxColumn";
      this.weeklyRateDataGridViewTextBoxColumn.ReadOnly = true;
      this.weeklyRateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
      this.weeklyRateDataGridViewTextBoxColumn.Width = 120;
      this.roomBindingSource.DataMember = "Room";
      this.roomBindingSource.DataSource = (object) this.systemDataSet;
      this.systemDataSet.DataSetName = "SystemDataSet";
      this.systemDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.roomTableAdapter.ClearBeforeFill = true;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(424, 582);
      this.dataGridView2.MultiSelect = false;
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridView2.RowTemplate.Height = 24;
      this.dataGridView2.Size = new Size(66, 36);
      this.dataGridView2.TabIndex = 4;
      this.dataGridView2.VirtualMode = true;
      this.dataGridView3.AllowUserToAddRows = false;
      this.dataGridView3.AllowUserToDeleteRows = false;
      this.dataGridView3.AllowUserToResizeColumns = false;
      this.dataGridView3.AllowUserToResizeRows = false;
      this.dataGridView3.BorderStyle = BorderStyle.None;
      this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView3.ColumnHeadersVisible = false;
      this.dataGridView3.Cursor = Cursors.Hand;
      this.dataGridView3.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView3.GridColor = SystemColors.AppWorkspace;
      this.dataGridView3.Location = new Point(28, 52);
      this.dataGridView3.MultiSelect = false;
      this.dataGridView3.Name = "dataGridView3";
      this.dataGridView3.ReadOnly = true;
      this.dataGridView3.RowHeadersVisible = false;
      this.dataGridView3.RowHeadersWidth = 100;
      this.dataGridView3.RowTemplate.DividerHeight = 5;
      this.dataGridView3.RowTemplate.Height = 60;
      this.dataGridView3.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView3.ShowEditingIcon = false;
      this.dataGridView3.Size = new Size(510, 427);
      this.dataGridView3.TabIndex = 5;
      this.dataGridView3.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
      this.dataGridView3.CellClick += new DataGridViewCellEventHandler(this.dataGridView3_CellClick);
      this.tabControl1.Controls.Add((Control) this.Level1);
      this.tabControl1.Controls.Add((Control) this.Level2);
      this.tabControl1.Controls.Add((Control) this.Level3);
      this.tabControl1.Controls.Add((Control) this.Level4);
      this.tabControl1.Controls.Add((Control) this.All_Level);
      this.tabControl1.Location = new Point(2, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(549, 511);
      this.tabControl1.TabIndex = 6;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.Level1.BackColor = SystemColors.AppWorkspace;
      this.Level1.Controls.Add((Control) this.dataGridView3);
      this.Level1.Location = new Point(4, 25);
      this.Level1.Name = "Level1";
      this.Level1.Padding = new Padding(3);
      this.Level1.Size = new Size(541, 482);
      this.Level1.TabIndex = 0;
      this.Level1.Text = "Level 1";
      this.Level2.BackColor = SystemColors.AppWorkspace;
      this.Level2.Controls.Add((Control) this.dataGridView4);
      this.Level2.Location = new Point(4, 25);
      this.Level2.Name = "Level2";
      this.Level2.Padding = new Padding(3);
      this.Level2.Size = new Size(541, 482);
      this.Level2.TabIndex = 1;
      this.Level2.Text = "Level 2";
      this.dataGridView4.AllowUserToAddRows = false;
      this.dataGridView4.AllowUserToDeleteRows = false;
      this.dataGridView4.AllowUserToResizeColumns = false;
      this.dataGridView4.AllowUserToResizeRows = false;
      this.dataGridView4.BorderStyle = BorderStyle.None;
      this.dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView4.ColumnHeadersVisible = false;
      this.dataGridView4.Cursor = Cursors.Hand;
      this.dataGridView4.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView4.GridColor = SystemColors.AppWorkspace;
      this.dataGridView4.Location = new Point(17, 30);
      this.dataGridView4.MultiSelect = false;
      this.dataGridView4.Name = "dataGridView4";
      this.dataGridView4.ReadOnly = true;
      this.dataGridView4.RowHeadersVisible = false;
      this.dataGridView4.RowHeadersWidth = 100;
      this.dataGridView4.RowTemplate.DividerHeight = 5;
      this.dataGridView4.RowTemplate.Height = 60;
      this.dataGridView4.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView4.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView4.ShowEditingIcon = false;
      this.dataGridView4.Size = new Size(521, 449);
      this.dataGridView4.TabIndex = 6;
      this.dataGridView4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView4_CellDoubleClick);
      this.dataGridView4.CellClick += new DataGridViewCellEventHandler(this.dataGridView4_CellClick);
      this.Level3.BackColor = SystemColors.AppWorkspace;
      this.Level3.Controls.Add((Control) this.dataGridView5);
      this.Level3.Location = new Point(4, 25);
      this.Level3.Name = "Level3";
      this.Level3.Padding = new Padding(3);
      this.Level3.Size = new Size(541, 482);
      this.Level3.TabIndex = 2;
      this.Level3.Text = "Level 3";
      this.dataGridView5.AllowUserToAddRows = false;
      this.dataGridView5.AllowUserToDeleteRows = false;
      this.dataGridView5.AllowUserToResizeColumns = false;
      this.dataGridView5.AllowUserToResizeRows = false;
      this.dataGridView5.BorderStyle = BorderStyle.None;
      this.dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView5.ColumnHeadersVisible = false;
      this.dataGridView5.Cursor = Cursors.Hand;
      this.dataGridView5.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView5.GridColor = SystemColors.AppWorkspace;
      this.dataGridView5.Location = new Point(27, 37);
      this.dataGridView5.MultiSelect = false;
      this.dataGridView5.Name = "dataGridView5";
      this.dataGridView5.ReadOnly = true;
      this.dataGridView5.RowHeadersVisible = false;
      this.dataGridView5.RowHeadersWidth = 100;
      this.dataGridView5.RowTemplate.DividerHeight = 5;
      this.dataGridView5.RowTemplate.Height = 60;
      this.dataGridView5.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView5.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView5.ShowEditingIcon = false;
      this.dataGridView5.Size = new Size(511, 442);
      this.dataGridView5.TabIndex = 7;
      this.dataGridView5.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView5_CellDoubleClick);
      this.dataGridView5.CellClick += new DataGridViewCellEventHandler(this.dataGridView5_CellClick);
      this.Level4.BackColor = SystemColors.AppWorkspace;
      this.Level4.Controls.Add((Control) this.dataGridView6);
      this.Level4.Location = new Point(4, 25);
      this.Level4.Name = "Level4";
      this.Level4.Padding = new Padding(3);
      this.Level4.Size = new Size(541, 482);
      this.Level4.TabIndex = 3;
      this.Level4.Text = "Level 4";
      this.dataGridView6.AllowUserToAddRows = false;
      this.dataGridView6.AllowUserToDeleteRows = false;
      this.dataGridView6.AllowUserToResizeColumns = false;
      this.dataGridView6.AllowUserToResizeRows = false;
      this.dataGridView6.BorderStyle = BorderStyle.None;
      this.dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView6.ColumnHeadersVisible = false;
      this.dataGridView6.Cursor = Cursors.Hand;
      this.dataGridView6.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView6.GridColor = SystemColors.AppWorkspace;
      this.dataGridView6.Location = new Point(23, 28);
      this.dataGridView6.MultiSelect = false;
      this.dataGridView6.Name = "dataGridView6";
      this.dataGridView6.ReadOnly = true;
      this.dataGridView6.RowHeadersVisible = false;
      this.dataGridView6.RowHeadersWidth = 100;
      this.dataGridView6.RowTemplate.DividerHeight = 5;
      this.dataGridView6.RowTemplate.Height = 60;
      this.dataGridView6.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView6.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView6.ShowEditingIcon = false;
      this.dataGridView6.Size = new Size(515, 451);
      this.dataGridView6.TabIndex = 7;
      this.dataGridView6.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView6_CellDoubleClick);
      this.dataGridView6.CellClick += new DataGridViewCellEventHandler(this.dataGridView6_CellClick);
      this.All_Level.BackColor = SystemColors.AppWorkspace;
      this.All_Level.Controls.Add((Control) this.dataGridView7);
      this.All_Level.Location = new Point(4, 25);
      this.All_Level.Name = "All_Level";
      this.All_Level.Padding = new Padding(3);
      this.All_Level.Size = new Size(541, 482);
      this.All_Level.TabIndex = 4;
      this.All_Level.Text = "All";
      this.dataGridView7.AllowUserToAddRows = false;
      this.dataGridView7.AllowUserToDeleteRows = false;
      this.dataGridView7.AllowUserToResizeColumns = false;
      this.dataGridView7.AllowUserToResizeRows = false;
      this.dataGridView7.BorderStyle = BorderStyle.None;
      this.dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView7.ColumnHeadersVisible = false;
      this.dataGridView7.Cursor = Cursors.Hand;
      this.dataGridView7.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView7.GridColor = SystemColors.AppWorkspace;
      this.dataGridView7.Location = new Point(17, 23);
      this.dataGridView7.MultiSelect = false;
      this.dataGridView7.Name = "dataGridView7";
      this.dataGridView7.ReadOnly = true;
      this.dataGridView7.RowHeadersVisible = false;
      this.dataGridView7.RowHeadersWidth = 100;
      this.dataGridView7.RowTemplate.DividerHeight = 5;
      this.dataGridView7.RowTemplate.Height = 60;
      this.dataGridView7.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView7.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView7.ShowEditingIcon = false;
      this.dataGridView7.Size = new Size(521, 456);
      this.dataGridView7.TabIndex = 7;
      this.dataGridView7.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView7_CellDoubleClick);
      this.dataGridView7.CellClick += new DataGridViewCellEventHandler(this.dataGridView7_CellClick);
      this.button1.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.button1.Location = new Point(227, 637);
      this.button1.Name = "button1";
      this.button1.Size = new Size(121, 51);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1005, 878);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.dataGridView2);
      this.Controls.Add((Control) this.dataGridView1);
      this.Cursor = Cursors.Arrow;
      this.Margin = new Padding(4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new EventHandler(this.Form1_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.roomBindingSource).EndInit();
      this.systemDataSet.EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      ((ISupportInitialize) this.dataGridView3).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.Level1.ResumeLayout(false);
      this.Level2.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView4).EndInit();
      this.Level3.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView5).EndInit();
      this.Level4.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView6).EndInit();
      this.All_Level.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView7).EndInit();
      this.ResumeLayout(false);
    }

    private void Init_DataGrid_View(DataGridView para_DataGridView)
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      para_DataGridView.Columns.AddRange((DataGridViewColumn) viewTextBoxColumn4, (DataGridViewColumn) viewTextBoxColumn3, (DataGridViewColumn) viewTextBoxColumn2, (DataGridViewColumn) viewTextBoxColumn1);
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.SelectionBackColor = Color.Transparent;
      gridViewCellStyle.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle.WrapMode = DataGridViewTriState.True;
      viewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn4.DividerWidth = 5;
      viewTextBoxColumn4.HeaderText = "RoomNo";
      viewTextBoxColumn4.Name = "local_dataGridViewTextBoxColumn1";
      viewTextBoxColumn4.ReadOnly = true;
      viewTextBoxColumn4.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn4.Width = 120;
      viewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn3.DividerWidth = 5;
      viewTextBoxColumn3.HeaderText = "RoomNo";
      viewTextBoxColumn3.Name = "local_dataGridViewTextBoxColumn2";
      viewTextBoxColumn3.ReadOnly = true;
      viewTextBoxColumn3.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn3.Width = 120;
      viewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn2.DividerWidth = 5;
      viewTextBoxColumn2.HeaderText = "RoomNo";
      viewTextBoxColumn2.Name = "local_dataGridViewTextBoxColumn3";
      viewTextBoxColumn2.ReadOnly = true;
      viewTextBoxColumn2.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn2.Width = 120;
      viewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn1.DividerWidth = 5;
      viewTextBoxColumn1.HeaderText = "RoomNo";
      viewTextBoxColumn1.Name = "local_dataGridViewTextBoxColumn4";
      viewTextBoxColumn1.ReadOnly = true;
      viewTextBoxColumn1.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn1.Width = 120;
    }

    public Form1()
    {
      this.InitializeComponent();
      this.Init_DataGrid_View(this.dataGridView3);
      this.Init_DataGrid_View(this.dataGridView4);
      this.Init_DataGrid_View(this.dataGridView5);
      this.Init_DataGrid_View(this.dataGridView6);
      this.Init_DataGrid_View(this.dataGridView7);
    }

    private void Disable_AutoSelected_Cell(DataGridView para_DataGridView)
    {
      for (int index1 = 0; index1 < para_DataGridView.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < para_DataGridView.ColumnCount; ++index2)
        {
          if (para_DataGridView.Rows[index1].Cells[index2].Selected)
            para_DataGridView.Rows[index1].Cells[index2].Selected = false;
        }
      }
    }

    private void Setup_Rooms_In_DataGridView_forAllLevel(
      DataGridView para_DataGridView,
      DataTable para_DataTable)
    {
      para_DataGridView.Rows.Clear();
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "01", 0, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "02", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "03", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "04", para_DataGridView.Rows.Count, 0, true);
    }

    private void Setup_Rooms_In_DataGridView(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No)
    {
      int index1 = 0;
      int index2 = 0;
      para_DataGridView.Rows.Clear();
      if (!(para_DataTable is SystemDataSet.RoomDataTable))
        return;
      if (para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index3 = 0; index3 < para_DataTable.Rows.Count; ++index3)
      {
        if (((SystemDataSet.RoomRow) para_DataTable.Rows[index3]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (index2 < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[index1].Cells[index2].Value = (object) ((SystemDataSet.RoomRow) para_DataTable.Rows[index3]).RoomNo;
            para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = this.Vacant_Back_Color;
            ++index2;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            int index4 = 0;
            ++index1;
            para_DataGridView.Rows[index1].Cells[index4].Value = (object) ((SystemDataSet.RoomRow) para_DataTable.Rows[index3]).RoomNo;
            para_DataGridView.Rows[index1].Cells[index4].Style.BackColor = this.Vacant_Back_Color;
            index2 = index4 + 1;
          }
        }
      }
      if (para_DataTable.Rows.Count > 0)
      {
        for (; index2 < para_DataGridView.ColumnCount; ++index2)
          para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = para_DataGridView.BackgroundColor;
      }
      para_DataGridView.Rows[1].Cells[2].Style.BackColor = this.Reserved_Back_Color;
    }

    private void Insert_Rooms_In_DataGridView_Relative(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No,
      int para_dataGridView_CurrentRow,
      int para_dataGridView_CurrentColumn,
      bool Add_Blank_Row_Flag)
    {
      if (!(para_DataTable is SystemDataSet.RoomDataTable))
        return;
      if (para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index = 0; index < para_DataTable.Rows.Count; ++index)
      {
        if (((SystemDataSet.RoomRow) para_DataTable.Rows[index]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) (((SystemDataSet.RoomRow) para_DataTable.Rows[index]).RoomNo + "     (Level 1) ");
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = this.Vacant_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            para_dataGridView_CurrentColumn = 0;
            ++para_dataGridView_CurrentRow;
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) (((SystemDataSet.RoomRow) para_DataTable.Rows[index]).RoomNo + "     (Level 1) ");
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = this.Vacant_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
        }
      }
      if (para_DataTable.Rows.Count > 0)
      {
        for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
        {
          para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
          para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
        }
        if (Add_Blank_Row_Flag)
        {
          para_DataGridView.Rows.Add(1);
          para_dataGridView_CurrentColumn = 0;
          ++para_dataGridView_CurrentRow;
          for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
          {
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
          }
          para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[0].Style.ForeColor = Color.Red;
          para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[0].Value = (object) ("Level" + Convert.ToInt16(para_Level_No).ToString());
          para_DataGridView.Rows.Add(1);
          para_dataGridView_CurrentColumn = 0;
          ++para_dataGridView_CurrentRow;
          for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
          {
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
          }
        }
      }
      para_DataGridView.Rows[1].Cells[2].Style.BackColor = this.Reserved_Back_Color;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.roomBindingSource.DataSource = (object) this.db.system_DB.systemDataSet.Room;
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      for (int index = 0; index < this.dataGridView1.ColumnCount; ++index)
      {
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0].Style.BackColor = Color.Wheat;
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0].Value = (object) "Htay";
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Value = (object) "";
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[2].Value = (object) "";
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Style.BackColor = this.dataGridView1.BackgroundColor;
        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[2].Style.BackColor = this.dataGridView1.BackgroundColor;
      }
      this.dataGridView1.Refresh();
      this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView7, (DataTable) this.db.system_DB.systemDataSet.Room);
      this.Setup_Rooms_In_DataGridView(this.dataGridView3, (DataTable) this.db.system_DB.systemDataSet.Room, "01");
      this.Setup_Rooms_In_DataGridView(this.dataGridView4, (DataTable) this.db.system_DB.systemDataSet.Room, "02");
      this.Setup_Rooms_In_DataGridView(this.dataGridView5, (DataTable) this.db.system_DB.systemDataSet.Room, "03");
      this.Setup_Rooms_In_DataGridView(this.dataGridView6, (DataTable) this.db.system_DB.systemDataSet.Room, "04");
      this.Disable_AutoSelected_Cell(this.dataGridView3);
    }

    private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView3.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView4.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView5.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView6.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView3.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView4.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView5.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView6.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex <= 0)
        return;
      if (this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView7.Refresh();
      }
      try
      {
        if (!((string) this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && !((string) this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") && this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      catch
      {
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex <= 0)
        return;
      if (this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView7.Refresh();
      }
      try
      {
        if (!((string) this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && !((string) this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") && this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      catch
      {
        this.dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tabControl1.SelectedTab == this.Level1)
        this.Disable_AutoSelected_Cell(this.dataGridView3);
      else if (this.tabControl1.SelectedTab == this.Level2)
        this.Disable_AutoSelected_Cell(this.dataGridView4);
      else if (this.tabControl1.SelectedTab == this.Level3)
        this.Disable_AutoSelected_Cell(this.dataGridView5);
      else if (this.tabControl1.SelectedTab == this.Level4)
      {
        this.Disable_AutoSelected_Cell(this.dataGridView6);
      }
      else
      {
        if (this.tabControl1.SelectedTab != this.All_Level)
          return;
        this.Disable_AutoSelected_Cell(this.dataGridView7);
      }
    }
  }
}
