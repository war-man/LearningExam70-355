//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 11/3/2015 6:17:08 AM
namespace SerivcePLC.StockServiceReference1
{
    
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "WebApiServerSample.Models", "SerivcePLC.StockServiceReference1");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("SerivcePLC.StockServiceReference1", global::System.StringComparison.Ordinal))
            {
                return string.Concat("WebApiServerSample.Models.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for StockDeals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<StockDeal> StockDeals
        {
            get
            {
                if ((this._StockDeals == null))
                {
                    this._StockDeals = base.CreateQuery<StockDeal>("StockDeals");
                }
                return this._StockDeals;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<StockDeal> _StockDeals;
        /// <summary>
        /// There are no comments for StockDeals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStockDeals(StockDeal stockDeal)
        {
            base.AddObject("StockDeals", stockDeal);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = @"<edmx:Edmx Version=""1.0"" xmlns:edmx=""http://schemas.microsoft.com/ado/2007/06/edmx""><edmx:DataServices m:DataServiceVersion=""3.0"" m:MaxDataServiceVersion=""3.0"" xmlns:m=""http://schemas.microsoft.com/ado/2007/08/dataservices/metadata""><Schema Namespace=""WebApiServerSample.Models"" xmlns=""http://schemas.microsoft.com/ado/2009/11/edm""><EntityType Name=""StockDeal""><Key><PropertyRef Name=""Symbole"" /><PropertyRef Name=""Date"" /></Key><Property Name=""Amount"" Type=""Edm.Int32"" Nullable=""false"" /><Property Name=""Symbole"" Type=""Edm.String"" Nullable=""false"" /><Property Name=""Value"" Type=""Edm.Double"" Nullable=""false"" /><Property Name=""Date"" Type=""Edm.DateTime"" Nullable=""false"" /><Property Name=""State"" Type=""Edm.String"" /></EntityType></Schema><Schema Namespace=""Default"" xmlns=""http://schemas.microsoft.com/ado/2009/11/edm""><EntityContainer Name=""Container"" m:IsDefaultEntityContainer=""true""><EntitySet Name=""StockDeals"" EntityType=""WebApiServerSample.Models.StockDeal"" /></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for WebApiServerSample.Models.StockDeal in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Symbole
    /// Date
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("StockDeals")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Symbole", "Date")]
    public partial class StockDeal : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new StockDeal object.
        /// </summary>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="symbole">Initial value of Symbole.</param>
        /// <param name="value">Initial value of Value.</param>
        /// <param name="date">Initial value of Date.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static StockDeal CreateStockDeal(int amount, string symbole, double value, global::System.DateTime date)
        {
            StockDeal stockDeal = new StockDeal();
            stockDeal.Amount = amount;
            stockDeal.Symbole = symbole;
            stockDeal.Value = value;
            stockDeal.Date = date;
            return stockDeal;
        }
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Amount;
        partial void OnAmountChanging(int value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property Symbole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Symbole
        {
            get
            {
                return this._Symbole;
            }
            set
            {
                this.OnSymboleChanging(value);
                this._Symbole = value;
                this.OnSymboleChanged();
                this.OnPropertyChanged("Symbole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Symbole;
        partial void OnSymboleChanging(string value);
        partial void OnSymboleChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Value;
        partial void OnValueChanging(double value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}