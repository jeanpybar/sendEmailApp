using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace angularapp.ViewModels
{
    public class EmailFormViewModel
    {
            public string ToEmail { get; set; }

            public string Subject { get; set; }

            public string Message { get; set; }
    }
}
