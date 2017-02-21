using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOn.ModelClasses
{
    public class UserInformation
    {
        private ICollection<Sport> _sports;

        public UserInformation()
        {
            _sports = new List<Sport>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Sport> Sports
        {
            get
            {
                return _sports;
            }
            set
            {
                _sports = value;
            }
        }

    }
}
