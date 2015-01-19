NerdcatsToolkit
===============

Controls: 

DroidSlideView
---------------
Still being built
 

HubTile 
-----------------------------------------------------
Ported from Windows Phone Toolkit for Windows Phone 8 

Usage:

1. Include the Project from the sources (Soon will be replaced with nuget package)
2. Include xmlns:nc="using:NerdCatsToolkit.Controls" inside your <Page>
3. Sample HubTile would look like following: 
```xaml 
<nc:HubTile Grid.Row="1" Grid.Column="0" 
                                         Margin="12,12,0,0"
                                         Source="Images/lg-desserts.jpg"
                                         Title="Dessert"
                                         Notification="3 New Recipes"
                                         GroupTag="FoodTag"/>```
