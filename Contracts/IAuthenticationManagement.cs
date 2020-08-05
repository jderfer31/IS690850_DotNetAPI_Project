using System;
using System.Collections.Generic;
using System.Text;
using Entities.DataTransferObjects;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthenticationManagement
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
