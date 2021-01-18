using MaakJeNietDrug;
using MaakJeNietDrug.Controllers;
using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
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
    public class IntakeMomentTest
    {
        /*
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public IntakeMomentTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task ReturnIntakeMomentFromMed()
        {
            //Arrange
            using var context = new DataBaseContext();
            int id = 1;
            int count = context.IntakeMoments
                .Where(o => o.MedicineId == id)
                .ToList().Count;
            // Act
            var response = await _client.GetAsync("/IntakeMoment/GetAllByMedicineId/" + id.ToString());
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<IntakeMoment>>(responseString);
            // Assert
            Assert.Equal(count, result.Count);
        }

        [Fact]
        public async Task AddIntakeMomentToMed()
        {
            //Arrange
            int medId = 1;
            IntakeMomentModel intake = new IntakeMomentModel(medId, "1 md", 1, "31-Dec-1998", "23:37:50");
            using var context = new DataBaseContext();
            int count = context.IntakeMoments
                .Where(o => o.MedicineId == medId)
                .ToList().Count;
            //Act
            var stringContent = new StringContent(JsonConvert.SerializeObject(intake), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/IntakeMoment/", stringContent);
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(count + 1, context.IntakeMoments
                .Where(o => o.MedicineId == medId)
                .ToList().Count);
        }

        [Fact]
        public async Task ReturnIntakeMomentFromUser()
        {
            int userId = 1;
            using var context = new DataBaseContext();
            //yet to be written
            //var text = context.IntakeMoments.Join(context.Medicines, i => i.MedicineId, m => m.Id, (i, m) => new { medicinename = m.Name }).Take(1);
            var intakes = from Medicine in context.Medicines
                          join IntakeMoments in context.IntakeMoments on Medicine.Id equals IntakeMoments.MedicineId
                          where Medicine.UID == userId.ToString()
                          select IntakeMoments;
            var response = await _client.GetAsync("/IntakeMoment/GetAllByAccountId/" + userId.ToString());
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<IntakeMoment>>(responseString);
            Assert.Equal(intakes.Count(), result.Count());
        }

        [Fact]
        public async Task UpdateIntakeMoment()
        {
            //Arrange
            using var context = new DataBaseContext();
            int medId = 2;
            string newDate = "20/01/1994";
            string newTime = "20:22:14";
            string dosage = "3 md";
            int id = 3;
            IntakeMomentModel intake = new IntakeMomentModel(medId, dosage, 1, newDate, newTime, id);
            //Act
            var stringContent = new StringContent(JsonConvert.SerializeObject(intake), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/IntakeMoment/", stringContent);
            response.EnsureSuccessStatusCode();
            List<IntakeMoment> moment = context.IntakeMoments
                .Where(o => o.MedicineId == medId)
                .ToList();
            Assert.Equal(newDate + " " + newTime, moment[0].startDate.ToString());
            Assert.Equal(dosage, moment[0].Dosage);
        }

        [Fact]
        public async Task DeleteIntakeMoment()
        {
            //Arrange
            using var context = new DataBaseContext();
            
            int count = context.IntakeMoments.ToList().Count();
            //Act
            var response = await _client.DeleteAsync("/IntakeMoment/2");

            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(count - 1, context.IntakeMoments.ToList().Count());
        }
        */
    }
}
