namespace DesignPatterns.State
{
    public class Canvas
    {
        public Tool Tool { get; set; }

        public void MouseDown()
        { 
            Tool.MouseDown();
        }

        public void MouseUp()
        {
            Tool.MouseUp();
        }
    }
}
