// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = 56;

if (number < 100)
{
    if (number is <= 80 and >= 60) { Console.WriteLine(number + " : 80 ile 60 arasında..."); }
    else if (number is <= 59 and >= 30) { Console.WriteLine(number + " : 50 ile 30 arasında..."); }
    else Console.WriteLine(number is <= 29 and >= 0 ? "29 ile sıfır arasında" : "sıfırdan küçük");
}
else { Console.WriteLine(number + " : sıfırdan küçük veya 100 den büyük"); }

Console.WriteLine("Switch!!!");
switch (number)
{
    case 10:
        Console.WriteLine(number);
        break;
    case 60:
        Console.WriteLine(number);
        break;
    default:
        Console.WriteLine(number + " : bu durumların dışında");
        break;
}