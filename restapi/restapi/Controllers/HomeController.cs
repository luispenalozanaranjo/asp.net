using restapi.Models;
using Rotativa;
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
using Rotativa.MVC;

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
                //Definir el formato de solicitud de datos
                user.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Enviando solicitud para encontrar el recurso de servicio REST de la API web al traer todos los Usuarios de la URL, utilizando HttpClient
                HttpResponseMessage Res = await user.GetAsync("HaibuSolutions/prueba-tecnica-sf/user");
                if (Res.IsSuccessStatusCode)
                {
                    //Almacenando la respuesta recibida de la api web 
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializando la respuesta recibida de la API web y almacenándola en la lista de Usuario
                    UserInfo = JsonConvert.DeserializeObject<List<Usuario>>(UserResponse);

                }
                return View(UserInfo);
            }
           
        }

        public ActionResult PrintViewToPdf()
        {
            //Convirtiendo lo que esta en la tabla a PDF
            var report = new ActionAsPdf("Index");
            return report;
        }
    }
}
