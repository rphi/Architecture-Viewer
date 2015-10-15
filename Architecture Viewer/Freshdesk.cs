using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Architecture_Viewer
{
    class Freshdesk
    {
        public IList<int> FindUserByEmail(string email)
        {
            string test = String.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://domain.freshdesk.com/customers.json?query=email is " + HttpUtility.UrlEncode(email));
            request.ContentType = "application/json";
            request.Method = "GET";
            string authInfo = "kIjKVpChLBc58G5E1N9A";
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            request.Headers["Authorization"] = "Basic " + authInfo;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                test = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
        }
    }
}
