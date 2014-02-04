using AutoMapper;
using EFIOCDIAFAMMVC.Model;
using EFIOCDIAFAMMVC.Models;

namespace LawHelpInteractive.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeModel>();
        }
    }
}