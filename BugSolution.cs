public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property in declaration

    public ExampleClass() // or in the constructor
    {
        MyProperty = 10;
    }

    public void MyMethod()
    {
        int value = MyProperty; 
        Console.WriteLine(value); // Output: 10 or 0, depending on whether a constructor is used
    }
}
//Another solution is to explicitly check if the property has been initialized before using it.
public class ExampleClass2
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        if(MyProperty == 0) // 0 is the default value
        {
            MyProperty = 10;
        }
        Console.WriteLine(MyProperty); //Output: 10
    }
}