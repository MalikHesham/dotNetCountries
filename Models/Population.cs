namespace CountriesAPI.Models
{
    public class Population
    {
        public int Id { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Only positive values are allowed")]
        public int Value { get; set; }
        
        [Range(1961, 2018, ErrorMessage = "Only values from 1961 to 2018 are allowed")]
        public int Year { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
