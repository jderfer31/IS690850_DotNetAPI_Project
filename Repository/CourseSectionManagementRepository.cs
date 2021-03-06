﻿using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CourseSectionManagementRepository : RepositoryBase<CourseSectionManagementRepository>, ICourseSectionManagementRepository
    {
        public CourseSectionManagementRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}