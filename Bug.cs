public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that has not been initialized will result in a default value (0 for int)
        int value = MyProperty; 

        // However, if you try to access it before it's been initialized or assigned a value, you get a default value (0 for int) instead of an error.
        Console.WriteLine(value); // Output: 0

        //Uninitialized variable error:
        //int uninitializedVariable;
        //Console.WriteLine(uninitializedVariable); // This will throw a compile-time error: Use of unassigned local variable 'uninitializedVariable'
    }
}