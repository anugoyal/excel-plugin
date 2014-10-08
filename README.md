excel-plugin
============

Plotly Excel Add-In

-------------------------
#Installation
1. Copy the latest file from Packages to the test system.  If you are using Windows, download PlotlyPC.xlam.  If you are using OSX, download PlotlyMac.xlam.
2. Double-click the file (or open it in excel)
3. A security prompt will appear with buttons to Enable Macros or Disable Macros.  Select the Enable Macros button.
 

 !["Security prompt"](https://github.com/plotly/excel-plugin/blob/master/images/1_SecurityNotice.png "Security prompt")

 If the security prompt does not allow you to enable macros, then edit your security settings. In Settings go to Security and uncheck the "Warn before opening a file that contains macros" box.

 !["Enable macros in settings"](http://i.imgur.com/MSirAxv.png)

4. Excel will load.

#Using the Add-In
1. The Plotly Ribbon will be displayed after the View Ribbon as shown below


!["Create ribbon"](https://github.com/plotly/excel-plugin/blob/master/images/2_PlotlyRibbon.png "Create ribbon")

2. Open or create a new WorkSheet.
3. Add data in columns that will represent the X and Y data of the Plot.
4. Select the Create Plot button


!["Create Plot form"](https://github.com/plotly/excel-plugin/blob/master/images/3_CreatePlotDialog.png "Create Plot form")

5. Enter username, API Key and file name for the plot.
6. Select one of the available Chart Types from the drop down


!["Select Chart type"](https://github.com/plotly/excel-plugin/blob/master/images/3_CreatePlotDialog_ChartType.png "Select Chart type")


7. Select one of the available columns to represent the X and Y data (Note that for Box Plot and Histogram, only 1 column of data is required)


!["Select data column"](https://github.com/plotly/excel-plugin/blob/master/images/3_CreatePlotDialog_XData.png "Select data column")

8. It is possible to add multiple traces.  Select the Add Trace button to choose more data
 

!["Select Add Trace"](https://github.com/plotly/excel-plugin/blob/master/images/3_CreatePlotDialog_AddTrace.png "Select Add Trace")

