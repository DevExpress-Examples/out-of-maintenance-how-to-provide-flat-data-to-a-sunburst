Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeMap
Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace SunburstFlatDataAdapterSample
    Partial Public Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim dataAdapter As New SunburstFlatDataAdapter()
            dataAdapter.ValueDataMember = "Annual"
            dataAdapter.LabelDataMember = "Product"
            dataAdapter.GroupDataMembers.AddRange(New String() { "Category", "Country" })
            dataAdapter.DataSource = CreateProductInfos()
            sunburstControl.DataAdapter = dataAdapter

            sunburstControl.Colorizer = New SunburstGradientColorizer With { _
                .Min = 0.4, _
                .Max = 0.9, _
                .Palette = Palette.Office2019Palette, _
                .GradientColor = Color.White _
            }
        End Sub
        Private Function CreateProductInfos() As List(Of ProductInfo)
            Return New List(Of ProductInfo) From { _
                New ProductInfo With { _
                    .Product = "Wheat", _
                    .Country = "China", _
                    .Annual = 129770, _
                    .Category = "Cereals" _
                }, _
                New ProductInfo With { _
                    .Product = "Maize", _
                    .Country = "USA", _
                    .Annual = 370971, _
                    .Category = "Cereals" _
                }, _
                New ProductInfo With { _
                    .Product = "Rice", _
                    .Country = "China", _
                    .Annual = 142864, _
                    .Category = "Cereals" _
                }, _
                New ProductInfo With { _
                    .Product = "Soybean", _
                    .Country = "USA", _
                    .Annual = 119533, _
                    .Category = "Oilseeds" _
                }, _
                New ProductInfo With { _
                    .Product = "Protein meals", _
                    .Country = "China", _
                    .Annual = 93306, _
                    .Category = "Oilseeds" _
                }, _
                New ProductInfo With { _
                    .Product = "Sugar (tq)", _
                    .Country = "India", _
                    .Annual = 26000, _
                    .Category = "Sugar" _
                }, _
                New ProductInfo With { _
                    .Product = "Sugar beet", _
                    .Country = "Russia", _
                    .Annual = 49473, _
                    .Category = "Sugar" _
                }, _
                New ProductInfo With { _
                    .Product = "Sugar cane", _
                    .Country = "India", _
                    .Annual = 384795, _
                    .Category = "Sugar" _
                }, _
                New ProductInfo With { _
                    .Product = "Milk", _
                    .Country= "India", _
                    .Annual = 169320, _
                    .Category = "Dairy" _
                } _
            }
        End Function
    End Class
End Namespace
