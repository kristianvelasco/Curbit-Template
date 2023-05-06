﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Data
{
    public interface IUnitOfWork
    {
       Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
