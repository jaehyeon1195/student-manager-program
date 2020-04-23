using System;
using System.IO;
using System.Text;

namespace _0924_project
{

    class Program
    {
       
        static void Main(string[] args)
        {
            app ap = app.Instance;
            ap.init();
            ap.run();
            ap.exit();
        }

    }
}
