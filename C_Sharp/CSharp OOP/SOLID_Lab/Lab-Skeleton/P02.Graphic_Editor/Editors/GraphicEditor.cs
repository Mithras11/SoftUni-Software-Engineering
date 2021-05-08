namespace P02.Graphic_Editor.Editors
{
    using Contracts;
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {

            System.Console.WriteLine(shape.Draw());
        }
    }
}
