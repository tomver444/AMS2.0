// Decompiled with JetBrains decompiler
// Type: AMS.ErradjustDBDataSet
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
  [XmlRoot("ErradjustDBDataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [ToolboxItem(true)]
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [Serializable]
  public class ErradjustDBDataSet : DataSet
  {
    private ErradjustDBDataSet.ErradjustDataTable tableErradjust;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public ErradjustDBDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected ErradjustDBDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Erradjust)] != null)
            base.Tables.Add((DataTable) new ErradjustDBDataSet.ErradjustDataTable(dataSet.Tables[nameof (Erradjust)]));
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

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ErradjustDBDataSet.ErradjustDataTable Erradjust => this.tableErradjust;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DebuggerNonUserCode]
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
      ErradjustDBDataSet erradjustDbDataSet = (ErradjustDBDataSet) base.Clone();
      erradjustDbDataSet.InitVars();
      erradjustDbDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) erradjustDbDataSet;
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
        if (dataSet.Tables["Erradjust"] != null)
          base.Tables.Add((DataTable) new ErradjustDBDataSet.ErradjustDataTable(dataSet.Tables["Erradjust"]));
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
      this.tableErradjust = (ErradjustDBDataSet.ErradjustDataTable) base.Tables["Erradjust"];
      if (!initTable || this.tableErradjust == null)
        return;
      this.tableErradjust.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "ErradjustDBDataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/ErradjustDBDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableErradjust = new ErradjustDBDataSet.ErradjustDataTable();
      base.Tables.Add((DataTable) this.tableErradjust);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeErradjust() => false;

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
      ErradjustDBDataSet erradjustDbDataSet = new ErradjustDBDataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = erradjustDbDataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = erradjustDbDataSet.GetSchemaSerializable();
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

    public delegate void ErradjustRowChangeEventHandler(
      object sender,
      ErradjustDBDataSet.ErradjustRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class ErradjustDataTable : DataTable, IEnumerable
    {
      private DataColumn columnPaymentNoteNo;
      private DataColumn columnRoomNo;
      private DataColumn columnErrDescription;
      private DataColumn columnErrAmount;
      private DataColumn columnBondErrDescription;
      private DataColumn columnBondErrAmount;
      private DataColumn columnTransType;
      private DataColumn columnTransDate;
      private DataColumn columnTransTime;
      private DataColumn columnCurrDate;
      private DataColumn columnCurrTime;
      private DataColumn columnStaffID;

      [DebuggerNonUserCode]
      public ErradjustDataTable()
      {
        this.TableName = "Erradjust";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ErradjustDataTable(DataTable table)
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
      protected ErradjustDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn PaymentNoteNoColumn => this.columnPaymentNoteNo;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn ErrDescriptionColumn => this.columnErrDescription;

      [DebuggerNonUserCode]
      public DataColumn ErrAmountColumn => this.columnErrAmount;

      [DebuggerNonUserCode]
      public DataColumn BondErrDescriptionColumn => this.columnBondErrDescription;

      [DebuggerNonUserCode]
      public DataColumn BondErrAmountColumn => this.columnBondErrAmount;

      [DebuggerNonUserCode]
      public DataColumn TransTypeColumn => this.columnTransType;

      [DebuggerNonUserCode]
      public DataColumn TransDateColumn => this.columnTransDate;

      [DebuggerNonUserCode]
      public DataColumn TransTimeColumn => this.columnTransTime;

      [DebuggerNonUserCode]
      public DataColumn CurrDateColumn => this.columnCurrDate;

      [DebuggerNonUserCode]
      public DataColumn CurrTimeColumn => this.columnCurrTime;

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public ErradjustDBDataSet.ErradjustRow this[int index]
      {
        get => (ErradjustDBDataSet.ErradjustRow) this.Rows[index];
      }

      public event ErradjustDBDataSet.ErradjustRowChangeEventHandler ErradjustRowChanging;

      public event ErradjustDBDataSet.ErradjustRowChangeEventHandler ErradjustRowChanged;

      public event ErradjustDBDataSet.ErradjustRowChangeEventHandler ErradjustRowDeleting;

      public event ErradjustDBDataSet.ErradjustRowChangeEventHandler ErradjustRowDeleted;

      [DebuggerNonUserCode]
      public void AddErradjustRow(ErradjustDBDataSet.ErradjustRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public ErradjustDBDataSet.ErradjustRow AddErradjustRow(
        int PaymentNoteNo,
        string RoomNo,
        string ErrDescription,
        Decimal ErrAmount,
        string BondErrDescription,
        Decimal BondErrAmount,
        string TransType,
        DateTime TransDate,
        string TransTime,
        DateTime CurrDate,
        string CurrTime,
        string StaffID)
      {
        ErradjustDBDataSet.ErradjustRow row = (ErradjustDBDataSet.ErradjustRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) PaymentNoteNo,
          (object) RoomNo,
          (object) ErrDescription,
          (object) ErrAmount,
          (object) BondErrDescription,
          (object) BondErrAmount,
          (object) TransType,
          (object) TransDate,
          (object) TransTime,
          (object) CurrDate,
          (object) CurrTime,
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
        ErradjustDBDataSet.ErradjustDataTable erradjustDataTable = (ErradjustDBDataSet.ErradjustDataTable) base.Clone();
        erradjustDataTable.InitVars();
        return (DataTable) erradjustDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ErradjustDBDataSet.ErradjustDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnPaymentNoteNo = this.Columns["PaymentNoteNo"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnErrDescription = this.Columns["ErrDescription"];
        this.columnErrAmount = this.Columns["ErrAmount"];
        this.columnBondErrDescription = this.Columns["BondErrDescription"];
        this.columnBondErrAmount = this.Columns["BondErrAmount"];
        this.columnTransType = this.Columns["TransType"];
        this.columnTransDate = this.Columns["TransDate"];
        this.columnTransTime = this.Columns["TransTime"];
        this.columnCurrDate = this.Columns["CurrDate"];
        this.columnCurrTime = this.Columns["CurrTime"];
        this.columnStaffID = this.Columns["StaffID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnPaymentNoteNo = new DataColumn("PaymentNoteNo", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPaymentNoteNo);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnErrDescription = new DataColumn("ErrDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnErrDescription);
        this.columnErrAmount = new DataColumn("ErrAmount", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnErrAmount);
        this.columnBondErrDescription = new DataColumn("BondErrDescription", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBondErrDescription);
        this.columnBondErrAmount = new DataColumn("BondErrAmount", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBondErrAmount);
        this.columnTransType = new DataColumn("TransType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransType);
        this.columnTransDate = new DataColumn("TransDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransDate);
        this.columnTransTime = new DataColumn("TransTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransTime);
        this.columnCurrDate = new DataColumn("CurrDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCurrDate);
        this.columnCurrTime = new DataColumn("CurrTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCurrTime);
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnRoomNo.MaxLength = 5;
        this.columnErrDescription.MaxLength = 100;
        this.columnBondErrDescription.MaxLength = 100;
        this.columnTransType.MaxLength = 2;
        this.columnTransTime.MaxLength = 12;
        this.columnCurrTime.MaxLength = 12;
        this.columnStaffID.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public ErradjustDBDataSet.ErradjustRow NewErradjustRow()
      {
        return (ErradjustDBDataSet.ErradjustRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ErradjustDBDataSet.ErradjustRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (ErradjustDBDataSet.ErradjustRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ErradjustRowChanged == null)
          return;
        this.ErradjustRowChanged((object) this, new ErradjustDBDataSet.ErradjustRowChangeEvent((ErradjustDBDataSet.ErradjustRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ErradjustRowChanging == null)
          return;
        this.ErradjustRowChanging((object) this, new ErradjustDBDataSet.ErradjustRowChangeEvent((ErradjustDBDataSet.ErradjustRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ErradjustRowDeleted == null)
          return;
        this.ErradjustRowDeleted((object) this, new ErradjustDBDataSet.ErradjustRowChangeEvent((ErradjustDBDataSet.ErradjustRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ErradjustRowDeleting == null)
          return;
        this.ErradjustRowDeleting((object) this, new ErradjustDBDataSet.ErradjustRowChangeEvent((ErradjustDBDataSet.ErradjustRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveErradjustRow(ErradjustDBDataSet.ErradjustRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ErradjustDBDataSet erradjustDbDataSet = new ErradjustDBDataSet();
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
          FixedValue = erradjustDbDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ErradjustDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = erradjustDbDataSet.GetSchemaSerializable();
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
    public class ErradjustRow : DataRow
    {
      private ErradjustDBDataSet.ErradjustDataTable tableErradjust;

      [DebuggerNonUserCode]
      internal ErradjustRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableErradjust = (ErradjustDBDataSet.ErradjustDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int PaymentNoteNo
      {
        get
        {
          try
          {
            return (int) this[this.tableErradjust.PaymentNoteNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'PaymentNoteNo' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.PaymentNoteNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ErrDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.ErrDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ErrDescription' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.ErrDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal ErrAmount
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableErradjust.ErrAmountColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ErrAmount' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.ErrAmountColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string BondErrDescription
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.BondErrDescriptionColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BondErrDescription' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.BondErrDescriptionColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal BondErrAmount
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableErradjust.BondErrAmountColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BondErrAmount' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.BondErrAmountColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransType
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.TransTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransType' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.TransTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime TransDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableErradjust.TransDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransDate' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.TransDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransTime
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.TransTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransTime' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.TransTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime CurrDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableErradjust.CurrDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CurrDate' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.CurrDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CurrTime
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.CurrTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CurrTime' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.CurrTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get
        {
          try
          {
            return (string) this[this.tableErradjust.StaffIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StaffID' in table 'Erradjust' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableErradjust.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsPaymentNoteNoNull() => this.IsNull(this.tableErradjust.PaymentNoteNoColumn);

      [DebuggerNonUserCode]
      public void SetPaymentNoteNoNull()
      {
        this[this.tableErradjust.PaymentNoteNoColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableErradjust.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableErradjust.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsErrDescriptionNull() => this.IsNull(this.tableErradjust.ErrDescriptionColumn);

      [DebuggerNonUserCode]
      public void SetErrDescriptionNull()
      {
        this[this.tableErradjust.ErrDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsErrAmountNull() => this.IsNull(this.tableErradjust.ErrAmountColumn);

      [DebuggerNonUserCode]
      public void SetErrAmountNull() => this[this.tableErradjust.ErrAmountColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsBondErrDescriptionNull()
      {
        return this.IsNull(this.tableErradjust.BondErrDescriptionColumn);
      }

      [DebuggerNonUserCode]
      public void SetBondErrDescriptionNull()
      {
        this[this.tableErradjust.BondErrDescriptionColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsBondErrAmountNull() => this.IsNull(this.tableErradjust.BondErrAmountColumn);

      [DebuggerNonUserCode]
      public void SetBondErrAmountNull()
      {
        this[this.tableErradjust.BondErrAmountColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsTransTypeNull() => this.IsNull(this.tableErradjust.TransTypeColumn);

      [DebuggerNonUserCode]
      public void SetTransTypeNull() => this[this.tableErradjust.TransTypeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransDateNull() => this.IsNull(this.tableErradjust.TransDateColumn);

      [DebuggerNonUserCode]
      public void SetTransDateNull() => this[this.tableErradjust.TransDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransTimeNull() => this.IsNull(this.tableErradjust.TransTimeColumn);

      [DebuggerNonUserCode]
      public void SetTransTimeNull() => this[this.tableErradjust.TransTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCurrDateNull() => this.IsNull(this.tableErradjust.CurrDateColumn);

      [DebuggerNonUserCode]
      public void SetCurrDateNull() => this[this.tableErradjust.CurrDateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCurrTimeNull() => this.IsNull(this.tableErradjust.CurrTimeColumn);

      [DebuggerNonUserCode]
      public void SetCurrTimeNull() => this[this.tableErradjust.CurrTimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsStaffIDNull() => this.IsNull(this.tableErradjust.StaffIDColumn);

      [DebuggerNonUserCode]
      public void SetStaffIDNull() => this[this.tableErradjust.StaffIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ErradjustRowChangeEvent : EventArgs
    {
      private ErradjustDBDataSet.ErradjustRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ErradjustRowChangeEvent(ErradjustDBDataSet.ErradjustRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public ErradjustDBDataSet.ErradjustRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
