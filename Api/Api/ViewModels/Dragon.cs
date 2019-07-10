namespace Api.Models
{
    public class Dragon
    {
        public Dragon(int id, string name, string image, string category, string type, string[] loot)
        {
            Id = id;
            Name = name;
            Image = image;
            Category = category;
            Type = type;
            Loot = loot;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string[] Loot { get; set; }
    }
}