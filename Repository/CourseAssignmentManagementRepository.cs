using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CourseAssignmentManagementRepository : RepositoryBase<CourseAssignmentManagementRepository>, ICourseManagementRepository
    {
        public CourseAssignmentManagementRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}