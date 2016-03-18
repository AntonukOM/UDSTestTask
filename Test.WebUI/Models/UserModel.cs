using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Test.WebUI.Models
{
    public class UserModel
    {
        public string Guid { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public DateTime Registered { get; set; }
        public List<string> Tags { get; set; }
    }
}