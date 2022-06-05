namespace CountriesAPI.Models
{
    public class Country
    {
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        [MaxLength(10)]
        public string Iso3 { get; set; }
    }
}
