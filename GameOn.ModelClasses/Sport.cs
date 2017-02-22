using System.ComponentModel.DataAnnotations.Schema;

namespace GameOn.ModelClasses
{
    public class Sport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SportId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int UserInformationId { get; set; }

        public virtual UserInformation UserInformation { get; set; }
    }
}
