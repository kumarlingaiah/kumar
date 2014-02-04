using AutoMapper;
using EFIOCDIAFAMMVC.Model;
using EFIOCDIAFAMMVC.Models;

namespace LawHelpInteractive.Mappings
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeModel, Employee>();
        }
    }
}