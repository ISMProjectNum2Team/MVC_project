using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TestMVC.Models
{
    public class EventViewModel
    {
        public string Id
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string length must be between 3 and 50 characters")]
        public string Title
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string length must be between 3 and 50 characters")]
        public string Description
        {
            get;
            set;
        }

        public string Details
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string length must be between 3 and 50 characters")]
        public string Location
        {
            get;
            set;
        }

        public DateTime? DateFrom
        {
            get;
            set;
        }

        public DateTime? DateTo
        {
            get;
            set;
        }

        public EventViewModel(string title, string description, string details, string location,
                    DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Description = description;
            Location = location;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Details = details;
        }

    }
}