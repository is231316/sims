using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Model
{
    public class Incident
    {
        public int Id { get; set; }

        [Column("incident_date")]
        public DateTime IncidentDate { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("incident_type")]
        public IncidentType IncidentType { get; set; }

        [Column("is_closed")]
        public bool IsClosed { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public enum IncidentType
    {
        Ticket,
        Issue,
        Information,
        Problem
    }

}
