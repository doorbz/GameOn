namespace GameOn.ModelClasses
{
    public class Sport
    {
        public int SportId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int UserInformationId { get; set; }

        public virtual UserInformation UserInformation { get; set; }
    }
}
