namespace Exercise8
{
    public interface IDoubleTroubleInt
    {
        int run();
    }

    public interface IDoubleTroubleVoid
    {
        void run();
    }

    public interface IMyExtraInterface
    {
        void StartExtra();
    }

    public interface IMyInterface
    {
        void Start();
    }

    internal class DoubleTrouble : IDoubleTroubleInt, IDoubleTroubleVoid
    {
        int IDoubleTroubleInt.run()
        {
            Console.WriteLine("Nu kör vi IDoubleTroubleInt: Returnerar 7");
            return 7;
        }

        void IDoubleTroubleVoid.run()
        {
            Console.WriteLine("Nu kör vi IDoubleTroubleVoid: Returnerar ingenting!");
        }
    }

    internal class Program1 : IMyInterface, IMyExtraInterface
    {
        //public void Run()
        //{
        //    Console.WriteLine("Nu kör vi program 1");
        //}

        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void StartExtra()
        {
            Console.WriteLine("Nu kör vi ExtraInterfacet i program 1");
        }
    }

    internal class Program2 : IMyInterface
    {
        //public void Go()
        //{
        //    Console.WriteLine("Nu kör vi program 2");
        //}

        public void Start()
        {
            Console.WriteLine("Nu kör vi program 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Program1 program1 = new();
            Program2 program2 = new();
            DoubleTrouble doubleTrouble = new();

            //program1.Run();
            //program2.Go();

            program1.Start();
            program1.StartExtra();
            program2.Start();

            ((IDoubleTroubleVoid)doubleTrouble).run();
            int myValue = ((IDoubleTroubleInt)doubleTrouble).run();
            Console.WriteLine($"Här är värdet som returnerades {myValue}");
        }
    }
}
