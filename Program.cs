using System.Text;

namespace Constructor
{
    interface Iinter123
    {
        public void show();
        public void display();
    }
    class class123 : Iinter123
    {
        public void show()
        {
            //logic
        }
        public void display()
        { 
        }
    }
    class Shape
    {
        int r;
        float area;
        float PI;

        public  Shape() //constructor
        {
          
        }
        public Shape(int rad) //constructor
        {
            r = rad;
            Console.WriteLine("this is automatic method..");
        }
        public Shape(char p1) //constructor
        {
            //r = rad;
            Console.WriteLine("this is automatic method..");
        }
        private void setRadius(int rad)//rad=19
        {
        r = rad; //r=19
        }
        public void calculateArea()//2
        {
             area = 3.14f * r * r;
        }
        public void showArea()//3
        {           
            Console.WriteLine("Area of Circle = "+area);
        }

    }
   class student  
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int total_marks { get; set; }

        public void setData(int r, string nm, int tm)
        {
            roll = r;
            name = nm;
            total_marks = tm;
        }
        public void showStudent()
        {
            Console.WriteLine($"Roll= {roll}\tName= {name}\tTotal Marks= {total_marks}");
        }
    }
    class aaa 
    {
        public void show()
        {
           // y = 888;
           // z = 444;
            //x = 42432;//not allowed in child class method
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //student ss = new student();
            //ss.setData(100, "Rajesh", 456);
            //ss.showStudent();
            int a = 111;
            Shape obj = new Shape(23);//object create  //default constructor //parameter less constructor
           // obj.setRadius(10);
            obj.calculateArea();
            obj.showArea();


            Shape obj2 = new Shape(12);// parameterised constructor
            //obj2.setRadius(13);
            obj2.calculateArea();
            obj2.showArea();

            StringBuilder sb=new StringBuilder()
        }
    }
}
