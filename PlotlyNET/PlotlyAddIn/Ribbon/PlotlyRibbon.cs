using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using PlotlyAddIn.Services;
using PlotlyAddIn.Ribbon.DataTypes;
using ExcelAddIn1.Forms;
// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new PlotlyRibbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace PlotlyAddIn.Ribbon
{
    [ComVisible(true)]
    public class PlotlyRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public PlotlyRibbon()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("PlotlyAddIn.Ribbon.PlotlyRibbon.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion

        #region Upload Data Methods
        public void OnUploadPlotDataButton(Office.IRibbonControl control)
        {
            try
            {
                //WriteToCell((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
                SendBasicPlot dialog = new SendBasicPlot((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
            }
        }
        private void WriteToCell(Excel.Worksheet ws)
        {
            Excel.Worksheet activeWorksheet = ws;

            var servicePath = "http://plot.ly/clientresp";
            var username = "NiranPatel";
            var apiKey = "4n5n0qb2hi";
            ClientResponsePOSTRequest reqArgs = new ClientResponsePOSTRequest()
            {
                un = activeWorksheet.get_Range("L1").Value2,
                key = activeWorksheet.get_Range("L2").Value2,
                origin = activeWorksheet.get_Range("L3").Value2,
                platform = activeWorksheet.get_Range("L4").Value2,
                kwargs = new Kwargs()
                {
                    filename = activeWorksheet.get_Range("L5").Value2,
                    fileopt = activeWorksheet.get_Range("L6").Value2
                },
                args = "[[0, 1, 2], [3, 4, 5], [1, 2, 3], [6, 6, 5]]"

            };
            string result = new PlotlyService().Application_GetServiceResponse(activeWorksheet.get_Range("K1").Value2, reqArgs);
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.Value2 = result;

        }
        #endregion
    }
}
