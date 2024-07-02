using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechprimeJwtProject.Models;
using TechprimeJwtProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechprimeJwtProject.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]


    public class ProjectController : ControllerBase
    {
        private readonly IProjectServices services;
        private readonly ITypeServices typeServices;
        private readonly IReasonServices reasonServices;
        private readonly IPriorityServices priorityServices;
        private readonly ILocationServices locationServices;
        private readonly IDivisionServices divisionServices;
        private readonly IDepartmentServices departmentServices;
        private readonly ICategoryServices categoryServices;
        public ProjectController(IProjectServices services, ITypeServices typeServices, IReasonServices reasonServices, IPriorityServices priorityServices, IDivisionServices divisionServices, IDepartmentServices departmentServices, ICategoryServices categoryServices, ILocationServices locationServices)
        {
            this.locationServices = locationServices;
            this.services = services;
            this.typeServices = typeServices;
            this.reasonServices = reasonServices;
            this.priorityServices = priorityServices;
            this.divisionServices = divisionServices;
            this.categoryServices = categoryServices;
            this.departmentServices = departmentServices;
        }
        // GET: api/<ProjectController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ProjectController>/5
        
        [HttpGet]
        [Route("GetProjects")]
        public async Task<IActionResult> GetAllProjects()
        {
            var projects = await services.GetAllProjects();
            return Ok(projects);
        }
        //public IActionResult GetAllproject()
        //{
        //    var model = services.GetAllProjects();
        //    return new ObjectResult(model);
        //}

        [HttpGet]
        [Route("getreasonbyid/{id}")]
        public IActionResult GetReasonbyid(int reasonid)
        {
            var model=reasonServices.GetReasonbyId(reasonid);
           return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getbytype/{id}")]
        public IActionResult Gettypesbyid(int typeid)
        {
            var model = typeServices.Gettypesbyid(typeid);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getcategorybyid/{id}")]
        public IActionResult Getcategorybyid(int reasonid)
        {
            var model = categoryServices.GetCategoryById(reasonid);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getdivisionbyid/{id}")]
        public IActionResult Getdivisionbyid(int reasonid)
        {
            var model = divisionServices.GetDivisionById(reasonid);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getdepartmentbyid/{id}")]
        public IActionResult Getdepartmentbyid(int reasonid)
        {
            var model = departmentServices.GetDepartmentById(reasonid);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getprioritybyid/{id}")]
        public IActionResult Getprioritybyid(int reasonid)
        {
            var model =priorityServices.GetPriorityById(reasonid);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("getlocationbyid/{id}")]
        public IActionResult Getlocationbyid(int reasonid)
        {
            var model =locationServices.GetLocationbyId(reasonid);
            return new ObjectResult(model);
        }


        //public IActionResult GetAllProjects()
        //{
        //    var model=services.GetAllProjects();
        //    return new ObjectResult(model);
        //}

        // POST api/<ProjectController>
        [HttpPost("saveproject")]
        public ActionResult<Project> Post([FromBody] Project pr)
        {
            var model = services.AddProject(pr);
            return new ObjectResult(model);
        }
        [HttpGet]
        [Route("projectcount")]
        public async Task<IActionResult> GetProjectCounts()
        {
            var projectCounts = await services.GetProjectCounts();
            return new ObjectResult(projectCounts);
        }
       
        
        [HttpPut("{id}")]
       
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet]
        [Route("getalltypes")]
        public IActionResult GetAllTypes()
        {
            var model=typeServices.GetAllTypes();
            return new ObjectResult(model);
           
        }
        [HttpGet]
        [Route("getallreasons")]
        public IActionResult Getallreasons()
        {
            var model = reasonServices.GetAllReasons();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getallpriority")]
        public IActionResult GetAllpriority()
        {
            var model = priorityServices.GetPriorityList();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getalllocations")]
        public IActionResult GetAlllocations()
        {
            var model =locationServices.GetLocations();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getallstatus")]
        public IActionResult GetAllstatus()
        {
            var model = services.GetStatuses();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getallcategory")]
        public IActionResult GetAllcategory()
        {
            var model = categoryServices.GetAllCategories();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getalldivisions")]
        public IActionResult GetAlldivisions()
        {
            var model = divisionServices.GetDivisions();
            return new ObjectResult(model);

        }
        [HttpGet]
        [Route("getalldepartments")]
        public IActionResult GetAlldepartments()
        {
            var model = departmentServices.GetDepartments();
            return new ObjectResult(model);

        }
        //[HttpPut("{id}/status")]
        //public async Task<IActionResult> UpdateProjectStatus(int id, [FromBody] Status request)
        //{
        //    var success = await services.UpdateProjectStatusAsync(id, request.Id);
        //    if (!success)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();
        //}
        [HttpPut]
        [Route("UpdateStatusProject")]
        public IActionResult UpdateStatusProject([FromBody]Project project)
        {
            var model=services.UpdateProject(project);
            return new ObjectResult(model);
        }
    }
}
