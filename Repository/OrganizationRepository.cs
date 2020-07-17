using Contracts;
using Entities;
using Entities.Models;
using System;

namespace Repository
{
    public class OrganizationRepository : RepositoryBase<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateUser(User organizationEntity)
        {
            throw new NotImplementedException();
        }

        public object GetUser(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}