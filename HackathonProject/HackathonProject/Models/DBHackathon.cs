using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HackathonProject.Models
{
    public class DBHackathon :DbContext
    {
        public DBHackathon() : base("DBHackathon")
        {
            
        }
    }
}