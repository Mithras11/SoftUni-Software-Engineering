namespace Logger.Core.Factories
{
    using Layouts;


    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
