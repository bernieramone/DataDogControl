using BusinessDogControl;
using System;
using System.Collections.Generic;

namespace ServiceDogControl
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DogService : IDogService
    {
        BusinessDog businessDog;

        public DogService()
        {
            businessDog = new BusinessDog();
        }

        public bool CreateDog(Dog dog)
        {
            DogBuz dogBuz = new DogBuz
            {
                breed = dog.breed,
                Id = dog.Id,
                name = dog.name,
                owner = dog.owner,
                size = dog.size
            };

            try
            {
                bool response = businessDog.CreateDog(dogBuz);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteDog(Dog dog)
        {
            DogBuz dogBuz = new DogBuz
            {
                Id = dog.Id,
            };

            try
            {
                bool response = businessDog.DeleteDog(dogBuz);

                return response;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Dog> GetAllDogs()
        {
            try
            {
                var lstBuz = businessDog.GetAllDogs();

                List<Dog> lstDogs = new List<Dog>();

                foreach (var item in lstBuz)
                {
                    lstDogs.Add(new Dog
                    {
                        breed = item.breed,
                        Id = item.Id,
                        name = item.name,
                        owner = item.owner,
                        size = item.size
                    });
                }

                return lstDogs;



            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Dog GetDog(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateDog(Dog dog)
        {
            throw new System.NotImplementedException();
        }
    }
}
