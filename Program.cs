
using System;
public class phuongtrinhbac2
{
    private int a_168;
    private int b_168;
    private int c_168;
    public phuongtrinhbac2(){}
    public phuongtrinhbac2(int a,int b,int c){
        a_168 = a;
        b_168 = b;
        c_168 = c;
    }
    public int A{
        get{return a_168;}
        set{a_168 = value;}
    }
    public int B{
        get{return b_168;}
        set{b_168 = value;}
    }
    public int C{
        get{return c_168;}
        set{c_168 = value;}
    }
    public double tinhdelta(){
        double delta;
        delta = (b_168 * b_168)-4*a_168*c_168;
        return delta;
    }
    public void tinhnghiem(){
        double d;
        d=tinhdelta();
        if(d<0){
            Console.WriteLine("Phuong trinh vo nghiem");
        }else{
            if(d==0){
                double x=-b_168/2*a_168;
                Console.WriteLine("phuong trinh co nghiem x= {0}",x);
            }else{
                double x1=(-b_168+Math.Sqrt(d))/2*a_168;
                double x2 = (-b_168-Math.Sqrt(d))/2*a_168;
                Console.WriteLine("phuong trinh co nghiem x1= {0}",x1);
                Console.WriteLine("phuong trinh co nghiem x2= {0}",x2);
            }
        }
    }
    public static void Main(string[] args)
    {
        phuongtrinhbac2 ptb2 = new phuongtrinhbac2(1,1,-2);
        ptb2.tinhnghiem();
    }
}