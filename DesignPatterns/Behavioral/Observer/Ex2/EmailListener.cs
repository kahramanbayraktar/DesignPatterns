namespace DesignPatterns.Behavioral.Observer.Ex2
{
    public class EmailListener : IEventListener
    {
        private readonly string _email;
        private readonly string _message;

        public EmailListener(string email, string message)
        {
            _email = email;
            _message = message;
        }

        public void Update(string fileName)
        {
            // Send email
            Console.WriteLine("Sending email | File: " + fileName, "Email content: " + _message);
        }
    }
}
