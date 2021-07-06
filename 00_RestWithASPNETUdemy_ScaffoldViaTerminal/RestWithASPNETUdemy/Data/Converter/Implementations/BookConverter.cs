using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            else
            {
                return new Book
                {
                    Id = origin.Id,
                    Author = origin.Author,
                    Launch_Date= origin.Launch_Date,
                    Price= origin.Price,
                    Title= origin.Title
                };
            }
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin==null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            else
            {
                return new BookVO
                {
                    Id = origin.Id,
                    Author = origin.Author,
                    Launch_Date = origin.Launch_Date,
                    Price = origin.Price,
                    Title = origin.Title
                };
            }
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
