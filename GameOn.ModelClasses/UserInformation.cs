using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameOn.ModelClasses
{
    public class UserInformation
    {
        private ICollection<Sport> _sports;

        public UserInformation()
        {
            _sports = new List<Sport>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
