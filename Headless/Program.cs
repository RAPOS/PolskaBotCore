﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Headless
{
    class Program
    {
        static void Main(string[] args)
        {
            API api = new API();
            api.Login("178.132.244.66", "");
        }
    }
}