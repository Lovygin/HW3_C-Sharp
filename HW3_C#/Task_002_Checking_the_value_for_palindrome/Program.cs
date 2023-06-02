/*Console.Clear();
Console.WriteLine("Please, enter a integer number for check for palindrome");
//"Введите 5ти значное просто число разделяя запятыми (seprated by commans) для проверки на палиндромность.
string inputString = Console.ReadLine();
string[] inputArray = inputString.Split(", ");//Преобразование строки в отдельные элементны массива строк путем разделения (NameString.Split(", "));
foreach(string element in inputArray)//Перебирает массив inputArray и перекладывает в массив element, чтобы его можно было вывести на экран и с ним взаимодействовать.
{
    if(element.Length % 2 == 0)//Прверка на четность массива
    {
        for(int i = 0; i <= element.Length/2; i++)
        {
            if(element[i] == element[element.Length - i - 1])
            {
                Console.WriteLine("This value is the palindrome");
            }
            else
            {
                Console.WriteLine("This value is not the palindrome");
            }
        }
    } 
    else
    {
       for(int i = 0; i <= (element.Length - 1)/2; i++)
        {
            if(element[i] == element[element.Length - i - 1])
            {
                Console.WriteLine("This value is the palindrome");
            }
            else
            {
                Console.WriteLine("This value is not the palindrome");
            }
        } 
    }   
}*/

Console.Clear();
Console.WriteLine("Please, enter a integer number for check for palindrome");
string inputString = Console.ReadLine();
string[] inputArray = inputString.Split(", ");
foreach( string element in inputArray)//не нужнг проверять длину массива на четность, так при нецелочисленном результате деления на 2, результат будет округлен в меньшую сторону.
{
    bool isPalindrome = true;
    for(int i = 0; i < element.Length / 2; i++)
    {
        if (element[i] != element[element.Length - i - 1])
        {
            isPalindrome = false;
            break;
        }
    }
    if(isPalindrome)
    {
       Console.WriteLine("This value is the palindrome"); 
    }
    else
    {
       Console.WriteLine("This value is not the palindrome"); 
    }
}
