namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        private readonly List<EditorState> _states = new();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var lastState = _states[_states.Count - 1];
            _states.Remove(lastState);
            return lastState;
        }
    }
}
