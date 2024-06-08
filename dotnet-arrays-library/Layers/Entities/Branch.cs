namespace dotnet_arrays_library.Layers.Entities
{
    public class Branch
    {
        public int IdBranch { get; set; }
        public string Name { get; set; }
        public Manager Manager { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}
