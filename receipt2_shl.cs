// Decompiled with JetBrains decompiler
// Type: AMS.receipt2_shl
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.ComponentModel;
using System.IO;

#nullable disable
namespace AMS
{
  public class receipt2_shl : ReportClass
  {
    public virtual string ResourceName
    {
      get => "receipt2_shl.rpt";
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
      get => "AMS.receipt2_shl.rpt";
      set
      {
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportHeaderSection1 => ((ReportDocument) this).ReportDefinition.Sections[0];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section PageHeaderSection1 => ((ReportDocument) this).ReportDefinition.Sections[1];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section PageHeaderSection2 => ((ReportDocument) this).ReportDefinition.Sections[2];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section DetailSection1 => ((ReportDocument) this).ReportDefinition.Sections[3];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection1 => ((ReportDocument) this).ReportDefinition.Sections[4];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection2 => ((ReportDocument) this).ReportDefinition.Sections[5];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection3 => ((ReportDocument) this).ReportDefinition.Sections[6];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection4 => ((ReportDocument) this).ReportDefinition.Sections[7];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection5 => ((ReportDocument) this).ReportDefinition.Sections[8];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection6 => ((ReportDocument) this).ReportDefinition.Sections[9];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection7 => ((ReportDocument) this).ReportDefinition.Sections[10];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection8 => ((ReportDocument) this).ReportDefinition.Sections[11];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection9 => ((ReportDocument) this).ReportDefinition.Sections[12];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection10 => ((ReportDocument) this).ReportDefinition.Sections[13];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection11 => ((ReportDocument) this).ReportDefinition.Sections[14];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection12 => ((ReportDocument) this).ReportDefinition.Sections[15];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection13 => ((ReportDocument) this).ReportDefinition.Sections[16];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection14 => ((ReportDocument) this).ReportDefinition.Sections[17];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection15 => ((ReportDocument) this).ReportDefinition.Sections[18];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection16 => ((ReportDocument) this).ReportDefinition.Sections[19];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection17 => ((ReportDocument) this).ReportDefinition.Sections[20];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection18 => ((ReportDocument) this).ReportDefinition.Sections[21];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection19 => ((ReportDocument) this).ReportDefinition.Sections[22];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection20 => ((ReportDocument) this).ReportDefinition.Sections[23];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection21 => ((ReportDocument) this).ReportDefinition.Sections[24];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection22 => ((ReportDocument) this).ReportDefinition.Sections[25];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection23 => ((ReportDocument) this).ReportDefinition.Sections[26];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection24 => ((ReportDocument) this).ReportDefinition.Sections[27];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection25 => ((ReportDocument) this).ReportDefinition.Sections[28];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection26 => ((ReportDocument) this).ReportDefinition.Sections[29];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection27 => ((ReportDocument) this).ReportDefinition.Sections[30];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection28 => ((ReportDocument) this).ReportDefinition.Sections[31];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection29 => ((ReportDocument) this).ReportDefinition.Sections[32];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection30 => ((ReportDocument) this).ReportDefinition.Sections[33];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection31 => ((ReportDocument) this).ReportDefinition.Sections[34];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section ReportFooterSection32 => ((ReportDocument) this).ReportDefinition.Sections[35];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection33 => ((ReportDocument) this).ReportDefinition.Sections[36];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section ReportFooterSection34 => ((ReportDocument) this).ReportDefinition.Sections[37];

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section PageFooterSection1 => ((ReportDocument) this).ReportDefinition.Sections[38];

        internal void Load(Stream rptStream)
        {
            throw new NotImplementedException();
        }
    }
}
