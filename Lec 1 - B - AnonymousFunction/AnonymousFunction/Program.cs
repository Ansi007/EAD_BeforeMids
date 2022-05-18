using MyNamespace;
Sir sir = new Sir();
sir.main();


Me me = new Me();
me.main();

namespace MyNamespace
{
    delegate void MyDelegate();
    delegate void MyDelegate2(int x);
    delegate int MyDelegate3(int x, int y);
    public class Sir
    {
        public void display()
        {
            Console.WriteLine("Hello!");
        }

        public void main()
        {
            display();
            MyDelegate d = new MyDelegate(display);
            d.Invoke();

            MyDelegate annonymousDeleagte = delegate {
                Console.WriteLine("AOA PAKISTAN!");
            };

            MyDelegate m = () =>
            {
                Console.WriteLine("Hello There");
            };

            MyDelegate3 m3 = (x, y) => x * y;

            annonymousDeleagte.DynamicInvoke();

            MyDelegate2 annonymousDelegate2 = delegate (int x)
            {
                Console.WriteLine("With Parameter: " + x);
            };
            annonymousDelegate2.DynamicInvoke(23);

            MyDelegate3 annonymousDelegate3 = delegate (int x, int y)
            {
                return x + y;
            };

            var x = annonymousDelegate3.DynamicInvoke(2, 4);
            Console.WriteLine("Returned: " + x);

            MyDelegate myDelegate = d;
            myDelegate.DynamicInvoke();

            MyDelegate2 annonymousDelegate4 = delegate(int x)
            {
                Console.WriteLine(x);
                MyDelegate2 annonymousDelegate5 = delegate (int y)
                {
                    Console.WriteLine(x + y);
                };
                annonymousDelegate5(4);
            };
            
           annonymousDelegate4.DynamicInvoke(2);

            MyDelegate3 lambdaDelegate = (int x, int y) =>  //lambda statements
            {
                int xA = 0;
                return 1 + xA;
            };

            lambdaDelegate.DynamicInvoke(10,10);

            MyDelegate3 doubleValue = (int x,int y) => x * y;
            Console.WriteLine(doubleValue.Invoke(2,5));


            // ----------------------------------------------------------------------------------------------------

            Action action1 = new Action(display);
            action1.Invoke();
            Action action2 = () => Console.WriteLine("ACTION EXPRESSION");
            action2.Invoke();
                
            Func<int> function1 = () => 2999;
            Console.WriteLine(function1.Invoke());
            
            Func<int, int, int> mulAandB = (a, b) => a * b;
            Console.WriteLine(mulAandB.Invoke(10,5));

            Func<Func<int>> myFunc = () =>
            {
                Func<int> f = () =>
                {
                    return 19405;
                };
                return f;
            };

            Func<int> FFF = myFunc.Invoke();
            Console.WriteLine(FFF.Invoke());

        }


    }

    public class Me
    {
        delegate void Count();  //10
        delegate void Count2(int a); //a
        delegate int Count3(int a); //a

        public void main()
        {
            Count countDelegate = delegate {
                Console.WriteLine("Count1: " + (10*(11))/2);
            };

            Count2 countDelegate2 = delegate (int a) {
                Console.WriteLine("Count2: " + (a*(a+1))/2);
            };

            Count3 countDelegate3 = delegate (int a) {
                 return (a*(a+1))/2;
            };
            countDelegate.DynamicInvoke();
            countDelegate2.DynamicInvoke(5);
            var x = countDelegate3.DynamicInvoke(7);
            Console.WriteLine("Count3: " + x);
        }
    }
}

//Can We DeRef one delegate and point it to other?
//E.g: D1 = new Delegate(f1);
//E.g: D2 = D1?
//Yes!!! Possible.

