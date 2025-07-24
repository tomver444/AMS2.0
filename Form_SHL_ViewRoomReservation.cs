// Decompiled with JetBrains decompiler
// Type: AMS.Form_SHL_ViewRoomReservation
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_SHL_ViewRoomReservation : Form
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
    public Label lbBuilding;
    public Label Label17;
    public Label Label18;
    public Button cmdView;
    public ComboBox cboBuilding;
    private DateTimePicker dateTimePicker_EndDate;
    private DateTimePicker dateTimePicker_StartDate;
    public Label lblMessage;
    public Button cmdReturn;
    public Button cmdClear;
    public Button cmdPrint;
    public Button cmdConfirm;
    public Button cmdNewReserve;
    public Button cmdReservedView;
    public GroupBox ReservationFrame;
    public Button cmdExisting;
    public TextBox txtNoOfDays;
    public TextBox txtFirstName;
    public TextBox txtDeposit;
    public TextBox txtSurName;
    public TextBox txtClientID;
    public TextBox txtReservationRef;
    public MaskedTextBox MaskEdBox2;
    public MaskedTextBox MaskEdBox4;
    public Label lblOldDepositAmount;
    public Label lblOldDeposit;
    public Label lblDifference;
    public Label lblDiffAmount;
    public Label lblOldRoomNo;
    public Label lblOldRoomType;
    public Label lblOldRoom;
    public Label Label13;
    public Label Label12;
    public Label lblBookingRoomNo;
    public Label Label9;
    public Label Label1;
    public Label Label_SelectRoom;
    public Label Label21;
    public Label Label5;
    public Label Label3;
    public Label Label6;
    private Label label_ReservationType;
    private DateTimePicker dateTimePicker_BookingStart;
    private DateTimePicker dateTimePicker_BookingEnd;
    private CheckBox checkBox_EnableChange;
    public Panel StatusFrame;
    public Label Label10;
    public Label label2;
    public Label Label8;
    public Label Label7;
    public Label Label4;
    public Label label11;
    public Label label14;
    public Label label15;
    public Label label16;
    public Label label19;
    private Color Reserved_Back_Color = Color.FromArgb((int) byte.MaxValue, 128, 128);
    private Color Occupied_Back_Color = Color.Red;
    private Color Vacant_Back_Color = Color.Cyan;
    private Color VacantClean_Back_Color = Color.Yellow;
    private Color OutOfOrder_Back_Color = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
    private DB db = new DB();
    private DateTime Old_Start_Date = DateTime.Now.Date;
    private DateTime Old_End_Date = DateTime.Now.Date;
    private DateTime Old_Booking_StartDate = DateTime.Now.Date;
    private DateTime Old_Booking_EndDate = DateTime.Now.Date;
    private bool Date_Time_Inserting_Flag;
    private Decimal Old_Deposit = 0.0M;
    private string Old_Reserved_Room = "";
    private bool Editing_Mode;
    private Color New_Reserve_Active_Backcolor = Color.FromArgb(128, (int) byte.MaxValue, 128);
    private Color New_Reserve_Inactive_Backcolor = SystemColors.InactiveCaption;
    private Color Reserve_View_Active_Backcolor = Color.FromArgb((int) byte.MaxValue, 128, 128);
    private Color Reserve_View_Inactive_Backcolor = SystemColors.InactiveCaption;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_SHL_ViewRoomReservation));
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
      this.lbBuilding = new Label();
      this.Label17 = new Label();
      this.Label18 = new Label();
      this.cmdView = new Button();
      this.cboBuilding = new ComboBox();
      this.dateTimePicker_EndDate = new DateTimePicker();
      this.dateTimePicker_StartDate = new DateTimePicker();
      this.lblMessage = new Label();
      this.cmdReturn = new Button();
      this.cmdClear = new Button();
      this.cmdPrint = new Button();
      this.cmdConfirm = new Button();
      this.cmdNewReserve = new Button();
      this.cmdReservedView = new Button();
      this.ReservationFrame = new GroupBox();
      this.dateTimePicker_BookingEnd = new DateTimePicker();
      this.label_ReservationType = new Label();
      this.dateTimePicker_BookingStart = new DateTimePicker();
      this.cmdExisting = new Button();
      this.txtNoOfDays = new TextBox();
      this.txtFirstName = new TextBox();
      this.txtDeposit = new TextBox();
      this.txtSurName = new TextBox();
      this.txtClientID = new TextBox();
      this.txtReservationRef = new TextBox();
      this.MaskEdBox2 = new MaskedTextBox();
      this.MaskEdBox4 = new MaskedTextBox();
      this.lblOldDepositAmount = new Label();
      this.lblOldDeposit = new Label();
      this.lblDifference = new Label();
      this.lblDiffAmount = new Label();
      this.lblOldRoomNo = new Label();
      this.lblOldRoomType = new Label();
      this.lblOldRoom = new Label();
      this.Label13 = new Label();
      this.Label12 = new Label();
      this.lblBookingRoomNo = new Label();
      this.Label9 = new Label();
      this.Label1 = new Label();
      this.Label_SelectRoom = new Label();
      this.Label21 = new Label();
      this.Label5 = new Label();
      this.Label3 = new Label();
      this.Label6 = new Label();
      this.checkBox_EnableChange = new CheckBox();
      this.StatusFrame = new Panel();
      this.Label10 = new Label();
      this.label2 = new Label();
      this.Label8 = new Label();
      this.Label7 = new Label();
      this.Label4 = new Label();
      this.label11 = new Label();
      this.label14 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label19 = new Label();
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
      this.ReservationFrame.SuspendLayout();
      this.StatusFrame.SuspendLayout();
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
      this.tabControl1.Location = new Point(8, 85);
      this.tabControl1.Margin = new Padding(2, 2, 2, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(446, 421);
      this.tabControl1.TabIndex = 7;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.Level1.BackColor = SystemColors.AppWorkspace;
      this.Level1.Controls.Add((Control) this.dataGridView_Tab1);
      this.Level1.Location = new Point(4, 24);
      this.Level1.Margin = new Padding(2, 2, 2, 2);
      this.Level1.Name = "Level1";
      this.Level1.Padding = new Padding(2, 2, 2, 2);
      this.Level1.Size = new Size(438, 393);
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
      this.dataGridView_Tab1.Size = new Size(434, 389);
      this.dataGridView_Tab1.TabIndex = 5;
      this.dataGridView_Tab1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab1__CellDoubleClick);
      this.dataGridView_Tab1.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab1_CellClick);
      this.Level2.BackColor = SystemColors.AppWorkspace;
      this.Level2.Controls.Add((Control) this.dataGridView_Tab2);
      this.Level2.Location = new Point(4, 24);
      this.Level2.Margin = new Padding(2, 2, 2, 2);
      this.Level2.Name = "Level2";
      this.Level2.Padding = new Padding(2, 2, 2, 2);
      this.Level2.Size = new Size(438, 393);
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
      this.dataGridView_Tab2.Size = new Size(434, 389);
      this.dataGridView_Tab2.TabIndex = 6;
      this.dataGridView_Tab2.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab2_CellDoubleClick);
      this.dataGridView_Tab2.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab2_CellClick);
      this.Level3.BackColor = SystemColors.AppWorkspace;
      this.Level3.Controls.Add((Control) this.dataGridView_Tab3);
      this.Level3.Location = new Point(4, 24);
      this.Level3.Margin = new Padding(2, 2, 2, 2);
      this.Level3.Name = "Level3";
      this.Level3.Padding = new Padding(2, 2, 2, 2);
      this.Level3.Size = new Size(438, 393);
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
      this.dataGridView_Tab3.Size = new Size(434, 389);
      this.dataGridView_Tab3.TabIndex = 7;
      this.dataGridView_Tab3.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab3_CellDoubleClick);
      this.dataGridView_Tab3.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab3_CellClick);
      this.Level4.BackColor = SystemColors.AppWorkspace;
      this.Level4.Controls.Add((Control) this.dataGridView_Tab4);
      this.Level4.Location = new Point(4, 24);
      this.Level4.Margin = new Padding(2, 2, 2, 2);
      this.Level4.Name = "Level4";
      this.Level4.Padding = new Padding(2, 2, 2, 2);
      this.Level4.Size = new Size(438, 393);
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
      this.dataGridView_Tab4.Size = new Size(434, 389);
      this.dataGridView_Tab4.TabIndex = 7;
      this.dataGridView_Tab4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab4_CellDoubleClick);
      this.dataGridView_Tab4.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab4_CellClick);
      this.Level5.BackColor = SystemColors.AppWorkspace;
      this.Level5.Controls.Add((Control) this.dataGridView_Tab5);
      this.Level5.Location = new Point(4, 24);
      this.Level5.Margin = new Padding(2, 2, 2, 2);
      this.Level5.Name = "Level5";
      this.Level5.Padding = new Padding(2, 2, 2, 2);
      this.Level5.Size = new Size(438, 393);
      this.Level5.TabIndex = 3;
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
      this.dataGridView_Tab5.Size = new Size(434, 389);
      this.dataGridView_Tab5.TabIndex = 7;
      this.dataGridView_Tab5.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab5_CellDoubleClick);
      this.dataGridView_Tab5.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab5_CellClick);
      this.Level6.BackColor = SystemColors.AppWorkspace;
      this.Level6.Controls.Add((Control) this.dataGridView_Tab6);
      this.Level6.Location = new Point(4, 24);
      this.Level6.Margin = new Padding(2, 2, 2, 2);
      this.Level6.Name = "Level6";
      this.Level6.Padding = new Padding(2, 2, 2, 2);
      this.Level6.Size = new Size(438, 393);
      this.Level6.TabIndex = 3;
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
      this.dataGridView_Tab6.Size = new Size(434, 389);
      this.dataGridView_Tab6.TabIndex = 7;
      this.dataGridView_Tab6.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab6_CellDoubleClick);
      this.dataGridView_Tab6.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab6_CellClick);
      this.Level7.BackColor = SystemColors.AppWorkspace;
      this.Level7.Controls.Add((Control) this.dataGridView_Tab7);
      this.Level7.Location = new Point(4, 24);
      this.Level7.Margin = new Padding(2, 2, 2, 2);
      this.Level7.Name = "Level7";
      this.Level7.Padding = new Padding(2, 2, 2, 2);
      this.Level7.Size = new Size(438, 393);
      this.Level7.TabIndex = 3;
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
      this.dataGridView_Tab7.Size = new Size(434, 389);
      this.dataGridView_Tab7.TabIndex = 7;
      this.dataGridView_Tab7.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab7_CellDoubleClick);
      this.dataGridView_Tab7.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab7_CellClick);
      this.All_Level.BackColor = SystemColors.AppWorkspace;
      this.All_Level.Controls.Add((Control) this.dataGridView_Tab8);
      this.All_Level.Location = new Point(4, 24);
      this.All_Level.Margin = new Padding(2, 2, 2, 2);
      this.All_Level.Name = "All_Level";
      this.All_Level.Padding = new Padding(2, 2, 2, 2);
      this.All_Level.Size = new Size(438, 393);
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
      this.dataGridView_Tab8.Size = new Size(434, 389);
      this.dataGridView_Tab8.TabIndex = 7;
      this.dataGridView_Tab8.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_Tab8_CellDoubleClick);
      this.dataGridView_Tab8.CellClick += new DataGridViewCellEventHandler(this.dataGridView_Tab8_CellClick);
      this.lbBuilding.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lbBuilding.Cursor = Cursors.Default;
      this.lbBuilding.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbBuilding.ForeColor = SystemColors.ControlText;
      this.lbBuilding.Location = new Point(64, 7);
      this.lbBuilding.Name = "lbBuilding";
      this.lbBuilding.RightToLeft = RightToLeft.No;
      this.lbBuilding.Size = new Size(57, 17);
      this.lbBuilding.TabIndex = 491;
      this.lbBuilding.Text = "Building";
      this.lbBuilding.TextAlign = ContentAlignment.TopRight;
      this.Label17.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label17.Cursor = Cursors.Default;
      this.Label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.ControlText;
      this.Label17.Location = new Point(40, 32);
      this.Label17.Name = "Label17";
      this.Label17.RightToLeft = RightToLeft.No;
      this.Label17.Size = new Size(81, 17);
      this.Label17.TabIndex = 490;
      this.Label17.Text = "Start Date";
      this.Label17.TextAlign = ContentAlignment.TopRight;
      this.Label18.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label18.Cursor = Cursors.Default;
      this.Label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.ControlText;
      this.Label18.Location = new Point(272, 32);
      this.Label18.Name = "Label18";
      this.Label18.RightToLeft = RightToLeft.No;
      this.Label18.Size = new Size(65, 17);
      this.Label18.TabIndex = 489;
      this.Label18.Text = "End Date";
      this.Label18.TextAlign = ContentAlignment.TopRight;
      this.cmdView.BackColor = Color.FromArgb(192, 192, 192);
      this.cmdView.Cursor = Cursors.Default;
      this.cmdView.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdView.ForeColor = SystemColors.ControlText;
      this.cmdView.Image = (Image) componentResourceManager.GetObject("cmdView.Image");
      this.cmdView.Location = new Point(472, 2);
      this.cmdView.Name = "cmdView";
      this.cmdView.RightToLeft = RightToLeft.No;
      this.cmdView.Size = new Size(97, 47);
      this.cmdView.TabIndex = 488;
      this.cmdView.Text = "&View Room";
      this.cmdView.TextAlign = ContentAlignment.BottomCenter;
      this.cmdView.UseVisualStyleBackColor = false;
      this.cmdView.Click += new EventHandler(this.cmdView_Click);
      this.cboBuilding.BackColor = SystemColors.Window;
      this.cboBuilding.Cursor = Cursors.Default;
      this.cboBuilding.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cboBuilding.ForeColor = SystemColors.WindowText;
      this.cboBuilding.Location = new Point(136, 7);
      this.cboBuilding.Name = "cboBuilding";
      this.cboBuilding.RightToLeft = RightToLeft.No;
      this.cboBuilding.Size = new Size(49, 22);
      this.cboBuilding.TabIndex = 485;
      this.dateTimePicker_EndDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_EndDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_EndDate.Location = new Point(343, 31);
      this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
      this.dateTimePicker_EndDate.Size = new Size(99, 20);
      this.dateTimePicker_EndDate.TabIndex = 493;
      this.dateTimePicker_EndDate.ValueChanged += new EventHandler(this.dateTimePicker_EndDate_ValueChanged);
      this.dateTimePicker_EndDate.MouseDown += new MouseEventHandler(this.dateTimePicker_EndDate_MouseDown);
      this.dateTimePicker_StartDate.Checked = false;
      this.dateTimePicker_StartDate.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_StartDate.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_StartDate.Location = new Point(136, 32);
      this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
      this.dateTimePicker_StartDate.Size = new Size(98, 20);
      this.dateTimePicker_StartDate.TabIndex = 492;
      this.dateTimePicker_StartDate.ValueChanged += new EventHandler(this.dateTimePicker_StartDate_ValueChanged);
      this.dateTimePicker_StartDate.MouseDown += new MouseEventHandler(this.dateTimePicker_StartDate_MouseDown);
      this.lblMessage.BackColor = Color.White;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Arial", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(8, 522);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(673, 17);
      this.lblMessage.TabIndex = 498;
      this.lblMessage.Text = "Label4";
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(742, 464);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(49, 55);
      this.cmdReturn.TabIndex = 497;
      this.cmdReturn.Text = "Retur&n";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdClear.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdClear.Cursor = Cursors.Default;
      this.cmdClear.Enabled = false;
      this.cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdClear.ForeColor = SystemColors.ControlText;
      this.cmdClear.Image = (Image) componentResourceManager.GetObject("cmdClear.Image");
      this.cmdClear.Location = new Point(689, 464);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.RightToLeft = RightToLeft.No;
      this.cmdClear.Size = new Size(49, 55);
      this.cmdClear.TabIndex = 496;
      this.cmdClear.Text = "&Cancel";
      this.cmdClear.TextAlign = ContentAlignment.BottomCenter;
      this.cmdClear.UseVisualStyleBackColor = false;
      this.cmdClear.Click += new EventHandler(this.cmdClear_Click);
      this.cmdPrint.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.cmdPrint.Cursor = Cursors.Default;
      this.cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrint.ForeColor = SystemColors.ControlText;
      this.cmdPrint.Image = (Image) componentResourceManager.GetObject("cmdPrint.Image");
      this.cmdPrint.Location = new Point(524, 464);
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.RightToLeft = RightToLeft.No;
      this.cmdPrint.Size = new Size(49, 55);
      this.cmdPrint.TabIndex = 495;
      this.cmdPrint.Text = "&Print Recipt";
      this.cmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.cmdPrint.UseVisualStyleBackColor = false;
      this.cmdPrint.Click += new EventHandler(this.cmdPrint_Click);
      this.cmdConfirm.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cmdConfirm.Cursor = Cursors.Default;
      this.cmdConfirm.Enabled = false;
      this.cmdConfirm.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdConfirm.ForeColor = SystemColors.ControlText;
      this.cmdConfirm.Image = (Image) componentResourceManager.GetObject("cmdConfirm.Image");
      this.cmdConfirm.Location = new Point(634, 464);
      this.cmdConfirm.Name = "cmdConfirm";
      this.cmdConfirm.RightToLeft = RightToLeft.No;
      this.cmdConfirm.Size = new Size(49, 55);
      this.cmdConfirm.TabIndex = 494;
      this.cmdConfirm.Text = "Con&firm";
      this.cmdConfirm.TextAlign = ContentAlignment.BottomCenter;
      this.cmdConfirm.UseVisualStyleBackColor = false;
      this.cmdConfirm.Click += new EventHandler(this.cmdConfirm_Click);
      this.cmdNewReserve.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.cmdNewReserve.Cursor = Cursors.Default;
      this.cmdNewReserve.Enabled = false;
      this.cmdNewReserve.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNewReserve.ForeColor = SystemColors.ControlText;
      this.cmdNewReserve.Location = new Point(582, 2);
      this.cmdNewReserve.Margin = new Padding(2, 2, 2, 2);
      this.cmdNewReserve.Name = "cmdNewReserve";
      this.cmdNewReserve.RightToLeft = RightToLeft.No;
      this.cmdNewReserve.Size = new Size(87, 47);
      this.cmdNewReserve.TabIndex = 501;
      this.cmdNewReserve.Text = "New Reser&vation";
      this.cmdNewReserve.UseVisualStyleBackColor = false;
      this.cmdNewReserve.Click += new EventHandler(this.cmdNewReserve_Click);
      this.cmdNewReserve.EnabledChanged += new EventHandler(this.cmdNewReserve_EnabledChanged);
      this.cmdReservedView.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdReservedView.Cursor = Cursors.Default;
      this.cmdReservedView.Enabled = false;
      this.cmdReservedView.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReservedView.ForeColor = SystemColors.ControlText;
      this.cmdReservedView.Image = (Image) componentResourceManager.GetObject("cmdReservedView.Image");
      this.cmdReservedView.Location = new Point(683, 2);
      this.cmdReservedView.Margin = new Padding(2, 2, 2, 2);
      this.cmdReservedView.Name = "cmdReservedView";
      this.cmdReservedView.RightToLeft = RightToLeft.No;
      this.cmdReservedView.Size = new Size(94, 47);
      this.cmdReservedView.TabIndex = 500;
      this.cmdReservedView.Text = "&Edit Reservation";
      this.cmdReservedView.TextAlign = ContentAlignment.BottomCenter;
      this.cmdReservedView.UseVisualStyleBackColor = false;
      this.cmdReservedView.Click += new EventHandler(this.cmdReservedView_Click);
      this.cmdReservedView.EnabledChanged += new EventHandler(this.cmdReservedView_EnabledChanged);
      this.ReservationFrame.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.ReservationFrame.Controls.Add((Control) this.dateTimePicker_BookingEnd);
      this.ReservationFrame.Controls.Add((Control) this.label_ReservationType);
      this.ReservationFrame.Controls.Add((Control) this.dateTimePicker_BookingStart);
      this.ReservationFrame.Controls.Add((Control) this.cmdExisting);
      this.ReservationFrame.Controls.Add((Control) this.txtNoOfDays);
      this.ReservationFrame.Controls.Add((Control) this.txtFirstName);
      this.ReservationFrame.Controls.Add((Control) this.txtDeposit);
      this.ReservationFrame.Controls.Add((Control) this.txtSurName);
      this.ReservationFrame.Controls.Add((Control) this.txtClientID);
      this.ReservationFrame.Controls.Add((Control) this.txtReservationRef);
      this.ReservationFrame.Controls.Add((Control) this.MaskEdBox2);
      this.ReservationFrame.Controls.Add((Control) this.MaskEdBox4);
      this.ReservationFrame.Controls.Add((Control) this.lblOldDepositAmount);
      this.ReservationFrame.Controls.Add((Control) this.lblOldDeposit);
      this.ReservationFrame.Controls.Add((Control) this.lblDifference);
      this.ReservationFrame.Controls.Add((Control) this.lblDiffAmount);
      this.ReservationFrame.Controls.Add((Control) this.lblOldRoomNo);
      this.ReservationFrame.Controls.Add((Control) this.lblOldRoomType);
      this.ReservationFrame.Controls.Add((Control) this.lblOldRoom);
      this.ReservationFrame.Controls.Add((Control) this.Label13);
      this.ReservationFrame.Controls.Add((Control) this.Label12);
      this.ReservationFrame.Controls.Add((Control) this.lblBookingRoomNo);
      this.ReservationFrame.Controls.Add((Control) this.Label9);
      this.ReservationFrame.Controls.Add((Control) this.Label1);
      this.ReservationFrame.Controls.Add((Control) this.Label_SelectRoom);
      this.ReservationFrame.Controls.Add((Control) this.Label21);
      this.ReservationFrame.Controls.Add((Control) this.Label5);
      this.ReservationFrame.Controls.Add((Control) this.Label3);
      this.ReservationFrame.Controls.Add((Control) this.Label6);
      this.ReservationFrame.Enabled = false;
      this.ReservationFrame.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ReservationFrame.ForeColor = Color.Red;
      this.ReservationFrame.Location = new Point(524, 56);
      this.ReservationFrame.Name = "ReservationFrame";
      this.ReservationFrame.Padding = new Padding(0);
      this.ReservationFrame.RightToLeft = RightToLeft.No;
      this.ReservationFrame.Size = new Size(253, 401);
      this.ReservationFrame.TabIndex = 502;
      this.ReservationFrame.TabStop = false;
      this.ReservationFrame.Text = "RESERVATION :";
      this.ReservationFrame.EnabledChanged += new EventHandler(this.ReservationFrame_EnabledChanged);
      this.dateTimePicker_BookingEnd.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_BookingEnd.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_BookingEnd.Location = new Point(103, 284);
      this.dateTimePicker_BookingEnd.Name = "dateTimePicker_BookingEnd";
      this.dateTimePicker_BookingEnd.Size = new Size(99, 20);
      this.dateTimePicker_BookingEnd.TabIndex = 504;
      this.dateTimePicker_BookingEnd.ValueChanged += new EventHandler(this.dateTimePicker_BookingEnd_ValueChanged);
      this.dateTimePicker_BookingEnd.MouseDown += new MouseEventHandler(this.dateTimePicker_BookingEnd_MouseDown);
      this.label_ReservationType.AutoSize = true;
      this.label_ReservationType.Font = new Font("Arial", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label_ReservationType.Location = new Point(163, 39);
      this.label_ReservationType.Margin = new Padding(2, 0, 2, 0);
      this.label_ReservationType.Name = "label_ReservationType";
      this.label_ReservationType.Size = new Size(0, 16);
      this.label_ReservationType.TabIndex = 365;
      this.dateTimePicker_BookingStart.Checked = false;
      this.dateTimePicker_BookingStart.CustomFormat = "yyyy-MM-dd";
      this.dateTimePicker_BookingStart.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker_BookingStart.Location = new Point(104, 256);
      this.dateTimePicker_BookingStart.Name = "dateTimePicker_BookingStart";
      this.dateTimePicker_BookingStart.Size = new Size(98, 20);
      this.dateTimePicker_BookingStart.TabIndex = 503;
      this.dateTimePicker_BookingStart.ValueChanged += new EventHandler(this.dateTimePicker_BookingStart_ValueChanged);
      this.dateTimePicker_BookingStart.MouseDown += new MouseEventHandler(this.dateTimePicker_BookingStart_MouseDown);
      this.cmdExisting.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cmdExisting.Cursor = Cursors.Default;
      this.cmdExisting.Enabled = false;
      this.cmdExisting.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdExisting.ForeColor = SystemColors.ControlText;
      this.cmdExisting.Location = new Point(152, 64);
      this.cmdExisting.Name = "cmdExisting";
      this.cmdExisting.RightToLeft = RightToLeft.No;
      this.cmdExisting.Size = new Size(70, 25);
      this.cmdExisting.TabIndex = 11;
      this.cmdExisting.Text = "&Existing";
      this.cmdExisting.UseVisualStyleBackColor = false;
      this.cmdExisting.Visible = false;
      this.txtNoOfDays.AcceptsReturn = true;
      this.txtNoOfDays.BackColor = SystemColors.Window;
      this.txtNoOfDays.Cursor = Cursors.IBeam;
      this.txtNoOfDays.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNoOfDays.ForeColor = SystemColors.WindowText;
      this.txtNoOfDays.Location = new Point(104, 312);
      this.txtNoOfDays.MaxLength = 0;
      this.txtNoOfDays.Name = "txtNoOfDays";
      this.txtNoOfDays.ReadOnly = true;
      this.txtNoOfDays.RightToLeft = RightToLeft.No;
      this.txtNoOfDays.Size = new Size(49, 20);
      this.txtNoOfDays.TabIndex = 5;
      this.txtNoOfDays.TextAlign = HorizontalAlignment.Center;
      this.txtFirstName.AcceptsReturn = true;
      this.txtFirstName.BackColor = SystemColors.Window;
      this.txtFirstName.Cursor = Cursors.IBeam;
      this.txtFirstName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFirstName.ForeColor = SystemColors.WindowText;
      this.txtFirstName.Location = new Point(16, 104);
      this.txtFirstName.MaxLength = 0;
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.RightToLeft = RightToLeft.No;
      this.txtFirstName.Size = new Size(177, 20);
      this.txtFirstName.TabIndex = 1;
      this.txtFirstName.TextAlign = HorizontalAlignment.Center;
      this.txtFirstName.TextChanged += new EventHandler(this.txtFirstName_TextChanged);
      this.txtDeposit.AcceptsReturn = true;
      this.txtDeposit.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDeposit.Cursor = Cursors.IBeam;
      this.txtDeposit.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeposit.ForeColor = Color.Black;
      this.txtDeposit.Location = new Point(72, 344);
      this.txtDeposit.MaxLength = 0;
      this.txtDeposit.Name = "txtDeposit";
      this.txtDeposit.RightToLeft = RightToLeft.No;
      this.txtDeposit.Size = new Size(65, 22);
      this.txtDeposit.TabIndex = 6;
      this.txtDeposit.Text = "0";
      this.txtDeposit.TextAlign = HorizontalAlignment.Center;
      this.txtDeposit.TextChanged += new EventHandler(this.txtDeposit_TextChanged);
      this.txtDeposit.KeyPress += new KeyPressEventHandler(this.txtDeposit_KeyPress);
      this.txtSurName.AcceptsReturn = true;
      this.txtSurName.BackColor = SystemColors.Window;
      this.txtSurName.Cursor = Cursors.IBeam;
      this.txtSurName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtSurName.ForeColor = SystemColors.WindowText;
      this.txtSurName.Location = new Point(16, 144);
      this.txtSurName.MaxLength = 0;
      this.txtSurName.Name = "txtSurName";
      this.txtSurName.RightToLeft = RightToLeft.No;
      this.txtSurName.Size = new Size(177, 20);
      this.txtSurName.TabIndex = 2;
      this.txtSurName.TextAlign = HorizontalAlignment.Center;
      this.txtSurName.TextChanged += new EventHandler(this.txtSurName_TextChanged);
      this.txtClientID.AcceptsReturn = true;
      this.txtClientID.BackColor = SystemColors.Window;
      this.txtClientID.Cursor = Cursors.IBeam;
      this.txtClientID.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtClientID.ForeColor = Color.Red;
      this.txtClientID.Location = new Point(64, 64);
      this.txtClientID.MaxLength = 8;
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.ReadOnly = true;
      this.txtClientID.RightToLeft = RightToLeft.No;
      this.txtClientID.Size = new Size(81, 20);
      this.txtClientID.TabIndex = 0;
      this.txtClientID.TextAlign = HorizontalAlignment.Center;
      this.txtReservationRef.AcceptsReturn = true;
      this.txtReservationRef.BackColor = SystemColors.Window;
      this.txtReservationRef.Cursor = Cursors.IBeam;
      this.txtReservationRef.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtReservationRef.ForeColor = Color.Red;
      this.txtReservationRef.Location = new Point(48, 32);
      this.txtReservationRef.MaxLength = 10;
      this.txtReservationRef.Name = "txtReservationRef";
      this.txtReservationRef.ReadOnly = true;
      this.txtReservationRef.RightToLeft = RightToLeft.No;
      this.txtReservationRef.Size = new Size(105, 26);
      this.txtReservationRef.TabIndex = 24;
      this.txtReservationRef.TextAlign = HorizontalAlignment.Center;
      this.MaskEdBox2.AllowPromptAsInput = false;
      this.MaskEdBox2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MaskEdBox2.ForeColor = Color.Blue;
      this.MaskEdBox2.Location = new Point(328, 216);
      this.MaskEdBox2.Mask = "##/##/####";
      this.MaskEdBox2.Name = "MaskEdBox2";
      this.MaskEdBox2.Size = new Size(81, 20);
      this.MaskEdBox2.TabIndex = 30;
      this.MaskEdBox4.AllowPromptAsInput = false;
      this.MaskEdBox4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MaskEdBox4.ForeColor = Color.Blue;
      this.MaskEdBox4.Location = new Point(320, 256);
      this.MaskEdBox4.Mask = "##/##/####";
      this.MaskEdBox4.Name = "MaskEdBox4";
      this.MaskEdBox4.Size = new Size(81, 20);
      this.MaskEdBox4.TabIndex = 33;
      this.lblOldDepositAmount.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.lblOldDepositAmount.BorderStyle = BorderStyle.Fixed3D;
      this.lblOldDepositAmount.Cursor = Cursors.Default;
      this.lblOldDepositAmount.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblOldDepositAmount.ForeColor = SystemColors.ControlText;
      this.lblOldDepositAmount.Location = new Point(144, 376);
      this.lblOldDepositAmount.Name = "lblOldDepositAmount";
      this.lblOldDepositAmount.RightToLeft = RightToLeft.No;
      this.lblOldDepositAmount.Size = new Size(57, 17);
      this.lblOldDepositAmount.TabIndex = 364;
      this.lblOldDepositAmount.TextAlign = ContentAlignment.TopCenter;
      this.lblOldDepositAmount.Visible = false;
      this.lblOldDeposit.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblOldDeposit.Cursor = Cursors.Default;
      this.lblOldDeposit.Font = new Font("Arial Black", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblOldDeposit.ForeColor = SystemColors.ControlText;
      this.lblOldDeposit.Location = new Point(134, 360);
      this.lblOldDeposit.Name = "lblOldDeposit";
      this.lblOldDeposit.RightToLeft = RightToLeft.No;
      this.lblOldDeposit.Size = new Size(73, 17);
      this.lblOldDeposit.TabIndex = 363;
      this.lblOldDeposit.Text = "Old Deposit";
      this.lblOldDeposit.Visible = false;
      this.lblDifference.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblDifference.Cursor = Cursors.Default;
      this.lblDifference.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDifference.ForeColor = Color.Blue;
      this.lblDifference.Location = new Point(8, 376);
      this.lblDifference.Name = "lblDifference";
      this.lblDifference.RightToLeft = RightToLeft.No;
      this.lblDifference.Size = new Size(57, 17);
      this.lblDifference.TabIndex = 362;
      this.lblDifference.Text = "Collect ";
      this.lblDifference.TextAlign = ContentAlignment.TopRight;
      this.lblDifference.Visible = false;
      this.lblDiffAmount.BackColor = Color.White;
      this.lblDiffAmount.BorderStyle = BorderStyle.Fixed3D;
      this.lblDiffAmount.Cursor = Cursors.Default;
      this.lblDiffAmount.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDiffAmount.ForeColor = Color.Red;
      this.lblDiffAmount.Location = new Point(72, 376);
      this.lblDiffAmount.Name = "lblDiffAmount";
      this.lblDiffAmount.RightToLeft = RightToLeft.No;
      this.lblDiffAmount.Size = new Size(65, 21);
      this.lblDiffAmount.TabIndex = 361;
      this.lblDiffAmount.TextAlign = ContentAlignment.TopCenter;
      this.lblDiffAmount.Visible = false;
      this.lblDiffAmount.Click += new EventHandler(this.lblDiffAmount_Click);
      this.lblOldRoomNo.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblOldRoomNo.Cursor = Cursors.Default;
      this.lblOldRoomNo.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblOldRoomNo.ForeColor = SystemColors.ControlText;
      this.lblOldRoomNo.Location = new Point(96, 176);
      this.lblOldRoomNo.Name = "lblOldRoomNo";
      this.lblOldRoomNo.RightToLeft = RightToLeft.No;
      this.lblOldRoomNo.Size = new Size(57, 17);
      this.lblOldRoomNo.TabIndex = 360;
      this.lblOldRoomNo.Visible = false;
      this.lblOldRoomType.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblOldRoomType.Cursor = Cursors.Default;
      this.lblOldRoomType.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblOldRoomType.ForeColor = SystemColors.ControlText;
      this.lblOldRoomType.Location = new Point(160, 176);
      this.lblOldRoomType.Name = "lblOldRoomType";
      this.lblOldRoomType.RightToLeft = RightToLeft.No;
      this.lblOldRoomType.Size = new Size(49, 17);
      this.lblOldRoomType.TabIndex = 359;
      this.lblOldRoomType.Visible = false;
      this.lblOldRoom.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblOldRoom.Cursor = Cursors.Default;
      this.lblOldRoom.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblOldRoom.ForeColor = SystemColors.ControlText;
      this.lblOldRoom.Location = new Point(8, 176);
      this.lblOldRoom.Name = "lblOldRoom";
      this.lblOldRoom.RightToLeft = RightToLeft.No;
      this.lblOldRoom.Size = new Size(65, 17);
      this.lblOldRoom.TabIndex = 358;
      this.lblOldRoom.Text = "Old Room";
      this.lblOldRoom.TextAlign = ContentAlignment.TopRight;
      this.lblOldRoom.Visible = false;
      this.Label13.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label13.Cursor = Cursors.Default;
      this.Label13.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.ControlText;
      this.Label13.Location = new Point(16, 312);
      this.Label13.Name = "Label13";
      this.Label13.RightToLeft = RightToLeft.No;
      this.Label13.Size = new Size(73, 17);
      this.Label13.TabIndex = 38;
      this.Label13.Text = "No.Of Days ";
      this.Label13.TextAlign = ContentAlignment.TopRight;
      this.Label12.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label12.Cursor = Cursors.Default;
      this.Label12.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.ControlText;
      this.Label12.Location = new Point(8, 93);
      this.Label12.Name = "Label12";
      this.Label12.RightToLeft = RightToLeft.No;
      this.Label12.Size = new Size(193, 14);
      this.Label12.TabIndex = 37;
      this.Label12.Text = "First Name";
      this.Label12.TextAlign = ContentAlignment.TopCenter;
      this.lblBookingRoomNo.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.lblBookingRoomNo.Cursor = Cursors.Default;
      this.lblBookingRoomNo.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBookingRoomNo.ForeColor = Color.Blue;
      this.lblBookingRoomNo.Location = new Point(104, 232);
      this.lblBookingRoomNo.Name = "lblBookingRoomNo";
      this.lblBookingRoomNo.RightToLeft = RightToLeft.No;
      this.lblBookingRoomNo.Size = new Size(97, 17);
      this.lblBookingRoomNo.TabIndex = 36;
      this.Label9.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label9.Cursor = Cursors.Default;
      this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.ControlText;
      this.Label9.Location = new Point(8, 288);
      this.Label9.Name = "Label9";
      this.Label9.RightToLeft = RightToLeft.No;
      this.Label9.Size = new Size(81, 25);
      this.Label9.TabIndex = 34;
      this.Label9.Text = "Booking End  ";
      this.Label9.TextAlign = ContentAlignment.TopRight;
      this.Label1.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(64, 64, 64);
      this.Label1.Location = new Point(8, 256);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(81, 25);
      this.Label1.TabIndex = 31;
      this.Label1.Text = "Booking Start ";
      this.Label1.TextAlign = ContentAlignment.TopRight;
      this.Label_SelectRoom.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label_SelectRoom.Cursor = Cursors.Default;
      this.Label_SelectRoom.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label_SelectRoom.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label_SelectRoom.Location = new Point(4, 232);
      this.Label_SelectRoom.Name = "Label_SelectRoom";
      this.Label_SelectRoom.RightToLeft = RightToLeft.No;
      this.Label_SelectRoom.Size = new Size(80, 17);
      this.Label_SelectRoom.TabIndex = 29;
      this.Label_SelectRoom.Text = "Room No.";
      this.Label_SelectRoom.TextAlign = ContentAlignment.TopRight;
      this.Label21.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label21.Cursor = Cursors.Default;
      this.Label21.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label21.ForeColor = Color.Red;
      this.Label21.Location = new Point(8, 344);
      this.Label21.Name = "Label21";
      this.Label21.RightToLeft = RightToLeft.No;
      this.Label21.Size = new Size(57, 17);
      this.Label21.TabIndex = 28;
      this.Label21.Text = "Deposit ";
      this.Label21.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ControlText;
      this.Label5.Location = new Point(8, 128);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(193, 17);
      this.Label5.TabIndex = 27;
      this.Label5.Text = "SurName ";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.Label3.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Blue;
      this.Label3.Location = new Point(8, 64);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(57, 17);
      this.Label3.TabIndex = 26;
      this.Label3.Text = "Guest ID   ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label6.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label6.Cursor = Cursors.Default;
      this.Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.FromArgb(0, 128, 0);
      this.Label6.Location = new Point(8, 16);
      this.Label6.Name = "Label6";
      this.Label6.RightToLeft = RightToLeft.No;
      this.Label6.Size = new Size(193, 17);
      this.Label6.TabIndex = 25;
      this.Label6.Text = "Reservation Reference : ";
      this.Label6.TextAlign = ContentAlignment.TopCenter;
      this.checkBox_EnableChange.AutoSize = true;
      this.checkBox_EnableChange.BackColor = Color.Fuchsia;
      this.checkBox_EnableChange.Enabled = false;
      this.checkBox_EnableChange.Font = new Font("Arial Narrow", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_EnableChange.Location = new Point(306, 63);
      this.checkBox_EnableChange.Margin = new Padding(2, 2, 2, 2);
      this.checkBox_EnableChange.Name = "checkBox_EnableChange";
      this.checkBox_EnableChange.Size = new Size(135, 21);
      this.checkBox_EnableChange.TabIndex = 504;
      this.checkBox_EnableChange.Text = "Enable Change Room";
      this.checkBox_EnableChange.UseVisualStyleBackColor = false;
      this.checkBox_EnableChange.Visible = false;
      this.checkBox_EnableChange.Click += new EventHandler(this.checkBox_EnableChange_Click);
      this.StatusFrame.BackColor = Color.White;
      this.StatusFrame.Controls.Add((Control) this.Label10);
      this.StatusFrame.Controls.Add((Control) this.label2);
      this.StatusFrame.Controls.Add((Control) this.Label8);
      this.StatusFrame.Controls.Add((Control) this.Label7);
      this.StatusFrame.Controls.Add((Control) this.Label4);
      this.StatusFrame.Controls.Add((Control) this.label11);
      this.StatusFrame.Controls.Add((Control) this.label14);
      this.StatusFrame.Controls.Add((Control) this.label15);
      this.StatusFrame.Controls.Add((Control) this.label16);
      this.StatusFrame.Controls.Add((Control) this.label19);
      this.StatusFrame.Cursor = Cursors.Default;
      this.StatusFrame.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.StatusFrame.ForeColor = SystemColors.ControlText;
      this.StatusFrame.Location = new Point(4, 543);
      this.StatusFrame.Name = "StatusFrame";
      this.StatusFrame.RightToLeft = RightToLeft.No;
      this.StatusFrame.Size = new Size(569, 49);
      this.StatusFrame.TabIndex = 731;
      this.Label10.BackColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Label10.Cursor = Cursors.Default;
      this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.ControlText;
      this.Label10.Location = new Point(456, 16);
      this.Label10.Name = "Label10";
      this.Label10.RightToLeft = RightToLeft.No;
      this.Label10.Size = new Size(17, 17);
      this.Label10.TabIndex = 172;
      this.label2.BackColor = Color.White;
      this.label2.Cursor = Cursors.Default;
      this.label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Blue;
      this.label2.Location = new Point(480, 16);
      this.label2.Name = "label2";
      this.label2.RightToLeft = RightToLeft.No;
      this.label2.Size = new Size(81, 17);
      this.label2.TabIndex = 171;
      this.label2.Text = "Out Of Order";
      this.Label8.BackColor = Color.Yellow;
      this.Label8.Cursor = Cursors.Default;
      this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ControlText;
      this.Label8.Location = new Point(328, 16);
      this.Label8.Name = "Label8";
      this.Label8.RightToLeft = RightToLeft.No;
      this.Label8.Size = new Size(17, 17);
      this.Label8.TabIndex = 170;
      this.Label7.BackColor = Color.White;
      this.Label7.Cursor = Cursors.Default;
      this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.Blue;
      this.Label7.Location = new Point(352, 16);
      this.Label7.Name = "Label7";
      this.Label7.RightToLeft = RightToLeft.No;
      this.Label7.Size = new Size(73, 17);
      this.Label7.TabIndex = 169;
      this.Label7.Text = "Vacant Clean";
      this.Label4.BackColor = Color.Cyan;
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(224, 16);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(17, 17);
      this.Label4.TabIndex = 168;
      this.label11.BackColor = Color.White;
      this.label11.Cursor = Cursors.Default;
      this.label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Blue;
      this.label11.Location = new Point(248, 16);
      this.label11.Name = "label11";
      this.label11.RightToLeft = RightToLeft.No;
      this.label11.Size = new Size(49, 17);
      this.label11.TabIndex = 167;
      this.label11.Text = "Vacant";
      this.label14.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.label14.Cursor = Cursors.Default;
      this.label14.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(112, 16);
      this.label14.Name = "label14";
      this.label14.RightToLeft = RightToLeft.No;
      this.label14.Size = new Size(17, 17);
      this.label14.TabIndex = 166;
      this.label15.BackColor = Color.White;
      this.label15.Cursor = Cursors.Default;
      this.label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.Blue;
      this.label15.Location = new Point(136, 16);
      this.label15.Name = "label15";
      this.label15.RightToLeft = RightToLeft.No;
      this.label15.Size = new Size(49, 17);
      this.label15.TabIndex = 165;
      this.label15.Text = "Reserved";
      this.label16.BackColor = Color.Red;
      this.label16.Cursor = Cursors.Default;
      this.label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = SystemColors.ControlText;
      this.label16.Location = new Point(16, 16);
      this.label16.Name = "label16";
      this.label16.RightToLeft = RightToLeft.No;
      this.label16.Size = new Size(17, 17);
      this.label16.TabIndex = 164;
      this.label19.BackColor = Color.White;
      this.label19.Cursor = Cursors.Default;
      this.label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.Blue;
      this.label19.Location = new Point(40, 16);
      this.label19.Name = "label19";
      this.label19.RightToLeft = RightToLeft.No;
      this.label19.Size = new Size(49, 17);
      this.label19.TabIndex = 163;
      this.label19.Text = "Occupied";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.ClientSize = new Size(793, 602);
      this.Controls.Add((Control) this.StatusFrame);
      this.Controls.Add((Control) this.checkBox_EnableChange);
      this.Controls.Add((Control) this.ReservationFrame);
      this.Controls.Add((Control) this.cmdNewReserve);
      this.Controls.Add((Control) this.cmdReservedView);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.cmdReturn);
      this.Controls.Add((Control) this.cmdConfirm);
      this.Controls.Add((Control) this.cmdPrint);
      this.Controls.Add((Control) this.cmdClear);
      this.Controls.Add((Control) this.dateTimePicker_EndDate);
      this.Controls.Add((Control) this.dateTimePicker_StartDate);
      this.Controls.Add((Control) this.lbBuilding);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.cmdView);
      this.Controls.Add((Control) this.cboBuilding);
      this.Controls.Add((Control) this.tabControl1);
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = "Form_SHL_ViewRoomReservation";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Room Reservation";
      this.Load += new EventHandler(this.Form_SHL_RoomView_Load);
      this.VisibleChanged += new EventHandler(this.Form_SHL_ViewRoomReservation_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_SHL_ViewRoomReservation_FormClosing);
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
      this.ReservationFrame.ResumeLayout(false);
      this.ReservationFrame.PerformLayout();
      this.StatusFrame.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form_SHL_ViewRoomReservation()
    {
      this.InitializeComponent();
      this.Init_DataGrid_View(this.dataGridView_Tab1, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab2, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab3, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab4, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab5, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab6, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab7, 8);
      this.Init_DataGrid_View(this.dataGridView_Tab8, 8);
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
        viewTextBoxColumnArray[index].Width = 100;
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
    }

    private void Setup_Rooms_In_DataGridView(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No)
    {
      int index1 = 0;
      int index2 = 0;
      para_DataGridView.Rows.Clear();
      if (!(para_DataTable is TempDataSet.AvailableRoom_TempDataTable) || para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index3 = 0; index3 < para_DataTable.Rows.Count; ++index3)
      {
        if (((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (index2 < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[index1].Cells[index2].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[index1].Cells[index2];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).Description);
            para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = !((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Occupied") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++index2;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            int index4 = 0;
            ++index1;
            para_DataGridView.Rows[index1].Cells[index4].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[index1].Cells[index4];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).Description);
            para_DataGridView.Rows[index1].Cells[index4].Style.BackColor = !(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription == "Occupied") ? (!(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription == "Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index3]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            index2 = index4 + 1;
          }
        }
      }
      if (para_DataTable.Rows.Count <= 0)
        return;
      for (; index2 < para_DataGridView.ColumnCount; ++index2)
        para_DataGridView.Rows[index1].Cells[index2].Style.BackColor = para_DataGridView.BackgroundColor;
    }

    private void Insert_Rooms_In_DataGridView_Relative(
      DataGridView para_DataGridView,
      DataTable para_DataTable,
      string para_Level_No,
      int para_dataGridView_CurrentRow,
      int para_dataGridView_CurrentColumn,
      bool Add_Blank_Row_Flag)
    {
      if (!(para_DataTable is TempDataSet.AvailableRoom_TempDataTable) || para_DataTable.Rows.Count <= 0)
        return;
      para_DataGridView.Rows.Add(1);
      for (int index = 0; index < para_DataTable.Rows.Count; ++index)
      {
        if (((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo.Substring(1, 2) == para_Level_No)
        {
          if (para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount)
          {
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).Description);
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = !(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Occupied") ? (!(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
          else
          {
            para_DataGridView.Rows.Add(1);
            para_dataGridView_CurrentColumn = 0;
            ++para_dataGridView_CurrentRow;
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RoomNo;
            DataGridViewCell cell = para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn];
            cell.Value = (object) (cell.Value.ToString() + "     " + ((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).Description);
            para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = !(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Occupied") ? (!(((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription == "Reserved") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Vacant Clean") ? (!((TempDataSet.AvailableRoom_TempRow) para_DataTable.Rows[index]).RmDescription.Contains("Out of Order") ? this.Vacant_Back_Color : this.OutOfOrder_Back_Color) : this.VacantClean_Back_Color) : this.Reserved_Back_Color) : this.Occupied_Back_Color;
            ++para_dataGridView_CurrentColumn;
          }
        }
      }
      if (para_DataTable.Rows.Count <= 0)
        return;
      for (; para_dataGridView_CurrentColumn < para_DataGridView.ColumnCount; ++para_dataGridView_CurrentColumn)
      {
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Style.BackColor = para_DataGridView.BackgroundColor;
        para_DataGridView.Rows[para_dataGridView_CurrentRow].Cells[para_dataGridView_CurrentColumn].Value = (object) "";
      }
      if (!Add_Blank_Row_Flag)
        return;
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

    private void dataGridView_Tab1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab1__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab1.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab2_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab2.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab3_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab3.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab4_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab4.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab5_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab5.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab6_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab6.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab7_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab7.Refresh();
        if (this.Editing_Mode)
          return;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = true;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        this.Get_and_Set_OldReserved_Information();
      }
      else if ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (this.Editing_Mode)
          return;
        this.Clear_Client_Information();
      }
    }

    private void dataGridView_Tab8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      Console.Beep(600, 300);
      if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab8.Refresh();
        if (!this.Editing_Mode)
        {
          this.cmdNewReserve.Enabled = false;
          this.cmdReservedView.Enabled = true;
          this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
          this.Get_and_Set_OldReserved_Information();
        }
      }
      else if ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") || this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (!this.Editing_Mode)
          this.Clear_Client_Information();
      }
      Thread.Sleep(500);
    }

    private void dataGridView_Tab8_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      Console.Beep(600, 300);
      if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Reserved_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.dataGridView_Tab8.Refresh();
        if (!this.Editing_Mode)
        {
          this.cmdNewReserve.Enabled = false;
          this.cmdReservedView.Enabled = true;
          this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
          this.Get_and_Set_OldReserved_Information();
        }
      }
      else if ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "" || ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Contains("Level") || this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.Occupied_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else if (this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == this.OutOfOrder_Back_Color)
      {
        this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
        this.cmdNewReserve.Enabled = false;
        this.cmdReservedView.Enabled = false;
      }
      else
      {
        this.cmdNewReserve.Enabled = true;
        this.cmdReservedView.Enabled = false;
        this.lblBookingRoomNo.Text = ((string) this.dataGridView_Tab8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).Substring(0, 5);
        if (!this.Editing_Mode)
          this.Clear_Client_Information();
      }
      Thread.Sleep(500);
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tabControl1.SelectedTab == this.Level1)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab1, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "01");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab1);
      }
      else if (this.tabControl1.SelectedTab == this.Level2)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab2, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "02");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab2);
      }
      else if (this.tabControl1.SelectedTab == this.Level3)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab3, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "03");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab3);
      }
      else if (this.tabControl1.SelectedTab == this.Level4)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab4, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "04");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab4);
      }
      else if (this.tabControl1.SelectedTab == this.Level5)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab5, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "05");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab5);
      }
      else if (this.tabControl1.SelectedTab == this.Level6)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab6, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "06");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab6);
      }
      else if (this.tabControl1.SelectedTab == this.Level7)
      {
        this.Setup_Rooms_In_DataGridView(this.dataGridView_Tab7, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp, "07");
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab7);
      }
      else
      {
        if (this.tabControl1.SelectedTab != this.All_Level)
          return;
        this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab8, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp);
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      }
    }

    private void Form_SHL_RoomView_Load(object sender, EventArgs e)
    {
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit = false;
      this.CheckBuilding(this.cboBuilding, ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel);
      this.db.Update_Date_Building_Roomstaus_Table((string) this.cboBuilding.SelectedItem);
      this.dateTimePicker_EndDate.Value = this.dateTimePicker_StartDate.Value.AddMonths(1);
      this.cmdNewReserve.BackColor = this.New_Reserve_Inactive_Backcolor;
      this.cmdReservedView.BackColor = this.Reserve_View_Inactive_Backcolor;
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      this.Clear_Reservation_And_Reset();
      this.db.temp_DB.tempDataSet.AvailableRoom_Temp.Clear();
      this.dataGridView_Tab1.Rows.Clear();
      this.dataGridView_Tab2.Rows.Clear();
      this.dataGridView_Tab3.Rows.Clear();
      this.dataGridView_Tab4.Rows.Clear();
      this.dataGridView_Tab5.Rows.Clear();
      this.dataGridView_Tab5.Rows.Clear();
      this.dataGridView_Tab6.Rows.Clear();
      this.dataGridView_Tab7.Rows.Clear();
      this.dataGridView_Tab8.Rows.Clear();
    }

    private void cmdView_Click(object sender, EventArgs e)
    {
      this.lblMessage.Text = "Loading Room Infomation!";
      this.lblMessage.Refresh();
      this.db.Get_AvailableRoom_Temp((string) this.cboBuilding.SelectedItem, "ALLGUEST");
      this.tabControl1.SelectedTab = this.All_Level;
      this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab8, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      this.db.Get_AccReservationList();
      this.tabControl1.Refresh();
      this.lblMessage.Text = "";
    }

    private void CheckBuilding(ComboBox para_ComboBox, string para_myAccLevel)
    {
      para_ComboBox.Items.Clear();
      try
      {
        if (this.db.system_DB.systemDataSet.Building.Rows.Count <= 0)
          this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      catch
      {
        this.db.system_DB.buildingTableAdapter.Fill(this.db.system_DB.systemDataSet.Building);
      }
      foreach (SystemDataSet.BuildingRow row in (InternalDataCollectionBase) this.db.system_DB.systemDataSet.Building.Rows)
      {
        if (para_myAccLevel != "0")
        {
          if (row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || row.BuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
            para_ComboBox.Items.Add((object) row.BuildingNo);
        }
        else
          para_ComboBox.Items.Add((object) row.BuildingNo);
        if (para_ComboBox.Items.Count > 0)
          para_ComboBox.SelectedItem = (object) ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo;
      }
    }

    private void Form_SHL_ViewRoomReservation_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void dateTimePicker_StartDate_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_Start_Date = this.dateTimePicker_StartDate.Value.Date;
    }

    private void dateTimePicker_StartDate_ValueChanged(object sender, EventArgs e)
    {
      if (this.dateTimePicker_EndDate.Value.CompareTo(this.dateTimePicker_StartDate.Value) >= 0)
        return;
      int num = (int) MessageBox.Show("Start Date must be earlier than End Date!");
      this.dateTimePicker_StartDate.Value = this.Old_Start_Date;
    }

    private void dateTimePicker_EndDate_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_End_Date = this.dateTimePicker_EndDate.Value.Date;
    }

    private void dateTimePicker_EndDate_ValueChanged(object sender, EventArgs e)
    {
      if (this.dateTimePicker_EndDate.Value.CompareTo(this.dateTimePicker_StartDate.Value) >= 0)
        return;
      int num = (int) MessageBox.Show("Start Date must be earlier than End Date!");
      this.dateTimePicker_EndDate.Value = this.Old_End_Date;
    }

    private void cmdNewReserve_EnabledChanged(object sender, EventArgs e)
    {
      if (this.cmdNewReserve.Enabled)
        this.cmdNewReserve.BackColor = this.New_Reserve_Active_Backcolor;
      else
        this.cmdNewReserve.BackColor = this.New_Reserve_Inactive_Backcolor;
    }

    private void cmdReservedView_EnabledChanged(object sender, EventArgs e)
    {
      if (this.cmdReservedView.Enabled)
        this.cmdReservedView.BackColor = this.Reserve_View_Active_Backcolor;
      else
        this.cmdReservedView.BackColor = this.Reserve_View_Inactive_Backcolor;
    }

    private void cmdNewReserve_Click(object sender, EventArgs e)
    {
      this.ReservationFrame.Enabled = true;
      this.cmdReservedView.Visible = false;
      this.cmdNewReserve.Visible = false;
      this.cmdReservedView.Enabled = false;
      this.cmdNewReserve.Enabled = false;
      this.cmdClear.Enabled = true;
      this.label_ReservationType.Text = "New";
      this.Date_Time_Inserting_Flag = true;
      this.dateTimePicker_BookingStart.Value = this.dateTimePicker_StartDate.Value.Date;
      this.dateTimePicker_BookingEnd.Value = this.dateTimePicker_EndDate.Value.Date;
      this.Date_Time_Inserting_Flag = false;
      this.tabControl1.Enabled = false;
      this.Editing_Mode = false;
      this.txtReservationRef.Text = "R-" + this.db.GetReserveNo_New("Guest", (string) this.cboBuilding.SelectedItem);
      this.txtClientID.Text = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.GetNew_ClientID(true, (int) Convert.ToInt16((string) this.cboBuilding.SelectedItem));
      this.txtNoOfDays.Text = this.db.Get_No_Of_Days(this.dateTimePicker_BookingStart.Value, this.dateTimePicker_BookingEnd.Value).ToString();
      this.cmdConfirm.Text = "Confirm";
      this.cmdPrint.Enabled = false;
    }

    private void cmdReservedView_Click(object sender, EventArgs e)
    {
      this.ReservationFrame.Enabled = true;
      this.cmdReservedView.Visible = false;
      this.cmdNewReserve.Visible = false;
      this.cmdReservedView.Enabled = false;
      this.cmdNewReserve.Enabled = false;
      this.cmdClear.Enabled = true;
      this.label_ReservationType.Text = "Editing";
      this.checkBox_EnableChange.Enabled = true;
      this.checkBox_EnableChange.Visible = true;
      this.Old_Reserved_Room = this.lblBookingRoomNo.Text;
      this.lblOldRoomNo.Text = this.Old_Reserved_Room;
      this.tabControl1.Enabled = false;
      this.Editing_Mode = true;
      try
      {
        this.Old_Deposit = Convert.ToDecimal(this.txtDeposit.Text);
      }
      catch
      {
        this.Old_Deposit = 0M;
      }
      this.txtNoOfDays.Text = this.db.Get_No_Of_Days(this.dateTimePicker_BookingStart.Value, this.dateTimePicker_BookingEnd.Value).ToString();
      this.cmdConfirm.Text = "Update";
      this.cmdConfirm.Enabled = true;
      this.cmdPrint.Enabled = false;
    }

    private void Clear_Reservation_Frame_and_reset()
    {
      this.txtReservationRef.Text = "";
      this.txtClientID.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.lblOldRoom.Visible = false;
      this.lblOldRoomNo.Text = "";
      this.lblBookingRoomNo.Text = "";
      this.txtNoOfDays.Text = "";
      this.txtDeposit.Text = "";
      this.lblDifference.Visible = false;
      this.lblDiffAmount.Text = "";
      this.lblOldDeposit.Visible = false;
      this.lblOldDepositAmount.Text = "";
      this.Editing_Mode = false;
    }

    private void Clear_Reservation_And_Reset()
    {
      this.cmdReservedView.Visible = true;
      this.cmdNewReserve.Visible = true;
      this.cmdReservedView.Enabled = false;
      this.cmdNewReserve.Enabled = false;
      this.Clear_Reservation_Frame_and_reset();
      this.ReservationFrame.Enabled = false;
      this.label_ReservationType.Text = "";
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab1);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab2);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab3);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab4);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab5);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab5);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab6);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab7);
      this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
      this.checkBox_EnableChange.Checked = false;
      this.checkBox_EnableChange.Enabled = false;
      this.checkBox_EnableChange.Visible = false;
      this.lblOldRoom.Visible = false;
      this.lblOldRoomNo.Text = "";
      this.lblBookingRoomNo.Text = "";
      this.Label_SelectRoom.Text = "Room No.";
      this.tabControl1.Enabled = true;
      this.cmdConfirm.Text = "Confirm";
      this.cmdConfirm.Enabled = false;
      this.cmdPrint.Enabled = false;
      this.Old_Deposit_Differnce_Disable();
    }

    private void cmdClear_Click(object sender, EventArgs e) => this.Clear_Reservation_And_Reset();

    private void checkBox_EnableChange_Click(object sender, EventArgs e)
    {
      if (!this.checkBox_EnableChange.Checked)
        return;
      this.checkBox_EnableChange.Enabled = false;
      this.lblOldRoom.Visible = true;
      this.lblOldRoomNo.Visible = true;
      this.lblOldRoomNo.Text = this.Old_Reserved_Room;
      this.Label_SelectRoom.Text = "New Room";
      this.tabControl1.Enabled = true;
    }

    private void dateTimePicker_BookingStart_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_Booking_StartDate = this.dateTimePicker_BookingStart.Value.Date;
    }

    private void dateTimePicker_BookingStart_ValueChanged(object sender, EventArgs e)
    {
      if (this.Date_Time_Inserting_Flag)
        return;
      if (this.dateTimePicker_BookingEnd.Value.CompareTo(this.dateTimePicker_BookingStart.Value) < 0)
      {
        int num = (int) MessageBox.Show("Start Date must be earlier than End Date!");
        this.dateTimePicker_BookingStart.Value = this.Old_Booking_StartDate;
      }
      this.txtNoOfDays.Text = this.db.Get_No_Of_Days(this.dateTimePicker_BookingStart.Value, this.dateTimePicker_BookingEnd.Value).ToString();
    }

    private void dateTimePicker_BookingEnd_MouseDown(object sender, MouseEventArgs e)
    {
      this.Old_Booking_EndDate = this.dateTimePicker_BookingEnd.Value.Date;
    }

    private void dateTimePicker_BookingEnd_ValueChanged(object sender, EventArgs e)
    {
      if (this.Date_Time_Inserting_Flag)
        return;
      if (this.dateTimePicker_BookingEnd.Value.CompareTo(this.dateTimePicker_BookingStart.Value) < 0)
      {
        int num = (int) MessageBox.Show("Start Date must be earlier than End Date!");
        this.dateTimePicker_BookingEnd.Value = this.Old_Booking_EndDate;
      }
      this.txtNoOfDays.Text = this.db.Get_No_Of_Days(this.dateTimePicker_BookingStart.Value, this.dateTimePicker_BookingEnd.Value).ToString();
    }

    private void Form_SHL_ViewRoomReservation_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Clear_Client_Information();
      this.cmdConfirm.Enabled = false;
      this.cmdPrint.Enabled = false;
      this.lblMessage.Text = "Click View Room To Load Room List and Choose Room No.";
      this.cmdView.Select();
      this.cmdView.Focus();
    }

    private void Get_and_Set_OldReserved_Information()
    {
      try
      {
        if (this.db.temp_DB.tempDataSet.AccReservationList.Rows.Count < 0)
          this.db.Get_AccReservationList();
      }
      catch
      {
        this.db.Get_AccReservationList();
      }
      foreach (TempDataSet.AccReservationListRow row in (InternalDataCollectionBase) this.db.temp_DB.tempDataSet.AccReservationList.Rows)
      {
        if (row.RoomNo == this.lblBookingRoomNo.Text)
        {
          this.txtClientID.Text = row.ClientID;
          this.txtReservationRef.Text = row.ReserveRef;
          this.txtFirstName.Text = row.ForeName;
          this.txtSurName.Text = row.SurName;
          this.Date_Time_Inserting_Flag = true;
          this.dateTimePicker_BookingStart.Value = row.StartDate;
          this.dateTimePicker_BookingEnd.Value = row.EndDate;
          this.Date_Time_Inserting_Flag = false;
          this.txtDeposit.Text = row.Deposit.ToString("F2");
          break;
        }
      }
    }

    private void Clear_Client_Information()
    {
      this.txtClientID.Text = "";
      this.txtReservationRef.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.Date_Time_Inserting_Flag = true;
      this.dateTimePicker_BookingStart.Value = this.dateTimePicker_StartDate.Value.Date;
      this.dateTimePicker_BookingEnd.Value = this.dateTimePicker_EndDate.Value.Date;
      this.Date_Time_Inserting_Flag = false;
      this.txtDeposit.Text = "";
    }

    private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar))
        e.Handled = false;
      else if (char.IsControl(e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '.')
      {
        if (this.txtDeposit.Text.Contains("."))
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '-')
        e.Handled = false;
      else
        e.Handled = true;
    }

    private Decimal calculate_differnce()
    {
      Decimal num;
      try
      {
        num = Convert.ToDecimal(this.txtDeposit.Text);
      }
      catch
      {
        num = 0M;
      }
      Decimal differnce = num - this.Old_Deposit;
      if (differnce >= 0M)
      {
        this.lblDifference.Text = "Collect";
        this.lblDiffAmount.Text = differnce.ToString("F2");
      }
      else
      {
        this.lblDifference.Text = "Refund";
        this.lblDiffAmount.Text = (-differnce).ToString("F2");
      }
      return differnce;
    }

    private void Old_Deposit_Differnce_Enable()
    {
      this.lblOldDeposit.Visible = true;
      this.lblOldDepositAmount.Visible = true;
      this.lblDiffAmount.Visible = true;
      this.lblDifference.Visible = true;
      this.lblOldDeposit.Enabled = true;
      this.lblOldDepositAmount.Enabled = true;
      this.lblDiffAmount.Enabled = true;
      this.lblDifference.Enabled = true;
      this.lblOldDepositAmount.Text = this.Old_Deposit.ToString("F");
    }

    private void Old_Deposit_Differnce_Disable()
    {
      this.lblOldDeposit.Visible = false;
      this.lblOldDepositAmount.Visible = false;
      this.lblDiffAmount.Visible = false;
      this.lblDifference.Visible = false;
      this.lblOldDeposit.Enabled = false;
      this.lblOldDepositAmount.Enabled = false;
      this.lblDiffAmount.Enabled = false;
      this.lblDifference.Enabled = false;
      this.lblDifference.Text = "Collect";
    }

    private void txtDeposit_TextChanged(object sender, EventArgs e)
    {
      if (this.txtDeposit.Text.Length == 0)
        this.txtDeposit.Text = "0";
      if (!this.Editing_Mode)
        return;
      if (this.calculate_differnce() != 0M)
        this.Old_Deposit_Differnce_Enable();
      else
        this.Old_Deposit_Differnce_Disable();
    }

    private void lblDiffAmount_Click(object sender, EventArgs e)
    {
    }

    private void ReservationFrame_EnabledChanged(object sender, EventArgs e)
    {
      if (this.ReservationFrame.Enabled)
        return;
      this.cmdConfirm.Enabled = false;
      this.cmdPrint.Enabled = false;
    }

    private void txtFirstName_TextChanged(object sender, EventArgs e)
    {
      if (this.txtFirstName.Text.Length > 0 && this.txtSurName.Text.Length > 0)
      {
        this.cmdConfirm.Enabled = true;
      }
      else
      {
        this.cmdConfirm.Enabled = false;
        this.cmdPrint.Enabled = false;
      }
    }

    private void txtSurName_TextChanged(object sender, EventArgs e)
    {
      if (this.txtFirstName.Text.Length > 0 && this.txtSurName.Text.Length > 0)
      {
        this.cmdConfirm.Enabled = true;
      }
      else
      {
        this.cmdConfirm.Enabled = false;
        this.cmdPrint.Enabled = false;
      }
    }

    private bool Update_CardTrans_Table()
    {
      int newTransId = this.db.GetNew_TransID((string) this.cboBuilding.SelectedItem);
      if (newTransId == -1)
      {
        int num = (int) MessageBox.Show("Can't Get TransID!");
        return false;
      }
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID = newTransId.ToString();
      BuildingDB1DataSet.CardTransRow row = this.db.building_DB1.buildingDB1DataSet.CardTrans.NewCardTransRow();
      row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      row.ClientID = this.txtClientID.Text;
      row.CardType = "Guest";
      row.RoomNo = this.lblBookingRoomNo.Text;
      row.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit ? "Unit" : "Individual";
      row.ReserveRef = this.txtReservationRef.Text;
      row.TransType = "R";
      row.TransDate = DateTime.Now.Date;
      row.TransTime = DateTime.Now.ToShortTimeString();
      row.ValidStart = this.dateTimePicker_BookingStart.Value.Date;
      row.ValidEnd = this.dateTimePicker_BookingEnd.Value.Date;
      if (!this.Editing_Mode)
      {
        row.Deposit = Convert.ToDecimal(this.txtDeposit.Text);
        row.LastPayment = Convert.ToDecimal(this.txtDeposit.Text);
      }
      else
      {
        Decimal differnce = this.calculate_differnce();
        row.Deposit = differnce;
        row.LastPayment = differnce;
      }
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      row.Update = false;
      this.db.building_DB1.buildingDB1DataSet.CardTrans.AddCardTransRow(row);
      if (this.db.building_DB1.cardTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.CardTrans) > 0)
        return true;
      int num1 = (int) MessageBox.Show("CardTrans Table can not be updated!");
      return false;
    }

    private bool Update_LastTrans_Table()
    {
      this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      while (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count > 0)
      {
        this.db.building_DB1.lastTransTableAdapter.Delete(new int?(((BuildingDB1DataSet.LastTransRow) this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows[0]).TransID));
        this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
        if (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count == 0)
          break;
      }
      this.db.building_DB1.lastTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      BuildingDB1DataSet.LastTransRow row = this.db.building_DB1.buildingDB1DataSet.LastTrans.NewLastTransRow();
      row.RBA = 0M;
      row.Balance = 0M;
      row.TransID = Convert.ToInt32(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.iTrackTransID);
      row.ClientID = this.txtClientID.Text;
      row.CardType = "Guest";
      row.RoomNo = this.lblBookingRoomNo.Text;
      row.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit ? "Unit" : "Individual";
      row.ReserveRef = this.txtReservationRef.Text;
      row.TransType = "R";
      row.TransDate = DateTime.Now.Date;
      row.TransTime = DateTime.Now.ToShortTimeString();
      row.ValidStart = this.dateTimePicker_BookingStart.Value.Date;
      row.ValidEnd = this.dateTimePicker_BookingEnd.Value.Date;
      if (!this.Editing_Mode)
      {
        row.Deposit = Convert.ToDecimal(this.txtDeposit.Text);
        row.LastPayment = Convert.ToDecimal(this.txtDeposit.Text);
      }
      else
      {
        Decimal differnce = this.calculate_differnce();
        row.Deposit = differnce;
        row.LastPayment = differnce;
      }
      row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
      this.db.building_DB1.buildingDB1DataSet.LastTrans.AddLastTransRow(row);
      if (this.db.building_DB1.lastTransTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.LastTrans) > 0)
        return true;
      int num = (int) MessageBox.Show("LastTrans Table can not be updated!");
      return false;
    }

    private bool EDIT_DATABASE()
    {
      if (!this.Reset_RoomStaus_ToVacant(this.lblOldRoomNo.Text, (string) this.cboBuilding.SelectedItem))
        return false;
      if (!this.RC_Status_Add(this.lblBookingRoomNo.Text, (string) this.cboBuilding.SelectedItem))
        return false;
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.Reserve.Rows.Count <= 0)
          this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
      }
      catch
      {
        this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
      }
      bool flag1 = false;
      foreach (BuildingDB1DataSet.ReserveRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.Reserve.Rows)
      {
        if (row.ReserveRef == this.txtReservationRef.Text)
        {
          if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit)
          {
            row.ReserveType = "Individual";
            row.RoomNo = this.lblBookingRoomNo.Text;
          }
          else
          {
            row.ReserveType = "Unit";
            row.RoomNo = this.lblBookingRoomNo.Text;
          }
          row.StartDate = this.dateTimePicker_BookingStart.Value.Date;
          row.EndDate = this.dateTimePicker_BookingEnd.Value.Date;
          row.Update = false;
          flag1 = true;
          break;
        }
      }
      if (flag1)
      {
        if (this.db.building_DB1.reserveTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.Reserve) <= 0)
        {
          int num = (int) MessageBox.Show("Failed in Reserve Table Update in EDITDATABASE!");
          return false;
        }
        try
        {
          if (this.db.building_DB1.buildingDB1DataSet.Client.Rows.Count <= 0)
            this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
        }
        catch
        {
          this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
        }
        bool flag2 = false;
        foreach (BuildingDB1DataSet.ClientRow clientRow in this.db.building_DB1.buildingDB1DataSet.Client)
        {
          if (clientRow.ClientID == this.txtClientID.Text)
          {
            clientRow.ForeName = this.txtFirstName.Text;
            clientRow.SurName = this.txtSurName.Text;
            clientRow.Update = false;
            flag2 = true;
            break;
          }
        }
        if (flag2)
        {
          if (this.db.building_DB1.clientTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.Client) <= 0)
          {
            int num = (int) MessageBox.Show("Failed in Client Table Edit in EDITDATABASE!, Client Table can not be updated!");
            return false;
          }
          try
          {
            if (this.db.building_DB1.buildingDB1DataSet.ClientAcc.Rows.Count <= 0)
              this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
          }
          catch
          {
            this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
          }
          bool flag3 = false;
          foreach (BuildingDB1DataSet.ClientAccRow clientAccRow in this.db.building_DB1.buildingDB1DataSet.ClientAcc)
          {
            if (clientAccRow.ClientID == this.txtClientID.Text)
            {
              clientAccRow.ContractStart = this.dateTimePicker_BookingStart.Value.Date;
              clientAccRow.ContractEnd = this.dateTimePicker_BookingEnd.Value.Date;
              clientAccRow.RoomNo = this.lblBookingRoomNo.Text;
              try
              {
                clientAccRow.Deposit = Convert.ToDecimal(this.txtDeposit.Text);
              }
              catch
              {
                clientAccRow.Deposit = 0M;
              }
              clientAccRow.Update = false;
              flag3 = true;
              break;
            }
          }
          if (flag3)
          {
            if (this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) <= 0)
            {
              int num = (int) MessageBox.Show("Failed in ClientAcc Table Edit in EDITDATABASE!, ClientAcc Table can not be updated!");
              return false;
            }
            return this.Update_CardTrans_Table() && this.Update_LastTrans_Table();
          }
          int num1 = (int) MessageBox.Show("Failed in ClientAcc Table Edit in EDITDATABASE!, Client ID not found!");
          return false;
        }
        int num2 = (int) MessageBox.Show("Failed in Client Table Edit in EDITDATABASE!, Client ID not found!");
        return false;
      }
      int num3 = (int) MessageBox.Show("Failed in Reserve Table Edit in EDITDATABASE!");
      return false;
    }

    private bool UPDATE_DATABASE()
    {
      if (!this.RC_Status_Add(this.lblBookingRoomNo.Text, (string) this.cboBuilding.SelectedItem))
        return false;
      this.db.building_DB1.reserveTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Reserve);
      BuildingDB1DataSet.ReserveRow row1 = this.db.building_DB1.buildingDB1DataSet.Reserve.NewReserveRow();
      if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit)
      {
        row1.ReserveType = "Individual";
        row1.RoomNo = this.lblBookingRoomNo.Text;
      }
      else
      {
        row1.ReserveType = "Unit";
        row1.RoomNo = this.lblBookingRoomNo.Text;
      }
      row1.ReserveRef = this.txtReservationRef.Text;
      row1.ClientID = this.txtClientID.Text;
      row1.StartDate = this.dateTimePicker_BookingStart.Value.Date;
      row1.EndDate = this.dateTimePicker_BookingEnd.Value.Date;
      row1.Update = false;
      this.db.building_DB1.buildingDB1DataSet.Reserve.AddReserveRow(row1);
      if (this.db.building_DB1.reserveTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.Reserve) <= 0)
      {
        int num = (int) MessageBox.Show("Failed in Reserve Table Update in UPDATE_DATABASE!");
        return false;
      }
      this.db.building_DB1.clientTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.Client);
      BuildingDB1DataSet.ClientRow row2 = this.db.building_DB1.buildingDB1DataSet.Client.NewClientRow();
      row2.ClientID = this.txtClientID.Text;
      row2.ForeName = this.txtFirstName.Text;
      row2.SurName = this.txtSurName.Text;
      row2.ClientType = "G";
      row2.Update = false;
      this.db.building_DB1.buildingDB1DataSet.Client.AddClientRow(row2);
      if (this.db.building_DB1.clientTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.Client) <= 0)
      {
        int num = (int) MessageBox.Show("Failed in Cleint Table Update in UPDATE_DATABASE!");
        return false;
      }
      this.db.building_DB1.clientAccTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.ClientAcc);
      BuildingDB1DataSet.ClientAccRow row3 = this.db.building_DB1.buildingDB1DataSet.ClientAcc.NewClientAccRow();
      row3.ClientID = this.txtClientID.Text;
      row3.RoomNo = this.lblBookingRoomNo.Text;
      try
      {
        row3.Deposit = Convert.ToDecimal(this.txtDeposit.Text);
      }
      catch
      {
        row3.Deposit = 0M;
      }
      row3.NoOfPeople = (byte) 0;
      row3.ContractStart = this.dateTimePicker_BookingStart.Value.Date;
      row3.ContractEnd = this.dateTimePicker_BookingEnd.Value.Date;
      row3.Update = false;
      this.db.building_DB1.buildingDB1DataSet.ClientAcc.AddClientAccRow(row3);
      if (this.db.building_DB1.clientAccTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.ClientAcc) <= 0)
      {
        int num = (int) MessageBox.Show("Failed in CleintAcc Table Update in UPDATE_DATABASE!");
        return false;
      }
      return this.Update_CardTrans_Table() && this.Update_LastTrans_Table();
    }

    private bool Update_or_Add_ReservationTables()
    {
      if (this.Editing_Mode)
      {
        if (!this.EDIT_DATABASE())
          return false;
      }
      else if (!this.UPDATE_DATABASE())
        return false;
      return true;
    }

    private bool Reset_RoomStaus_ToVacant(string para_Room_No, string para_BuildingNo)
    {
      bool flag = false;
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count < 0)
          this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      catch
      {
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_Room_No)
        {
          row.Status = (byte) 0;
          row.Description = "Vacant";
          row.ClientID = "";
          row.StartDate = DateTime.Now.Date;
          row.EndDate = DateTime.Now.Date;
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          flag = true;
          break;
        }
      }
      if (!flag || this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) <= 0)
        return false;
      this.db.Update_RoomStausXX_inSystemDB((string) this.cboBuilding.SelectedItem);
      return true;
    }

    private bool RC_Status_Add(string para_Room_No, string para_BuildingNo)
    {
      bool flag = false;
      try
      {
        if (this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows.Count < 0)
          this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      catch
      {
        this.db.building_DB1.roomStatusTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.RoomStatus);
      }
      foreach (BuildingDB1DataSet.RoomStatusRow row in (InternalDataCollectionBase) this.db.building_DB1.buildingDB1DataSet.RoomStatus.Rows)
      {
        if (row.RoomNo == para_Room_No)
        {
          row.Status = (byte) 2;
          row.Description = "Reserved";
          row.ClientID = this.txtClientID.Text;
          row.StartDate = this.dateTimePicker_BookingStart.Value.Date;
          row.EndDate = this.dateTimePicker_BookingEnd.Value.Date;
          row.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
          row.Update = false;
          row.Condition = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bWholeUnit ? "Unit" : "Individual";
          flag = true;
          break;
        }
      }
      if (!flag || this.db.building_DB1.roomStatusTableAdapter.Update(this.db.building_DB1.buildingDB1DataSet.RoomStatus) <= 0)
        return false;
      this.db.Update_RoomStausXX_inSystemDB((string) this.cboBuilding.SelectedItem);
      return true;
    }

    private void cmdConfirm_Click(object sender, EventArgs e)
    {
      bool flag = this.db.Backup_Before_Transact((string) this.cboBuilding.SelectedItem);
      if (this.Update_or_Add_ReservationTables())
      {
        int num = (int) MessageBox.Show("Reservation Successful !");
        this.Clear_Reservation_And_Reset();
        this.db.Get_AvailableRoom_Temp((string) this.cboBuilding.SelectedItem, "ALLGUEST");
        this.tabControl1.SelectedTab = this.All_Level;
        this.Setup_Rooms_In_DataGridView_forAllLevel(this.dataGridView_Tab8, (DataTable) this.db.temp_DB.tempDataSet.AvailableRoom_Temp);
        this.Disable_AutoSelected_Cell(this.dataGridView_Tab8);
        this.db.Get_AccReservationList();
        this.cmdPrint.Enabled = true;
      }
      else
      {
        int num = (int) MessageBox.Show("Reservation Failed !");
        if (!flag)
          return;
        this.db.Restore_For_FailedTransact((string) this.cboBuilding.SelectedItem);
      }
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      this.db.building_DB1.lastTransTableAdapter.Fill(this.db.building_DB1.buildingDB1DataSet.LastTrans);
      if (this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count <= 0)
        return;
      BuildingDB1DataSet.LastTransRow lastTran = this.db.building_DB1.buildingDB1DataSet.LastTrans[this.db.building_DB1.buildingDB1DataSet.LastTrans.Rows.Count - 1];
      string transType = lastTran.TransType;
      int transId = lastTran.TransID;
      this.Refresh();
      ReportForm reportForm = new ReportForm();
      ReportClass_Receipt_Reservation receiptReservation = new ReportClass_Receipt_Reservation();
      reportForm.crystalReportViewer1.ReportSource = receiptReservation.CHECK_TransType(transType, transId, Global_Data.sBldNo);
      int num = (int) reportForm.ShowDialog();
    }
  }
}
