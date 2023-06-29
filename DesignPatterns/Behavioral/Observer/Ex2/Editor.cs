namespace DesignPatterns.Behavioral.Observer.Ex2
{
    public class Editor
    {
        private File _file = null!;
        public EventManager Events;

        public Editor()
        {
            Events = new EventManager();
        }

        public void OpenFile(string path)
        { 
            _file = new File(path);

            Events.Notify(typeof(LoggingListener), _file.FileName);
        }

        public void SaveFile(string path)
        {
            _file.Write(path);

            Events.Notify(typeof(LoggingListener), _file.FileName);
        }
    }
}
