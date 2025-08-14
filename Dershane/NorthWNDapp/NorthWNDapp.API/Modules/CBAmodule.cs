using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;

namespace NorthWNDapp.API.Modules
{
    public class CBAmodule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.AuthorizeRequest += Context_AuthorizeRequest;
            context.EndRequest += Context_EndRequest;
        }

        private void Context_EndRequest(object sender, EventArgs e)
        {
            var response = HttpContext.Current.Response;
            
            if (response.StatusCode == 401)
            {
                response.Headers.Add("WWW-Authenticate", "Basic realm=\"insert for realm\"");
            }
        }

        private void Context_AuthorizeRequest(object sender, EventArgs e)
        {
            var request = HttpContext.Current.Request;
            var header = request.Headers["Authorization"];

            if (header != null)
            {
                var parsedValue = AuthenticationHeaderValue.Parse(header);

                if (parsedValue.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) && parsedValue.Parameter != null)
                {
                    Authenticate(parsedValue.Parameter);
                }
            }
        }

        private bool Authenticate(string credentialValues)
        {
            bool isValid = false;

            try
            {
                var credentials = Encoding.GetEncoding("iso-8859-1").GetString(Convert.FromBase64String(credentialValues));
                var values = credentials.Split(':');

                isValid = CheckUser(userName: values[0], password: values[1]);

                if (isValid)
                {
                    SetPrincipal(new GenericPrincipal(new GenericIdentity(values[0]), null));
                }
            }
            catch
            {
                isValid = false;
            }

            return isValid;
        }

        private bool CheckUser(string userName, string password)
        {
            return (userName == "armagan" && password == "1234!");
        }

        private static void SetPrincipal(IPrincipal Principal)
        {
            Thread.CurrentPrincipal = Principal;

            if (HttpContext.Current != null)
            {
                HttpContext.Current.User = Principal;
            }
        }

        public void Dispose()
        {
            
        }
    }
}