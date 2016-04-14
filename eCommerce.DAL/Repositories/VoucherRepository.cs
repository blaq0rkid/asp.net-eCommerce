﻿using eCommerce.DAL.Data;
using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public class VoucherRepository: RepositoryBase<Voucher>
    {
        public VoucherRepository(DataContext context)
            :base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
