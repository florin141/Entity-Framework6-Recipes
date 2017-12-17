using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ef.Api.Models
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}