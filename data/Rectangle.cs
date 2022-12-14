class Rectangle : Shape
{
    private double fistSide;
    private double secondSide;
    public Rectangle(double fistSide,double secondSide){
        this.fistSide = fistSide;
        this.secondSide = secondSide;
    }
    public override double countPerimeter(){
        double res = (this.fistSide + this.secondSide)*2;
        return res;
    }
    public override double countArea(){
        double res = this.fistSide*this.secondSide;
        return res;
    }
    public double getFirstSide(){
        return fistSide;
    }
    public double getSecondSide(){
        return secondSide;
    }
    public String toString(){
        return "Rectangle{" + "firstSide="+ fistSide + "secondSide" + secondSide + "}" + "area= " + countArea() + "perimeter= " + countPerimeter();
    }
}