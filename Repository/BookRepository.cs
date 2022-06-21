using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Webapi.Data;
using Webapi.Model;

namespace Webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            //var records =await _context.Books.Select(a=> new BookModel
            //{
            //    Id = a.Id,
            //    Title=a.Title,
            //    Description = a.Description
            //}).ToListAsync();   
            var v = await _context.Books.ToListAsync();

          return  _mapper.Map<List<BookModel>>(v);
        }  
        
        public async Task<BookModel> GetSingleBooksAsync(int bookId)
         {
            //var records =await _context.Books.Where(a=>a.Id==bookId).Select(a=> new BookModel
            //{   
            //    Id = a.Id,
            //    Title=a.Title,
            //    Description = a.Description
            //}).FirstOrDefaultAsync();   
            var rec = await _context.Books.FindAsync(bookId);

          return   _mapper.Map<BookModel>(rec);
        }

        public async Task<int> GetAddBooksAsync(BookModel bookModel)
        {
            var s = new Books()
            {
                Description = bookModel.Description,
                Title = bookModel.Title
            };
            _context.Books.Add(s);
           await _context.SaveChangesAsync();
           return s.Id;
        }  
        public async Task AddBooksAsync(int id,BookModel bookModel)
        {
            //var v = await _context.Books.FindAsync(id);
            //if(v!=null)
            //{
            //    v.Description = bookModel.Description;
            //    v.Title = bookModel.Title;
            //}
            //await _context.SaveChangesAsync();

            var v = new Books()
            {
                Id = id,
                Description = bookModel.Description,
                Title = bookModel.Title
            };
            _context.Books.Update(v);
                await _context.SaveChangesAsync();
        } 
        public async Task PatchBooksAsync(int id, JsonPatchDocument bookModel)
         {
            var v = await _context.Books.FindAsync(id);

            if (v != null)
            {
                bookModel.ApplyTo(v);
                await _context.SaveChangesAsync();
            }
        } 
        
        public async Task DeleteBooksAsync(int id)
         {
            var v = await _context.Books.FindAsync(id);

            if(v!=null)
            {
                 _context.Books.Remove(v);
                await _context.SaveChangesAsync();
            }
        }
    }
}
 