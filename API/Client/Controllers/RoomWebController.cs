using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class RoomWebController : Controller
    {
        HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44305/api/")
        };
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult LoadRoom()
        {
            IEnumerable<RoomVM> rooms = null;
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var restTask = httpClient.GetAsync("Room/getRoom");
            restTask.Wait();

            var result = restTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<RoomVM>>();
                readTask.Wait();
                rooms = readTask.Result;

            }
            return Json(rooms, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public JsonResult InsertorupdateRoom(Room rooms, string id)
        {
            try
            {
                var json = JsonConvert.SerializeObject(rooms);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //var token = HttpContext.Session.GetString("JWToken");
                //httpClient.DefaultRequestHeaders.Add("Authorization", token);

                if (id == null)
                {
                    var result = httpClient.PostAsync("Room", byteContent).Result;
                    return Json(result);
                }
                else if (id != null)
                {
                    var result = httpClient.PutAsync("Room/" + id, byteContent).Result;
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
            Room rooms = null;
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = httpClient.GetAsync("Room/" + id);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var getJson = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                rooms = JsonConvert.DeserializeObject<Room>(getJson);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }

            return Json(rooms, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Delete(string id)
        {
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var result = httpClient.DeleteAsync("Room/" + id).Result;
            return Json(result);
        }
        public JsonResult LoadRoomEmp()
        {
            IEnumerable<RoomVM> rooms = null;
            //var token = HttpContext.Session.GetString("JWToken");
            //httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var restTask = httpClient.GetAsync("Room/getRoomEmp");
            restTask.Wait();

            var result = restTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<RoomVM>>();
                readTask.Wait();
                rooms = readTask.Result;

            }
            return Json(rooms, new Newtonsoft.Json.JsonSerializerSettings());

        }
    }
}
