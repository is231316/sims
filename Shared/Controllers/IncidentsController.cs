using Microsoft.AspNetCore.Mvc;
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
}
