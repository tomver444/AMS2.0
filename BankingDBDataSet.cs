// Decompiled with JetBrains decompiler
// Type: AMS.BankingDBDataSet
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
  [DesignerCategory("code")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("BankingDBDataSet")]
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [ToolboxItem(true)]
  [Serializable]
  public class BankingDBDataSet : DataSet
  {
    private BankingDBDataSet.BankingDataTable tableBanking;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public BankingDBDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected BankingDBDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Banking)] != null)
            base.Tables.Add((DataTable) new BankingDBDataSet.BankingDataTable(dataSet.Tables[nameof (Banking)]));
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

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public BankingDBDataSet.BankingDataTable Banking => this.tableBanking;

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
      BankingDBDataSet bankingDbDataSet = (BankingDBDataSet) base.Clone();
      bankingDbDataSet.InitVars();
      bankingDbDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) bankingDbDataSet;
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
        if (dataSet.Tables["Banking"] != null)
          base.Tables.Add((DataTable) new BankingDBDataSet.BankingDataTable(dataSet.Tables["Banking"]));
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
      this.tableBanking = (BankingDBDataSet.BankingDataTable) base.Tables["Banking"];
      if (!initTable || this.tableBanking == null)
        return;
      this.tableBanking.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
            this.DataSetName = "BankingDBDataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/BankingDBDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableBanking = new BankingDBDataSet.BankingDataTable();
      base.Tables.Add((DataTable) this.tableBanking);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeBanking() => false;

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
      BankingDBDataSet bankingDbDataSet = new BankingDBDataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = bankingDbDataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = bankingDbDataSet.GetSchemaSerializable();
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

    public delegate void BankingRowChangeEventHandler(
      object sender,
      BankingDBDataSet.BankingRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class BankingDataTable : DataTable, IEnumerable
    {
      private DataColumn columnCodeDesc;
      private DataColumn columnChequeNo;
      private DataColumn columnAmount;
      private DataColumn columnDate;
      private DataColumn columnTime;
      private DataColumn columnOperator;

      [DebuggerNonUserCode]
      public BankingDataTable()
      {
        this.TableName = "Banking";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal BankingDataTable(DataTable table)
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
      protected BankingDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn CodeDescColumn => this.columnCodeDesc;

      [DebuggerNonUserCode]
      public DataColumn ChequeNoColumn => this.columnChequeNo;

      [DebuggerNonUserCode]
      public DataColumn AmountColumn => this.columnAmount;

      [DebuggerNonUserCode]
      public DataColumn DateColumn => this.columnDate;

      [DebuggerNonUserCode]
      public DataColumn TimeColumn => this.columnTime;

      [DebuggerNonUserCode]
      public DataColumn OperatorColumn => this.columnOperator;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public BankingDBDataSet.BankingRow this[int index]
      {
        get => (BankingDBDataSet.BankingRow) this.Rows[index];
      }

      public event BankingDBDataSet.BankingRowChangeEventHandler BankingRowChanging;

      public event BankingDBDataSet.BankingRowChangeEventHandler BankingRowChanged;

      public event BankingDBDataSet.BankingRowChangeEventHandler BankingRowDeleting;

      public event BankingDBDataSet.BankingRowChangeEventHandler BankingRowDeleted;

      [DebuggerNonUserCode]
      public void AddBankingRow(BankingDBDataSet.BankingRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public BankingDBDataSet.BankingRow AddBankingRow(
        string CodeDesc,
        string ChequeNo,
        Decimal Amount,
        DateTime Date,
        string Time,
        string Operator)
      {
        BankingDBDataSet.BankingRow row = (BankingDBDataSet.BankingRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) CodeDesc,
          (object) ChequeNo,
          (object) Amount,
          (object) Date,
          (object) Time,
          (object) Operator
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
        BankingDBDataSet.BankingDataTable bankingDataTable = (BankingDBDataSet.BankingDataTable) base.Clone();
        bankingDataTable.InitVars();
        return (DataTable) bankingDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new BankingDBDataSet.BankingDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnCodeDesc = this.Columns["CodeDesc"];
        this.columnChequeNo = this.Columns["ChequeNo"];
        this.columnAmount = this.Columns["Amount"];
        this.columnDate = this.Columns["Date"];
        this.columnTime = this.Columns["Time"];
        this.columnOperator = this.Columns["Operator"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnCodeDesc = new DataColumn("CodeDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCodeDesc);
        this.columnChequeNo = new DataColumn("ChequeNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnChequeNo);
        this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAmount);
        this.columnDate = new DataColumn("Date", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDate);
        this.columnTime = new DataColumn("Time", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTime);
        this.columnOperator = new DataColumn("Operator", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOperator);
        this.columnCodeDesc.MaxLength = 10;
        this.columnChequeNo.MaxLength = 30;
        this.columnTime.MaxLength = 12;
        this.columnOperator.MaxLength = 10;
      }

      [DebuggerNonUserCode]
      public BankingDBDataSet.BankingRow NewBankingRow()
      {
        return (BankingDBDataSet.BankingRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new BankingDBDataSet.BankingRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (BankingDBDataSet.BankingRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.BankingRowChanged == null)
          return;
        this.BankingRowChanged((object) this, new BankingDBDataSet.BankingRowChangeEvent((BankingDBDataSet.BankingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.BankingRowChanging == null)
          return;
        this.BankingRowChanging((object) this, new BankingDBDataSet.BankingRowChangeEvent((BankingDBDataSet.BankingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.BankingRowDeleted == null)
          return;
        this.BankingRowDeleted((object) this, new BankingDBDataSet.BankingRowChangeEvent((BankingDBDataSet.BankingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.BankingRowDeleting == null)
          return;
        this.BankingRowDeleting((object) this, new BankingDBDataSet.BankingRowChangeEvent((BankingDBDataSet.BankingRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveBankingRow(BankingDBDataSet.BankingRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        BankingDBDataSet bankingDbDataSet = new BankingDBDataSet();
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
          FixedValue = bankingDbDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (BankingDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = bankingDbDataSet.GetSchemaSerializable();
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
    public class BankingRow : DataRow
    {
      private BankingDBDataSet.BankingDataTable tableBanking;

      [DebuggerNonUserCode]
      internal BankingRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBanking = (BankingDBDataSet.BankingDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string CodeDesc
      {
        get
        {
          try
          {
            return (string) this[this.tableBanking.CodeDescColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CodeDesc' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.CodeDescColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string ChequeNo
      {
        get
        {
          try
          {
            return (string) this[this.tableBanking.ChequeNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ChequeNo' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.ChequeNoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public Decimal Amount
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableBanking.AmountColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Amount' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.AmountColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime Date
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableBanking.DateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Date' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.DateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Time
      {
        get
        {
          try
          {
            return (string) this[this.tableBanking.TimeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Time' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.TimeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Operator
      {
        get
        {
          try
          {
            return (string) this[this.tableBanking.OperatorColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Operator' in table 'Banking' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableBanking.OperatorColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsCodeDescNull() => this.IsNull(this.tableBanking.CodeDescColumn);

      [DebuggerNonUserCode]
      public void SetCodeDescNull() => this[this.tableBanking.CodeDescColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsChequeNoNull() => this.IsNull(this.tableBanking.ChequeNoColumn);

      [DebuggerNonUserCode]
      public void SetChequeNoNull() => this[this.tableBanking.ChequeNoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsAmountNull() => this.IsNull(this.tableBanking.AmountColumn);

      [DebuggerNonUserCode]
      public void SetAmountNull() => this[this.tableBanking.AmountColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDateNull() => this.IsNull(this.tableBanking.DateColumn);

      [DebuggerNonUserCode]
      public void SetDateNull() => this[this.tableBanking.DateColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTimeNull() => this.IsNull(this.tableBanking.TimeColumn);

      [DebuggerNonUserCode]
      public void SetTimeNull() => this[this.tableBanking.TimeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsOperatorNull() => this.IsNull(this.tableBanking.OperatorColumn);

      [DebuggerNonUserCode]
      public void SetOperatorNull() => this[this.tableBanking.OperatorColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class BankingRowChangeEvent : EventArgs
    {
      private BankingDBDataSet.BankingRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public BankingRowChangeEvent(BankingDBDataSet.BankingRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public BankingDBDataSet.BankingRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
