using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.DbContextFolder;
using Shared.Model;

[Route("api/incidents")]
[ApiController]
public class IncidentsController : ControllerBase
{
    private readonly IncidentDbContext _context;

    public IncidentsController(IncidentDbContext context)
    {
        _context = context;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateIncident([FromBody] Incident incident)
    {
        //if (!ModelState.IsValid)
        //{
        //    return BadRequest(ModelState);
        //}

        _context.Incidents.Add(incident);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(CreateIncident), new { id = incident.Id }, incident);
    }

    /// <summary>
    /// Diese Methode erstellt in C# ein Select Statement basierend auf den Suchparametern 
    /// welche später eine Liste der gewünschten Incidents zurückliefert.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="closed"></param>
    /// <returns>Liste von Incidents</returns>

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<KeyValuePair<IncidentType, bool>>>> SearchIncidents(IncidentType type, bool closed)
    {

        var incidents = await _context.Incidents
                .Where(i => i.IncidentType == type && i.IsClosed == closed)
                .ToListAsync();

        return Ok(incidents);
    }
}
