namespace Portfolio_Backend.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedByDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedByDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedByDate { get; set; }
    }
}
