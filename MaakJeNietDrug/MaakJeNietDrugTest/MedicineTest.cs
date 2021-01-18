using MaakJeNietDrug;
using MaakJeNietDrug.Controllers;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MaakJeNietDrugTest
{
    public class MedicineTest
    {
        /*
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
        public async Task ReturnMedicine()
        {
            //Arrange
            using var context = new DataBaseContext();
            int count = context.Medicines.ToList().Count();
            // Act
            var response = await _client.GetAsync("/medicine/");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Medicine>>(responseString);
            // Assert
            Assert.Equal(count, result.Count);
        }

        [Fact]
        public async Task AddMedicine()
        {
            //Arrange
            Medicine medi = new Medicine { Name = "test5", UID = "re124sa", Description = "Description of test5" };
            using var context = new DataBaseContext();
            int count = context.Medicines.ToList().Count();
            //Act
            var stringContent = new StringContent(JsonConvert.SerializeObject(medi), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/medicine/", stringContent);
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(count + 1, context.Medicines.ToList().Count());
        }

        [Fact]
        public async Task UpdateMedicine()
        {
            //Arrange
            using var context = new DataBaseContext();
            int medId = 2;
            Medicine medi = new Medicine { Id = medId, Name = "test6", UID = "re124sa23", Description = "Description of test6" };
            //Act
            var stringContent = new StringContent(JsonConvert.SerializeObject(medi), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/medicine/", stringContent);
            response.EnsureSuccessStatusCode();
            Medicine medi2 = context.Medicines.Find(medId);
            //Assert
            Assert.Equal(medi.Name, medi2.Name);
            Assert.Equal(medi.UID, medi2.UID);
            Assert.Equal(medi.Description, medi2.Description);
        }

        [Fact]
        public async Task DeleteMedicine()
        {
            //Arrange
            using var context = new DataBaseContext();
            int count = context.Medicines.ToList().Count();
            //Act
            var response = await _client.DeleteAsync("/medicine/4");
            
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(count - 1, context.Medicines.ToList().Count());
        }
        */
    }
}
