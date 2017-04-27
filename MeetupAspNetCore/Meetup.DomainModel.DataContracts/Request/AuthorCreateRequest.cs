using Meetup.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meetup.DomainModel.DataContracts.Request
{
    public class AuthorCreateRequest
    {
        public AuthorCreateRequest()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Genre { get; set; }

        public ICollection<BookCreateRequest> Books { get; set; }
        = new List<BookCreateRequest>();

        public Author ConvertToAuthor()
        {
            var author = new Author();
            author.FirstName = this.FirstName;
            author.LastName = this.LastName;
            author.DateOfBirth = this.DateOfBirth;
            author.Genre = this.Genre;
            author.Books = this.Books.Select(x => x.ConvertToBook()).ToList();

            return author;
        }
    }
}
