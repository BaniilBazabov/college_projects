namespace finalexam.Command;

public class Invoker
{
    private List<Command> commands;
    private List<Command> UndoneCommands;
    
    public Invoker()
    {
        commands = new List<Command>();
        UndoneCommands = new List<Command>();
    }

    public void AddCommand(Command command)
    {
        commands.Add(command);
        command.Execute();
    }

    public void Undo()
    {
        if (commands.Count <= 0)
            return;
        

        var cmnd = commands.Last();
        commands.Remove(cmnd);
        cmnd.UndoExecute();
        UndoneCommands.Add(cmnd);
    }

    public void Redo()
    {
        if (UndoneCommands.Count <= 0)
            return;

        var cmnd = UndoneCommands.Last();
        UndoneCommands.Remove(cmnd);
        cmnd.Execute();
        commands.Add(cmnd);
    }
}