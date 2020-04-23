﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_project
{
    /// <summary>
    /// 프로그램에서 반복적으로 사용되는 기능
    /// </summary>
    static class wblib
    {
        public static int inputnumber(string msg)
        {
            Console.Write(msg + " : ");
            return int.Parse(Console.ReadLine());
        }

        public static string inputstring(string msg)
        {
            Console.Write(msg + " : ");
            return Console.ReadLine();
        }
    }
}
