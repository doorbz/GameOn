using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOn.ModelClasses
{
    public class Event
    {
        private ICollection<User> _users;

        public Event()
        {
            _users = new List<User>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public virtual ICollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }

    }
}
