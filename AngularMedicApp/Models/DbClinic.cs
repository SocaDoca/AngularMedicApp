namespace AngularMedicApp.Models
{
    public class DbClinic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
