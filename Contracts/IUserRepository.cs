using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository
    {
        
        IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        object GetAllUser(bool trackChanges);
        void CreateUsers(User User);
        object GetUsers(Guid id, bool trackChanges);
        void DeleteUser(object user);
    }
}