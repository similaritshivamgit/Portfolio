namespace Portfolio_Backend.Models
{
    public class UserDetails: BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int Pincode { get; set; } = 0;
        public string BloodGroup { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
    }
}
