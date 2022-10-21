//lerissa lazar
//10-19-22
//greater than or less than
//the user is asked to input 2 numbers and the computer will tell us if the numbers are greater than, less than or equal to.

Console.Clear();

int numOne = 0, numTwo = 0;
string symbolOne, symbolTwo;
bool validNumOne, validNumTwo;
bool loop = true;

while (loop)
{
    validNumOne = false;
    Console.WriteLine("What is your first number: ");
    while (!validNumOne)
    {
        validNumOne = Int32.TryParse(Console.ReadLine(), out numOne);
        if (!validNumOne)
        {
            Console.WriteLine("Invalid input, enter a number");
        }
    }

    validNumTwo = false;
    Console.WriteLine("What is your second number: ");
    while (!validNumTwo)
    {
        validNumTwo = Int32.TryParse(Console.ReadLine(), out numTwo);
        if (!validNumTwo)
        {
            Console.WriteLine("Invalid input, enter your second number");
        }
    }

    if (numOne > numTwo)
    {
        symbolOne = " greater than ";
        symbolTwo = " less than ";
    }
    else if (numOne < numTwo)
    {
        symbolOne = " less than ";
        symbolTwo = " greater than ";
    }
    else
    {
        symbolOne = " equal to ";
        symbolTwo = " equal to ";
    }

    if (validNumOne && validNumTwo)
    {
        Console.WriteLine("The number " + numOne + " is" + symbolOne + "the number " + numTwo);
        Console.WriteLine("The number " + numTwo + " is" + symbolTwo + "the number " + numOne);

        Console.WriteLine("Do you want to try again? Yes or No?");

        bool validLoopInput = false;
        while (!validLoopInput)
        {
            string loopInput = Console.ReadLine().ToLower();

            if (loopInput == "yes")
            {
                validLoopInput = true;
            }
            else if (loopInput == "no")
            {
                validLoopInput = true;
                loop = false;
                Console.WriteLine("Okay well bye now!");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter Yes or No");
            }
        }

    }
}