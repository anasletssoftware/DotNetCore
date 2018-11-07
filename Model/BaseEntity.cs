


namespace ImadErp.Model
{
    public class BaseEntity
    {
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}