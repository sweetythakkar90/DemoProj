using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProjServiceAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class CompanyController : Controller
    {
        // GET: api/company
        [HttpGet]
        [EnableCors("MyPolicy")]
        public IEnumerable<Company> GetCompanies()
        {
            return CompanyService.GetCompanies();
        }
        // GET api/company/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "company";
        }
        // POST api/company
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        // PUT api/company/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/company/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
