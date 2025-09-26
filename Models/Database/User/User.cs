using System.ComponentModel.DataAnnotations;

namespace WeddingServer.Models.Database.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Wishes { get; set; }
        public int NumberOfVisitors { get; set; }

        public override string ToString()
        {
            return $"""
                    Имя: {Name}
                        Число гостей: {NumberOfVisitors}
                        Пожелание: {Wishes}
                    """;
        }
    }
}
