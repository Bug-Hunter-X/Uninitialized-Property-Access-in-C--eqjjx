public class ExampleClass{
    public int MyProperty { get; set; } = 0; // Initialized with a default value of 0

    public void MyMethod(){
        // Accessing a property that has now been initialized.
        int value = MyProperty * 2; 
    }
}