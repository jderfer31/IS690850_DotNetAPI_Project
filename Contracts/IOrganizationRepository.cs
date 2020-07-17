using Entities.Models;
using System;

namespace Contracts
{
    public interface IOrganizationRepository
    {
        void CreateUser(User organizationEntity);
        object GetUser(Guid id, bool trackChanges);
    }
}