// Decompiled with JetBrains decompiler
// Type: AMS.ReportForm
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class ReportForm : Form
  {
    private IContainer components;
    public CrystalReportViewer crystalReportViewer1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      /*this.crystalReportViewer1 = new CrystalReportViewer();
      this.SuspendLayout();
      this.crystalReportViewer1.ActiveViewIndex = -1;
      ((UserControl) this.crystalReportViewer1).BorderStyle = BorderStyle.FixedSingle;
      ((Control) this.crystalReportViewer1).Dock = DockStyle.Fill;
      ((Control) this.crystalReportViewer1).Location = new Point(0, 0);
      ((Control) this.crystalReportViewer1).Margin = new Padding(2);
      ((Control) this.crystalReportViewer1).Name = "crystalReportViewer1";
      this.crystalReportViewer1.SelectionFormula = "";
      ((Control) this.crystalReportViewer1).Size = new Size(548, 400);
      ((Control) this.crystalReportViewer1).TabIndex = 0;
      this.crystalReportViewer1.ViewTimeSelectionFormula = "";

      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new Size(548, 400);
      this.Controls.Add((Control) this.crystalReportViewer1);
      this.Margin = new Padding(2);
      this.Name = "ReportForm";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ReportForm";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.ReportForm_Load);
      this.VisibleChanged += new EventHandler(this.ReportForm_VisibleChanged);
      */
      this.ResumeLayout(false);
    }

    public ReportForm() => this.InitializeComponent();

    private void ReportForm_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.Text = Global_Data.Report_Form_Title;
    }

    private void ReportForm_Load(object sender, EventArgs e)
    {
    }
  }
}
