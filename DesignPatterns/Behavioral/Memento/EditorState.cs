namespace DesignPatterns.Behavioral.Memento
{
    public class EditorState
    {
        private readonly string _content;

        public EditorState(string content)
        {
            _content = content;
        }

        public string Content => _content;
    }
}
