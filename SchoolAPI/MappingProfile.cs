using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI.Controllers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UsersDTO>()
                    .ForMember(c => c.FullAddress,
                        opt => opt.MapFrom(x => string.Join(' ', x.UserName, x.Password, x.Email, x.Status, x.SystemRoleID, x.CreatedDate, x.UpdatedDate)));

            CreateMap<UserForCreationDTO, User>();
            CreateMap<UserForUpdateDTO, User>();
        }
    }
}
