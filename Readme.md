## How to: provide flat data to Sunburst

This example demonstrates how to visualize flat data using the SunburstControl.

![](Images/flat-data-sample.png)

### Description
Create a **SunburstFlatDataAdapter** object and assign it to the **SunburstControl.DataAdapter** property to provide flat data to the Sunburst. Then, specify the adapter's **DataSource**, **LabelDataMember** and **ValueDataMember** to define data source members that should be used to generate sunburst items. Add data members to the **GroupDataMembers** collection to specify how to group the sunburst's items.
Use the **SunburstGradientColorizer** class to color each sunburst group using similar colors. The **Palette** property specifies colors assigned to groups. The **Max** and **Min** properties configure the maximum and minimum portions of palette colors in colors assigned to items. The **GradientColor** property sets the color with that is mixed with an item's color.
