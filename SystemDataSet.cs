// Decompiled with JetBrains decompiler
// Type: AMS.SystemDataSet
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace AMS
{
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlRoot("SystemDataSet")]
  [Serializable]
  public class SystemDataSet : DataSet
  {
    private SystemDataSet.BonusDataTable tableBonus;
    private SystemDataSet.Bonus1DataTable tableBonus1;
    private SystemDataSet.Bonus2DataTable tableBonus2;
    private SystemDataSet.Bonus3DataTable tableBonus3;
    private SystemDataSet.Bonus4DataTable tableBonus4;
    private SystemDataSet.Bonus5DataTable tableBonus5;
    private SystemDataSet.Bonus6DataTable tableBonus6;
    private SystemDataSet.BuildingDataTable tableBuilding;
    private SystemDataSet.CountryDataTable tableCountry;
    private SystemDataSet.FloorDataTable tableFloor;
    private SystemDataSet.GSTHistoryDataTable tableGSTHistory;
    private SystemDataSet.GSTHistory1DataTable tableGSTHistory1;
    private SystemDataSet.GSTHistory2DataTable tableGSTHistory2;
    private SystemDataSet.GSTHistory3DataTable tableGSTHistory3;
    private SystemDataSet.GSTHistory4DataTable tableGSTHistory4;
    private SystemDataSet.GSTHistory5DataTable tableGSTHistory5;
    private SystemDataSet.GSTHistory6DataTable tableGSTHistory6;
    private SystemDataSet.RoomDataTable tableRoom;
    private SystemDataSet.RoomStatus1DataTable tableRoomStatus1;
    private SystemDataSet.RoomStatus2DataTable tableRoomStatus2;
    private SystemDataSet.RoomStatus3DataTable tableRoomStatus3;
    private SystemDataSet.RoomStatus4DataTable tableRoomStatus4;
    private SystemDataSet.RoomStatus5DataTable tableRoomStatus5;
    private SystemDataSet.RoomStatus6DataTable tableRoomStatus6;
    private SystemDataSet.RoomTypeDataTable tableRoomType;
    private SystemDataSet.SystemSet1DataTable tableSystemSet1;
    private SystemDataSet.ZoneDataTable tableZone;
    private SystemDataSet.SystemSet2DataTable tableSystemSet2;
    private SystemDataSet.SystemSet3DataTable tableSystemSet3;
    private SystemDataSet.SystemSet4DataTable tableSystemSet4;
    private SystemDataSet.SystemSet5DataTable tableSystemSet5;
    private SystemDataSet.SystemSet6DataTable tableSystemSet6;
    private SystemDataSet.SystemSetDataTable tableSystemSet;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public SystemDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected SystemDataSet(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (Bonus)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.BonusDataTable(dataSet.Tables[nameof (Bonus)]));
          if (dataSet.Tables[nameof (Bonus1)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus1DataTable(dataSet.Tables[nameof (Bonus1)]));
          if (dataSet.Tables[nameof (Bonus2)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus2DataTable(dataSet.Tables[nameof (Bonus2)]));
          if (dataSet.Tables[nameof (Bonus3)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus3DataTable(dataSet.Tables[nameof (Bonus3)]));
          if (dataSet.Tables[nameof (Bonus4)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus4DataTable(dataSet.Tables[nameof (Bonus4)]));
          if (dataSet.Tables[nameof (Bonus5)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus5DataTable(dataSet.Tables[nameof (Bonus5)]));
          if (dataSet.Tables[nameof (Bonus6)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.Bonus6DataTable(dataSet.Tables[nameof (Bonus6)]));
          if (dataSet.Tables[nameof (Building)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.BuildingDataTable(dataSet.Tables[nameof (Building)]));
          if (dataSet.Tables[nameof (Country)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.CountryDataTable(dataSet.Tables[nameof (Country)]));
          if (dataSet.Tables[nameof (Floor)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.FloorDataTable(dataSet.Tables[nameof (Floor)]));
          if (dataSet.Tables[nameof (GSTHistory)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistoryDataTable(dataSet.Tables[nameof (GSTHistory)]));
          if (dataSet.Tables[nameof (GSTHistory1)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory1DataTable(dataSet.Tables[nameof (GSTHistory1)]));
          if (dataSet.Tables[nameof (GSTHistory2)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory2DataTable(dataSet.Tables[nameof (GSTHistory2)]));
          if (dataSet.Tables[nameof (GSTHistory3)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory3DataTable(dataSet.Tables[nameof (GSTHistory3)]));
          if (dataSet.Tables[nameof (GSTHistory4)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory4DataTable(dataSet.Tables[nameof (GSTHistory4)]));
          if (dataSet.Tables[nameof (GSTHistory5)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory5DataTable(dataSet.Tables[nameof (GSTHistory5)]));
          if (dataSet.Tables[nameof (GSTHistory6)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.GSTHistory6DataTable(dataSet.Tables[nameof (GSTHistory6)]));
          if (dataSet.Tables[nameof (Room)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomDataTable(dataSet.Tables[nameof (Room)]));
          if (dataSet.Tables[nameof (RoomStatus1)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus1DataTable(dataSet.Tables[nameof (RoomStatus1)]));
          if (dataSet.Tables[nameof (RoomStatus2)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus2DataTable(dataSet.Tables[nameof (RoomStatus2)]));
          if (dataSet.Tables[nameof (RoomStatus3)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus3DataTable(dataSet.Tables[nameof (RoomStatus3)]));
          if (dataSet.Tables[nameof (RoomStatus4)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus4DataTable(dataSet.Tables[nameof (RoomStatus4)]));
          if (dataSet.Tables[nameof (RoomStatus5)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus5DataTable(dataSet.Tables[nameof (RoomStatus5)]));
          if (dataSet.Tables[nameof (RoomStatus6)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomStatus6DataTable(dataSet.Tables[nameof (RoomStatus6)]));
          if (dataSet.Tables[nameof (RoomType)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.RoomTypeDataTable(dataSet.Tables[nameof (RoomType)]));
          if (dataSet.Tables[nameof (SystemSet1)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet1DataTable(dataSet.Tables[nameof (SystemSet1)]));
          if (dataSet.Tables[nameof (Zone)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.ZoneDataTable(dataSet.Tables[nameof (Zone)]));
          if (dataSet.Tables[nameof (SystemSet2)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet2DataTable(dataSet.Tables[nameof (SystemSet2)]));
          if (dataSet.Tables[nameof (SystemSet3)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet3DataTable(dataSet.Tables[nameof (SystemSet3)]));
          if (dataSet.Tables[nameof (SystemSet4)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet4DataTable(dataSet.Tables[nameof (SystemSet4)]));
          if (dataSet.Tables[nameof (SystemSet5)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet5DataTable(dataSet.Tables[nameof (SystemSet5)]));
          if (dataSet.Tables[nameof (SystemSet6)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSet6DataTable(dataSet.Tables[nameof (SystemSet6)]));
          if (dataSet.Tables[nameof (SystemSet)] != null)
            base.Tables.Add((DataTable) new SystemDataSet.SystemSetDataTable(dataSet.Tables[nameof (SystemSet)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.BonusDataTable Bonus => this.tableBonus;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus1DataTable Bonus1 => this.tableBonus1;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus2DataTable Bonus2 => this.tableBonus2;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus3DataTable Bonus3 => this.tableBonus3;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus4DataTable Bonus4 => this.tableBonus4;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus5DataTable Bonus5 => this.tableBonus5;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.Bonus6DataTable Bonus6 => this.tableBonus6;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.BuildingDataTable Building => this.tableBuilding;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.CountryDataTable Country => this.tableCountry;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.FloorDataTable Floor => this.tableFloor;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.GSTHistoryDataTable GSTHistory => this.tableGSTHistory;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.GSTHistory1DataTable GSTHistory1 => this.tableGSTHistory1;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.GSTHistory2DataTable GSTHistory2 => this.tableGSTHistory2;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.GSTHistory3DataTable GSTHistory3 => this.tableGSTHistory3;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.GSTHistory4DataTable GSTHistory4 => this.tableGSTHistory4;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.GSTHistory5DataTable GSTHistory5 => this.tableGSTHistory5;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.GSTHistory6DataTable GSTHistory6 => this.tableGSTHistory6;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.RoomDataTable Room => this.tableRoom;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.RoomStatus1DataTable RoomStatus1 => this.tableRoomStatus1;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public SystemDataSet.RoomStatus2DataTable RoomStatus2 => this.tableRoomStatus2;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.RoomStatus3DataTable RoomStatus3 => this.tableRoomStatus3;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.RoomStatus4DataTable RoomStatus4 => this.tableRoomStatus4;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public SystemDataSet.RoomStatus5DataTable RoomStatus5 => this.tableRoomStatus5;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.RoomStatus6DataTable RoomStatus6 => this.tableRoomStatus6;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public SystemDataSet.RoomTypeDataTable RoomType => this.tableRoomType;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public SystemDataSet.SystemSet1DataTable SystemSet1 => this.tableSystemSet1;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public SystemDataSet.ZoneDataTable Zone => this.tableZone;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.SystemSet2DataTable SystemSet2 => this.tableSystemSet2;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.SystemSet3DataTable SystemSet3 => this.tableSystemSet3;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public SystemDataSet.SystemSet4DataTable SystemSet4 => this.tableSystemSet4;

    [DebuggerNonUserCode]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.SystemSet5DataTable SystemSet5 => this.tableSystemSet5;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public SystemDataSet.SystemSet6DataTable SystemSet6 => this.tableSystemSet6;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public SystemDataSet.SystemSetDataTable SystemSet => this.tableSystemSet;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataTableCollection Tables => base.Tables;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    public override DataSet Clone()
    {
      SystemDataSet systemDataSet = (SystemDataSet) base.Clone();
      systemDataSet.InitVars();
      systemDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) systemDataSet;
    }

    [DebuggerNonUserCode]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Bonus"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.BonusDataTable(dataSet.Tables["Bonus"]));
        if (dataSet.Tables["Bonus1"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus1DataTable(dataSet.Tables["Bonus1"]));
        if (dataSet.Tables["Bonus2"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus2DataTable(dataSet.Tables["Bonus2"]));
        if (dataSet.Tables["Bonus3"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus3DataTable(dataSet.Tables["Bonus3"]));
        if (dataSet.Tables["Bonus4"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus4DataTable(dataSet.Tables["Bonus4"]));
        if (dataSet.Tables["Bonus5"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus5DataTable(dataSet.Tables["Bonus5"]));
        if (dataSet.Tables["Bonus6"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.Bonus6DataTable(dataSet.Tables["Bonus6"]));
        if (dataSet.Tables["Building"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.BuildingDataTable(dataSet.Tables["Building"]));
        if (dataSet.Tables["Country"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.CountryDataTable(dataSet.Tables["Country"]));
        if (dataSet.Tables["Floor"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.FloorDataTable(dataSet.Tables["Floor"]));
        if (dataSet.Tables["GSTHistory"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistoryDataTable(dataSet.Tables["GSTHistory"]));
        if (dataSet.Tables["GSTHistory1"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory1DataTable(dataSet.Tables["GSTHistory1"]));
        if (dataSet.Tables["GSTHistory2"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory2DataTable(dataSet.Tables["GSTHistory2"]));
        if (dataSet.Tables["GSTHistory3"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory3DataTable(dataSet.Tables["GSTHistory3"]));
        if (dataSet.Tables["GSTHistory4"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory4DataTable(dataSet.Tables["GSTHistory4"]));
        if (dataSet.Tables["GSTHistory5"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory5DataTable(dataSet.Tables["GSTHistory5"]));
        if (dataSet.Tables["GSTHistory6"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.GSTHistory6DataTable(dataSet.Tables["GSTHistory6"]));
        if (dataSet.Tables["Room"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomDataTable(dataSet.Tables["Room"]));
        if (dataSet.Tables["RoomStatus1"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus1DataTable(dataSet.Tables["RoomStatus1"]));
        if (dataSet.Tables["RoomStatus2"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus2DataTable(dataSet.Tables["RoomStatus2"]));
        if (dataSet.Tables["RoomStatus3"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus3DataTable(dataSet.Tables["RoomStatus3"]));
        if (dataSet.Tables["RoomStatus4"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus4DataTable(dataSet.Tables["RoomStatus4"]));
        if (dataSet.Tables["RoomStatus5"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus5DataTable(dataSet.Tables["RoomStatus5"]));
        if (dataSet.Tables["RoomStatus6"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomStatus6DataTable(dataSet.Tables["RoomStatus6"]));
        if (dataSet.Tables["RoomType"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.RoomTypeDataTable(dataSet.Tables["RoomType"]));
        if (dataSet.Tables["SystemSet1"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet1DataTable(dataSet.Tables["SystemSet1"]));
        if (dataSet.Tables["Zone"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.ZoneDataTable(dataSet.Tables["Zone"]));
        if (dataSet.Tables["SystemSet2"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet2DataTable(dataSet.Tables["SystemSet2"]));
        if (dataSet.Tables["SystemSet3"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet3DataTable(dataSet.Tables["SystemSet3"]));
        if (dataSet.Tables["SystemSet4"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet4DataTable(dataSet.Tables["SystemSet4"]));
        if (dataSet.Tables["SystemSet5"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet5DataTable(dataSet.Tables["SystemSet5"]));
        if (dataSet.Tables["SystemSet6"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSet6DataTable(dataSet.Tables["SystemSet6"]));
        if (dataSet.Tables["SystemSet"] != null)
          base.Tables.Add((DataTable) new SystemDataSet.SystemSetDataTable(dataSet.Tables["SystemSet"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    internal void InitVars(bool initTable)
    {
      this.tableBonus = (SystemDataSet.BonusDataTable) base.Tables["Bonus"];
      if (initTable && this.tableBonus != null)
        this.tableBonus.InitVars();
      this.tableBonus1 = (SystemDataSet.Bonus1DataTable) base.Tables["Bonus1"];
      if (initTable && this.tableBonus1 != null)
        this.tableBonus1.InitVars();
      this.tableBonus2 = (SystemDataSet.Bonus2DataTable) base.Tables["Bonus2"];
      if (initTable && this.tableBonus2 != null)
        this.tableBonus2.InitVars();
      this.tableBonus3 = (SystemDataSet.Bonus3DataTable) base.Tables["Bonus3"];
      if (initTable && this.tableBonus3 != null)
        this.tableBonus3.InitVars();
      this.tableBonus4 = (SystemDataSet.Bonus4DataTable) base.Tables["Bonus4"];
      if (initTable && this.tableBonus4 != null)
        this.tableBonus4.InitVars();
      this.tableBonus5 = (SystemDataSet.Bonus5DataTable) base.Tables["Bonus5"];
      if (initTable && this.tableBonus5 != null)
        this.tableBonus5.InitVars();
      this.tableBonus6 = (SystemDataSet.Bonus6DataTable) base.Tables["Bonus6"];
      if (initTable && this.tableBonus6 != null)
        this.tableBonus6.InitVars();
      this.tableBuilding = (SystemDataSet.BuildingDataTable) base.Tables["Building"];
      if (initTable && this.tableBuilding != null)
        this.tableBuilding.InitVars();
      this.tableCountry = (SystemDataSet.CountryDataTable) base.Tables["Country"];
      if (initTable && this.tableCountry != null)
        this.tableCountry.InitVars();
      this.tableFloor = (SystemDataSet.FloorDataTable) base.Tables["Floor"];
      if (initTable && this.tableFloor != null)
        this.tableFloor.InitVars();
      this.tableGSTHistory = (SystemDataSet.GSTHistoryDataTable) base.Tables["GSTHistory"];
      if (initTable && this.tableGSTHistory != null)
        this.tableGSTHistory.InitVars();
      this.tableGSTHistory1 = (SystemDataSet.GSTHistory1DataTable) base.Tables["GSTHistory1"];
      if (initTable && this.tableGSTHistory1 != null)
        this.tableGSTHistory1.InitVars();
      this.tableGSTHistory2 = (SystemDataSet.GSTHistory2DataTable) base.Tables["GSTHistory2"];
      if (initTable && this.tableGSTHistory2 != null)
        this.tableGSTHistory2.InitVars();
      this.tableGSTHistory3 = (SystemDataSet.GSTHistory3DataTable) base.Tables["GSTHistory3"];
      if (initTable && this.tableGSTHistory3 != null)
        this.tableGSTHistory3.InitVars();
      this.tableGSTHistory4 = (SystemDataSet.GSTHistory4DataTable) base.Tables["GSTHistory4"];
      if (initTable && this.tableGSTHistory4 != null)
        this.tableGSTHistory4.InitVars();
      this.tableGSTHistory5 = (SystemDataSet.GSTHistory5DataTable) base.Tables["GSTHistory5"];
      if (initTable && this.tableGSTHistory5 != null)
        this.tableGSTHistory5.InitVars();
      this.tableGSTHistory6 = (SystemDataSet.GSTHistory6DataTable) base.Tables["GSTHistory6"];
      if (initTable && this.tableGSTHistory6 != null)
        this.tableGSTHistory6.InitVars();
      this.tableRoom = (SystemDataSet.RoomDataTable) base.Tables["Room"];
      if (initTable && this.tableRoom != null)
        this.tableRoom.InitVars();
      this.tableRoomStatus1 = (SystemDataSet.RoomStatus1DataTable) base.Tables["RoomStatus1"];
      if (initTable && this.tableRoomStatus1 != null)
        this.tableRoomStatus1.InitVars();
      this.tableRoomStatus2 = (SystemDataSet.RoomStatus2DataTable) base.Tables["RoomStatus2"];
      if (initTable && this.tableRoomStatus2 != null)
        this.tableRoomStatus2.InitVars();
      this.tableRoomStatus3 = (SystemDataSet.RoomStatus3DataTable) base.Tables["RoomStatus3"];
      if (initTable && this.tableRoomStatus3 != null)
        this.tableRoomStatus3.InitVars();
      this.tableRoomStatus4 = (SystemDataSet.RoomStatus4DataTable) base.Tables["RoomStatus4"];
      if (initTable && this.tableRoomStatus4 != null)
        this.tableRoomStatus4.InitVars();
      this.tableRoomStatus5 = (SystemDataSet.RoomStatus5DataTable) base.Tables["RoomStatus5"];
      if (initTable && this.tableRoomStatus5 != null)
        this.tableRoomStatus5.InitVars();
      this.tableRoomStatus6 = (SystemDataSet.RoomStatus6DataTable) base.Tables["RoomStatus6"];
      if (initTable && this.tableRoomStatus6 != null)
        this.tableRoomStatus6.InitVars();
      this.tableRoomType = (SystemDataSet.RoomTypeDataTable) base.Tables["RoomType"];
      if (initTable && this.tableRoomType != null)
        this.tableRoomType.InitVars();
      this.tableSystemSet1 = (SystemDataSet.SystemSet1DataTable) base.Tables["SystemSet1"];
      if (initTable && this.tableSystemSet1 != null)
        this.tableSystemSet1.InitVars();
      this.tableZone = (SystemDataSet.ZoneDataTable) base.Tables["Zone"];
      if (initTable && this.tableZone != null)
        this.tableZone.InitVars();
      this.tableSystemSet2 = (SystemDataSet.SystemSet2DataTable) base.Tables["SystemSet2"];
      if (initTable && this.tableSystemSet2 != null)
        this.tableSystemSet2.InitVars();
      this.tableSystemSet3 = (SystemDataSet.SystemSet3DataTable) base.Tables["SystemSet3"];
      if (initTable && this.tableSystemSet3 != null)
        this.tableSystemSet3.InitVars();
      this.tableSystemSet4 = (SystemDataSet.SystemSet4DataTable) base.Tables["SystemSet4"];
      if (initTable && this.tableSystemSet4 != null)
        this.tableSystemSet4.InitVars();
      this.tableSystemSet5 = (SystemDataSet.SystemSet5DataTable) base.Tables["SystemSet5"];
      if (initTable && this.tableSystemSet5 != null)
        this.tableSystemSet5.InitVars();
      this.tableSystemSet6 = (SystemDataSet.SystemSet6DataTable) base.Tables["SystemSet6"];
      if (initTable && this.tableSystemSet6 != null)
        this.tableSystemSet6.InitVars();
      this.tableSystemSet = (SystemDataSet.SystemSetDataTable) base.Tables["SystemSet"];
      if (!initTable || this.tableSystemSet == null)
        return;
      this.tableSystemSet.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "SystemDataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/SystemDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableBonus = new SystemDataSet.BonusDataTable();
      base.Tables.Add((DataTable) this.tableBonus);
      this.tableBonus1 = new SystemDataSet.Bonus1DataTable();
      base.Tables.Add((DataTable) this.tableBonus1);
      this.tableBonus2 = new SystemDataSet.Bonus2DataTable();
      base.Tables.Add((DataTable) this.tableBonus2);
      this.tableBonus3 = new SystemDataSet.Bonus3DataTable();
      base.Tables.Add((DataTable) this.tableBonus3);
      this.tableBonus4 = new SystemDataSet.Bonus4DataTable();
      base.Tables.Add((DataTable) this.tableBonus4);
      this.tableBonus5 = new SystemDataSet.Bonus5DataTable();
      base.Tables.Add((DataTable) this.tableBonus5);
      this.tableBonus6 = new SystemDataSet.Bonus6DataTable();
      base.Tables.Add((DataTable) this.tableBonus6);
      this.tableBuilding = new SystemDataSet.BuildingDataTable();
      base.Tables.Add((DataTable) this.tableBuilding);
      this.tableCountry = new SystemDataSet.CountryDataTable();
      base.Tables.Add((DataTable) this.tableCountry);
      this.tableFloor = new SystemDataSet.FloorDataTable();
      base.Tables.Add((DataTable) this.tableFloor);
      this.tableGSTHistory = new SystemDataSet.GSTHistoryDataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory);
      this.tableGSTHistory1 = new SystemDataSet.GSTHistory1DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory1);
      this.tableGSTHistory2 = new SystemDataSet.GSTHistory2DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory2);
      this.tableGSTHistory3 = new SystemDataSet.GSTHistory3DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory3);
      this.tableGSTHistory4 = new SystemDataSet.GSTHistory4DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory4);
      this.tableGSTHistory5 = new SystemDataSet.GSTHistory5DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory5);
      this.tableGSTHistory6 = new SystemDataSet.GSTHistory6DataTable();
      base.Tables.Add((DataTable) this.tableGSTHistory6);
      this.tableRoom = new SystemDataSet.RoomDataTable();
      base.Tables.Add((DataTable) this.tableRoom);
      this.tableRoomStatus1 = new SystemDataSet.RoomStatus1DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus1);
      this.tableRoomStatus2 = new SystemDataSet.RoomStatus2DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus2);
      this.tableRoomStatus3 = new SystemDataSet.RoomStatus3DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus3);
      this.tableRoomStatus4 = new SystemDataSet.RoomStatus4DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus4);
      this.tableRoomStatus5 = new SystemDataSet.RoomStatus5DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus5);
      this.tableRoomStatus6 = new SystemDataSet.RoomStatus6DataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus6);
      this.tableRoomType = new SystemDataSet.RoomTypeDataTable();
      base.Tables.Add((DataTable) this.tableRoomType);
      this.tableSystemSet1 = new SystemDataSet.SystemSet1DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet1);
      this.tableZone = new SystemDataSet.ZoneDataTable();
      base.Tables.Add((DataTable) this.tableZone);
      this.tableSystemSet2 = new SystemDataSet.SystemSet2DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet2);
      this.tableSystemSet3 = new SystemDataSet.SystemSet3DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet3);
      this.tableSystemSet4 = new SystemDataSet.SystemSet4DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet4);
      this.tableSystemSet5 = new SystemDataSet.SystemSet5DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet5);
      this.tableSystemSet6 = new SystemDataSet.SystemSet6DataTable();
      base.Tables.Add((DataTable) this.tableSystemSet6);
      this.tableSystemSet = new SystemDataSet.SystemSetDataTable();
      base.Tables.Add((DataTable) this.tableSystemSet);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus1() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus2() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus3() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus4() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus5() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBonus6() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeBuilding() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeCountry() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeFloor() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory1() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory2() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory3() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory4() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory5() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeGSTHistory6() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoom() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus1() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus2() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus3() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus4() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus5() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus6() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomType() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet1() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeZone() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet2() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet3() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet4() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet5() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet6() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeSystemSet() => false;

    [DebuggerNonUserCode]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      SystemDataSet systemDataSet = new SystemDataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = systemDataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedDataSetSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedDataSetSchema;
    }

    public delegate void BonusRowChangeEventHandler(
      object sender,
      SystemDataSet.BonusRowChangeEvent e);

    public delegate void Bonus1RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus1RowChangeEvent e);

    public delegate void Bonus2RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus2RowChangeEvent e);

    public delegate void Bonus3RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus3RowChangeEvent e);

    public delegate void Bonus4RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus4RowChangeEvent e);

    public delegate void Bonus5RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus5RowChangeEvent e);

    public delegate void Bonus6RowChangeEventHandler(
      object sender,
      SystemDataSet.Bonus6RowChangeEvent e);

    public delegate void BuildingRowChangeEventHandler(
      object sender,
      SystemDataSet.BuildingRowChangeEvent e);

    public delegate void CountryRowChangeEventHandler(
      object sender,
      SystemDataSet.CountryRowChangeEvent e);

    public delegate void FloorRowChangeEventHandler(
      object sender,
      SystemDataSet.FloorRowChangeEvent e);

    public delegate void GSTHistoryRowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistoryRowChangeEvent e);

    public delegate void GSTHistory1RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory1RowChangeEvent e);

    public delegate void GSTHistory2RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory2RowChangeEvent e);

    public delegate void GSTHistory3RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory3RowChangeEvent e);

    public delegate void GSTHistory4RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory4RowChangeEvent e);

    public delegate void GSTHistory5RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory5RowChangeEvent e);

    public delegate void GSTHistory6RowChangeEventHandler(
      object sender,
      SystemDataSet.GSTHistory6RowChangeEvent e);

    public delegate void RoomRowChangeEventHandler(
      object sender,
      SystemDataSet.RoomRowChangeEvent e);

    public delegate void RoomStatus1RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus1RowChangeEvent e);

    public delegate void RoomStatus2RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus2RowChangeEvent e);

    public delegate void RoomStatus3RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus3RowChangeEvent e);

    public delegate void RoomStatus4RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus4RowChangeEvent e);

    public delegate void RoomStatus5RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus5RowChangeEvent e);

    public delegate void RoomStatus6RowChangeEventHandler(
      object sender,
      SystemDataSet.RoomStatus6RowChangeEvent e);

    public delegate void RoomTypeRowChangeEventHandler(
      object sender,
      SystemDataSet.RoomTypeRowChangeEvent e);

    public delegate void SystemSet1RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet1RowChangeEvent e);

    public delegate void ZoneRowChangeEventHandler(
      object sender,
      SystemDataSet.ZoneRowChangeEvent e);

    public delegate void SystemSet2RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet2RowChangeEvent e);

    public delegate void SystemSet3RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet3RowChangeEvent e);

    public delegate void SystemSet4RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet4RowChangeEvent e);

    public delegate void SystemSet5RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet5RowChangeEvent e);

    public delegate void SystemSet6RowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSet6RowChangeEvent e);

    public delegate void SystemSetRowChangeEventHandler(
      object sender,
      SystemDataSet.SystemSetRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class BonusDataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public BonusDataTable()
      {
        this.TableName = "Bonus";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal BonusDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected BonusDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.BonusRow this[int index] => (SystemDataSet.BonusRow) this.Rows[index];

      public event SystemDataSet.BonusRowChangeEventHandler BonusRowChanging;

      public event SystemDataSet.BonusRowChangeEventHandler BonusRowChanged;

      public event SystemDataSet.BonusRowChangeEventHandler BonusRowDeleting;

      public event SystemDataSet.BonusRowChangeEventHandler BonusRowDeleted;

      [DebuggerNonUserCode]
      public void AddBonusRow(SystemDataSet.BonusRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.BonusRow AddBonusRow(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.BonusRow row = (SystemDataSet.BonusRow) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.BonusDataTable bonusDataTable = (SystemDataSet.BonusDataTable) base.Clone();
        bonusDataTable.InitVars();
        return (DataTable) bonusDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.BonusDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.BonusRow NewBonusRow() => (SystemDataSet.BonusRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.BonusRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.BonusRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.BonusRowChanged == null)
          return;
        this.BonusRowChanged((object) this, new SystemDataSet.BonusRowChangeEvent((SystemDataSet.BonusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.BonusRowChanging == null)
          return;
        this.BonusRowChanging((object) this, new SystemDataSet.BonusRowChangeEvent((SystemDataSet.BonusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.BonusRowDeleted == null)
          return;
        this.BonusRowDeleted((object) this, new SystemDataSet.BonusRowChangeEvent((SystemDataSet.BonusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.BonusRowDeleting == null)
          return;
        this.BonusRowDeleting((object) this, new SystemDataSet.BonusRowChangeEvent((SystemDataSet.BonusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonusRow(SystemDataSet.BonusRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (BonusDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class Bonus1DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus1DataTable()
      {
        this.TableName = "Bonus1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus1Row this[int index] => (SystemDataSet.Bonus1Row) this.Rows[index];

      public event SystemDataSet.Bonus1RowChangeEventHandler Bonus1RowChanging;

      public event SystemDataSet.Bonus1RowChangeEventHandler Bonus1RowChanged;

      public event SystemDataSet.Bonus1RowChangeEventHandler Bonus1RowDeleting;

      public event SystemDataSet.Bonus1RowChangeEventHandler Bonus1RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus1Row(SystemDataSet.Bonus1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus1Row AddBonus1Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus1Row row = (SystemDataSet.Bonus1Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus1DataTable bonus1DataTable = (SystemDataSet.Bonus1DataTable) base.Clone();
        bonus1DataTable.InitVars();
        return (DataTable) bonus1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus1DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus1Row NewBonus1Row() => (SystemDataSet.Bonus1Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus1Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus1RowChanged == null)
          return;
        this.Bonus1RowChanged((object) this, new SystemDataSet.Bonus1RowChangeEvent((SystemDataSet.Bonus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus1RowChanging == null)
          return;
        this.Bonus1RowChanging((object) this, new SystemDataSet.Bonus1RowChangeEvent((SystemDataSet.Bonus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus1RowDeleted == null)
          return;
        this.Bonus1RowDeleted((object) this, new SystemDataSet.Bonus1RowChangeEvent((SystemDataSet.Bonus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus1RowDeleting == null)
          return;
        this.Bonus1RowDeleting((object) this, new SystemDataSet.Bonus1RowChangeEvent((SystemDataSet.Bonus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus1Row(SystemDataSet.Bonus1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Bonus2DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus2DataTable()
      {
        this.TableName = "Bonus2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus2DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus2Row this[int index] => (SystemDataSet.Bonus2Row) this.Rows[index];

      public event SystemDataSet.Bonus2RowChangeEventHandler Bonus2RowChanging;

      public event SystemDataSet.Bonus2RowChangeEventHandler Bonus2RowChanged;

      public event SystemDataSet.Bonus2RowChangeEventHandler Bonus2RowDeleting;

      public event SystemDataSet.Bonus2RowChangeEventHandler Bonus2RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus2Row(SystemDataSet.Bonus2Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus2Row AddBonus2Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus2Row row = (SystemDataSet.Bonus2Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus2DataTable bonus2DataTable = (SystemDataSet.Bonus2DataTable) base.Clone();
        bonus2DataTable.InitVars();
        return (DataTable) bonus2DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus2DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus2Row NewBonus2Row() => (SystemDataSet.Bonus2Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus2Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus2Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus2RowChanged == null)
          return;
        this.Bonus2RowChanged((object) this, new SystemDataSet.Bonus2RowChangeEvent((SystemDataSet.Bonus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus2RowChanging == null)
          return;
        this.Bonus2RowChanging((object) this, new SystemDataSet.Bonus2RowChangeEvent((SystemDataSet.Bonus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus2RowDeleted == null)
          return;
        this.Bonus2RowDeleted((object) this, new SystemDataSet.Bonus2RowChangeEvent((SystemDataSet.Bonus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus2RowDeleting == null)
          return;
        this.Bonus2RowDeleting((object) this, new SystemDataSet.Bonus2RowChangeEvent((SystemDataSet.Bonus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus2Row(SystemDataSet.Bonus2Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class Bonus3DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus3DataTable()
      {
        this.TableName = "Bonus3";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus3DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus3DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus3Row this[int index] => (SystemDataSet.Bonus3Row) this.Rows[index];

      public event SystemDataSet.Bonus3RowChangeEventHandler Bonus3RowChanging;

      public event SystemDataSet.Bonus3RowChangeEventHandler Bonus3RowChanged;

      public event SystemDataSet.Bonus3RowChangeEventHandler Bonus3RowDeleting;

      public event SystemDataSet.Bonus3RowChangeEventHandler Bonus3RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus3Row(SystemDataSet.Bonus3Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus3Row AddBonus3Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus3Row row = (SystemDataSet.Bonus3Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus3DataTable bonus3DataTable = (SystemDataSet.Bonus3DataTable) base.Clone();
        bonus3DataTable.InitVars();
        return (DataTable) bonus3DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus3DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus3Row NewBonus3Row() => (SystemDataSet.Bonus3Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus3Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus3Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus3RowChanged == null)
          return;
        this.Bonus3RowChanged((object) this, new SystemDataSet.Bonus3RowChangeEvent((SystemDataSet.Bonus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus3RowChanging == null)
          return;
        this.Bonus3RowChanging((object) this, new SystemDataSet.Bonus3RowChangeEvent((SystemDataSet.Bonus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus3RowDeleted == null)
          return;
        this.Bonus3RowDeleted((object) this, new SystemDataSet.Bonus3RowChangeEvent((SystemDataSet.Bonus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus3RowDeleting == null)
          return;
        this.Bonus3RowDeleting((object) this, new SystemDataSet.Bonus3RowChangeEvent((SystemDataSet.Bonus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus3Row(SystemDataSet.Bonus3Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus3DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Bonus4DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus4DataTable()
      {
        this.TableName = "Bonus4";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus4DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus4DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus4Row this[int index] => (SystemDataSet.Bonus4Row) this.Rows[index];

      public event SystemDataSet.Bonus4RowChangeEventHandler Bonus4RowChanging;

      public event SystemDataSet.Bonus4RowChangeEventHandler Bonus4RowChanged;

      public event SystemDataSet.Bonus4RowChangeEventHandler Bonus4RowDeleting;

      public event SystemDataSet.Bonus4RowChangeEventHandler Bonus4RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus4Row(SystemDataSet.Bonus4Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus4Row AddBonus4Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus4Row row = (SystemDataSet.Bonus4Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus4DataTable bonus4DataTable = (SystemDataSet.Bonus4DataTable) base.Clone();
        bonus4DataTable.InitVars();
        return (DataTable) bonus4DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus4DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus4Row NewBonus4Row() => (SystemDataSet.Bonus4Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus4Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus4Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus4RowChanged == null)
          return;
        this.Bonus4RowChanged((object) this, new SystemDataSet.Bonus4RowChangeEvent((SystemDataSet.Bonus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus4RowChanging == null)
          return;
        this.Bonus4RowChanging((object) this, new SystemDataSet.Bonus4RowChangeEvent((SystemDataSet.Bonus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus4RowDeleted == null)
          return;
        this.Bonus4RowDeleted((object) this, new SystemDataSet.Bonus4RowChangeEvent((SystemDataSet.Bonus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus4RowDeleting == null)
          return;
        this.Bonus4RowDeleting((object) this, new SystemDataSet.Bonus4RowChangeEvent((SystemDataSet.Bonus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus4Row(SystemDataSet.Bonus4Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus4DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Bonus5DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus5DataTable()
      {
        this.TableName = "Bonus5";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus5DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus5DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus5Row this[int index] => (SystemDataSet.Bonus5Row) this.Rows[index];

      public event SystemDataSet.Bonus5RowChangeEventHandler Bonus5RowChanging;

      public event SystemDataSet.Bonus5RowChangeEventHandler Bonus5RowChanged;

      public event SystemDataSet.Bonus5RowChangeEventHandler Bonus5RowDeleting;

      public event SystemDataSet.Bonus5RowChangeEventHandler Bonus5RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus5Row(SystemDataSet.Bonus5Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus5Row AddBonus5Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus5Row row = (SystemDataSet.Bonus5Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus5DataTable bonus5DataTable = (SystemDataSet.Bonus5DataTable) base.Clone();
        bonus5DataTable.InitVars();
        return (DataTable) bonus5DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus5DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus5Row NewBonus5Row() => (SystemDataSet.Bonus5Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus5Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus5Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus5RowChanged == null)
          return;
        this.Bonus5RowChanged((object) this, new SystemDataSet.Bonus5RowChangeEvent((SystemDataSet.Bonus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus5RowChanging == null)
          return;
        this.Bonus5RowChanging((object) this, new SystemDataSet.Bonus5RowChangeEvent((SystemDataSet.Bonus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus5RowDeleted == null)
          return;
        this.Bonus5RowDeleted((object) this, new SystemDataSet.Bonus5RowChangeEvent((SystemDataSet.Bonus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus5RowDeleting == null)
          return;
        this.Bonus5RowDeleting((object) this, new SystemDataSet.Bonus5RowChangeEvent((SystemDataSet.Bonus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus5Row(SystemDataSet.Bonus5Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus5DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Bonus6DataTable : DataTable, IEnumerable
    {
      private DataColumn columnStayType;
      private DataColumn columnStayLength;
      private DataColumn columnBonusType;
      private DataColumn columnBonusLength;
      private DataColumn columnBonusStart;
      private DataColumn columnDateUpdate;
      private DataColumn columnStaff;

      [DebuggerNonUserCode]
      public Bonus6DataTable()
      {
        this.TableName = "Bonus6";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Bonus6DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected Bonus6DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StayTypeColumn => this.columnStayType;

      [DebuggerNonUserCode]
      public DataColumn StayLengthColumn => this.columnStayLength;

      [DebuggerNonUserCode]
      public DataColumn BonusTypeColumn => this.columnBonusType;

      [DebuggerNonUserCode]
      public DataColumn BonusLengthColumn => this.columnBonusLength;

      [DebuggerNonUserCode]
      public DataColumn BonusStartColumn => this.columnBonusStart;

      [DebuggerNonUserCode]
      public DataColumn DateUpdateColumn => this.columnDateUpdate;

      [DebuggerNonUserCode]
      public DataColumn StaffColumn => this.columnStaff;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus6Row this[int index] => (SystemDataSet.Bonus6Row) this.Rows[index];

      public event SystemDataSet.Bonus6RowChangeEventHandler Bonus6RowChanging;

      public event SystemDataSet.Bonus6RowChangeEventHandler Bonus6RowChanged;

      public event SystemDataSet.Bonus6RowChangeEventHandler Bonus6RowDeleting;

      public event SystemDataSet.Bonus6RowChangeEventHandler Bonus6RowDeleted;

      [DebuggerNonUserCode]
      public void AddBonus6Row(SystemDataSet.Bonus6Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus6Row AddBonus6Row(
        string StayType,
        short StayLength,
        string BonusType,
        short BonusLength,
        string BonusStart,
        string DateUpdate,
        string Staff)
      {
        SystemDataSet.Bonus6Row row = (SystemDataSet.Bonus6Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) StayType,
          (object) StayLength,
          (object) BonusType,
          (object) BonusLength,
          (object) BonusStart,
          (object) DateUpdate,
          (object) Staff
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.Bonus6DataTable bonus6DataTable = (SystemDataSet.Bonus6DataTable) base.Clone();
        bonus6DataTable.InitVars();
        return (DataTable) bonus6DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.Bonus6DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStayType = this.Columns["StayType"];
        this.columnStayLength = this.Columns["StayLength"];
        this.columnBonusType = this.Columns["BonusType"];
        this.columnBonusLength = this.Columns["BonusLength"];
        this.columnBonusStart = this.Columns["BonusStart"];
        this.columnDateUpdate = this.Columns["DateUpdate"];
        this.columnStaff = this.Columns["Staff"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStayType = new DataColumn("StayType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayType);
        this.columnStayLength = new DataColumn("StayLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStayLength);
        this.columnBonusType = new DataColumn("BonusType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusType);
        this.columnBonusLength = new DataColumn("BonusLength", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusLength);
        this.columnBonusStart = new DataColumn("BonusStart", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusStart);
        this.columnDateUpdate = new DataColumn("DateUpdate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDateUpdate);
        this.columnStaff = new DataColumn("Staff", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaff);
        this.columnStayType.MaxLength = 1;
        this.columnBonusType.MaxLength = 50;
        this.columnBonusStart.MaxLength = 10;
        this.columnDateUpdate.MaxLength = 10;
        this.columnStaff.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus6Row NewBonus6Row() => (SystemDataSet.Bonus6Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.Bonus6Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.Bonus6Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Bonus6RowChanged == null)
          return;
        this.Bonus6RowChanged((object) this, new SystemDataSet.Bonus6RowChangeEvent((SystemDataSet.Bonus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Bonus6RowChanging == null)
          return;
        this.Bonus6RowChanging((object) this, new SystemDataSet.Bonus6RowChangeEvent((SystemDataSet.Bonus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Bonus6RowDeleted == null)
          return;
        this.Bonus6RowDeleted((object) this, new SystemDataSet.Bonus6RowChangeEvent((SystemDataSet.Bonus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Bonus6RowDeleting == null)
          return;
        this.Bonus6RowDeleting((object) this, new SystemDataSet.Bonus6RowChangeEvent((SystemDataSet.Bonus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBonus6Row(SystemDataSet.Bonus6Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Bonus6DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class BuildingDataTable : DataTable, IEnumerable
    {
      private DataColumn columnBuildingNo;
      private DataColumn columnBldName;
      private DataColumn columnBuildingType;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public BuildingDataTable()
      {
        this.TableName = "Building";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal BuildingDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected BuildingDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn BuildingNoColumn => this.columnBuildingNo;

      [DebuggerNonUserCode]
      public DataColumn BldNameColumn => this.columnBldName;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.BuildingRow this[int index]
      {
        get => (SystemDataSet.BuildingRow) this.Rows[index];
      }

      public event SystemDataSet.BuildingRowChangeEventHandler BuildingRowChanging;

      public event SystemDataSet.BuildingRowChangeEventHandler BuildingRowChanged;

      public event SystemDataSet.BuildingRowChangeEventHandler BuildingRowDeleting;

      public event SystemDataSet.BuildingRowChangeEventHandler BuildingRowDeleted;

      [DebuggerNonUserCode]
      public void AddBuildingRow(SystemDataSet.BuildingRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.BuildingRow AddBuildingRow(
        string BuildingNo,
        string BldName,
        string BuildingType,
        string StaffID,
        bool Update)
      {
        SystemDataSet.BuildingRow row = (SystemDataSet.BuildingRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) BuildingNo,
          (object) BldName,
          (object) BuildingType,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.BuildingDataTable buildingDataTable = (SystemDataSet.BuildingDataTable) base.Clone();
        buildingDataTable.InitVars();
        return (DataTable) buildingDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.BuildingDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnBuildingNo = this.Columns["BuildingNo"];
        this.columnBldName = this.Columns["BldName"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingNo);
        this.columnBldName = new DataColumn("BldName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBldName);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnBuildingNo.MaxLength = 2;
        this.columnBldName.MaxLength = 20;
        this.columnBuildingType.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.BuildingRow NewBuildingRow()
      {
        return (SystemDataSet.BuildingRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.BuildingRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.BuildingRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.BuildingRowChanged == null)
          return;
        this.BuildingRowChanged((object) this, new SystemDataSet.BuildingRowChangeEvent((SystemDataSet.BuildingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.BuildingRowChanging == null)
          return;
        this.BuildingRowChanging((object) this, new SystemDataSet.BuildingRowChangeEvent((SystemDataSet.BuildingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.BuildingRowDeleted == null)
          return;
        this.BuildingRowDeleted((object) this, new SystemDataSet.BuildingRowChangeEvent((SystemDataSet.BuildingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.BuildingRowDeleting == null)
          return;
        this.BuildingRowDeleting((object) this, new SystemDataSet.BuildingRowChangeEvent((SystemDataSet.BuildingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBuildingRow(SystemDataSet.BuildingRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (BuildingDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class CountryDataTable : DataTable, IEnumerable
    {
      private DataColumn columnCountryID;
      private DataColumn columnCountryDesc;

      [DebuggerNonUserCode]
      public CountryDataTable()
      {
        this.TableName = "Country";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal CountryDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected CountryDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn CountryIDColumn => this.columnCountryID;

      [DebuggerNonUserCode]
      public DataColumn CountryDescColumn => this.columnCountryDesc;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.CountryRow this[int index]
      {
        get => (SystemDataSet.CountryRow) this.Rows[index];
      }

      public event SystemDataSet.CountryRowChangeEventHandler CountryRowChanging;

      public event SystemDataSet.CountryRowChangeEventHandler CountryRowChanged;

      public event SystemDataSet.CountryRowChangeEventHandler CountryRowDeleting;

      public event SystemDataSet.CountryRowChangeEventHandler CountryRowDeleted;

      [DebuggerNonUserCode]
      public void AddCountryRow(SystemDataSet.CountryRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.CountryRow AddCountryRow(string CountryDesc)
      {
        SystemDataSet.CountryRow row = (SystemDataSet.CountryRow) this.NewRow();
        object[] objArray = new object[2]
        {
          null,
          (object) CountryDesc
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.CountryRow FindByCountryID(int CountryID)
      {
        return (SystemDataSet.CountryRow) this.Rows.Find(new object[1]
        {
          (object) CountryID
        });
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.CountryDataTable countryDataTable = (SystemDataSet.CountryDataTable) base.Clone();
        countryDataTable.InitVars();
        return (DataTable) countryDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.CountryDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnCountryID = this.Columns["CountryID"];
        this.columnCountryDesc = this.Columns["CountryDesc"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnCountryID = new DataColumn("CountryID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCountryID);
        this.columnCountryDesc = new DataColumn("CountryDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCountryDesc);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnCountryID
        }, true));
        this.columnCountryID.AutoIncrement = true;
        this.columnCountryID.AutoIncrementSeed = -1L;
        this.columnCountryID.AutoIncrementStep = -1L;
        this.columnCountryID.AllowDBNull = false;
        this.columnCountryID.Unique = true;
        this.columnCountryDesc.MaxLength = 20;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.CountryRow NewCountryRow() => (SystemDataSet.CountryRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.CountryRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.CountryRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CountryRowChanged == null)
          return;
        this.CountryRowChanged((object) this, new SystemDataSet.CountryRowChangeEvent((SystemDataSet.CountryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CountryRowChanging == null)
          return;
        this.CountryRowChanging((object) this, new SystemDataSet.CountryRowChangeEvent((SystemDataSet.CountryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CountryRowDeleted == null)
          return;
        this.CountryRowDeleted((object) this, new SystemDataSet.CountryRowChangeEvent((SystemDataSet.CountryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CountryRowDeleting == null)
          return;
        this.CountryRowDeleting((object) this, new SystemDataSet.CountryRowChangeEvent((SystemDataSet.CountryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveCountryRow(SystemDataSet.CountryRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CountryDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class FloorDataTable : DataTable, IEnumerable
    {
      private DataColumn columnFloorNo;
      private DataColumn columnBuildingNo;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public FloorDataTable()
      {
        this.TableName = "Floor";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal FloorDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected FloorDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn FloorNoColumn => this.columnFloorNo;

      [DebuggerNonUserCode]
      public DataColumn BuildingNoColumn => this.columnBuildingNo;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.FloorRow this[int index] => (SystemDataSet.FloorRow) this.Rows[index];

      public event SystemDataSet.FloorRowChangeEventHandler FloorRowChanging;

      public event SystemDataSet.FloorRowChangeEventHandler FloorRowChanged;

      public event SystemDataSet.FloorRowChangeEventHandler FloorRowDeleting;

      public event SystemDataSet.FloorRowChangeEventHandler FloorRowDeleted;

      [DebuggerNonUserCode]
      public void AddFloorRow(SystemDataSet.FloorRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.FloorRow AddFloorRow(
        string FloorNo,
        string BuildingNo,
        string StaffID,
        bool Update)
      {
        SystemDataSet.FloorRow row = (SystemDataSet.FloorRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) FloorNo,
          (object) BuildingNo,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.FloorDataTable floorDataTable = (SystemDataSet.FloorDataTable) base.Clone();
        floorDataTable.InitVars();
        return (DataTable) floorDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.FloorDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnFloorNo = this.Columns["FloorNo"];
        this.columnBuildingNo = this.Columns["BuildingNo"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnFloorNo = new DataColumn("FloorNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFloorNo);
        this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingNo);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnFloorNo.MaxLength = 2;
        this.columnBuildingNo.MaxLength = 2;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.FloorRow NewFloorRow() => (SystemDataSet.FloorRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.FloorRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.FloorRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.FloorRowChanged == null)
          return;
        this.FloorRowChanged((object) this, new SystemDataSet.FloorRowChangeEvent((SystemDataSet.FloorRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.FloorRowChanging == null)
          return;
        this.FloorRowChanging((object) this, new SystemDataSet.FloorRowChangeEvent((SystemDataSet.FloorRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.FloorRowDeleted == null)
          return;
        this.FloorRowDeleted((object) this, new SystemDataSet.FloorRowChangeEvent((SystemDataSet.FloorRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.FloorRowDeleting == null)
          return;
        this.FloorRowDeleting((object) this, new SystemDataSet.FloorRowChangeEvent((SystemDataSet.FloorRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveFloorRow(SystemDataSet.FloorRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (FloorDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class GSTHistoryDataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistoryDataTable()
      {
        this.TableName = "GSTHistory";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistoryDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistoryDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistoryRow this[int index]
      {
        get => (SystemDataSet.GSTHistoryRow) this.Rows[index];
      }

      public event SystemDataSet.GSTHistoryRowChangeEventHandler GSTHistoryRowChanging;

      public event SystemDataSet.GSTHistoryRowChangeEventHandler GSTHistoryRowChanged;

      public event SystemDataSet.GSTHistoryRowChangeEventHandler GSTHistoryRowDeleting;

      public event SystemDataSet.GSTHistoryRowChangeEventHandler GSTHistoryRowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistoryRow(SystemDataSet.GSTHistoryRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistoryRow AddGSTHistoryRow(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistoryRow row = (SystemDataSet.GSTHistoryRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistoryDataTable historyDataTable = (SystemDataSet.GSTHistoryDataTable) base.Clone();
        historyDataTable.InitVars();
        return (DataTable) historyDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistoryDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistoryRow NewGSTHistoryRow()
      {
        return (SystemDataSet.GSTHistoryRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistoryRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistoryRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistoryRowChanged == null)
          return;
        this.GSTHistoryRowChanged((object) this, new SystemDataSet.GSTHistoryRowChangeEvent((SystemDataSet.GSTHistoryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistoryRowChanging == null)
          return;
        this.GSTHistoryRowChanging((object) this, new SystemDataSet.GSTHistoryRowChangeEvent((SystemDataSet.GSTHistoryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistoryRowDeleted == null)
          return;
        this.GSTHistoryRowDeleted((object) this, new SystemDataSet.GSTHistoryRowChangeEvent((SystemDataSet.GSTHistoryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistoryRowDeleting == null)
          return;
        this.GSTHistoryRowDeleting((object) this, new SystemDataSet.GSTHistoryRowChangeEvent((SystemDataSet.GSTHistoryRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistoryRow(SystemDataSet.GSTHistoryRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistoryDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GSTHistory1DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory1DataTable()
      {
        this.TableName = "GSTHistory1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory1Row this[int index]
      {
        get => (SystemDataSet.GSTHistory1Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory1RowChangeEventHandler GSTHistory1RowChanging;

      public event SystemDataSet.GSTHistory1RowChangeEventHandler GSTHistory1RowChanged;

      public event SystemDataSet.GSTHistory1RowChangeEventHandler GSTHistory1RowDeleting;

      public event SystemDataSet.GSTHistory1RowChangeEventHandler GSTHistory1RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory1Row(SystemDataSet.GSTHistory1Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory1Row AddGSTHistory1Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory1Row row = (SystemDataSet.GSTHistory1Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory1DataTable history1DataTable = (SystemDataSet.GSTHistory1DataTable) base.Clone();
        history1DataTable.InitVars();
        return (DataTable) history1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory1DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory1Row NewGSTHistory1Row()
      {
        return (SystemDataSet.GSTHistory1Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory1Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory1RowChanged == null)
          return;
        this.GSTHistory1RowChanged((object) this, new SystemDataSet.GSTHistory1RowChangeEvent((SystemDataSet.GSTHistory1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory1RowChanging == null)
          return;
        this.GSTHistory1RowChanging((object) this, new SystemDataSet.GSTHistory1RowChangeEvent((SystemDataSet.GSTHistory1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory1RowDeleted == null)
          return;
        this.GSTHistory1RowDeleted((object) this, new SystemDataSet.GSTHistory1RowChangeEvent((SystemDataSet.GSTHistory1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory1RowDeleting == null)
          return;
        this.GSTHistory1RowDeleting((object) this, new SystemDataSet.GSTHistory1RowChangeEvent((SystemDataSet.GSTHistory1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory1Row(SystemDataSet.GSTHistory1Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GSTHistory2DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory2DataTable()
      {
        this.TableName = "GSTHistory2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory2DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory2Row this[int index]
      {
        get => (SystemDataSet.GSTHistory2Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory2RowChangeEventHandler GSTHistory2RowChanging;

      public event SystemDataSet.GSTHistory2RowChangeEventHandler GSTHistory2RowChanged;

      public event SystemDataSet.GSTHistory2RowChangeEventHandler GSTHistory2RowDeleting;

      public event SystemDataSet.GSTHistory2RowChangeEventHandler GSTHistory2RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory2Row(SystemDataSet.GSTHistory2Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory2Row AddGSTHistory2Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory2Row row = (SystemDataSet.GSTHistory2Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory2DataTable history2DataTable = (SystemDataSet.GSTHistory2DataTable) base.Clone();
        history2DataTable.InitVars();
        return (DataTable) history2DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory2DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory2Row NewGSTHistory2Row()
      {
        return (SystemDataSet.GSTHistory2Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory2Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory2Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory2RowChanged == null)
          return;
        this.GSTHistory2RowChanged((object) this, new SystemDataSet.GSTHistory2RowChangeEvent((SystemDataSet.GSTHistory2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory2RowChanging == null)
          return;
        this.GSTHistory2RowChanging((object) this, new SystemDataSet.GSTHistory2RowChangeEvent((SystemDataSet.GSTHistory2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory2RowDeleted == null)
          return;
        this.GSTHistory2RowDeleted((object) this, new SystemDataSet.GSTHistory2RowChangeEvent((SystemDataSet.GSTHistory2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory2RowDeleting == null)
          return;
        this.GSTHistory2RowDeleting((object) this, new SystemDataSet.GSTHistory2RowChangeEvent((SystemDataSet.GSTHistory2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory2Row(SystemDataSet.GSTHistory2Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GSTHistory3DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory3DataTable()
      {
        this.TableName = "GSTHistory3";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory3DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory3DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory3Row this[int index]
      {
        get => (SystemDataSet.GSTHistory3Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory3RowChangeEventHandler GSTHistory3RowChanging;

      public event SystemDataSet.GSTHistory3RowChangeEventHandler GSTHistory3RowChanged;

      public event SystemDataSet.GSTHistory3RowChangeEventHandler GSTHistory3RowDeleting;

      public event SystemDataSet.GSTHistory3RowChangeEventHandler GSTHistory3RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory3Row(SystemDataSet.GSTHistory3Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory3Row AddGSTHistory3Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory3Row row = (SystemDataSet.GSTHistory3Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory3DataTable history3DataTable = (SystemDataSet.GSTHistory3DataTable) base.Clone();
        history3DataTable.InitVars();
        return (DataTable) history3DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory3DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory3Row NewGSTHistory3Row()
      {
        return (SystemDataSet.GSTHistory3Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory3Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory3Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory3RowChanged == null)
          return;
        this.GSTHistory3RowChanged((object) this, new SystemDataSet.GSTHistory3RowChangeEvent((SystemDataSet.GSTHistory3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory3RowChanging == null)
          return;
        this.GSTHistory3RowChanging((object) this, new SystemDataSet.GSTHistory3RowChangeEvent((SystemDataSet.GSTHistory3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory3RowDeleted == null)
          return;
        this.GSTHistory3RowDeleted((object) this, new SystemDataSet.GSTHistory3RowChangeEvent((SystemDataSet.GSTHistory3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory3RowDeleting == null)
          return;
        this.GSTHistory3RowDeleting((object) this, new SystemDataSet.GSTHistory3RowChangeEvent((SystemDataSet.GSTHistory3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory3Row(SystemDataSet.GSTHistory3Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory3DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class GSTHistory4DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory4DataTable()
      {
        this.TableName = "GSTHistory4";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory4DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory4DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory4Row this[int index]
      {
        get => (SystemDataSet.GSTHistory4Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory4RowChangeEventHandler GSTHistory4RowChanging;

      public event SystemDataSet.GSTHistory4RowChangeEventHandler GSTHistory4RowChanged;

      public event SystemDataSet.GSTHistory4RowChangeEventHandler GSTHistory4RowDeleting;

      public event SystemDataSet.GSTHistory4RowChangeEventHandler GSTHistory4RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory4Row(SystemDataSet.GSTHistory4Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory4Row AddGSTHistory4Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory4Row row = (SystemDataSet.GSTHistory4Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory4DataTable history4DataTable = (SystemDataSet.GSTHistory4DataTable) base.Clone();
        history4DataTable.InitVars();
        return (DataTable) history4DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory4DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory4Row NewGSTHistory4Row()
      {
        return (SystemDataSet.GSTHistory4Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory4Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory4Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory4RowChanged == null)
          return;
        this.GSTHistory4RowChanged((object) this, new SystemDataSet.GSTHistory4RowChangeEvent((SystemDataSet.GSTHistory4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory4RowChanging == null)
          return;
        this.GSTHistory4RowChanging((object) this, new SystemDataSet.GSTHistory4RowChangeEvent((SystemDataSet.GSTHistory4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory4RowDeleted == null)
          return;
        this.GSTHistory4RowDeleted((object) this, new SystemDataSet.GSTHistory4RowChangeEvent((SystemDataSet.GSTHistory4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory4RowDeleting == null)
          return;
        this.GSTHistory4RowDeleting((object) this, new SystemDataSet.GSTHistory4RowChangeEvent((SystemDataSet.GSTHistory4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory4Row(SystemDataSet.GSTHistory4Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory4DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GSTHistory5DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory5DataTable()
      {
        this.TableName = "GSTHistory5";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory5DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory5DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory5Row this[int index]
      {
        get => (SystemDataSet.GSTHistory5Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory5RowChangeEventHandler GSTHistory5RowChanging;

      public event SystemDataSet.GSTHistory5RowChangeEventHandler GSTHistory5RowChanged;

      public event SystemDataSet.GSTHistory5RowChangeEventHandler GSTHistory5RowDeleting;

      public event SystemDataSet.GSTHistory5RowChangeEventHandler GSTHistory5RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory5Row(SystemDataSet.GSTHistory5Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory5Row AddGSTHistory5Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory5Row row = (SystemDataSet.GSTHistory5Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory5DataTable history5DataTable = (SystemDataSet.GSTHistory5DataTable) base.Clone();
        history5DataTable.InitVars();
        return (DataTable) history5DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory5DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory5Row NewGSTHistory5Row()
      {
        return (SystemDataSet.GSTHistory5Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory5Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory5Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory5RowChanged == null)
          return;
        this.GSTHistory5RowChanged((object) this, new SystemDataSet.GSTHistory5RowChangeEvent((SystemDataSet.GSTHistory5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory5RowChanging == null)
          return;
        this.GSTHistory5RowChanging((object) this, new SystemDataSet.GSTHistory5RowChangeEvent((SystemDataSet.GSTHistory5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory5RowDeleted == null)
          return;
        this.GSTHistory5RowDeleted((object) this, new SystemDataSet.GSTHistory5RowChangeEvent((SystemDataSet.GSTHistory5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory5RowDeleting == null)
          return;
        this.GSTHistory5RowDeleting((object) this, new SystemDataSet.GSTHistory5RowChangeEvent((SystemDataSet.GSTHistory5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory5Row(SystemDataSet.GSTHistory5Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory5DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GSTHistory6DataTable : DataTable, IEnumerable
    {
      private DataColumn columnGSTRate;
      private DataColumn columnUpdateDate;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public GSTHistory6DataTable()
      {
        this.TableName = "GSTHistory6";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GSTHistory6DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected GSTHistory6DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn UpdateDateColumn => this.columnUpdateDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory6Row this[int index]
      {
        get => (SystemDataSet.GSTHistory6Row) this.Rows[index];
      }

      public event SystemDataSet.GSTHistory6RowChangeEventHandler GSTHistory6RowChanging;

      public event SystemDataSet.GSTHistory6RowChangeEventHandler GSTHistory6RowChanged;

      public event SystemDataSet.GSTHistory6RowChangeEventHandler GSTHistory6RowDeleting;

      public event SystemDataSet.GSTHistory6RowChangeEventHandler GSTHistory6RowDeleted;

      [DebuggerNonUserCode]
      public void AddGSTHistory6Row(SystemDataSet.GSTHistory6Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory6Row AddGSTHistory6Row(
        double GSTRate,
        DateTime UpdateDate,
        string StaffID)
      {
        SystemDataSet.GSTHistory6Row row = (SystemDataSet.GSTHistory6Row) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) GSTRate,
          (object) UpdateDate,
          (object) StaffID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.GSTHistory6DataTable history6DataTable = (SystemDataSet.GSTHistory6DataTable) base.Clone();
        history6DataTable.InitVars();
        return (DataTable) history6DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.GSTHistory6DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnUpdateDate = this.Columns["UpdateDate"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnUpdateDate = new DataColumn("UpdateDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdateDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory6Row NewGSTHistory6Row()
      {
        return (SystemDataSet.GSTHistory6Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.GSTHistory6Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.GSTHistory6Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GSTHistory6RowChanged == null)
          return;
        this.GSTHistory6RowChanged((object) this, new SystemDataSet.GSTHistory6RowChangeEvent((SystemDataSet.GSTHistory6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GSTHistory6RowChanging == null)
          return;
        this.GSTHistory6RowChanging((object) this, new SystemDataSet.GSTHistory6RowChangeEvent((SystemDataSet.GSTHistory6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GSTHistory6RowDeleted == null)
          return;
        this.GSTHistory6RowDeleted((object) this, new SystemDataSet.GSTHistory6RowChangeEvent((SystemDataSet.GSTHistory6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GSTHistory6RowDeleting == null)
          return;
        this.GSTHistory6RowDeleting((object) this, new SystemDataSet.GSTHistory6RowChangeEvent((SystemDataSet.GSTHistory6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGSTHistory6Row(SystemDataSet.GSTHistory6Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (GSTHistory6DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class RoomDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnRoomID;
      private DataColumn columnRoomType;
      private DataColumn columnFloorNo;
      private DataColumn columnBuildingNo;
      private DataColumn columnDailyRate;
      private DataColumn columnWeeklyRate;
      private DataColumn columnMonthlyRate;
      private DataColumn columnDailyRate2;
      private DataColumn columnWeeklyRate2;
      private DataColumn columnMonthlyRate2;
      private DataColumn columnIssuedCard;
      private DataColumn columnTotalStay;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomDataTable()
      {
        this.TableName = "Room";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn RoomIDColumn => this.columnRoomID;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn FloorNoColumn => this.columnFloorNo;

      [DebuggerNonUserCode]
      public DataColumn BuildingNoColumn => this.columnBuildingNo;

      [DebuggerNonUserCode]
      public DataColumn DailyRateColumn => this.columnDailyRate;

      [DebuggerNonUserCode]
      public DataColumn WeeklyRateColumn => this.columnWeeklyRate;

      [DebuggerNonUserCode]
      public DataColumn MonthlyRateColumn => this.columnMonthlyRate;

      [DebuggerNonUserCode]
      public DataColumn DailyRate2Column => this.columnDailyRate2;

      [DebuggerNonUserCode]
      public DataColumn WeeklyRate2Column => this.columnWeeklyRate2;

      [DebuggerNonUserCode]
      public DataColumn MonthlyRate2Column => this.columnMonthlyRate2;

      [DebuggerNonUserCode]
      public DataColumn IssuedCardColumn => this.columnIssuedCard;

      [DebuggerNonUserCode]
      public DataColumn TotalStayColumn => this.columnTotalStay;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomRow this[int index] => (SystemDataSet.RoomRow) this.Rows[index];

      public event SystemDataSet.RoomRowChangeEventHandler RoomRowChanging;

      public event SystemDataSet.RoomRowChangeEventHandler RoomRowChanged;

      public event SystemDataSet.RoomRowChangeEventHandler RoomRowDeleting;

      public event SystemDataSet.RoomRowChangeEventHandler RoomRowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomRow(SystemDataSet.RoomRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.RoomRow AddRoomRow(
        string RoomNo,
        string RoomID,
        byte RoomType,
        string FloorNo,
        string BuildingNo,
        Decimal DailyRate,
        Decimal WeeklyRate,
        Decimal MonthlyRate,
        Decimal DailyRate2,
        Decimal WeeklyRate2,
        Decimal MonthlyRate2,
        short IssuedCard,
        byte TotalStay,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomRow row = (SystemDataSet.RoomRow) this.NewRow();
        object[] objArray = new object[15]
        {
          (object) RoomNo,
          (object) RoomID,
          (object) RoomType,
          (object) FloorNo,
          (object) BuildingNo,
          (object) DailyRate,
          (object) WeeklyRate,
          (object) MonthlyRate,
          (object) DailyRate2,
          (object) WeeklyRate2,
          (object) MonthlyRate2,
          (object) IssuedCard,
          (object) TotalStay,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomDataTable roomDataTable = (SystemDataSet.RoomDataTable) base.Clone();
        roomDataTable.InitVars();
        return (DataTable) roomDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnRoomID = this.Columns["RoomID"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnFloorNo = this.Columns["FloorNo"];
        this.columnBuildingNo = this.Columns["BuildingNo"];
        this.columnDailyRate = this.Columns["DailyRate"];
        this.columnWeeklyRate = this.Columns["WeeklyRate"];
        this.columnMonthlyRate = this.Columns["MonthlyRate"];
        this.columnDailyRate2 = this.Columns["DailyRate2"];
        this.columnWeeklyRate2 = this.Columns["WeeklyRate2"];
        this.columnMonthlyRate2 = this.Columns["MonthlyRate2"];
        this.columnIssuedCard = this.Columns["IssuedCard"];
        this.columnTotalStay = this.Columns["TotalStay"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnRoomID = new DataColumn("RoomID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomID);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnFloorNo = new DataColumn("FloorNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFloorNo);
        this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingNo);
        this.columnDailyRate = new DataColumn("DailyRate", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDailyRate);
        this.columnWeeklyRate = new DataColumn("WeeklyRate", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWeeklyRate);
        this.columnMonthlyRate = new DataColumn("MonthlyRate", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMonthlyRate);
        this.columnDailyRate2 = new DataColumn("DailyRate2", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDailyRate2);
        this.columnWeeklyRate2 = new DataColumn("WeeklyRate2", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWeeklyRate2);
        this.columnMonthlyRate2 = new DataColumn("MonthlyRate2", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMonthlyRate2);
        this.columnIssuedCard = new DataColumn("IssuedCard", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIssuedCard);
        this.columnTotalStay = new DataColumn("TotalStay", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTotalStay);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnRoomNo
        }, false));
        this.columnRoomNo.Unique = true;
        this.columnRoomNo.MaxLength = 5;
        this.columnRoomID.MaxLength = 2;
        this.columnFloorNo.MaxLength = 2;
        this.columnBuildingNo.MaxLength = 2;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomRow NewRoomRow() => (SystemDataSet.RoomRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomRowChanged == null)
          return;
        this.RoomRowChanged((object) this, new SystemDataSet.RoomRowChangeEvent((SystemDataSet.RoomRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomRowChanging == null)
          return;
        this.RoomRowChanging((object) this, new SystemDataSet.RoomRowChangeEvent((SystemDataSet.RoomRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomRowDeleted == null)
          return;
        this.RoomRowDeleted((object) this, new SystemDataSet.RoomRowChangeEvent((SystemDataSet.RoomRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomRowDeleting == null)
          return;
        this.RoomRowDeleting((object) this, new SystemDataSet.RoomRowChangeEvent((SystemDataSet.RoomRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomRow(SystemDataSet.RoomRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomStatus1DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus1DataTable()
      {
        this.TableName = "RoomStatus1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus1Row this[int index]
      {
        get => (SystemDataSet.RoomStatus1Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus1RowChangeEventHandler RoomStatus1RowChanging;

      public event SystemDataSet.RoomStatus1RowChangeEventHandler RoomStatus1RowChanged;

      public event SystemDataSet.RoomStatus1RowChangeEventHandler RoomStatus1RowDeleting;

      public event SystemDataSet.RoomStatus1RowChangeEventHandler RoomStatus1RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus1Row(SystemDataSet.RoomStatus1Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus1Row AddRoomStatus1Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus1Row row = (SystemDataSet.RoomStatus1Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus1DataTable status1DataTable = (SystemDataSet.RoomStatus1DataTable) base.Clone();
        status1DataTable.InitVars();
        return (DataTable) status1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus1DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus1Row NewRoomStatus1Row()
      {
        return (SystemDataSet.RoomStatus1Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus1Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus1RowChanged == null)
          return;
        this.RoomStatus1RowChanged((object) this, new SystemDataSet.RoomStatus1RowChangeEvent((SystemDataSet.RoomStatus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus1RowChanging == null)
          return;
        this.RoomStatus1RowChanging((object) this, new SystemDataSet.RoomStatus1RowChangeEvent((SystemDataSet.RoomStatus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus1RowDeleted == null)
          return;
        this.RoomStatus1RowDeleted((object) this, new SystemDataSet.RoomStatus1RowChangeEvent((SystemDataSet.RoomStatus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus1RowDeleting == null)
          return;
        this.RoomStatus1RowDeleting((object) this, new SystemDataSet.RoomStatus1RowChangeEvent((SystemDataSet.RoomStatus1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus1Row(SystemDataSet.RoomStatus1Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomStatus2DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus2DataTable()
      {
        this.TableName = "RoomStatus2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus2DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus2Row this[int index]
      {
        get => (SystemDataSet.RoomStatus2Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus2RowChangeEventHandler RoomStatus2RowChanging;

      public event SystemDataSet.RoomStatus2RowChangeEventHandler RoomStatus2RowChanged;

      public event SystemDataSet.RoomStatus2RowChangeEventHandler RoomStatus2RowDeleting;

      public event SystemDataSet.RoomStatus2RowChangeEventHandler RoomStatus2RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus2Row(SystemDataSet.RoomStatus2Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus2Row AddRoomStatus2Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus2Row row = (SystemDataSet.RoomStatus2Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus2DataTable status2DataTable = (SystemDataSet.RoomStatus2DataTable) base.Clone();
        status2DataTable.InitVars();
        return (DataTable) status2DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus2DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus2Row NewRoomStatus2Row()
      {
        return (SystemDataSet.RoomStatus2Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus2Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus2Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus2RowChanged == null)
          return;
        this.RoomStatus2RowChanged((object) this, new SystemDataSet.RoomStatus2RowChangeEvent((SystemDataSet.RoomStatus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus2RowChanging == null)
          return;
        this.RoomStatus2RowChanging((object) this, new SystemDataSet.RoomStatus2RowChangeEvent((SystemDataSet.RoomStatus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus2RowDeleted == null)
          return;
        this.RoomStatus2RowDeleted((object) this, new SystemDataSet.RoomStatus2RowChangeEvent((SystemDataSet.RoomStatus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus2RowDeleting == null)
          return;
        this.RoomStatus2RowDeleting((object) this, new SystemDataSet.RoomStatus2RowChangeEvent((SystemDataSet.RoomStatus2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus2Row(SystemDataSet.RoomStatus2Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomStatus3DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus3DataTable()
      {
        this.TableName = "RoomStatus3";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus3DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus3DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus3Row this[int index]
      {
        get => (SystemDataSet.RoomStatus3Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus3RowChangeEventHandler RoomStatus3RowChanging;

      public event SystemDataSet.RoomStatus3RowChangeEventHandler RoomStatus3RowChanged;

      public event SystemDataSet.RoomStatus3RowChangeEventHandler RoomStatus3RowDeleting;

      public event SystemDataSet.RoomStatus3RowChangeEventHandler RoomStatus3RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus3Row(SystemDataSet.RoomStatus3Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus3Row AddRoomStatus3Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus3Row row = (SystemDataSet.RoomStatus3Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus3DataTable status3DataTable = (SystemDataSet.RoomStatus3DataTable) base.Clone();
        status3DataTable.InitVars();
        return (DataTable) status3DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus3DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus3Row NewRoomStatus3Row()
      {
        return (SystemDataSet.RoomStatus3Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus3Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus3Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus3RowChanged == null)
          return;
        this.RoomStatus3RowChanged((object) this, new SystemDataSet.RoomStatus3RowChangeEvent((SystemDataSet.RoomStatus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus3RowChanging == null)
          return;
        this.RoomStatus3RowChanging((object) this, new SystemDataSet.RoomStatus3RowChangeEvent((SystemDataSet.RoomStatus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus3RowDeleted == null)
          return;
        this.RoomStatus3RowDeleted((object) this, new SystemDataSet.RoomStatus3RowChangeEvent((SystemDataSet.RoomStatus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus3RowDeleting == null)
          return;
        this.RoomStatus3RowDeleting((object) this, new SystemDataSet.RoomStatus3RowChangeEvent((SystemDataSet.RoomStatus3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus3Row(SystemDataSet.RoomStatus3Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus3DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomStatus4DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus4DataTable()
      {
        this.TableName = "RoomStatus4";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus4DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus4DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus4Row this[int index]
      {
        get => (SystemDataSet.RoomStatus4Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus4RowChangeEventHandler RoomStatus4RowChanging;

      public event SystemDataSet.RoomStatus4RowChangeEventHandler RoomStatus4RowChanged;

      public event SystemDataSet.RoomStatus4RowChangeEventHandler RoomStatus4RowDeleting;

      public event SystemDataSet.RoomStatus4RowChangeEventHandler RoomStatus4RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus4Row(SystemDataSet.RoomStatus4Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus4Row AddRoomStatus4Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus4Row row = (SystemDataSet.RoomStatus4Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus4DataTable status4DataTable = (SystemDataSet.RoomStatus4DataTable) base.Clone();
        status4DataTable.InitVars();
        return (DataTable) status4DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus4DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus4Row NewRoomStatus4Row()
      {
        return (SystemDataSet.RoomStatus4Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus4Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus4Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus4RowChanged == null)
          return;
        this.RoomStatus4RowChanged((object) this, new SystemDataSet.RoomStatus4RowChangeEvent((SystemDataSet.RoomStatus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus4RowChanging == null)
          return;
        this.RoomStatus4RowChanging((object) this, new SystemDataSet.RoomStatus4RowChangeEvent((SystemDataSet.RoomStatus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus4RowDeleted == null)
          return;
        this.RoomStatus4RowDeleted((object) this, new SystemDataSet.RoomStatus4RowChangeEvent((SystemDataSet.RoomStatus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus4RowDeleting == null)
          return;
        this.RoomStatus4RowDeleting((object) this, new SystemDataSet.RoomStatus4RowChangeEvent((SystemDataSet.RoomStatus4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus4Row(SystemDataSet.RoomStatus4Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus4DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class RoomStatus5DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus5DataTable()
      {
        this.TableName = "RoomStatus5";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus5DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus5DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus5Row this[int index]
      {
        get => (SystemDataSet.RoomStatus5Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus5RowChangeEventHandler RoomStatus5RowChanging;

      public event SystemDataSet.RoomStatus5RowChangeEventHandler RoomStatus5RowChanged;

      public event SystemDataSet.RoomStatus5RowChangeEventHandler RoomStatus5RowDeleting;

      public event SystemDataSet.RoomStatus5RowChangeEventHandler RoomStatus5RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus5Row(SystemDataSet.RoomStatus5Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus5Row AddRoomStatus5Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus5Row row = (SystemDataSet.RoomStatus5Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus5DataTable status5DataTable = (SystemDataSet.RoomStatus5DataTable) base.Clone();
        status5DataTable.InitVars();
        return (DataTable) status5DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus5DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus5Row NewRoomStatus5Row()
      {
        return (SystemDataSet.RoomStatus5Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus5Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus5Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus5RowChanged == null)
          return;
        this.RoomStatus5RowChanged((object) this, new SystemDataSet.RoomStatus5RowChangeEvent((SystemDataSet.RoomStatus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus5RowChanging == null)
          return;
        this.RoomStatus5RowChanging((object) this, new SystemDataSet.RoomStatus5RowChangeEvent((SystemDataSet.RoomStatus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus5RowDeleted == null)
          return;
        this.RoomStatus5RowDeleted((object) this, new SystemDataSet.RoomStatus5RowChangeEvent((SystemDataSet.RoomStatus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus5RowDeleting == null)
          return;
        this.RoomStatus5RowDeleting((object) this, new SystemDataSet.RoomStatus5RowChangeEvent((SystemDataSet.RoomStatus5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus5Row(SystemDataSet.RoomStatus5Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus5DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomStatus6DataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnStatus;
      private DataColumn columnDescription;
      private DataColumn columnRoomType;
      private DataColumn columnClientID;
      private DataColumn columnCondition;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomStatus6DataTable()
      {
        this.TableName = "RoomStatus6";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatus6DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomStatus6DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn StatusColumn => this.columnStatus;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus6Row this[int index]
      {
        get => (SystemDataSet.RoomStatus6Row) this.Rows[index];
      }

      public event SystemDataSet.RoomStatus6RowChangeEventHandler RoomStatus6RowChanging;

      public event SystemDataSet.RoomStatus6RowChangeEventHandler RoomStatus6RowChanged;

      public event SystemDataSet.RoomStatus6RowChangeEventHandler RoomStatus6RowDeleting;

      public event SystemDataSet.RoomStatus6RowChangeEventHandler RoomStatus6RowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatus6Row(SystemDataSet.RoomStatus6Row row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus6Row AddRoomStatus6Row(
        string RoomNo,
        byte Status,
        string Description,
        byte RoomType,
        string ClientID,
        string Condition,
        DateTime StartDate,
        DateTime EndDate,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomStatus6Row row = (SystemDataSet.RoomStatus6Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) RoomNo,
          (object) Status,
          (object) Description,
          (object) RoomType,
          (object) ClientID,
          (object) Condition,
          (object) StartDate,
          (object) EndDate,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomStatus6DataTable status6DataTable = (SystemDataSet.RoomStatus6DataTable) base.Clone();
        status6DataTable.InitVars();
        return (DataTable) status6DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomStatus6DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnStatus = this.Columns["Status"];
        this.columnDescription = this.Columns["Description"];
        this.columnRoomType = this.Columns["RoomType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCondition = this.Columns["Condition"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnStatus = new DataColumn("Status", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStatus);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnRoomNo.MaxLength = 5;
        this.columnDescription.MaxLength = 30;
        this.columnClientID.MaxLength = 10;
        this.columnCondition.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus6Row NewRoomStatus6Row()
      {
        return (SystemDataSet.RoomStatus6Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomStatus6Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomStatus6Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatus6RowChanged == null)
          return;
        this.RoomStatus6RowChanged((object) this, new SystemDataSet.RoomStatus6RowChangeEvent((SystemDataSet.RoomStatus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatus6RowChanging == null)
          return;
        this.RoomStatus6RowChanging((object) this, new SystemDataSet.RoomStatus6RowChangeEvent((SystemDataSet.RoomStatus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatus6RowDeleted == null)
          return;
        this.RoomStatus6RowDeleted((object) this, new SystemDataSet.RoomStatus6RowChangeEvent((SystemDataSet.RoomStatus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatus6RowDeleting == null)
          return;
        this.RoomStatus6RowDeleting((object) this, new SystemDataSet.RoomStatus6RowChangeEvent((SystemDataSet.RoomStatus6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatus6Row(SystemDataSet.RoomStatus6Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatus6DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class RoomTypeDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomType;
      private DataColumn columnRmDescription;
      private DataColumn columnMaxCard;
      private DataColumn columnMinCard;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public RoomTypeDataTable()
      {
        this.TableName = "RoomType";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomTypeDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected RoomTypeDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomTypeColumn => this.columnRoomType;

      [DebuggerNonUserCode]
      public DataColumn RmDescriptionColumn => this.columnRmDescription;

      [DebuggerNonUserCode]
      public DataColumn MaxCardColumn => this.columnMaxCard;

      [DebuggerNonUserCode]
      public DataColumn MinCardColumn => this.columnMinCard;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.RoomTypeRow this[int index]
      {
        get => (SystemDataSet.RoomTypeRow) this.Rows[index];
      }

      public event SystemDataSet.RoomTypeRowChangeEventHandler RoomTypeRowChanging;

      public event SystemDataSet.RoomTypeRowChangeEventHandler RoomTypeRowChanged;

      public event SystemDataSet.RoomTypeRowChangeEventHandler RoomTypeRowDeleting;

      public event SystemDataSet.RoomTypeRowChangeEventHandler RoomTypeRowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomTypeRow(SystemDataSet.RoomTypeRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.RoomTypeRow AddRoomTypeRow(
        byte RoomType,
        string RmDescription,
        byte MaxCard,
        byte MinCard,
        string StaffID,
        bool Update)
      {
        SystemDataSet.RoomTypeRow row = (SystemDataSet.RoomTypeRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) RoomType,
          (object) RmDescription,
          (object) MaxCard,
          (object) MinCard,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.RoomTypeDataTable roomTypeDataTable = (SystemDataSet.RoomTypeDataTable) base.Clone();
        roomTypeDataTable.InitVars();
        return (DataTable) roomTypeDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.RoomTypeDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomType = this.Columns["RoomType"];
        this.columnRmDescription = this.Columns["RmDescription"];
        this.columnMaxCard = this.Columns["MaxCard"];
        this.columnMinCard = this.Columns["MinCard"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomType = new DataColumn("RoomType", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomType);
        this.columnRmDescription = new DataColumn("RmDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRmDescription);
        this.columnMaxCard = new DataColumn("MaxCard", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMaxCard);
        this.columnMinCard = new DataColumn("MinCard", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMinCard);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnRoomType
        }, false));
        this.columnRoomType.Unique = true;
        this.columnRmDescription.MaxLength = 30;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomTypeRow NewRoomTypeRow()
      {
        return (SystemDataSet.RoomTypeRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.RoomTypeRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.RoomTypeRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomTypeRowChanged == null)
          return;
        this.RoomTypeRowChanged((object) this, new SystemDataSet.RoomTypeRowChangeEvent((SystemDataSet.RoomTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomTypeRowChanging == null)
          return;
        this.RoomTypeRowChanging((object) this, new SystemDataSet.RoomTypeRowChangeEvent((SystemDataSet.RoomTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomTypeRowDeleted == null)
          return;
        this.RoomTypeRowDeleted((object) this, new SystemDataSet.RoomTypeRowChangeEvent((SystemDataSet.RoomTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomTypeRowDeleting == null)
          return;
        this.RoomTypeRowDeleting((object) this, new SystemDataSet.RoomTypeRowChangeEvent((SystemDataSet.RoomTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomTypeRow(SystemDataSet.RoomTypeRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomTypeDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class SystemSet1DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet1DataTable()
      {
        this.TableName = "SystemSet1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet1Row this[int index]
      {
        get => (SystemDataSet.SystemSet1Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet1RowChangeEventHandler SystemSet1RowChanging;

      public event SystemDataSet.SystemSet1RowChangeEventHandler SystemSet1RowChanged;

      public event SystemDataSet.SystemSet1RowChangeEventHandler SystemSet1RowDeleting;

      public event SystemDataSet.SystemSet1RowChangeEventHandler SystemSet1RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet1Row(SystemDataSet.SystemSet1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet1Row AddSystemSet1Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet1Row row = (SystemDataSet.SystemSet1Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet1DataTable systemSet1DataTable = (SystemDataSet.SystemSet1DataTable) base.Clone();
        systemSet1DataTable.InitVars();
        return (DataTable) systemSet1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet1DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet1Row NewSystemSet1Row()
      {
        return (SystemDataSet.SystemSet1Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet1Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet1RowChanged == null)
          return;
        this.SystemSet1RowChanged((object) this, new SystemDataSet.SystemSet1RowChangeEvent((SystemDataSet.SystemSet1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet1RowChanging == null)
          return;
        this.SystemSet1RowChanging((object) this, new SystemDataSet.SystemSet1RowChangeEvent((SystemDataSet.SystemSet1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet1RowDeleted == null)
          return;
        this.SystemSet1RowDeleted((object) this, new SystemDataSet.SystemSet1RowChangeEvent((SystemDataSet.SystemSet1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet1RowDeleting == null)
          return;
        this.SystemSet1RowDeleting((object) this, new SystemDataSet.SystemSet1RowChangeEvent((SystemDataSet.SystemSet1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet1Row(SystemDataSet.SystemSet1Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class ZoneDataTable : DataTable, IEnumerable
    {
      private DataColumn columnZoneNo;
      private DataColumn columnZoneName;
      private DataColumn columnBuildingNo;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public ZoneDataTable()
      {
        this.TableName = "Zone";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ZoneDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected ZoneDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ZoneNoColumn => this.columnZoneNo;

      [DebuggerNonUserCode]
      public DataColumn ZoneNameColumn => this.columnZoneName;

      [DebuggerNonUserCode]
      public DataColumn BuildingNoColumn => this.columnBuildingNo;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.ZoneRow this[int index] => (SystemDataSet.ZoneRow) this.Rows[index];

      public event SystemDataSet.ZoneRowChangeEventHandler ZoneRowChanging;

      public event SystemDataSet.ZoneRowChangeEventHandler ZoneRowChanged;

      public event SystemDataSet.ZoneRowChangeEventHandler ZoneRowDeleting;

      public event SystemDataSet.ZoneRowChangeEventHandler ZoneRowDeleted;

      [DebuggerNonUserCode]
      public void AddZoneRow(SystemDataSet.ZoneRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.ZoneRow AddZoneRow(
        short ZoneNo,
        string ZoneName,
        string BuildingNo,
        string StaffID,
        bool Update)
      {
        SystemDataSet.ZoneRow row = (SystemDataSet.ZoneRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) ZoneNo,
          (object) ZoneName,
          (object) BuildingNo,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.ZoneDataTable zoneDataTable = (SystemDataSet.ZoneDataTable) base.Clone();
        zoneDataTable.InitVars();
        return (DataTable) zoneDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.ZoneDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnZoneNo = this.Columns["ZoneNo"];
        this.columnZoneName = this.Columns["ZoneName"];
        this.columnBuildingNo = this.Columns["BuildingNo"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnZoneNo = new DataColumn("ZoneNo", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnZoneNo);
        this.columnZoneName = new DataColumn("ZoneName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnZoneName);
        this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingNo);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnZoneName.MaxLength = 20;
        this.columnBuildingNo.MaxLength = 2;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.ZoneRow NewZoneRow() => (SystemDataSet.ZoneRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.ZoneRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.ZoneRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ZoneRowChanged == null)
          return;
        this.ZoneRowChanged((object) this, new SystemDataSet.ZoneRowChangeEvent((SystemDataSet.ZoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ZoneRowChanging == null)
          return;
        this.ZoneRowChanging((object) this, new SystemDataSet.ZoneRowChangeEvent((SystemDataSet.ZoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ZoneRowDeleted == null)
          return;
        this.ZoneRowDeleted((object) this, new SystemDataSet.ZoneRowChangeEvent((SystemDataSet.ZoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ZoneRowDeleting == null)
          return;
        this.ZoneRowDeleting((object) this, new SystemDataSet.ZoneRowChangeEvent((SystemDataSet.ZoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveZoneRow(SystemDataSet.ZoneRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ZoneDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSet2DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet2DataTable()
      {
        this.TableName = "SystemSet2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet2DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet2Row this[int index]
      {
        get => (SystemDataSet.SystemSet2Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet2RowChangeEventHandler SystemSet2RowChanging;

      public event SystemDataSet.SystemSet2RowChangeEventHandler SystemSet2RowChanged;

      public event SystemDataSet.SystemSet2RowChangeEventHandler SystemSet2RowDeleting;

      public event SystemDataSet.SystemSet2RowChangeEventHandler SystemSet2RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet2Row(SystemDataSet.SystemSet2Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet2Row AddSystemSet2Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet2Row row = (SystemDataSet.SystemSet2Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet2DataTable systemSet2DataTable = (SystemDataSet.SystemSet2DataTable) base.Clone();
        systemSet2DataTable.InitVars();
        return (DataTable) systemSet2DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet2DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet2Row NewSystemSet2Row()
      {
        return (SystemDataSet.SystemSet2Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet2Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet2Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet2RowChanged == null)
          return;
        this.SystemSet2RowChanged((object) this, new SystemDataSet.SystemSet2RowChangeEvent((SystemDataSet.SystemSet2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet2RowChanging == null)
          return;
        this.SystemSet2RowChanging((object) this, new SystemDataSet.SystemSet2RowChangeEvent((SystemDataSet.SystemSet2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet2RowDeleted == null)
          return;
        this.SystemSet2RowDeleted((object) this, new SystemDataSet.SystemSet2RowChangeEvent((SystemDataSet.SystemSet2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet2RowDeleting == null)
          return;
        this.SystemSet2RowDeleting((object) this, new SystemDataSet.SystemSet2RowChangeEvent((SystemDataSet.SystemSet2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet2Row(SystemDataSet.SystemSet2Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSet3DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet3DataTable()
      {
        this.TableName = "SystemSet3";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet3DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet3DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet3Row this[int index]
      {
        get => (SystemDataSet.SystemSet3Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet3RowChangeEventHandler SystemSet3RowChanging;

      public event SystemDataSet.SystemSet3RowChangeEventHandler SystemSet3RowChanged;

      public event SystemDataSet.SystemSet3RowChangeEventHandler SystemSet3RowDeleting;

      public event SystemDataSet.SystemSet3RowChangeEventHandler SystemSet3RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet3Row(SystemDataSet.SystemSet3Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet3Row AddSystemSet3Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet3Row row = (SystemDataSet.SystemSet3Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet3DataTable systemSet3DataTable = (SystemDataSet.SystemSet3DataTable) base.Clone();
        systemSet3DataTable.InitVars();
        return (DataTable) systemSet3DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet3DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet3Row NewSystemSet3Row()
      {
        return (SystemDataSet.SystemSet3Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet3Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet3Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet3RowChanged == null)
          return;
        this.SystemSet3RowChanged((object) this, new SystemDataSet.SystemSet3RowChangeEvent((SystemDataSet.SystemSet3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet3RowChanging == null)
          return;
        this.SystemSet3RowChanging((object) this, new SystemDataSet.SystemSet3RowChangeEvent((SystemDataSet.SystemSet3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet3RowDeleted == null)
          return;
        this.SystemSet3RowDeleted((object) this, new SystemDataSet.SystemSet3RowChangeEvent((SystemDataSet.SystemSet3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet3RowDeleting == null)
          return;
        this.SystemSet3RowDeleting((object) this, new SystemDataSet.SystemSet3RowChangeEvent((SystemDataSet.SystemSet3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet3Row(SystemDataSet.SystemSet3Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet3DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSet4DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet4DataTable()
      {
        this.TableName = "SystemSet4";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet4DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet4DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet4Row this[int index]
      {
        get => (SystemDataSet.SystemSet4Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet4RowChangeEventHandler SystemSet4RowChanging;

      public event SystemDataSet.SystemSet4RowChangeEventHandler SystemSet4RowChanged;

      public event SystemDataSet.SystemSet4RowChangeEventHandler SystemSet4RowDeleting;

      public event SystemDataSet.SystemSet4RowChangeEventHandler SystemSet4RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet4Row(SystemDataSet.SystemSet4Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet4Row AddSystemSet4Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet4Row row = (SystemDataSet.SystemSet4Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet4DataTable systemSet4DataTable = (SystemDataSet.SystemSet4DataTable) base.Clone();
        systemSet4DataTable.InitVars();
        return (DataTable) systemSet4DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet4DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet4Row NewSystemSet4Row()
      {
        return (SystemDataSet.SystemSet4Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet4Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet4Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet4RowChanged == null)
          return;
        this.SystemSet4RowChanged((object) this, new SystemDataSet.SystemSet4RowChangeEvent((SystemDataSet.SystemSet4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet4RowChanging == null)
          return;
        this.SystemSet4RowChanging((object) this, new SystemDataSet.SystemSet4RowChangeEvent((SystemDataSet.SystemSet4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet4RowDeleted == null)
          return;
        this.SystemSet4RowDeleted((object) this, new SystemDataSet.SystemSet4RowChangeEvent((SystemDataSet.SystemSet4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet4RowDeleting == null)
          return;
        this.SystemSet4RowDeleting((object) this, new SystemDataSet.SystemSet4RowChangeEvent((SystemDataSet.SystemSet4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet4Row(SystemDataSet.SystemSet4Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet4DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSet5DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet5DataTable()
      {
        this.TableName = "SystemSet5";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet5DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet5DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet5Row this[int index]
      {
        get => (SystemDataSet.SystemSet5Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet5RowChangeEventHandler SystemSet5RowChanging;

      public event SystemDataSet.SystemSet5RowChangeEventHandler SystemSet5RowChanged;

      public event SystemDataSet.SystemSet5RowChangeEventHandler SystemSet5RowDeleting;

      public event SystemDataSet.SystemSet5RowChangeEventHandler SystemSet5RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet5Row(SystemDataSet.SystemSet5Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet5Row AddSystemSet5Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet5Row row = (SystemDataSet.SystemSet5Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet5DataTable systemSet5DataTable = (SystemDataSet.SystemSet5DataTable) base.Clone();
        systemSet5DataTable.InitVars();
        return (DataTable) systemSet5DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet5DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet5Row NewSystemSet5Row()
      {
        return (SystemDataSet.SystemSet5Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet5Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet5Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet5RowChanged == null)
          return;
        this.SystemSet5RowChanged((object) this, new SystemDataSet.SystemSet5RowChangeEvent((SystemDataSet.SystemSet5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet5RowChanging == null)
          return;
        this.SystemSet5RowChanging((object) this, new SystemDataSet.SystemSet5RowChangeEvent((SystemDataSet.SystemSet5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet5RowDeleted == null)
          return;
        this.SystemSet5RowDeleted((object) this, new SystemDataSet.SystemSet5RowChangeEvent((SystemDataSet.SystemSet5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet5RowDeleting == null)
          return;
        this.SystemSet5RowDeleting((object) this, new SystemDataSet.SystemSet5RowChangeEvent((SystemDataSet.SystemSet5Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet5Row(SystemDataSet.SystemSet5Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet5DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSet6DataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSet6DataTable()
      {
        this.TableName = "SystemSet6";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSet6DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSet6DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet6Row this[int index]
      {
        get => (SystemDataSet.SystemSet6Row) this.Rows[index];
      }

      public event SystemDataSet.SystemSet6RowChangeEventHandler SystemSet6RowChanging;

      public event SystemDataSet.SystemSet6RowChangeEventHandler SystemSet6RowChanged;

      public event SystemDataSet.SystemSet6RowChangeEventHandler SystemSet6RowDeleting;

      public event SystemDataSet.SystemSet6RowChangeEventHandler SystemSet6RowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSet6Row(SystemDataSet.SystemSet6Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet6Row AddSystemSet6Row(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSet6Row row = (SystemDataSet.SystemSet6Row) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSet6DataTable systemSet6DataTable = (SystemDataSet.SystemSet6DataTable) base.Clone();
        systemSet6DataTable.InitVars();
        return (DataTable) systemSet6DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSet6DataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet6Row NewSystemSet6Row()
      {
        return (SystemDataSet.SystemSet6Row) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSet6Row(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSet6Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSet6RowChanged == null)
          return;
        this.SystemSet6RowChanged((object) this, new SystemDataSet.SystemSet6RowChangeEvent((SystemDataSet.SystemSet6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSet6RowChanging == null)
          return;
        this.SystemSet6RowChanging((object) this, new SystemDataSet.SystemSet6RowChangeEvent((SystemDataSet.SystemSet6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSet6RowDeleted == null)
          return;
        this.SystemSet6RowDeleted((object) this, new SystemDataSet.SystemSet6RowChangeEvent((SystemDataSet.SystemSet6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSet6RowDeleting == null)
          return;
        this.SystemSet6RowDeleting((object) this, new SystemDataSet.SystemSet6RowChangeEvent((SystemDataSet.SystemSet6Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSet6Row(SystemDataSet.SystemSet6Row row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSet6DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SystemSetDataTable : DataTable, IEnumerable
    {
      private DataColumn columnSystemID;
      private DataColumn columnDescription;
      private DataColumn columnBuildingType;
      private DataColumn columnComport;
      private DataColumn columnGSTRate;
      private DataColumn columnBonus;
      private DataColumn columnCheckOutTime;
      private DataColumn columnMGraceDefault;
      private DataColumn columnWGraceDefault;
      private DataColumn columnDGraceDefault;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;
      private DataColumn columnHotelCode;

      [DebuggerNonUserCode]
      public SystemSetDataTable()
      {
        this.TableName = "SystemSet";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SystemSetDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SystemSetDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn SystemIDColumn => this.columnSystemID;

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn => this.columnDescription;

      [DebuggerNonUserCode]
      public DataColumn BuildingTypeColumn => this.columnBuildingType;

      [DebuggerNonUserCode]
      public DataColumn ComportColumn => this.columnComport;

      [DebuggerNonUserCode]
      public DataColumn GSTRateColumn => this.columnGSTRate;

      [DebuggerNonUserCode]
      public DataColumn BonusColumn => this.columnBonus;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn MGraceDefaultColumn => this.columnMGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn WGraceDefaultColumn => this.columnWGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn DGraceDefaultColumn => this.columnDGraceDefault;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn HotelCodeColumn => this.columnHotelCode;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSetRow this[int index]
      {
        get => (SystemDataSet.SystemSetRow) this.Rows[index];
      }

      public event SystemDataSet.SystemSetRowChangeEventHandler SystemSetRowChanging;

      public event SystemDataSet.SystemSetRowChangeEventHandler SystemSetRowChanged;

      public event SystemDataSet.SystemSetRowChangeEventHandler SystemSetRowDeleting;

      public event SystemDataSet.SystemSetRowChangeEventHandler SystemSetRowDeleted;

      [DebuggerNonUserCode]
      public void AddSystemSetRow(SystemDataSet.SystemSetRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSetRow AddSystemSetRow(
        short SystemID,
        string Description,
        string BuildingType,
        byte Comport,
        double GSTRate,
        bool Bonus,
        string CheckOutTime,
        int MGraceDefault,
        int WGraceDefault,
        int DGraceDefault,
        string StaffID,
        bool Update,
        string HotelCode)
      {
        SystemDataSet.SystemSetRow row = (SystemDataSet.SystemSetRow) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) SystemID,
          (object) Description,
          (object) BuildingType,
          (object) Comport,
          (object) GSTRate,
          (object) Bonus,
          (object) CheckOutTime,
          (object) MGraceDefault,
          (object) WGraceDefault,
          (object) DGraceDefault,
          (object) StaffID,
          (object) Update,
          (object) HotelCode
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        SystemDataSet.SystemSetDataTable systemSetDataTable = (SystemDataSet.SystemSetDataTable) base.Clone();
        systemSetDataTable.InitVars();
        return (DataTable) systemSetDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new SystemDataSet.SystemSetDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnSystemID = this.Columns["SystemID"];
        this.columnDescription = this.Columns["Description"];
        this.columnBuildingType = this.Columns["BuildingType"];
        this.columnComport = this.Columns["Comport"];
        this.columnGSTRate = this.Columns["GSTRate"];
        this.columnBonus = this.Columns["Bonus"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnMGraceDefault = this.Columns["MGraceDefault"];
        this.columnWGraceDefault = this.Columns["WGraceDefault"];
        this.columnDGraceDefault = this.Columns["DGraceDefault"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
        this.columnHotelCode = this.Columns["HotelCode"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnSystemID = new DataColumn("SystemID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSystemID);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.columnBuildingType = new DataColumn("BuildingType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingType);
        this.columnComport = new DataColumn("Comport", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComport);
        this.columnGSTRate = new DataColumn("GSTRate", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGSTRate);
        this.columnBonus = new DataColumn("Bonus", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonus);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnMGraceDefault = new DataColumn("MGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMGraceDefault);
        this.columnWGraceDefault = new DataColumn("WGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWGraceDefault);
        this.columnDGraceDefault = new DataColumn("DGraceDefault", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDGraceDefault);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnHotelCode = new DataColumn("HotelCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHotelCode);
        this.columnDescription.MaxLength = 50;
        this.columnBuildingType.MaxLength = 20;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
        this.columnHotelCode.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSetRow NewSystemSetRow()
      {
        return (SystemDataSet.SystemSetRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new SystemDataSet.SystemSetRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (SystemDataSet.SystemSetRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SystemSetRowChanged == null)
          return;
        this.SystemSetRowChanged((object) this, new SystemDataSet.SystemSetRowChangeEvent((SystemDataSet.SystemSetRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SystemSetRowChanging == null)
          return;
        this.SystemSetRowChanging((object) this, new SystemDataSet.SystemSetRowChangeEvent((SystemDataSet.SystemSetRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SystemSetRowDeleted == null)
          return;
        this.SystemSetRowDeleted((object) this, new SystemDataSet.SystemSetRowChangeEvent((SystemDataSet.SystemSetRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SystemSetRowDeleting == null)
          return;
        this.SystemSetRowDeleting((object) this, new SystemDataSet.SystemSetRowChangeEvent((SystemDataSet.SystemSetRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSystemSetRow(SystemDataSet.SystemSetRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        SystemDataSet systemDataSet = new SystemDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = systemDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SystemSetDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = systemDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class BonusRow : DataRow
    {
      private SystemDataSet.BonusDataTable tableBonus;

      [DebuggerNonUserCode]
      internal BonusRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus = (SystemDataSet.BonusDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus1Row : DataRow
    {
      private SystemDataSet.Bonus1DataTable tableBonus1;

      [DebuggerNonUserCode]
      internal Bonus1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus1 = (SystemDataSet.Bonus1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus1.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus1.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus1.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus1.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus1.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus1.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus1.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus1.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus1.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus1.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus1.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus1.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus1.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus1.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus1.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus1.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus1.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus1.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus1.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus1.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus1.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus1.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus2Row : DataRow
    {
      private SystemDataSet.Bonus2DataTable tableBonus2;

      [DebuggerNonUserCode]
      internal Bonus2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus2 = (SystemDataSet.Bonus2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus2.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus2.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus2.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus2.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus2.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus2.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus2.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus2.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus2.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus2.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus2.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus2.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus2.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus2.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus2.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus2.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus2.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus2.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus2.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus2.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus2.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus2.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus3Row : DataRow
    {
      private SystemDataSet.Bonus3DataTable tableBonus3;

      [DebuggerNonUserCode]
      internal Bonus3Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus3 = (SystemDataSet.Bonus3DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus3.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus3.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus3.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus3.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus3.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus3.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus3.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus3.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus3.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus3.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus3.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus3.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus3.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus3.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus3.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus3.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus3.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus3.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus3.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus3.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus3.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus3.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus4Row : DataRow
    {
      private SystemDataSet.Bonus4DataTable tableBonus4;

      [DebuggerNonUserCode]
      internal Bonus4Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus4 = (SystemDataSet.Bonus4DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus4.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus4.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus4.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus4.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus4.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus4.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus4.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus4.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus4.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus4.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus4.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus4.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus4.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus4.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus4.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus4.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus4.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus4.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus4.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus4.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus4.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus4.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus5Row : DataRow
    {
      private SystemDataSet.Bonus5DataTable tableBonus5;

      [DebuggerNonUserCode]
      internal Bonus5Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus5 = (SystemDataSet.Bonus5DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus5.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus5.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus5.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus5.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus5.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus5.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus5.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus5.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus5.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus5.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus5.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus5.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus5.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus5.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus5.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus5.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus5.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus5.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus5.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus5.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus5.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus5.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus6Row : DataRow
    {
      private SystemDataSet.Bonus6DataTable tableBonus6;

      [DebuggerNonUserCode]
      internal Bonus6Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBonus6 = (SystemDataSet.Bonus6DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StayType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus6.StayTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayType' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.StayTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short StayLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus6.StayLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StayLength' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.StayLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusType
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus6.BonusTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusType' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.BonusTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short BonusLength
      {
        get
        {
          try
          {
            return (short) this[this.tableBonus6.BonusLengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusLength' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.BonusLengthColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusStart
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus6.BonusStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BonusStart' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.BonusStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string DateUpdate
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus6.DateUpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DateUpdate' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.DateUpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Staff
      {
        get
        {
          try
          {
            return (string) this[this.tableBonus6.StaffColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Staff' in table 'Bonus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBonus6.StaffColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStayTypeNull() => this.IsNull(this.tableBonus6.StayTypeColumn);

      [DebuggerNonUserCode]
      public void SetStayTypeNull() => this[this.tableBonus6.StayTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStayLengthNull() => this.IsNull(this.tableBonus6.StayLengthColumn);

      [DebuggerNonUserCode]
      public void SetStayLengthNull() => this[this.tableBonus6.StayLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusTypeNull() => this.IsNull(this.tableBonus6.BonusTypeColumn);

      [DebuggerNonUserCode]
      public void SetBonusTypeNull() => this[this.tableBonus6.BonusTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusLengthNull() => this.IsNull(this.tableBonus6.BonusLengthColumn);

      [DebuggerNonUserCode]
      public void SetBonusLengthNull() => this[this.tableBonus6.BonusLengthColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusStartNull() => this.IsNull(this.tableBonus6.BonusStartColumn);

      [DebuggerNonUserCode]
      public void SetBonusStartNull() => this[this.tableBonus6.BonusStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateUpdateNull() => this.IsNull(this.tableBonus6.DateUpdateColumn);

      [DebuggerNonUserCode]
      public void SetDateUpdateNull() => this[this.tableBonus6.DateUpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffNull() => this.IsNull(this.tableBonus6.StaffColumn);

      [DebuggerNonUserCode]
      public void SetStaffNull() => this[this.tableBonus6.StaffColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class BuildingRow : DataRow
    {
      private SystemDataSet.BuildingDataTable tableBuilding;

      [DebuggerNonUserCode]
      internal BuildingRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBuilding = (SystemDataSet.BuildingDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string BuildingNo
      {
        get
        {
          try
          {
            return (string) this[this.tableBuilding.BuildingNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingNo' in table 'Building' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBuilding.BuildingNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BldName
      {
        get
        {
          try
          {
            return (string) this[this.tableBuilding.BldNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BldName' in table 'Building' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBuilding.BldNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableBuilding.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'Building' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBuilding.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableBuilding.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'Building' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBuilding.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableBuilding.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Building' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBuilding.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingNoNull() => this.IsNull(this.tableBuilding.BuildingNoColumn);

      [DebuggerNonUserCode]
      public void SetBuildingNoNull() => this[this.tableBuilding.BuildingNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBldNameNull() => this.IsNull(this.tableBuilding.BldNameColumn);

      [DebuggerNonUserCode]
      public void SetBldNameNull() => this[this.tableBuilding.BldNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableBuilding.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableBuilding.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableBuilding.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableBuilding.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableBuilding.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableBuilding.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class CountryRow : DataRow
    {
      private SystemDataSet.CountryDataTable tableCountry;

      [DebuggerNonUserCode]
      internal CountryRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCountry = (SystemDataSet.CountryDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int CountryID
      {
        get => (int) this[this.tableCountry.CountryIDColumn];
        set => this[this.tableCountry.CountryIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CountryDesc
      {
        get
        {
          try
          {
            return (string) this[this.tableCountry.CountryDescColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CountryDesc' in table 'Country' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCountry.CountryDescColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsCountryDescNull() => this.IsNull(this.tableCountry.CountryDescColumn);

      [DebuggerNonUserCode]
      public void SetCountryDescNull()
      {
        this[this.tableCountry.CountryDescColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class FloorRow : DataRow
    {
      private SystemDataSet.FloorDataTable tableFloor;

      [DebuggerNonUserCode]
      internal FloorRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableFloor = (SystemDataSet.FloorDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string FloorNo
      {
        get
        {
          try
          {
            return (string) this[this.tableFloor.FloorNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'FloorNo' in table 'Floor' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableFloor.FloorNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingNo
      {
        get
        {
          try
          {
            return (string) this[this.tableFloor.BuildingNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingNo' in table 'Floor' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableFloor.BuildingNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableFloor.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'Floor' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableFloor.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableFloor.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Floor' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableFloor.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsFloorNoNull() => this.IsNull(this.tableFloor.FloorNoColumn);

      [DebuggerNonUserCode]
      public void SetFloorNoNull() => this[this.tableFloor.FloorNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBuildingNoNull() => this.IsNull(this.tableFloor.BuildingNoColumn);

      [DebuggerNonUserCode]
      public void SetBuildingNoNull() => this[this.tableFloor.BuildingNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableFloor.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableFloor.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableFloor.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableFloor.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistoryRow : DataRow
    {
      private SystemDataSet.GSTHistoryDataTable tableGSTHistory;

      [DebuggerNonUserCode]
      internal GSTHistoryRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory = (SystemDataSet.GSTHistoryDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory1Row : DataRow
    {
      private SystemDataSet.GSTHistory1DataTable tableGSTHistory1;

      [DebuggerNonUserCode]
      internal GSTHistory1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory1 = (SystemDataSet.GSTHistory1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory1.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory1.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory1.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory1.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory1.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory1.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory1.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory1.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory1.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory1.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory1.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory1.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory2Row : DataRow
    {
      private SystemDataSet.GSTHistory2DataTable tableGSTHistory2;

      [DebuggerNonUserCode]
      internal GSTHistory2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory2 = (SystemDataSet.GSTHistory2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory2.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory2.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory2.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory2.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory2.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory2.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory2.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory2.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory2.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory2.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory2.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory2.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory3Row : DataRow
    {
      private SystemDataSet.GSTHistory3DataTable tableGSTHistory3;

      [DebuggerNonUserCode]
      internal GSTHistory3Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory3 = (SystemDataSet.GSTHistory3DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory3.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory3.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory3.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory3.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory3.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory3.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory3.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory3.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory3.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory3.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory3.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory3.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory4Row : DataRow
    {
      private SystemDataSet.GSTHistory4DataTable tableGSTHistory4;

      [DebuggerNonUserCode]
      internal GSTHistory4Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory4 = (SystemDataSet.GSTHistory4DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory4.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory4.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory4.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory4.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory4.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory4.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory4.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory4.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory4.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory4.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory4.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory4.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory5Row : DataRow
    {
      private SystemDataSet.GSTHistory5DataTable tableGSTHistory5;

      [DebuggerNonUserCode]
      internal GSTHistory5Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory5 = (SystemDataSet.GSTHistory5DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory5.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory5.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory5.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory5.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory5.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory5.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory5.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory5.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory5.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory5.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory5.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory5.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory6Row : DataRow
    {
      private SystemDataSet.GSTHistory6DataTable tableGSTHistory6;

      [DebuggerNonUserCode]
      internal GSTHistory6Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGSTHistory6 = (SystemDataSet.GSTHistory6DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableGSTHistory6.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'GSTHistory6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory6.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UpdateDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableGSTHistory6.UpdateDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UpdateDate' in table 'GSTHistory6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory6.UpdateDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableGSTHistory6.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'GSTHistory6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableGSTHistory6.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableGSTHistory6.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableGSTHistory6.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateDateNull() => this.IsNull(this.tableGSTHistory6.UpdateDateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateDateNull()
      {
        this[this.tableGSTHistory6.UpdateDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableGSTHistory6.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableGSTHistory6.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomRow : DataRow
    {
      private SystemDataSet.RoomDataTable tableRoom;

      [DebuggerNonUserCode]
      internal RoomRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoom = (SystemDataSet.RoomDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoom.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoom.RoomIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomID' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.RoomIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoom.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string FloorNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoom.FloorNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'FloorNo' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.FloorNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoom.BuildingNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingNo' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.BuildingNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal DailyRate
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.DailyRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DailyRate' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.DailyRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal WeeklyRate
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.WeeklyRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WeeklyRate' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.WeeklyRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal MonthlyRate
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.MonthlyRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MonthlyRate' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.MonthlyRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal DailyRate2
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.DailyRate2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DailyRate2' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.DailyRate2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal WeeklyRate2
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.WeeklyRate2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WeeklyRate2' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.WeeklyRate2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal MonthlyRate2
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableRoom.MonthlyRate2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MonthlyRate2' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.MonthlyRate2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public short IssuedCard
      {
        get
        {
          try
          {
            return (short) this[this.tableRoom.IssuedCardColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'IssuedCard' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.IssuedCardColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte TotalStay
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoom.TotalStayColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TotalStay' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.TotalStayColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoom.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoom.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Room' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoom.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoom.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoom.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomIDNull() => this.IsNull(this.tableRoom.RoomIDColumn);

      [DebuggerNonUserCode]
      public void SetRoomIDNull() => this[this.tableRoom.RoomIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoom.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoom.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsFloorNoNull() => this.IsNull(this.tableRoom.FloorNoColumn);

      [DebuggerNonUserCode]
      public void SetFloorNoNull() => this[this.tableRoom.FloorNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBuildingNoNull() => this.IsNull(this.tableRoom.BuildingNoColumn);

      [DebuggerNonUserCode]
      public void SetBuildingNoNull() => this[this.tableRoom.BuildingNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDailyRateNull() => this.IsNull(this.tableRoom.DailyRateColumn);

      [DebuggerNonUserCode]
      public void SetDailyRateNull() => this[this.tableRoom.DailyRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsWeeklyRateNull() => this.IsNull(this.tableRoom.WeeklyRateColumn);

      [DebuggerNonUserCode]
      public void SetWeeklyRateNull() => this[this.tableRoom.WeeklyRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsMonthlyRateNull() => this.IsNull(this.tableRoom.MonthlyRateColumn);

      [DebuggerNonUserCode]
      public void SetMonthlyRateNull() => this[this.tableRoom.MonthlyRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDailyRate2Null() => this.IsNull(this.tableRoom.DailyRate2Column);

      [DebuggerNonUserCode]
      public void SetDailyRate2Null() => this[this.tableRoom.DailyRate2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsWeeklyRate2Null() => this.IsNull(this.tableRoom.WeeklyRate2Column);

      [DebuggerNonUserCode]
      public void SetWeeklyRate2Null() => this[this.tableRoom.WeeklyRate2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsMonthlyRate2Null() => this.IsNull(this.tableRoom.MonthlyRate2Column);

      [DebuggerNonUserCode]
      public void SetMonthlyRate2Null() => this[this.tableRoom.MonthlyRate2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsIssuedCardNull() => this.IsNull(this.tableRoom.IssuedCardColumn);

      [DebuggerNonUserCode]
      public void SetIssuedCardNull() => this[this.tableRoom.IssuedCardColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTotalStayNull() => this.IsNull(this.tableRoom.TotalStayColumn);

      [DebuggerNonUserCode]
      public void SetTotalStayNull() => this[this.tableRoom.TotalStayColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoom.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoom.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoom.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoom.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus1Row : DataRow
    {
      private SystemDataSet.RoomStatus1DataTable tableRoomStatus1;

      [DebuggerNonUserCode]
      internal RoomStatus1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus1 = (SystemDataSet.RoomStatus1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus1.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus1.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus1.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus1.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus1.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus1.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus1.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus1.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus1.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus1.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus1.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus1.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus1.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus1.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus1.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus1.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus1.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus1.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus1.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus1.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus1.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus1.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus1.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus1.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus1.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus1.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus1.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus1.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus1.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus1.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus1.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus2Row : DataRow
    {
      private SystemDataSet.RoomStatus2DataTable tableRoomStatus2;

      [DebuggerNonUserCode]
      internal RoomStatus2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus2 = (SystemDataSet.RoomStatus2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus2.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus2.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus2.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus2.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus2.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus2.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus2.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus2.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus2.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus2.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus2.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus2.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus2.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus2.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus2.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus2.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus2.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus2.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus2.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus2.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus2.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus2.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus2.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus2.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus2.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus2.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus2.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus2.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus2.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus2.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus2.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus3Row : DataRow
    {
      private SystemDataSet.RoomStatus3DataTable tableRoomStatus3;

      [DebuggerNonUserCode]
      internal RoomStatus3Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus3 = (SystemDataSet.RoomStatus3DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus3.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus3.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus3.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus3.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus3.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus3.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus3.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus3.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus3.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus3.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus3.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus3.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus3.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus3.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus3.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus3.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus3.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus3.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus3.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus3.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus3.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus3.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus3.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus3.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus3.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus3.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus3.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus3.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus3.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus3.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus3.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus4Row : DataRow
    {
      private SystemDataSet.RoomStatus4DataTable tableRoomStatus4;

      [DebuggerNonUserCode]
      internal RoomStatus4Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus4 = (SystemDataSet.RoomStatus4DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus4.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus4.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus4.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus4.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus4.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus4.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus4.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus4.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus4.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus4.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus4.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus4.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus4.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus4.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus4.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus4.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus4.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus4.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus4.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus4.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus4.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus4.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus4.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus4.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus4.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus4.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus4.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus4.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus4.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus4.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus4.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus5Row : DataRow
    {
      private SystemDataSet.RoomStatus5DataTable tableRoomStatus5;

      [DebuggerNonUserCode]
      internal RoomStatus5Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus5 = (SystemDataSet.RoomStatus5DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus5.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus5.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus5.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus5.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus5.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus5.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus5.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus5.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus5.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus5.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus5.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus5.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus5.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus5.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus5.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus5.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus5.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus5.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus5.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus5.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus5.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus5.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus5.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus5.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus5.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus5.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus5.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus5.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus5.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus5.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus5.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus6Row : DataRow
    {
      private SystemDataSet.RoomStatus6DataTable tableRoomStatus6;

      [DebuggerNonUserCode]
      internal RoomStatus6Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus6 = (SystemDataSet.RoomStatus6DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus6.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus6.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Status' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus6.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus6.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus6.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus6.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Condition' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus6.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus6.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus6.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus6.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus6.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus6.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus6.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus6.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus6.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus6.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus6.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus6.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus6.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus6.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus6.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus6.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull()
      {
        this[this.tableRoomStatus6.ConditionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus6.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull()
      {
        this[this.tableRoomStatus6.StartDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus6.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus6.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus6.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus6.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus6.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus6.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomTypeRow : DataRow
    {
      private SystemDataSet.RoomTypeDataTable tableRoomType;

      [DebuggerNonUserCode]
      internal RoomTypeRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomType = (SystemDataSet.RoomTypeDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomType.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomType' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RmDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomType.RmDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RmDescription' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.RmDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte MaxCard
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomType.MaxCardColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MaxCard' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.MaxCardColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte MinCard
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomType.MinCardColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MinCard' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.MinCardColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomType.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomType.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomType' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomType.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomType.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomType.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRmDescriptionNull() => this.IsNull(this.tableRoomType.RmDescriptionColumn);

      [DebuggerNonUserCode]
      public void SetRmDescriptionNull()
      {
        this[this.tableRoomType.RmDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMaxCardNull() => this.IsNull(this.tableRoomType.MaxCardColumn);

      [DebuggerNonUserCode]
      public void SetMaxCardNull() => this[this.tableRoomType.MaxCardColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsMinCardNull() => this.IsNull(this.tableRoomType.MinCardColumn);

      [DebuggerNonUserCode]
      public void SetMinCardNull() => this[this.tableRoomType.MinCardColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomType.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomType.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomType.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomType.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet1Row : DataRow
    {
      private SystemDataSet.SystemSet1DataTable tableSystemSet1;

      [DebuggerNonUserCode]
      internal SystemSet1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet1 = (SystemDataSet.SystemSet1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet1.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet1.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet1.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet1.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet1.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet1.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet1.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet1.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet1.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet1.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet1.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet1.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet1.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet1.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet1.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet1.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet1.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet1.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet1.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet1.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet1.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet1.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet1.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet1.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet1.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet1.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet1.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet1.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet1.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet1.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet1.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet1.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet1.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet1.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet1.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet1.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet1.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet1.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet1.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet1.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ZoneRow : DataRow
    {
      private SystemDataSet.ZoneDataTable tableZone;

      [DebuggerNonUserCode]
      internal ZoneRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableZone = (SystemDataSet.ZoneDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short ZoneNo
      {
        get
        {
          try
          {
            return (short) this[this.tableZone.ZoneNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ZoneNo' in table 'Zone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableZone.ZoneNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ZoneName
      {
        get
        {
          try
          {
            return (string) this[this.tableZone.ZoneNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ZoneName' in table 'Zone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableZone.ZoneNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingNo
      {
        get
        {
          try
          {
            return (string) this[this.tableZone.BuildingNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingNo' in table 'Zone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableZone.BuildingNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableZone.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'Zone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableZone.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableZone.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Zone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableZone.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsZoneNoNull() => this.IsNull(this.tableZone.ZoneNoColumn);

      [DebuggerNonUserCode]
      public void SetZoneNoNull() => this[this.tableZone.ZoneNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsZoneNameNull() => this.IsNull(this.tableZone.ZoneNameColumn);

      [DebuggerNonUserCode]
      public void SetZoneNameNull() => this[this.tableZone.ZoneNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBuildingNoNull() => this.IsNull(this.tableZone.BuildingNoColumn);

      [DebuggerNonUserCode]
      public void SetBuildingNoNull() => this[this.tableZone.BuildingNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableZone.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableZone.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableZone.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableZone.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet2Row : DataRow
    {
      private SystemDataSet.SystemSet2DataTable tableSystemSet2;

      [DebuggerNonUserCode]
      internal SystemSet2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet2 = (SystemDataSet.SystemSet2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet2.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet2.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet2.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet2.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet2.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet2.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet2.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet2.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet2.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet2.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet2.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet2.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet2.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet2' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet2.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet2.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet2.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet2.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet2.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet2.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet2.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet2.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet2.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet2.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet2.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet2.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet2.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet2.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet2.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet2.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet2.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet2.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet2.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet2.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet2.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet2.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet2.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet2.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet2.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet2.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet2.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet3Row : DataRow
    {
      private SystemDataSet.SystemSet3DataTable tableSystemSet3;

      [DebuggerNonUserCode]
      internal SystemSet3Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet3 = (SystemDataSet.SystemSet3DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet3.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet3.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet3.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet3.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet3.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet3.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet3.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet3.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet3.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet3.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet3.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet3.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet3.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet3' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet3.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet3.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet3.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet3.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet3.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet3.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet3.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet3.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet3.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet3.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet3.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet3.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet3.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet3.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet3.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet3.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet3.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet3.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet3.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet3.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet3.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet3.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet3.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet3.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet3.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet3.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet3.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet4Row : DataRow
    {
      private SystemDataSet.SystemSet4DataTable tableSystemSet4;

      [DebuggerNonUserCode]
      internal SystemSet4Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet4 = (SystemDataSet.SystemSet4DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet4.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet4.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet4.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet4.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet4.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet4.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet4.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet4.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet4.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet4.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet4.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet4.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet4.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet4' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet4.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet4.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet4.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet4.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet4.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet4.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet4.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet4.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet4.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet4.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet4.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet4.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet4.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet4.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet4.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet4.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet4.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet4.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet4.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet4.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet4.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet4.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet4.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet4.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet4.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet4.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet4.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet5Row : DataRow
    {
      private SystemDataSet.SystemSet5DataTable tableSystemSet5;

      [DebuggerNonUserCode]
      internal SystemSet5Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet5 = (SystemDataSet.SystemSet5DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet5.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet5.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet5.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet5.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet5.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet5.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet5.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet5.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet5.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet5.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet5.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet5.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet5.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet5' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet5.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet5.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet5.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet5.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet5.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet5.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet5.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet5.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet5.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet5.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet5.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet5.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet5.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet5.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet5.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet5.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet5.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet5.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet5.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet5.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet5.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet5.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet5.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet5.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet5.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet5.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet5.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet6Row : DataRow
    {
      private SystemDataSet.SystemSet6DataTable tableSystemSet6;

      [DebuggerNonUserCode]
      internal SystemSet6Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet6 = (SystemDataSet.SystemSet6DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet6.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet6.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet6.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet6.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet6.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet6.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet6.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet6.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet6.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet6.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet6.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet6.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet6.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet6' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet6.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet6.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet6.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet6.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet6.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet6.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet6.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet6.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet6.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet6.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet6.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet6.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet6.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet6.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet6.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet6.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet6.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet6.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet6.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet6.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet6.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet6.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet6.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet6.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet6.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet6.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet6.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSetRow : DataRow
    {
      private SystemDataSet.SystemSetDataTable tableSystemSet;

      [DebuggerNonUserCode]
      internal SystemSetRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSystemSet = (SystemDataSet.SystemSetDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public short SystemID
      {
        get
        {
          try
          {
            return (short) this[this.tableSystemSet.SystemIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SystemID' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.SystemIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Description' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BuildingType
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet.BuildingTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BuildingType' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.BuildingTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Comport
      {
        get
        {
          try
          {
            return (byte) this[this.tableSystemSet.ComportColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comport' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.ComportColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public double GSTRate
      {
        get
        {
          try
          {
            return (double) this[this.tableSystemSet.GSTRateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GSTRate' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.GSTRateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Bonus
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet.BonusColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Bonus' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.BonusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int MGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet.MGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MGraceDefault' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.MGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int WGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet.WGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'WGraceDefault' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.WGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int DGraceDefault
      {
        get
        {
          try
          {
            return (int) this[this.tableSystemSet.DGraceDefaultColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DGraceDefault' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.DGraceDefaultColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableSystemSet.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string HotelCode
      {
        get
        {
          try
          {
            return (string) this[this.tableSystemSet.HotelCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'HotelCode' in table 'SystemSet' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSystemSet.HotelCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSystemIDNull() => this.IsNull(this.tableSystemSet.SystemIDColumn);

      [DebuggerNonUserCode]
      public void SetSystemIDNull() => this[this.tableSystemSet.SystemIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableSystemSet.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSystemSet.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingTypeNull() => this.IsNull(this.tableSystemSet.BuildingTypeColumn);

      [DebuggerNonUserCode]
      public void SetBuildingTypeNull()
      {
        this[this.tableSystemSet.BuildingTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsComportNull() => this.IsNull(this.tableSystemSet.ComportColumn);

      [DebuggerNonUserCode]
      public void SetComportNull() => this[this.tableSystemSet.ComportColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsGSTRateNull() => this.IsNull(this.tableSystemSet.GSTRateColumn);

      [DebuggerNonUserCode]
      public void SetGSTRateNull() => this[this.tableSystemSet.GSTRateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBonusNull() => this.IsNull(this.tableSystemSet.BonusColumn);

      [DebuggerNonUserCode]
      public void SetBonusNull() => this[this.tableSystemSet.BonusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableSystemSet.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableSystemSet.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsMGraceDefaultNull() => this.IsNull(this.tableSystemSet.MGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetMGraceDefaultNull()
      {
        this[this.tableSystemSet.MGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsWGraceDefaultNull() => this.IsNull(this.tableSystemSet.WGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetWGraceDefaultNull()
      {
        this[this.tableSystemSet.WGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsDGraceDefaultNull() => this.IsNull(this.tableSystemSet.DGraceDefaultColumn);

      [DebuggerNonUserCode]
      public void SetDGraceDefaultNull()
      {
        this[this.tableSystemSet.DGraceDefaultColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableSystemSet.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableSystemSet.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableSystemSet.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableSystemSet.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsHotelCodeNull() => this.IsNull(this.tableSystemSet.HotelCodeColumn);

      [DebuggerNonUserCode]
      public void SetHotelCodeNull() => this[this.tableSystemSet.HotelCodeColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class BonusRowChangeEvent : EventArgs
    {
      private SystemDataSet.BonusRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public BonusRowChangeEvent(SystemDataSet.BonusRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.BonusRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus1RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus1RowChangeEvent(SystemDataSet.Bonus1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus2RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus2RowChangeEvent(SystemDataSet.Bonus2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus3RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus3Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus3RowChangeEvent(SystemDataSet.Bonus3Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus3Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus4RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus4Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus4RowChangeEvent(SystemDataSet.Bonus4Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus4Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus5RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus5Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus5RowChangeEvent(SystemDataSet.Bonus5Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus5Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Bonus6RowChangeEvent : EventArgs
    {
      private SystemDataSet.Bonus6Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Bonus6RowChangeEvent(SystemDataSet.Bonus6Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.Bonus6Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class BuildingRowChangeEvent : EventArgs
    {
      private SystemDataSet.BuildingRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public BuildingRowChangeEvent(SystemDataSet.BuildingRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.BuildingRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class CountryRowChangeEvent : EventArgs
    {
      private SystemDataSet.CountryRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public CountryRowChangeEvent(SystemDataSet.CountryRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.CountryRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class FloorRowChangeEvent : EventArgs
    {
      private SystemDataSet.FloorRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public FloorRowChangeEvent(SystemDataSet.FloorRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.FloorRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistoryRowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistoryRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistoryRowChangeEvent(SystemDataSet.GSTHistoryRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistoryRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory1RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory1RowChangeEvent(SystemDataSet.GSTHistory1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory2RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory2RowChangeEvent(SystemDataSet.GSTHistory2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory3RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory3Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory3RowChangeEvent(SystemDataSet.GSTHistory3Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory3Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory4RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory4Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory4RowChangeEvent(SystemDataSet.GSTHistory4Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory4Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory5RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory5Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory5RowChangeEvent(SystemDataSet.GSTHistory5Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory5Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GSTHistory6RowChangeEvent : EventArgs
    {
      private SystemDataSet.GSTHistory6Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public GSTHistory6RowChangeEvent(SystemDataSet.GSTHistory6Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.GSTHistory6Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomRowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomRowChangeEvent(SystemDataSet.RoomRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus1RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus1RowChangeEvent(SystemDataSet.RoomStatus1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus2RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus2RowChangeEvent(SystemDataSet.RoomStatus2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus3RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus3Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus3RowChangeEvent(SystemDataSet.RoomStatus3Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus3Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus4RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus4Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus4RowChangeEvent(SystemDataSet.RoomStatus4Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus4Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus5RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus5Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus5RowChangeEvent(SystemDataSet.RoomStatus5Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus5Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatus6RowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomStatus6Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatus6RowChangeEvent(SystemDataSet.RoomStatus6Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomStatus6Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomTypeRowChangeEvent : EventArgs
    {
      private SystemDataSet.RoomTypeRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomTypeRowChangeEvent(SystemDataSet.RoomTypeRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.RoomTypeRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet1RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet1RowChangeEvent(SystemDataSet.SystemSet1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ZoneRowChangeEvent : EventArgs
    {
      private SystemDataSet.ZoneRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ZoneRowChangeEvent(SystemDataSet.ZoneRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.ZoneRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet2RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet2RowChangeEvent(SystemDataSet.SystemSet2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet3RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet3Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet3RowChangeEvent(SystemDataSet.SystemSet3Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet3Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet4RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet4Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet4RowChangeEvent(SystemDataSet.SystemSet4Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet4Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet5RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet5Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet5RowChangeEvent(SystemDataSet.SystemSet5Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet5Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSet6RowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSet6Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSet6RowChangeEvent(SystemDataSet.SystemSet6Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSet6Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SystemSetRowChangeEvent : EventArgs
    {
      private SystemDataSet.SystemSetRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SystemSetRowChangeEvent(SystemDataSet.SystemSetRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public SystemDataSet.SystemSetRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
