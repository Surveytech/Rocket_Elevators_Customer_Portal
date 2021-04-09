using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocket_Elevators_Customer_Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        //public static async task<dynamic> queryasync(string query, object obj)
        //{
        //    var graphqlclient = new graphqlhttpclient("https://graphql-codeboxx.herokuapp.com/graphiql", new newtonsoftjsonserializer());

        //    var getCustomerByEmailRequest = new GraphQL.GraphQLRequest
        //    {
        //        Query = query,
        //        Variables = obj
        //    };
        //    var response = await graphQLClient.SendQueryAsync<dynamic>(getCustomerByEmailRequest);
        //    return response.Data;
        //}
    }
}
