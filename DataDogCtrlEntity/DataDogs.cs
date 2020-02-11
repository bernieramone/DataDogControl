using System;
using System.Collections.Generic;
using System.Linq;

namespace DataDogCtrlEntity
{
    public class DataDogs
    {
        DogsControlDBEntities context;

        public DataDogs()
        {
            context = new DogsControlDBEntities();
        }


        public List<Dog> GetAllDogs()
        {
            try
            {
                var lstCtx = context.GetAllDogs().ToList();
                if (lstCtx == null || !lstCtx.Any())
                {
                    throw new Exception("Data: Lista vacia");
                }

                List<Dog> lstDogs = new List<Dog>();

                foreach (var item in lstCtx)
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
            catch (Exception)
            {

                throw;
            }
        }

        public Dog GetDog(int id)
        {
            try
            {
                var dogCtx = context.GetDogId(id);

                if (dogCtx == null)
                {
                    throw new Exception("Data: No se encotro el perro");

                };

                Dog dog = new Dog();

                foreach (var item in dogCtx)
                {
                    dog.size = item.size;
                    dog.breed = item.breed;
                    dog.Id = item.Id;
                    dog.name = item.name;
                    dog.owner = item.owner;
                };

                return dog;

            }

            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteDog(int id)
        {
            bool deleteSucces = false;

            try
            {
                var result = context.DeleteDog(id);

                if (result == 0)
                {
                    throw new Exception("Datos: Error al borrar El perro");
                }

                deleteSucces = true;

                return deleteSucces;


            } 
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateDog(Dog dog)
        {
            bool updateSuccess = false;

            try
            {
                var result = context.UpdateDog(dog.Id, dog.name, dog.owner, dog.breed, dog.size);

                if (result == 0)
                {
                    throw new Exception("Datos: Error al actualizar Perro");

                }

                updateSuccess = true;

                return updateSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CreateDog(Dog dog)
        {
            bool createSucces = false;

            try
            {
                var result = context.CreateDog(dog.name, dog.owner, dog.breed, dog.size);

                if (result == 0)
                {
                    throw new Exception("Datos: Error al crear el perro");
                }

                createSucces = true;

                return createSucces;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
