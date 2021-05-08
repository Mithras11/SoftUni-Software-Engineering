namespace P02.Graphic_Editor.Models
{
    using Contracts;
    public class Square : IShape
    {
        public string Draw()
        {
            return "I'm Square";
        }
    }
}
