//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace PC_shop {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("KR_PIDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class KR_PIDataSet : global::System.Data.DataSet {
        
        private ComputersDataTable tableComputers;
        
        private HRDataTable tableHR;
        
        private PartsDataTable tableParts;
        
        private PeripheryDataTable tablePeriphery;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public KR_PIDataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected KR_PIDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Computers"] != null)) {
                    base.Tables.Add(new ComputersDataTable(ds.Tables["Computers"]));
                }
                if ((ds.Tables["HR"] != null)) {
                    base.Tables.Add(new HRDataTable(ds.Tables["HR"]));
                }
                if ((ds.Tables["Parts"] != null)) {
                    base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
                }
                if ((ds.Tables["Periphery"] != null)) {
                    base.Tables.Add(new PeripheryDataTable(ds.Tables["Periphery"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ComputersDataTable Computers {
            get {
                return this.tableComputers;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public HRDataTable HR {
            get {
                return this.tableHR;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PartsDataTable Parts {
            get {
                return this.tableParts;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PeripheryDataTable Periphery {
            get {
                return this.tablePeriphery;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            KR_PIDataSet cln = ((KR_PIDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Computers"] != null)) {
                    base.Tables.Add(new ComputersDataTable(ds.Tables["Computers"]));
                }
                if ((ds.Tables["HR"] != null)) {
                    base.Tables.Add(new HRDataTable(ds.Tables["HR"]));
                }
                if ((ds.Tables["Parts"] != null)) {
                    base.Tables.Add(new PartsDataTable(ds.Tables["Parts"]));
                }
                if ((ds.Tables["Periphery"] != null)) {
                    base.Tables.Add(new PeripheryDataTable(ds.Tables["Periphery"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableComputers = ((ComputersDataTable)(base.Tables["Computers"]));
            if ((initTable == true)) {
                if ((this.tableComputers != null)) {
                    this.tableComputers.InitVars();
                }
            }
            this.tableHR = ((HRDataTable)(base.Tables["HR"]));
            if ((initTable == true)) {
                if ((this.tableHR != null)) {
                    this.tableHR.InitVars();
                }
            }
            this.tableParts = ((PartsDataTable)(base.Tables["Parts"]));
            if ((initTable == true)) {
                if ((this.tableParts != null)) {
                    this.tableParts.InitVars();
                }
            }
            this.tablePeriphery = ((PeripheryDataTable)(base.Tables["Periphery"]));
            if ((initTable == true)) {
                if ((this.tablePeriphery != null)) {
                    this.tablePeriphery.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "KR_PIDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/KR_PIDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableComputers = new ComputersDataTable();
            base.Tables.Add(this.tableComputers);
            this.tableHR = new HRDataTable();
            base.Tables.Add(this.tableHR);
            this.tableParts = new PartsDataTable();
            base.Tables.Add(this.tableParts);
            this.tablePeriphery = new PeripheryDataTable();
            base.Tables.Add(this.tablePeriphery);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeComputers() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeHR() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeParts() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializePeriphery() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            KR_PIDataSet ds = new KR_PIDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void ComputersRowChangeEventHandler(object sender, ComputersRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void HRRowChangeEventHandler(object sender, HRRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void PartsRowChangeEventHandler(object sender, PartsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void PeripheryRowChangeEventHandler(object sender, PeripheryRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class ComputersDataTable : global::System.Data.TypedTableBase<ComputersRow> {
            
            private global::System.Data.DataColumn _columnS_N;
            
            private global::System.Data.DataColumn columnModel;
            
            private global::System.Data.DataColumn columnConfig;
            
            private global::System.Data.DataColumn columnStok;
            
            private global::System.Data.DataColumn columnRetail_price;
            
            private global::System.Data.DataColumn columnWholesale_price;
            
            private global::System.Data.DataColumn columnIncoming_price;
            
            private global::System.Data.DataColumn columnСontractor;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersDataTable() {
                this.TableName = "Computers";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ComputersDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ComputersDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn _S_NColumn {
                get {
                    return this._columnS_N;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ModelColumn {
                get {
                    return this.columnModel;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ConfigColumn {
                get {
                    return this.columnConfig;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StokColumn {
                get {
                    return this.columnStok;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Retail_priceColumn {
                get {
                    return this.columnRetail_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Wholesale_priceColumn {
                get {
                    return this.columnWholesale_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Incoming_priceColumn {
                get {
                    return this.columnIncoming_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn СontractorColumn {
                get {
                    return this.columnСontractor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRow this[int index] {
                get {
                    return ((ComputersRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ComputersRowChangeEventHandler ComputersRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ComputersRowChangeEventHandler ComputersRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ComputersRowChangeEventHandler ComputersRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ComputersRowChangeEventHandler ComputersRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddComputersRow(ComputersRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRow AddComputersRow(string _S_N, string Model, string Config, int Stok, decimal Retail_price, decimal Wholesale_price, decimal Incoming_price, string Сontractor) {
                ComputersRow rowComputersRow = ((ComputersRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        _S_N,
                        Model,
                        Config,
                        Stok,
                        Retail_price,
                        Wholesale_price,
                        Incoming_price,
                        Сontractor};
                rowComputersRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowComputersRow);
                return rowComputersRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRow FindByModel(string Model) {
                return ((ComputersRow)(this.Rows.Find(new object[] {
                            Model})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                ComputersDataTable cln = ((ComputersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new ComputersDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this._columnS_N = base.Columns["S/N"];
                this.columnModel = base.Columns["Model"];
                this.columnConfig = base.Columns["Config"];
                this.columnStok = base.Columns["Stok"];
                this.columnRetail_price = base.Columns["Retail price"];
                this.columnWholesale_price = base.Columns["Wholesale price"];
                this.columnIncoming_price = base.Columns["Incoming price"];
                this.columnСontractor = base.Columns["Сontractor"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this._columnS_N = new global::System.Data.DataColumn("S/N", typeof(string), null, global::System.Data.MappingType.Element);
                this._columnS_N.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnS_N");
                this._columnS_N.ExtendedProperties.Add("Generator_UserColumnName", "S/N");
                base.Columns.Add(this._columnS_N);
                this.columnModel = new global::System.Data.DataColumn("Model", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnModel);
                this.columnConfig = new global::System.Data.DataColumn("Config", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnConfig);
                this.columnStok = new global::System.Data.DataColumn("Stok", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStok);
                this.columnRetail_price = new global::System.Data.DataColumn("Retail price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRetail_price);
                this.columnWholesale_price = new global::System.Data.DataColumn("Wholesale price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWholesale_price);
                this.columnIncoming_price = new global::System.Data.DataColumn("Incoming price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIncoming_price);
                this.columnСontractor = new global::System.Data.DataColumn("Сontractor", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСontractor);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnModel}, true));
                this._columnS_N.MaxLength = 255;
                this.columnModel.AllowDBNull = true;
                this.columnModel.Unique = true;
                this.columnModel.MaxLength = 255;
                this.columnConfig.MaxLength = 255;
                this.columnСontractor.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRow NewComputersRow() {
                return ((ComputersRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new ComputersRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(ComputersRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ComputersRowChanged != null)) {
                    this.ComputersRowChanged(this, new ComputersRowChangeEvent(((ComputersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ComputersRowChanging != null)) {
                    this.ComputersRowChanging(this, new ComputersRowChangeEvent(((ComputersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ComputersRowDeleted != null)) {
                    this.ComputersRowDeleted(this, new ComputersRowChangeEvent(((ComputersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ComputersRowDeleting != null)) {
                    this.ComputersRowDeleting(this, new ComputersRowChangeEvent(((ComputersRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveComputersRow(ComputersRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                KR_PIDataSet ds = new KR_PIDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "ComputersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class HRDataTable : global::System.Data.TypedTableBase<HRRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnName1;
            
            private global::System.Data.DataColumn columnName2;
            
            private global::System.Data.DataColumn columnName3;
            
            private global::System.Data.DataColumn columnAge;
            
            private global::System.Data.DataColumn columnPosition;
            
            private global::System.Data.DataColumn columnTelephone;
            
            private global::System.Data.DataColumn columnAccess;
            
            private global::System.Data.DataColumn columnLogin;
            
            private global::System.Data.DataColumn columnPassword;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRDataTable() {
                this.TableName = "HR";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal HRDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected HRDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Name1Column {
                get {
                    return this.columnName1;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Name2Column {
                get {
                    return this.columnName2;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Name3Column {
                get {
                    return this.columnName3;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AgeColumn {
                get {
                    return this.columnAge;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PositionColumn {
                get {
                    return this.columnPosition;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TelephoneColumn {
                get {
                    return this.columnTelephone;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AccessColumn {
                get {
                    return this.columnAccess;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn LoginColumn {
                get {
                    return this.columnLogin;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn PasswordColumn {
                get {
                    return this.columnPassword;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRow this[int index] {
                get {
                    return ((HRRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HRRowChangeEventHandler HRRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HRRowChangeEventHandler HRRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HRRowChangeEventHandler HRRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event HRRowChangeEventHandler HRRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddHRRow(HRRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRow AddHRRow(int ID, string Name1, string Name2, string Name3, int Age, string Position, string Telephone, string Access, string Login, string Password) {
                HRRow rowHRRow = ((HRRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        ID,
                        Name1,
                        Name2,
                        Name3,
                        Age,
                        Position,
                        Telephone,
                        Access,
                        Login,
                        Password};
                rowHRRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowHRRow);
                return rowHRRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRow FindByLogin(string Login) {
                return ((HRRow)(this.Rows.Find(new object[] {
                            Login})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                HRDataTable cln = ((HRDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new HRDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnName1 = base.Columns["Name1"];
                this.columnName2 = base.Columns["Name2"];
                this.columnName3 = base.Columns["Name3"];
                this.columnAge = base.Columns["Age"];
                this.columnPosition = base.Columns["Position"];
                this.columnTelephone = base.Columns["Telephone"];
                this.columnAccess = base.Columns["Access"];
                this.columnLogin = base.Columns["Login"];
                this.columnPassword = base.Columns["Password"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnName1 = new global::System.Data.DataColumn("Name1", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName1);
                this.columnName2 = new global::System.Data.DataColumn("Name2", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName2);
                this.columnName3 = new global::System.Data.DataColumn("Name3", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName3);
                this.columnAge = new global::System.Data.DataColumn("Age", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAge);
                this.columnPosition = new global::System.Data.DataColumn("Position", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPosition);
                this.columnTelephone = new global::System.Data.DataColumn("Telephone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTelephone);
                this.columnAccess = new global::System.Data.DataColumn("Access", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAccess);
                this.columnLogin = new global::System.Data.DataColumn("Login", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLogin);
                this.columnPassword = new global::System.Data.DataColumn("Password", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPassword);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnLogin}, true));
                this.columnName1.MaxLength = 255;
                this.columnName2.MaxLength = 255;
                this.columnName3.MaxLength = 255;
                this.columnPosition.MaxLength = 255;
                this.columnTelephone.MaxLength = 255;
                this.columnAccess.MaxLength = 255;
                this.columnLogin.AllowDBNull = true;
                this.columnLogin.Unique = true;
                this.columnLogin.MaxLength = 255;
                this.columnPassword.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRow NewHRRow() {
                return ((HRRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new HRRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(HRRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.HRRowChanged != null)) {
                    this.HRRowChanged(this, new HRRowChangeEvent(((HRRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.HRRowChanging != null)) {
                    this.HRRowChanging(this, new HRRowChangeEvent(((HRRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.HRRowDeleted != null)) {
                    this.HRRowDeleted(this, new HRRowChangeEvent(((HRRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.HRRowDeleting != null)) {
                    this.HRRowDeleting(this, new HRRowChangeEvent(((HRRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveHRRow(HRRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                KR_PIDataSet ds = new KR_PIDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "HRDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PartsDataTable : global::System.Data.TypedTableBase<PartsRow> {
            
            private global::System.Data.DataColumn columnArticle;
            
            private global::System.Data.DataColumn columnType;
            
            private global::System.Data.DataColumn columnModel;
            
            private global::System.Data.DataColumn columnStock;
            
            private global::System.Data.DataColumn columnRetail_price;
            
            private global::System.Data.DataColumn columnWholesale_price;
            
            private global::System.Data.DataColumn columnIncoming_price;
            
            private global::System.Data.DataColumn columnContractor;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsDataTable() {
                this.TableName = "Parts";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PartsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected PartsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ArticleColumn {
                get {
                    return this.columnArticle;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TypeColumn {
                get {
                    return this.columnType;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ModelColumn {
                get {
                    return this.columnModel;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StockColumn {
                get {
                    return this.columnStock;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Retail_priceColumn {
                get {
                    return this.columnRetail_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Wholesale_priceColumn {
                get {
                    return this.columnWholesale_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Incoming_priceColumn {
                get {
                    return this.columnIncoming_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ContractorColumn {
                get {
                    return this.columnContractor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRow this[int index] {
                get {
                    return ((PartsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PartsRowChangeEventHandler PartsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PartsRowChangeEventHandler PartsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PartsRowChangeEventHandler PartsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PartsRowChangeEventHandler PartsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddPartsRow(PartsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRow AddPartsRow(int Article, string Type, string Model, int Stock, decimal Retail_price, decimal Wholesale_price, decimal Incoming_price, string Contractor) {
                PartsRow rowPartsRow = ((PartsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Article,
                        Type,
                        Model,
                        Stock,
                        Retail_price,
                        Wholesale_price,
                        Incoming_price,
                        Contractor};
                rowPartsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPartsRow);
                return rowPartsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRow FindByArticle(int Article) {
                return ((PartsRow)(this.Rows.Find(new object[] {
                            Article})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                PartsDataTable cln = ((PartsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new PartsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnArticle = base.Columns["Article"];
                this.columnType = base.Columns["Type"];
                this.columnModel = base.Columns["Model"];
                this.columnStock = base.Columns["Stock"];
                this.columnRetail_price = base.Columns["Retail price"];
                this.columnWholesale_price = base.Columns["Wholesale price"];
                this.columnIncoming_price = base.Columns["Incoming price"];
                this.columnContractor = base.Columns["Contractor"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnArticle = new global::System.Data.DataColumn("Article", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnArticle);
                this.columnType = new global::System.Data.DataColumn("Type", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnType);
                this.columnModel = new global::System.Data.DataColumn("Model", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnModel);
                this.columnStock = new global::System.Data.DataColumn("Stock", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStock);
                this.columnRetail_price = new global::System.Data.DataColumn("Retail price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRetail_price);
                this.columnWholesale_price = new global::System.Data.DataColumn("Wholesale price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWholesale_price);
                this.columnIncoming_price = new global::System.Data.DataColumn("Incoming price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIncoming_price);
                this.columnContractor = new global::System.Data.DataColumn("Contractor", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnContractor);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnArticle}, true));
                this.columnArticle.AllowDBNull = true;
                this.columnArticle.Unique = true;
                this.columnType.MaxLength = 255;
                this.columnModel.MaxLength = 255;
                this.columnContractor.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRow NewPartsRow() {
                return ((PartsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new PartsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(PartsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PartsRowChanged != null)) {
                    this.PartsRowChanged(this, new PartsRowChangeEvent(((PartsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PartsRowChanging != null)) {
                    this.PartsRowChanging(this, new PartsRowChangeEvent(((PartsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PartsRowDeleted != null)) {
                    this.PartsRowDeleted(this, new PartsRowChangeEvent(((PartsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PartsRowDeleting != null)) {
                    this.PartsRowDeleting(this, new PartsRowChangeEvent(((PartsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovePartsRow(PartsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                KR_PIDataSet ds = new KR_PIDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PartsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PeripheryDataTable : global::System.Data.TypedTableBase<PeripheryRow> {
            
            private global::System.Data.DataColumn columnArticle;
            
            private global::System.Data.DataColumn columnType;
            
            private global::System.Data.DataColumn columnModel;
            
            private global::System.Data.DataColumn columnStock;
            
            private global::System.Data.DataColumn columnRetail_price;
            
            private global::System.Data.DataColumn columnWholesale_price;
            
            private global::System.Data.DataColumn columnIncoming_price;
            
            private global::System.Data.DataColumn columnContractor;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryDataTable() {
                this.TableName = "Periphery";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PeripheryDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected PeripheryDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ArticleColumn {
                get {
                    return this.columnArticle;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TypeColumn {
                get {
                    return this.columnType;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ModelColumn {
                get {
                    return this.columnModel;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn StockColumn {
                get {
                    return this.columnStock;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Retail_priceColumn {
                get {
                    return this.columnRetail_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Wholesale_priceColumn {
                get {
                    return this.columnWholesale_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Incoming_priceColumn {
                get {
                    return this.columnIncoming_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ContractorColumn {
                get {
                    return this.columnContractor;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRow this[int index] {
                get {
                    return ((PeripheryRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PeripheryRowChangeEventHandler PeripheryRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PeripheryRowChangeEventHandler PeripheryRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PeripheryRowChangeEventHandler PeripheryRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PeripheryRowChangeEventHandler PeripheryRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddPeripheryRow(PeripheryRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRow AddPeripheryRow(int Article, string Type, string Model, int Stock, decimal Retail_price, decimal Wholesale_price, decimal Incoming_price, string Contractor) {
                PeripheryRow rowPeripheryRow = ((PeripheryRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Article,
                        Type,
                        Model,
                        Stock,
                        Retail_price,
                        Wholesale_price,
                        Incoming_price,
                        Contractor};
                rowPeripheryRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPeripheryRow);
                return rowPeripheryRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRow FindByArticle(int Article) {
                return ((PeripheryRow)(this.Rows.Find(new object[] {
                            Article})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                PeripheryDataTable cln = ((PeripheryDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new PeripheryDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnArticle = base.Columns["Article"];
                this.columnType = base.Columns["Type"];
                this.columnModel = base.Columns["Model"];
                this.columnStock = base.Columns["Stock"];
                this.columnRetail_price = base.Columns["Retail price"];
                this.columnWholesale_price = base.Columns["Wholesale price"];
                this.columnIncoming_price = base.Columns["Incoming price"];
                this.columnContractor = base.Columns["Contractor"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnArticle = new global::System.Data.DataColumn("Article", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnArticle);
                this.columnType = new global::System.Data.DataColumn("Type", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnType);
                this.columnModel = new global::System.Data.DataColumn("Model", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnModel);
                this.columnStock = new global::System.Data.DataColumn("Stock", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStock);
                this.columnRetail_price = new global::System.Data.DataColumn("Retail price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRetail_price);
                this.columnWholesale_price = new global::System.Data.DataColumn("Wholesale price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWholesale_price);
                this.columnIncoming_price = new global::System.Data.DataColumn("Incoming price", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIncoming_price);
                this.columnContractor = new global::System.Data.DataColumn("Contractor", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnContractor);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnArticle}, true));
                this.columnArticle.AllowDBNull = true;
                this.columnArticle.Unique = true;
                this.columnType.MaxLength = 255;
                this.columnModel.MaxLength = 255;
                this.columnContractor.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRow NewPeripheryRow() {
                return ((PeripheryRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new PeripheryRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(PeripheryRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PeripheryRowChanged != null)) {
                    this.PeripheryRowChanged(this, new PeripheryRowChangeEvent(((PeripheryRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PeripheryRowChanging != null)) {
                    this.PeripheryRowChanging(this, new PeripheryRowChangeEvent(((PeripheryRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PeripheryRowDeleted != null)) {
                    this.PeripheryRowDeleted(this, new PeripheryRowChangeEvent(((PeripheryRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PeripheryRowDeleting != null)) {
                    this.PeripheryRowDeleting(this, new PeripheryRowChangeEvent(((PeripheryRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovePeripheryRow(PeripheryRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                KR_PIDataSet ds = new KR_PIDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PeripheryDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class ComputersRow : global::System.Data.DataRow {
            
            private ComputersDataTable tableComputers;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ComputersRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableComputers = ((ComputersDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string _S_N {
                get {
                    try {
                        return ((string)(this[this.tableComputers._S_NColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'S/N\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers._S_NColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Model {
                get {
                    return ((string)(this[this.tableComputers.ModelColumn]));
                }
                set {
                    this[this.tableComputers.ModelColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Config {
                get {
                    try {
                        return ((string)(this[this.tableComputers.ConfigColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Config\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.ConfigColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Stok {
                get {
                    try {
                        return ((int)(this[this.tableComputers.StokColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Stok\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.StokColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Retail_price {
                get {
                    try {
                        return ((decimal)(this[this.tableComputers.Retail_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Retail price\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.Retail_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Wholesale_price {
                get {
                    try {
                        return ((decimal)(this[this.tableComputers.Wholesale_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Wholesale price\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.Wholesale_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Incoming_price {
                get {
                    try {
                        return ((decimal)(this[this.tableComputers.Incoming_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Incoming price\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.Incoming_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Сontractor {
                get {
                    try {
                        return ((string)(this[this.tableComputers.СontractorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Сontractor\' in table \'Computers\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableComputers.СontractorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Is_S_NNull() {
                return this.IsNull(this.tableComputers._S_NColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Set_S_NNull() {
                this[this.tableComputers._S_NColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsConfigNull() {
                return this.IsNull(this.tableComputers.ConfigColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetConfigNull() {
                this[this.tableComputers.ConfigColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStokNull() {
                return this.IsNull(this.tableComputers.StokColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStokNull() {
                this[this.tableComputers.StokColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRetail_priceNull() {
                return this.IsNull(this.tableComputers.Retail_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRetail_priceNull() {
                this[this.tableComputers.Retail_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWholesale_priceNull() {
                return this.IsNull(this.tableComputers.Wholesale_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWholesale_priceNull() {
                this[this.tableComputers.Wholesale_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsIncoming_priceNull() {
                return this.IsNull(this.tableComputers.Incoming_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetIncoming_priceNull() {
                this[this.tableComputers.Incoming_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsСontractorNull() {
                return this.IsNull(this.tableComputers.СontractorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetСontractorNull() {
                this[this.tableComputers.СontractorColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class HRRow : global::System.Data.DataRow {
            
            private HRDataTable tableHR;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal HRRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableHR = ((HRDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    try {
                        return ((int)(this[this.tableHR.IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ID\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name1 {
                get {
                    try {
                        return ((string)(this[this.tableHR.Name1Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Name1\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.Name1Column] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name2 {
                get {
                    try {
                        return ((string)(this[this.tableHR.Name2Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Name2\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.Name2Column] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name3 {
                get {
                    try {
                        return ((string)(this[this.tableHR.Name3Column]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Name3\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.Name3Column] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Age {
                get {
                    try {
                        return ((int)(this[this.tableHR.AgeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Age\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.AgeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Position {
                get {
                    try {
                        return ((string)(this[this.tableHR.PositionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Position\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.PositionColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Telephone {
                get {
                    try {
                        return ((string)(this[this.tableHR.TelephoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Telephone\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.TelephoneColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Access {
                get {
                    try {
                        return ((string)(this[this.tableHR.AccessColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Access\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.AccessColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Login {
                get {
                    return ((string)(this[this.tableHR.LoginColumn]));
                }
                set {
                    this[this.tableHR.LoginColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Password {
                get {
                    try {
                        return ((string)(this[this.tableHR.PasswordColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Password\' in table \'HR\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHR.PasswordColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsIDNull() {
                return this.IsNull(this.tableHR.IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetIDNull() {
                this[this.tableHR.IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsName1Null() {
                return this.IsNull(this.tableHR.Name1Column);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetName1Null() {
                this[this.tableHR.Name1Column] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsName2Null() {
                return this.IsNull(this.tableHR.Name2Column);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetName2Null() {
                this[this.tableHR.Name2Column] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsName3Null() {
                return this.IsNull(this.tableHR.Name3Column);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetName3Null() {
                this[this.tableHR.Name3Column] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAgeNull() {
                return this.IsNull(this.tableHR.AgeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAgeNull() {
                this[this.tableHR.AgeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPositionNull() {
                return this.IsNull(this.tableHR.PositionColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPositionNull() {
                this[this.tableHR.PositionColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTelephoneNull() {
                return this.IsNull(this.tableHR.TelephoneColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTelephoneNull() {
                this[this.tableHR.TelephoneColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAccessNull() {
                return this.IsNull(this.tableHR.AccessColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAccessNull() {
                this[this.tableHR.AccessColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsPasswordNull() {
                return this.IsNull(this.tableHR.PasswordColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetPasswordNull() {
                this[this.tableHR.PasswordColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PartsRow : global::System.Data.DataRow {
            
            private PartsDataTable tableParts;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PartsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableParts = ((PartsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Article {
                get {
                    return ((int)(this[this.tableParts.ArticleColumn]));
                }
                set {
                    this[this.tableParts.ArticleColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Type {
                get {
                    try {
                        return ((string)(this[this.tableParts.TypeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Type\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.TypeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Model {
                get {
                    try {
                        return ((string)(this[this.tableParts.ModelColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Model\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.ModelColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Stock {
                get {
                    try {
                        return ((int)(this[this.tableParts.StockColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Stock\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.StockColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Retail_price {
                get {
                    try {
                        return ((decimal)(this[this.tableParts.Retail_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Retail price\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.Retail_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Wholesale_price {
                get {
                    try {
                        return ((decimal)(this[this.tableParts.Wholesale_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Wholesale price\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.Wholesale_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Incoming_price {
                get {
                    try {
                        return ((decimal)(this[this.tableParts.Incoming_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Incoming price\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.Incoming_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Contractor {
                get {
                    try {
                        return ((string)(this[this.tableParts.ContractorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Contractor\' in table \'Parts\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableParts.ContractorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTypeNull() {
                return this.IsNull(this.tableParts.TypeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTypeNull() {
                this[this.tableParts.TypeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModelNull() {
                return this.IsNull(this.tableParts.ModelColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModelNull() {
                this[this.tableParts.ModelColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStockNull() {
                return this.IsNull(this.tableParts.StockColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStockNull() {
                this[this.tableParts.StockColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRetail_priceNull() {
                return this.IsNull(this.tableParts.Retail_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRetail_priceNull() {
                this[this.tableParts.Retail_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWholesale_priceNull() {
                return this.IsNull(this.tableParts.Wholesale_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWholesale_priceNull() {
                this[this.tableParts.Wholesale_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsIncoming_priceNull() {
                return this.IsNull(this.tableParts.Incoming_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetIncoming_priceNull() {
                this[this.tableParts.Incoming_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsContractorNull() {
                return this.IsNull(this.tableParts.ContractorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetContractorNull() {
                this[this.tableParts.ContractorColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PeripheryRow : global::System.Data.DataRow {
            
            private PeripheryDataTable tablePeriphery;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PeripheryRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablePeriphery = ((PeripheryDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Article {
                get {
                    return ((int)(this[this.tablePeriphery.ArticleColumn]));
                }
                set {
                    this[this.tablePeriphery.ArticleColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Type {
                get {
                    try {
                        return ((string)(this[this.tablePeriphery.TypeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Type\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.TypeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Model {
                get {
                    try {
                        return ((string)(this[this.tablePeriphery.ModelColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Model\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.ModelColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Stock {
                get {
                    try {
                        return ((int)(this[this.tablePeriphery.StockColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Stock\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.StockColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Retail_price {
                get {
                    try {
                        return ((decimal)(this[this.tablePeriphery.Retail_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Retail price\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.Retail_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Wholesale_price {
                get {
                    try {
                        return ((decimal)(this[this.tablePeriphery.Wholesale_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Wholesale price\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.Wholesale_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Incoming_price {
                get {
                    try {
                        return ((decimal)(this[this.tablePeriphery.Incoming_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Incoming price\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.Incoming_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Contractor {
                get {
                    try {
                        return ((string)(this[this.tablePeriphery.ContractorColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Contractor\' in table \'Periphery\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePeriphery.ContractorColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTypeNull() {
                return this.IsNull(this.tablePeriphery.TypeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTypeNull() {
                this[this.tablePeriphery.TypeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsModelNull() {
                return this.IsNull(this.tablePeriphery.ModelColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetModelNull() {
                this[this.tablePeriphery.ModelColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsStockNull() {
                return this.IsNull(this.tablePeriphery.StockColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStockNull() {
                this[this.tablePeriphery.StockColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRetail_priceNull() {
                return this.IsNull(this.tablePeriphery.Retail_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRetail_priceNull() {
                this[this.tablePeriphery.Retail_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsWholesale_priceNull() {
                return this.IsNull(this.tablePeriphery.Wholesale_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetWholesale_priceNull() {
                this[this.tablePeriphery.Wholesale_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsIncoming_priceNull() {
                return this.IsNull(this.tablePeriphery.Incoming_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetIncoming_priceNull() {
                this[this.tablePeriphery.Incoming_priceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsContractorNull() {
                return this.IsNull(this.tablePeriphery.ContractorColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetContractorNull() {
                this[this.tablePeriphery.ContractorColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class ComputersRowChangeEvent : global::System.EventArgs {
            
            private ComputersRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRowChangeEvent(ComputersRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ComputersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class HRRowChangeEvent : global::System.EventArgs {
            
            private HRRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRowChangeEvent(HRRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public HRRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class PartsRowChangeEvent : global::System.EventArgs {
            
            private PartsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRowChangeEvent(PartsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PartsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class PeripheryRowChangeEvent : global::System.EventArgs {
            
            private PeripheryRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRowChangeEvent(PeripheryRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PeripheryRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace PC_shop.KR_PIDataSetTableAdapters {
    
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ComputersTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ComputersTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Computers";
            tableMapping.ColumnMappings.Add("S/N", "S/N");
            tableMapping.ColumnMappings.Add("Model", "Model");
            tableMapping.ColumnMappings.Add("Config", "Config");
            tableMapping.ColumnMappings.Add("Stok", "Stok");
            tableMapping.ColumnMappings.Add("Retail price", "Retail price");
            tableMapping.ColumnMappings.Add("Wholesale price", "Wholesale price");
            tableMapping.ColumnMappings.Add("Incoming price", "Incoming price");
            tableMapping.ColumnMappings.Add("Сontractor", "Сontractor");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Computers` WHERE (((? = 1 AND `S/N` IS NULL) OR (`S/N` = ?)) AND (`Model` = ?) AND ((? = 1 AND `Config` IS NULL) OR (`Config` = ?)) AND ((? = 1 AND `Stok` IS NULL) OR (`Stok` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Сontractor` IS NULL) OR (`Сontractor` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_S/N", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_S/N", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Config", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Config", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сontractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сontractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Computers` (`S/N`, `Model`, `Config`, `Stok`, `Retail price`, `Whole" +
                "sale price`, `Incoming price`, `Сontractor`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("S/N", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Config", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сontractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Computers` SET `S/N` = ?, `Model` = ?, `Config` = ?, `Stok` = ?, `Retail price` = ?, `Wholesale price` = ?, `Incoming price` = ?, `Сontractor` = ? WHERE (((? = 1 AND `S/N` IS NULL) OR (`S/N` = ?)) AND (`Model` = ?) AND ((? = 1 AND `Config` IS NULL) OR (`Config` = ?)) AND ((? = 1 AND `Stok` IS NULL) OR (`Stok` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Сontractor` IS NULL) OR (`Сontractor` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("S/N", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Config", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сontractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_S/N", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_S/N", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S/N", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Config", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Config", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Config", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stok", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stok", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сontractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сontractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сontractor", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::PC_shop.Properties.Settings.Default.KR_PIConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [S/N], Model, Config, Stok, [Retail price], [Wholesale price], [Incoming p" +
                "rice], Сontractor FROM Computers";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(KR_PIDataSet.ComputersDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual KR_PIDataSet.ComputersDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            KR_PIDataSet.ComputersDataTable dataTable = new KR_PIDataSet.ComputersDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet.ComputersDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet dataSet) {
            return this.Adapter.Update(dataSet, "Computers");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string _Original_S_N, string Original_Model, string Original_Config, global::System.Nullable<int> Original_Stok, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Сontractor) {
            if ((_Original_S_N == null)) {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(_Original_S_N));
            }
            if ((Original_Model == null)) {
                throw new global::System.ArgumentNullException("Original_Model");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Model));
            }
            if ((Original_Config == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Config));
            }
            if ((Original_Stok.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((int)(Original_Stok.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_Сontractor == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_Сontractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string _S_N, string Model, string Config, global::System.Nullable<int> Stok, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Сontractor) {
            if ((_S_N == null)) {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(_S_N));
            }
            if ((Model == null)) {
                throw new global::System.ArgumentNullException("Model");
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Model));
            }
            if ((Config == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Config));
            }
            if ((Stok.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Stok.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Сontractor == null)) {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(Сontractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string _S_N, 
                    string Model, 
                    string Config, 
                    global::System.Nullable<int> Stok, 
                    global::System.Nullable<decimal> Retail_price, 
                    global::System.Nullable<decimal> Wholesale_price, 
                    global::System.Nullable<decimal> Incoming_price, 
                    string Сontractor, 
                    string _Original_S_N, 
                    string Original_Model, 
                    string Original_Config, 
                    global::System.Nullable<int> Original_Stok, 
                    global::System.Nullable<decimal> Original_Retail_price, 
                    global::System.Nullable<decimal> Original_Wholesale_price, 
                    global::System.Nullable<decimal> Original_Incoming_price, 
                    string Original_Сontractor) {
            if ((_S_N == null)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(_S_N));
            }
            if ((Model == null)) {
                throw new global::System.ArgumentNullException("Model");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Model));
            }
            if ((Config == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Config));
            }
            if ((Stok.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Stok.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Сontractor == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Сontractor));
            }
            if ((_Original_S_N == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(_Original_S_N));
            }
            if ((Original_Model == null)) {
                throw new global::System.ArgumentNullException("Original_Model");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_Model));
            }
            if ((Original_Config == null)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_Config));
            }
            if ((Original_Stok.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((int)(Original_Stok.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_Сontractor == null)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((string)(Original_Сontractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string _S_N, string Config, global::System.Nullable<int> Stok, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Сontractor, string _Original_S_N, string Original_Model, string Original_Config, global::System.Nullable<int> Original_Stok, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Сontractor) {
            return this.Update(_S_N, Original_Model, Config, Stok, Retail_price, Wholesale_price, Incoming_price, Сontractor, _Original_S_N, Original_Model, Original_Config, Original_Stok, Original_Retail_price, Original_Wholesale_price, Original_Incoming_price, Original_Сontractor);
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class HRTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public HRTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "HR";
            tableMapping.ColumnMappings.Add("ID", "ID");
            tableMapping.ColumnMappings.Add("Name1", "Name1");
            tableMapping.ColumnMappings.Add("Name2", "Name2");
            tableMapping.ColumnMappings.Add("Name3", "Name3");
            tableMapping.ColumnMappings.Add("Age", "Age");
            tableMapping.ColumnMappings.Add("Position", "Position");
            tableMapping.ColumnMappings.Add("Telephone", "Telephone");
            tableMapping.ColumnMappings.Add("Access", "Access");
            tableMapping.ColumnMappings.Add("Login", "Login");
            tableMapping.ColumnMappings.Add("Password", "Password");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `HR` WHERE (((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `Name1` IS NULL) OR (`Name1` = ?)) AND ((? = 1 AND `Name2` IS NULL) OR (`Name2` = ?)) AND ((? = 1 AND `Name3` IS NULL) OR (`Name3` = ?)) AND ((? = 1 AND `Age` IS NULL) OR (`Age` = ?)) AND ((? = 1 AND `Position` IS NULL) OR (`Position` = ?)) AND ((? = 1 AND `Telephone` IS NULL) OR (`Telephone` = ?)) AND ((? = 1 AND `Access` IS NULL) OR (`Access` = ?)) AND (`Login` = ?) AND ((? = 1 AND `Password` IS NULL) OR (`Password` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name1", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name2", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name3", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name3", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Position", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Position", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Telephone", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Telephone", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Access", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Access", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Login", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Login", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Password", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Password", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `HR` (`ID`, `Name1`, `Name2`, `Name3`, `Age`, `Position`, `Telephone`" +
                ", `Access`, `Login`, `Password`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name1", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name2", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name3", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Position", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Telephone", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Access", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Login", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Login", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Password", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `HR` SET `ID` = ?, `Name1` = ?, `Name2` = ?, `Name3` = ?, `Age` = ?, `Position` = ?, `Telephone` = ?, `Access` = ?, `Login` = ?, `Password` = ? WHERE (((? = 1 AND `ID` IS NULL) OR (`ID` = ?)) AND ((? = 1 AND `Name1` IS NULL) OR (`Name1` = ?)) AND ((? = 1 AND `Name2` IS NULL) OR (`Name2` = ?)) AND ((? = 1 AND `Name3` IS NULL) OR (`Name3` = ?)) AND ((? = 1 AND `Age` IS NULL) OR (`Age` = ?)) AND ((? = 1 AND `Position` IS NULL) OR (`Position` = ?)) AND ((? = 1 AND `Telephone` IS NULL) OR (`Telephone` = ?)) AND ((? = 1 AND `Access` IS NULL) OR (`Access` = ?)) AND (`Login` = ?) AND ((? = 1 AND `Password` IS NULL) OR (`Password` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name1", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name2", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Name3", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Position", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Telephone", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Access", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Login", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Login", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Password", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name1", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name1", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name1", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name2", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name2", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name2", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Name3", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Name3", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name3", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Age", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Age", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Position", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Position", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Position", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Telephone", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Telephone", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telephone", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Access", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Access", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Access", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Login", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Login", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Password", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Password", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Password", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::PC_shop.Properties.Settings.Default.KR_PIConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT ID, Name1, Name2, Name3, Age, [Position], Telephone, Access, Login, [Passw" +
                "ord] FROM HR";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(KR_PIDataSet.HRDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual KR_PIDataSet.HRDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            KR_PIDataSet.HRDataTable dataTable = new KR_PIDataSet.HRDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet.HRDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet dataSet) {
            return this.Adapter.Update(dataSet, "HR");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(global::System.Nullable<int> Original_ID, string Original_Name1, string Original_Name2, string Original_Name3, global::System.Nullable<int> Original_Age, string Original_Position, string Original_Telephone, string Original_Access, string Original_Login, string Original_Password) {
            if ((Original_ID.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_ID.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Original_Name1 == null)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_Name1));
            }
            if ((Original_Name2 == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Name2));
            }
            if ((Original_Name3 == null)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((string)(Original_Name3));
            }
            if ((Original_Age.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[9].Value = ((int)(Original_Age.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Original_Position == null)) {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[11].Value = ((string)(Original_Position));
            }
            if ((Original_Telephone == null)) {
                this.Adapter.DeleteCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[13].Value = ((string)(Original_Telephone));
            }
            if ((Original_Access == null)) {
                this.Adapter.DeleteCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[15].Value = ((string)(Original_Access));
            }
            if ((Original_Login == null)) {
                throw new global::System.ArgumentNullException("Original_Login");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[16].Value = ((string)(Original_Login));
            }
            if ((Original_Password == null)) {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[18].Value = ((string)(Original_Password));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(global::System.Nullable<int> ID, string Name1, string Name2, string Name3, global::System.Nullable<int> Age, string Position, string Telephone, string Access, string Login, string Password) {
            if ((ID.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(ID.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Name1 == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Name1));
            }
            if ((Name2 == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Name2));
            }
            if ((Name3 == null)) {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(Name3));
            }
            if ((Age.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(Age.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Position == null)) {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Position));
            }
            if ((Telephone == null)) {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(Telephone));
            }
            if ((Access == null)) {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(Access));
            }
            if ((Login == null)) {
                throw new global::System.ArgumentNullException("Login");
            }
            else {
                this.Adapter.InsertCommand.Parameters[8].Value = ((string)(Login));
            }
            if ((Password == null)) {
                this.Adapter.InsertCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[9].Value = ((string)(Password));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> ID, 
                    string Name1, 
                    string Name2, 
                    string Name3, 
                    global::System.Nullable<int> Age, 
                    string Position, 
                    string Telephone, 
                    string Access, 
                    string Login, 
                    string Password, 
                    global::System.Nullable<int> Original_ID, 
                    string Original_Name1, 
                    string Original_Name2, 
                    string Original_Name3, 
                    global::System.Nullable<int> Original_Age, 
                    string Original_Position, 
                    string Original_Telephone, 
                    string Original_Access, 
                    string Original_Login, 
                    string Original_Password) {
            if ((ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Name1 == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Name1));
            }
            if ((Name2 == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Name2));
            }
            if ((Name3 == null)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(Name3));
            }
            if ((Age.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Age.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Position == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Position));
            }
            if ((Telephone == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Telephone));
            }
            if ((Access == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Access));
            }
            if ((Login == null)) {
                throw new global::System.ArgumentNullException("Login");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((string)(Login));
            }
            if ((Password == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Password));
            }
            if ((Original_ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((int)(Original_ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Original_Name1 == null)) {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((string)(Original_Name1));
            }
            if ((Original_Name2 == null)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((string)(Original_Name2));
            }
            if ((Original_Name3 == null)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((string)(Original_Name3));
            }
            if ((Original_Age.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((int)(Original_Age.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            if ((Original_Position == null)) {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((string)(Original_Position));
            }
            if ((Original_Telephone == null)) {
                this.Adapter.UpdateCommand.Parameters[22].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[23].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[22].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[23].Value = ((string)(Original_Telephone));
            }
            if ((Original_Access == null)) {
                this.Adapter.UpdateCommand.Parameters[24].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[25].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[24].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[25].Value = ((string)(Original_Access));
            }
            if ((Original_Login == null)) {
                throw new global::System.ArgumentNullException("Original_Login");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[26].Value = ((string)(Original_Login));
            }
            if ((Original_Password == null)) {
                this.Adapter.UpdateCommand.Parameters[27].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[28].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[27].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[28].Value = ((string)(Original_Password));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> ID, 
                    string Name1, 
                    string Name2, 
                    string Name3, 
                    global::System.Nullable<int> Age, 
                    string Position, 
                    string Telephone, 
                    string Access, 
                    string Password, 
                    global::System.Nullable<int> Original_ID, 
                    string Original_Name1, 
                    string Original_Name2, 
                    string Original_Name3, 
                    global::System.Nullable<int> Original_Age, 
                    string Original_Position, 
                    string Original_Telephone, 
                    string Original_Access, 
                    string Original_Login, 
                    string Original_Password) {
            return this.Update(ID, Name1, Name2, Name3, Age, Position, Telephone, Access, Original_Login, Password, Original_ID, Original_Name1, Original_Name2, Original_Name3, Original_Age, Original_Position, Original_Telephone, Original_Access, Original_Login, Original_Password);
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class PartsTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public PartsTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Parts";
            tableMapping.ColumnMappings.Add("Article", "Article");
            tableMapping.ColumnMappings.Add("Type", "Type");
            tableMapping.ColumnMappings.Add("Model", "Model");
            tableMapping.ColumnMappings.Add("Stock", "Stock");
            tableMapping.ColumnMappings.Add("Retail price", "Retail price");
            tableMapping.ColumnMappings.Add("Wholesale price", "Wholesale price");
            tableMapping.ColumnMappings.Add("Incoming price", "Incoming price");
            tableMapping.ColumnMappings.Add("Contractor", "Contractor");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Parts` WHERE ((`Article` = ?) AND ((? = 1 AND `Type` IS NULL) OR (`Type` = ?)) AND ((? = 1 AND `Model` IS NULL) OR (`Model` = ?)) AND ((? = 1 AND `Stock` IS NULL) OR (`Stock` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Contractor` IS NULL) OR (`Contractor` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Type", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Model", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Contractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Parts` (`Article`, `Type`, `Model`, `Stock`, `Retail price`, `Wholes" +
                "ale price`, `Incoming price`, `Contractor`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Parts` SET `Article` = ?, `Type` = ?, `Model` = ?, `Stock` = ?, `Retail price` = ?, `Wholesale price` = ?, `Incoming price` = ?, `Contractor` = ? WHERE ((`Article` = ?) AND ((? = 1 AND `Type` IS NULL) OR (`Type` = ?)) AND ((? = 1 AND `Model` IS NULL) OR (`Model` = ?)) AND ((? = 1 AND `Stock` IS NULL) OR (`Stock` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Contractor` IS NULL) OR (`Contractor` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Type", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Model", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Contractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::PC_shop.Properties.Settings.Default.KR_PIConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Article, Type, Model, Stock, [Retail price], [Wholesale price], [Incoming " +
                "price], Contractor FROM Parts";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(KR_PIDataSet.PartsDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual KR_PIDataSet.PartsDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            KR_PIDataSet.PartsDataTable dataTable = new KR_PIDataSet.PartsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet.PartsDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet dataSet) {
            return this.Adapter.Update(dataSet, "Parts");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Article, string Original_Type, string Original_Model, global::System.Nullable<int> Original_Stock, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Contractor) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Article));
            if ((Original_Type == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Type));
            }
            if ((Original_Model == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Model));
            }
            if ((Original_Stock.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((int)(Original_Stock.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_Contractor == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int Article, string Type, string Model, global::System.Nullable<int> Stock, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Contractor) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(Article));
            if ((Type == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Type));
            }
            if ((Model == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Model));
            }
            if ((Stock.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Stock.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Contractor == null)) {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    int Article, 
                    string Type, 
                    string Model, 
                    global::System.Nullable<int> Stock, 
                    global::System.Nullable<decimal> Retail_price, 
                    global::System.Nullable<decimal> Wholesale_price, 
                    global::System.Nullable<decimal> Incoming_price, 
                    string Contractor, 
                    int Original_Article, 
                    string Original_Type, 
                    string Original_Model, 
                    global::System.Nullable<int> Original_Stock, 
                    global::System.Nullable<decimal> Original_Retail_price, 
                    global::System.Nullable<decimal> Original_Wholesale_price, 
                    global::System.Nullable<decimal> Original_Incoming_price, 
                    string Original_Contractor) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(Article));
            if ((Type == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Type));
            }
            if ((Model == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Model));
            }
            if ((Stock.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Stock.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Contractor == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Contractor));
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_Article));
            if ((Original_Type == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_Type));
            }
            if ((Original_Model == null)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_Model));
            }
            if ((Original_Stock.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((int)(Original_Stock.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_Contractor == null)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((string)(Original_Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Type, string Model, global::System.Nullable<int> Stock, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Contractor, int Original_Article, string Original_Type, string Original_Model, global::System.Nullable<int> Original_Stock, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Contractor) {
            return this.Update(Original_Article, Type, Model, Stock, Retail_price, Wholesale_price, Incoming_price, Contractor, Original_Article, Original_Type, Original_Model, Original_Stock, Original_Retail_price, Original_Wholesale_price, Original_Incoming_price, Original_Contractor);
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class PeripheryTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public PeripheryTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Periphery";
            tableMapping.ColumnMappings.Add("Article", "Article");
            tableMapping.ColumnMappings.Add("Type", "Type");
            tableMapping.ColumnMappings.Add("Model", "Model");
            tableMapping.ColumnMappings.Add("Stock", "Stock");
            tableMapping.ColumnMappings.Add("Retail price", "Retail price");
            tableMapping.ColumnMappings.Add("Wholesale price", "Wholesale price");
            tableMapping.ColumnMappings.Add("Incoming price", "Incoming price");
            tableMapping.ColumnMappings.Add("Contractor", "Contractor");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Periphery` WHERE ((`Article` = ?) AND ((? = 1 AND `Type` IS NULL) OR (`Type` = ?)) AND ((? = 1 AND `Model` IS NULL) OR (`Model` = ?)) AND ((? = 1 AND `Stock` IS NULL) OR (`Stock` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Contractor` IS NULL) OR (`Contractor` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Type", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Model", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Contractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Periphery` (`Article`, `Type`, `Model`, `Stock`, `Retail price`, `Wh" +
                "olesale price`, `Incoming price`, `Contractor`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Periphery` SET `Article` = ?, `Type` = ?, `Model` = ?, `Stock` = ?, `Retail price` = ?, `Wholesale price` = ?, `Incoming price` = ?, `Contractor` = ? WHERE ((`Article` = ?) AND ((? = 1 AND `Type` IS NULL) OR (`Type` = ?)) AND ((? = 1 AND `Model` IS NULL) OR (`Model` = ?)) AND ((? = 1 AND `Stock` IS NULL) OR (`Stock` = ?)) AND ((? = 1 AND `Retail price` IS NULL) OR (`Retail price` = ?)) AND ((? = 1 AND `Wholesale price` IS NULL) OR (`Wholesale price` = ?)) AND ((? = 1 AND `Incoming price` IS NULL) OR (`Incoming price` = ?)) AND ((? = 1 AND `Contractor` IS NULL) OR (`Contractor` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Article", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Article", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Type", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Type", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Model", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Model", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Model", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Stock", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Stock", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Retail_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Retail_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Retail price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Wholesale_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Wholesale_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Wholesale price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Incoming_price", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Incoming_price", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Incoming price", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Contractor", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Contractor", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contractor", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::PC_shop.Properties.Settings.Default.KR_PIConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Article, Type, Model, Stock, [Retail price], [Wholesale price], [Incoming " +
                "price], Contractor FROM Periphery";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(KR_PIDataSet.PeripheryDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual KR_PIDataSet.PeripheryDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            KR_PIDataSet.PeripheryDataTable dataTable = new KR_PIDataSet.PeripheryDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet.PeripheryDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(KR_PIDataSet dataSet) {
            return this.Adapter.Update(dataSet, "Periphery");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Article, string Original_Type, string Original_Model, global::System.Nullable<int> Original_Stock, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Contractor) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Article));
            if ((Original_Type == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Type));
            }
            if ((Original_Model == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Model));
            }
            if ((Original_Stock.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((int)(Original_Stock.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_Contractor == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int Article, string Type, string Model, global::System.Nullable<int> Stock, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Contractor) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(Article));
            if ((Type == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Type));
            }
            if ((Model == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Model));
            }
            if ((Stock.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Stock.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Contractor == null)) {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    int Article, 
                    string Type, 
                    string Model, 
                    global::System.Nullable<int> Stock, 
                    global::System.Nullable<decimal> Retail_price, 
                    global::System.Nullable<decimal> Wholesale_price, 
                    global::System.Nullable<decimal> Incoming_price, 
                    string Contractor, 
                    int Original_Article, 
                    string Original_Type, 
                    string Original_Model, 
                    global::System.Nullable<int> Original_Stock, 
                    global::System.Nullable<decimal> Original_Retail_price, 
                    global::System.Nullable<decimal> Original_Wholesale_price, 
                    global::System.Nullable<decimal> Original_Incoming_price, 
                    string Original_Contractor) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(Article));
            if ((Type == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Type));
            }
            if ((Model == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Model));
            }
            if ((Stock.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Stock.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((decimal)(Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Contractor == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Contractor));
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_Article));
            if ((Original_Type == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_Type));
            }
            if ((Original_Model == null)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_Model));
            }
            if ((Original_Stock.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((int)(Original_Stock.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_Retail_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((decimal)(Original_Retail_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_Wholesale_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((decimal)(Original_Wholesale_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_Incoming_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((decimal)(Original_Incoming_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_Contractor == null)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((string)(Original_Contractor));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Type, string Model, global::System.Nullable<int> Stock, global::System.Nullable<decimal> Retail_price, global::System.Nullable<decimal> Wholesale_price, global::System.Nullable<decimal> Incoming_price, string Contractor, int Original_Article, string Original_Type, string Original_Model, global::System.Nullable<int> Original_Stock, global::System.Nullable<decimal> Original_Retail_price, global::System.Nullable<decimal> Original_Wholesale_price, global::System.Nullable<decimal> Original_Incoming_price, string Original_Contractor) {
            return this.Update(Original_Article, Type, Model, Stock, Retail_price, Wholesale_price, Incoming_price, Contractor, Original_Article, Original_Type, Original_Model, Original_Stock, Original_Retail_price, Original_Wholesale_price, Original_Incoming_price, Original_Contractor);
        }
    }
    
    /// <summary>
    ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component {
        
        private UpdateOrderOption _updateOrder;
        
        private ComputersTableAdapter _computersTableAdapter;
        
        private HRTableAdapter _hRTableAdapter;
        
        private PartsTableAdapter _partsTableAdapter;
        
        private PeripheryTableAdapter _peripheryTableAdapter;
        
        private bool _backupDataSetBeforeUpdate;
        
        private global::System.Data.IDbConnection _connection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public ComputersTableAdapter ComputersTableAdapter {
            get {
                return this._computersTableAdapter;
            }
            set {
                this._computersTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public HRTableAdapter HRTableAdapter {
            get {
                return this._hRTableAdapter;
            }
            set {
                this._hRTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public PartsTableAdapter PartsTableAdapter {
            get {
                return this._partsTableAdapter;
            }
            set {
                this._partsTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public PeripheryTableAdapter PeripheryTableAdapter {
            get {
                return this._peripheryTableAdapter;
            }
            set {
                this._peripheryTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._computersTableAdapter != null) 
                            && (this._computersTableAdapter.Connection != null))) {
                    return this._computersTableAdapter.Connection;
                }
                if (((this._hRTableAdapter != null) 
                            && (this._hRTableAdapter.Connection != null))) {
                    return this._hRTableAdapter.Connection;
                }
                if (((this._partsTableAdapter != null) 
                            && (this._partsTableAdapter.Connection != null))) {
                    return this._partsTableAdapter.Connection;
                }
                if (((this._peripheryTableAdapter != null) 
                            && (this._peripheryTableAdapter.Connection != null))) {
                    return this._peripheryTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._computersTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._hRTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._partsTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._peripheryTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }
        
        /// <summary>
        ///Update rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateUpdatedRows(KR_PIDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._computersTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Computers.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._computersTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._hRTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.HR.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._hRTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._partsTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Parts.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._partsTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._peripheryTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Periphery.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._peripheryTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Insert rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateInsertedRows(KR_PIDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._computersTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Computers.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._computersTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._hRTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.HR.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._hRTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._partsTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Parts.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._partsTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._peripheryTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Periphery.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._peripheryTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Delete rows in bottom-up order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(KR_PIDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._peripheryTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Periphery.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._peripheryTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._partsTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Parts.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._partsTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._hRTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.HR.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._hRTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._computersTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Computers.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._computersTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }
        
        /// <summary>
        ///Update all changes to the dataset.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(KR_PIDataSet dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._computersTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._computersTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._hRTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._hRTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._partsTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._partsTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._peripheryTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._peripheryTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
                // ---- Prepare for update -----------
                //
                if ((this._computersTableAdapter != null)) {
                    revertConnections.Add(this._computersTableAdapter, this._computersTableAdapter.Connection);
                    this._computersTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._computersTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._computersTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._computersTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._computersTableAdapter.Adapter);
                    }
                }
                if ((this._hRTableAdapter != null)) {
                    revertConnections.Add(this._hRTableAdapter, this._hRTableAdapter.Connection);
                    this._hRTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._hRTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._hRTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._hRTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._hRTableAdapter.Adapter);
                    }
                }
                if ((this._partsTableAdapter != null)) {
                    revertConnections.Add(this._partsTableAdapter, this._partsTableAdapter.Connection);
                    this._partsTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._partsTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._partsTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._partsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._partsTableAdapter.Adapter);
                    }
                }
                if ((this._peripheryTableAdapter != null)) {
                    revertConnections.Add(this._peripheryTableAdapter, this._peripheryTableAdapter.Connection);
                    this._peripheryTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._peripheryTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._peripheryTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._peripheryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._peripheryTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._computersTableAdapter != null)) {
                    this._computersTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._computersTableAdapter]));
                    this._computersTableAdapter.Transaction = null;
                }
                if ((this._hRTableAdapter != null)) {
                    this._hRTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._hRTableAdapter]));
                    this._hRTableAdapter.Transaction = null;
                }
                if ((this._partsTableAdapter != null)) {
                    this._partsTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._partsTableAdapter]));
                    this._partsTableAdapter.Transaction = null;
                }
                if ((this._peripheryTableAdapter != null)) {
                    this._peripheryTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._peripheryTableAdapter]));
                    this._peripheryTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///Update Order Option
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption {
            
            InsertUpdateDelete = 0,
            
            UpdateInsertDelete = 1,
        }
        
        /// <summary>
        ///Used to sort self-referenced table's rows
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {
            
            private global::System.Data.DataRelation _relation;
            
            private int _childFirst;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591