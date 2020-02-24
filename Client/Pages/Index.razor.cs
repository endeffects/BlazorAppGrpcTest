using BlazorApp1.Shared;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.AspNetCore.Components;
using ProtoBuf.Grpc.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Pages
{
    public partial class Index
    {
        protected MultiplyResult _result;

        protected async Task TestGrpc()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            using (var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions { HttpClient = httpClient }))
            {
                var client = channel.CreateGrpcService<ICalculatorService>();
                _result = await client.MultiplyAsync(new MultiplyRequest { X = 12, Y = 4 });
                Console.WriteLine(_result);
            }
        }
    }
}
