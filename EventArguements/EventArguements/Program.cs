using System.Collections;


MyArrayList myArrayList = new MyArrayList();
myArrayList.Added += delegate (object sender, MyEventArgs e)
{
    Console.Write(e.Count + " ");
    Console.WriteLine(e.Val);
};

myArrayList.Add(1);
myArrayList.Add(2);
myArrayList.Add("3");
myArrayList.Add('5');
myArrayList.Add(6.94);

class MyEventArgs : EventArgs
{
    public int Count { get; set; }
    public object Val { get; set; }
    public MyEventArgs(int c, object v)
    {
        Count = c;
        Val = v;
    }
}


delegate void EventHandler(object sender, MyEventArgs e);
class MyArrayList : ArrayList
{
    public event EventHandler Added;
    public void OnAdded(object val)
    {
        Added(this, new MyEventArgs(Count,val));
    }
    public override int Add(object? value)
    {
        int x = base.Add(value);
        OnAdded(value);
        return x;
    }

}

/*using System.Collections;


MyArrayList myArrayList = new MyArrayList();
myArrayList.Added += delegate (object sender, MyEventArgs e)
{
    Console.WriteLine(e.Count);
};
myArrayList.Add(1);
myArrayList.Add(2);


class MyEventArgs : EventArgs
{
    public int Count { get; set; }
    public MyEventArgs(int c)
    {
        Count = c;
    }
}


delegate void EventHandler(object sender, MyEventArgs e);
class MyArrayList : ArrayList
{
    public event EventHandler Added;
    public void OnAdded()
    {
        Added(this, new MyEventArgs(Count));
    }
    public override int Add(object? value)
    {
        int x = base.Add(value);
        OnAdded();
        return x;
    }

}*/