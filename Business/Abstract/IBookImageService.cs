﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookImageService
    {
        IResult Add(IFormFile file, BookImage bookImage);
        IResult Update(BookImage bookImage);
        IResult Delete(BookImage bookImage);
        IDataResult<List<BookImage>> GetAll();
        IDataResult<BookImage> GetById(int id);
        IDataResult<BookImage> GetByBookId(int id);
        IDataResult<List<BookImageDetailDto>> GetBookImageDetails();
    }
}
