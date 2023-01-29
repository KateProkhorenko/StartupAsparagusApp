namespace StartupAsparagusApp.Models
{
    public class User
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int NumberOfMeals { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime DateEating { get; set; }

        
    }
}
