using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User User)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(object user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllOrganizations(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public User GetOrganization(Guid companyId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public object GetUser(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        object IUserRepository.GetAllUser(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        object IUserRepository.GetUser(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
        
    }
}