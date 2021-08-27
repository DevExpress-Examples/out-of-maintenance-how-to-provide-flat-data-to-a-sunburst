<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/153758356/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830505)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## How to: provide flat data to Sunburst

This example demonstrates how to visualize flat data using the SunburstControl.

![](Images/flat-data-sample.png)

### Description
Create a **SunburstFlatDataAdapter** object and assign it to the **SunburstControl.DataAdapter** property to provide flat data to the Sunburst. Then, specify the adapter's **DataSource**, **LabelDataMember** and **ValueDataMember** to define data source members that should be used to generate sunburst items. Add data members to the **GroupDataMembers** collection to specify how to group the sunburst's items.
Use the **SunburstGradientColorizer** class to color each sunburst group using similar colors. The **Palette** property specifies colors assigned to groups. The **Max** and **Min** properties configure the maximum and minimum portions of palette colors in colors assigned to items. The **GradientColor** property sets the color that is mixed with an item's color. 
