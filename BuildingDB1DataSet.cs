// Decompiled with JetBrains decompiler
// Type: AMS.BuildingDB1DataSet
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
  [HelpKeyword("vs.data.DataSet")]
  [XmlRoot("BuildingDB1DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class BuildingDB1DataSet : DataSet
  {
    private BuildingDB1DataSet.CardNoDataTable tableCardNo;
    private BuildingDB1DataSet.CardTransDataTable tableCardTrans;
    private BuildingDB1DataSet.AllLockedRecordDataTable tableAllLockedRecord;
    private BuildingDB1DataSet.EventLogDataTable tableEventLog;
    private BuildingDB1DataSet.ExtraChargeDataTable tableExtraCharge;
    private BuildingDB1DataSet.KeyChargesDataTable tableKeyCharges;
    private BuildingDB1DataSet.LastTransDataTable tableLastTrans;
    private BuildingDB1DataSet.LockedRecordDataTable tableLockedRecord;
    private BuildingDB1DataSet.LogInOutDataTable tableLogInOut;
    private BuildingDB1DataSet.ReserveDataTable tableReserve;
    private BuildingDB1DataSet.RoomStatusDataTable tableRoomStatus;
    private BuildingDB1DataSet.UnitRefDataTable tableUnitRef;
    private BuildingDB1DataSet.ClientAccDataTable tableClientAcc;
    private BuildingDB1DataSet.ClientDataTable tableClient;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public BuildingDB1DataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected BuildingDB1DataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (CardNo)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.CardNoDataTable(dataSet.Tables[nameof (CardNo)]));
          if (dataSet.Tables[nameof (CardTrans)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.CardTransDataTable(dataSet.Tables[nameof (CardTrans)]));
          if (dataSet.Tables[nameof (AllLockedRecord)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.AllLockedRecordDataTable(dataSet.Tables[nameof (AllLockedRecord)]));
          if (dataSet.Tables[nameof (EventLog)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.EventLogDataTable(dataSet.Tables[nameof (EventLog)]));
          if (dataSet.Tables[nameof (ExtraCharge)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.ExtraChargeDataTable(dataSet.Tables[nameof (ExtraCharge)]));
          if (dataSet.Tables[nameof (KeyCharges)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.KeyChargesDataTable(dataSet.Tables[nameof (KeyCharges)]));
          if (dataSet.Tables[nameof (LastTrans)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.LastTransDataTable(dataSet.Tables[nameof (LastTrans)]));
          if (dataSet.Tables[nameof (LockedRecord)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.LockedRecordDataTable(dataSet.Tables[nameof (LockedRecord)]));
          if (dataSet.Tables[nameof (LogInOut)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.LogInOutDataTable(dataSet.Tables[nameof (LogInOut)]));
          if (dataSet.Tables[nameof (Reserve)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.ReserveDataTable(dataSet.Tables[nameof (Reserve)]));
          if (dataSet.Tables[nameof (RoomStatus)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.RoomStatusDataTable(dataSet.Tables[nameof (RoomStatus)]));
          if (dataSet.Tables[nameof (UnitRef)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.UnitRefDataTable(dataSet.Tables[nameof (UnitRef)]));
          if (dataSet.Tables[nameof (ClientAcc)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.ClientAccDataTable(dataSet.Tables[nameof (ClientAcc)]));
          if (dataSet.Tables[nameof (Client)] != null)
            base.Tables.Add((DataTable) new BuildingDB1DataSet.ClientDataTable(dataSet.Tables[nameof (Client)]));
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
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.CardNoDataTable CardNo => this.tableCardNo;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.CardTransDataTable CardTrans => this.tableCardTrans;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.AllLockedRecordDataTable AllLockedRecord => this.tableAllLockedRecord;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.EventLogDataTable EventLog => this.tableEventLog;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.ExtraChargeDataTable ExtraCharge => this.tableExtraCharge;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public BuildingDB1DataSet.KeyChargesDataTable KeyCharges => this.tableKeyCharges;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public BuildingDB1DataSet.LastTransDataTable LastTrans => this.tableLastTrans;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public BuildingDB1DataSet.LockedRecordDataTable LockedRecord => this.tableLockedRecord;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public BuildingDB1DataSet.LogInOutDataTable LogInOut => this.tableLogInOut;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public BuildingDB1DataSet.ReserveDataTable Reserve => this.tableReserve;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public BuildingDB1DataSet.RoomStatusDataTable RoomStatus => this.tableRoomStatus;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.UnitRefDataTable UnitRef => this.tableUnitRef;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.ClientAccDataTable ClientAcc => this.tableClientAcc;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public BuildingDB1DataSet.ClientDataTable Client => this.tableClient;

    [Browsable(true)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
      BuildingDB1DataSet buildingDb1DataSet = (BuildingDB1DataSet) base.Clone();
      buildingDb1DataSet.InitVars();
      buildingDb1DataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) buildingDb1DataSet;
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
        if (dataSet.Tables["CardNo"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.CardNoDataTable(dataSet.Tables["CardNo"]));
        if (dataSet.Tables["CardTrans"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.CardTransDataTable(dataSet.Tables["CardTrans"]));
        if (dataSet.Tables["AllLockedRecord"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.AllLockedRecordDataTable(dataSet.Tables["AllLockedRecord"]));
        if (dataSet.Tables["EventLog"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.EventLogDataTable(dataSet.Tables["EventLog"]));
        if (dataSet.Tables["ExtraCharge"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.ExtraChargeDataTable(dataSet.Tables["ExtraCharge"]));
        if (dataSet.Tables["KeyCharges"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.KeyChargesDataTable(dataSet.Tables["KeyCharges"]));
        if (dataSet.Tables["LastTrans"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.LastTransDataTable(dataSet.Tables["LastTrans"]));
        if (dataSet.Tables["LockedRecord"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.LockedRecordDataTable(dataSet.Tables["LockedRecord"]));
        if (dataSet.Tables["LogInOut"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.LogInOutDataTable(dataSet.Tables["LogInOut"]));
        if (dataSet.Tables["Reserve"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.ReserveDataTable(dataSet.Tables["Reserve"]));
        if (dataSet.Tables["RoomStatus"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.RoomStatusDataTable(dataSet.Tables["RoomStatus"]));
        if (dataSet.Tables["UnitRef"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.UnitRefDataTable(dataSet.Tables["UnitRef"]));
        if (dataSet.Tables["ClientAcc"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.ClientAccDataTable(dataSet.Tables["ClientAcc"]));
        if (dataSet.Tables["Client"] != null)
          base.Tables.Add((DataTable) new BuildingDB1DataSet.ClientDataTable(dataSet.Tables["Client"]));
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
      this.tableCardNo = (BuildingDB1DataSet.CardNoDataTable) base.Tables["CardNo"];
      if (initTable && this.tableCardNo != null)
        this.tableCardNo.InitVars();
      this.tableCardTrans = (BuildingDB1DataSet.CardTransDataTable) base.Tables["CardTrans"];
      if (initTable && this.tableCardTrans != null)
        this.tableCardTrans.InitVars();
      this.tableAllLockedRecord = (BuildingDB1DataSet.AllLockedRecordDataTable) base.Tables["AllLockedRecord"];
      if (initTable && this.tableAllLockedRecord != null)
        this.tableAllLockedRecord.InitVars();
      this.tableEventLog = (BuildingDB1DataSet.EventLogDataTable) base.Tables["EventLog"];
      if (initTable && this.tableEventLog != null)
        this.tableEventLog.InitVars();
      this.tableExtraCharge = (BuildingDB1DataSet.ExtraChargeDataTable) base.Tables["ExtraCharge"];
      if (initTable && this.tableExtraCharge != null)
        this.tableExtraCharge.InitVars();
      this.tableKeyCharges = (BuildingDB1DataSet.KeyChargesDataTable) base.Tables["KeyCharges"];
      if (initTable && this.tableKeyCharges != null)
        this.tableKeyCharges.InitVars();
      this.tableLastTrans = (BuildingDB1DataSet.LastTransDataTable) base.Tables["LastTrans"];
      if (initTable && this.tableLastTrans != null)
        this.tableLastTrans.InitVars();
      this.tableLockedRecord = (BuildingDB1DataSet.LockedRecordDataTable) base.Tables["LockedRecord"];
      if (initTable && this.tableLockedRecord != null)
        this.tableLockedRecord.InitVars();
      this.tableLogInOut = (BuildingDB1DataSet.LogInOutDataTable) base.Tables["LogInOut"];
      if (initTable && this.tableLogInOut != null)
        this.tableLogInOut.InitVars();
      this.tableReserve = (BuildingDB1DataSet.ReserveDataTable) base.Tables["Reserve"];
      if (initTable && this.tableReserve != null)
        this.tableReserve.InitVars();
      this.tableRoomStatus = (BuildingDB1DataSet.RoomStatusDataTable) base.Tables["RoomStatus"];
      if (initTable && this.tableRoomStatus != null)
        this.tableRoomStatus.InitVars();
      this.tableUnitRef = (BuildingDB1DataSet.UnitRefDataTable) base.Tables["UnitRef"];
      if (initTable && this.tableUnitRef != null)
        this.tableUnitRef.InitVars();
      this.tableClientAcc = (BuildingDB1DataSet.ClientAccDataTable) base.Tables["ClientAcc"];
      if (initTable && this.tableClientAcc != null)
        this.tableClientAcc.InitVars();
      this.tableClient = (BuildingDB1DataSet.ClientDataTable) base.Tables["Client"];
      if (!initTable || this.tableClient == null)
        return;
      this.tableClient.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "BuildingDB1DataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/BuildingDB1DataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableCardNo = new BuildingDB1DataSet.CardNoDataTable();
      base.Tables.Add((DataTable) this.tableCardNo);
      this.tableCardTrans = new BuildingDB1DataSet.CardTransDataTable();
      base.Tables.Add((DataTable) this.tableCardTrans);
      this.tableAllLockedRecord = new BuildingDB1DataSet.AllLockedRecordDataTable();
      base.Tables.Add((DataTable) this.tableAllLockedRecord);
      this.tableEventLog = new BuildingDB1DataSet.EventLogDataTable();
      base.Tables.Add((DataTable) this.tableEventLog);
      this.tableExtraCharge = new BuildingDB1DataSet.ExtraChargeDataTable();
      base.Tables.Add((DataTable) this.tableExtraCharge);
      this.tableKeyCharges = new BuildingDB1DataSet.KeyChargesDataTable();
      base.Tables.Add((DataTable) this.tableKeyCharges);
      this.tableLastTrans = new BuildingDB1DataSet.LastTransDataTable();
      base.Tables.Add((DataTable) this.tableLastTrans);
      this.tableLockedRecord = new BuildingDB1DataSet.LockedRecordDataTable();
      base.Tables.Add((DataTable) this.tableLockedRecord);
      this.tableLogInOut = new BuildingDB1DataSet.LogInOutDataTable();
      base.Tables.Add((DataTable) this.tableLogInOut);
      this.tableReserve = new BuildingDB1DataSet.ReserveDataTable();
      base.Tables.Add((DataTable) this.tableReserve);
      this.tableRoomStatus = new BuildingDB1DataSet.RoomStatusDataTable();
      base.Tables.Add((DataTable) this.tableRoomStatus);
      this.tableUnitRef = new BuildingDB1DataSet.UnitRefDataTable();
      base.Tables.Add((DataTable) this.tableUnitRef);
      this.tableClientAcc = new BuildingDB1DataSet.ClientAccDataTable();
      base.Tables.Add((DataTable) this.tableClientAcc);
      this.tableClient = new BuildingDB1DataSet.ClientDataTable();
      base.Tables.Add((DataTable) this.tableClient);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeCardNo() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeCardTrans() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeAllLockedRecord() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeEventLog() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeExtraCharge() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeKeyCharges() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeLastTrans() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeLockedRecord() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeLogInOut() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeReserve() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeRoomStatus() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeUnitRef() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeClientAcc() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeClient() => false;

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
      BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = buildingDb1DataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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

    public delegate void CardNoRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.CardNoRowChangeEvent e);

    public delegate void CardTransRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.CardTransRowChangeEvent e);

    public delegate void AllLockedRecordRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.AllLockedRecordRowChangeEvent e);

    public delegate void EventLogRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.EventLogRowChangeEvent e);

    public delegate void ExtraChargeRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.ExtraChargeRowChangeEvent e);

    public delegate void KeyChargesRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.KeyChargesRowChangeEvent e);

    public delegate void LastTransRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.LastTransRowChangeEvent e);

    public delegate void LockedRecordRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.LockedRecordRowChangeEvent e);

    public delegate void LogInOutRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.LogInOutRowChangeEvent e);

    public delegate void ReserveRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.ReserveRowChangeEvent e);

    public delegate void RoomStatusRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.RoomStatusRowChangeEvent e);

    public delegate void UnitRefRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.UnitRefRowChangeEvent e);

    public delegate void ClientAccRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.ClientAccRowChangeEvent e);

    public delegate void ClientRowChangeEventHandler(
      object sender,
      BuildingDB1DataSet.ClientRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class CardNoDataTable : DataTable, IEnumerable
    {
      private DataColumn columnCardNo;
      private DataColumn columnRoomNo;
      private DataColumn columnCardType;
      private DataColumn columnClientID;
      private DataColumn columnCardStatus;
      private DataColumn columnKeyCharge;
      private DataColumn columnRecordDate;
      private DataColumn columnRecordTime;
      private DataColumn columnUpdate;
      private DataColumn columnCard_AutoNumber;
      private DataColumn columnCard_HW_ID;
      private DataColumn columnReaderID;

      [DebuggerNonUserCode]
      public CardNoDataTable()
      {
        this.TableName = "CardNo";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal CardNoDataTable(DataTable table)
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
      protected CardNoDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn CardTypeColumn => this.columnCardType;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn CardStatusColumn => this.columnCardStatus;

      [DebuggerNonUserCode]
      public DataColumn KeyChargeColumn => this.columnKeyCharge;

      [DebuggerNonUserCode]
      public DataColumn RecordDateColumn => this.columnRecordDate;

      [DebuggerNonUserCode]
      public DataColumn RecordTimeColumn => this.columnRecordTime;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      public DataColumn Card_AutoNumberColumn => this.columnCard_AutoNumber;

      [DebuggerNonUserCode]
      public DataColumn Card_HW_IDColumn => this.columnCard_HW_ID;

      [DebuggerNonUserCode]
      public DataColumn ReaderIDColumn => this.columnReaderID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardNoRow this[int index]
      {
        get => (BuildingDB1DataSet.CardNoRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.CardNoRowChangeEventHandler CardNoRowChanging;

      public event BuildingDB1DataSet.CardNoRowChangeEventHandler CardNoRowChanged;

      public event BuildingDB1DataSet.CardNoRowChangeEventHandler CardNoRowDeleting;

      public event BuildingDB1DataSet.CardNoRowChangeEventHandler CardNoRowDeleted;

      [DebuggerNonUserCode]
      public void AddCardNoRow(BuildingDB1DataSet.CardNoRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardNoRow AddCardNoRow(
        string CardNo,
        string RoomNo,
        string CardType,
        string ClientID,
        byte CardStatus,
        Decimal KeyCharge,
        DateTime RecordDate,
        string RecordTime,
        bool Update,
        string Card_AutoNumber,
        string Card_HW_ID,
        string ReaderID)
      {
        BuildingDB1DataSet.CardNoRow row = (BuildingDB1DataSet.CardNoRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) CardNo,
          (object) RoomNo,
          (object) CardType,
          (object) ClientID,
          (object) CardStatus,
          (object) KeyCharge,
          (object) RecordDate,
          (object) RecordTime,
          (object) Update,
          (object) Card_AutoNumber,
          (object) Card_HW_ID,
          (object) ReaderID
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
        BuildingDB1DataSet.CardNoDataTable cardNoDataTable = (BuildingDB1DataSet.CardNoDataTable) base.Clone();
        cardNoDataTable.InitVars();
        return (DataTable) cardNoDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.CardNoDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnCardNo = this.Columns["CardNo"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCardType = this.Columns["CardType"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCardStatus = this.Columns["CardStatus"];
        this.columnKeyCharge = this.Columns["KeyCharge"];
        this.columnRecordDate = this.Columns["RecordDate"];
        this.columnRecordTime = this.Columns["RecordTime"];
        this.columnUpdate = this.Columns["Update"];
        this.columnCard_AutoNumber = this.Columns["Card_AutoNumber"];
        this.columnCard_HW_ID = this.Columns["Card_HW_ID"];
        this.columnReaderID = this.Columns["ReaderID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCardType = new DataColumn("CardType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardType);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCardStatus = new DataColumn("CardStatus", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardStatus);
        this.columnKeyCharge = new DataColumn("KeyCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKeyCharge);
        this.columnRecordDate = new DataColumn("RecordDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRecordDate);
        this.columnRecordTime = new DataColumn("RecordTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRecordTime);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnCard_AutoNumber = new DataColumn("Card_AutoNumber", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCard_AutoNumber);
        this.columnCard_HW_ID = new DataColumn("Card_HW_ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCard_HW_ID);
        this.columnReaderID = new DataColumn("ReaderID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReaderID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnCardNo
        }, false));
        this.columnCardNo.Unique = true;
        this.columnCardNo.MaxLength = 5;
        this.columnRoomNo.MaxLength = 5;
        this.columnCardType.MaxLength = 15;
        this.columnClientID.MaxLength = 10;
        this.columnRecordTime.MaxLength = 12;
        this.columnCard_AutoNumber.MaxLength = 16;
        this.columnCard_HW_ID.MaxLength = 16;
        this.columnReaderID.MaxLength = 16;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardNoRow NewCardNoRow()
      {
        return (BuildingDB1DataSet.CardNoRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.CardNoRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.CardNoRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CardNoRowChanged == null)
          return;
        this.CardNoRowChanged((object) this, new BuildingDB1DataSet.CardNoRowChangeEvent((BuildingDB1DataSet.CardNoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CardNoRowChanging == null)
          return;
        this.CardNoRowChanging((object) this, new BuildingDB1DataSet.CardNoRowChangeEvent((BuildingDB1DataSet.CardNoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CardNoRowDeleted == null)
          return;
        this.CardNoRowDeleted((object) this, new BuildingDB1DataSet.CardNoRowChangeEvent((BuildingDB1DataSet.CardNoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CardNoRowDeleting == null)
          return;
        this.CardNoRowDeleting((object) this, new BuildingDB1DataSet.CardNoRowChangeEvent((BuildingDB1DataSet.CardNoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveCardNoRow(BuildingDB1DataSet.CardNoRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CardNoDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class CardTransDataTable : DataTable, IEnumerable
    {
      private DataColumn columnTransID;
      private DataColumn columnClientID;
      private DataColumn columnCardNo;
      private DataColumn columnCardType;
      private DataColumn columnRoomNo;
      private DataColumn columnCondition;
      private DataColumn columnReserveRef;
      private DataColumn columnOldRoom;
      private DataColumn columnPreviousAdvance;
      private DataColumn columnAdvancedPayment;
      private DataColumn columnBalance;
      private DataColumn columnBond;
      private DataColumn columnRBA;
      private DataColumn columnDeposit;
      private DataColumn columnKeyDeposit;
      private DataColumn columnExtraCharge;
      private DataColumn columnExDescription;
      private DataColumn columnRoomCharge;
      private DataColumn columnTransType;
      private DataColumn columnTransDate;
      private DataColumn columnTransTime;
      private DataColumn columnValidStart;
      private DataColumn columnValidEnd;
      private DataColumn columnCheckInDate;
      private DataColumn columnCheckInTime;
      private DataColumn columnCheckOutTime;
      private DataColumn columnCheckOutDate;
      private DataColumn columnChargeType;
      private DataColumn columnGracePeriod;
      private DataColumn columnBonusClaim;
      private DataColumn columnGST;
      private DataColumn columnLastPayment;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public CardTransDataTable()
      {
        this.TableName = "CardTrans";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal CardTransDataTable(DataTable table)
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
      protected CardTransDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn TransIDColumn => this.columnTransID;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn CardTypeColumn => this.columnCardType;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn ReserveRefColumn => this.columnReserveRef;

      [DebuggerNonUserCode]
      public DataColumn OldRoomColumn => this.columnOldRoom;

      [DebuggerNonUserCode]
      public DataColumn PreviousAdvanceColumn => this.columnPreviousAdvance;

      [DebuggerNonUserCode]
      public DataColumn AdvancedPaymentColumn => this.columnAdvancedPayment;

      [DebuggerNonUserCode]
      public DataColumn BalanceColumn => this.columnBalance;

      [DebuggerNonUserCode]
      public DataColumn BondColumn => this.columnBond;

      [DebuggerNonUserCode]
      public DataColumn RBAColumn => this.columnRBA;

      [DebuggerNonUserCode]
      public DataColumn DepositColumn => this.columnDeposit;

      [DebuggerNonUserCode]
      public DataColumn KeyDepositColumn => this.columnKeyDeposit;

      [DebuggerNonUserCode]
      public DataColumn ExtraChargeColumn => this.columnExtraCharge;

      [DebuggerNonUserCode]
      public DataColumn ExDescriptionColumn => this.columnExDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomChargeColumn => this.columnRoomCharge;

      [DebuggerNonUserCode]
      public DataColumn TransTypeColumn => this.columnTransType;

      [DebuggerNonUserCode]
      public DataColumn TransDateColumn => this.columnTransDate;

      [DebuggerNonUserCode]
      public DataColumn TransTimeColumn => this.columnTransTime;

      [DebuggerNonUserCode]
      public DataColumn ValidStartColumn => this.columnValidStart;

      [DebuggerNonUserCode]
      public DataColumn ValidEndColumn => this.columnValidEnd;

      [DebuggerNonUserCode]
      public DataColumn CheckInDateColumn => this.columnCheckInDate;

      [DebuggerNonUserCode]
      public DataColumn CheckInTimeColumn => this.columnCheckInTime;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn CheckOutDateColumn => this.columnCheckOutDate;

      [DebuggerNonUserCode]
      public DataColumn ChargeTypeColumn => this.columnChargeType;

      [DebuggerNonUserCode]
      public DataColumn GracePeriodColumn => this.columnGracePeriod;

      [DebuggerNonUserCode]
      public DataColumn BonusClaimColumn => this.columnBonusClaim;

      [DebuggerNonUserCode]
      public DataColumn GSTColumn => this.columnGST;

      [DebuggerNonUserCode]
      public DataColumn LastPaymentColumn => this.columnLastPayment;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardTransRow this[int index]
      {
        get => (BuildingDB1DataSet.CardTransRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.CardTransRowChangeEventHandler CardTransRowChanging;

      public event BuildingDB1DataSet.CardTransRowChangeEventHandler CardTransRowChanged;

      public event BuildingDB1DataSet.CardTransRowChangeEventHandler CardTransRowDeleting;

      public event BuildingDB1DataSet.CardTransRowChangeEventHandler CardTransRowDeleted;

      [DebuggerNonUserCode]
      public void AddCardTransRow(BuildingDB1DataSet.CardTransRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardTransRow AddCardTransRow(
        string ClientID,
        string CardNo,
        string CardType,
        string RoomNo,
        string Condition,
        string ReserveRef,
        string OldRoom,
        Decimal PreviousAdvance,
        Decimal AdvancedPayment,
        Decimal Balance,
        Decimal Bond,
        Decimal RBA,
        Decimal Deposit,
        Decimal KeyDeposit,
        Decimal ExtraCharge,
        string ExDescription,
        Decimal RoomCharge,
        string TransType,
        DateTime TransDate,
        string TransTime,
        DateTime ValidStart,
        DateTime ValidEnd,
        DateTime CheckInDate,
        string CheckInTime,
        string CheckOutTime,
        DateTime CheckOutDate,
        string ChargeType,
        short GracePeriod,
        Decimal BonusClaim,
        Decimal GST,
        Decimal LastPayment,
        string StaffID,
        bool Update)
      {
        BuildingDB1DataSet.CardTransRow row = (BuildingDB1DataSet.CardTransRow) this.NewRow();
        object[] objArray = new object[34]
        {
          null,
          (object) ClientID,
          (object) CardNo,
          (object) CardType,
          (object) RoomNo,
          (object) Condition,
          (object) ReserveRef,
          (object) OldRoom,
          (object) PreviousAdvance,
          (object) AdvancedPayment,
          (object) Balance,
          (object) Bond,
          (object) RBA,
          (object) Deposit,
          (object) KeyDeposit,
          (object) ExtraCharge,
          (object) ExDescription,
          (object) RoomCharge,
          (object) TransType,
          (object) TransDate,
          (object) TransTime,
          (object) ValidStart,
          (object) ValidEnd,
          (object) CheckInDate,
          (object) CheckInTime,
          (object) CheckOutTime,
          (object) CheckOutDate,
          (object) ChargeType,
          (object) GracePeriod,
          (object) BonusClaim,
          (object) GST,
          (object) LastPayment,
          (object) StaffID,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardTransRow FindByTransID(int TransID)
      {
        return (BuildingDB1DataSet.CardTransRow) this.Rows.Find(new object[1]
        {
          (object) TransID
        });
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        BuildingDB1DataSet.CardTransDataTable cardTransDataTable = (BuildingDB1DataSet.CardTransDataTable) base.Clone();
        cardTransDataTable.InitVars();
        return (DataTable) cardTransDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.CardTransDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnTransID = this.Columns["TransID"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnCardType = this.Columns["CardType"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCondition = this.Columns["Condition"];
        this.columnReserveRef = this.Columns["ReserveRef"];
        this.columnOldRoom = this.Columns["OldRoom"];
        this.columnPreviousAdvance = this.Columns["PreviousAdvance"];
        this.columnAdvancedPayment = this.Columns["AdvancedPayment"];
        this.columnBalance = this.Columns["Balance"];
        this.columnBond = this.Columns["Bond"];
        this.columnRBA = this.Columns["RBA"];
        this.columnDeposit = this.Columns["Deposit"];
        this.columnKeyDeposit = this.Columns["KeyDeposit"];
        this.columnExtraCharge = this.Columns["ExtraCharge"];
        this.columnExDescription = this.Columns["ExDescription"];
        this.columnRoomCharge = this.Columns["RoomCharge"];
        this.columnTransType = this.Columns["TransType"];
        this.columnTransDate = this.Columns["TransDate"];
        this.columnTransTime = this.Columns["TransTime"];
        this.columnValidStart = this.Columns["ValidStart"];
        this.columnValidEnd = this.Columns["ValidEnd"];
        this.columnCheckInDate = this.Columns["CheckInDate"];
        this.columnCheckInTime = this.Columns["CheckInTime"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnCheckOutDate = this.Columns["CheckOutDate"];
        this.columnChargeType = this.Columns["ChargeType"];
        this.columnGracePeriod = this.Columns["GracePeriod"];
        this.columnBonusClaim = this.Columns["BonusClaim"];
        this.columnGST = this.Columns["GST"];
        this.columnLastPayment = this.Columns["LastPayment"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnTransID = new DataColumn("TransID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransID);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnCardType = new DataColumn("CardType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardType);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnReserveRef = new DataColumn("ReserveRef", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReserveRef);
        this.columnOldRoom = new DataColumn("OldRoom", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOldRoom);
        this.columnPreviousAdvance = new DataColumn("PreviousAdvance", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPreviousAdvance);
        this.columnAdvancedPayment = new DataColumn("AdvancedPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAdvancedPayment);
        this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBalance);
        this.columnBond = new DataColumn("Bond", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBond);
        this.columnRBA = new DataColumn("RBA", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRBA);
        this.columnDeposit = new DataColumn("Deposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDeposit);
        this.columnKeyDeposit = new DataColumn("KeyDeposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKeyDeposit);
        this.columnExtraCharge = new DataColumn("ExtraCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExtraCharge);
        this.columnExDescription = new DataColumn("ExDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExDescription);
        this.columnRoomCharge = new DataColumn("RoomCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomCharge);
        this.columnTransType = new DataColumn("TransType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransType);
        this.columnTransDate = new DataColumn("TransDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransDate);
        this.columnTransTime = new DataColumn("TransTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransTime);
        this.columnValidStart = new DataColumn("ValidStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidStart);
        this.columnValidEnd = new DataColumn("ValidEnd", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidEnd);
        this.columnCheckInDate = new DataColumn("CheckInDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInDate);
        this.columnCheckInTime = new DataColumn("CheckInTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInTime);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnCheckOutDate = new DataColumn("CheckOutDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutDate);
        this.columnChargeType = new DataColumn("ChargeType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnChargeType);
        this.columnGracePeriod = new DataColumn("GracePeriod", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGracePeriod);
        this.columnBonusClaim = new DataColumn("BonusClaim", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusClaim);
        this.columnGST = new DataColumn("GST", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGST);
        this.columnLastPayment = new DataColumn("LastPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLastPayment);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnTransID
        }, true));
        this.columnTransID.AutoIncrement = true;
        this.columnTransID.AutoIncrementSeed = -1L;
        this.columnTransID.AutoIncrementStep = -1L;
        this.columnTransID.AllowDBNull = false;
        this.columnTransID.Unique = true;
        this.columnClientID.MaxLength = 10;
        this.columnCardNo.MaxLength = 5;
        this.columnCardType.MaxLength = 15;
        this.columnRoomNo.MaxLength = 5;
        this.columnCondition.MaxLength = 20;
        this.columnReserveRef.MaxLength = 10;
        this.columnOldRoom.MaxLength = 5;
        this.columnExDescription.MaxLength = 30;
        this.columnTransType.MaxLength = 2;
        this.columnTransTime.MaxLength = 12;
        this.columnCheckInTime.MaxLength = 12;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnChargeType.MaxLength = 1;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardTransRow NewCardTransRow()
      {
        return (BuildingDB1DataSet.CardTransRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.CardTransRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.CardTransRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CardTransRowChanged == null)
          return;
        this.CardTransRowChanged((object) this, new BuildingDB1DataSet.CardTransRowChangeEvent((BuildingDB1DataSet.CardTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CardTransRowChanging == null)
          return;
        this.CardTransRowChanging((object) this, new BuildingDB1DataSet.CardTransRowChangeEvent((BuildingDB1DataSet.CardTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CardTransRowDeleted == null)
          return;
        this.CardTransRowDeleted((object) this, new BuildingDB1DataSet.CardTransRowChangeEvent((BuildingDB1DataSet.CardTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CardTransRowDeleting == null)
          return;
        this.CardTransRowDeleting((object) this, new BuildingDB1DataSet.CardTransRowChangeEvent((BuildingDB1DataSet.CardTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveCardTransRow(BuildingDB1DataSet.CardTransRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (CardTransDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class AllLockedRecordDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnCardNo;
      private DataColumn columnCardType;
      private DataColumn columnUnLockSDate;
      private DataColumn columnUnLockSTime;
      private DataColumn columnCollectionSDate;
      private DataColumn columnCollectionSTime;
      private DataColumn columnClientID;
      private DataColumn columnForeName;
      private DataColumn columnSurName;
      private DataColumn columnStaffID;
      private DataColumn columnID;

      [DebuggerNonUserCode]
      public AllLockedRecordDataTable()
      {
        this.TableName = "AllLockedRecord";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal AllLockedRecordDataTable(DataTable table)
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
      protected AllLockedRecordDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn CardTypeColumn => this.columnCardType;

      [DebuggerNonUserCode]
      public DataColumn UnLockSDateColumn => this.columnUnLockSDate;

      [DebuggerNonUserCode]
      public DataColumn UnLockSTimeColumn => this.columnUnLockSTime;

      [DebuggerNonUserCode]
      public DataColumn CollectionSDateColumn => this.columnCollectionSDate;

      [DebuggerNonUserCode]
      public DataColumn CollectionSTimeColumn => this.columnCollectionSTime;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ForeNameColumn => this.columnForeName;

      [DebuggerNonUserCode]
      public DataColumn SurNameColumn => this.columnSurName;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn IDColumn => this.columnID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.AllLockedRecordRow this[int index]
      {
        get => (BuildingDB1DataSet.AllLockedRecordRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.AllLockedRecordRowChangeEventHandler AllLockedRecordRowChanging;

      public event BuildingDB1DataSet.AllLockedRecordRowChangeEventHandler AllLockedRecordRowChanged;

      public event BuildingDB1DataSet.AllLockedRecordRowChangeEventHandler AllLockedRecordRowDeleting;

      public event BuildingDB1DataSet.AllLockedRecordRowChangeEventHandler AllLockedRecordRowDeleted;

      [DebuggerNonUserCode]
      public void AddAllLockedRecordRow(BuildingDB1DataSet.AllLockedRecordRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.AllLockedRecordRow AddAllLockedRecordRow(
        string RoomNo,
        string CardNo,
        string CardType,
        DateTime UnLockSDate,
        string UnLockSTime,
        DateTime CollectionSDate,
        string CollectionSTime,
        string ClientID,
        string ForeName,
        string SurName,
        string StaffID)
      {
        BuildingDB1DataSet.AllLockedRecordRow row = (BuildingDB1DataSet.AllLockedRecordRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) RoomNo,
          (object) CardNo,
          (object) CardType,
          (object) UnLockSDate,
          (object) UnLockSTime,
          (object) CollectionSDate,
          (object) CollectionSTime,
          (object) ClientID,
          (object) ForeName,
          (object) SurName,
          (object) StaffID,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.AllLockedRecordRow FindByID(int ID)
      {
        return (BuildingDB1DataSet.AllLockedRecordRow) this.Rows.Find(new object[1]
        {
          (object) ID
        });
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        BuildingDB1DataSet.AllLockedRecordDataTable lockedRecordDataTable = (BuildingDB1DataSet.AllLockedRecordDataTable) base.Clone();
        lockedRecordDataTable.InitVars();
        return (DataTable) lockedRecordDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.AllLockedRecordDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnCardType = this.Columns["CardType"];
        this.columnUnLockSDate = this.Columns["UnLockSDate"];
        this.columnUnLockSTime = this.Columns["UnLockSTime"];
        this.columnCollectionSDate = this.Columns["CollectionSDate"];
        this.columnCollectionSTime = this.Columns["CollectionSTime"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnForeName = this.Columns["ForeName"];
        this.columnSurName = this.Columns["SurName"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnID = this.Columns["ID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnCardType = new DataColumn("CardType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardType);
        this.columnUnLockSDate = new DataColumn("UnLockSDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUnLockSDate);
        this.columnUnLockSTime = new DataColumn("UnLockSTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUnLockSTime);
        this.columnCollectionSDate = new DataColumn("CollectionSDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCollectionSDate);
        this.columnCollectionSTime = new DataColumn("CollectionSTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCollectionSTime);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnForeName = new DataColumn("ForeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnForeName);
        this.columnSurName = new DataColumn("SurName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSurName);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnRoomNo.MaxLength = 5;
        this.columnCardNo.MaxLength = 5;
        this.columnCardType.MaxLength = 15;
        this.columnUnLockSTime.MaxLength = 12;
        this.columnCollectionSTime.MaxLength = 12;
        this.columnClientID.MaxLength = 10;
        this.columnForeName.MaxLength = 20;
        this.columnSurName.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.AllLockedRecordRow NewAllLockedRecordRow()
      {
        return (BuildingDB1DataSet.AllLockedRecordRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.AllLockedRecordRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.AllLockedRecordRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.AllLockedRecordRowChanged == null)
          return;
        this.AllLockedRecordRowChanged((object) this, new BuildingDB1DataSet.AllLockedRecordRowChangeEvent((BuildingDB1DataSet.AllLockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.AllLockedRecordRowChanging == null)
          return;
        this.AllLockedRecordRowChanging((object) this, new BuildingDB1DataSet.AllLockedRecordRowChangeEvent((BuildingDB1DataSet.AllLockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.AllLockedRecordRowDeleted == null)
          return;
        this.AllLockedRecordRowDeleted((object) this, new BuildingDB1DataSet.AllLockedRecordRowChangeEvent((BuildingDB1DataSet.AllLockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.AllLockedRecordRowDeleting == null)
          return;
        this.AllLockedRecordRowDeleting((object) this, new BuildingDB1DataSet.AllLockedRecordRowChangeEvent((BuildingDB1DataSet.AllLockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveAllLockedRecordRow(BuildingDB1DataSet.AllLockedRecordRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (AllLockedRecordDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class EventLogDataTable : DataTable, IEnumerable
    {
      private DataColumn columnEventDate;
      private DataColumn columnEventTime;
      private DataColumn columnEventCode;
      private DataColumn columnEventDescription;
      private DataColumn columnCardNo;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public EventLogDataTable()
      {
        this.TableName = "EventLog";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal EventLogDataTable(DataTable table)
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
      protected EventLogDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn EventDateColumn => this.columnEventDate;

      [DebuggerNonUserCode]
      public DataColumn EventTimeColumn => this.columnEventTime;

      [DebuggerNonUserCode]
      public DataColumn EventCodeColumn => this.columnEventCode;

      [DebuggerNonUserCode]
      public DataColumn EventDescriptionColumn => this.columnEventDescription;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.EventLogRow this[int index]
      {
        get => (BuildingDB1DataSet.EventLogRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.EventLogRowChangeEventHandler EventLogRowChanging;

      public event BuildingDB1DataSet.EventLogRowChangeEventHandler EventLogRowChanged;

      public event BuildingDB1DataSet.EventLogRowChangeEventHandler EventLogRowDeleting;

      public event BuildingDB1DataSet.EventLogRowChangeEventHandler EventLogRowDeleted;

      [DebuggerNonUserCode]
      public void AddEventLogRow(BuildingDB1DataSet.EventLogRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.EventLogRow AddEventLogRow(
        DateTime EventDate,
        string EventTime,
        string EventCode,
        string EventDescription,
        int CardNo,
        string StaffID)
      {
        BuildingDB1DataSet.EventLogRow row = (BuildingDB1DataSet.EventLogRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) EventDate,
          (object) EventTime,
          (object) EventCode,
          (object) EventDescription,
          (object) CardNo,
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
        BuildingDB1DataSet.EventLogDataTable eventLogDataTable = (BuildingDB1DataSet.EventLogDataTable) base.Clone();
        eventLogDataTable.InitVars();
        return (DataTable) eventLogDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.EventLogDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnEventDate = this.Columns["EventDate"];
        this.columnEventTime = this.Columns["EventTime"];
        this.columnEventCode = this.Columns["EventCode"];
        this.columnEventDescription = this.Columns["EventDescription"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnEventDate = new DataColumn("EventDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEventDate);
        this.columnEventTime = new DataColumn("EventTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEventTime);
        this.columnEventCode = new DataColumn("EventCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEventCode);
        this.columnEventDescription = new DataColumn("EventDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEventDescription);
        this.columnCardNo = new DataColumn("CardNo", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnEventTime.MaxLength = 12;
        this.columnEventCode.MaxLength = 5;
        this.columnEventDescription.MaxLength = 60;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.EventLogRow NewEventLogRow()
      {
        return (BuildingDB1DataSet.EventLogRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.EventLogRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.EventLogRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.EventLogRowChanged == null)
          return;
        this.EventLogRowChanged((object) this, new BuildingDB1DataSet.EventLogRowChangeEvent((BuildingDB1DataSet.EventLogRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.EventLogRowChanging == null)
          return;
        this.EventLogRowChanging((object) this, new BuildingDB1DataSet.EventLogRowChangeEvent((BuildingDB1DataSet.EventLogRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.EventLogRowDeleted == null)
          return;
        this.EventLogRowDeleted((object) this, new BuildingDB1DataSet.EventLogRowChangeEvent((BuildingDB1DataSet.EventLogRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.EventLogRowDeleting == null)
          return;
        this.EventLogRowDeleting((object) this, new BuildingDB1DataSet.EventLogRowChangeEvent((BuildingDB1DataSet.EventLogRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveEventLogRow(BuildingDB1DataSet.EventLogRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (EventLogDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class ExtraChargeDataTable : DataTable, IEnumerable
    {
      private DataColumn columnReceiptID;
      private DataColumn columnClientID;
      private DataColumn columnExDescription;
      private DataColumn columnExtraCharge;

      [DebuggerNonUserCode]
      public ExtraChargeDataTable()
      {
        this.TableName = "ExtraCharge";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ExtraChargeDataTable(DataTable table)
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
      protected ExtraChargeDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ReceiptIDColumn => this.columnReceiptID;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ExDescriptionColumn => this.columnExDescription;

      [DebuggerNonUserCode]
      public DataColumn ExtraChargeColumn => this.columnExtraCharge;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ExtraChargeRow this[int index]
      {
        get => (BuildingDB1DataSet.ExtraChargeRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.ExtraChargeRowChangeEventHandler ExtraChargeRowChanging;

      public event BuildingDB1DataSet.ExtraChargeRowChangeEventHandler ExtraChargeRowChanged;

      public event BuildingDB1DataSet.ExtraChargeRowChangeEventHandler ExtraChargeRowDeleting;

      public event BuildingDB1DataSet.ExtraChargeRowChangeEventHandler ExtraChargeRowDeleted;

      [DebuggerNonUserCode]
      public void AddExtraChargeRow(BuildingDB1DataSet.ExtraChargeRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ExtraChargeRow AddExtraChargeRow(
        int ReceiptID,
        string ClientID,
        string ExDescription,
        Decimal ExtraCharge)
      {
        BuildingDB1DataSet.ExtraChargeRow row = (BuildingDB1DataSet.ExtraChargeRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) ReceiptID,
          (object) ClientID,
          (object) ExDescription,
          (object) ExtraCharge
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
        BuildingDB1DataSet.ExtraChargeDataTable extraChargeDataTable = (BuildingDB1DataSet.ExtraChargeDataTable) base.Clone();
        extraChargeDataTable.InitVars();
        return (DataTable) extraChargeDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.ExtraChargeDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnReceiptID = this.Columns["ReceiptID"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnExDescription = this.Columns["ExDescription"];
        this.columnExtraCharge = this.Columns["ExtraCharge"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnReceiptID = new DataColumn("ReceiptID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReceiptID);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnExDescription = new DataColumn("ExDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExDescription);
        this.columnExtraCharge = new DataColumn("ExtraCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExtraCharge);
        this.columnClientID.MaxLength = 10;
        this.columnExDescription.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ExtraChargeRow NewExtraChargeRow()
      {
        return (BuildingDB1DataSet.ExtraChargeRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.ExtraChargeRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.ExtraChargeRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ExtraChargeRowChanged == null)
          return;
        this.ExtraChargeRowChanged((object) this, new BuildingDB1DataSet.ExtraChargeRowChangeEvent((BuildingDB1DataSet.ExtraChargeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ExtraChargeRowChanging == null)
          return;
        this.ExtraChargeRowChanging((object) this, new BuildingDB1DataSet.ExtraChargeRowChangeEvent((BuildingDB1DataSet.ExtraChargeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ExtraChargeRowDeleted == null)
          return;
        this.ExtraChargeRowDeleted((object) this, new BuildingDB1DataSet.ExtraChargeRowChangeEvent((BuildingDB1DataSet.ExtraChargeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ExtraChargeRowDeleting == null)
          return;
        this.ExtraChargeRowDeleting((object) this, new BuildingDB1DataSet.ExtraChargeRowChangeEvent((BuildingDB1DataSet.ExtraChargeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveExtraChargeRow(BuildingDB1DataSet.ExtraChargeRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ExtraChargeDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class KeyChargesDataTable : DataTable, IEnumerable
    {
      private DataColumn columnBuildingNo;
      private DataColumn columnKeyDeposit;
      private DataColumn columnSpareKeyCharge;
      private DataColumn columnStaffID;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public KeyChargesDataTable()
      {
        this.TableName = "KeyCharges";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal KeyChargesDataTable(DataTable table)
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
      protected KeyChargesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn BuildingNoColumn => this.columnBuildingNo;

      [DebuggerNonUserCode]
      public DataColumn KeyDepositColumn => this.columnKeyDeposit;

      [DebuggerNonUserCode]
      public DataColumn SpareKeyChargeColumn => this.columnSpareKeyCharge;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.KeyChargesRow this[int index]
      {
        get => (BuildingDB1DataSet.KeyChargesRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.KeyChargesRowChangeEventHandler KeyChargesRowChanging;

      public event BuildingDB1DataSet.KeyChargesRowChangeEventHandler KeyChargesRowChanged;

      public event BuildingDB1DataSet.KeyChargesRowChangeEventHandler KeyChargesRowDeleting;

      public event BuildingDB1DataSet.KeyChargesRowChangeEventHandler KeyChargesRowDeleted;

      [DebuggerNonUserCode]
      public void AddKeyChargesRow(BuildingDB1DataSet.KeyChargesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.KeyChargesRow AddKeyChargesRow(
        string BuildingNo,
        Decimal KeyDeposit,
        Decimal SpareKeyCharge,
        string StaffID,
        bool Update)
      {
        BuildingDB1DataSet.KeyChargesRow row = (BuildingDB1DataSet.KeyChargesRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) BuildingNo,
          (object) KeyDeposit,
          (object) SpareKeyCharge,
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
        BuildingDB1DataSet.KeyChargesDataTable chargesDataTable = (BuildingDB1DataSet.KeyChargesDataTable) base.Clone();
        chargesDataTable.InitVars();
        return (DataTable) chargesDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.KeyChargesDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnBuildingNo = this.Columns["BuildingNo"];
        this.columnKeyDeposit = this.Columns["KeyDeposit"];
        this.columnSpareKeyCharge = this.Columns["SpareKeyCharge"];
        this.columnStaffID = this.Columns["StaffID"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBuildingNo);
        this.columnKeyDeposit = new DataColumn("KeyDeposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKeyDeposit);
        this.columnSpareKeyCharge = new DataColumn("SpareKeyCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSpareKeyCharge);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnBuildingNo.MaxLength = 2;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.KeyChargesRow NewKeyChargesRow()
      {
        return (BuildingDB1DataSet.KeyChargesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.KeyChargesRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.KeyChargesRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.KeyChargesRowChanged == null)
          return;
        this.KeyChargesRowChanged((object) this, new BuildingDB1DataSet.KeyChargesRowChangeEvent((BuildingDB1DataSet.KeyChargesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.KeyChargesRowChanging == null)
          return;
        this.KeyChargesRowChanging((object) this, new BuildingDB1DataSet.KeyChargesRowChangeEvent((BuildingDB1DataSet.KeyChargesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.KeyChargesRowDeleted == null)
          return;
        this.KeyChargesRowDeleted((object) this, new BuildingDB1DataSet.KeyChargesRowChangeEvent((BuildingDB1DataSet.KeyChargesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.KeyChargesRowDeleting == null)
          return;
        this.KeyChargesRowDeleting((object) this, new BuildingDB1DataSet.KeyChargesRowChangeEvent((BuildingDB1DataSet.KeyChargesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveKeyChargesRow(BuildingDB1DataSet.KeyChargesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (KeyChargesDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class LastTransDataTable : DataTable, IEnumerable
    {
      private DataColumn columnTransID;
      private DataColumn columnClientID;
      private DataColumn columnCardNo;
      private DataColumn columnCardType;
      private DataColumn columnRoomNo;
      private DataColumn columnCondition;
      private DataColumn columnReserveRef;
      private DataColumn columnOldRoom;
      private DataColumn columnPreviousAdvance;
      private DataColumn columnAdvancedPayment;
      private DataColumn columnBalance;
      private DataColumn columnBond;
      private DataColumn columnRBA;
      private DataColumn columnDeposit;
      private DataColumn columnKeyDeposit;
      private DataColumn columnExtraCharge;
      private DataColumn columnExDescription;
      private DataColumn columnRoomCharge;
      private DataColumn columnTransType;
      private DataColumn columnTransDate;
      private DataColumn columnTransTime;
      private DataColumn columnValidStart;
      private DataColumn columnValidEnd;
      private DataColumn columnCheckInDate;
      private DataColumn columnCheckInTime;
      private DataColumn columnCheckOutTime;
      private DataColumn columnCheckOutDate;
      private DataColumn columnChargeType;
      private DataColumn columnGracePeriod;
      private DataColumn columnBonusClaim;
      private DataColumn columnGST;
      private DataColumn columnLastPayment;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public LastTransDataTable()
      {
        this.TableName = "LastTrans";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal LastTransDataTable(DataTable table)
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
      protected LastTransDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn TransIDColumn => this.columnTransID;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn CardTypeColumn => this.columnCardType;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn ReserveRefColumn => this.columnReserveRef;

      [DebuggerNonUserCode]
      public DataColumn OldRoomColumn => this.columnOldRoom;

      [DebuggerNonUserCode]
      public DataColumn PreviousAdvanceColumn => this.columnPreviousAdvance;

      [DebuggerNonUserCode]
      public DataColumn AdvancedPaymentColumn => this.columnAdvancedPayment;

      [DebuggerNonUserCode]
      public DataColumn BalanceColumn => this.columnBalance;

      [DebuggerNonUserCode]
      public DataColumn BondColumn => this.columnBond;

      [DebuggerNonUserCode]
      public DataColumn RBAColumn => this.columnRBA;

      [DebuggerNonUserCode]
      public DataColumn DepositColumn => this.columnDeposit;

      [DebuggerNonUserCode]
      public DataColumn KeyDepositColumn => this.columnKeyDeposit;

      [DebuggerNonUserCode]
      public DataColumn ExtraChargeColumn => this.columnExtraCharge;

      [DebuggerNonUserCode]
      public DataColumn ExDescriptionColumn => this.columnExDescription;

      [DebuggerNonUserCode]
      public DataColumn RoomChargeColumn => this.columnRoomCharge;

      [DebuggerNonUserCode]
      public DataColumn TransTypeColumn => this.columnTransType;

      [DebuggerNonUserCode]
      public DataColumn TransDateColumn => this.columnTransDate;

      [DebuggerNonUserCode]
      public DataColumn TransTimeColumn => this.columnTransTime;

      [DebuggerNonUserCode]
      public DataColumn ValidStartColumn => this.columnValidStart;

      [DebuggerNonUserCode]
      public DataColumn ValidEndColumn => this.columnValidEnd;

      [DebuggerNonUserCode]
      public DataColumn CheckInDateColumn => this.columnCheckInDate;

      [DebuggerNonUserCode]
      public DataColumn CheckInTimeColumn => this.columnCheckInTime;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn CheckOutDateColumn => this.columnCheckOutDate;

      [DebuggerNonUserCode]
      public DataColumn ChargeTypeColumn => this.columnChargeType;

      [DebuggerNonUserCode]
      public DataColumn GracePeriodColumn => this.columnGracePeriod;

      [DebuggerNonUserCode]
      public DataColumn BonusClaimColumn => this.columnBonusClaim;

      [DebuggerNonUserCode]
      public DataColumn GSTColumn => this.columnGST;

      [DebuggerNonUserCode]
      public DataColumn LastPaymentColumn => this.columnLastPayment;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LastTransRow this[int index]
      {
        get => (BuildingDB1DataSet.LastTransRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.LastTransRowChangeEventHandler LastTransRowChanging;

      public event BuildingDB1DataSet.LastTransRowChangeEventHandler LastTransRowChanged;

      public event BuildingDB1DataSet.LastTransRowChangeEventHandler LastTransRowDeleting;

      public event BuildingDB1DataSet.LastTransRowChangeEventHandler LastTransRowDeleted;

      [DebuggerNonUserCode]
      public void AddLastTransRow(BuildingDB1DataSet.LastTransRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LastTransRow AddLastTransRow(
        int TransID,
        string ClientID,
        string CardNo,
        string CardType,
        string RoomNo,
        string Condition,
        string ReserveRef,
        string OldRoom,
        Decimal PreviousAdvance,
        Decimal AdvancedPayment,
        Decimal Balance,
        Decimal Bond,
        Decimal RBA,
        Decimal Deposit,
        Decimal KeyDeposit,
        Decimal ExtraCharge,
        string ExDescription,
        Decimal RoomCharge,
        string TransType,
        DateTime TransDate,
        string TransTime,
        DateTime ValidStart,
        DateTime ValidEnd,
        DateTime CheckInDate,
        string CheckInTime,
        string CheckOutTime,
        DateTime CheckOutDate,
        string ChargeType,
        short GracePeriod,
        Decimal BonusClaim,
        Decimal GST,
        Decimal LastPayment,
        string StaffID)
      {
        BuildingDB1DataSet.LastTransRow row = (BuildingDB1DataSet.LastTransRow) this.NewRow();
        object[] objArray = new object[33]
        {
          (object) TransID,
          (object) ClientID,
          (object) CardNo,
          (object) CardType,
          (object) RoomNo,
          (object) Condition,
          (object) ReserveRef,
          (object) OldRoom,
          (object) PreviousAdvance,
          (object) AdvancedPayment,
          (object) Balance,
          (object) Bond,
          (object) RBA,
          (object) Deposit,
          (object) KeyDeposit,
          (object) ExtraCharge,
          (object) ExDescription,
          (object) RoomCharge,
          (object) TransType,
          (object) TransDate,
          (object) TransTime,
          (object) ValidStart,
          (object) ValidEnd,
          (object) CheckInDate,
          (object) CheckInTime,
          (object) CheckOutTime,
          (object) CheckOutDate,
          (object) ChargeType,
          (object) GracePeriod,
          (object) BonusClaim,
          (object) GST,
          (object) LastPayment,
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
        BuildingDB1DataSet.LastTransDataTable lastTransDataTable = (BuildingDB1DataSet.LastTransDataTable) base.Clone();
        lastTransDataTable.InitVars();
        return (DataTable) lastTransDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.LastTransDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnTransID = this.Columns["TransID"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnCardType = this.Columns["CardType"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCondition = this.Columns["Condition"];
        this.columnReserveRef = this.Columns["ReserveRef"];
        this.columnOldRoom = this.Columns["OldRoom"];
        this.columnPreviousAdvance = this.Columns["PreviousAdvance"];
        this.columnAdvancedPayment = this.Columns["AdvancedPayment"];
        this.columnBalance = this.Columns["Balance"];
        this.columnBond = this.Columns["Bond"];
        this.columnRBA = this.Columns["RBA"];
        this.columnDeposit = this.Columns["Deposit"];
        this.columnKeyDeposit = this.Columns["KeyDeposit"];
        this.columnExtraCharge = this.Columns["ExtraCharge"];
        this.columnExDescription = this.Columns["ExDescription"];
        this.columnRoomCharge = this.Columns["RoomCharge"];
        this.columnTransType = this.Columns["TransType"];
        this.columnTransDate = this.Columns["TransDate"];
        this.columnTransTime = this.Columns["TransTime"];
        this.columnValidStart = this.Columns["ValidStart"];
        this.columnValidEnd = this.Columns["ValidEnd"];
        this.columnCheckInDate = this.Columns["CheckInDate"];
        this.columnCheckInTime = this.Columns["CheckInTime"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnCheckOutDate = this.Columns["CheckOutDate"];
        this.columnChargeType = this.Columns["ChargeType"];
        this.columnGracePeriod = this.Columns["GracePeriod"];
        this.columnBonusClaim = this.Columns["BonusClaim"];
        this.columnGST = this.Columns["GST"];
        this.columnLastPayment = this.Columns["LastPayment"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnTransID = new DataColumn("TransID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransID);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnCardType = new DataColumn("CardType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardType);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnReserveRef = new DataColumn("ReserveRef", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReserveRef);
        this.columnOldRoom = new DataColumn("OldRoom", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOldRoom);
        this.columnPreviousAdvance = new DataColumn("PreviousAdvance", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPreviousAdvance);
        this.columnAdvancedPayment = new DataColumn("AdvancedPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAdvancedPayment);
        this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBalance);
        this.columnBond = new DataColumn("Bond", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBond);
        this.columnRBA = new DataColumn("RBA", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRBA);
        this.columnDeposit = new DataColumn("Deposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDeposit);
        this.columnKeyDeposit = new DataColumn("KeyDeposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKeyDeposit);
        this.columnExtraCharge = new DataColumn("ExtraCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExtraCharge);
        this.columnExDescription = new DataColumn("ExDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExDescription);
        this.columnRoomCharge = new DataColumn("RoomCharge", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomCharge);
        this.columnTransType = new DataColumn("TransType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransType);
        this.columnTransDate = new DataColumn("TransDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransDate);
        this.columnTransTime = new DataColumn("TransTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransTime);
        this.columnValidStart = new DataColumn("ValidStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidStart);
        this.columnValidEnd = new DataColumn("ValidEnd", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidEnd);
        this.columnCheckInDate = new DataColumn("CheckInDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInDate);
        this.columnCheckInTime = new DataColumn("CheckInTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInTime);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnCheckOutDate = new DataColumn("CheckOutDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutDate);
        this.columnChargeType = new DataColumn("ChargeType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnChargeType);
        this.columnGracePeriod = new DataColumn("GracePeriod", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGracePeriod);
        this.columnBonusClaim = new DataColumn("BonusClaim", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusClaim);
        this.columnGST = new DataColumn("GST", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGST);
        this.columnLastPayment = new DataColumn("LastPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLastPayment);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnTransID
        }, false));
        this.columnTransID.Unique = true;
        this.columnClientID.MaxLength = 10;
        this.columnCardNo.MaxLength = 5;
        this.columnCardType.MaxLength = 15;
        this.columnRoomNo.MaxLength = 5;
        this.columnCondition.MaxLength = 20;
        this.columnReserveRef.MaxLength = 10;
        this.columnOldRoom.MaxLength = 5;
        this.columnExDescription.MaxLength = 30;
        this.columnTransType.MaxLength = 2;
        this.columnTransTime.MaxLength = 12;
        this.columnCheckInTime.MaxLength = 12;
        this.columnCheckOutTime.MaxLength = 12;
        this.columnChargeType.MaxLength = 1;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LastTransRow NewLastTransRow()
      {
        return (BuildingDB1DataSet.LastTransRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.LastTransRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.LastTransRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.LastTransRowChanged == null)
          return;
        this.LastTransRowChanged((object) this, new BuildingDB1DataSet.LastTransRowChangeEvent((BuildingDB1DataSet.LastTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.LastTransRowChanging == null)
          return;
        this.LastTransRowChanging((object) this, new BuildingDB1DataSet.LastTransRowChangeEvent((BuildingDB1DataSet.LastTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.LastTransRowDeleted == null)
          return;
        this.LastTransRowDeleted((object) this, new BuildingDB1DataSet.LastTransRowChangeEvent((BuildingDB1DataSet.LastTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.LastTransRowDeleting == null)
          return;
        this.LastTransRowDeleting((object) this, new BuildingDB1DataSet.LastTransRowChangeEvent((BuildingDB1DataSet.LastTransRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveLastTransRow(BuildingDB1DataSet.LastTransRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (LastTransDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class LockedRecordDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRoomNo;
      private DataColumn columnCardNo;
      private DataColumn columnCardType;
      private DataColumn columnUnlockSDate;
      private DataColumn columnUnlockSTime;
      private DataColumn columnCollectionSDate;
      private DataColumn columnCollectionSTime;
      private DataColumn columnClientID;
      private DataColumn columnForeName;
      private DataColumn columnSurName;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public LockedRecordDataTable()
      {
        this.TableName = "LockedRecord";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal LockedRecordDataTable(DataTable table)
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
      protected LockedRecordDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn CardTypeColumn => this.columnCardType;

      [DebuggerNonUserCode]
      public DataColumn UnlockSDateColumn => this.columnUnlockSDate;

      [DebuggerNonUserCode]
      public DataColumn UnlockSTimeColumn => this.columnUnlockSTime;

      [DebuggerNonUserCode]
      public DataColumn CollectionSDateColumn => this.columnCollectionSDate;

      [DebuggerNonUserCode]
      public DataColumn CollectionSTimeColumn => this.columnCollectionSTime;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ForeNameColumn => this.columnForeName;

      [DebuggerNonUserCode]
      public DataColumn SurNameColumn => this.columnSurName;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LockedRecordRow this[int index]
      {
        get => (BuildingDB1DataSet.LockedRecordRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.LockedRecordRowChangeEventHandler LockedRecordRowChanging;

      public event BuildingDB1DataSet.LockedRecordRowChangeEventHandler LockedRecordRowChanged;

      public event BuildingDB1DataSet.LockedRecordRowChangeEventHandler LockedRecordRowDeleting;

      public event BuildingDB1DataSet.LockedRecordRowChangeEventHandler LockedRecordRowDeleted;

      [DebuggerNonUserCode]
      public void AddLockedRecordRow(BuildingDB1DataSet.LockedRecordRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LockedRecordRow AddLockedRecordRow(
        string RoomNo,
        string CardNo,
        string CardType,
        DateTime UnlockSDate,
        string UnlockSTime,
        DateTime CollectionSDate,
        string CollectionSTime,
        string ClientID,
        string ForeName,
        string SurName,
        string StaffID)
      {
        BuildingDB1DataSet.LockedRecordRow row = (BuildingDB1DataSet.LockedRecordRow) this.NewRow();
        object[] objArray = new object[11]
        {
          (object) RoomNo,
          (object) CardNo,
          (object) CardType,
          (object) UnlockSDate,
          (object) UnlockSTime,
          (object) CollectionSDate,
          (object) CollectionSTime,
          (object) ClientID,
          (object) ForeName,
          (object) SurName,
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
        BuildingDB1DataSet.LockedRecordDataTable lockedRecordDataTable = (BuildingDB1DataSet.LockedRecordDataTable) base.Clone();
        lockedRecordDataTable.InitVars();
        return (DataTable) lockedRecordDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.LockedRecordDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnCardType = this.Columns["CardType"];
        this.columnUnlockSDate = this.Columns["UnlockSDate"];
        this.columnUnlockSTime = this.Columns["UnlockSTime"];
        this.columnCollectionSDate = this.Columns["CollectionSDate"];
        this.columnCollectionSTime = this.Columns["CollectionSTime"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnForeName = this.Columns["ForeName"];
        this.columnSurName = this.Columns["SurName"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnCardType = new DataColumn("CardType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardType);
        this.columnUnlockSDate = new DataColumn("UnlockSDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUnlockSDate);
        this.columnUnlockSTime = new DataColumn("UnlockSTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUnlockSTime);
        this.columnCollectionSDate = new DataColumn("CollectionSDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCollectionSDate);
        this.columnCollectionSTime = new DataColumn("CollectionSTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCollectionSTime);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnForeName = new DataColumn("ForeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnForeName);
        this.columnSurName = new DataColumn("SurName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSurName);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnRoomNo.MaxLength = 5;
        this.columnCardNo.MaxLength = 5;
        this.columnCardType.MaxLength = 15;
        this.columnUnlockSTime.MaxLength = 12;
        this.columnCollectionSTime.MaxLength = 12;
        this.columnClientID.MaxLength = 10;
        this.columnForeName.MaxLength = 20;
        this.columnSurName.MaxLength = 20;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LockedRecordRow NewLockedRecordRow()
      {
        return (BuildingDB1DataSet.LockedRecordRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.LockedRecordRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.LockedRecordRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.LockedRecordRowChanged == null)
          return;
        this.LockedRecordRowChanged((object) this, new BuildingDB1DataSet.LockedRecordRowChangeEvent((BuildingDB1DataSet.LockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.LockedRecordRowChanging == null)
          return;
        this.LockedRecordRowChanging((object) this, new BuildingDB1DataSet.LockedRecordRowChangeEvent((BuildingDB1DataSet.LockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.LockedRecordRowDeleted == null)
          return;
        this.LockedRecordRowDeleted((object) this, new BuildingDB1DataSet.LockedRecordRowChangeEvent((BuildingDB1DataSet.LockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.LockedRecordRowDeleting == null)
          return;
        this.LockedRecordRowDeleting((object) this, new BuildingDB1DataSet.LockedRecordRowChangeEvent((BuildingDB1DataSet.LockedRecordRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveLockedRecordRow(BuildingDB1DataSet.LockedRecordRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (LockedRecordDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class LogInOutDataTable : DataTable, IEnumerable
    {
      private DataColumn columnStaffID;
      private DataColumn columnLogDate;
      private DataColumn columnInTime;
      private DataColumn columnOutTime;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public LogInOutDataTable()
      {
        this.TableName = "LogInOut";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal LogInOutDataTable(DataTable table)
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
      protected LogInOutDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn LogDateColumn => this.columnLogDate;

      [DebuggerNonUserCode]
      public DataColumn InTimeColumn => this.columnInTime;

      [DebuggerNonUserCode]
      public DataColumn OutTimeColumn => this.columnOutTime;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LogInOutRow this[int index]
      {
        get => (BuildingDB1DataSet.LogInOutRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.LogInOutRowChangeEventHandler LogInOutRowChanging;

      public event BuildingDB1DataSet.LogInOutRowChangeEventHandler LogInOutRowChanged;

      public event BuildingDB1DataSet.LogInOutRowChangeEventHandler LogInOutRowDeleting;

      public event BuildingDB1DataSet.LogInOutRowChangeEventHandler LogInOutRowDeleted;

      [DebuggerNonUserCode]
      public void AddLogInOutRow(BuildingDB1DataSet.LogInOutRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LogInOutRow AddLogInOutRow(
        string StaffID,
        DateTime LogDate,
        string InTime,
        string OutTime,
        bool Update)
      {
        BuildingDB1DataSet.LogInOutRow row = (BuildingDB1DataSet.LogInOutRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) StaffID,
          (object) LogDate,
          (object) InTime,
          (object) OutTime,
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
        BuildingDB1DataSet.LogInOutDataTable logInOutDataTable = (BuildingDB1DataSet.LogInOutDataTable) base.Clone();
        logInOutDataTable.InitVars();
        return (DataTable) logInOutDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.LogInOutDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStaffID = this.Columns["StaffID"];
        this.columnLogDate = this.Columns["LogDate"];
        this.columnInTime = this.Columns["InTime"];
        this.columnOutTime = this.Columns["OutTime"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLogDate);
        this.columnInTime = new DataColumn("InTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnInTime);
        this.columnOutTime = new DataColumn("OutTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOutTime);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.columnStaffID.MaxLength = 10;
        this.columnInTime.MaxLength = 12;
        this.columnOutTime.MaxLength = 12;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LogInOutRow NewLogInOutRow()
      {
        return (BuildingDB1DataSet.LogInOutRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.LogInOutRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.LogInOutRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.LogInOutRowChanged == null)
          return;
        this.LogInOutRowChanged((object) this, new BuildingDB1DataSet.LogInOutRowChangeEvent((BuildingDB1DataSet.LogInOutRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.LogInOutRowChanging == null)
          return;
        this.LogInOutRowChanging((object) this, new BuildingDB1DataSet.LogInOutRowChangeEvent((BuildingDB1DataSet.LogInOutRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.LogInOutRowDeleted == null)
          return;
        this.LogInOutRowDeleted((object) this, new BuildingDB1DataSet.LogInOutRowChangeEvent((BuildingDB1DataSet.LogInOutRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.LogInOutRowDeleting == null)
          return;
        this.LogInOutRowDeleting((object) this, new BuildingDB1DataSet.LogInOutRowChangeEvent((BuildingDB1DataSet.LogInOutRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveLogInOutRow(BuildingDB1DataSet.LogInOutRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (LogInOutDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class ReserveDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRefNo;
      private DataColumn columnReserveRef;
      private DataColumn columnRoomNo;
      private DataColumn columnClientID;
      private DataColumn columnStartDate;
      private DataColumn columnEndDate;
      private DataColumn columnReserveType;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public ReserveDataTable()
      {
        this.TableName = "Reserve";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ReserveDataTable(DataTable table)
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
      protected ReserveDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn RefNoColumn => this.columnRefNo;

      [DebuggerNonUserCode]
      public DataColumn ReserveRefColumn => this.columnReserveRef;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn StartDateColumn => this.columnStartDate;

      [DebuggerNonUserCode]
      public DataColumn EndDateColumn => this.columnEndDate;

      [DebuggerNonUserCode]
      public DataColumn ReserveTypeColumn => this.columnReserveType;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ReserveRow this[int index]
      {
        get => (BuildingDB1DataSet.ReserveRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.ReserveRowChangeEventHandler ReserveRowChanging;

      public event BuildingDB1DataSet.ReserveRowChangeEventHandler ReserveRowChanged;

      public event BuildingDB1DataSet.ReserveRowChangeEventHandler ReserveRowDeleting;

      public event BuildingDB1DataSet.ReserveRowChangeEventHandler ReserveRowDeleted;

      [DebuggerNonUserCode]
      public void AddReserveRow(BuildingDB1DataSet.ReserveRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ReserveRow AddReserveRow(
        string ReserveRef,
        string RoomNo,
        string ClientID,
        DateTime StartDate,
        DateTime EndDate,
        string ReserveType,
        bool Update)
      {
        BuildingDB1DataSet.ReserveRow row = (BuildingDB1DataSet.ReserveRow) this.NewRow();
        object[] objArray = new object[8]
        {
          null,
          (object) ReserveRef,
          (object) RoomNo,
          (object) ClientID,
          (object) StartDate,
          (object) EndDate,
          (object) ReserveType,
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
        BuildingDB1DataSet.ReserveDataTable reserveDataTable = (BuildingDB1DataSet.ReserveDataTable) base.Clone();
        reserveDataTable.InitVars();
        return (DataTable) reserveDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.ReserveDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRefNo = this.Columns["RefNo"];
        this.columnReserveRef = this.Columns["ReserveRef"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnStartDate = this.Columns["StartDate"];
        this.columnEndDate = this.Columns["EndDate"];
        this.columnReserveType = this.Columns["ReserveType"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRefNo = new DataColumn("RefNo", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRefNo);
        this.columnReserveRef = new DataColumn("ReserveRef", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReserveRef);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStartDate);
        this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEndDate);
        this.columnReserveType = new DataColumn("ReserveType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReserveType);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnReserveRef
        }, false));
        this.columnRefNo.AutoIncrement = true;
        this.columnRefNo.AutoIncrementSeed = -1L;
        this.columnRefNo.AutoIncrementStep = -1L;
        this.columnReserveRef.Unique = true;
        this.columnReserveRef.MaxLength = 10;
        this.columnRoomNo.MaxLength = 5;
        this.columnClientID.MaxLength = 10;
        this.columnReserveType.MaxLength = 20;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ReserveRow NewReserveRow()
      {
        return (BuildingDB1DataSet.ReserveRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.ReserveRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.ReserveRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ReserveRowChanged == null)
          return;
        this.ReserveRowChanged((object) this, new BuildingDB1DataSet.ReserveRowChangeEvent((BuildingDB1DataSet.ReserveRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ReserveRowChanging == null)
          return;
        this.ReserveRowChanging((object) this, new BuildingDB1DataSet.ReserveRowChangeEvent((BuildingDB1DataSet.ReserveRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ReserveRowDeleted == null)
          return;
        this.ReserveRowDeleted((object) this, new BuildingDB1DataSet.ReserveRowChangeEvent((BuildingDB1DataSet.ReserveRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ReserveRowDeleting == null)
          return;
        this.ReserveRowDeleting((object) this, new BuildingDB1DataSet.ReserveRowChangeEvent((BuildingDB1DataSet.ReserveRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveReserveRow(BuildingDB1DataSet.ReserveRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ReserveDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class RoomStatusDataTable : DataTable, IEnumerable
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
      public RoomStatusDataTable()
      {
        this.TableName = "RoomStatus";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal RoomStatusDataTable(DataTable table)
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
      protected RoomStatusDataTable(SerializationInfo info, StreamingContext context)
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
      public BuildingDB1DataSet.RoomStatusRow this[int index]
      {
        get => (BuildingDB1DataSet.RoomStatusRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.RoomStatusRowChangeEventHandler RoomStatusRowChanging;

      public event BuildingDB1DataSet.RoomStatusRowChangeEventHandler RoomStatusRowChanged;

      public event BuildingDB1DataSet.RoomStatusRowChangeEventHandler RoomStatusRowDeleting;

      public event BuildingDB1DataSet.RoomStatusRowChangeEventHandler RoomStatusRowDeleted;

      [DebuggerNonUserCode]
      public void AddRoomStatusRow(BuildingDB1DataSet.RoomStatusRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.RoomStatusRow AddRoomStatusRow(
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
        BuildingDB1DataSet.RoomStatusRow row = (BuildingDB1DataSet.RoomStatusRow) this.NewRow();
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
        BuildingDB1DataSet.RoomStatusDataTable roomStatusDataTable = (BuildingDB1DataSet.RoomStatusDataTable) base.Clone();
        roomStatusDataTable.InitVars();
        return (DataTable) roomStatusDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.RoomStatusDataTable();
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
      public BuildingDB1DataSet.RoomStatusRow NewRoomStatusRow()
      {
        return (BuildingDB1DataSet.RoomStatusRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.RoomStatusRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.RoomStatusRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.RoomStatusRowChanged == null)
          return;
        this.RoomStatusRowChanged((object) this, new BuildingDB1DataSet.RoomStatusRowChangeEvent((BuildingDB1DataSet.RoomStatusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.RoomStatusRowChanging == null)
          return;
        this.RoomStatusRowChanging((object) this, new BuildingDB1DataSet.RoomStatusRowChangeEvent((BuildingDB1DataSet.RoomStatusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.RoomStatusRowDeleted == null)
          return;
        this.RoomStatusRowDeleted((object) this, new BuildingDB1DataSet.RoomStatusRowChangeEvent((BuildingDB1DataSet.RoomStatusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.RoomStatusRowDeleting == null)
          return;
        this.RoomStatusRowDeleting((object) this, new BuildingDB1DataSet.RoomStatusRowChangeEvent((BuildingDB1DataSet.RoomStatusRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveRoomStatusRow(BuildingDB1DataSet.RoomStatusRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (RoomStatusDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class UnitRefDataTable : DataTable, IEnumerable
    {
      private DataColumn columnClientID;
      private DataColumn columnCardNo;
      private DataColumn columnRoomNo;
      private DataColumn columnValidStart;
      private DataColumn columnValidEnd;

      [DebuggerNonUserCode]
      public UnitRefDataTable()
      {
        this.TableName = "UnitRef";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal UnitRefDataTable(DataTable table)
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
      protected UnitRefDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ValidStartColumn => this.columnValidStart;

      [DebuggerNonUserCode]
      public DataColumn ValidEndColumn => this.columnValidEnd;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.UnitRefRow this[int index]
      {
        get => (BuildingDB1DataSet.UnitRefRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.UnitRefRowChangeEventHandler UnitRefRowChanging;

      public event BuildingDB1DataSet.UnitRefRowChangeEventHandler UnitRefRowChanged;

      public event BuildingDB1DataSet.UnitRefRowChangeEventHandler UnitRefRowDeleting;

      public event BuildingDB1DataSet.UnitRefRowChangeEventHandler UnitRefRowDeleted;

      [DebuggerNonUserCode]
      public void AddUnitRefRow(BuildingDB1DataSet.UnitRefRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.UnitRefRow AddUnitRefRow(
        string ClientID,
        string CardNo,
        string RoomNo,
        DateTime ValidStart,
        DateTime ValidEnd)
      {
        BuildingDB1DataSet.UnitRefRow row = (BuildingDB1DataSet.UnitRefRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) ClientID,
          (object) CardNo,
          (object) RoomNo,
          (object) ValidStart,
          (object) ValidEnd
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
        BuildingDB1DataSet.UnitRefDataTable unitRefDataTable = (BuildingDB1DataSet.UnitRefDataTable) base.Clone();
        unitRefDataTable.InitVars();
        return (DataTable) unitRefDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.UnitRefDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnClientID = this.Columns["ClientID"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnValidStart = this.Columns["ValidStart"];
        this.columnValidEnd = this.Columns["ValidEnd"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnValidStart = new DataColumn("ValidStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidStart);
        this.columnValidEnd = new DataColumn("ValidEnd", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidEnd);
        this.columnClientID.MaxLength = 10;
        this.columnCardNo.MaxLength = 5;
        this.columnRoomNo.MaxLength = 5;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.UnitRefRow NewUnitRefRow()
      {
        return (BuildingDB1DataSet.UnitRefRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.UnitRefRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.UnitRefRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.UnitRefRowChanged == null)
          return;
        this.UnitRefRowChanged((object) this, new BuildingDB1DataSet.UnitRefRowChangeEvent((BuildingDB1DataSet.UnitRefRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.UnitRefRowChanging == null)
          return;
        this.UnitRefRowChanging((object) this, new BuildingDB1DataSet.UnitRefRowChangeEvent((BuildingDB1DataSet.UnitRefRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.UnitRefRowDeleted == null)
          return;
        this.UnitRefRowDeleted((object) this, new BuildingDB1DataSet.UnitRefRowChangeEvent((BuildingDB1DataSet.UnitRefRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.UnitRefRowDeleting == null)
          return;
        this.UnitRefRowDeleting((object) this, new BuildingDB1DataSet.UnitRefRowChangeEvent((BuildingDB1DataSet.UnitRefRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveUnitRefRow(BuildingDB1DataSet.UnitRefRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (UnitRefDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class ClientAccDataTable : DataTable, IEnumerable
    {
      private DataColumn columnClientID;
      private DataColumn columnRoomNo;
      private DataColumn columnCondition;
      private DataColumn columnOldRoom;
      private DataColumn columnCardNo;
      private DataColumn columnDeposit;
      private DataColumn columnKeyDeposit;
      private DataColumn columnBond;
      private DataColumn columnNoOfPeople;
      private DataColumn columnContractStart;
      private DataColumn columnContractEnd;
      private DataColumn columnChargeType;
      private DataColumn columnGracePeriod;
      private DataColumn columnValidStart;
      private DataColumn columnValidEnd;
      private DataColumn columnLastPayment;
      private DataColumn columnAmountPaid;
      private DataColumn columnAdvancedPayment;
      private DataColumn columnCheckInDate;
      private DataColumn columnCheckInTime;
      private DataColumn columnCheckOutDate;
      private DataColumn columnCheckOutTime;
      private DataColumn columnLastRecDate;
      private DataColumn columnBonusDate;
      private DataColumn columnRoomStart;
      private DataColumn columnRemark;
      private DataColumn columnRmPriceAdjust;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public ClientAccDataTable()
      {
        this.TableName = "ClientAcc";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ClientAccDataTable(DataTable table)
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
      protected ClientAccDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ConditionColumn => this.columnCondition;

      [DebuggerNonUserCode]
      public DataColumn OldRoomColumn => this.columnOldRoom;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn DepositColumn => this.columnDeposit;

      [DebuggerNonUserCode]
      public DataColumn KeyDepositColumn => this.columnKeyDeposit;

      [DebuggerNonUserCode]
      public DataColumn BondColumn => this.columnBond;

      [DebuggerNonUserCode]
      public DataColumn NoOfPeopleColumn => this.columnNoOfPeople;

      [DebuggerNonUserCode]
      public DataColumn ContractStartColumn => this.columnContractStart;

      [DebuggerNonUserCode]
      public DataColumn ContractEndColumn => this.columnContractEnd;

      [DebuggerNonUserCode]
      public DataColumn ChargeTypeColumn => this.columnChargeType;

      [DebuggerNonUserCode]
      public DataColumn GracePeriodColumn => this.columnGracePeriod;

      [DebuggerNonUserCode]
      public DataColumn ValidStartColumn => this.columnValidStart;

      [DebuggerNonUserCode]
      public DataColumn ValidEndColumn => this.columnValidEnd;

      [DebuggerNonUserCode]
      public DataColumn LastPaymentColumn => this.columnLastPayment;

      [DebuggerNonUserCode]
      public DataColumn AmountPaidColumn => this.columnAmountPaid;

      [DebuggerNonUserCode]
      public DataColumn AdvancedPaymentColumn => this.columnAdvancedPayment;

      [DebuggerNonUserCode]
      public DataColumn CheckInDateColumn => this.columnCheckInDate;

      [DebuggerNonUserCode]
      public DataColumn CheckInTimeColumn => this.columnCheckInTime;

      [DebuggerNonUserCode]
      public DataColumn CheckOutDateColumn => this.columnCheckOutDate;

      [DebuggerNonUserCode]
      public DataColumn CheckOutTimeColumn => this.columnCheckOutTime;

      [DebuggerNonUserCode]
      public DataColumn LastRecDateColumn => this.columnLastRecDate;

      [DebuggerNonUserCode]
      public DataColumn BonusDateColumn => this.columnBonusDate;

      [DebuggerNonUserCode]
      public DataColumn RoomStartColumn => this.columnRoomStart;

      [DebuggerNonUserCode]
      public DataColumn RemarkColumn => this.columnRemark;

      [DebuggerNonUserCode]
      public DataColumn RmPriceAdjustColumn => this.columnRmPriceAdjust;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientAccRow this[int index]
      {
        get => (BuildingDB1DataSet.ClientAccRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.ClientAccRowChangeEventHandler ClientAccRowChanging;

      public event BuildingDB1DataSet.ClientAccRowChangeEventHandler ClientAccRowChanged;

      public event BuildingDB1DataSet.ClientAccRowChangeEventHandler ClientAccRowDeleting;

      public event BuildingDB1DataSet.ClientAccRowChangeEventHandler ClientAccRowDeleted;

      [DebuggerNonUserCode]
      public void AddClientAccRow(BuildingDB1DataSet.ClientAccRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientAccRow AddClientAccRow(
        string ClientID,
        string RoomNo,
        string Condition,
        string OldRoom,
        string CardNo,
        Decimal Deposit,
        Decimal KeyDeposit,
        Decimal Bond,
        byte NoOfPeople,
        DateTime ContractStart,
        DateTime ContractEnd,
        string ChargeType,
        short GracePeriod,
        DateTime ValidStart,
        DateTime ValidEnd,
        Decimal LastPayment,
        Decimal AmountPaid,
        Decimal AdvancedPayment,
        DateTime CheckInDate,
        DateTime CheckInTime,
        DateTime CheckOutDate,
        DateTime CheckOutTime,
        DateTime LastRecDate,
        string BonusDate,
        DateTime RoomStart,
        string Remark,
        bool RmPriceAdjust,
        bool Update)
      {
        BuildingDB1DataSet.ClientAccRow row = (BuildingDB1DataSet.ClientAccRow) this.NewRow();
        object[] objArray = new object[28]
        {
          (object) ClientID,
          (object) RoomNo,
          (object) Condition,
          (object) OldRoom,
          (object) CardNo,
          (object) Deposit,
          (object) KeyDeposit,
          (object) Bond,
          (object) NoOfPeople,
          (object) ContractStart,
          (object) ContractEnd,
          (object) ChargeType,
          (object) GracePeriod,
          (object) ValidStart,
          (object) ValidEnd,
          (object) LastPayment,
          (object) AmountPaid,
          (object) AdvancedPayment,
          (object) CheckInDate,
          (object) CheckInTime,
          (object) CheckOutDate,
          (object) CheckOutTime,
          (object) LastRecDate,
          (object) BonusDate,
          (object) RoomStart,
          (object) Remark,
          (object) RmPriceAdjust,
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
        BuildingDB1DataSet.ClientAccDataTable clientAccDataTable = (BuildingDB1DataSet.ClientAccDataTable) base.Clone();
        clientAccDataTable.InitVars();
        return (DataTable) clientAccDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.ClientAccDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnClientID = this.Columns["ClientID"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCondition = this.Columns["Condition"];
        this.columnOldRoom = this.Columns["OldRoom"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnDeposit = this.Columns["Deposit"];
        this.columnKeyDeposit = this.Columns["KeyDeposit"];
        this.columnBond = this.Columns["Bond"];
        this.columnNoOfPeople = this.Columns["NoOfPeople"];
        this.columnContractStart = this.Columns["ContractStart"];
        this.columnContractEnd = this.Columns["ContractEnd"];
        this.columnChargeType = this.Columns["ChargeType"];
        this.columnGracePeriod = this.Columns["GracePeriod"];
        this.columnValidStart = this.Columns["ValidStart"];
        this.columnValidEnd = this.Columns["ValidEnd"];
        this.columnLastPayment = this.Columns["LastPayment"];
        this.columnAmountPaid = this.Columns["AmountPaid"];
        this.columnAdvancedPayment = this.Columns["AdvancedPayment"];
        this.columnCheckInDate = this.Columns["CheckInDate"];
        this.columnCheckInTime = this.Columns["CheckInTime"];
        this.columnCheckOutDate = this.Columns["CheckOutDate"];
        this.columnCheckOutTime = this.Columns["CheckOutTime"];
        this.columnLastRecDate = this.Columns["LastRecDate"];
        this.columnBonusDate = this.Columns["BonusDate"];
        this.columnRoomStart = this.Columns["RoomStart"];
        this.columnRemark = this.Columns["Remark"];
        this.columnRmPriceAdjust = this.Columns["RmPriceAdjust"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCondition);
        this.columnOldRoom = new DataColumn("OldRoom", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOldRoom);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnDeposit = new DataColumn("Deposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDeposit);
        this.columnKeyDeposit = new DataColumn("KeyDeposit", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKeyDeposit);
        this.columnBond = new DataColumn("Bond", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBond);
        this.columnNoOfPeople = new DataColumn("NoOfPeople", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnNoOfPeople);
        this.columnContractStart = new DataColumn("ContractStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnContractStart);
        this.columnContractEnd = new DataColumn("ContractEnd", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnContractEnd);
        this.columnChargeType = new DataColumn("ChargeType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnChargeType);
        this.columnGracePeriod = new DataColumn("GracePeriod", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGracePeriod);
        this.columnValidStart = new DataColumn("ValidStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidStart);
        this.columnValidEnd = new DataColumn("ValidEnd", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidEnd);
        this.columnLastPayment = new DataColumn("LastPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLastPayment);
        this.columnAmountPaid = new DataColumn("AmountPaid", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAmountPaid);
        this.columnAdvancedPayment = new DataColumn("AdvancedPayment", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAdvancedPayment);
        this.columnCheckInDate = new DataColumn("CheckInDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInDate);
        this.columnCheckInTime = new DataColumn("CheckInTime", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckInTime);
        this.columnCheckOutDate = new DataColumn("CheckOutDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutDate);
        this.columnCheckOutTime = new DataColumn("CheckOutTime", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCheckOutTime);
        this.columnLastRecDate = new DataColumn("LastRecDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLastRecDate);
        this.columnBonusDate = new DataColumn("BonusDate", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBonusDate);
        this.columnRoomStart = new DataColumn("RoomStart", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomStart);
        this.columnRemark = new DataColumn("Remark", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRemark);
        this.columnRmPriceAdjust = new DataColumn("RmPriceAdjust", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRmPriceAdjust);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnClientID
        }, false));
        this.columnClientID.Unique = true;
        this.columnClientID.MaxLength = 10;
        this.columnRoomNo.MaxLength = 5;
        this.columnCondition.MaxLength = 20;
        this.columnOldRoom.MaxLength = 5;
        this.columnCardNo.MaxLength = 5;
        this.columnChargeType.MaxLength = 1;
        this.columnBonusDate.MaxLength = 10;
        this.columnRemark.MaxLength = 40;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientAccRow NewClientAccRow()
      {
        return (BuildingDB1DataSet.ClientAccRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.ClientAccRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.ClientAccRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ClientAccRowChanged == null)
          return;
        this.ClientAccRowChanged((object) this, new BuildingDB1DataSet.ClientAccRowChangeEvent((BuildingDB1DataSet.ClientAccRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ClientAccRowChanging == null)
          return;
        this.ClientAccRowChanging((object) this, new BuildingDB1DataSet.ClientAccRowChangeEvent((BuildingDB1DataSet.ClientAccRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ClientAccRowDeleted == null)
          return;
        this.ClientAccRowDeleted((object) this, new BuildingDB1DataSet.ClientAccRowChangeEvent((BuildingDB1DataSet.ClientAccRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ClientAccRowDeleting == null)
          return;
        this.ClientAccRowDeleting((object) this, new BuildingDB1DataSet.ClientAccRowChangeEvent((BuildingDB1DataSet.ClientAccRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveClientAccRow(BuildingDB1DataSet.ClientAccRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ClientAccDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class ClientDataTable : DataTable, IEnumerable
    {
      private DataColumn columnClientID;
      private DataColumn columnClientType;
      private DataColumn columnForeName;
      private DataColumn columnSurName;
      private DataColumn columnSex;
      private DataColumn columnIdentity;
      private DataColumn columnNationality;
      private DataColumn columnAddress;
      private DataColumn columnCountry;
      private DataColumn columnContact;
      private DataColumn columnEmail;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public ClientDataTable()
      {
        this.TableName = "Client";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ClientDataTable(DataTable table)
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
      protected ClientDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn ClientTypeColumn => this.columnClientType;

      [DebuggerNonUserCode]
      public DataColumn ForeNameColumn => this.columnForeName;

      [DebuggerNonUserCode]
      public DataColumn SurNameColumn => this.columnSurName;

      [DebuggerNonUserCode]
      public DataColumn SexColumn => this.columnSex;

      [DebuggerNonUserCode]
      public DataColumn IdentityColumn => this.columnIdentity;

      [DebuggerNonUserCode]
      public DataColumn NationalityColumn => this.columnNationality;

      [DebuggerNonUserCode]
      public DataColumn AddressColumn => this.columnAddress;

      [DebuggerNonUserCode]
      public DataColumn CountryColumn => this.columnCountry;

      [DebuggerNonUserCode]
      public DataColumn ContactColumn => this.columnContact;

      [DebuggerNonUserCode]
      public DataColumn EmailColumn => this.columnEmail;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientRow this[int index]
      {
        get => (BuildingDB1DataSet.ClientRow) this.Rows[index];
      }

      public event BuildingDB1DataSet.ClientRowChangeEventHandler ClientRowChanging;

      public event BuildingDB1DataSet.ClientRowChangeEventHandler ClientRowChanged;

      public event BuildingDB1DataSet.ClientRowChangeEventHandler ClientRowDeleting;

      public event BuildingDB1DataSet.ClientRowChangeEventHandler ClientRowDeleted;

      [DebuggerNonUserCode]
      public void AddClientRow(BuildingDB1DataSet.ClientRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientRow AddClientRow(
        string ClientID,
        string ClientType,
        string ForeName,
        string SurName,
        string Sex,
        string Identity,
        string Nationality,
        string Address,
        string Country,
        string Contact,
        string Email,
        bool Update)
      {
        BuildingDB1DataSet.ClientRow row = (BuildingDB1DataSet.ClientRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) ClientID,
          (object) ClientType,
          (object) ForeName,
          (object) SurName,
          (object) Sex,
          (object) Identity,
          (object) Nationality,
          (object) Address,
          (object) Country,
          (object) Contact,
          (object) Email,
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
        BuildingDB1DataSet.ClientDataTable clientDataTable = (BuildingDB1DataSet.ClientDataTable) base.Clone();
        clientDataTable.InitVars();
        return (DataTable) clientDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BuildingDB1DataSet.ClientDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnClientID = this.Columns["ClientID"];
        this.columnClientType = this.Columns["ClientType"];
        this.columnForeName = this.Columns["ForeName"];
        this.columnSurName = this.Columns["SurName"];
        this.columnSex = this.Columns["Sex"];
        this.columnIdentity = this.Columns["Identity"];
        this.columnNationality = this.Columns["Nationality"];
        this.columnAddress = this.Columns["Address"];
        this.columnCountry = this.Columns["Country"];
        this.columnContact = this.Columns["Contact"];
        this.columnEmail = this.Columns["Email"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnClientType = new DataColumn("ClientType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientType);
        this.columnForeName = new DataColumn("ForeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnForeName);
        this.columnSurName = new DataColumn("SurName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSurName);
        this.columnSex = new DataColumn("Sex", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSex);
        this.columnIdentity = new DataColumn("Identity", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIdentity);
        this.columnNationality = new DataColumn("Nationality", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnNationality);
        this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAddress);
        this.columnCountry = new DataColumn("Country", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCountry);
        this.columnContact = new DataColumn("Contact", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnContact);
        this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEmail);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnClientID
        }, false));
        this.columnClientID.Unique = true;
        this.columnClientID.MaxLength = 10;
        this.columnClientType.MaxLength = 2;
        this.columnForeName.MaxLength = 20;
        this.columnSurName.MaxLength = 20;
        this.columnSex.MaxLength = 1;
        this.columnIdentity.MaxLength = 20;
        this.columnNationality.MaxLength = 20;
        this.columnAddress.MaxLength = 50;
        this.columnCountry.MaxLength = 30;
        this.columnContact.MaxLength = 20;
        this.columnEmail.MaxLength = 40;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientRow NewClientRow()
      {
        return (BuildingDB1DataSet.ClientRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BuildingDB1DataSet.ClientRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BuildingDB1DataSet.ClientRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ClientRowChanged == null)
          return;
        this.ClientRowChanged((object) this, new BuildingDB1DataSet.ClientRowChangeEvent((BuildingDB1DataSet.ClientRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ClientRowChanging == null)
          return;
        this.ClientRowChanging((object) this, new BuildingDB1DataSet.ClientRowChangeEvent((BuildingDB1DataSet.ClientRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ClientRowDeleted == null)
          return;
        this.ClientRowDeleted((object) this, new BuildingDB1DataSet.ClientRowChangeEvent((BuildingDB1DataSet.ClientRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ClientRowDeleting == null)
          return;
        this.ClientRowDeleting((object) this, new BuildingDB1DataSet.ClientRowChangeEvent((BuildingDB1DataSet.ClientRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveClientRow(BuildingDB1DataSet.ClientRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BuildingDB1DataSet buildingDb1DataSet = new BuildingDB1DataSet();
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
          FixedValue = buildingDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ClientDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = buildingDb1DataSet.GetSchemaSerializable();
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
    public class CardNoRow : DataRow
    {
      private BuildingDB1DataSet.CardNoDataTable tableCardNo;

      [DebuggerNonUserCode]
      internal CardNoRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCardNo = (BuildingDB1DataSet.CardNoDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardType
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.CardTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.CardTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte CardStatus
      {
        get
        {
          try
          {
            return (byte) this[this.tableCardNo.CardStatusColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableCardNo.CardStatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal KeyCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardNo.KeyChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardNo.KeyChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime RecordDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardNo.RecordDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RecordDate' in table 'CardNo' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardNo.RecordDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RecordTime
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.RecordTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.RecordTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableCardNo.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'CardNo' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardNo.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Card_AutoNumber
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.Card_AutoNumberColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.Card_AutoNumberColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Card_HW_ID
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.Card_HW_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.Card_HW_IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ReaderID
      {
        get
        {
          try
          {
            return (string) this[this.tableCardNo.ReaderIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardNo.ReaderIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableCardNo.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableCardNo.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableCardNo.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableCardNo.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardTypeNull() => this.IsNull(this.tableCardNo.CardTypeColumn);

      [DebuggerNonUserCode]
      public void SetCardTypeNull() => this[this.tableCardNo.CardTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableCardNo.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableCardNo.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardStatusNull() => this.IsNull(this.tableCardNo.CardStatusColumn);

      [DebuggerNonUserCode]
      public void SetCardStatusNull() => this[this.tableCardNo.CardStatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsKeyChargeNull() => this.IsNull(this.tableCardNo.KeyChargeColumn);

      [DebuggerNonUserCode]
      public void SetKeyChargeNull() => this[this.tableCardNo.KeyChargeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRecordDateNull() => this.IsNull(this.tableCardNo.RecordDateColumn);

      [DebuggerNonUserCode]
      public void SetRecordDateNull() => this[this.tableCardNo.RecordDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRecordTimeNull() => this.IsNull(this.tableCardNo.RecordTimeColumn);

      [DebuggerNonUserCode]
      public void SetRecordTimeNull() => this[this.tableCardNo.RecordTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableCardNo.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableCardNo.UpdateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCard_AutoNumberNull() => this.IsNull(this.tableCardNo.Card_AutoNumberColumn);

      [DebuggerNonUserCode]
      public void SetCard_AutoNumberNull()
      {
        this[this.tableCardNo.Card_AutoNumberColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCard_HW_IDNull() => this.IsNull(this.tableCardNo.Card_HW_IDColumn);

      [DebuggerNonUserCode]
      public void SetCard_HW_IDNull() => this[this.tableCardNo.Card_HW_IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsReaderIDNull() => this.IsNull(this.tableCardNo.ReaderIDColumn);

      [DebuggerNonUserCode]
      public void SetReaderIDNull() => this[this.tableCardNo.ReaderIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class CardTransRow : DataRow
    {
      private BuildingDB1DataSet.CardTransDataTable tableCardTrans;

      [DebuggerNonUserCode]
      internal CardTransRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCardTrans = (BuildingDB1DataSet.CardTransDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int TransID
      {
        get => (int) this[this.tableCardTrans.TransIDColumn];
        set => this[this.tableCardTrans.TransIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardType
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.CardTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.CardTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ReserveRef
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.ReserveRefColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.ReserveRefColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string OldRoom
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.OldRoomColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.OldRoomColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal PreviousAdvance
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.PreviousAdvanceColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.PreviousAdvanceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal AdvancedPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.AdvancedPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.AdvancedPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Balance
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.BalanceColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.BalanceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Bond
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.BondColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.BondColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal RBA
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.RBAColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.RBAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Deposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.DepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.DepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal KeyDeposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.KeyDepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.KeyDepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal ExtraCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.ExtraChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.ExtraChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ExDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.ExDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.ExDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal RoomCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.RoomChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.RoomChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransType
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.TransTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.TransTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime TransDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardTrans.TransDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransDate' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.TransDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransTime
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.TransTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.TransTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardTrans.ValidStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidStart' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.ValidStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidEnd
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardTrans.ValidEndColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidEnd' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.ValidEndColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckInDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardTrans.CheckInDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckInDate' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.CheckInDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckInTime
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.CheckInTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.CheckInTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckOutDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableCardTrans.CheckOutDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutDate' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.CheckOutDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ChargeType
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.ChargeTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.ChargeTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short GracePeriod
      {
        get
        {
          try
          {
            return (short) this[this.tableCardTrans.GracePeriodColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableCardTrans.GracePeriodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal BonusClaim
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.BonusClaimColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.BonusClaimColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal GST
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.GSTColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.GSTColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal LastPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableCardTrans.LastPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableCardTrans.LastPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableCardTrans.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableCardTrans.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableCardTrans.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'CardTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableCardTrans.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableCardTrans.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableCardTrans.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableCardTrans.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableCardTrans.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardTypeNull() => this.IsNull(this.tableCardTrans.CardTypeColumn);

      [DebuggerNonUserCode]
      public void SetCardTypeNull() => this[this.tableCardTrans.CardTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableCardTrans.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableCardTrans.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableCardTrans.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull() => this[this.tableCardTrans.ConditionColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsReserveRefNull() => this.IsNull(this.tableCardTrans.ReserveRefColumn);

      [DebuggerNonUserCode]
      public void SetReserveRefNull()
      {
        this[this.tableCardTrans.ReserveRefColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsOldRoomNull() => this.IsNull(this.tableCardTrans.OldRoomColumn);

      [DebuggerNonUserCode]
      public void SetOldRoomNull() => this[this.tableCardTrans.OldRoomColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsPreviousAdvanceNull() => this.IsNull(this.tableCardTrans.PreviousAdvanceColumn);

      [DebuggerNonUserCode]
      public void SetPreviousAdvanceNull()
      {
        this[this.tableCardTrans.PreviousAdvanceColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAdvancedPaymentNull() => this.IsNull(this.tableCardTrans.AdvancedPaymentColumn);

      [DebuggerNonUserCode]
      public void SetAdvancedPaymentNull()
      {
        this[this.tableCardTrans.AdvancedPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBalanceNull() => this.IsNull(this.tableCardTrans.BalanceColumn);

      [DebuggerNonUserCode]
      public void SetBalanceNull() => this[this.tableCardTrans.BalanceColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBondNull() => this.IsNull(this.tableCardTrans.BondColumn);

      [DebuggerNonUserCode]
      public void SetBondNull() => this[this.tableCardTrans.BondColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRBANull() => this.IsNull(this.tableCardTrans.RBAColumn);

      [DebuggerNonUserCode]
      public void SetRBANull() => this[this.tableCardTrans.RBAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDepositNull() => this.IsNull(this.tableCardTrans.DepositColumn);

      [DebuggerNonUserCode]
      public void SetDepositNull() => this[this.tableCardTrans.DepositColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsKeyDepositNull() => this.IsNull(this.tableCardTrans.KeyDepositColumn);

      [DebuggerNonUserCode]
      public void SetKeyDepositNull()
      {
        this[this.tableCardTrans.KeyDepositColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsExtraChargeNull() => this.IsNull(this.tableCardTrans.ExtraChargeColumn);

      [DebuggerNonUserCode]
      public void SetExtraChargeNull()
      {
        this[this.tableCardTrans.ExtraChargeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsExDescriptionNull() => this.IsNull(this.tableCardTrans.ExDescriptionColumn);

      [DebuggerNonUserCode]
      public void SetExDescriptionNull()
      {
        this[this.tableCardTrans.ExDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomChargeNull() => this.IsNull(this.tableCardTrans.RoomChargeColumn);

      [DebuggerNonUserCode]
      public void SetRoomChargeNull()
      {
        this[this.tableCardTrans.RoomChargeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsTransTypeNull() => this.IsNull(this.tableCardTrans.TransTypeColumn);

      [DebuggerNonUserCode]
      public void SetTransTypeNull() => this[this.tableCardTrans.TransTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransDateNull() => this.IsNull(this.tableCardTrans.TransDateColumn);

      [DebuggerNonUserCode]
      public void SetTransDateNull() => this[this.tableCardTrans.TransDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransTimeNull() => this.IsNull(this.tableCardTrans.TransTimeColumn);

      [DebuggerNonUserCode]
      public void SetTransTimeNull() => this[this.tableCardTrans.TransTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsValidStartNull() => this.IsNull(this.tableCardTrans.ValidStartColumn);

      [DebuggerNonUserCode]
      public void SetValidStartNull()
      {
        this[this.tableCardTrans.ValidStartColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsValidEndNull() => this.IsNull(this.tableCardTrans.ValidEndColumn);

      [DebuggerNonUserCode]
      public void SetValidEndNull() => this[this.tableCardTrans.ValidEndColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckInDateNull() => this.IsNull(this.tableCardTrans.CheckInDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckInDateNull()
      {
        this[this.tableCardTrans.CheckInDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckInTimeNull() => this.IsNull(this.tableCardTrans.CheckInTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckInTimeNull()
      {
        this[this.tableCardTrans.CheckInTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableCardTrans.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableCardTrans.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutDateNull() => this.IsNull(this.tableCardTrans.CheckOutDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutDateNull()
      {
        this[this.tableCardTrans.CheckOutDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsChargeTypeNull() => this.IsNull(this.tableCardTrans.ChargeTypeColumn);

      [DebuggerNonUserCode]
      public void SetChargeTypeNull()
      {
        this[this.tableCardTrans.ChargeTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsGracePeriodNull() => this.IsNull(this.tableCardTrans.GracePeriodColumn);

      [DebuggerNonUserCode]
      public void SetGracePeriodNull()
      {
        this[this.tableCardTrans.GracePeriodColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBonusClaimNull() => this.IsNull(this.tableCardTrans.BonusClaimColumn);

      [DebuggerNonUserCode]
      public void SetBonusClaimNull()
      {
        this[this.tableCardTrans.BonusClaimColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsGSTNull() => this.IsNull(this.tableCardTrans.GSTColumn);

      [DebuggerNonUserCode]
      public void SetGSTNull() => this[this.tableCardTrans.GSTColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsLastPaymentNull() => this.IsNull(this.tableCardTrans.LastPaymentColumn);

      [DebuggerNonUserCode]
      public void SetLastPaymentNull()
      {
        this[this.tableCardTrans.LastPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableCardTrans.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableCardTrans.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableCardTrans.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableCardTrans.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class AllLockedRecordRow : DataRow
    {
      private BuildingDB1DataSet.AllLockedRecordDataTable tableAllLockedRecord;

      [DebuggerNonUserCode]
      internal AllLockedRecordRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableAllLockedRecord = (BuildingDB1DataSet.AllLockedRecordDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardType
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.CardTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.CardTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UnLockSDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableAllLockedRecord.UnLockSDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UnLockSDate' in table 'AllLockedRecord' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAllLockedRecord.UnLockSDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string UnLockSTime
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.UnLockSTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.UnLockSTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CollectionSDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableAllLockedRecord.CollectionSDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CollectionSDate' in table 'AllLockedRecord' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableAllLockedRecord.CollectionSDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CollectionSTime
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.CollectionSTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.CollectionSTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ForeName
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.ForeNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.ForeNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string SurName
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.SurNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.SurNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableAllLockedRecord.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableAllLockedRecord.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int ID
      {
        get => (int) this[this.tableAllLockedRecord.IDColumn];
        set => this[this.tableAllLockedRecord.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableAllLockedRecord.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableAllLockedRecord.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableAllLockedRecord.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableAllLockedRecord.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardTypeNull() => this.IsNull(this.tableAllLockedRecord.CardTypeColumn);

      [DebuggerNonUserCode]
      public void SetCardTypeNull()
      {
        this[this.tableAllLockedRecord.CardTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsUnLockSDateNull() => this.IsNull(this.tableAllLockedRecord.UnLockSDateColumn);

      [DebuggerNonUserCode]
      public void SetUnLockSDateNull()
      {
        this[this.tableAllLockedRecord.UnLockSDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsUnLockSTimeNull() => this.IsNull(this.tableAllLockedRecord.UnLockSTimeColumn);

      [DebuggerNonUserCode]
      public void SetUnLockSTimeNull()
      {
        this[this.tableAllLockedRecord.UnLockSTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCollectionSDateNull()
      {
        return this.IsNull(this.tableAllLockedRecord.CollectionSDateColumn);
      }

      [DebuggerNonUserCode]
      public void SetCollectionSDateNull()
      {
        this[this.tableAllLockedRecord.CollectionSDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCollectionSTimeNull()
      {
        return this.IsNull(this.tableAllLockedRecord.CollectionSTimeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCollectionSTimeNull()
      {
        this[this.tableAllLockedRecord.CollectionSTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableAllLockedRecord.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull()
      {
        this[this.tableAllLockedRecord.ClientIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsForeNameNull() => this.IsNull(this.tableAllLockedRecord.ForeNameColumn);

      [DebuggerNonUserCode]
      public void SetForeNameNull()
      {
        this[this.tableAllLockedRecord.ForeNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsSurNameNull() => this.IsNull(this.tableAllLockedRecord.SurNameColumn);

      [DebuggerNonUserCode]
      public void SetSurNameNull()
      {
        this[this.tableAllLockedRecord.SurNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableAllLockedRecord.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull()
      {
        this[this.tableAllLockedRecord.StaffIDColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class EventLogRow : DataRow
    {
      private BuildingDB1DataSet.EventLogDataTable tableEventLog;

      [DebuggerNonUserCode]
      internal EventLogRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableEventLog = (BuildingDB1DataSet.EventLogDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public DateTime EventDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableEventLog.EventDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EventDate' in table 'EventLog' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEventLog.EventDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string EventTime
      {
        get
        {
          try
          {
            return (string) this[this.tableEventLog.EventTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableEventLog.EventTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string EventCode
      {
        get
        {
          try
          {
            return (string) this[this.tableEventLog.EventCodeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableEventLog.EventCodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string EventDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableEventLog.EventDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableEventLog.EventDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CardNo
      {
        get
        {
          try
          {
            return (int) this[this.tableEventLog.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableEventLog.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableEventLog.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableEventLog.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsEventDateNull() => this.IsNull(this.tableEventLog.EventDateColumn);

      [DebuggerNonUserCode]
      public void SetEventDateNull() => this[this.tableEventLog.EventDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEventTimeNull() => this.IsNull(this.tableEventLog.EventTimeColumn);

      [DebuggerNonUserCode]
      public void SetEventTimeNull() => this[this.tableEventLog.EventTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEventCodeNull() => this.IsNull(this.tableEventLog.EventCodeColumn);

      [DebuggerNonUserCode]
      public void SetEventCodeNull() => this[this.tableEventLog.EventCodeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEventDescriptionNull()
      {
        return this.IsNull(this.tableEventLog.EventDescriptionColumn);
      }

      [DebuggerNonUserCode]
      public void SetEventDescriptionNull()
      {
        this[this.tableEventLog.EventDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableEventLog.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableEventLog.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableEventLog.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableEventLog.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ExtraChargeRow : DataRow
    {
      private BuildingDB1DataSet.ExtraChargeDataTable tableExtraCharge;

      [DebuggerNonUserCode]
      internal ExtraChargeRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableExtraCharge = (BuildingDB1DataSet.ExtraChargeDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int ReceiptID
      {
        get
        {
          try
          {
            return (int) this[this.tableExtraCharge.ReceiptIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableExtraCharge.ReceiptIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableExtraCharge.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableExtraCharge.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ExDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableExtraCharge.ExDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableExtraCharge.ExDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal ExtraCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableExtraCharge.ExtraChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableExtraCharge.ExtraChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsReceiptIDNull() => this.IsNull(this.tableExtraCharge.ReceiptIDColumn);

      [DebuggerNonUserCode]
      public void SetReceiptIDNull()
      {
        this[this.tableExtraCharge.ReceiptIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableExtraCharge.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableExtraCharge.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsExDescriptionNull() => this.IsNull(this.tableExtraCharge.ExDescriptionColumn);

      [DebuggerNonUserCode]
      public void SetExDescriptionNull()
      {
        this[this.tableExtraCharge.ExDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsExtraChargeNull() => this.IsNull(this.tableExtraCharge.ExtraChargeColumn);

      [DebuggerNonUserCode]
      public void SetExtraChargeNull()
      {
        this[this.tableExtraCharge.ExtraChargeColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class KeyChargesRow : DataRow
    {
      private BuildingDB1DataSet.KeyChargesDataTable tableKeyCharges;

      [DebuggerNonUserCode]
      internal KeyChargesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableKeyCharges = (BuildingDB1DataSet.KeyChargesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string BuildingNo
      {
        get
        {
          try
          {
            return (string) this[this.tableKeyCharges.BuildingNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableKeyCharges.BuildingNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal KeyDeposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableKeyCharges.KeyDepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableKeyCharges.KeyDepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal SpareKeyCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableKeyCharges.SpareKeyChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableKeyCharges.SpareKeyChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableKeyCharges.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableKeyCharges.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableKeyCharges.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'KeyCharges' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableKeyCharges.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsBuildingNoNull() => this.IsNull(this.tableKeyCharges.BuildingNoColumn);

      [DebuggerNonUserCode]
      public void SetBuildingNoNull()
      {
        this[this.tableKeyCharges.BuildingNoColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsKeyDepositNull() => this.IsNull(this.tableKeyCharges.KeyDepositColumn);

      [DebuggerNonUserCode]
      public void SetKeyDepositNull()
      {
        this[this.tableKeyCharges.KeyDepositColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsSpareKeyChargeNull() => this.IsNull(this.tableKeyCharges.SpareKeyChargeColumn);

      [DebuggerNonUserCode]
      public void SetSpareKeyChargeNull()
      {
        this[this.tableKeyCharges.SpareKeyChargeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableKeyCharges.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableKeyCharges.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableKeyCharges.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableKeyCharges.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LastTransRow : DataRow
    {
      private BuildingDB1DataSet.LastTransDataTable tableLastTrans;

      [DebuggerNonUserCode]
      internal LastTransRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableLastTrans = (BuildingDB1DataSet.LastTransDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int TransID
      {
        get
        {
          try
          {
            return (int) this[this.tableLastTrans.TransIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableLastTrans.TransIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardType
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.CardTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.CardTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ReserveRef
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.ReserveRefColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.ReserveRefColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string OldRoom
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.OldRoomColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.OldRoomColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal PreviousAdvance
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.PreviousAdvanceColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.PreviousAdvanceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal AdvancedPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.AdvancedPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.AdvancedPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Balance
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.BalanceColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.BalanceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Bond
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.BondColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.BondColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal RBA
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.RBAColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.RBAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Deposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.DepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.DepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal KeyDeposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.KeyDepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.KeyDepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal ExtraCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.ExtraChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.ExtraChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ExDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.ExDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.ExDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal RoomCharge
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.RoomChargeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.RoomChargeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransType
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.TransTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.TransTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime TransDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLastTrans.TransDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransDate' in table 'LastTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLastTrans.TransDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.TransTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.TransTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLastTrans.ValidStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidStart' in table 'LastTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLastTrans.ValidStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidEnd
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLastTrans.ValidEndColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidEnd' in table 'LastTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLastTrans.ValidEndColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckInDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLastTrans.CheckInDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckInDate' in table 'LastTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLastTrans.CheckInDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckInTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.CheckInTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.CheckInTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CheckOutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckOutDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLastTrans.CheckOutDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutDate' in table 'LastTrans' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLastTrans.CheckOutDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ChargeType
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.ChargeTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.ChargeTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short GracePeriod
      {
        get
        {
          try
          {
            return (short) this[this.tableLastTrans.GracePeriodColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableLastTrans.GracePeriodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal BonusClaim
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.BonusClaimColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.BonusClaimColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal GST
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.GSTColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.GSTColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal LastPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableLastTrans.LastPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableLastTrans.LastPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableLastTrans.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLastTrans.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsTransIDNull() => this.IsNull(this.tableLastTrans.TransIDColumn);

      [DebuggerNonUserCode]
      public void SetTransIDNull() => this[this.tableLastTrans.TransIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableLastTrans.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableLastTrans.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableLastTrans.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableLastTrans.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardTypeNull() => this.IsNull(this.tableLastTrans.CardTypeColumn);

      [DebuggerNonUserCode]
      public void SetCardTypeNull() => this[this.tableLastTrans.CardTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableLastTrans.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableLastTrans.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableLastTrans.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull() => this[this.tableLastTrans.ConditionColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsReserveRefNull() => this.IsNull(this.tableLastTrans.ReserveRefColumn);

      [DebuggerNonUserCode]
      public void SetReserveRefNull()
      {
        this[this.tableLastTrans.ReserveRefColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsOldRoomNull() => this.IsNull(this.tableLastTrans.OldRoomColumn);

      [DebuggerNonUserCode]
      public void SetOldRoomNull() => this[this.tableLastTrans.OldRoomColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsPreviousAdvanceNull() => this.IsNull(this.tableLastTrans.PreviousAdvanceColumn);

      [DebuggerNonUserCode]
      public void SetPreviousAdvanceNull()
      {
        this[this.tableLastTrans.PreviousAdvanceColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAdvancedPaymentNull() => this.IsNull(this.tableLastTrans.AdvancedPaymentColumn);

      [DebuggerNonUserCode]
      public void SetAdvancedPaymentNull()
      {
        this[this.tableLastTrans.AdvancedPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBalanceNull() => this.IsNull(this.tableLastTrans.BalanceColumn);

      [DebuggerNonUserCode]
      public void SetBalanceNull() => this[this.tableLastTrans.BalanceColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBondNull() => this.IsNull(this.tableLastTrans.BondColumn);

      [DebuggerNonUserCode]
      public void SetBondNull() => this[this.tableLastTrans.BondColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRBANull() => this.IsNull(this.tableLastTrans.RBAColumn);

      [DebuggerNonUserCode]
      public void SetRBANull() => this[this.tableLastTrans.RBAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDepositNull() => this.IsNull(this.tableLastTrans.DepositColumn);

      [DebuggerNonUserCode]
      public void SetDepositNull() => this[this.tableLastTrans.DepositColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsKeyDepositNull() => this.IsNull(this.tableLastTrans.KeyDepositColumn);

      [DebuggerNonUserCode]
      public void SetKeyDepositNull()
      {
        this[this.tableLastTrans.KeyDepositColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsExtraChargeNull() => this.IsNull(this.tableLastTrans.ExtraChargeColumn);

      [DebuggerNonUserCode]
      public void SetExtraChargeNull()
      {
        this[this.tableLastTrans.ExtraChargeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsExDescriptionNull() => this.IsNull(this.tableLastTrans.ExDescriptionColumn);

      [DebuggerNonUserCode]
      public void SetExDescriptionNull()
      {
        this[this.tableLastTrans.ExDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomChargeNull() => this.IsNull(this.tableLastTrans.RoomChargeColumn);

      [DebuggerNonUserCode]
      public void SetRoomChargeNull()
      {
        this[this.tableLastTrans.RoomChargeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsTransTypeNull() => this.IsNull(this.tableLastTrans.TransTypeColumn);

      [DebuggerNonUserCode]
      public void SetTransTypeNull() => this[this.tableLastTrans.TransTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransDateNull() => this.IsNull(this.tableLastTrans.TransDateColumn);

      [DebuggerNonUserCode]
      public void SetTransDateNull() => this[this.tableLastTrans.TransDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransTimeNull() => this.IsNull(this.tableLastTrans.TransTimeColumn);

      [DebuggerNonUserCode]
      public void SetTransTimeNull() => this[this.tableLastTrans.TransTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsValidStartNull() => this.IsNull(this.tableLastTrans.ValidStartColumn);

      [DebuggerNonUserCode]
      public void SetValidStartNull()
      {
        this[this.tableLastTrans.ValidStartColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsValidEndNull() => this.IsNull(this.tableLastTrans.ValidEndColumn);

      [DebuggerNonUserCode]
      public void SetValidEndNull() => this[this.tableLastTrans.ValidEndColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCheckInDateNull() => this.IsNull(this.tableLastTrans.CheckInDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckInDateNull()
      {
        this[this.tableLastTrans.CheckInDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckInTimeNull() => this.IsNull(this.tableLastTrans.CheckInTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckInTimeNull()
      {
        this[this.tableLastTrans.CheckInTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableLastTrans.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableLastTrans.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutDateNull() => this.IsNull(this.tableLastTrans.CheckOutDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutDateNull()
      {
        this[this.tableLastTrans.CheckOutDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsChargeTypeNull() => this.IsNull(this.tableLastTrans.ChargeTypeColumn);

      [DebuggerNonUserCode]
      public void SetChargeTypeNull()
      {
        this[this.tableLastTrans.ChargeTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsGracePeriodNull() => this.IsNull(this.tableLastTrans.GracePeriodColumn);

      [DebuggerNonUserCode]
      public void SetGracePeriodNull()
      {
        this[this.tableLastTrans.GracePeriodColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBonusClaimNull() => this.IsNull(this.tableLastTrans.BonusClaimColumn);

      [DebuggerNonUserCode]
      public void SetBonusClaimNull()
      {
        this[this.tableLastTrans.BonusClaimColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsGSTNull() => this.IsNull(this.tableLastTrans.GSTColumn);

      [DebuggerNonUserCode]
      public void SetGSTNull() => this[this.tableLastTrans.GSTColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsLastPaymentNull() => this.IsNull(this.tableLastTrans.LastPaymentColumn);

      [DebuggerNonUserCode]
      public void SetLastPaymentNull()
      {
        this[this.tableLastTrans.LastPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableLastTrans.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableLastTrans.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LockedRecordRow : DataRow
    {
      private BuildingDB1DataSet.LockedRecordDataTable tableLockedRecord;

      [DebuggerNonUserCode]
      internal LockedRecordRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableLockedRecord = (BuildingDB1DataSet.LockedRecordDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardType
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.CardTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.CardTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime UnlockSDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLockedRecord.UnlockSDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'UnlockSDate' in table 'LockedRecord' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLockedRecord.UnlockSDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string UnlockSTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.UnlockSTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.UnlockSTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CollectionSDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLockedRecord.CollectionSDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CollectionSDate' in table 'LockedRecord' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLockedRecord.CollectionSDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CollectionSTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.CollectionSTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.CollectionSTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ForeName
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.ForeNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.ForeNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string SurName
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.SurNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.SurNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableLockedRecord.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLockedRecord.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableLockedRecord.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableLockedRecord.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableLockedRecord.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableLockedRecord.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardTypeNull() => this.IsNull(this.tableLockedRecord.CardTypeColumn);

      [DebuggerNonUserCode]
      public void SetCardTypeNull() => this[this.tableLockedRecord.CardTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUnlockSDateNull() => this.IsNull(this.tableLockedRecord.UnlockSDateColumn);

      [DebuggerNonUserCode]
      public void SetUnlockSDateNull()
      {
        this[this.tableLockedRecord.UnlockSDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsUnlockSTimeNull() => this.IsNull(this.tableLockedRecord.UnlockSTimeColumn);

      [DebuggerNonUserCode]
      public void SetUnlockSTimeNull()
      {
        this[this.tableLockedRecord.UnlockSTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCollectionSDateNull()
      {
        return this.IsNull(this.tableLockedRecord.CollectionSDateColumn);
      }

      [DebuggerNonUserCode]
      public void SetCollectionSDateNull()
      {
        this[this.tableLockedRecord.CollectionSDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCollectionSTimeNull()
      {
        return this.IsNull(this.tableLockedRecord.CollectionSTimeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCollectionSTimeNull()
      {
        this[this.tableLockedRecord.CollectionSTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableLockedRecord.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableLockedRecord.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsForeNameNull() => this.IsNull(this.tableLockedRecord.ForeNameColumn);

      [DebuggerNonUserCode]
      public void SetForeNameNull() => this[this.tableLockedRecord.ForeNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsSurNameNull() => this.IsNull(this.tableLockedRecord.SurNameColumn);

      [DebuggerNonUserCode]
      public void SetSurNameNull() => this[this.tableLockedRecord.SurNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableLockedRecord.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableLockedRecord.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LogInOutRow : DataRow
    {
      private BuildingDB1DataSet.LogInOutDataTable tableLogInOut;

      [DebuggerNonUserCode]
      internal LogInOutRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableLogInOut = (BuildingDB1DataSet.LogInOutDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableLogInOut.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLogInOut.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime LogDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableLogInOut.LogDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'LogDate' in table 'LogInOut' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLogInOut.LogDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string InTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLogInOut.InTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLogInOut.InTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string OutTime
      {
        get
        {
          try
          {
            return (string) this[this.tableLogInOut.OutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableLogInOut.OutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableLogInOut.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'LogInOut' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableLogInOut.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableLogInOut.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableLogInOut.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsLogDateNull() => this.IsNull(this.tableLogInOut.LogDateColumn);

      [DebuggerNonUserCode]
      public void SetLogDateNull() => this[this.tableLogInOut.LogDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsInTimeNull() => this.IsNull(this.tableLogInOut.InTimeColumn);

      [DebuggerNonUserCode]
      public void SetInTimeNull() => this[this.tableLogInOut.InTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsOutTimeNull() => this.IsNull(this.tableLogInOut.OutTimeColumn);

      [DebuggerNonUserCode]
      public void SetOutTimeNull() => this[this.tableLogInOut.OutTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableLogInOut.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableLogInOut.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ReserveRow : DataRow
    {
      private BuildingDB1DataSet.ReserveDataTable tableReserve;

      [DebuggerNonUserCode]
      internal ReserveRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableReserve = (BuildingDB1DataSet.ReserveDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int RefNo
      {
        get
        {
          try
          {
            return (int) this[this.tableReserve.RefNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableReserve.RefNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ReserveRef
      {
        get
        {
          try
          {
            return (string) this[this.tableReserve.ReserveRefColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableReserve.ReserveRefColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableReserve.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableReserve.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableReserve.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableReserve.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableReserve.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'Reserve' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReserve.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableReserve.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'Reserve' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReserve.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ReserveType
      {
        get
        {
          try
          {
            return (string) this[this.tableReserve.ReserveTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableReserve.ReserveTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableReserve.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Reserve' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReserve.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRefNoNull() => this.IsNull(this.tableReserve.RefNoColumn);

      [DebuggerNonUserCode]
      public void SetRefNoNull() => this[this.tableReserve.RefNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsReserveRefNull() => this.IsNull(this.tableReserve.ReserveRefColumn);

      [DebuggerNonUserCode]
      public void SetReserveRefNull() => this[this.tableReserve.ReserveRefColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableReserve.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableReserve.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableReserve.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableReserve.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableReserve.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull() => this[this.tableReserve.StartDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableReserve.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableReserve.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsReserveTypeNull() => this.IsNull(this.tableReserve.ReserveTypeColumn);

      [DebuggerNonUserCode]
      public void SetReserveTypeNull()
      {
        this[this.tableReserve.ReserveTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableReserve.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableReserve.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatusRow : DataRow
    {
      private BuildingDB1DataSet.RoomStatusDataTable tableRoomStatus;

      [DebuggerNonUserCode]
      internal RoomStatusRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRoomStatus = (BuildingDB1DataSet.RoomStatusDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableRoomStatus.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte Status
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus.StatusColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableRoomStatus.StatusColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus.DescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableRoomStatus.DescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte RoomType
      {
        get
        {
          try
          {
            return (byte) this[this.tableRoomStatus.RoomTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableRoomStatus.RoomTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableRoomStatus.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableRoomStatus.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime StartDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus.StartDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StartDate' in table 'RoomStatus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus.StartDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime EndDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableRoomStatus.EndDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'EndDate' in table 'RoomStatus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus.EndDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableRoomStatus.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableRoomStatus.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableRoomStatus.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'RoomStatus' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableRoomStatus.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableRoomStatus.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableRoomStatus.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStatusNull() => this.IsNull(this.tableRoomStatus.StatusColumn);

      [DebuggerNonUserCode]
      public void SetStatusNull() => this[this.tableRoomStatus.StatusColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescriptionNull() => this.IsNull(this.tableRoomStatus.DescriptionColumn);

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableRoomStatus.DescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomTypeNull() => this.IsNull(this.tableRoomStatus.RoomTypeColumn);

      [DebuggerNonUserCode]
      public void SetRoomTypeNull() => this[this.tableRoomStatus.RoomTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableRoomStatus.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableRoomStatus.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableRoomStatus.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull() => this[this.tableRoomStatus.ConditionColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStartDateNull() => this.IsNull(this.tableRoomStatus.StartDateColumn);

      [DebuggerNonUserCode]
      public void SetStartDateNull() => this[this.tableRoomStatus.StartDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEndDateNull() => this.IsNull(this.tableRoomStatus.EndDateColumn);

      [DebuggerNonUserCode]
      public void SetEndDateNull() => this[this.tableRoomStatus.EndDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableRoomStatus.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableRoomStatus.StaffIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableRoomStatus.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableRoomStatus.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class UnitRefRow : DataRow
    {
      private BuildingDB1DataSet.UnitRefDataTable tableUnitRef;

      [DebuggerNonUserCode]
      internal UnitRefRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableUnitRef = (BuildingDB1DataSet.UnitRefDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableUnitRef.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableUnitRef.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableUnitRef.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableUnitRef.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableUnitRef.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableUnitRef.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableUnitRef.ValidStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidStart' in table 'UnitRef' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableUnitRef.ValidStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidEnd
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableUnitRef.ValidEndColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidEnd' in table 'UnitRef' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableUnitRef.ValidEndColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableUnitRef.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableUnitRef.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableUnitRef.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableUnitRef.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableUnitRef.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableUnitRef.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsValidStartNull() => this.IsNull(this.tableUnitRef.ValidStartColumn);

      [DebuggerNonUserCode]
      public void SetValidStartNull() => this[this.tableUnitRef.ValidStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsValidEndNull() => this.IsNull(this.tableUnitRef.ValidEndColumn);

      [DebuggerNonUserCode]
      public void SetValidEndNull() => this[this.tableUnitRef.ValidEndColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ClientAccRow : DataRow
    {
      private BuildingDB1DataSet.ClientAccDataTable tableClientAcc;

      [DebuggerNonUserCode]
      internal ClientAccRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableClientAcc = (BuildingDB1DataSet.ClientAccDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Condition
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.ConditionColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.ConditionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string OldRoom
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.OldRoomColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.OldRoomColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Deposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.DepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.DepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal KeyDeposit
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.KeyDepositColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.KeyDepositColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Bond
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.BondColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.BondColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public byte NoOfPeople
      {
        get
        {
          try
          {
            return (byte) this[this.tableClientAcc.NoOfPeopleColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableClientAcc.NoOfPeopleColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ContractStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.ContractStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ContractStart' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.ContractStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ContractEnd
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.ContractEndColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ContractEnd' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.ContractEndColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ChargeType
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.ChargeTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.ChargeTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public short GracePeriod
      {
        get
        {
          try
          {
            return (short) this[this.tableClientAcc.GracePeriodColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0;
          }
        }
        set => this[this.tableClientAcc.GracePeriodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.ValidStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidStart' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.ValidStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime ValidEnd
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.ValidEndColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ValidEnd' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.ValidEndColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal LastPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.LastPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.LastPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal AmountPaid
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.AmountPaidColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.AmountPaidColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal AdvancedPayment
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableClientAcc.AdvancedPaymentColumn];
          }
          catch (InvalidCastException ex)
          {
            return 0M;
          }
        }
        set => this[this.tableClientAcc.AdvancedPaymentColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckInDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.CheckInDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckInDate' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.CheckInDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckInTime
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.CheckInTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckInTime' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.CheckInTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckOutDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.CheckOutDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutDate' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.CheckOutDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CheckOutTime
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.CheckOutTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CheckOutTime' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.CheckOutTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime LastRecDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.LastRecDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'LastRecDate' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.LastRecDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BonusDate
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.BonusDateColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.BonusDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime RoomStart
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableClientAcc.RoomStartColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomStart' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.RoomStartColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Remark
      {
        get
        {
          try
          {
            return (string) this[this.tableClientAcc.RemarkColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClientAcc.RemarkColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool RmPriceAdjust
      {
        get
        {
          try
          {
            return (bool) this[this.tableClientAcc.RmPriceAdjustColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RmPriceAdjust' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.RmPriceAdjustColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableClientAcc.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'ClientAcc' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClientAcc.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableClientAcc.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableClientAcc.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableClientAcc.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableClientAcc.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsConditionNull() => this.IsNull(this.tableClientAcc.ConditionColumn);

      [DebuggerNonUserCode]
      public void SetConditionNull() => this[this.tableClientAcc.ConditionColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsOldRoomNull() => this.IsNull(this.tableClientAcc.OldRoomColumn);

      [DebuggerNonUserCode]
      public void SetOldRoomNull() => this[this.tableClientAcc.OldRoomColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableClientAcc.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableClientAcc.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDepositNull() => this.IsNull(this.tableClientAcc.DepositColumn);

      [DebuggerNonUserCode]
      public void SetDepositNull() => this[this.tableClientAcc.DepositColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsKeyDepositNull() => this.IsNull(this.tableClientAcc.KeyDepositColumn);

      [DebuggerNonUserCode]
      public void SetKeyDepositNull()
      {
        this[this.tableClientAcc.KeyDepositColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBondNull() => this.IsNull(this.tableClientAcc.BondColumn);

      [DebuggerNonUserCode]
      public void SetBondNull() => this[this.tableClientAcc.BondColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsNoOfPeopleNull() => this.IsNull(this.tableClientAcc.NoOfPeopleColumn);

      [DebuggerNonUserCode]
      public void SetNoOfPeopleNull()
      {
        this[this.tableClientAcc.NoOfPeopleColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsContractStartNull() => this.IsNull(this.tableClientAcc.ContractStartColumn);

      [DebuggerNonUserCode]
      public void SetContractStartNull()
      {
        this[this.tableClientAcc.ContractStartColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsContractEndNull() => this.IsNull(this.tableClientAcc.ContractEndColumn);

      [DebuggerNonUserCode]
      public void SetContractEndNull()
      {
        this[this.tableClientAcc.ContractEndColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsChargeTypeNull() => this.IsNull(this.tableClientAcc.ChargeTypeColumn);

      [DebuggerNonUserCode]
      public void SetChargeTypeNull()
      {
        this[this.tableClientAcc.ChargeTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsGracePeriodNull() => this.IsNull(this.tableClientAcc.GracePeriodColumn);

      [DebuggerNonUserCode]
      public void SetGracePeriodNull()
      {
        this[this.tableClientAcc.GracePeriodColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsValidStartNull() => this.IsNull(this.tableClientAcc.ValidStartColumn);

      [DebuggerNonUserCode]
      public void SetValidStartNull()
      {
        this[this.tableClientAcc.ValidStartColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsValidEndNull() => this.IsNull(this.tableClientAcc.ValidEndColumn);

      [DebuggerNonUserCode]
      public void SetValidEndNull() => this[this.tableClientAcc.ValidEndColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsLastPaymentNull() => this.IsNull(this.tableClientAcc.LastPaymentColumn);

      [DebuggerNonUserCode]
      public void SetLastPaymentNull()
      {
        this[this.tableClientAcc.LastPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAmountPaidNull() => this.IsNull(this.tableClientAcc.AmountPaidColumn);

      [DebuggerNonUserCode]
      public void SetAmountPaidNull()
      {
        this[this.tableClientAcc.AmountPaidColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAdvancedPaymentNull() => this.IsNull(this.tableClientAcc.AdvancedPaymentColumn);

      [DebuggerNonUserCode]
      public void SetAdvancedPaymentNull()
      {
        this[this.tableClientAcc.AdvancedPaymentColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckInDateNull() => this.IsNull(this.tableClientAcc.CheckInDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckInDateNull()
      {
        this[this.tableClientAcc.CheckInDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckInTimeNull() => this.IsNull(this.tableClientAcc.CheckInTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckInTimeNull()
      {
        this[this.tableClientAcc.CheckInTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutDateNull() => this.IsNull(this.tableClientAcc.CheckOutDateColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutDateNull()
      {
        this[this.tableClientAcc.CheckOutDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsCheckOutTimeNull() => this.IsNull(this.tableClientAcc.CheckOutTimeColumn);

      [DebuggerNonUserCode]
      public void SetCheckOutTimeNull()
      {
        this[this.tableClientAcc.CheckOutTimeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsLastRecDateNull() => this.IsNull(this.tableClientAcc.LastRecDateColumn);

      [DebuggerNonUserCode]
      public void SetLastRecDateNull()
      {
        this[this.tableClientAcc.LastRecDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBonusDateNull() => this.IsNull(this.tableClientAcc.BonusDateColumn);

      [DebuggerNonUserCode]
      public void SetBonusDateNull() => this[this.tableClientAcc.BonusDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomStartNull() => this.IsNull(this.tableClientAcc.RoomStartColumn);

      [DebuggerNonUserCode]
      public void SetRoomStartNull() => this[this.tableClientAcc.RoomStartColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRemarkNull() => this.IsNull(this.tableClientAcc.RemarkColumn);

      [DebuggerNonUserCode]
      public void SetRemarkNull() => this[this.tableClientAcc.RemarkColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRmPriceAdjustNull() => this.IsNull(this.tableClientAcc.RmPriceAdjustColumn);

      [DebuggerNonUserCode]
      public void SetRmPriceAdjustNull()
      {
        this[this.tableClientAcc.RmPriceAdjustColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableClientAcc.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableClientAcc.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ClientRow : DataRow
    {
      private BuildingDB1DataSet.ClientDataTable tableClient;

      [DebuggerNonUserCode]
      internal ClientRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableClient = (BuildingDB1DataSet.ClientDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientType
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.ClientTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.ClientTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ForeName
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.ForeNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.ForeNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string SurName
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.SurNameColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.SurNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Sex
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.SexColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.SexColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Identity
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.IdentityColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.IdentityColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Nationality
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.NationalityColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.NationalityColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Address
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.AddressColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.AddressColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Country
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.CountryColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.CountryColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Contact
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.ContactColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.ContactColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Email
      {
        get
        {
          try
          {
            return (string) this[this.tableClient.EmailColumn];
          }
          catch (InvalidCastException ex)
          {
            return "";
          }
        }
        set => this[this.tableClient.EmailColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableClient.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Client' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableClient.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableClient.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableClient.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsClientTypeNull() => this.IsNull(this.tableClient.ClientTypeColumn);

      [DebuggerNonUserCode]
      public void SetClientTypeNull() => this[this.tableClient.ClientTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsForeNameNull() => this.IsNull(this.tableClient.ForeNameColumn);

      [DebuggerNonUserCode]
      public void SetForeNameNull() => this[this.tableClient.ForeNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsSurNameNull() => this.IsNull(this.tableClient.SurNameColumn);

      [DebuggerNonUserCode]
      public void SetSurNameNull() => this[this.tableClient.SurNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsSexNull() => this.IsNull(this.tableClient.SexColumn);

      [DebuggerNonUserCode]
      public void SetSexNull() => this[this.tableClient.SexColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsIdentityNull() => this.IsNull(this.tableClient.IdentityColumn);

      [DebuggerNonUserCode]
      public void SetIdentityNull() => this[this.tableClient.IdentityColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsNationalityNull() => this.IsNull(this.tableClient.NationalityColumn);

      [DebuggerNonUserCode]
      public void SetNationalityNull() => this[this.tableClient.NationalityColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsAddressNull() => this.IsNull(this.tableClient.AddressColumn);

      [DebuggerNonUserCode]
      public void SetAddressNull() => this[this.tableClient.AddressColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCountryNull() => this.IsNull(this.tableClient.CountryColumn);

      [DebuggerNonUserCode]
      public void SetCountryNull() => this[this.tableClient.CountryColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsContactNull() => this.IsNull(this.tableClient.ContactColumn);

      [DebuggerNonUserCode]
      public void SetContactNull() => this[this.tableClient.ContactColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsEmailNull() => this.IsNull(this.tableClient.EmailColumn);

      [DebuggerNonUserCode]
      public void SetEmailNull() => this[this.tableClient.EmailColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableClient.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableClient.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class CardNoRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.CardNoRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public CardNoRowChangeEvent(BuildingDB1DataSet.CardNoRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardNoRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class CardTransRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.CardTransRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public CardTransRowChangeEvent(BuildingDB1DataSet.CardTransRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.CardTransRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class AllLockedRecordRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.AllLockedRecordRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public AllLockedRecordRowChangeEvent(
        BuildingDB1DataSet.AllLockedRecordRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.AllLockedRecordRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class EventLogRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.EventLogRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EventLogRowChangeEvent(BuildingDB1DataSet.EventLogRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.EventLogRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ExtraChargeRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.ExtraChargeRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ExtraChargeRowChangeEvent(BuildingDB1DataSet.ExtraChargeRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ExtraChargeRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class KeyChargesRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.KeyChargesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public KeyChargesRowChangeEvent(BuildingDB1DataSet.KeyChargesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.KeyChargesRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LastTransRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.LastTransRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public LastTransRowChangeEvent(BuildingDB1DataSet.LastTransRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LastTransRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LockedRecordRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.LockedRecordRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public LockedRecordRowChangeEvent(
        BuildingDB1DataSet.LockedRecordRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LockedRecordRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class LogInOutRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.LogInOutRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public LogInOutRowChangeEvent(BuildingDB1DataSet.LogInOutRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.LogInOutRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ReserveRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.ReserveRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ReserveRowChangeEvent(BuildingDB1DataSet.ReserveRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ReserveRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class RoomStatusRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.RoomStatusRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public RoomStatusRowChangeEvent(BuildingDB1DataSet.RoomStatusRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.RoomStatusRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class UnitRefRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.UnitRefRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public UnitRefRowChangeEvent(BuildingDB1DataSet.UnitRefRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.UnitRefRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ClientAccRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.ClientAccRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ClientAccRowChangeEvent(BuildingDB1DataSet.ClientAccRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientAccRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ClientRowChangeEvent : EventArgs
    {
      private BuildingDB1DataSet.ClientRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ClientRowChangeEvent(BuildingDB1DataSet.ClientRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BuildingDB1DataSet.ClientRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
