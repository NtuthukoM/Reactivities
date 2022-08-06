using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistance;

namespace Reactivities.API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
        private readonly ReactivitiesDataContext dataContext;

        public ActivitiesController(ReactivitiesDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await dataContext.Activities.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(int id)
        {
            return await dataContext.Activities.FindAsync(id);
        }
    }
}
