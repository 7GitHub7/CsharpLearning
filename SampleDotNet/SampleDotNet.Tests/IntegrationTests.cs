using Microsoft.AspNetCore.Mvc.Testing;
using SampleDotNetWithAngular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotNet.Tests
{
    class IntegrationTests
    {
        protected readonly HttpClient _httpClient;
        public IntegrationTests()
        {
            var appFactory = new WebApplicationFactory<Startup>();

        }
    }
}
