using System.Runtime.Serialization;

namespace MultiTenancy.RestfulApi.DTOs
{
    [DataContract]
    public class CreateProductRequestDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Rate { get; set; }
    }
}
