using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyWebsiteFramwork.Models
{
    public class App
    {
        [Key]
        public int OppId { get; set; }
        public string Name { get; set; }
        public  int CreatedbyUserId { get; set; }
    }
}