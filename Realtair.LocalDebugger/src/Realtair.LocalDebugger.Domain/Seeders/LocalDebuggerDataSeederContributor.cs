﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Realtair.LocalDebugger.Books;
//using Volo.Abp.Data;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.Domain.Repositories;

//namespace Realtair.LocalDebugger.Seeders
//{
//    public class LocalDebuggerDataSeederContributor : IDataSeedContributor, ITransientDependency
//    {
//        private readonly IRepository<Book, Guid> _bookRepository;

//        public LocalDebuggerDataSeederContributor(IRepository<Book, Guid> bookRepository) 
//        { 
//            _bookRepository = bookRepository; 
//        }

//        public async Task SeedAsync(DataSeedContext context)
//        {
//            if (await _bookRepository.GetCountAsync() <= 0)
//            {
//                await _bookRepository.InsertAsync(
//                    new Book
//                    {
//                        Name = "1984",
//                        Type = BookType.Dystopia,
//                        PublishDate = new DateTime(1949, 6, 8),
//                        Price = 19.84f
//                    }
//                );
//                await _bookRepository.InsertAsync(
//                    new Book
//                    {
//                        Name = "The Hitchhiker's Guide to the Galaxy",
//                        Type = BookType.ScienceFiction,
//                        PublishDate = new DateTime(1995, 9, 27),
//                        Price = 42.0f
//                    }
//                );

//                //await _bookRepository.InsertManyAsync(
//                //    [
//                //        new Book { 
//                //            Name = "1984",
//                //            Type = BookType.Dystopia,
//                //            PublishDate = new DateTime(1949, 6, 8),
//                //            Price = 19.84f
//                //        },
//                //        new Book {
//                //            Name = "The Hitchhiker's Guide to the Galaxy",
//                //            Type = BookType.ScienceFiction,
//                //            PublishDate = new DateTime(1995, 9, 27),
//                //            Price = 42.0f
//                //        }
//                //    ],
//                //    autoSave: true
//                //);
//            }
//        }
//    }
//}
