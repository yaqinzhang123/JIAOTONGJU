﻿using DYApp.Domain.Model;
using DYApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYApp.Domain;

namespace DYApp.Repositories.Repository
{
    public class InvolvedRepository : RepositoryBase<Involved>, IInvolvedRepository
    {
        public InvolvedRepository(IRepositoryContext context) : base(context)
        {
        }
    }
}
