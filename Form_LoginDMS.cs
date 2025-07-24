// Decompiled with JetBrains decompiler
// Type: AMS.Form_LoginDMS
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form_LoginDMS : Form
  {
    private DB db;
    private IContainer components;
    public Label datPassword;
    public Label labPassword;
    public Label Label4;
    public Panel Frame3;
    public TextBox txtUserID;
    public ToolTip ToolTip1;
    public TextBox txtPassword;
    public Button cmdLogin;
    public Button cmdCancel;
    public Label Label_BuildigName;
    public Label Label_Description;
    public Label lblLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox_Users;

    public Form_LoginDMS()
    {
      this.db = new DB();
      this.InitializeComponent();
            AMS.CardCheck.CreateLogEntriesTable();
    }

    private void Init_Staff_Data()
    {
      bool flag = false;
      this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
      this.comboBox_Users.Items.Clear();
      foreach (StaffDataSet.StaffRow row in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        this.comboBox_Users.Items.Add((object) row.StaffID);
        flag = true;
      }
      if (flag && this.comboBox_Users.Items.Count > 0)
        this.comboBox_Users.SelectedIndex = 1;
      this.txtUserID.Text = "";
      this.txtPassword.Text = "";
      this.txtUserID.Focus();
      this.txtUserID.Select();
    }

    private void Form_LoginDMS_Load(object sender, EventArgs e) => this.Init_Staff_Data();

    public bool Check_User_ID_and_Password_Correct(string sUserID, string sPassword)
    {
      bool flag1 = false;
      bool flag2 = false;
      sUserID = this.txtUserID.Text;
      sPassword = this.txtPassword.Text + "0000";
      byte[] source = this.db.PASSWORDENCRYPT(sPassword);
      int cb = Marshal.SizeOf((object) source[0]) * source.Length;
      IntPtr num = Marshal.AllocHGlobal(cb);
      Marshal.AllocHGlobal(cb);
      Marshal.Copy(source, 0, num, source.Length);
      string stringAnsi = Marshal.PtrToStringAnsi(num, source.Length);
      foreach (StaffDataSet.StaffRow row in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        if (sUserID == row.StaffID)
        {
          if (row.Password == stringAnsi)
            flag2 = true;
          flag1 = true;
          if (!flag2)
            break;
          break;
        }
      }
      return flag1 && flag2;
    }

    private void cmdLogin_Click(object sender, EventArgs e)
    {
      bool flag1 = false;
      bool flag2 = false;
      string text = this.txtUserID.Text;
      byte[] source = this.db.PASSWORDENCRYPT(this.txtPassword.Text + "0000");
      int cb = Marshal.SizeOf((object) source[0]) * source.Length;
      IntPtr num1 = Marshal.AllocHGlobal(cb);
      Marshal.AllocHGlobal(cb);
      Marshal.Copy(source, 0, num1, source.Length);
      string stringAnsi = Marshal.PtrToStringAnsi(num1, source.Length);
      ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdminOnly = false;
      foreach (StaffDataSet.StaffRow row in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        if (text == row.StaffID)
        {
          if (row.Password == stringAnsi)
            flag2 = true;
          flag1 = true;
          if (flag2)
          {
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel = row.AccLevel;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gFORENAME = row.SForeName;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gSURNAME = row.SSurName;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gUSERID = row.StaffID;
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gPASSWORD = "NA";
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL = ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel;
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
            {
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 = "1";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding = "0";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB1 = "1";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 = "2";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB2 = "2";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 = "3";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB3 = "3";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 = "4";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB4 = "4";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 = "5";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB5 = "5";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 = "6";
              ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB6 = "6";
            }
            else
            {
              if (row.AccBuilding1)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 = "1";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding = "0";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB1 = "1";
              }
              else
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 = "";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding = "";
              }
              if (row.AccBuilding2)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 = "2";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB2 = "2";
              }
              else
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 = "";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB2 = "";
              }
              if (row.AccBuilding3)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 = "3";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB3 = "3";
              }
              else
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 = "";
              if (row.AccBuilding4)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 = "4";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB4 = "4";
              }
              else
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 = "";
              if (row.AccBuilding5)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 = "5";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB5 = "5";
              }
              else
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 = "";
              if (row.AccBuilding6)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 = "6";
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.sActiveDB6 = "6";
              }
              else
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 = "";
            }
            Global_Data.gInTime = DateTime.Now.ToString("HH:mm:ss");
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bTYPE = false;
            if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
            {
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
              {
                this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
                ModDoorLockSystem.Form_MainDMS_Ptr.Show();
                this.Visible = false;
                break;
              }
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1" || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "2")
              {
                if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
                {
                  this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
                  ModDoorLockSystem.Form_MainDMS_Ptr.Show();
                  this.Visible = false;
                  break;
                }
                int num2 = (int) MessageBox.Show("Don't Allow To Access This Building!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUserID.Focus();
                break;
              }
              int num3 = (int) MessageBox.Show(" UnAuthroized User..", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.txtUserID.Focus();
              break;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bSystemMode)
            {
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
              {
                this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
                ModDoorLockSystem.Form_MainDMS_Ptr.Show();
                this.Visible = false;
                break;
              }
              int num4 = (int) MessageBox.Show(" UnAuthroized User..", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.txtUserID.Focus();
              break;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
            {
              this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
              ModDoorLockSystem.Form_MainDMS_Ptr.Show();
              this.Visible = false;
              break;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1")
            {
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
              {
                this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
                ModDoorLockSystem.Form_MainDMS_Ptr.Show();
                this.Visible = false;
                break;
              }
              int num5 = (int) MessageBox.Show("Don't Allow To Access This Building!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.txtUserID.Focus();
              break;
            }
            if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "3")
            {
              if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 || ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo == ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6)
              {
                ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdminOnly = true;
                this.db.UPDATE_LOGIN(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccessBuildingNo);
                ModDoorLockSystem.Form_MainDMS_Ptr.Show();
                this.Visible = false;
                break;
              }
              int num6 = (int) MessageBox.Show("Don't Allow To Access This Building!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.txtUserID.Focus();
              break;
            }
            int num7 = (int) MessageBox.Show(" UnAuthroized User..", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.txtUserID.Focus();
            break;
          }
          break;
        }
      }
      if (flag1 && !flag2)
      {
        int num8 = (int) MessageBox.Show("Invalid Password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtUserID.Focus();
      }
      else if (!flag1)
      {
        int num9 = (int) MessageBox.Show("User ID not Found!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtUserID.Focus();
      }
      this.txtUserID.Clear();
      this.txtPassword.Clear();
    }

    private void txtUserID_TextChanged(object sender, EventArgs e)
    {
      if (this.txtPassword.Text.Length != 4 || this.txtUserID.Text.Length == 0)
        this.cmdLogin.Enabled = false;
      else
        this.cmdLogin.Enabled = true;
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
      if (this.txtPassword.Text.Length != 4 || this.txtUserID.Text.Length == 0)
        this.cmdLogin.Enabled = false;
      else
        this.cmdLogin.Enabled = true;
    }

    private void Form_LoginDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Init_Staff_Data();
      if (this.txtPassword.Text.Length == 4 && this.txtUserID.Text.Length != 0)
        return;
      this.cmdLogin.Enabled = false;
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      //this.Owner.Visible = true;
      this.Visible = false;
    }

    private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtPassword.Focus();
    }

    private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.cmdLogin.Focus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.datPassword = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Frame3 = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.comboBox_Users = new System.Windows.Forms.ComboBox();
            this.Label_BuildigName = new System.Windows.Forms.Label();
            this.Label_Description = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Frame3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datPassword
            // 
            this.datPassword.BackColor = System.Drawing.Color.Red;
            this.datPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datPassword.ForeColor = System.Drawing.Color.Black;
            this.datPassword.Location = new System.Drawing.Point(31, 219);
            this.datPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datPassword.Name = "datPassword";
            this.datPassword.Size = new System.Drawing.Size(61, 21);
            this.datPassword.TabIndex = 10;
            this.datPassword.Text = "datPassword";
            this.datPassword.Visible = false;
            // 
            // labPassword
            // 
            this.labPassword.BackColor = System.Drawing.Color.PowderBlue;
            this.labPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.labPassword.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labPassword.Location = new System.Drawing.Point(5, 64);
            this.labPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labPassword.Size = new System.Drawing.Size(171, 30);
            this.labPassword.TabIndex = 6;
            this.labPassword.Text = "PASSWORD";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.PowderBlue;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label4.Location = new System.Drawing.Point(32, 20);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(125, 27);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "USER ID";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.Color.PowderBlue;
            this.Frame3.Controls.Add(this.txtUserID);
            this.Frame3.Controls.Add(this.txtPassword);
            this.Frame3.Controls.Add(this.cmdLogin);
            this.Frame3.Controls.Add(this.cmdCancel);
            this.Frame3.Controls.Add(this.labPassword);
            this.Frame3.Controls.Add(this.Label4);
            this.Frame3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Frame3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame3.ForeColor = System.Drawing.Color.Red;
            this.Frame3.Location = new System.Drawing.Point(136, 158);
            this.Frame3.Margin = new System.Windows.Forms.Padding(2);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(328, 185);
            this.Frame3.TabIndex = 11;
            // 
            // txtUserID
            // 
            this.txtUserID.AcceptsReturn = true;
            this.txtUserID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Red;
            this.txtUserID.Location = new System.Drawing.Point(180, 16);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.MaxLength = 10;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.Size = new System.Drawing.Size(133, 35);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtUserID, "Enter User ID");
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(180, 61);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(133, 35);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtPassword, "Enter Password");
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLogin.Location = new System.Drawing.Point(24, 125);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLogin.Size = new System.Drawing.Size(120, 46);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "LOGIN";
            this.ToolTip1.SetToolTip(this.cmdLogin, "To Confirm LogIn");
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancel.Location = new System.Drawing.Point(193, 125);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(120, 46);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "CANCEL";
            this.ToolTip1.SetToolTip(this.cmdCancel, "Confirm Login Cancel");
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // comboBox_Users
            // 
            this.comboBox_Users.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Users.FormattingEnabled = true;
            this.comboBox_Users.Location = new System.Drawing.Point(8, 91);
            this.comboBox_Users.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Users.Name = "comboBox_Users";
            this.comboBox_Users.Size = new System.Drawing.Size(129, 35);
            this.comboBox_Users.TabIndex = 7;
            this.comboBox_Users.Visible = false;
            // 
            // Label_BuildigName
            // 
            this.Label_BuildigName.BackColor = System.Drawing.Color.White;
            this.Label_BuildigName.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_BuildigName.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BuildigName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Label_BuildigName.Location = new System.Drawing.Point(25, 20);
            this.Label_BuildigName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_BuildigName.Name = "Label_BuildigName";
            this.Label_BuildigName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_BuildigName.Size = new System.Drawing.Size(583, 27);
            this.Label_BuildigName.TabIndex = 14;
            this.Label_BuildigName.Text = "Hawthorn";
            this.Label_BuildigName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_BuildigName.Visible = false;
            // 
            // Label_Description
            // 
            this.Label_Description.BackColor = System.Drawing.Color.White;
            this.Label_Description.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Description.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label_Description.Location = new System.Drawing.Point(11, 56);
            this.Label_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Description.Size = new System.Drawing.Size(583, 33);
            this.Label_Description.TabIndex = 13;
            this.Label_Description.Text = "AMS 2.0";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLogin.Location = new System.Drawing.Point(139, 91);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogin.Size = new System.Drawing.Size(325, 40);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(255, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Designed by TV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 424);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Coded by AV";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form_LoginDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 466);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_Users);
            this.Controls.Add(this.datPassword);
            this.Controls.Add(this.Frame3);
            this.Controls.Add(this.Label_BuildigName);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_LoginDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOMMODATION MANAGEMENT SYSTEM ";
            this.Load += new System.EventHandler(this.Form_LoginDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_LoginDMS_VisibleChanged);
            this.Frame3.ResumeLayout(false);
            this.Frame3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
