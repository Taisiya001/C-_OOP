using System.Collections;

public class ShapeService{
    private List<Shape> Shapes;
    public ShapeService(){
        this.Shapes = new ArrayList<>();
    }
    public List<Shape> getShape(){return Shapes;}
}