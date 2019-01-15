using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string imie { get; set; }

        public string nazwisko { get; set; }

        public string e_mail { get; set; }

        public string login { get; set; }

        public string haslo { get; set; }

        public Guid Id { get; set; }
        
    }
}