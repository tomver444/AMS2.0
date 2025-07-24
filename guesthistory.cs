// Decompiled with JetBrains decompiler
// Type: AMS.guesthistory
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System.ComponentModel;

#nullable disable
namespace AMS
{
  public class guesthistory : ReportClass
  {
    public virtual string ResourceName
    {
      get => "guesthistory.rpt";
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
      get => "AMS.guesthistory.rpt";
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section PageFooterSection1 => ((ReportDocument) this).ReportDefinition.Sections[4];
  }
}
