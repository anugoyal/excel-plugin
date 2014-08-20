using PlotlyAddIn.Ribbon.DataTypes;
using PlotlyAddIn.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.Forms
{
    public partial class SendBasicPlot : Form
    {
        Excel.Worksheet ws;

        public SendBasicPlot(Excel.Worksheet sheet)
        {
            var servicePath = "http://plot.ly/clientresp";
            var username = "NiranPatel";
            var apiKey = "4n5n0qb2hi";
            InitializeComponent();
            textBoxServiceURL.Text = servicePath;
            textBoxUsername.Text = username;
            textBoxAPIKey.Text = apiKey;
            textBoxOrigin.Text = "plot";
            textBoxPlatform.Text = "lisp";
            textBoxFilename.Text = "aaa";
            textBoxFileOption.Text = "overwrite";
            ws = sheet;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ClientResponsePOSTRequest reqArgs = new ClientResponsePOSTRequest()
            {
                un = textBoxUsername.Text,
                key = textBoxAPIKey.Text,
                origin = textBoxOrigin.Text,
                platform = textBoxPlatform.Text,
                kwargs = new Kwargs()
                {
                    filename = textBoxFilename.Text,
                    fileopt = textBoxFileOption.Text
                },
                args = "[[0, 1, 2], [3, 4, 5], [1, 2, 3], [6, 6, 5]]"
            };

            string x = textBoxXColumn.Text;
            string y = textBoxYColumn.Text;

            Excel.Range xCols = ws.get_Range(x + "1").EntireColumn;
            Excel.Range yCols = ws.get_Range(y + "1").EntireColumn;
            List<string> xList = new List<string>();
            List<string> yList = new List<string>();

            if (xCols != null && yCols != null && xCols.Count > 0 && yCols.Count > 0)
            {
                foreach (Excel.Range c in xCols.Cells)
                {
                    if (c.Value2 == null || string.IsNullOrEmpty(c.Value2.ToString()))
                        break;
                    xList.Add(c.Value2.ToString());
                }
                foreach (Excel.Range c in yCols.Cells)
                {
                    if (c.Value2 == null || string.IsNullOrEmpty(c.Value2.ToString()))
                        break;
                    yList.Add(c.Value2.ToString());
                }

                List<string> coords = new List<string>();
                for (int i = 0; i < (xList.Count > yList.Count ? yList.Count : xList.Count); i++)
                {
                    coords.Add(string.Format("[{0},{1}]", xList[i], yList[i]));
                }
                reqArgs.args = string.Format("[{0}]", string.Join(",", coords));
                string result = new PlotlyService().Application_GetServiceResponse(textBoxServiceURL.Text, reqArgs);
                textBox10.Text = result;
            }
        }

    }
}
