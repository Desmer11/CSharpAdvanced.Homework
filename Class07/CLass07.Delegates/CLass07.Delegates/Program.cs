
void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");

}
void Greeting(string name, PrintingDelegate printingDelegate)
{
    printingDelegate(name);
}

Greeting("Marko", SayHello);
Greeting("Ana", x=>Console.WriteLine($"Hello {x}"));

int Sum(int num1, int num2)
{
    return num1 + num2;
}
int Substract(int num1, int num2)
{
    return num1 - num2;
}


void PrintResult(int num1, int num2, NumberDelegate numberDelegate)
{
    int result = numberDelegate(num1, num2);

    Console.WriteLine($"Result: {num1}  {num2} "+result);
}
PrintResult(3, 4, Sum);
PrintResult(3, 4, Substract);

NumberDelegate numberDelegate = new NumberDelegate(Sum);
numberDelegate(3,4);

// Declare delegate 
// Each delegate defines a signature of given method 
// used to save method
//when we encounter the PrintingDelegate 
// Expect a void method with One string 
delegate void PrintingDelegate(string name);
delegate int NumberDelegate(int num1, int num2);







