using System;
using RestSharp;
using Session2_3.DataModels;

namespace Session2_3.Tests
{
    public class ApiBaseTest
    {
        public RestClient RestClient { get; set; }

        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

    }
}