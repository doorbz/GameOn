using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOn.ModelClasses
{
    public class User
    {
        private ICollection<UserInformation> _userInformations;
        private ICollection<Event> _events;

        public User()
        {
            _userInformations = new List<UserInformation>();
            _events = new List<Event>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public virtual ICollection<UserInformation> UserInformations
        {
            get
            {
                return _userInformations;
            }
            set
            {
                _userInformations = value;
            }
        }

        public virtual ICollection<Event> Events
        {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
            }
        }

    }
}
