﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<BookDetailDto>> GetBookDetailsDto();
        IDataResult<List<BookDetailDto>> GetBooksDetailsByFilter(int writerId, int publisherId, int categoryId);
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
    }
}
