// See https://aka.ms/new-console-template for more information

int GCF(int num1, int num2)
{
   int temp1 = num1;
   int temp2= num2;
    while (temp1 != temp2){
        if (temp1 > temp2){
            temp1 = temp1 - temp2;
        }
        else{
            temp2 = temp2 - temp1;
        }
    }
    int result = temp1;
    return result;
}


Console.WriteLine("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = GCF(num1, num2);
Console.WriteLine("the greatest common factor is " + result);

// Console.WriteLine("results of 12 and 39 is " + GCF(12,39));

// question 3.3 so that the program can still access the inital two numbers if needed


// TASK 2

Console.WriteLine("Enter a number to convert: ");
int decimalNum = Convert.ToInt32(Console.ReadLine());

// define a function that takes in an integer and return its binary value
int DentoBin(int decimalNum)
{
    int result = 0;
    while (decimalNum > 0)
    {
        result = result * 10 ;
        result = result + decimalNum % 2;
        decimalNum = decimalNum / 2;
    }
    return result;
}

Console.WriteLine("the binary value is " + DentoBin(decimalNum));


