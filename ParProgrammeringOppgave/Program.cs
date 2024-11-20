var input = Console.ReadLine();
var input2 = Console.ReadLine();
PrintText();
void PrintText()
{
    
    Console.WriteLine($"{input}");
    if(input2 == "1")
    {
        ReverseText();
    } 
    
}

void ReverseText()
{

    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[input.Length - i - 1]);
    }
    
}


