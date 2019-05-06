﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Models
{
    public class VehicleModel : IVehicleModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Abrv { get; set; }
        public int VehicleMakeId { get; set; }
        [ForeignKey("VehicleMakeId")]
        public IVehicleMake VehicleMake { get; set; }
    }
}
