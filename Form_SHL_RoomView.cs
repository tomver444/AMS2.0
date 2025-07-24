// Decompiled with JetBrains decompiler
// Type: AMS.Form_SHL_RoomView
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
  public class Form_SHL_RoomView : Form
  {
    private IContainer components;
    private TabControl tabControl1;
    private TabPage Level1;
    private DataGridView dataGridView_Tab1;
    private TabPage Level2;
    private DataGridView dataGridView_Tab2;
    private TabPage Level3;
    private DataGridView dataGridView_Tab3;
    private TabPage Level4;
    private DataGridView dataGridView_Tab4;
    private TabPage Level5;
    private DataGridView dataGridView_Tab5;
    private TabPage Level6;
    private DataGridView dataGridView_Tab6;
    private TabPage Level7;
    private DataGridView dataGridView_Tab7;
    private TabPage All_Level;
    private DataGridView dataGridView_Tab8;
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
      this.tabControl1 = new TabControl();
      this.Level1 = new TabPage();
      this.dataGridView_Tab1 = new DataGridView();
      this.Level2 = new TabPage();
      this.dataGridView_Tab2 = new DataGridView();
      this.Level3 = new TabPage();
      this.dataGridView_Tab3 = new DataGridView();
      this.Level4 = new TabPage();
      this.dataGridView_Tab4 = new DataGridView();
      this.Level5 = new TabPage();
      this.dataGridView_Tab5 = new DataGridView();
      this.Level6 = new TabPage();
      this.dataGridView_Tab6 = new DataGridView();
      this.Level7 = new TabPage();
      this.dataGridView_Tab7 = new DataGridView();
      this.All_Level = new TabPage();
      this.dataGridView_Tab8 = new DataGridView();
      this.tabControl1.SuspendLayout();
      this.Level1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab1).BeginInit();
      this.Level2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab2).BeginInit();
      this.Level3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab3).BeginInit();
      this.Level4.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab4).BeginInit();
      this.Level5.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab5).BeginInit();
      this.Level6.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab6).BeginInit();
      this.Level7.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab7).BeginInit();
      this.All_Level.SuspendLayout();
      ((ISupportInitialize) this.dataGridView_Tab8).BeginInit();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.Level1);
      this.tabControl1.Controls.Add((Control) this.Level2);
      this.tabControl1.Controls.Add((Control) this.Level3);
      this.tabControl1.Controls.Add((Control) this.Level4);
      this.tabControl1.Controls.Add((Control) this.Level5);
      this.tabControl1.Controls.Add((Control) this.Level6);
      this.tabControl1.Controls.Add((Control) this.Level7);
      this.tabControl1.Controls.Add((Control) this.All_Level);
      this.tabControl1.Font = new Font("Arial", 9f);
      this.tabControl1.Location = new Point(9, 10);
      this.tabControl1.Margin = new Padding(2, 2, 2, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(424, 499);
      this.tabControl1.TabIndex = 7;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.Level1.BackColor = SystemColors.AppWorkspace;
      this.Level1.Controls.Add((Control) this.dataGridView_Tab1);
      this.Level1.Location = new Point(4, 24);
      this.Level1.Margin = new Padding(2, 2, 2, 2);
      this.Level1.Name = "Level1";
      this.Level1.Padding = new Padding(2, 2, 2, 2);
      this.Level1.Size = new Size(416, 471);
      this.Level1.TabIndex = 0;
      this.Level1.Text = "Level 1";
      this.dataGridView_Tab1.AllowUserToAddRows = false;
      this.dataGridView_Tab1.AllowUserToDeleteRows = false;
      this.dataGridView_Tab1.AllowUserToResizeColumns = false;
      this.dataGridView_Tab1.AllowUserToResizeRows = false;
      this.dataGridView_Tab1.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab1.ColumnHeadersVisible = false;
      this.dataGridView_Tab1.Cursor = Cursors.Hand;
      this.dataGridView_Tab1.Dock = DockStyle.Fill;
      this.dataGridView_Tab1.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab1.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab1.Location = new Point(2, 2);
      this.dataGridView_Tab1.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab1.MultiSelect = false;
      this.dataGridView_Tab1.Name = "dataGridView_Tab1";
      this.dataGridView_Tab1.ReadOnly = true;
      this.dataGridView_Tab1.RowHeadersVisible = false;
      this.dataGridView_Tab1.RowHeadersWidth = 100;
      this.dataGridView_Tab1.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab1.RowTemplate.Height = 60;
      this.dataGridView_Tab1.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab1.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab1.ShowEditingIcon = false;
      this.dataGridView_Tab1.Size = new Size(412, 467);
      this.dataGridView_Tab1.TabIndex = 5;
      this.dataGridView_Tab1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
      this.dataGridView_Tab1.CellClick += new DataGridViewCellEventHandler(this.dataGridView3_CellClick);
      this.Level2.BackColor = SystemColors.AppWorkspace;
      this.Level2.Controls.Add((Control) this.dataGridView_Tab2);
      this.Level2.Location = new Point(4, 24);
      this.Level2.Margin = new Padding(2, 2, 2, 2);
      this.Level2.Name = "Level2";
      this.Level2.Padding = new Padding(2, 2, 2, 2);
      this.Level2.Size = new Size(416, 471);
      this.Level2.TabIndex = 1;
      this.Level2.Text = "Level 2";
      this.dataGridView_Tab2.AllowUserToAddRows = false;
      this.dataGridView_Tab2.AllowUserToDeleteRows = false;
      this.dataGridView_Tab2.AllowUserToResizeColumns = false;
      this.dataGridView_Tab2.AllowUserToResizeRows = false;
      this.dataGridView_Tab2.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab2.ColumnHeadersVisible = false;
      this.dataGridView_Tab2.Cursor = Cursors.Hand;
      this.dataGridView_Tab2.Dock = DockStyle.Fill;
      this.dataGridView_Tab2.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab2.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab2.Location = new Point(2, 2);
      this.dataGridView_Tab2.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab2.MultiSelect = false;
      this.dataGridView_Tab2.Name = "dataGridView_Tab2";
      this.dataGridView_Tab2.ReadOnly = true;
      this.dataGridView_Tab2.RowHeadersVisible = false;
      this.dataGridView_Tab2.RowHeadersWidth = 100;
      this.dataGridView_Tab2.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab2.RowTemplate.Height = 60;
      this.dataGridView_Tab2.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab2.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab2.ShowEditingIcon = false;
      this.dataGridView_Tab2.Size = new Size(412, 467);
      this.dataGridView_Tab2.TabIndex = 6;
      this.dataGridView_Tab2.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView4_CellDoubleClick);
      this.dataGridView_Tab2.CellClick += new DataGridViewCellEventHandler(this.dataGridView4_CellClick);
      this.Level3.BackColor = SystemColors.AppWorkspace;
      this.Level3.Controls.Add((Control) this.dataGridView_Tab3);
      this.Level3.Location = new Point(4, 24);
      this.Level3.Margin = new Padding(2, 2, 2, 2);
      this.Level3.Name = "Level3";
      this.Level3.Padding = new Padding(2, 2, 2, 2);
      this.Level3.Size = new Size(416, 471);
      this.Level3.TabIndex = 2;
      this.Level3.Text = "Level 3";
      this.dataGridView_Tab3.AllowUserToAddRows = false;
      this.dataGridView_Tab3.AllowUserToDeleteRows = false;
      this.dataGridView_Tab3.AllowUserToResizeColumns = false;
      this.dataGridView_Tab3.AllowUserToResizeRows = false;
      this.dataGridView_Tab3.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab3.ColumnHeadersVisible = false;
      this.dataGridView_Tab3.Cursor = Cursors.Hand;
      this.dataGridView_Tab3.Dock = DockStyle.Fill;
      this.dataGridView_Tab3.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab3.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab3.Location = new Point(2, 2);
      this.dataGridView_Tab3.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab3.MultiSelect = false;
      this.dataGridView_Tab3.Name = "dataGridView_Tab3";
      this.dataGridView_Tab3.ReadOnly = true;
      this.dataGridView_Tab3.RowHeadersVisible = false;
      this.dataGridView_Tab3.RowHeadersWidth = 100;
      this.dataGridView_Tab3.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab3.RowTemplate.Height = 60;
      this.dataGridView_Tab3.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab3.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab3.ShowEditingIcon = false;
      this.dataGridView_Tab3.Size = new Size(412, 467);
      this.dataGridView_Tab3.TabIndex = 7;
      this.dataGridView_Tab3.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView5_CellDoubleClick);
      this.dataGridView_Tab3.CellClick += new DataGridViewCellEventHandler(this.dataGridView5_CellClick);
      this.Level4.BackColor = SystemColors.AppWorkspace;
      this.Level4.Controls.Add((Control) this.dataGridView_Tab4);
      this.Level4.Location = new Point(4, 24);
      this.Level4.Margin = new Padding(2, 2, 2, 2);
      this.Level4.Name = "Level4";
      this.Level4.Padding = new Padding(2, 2, 2, 2);
      this.Level4.Size = new Size(416, 471);
      this.Level4.TabIndex = 3;
      this.Level4.Text = "Level 4";
      this.dataGridView_Tab4.AllowUserToAddRows = false;
      this.dataGridView_Tab4.AllowUserToDeleteRows = false;
      this.dataGridView_Tab4.AllowUserToResizeColumns = false;
      this.dataGridView_Tab4.AllowUserToResizeRows = false;
      this.dataGridView_Tab4.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab4.ColumnHeadersVisible = false;
      this.dataGridView_Tab4.Cursor = Cursors.Hand;
      this.dataGridView_Tab4.Dock = DockStyle.Fill;
      this.dataGridView_Tab4.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab4.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab4.Location = new Point(2, 2);
      this.dataGridView_Tab4.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab4.MultiSelect = false;
      this.dataGridView_Tab4.Name = "dataGridView_Tab4";
      this.dataGridView_Tab4.ReadOnly = true;
      this.dataGridView_Tab4.RowHeadersVisible = false;
      this.dataGridView_Tab4.RowHeadersWidth = 100;
      this.dataGridView_Tab4.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab4.RowTemplate.Height = 60;
      this.dataGridView_Tab4.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab4.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab4.ShowEditingIcon = false;
      this.dataGridView_Tab4.Size = new Size(412, 467);
      this.dataGridView_Tab4.TabIndex = 7;
      this.dataGridView_Tab4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView6_CellDoubleClick);
      this.dataGridView_Tab4.CellClick += new DataGridViewCellEventHandler(this.dataGridView6_CellClick);
      this.Level5.BackColor = SystemColors.AppWorkspace;
      this.Level5.Controls.Add((Control) this.dataGridView_Tab5);
      this.Level5.Location = new Point(4, 24);
      this.Level5.Margin = new Padding(2, 2, 2, 2);
      this.Level5.Name = "Level5";
      this.Level5.Padding = new Padding(2, 2, 2, 2);
      this.Level5.Size = new Size(416, 471);
      this.Level5.TabIndex = 4;
      this.Level5.Text = "Level 5";
      this.dataGridView_Tab5.AllowUserToAddRows = false;
      this.dataGridView_Tab5.AllowUserToDeleteRows = false;
      this.dataGridView_Tab5.AllowUserToResizeColumns = false;
      this.dataGridView_Tab5.AllowUserToResizeRows = false;
      this.dataGridView_Tab5.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab5.ColumnHeadersVisible = false;
      this.dataGridView_Tab5.Cursor = Cursors.Hand;
      this.dataGridView_Tab5.Dock = DockStyle.Fill;
      this.dataGridView_Tab5.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab5.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab5.Location = new Point(2, 2);
      this.dataGridView_Tab5.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab5.MultiSelect = false;
      this.dataGridView_Tab5.Name = "dataGridView_Tab5";
      this.dataGridView_Tab5.ReadOnly = true;
      this.dataGridView_Tab5.RowHeadersVisible = false;
      this.dataGridView_Tab5.RowHeadersWidth = 100;
      this.dataGridView_Tab5.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab5.RowTemplate.Height = 60;
      this.dataGridView_Tab5.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab5.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab5.ShowEditingIcon = false;
      this.dataGridView_Tab5.Size = new Size(412, 467);
      this.dataGridView_Tab5.TabIndex = 7;
      this.dataGridView_Tab5.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView7_CellDoubleClick);
      this.dataGridView_Tab5.CellClick += new DataGridViewCellEventHandler(this.dataGridView7_CellClick);
      this.Level6.BackColor = SystemColors.AppWorkspace;
      this.Level6.Controls.Add((Control) this.dataGridView_Tab6);
      this.Level6.Location = new Point(4, 24);
      this.Level6.Margin = new Padding(2, 2, 2, 2);
      this.Level6.Name = "Level6";
      this.Level6.Padding = new Padding(2, 2, 2, 2);
      this.Level6.Size = new Size(416, 471);
      this.Level6.TabIndex = 5;
      this.Level6.Text = "Level 6";
      this.dataGridView_Tab6.AllowUserToAddRows = false;
      this.dataGridView_Tab6.AllowUserToDeleteRows = false;
      this.dataGridView_Tab6.AllowUserToResizeColumns = false;
      this.dataGridView_Tab6.AllowUserToResizeRows = false;
      this.dataGridView_Tab6.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab6.ColumnHeadersVisible = false;
      this.dataGridView_Tab6.Cursor = Cursors.Hand;
      this.dataGridView_Tab6.Dock = DockStyle.Fill;
      this.dataGridView_Tab6.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab6.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab6.Location = new Point(2, 2);
      this.dataGridView_Tab6.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab6.MultiSelect = false;
      this.dataGridView_Tab6.Name = "dataGridView_Tab6";
      this.dataGridView_Tab6.ReadOnly = true;
      this.dataGridView_Tab6.RowHeadersVisible = false;
      this.dataGridView_Tab6.RowHeadersWidth = 100;
      this.dataGridView_Tab6.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab6.RowTemplate.Height = 60;
      this.dataGridView_Tab6.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab6.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab6.ShowEditingIcon = false;
      this.dataGridView_Tab6.Size = new Size(412, 467);
      this.dataGridView_Tab6.TabIndex = 7;
      this.dataGridView_Tab6.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView8_CellDoubleClick);
      this.dataGridView_Tab6.CellClick += new DataGridViewCellEventHandler(this.dataGridView8_CellClick);
      this.Level7.BackColor = SystemColors.AppWorkspace;
      this.Level7.Controls.Add((Control) this.dataGridView_Tab7);
      this.Level7.Location = new Point(4, 24);
      this.Level7.Margin = new Padding(2, 2, 2, 2);
      this.Level7.Name = "Level7";
      this.Level7.Padding = new Padding(2, 2, 2, 2);
      this.Level7.Size = new Size(416, 471);
      this.Level7.TabIndex = 6;
      this.Level7.Text = "Level 7";
      this.dataGridView_Tab7.AllowUserToAddRows = false;
      this.dataGridView_Tab7.AllowUserToDeleteRows = false;
      this.dataGridView_Tab7.AllowUserToResizeColumns = false;
      this.dataGridView_Tab7.AllowUserToResizeRows = false;
      this.dataGridView_Tab7.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab7.ColumnHeadersVisible = false;
      this.dataGridView_Tab7.Cursor = Cursors.Hand;
      this.dataGridView_Tab7.Dock = DockStyle.Fill;
      this.dataGridView_Tab7.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab7.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab7.Location = new Point(2, 2);
      this.dataGridView_Tab7.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab7.MultiSelect = false;
      this.dataGridView_Tab7.Name = "dataGridView_Tab7";
      this.dataGridView_Tab7.ReadOnly = true;
      this.dataGridView_Tab7.RowHeadersVisible = false;
      this.dataGridView_Tab7.RowHeadersWidth = 100;
      this.dataGridView_Tab7.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab7.RowTemplate.Height = 60;
      this.dataGridView_Tab7.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab7.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab7.ShowEditingIcon = false;
      this.dataGridView_Tab7.Size = new Size(412, 467);
      this.dataGridView_Tab7.TabIndex = 7;
      this.dataGridView_Tab7.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView9_CellDoubleClick);
      this.dataGridView_Tab7.CellClick += new DataGridViewCellEventHandler(this.dataGridView9_CellClick);
      this.All_Level.BackColor = SystemColors.AppWorkspace;
      this.All_Level.Controls.Add((Control) this.dataGridView_Tab8);
      this.All_Level.Location = new Point(4, 24);
      this.All_Level.Margin = new Padding(2, 2, 2, 2);
      this.All_Level.Name = "All_Level";
      this.All_Level.Padding = new Padding(2, 2, 2, 2);
      this.All_Level.Size = new Size(416, 471);
      this.All_Level.TabIndex = 4;
      this.All_Level.Text = "All";
      this.dataGridView_Tab8.AllowUserToAddRows = false;
      this.dataGridView_Tab8.AllowUserToDeleteRows = false;
      this.dataGridView_Tab8.AllowUserToResizeColumns = false;
      this.dataGridView_Tab8.AllowUserToResizeRows = false;
      this.dataGridView_Tab8.BorderStyle = BorderStyle.None;
      this.dataGridView_Tab8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Tab8.ColumnHeadersVisible = false;
      this.dataGridView_Tab8.Cursor = Cursors.Hand;
      this.dataGridView_Tab8.Dock = DockStyle.Fill;
      this.dataGridView_Tab8.EditMode = DataGridViewEditMode.EditOnF2;
      this.dataGridView_Tab8.GridColor = SystemColors.AppWorkspace;
      this.dataGridView_Tab8.Location = new Point(2, 2);
      this.dataGridView_Tab8.Margin = new Padding(2, 2, 2, 2);
      this.dataGridView_Tab8.MultiSelect = false;
      this.dataGridView_Tab8.Name = "dataGridView_Tab8";
      this.dataGridView_Tab8.ReadOnly = true;
      this.dataGridView_Tab8.RowHeadersVisible = false;
      this.dataGridView_Tab8.RowHeadersWidth = 100;
      this.dataGridView_Tab8.RowTemplate.DividerHeight = 5;
      this.dataGridView_Tab8.RowTemplate.Height = 60;
      this.dataGridView_Tab8.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dataGridView_Tab8.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.dataGridView_Tab8.ShowEditingIcon = false;
      this.dataGridView_Tab8.Size = new Size(412, 467);
      this.dataGridView_Tab8.TabIndex = 7;
      this.dataGridView_Tab8.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView7_CellDoubleClick);
      this.dataGridView_Tab8.CellClick += new DataGridViewCellEventHandler(this.dataGridView7_CellClick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(795, 602);
      this.Controls.Add((Control) this.tabControl1);
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = "Form_SHL_RoomView";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
      this.Load += new EventHandler(this.Form_SHL_RoomView_Load);
      this.tabControl1.ResumeLayout(false);
      this.Level1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab1).EndInit();
      this.Level2.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab2).EndInit();
      this.Level3.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab3).EndInit();
      this.Level4.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab4).EndInit();
      this.Level5.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab5).EndInit();
      this.Level6.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab6).EndInit();
      this.Level7.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab7).EndInit();
      this.All_Level.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView_Tab8).EndInit();
      this.ResumeLayout(false);
    }

    public Form_SHL_RoomView()
    {
      this.InitializeComponent();
      this.Init_DataGrid_View(this.dataGridView_Tab1, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab2, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab3, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab4, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab5, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab6, 5);
      this.Init_DataGrid_View(this.dataGridView_Tab7, 5);
    }

    private void Init_DataGrid_View(DataGridView para_DataGridView)
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxColumn viewTextBoxColumn7 = new DataGridViewTextBoxColumn();
      para_DataGridView.Columns.AddRange((DataGridViewColumn) viewTextBoxColumn7, (DataGridViewColumn) viewTextBoxColumn6, (DataGridViewColumn) viewTextBoxColumn5, (DataGridViewColumn) viewTextBoxColumn4, (DataGridViewColumn) viewTextBoxColumn3, (DataGridViewColumn) viewTextBoxColumn2, (DataGridViewColumn) viewTextBoxColumn1);
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.SelectionBackColor = Color.Transparent;
      gridViewCellStyle.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle.WrapMode = DataGridViewTriState.True;
      viewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn6.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn7.DividerWidth = 5;
      viewTextBoxColumn7.HeaderText = "RoomNo";
      viewTextBoxColumn7.Name = "local_dataGridViewTextBoxColumn1";
      viewTextBoxColumn7.ReadOnly = true;
      viewTextBoxColumn7.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn7.Width = 120;
      viewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn6.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn6.DividerWidth = 5;
      viewTextBoxColumn6.HeaderText = "RoomNo";
      viewTextBoxColumn6.Name = "local_dataGridViewTextBoxColumn2";
      viewTextBoxColumn6.ReadOnly = true;
      viewTextBoxColumn6.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn6.Width = 120;
      viewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn5.DividerWidth = 5;
      viewTextBoxColumn5.HeaderText = "RoomNo";
      viewTextBoxColumn5.Name = "local_dataGridViewTextBoxColumn3";
      viewTextBoxColumn5.ReadOnly = true;
      viewTextBoxColumn5.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn5.Width = 120;
      viewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn4.DividerWidth = 5;
      viewTextBoxColumn4.HeaderText = "RoomNo";
      viewTextBoxColumn4.Name = "local_dataGridViewTextBoxColumn4";
      viewTextBoxColumn4.ReadOnly = true;
      viewTextBoxColumn4.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn4.Width = 120;
      viewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn3.DividerWidth = 5;
      viewTextBoxColumn3.HeaderText = "RoomNo";
      viewTextBoxColumn3.Name = "local_dataGridViewTextBoxColumn5";
      viewTextBoxColumn3.ReadOnly = true;
      viewTextBoxColumn3.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn3.Width = 120;
      viewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn2.DividerWidth = 5;
      viewTextBoxColumn2.HeaderText = "RoomNo";
      viewTextBoxColumn2.Name = "local_dataGridViewTextBoxColumn6";
      viewTextBoxColumn2.ReadOnly = true;
      viewTextBoxColumn2.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn2.Width = 120;
      viewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      viewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle;
      viewTextBoxColumn1.DividerWidth = 5;
      viewTextBoxColumn1.HeaderText = "RoomNo";
      viewTextBoxColumn1.Name = "local_dataGridViewTextBoxColumn7";
      viewTextBoxColumn1.ReadOnly = true;
      viewTextBoxColumn1.Resizable = DataGridViewTriState.False;
      viewTextBoxColumn1.Width = 120;
    }

    private void Init_DataGrid_View(DataGridView para_DataGridView, int para_Column_Count)
    {
      DataGridViewTextBoxColumn[] viewTextBoxColumnArray = new DataGridViewTextBoxColumn[para_Column_Count];
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      for (int index = 0; index < para_Column_Count; ++index)
        viewTextBoxColumnArray[index] = new DataGridViewTextBoxColumn();
      para_DataGridView.Columns.AddRange((DataGridViewColumn[]) viewTextBoxColumnArray);
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      gridViewCellStyle.ForeColor = SystemColors.ControlText;
      gridViewCellStyle.SelectionBackColor = Color.Transparent;
      gridViewCellStyle.SelectionForeColor = Color.FromArgb(0, 192, 0);
      gridViewCellStyle.WrapMode = DataGridViewTriState.True;
      for (int index = 0; index < para_Column_Count; ++index)
      {
        viewTextBoxColumnArray[index].DefaultCellStyle = gridViewCellStyle;
        viewTextBoxColumnArray[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        viewTextBoxColumnArray[index].DefaultCellStyle = gridViewCellStyle;
        viewTextBoxColumnArray[index].DividerWidth = 5;
        viewTextBoxColumnArray[index].HeaderText = "RoomNo";
        viewTextBoxColumnArray[index].Name = "TextBoxColumn" + index.ToString();
        viewTextBoxColumnArray[index].ReadOnly = true;
        viewTextBoxColumnArray[index].Resizable = DataGridViewTriState.False;
        viewTextBoxColumnArray[index].Width = 120;
      }
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
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "05", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "06", para_DataGridView.Rows.Count, 0, true);
      this.Insert_Rooms_In_DataGridView_Relative(para_DataGridView, para_DataTable, "07", para_DataGridView.Rows.Count, 0, true);
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

    private void Form_SHL_RoomView_Load(object sender, EventArgs e)
    {
      this.db.system_DB.roomTableAdapter.Fill(this.db.system_DB.systemDataSet.Room);
      this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab5, (DataTable) this.db.system_DB.systemDataSet.Room);
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab1, (DataTable) this.db.system_DB.systemDataSet.Room, "01");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab2, (DataTable) this.db.system_DB.systemDataSet.Room, "02");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab3, (DataTable) this.db.system_DB.systemDataSet.Room, "03");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab4, (DataTable) this.db.system_DB.systemDataSet.Room, "04");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab5, (DataTable) this.db.system_DB.systemDataSet.Room, "05");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab6, (DataTable) this.db.system_DB.systemDataSet.Room, "06");
      this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab7, (DataTable) this.db.system_DB.systemDataSet.Room, "07");
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab1);
    }

    private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
      }
      else
      {
        if (!((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex <= 0)
        return;
      if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab8.Refresh();
      }
      try
      {
        if (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && !((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") && this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      catch
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex <= 0)
        return;
      if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab8.Refresh();
      }
      try
      {
        if (!((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "") && !((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") && this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
          return;
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
      catch
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
      }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tabControl1.SelectedTab == this.Level1)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab1);
      else if (this.tabControl1.SelectedTab == this.Level2)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab2);
      else if (this.tabControl1.SelectedTab == this.Level3)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab3);
      else if (this.tabControl1.SelectedTab == this.Level4)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab4);
      else if (this.tabControl1.SelectedTab == this.Level5)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab5);
      else if (this.tabControl1.SelectedTab == this.Level6)
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab6);
      else if (this.tabControl1.SelectedTab == this.Level7)
      {
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab7);
      }
      else
      {
        if (this.tabControl1.SelectedTab != this.All_Level)
          return;
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      }
    }
  }
}
