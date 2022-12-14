using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Persistence;
using System.Diagnostics;



namespace API.Controllers
{
    public class ActivitiesController : BaseAPIController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Domain.Activity>>> GetActivities()
        {
          return await  _context.Activities.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Activity>>GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}
