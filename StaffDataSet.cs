// Decompiled with JetBrains decompiler
// Type: AMS.StaffDataSet
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
  [XmlRoot("StaffDataSet")]
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class StaffDataSet : DataSet
  {
    private StaffDataSet.StaffDataTable tableStaff;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public StaffDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected StaffDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Staff)] != null)
            base.Tables.Add((DataTable) new StaffDataSet.StaffDataTable(dataSet.Tables[nameof (Staff)]));
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
    public StaffDataSet.StaffDataTable Staff => this.tableStaff;

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
      StaffDataSet staffDataSet = (StaffDataSet) base.Clone();
      staffDataSet.InitVars();
      staffDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) staffDataSet;
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
        if (dataSet.Tables["Staff"] != null)
          base.Tables.Add((DataTable) new StaffDataSet.StaffDataTable(dataSet.Tables["Staff"]));
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
      this.tableStaff = (StaffDataSet.StaffDataTable) base.Tables["Staff"];
      if (!initTable || this.tableStaff == null)
        return;
      this.tableStaff.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
            this.DataSetName = "StaffDataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/StaffDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableStaff = new StaffDataSet.StaffDataTable();
      base.Tables.Add((DataTable) this.tableStaff);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeStaff() => false;

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
      StaffDataSet staffDataSet = new StaffDataSet();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = staffDataSet.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = staffDataSet.GetSchemaSerializable();
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

    public delegate void StaffRowChangeEventHandler(
      object sender,
      StaffDataSet.StaffRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class StaffDataTable : DataTable, IEnumerable
    {
      private DataColumn columnStaffID;
      private DataColumn columnAccLevel;
      private DataColumn columnAccBuilding1;
      private DataColumn columnAccBuilding2;
      private DataColumn columnAccBuilding3;
      private DataColumn columnAccBuilding4;
      private DataColumn columnAccBuilding5;
      private DataColumn columnAccBuilding6;
      private DataColumn columnSForeName;
      private DataColumn columnSSurName;
      private DataColumn columnIdentity;
      private DataColumn columnPassword;
      private DataColumn columnUpdate;

      [DebuggerNonUserCode]
      public StaffDataTable()
      {
        this.TableName = "Staff";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal StaffDataTable(DataTable table)
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
      protected StaffDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn StaffIDColumn => this.columnStaffID;

      [DebuggerNonUserCode]
      public DataColumn AccLevelColumn => this.columnAccLevel;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding1Column => this.columnAccBuilding1;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding2Column => this.columnAccBuilding2;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding3Column => this.columnAccBuilding3;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding4Column => this.columnAccBuilding4;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding5Column => this.columnAccBuilding5;

      [DebuggerNonUserCode]
      public DataColumn AccBuilding6Column => this.columnAccBuilding6;

      [DebuggerNonUserCode]
      public DataColumn SForeNameColumn => this.columnSForeName;

      [DebuggerNonUserCode]
      public DataColumn SSurNameColumn => this.columnSSurName;

      [DebuggerNonUserCode]
      public DataColumn IdentityColumn => this.columnIdentity;

      [DebuggerNonUserCode]
      public DataColumn PasswordColumn => this.columnPassword;

      [DebuggerNonUserCode]
      public DataColumn UpdateColumn => this.columnUpdate;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public StaffDataSet.StaffRow this[int index] => (StaffDataSet.StaffRow) this.Rows[index];

      public event StaffDataSet.StaffRowChangeEventHandler StaffRowChanging;

      public event StaffDataSet.StaffRowChangeEventHandler StaffRowChanged;

      public event StaffDataSet.StaffRowChangeEventHandler StaffRowDeleting;

      public event StaffDataSet.StaffRowChangeEventHandler StaffRowDeleted;

      [DebuggerNonUserCode]
      public void AddStaffRow(StaffDataSet.StaffRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public StaffDataSet.StaffRow AddStaffRow(
        string StaffID,
        string AccLevel,
        bool AccBuilding1,
        bool AccBuilding2,
        bool AccBuilding3,
        bool AccBuilding4,
        bool AccBuilding5,
        bool AccBuilding6,
        string SForeName,
        string SSurName,
        string Identity,
        string Password,
        bool Update)
      {
        StaffDataSet.StaffRow row = (StaffDataSet.StaffRow) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) StaffID,
          (object) AccLevel,
          (object) AccBuilding1,
          (object) AccBuilding2,
          (object) AccBuilding3,
          (object) AccBuilding4,
          (object) AccBuilding5,
          (object) AccBuilding6,
          (object) SForeName,
          (object) SSurName,
          (object) Identity,
          (object) Password,
          (object) Update
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public StaffDataSet.StaffRow FindByStaffID(string StaffID)
      {
        return (StaffDataSet.StaffRow) this.Rows.Find(new object[1]
        {
          (object) StaffID
        });
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        StaffDataSet.StaffDataTable staffDataTable = (StaffDataSet.StaffDataTable) base.Clone();
        staffDataTable.InitVars();
        return (DataTable) staffDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new StaffDataSet.StaffDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnStaffID = this.Columns["StaffID"];
        this.columnAccLevel = this.Columns["AccLevel"];
        this.columnAccBuilding1 = this.Columns["AccBuilding1"];
        this.columnAccBuilding2 = this.Columns["AccBuilding2"];
        this.columnAccBuilding3 = this.Columns["AccBuilding3"];
        this.columnAccBuilding4 = this.Columns["AccBuilding4"];
        this.columnAccBuilding5 = this.Columns["AccBuilding5"];
        this.columnAccBuilding6 = this.Columns["AccBuilding6"];
        this.columnSForeName = this.Columns["SForeName"];
        this.columnSSurName = this.Columns["SSurName"];
        this.columnIdentity = this.Columns["Identity"];
        this.columnPassword = this.Columns["Password"];
        this.columnUpdate = this.Columns["Update"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnStaffID = new DataColumn("StaffID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStaffID);
        this.columnAccLevel = new DataColumn("AccLevel", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccLevel);
        this.columnAccBuilding1 = new DataColumn("AccBuilding1", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding1);
        this.columnAccBuilding2 = new DataColumn("AccBuilding2", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding2);
        this.columnAccBuilding3 = new DataColumn("AccBuilding3", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding3);
        this.columnAccBuilding4 = new DataColumn("AccBuilding4", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding4);
        this.columnAccBuilding5 = new DataColumn("AccBuilding5", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding5);
        this.columnAccBuilding6 = new DataColumn("AccBuilding6", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnAccBuilding6);
        this.columnSForeName = new DataColumn("SForeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSForeName);
        this.columnSSurName = new DataColumn("SSurName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSSurName);
        this.columnIdentity = new DataColumn("Identity", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIdentity);
        this.columnPassword = new DataColumn("Password", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPassword);
        this.columnUpdate = new DataColumn("Update", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUpdate);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnStaffID
        }, true));
        this.columnStaffID.AllowDBNull = false;
        this.columnStaffID.Unique = true;
        this.columnStaffID.MaxLength = 10;
        this.columnAccLevel.MaxLength = 1;
        this.columnSForeName.MaxLength = 20;
        this.columnSSurName.MaxLength = 20;
        this.columnIdentity.MaxLength = 20;
        this.columnPassword.MaxLength = 8;
      }

      [DebuggerNonUserCode]
      public StaffDataSet.StaffRow NewStaffRow() => (StaffDataSet.StaffRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new StaffDataSet.StaffRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (StaffDataSet.StaffRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.StaffRowChanged == null)
          return;
        this.StaffRowChanged((object) this, new StaffDataSet.StaffRowChangeEvent((StaffDataSet.StaffRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.StaffRowChanging == null)
          return;
        this.StaffRowChanging((object) this, new StaffDataSet.StaffRowChangeEvent((StaffDataSet.StaffRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.StaffRowDeleted == null)
          return;
        this.StaffRowDeleted((object) this, new StaffDataSet.StaffRowChangeEvent((StaffDataSet.StaffRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.StaffRowDeleting == null)
          return;
        this.StaffRowDeleting((object) this, new StaffDataSet.StaffRowChangeEvent((StaffDataSet.StaffRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveStaffRow(StaffDataSet.StaffRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        StaffDataSet staffDataSet = new StaffDataSet();
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
          FixedValue = staffDataSet.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "StaffDataTable"
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = staffDataSet.GetSchemaSerializable();
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
    public class StaffRow : DataRow
    {
      private StaffDataSet.StaffDataTable tableStaff;

      [DebuggerNonUserCode]
      internal StaffRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableStaff = (StaffDataSet.StaffDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string StaffID
      {
        get => (string) this[this.tableStaff.StaffIDColumn];
        set => this[this.tableStaff.StaffIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string AccLevel
      {
        get
        {
          try
          {
            return (string) this[this.tableStaff.AccLevelColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccLevel' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccLevelColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding1
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding1' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding2
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding2' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding3
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding3' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding4
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding4Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding4' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding4Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding5
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding5Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding5' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding5Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool AccBuilding6
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.AccBuilding6Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'AccBuilding6' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.AccBuilding6Column] = (object) value;
      }

      [DebuggerNonUserCode]
      public string SForeName
      {
        get
        {
          try
          {
            return (string) this[this.tableStaff.SForeNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SForeName' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.SForeNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string SSurName
      {
        get
        {
          try
          {
            return (string) this[this.tableStaff.SSurNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SSurName' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.SSurNameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Identity
      {
        get
        {
          try
          {
            return (string) this[this.tableStaff.IdentityColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Identity' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.IdentityColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Password
      {
        get
        {
          try
          {
            return (string) this[this.tableStaff.PasswordColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Password' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.PasswordColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Update
      {
        get
        {
          try
          {
            return (bool) this[this.tableStaff.UpdateColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Update' in table 'Staff' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableStaff.UpdateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsAccLevelNull() => this.IsNull(this.tableStaff.AccLevelColumn);

      [DebuggerNonUserCode]
      public void SetAccLevelNull() => this[this.tableStaff.AccLevelColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsAccBuilding1Null() => this.IsNull(this.tableStaff.AccBuilding1Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding1Null()
      {
        this[this.tableStaff.AccBuilding1Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAccBuilding2Null() => this.IsNull(this.tableStaff.AccBuilding2Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding2Null()
      {
        this[this.tableStaff.AccBuilding2Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAccBuilding3Null() => this.IsNull(this.tableStaff.AccBuilding3Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding3Null()
      {
        this[this.tableStaff.AccBuilding3Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAccBuilding4Null() => this.IsNull(this.tableStaff.AccBuilding4Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding4Null()
      {
        this[this.tableStaff.AccBuilding4Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAccBuilding5Null() => this.IsNull(this.tableStaff.AccBuilding5Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding5Null()
      {
        this[this.tableStaff.AccBuilding5Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsAccBuilding6Null() => this.IsNull(this.tableStaff.AccBuilding6Column);

      [DebuggerNonUserCode]
      public void SetAccBuilding6Null()
      {
        this[this.tableStaff.AccBuilding6Column] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      public bool IsSForeNameNull() => this.IsNull(this.tableStaff.SForeNameColumn);

      [DebuggerNonUserCode]
      public void SetSForeNameNull() => this[this.tableStaff.SForeNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsSSurNameNull() => this.IsNull(this.tableStaff.SSurNameColumn);

      [DebuggerNonUserCode]
      public void SetSSurNameNull() => this[this.tableStaff.SSurNameColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsIdentityNull() => this.IsNull(this.tableStaff.IdentityColumn);

      [DebuggerNonUserCode]
      public void SetIdentityNull() => this[this.tableStaff.IdentityColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsPasswordNull() => this.IsNull(this.tableStaff.PasswordColumn);

      [DebuggerNonUserCode]
      public void SetPasswordNull() => this[this.tableStaff.PasswordColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsUpdateNull() => this.IsNull(this.tableStaff.UpdateColumn);

      [DebuggerNonUserCode]
      public void SetUpdateNull() => this[this.tableStaff.UpdateColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class StaffRowChangeEvent : EventArgs
    {
      private StaffDataSet.StaffRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public StaffRowChangeEvent(StaffDataSet.StaffRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public StaffDataSet.StaffRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
