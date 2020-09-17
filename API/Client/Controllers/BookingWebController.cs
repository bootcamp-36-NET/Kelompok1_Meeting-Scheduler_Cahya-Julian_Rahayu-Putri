using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class BookingWebController : Controller
    {
        HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44305/api/")
        };
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult LoadBook()
        {
            IEnumerable<Booking> bookings = null;
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var restTask = httpClient.GetAsync("Booking");
            restTask.Wait();

            var result = restTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Booking>>();
                readTask.Wait();
                bookings = readTask.Result;

            }
            return Json(bookings, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public JsonResult InsertorupdateBooking(Booking bookings, string id)
        {
            try
            {
                var json = JsonConvert.SerializeObject(bookings);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //var token = HttpContext.Session.GetString("JWToken");
                //httpClient.DefaultRequestHeaders.Add("Authorization", token);

                if (id == null)
                {
                    var result = httpClient.PostAsync("Booking", byteContent).Result;
                    return Json(result);
                }
                else if (id != null)
                {
                    var result = httpClient.PutAsync("Booking/" + id, byteContent).Result;
                    return Json(result);
                }

                return Json(404);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetById(string id)
        {
            Booking bookings = null;
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = httpClient.GetAsync("Booking/" + id);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var getJson = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                bookings = JsonConvert.DeserializeObject<Booking>(getJson);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }

            return Json(bookings, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Delete(string id)
        {
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var result = httpClient.DeleteAsync("Booking/" + id).Result;
            return Json(result);
        }

        public JsonResult LoadEmployee()
        {
            IEnumerable<Employee> employees = null;
            var resTask = httpClient.GetAsync("Employee");  //departments nya ini dari si controller api
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Employee>>();
                readTask.Wait();
                employees = readTask.Result;

            }
            else
            {
                employees = Enumerable.Empty<Employee>();
                ModelState.AddModelError(string.Empty, "Server Error try Again");
            }
            return Json(employees);
        }
    }
}
