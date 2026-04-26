using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheatreMs.Api.Common;
using TheatreMs.Api.Data;
using TheatreMs.Api.Models;

namespace TheatreMs.Api.Controllers.Admin;

[ApiController]
[Route("api/admin/audit")]
[Authorize(Roles = "ROLE_ADMIN")]
public class AdminAuditController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<AuditLog>>>> GetLogs(
        [FromQuery] int limit = 100,
        [FromQuery] string? userId = null)
    {
        var query = context.Set<AuditLog>().AsQueryable();

        if (!string.IsNullOrEmpty(userId))
        {
            query = query.Where(l => l.UserId == userId);
        }

        var logs = await query
            .OrderByDescending(l => l.Timestamp)
            .Take(limit)
            .ToListAsync();

        return Ok(ApiResponse<IEnumerable<AuditLog>>.Ok(logs));
    }

    [HttpDelete("clear")]
    public async Task<ActionResult<ApiResponse<string>>> ClearLogs([FromQuery] int olderThanDays = 30)
    {
        var cutoff = DateTime.UtcNow.AddDays(-olderThanDays);
        var logsToDelete = await context.Set<AuditLog>()
            .Where(l => l.Timestamp < cutoff)
            .ToListAsync();

        context.Set<AuditLog>().RemoveRange(logsToDelete);
        await context.SaveChangesAsync();

        return Ok(ApiResponse<string>.Ok($"Cleared {logsToDelete.Count} logs older than {olderThanDays} days."));
    }
}
