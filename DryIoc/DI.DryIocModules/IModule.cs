using DryIoc;
using System;

namespace DI.DryIocModules
{
    public interface IModule : IModuleInfo
    {
        void RegisterTypes(IContainer container);
    }
}
