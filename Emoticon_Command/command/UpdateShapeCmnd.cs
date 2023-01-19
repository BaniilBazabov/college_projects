namespace finalexam.Command;

public class UpdateShapeCmnd: Command
{
    private Canvas receiver;
    private AbstractShape oldShape;
    private string direction;
    private int value;
    
    
    public UpdateShapeCmnd(Canvas receiver, AbstractShape oldShape, string direction, int value)
    {
        this.receiver = receiver;
        this.oldShape = oldShape;
        this.direction = direction;
        this.value = value;
    }
    

    public override void Execute()
    {
        oldShape.UpdateShape(direction,value);
    }

    public override void UndoExecute()
    {
       oldShape.UpdateShape(direction,-value);
    }
}