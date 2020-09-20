using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class BookingEmployeeController : Controller
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
    }
}
