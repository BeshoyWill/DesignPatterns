﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton
    /// </summary>
    public sealed class TheBell
    {
        private static TheBell bellConnection;
        private static object syncRoot = new object();
        private TheBell()
        {

        }

        /// <summary>
        /// We implement this method to ensure thread safety for our singleton.
        /// </summary>
        public static TheBell Instance
        {
            get
            {
                lock(syncRoot)
                {
                    if (bellConnection == null)
                    {
                        bellConnection = new TheBell();
                    }
                }

                return bellConnection;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order up!");
        }
    
    }

}
