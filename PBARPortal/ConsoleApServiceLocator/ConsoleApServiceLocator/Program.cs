using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApServiceLocator
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
    public static class LocateService
    {
        public static IService _Service { get; set; }
        public static IService GetService()
        {
            if (_Service == null)
                _Service = new Service();

            return _Service;
        }
    }
    public class Client
    {
        private IService _service;
        public Client()
        {
            this._service = LocateService.GetService();
        }
        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Business Logic
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Start();
            Console.ReadKey();

        }
    }
}
