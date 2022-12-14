using System;
using System.Collections;
using System.Collections.Generic;

public class RepositoryShape : Reporitory{
    List<Shape> shape;
    public RepositoryShape(){
        this.shape = new ArrayList<>();
    }
    public double getAllPerimeter(){
        double a = 0.0;
        foreach(Shape item in shape){
            a = a + item.countPerimeter();
        }
        return a;
    }
    public double getAllArea(){
        double b =0.0;
        foreach(Shape item in shape){
            b = b + item.countArea();
        }
        return b;
    }
    public List<Shape> getShape(){return shape;}
}

