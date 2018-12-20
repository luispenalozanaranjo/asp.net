using restapi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;


namespace restapi.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "https://my-json-server.typicode.com/";
        public async Task<ActionResult> Index()
        {
            List<Usuario> UserInfo = new List<Usuario>();
            using (var user = new HttpClient())
            {
                user.BaseAddress = new Uri(Baseurl);
                user.DefaultRequestHeaders.Clear();
                //Define request data format  
                user.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await user.GetAsync("HaibuSolutions/prueba-tecnica-sf/user");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    UserInfo = JsonConvert.DeserializeObject<List<Usuario>>(UserResponse);

                }
                return View(UserInfo);
            }
           
        }

        public ActionResult PrintViewToPdf()
        {
            var report = new ActionAsPdf("Index");
            return report;
        }
    }
}
