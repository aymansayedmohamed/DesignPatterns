namespace Command
{
    /// <summary>
    /// The invoker class like [the remote control] 
    /// </summary>
    public class Switch
    {
        private readonly ICommand _closeCommand;
        private readonly ICommand _openCommand;

        public Switch(ICommand closeCommand, ICommand OpenCommand)
        {
            this._openCommand = OpenCommand;
            this._closeCommand = closeCommand;
        }

        //open button functon
        public void OpenLight()
        {
            this._openCommand.Execute();
        }

        //clos button function
        public void CloseLight()
        {
            this._closeCommand.Execute();
        }
    }


}

