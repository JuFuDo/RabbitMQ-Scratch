﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;

namespace ReceiverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new RabbitMqService().BasicReceiver();
        }
    }
}
