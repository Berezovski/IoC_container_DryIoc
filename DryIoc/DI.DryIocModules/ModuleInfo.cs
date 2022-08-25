using System;
using System.Collections.Generic;
using System.Text;

namespace DI.DryIocModules
{
    public class ModuleInfo : IModuleInfo
    {
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public bool Enabled { get; set; }
    }
}
