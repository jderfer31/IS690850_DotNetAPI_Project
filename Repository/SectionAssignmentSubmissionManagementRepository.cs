using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SectionAssignmentSubmissionManagementRepository : RepositoryBase<SectionAssignmentSubmissionManagementRepository>, ISectionAssignmentSubmissionManagementRepository
    {
        public SectionAssignmentSubmissionManagementRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}