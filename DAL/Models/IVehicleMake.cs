﻿using System;

namespace Test.DAL.Models
{
    public interface IVehicleMake
    {
        string Abrv { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}