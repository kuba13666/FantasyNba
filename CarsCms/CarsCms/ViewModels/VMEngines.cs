using CarsCms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsCms.ViewModels
{
    public class VMEngines
    {
        public EngineEntity EngineEntity { get; set; }
        public List<EngineEntity> EngineList { get; set; }
    }
}