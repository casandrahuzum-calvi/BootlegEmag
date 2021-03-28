﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootlegEmagService.Models
{
    public class User
    {
        public string name { get; set; }

        public string password { get; set; }

        public string role { get; set; }

        public int counter { get; set; }



        public User(string username, string pass , string rol , int count)
        {
            name = username;
            password = pass;
            role = rol;
            counter = count;
        }

    }
    
}