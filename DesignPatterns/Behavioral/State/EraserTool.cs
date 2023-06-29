namespace DesignPatterns.Behavioral.State
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}