using Owner.API.Model;
using System;
using System.Collections.Generic;

namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<OwnerModel> GelAllOwner()
        {
            return new List<OwnerModel>
            {
                new OwnerModel
                {
                    Id = 1,
                    Name = "Hilal",
                    LastName = "Batibeyi",
                    Date = DateTime.Now,
                    Description = "Software Engineer",
                    Type = "Type1"
                },
                new OwnerModel
                {
                    Id = 2,
                    Name = "Ali",
                    LastName = "Beyaz",
                    Date = DateTime.Now,
                    Description = "CEO",
                    Type = "Type2"
                },
                new OwnerModel
                {
                    Id = 3,
                    Name = "Eren",
                    LastName = "Demir",
                    Date = DateTime.Now,
                    Description = "Human Resources Specialist",
                    Type = "Type3"
                }
            };
        }
    }
}
