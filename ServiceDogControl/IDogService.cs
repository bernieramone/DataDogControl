using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceDogControl
{
    [ServiceContract]
    public interface IDogService
    {
        [OperationContract]
        List<Dog> GetAllDogs();

        [OperationContract]
        Dog GetDog(int id);

        [OperationContract]
        bool DeleteDog(Dog dog);

        [OperationContract]
        bool UpdateDog(Dog dog);

        [OperationContract]
        bool CreateDog(Dog dog);


        
    }
}
