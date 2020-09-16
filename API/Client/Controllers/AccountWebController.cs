using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class AccountWebController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44305/api/")
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("verify")]
        public IActionResult Verify()
        {
            return View();
        }

        [Route("profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [Route("verif")]
        [HttpPost]
        public IActionResult Verify(User model)
        {
            if (model.SecurityStamp != null)
            {
                var jsonUserVM = JsonConvert.SerializeObject(model);
                var buffer = System.Text.Encoding.UTF8.GetBytes(jsonUserVM);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var resTask = client.PostAsync("accounts/verify/", byteContent);
                resTask.Wait();
                var result = resTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsStringAsync().Result;
                    if (data != "")
                    {
                        var json = JsonConvert.DeserializeObject(data).ToString();
                        var account = JsonConvert.DeserializeObject<VerifyViewModel>(json);
                        if (account.RoleName == "Admin" || account.RoleName == "Sales" || account.RoleName == "HR")
                        {
                            HttpContext.Session.SetString("id", account.Id);
                            HttpContext.Session.SetString("phone", account.Phone);
                            HttpContext.Session.SetString("address", account.Adddress);
                            HttpContext.Session.SetString("gender", account.Gender);
                            HttpContext.Session.SetString("uname", account.Username);
                            HttpContext.Session.SetString("email", account.Email);
                            HttpContext.Session.SetString("lvl", account.RoleName);
                            HttpContext.Session.SetString("fullName", account.FullName);
                            if (account.RoleName == "Admin")
                            {
                                return Json(new { status = true, msg = "Well done. Your account has been verified"});
                            }
                            else if (account.RoleName == "Sales")
                            {
                                return Json(new { status = true, msg = "Well done. Your account has been verified"});
                            }
                            else
                            {
                                return Json(new { status = true, msg = "Well done. Your account has been verified"});
                            }
                        }
                        else
                        {
                            return Json(new { status = false, msg = "Please registration first." });
                        }
                    }
                    else
                    {
                        return Json(new { status = false, msg = "The data must be filled" });
                    }
                }
                else
                {
                    return Json(new { status = false, msg = "Something went wrong" });
                }
            }
            return Redirect("/verify");
        }

        [Route("regisvalidate")]
        public IActionResult Validate(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Username != null)
            {
                var json = JsonConvert.SerializeObject(registerViewModel);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client.PostAsync("Accounts/register/", byteContent).Result;
                if (result.IsSuccessStatusCode)
                {
                    return Json(new { status = true, code = result, msg = "Registration success" });
                }
                else
                {
                    return Json(new { status = false, msg = "Something went wrong. Please try again" });
                }
            }
            return Redirect("/register");
        }
        [Route("validate")]
        public IActionResult Validate(VerifyViewModel userVM)
        {
            if (userVM.Username == null)
            {
                var jsonUserVM = JsonConvert.SerializeObject(userVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(jsonUserVM);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var resTask = client.PostAsync("Accounts/login/", byteContent);
                resTask.Wait();
                var result = resTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsStringAsync().Result;
                    if (data != "")
                    {
                        var handler = new JwtSecurityTokenHandler().ReadJwtToken(data);
                        var account = new VerifyViewModel
                        {
                            Id = handler.Claims.Where(p => p.Type == "id").Select(s => s.Value).FirstOrDefault(),
                            Username = handler.Claims.Where(p => p.Type == "username").Select(s => s.Value).FirstOrDefault(),
                            Email = handler.Claims.Where(p => p.Type == "email").Select(s => s.Value).FirstOrDefault(),
                            Phone = handler.Claims.Where(p => p.Type == "Phone").Select(s => s.Value).FirstOrDefault(),
                            RoleName = handler.Claims.Where(p => p.Type == "RoleName").Select(s => s.Value).FirstOrDefault(),
                            Adddress = handler.Claims.Where(p => p.Type == "address").Select(s => s.Value).FirstOrDefault(),
                            Gender = handler.Claims.Where(p=>p.Type == "gender").Select(s=>s.Value).FirstOrDefault(),
                            FullName = handler.Claims.Where(p=>p.Type == "fullName").Select(s=>s.Value).FirstOrDefault()

                        };

                        if (account.RoleName == "Admin" || account.RoleName == "Sales" || account.RoleName == "HR")
                        {
                            HttpContext.Session.SetString("id", account.Id);
                            HttpContext.Session.SetString("Phone", account.Phone);
                            HttpContext.Session.SetString("address", account.Adddress);
                            HttpContext.Session.SetString("gender", account.Gender);
                            HttpContext.Session.SetString("username", account.Username);
                            HttpContext.Session.SetString("email", account.Email);
                            HttpContext.Session.SetString("lvl", account.RoleName);
                            HttpContext.Session.SetString("fullName", account.FullName);
                            HttpContext.Session.SetString("JWToken", "Bearer " + data);
                            if (account.RoleName == "Admin")
                            {
                                return Json(new { status = true, msg = "Login Successfully !"});
                            }
                            else if (account.RoleName == "Sales")
                            {
                                return Json(new { status = true, msg = "Login Successfully !"});
                            }
                            else
                            {
                                return Json(new { status = true, msg = "Login Successfully !"});
                            }
                        }
                        else
                        {
                            return Json(new { status = false, msg = "Please registration first." });
                        }
                    }
                    else
                    {
                        return Json(new { status = false, msg = "The data must be filled" });
                    }
                }
                else
                {
                    return Json(new { status = false, msg = "Something went wrong" });
                }
            }
            return Redirect("/login");

        }
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }

    }
}
