using System.Runtime.Serialization;

namespace ServiceDogControl
{
    [DataContract]
    public class Dog
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]

        public string name { get; set; }

        [DataMember]

        public string owner { get; set; }

        [DataMember]

        public string breed { get; set; }

        [DataMember]

        public string size { get; set; }
    }
}