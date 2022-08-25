using MainService;
using System;

namespace FirstService
{
    public class FirstServ : IMainService
    {
        public void UseService()
        {
            Console.WriteLine(nameof(FirstServ));
        }
    }
}
