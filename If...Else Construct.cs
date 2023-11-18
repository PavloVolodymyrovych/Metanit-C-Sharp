//https://metanit.com/sharp/practice/1.1.php

/*PART 1*/
//Console.Write("Number A: ");
//string numA = Console.ReadLine();
//Console.Write("Number B: ");
//string numB = Console.ReadLine();

//if (Convert.ToInt32(numA) == Convert.ToInt32(numB))
//    Console.WriteLine($"Значение А равно значению В: {numA}={numB}");
//else if(Convert.ToInt32(numA) > Convert.ToInt32(numB))
//    Console.WriteLine($"Значение А больше значения В: {numA}>{numB}");
//else if (Convert.ToInt32(numA) < Convert.ToInt32(numB))
//    Console.WriteLine($"Значение А меньше значения В: {numA}<{numB}");


/*PART 2*/
//Console.Write("Enter number: ");
//string num = Console.ReadLine();

//if(Convert.ToInt32(num) > 5 && Convert.ToInt32(num) < 10)
//{
//    Console.WriteLine("Число больше 5 и меньше 10");
//}
//else
//{
//    Console.WriteLine("Неизвестное число");
//}


/*PART 3*/
//Console.Write("Enter you deposit amount: ");
//double depositAmount = Convert.ToDouble(Console.ReadLine());
//if(depositAmount < 100)
//{
//    depositAmount += (5 * depositAmount) / 100; //* 0.05;
//}
//else if (depositAmount >= 100 && depositAmount <= 200)
//{
//    depositAmount += (7 * depositAmount) / 100; //* 0.07;
//}
//else if(depositAmount > 200)
//{
//    depositAmount += (10 * depositAmount) / 100; //* 0.1;
//}
//Console.WriteLine($"Summ deposit: {depositAmount}");


/*PART 4*/
//Console.Write("Enter you deposit amount: ");
//double depositAmount = Convert.ToDouble(Console.ReadLine());
//if (depositAmount < 100)
//{
//    depositAmount += (5 * depositAmount) / 100; //* 0.05;
//}
//else if (depositAmount >= 100 && depositAmount <= 200)
//{
//    depositAmount += (7 * depositAmount) / 100; //* 0.07;
//}
//else if (depositAmount > 200)
//{
//    depositAmount += (10 * depositAmount) / 100; //* 0.1;
//}
//Console.WriteLine($"Summ deposit: {depositAmount + 15}");


/*PART 5*/
//Console.Write("Введите математическую операцию |* / + -|: ");
//char mathSymbol = Convert.ToChar(Console.ReadLine());
//Console.Write("\nВведите число a: ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.Write("\nВведите число b: ");
//double b = Convert.ToDouble(Console.ReadLine());
//switch (mathSymbol)
//{
//    case '*':
//        Console.WriteLine($"Результат умножения: {a} * {b} = {a*b}");
//        break;
//    case '/':
//        Console.WriteLine($"Результат деления: {a} / {b} = {a/b}");
//        break;
//    case '+':
//        Console.WriteLine($"Результат сложения: {a} + {b} = {a + b}");
//        break;
//    case '-':
//        Console.WriteLine($"Результат вычитания: {a} - {b} = {a - b}");
//        break;
//    default:
//        Console.WriteLine("Было допущено ошибку при выборе операции.");
//        break;
//}
