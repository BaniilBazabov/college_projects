namespace finalexam.Command;

public class UpdateStyleCmnd: Command
{
    private Canvas receiver;
    private AbstractShape oldShape;
    private string color;
    private string oldColor;
    
    
    public UpdateStyleCmnd(Canvas receiver, AbstractShape oldShape, string color)
    {
        this.receiver = receiver;
        this.oldShape = oldShape;
        this.color = color;
        this.oldColor = "black";
        
    }
    

    public override void Execute()
    {
        oldShape.UpdateStyle(color);
    }

    public override void UndoExecute()
    {
       oldShape.UpdateStyle(oldColor);
    }
}