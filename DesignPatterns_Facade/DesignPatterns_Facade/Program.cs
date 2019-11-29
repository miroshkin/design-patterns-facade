using System;

namespace DesignPatterns_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns - Facade!");
            SimpleClient client = new SimpleClient();
            client.JustDoIt();
        }
    }

    class SuperComplexLibrary : ISuperInterface
    {
        public void Operation_1()
        {
            Console.WriteLine("Operation 1 success");
        }

        public void Operation_2()
        {
            Console.WriteLine("Operation 2 success");
        }

        public void Operation_3()
        {
            Console.WriteLine("Operaion 3 success");
        }
    }

    interface ISuperInterface
    {
        void Operation_1();
        void Operation_2();
        void Operation_3();
    }

    interface ISimpleFacade
    {
        void JustDoIt();
    }

    class SimpleClient : ISimpleFacade
    {
        private SuperComplexLibrary _library;
        public SimpleClient()
        {
            _library = new SuperComplexLibrary();
        }

        /// <summary>
        /// Hides the complexity of the library behind the Facade
        /// </summary>
        public void JustDoIt()
        {
            _library.Operation_1();
            _library.Operation_2();
            _library.Operation_3();
        }
    }
}
