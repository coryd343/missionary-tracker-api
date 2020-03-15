using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MissionaryTrackerApi.Model;

namespace MissionaryTrackerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissionaryController : Controller
    {
        private readonly MissionaryTrackerDbContext _db;

        public MissionaryController(MissionaryTrackerDbContext db)
        {
            this._db = db;
        }

        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GetMissionary(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }
            Missionary missionary = this._db.Missionary.FirstOrDefault(o => o.Id == id);
            return this.Ok(missionary);
        }

        [HttpPost]
        public async Task<ActionResult> PostMissionary([FromBody] Missionary NewMissionary)
        {
            if (NewMissionary == null)
            {
                return this.BadRequest();
            }

            this._db.Missionary.Add(NewMissionary);
            await this._db.SaveChangesAsync();
            return this.Ok(NewMissionary);
        }
    }
}