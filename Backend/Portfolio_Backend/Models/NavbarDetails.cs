namespace Portfolio_Backend.Models
{
    public class NavbarDetails: BaseModel
    {
        public string Logo { get; set; } = string.Empty;
        public List<object>? MenuItems { get; set; }
    }
}
