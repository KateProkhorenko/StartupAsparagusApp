namespace StartupAsparagusApp.Models
{
    public class UserViewModel
    {
        public User User { get; set; } = new User();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;

      
    }
}
