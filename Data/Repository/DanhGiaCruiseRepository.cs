﻿using Data.Interfaces;
using Data.Models;
using Data.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IDanhGiaCruiseRepository : IRepository<DanhGiaCruise>
    {
    }

    public class DanhGiaCruiseRepository : Repository<DanhGiaCruise>, IDanhGiaCruiseRepository
    {
        public DanhGiaCruiseRepository(qltaikhoanContext context) : base(context)
        {
        }
    }
}