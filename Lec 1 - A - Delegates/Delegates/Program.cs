MyDelegate m1 = new MyDelegate(display);
MyDelegate2 m2 = new MyDelegate2(display2);
Console.WriteLine(m1.Method);
Console.WriteLine(m1.Target);
m1.Invoke();
display();
m2.Invoke("GGWWPPP");
m1 += f1;
Console.WriteLine(m1.Method);
m1.Invoke();
m1.GetInvocationList();
/*
MathOperation d = new MathOperation(Add);
var x = d.Invoke(2, 2);
Console.WriteLine(x);
d += Sub;
x = d.Invoke(2,2);
Console.WriteLine(x);

MyDelegate3 X = new MyDelegate3(func);

*/

Library l = new Library();
var input = Console.ReadLine();
var x = l.operation(input);
if (x != null)
{
    Console.WriteLine(x.Invoke(2,3));
}

void display()
{
    Console.WriteLine("AOA PAKISTAN!!!");
}

void display2(string s)
{
    Console.WriteLine(s);
}

static void f1()
{
    Console.WriteLine("AOA PAKISTAN!!!");
}

static void f2(string s)
{
    Console.WriteLine(s);
}

int Add(int a, int b)
{
    return (a + b);
}

int Sub(int a, int b)
{
    return (a - b);
}

int Mul(int a, int b)
{
    return (a * b);
}

int Div(int a, int b)
{
    return (a / b);
}

void func(params int[] x) { }


delegate void MyDelegate();
delegate void MyDelegate2(string s);
delegate void MyDelegate3(params int[] a);
//Top Level Statements

public class Library
{
    public delegate int MathOperation(int a, int b);
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a + b;
    }
    public int Mul(int a, int b)
    {
        return a + b;
    }
    public int Div(int a, int b)
    {
        return a + b;
    }

    public MathOperation operation(string x)
    {
        MathOperation m = null;
        switch (x)
        {
            case "+":
                m = Add;
                break;
             case "-":
                m = Sub;
                break;
            case "*":
                m = Mul;
                break;
            case "/":
                m = Div;
                break;
        }
        return m;
    }
}