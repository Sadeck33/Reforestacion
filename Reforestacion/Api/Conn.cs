using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Reforestacion.Api
{
    public class Conn
    {
        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);

            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(Datos);
            return data;
        }

        public dynamic Post(string url, string json, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if(autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }
                IRestResponse response = client.Execute(request);
                dynamic datos = JsonConvert.DeserializeObject(response.Content);
                return datos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public dynamic Put(string url, string id,string json)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.PUT);
            request.AddParameter("id", id);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);
            dynamic datos = JsonConvert.DeserializeObject(response.Content);
            return datos;
        }

        public dynamic Delete(string url, string id)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);
            var response = client.Execute(request);
            dynamic datos = JsonConvert.DeserializeObject(response.Content);
            return datos;
        }
    }
}
