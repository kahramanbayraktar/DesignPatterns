namespace DesignPatterns.Behavioral.State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
