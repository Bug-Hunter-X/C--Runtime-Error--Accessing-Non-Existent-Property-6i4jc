public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-existent property will throw a runtime exception.
        int value = this.NonExistentProperty; 
    }
}