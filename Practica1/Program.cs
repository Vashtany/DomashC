//2. напишите программу которая на вход принимает два числа ,
//и выдает какое число больше ,а какое меньше.

void Task2()
{
    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
         Console.Write(num1+">"+ num2);
    }
    else
    {
         Console.Write(num1+"<"+ num2);
    }
}

// 4. Напишите программу , которая принимает на вход три числа и выдает максимально из этих чисел.

void Task4()
{
    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int num3 = Convert.ToInt32(Console.ReadLine());
    
    int max = num1;
    
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

     Console.Write("Максимальное число" + " " + (max) );

} 

//6....принимает число и выдает чет/нечет.

void Task6()
{
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x%2==0)
    {
        Console.Write("Данное число чётное");
    }
    else
    {
        Console.Write("Данное число нечётное");
    }
  
}


void Task8()
{
    //8...Принимает число (N>0),на выходе показывает все четные числа от 1 до N (пример 5->2.4)
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    int counter = 1;

    while (counter <= num)
    {
        if (counter%2==0)
        Console.Write(counter + " ");
        counter++;

    }

}
// 


Task8();

