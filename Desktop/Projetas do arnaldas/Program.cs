using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static Arnaldo.Calculadora;

namespace Arnaldo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool Ocorrendodowload = false;
            Ocorrendodowload = true;
            await Yes(Ocorrendodowload);
            Ocorrendodowload = false;
            if (Ocorrendodowload == false)
            {
                Console.ReadKey();
            }
        }
        static async Task Yes(bool Ocorrendodowload)
        {
            Console.WriteLine("Espere 5 segundos para receber seu dowload");
            await Task.Delay(5000);
            Console.WriteLine("Https//:www.youtube.com//");
        }
    }
}