using System;
using System.Collections.Generic;
using System.Text;

namespace Session2_3.Resources
{

    public class Endpoints
    {
        //Base URL
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetPetByID(long id) => $"{baseURL}/pet/{id}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeletePetByID(long id) => $"{baseURL}/pet/{id}";
    }
}