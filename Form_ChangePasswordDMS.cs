// Decompiled with JetBrains decompiler
// Type: AMS.Form_ChangePasswordDMS
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
  public class Form_ChangePasswordDMS : Form
  {
    private DB db;
    private IContainer components;
    public GroupBox Frame2;
    public TextBox txtOldPass;
    public ToolTip ToolTip1;
    public GroupBox Frame5;
    public TextBox txtUserID;
    public Panel Frame1;
    public Button cmdUpdate;
    public Button cmdReturn;
    public GroupBox Frame3;
    public TextBox txtNewPass1;
    public GroupBox Frame4;
    public TextBox txtNewPass2;
    public Label Label3;
    public Label datpassword;
    public Label Label_ModeName;

    public Form_ChangePasswordDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void Form_ChangePasswordDMS_Load(object sender, EventArgs e)
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
        this.Label_ModeName.Text = "Admin Mode";
      else
        this.Label_ModeName.Text = "Operation Mode";
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      if (!ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
        ModDoorLockSystem.Form_OperationDMS_Ptr.Visible = true;
      else
        ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_ChangePasswordDMS_Activated(object sender, EventArgs e)
    {
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
        this.Label_ModeName.Text = "Admin Mode";
      else
        this.Label_ModeName.Text = "Operation Mode";
    }

    private void Form_ChangePasswordDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    public bool Check_User_ID_and_Password_Correct(string sUserID, string sPassword)
    {
      bool flag1 = false;
      bool flag2 = false;
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
      if (flag1 && flag2)
      {
        this.txtNewPass1.Focus();
        return true;
      }
      this.cmdUpdate.Enabled = false;
      return false;
    }

    private void Check_NewPasswords_Enabled()
    {
      if (this.txtUserID.Text.Length > 0 && this.txtOldPass.Text.Length == 4)
      {
        if (this.Check_User_ID_and_Password_Correct(this.txtUserID.Text, this.txtOldPass.Text + "0000"))
        {
          this.txtNewPass1.Enabled = true;
          this.txtNewPass2.Enabled = true;
          this.txtNewPass1.Focus();
          this.txtNewPass1.Text = "";
          this.txtNewPass2.Text = "";
        }
        else
        {
          this.txtNewPass1.Enabled = false;
          this.txtNewPass2.Enabled = false;
          this.cmdUpdate.Enabled = false;
        }
      }
      else
      {
        this.txtNewPass1.Enabled = false;
        this.txtNewPass2.Enabled = false;
        this.cmdUpdate.Enabled = false;
      }
    }

    private bool Check_New_Passwords_Same()
    {
      if (this.txtNewPass1.Text.Length == 4 && this.txtNewPass2.Text.Length == 4 && this.txtNewPass1.Text == this.txtNewPass2.Text)
      {
        this.cmdUpdate.Enabled = true;
        return true;
      }
      this.cmdUpdate.Enabled = false;
      return false;
    }

    private void Load_Staff_Data()
    {
      this.db.staff_DB.staffDataSet.Staff.Clear();
      this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
    }

    private void Clear_Password_Setup_Contents()
    {
      this.txtUserID.Text = "";
      this.txtOldPass.Text = "";
      this.txtNewPass1.Text = "";
      this.txtNewPass2.Text = "";
      this.cmdUpdate.Enabled = false;
      this.Check_NewPasswords_Enabled();
      this.txtUserID.Focus();
      this.txtUserID.Select();
      this.txtUserID.Update();
    }

    private void Form_ChangePasswordDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Clear_Password_Setup_Contents();
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.bAdmin)
        this.Label_ModeName.Text = "ADMIN MODE";
      else
        this.Label_ModeName.Text = "OPERATION MODE";
    }

    private void txtUserID_TextChanged(object sender, EventArgs e)
    {
      if (this.txtUserID.Text.Length <= 0 || this.txtOldPass.Text.Length <= 0)
        return;
      this.Check_NewPasswords_Enabled();
    }

    private void txtOldPass_TextChanged(object sender, EventArgs e)
    {
      if (this.txtUserID.Text.Length <= 0 || this.txtOldPass.Text.Length <= 0)
        return;
      this.Check_NewPasswords_Enabled();
    }

    private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r' || this.txtUserID.Text.Length <= 0)
        return;
      this.txtOldPass.Focus();
    }

    private void txtNewPass1_TextChanged(object sender, EventArgs e)
    {
      if (this.txtNewPass1.Text.Length <= 0 || this.txtNewPass2.Text.Length <= 0)
        return;
      this.Check_New_Passwords_Same();
    }

    private void txtNewPass2_TextChanged(object sender, EventArgs e)
    {
      if (this.txtNewPass1.Text.Length <= 0 || this.txtNewPass2.Text.Length <= 0)
        return;
      this.Check_New_Passwords_Same();
    }

    private void txtNewPass1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r' || this.txtNewPass1.Text.Length <= 0)
        return;
      this.txtNewPass2.Focus();
    }

    private void txtNewPass2_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r' || !this.Check_New_Passwords_Same())
        return;
      this.cmdUpdate.Focus();
    }

    private bool Check_N_Update_Password(string sUserID, string sPassword)
    {
      bool flag = false;
      byte[] source = this.db.PASSWORDENCRYPT(sPassword);
      int cb = Marshal.SizeOf((object) source[0]) * source.Length;
      IntPtr num1 = Marshal.AllocHGlobal(cb);
      Marshal.AllocHGlobal(cb);
      Marshal.Copy(source, 0, num1, source.Length);
      string stringAnsi = Marshal.PtrToStringAnsi(num1, source.Length);
      this.db.staff_DB.staffDataSet.Clear();
      this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
      foreach (StaffDataSet.StaffRow row in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        if (sUserID == row.StaffID)
        {
          row.Password = stringAnsi;
          flag = true;
          break;
        }
      }
      if (flag)
      {
        if (this.db.staff_DB.staffTableAdapter.Update(this.db.staff_DB.staffDataSet) > 0)
        {
          int num2 = (int) MessageBox.Show("New Password Successfully Changed!");
          return true;
        }
        int num3 = (int) MessageBox.Show("New Password Update Failed!");
      }
      else
      {
        int num4 = (int) MessageBox.Show("Sorry! User ID Not Matched  ");
      }
      return false;
    }

    private void cmdUpdate_Click(object sender, EventArgs e)
    {
      if (this.Check_New_Passwords_Same())
      {
        if (this.Check_User_ID_and_Password_Correct(this.txtUserID.Text, this.txtOldPass.Text + "0000"))
        {
          if (this.Check_N_Update_Password(this.txtUserID.Text, this.txtNewPass1.Text + "0000"))
          {
            this.Clear_Password_Setup_Contents();
            this.cmdReturn.Focus();
          }
          else
            this.Clear_Password_Setup_Contents();
        }
        else
        {
          int num = (int) MessageBox.Show("Invalid Password   ");
          this.Clear_Password_Setup_Contents();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("New Password not Match    ");
        this.Clear_Password_Setup_Contents();
      }
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
      this.Frame2 = new GroupBox();
      this.txtOldPass = new TextBox();
      this.Frame5 = new GroupBox();
      this.txtUserID = new TextBox();
      this.Frame1 = new Panel();
      this.cmdUpdate = new Button();
      this.cmdReturn = new Button();
      this.Frame3 = new GroupBox();
      this.txtNewPass1 = new TextBox();
      this.Frame4 = new GroupBox();
      this.txtNewPass2 = new TextBox();
      this.Label3 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.datpassword = new Label();
      this.Label_ModeName = new Label();
      this.Frame2.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      this.Frame2.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame2.Controls.Add((Control) this.txtOldPass);
      this.Frame2.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame2.ForeColor = Color.Blue;
      this.Frame2.Location = new Point(38, 96);
      this.Frame2.Name = "Frame2";
      this.Frame2.Padding = new Padding(0);
      this.Frame2.RightToLeft = RightToLeft.No;
      this.Frame2.Size = new Size(251, 65);
      this.Frame2.TabIndex = 8;
      this.Frame2.TabStop = false;
      this.Frame2.Text = "Enter Old Password";
      this.txtOldPass.AcceptsReturn = true;
      this.txtOldPass.BackColor = SystemColors.Window;
      this.txtOldPass.Cursor = Cursors.IBeam;
      this.txtOldPass.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtOldPass.ForeColor = SystemColors.WindowText;
      this.txtOldPass.ImeMode = ImeMode.Disable;
      this.txtOldPass.Location = new Point(48, 25);
      this.txtOldPass.MaxLength = 4;
      this.txtOldPass.Name = "txtOldPass";
      this.txtOldPass.PasswordChar = '*';
      this.txtOldPass.RightToLeft = RightToLeft.No;
      this.txtOldPass.Size = new Size(161, 28);
      this.txtOldPass.TabIndex = 1;
      this.txtOldPass.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtOldPass, "To Enter Old Password");
      this.txtOldPass.TextChanged += new EventHandler(this.txtOldPass_TextChanged);
      this.Frame5.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame5.Controls.Add((Control) this.txtUserID);
      this.Frame5.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame5.ForeColor = Color.Blue;
      this.Frame5.Location = new Point(38, 24);
      this.Frame5.Name = "Frame5";
      this.Frame5.Padding = new Padding(0);
      this.Frame5.RightToLeft = RightToLeft.No;
      this.Frame5.Size = new Size(251, 65);
      this.Frame5.TabIndex = 7;
      this.Frame5.TabStop = false;
      this.Frame5.Text = "Enter User ID";
      this.txtUserID.AcceptsReturn = true;
      this.txtUserID.BackColor = SystemColors.Window;
      this.txtUserID.Cursor = Cursors.IBeam;
      this.txtUserID.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtUserID.ForeColor = SystemColors.WindowText;
      this.txtUserID.Location = new Point(48, 25);
      this.txtUserID.MaxLength = 10;
      this.txtUserID.Name = "txtUserID";
      this.txtUserID.RightToLeft = RightToLeft.No;
      this.txtUserID.Size = new Size(161, 28);
      this.txtUserID.TabIndex = 0;
      this.txtUserID.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtUserID, "To Enter User ID");
      this.txtUserID.TextChanged += new EventHandler(this.txtUserID_TextChanged);
      this.txtUserID.KeyPress += new KeyPressEventHandler(this.txtUserID_KeyPress);
      this.Frame1.BackColor = Color.Cyan;
      this.Frame1.Controls.Add((Control) this.cmdUpdate);
      this.Frame1.Controls.Add((Control) this.cmdReturn);
      this.Frame1.Controls.Add((Control) this.Frame3);
      this.Frame1.Controls.Add((Control) this.Frame4);
      this.Frame1.Controls.Add((Control) this.Frame2);
      this.Frame1.Controls.Add((Control) this.Frame5);
      this.Frame1.Cursor = Cursors.Default;
      this.Frame1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame1.ForeColor = SystemColors.ControlText;
      this.Frame1.Location = new Point(231, 121);
      this.Frame1.Name = "Frame1";
      this.Frame1.RightToLeft = RightToLeft.No;
      this.Frame1.Size = new Size(322, 390);
      this.Frame1.TabIndex = 13;
      this.cmdUpdate.BackColor = SystemColors.Control;
      this.cmdUpdate.Cursor = Cursors.Default;
      this.cmdUpdate.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdUpdate.ForeColor = SystemColors.ControlText;
      this.cmdUpdate.Location = new Point(21, 320);
      this.cmdUpdate.Name = "cmdUpdate";
      this.cmdUpdate.RightToLeft = RightToLeft.No;
      this.cmdUpdate.Size = new Size(131, 52);
      this.cmdUpdate.TabIndex = 4;
      this.cmdUpdate.Text = "&UPDATE";
      this.ToolTip1.SetToolTip((Control) this.cmdUpdate, "Confirm Update Passward Change");
      this.cmdUpdate.UseVisualStyleBackColor = false;
      this.cmdUpdate.Click += new EventHandler(this.cmdUpdate_Click);
      this.cmdReturn.BackColor = SystemColors.Control;
      this.cmdReturn.Cursor = Cursors.Default;
      this.cmdReturn.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdReturn.ForeColor = SystemColors.ControlText;
      this.cmdReturn.Location = new Point(168, 320);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.RightToLeft = RightToLeft.No;
      this.cmdReturn.Size = new Size(131, 52);
      this.cmdReturn.TabIndex = 5;
      this.cmdReturn.Text = "RETUR&N";
      this.ToolTip1.SetToolTip((Control) this.cmdReturn, "Return to Main Screen");
      this.cmdReturn.UseVisualStyleBackColor = false;
      this.cmdReturn.Click += new EventHandler(this.cmdReturn_Click);
      this.Frame3.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame3.Controls.Add((Control) this.txtNewPass1);
      this.Frame3.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame3.ForeColor = Color.Blue;
      this.Frame3.Location = new Point(38, 168);
      this.Frame3.Name = "Frame3";
      this.Frame3.Padding = new Padding(0);
      this.Frame3.RightToLeft = RightToLeft.No;
      this.Frame3.Size = new Size(251, 65);
      this.Frame3.TabIndex = 10;
      this.Frame3.TabStop = false;
      this.Frame3.Text = "Enter New Password";
      this.txtNewPass1.AcceptsReturn = true;
      this.txtNewPass1.BackColor = SystemColors.Window;
      this.txtNewPass1.Cursor = Cursors.IBeam;
      this.txtNewPass1.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNewPass1.ForeColor = SystemColors.WindowText;
      this.txtNewPass1.ImeMode = ImeMode.Disable;
      this.txtNewPass1.Location = new Point(48, 24);
      this.txtNewPass1.MaxLength = 4;
      this.txtNewPass1.Name = "txtNewPass1";
      this.txtNewPass1.PasswordChar = '*';
      this.txtNewPass1.RightToLeft = RightToLeft.No;
      this.txtNewPass1.Size = new Size(161, 28);
      this.txtNewPass1.TabIndex = 2;
      this.txtNewPass1.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtNewPass1, "To Enter New Password");
      this.txtNewPass1.TextChanged += new EventHandler(this.txtNewPass1_TextChanged);
      this.txtNewPass1.KeyPress += new KeyPressEventHandler(this.txtNewPass1_KeyPress);
      this.Frame4.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.Frame4.Controls.Add((Control) this.txtNewPass2);
      this.Frame4.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Frame4.ForeColor = Color.Blue;
      this.Frame4.Location = new Point(38, 240);
      this.Frame4.Name = "Frame4";
      this.Frame4.Padding = new Padding(0);
      this.Frame4.RightToLeft = RightToLeft.No;
      this.Frame4.Size = new Size(251, 65);
      this.Frame4.TabIndex = 9;
      this.Frame4.TabStop = false;
      this.Frame4.Text = "Re-Enter New Password";
      this.txtNewPass2.AcceptsReturn = true;
      this.txtNewPass2.BackColor = SystemColors.Window;
      this.txtNewPass2.Cursor = Cursors.IBeam;
      this.txtNewPass2.Font = new Font("Arial", 13.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNewPass2.ForeColor = SystemColors.WindowText;
      this.txtNewPass2.ImeMode = ImeMode.Disable;
      this.txtNewPass2.Location = new Point(48, 24);
      this.txtNewPass2.MaxLength = 4;
      this.txtNewPass2.Name = "txtNewPass2";
      this.txtNewPass2.PasswordChar = '*';
      this.txtNewPass2.RightToLeft = RightToLeft.No;
      this.txtNewPass2.Size = new Size(161, 28);
      this.txtNewPass2.TabIndex = 3;
      this.txtNewPass2.TextAlign = HorizontalAlignment.Center;
      this.ToolTip1.SetToolTip((Control) this.txtNewPass2, "To Re-Enter New Password");
      this.txtNewPass2.TextChanged += new EventHandler(this.txtNewPass2_TextChanged);
      this.txtNewPass2.KeyPress += new KeyPressEventHandler(this.txtNewPass2_KeyPress);
      this.Label3.BackColor = SystemColors.Control;
      this.Label3.Cursor = Cursors.Default;
      this.Label3.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Red;
      this.Label3.Location = new Point(-2, 65);
      this.Label3.Name = "Label3";
      this.Label3.RightToLeft = RightToLeft.No;
      this.Label3.Size = new Size(785, 33);
      this.Label3.TabIndex = 16;
      this.Label3.Text = "CHANGE PASSWORD";
      this.Label3.TextAlign = ContentAlignment.TopCenter;
      this.datpassword.BackColor = Color.Red;
      this.datpassword.BorderStyle = BorderStyle.FixedSingle;
      this.datpassword.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datpassword.ForeColor = Color.Black;
      this.datpassword.Location = new Point(54, 331);
      this.datpassword.Name = "datpassword";
      this.datpassword.Size = new Size(103, 23);
      this.datpassword.TabIndex = 14;
      this.datpassword.Text = "datpassword";
      this.datpassword.Visible = false;
      this.Label_ModeName.BackColor = SystemColors.Control;
      this.Label_ModeName.Cursor = Cursors.Default;
      this.Label_ModeName.Font = new Font("Arial", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label_ModeName.ForeColor = Color.Blue;
      this.Label_ModeName.Location = new Point(-2, 9);
      this.Label_ModeName.Name = "Label_ModeName";
      this.Label_ModeName.RightToLeft = RightToLeft.No;
      this.Label_ModeName.Size = new Size(785, 41);
      this.Label_ModeName.TabIndex = 15;
      this.Label_ModeName.Text = "Operation Mode ";
      this.Label_ModeName.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(795, 573);
      this.Controls.Add((Control) this.Frame1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.datpassword);
      this.Controls.Add((Control) this.Label_ModeName);
      this.Name = "Form_ChangePasswordDMS";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ACCOMMODATION MANAGEMENT SYSTEM";
      this.Load += new EventHandler(this.Form_ChangePasswordDMS_Load);
      this.Activated += new EventHandler(this.Form_ChangePasswordDMS_Activated);
      this.VisibleChanged += new EventHandler(this.Form_ChangePasswordDMS_VisibleChanged);
      this.FormClosing += new FormClosingEventHandler(this.Form_ChangePasswordDMS_FormClosing);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame5.ResumeLayout(false);
      this.Frame5.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
