using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDirectInjection
{
    public interface IService
    {
        void Serve();
    }
    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");

            //To Do: Business Logic
        }
    }
    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            this._service = service;
        }
        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Business Logic
        }

        static void Main(string[] args)
        {
           var client = new Client(new Service());
            client.Start();
            Console.ReadKey();

        }
    }
}
