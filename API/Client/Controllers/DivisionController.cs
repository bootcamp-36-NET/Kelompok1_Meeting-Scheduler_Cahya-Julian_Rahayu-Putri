using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class DivisionController : Controller
    {
        readonly HttpClient http = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44305/api/")
        };

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadDivision()
        {
            IEnumerable<Division> division = null;
                var token = HttpContext.Session.GetString("JWToken");
                http.DefaultRequestHeaders.Add("Authorization", token);
            var restTask = http.GetAsync("division");
            restTask.Wait();

            var result = restTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Division>>();
                readTask.Wait();
                division = readTask.Result;
            }
            return Json(division, new Newtonsoft.Json.JsonSerializerSettings());
        }

        public JsonResult GetById(string id)
        {
            Division division = null;
                var token = HttpContext.Session.GetString("JWToken");
                http.DefaultRequestHeaders.Add("Authorization", token);
            var restTask = http.GetAsync("division/" + id);
            restTask.Wait();

            var result = restTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                division = JsonConvert.DeserializeObject<Division>(readTask);
            }
            return Json(division);
        }

        public JsonResult InsertOrUpdate(Division divisions, string id)
        {
            try
            {
                var json = JsonConvert.SerializeObject(divisions);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var token = HttpContext.Session.GetString("JWToken");
                http.DefaultRequestHeaders.Add("Authorization", token);

                if (divisions.Id == null)
                {
                    var result = http.PostAsync("division", byteContent).Result;
                    return Json(result);
                }
                else if (divisions.Id != null)
                {
                    var result = http.PutAsync("division/" + id, byteContent).Result;
                    return Json(result);
                }

                return Json(404);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult Delete(string id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            http.DefaultRequestHeaders.Add("Authorization", token);
            var result = http.DeleteAsync("division/" + id).Result;
            return Json(result);
        }
    }
}