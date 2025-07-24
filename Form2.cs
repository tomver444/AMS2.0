// Decompiled with JetBrains decompiler
// Type: AMS.Form2
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using AMS.ReplacementDB1DataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace AMS
{
  public class Form2 : Form
  {
    private IContainer components;
    private ReplacementDB1DataSet replacementDB1DataSet;
    private BindingSource replacementBindingSource;
    private ReplacementTableAdapter replacementTableAdapter;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.replacementBindingSource = new BindingSource(this.components);
      this.replacementDB1DataSet = new ReplacementDB1DataSet();
      this.replacementTableAdapter = new ReplacementTableAdapter();
      ((ISupportInitialize) this.replacementBindingSource).BeginInit();
      this.replacementDB1DataSet.BeginInit();
      this.SuspendLayout();
      this.replacementBindingSource.DataMember = "Replacement";
      this.replacementBindingSource.DataSource = (object) this.replacementDB1DataSet;
      this.replacementDB1DataSet.DataSetName = "ReplacementDB1DataSet";
      this.replacementDB1DataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.replacementTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(741, 488);
      this.Name = "Form2";
      this.Load += new EventHandler(this.Form2_Load);
      ((ISupportInitialize) this.replacementBindingSource).EndInit();
      this.replacementDB1DataSet.EndInit();
      this.ResumeLayout(false);
    }

    public Form2() => this.InitializeComponent();

    private void Form2_Load(object sender, EventArgs e)
    {
      this.replacementTableAdapter.Fill(this.replacementDB1DataSet.Replacement);
    }
  }
}
