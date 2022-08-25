using MainService;
using System;

namespace SecondService
{
    public class SecondServ : IMainService
    {
        public void UseService()
        {
            Console.WriteLine(nameof(SecondServ));
        }
    }
}
