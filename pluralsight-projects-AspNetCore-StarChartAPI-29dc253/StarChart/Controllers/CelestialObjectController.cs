using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
 // 4)   Create CelestialObjectController class
 //Create a new class CelestialObjectController in the Controllers folder that inherits the ControllerBase class. If any actions are automatically generated they should be removed. (Note: you will need to add a using directive for Microsoft.AspNetCore.Mvc)
 //Add a Route attribute with a value of "" and ApiController attribute to the CelestialObjectController.
 //Create a new private readonly field of type ApplicationDbContext named _context. (Note: you will need to add a using directive for StarChart.Data)
 //Create a constructor that accepts a parameter of type ApplicationDbContext and sets the _context field using the provided parameter.

    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }


    }
}
