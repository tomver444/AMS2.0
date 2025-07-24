// Decompiled with JetBrains decompiler
// Type: AMS.ReportClass_Dummy
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using CrystalDecisions.CrystalReports.Engine;
using System.ComponentModel;

#nullable disable
namespace AMS
{
  internal class ReportClass_Dummy
  {
    private static bool Temp_MDB_SaveFlag;
    private DB db;
    private IContainer components;
    public string start_Date = "";
    public string End_date = "";
    public receipt2_shl receipt2_1;

    public ReportClass_Dummy()
    {
      this.InitializeComponent();
      this.db = new DB();
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.receipt2_1 = new receipt2_shl();
    }

    public object Dummy_Show() => (object) this.Check_Report_Dummy();

        private ReportDocument Check_Report_Dummy()
        {
            // Create a new ReportDocument instance
            ReportDocument reportDocument = new ReportDocument();

            // Load the report from the specified file path
            string reportPath = @"C:\Users\Administrator\Desktop\birchridge\src\AMS\receipt2_shl.rpt";
            reportDocument.Load(reportPath);

            // Set the data source for the report
            reportDocument.SetDataSource(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Receipt.DataSet);

            // Fill the table adapter with data
            ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.receiptTableAdapter.Fill(ModDoorLockSystem.Class_ModDoorLockSystem_Object_Ptr.tempDataSet.Receipt);

            // Return the loaded ReportDocument
            return reportDocument;
        }


    }
}
