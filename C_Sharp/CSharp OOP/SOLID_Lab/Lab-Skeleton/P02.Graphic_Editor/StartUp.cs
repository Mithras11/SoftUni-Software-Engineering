namespace P02.Graphic_Editor
{
    using Editors;
    using Models;
    class StartUp
    {
        static void Main()
        {
            var graphicEditor = new GraphicEditor();

            var square = new Square();
            var rectangle = new Rectangle();
            var circle = new Circle();
            var pyramid = new Pyramid();

            graphicEditor.DrawShape(square);
            graphicEditor.DrawShape(rectangle);
            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(pyramid);
        }
    }
}
