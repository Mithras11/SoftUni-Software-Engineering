namespace Logger
{
    using Core.Factories;
    using Core;
    using Core.IO;

    public class StartUp
    {
        static void Main(string[] args)
        {

            var appenderFactory = new AppenderFactory();
            var layoutFactory = new LayoutFactory();
            var reader = new FileReader();

            var engine = new Engine(appenderFactory, layoutFactory, reader);

            engine.Run();
        }


    }
}
