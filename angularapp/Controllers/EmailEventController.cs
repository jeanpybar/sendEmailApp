using angularapp.misc;
using angularapp.Repositories;
using angularapp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace angularapp.Controllers
    {
    public class EmailEventController : Controller
        {

        
        public void GetEventInformation([FromBody] SendGridSentEvent[] eventList)
            {

            EmailRepository emrepo = new EmailRepository();
            foreach (var eventItem in eventList)
                {
                emrepo.ChangeEmailStatus(eventItem.@event, eventItem.identifier);
                }
            }
        }
    }
