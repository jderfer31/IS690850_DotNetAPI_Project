using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SectionEnrollmentManagementRepository : RepositoryBase<SectionEnrollmentManagementRepository>, ISectionEnrollmentManagementRepository
    {
        public SectionEnrollmentManagementRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}