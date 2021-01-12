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
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MaakJeNietDrugTest
{
    public class UnitTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;
        DateTime EndDate = new DateTime();
        string Date = "24-07-2020";
        string Time = "01:01:01";

        public UnitTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
            
            EndDate = Convert.ToDateTime(Date + " " + Time);

        }

        [Fact]
        public void GetDate()
        {
            //arrange
            IntakeMomentModel intake = new IntakeMomentModel { startDate = "24-07-2020", time = "01:01:01" };
            //act
            DateTime date = intake.GetDateTime(intake.startDate + " " + intake.time, "dd-MM-yyyy HH:mm:ss", null);
            //assert
            Assert.Equal(EndDate, date);
            //arrange
        }

        [Fact]
        public void GetDate2()
        {
            //arrange
            IntakeMomentModel intake = new IntakeMomentModel { startDate = "24/07/2020", time = "01:01:01" };
            //act
            DateTime date = intake.GetDateTime(intake.startDate + " " + intake.time, "dd/MM/yyyy HH:mm:ss" , null);
            //assert
            Assert.Equal(EndDate, date);
        }

        [Fact]
        public void GetDate3()
        {
            //arrange
            IntakeMomentModel intake = new IntakeMomentModel { startDate = "24-07-2020", time = "01:01:01" };
            //act
            DateTime date = intake.GetDateTime(intake.startDate, "dd-MM-yyyy", null);
            //assert
            Assert.Equal(Convert.ToDateTime(Date), date);
        }

        [Fact]
        public void GetDate4()
        {
            //arrange
            IntakeMomentModel intake = new IntakeMomentModel { startDate = "24-07-2020", time = "01:01:01" };
            //act
            DateTime date = intake.GetDateTime(intake.time, "HH:mm:ss", null);
            //assert
            Assert.Equal(Convert.ToDateTime(Time), date);
        }
    }
}
