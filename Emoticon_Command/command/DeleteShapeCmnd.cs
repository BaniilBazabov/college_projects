namespace finalexam.Command;

public class DeleteShapeCmnd: Command
{
    private Canvas receiver;
    private AbstractShape _shape;
    
    
    public DeleteShapeCmnd(Canvas receiver, AbstractShape shape)
    {
        this.receiver = receiver;
        this._shape = shape;
    }
    

    public override void Execute()
    {
        this.receiver.DeleteShape(_shape);
    }

    public override void UndoExecute()
    {
        this.receiver.AddShape(_shape);
    }
}