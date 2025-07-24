// Decompiled with JetBrains decompiler
// Type: AMS.Form_RoomTypeDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.SystemDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_RoomTypeDMS : Form
  {
    private DB db;
    public SystemDataSet Browse_RoomType_DataSet;
    public RoomTypeTableAdapter RoomTypeTableAdapter_1;
    public int selected_rowindex;
    public bool OK_Flag;
    public byte Selected_Room_Type;
    private string Old_RoomType = "";
    private IContainer components;
    public ToolTip ToolTip1;
    public Button CmdPrint;
    public TextBox txtMinCard;
    public TextBox txtMaxCard;
    public Button cmdPrevious;
    public Button cmdFirst;
    public Button cmdNext;
    public Button cmdLast;
    public Button cmdReturn;
    public Button cmdDelete;
    public Button cmdAdd;
    public Button cmdNew;
    public TextBox txtRmType;
    public Button cmdRmTypeBrowse;
    public TextBox txtRmDescription;
    public GroupBox Frame1;
    public Label Label4;
    public Label Label3;
    public Label Label2;
    public Label Label1;
    public Label Label5;
    public Label lblMessage;

    public Form_RoomTypeDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
      this.Browse_RoomType_DataSet = new SystemDataSet();
      this.RoomTypeTableAdapter_1 = new RoomTypeTableAdapter();
      this.RoomTypeTableAdapter_1.ClearBeforeFill = true;
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_SystemSettingDMS_Ptr.Visible = true;
    }

    private void Form_RoomTypeDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void Form_RoomTypeDMS_Load(object sender, EventArgs e)
    {
      this.ClearScreen();
      this.RoomTypeTableAdapter_1.Fill(this.Browse_RoomType_DataSet.RoomType);
      if (this.Browse_RoomType_DataSet.RoomType.Count <= 0)
        return;
      SystemDataSet.RoomTypeRow roomTypeRow = this.Browse_RoomType_DataSet.RoomType[0];
      this.txtRmType.Text = roomTypeRow.RoomType.ToString();
      this.txtRmDescription.Text = roomTypeRow.RmDescription;
      this.txtMaxCard.Text = roomTypeRow.MaxCard.ToString();
      this.txtMinCard.Text = roomTypeRow.MinCard.ToString();
    }

    private void ClearScreen()
    {
      this.txtRmType.Text = "";
      this.txtRmDescription.Text = "";
      this.txtMaxCard.Text = "";
      this.txtMinCard.Text = "";
    }

    private void ClearScreen2()
    {
      this.txtRmDescription.Text = "";
      this.txtMaxCard.Text = "";
      this.txtMinCard.Text = "";
    }

    private void cmdNew_Click(object sender, EventArgs e) => this.ClearScreen();

    private void cmdRmTypeBrowse_Click(object sender, EventArgs e)
    {
      try
      {
        this.RoomTypeTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from RoomType";
        this.RoomTypeTableAdapter_1.Fill(this.Browse_RoomType_DataSet.RoomType);
        int num = (int) new Form_RoomTypebwr().ShowDialog();
        if (this.OK_Flag)
        {
          this.txtRmType.Text = this.Selected_Room_Type.ToString();
          this.RoomTypeTableAdapter_1.Adapter.SelectCommand.CommandText = "Select * from RoomType";
          this.RoomTypeTableAdapter_1.Fill(this.Browse_RoomType_DataSet.RoomType);
          try
          {
            this.ClearScreen2();
            this.Refresh();
            Thread.Sleep(300);
            if (ClsRoomType.ReadIt(this.db, Convert.ToByte(this.txtRmType.Text)))
            {
              this.UpdateScreen();
            }
            else
            {
              this.lblMessage.Text = "No Such Room Type Found!";
              this.lblMessage.Refresh();
              Console.Beep(700, 800);
              this.lblMessage.Text = "";
              this.ClearScreen();
            }
          }
          catch
          {
            this.lblMessage.Text = "No Such Room Type Found!";
            this.lblMessage.Refresh();
            Console.Beep(700, 800);
            this.lblMessage.Text = "";
            this.ClearScreen();
          }
        }
        else
          this.ClearScreen();
      }
      catch
      {
        int num = (int) MessageBox.Show("Room Type Table Loading Fail!");
      }
    }

    private void UpdateScreen()
    {
      this.txtRmType.Text = ClsRoomType.RoomType.ToString();
      this.txtRmDescription.Text = ClsRoomType.RmDescription;
      this.txtMaxCard.Text = ClsRoomType.MaxCard.ToString();
      this.txtMinCard.Text = ClsRoomType.MinCard.ToString();
      this.Old_RoomType = this.txtRmType.Text;
    }

    private void txtRmType_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r')
      {
        try
        {
          this.ClearScreen2();
          this.Refresh();
          Thread.Sleep(300);
          if (ClsRoomType.ReadIt(this.db, Convert.ToByte(this.txtRmType.Text)))
          {
            this.UpdateScreen();
          }
          else
          {
            this.lblMessage.Text = "No Such Room Type Found!";
            this.lblMessage.Refresh();
            Console.Beep(700, 800);
            this.lblMessage.Text = "";
            this.ClearScreen();
          }
        }
        catch
        {
          this.lblMessage.Text = "No Such Room Type Found!";
          this.lblMessage.Refresh();
          Console.Beep(700, 800);
          this.lblMessage.Text = "";
          this.ClearScreen();
        }
      }
      else
      {
        if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
          return;
        e.Handled = true;
      }
    }

    private void cmdPrevious_Click(object sender, EventArgs e)
    {
      try
      {
        if (ClsRoomType.MovePrevious1(this.db, Convert.ToByte(this.txtRmType.Text)))
        {
          this.UpdateScreen();
        }
        else
        {
          this.lblMessage.Text = "No More Room Type Found!";
          this.lblMessage.Refresh();
          Console.Beep(700, 800);
          this.lblMessage.Text = "";
        }
      }
      catch
      {
      }
    }

    private void cmdNext_Click(object sender, EventArgs e)
    {
      try
      {
        if (ClsRoomType.MoveNext(this.db, Convert.ToByte(this.txtRmType.Text)))
        {
          this.UpdateScreen();
        }
        else
        {
          this.lblMessage.Text = "No More Room Type Found!";
          this.lblMessage.Refresh();
          Console.Beep(700, 800);
          this.lblMessage.Text = "";
        }
      }
      catch
      {
      }
    }

    private void cmdFirst_Click(object sender, EventArgs e)
    {
      try
      {
        if (ClsRoomType.MoveFirst(this.db))
        {
          this.UpdateScreen();
        }
        else
        {
          this.lblMessage.Text = "No Record Found!";
          this.lblMessage.Refresh();
          Console.Beep(700, 800);
          this.lblMessage.Text = "";
        }
      }
      catch
      {
      }
    }

    private void cmdLast_Click(object sender, EventArgs e)
    {
      try
      {
        if (ClsRoomType.MoveLast1(this.db))
        {
          this.UpdateScreen();
        }
        else
        {
          this.lblMessage.Text = "No Record Found!";
          this.lblMessage.Refresh();
          Console.Beep(700, 800);
          this.lblMessage.Text = "";
        }
      }
      catch
      {
      }
    }

    private void Disable_RoomType_Edit()
    {
    }

    private void Enable_RoomType_Edit()
    {
    }

    private void UpdateObject()
    {
      ClsRoomType.RoomType = Convert.ToByte(this.txtRmType.Text);
      ClsRoomType.RmDescription = this.txtRmDescription.Text;
      ClsRoomType.MaxCard = Convert.ToByte(this.txtMaxCard.Text);
      ClsRoomType.MinCard = Convert.ToByte(this.txtMinCard.Text);
      ClsRoomType.StaffID = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID;
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      this.UpdateObject();
      if (ClsRoomType.FoundIt(this.db, Convert.ToByte(this.txtRmType.Text)))
      {
        if (DialogResult.Yes != MessageBox.Show("Room Type Already exists. Do you want to overwrite?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
          return;
        if (ClsRoomType.SaveIt(this.db, Convert.ToByte(this.txtRmType.Text)))
        {
          int num1 = (int) MessageBox.Show("Save Successfully");
        }
        else
        {
          int num2 = (int) MessageBox.Show("***Record Not Saved***");
        }
      }
      else if (ClsRoomType.SaveIt(this.db, Convert.ToByte(this.txtRmType.Text)))
      {
        int num3 = (int) MessageBox.Show("Save Successfully");
      }
      else
      {
        int num4 = (int) MessageBox.Show("***Record Not Saved***");
      }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      if (this.txtRmType.Text.Length <= 0)
        return;
      if (ClsRoomType.DeleteIt(this.db, Convert.ToByte(this.txtRmType.Text)))
      {
        int num = (int) MessageBox.Show("Delete Successfully!");
        this.ClearScreen();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Delete Failed!");
      }
    }

    private void txtRmType_KeyUp(object sender, KeyEventArgs e)
    {
      if (!(this.Old_RoomType != this.txtRmType.Text))
        return;
      this.ClearScreen2();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_RoomTypeDMS));
      this.ToolTip1 = new ToolTip(this.components);
      this.CmdPrint = new Button();
      this.txtMinCard = new TextBox();
      this.txtMaxCard = new TextBox();
      this.cmdPrevious = new Button();
      this.cmdFirst = new Button();
      this.cmdNext = new Button();
      this.cmdLast = new Button();
      this.cmdReturn = new Button();
      this.cmdDelete = new Button();
      this.cmdAdd = new Button();
      this.cmdNew = new Button();
      this.txtRmType = new TextBox();
      this.cmdRmTypeBrowse = new Button();
      this.txtRmDescription = new TextBox();
      this.Frame1 = new GroupBox();
      this.Label4 = new Label();
      this.Label3 = new Label();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.Label5 = new Label();
      this.lblMessage = new Label();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      this.CmdPrint.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      this.CmdPrint.Cursor = Cursors.Default;
      this.CmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CmdPrint.ForeColor = SystemColors.ControlText;
      this.CmdPrint.Image = (Image) componentResourceManager.GetObject("CmdPrint.Image");
      this.CmdPrint.Location = new Point(160, 272);
      this.CmdPrint.Name = "CmdPrint";
      this.CmdPrint.RightToLeft = RightToLeft.No;
      this.CmdPrint.Size = new Size(89, 41);
      this.CmdPrint.TabIndex = 18;
      this.CmdPrint.Text = "&PRINT";
      this.CmdPrint.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CmdPrint, "To Print Room Type Report");
      this.CmdPrint.UseVisualStyleBackColor = false;
      this.txtMinCard.AcceptsReturn = true;
      this.txtMinCard.BackColor = SystemColors.Window;
      this.txtMinCard.Cursor = Cursors.IBeam;
      this.txtMinCard.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMinCard.ForeColor = SystemColors.WindowText;
      this.txtMinCard.Location = new Point(232, 192);
      this.txtMinCard.MaxLength = 0;
      this.txtMinCard.Name = "txtMinCard";
      this.txtMinCard.RightToLeft = RightToLeft.No;
      this.txtMinCard.Size = new Size(41, 20);
      this.txtMinCard.TabIndex = 3;
      this.ToolTip1.SetToolTip((Control) this.txtMinCard, "Enter Min No. of Card Issued");
      this.txtMaxCard.AcceptsReturn = true;
      this.txtMaxCard.BackColor = SystemColors.Window;
      this.txtMaxCard.Cursor = Cursors.IBeam;
      this.txtMaxCard.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaxCard.ForeColor = SystemColors.WindowText;
      this.txtMaxCard.Location = new Point(232, 144);
      this.txtMaxCard.MaxLength = 0;
      this.txtMaxCard.Name = "txtMaxCard";
      this.txtMaxCard.RightToLeft = RightToLeft.No;
      this.txtMaxCard.Size = new Size(41, 20);
      this.txtMaxCard.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.txtMaxCard, "Enter Max No of Card Issued ");
      this.cmdPrevious.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdPrevious.Cursor = Cursors.Default;
      this.cmdPrevious.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdPrevious.ForeColor = SystemColors.ControlText;
      this.cmdPrevious.Location = new Point(128, 240);
      this.cmdPrevious.Name = "cmdPrevious";
      this.cmdPrevious.RightToLeft = RightToLeft.No;
      this.cmdPrevious.Size = new Size(33, 33);
      this.cmdPrevious.TabIndex = 8;
      this.cmdPrevious.Text = "<";
      this.ToolTip1.SetToolTip((Control) this.cmdPrevious, "To View Previous Record");
      this.cmdPrevious.UseVisualStyleBackColor = false;
      this.cmdPrevious.Click += new EventHandler(this.cmdPrevious_Click);
      this.cmdFirst.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdFirst.Cursor = Cursors.Default;
      this.cmdFirst.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdFirst.ForeColor = SystemColors.ControlText;
      this.cmdFirst.Location = new Point(96, 240);
      this.cmdFirst.Name = "cmdFirst";
      this.cmdFirst.RightToLeft = RightToLeft.No;
      this.cmdFirst.Size = new Size(33, 33);
      this.cmdFirst.TabIndex = 9;
      this.cmdFirst.Text = "<|";
      this.ToolTip1.SetToolTip((Control) this.cmdFirst, "To View First Record");
      this.cmdFirst.UseVisualStyleBackColor = false;
      this.cmdFirst.Click += new EventHandler(this.cmdFirst_Click);
      this.cmdNext.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdNext.Cursor = Cursors.Default;
      this.cmdNext.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNext.ForeColor = SystemColors.ControlText;
      this.cmdNext.Location = new Point(328, 240);
      this.cmdNext.Name = "cmdNext";
      this.cmdNext.RightToLeft = RightToLeft.No;
      this.cmdNext.Size = new Size(33, 33);
      this.cmdNext.TabIndex = 10;
      this.cmdNext.Text = ">";
      this.ToolTip1.SetToolTip((Control) this.cmdNext, "To View Next Record");
      this.cmdNext.UseVisualStyleBackColor = false;
      this.cmdNext.Click += new EventHandler(this.cmdNext_Click);
      this.cmdLast.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.cmdLast.Cursor = Cursors.Default;
      this.cmdLast.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdLast.ForeColor = SystemColors.ControlText;
      this.cmdLast.Location = new Point(360, 240);
      this.cmdLast.Name = "cmdLast";
      this.cmdLast.RightToLeft = RightToLeft.No;
      this.cmdLast.Size = new Size(33, 33);
      this.cmdLast.TabIndex = 11;
      this.cmdLast.Text = "|>";
      this.ToolTip1.SetToolTip((Control) this.cmdLast, "To View Last Record");
      this.cmdLast.UseVisualStyleBackColor = false;
      this.cmdLast.Click += new EventHandler(this.cmdLast_Click);
      this.cmdReturn.BackColor = Color.FromArgb(0, 192, 192);
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Image = (Image) componentResourceManager.GetObject("cmdReturn.Image");
      this.cmdReturn.Location = new Point(240, 272);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(89, 41);
      this.cmdReturn.TabIndex = 12;
      this.cmdReturn.Text = "RETUR&N";
      this.cmdReturn.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to System Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.cmdDelete.BackColor = Color.FromArgb(192, 192, 0);
      this.cmdDelete.Cursor = Cursors.Default;
      this.cmdDelete.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDelete.ForeColor = SystemColors.ControlText;
      this.cmdDelete.Location = new Point(272, 240);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.RightToLeft = RightToLeft.No;
      this.cmdDelete.Size = new Size(57, 33);
      this.cmdDelete.TabIndex = 7;
      this.cmdDelete.Text = "&DELETE";
      this.ToolTip1.SetToolTip((Control) this.cmdDelete, "To Delete Selected Room Type");
      this.cmdDelete.UseVisualStyleBackColor = false;
      this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
      this.cmdAdd.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.cmdAdd.Cursor = Cursors.Default;
      this.cmdAdd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdAdd.ForeColor = SystemColors.ControlText;
      this.cmdAdd.Location = new Point(216, 240);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.RightToLeft = RightToLeft.No;
      this.cmdAdd.Size = new Size(57, 33);
      this.cmdAdd.TabIndex = 4;
      this.cmdAdd.Text = "&SAVE";
      this.ToolTip1.SetToolTip((Control) this.cmdAdd, "To Save Current Room Type Setting");
      this.cmdAdd.UseVisualStyleBackColor = false;
      this.cmdAdd.Click += new EventHandler(this.cmdAdd_Click);
      this.cmdNew.BackColor = Color.FromArgb(0, 192, 0);
      this.cmdNew.Cursor = Cursors.Default;
      this.cmdNew.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdNew.ForeColor = SystemColors.ControlText;
      this.cmdNew.Location = new Point(160, 240);
      this.cmdNew.Name = "cmdNew";
      this.cmdNew.RightToLeft = RightToLeft.No;
      this.cmdNew.Size = new Size(57, 33);
      this.cmdNew.TabIndex = 5;
      this.cmdNew.Text = "NE&W";
      this.ToolTip1.SetToolTip((Control) this.cmdNew, "To Create New Room Type");
      this.cmdNew.UseVisualStyleBackColor = false;
      this.cmdNew.Click += new EventHandler(this.cmdNew_Click);
      this.txtRmType.AcceptsReturn = true;
      this.txtRmType.BackColor = SystemColors.Window;
      this.txtRmType.Cursor = Cursors.IBeam;
      this.txtRmType.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRmType.ForeColor = SystemColors.WindowText;
      this.txtRmType.Location = new Point(232, 48);
      this.txtRmType.MaxLength = 0;
      this.txtRmType.Name = "txtRmType";
      this.txtRmType.RightToLeft = RightToLeft.No;
      this.txtRmType.Size = new Size(41, 20);
      this.txtRmType.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.txtRmType, "Enter Room Type");
      this.txtRmType.KeyUp += new KeyEventHandler(this.txtRmType_KeyUp);
      this.txtRmType.KeyPress += new KeyPressEventHandler(this.txtRmType_KeyPress);
      this.cmdRmTypeBrowse.BackColor = Color.FromArgb((int) byte.MaxValue, 128, (int) byte.MaxValue);
      this.cmdRmTypeBrowse.Cursor = Cursors.Default;
      this.cmdRmTypeBrowse.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmdRmTypeBrowse.ForeColor = SystemColors.ControlText;
      this.cmdRmTypeBrowse.Image = (Image) componentResourceManager.GetObject("cmdRmTypeBrowse.Image");
      this.cmdRmTypeBrowse.Location = new Point(274, 48);
      this.cmdRmTypeBrowse.Name = "cmdRmTypeBrowse";
      this.cmdRmTypeBrowse.RightToLeft = RightToLeft.No;
      this.cmdRmTypeBrowse.Size = new Size(41, 26);
      this.cmdRmTypeBrowse.TabIndex = 6;
      this.cmdRmTypeBrowse.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.cmdRmTypeBrowse, "To View Room Type List");
      this.cmdRmTypeBrowse.UseVisualStyleBackColor = false;
      this.cmdRmTypeBrowse.Click += new EventHandler(this.cmdRmTypeBrowse_Click);
      this.txtRmDescription.AcceptsReturn = true;
      this.txtRmDescription.BackColor = SystemColors.Window;
      this.txtRmDescription.Cursor = Cursors.IBeam;
      this.txtRmDescription.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRmDescription.ForeColor = SystemColors.WindowText;
      this.txtRmDescription.Location = new Point(232, 96);
      this.txtRmDescription.MaxLength = 30;
      this.txtRmDescription.Name = "txtRmDescription";
      this.txtRmDescription.RightToLeft = RightToLeft.No;
      this.txtRmDescription.Size = new Size(225, 20);
      this.txtRmDescription.TabIndex = 1;
      this.ToolTip1.SetToolTip((Control) this.txtRmDescription, "Enter Room Type Description");
      this.Frame1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Frame1.Controls.Add((Control) this.CmdPrint);
      this.Frame1.Controls.Add((Control) this.txtMinCard);
      this.Frame1.Controls.Add((Control) this.txtMaxCard);
      this.Frame1.Controls.Add((Control) this.cmdPrevious);
      this.Frame1.Controls.Add((Control) this.cmdFirst);
      this.Frame1.Controls.Add((Control) this.cmdNext);
      this.Frame1.Controls.Add((Control) this.cmdLast);
      this.Frame1.Controls.Add((Control) this.cmdReturn);
      this.Frame1.Controls.Add((Control) this.cmdDelete);
      this.Frame1.Controls.Add((Control) this.cmdAdd);
      this.Frame1.Controls.Add((Control) this.cmdNew);
      this.Frame1.Controls.Add((Control) this.txtRmType);
      this.Frame1.Controls.Add((Control) this.cmdRmTypeBrowse);
      this.Frame1.Controls.Add((Control) this.txtRmDescription);
      this.Frame1.Controls.Add((Control) this.Label4);
      this.Frame1.Controls.Add((Control) this.Label3);
      this.Frame1.Controls.Add((Control) this.Label2);
      this.Frame1.Controls.Add((Control) this.Label1);
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, (int) byte.MaxValue);
      this.Frame1.Location = new Point(145, 121);
      this.Frame1.Name = "Frame1";
      this.Frame1.Padding = new Padding(0);
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(489, 329);
      this.Frame1.TabIndex = 20;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "ROOM TYPE SETTING : ";
      this.Label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label4.Cursor = Cursors.Default;
      this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ControlText;
      this.Label4.Location = new Point(40, 192);
      this.Label4.Name = "Label4";
      this.Label4.RightToLeft = RightToLeft.No;
      this.Label4.Size = new Size(161, 25);
      this.Label4.TabIndex = 17;
      this.Label4.Text = "Minimum Card Issued ";
      this.Label4.TextAlign = ContentAlignment.TopRight;
      this.Label3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ControlText;
      this.Label3.Location = new Point(24, 144);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(177, 25);
      this.Label3.TabIndex = 16;
      this.Label3.Text = "Maximum Card Issued ";
      this.Label3.TextAlign = ContentAlignment.TopRight;
      this.Label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label2.Cursor = Cursors.Default;
      this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.ControlText;
      this.Label2.Location = new Point(80, 96);
      this.Label2.Name = "Label2";
      this.Label2.RightToLeft = RightToLeft.No;
      this.Label2.Size = new Size(121, 25);
      this.Label2.TabIndex = 15;
      this.Label2.Text = "Room Description ";
      this.Label2.TextAlign = ContentAlignment.TopRight;
      this.Label1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.Label1.Cursor = Cursors.Default;
      this.Label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ControlText;
      this.Label1.Location = new Point(88, 48);
      this.Label1.Name = "Label1";
      this.Label1.RightToLeft = RightToLeft.No;
      this.Label1.Size = new Size(113, 25);
      this.Label1.TabIndex = 14;
      this.Label1.Text = "Room Type ";
      this.Label1.TextAlign = ContentAlignment.TopRight;
      this.Label5.BackColor = Color.FromArgb(128, (int) byte.MaxValue, (int) byte.MaxValue);
      this.Label5.Cursor = Cursors.Default;
      this.Label5.Font = new Font("Arial", 26.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Red;
      this.Label5.Location = new Point(1, 9);
      this.Label5.Name = "Label5";
      this.Label5.RightToLeft = RightToLeft.No;
      this.Label5.Size = new Size(785, 49);
      this.Label5.TabIndex = 21;
      this.Label5.Text = "Accommodation Management System";
      this.Label5.TextAlign = ContentAlignment.TopCenter;
      this.lblMessage.BackColor = SystemColors.Control;
      this.lblMessage.Cursor = Cursors.Default;
      this.lblMessage.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMessage.ForeColor = Color.Red;
      this.lblMessage.Location = new Point(237, 486);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = RightToLeft.No;
      this.lblMessage.Size = new Size(337, 41);
      this.lblMessage.TabIndex = 156;
      this.lblMessage.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(798, 582);
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Label5);
      this.Name = "Form_RoomTypeDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_RoomTypeDMS_Load);
      this.FormClosing += new FormClosingEventHandler(this.Form_RoomTypeDMS_FormClosing);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
