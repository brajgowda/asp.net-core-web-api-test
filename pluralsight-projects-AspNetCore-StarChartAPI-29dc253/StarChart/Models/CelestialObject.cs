using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{

 //  3) Create CelestialObject Model task
 //Create a new public class CelestialObject in the Models directory
 //Create a new public property of type int named Id.
 //Create a new public property of type string named Name.This property should have the Required attribute. (Note: you will need to add a using directive for Systems.ComponentModel.DataAnnotations)
 //Create a new public property of type int? named OrbitedObjectId.
 //Create a new public property of type List<CelestialObject> named Satellites. This property should have the NotMapped attribute. (Note: you will need to add using directives for System.Collections.Generic and System.ComponentModels.DataAnnotations.Schema)
 //Create a new public property of type TimeSpan named OrbitalPeriod.
 //In the ApplicationDbContext class, located in the Data folder, create a new public property of type DbSet<CelestialObject> named CelestialObjects. (Note: you will need to add a using directive for StarChart.Models)
    public class CelestialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObjectId { get; set; }
        
        // Satellite list
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        
        // to calculate time
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
