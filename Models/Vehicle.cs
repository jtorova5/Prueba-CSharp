using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string CarPlate { get; set; }
    public string Type { get; set; }
    public string EngineNumber { get; set; }
    public string SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver Owner { get; set; }
}
