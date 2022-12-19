int counter = 5;

int a = 0; 

int b = 1;

int fibonacci(int before, int after, int counter)
{
    if(counter <= 0) return after;
    

    return fibonacci(after, before + after, counter - 1);
    
}

Console.WriteLine(fibonacci(a, b, counter));