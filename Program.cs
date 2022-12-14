public class Main{
    public static void main(String[] args){
        Contrrollers contrrollers = new Contrrollers();
        contrrollers.add(new Rectangle(3,4));
        contrrollers.add(new Squered(4));
        contrrollers.sendOnConsole();
        contrrollers.getAllArea();
        contrrollers.getAllPerimeter();
    }
}