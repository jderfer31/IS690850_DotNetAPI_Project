using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ICourseSectionManagementRepository
    {
        
            IEnumerable<CourseSection> GetAllCourseSections(bool trackChanges);
            CourseSection GetCourseSection(Guid companyId, bool trackChanges);

            void CreateCourseSection(CourseSection coursesection);

            IEnumerable<CourseSection> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

            void DeleteCourseSection(CourseSection organization);
        
    }
}

