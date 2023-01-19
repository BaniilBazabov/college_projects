namespace finalexam.Command;

public class AddShapeCmnd: Command
{
    private Canvas receiver;
    private AbstractShape _shape;
    
    
    public AddShapeCmnd(Canvas receiver, AbstractShape shape)
    {
        this.receiver = receiver;
        this._shape = shape;
    }
    

    public override void Execute()
    {
        this.receiver.AddShape(_shape);
    }

    public override void UndoExecute()
    {
        this.receiver.DeleteShape(_shape);
    }
}