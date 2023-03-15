using System;
using Session2_3.DataModels;

namespace Session2_3.Tests.TestData
{

    public class PetGenerate
    {
        public static PetModel newPet()
        {
            return new PetModel
            {
                Id = 99,
                Name = "Mr.Pickles",
                Category = new PetCategory { Name = "Poodle" },
                PhotoUrls = new string[] { "photo " },
                Tags = new PetCategory[] { new PetCategory { Name = "Tags" } },
                Status = "available"
            };
        }
    }
}