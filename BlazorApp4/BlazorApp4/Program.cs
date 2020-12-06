using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BlazorApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SDC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var stm = "SELECT @@VERSION";

            using var con = new SqlConnection(cs);
            con.Open();

            using var cmd = new SqlCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine(version);

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
