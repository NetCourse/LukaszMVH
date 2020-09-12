namespace VirtualHome.Models
{
    public class Light
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPowered { get; set; }

        public virtual Room Location { get; set; }

        public string Color { get; set; }
    }
}
