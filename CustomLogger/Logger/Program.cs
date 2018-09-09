﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("123");
            Logger.Log.Error("Error");
            Console.ReadKey();
        }
    }
}
