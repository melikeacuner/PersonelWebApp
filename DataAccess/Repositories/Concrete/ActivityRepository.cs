﻿using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(PersonelDbContext dbContext) : base(dbContext)
        {
        }
        public PersonelDbContext PersonelContext { get { return (PersonelDbContext)dbContext; } }
    }
}
