using Meetup.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Meetup.DomainModel.DataContracts.Request
{
    public class BookUpdateRequest : AbstractBookRequest
    {
        public BookUpdateRequest() { }

        public BookUpdateRequest(Book book)
        {
            this.Description = book.Description;
            this.Title = book.Title;
        }

        [Required(ErrorMessage = "You should fill out a description.")]
        public override string Description
        {
            get
            {
                return base.Description;
            }

            set
            {
                base.Description = value;
            }
        }
    }
}
