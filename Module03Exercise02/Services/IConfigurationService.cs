﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Exercise02.Services
{
    public interface IConfigurationService
    {
        string GetMessage();
    }

    public class MyService : IConfigurationService
    {
        public string GetMessage()
        {
            return "Welcome to the Employee View App!";
        }
    }
}