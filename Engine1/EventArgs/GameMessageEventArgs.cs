namespace Engine1.EventArgs
{
    public class GameMessageEventArgs : System.EventArgs
    {
        public string Message { get; private set; }

        public GameMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}