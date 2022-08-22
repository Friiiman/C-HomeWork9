// ------------- ЗАДАЧИ -------------
// ----------------------------------

void Task1(){

    //  Задайте значения M и N. 
    // Напишите программу, которая выведет все натуральные числа кратные 3-ём 
    // в промежутке от M до N.

    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if(numberN <= numberM){
        Console.Write("Введено неверное значение числа N. Повторите попытку: ");
        numberN = Convert.ToInt32(Console.ReadLine());
    }
    RecursionTask1(numberM, numberN);
    Console.Write("\b\b.");
}

void Task2(){

    // Задайте значения M и N. 
    // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if(numberN <= numberM){
        Console.Write("Введено неверное значение числа N. Повторите попытку: ");
        numberN = Convert.ToInt32(Console.ReadLine());
    }
    RecursionTask2(numberM, numberN);
}

void Task3(){

    // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    // Даны два неотрицательных числа m и n.

    Console.Write("Введите число M: ");
    int numberM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.Write("Введите число N: ");
    int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine($"A({numberM}, {numberN}) = {Ackermann(numberM, numberN)}");
}

// ------------- МЕТОДЫ -------------
// ----------------------------------

void RecursionTask1(int m, int n){
    if(m > n){
        return;
    }
    if(m % 3 == 0){
        Console.Write(m + ", ");
    }
    m++;
    RecursionTask1(m, n);
}

void RecursionTask2(int m, int n, int sum = 0){
    if(m > n){
        Console.Write(sum);
        return;
    }
    sum += m;
    m++;
    RecursionTask2(m, n, sum);
}

int Ackermann(int m, int n){
    if(m == 0){
        return n + 1;
    }
    else{
        if((m != 0) && (n == 0)){
            return Ackermann(m - 1, 1);
        }
        else{
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}

// ------------- ВЫВОД РЕШЕНИЯ ЗАДАЧ -------------
// -----------------------------------------------

Task1();
// Task2();
// Task3();
