using angularapp.misc;
using angularapp.Models;
using angularapp.Repositories;
using angularapp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace angularapp.Controllers
    {
    public class EmailController : Controller
        {

        [HttpPost]
        public JsonResult SendMail([FromBody] EmailFormViewModel model)
            {
            if (IsValidEmail(model.ToEmail))
                {
                return Json(EmailSender.SendEmail(model.ToEmail, model.Subject, model.Message));
                }
            else
                {
                throw new HttpRequestException("email format is not correct");
                }
            }  
        [HttpGet]
        public JsonResult EmailSearch(DateTime? StartDate, DateTime? EndDate, string ToEmail, string Subject) {
            EmailRepository emrepo = new EmailRepository();
            if (string.IsNullOrEmpty(ToEmail))
                { ToEmail = string.Empty; }
            if (string.IsNullOrEmpty(Subject))
                { Subject = string.Empty; }
            return Json(emrepo.GetEmails(StartDate,EndDate,Subject,ToEmail));
            }

        private bool IsValidEmail(string email)
            {
           return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            }
        }
    }
