using DevExpress.XtraEditors;
using DevExpress.XtraTreeMap;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SunburstFlatDataAdapterSample {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e) {
            SunburstFlatDataAdapter dataAdapter = new SunburstFlatDataAdapter();            
            dataAdapter.ValueDataMember = "Annual";
            dataAdapter.LabelDataMember = "Product";
            dataAdapter.GroupDataMembers.AddRange(new string[] { "Category", "Country" });
            dataAdapter.DataSource = CreateProductInfos();
            sunburstControl.DataAdapter = dataAdapter;

            sunburstControl.Colorizer = new SunburstGradientColorizer {
                Min = 0.4,
                Max = 0.9,
                Palette = Palette.Office2019Palette,
                Mode = GradientColorizerMode.ByGroupLevel,
                GradientColor = Color.White
            };
        }
        List<ProductInfo> CreateProductInfos() {
            return new List<ProductInfo> {
                new ProductInfo {Product = "Wheat",         Country = "China",  Annual = 129770, Category = "Cereals"},
                new ProductInfo {Product = "Maize",         Country = "USA",    Annual = 370971, Category = "Cereals"},
                new ProductInfo {Product = "Rice",          Country = "China",  Annual = 142864, Category = "Cereals"},
                new ProductInfo {Product = "Soybean",       Country = "USA",    Annual = 119533, Category = "Oilseeds"},
                new ProductInfo {Product = "Protein meals", Country = "China",  Annual = 93306,  Category = "Oilseeds"},
                new ProductInfo {Product = "Sugar (tq)",    Country = "India",  Annual = 26000,  Category = "Sugar"},
                new ProductInfo {Product = "Sugar beet",    Country = "Russia", Annual = 49473,  Category = "Sugar"},
                new ProductInfo {Product = "Sugar cane",    Country = "India",  Annual = 384795, Category = "Sugar"},
                new ProductInfo {Product = "Milk",          Country=  "India",  Annual = 169320, Category = "Dairy"}
             };
        }
    }
}
