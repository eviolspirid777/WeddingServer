namespace WeddingServer.Models.Requests
{
    public class WeddingForm
    {
        public string Name { get; set; }
        public int NumberOfVisitors { get; set; }
        public string Wishes { get; set; }

        public override string ToString()
        {
            return $"""
                        Имя: {this.Name}
                        Число гостей: {this.NumberOfVisitors}
                        Пожелание: {this.Wishes}
                    """;
        }
    }
}
