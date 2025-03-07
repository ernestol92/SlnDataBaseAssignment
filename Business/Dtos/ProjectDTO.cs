

namespace Business.Dtos
{
    public class ProjectDTO
    {
        
        public int Id { get; set; }
        public string ProjectName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectManagerName { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string ServiceName { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
