namespace Courses._20483.Services
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}