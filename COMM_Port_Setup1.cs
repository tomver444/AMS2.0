// Decompiled with JetBrains decompiler
// Type: AMS.COMM_Port_Setup1
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class COMM_Port_Setup1 : Form
  {
    private IContainer components;
    private ComboBox PortList;
    private Label label1;
    private ComboBox comboBox_FlowControl;
    private Label label6;
    private ComboBox comboBox_DataBits;
    private Label label5;
    private ComboBox comboBox_Stopbits;
    private Label label4;
    private ComboBox comboBox_Parity;
    private Label label3;
    private ComboBox comboBox_BPS;
    private Label label2;
    private Button Cancel;
    private Button OK_NEW_COMM;
    private string[] Bate_Rates_TextList;
    private string[] DataBits_TextList;
    private string[] Parity_TextList;
    private string[] StopBits_TextList;
    private string[] FlowCtrl_TextList;
    private string Active_Comm_Port = "";
    public string[] COMM_Port_Names;
    private int COM_PORTS_COUNT;
    private byte COM_Port_Num;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.PortList = new ComboBox();
      this.label1 = new Label();
      this.comboBox_FlowControl = new ComboBox();
      this.label6 = new Label();
      this.comboBox_DataBits = new ComboBox();
      this.label5 = new Label();
      this.comboBox_Stopbits = new ComboBox();
      this.label4 = new Label();
      this.comboBox_Parity = new ComboBox();
      this.label3 = new Label();
      this.comboBox_BPS = new ComboBox();
      this.label2 = new Label();
      this.Cancel = new Button();
      this.OK_NEW_COMM = new Button();
      this.SuspendLayout();
      this.PortList.FormattingEnabled = true;
      this.PortList.Location = new Point(146, 38);
      this.PortList.Margin = new Padding(2);
      this.PortList.Name = "PortList";
      this.PortList.Size = new Size(145, 21);
      this.PortList.TabIndex = 0;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(39, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(98, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = " Select  COM Port :";
      this.comboBox_FlowControl.Enabled = false;
      this.comboBox_FlowControl.FormattingEnabled = true;
      this.comboBox_FlowControl.Location = new Point(146, 276);
      this.comboBox_FlowControl.Name = "comboBox_FlowControl";
      this.comboBox_FlowControl.Size = new Size(145, 21);
      this.comboBox_FlowControl.TabIndex = 21;
      this.comboBox_FlowControl.Visible = false;
      this.label6.AutoSize = true;
      this.label6.Enabled = false;
      this.label6.Location = new Point(39, 276);
      this.label6.Name = "label6";
      this.label6.Size = new Size(68, 13);
      this.label6.TabIndex = 20;
      this.label6.Text = "Flow Control:";
      this.label6.Visible = false;
      this.comboBox_DataBits.Enabled = false;
      this.comboBox_DataBits.FormattingEnabled = true;
      this.comboBox_DataBits.Location = new Point(146, 130);
      this.comboBox_DataBits.Name = "comboBox_DataBits";
      this.comboBox_DataBits.Size = new Size(145, 21);
      this.comboBox_DataBits.TabIndex = 24;
      this.comboBox_DataBits.Visible = false;
      this.comboBox_DataBits.SelectedIndexChanged += new EventHandler(this.comboBox_DataBits_SelectedIndexChanged);
      this.label5.AutoSize = true;
      this.label5.Enabled = false;
      this.label5.Location = new Point(39, 130);
      this.label5.Name = "label5";
      this.label5.Size = new Size(53, 13);
      this.label5.TabIndex = 23;
      this.label5.Text = "Data Bits:";
      this.label5.Visible = false;
      this.comboBox_Stopbits.Enabled = false;
      this.comboBox_Stopbits.FormattingEnabled = true;
      this.comboBox_Stopbits.Location = new Point(148, 226);
      this.comboBox_Stopbits.Name = "comboBox_Stopbits";
      this.comboBox_Stopbits.Size = new Size(144, 21);
      this.comboBox_Stopbits.TabIndex = 22;
      this.comboBox_Stopbits.Visible = false;
      this.label4.AutoSize = true;
      this.label4.Enabled = false;
      this.label4.Location = new Point(39, 226);
      this.label4.Name = "label4";
      this.label4.Size = new Size(51, 13);
      this.label4.TabIndex = 19;
      this.label4.Text = "Stop bits:";
      this.label4.Visible = false;
      this.comboBox_Parity.Enabled = false;
      this.comboBox_Parity.FormattingEnabled = true;
      this.comboBox_Parity.Location = new Point(146, 174);
      this.comboBox_Parity.Name = "comboBox_Parity";
      this.comboBox_Parity.Size = new Size(145, 21);
      this.comboBox_Parity.TabIndex = 18;
      this.comboBox_Parity.Visible = false;
      this.label3.AutoSize = true;
      this.label3.Enabled = false;
      this.label3.Location = new Point(39, 176);
      this.label3.Name = "label3";
      this.label3.Size = new Size(36, 13);
      this.label3.TabIndex = 17;
      this.label3.Text = "Parity:";
      this.label3.Visible = false;
      this.comboBox_BPS.Enabled = false;
      this.comboBox_BPS.FormattingEnabled = true;
      this.comboBox_BPS.Location = new Point(146, 83);
      this.comboBox_BPS.Name = "comboBox_BPS";
      this.comboBox_BPS.Size = new Size(145, 21);
      this.comboBox_BPS.TabIndex = 16;
      this.comboBox_BPS.Visible = false;
      this.label2.AutoSize = true;
      this.label2.Enabled = false;
      this.label2.Location = new Point(39, 89);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 13);
      this.label2.TabIndex = 15;
      this.label2.Text = "Bits per second:";
      this.label2.Visible = false;
      this.Cancel.DialogResult = DialogResult.Cancel;
      this.Cancel.Enabled = false;
      this.Cancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Cancel.Location = new Point(230, 336);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new Size(96, 24);
      this.Cancel.TabIndex = 26;
      this.Cancel.Text = "Cancel";
      this.Cancel.UseVisualStyleBackColor = true;
      this.Cancel.Visible = false;
      this.Cancel.Click += new EventHandler(this.Cancel_Click);
      this.OK_NEW_COMM.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.OK_NEW_COMM.Location = new Point(325, 38);
      this.OK_NEW_COMM.Name = "OK_NEW_COMM";
      this.OK_NEW_COMM.Size = new Size(104, 24);
      this.OK_NEW_COMM.TabIndex = 25;
      this.OK_NEW_COMM.Text = "OK";
      this.OK_NEW_COMM.UseVisualStyleBackColor = true;
      this.OK_NEW_COMM.Click += new EventHandler(this.OK_NEW_COMM_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(451, 83);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Cancel);
      this.Controls.Add((Control) this.OK_NEW_COMM);
      this.Controls.Add((Control) this.comboBox_FlowControl);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.comboBox_DataBits);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.comboBox_Stopbits);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.comboBox_Parity);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.comboBox_BPS);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.PortList);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.HelpButton = true;
      this.Margin = new Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "COMM_Port_Setup1";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Setup COM Port Properties";
      this.Load += new EventHandler(this.COMM_Setup_Form_Load);
      this.VisibleChanged += new EventHandler(this.COMM_Port_Setup1_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public COMM_Port_Setup1()
    {
      this.InitializeComponent();
      this.Bate_Rates_TextList = new string[13]
      {
        "110",
        "300",
        "1200",
        "2400",
        "4800",
        "9600",
        "19200",
        "38400",
        "57600",
        "115200",
        "230400",
        "460800",
        "921600"
      };
      this.DataBits_TextList = new string[4]
      {
        "5",
        "6",
        "7",
        "8"
      };
      this.Parity_TextList = new string[5]
      {
        "Even",
        "Odd",
        "None",
        "Mark",
        "Space"
      };
      this.StopBits_TextList = new string[3]
      {
        "1",
        "1.5",
        "2"
      };
      this.FlowCtrl_TextList = new string[3]
      {
        "Xon/Xoff",
        "Hardware",
        "None"
      };
    }

    public string COM_PORT
    {
      get => this.Active_Comm_Port;
      set => this.Active_Comm_Port = value;
    }

    public int COM_Ports_Count => this.COM_PORTS_COUNT;

    public byte COM_NUM
    {
      get => this.COM_Port_Num;
      set => this.COM_Port_Num = value;
    }

    public int Get_Port_List_And_SetDefault()
    {
      this.COMM_Port_Names = SerialPort.GetPortNames();
      if (this.COMM_Port_Names.Length == 0)
      {
        this.Active_Comm_Port = "";
        return 0;
      }
      if (this.COMM_Port_Names.Length == 1)
      {
        this.Active_Comm_Port = this.COMM_Port_Names[0];
      }
      else
      {
        foreach (string commPortName in this.COMM_Port_Names)
        {
          if (this.Active_Comm_Port == "")
          {
            if (commPortName == "COM" + Global_Data.COM_NUM.ToString())
            {
              this.Active_Comm_Port = commPortName;
              break;
            }
          }
          else if (commPortName == this.Active_Comm_Port)
            break;
        }
        if (this.Active_Comm_Port == "")
          this.Active_Comm_Port = this.COMM_Port_Names[0];
      }
      this.COM_PORTS_COUNT = this.COMM_Port_Names.Length;
      this.COM_Port_Num = !(this.Active_Comm_Port != "") ? (byte) 0 : Convert.ToByte(this.Active_Comm_Port.Remove(0, 3), 10);
      return this.COMM_Port_Names.Length;
    }

    public void Select_COM_Port_Name(string para_COM_PortName)
    {
      this.Active_Comm_Port = para_COM_PortName;
      if (this.Active_Comm_Port != "")
        this.COM_Port_Num = Convert.ToByte(this.Active_Comm_Port.Remove(0, 3), 10);
      else
        this.COM_Port_Num = (byte) 0;
    }

    private void Get_ComPorts_Refresh()
    {
      bool flag = false;
      Form1 owner = (Form1) this.Owner;
      this.PortList.Items.Clear();
      this.OK_NEW_COMM.DialogResult = DialogResult.OK;
      this.Cancel.DialogResult = DialogResult.Cancel;
      this.COMM_Port_Names = SerialPort.GetPortNames();
      this.PortList.BeginUpdate();
      int index = 0;
      int num1 = 0;
      int num2 = 0;
      do
      {
        if (this.COMM_Port_Names[index] == this.COM_PORT)
        {
          flag = true;
          num2 = index;
        }
        this.PortList.Items.Add((object) this.COMM_Port_Names[index]);
        ++num1;
        ++index;
      }
      while (index < this.COMM_Port_Names.Length);
      this.PortList.EndUpdate();
      if (flag)
        this.PortList.SelectedIndex = num2;
      else
        this.PortList.SelectedIndex = 0;
      this.COM_PORTS_COUNT = this.COMM_Port_Names.Length;
    }

    private void COMM_Setup_Form_Load(object sender, EventArgs e) => this.Get_ComPorts_Refresh();

    private void Cancel_Click(object sender, EventArgs e) => this.Visible = false;

    private void OK_NEW_COMM_Click(object sender, EventArgs e)
    {
      Form1 owner = (Form1) this.Owner;
      this.Active_Comm_Port = (string) this.PortList.SelectedItem;
      if (this.PortList.SelectedIndex == -1)
        this.Active_Comm_Port = "";
      this.COM_Port_Num = !(this.Active_Comm_Port != "") ? (byte) 0 : Convert.ToByte(this.Active_Comm_Port.Remove(0, 3), 10);
      this.Visible = false;
    }

    private void comboBox_DataBits_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    public void Reload() => this.Get_ComPorts_Refresh();

    private void COMM_Port_Setup1_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Get_ComPorts_Refresh();
    }
  }
}
