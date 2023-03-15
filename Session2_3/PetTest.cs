using System;
using RestSharp;
using System.Net;
using Session2_3.DataModels;
using Session2_3.Resources;
using Session2_3.Tests;
using Session2_3.Helpers;


namespace Session2_3.Test
{
    [TestClass]
    public class PetTests : ApiBaseTest
    {
        private static List<PetModel> petCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task DemoGetPet()
        {
            //Arrange
            var petGetRequest = new RestRequest(Endpoints.GetPetByID(PetDetails.Id));
            petCleanUpList.Add(PetDetails);

            //Act
            var petGetResponse = await RestClient.ExecuteGetAsync<PetModel>(petGetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, petGetResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(PetDetails.Name, petGetResponse.Data.Name, "Name did not Match");
            Assert.AreEqual(PetDetails.Category.Name, petGetResponse.Data.Category.Name, "Category did not Match");
            Assert.AreEqual(PetDetails.PhotoUrls[0], petGetResponse.Data.PhotoUrls[0], "PhotoUrls not found");
            Assert.AreEqual(PetDetails.Tags[0].Name, petGetResponse.Data.Tags[0].Name, "tags not found");

        }
        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(Endpoints.GetPetByID(data.Id));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }

    }
}
