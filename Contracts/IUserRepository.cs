using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository
    {
        
        IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        object GetAllUser(bool trackChanges);
        void CreateUser(User User);
        object GetUser(Guid id, bool trackChanges);
        void DeleteUser(object user);
    }
}