// Decompiled with JetBrains decompiler
// Type: AMS.Form_StaffDMS
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
  public class Form_StaffDMS : Form
  {
    private int selected_rowindex;
    private DB db = new DB();
    private int Combo1_Old_Index;
    private bool Combo1_Click_flag;
    private bool Add_New_Flag;
    private bool Edit_Enable_Flag;
    private IContainer components;
    public GroupBox Frame3;
    public Button cmdDelete;
    public ToolTip ToolTip1;
    public Button cmdAdd;
    public Button cmdPrint;
    public Button cmdUpdate;
    public Button cmdCancel;
    public Button cmdReturn;
    public Label Label10;
    public Label Label5;
    public Label Label7;
    public CheckBox _chkBuilding_5;
    public CheckBox _chkBuilding_4;
    public Label Label11;
    public CheckBox _chkBuilding_3;
    public TextBox txtIdentity;
    public TextBox txtSurName;
    public TextBox txtFirstName;
    public TextBox txtUserID;
    public ComboBox Combo1;
    public TextBox txtPassword;
    public CheckBox _chkBuilding_2;
    public Label Label2;
    public Label datPassword;
    public Label Label6;
    public Label Label3;
    public Label Label9;
    public Label Label4;
    public Label Label1;
    public Panel frame;
    public CheckBox _chkBuilding_0;
    public CheckBox _chkBuilding_1;
    public Panel BuildingFrame;
    private DataGridViewCheckBoxColumn accBuilding1DataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn accBuilding2DataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn accBuilding3DataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn accBuilding4DataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn accBuilding5DataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn accBuilding6DataGridViewCheckBoxColumn;
    private DataGridView dataGridView1;
    private StaffDataSet staffDataSet;
    private DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn accLevelDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
    private DataGridViewTextBoxColumn sForeNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sSurNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn identityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn updateDataGridViewCheckBoxColumn;
    private BindingSource staffBindingSource;

    public Form_StaffDMS()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void cmdReturn_Click(object sender, EventArgs e)
    {
      this.Visible = false;
      ModDoorLockSystem.Form_AdminDMS_Ptr.Visible = true;
    }

    private void Form_StaffDMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void StaffIDChecking()
    {
    }

    private void AllowBuildingChecking()
    {
      this.StaffIDChecking();
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding1 != "")
        {
          this._chkBuilding_0.Enabled = true;
          this._chkBuilding_0.Checked = false;
        }
        else
        {
          this._chkBuilding_0.Enabled = false;
          this._chkBuilding_0.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_0.Enabled = false;
        this._chkBuilding_0.Checked = false;
      }
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding2 != "")
        {
          this._chkBuilding_1.Enabled = true;
          this._chkBuilding_1.Checked = false;
        }
        else
        {
          this._chkBuilding_1.Enabled = false;
          this._chkBuilding_1.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_1.Enabled = false;
        this._chkBuilding_1.Checked = false;
      }
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding3 != "")
        {
          this._chkBuilding_2.Enabled = true;
          this._chkBuilding_2.Checked = false;
        }
        else
        {
          this._chkBuilding_2.Enabled = false;
          this._chkBuilding_2.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_2.Enabled = false;
        this._chkBuilding_2.Checked = false;
      }
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding4 != "")
        {
          this._chkBuilding_3.Enabled = true;
          this._chkBuilding_3.Checked = false;
        }
        else
        {
          this._chkBuilding_3.Enabled = false;
          this._chkBuilding_3.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_3.Enabled = false;
        this._chkBuilding_3.Checked = false;
      }
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding5 != "")
        {
          this._chkBuilding_4.Enabled = true;
          this._chkBuilding_4.Checked = false;
        }
        else
        {
          this._chkBuilding_4.Enabled = false;
          this._chkBuilding_4.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_4.Enabled = false;
        this._chkBuilding_4.Checked = false;
      }
      try
      {
        if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gAccBuilding6 != "")
        {
          this._chkBuilding_5.Enabled = true;
          this._chkBuilding_5.Checked = false;
        }
        else
        {
          this._chkBuilding_5.Enabled = false;
          this._chkBuilding_5.Checked = false;
        }
      }
      catch
      {
        this._chkBuilding_5.Enabled = false;
        this._chkBuilding_5.Checked = false;
      }
    }

    private void Set_Defaults()
    {
      this.cmdAdd.Enabled = true;
      this.cmdCancel.Enabled = false;
      this.cmdDelete.Enabled = true;
      this.cmdPrint.Enabled = true;
      this.cmdReturn.Enabled = true;
      this.cmdUpdate.Enabled = false;
      this.BuildingFrame.Enabled = false;
      this.txtUserID.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.txtIdentity.Text = "";
      this.txtPassword.Text = "";
      this.Combo1.SelectedIndex = 3;
      this.txtUserID.Enabled = false;
      this.txtFirstName.Enabled = false;
      this.txtSurName.Enabled = false;
      this.txtIdentity.Enabled = false;
      this.txtPassword.Enabled = false;
      this.Combo1.SelectedIndex = 3;
      this.Combo1.Enabled = false;
      this.dataGridView1.Enabled = true;
      this._chkBuilding_0.Checked = false;
      this._chkBuilding_1.Checked = false;
      this._chkBuilding_2.Checked = false;
      this._chkBuilding_3.Checked = false;
      this._chkBuilding_4.Checked = false;
      this._chkBuilding_5.Checked = false;
      this.BuildingFrame.Enabled = false;
    }

    private void Init_Add_Controls()
    {
      this.cmdAdd.Enabled = false;
      this.cmdCancel.Enabled = true;
      this.cmdDelete.Enabled = false;
      this.cmdPrint.Enabled = false;
      this.cmdReturn.Enabled = true;
      this.cmdUpdate.Enabled = false;
      this._chkBuilding_0.Checked = false;
      this._chkBuilding_1.Checked = false;
      this._chkBuilding_2.Checked = false;
      this._chkBuilding_3.Checked = false;
      this._chkBuilding_4.Checked = false;
      this._chkBuilding_5.Checked = false;
      this.BuildingFrame.Enabled = true;
      this.txtUserID.Enabled = true;
      this.txtFirstName.Enabled = true;
      this.txtSurName.Enabled = true;
      this.txtIdentity.Enabled = true;
      this.txtPassword.Enabled = true;
      this.Combo1.Enabled = true;
      this.txtUserID.Text = "";
      this.txtFirstName.Text = "";
      this.txtSurName.Text = "";
      this.txtIdentity.Text = "";
      this.txtPassword.Text = "";
      this.Combo1.SelectedIndex = 3;
      this.txtUserID.Focus();
      this.txtUserID.Select();
      this.dataGridView1.Enabled = false;
    }

    private void Initialize_GridView(short para_gACCLEVEL)
    {
      try
      {
        if (this.dataGridView1.Rows.Count > 0)
          this.dataGridView1.Rows.Clear();
      }
      catch
      {
      }
      this.staffBindingSource.DataSource = (object) this.db.staff_DB.staffDataSet;
      try
      {
        if (this.db.staff_DB.staffDataSet.Staff.Rows.Count > 0)
          this.db.staff_DB.staffDataSet.Staff.Clear();
      }
      catch
      {
      }
      this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
      this.selected_rowindex = 0;
      this.dataGridView1.Refresh();
    }

    public void Initialize()
    {
      this.Initialize_GridView(Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL));
      this.Combo1.Items.Clear();
      this.Combo1.Items.Add((object) "0 - Owner");
      this.Combo1.Items.Add((object) "1 - Manager");
      this.Combo1.Items.Add((object) "2 - Supervisor");
      this.Combo1.Items.Add((object) "3 - Emergency");
      this.Combo1.SelectedIndex = 3;
      this.AllowBuildingChecking();
    }

    private void Form_StaffDMS_Load(object sender, EventArgs e) => this.Initialize();

    private void Form_StaffDMS_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Initialize();
      this.Set_Defaults();
      this.selected_rowindex = 0;
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      this.dataGridView1.Rows[this.selected_rowindex].Selected = false;
      this.Init_Add_Controls();
      this.Add_New_Flag = true;
    }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Set_Defaults();

    private bool Display_Selected_Staff()
    {
      this.Combo1_Click_flag = false;
      if (this.selected_rowindex >= this.dataGridView1.Rows.Count)
        return false;
      this.txtUserID.Text = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.staffIDDataGridViewTextBoxColumn.Name].Value;
      this.txtFirstName.Text = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.sForeNameDataGridViewTextBoxColumn.Name].Value;
      this.txtSurName.Text = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.sSurNameDataGridViewTextBoxColumn.Name].Value;
      try
      {
        this.txtIdentity.Text = (string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.identityDataGridViewTextBoxColumn.Name].Value;
      }
      catch
      {
      }
      this.txtPassword.Text = "";
      this.Combo1.SelectedIndex = Convert.ToInt32((string) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.accLevelDataGridViewTextBoxColumn.Name].Value);
      this.Combo1_Old_Index = this.Combo1.SelectedIndex;
      this._chkBuilding_0.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn1.Name].Value;
      this._chkBuilding_1.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn2.Name].Value;
      this._chkBuilding_2.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn3.Name].Value;
      this._chkBuilding_3.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn4.Name].Value;
      this._chkBuilding_4.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn5.Name].Value;
      this._chkBuilding_5.Checked = (bool) this.dataGridView1.Rows[this.selected_rowindex].Cells[this.dataGridViewCheckBoxColumn6.Name].Value;
      return true;
    }

    private void DeleteRoutine(StaffDataSet.StaffRow para_row)
    {
      if (MessageBox.Show("Are you sure that you want to delete record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        if (this.db.staff_DB.staffTableAdapter.Delete(this.txtUserID.Text) > 0)
        {
          int num = (int) MessageBox.Show("Delete Successful !");
          this.Set_Defaults();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Delete Fail !");
        }
        this.Initialize_GridView(Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL));
        this.dataGridView1.Refresh();
        this.selected_rowindex = 0;
      }
      else
      {
        int num2 = (int) MessageBox.Show("Record not Deleted...", "Message");
      }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      if (!this.Display_Selected_Staff())
        return;
      if (ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "0")
      {
        StaffDataSet.StaffRow para_row = (StaffDataSet.StaffRow) this.db.staff_DB.staffDataSet.Staff.Rows.Find((object) this.txtUserID.Text);
        if (para_row.AccLevel == "0")
        {
          int num = (int) MessageBox.Show("Sorry! Not Allowed to Delete this Record. ");
        }
        else
          this.DeleteRoutine(para_row);
      }
      else
      {
        if (!(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.myAccLevel == "1"))
          return;
        StaffDataSet.StaffRow para_row = (StaffDataSet.StaffRow) this.db.staff_DB.staffDataSet.Staff.Rows.Find((object) this.txtUserID.Text);
        if (para_row.AccLevel == "0" || para_row.AccLevel == "1")
        {
          int num = (int) MessageBox.Show("Sorry! Not Allowed to Delete this Record. ");
        }
        else
          this.DeleteRoutine(para_row);
      }
    }

    private void Enable_Edit_Controls()
    {
      this.BuildingFrame.Enabled = true;
      this.txtUserID.Enabled = true;
      this.txtFirstName.Enabled = true;
      this.txtSurName.Enabled = true;
      this.txtIdentity.Enabled = true;
      this.txtPassword.Enabled = true;
      this.Combo1.Enabled = true;
      this.Edit_Enable_Flag = true;
    }

    private void Disable_Edit_Controls()
    {
      this.BuildingFrame.Enabled = false;
      this.txtUserID.Enabled = false;
      this.txtFirstName.Enabled = false;
      this.txtSurName.Enabled = false;
      this.txtIdentity.Enabled = false;
      this.txtPassword.Enabled = false;
      this.Combo1.Enabled = false;
      this.Edit_Enable_Flag = false;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
      this.Display_Selected_Staff();
      this.Add_New_Flag = false;
      if (Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL) > (short) 0)
      {
        if (((string) this.Combo1.SelectedItem).Contains("0") || ((string) this.Combo1.SelectedItem).Contains("1"))
        {
          this.cmdUpdate.Enabled = false;
          this.cmdDelete.Enabled = false;
          this.Disable_Edit_Controls();
        }
        else
        {
          this.cmdUpdate.Enabled = true;
          this.cmdDelete.Enabled = true;
          this.Enable_Edit_Controls();
        }
      }
      else
      {
        this.cmdUpdate.Enabled = true;
        this.cmdDelete.Enabled = true;
        this.Enable_Edit_Controls();
      }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
        return;
      this.selected_rowindex = e.RowIndex;
      this.Display_Selected_Staff();
      if (Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL) <= (short) 0)
        return;
      if (((string) this.Combo1.SelectedItem).Contains("0") || ((string) this.Combo1.SelectedItem).Contains("1"))
      {
        this.cmdUpdate.Enabled = false;
        this.cmdDelete.Enabled = false;
        this.Disable_Edit_Controls();
      }
      else
      {
        this.cmdUpdate.Enabled = true;
        this.cmdDelete.Enabled = true;
        this.Enable_Edit_Controls();
      }
    }

    private void dataGridView1_RowStateChanged(
      object sender,
      DataGridViewRowStateChangedEventArgs e)
    {
      if ((e.Row.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.None || e.Row.Index < 0 || e.Row.Index >= this.db.staff_DB.staffDataSet.Staff.Rows.Count || this.dataGridView1.Rows.Count != this.db.staff_DB.staffDataSet.Staff.Rows.Count)
        return;
      this.selected_rowindex = e.Row.Index;
      this.Display_Selected_Staff();
      if (Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL) <= (short) 0)
        return;
      if (((string) this.Combo1.SelectedItem).Contains("0") || ((string) this.Combo1.SelectedItem).Contains("1"))
      {
        this.cmdUpdate.Enabled = false;
        this.cmdDelete.Enabled = false;
        this.Disable_Edit_Controls();
      }
      else
      {
        this.cmdUpdate.Enabled = true;
        this.cmdDelete.Enabled = true;
        this.Enable_Edit_Controls();
      }
    }

    private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.txtPassword.Text.Length == 4)
        this.cmdUpdate.Enabled = true;
      if (e.KeyChar != '\r')
        return;
      this.txtIdentity.Focus();
    }

    private void txtPassword_KeyUp(object sender, KeyEventArgs e)
    {
      if (this.txtPassword.Text.Length != 4)
        return;
      this.cmdUpdate.Enabled = true;
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
      if (!this.BuildingFrame.Enabled || this.txtPassword.Text.Length >= 4)
        return;
      this.cmdUpdate.Enabled = false;
    }

    private bool Check_All_Field_Filled()
    {
      if (this.txtUserID.Text.Length < 1)
      {
        int num = (int) MessageBox.Show("User ID Cannot be blank");
        return false;
      }
      if (this.txtFirstName.Text.Length < 1)
      {
        int num = (int) MessageBox.Show("First Name Cannot be blank");
        return false;
      }
      if (this.txtSurName.Text.Length < 1)
      {
        int num = (int) MessageBox.Show("Surname Cannot be blank");
        return false;
      }
      if (this.txtPassword.Text.Length != 4)
      {
        if (this.txtPassword.Text.Length > 0 && this.txtPassword.Text.Length < 4)
        {
          int num1 = (int) MessageBox.Show("Password should be 4 character. ");
        }
        else
        {
          int num2 = (int) MessageBox.Show("Password Cannot be blank");
        }
        return false;
      }
      return this.txtIdentity.Text.Length >= 1;
    }

    public bool Check_User_ID_and_Password_Correct_N_Update(string sUserID, string sPassword)
    {
      bool flag = false;
      byte[] source = this.db.PASSWORDENCRYPT(sPassword);
      int cb = Marshal.SizeOf((object) source[0]) * source.Length;
      IntPtr num1 = Marshal.AllocHGlobal(cb);
      Marshal.AllocHGlobal(cb);
      Marshal.Copy(source, 0, num1, source.Length);
      string stringAnsi = Marshal.PtrToStringAnsi(num1, source.Length);
      this.db.staff_DB.staffTableAdapter.Fill(this.db.staff_DB.staffDataSet.Staff);
      foreach (StaffDataSet.StaffRow row in (InternalDataCollectionBase) this.db.staff_DB.staffDataSet.Staff.Rows)
      {
        if (sUserID == row.StaffID)
        {
          flag = true;
          if (!this.Add_New_Flag)
          {
            row.StaffID = this.txtUserID.Text;
            row.SForeName = this.txtFirstName.Text;
            row.SSurName = this.txtSurName.Text;
            try
            {
              row.Identity = this.txtIdentity.Text;
            }
            catch
            {
              row.Identity = "";
            }
            row.AccLevel = this.Combo1.SelectedIndex.ToString();
            row.AccBuilding1 = this._chkBuilding_0.Checked;
            row.AccBuilding2 = this._chkBuilding_1.Checked;
            row.AccBuilding3 = this._chkBuilding_2.Checked;
            row.AccBuilding4 = this._chkBuilding_3.Checked;
            row.AccBuilding5 = this._chkBuilding_4.Checked;
            row.AccBuilding6 = this._chkBuilding_5.Checked;
            row.Password = stringAnsi;
            row.Update = false;
            if (this.db.staff_DB.staffTableAdapter.Update(this.db.staff_DB.staffDataSet.Staff) <= 0)
            {
              int num2 = (int) MessageBox.Show("Cannot modify for this Staff data!");
              return false;
            }
            this.Add_New_Flag = false;
            return true;
          }
          break;
        }
      }
      if (flag && this.Add_New_Flag)
      {
        int num3 = (int) MessageBox.Show("Duplicate User ID");
        return false;
      }
      StaffDataSet.StaffRow row1 = this.db.staff_DB.staffDataSet.Staff.NewStaffRow();
      row1.StaffID = this.txtUserID.Text;
      row1.SForeName = this.txtFirstName.Text;
      row1.SSurName = this.txtSurName.Text;
      try
      {
        row1.Identity = this.txtIdentity.Text;
      }
      catch
      {
        row1.Identity = "";
      }
      row1.AccLevel = this.Combo1.SelectedIndex.ToString();
      row1.AccBuilding1 = this._chkBuilding_0.Checked;
      row1.AccBuilding2 = this._chkBuilding_1.Checked;
      row1.AccBuilding3 = this._chkBuilding_2.Checked;
      row1.AccBuilding4 = this._chkBuilding_3.Checked;
      row1.AccBuilding5 = this._chkBuilding_4.Checked;
      row1.AccBuilding6 = this._chkBuilding_5.Checked;
      row1.Password = stringAnsi;
      row1.Update = false;
      this.db.staff_DB.staffDataSet.Staff.AddStaffRow(row1);
      if (this.db.staff_DB.staffTableAdapter.Update(this.db.staff_DB.staffDataSet.Staff) > 0)
        return true;
      int num4 = (int) MessageBox.Show("Cannot Add New Staff!");
      return false;
    }

    private void cmdUpdate_Click(object sender, EventArgs e)
    {
      if (this.Check_All_Field_Filled())
      {
        if (!this.Check_User_ID_and_Password_Correct_N_Update(this.txtUserID.Text, this.txtPassword.Text + "0000"))
          return;
        this.Initialize_GridView(Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL));
        this.Set_Defaults();
      }
      else
      {
        int num = (int) MessageBox.Show("Pls. Check Fields not to be Blank !");
      }
    }

    private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.Combo1.Focus();
    }

    private void Combo1_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
      this.Combo1_Click_flag = true;
      if (e.KeyChar != '\r')
        return;
      this.txtFirstName.Focus();
    }

    private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtSurName.Focus();
    }

    private void txtSurName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.txtPassword.Focus();
    }

    private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.BuildingFrame.Focus();
    }

    private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.Combo1_Click_flag || this.Combo1.SelectedIndex >= 2 || Convert.ToInt16(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.gACCLEVEL) <= (short) 0)
        return;
      if (this.Combo1_Old_Index >= 2)
        this.Combo1.SelectedIndex = this.Combo1_Old_Index;
      else
        this.Combo1.SelectedIndex = 3;
      this.Combo1_Click_flag = true;
    }

    private void Combo1_Click(object sender, EventArgs e) => this.Combo1_Click_flag = true;

    private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      if (this.Edit_Enable_Flag)
      {
        this.txtUserID.Focus();
        this.txtUserID.Select();
        this.Edit_Enable_Flag = false;
      }
      e.Handled = true;
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.Edit_Enable_Flag)
      {
        this.txtUserID.Focus();
        this.txtUserID.Select();
        this.Edit_Enable_Flag = false;
      }
      e.Handled = true;
    }

    private void Combo1_Enter(object sender, EventArgs e) => this.Combo1_Click_flag = true;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this._chkBuilding_5 = new System.Windows.Forms.CheckBox();
            this._chkBuilding_4 = new System.Windows.Forms.CheckBox();
            this.Label11 = new System.Windows.Forms.Label();
            this._chkBuilding_3 = new System.Windows.Forms.CheckBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.Combo1 = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this._chkBuilding_2 = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.datPassword = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.frame = new System.Windows.Forms.Panel();
            this._chkBuilding_0 = new System.Windows.Forms.CheckBox();
            this._chkBuilding_1 = new System.Windows.Forms.CheckBox();
            this.BuildingFrame = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sForeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSurNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new AMS.StaffDataSet();
            this.Frame3.SuspendLayout();
            this.frame.SuspendLayout();
            this.BuildingFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Frame3.Controls.Add(this.cmdDelete);
            this.Frame3.Controls.Add(this.cmdAdd);
            this.Frame3.Controls.Add(this.cmdPrint);
            this.Frame3.Controls.Add(this.cmdUpdate);
            this.Frame3.Controls.Add(this.cmdCancel);
            this.Frame3.Controls.Add(this.cmdReturn);
            this.Frame3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(16, 162);
            this.Frame3.Name = "Frame3";
            this.Frame3.Padding = new System.Windows.Forms.Padding(0);
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(617, 64);
            this.Frame3.TabIndex = 13;
            this.Frame3.TabStop = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDelete.Location = new System.Drawing.Point(218, 16);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDelete.Size = new System.Drawing.Size(89, 39);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "&DELETE";
            this.ToolTip1.SetToolTip(this.cmdDelete, "To Delete Selected Record");
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.SystemColors.Control;
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAdd.Location = new System.Drawing.Point(16, 16);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAdd.Size = new System.Drawing.Size(89, 39);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "&ADD";
            this.ToolTip1.SetToolTip(this.cmdAdd, "To Add New Staff");
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPrint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPrint.Location = new System.Drawing.Point(117, 16);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPrint.Size = new System.Drawing.Size(89, 39);
            this.cmdPrint.TabIndex = 8;
            this.cmdPrint.Text = "&PRINT";
            this.ToolTip1.SetToolTip(this.cmdPrint, "To Print Staff Data");
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Visible = false;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUpdate.Location = new System.Drawing.Point(319, 16);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpdate.Size = new System.Drawing.Size(89, 39);
            this.cmdUpdate.TabIndex = 7;
            this.cmdUpdate.Text = "&UPDATE";
            this.ToolTip1.SetToolTip(this.cmdUpdate, "To Confirm Add Data");
            this.cmdUpdate.UseVisualStyleBackColor = false;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancel.Location = new System.Drawing.Point(420, 16);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(89, 39);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "&CANCEL";
            this.ToolTip1.SetToolTip(this.cmdCancel, "To Cancel ");
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdReturn.Location = new System.Drawing.Point(520, 16);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReturn.Size = new System.Drawing.Size(89, 39);
            this.cmdReturn.TabIndex = 11;
            this.cmdReturn.Text = "RETUR&N";
            this.ToolTip1.SetToolTip(this.cmdReturn, "Return to Admin Screen");
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label10.Location = new System.Drawing.Point(0, 112);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(176, 25);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "AUTHORIZED BUILDING ";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Blue;
            this.Label5.Location = new System.Drawing.Point(320, 8);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(120, 25);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "ACCESS  LEVEL";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(320, 40);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(80, 25);
            this.Label7.TabIndex = 22;
            this.Label7.Text = "SURNAME";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _chkBuilding_5
            // 
            this._chkBuilding_5.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_5.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_5.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_5.Location = new System.Drawing.Point(344, 8);
            this._chkBuilding_5.Name = "_chkBuilding_5";
            this._chkBuilding_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_5.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_5.TabIndex = 31;
            this._chkBuilding_5.Text = " 6";
            this._chkBuilding_5.UseVisualStyleBackColor = false;
            // 
            // _chkBuilding_4
            // 
            this._chkBuilding_4.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_4.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_4.Location = new System.Drawing.Point(280, 8);
            this._chkBuilding_4.Name = "_chkBuilding_4";
            this._chkBuilding_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_4.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_4.TabIndex = 30;
            this._chkBuilding_4.Text = " 5 ";
            this._chkBuilding_4.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Blue;
            this.Label11.Location = new System.Drawing.Point(320, 72);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(80, 17);
            this.Label11.TabIndex = 24;
            this.Label11.Text = "IDENTITY ";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _chkBuilding_3
            // 
            this._chkBuilding_3.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_3.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_3.Location = new System.Drawing.Point(216, 8);
            this._chkBuilding_3.Name = "_chkBuilding_3";
            this._chkBuilding_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_3.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_3.TabIndex = 29;
            this._chkBuilding_3.Text = " 4 ";
            this._chkBuilding_3.UseVisualStyleBackColor = false;
            // 
            // txtIdentity
            // 
            this.txtIdentity.AcceptsReturn = true;
            this.txtIdentity.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentity.Enabled = false;
            this.txtIdentity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.ForeColor = System.Drawing.Color.Black;
            this.txtIdentity.Location = new System.Drawing.Point(408, 72);
            this.txtIdentity.MaxLength = 20;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentity.Size = new System.Drawing.Size(191, 26);
            this.txtIdentity.TabIndex = 6;
            this.ToolTip1.SetToolTip(this.txtIdentity, "Enter Identity No.");
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_KeyPress);
            // 
            // txtSurName
            // 
            this.txtSurName.AcceptsReturn = true;
            this.txtSurName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurName.Enabled = false;
            this.txtSurName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurName.ForeColor = System.Drawing.Color.Black;
            this.txtSurName.Location = new System.Drawing.Point(408, 40);
            this.txtSurName.MaxLength = 40;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurName.Size = new System.Drawing.Size(191, 26);
            this.txtSurName.TabIndex = 4;
            this.ToolTip1.SetToolTip(this.txtSurName, "Enter SurName");
            this.txtSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = true;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(184, 40);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(127, 26);
            this.txtFirstName.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.txtFirstName, "Enter First Name");
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtUserID
            // 
            this.txtUserID.AcceptsReturn = true;
            this.txtUserID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.Location = new System.Drawing.Point(184, 8);
            this.txtUserID.MaxLength = 10;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.Size = new System.Drawing.Size(127, 26);
            this.txtUserID.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.txtUserID, "Enter Staff ID");
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // Combo1
            // 
            this.Combo1.BackColor = System.Drawing.SystemColors.Window;
            this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Combo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo1.ForeColor = System.Drawing.Color.Black;
            this.Combo1.Location = new System.Drawing.Point(448, 8);
            this.Combo1.Name = "Combo1";
            this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combo1.Size = new System.Drawing.Size(143, 27);
            this.Combo1.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.Combo1, "Select Access Level");
            this.Combo1.SelectedIndexChanged += new System.EventHandler(this.Combo1_SelectedIndexChanged);
            this.Combo1.Click += new System.EventHandler(this.Combo1_Click);
            this.Combo1.Enter += new System.EventHandler(this.Combo1_Enter);
            this.Combo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combo1_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(184, 72);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(127, 26);
            this.txtPassword.TabIndex = 5;
            this.ToolTip1.SetToolTip(this.txtPassword, "Enter Password");
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // _chkBuilding_2
            // 
            this._chkBuilding_2.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_2.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_2.Location = new System.Drawing.Point(152, 8);
            this._chkBuilding_2.Name = "_chkBuilding_2";
            this._chkBuilding_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_2.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_2.TabIndex = 28;
            this._chkBuilding_2.Text = " 3 ";
            this._chkBuilding_2.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(48, 40);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(120, 25);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "FIRST NAME ";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datPassword
            // 
            this.datPassword.BackColor = System.Drawing.Color.Red;
            this.datPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datPassword.ForeColor = System.Drawing.Color.Black;
            this.datPassword.Location = new System.Drawing.Point(25, 536);
            this.datPassword.Name = "datPassword";
            this.datPassword.Size = new System.Drawing.Size(72, 25);
            this.datPassword.TabIndex = 32;
            this.datPassword.Text = "datPassword";
            this.datPassword.Visible = false;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.Location = new System.Drawing.Point(56, 316);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(681, 25);
            this.Label6.TabIndex = 30;
            this.Label6.Text = "STAFF LIST";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Label3.Location = new System.Drawing.Point(56, 8);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(120, 25);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "STAFF ID ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(0, 52);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(785, 25);
            this.Label9.TabIndex = 29;
            this.Label9.Text = "STAFF DATA";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Blue;
            this.Label4.Location = new System.Drawing.Point(56, 72);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(120, 25);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "PASSWORD ";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(0, 4);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(785, 33);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Admin Mode ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.frame.Controls.Add(this.txtIdentity);
            this.frame.Controls.Add(this.txtSurName);
            this.frame.Controls.Add(this.txtFirstName);
            this.frame.Controls.Add(this.txtUserID);
            this.frame.Controls.Add(this.Frame3);
            this.frame.Controls.Add(this.Combo1);
            this.frame.Controls.Add(this.txtPassword);
            this.frame.Controls.Add(this.Label11);
            this.frame.Controls.Add(this.Label10);
            this.frame.Controls.Add(this.Label7);
            this.frame.Controls.Add(this.Label5);
            this.frame.Controls.Add(this.Label2);
            this.frame.Controls.Add(this.Label3);
            this.frame.Controls.Add(this.Label4);
            this.frame.Cursor = System.Windows.Forms.Cursors.Default;
            this.frame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.frame.Location = new System.Drawing.Point(72, 84);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frame.Size = new System.Drawing.Size(645, 228);
            this.frame.TabIndex = 27;
            // 
            // _chkBuilding_0
            // 
            this._chkBuilding_0.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_0.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_0.Location = new System.Drawing.Point(24, 8);
            this._chkBuilding_0.Name = "_chkBuilding_0";
            this._chkBuilding_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_0.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_0.TabIndex = 26;
            this._chkBuilding_0.Text = " 1 ";
            this._chkBuilding_0.UseVisualStyleBackColor = false;
            // 
            // _chkBuilding_1
            // 
            this._chkBuilding_1.BackColor = System.Drawing.Color.GreenYellow;
            this._chkBuilding_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkBuilding_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBuilding_1.ForeColor = System.Drawing.Color.Blue;
            this._chkBuilding_1.Location = new System.Drawing.Point(88, 8);
            this._chkBuilding_1.Name = "_chkBuilding_1";
            this._chkBuilding_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkBuilding_1.Size = new System.Drawing.Size(49, 25);
            this._chkBuilding_1.TabIndex = 27;
            this._chkBuilding_1.Text = " 2 ";
            this._chkBuilding_1.UseVisualStyleBackColor = false;
            // 
            // BuildingFrame
            // 
            this.BuildingFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BuildingFrame.Controls.Add(this._chkBuilding_5);
            this.BuildingFrame.Controls.Add(this._chkBuilding_4);
            this.BuildingFrame.Controls.Add(this._chkBuilding_3);
            this.BuildingFrame.Controls.Add(this._chkBuilding_2);
            this.BuildingFrame.Controls.Add(this._chkBuilding_1);
            this.BuildingFrame.Controls.Add(this._chkBuilding_0);
            this.BuildingFrame.Cursor = System.Windows.Forms.Cursors.Default;
            this.BuildingFrame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BuildingFrame.Location = new System.Drawing.Point(256, 188);
            this.BuildingFrame.Name = "BuildingFrame";
            this.BuildingFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BuildingFrame.Size = new System.Drawing.Size(417, 41);
            this.BuildingFrame.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.accLevelDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.sForeNameDataGridViewTextBoxColumn,
            this.sSurNameDataGridViewTextBoxColumn,
            this.identityDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.updateDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 344);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 171);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accLevelDataGridViewTextBoxColumn
            // 
            this.accLevelDataGridViewTextBoxColumn.DataPropertyName = "AccLevel";
            this.accLevelDataGridViewTextBoxColumn.HeaderText = "AccLevel";
            this.accLevelDataGridViewTextBoxColumn.Name = "accLevelDataGridViewTextBoxColumn";
            this.accLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AccBuilding1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AccBuilding1";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "AccBuilding2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "AccBuilding2";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 40;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "AccBuilding3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "AccBuilding3";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 40;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "AccBuilding4";
            this.dataGridViewCheckBoxColumn4.HeaderText = "AccBuilding4";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 40;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "AccBuilding5";
            this.dataGridViewCheckBoxColumn5.HeaderText = "AccBuilding5";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Width = 40;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "AccBuilding6";
            this.dataGridViewCheckBoxColumn6.HeaderText = "AccBuilding6";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Width = 40;
            // 
            // sForeNameDataGridViewTextBoxColumn
            // 
            this.sForeNameDataGridViewTextBoxColumn.DataPropertyName = "SForeName";
            this.sForeNameDataGridViewTextBoxColumn.HeaderText = "SForeName";
            this.sForeNameDataGridViewTextBoxColumn.Name = "sForeNameDataGridViewTextBoxColumn";
            this.sForeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSurNameDataGridViewTextBoxColumn
            // 
            this.sSurNameDataGridViewTextBoxColumn.DataPropertyName = "SSurName";
            this.sSurNameDataGridViewTextBoxColumn.HeaderText = "SSurName";
            this.sSurNameDataGridViewTextBoxColumn.Name = "sSurNameDataGridViewTextBoxColumn";
            this.sSurNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identityDataGridViewTextBoxColumn
            // 
            this.identityDataGridViewTextBoxColumn.DataPropertyName = "Identity";
            this.identityDataGridViewTextBoxColumn.HeaderText = "Identity";
            this.identityDataGridViewTextBoxColumn.Name = "identityDataGridViewTextBoxColumn";
            this.identityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateDataGridViewCheckBoxColumn
            // 
            this.updateDataGridViewCheckBoxColumn.DataPropertyName = "Update";
            this.updateDataGridViewCheckBoxColumn.HeaderText = "Update";
            this.updateDataGridViewCheckBoxColumn.Name = "updateDataGridViewCheckBoxColumn";
            this.updateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.staffDataSet;
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "StaffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_StaffDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datPassword);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BuildingFrame);
            this.Controls.Add(this.frame);
            this.Name = "Form_StaffDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_StaffDMS_FormClosing);
            this.Load += new System.EventHandler(this.Form_StaffDMS_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_StaffDMS_VisibleChanged);
            this.Frame3.ResumeLayout(false);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.BuildingFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            this.ResumeLayout(false);

    }
  }
}
