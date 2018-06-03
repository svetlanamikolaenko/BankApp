using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankApp.Models;

namespace BankApp.View_models
{
    public class NewManagerViewModel: Base
    {
        public IEnumerable<Role> Role { get; set; }
        public Manager Manager { get; set; }
    }
}