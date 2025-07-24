// Decompiled with JetBrains decompiler
// Type: AMS.gbonusroom_shl
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System.ComponentModel;

#nullable disable
namespace AMS
{
  public class gbonusroom_shl : ReportClass
  {
    public virtual string ResourceName
    {
      get => "gbonusroom_shl.rpt";
      set
      {
      }
    }

    public virtual bool NewGenerator
    {
      get => true;
      set
      {
      }
    }

    public virtual string FullResourceName
    {
      get => "AMS.gbonusroom_shl.rpt";
      set
      {
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportHeaderSection1 => ((ReportDocument) this).ReportDefinition.Sections[0];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section PageHeaderSection1 => ((ReportDocument) this).ReportDefinition.Sections[1];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section DetailSection1 => ((ReportDocument) this).ReportDefinition.Sections[2];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection1 => ((ReportDocument) this).ReportDefinition.Sections[3];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection11 => ((ReportDocument) this).ReportDefinition.Sections[4];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection2 => ((ReportDocument) this).ReportDefinition.Sections[5];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection3 => ((ReportDocument) this).ReportDefinition.Sections[6];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection4 => ((ReportDocument) this).ReportDefinition.Sections[7];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection5 => ((ReportDocument) this).ReportDefinition.Sections[8];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection6 => ((ReportDocument) this).ReportDefinition.Sections[9];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection7 => ((ReportDocument) this).ReportDefinition.Sections[10];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection8 => ((ReportDocument) this).ReportDefinition.Sections[11];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection9 => ((ReportDocument) this).ReportDefinition.Sections[12];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection10 => ((ReportDocument) this).ReportDefinition.Sections[13];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section PageFooterSection1 => ((ReportDocument) this).ReportDefinition.Sections[14];
  }
}
