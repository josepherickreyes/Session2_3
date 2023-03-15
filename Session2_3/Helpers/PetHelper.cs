using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using Session2_3.DataModels;
using Session2_3.Resources;
using Session2_3.Tests.TestData;
using Session2_3.Test;




namespace Session2_3.Helpers
{

    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new user
        /// </summary>
        ///

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = PetGenerate.newPet();
            var postRequest = new RestRequest(Endpoints.PostPet());

            //Send Post Request to add new user
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdUserData = newPetData;
            return createdUserData;
        }
    }
}