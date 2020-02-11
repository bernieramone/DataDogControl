using BusinessDogControl;
using HostDogControl.DogControlServiceReference;
using System;





namespace HostDogControl
{
    class Program
    {
        static void Main(string[] args)
        {


            DogServiceClient dogServiceClient = new DogServiceClient();


            BusinessDog businessDog = new BusinessDog();
            
            DogBuz dogBuzUpdate = new DogBuz { breed = "GermanSheppard", Id = 6, name = "Nanilka_2", owner = "El bernie_2", size = "Big" };
            DogBuz dogBuzCreate = new DogBuz { breed = "pastor aleman", name = "Nanilka", owner = "El bernie", size = "Big" };
            DogBuz dogBuxDelete = new DogBuz { Id = 18 };

            var lstDogs = dogServiceClient.GetAllDogs();
            


            //var resultGetId = businessDog.GetDog(1);
            //var resultGetAll = businessDog.GetAllDogs();
            //var resultInserDog = businessDog.CreateDog(dogBuzCreate);
            //var rsultDeleteDog = businessDog.DeleteDog(dogBuxDelete);
            //var resultUpdateDog = businessDog.UpdateDog(dogBuzUpdate);







            //DataDogs data = new DataDogs();

            //var dog = data.GetDog(1);

            //var lstDogs = data.GetAllDogs();
            ////var deleteDog = data.DeleteDog(14);

            //var updateDog = data.UpdateDog(dogUpdate);




            





            //Console.WriteLine(dog.Id);
            //Console.WriteLine(dog.breed);
            //Console.WriteLine(dog.name);
            //Console.WriteLine(dog.owner);
            //Console.WriteLine(dog.size);

            Console.ReadLine();


        }
    }
}
