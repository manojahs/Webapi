using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;
using Webapi.Model;

namespace Webapi.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetSingleBooksAsync(int bookId);

        Task<int> GetAddBooksAsync(BookModel bookModel);

        Task AddBooksAsync(int id, BookModel bookModel); 
        Task PatchBooksAsync(int id, JsonPatchDocument bookModel);

         Task DeleteBooksAsync(int id);
    }   
}
