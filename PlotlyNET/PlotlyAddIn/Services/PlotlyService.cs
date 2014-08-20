using PlotlyAddIn.Ribbon.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PlotlyAddIn.Services
{
    public class PlotlyService
    {
        public string Application_GetServiceResponse(string url, ClientResponsePOSTRequest req)
        {
            try
            {
                // Create a request using a URL that can receive a post. 
                WebRequest request = WebRequest.Create(url);
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = req.ToString();
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;
                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.
                WebResponse response = request.GetResponse();
                using (Stream a = response.GetResponseStream())
                {
                    StreamReader b = new StreamReader(a, Encoding.UTF8);
                    string c = b.ReadToEnd();
                    return c;
                }
            }
            catch (Exception ex)
            {
            }
            return "Unable to get response";
        }
    
    }
}
