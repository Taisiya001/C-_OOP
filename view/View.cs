public class View{
    public void sendOnConsole(List<Shape> shape){
        foreach(Shape item in shape){
            System.Console.WriteLine(item);
        }
    }
    public void sendArea(Double area){
        System.Console.WriteLine("Area= " + area);
    }
    public void sendPerimeter(Double perimeter){
        System.Console.WriteLine("Perimeter= "+ perimeter);
    }
}