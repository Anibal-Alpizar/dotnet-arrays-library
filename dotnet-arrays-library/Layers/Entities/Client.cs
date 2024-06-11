namespace dotnet_arrays_library.Layers.Entities
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool Active { get; set; }
    }
}
