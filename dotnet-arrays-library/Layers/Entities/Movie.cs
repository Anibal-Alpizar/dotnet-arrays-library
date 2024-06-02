namespace dotnet_arrays_library.Layers.Entities
{
    public class Movie
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public CategoryMovie CategoryMovie { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }

    }
}
