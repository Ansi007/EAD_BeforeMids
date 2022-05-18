MyDelegate d = delegate
{
    Console.WriteLine("Hello 1");
};

MyDelegate2 d2 = (x) =>
{
    Console.WriteLine($"Hello {x}");
};

d();
d2(4);
Operation op = new Operation();
char inp = Console.ReadKey().KeyChar;
var func = op.Allot(inp);
if(func != null) func(5,5);

Action a = () => Console.WriteLine("ACB");
Action<int> b = (x) => Console.WriteLine("ACB");
Func<int> c = () => 3;

c();

Publisher p = new Publisher();
p.RightClick += () => Console.WriteLine("A");
p.OnRightClick();

realDelegate ds = delegate {
    
};

ds("this", new myevents());

delegate void MyDelegate();
delegate void MyDelegate2(int x);
delegate int MyDelegate3(int x);
delegate void realDelegate(object sender, EventArgs e);

class Operation
{
    public delegate void MathOperation(int a, int b);

    void Add(int a , int b)
    {
        Console.WriteLine(a + b);
    }

    void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    void Mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    void Div(int a, int b)
    {
        Console.WriteLine(a / b);
    }

    public MathOperation Allot(char s)
    {
        MathOperation m = null;
        switch (s)
        {
            case '+':
                m = Add;
                break;

            case '-':
                m = Sub;
                break;

            case '*':
                m = Mul;
                break;

            case '/':
                m = Div;
                break;
        }
        return m;
    }
}
public delegate void MyEventHandler();

class Publisher
{
    public event MyDelegate RightClick;
    //Defining
    public void OnRightClick()//Raising
    {
        if (RightClick != null)
            RightClick();
    }
};

class Subscriber
{
    public Subscriber(Publisher p)
    {
        p.RightClick += () => Console.WriteLine("Right Clicked");
    }
};

class myevents : EventArgs
{
    public int value;
    public string name;
}