﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Starter
    {
        public void Run()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int action = random.Next(1, 4);

                switch (action)
                {
                    case 1:
                        Actions.InfoMethod();
                        break;
                    case 2:
                        Actions.WarningMethod();
                        break;
                    case 3:
                        Actions.ErrorMethod();
                        break;
                }
            }

            File.WriteAllLines("log.txt", Logger.GetLogList());
        }
    }
}
