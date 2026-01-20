using System;
using System.ComponentModel.DataAnnotations;

namespace JiraClone.Data
{
    public class WorkItem
    {
        public int Id { get; set; }

        [Required]
        public string Item { get; set; } = string.Empty;

        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }

        public string? DevLead { get; set; }
        public string? Dev { get; set; }
        public string? BALead { get; set; }
        public string? BA { get; set; }

        public string? Comments { get; set; }

        public DateTime? DemoDate { get; set; }
        public DateTime? DesignETA { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? DevETA { get; set; }

        // REQUIRED FKs (nullable so Required works)
        [Required(ErrorMessage = "Please select a Project")]
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }

        [Required(ErrorMessage = "Please select a Board")]
        public int? BoardId { get; set; }
        public Board? Board { get; set; }
    }
}