using MaakJeNietDrug;
using MaakJeNietDrugLogic.ClassesLogic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MaakJeNietDrugTest
{
    public class MedicineTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public MedicineTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
        [Fact]
        public async Task ReturnUsers()
        {
            // Act
            var response = await _client.GetAsync("/medicine/");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            List<Medicine> medi = new List<Medicine>();
            var result = JsonConvert.DeserializeObject<List<Medicine>>(responseString);
            // Assert
            Assert.Equal(4, result.Count);
        }
    }
}
