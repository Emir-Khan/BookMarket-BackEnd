﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPublisherDal:EfEntityRepositoryBase<Publisher, BooksContext>,IPublisherDal
    {
    }
}
