using Meetup.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.DomainModel.DataContracts.Response
{
    public class BookResponse
    {
        public BookResponse(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Description = book.Description;
            this.AuthorId = book.AuthorId;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid AuthorId { get; set; }
    }
}
