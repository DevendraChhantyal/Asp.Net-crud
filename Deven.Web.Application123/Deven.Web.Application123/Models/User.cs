﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}