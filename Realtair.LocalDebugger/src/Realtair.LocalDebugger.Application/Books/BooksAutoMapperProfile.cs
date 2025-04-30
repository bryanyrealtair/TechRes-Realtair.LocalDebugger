using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Realtair.LocalDebugger.Books;

public class BooksAutoMapperProfile : Profile
{
    public BooksAutoMapperProfile()
    {
        //CreateMap<Book, BookDto>().ReverseMap(); //for two-way mapping
        //CreateMap<CreateUpdateBookDto, Book>().ReverseMap();
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

    }
}
