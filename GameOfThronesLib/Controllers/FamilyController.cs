using GameOfThronesLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GameOfThronesLib.Controller
{
    public class FamiliyController : ApiController
    {
        private GoTLibContext _context { get; set; }

        public FamiliyController()
        {
            _context = new GoTLibContext();
        }

        [HttpGet, Route("api/Family/FindFamilies")]
        public List<Family> FindFamilies()
        {
            var families = _context.Families.ToList();
            return families;
        }
    }
}
