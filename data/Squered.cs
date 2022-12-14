class Squered : Rectangle
{
    private double firstSide;
    private double secondSide;
    public Squered(double firstSide,double secondSide): base(firstSide,firstSide){
        this.firstSide = firstSide;
    }
    public override double countPerimeter()
    {
        double res = (this.firstSide)*4;
        return res;
    }
    public override double countArea()
    {
        double res = this.firstSide*this.firstSide;
        return res;
    }
    public double getFirstSide(){return firstSide;}
    public override String ToString()
    {
        return "Squared{" + "firstSide=" + firstSide + "}" + "area= " + countArea() + "perimeter= " + countPerimeter();
    }
}