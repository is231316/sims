using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Shared.Model
{
    public class Incident
    {
        public int Id { get; set; }

        [JsonPropertyName("incident_date")]
        [Column("incident_date")]
        public DateTime IncidentDate { get; set; }

        [JsonPropertyName("title")]
        [Column("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        [Column("description")]
        public string Description { get; set; }

        [JsonPropertyName("incident_type")]
        [Column("incident_type")]
        public IncidentType IncidentType { get; set; }

        [JsonPropertyName("is_closed")]
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
