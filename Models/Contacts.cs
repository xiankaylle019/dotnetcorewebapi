namespace dotnetcorewebapi.Models
{
    public class Contacts : BaseEntity
    {
        public string ContactType { get; set; }
        public string Contact { get; set; }
        public Person PersonId { get; set; }
        public Person Person { get; set; }
    }
}