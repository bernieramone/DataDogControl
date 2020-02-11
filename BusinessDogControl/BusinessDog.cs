using DataDogCtrlEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessDogControl
{
    public class BusinessDog
    {
        DataDogs data;

        public BusinessDog()
        {
            data = new DataDogs();
        }

        public List<DogBuz> GetAllDogs()
        {
            try
            {
                var result = data.GetAllDogs();

                if (result == null || !result.Any())
                {
                    throw new Exception("Business: Lista vacia");
                }

                List<DogBuz> lstDogBuzs = new List<DogBuz>();

                foreach (var item in result)
                {
                    lstDogBuzs.Add(new DogBuz
                    {
                        breed = item.breed,
                        Id = item.Id,
                        name = item.name,
                        owner = item.owner,
                        size = item.size
                    });
                }

                return lstDogBuzs;

            }
            catch (Exception ex)
            {
               

                throw;
            }
        }

        public DogBuz GetDog(int id)
        {
            try
            {
                var result = data.GetDog(id);

                if (result == null)
                {
                    throw new Exception("Business: No se encontro al perro");
                }

                DogBuz dog = new DogBuz { breed = result.breed, Id = result.Id, name = result.name, owner = result.owner, size = result.size };

                return dog;


            }

            catch (Exception ex)
            {
                
                throw;
            }
        }

        public bool DeleteDog(DogBuz dog)
        {
            bool result = false;
            
            try
            {
                result = data.DeleteDog(dog.Id);

                if (!result)
                {
                    throw new Exception("Business: Error al borrar el perro.");
                }

                return result;


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdateDog(DogBuz dog)
        {
            bool updateSuccess = false;
            Dog dogCtx = new Dog();

            dogCtx.breed = dog.breed;
            dogCtx.Id = dog.Id;
            dogCtx.name = dog.name;
            dogCtx.owner = dog.owner;
            dogCtx.size = dog.size;



            try
            {
                updateSuccess = data.UpdateDog(dogCtx);

                if (!updateSuccess)
                {
                    throw new Exception("Business: Error al actualizar el perro");
                }

                return updateSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CreateDog(DogBuz dog)
        {
            bool createSuccess = false;

            Dog dogCtx = new Dog()
            {
                breed = dog.breed,
                Id = dog.Id,
                name = dog.name,
                owner = dog.owner,
                size = dog.size
            };

            try
            {
                 createSuccess = data.CreateDog(dogCtx);

                if (!createSuccess)
                {
                    throw new Exception("Business: Error al crear al Perro");

                }

                return createSuccess;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
