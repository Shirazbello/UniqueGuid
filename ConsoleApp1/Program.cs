using System;
using FluentCassandra;
using System.Net;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Based Guid");
            Guid TimeGuid1 = GuidGenerator.GenerateTimeBasedGuid();
            Console.WriteLine(TimeGuid1.ToString());

        }

    }
    

}
