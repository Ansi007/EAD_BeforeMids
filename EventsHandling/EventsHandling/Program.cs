using EventsHandler;
ArrayList arr = new ArrayList();
arr.add += delegate {
    Console.WriteLine("ADDED");
};
arr.Add(3);

Pub p = new Pub();
Sub s1 = new Sub();
Sub s2 = new Sub();

s1.Subscribe(p);
p.OnOccur();
s2.Subscribe(p); 
p.OnOccur();


namespace EventsHandler
{
    public delegate void MyEventHandler();
    public class Publisher { 
        public event MyEventHandler myEventHandler;
        public void OnEvent()
        {
            myEventHandler();
        }
    }
    public class Listener { 
    
    }
    public class MyButton
    {
        public event MyEventHandler click;  //defining events, Step # 01
        public event MyEventHandler rightClick; //defining
        public void OnClick() { //firing/raising, Step # 02
            click?.Invoke(); //GRAPESSSSSSS
        }
        public void OnRightClick()
        {
            if(rightClick != null) rightClick.Invoke();    //firing
        }
    }
    public class MyButtonListener
    {
        MyButton button;
       /* MyEventHandler Func = delegate
        {
            Console.WriteLine("AOA PAKISTAN");
        };*/

        Action Func2 = delegate
        {
            Console.WriteLine("AOA PAKISTAN");
        };
        public MyButtonListener() {
            button = new MyButton();
            button.click += () => Console.WriteLine("Lambda Statement"); //Registering an event.
            button.OnClick();
/*            button.rightClick += Func;
*/            button.rightClick += delegate {
                Console.WriteLine("AOA PAKISTAN");
            };
            button.OnRightClick();
        }
    }


    public class ArrayList : List<int>
    {
        public event MyEventHandler add;
        public void Add(int x)
        {
            add?.Invoke();
            base.Add(x);
        }   
        public void OnAdd()
        {
            if(add != null) add.Invoke(); 
        }
    }

    public class Pub
    {
        public event MyEventHandler myEvent;

        public void OnOccur()
        {
            myEvent?.Invoke();
        }
    }

    public class Sub
    {
        public void Subscribe(Pub p)
        {
            p.myEvent += () => Console.WriteLine("ABC");
        }
    }


}