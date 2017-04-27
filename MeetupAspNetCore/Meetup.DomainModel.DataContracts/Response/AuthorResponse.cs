using Meetup.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Meetup.Api.Helpers;

namespace Meetup.DomainModel.DataContracts.Response
{
    public class AuthorResponse
    {
        public AuthorResponse() { }

        public AuthorResponse(Author author)
        {
            this.Age = author.DateOfBirth.GetCurrentAge();
            this.Genre = author.Genre;
            this.Name = $"{author.FirstName} {author.LastName}";
            this.Id = author.Id;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Genre { get; set; }
    }
}
