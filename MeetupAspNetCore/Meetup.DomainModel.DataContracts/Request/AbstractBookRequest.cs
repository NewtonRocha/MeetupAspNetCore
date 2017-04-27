using Meetup.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Meetup.DomainModel.DataContracts.Request
{
    public abstract class AbstractBookRequest
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters.")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "The description shouldn't have more than 500 characters.")]
        public virtual string Description { get; set; }

        public Book ConvertToBook()
        {
            var book = new Book()
            {
                Description = this.Description,
                Title = this.Title
            };
            return book;
        }
    }
}
