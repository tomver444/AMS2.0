// Decompiled with JetBrains decompiler
// Type: AMS.ReplacementDB1DataSet
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
  [XmlRoot("ReplacementDB1DataSet")]
  [DesignerCategory("code")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [ToolboxItem(true)]
  [Serializable]
  public class ReplacementDB1DataSet : DataSet
  {
    private ReplacementDB1DataSet.ReplacementDataTable tableReplacement;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public ReplacementDB1DataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected ReplacementDB1DataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Replacement)] != null)
            base.Tables.Add((DataTable) new ReplacementDB1DataSet.ReplacementDataTable(dataSet.Tables[nameof (Replacement)]));
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
    public ReplacementDB1DataSet.ReplacementDataTable Replacement => this.tableReplacement;

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

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
      ReplacementDB1DataSet replacementDb1DataSet = (ReplacementDB1DataSet) base.Clone();
      replacementDb1DataSet.InitVars();
      replacementDb1DataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) replacementDb1DataSet;
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
        if (dataSet.Tables["Replacement"] != null)
          base.Tables.Add((DataTable) new ReplacementDB1DataSet.ReplacementDataTable(dataSet.Tables["Replacement"]));
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
      this.tableReplacement = (ReplacementDB1DataSet.ReplacementDataTable) base.Tables["Replacement"];
      if (!initTable || this.tableReplacement == null)
        return;
      this.tableReplacement.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "ReplacementDB1DataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/RepacementDB1DataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableReplacement = new ReplacementDB1DataSet.ReplacementDataTable();
      base.Tables.Add((DataTable) this.tableReplacement);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeReplacement() => false;

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
      ReplacementDB1DataSet replacementDb1DataSet = new ReplacementDB1DataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = replacementDb1DataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = replacementDb1DataSet.GetSchemaSerializable();
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

    public delegate void ReplacementRowChangeEventHandler(
      object sender,
      ReplacementDB1DataSet.ReplacementRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class ReplacementDataTable : TypedTableBase<ReplacementDB1DataSet.ReplacementRow>
    {
      private DataColumn columnReceiptID;
      private DataColumn columnClientID;
      private DataColumn columnRoomNo;
      private DataColumn columnCardNo;
      private DataColumn columnTransType;
      private DataColumn columnTransactionDate;
      private DataColumn columnTransactionTime;

      [DebuggerNonUserCode]
      public ReplacementDataTable()
      {
        this.TableName = "Replacement";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ReplacementDataTable(DataTable table)
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
      protected ReplacementDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn ReceiptIDColumn => this.columnReceiptID;

      [DebuggerNonUserCode]
      public DataColumn ClientIDColumn => this.columnClientID;

      [DebuggerNonUserCode]
      public DataColumn RoomNoColumn => this.columnRoomNo;

      [DebuggerNonUserCode]
      public DataColumn CardNoColumn => this.columnCardNo;

      [DebuggerNonUserCode]
      public DataColumn TransTypeColumn => this.columnTransType;

      [DebuggerNonUserCode]
      public DataColumn TransactionDateColumn => this.columnTransactionDate;

      [DebuggerNonUserCode]
      public DataColumn TransactionTimeColumn => this.columnTransactionTime;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public ReplacementDB1DataSet.ReplacementRow this[int index]
      {
        get => (ReplacementDB1DataSet.ReplacementRow) this.Rows[index];
      }

      public event ReplacementDB1DataSet.ReplacementRowChangeEventHandler ReplacementRowChanging;

      public event ReplacementDB1DataSet.ReplacementRowChangeEventHandler ReplacementRowChanged;

      public event ReplacementDB1DataSet.ReplacementRowChangeEventHandler ReplacementRowDeleting;

      public event ReplacementDB1DataSet.ReplacementRowChangeEventHandler ReplacementRowDeleted;

      [DebuggerNonUserCode]
      public void AddReplacementRow(ReplacementDB1DataSet.ReplacementRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public ReplacementDB1DataSet.ReplacementRow AddReplacementRow(
        int ReceiptID,
        string ClientID,
        string RoomNo,
        string CardNo,
        string TransType,
        DateTime TransactionDate,
        string TransactionTime)
      {
        ReplacementDB1DataSet.ReplacementRow row = (ReplacementDB1DataSet.ReplacementRow) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) ReceiptID,
          (object) ClientID,
          (object) RoomNo,
          (object) CardNo,
          (object) TransType,
          (object) TransactionDate,
          (object) TransactionTime
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        ReplacementDB1DataSet.ReplacementDataTable replacementDataTable = (ReplacementDB1DataSet.ReplacementDataTable) base.Clone();
        replacementDataTable.InitVars();
        return (DataTable) replacementDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ReplacementDB1DataSet.ReplacementDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnReceiptID = this.Columns["ReceiptID"];
        this.columnClientID = this.Columns["ClientID"];
        this.columnRoomNo = this.Columns["RoomNo"];
        this.columnCardNo = this.Columns["CardNo"];
        this.columnTransType = this.Columns["TransType"];
        this.columnTransactionDate = this.Columns["TransactionDate"];
        this.columnTransactionTime = this.Columns["TransactionTime"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnReceiptID = new DataColumn("ReceiptID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReceiptID);
        this.columnClientID = new DataColumn("ClientID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnClientID);
        this.columnRoomNo = new DataColumn("RoomNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRoomNo);
        this.columnCardNo = new DataColumn("CardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCardNo);
        this.columnTransType = new DataColumn("TransType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransType);
        this.columnTransactionDate = new DataColumn("TransactionDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransactionDate);
        this.columnTransactionTime = new DataColumn("TransactionTime", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTransactionTime);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnCardNo
        }, false));
        this.columnClientID.MaxLength = 10;
        this.columnRoomNo.MaxLength = 5;
        this.columnCardNo.Unique = true;
        this.columnCardNo.MaxLength = 5;
        this.columnTransType.MaxLength = 2;
        this.columnTransactionTime.MaxLength = 12;
      }

      [DebuggerNonUserCode]
      public ReplacementDB1DataSet.ReplacementRow NewReplacementRow()
      {
        return (ReplacementDB1DataSet.ReplacementRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ReplacementDB1DataSet.ReplacementRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (ReplacementDB1DataSet.ReplacementRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ReplacementRowChanged == null)
          return;
        this.ReplacementRowChanged((object) this, new ReplacementDB1DataSet.ReplacementRowChangeEvent((ReplacementDB1DataSet.ReplacementRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ReplacementRowChanging == null)
          return;
        this.ReplacementRowChanging((object) this, new ReplacementDB1DataSet.ReplacementRowChangeEvent((ReplacementDB1DataSet.ReplacementRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ReplacementRowDeleted == null)
          return;
        this.ReplacementRowDeleted((object) this, new ReplacementDB1DataSet.ReplacementRowChangeEvent((ReplacementDB1DataSet.ReplacementRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ReplacementRowDeleting == null)
          return;
        this.ReplacementRowDeleting((object) this, new ReplacementDB1DataSet.ReplacementRowChangeEvent((ReplacementDB1DataSet.ReplacementRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveReplacementRow(ReplacementDB1DataSet.ReplacementRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ReplacementDB1DataSet replacementDb1DataSet = new ReplacementDB1DataSet();
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
          FixedValue = replacementDb1DataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ReplacementDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = replacementDb1DataSet.GetSchemaSerializable();
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
    public class ReplacementRow : DataRow
    {
      private ReplacementDB1DataSet.ReplacementDataTable tableReplacement;

      [DebuggerNonUserCode]
      internal ReplacementRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableReplacement = (ReplacementDB1DataSet.ReplacementDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int ReceiptID
      {
        get
        {
          try
          {
            return (int) this[this.tableReplacement.ReceiptIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ReceiptID' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.ReceiptIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ClientID
      {
        get
        {
          try
          {
            return (string) this[this.tableReplacement.ClientIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ClientID' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.ClientIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string RoomNo
      {
        get
        {
          try
          {
            return (string) this[this.tableReplacement.RoomNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RoomNo' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.RoomNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string CardNo
      {
        get
        {
          try
          {
            return (string) this[this.tableReplacement.CardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CardNo' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.CardNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransType
      {
        get
        {
          try
          {
            return (string) this[this.tableReplacement.TransTypeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransType' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.TransTypeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime TransactionDate
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableReplacement.TransactionDateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransactionDate' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.TransactionDateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string TransactionTime
      {
        get
        {
          try
          {
            return (string) this[this.tableReplacement.TransactionTimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TransactionTime' in table 'Replacement' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableReplacement.TransactionTimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsReceiptIDNull() => this.IsNull(this.tableReplacement.ReceiptIDColumn);

      [DebuggerNonUserCode]
      public void SetReceiptIDNull()
      {
        this[this.tableReplacement.ReceiptIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsClientIDNull() => this.IsNull(this.tableReplacement.ClientIDColumn);

      [DebuggerNonUserCode]
      public void SetClientIDNull() => this[this.tableReplacement.ClientIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsRoomNoNull() => this.IsNull(this.tableReplacement.RoomNoColumn);

      [DebuggerNonUserCode]
      public void SetRoomNoNull() => this[this.tableReplacement.RoomNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCardNoNull() => this.IsNull(this.tableReplacement.CardNoColumn);

      [DebuggerNonUserCode]
      public void SetCardNoNull() => this[this.tableReplacement.CardNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTransTypeNull() => this.IsNull(this.tableReplacement.TransTypeColumn);

      [DebuggerNonUserCode]
      public void SetTransTypeNull()
      {
        this[this.tableReplacement.TransTypeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsTransactionDateNull()
      {
        return this.IsNull(this.tableReplacement.TransactionDateColumn);
      }

      [DebuggerNonUserCode]
      public void SetTransactionDateNull()
      {
        this[this.tableReplacement.TransactionDateColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsTransactionTimeNull()
      {
        return this.IsNull(this.tableReplacement.TransactionTimeColumn);
      }

      [DebuggerNonUserCode]
      public void SetTransactionTimeNull()
      {
        this[this.tableReplacement.TransactionTimeColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ReplacementRowChangeEvent : EventArgs
    {
      private ReplacementDB1DataSet.ReplacementRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ReplacementRowChangeEvent(
        ReplacementDB1DataSet.ReplacementRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public ReplacementDB1DataSet.ReplacementRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
