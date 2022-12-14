class Contrrollers{
    private RepositoryShape repositoryShape;
    private View view;
    public Contrrollers(){
        this.repositoryShape = new RepositoryShape();
        this.view = new View();
    }
    public void sendOnConsole(){
        view.sendOnConsole(this.repositoryShape.getShape());
        view.sendArea(this.repositoryShape.getAllArea());
    }
    public void add(Shape shape){
        this.repositoryShape.add(shape);
    }
    public void getAllArea(){
        this.repositoryShape.getAllArea();
    }
    public void getAllPerimeter(){
        view.sendPerimeter(this.repositoryShape.getAllPerimeter());
    }
}