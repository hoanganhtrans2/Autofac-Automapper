using AutoMapper;
using DeviceDbDTO;
using EF6CodeFirstDemo;


namespace TransferObject
{
    class MappingContainer: Profile
    {
        public MappingContainer()
        {
            CreateMap<Grade, GradeDTO>().ReverseMap();
        }
    }
}
