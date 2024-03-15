//int num = Convert.ToInt32(Console.ReadLine());
//if (num < 15)
//{
//    Console.WriteLine("Hava soyuqdur");
//}
//else
//{
//    Console.WriteLine("Hava istidir");
//}




//______________________________________________________________________________________________________________




//console.writeline("ay daxil et:");
//string mounth = convert.tostring(console.readline());

//switch(mounth)
//{
//    case "yanvar":
//    case "mart":
//    case "may":
//    case "iyul":
//    case "avqust":
//    case "oktyabr":
//    case "dekabr":
//        console.writeline("31");
//        break;

//    case "aprel":
//    case "iyun":
//    case "sentyabr":
//    case "noyabr":
//        console.writeline("30");
//        break;
//    case "fevral":
//        console.writeline("29");
//        break;
//}




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//int res = 1;

//if (num % 2 == 0)
//{
//    for (int i = 0; 0 < num; num--)
//    {
//        res *= num;
//    }
//    Console.WriteLine(res);
//}
//else
//{
//    Console.WriteLine("Musbet deyil");
//}




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//bool res = false;

//if (2 > num)
//{
//    Console.WriteLine("Ne sade Ne murekkeb");
//}
//else
//{
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0)
//        {
//            res = true;
//            break;
//        }


//    }
//    if (res)
//    {
//        Console.WriteLine("murekkebdir");
//    }
//    else
//    {
//        Console.WriteLine("Sade");
//    }
//}




//______________________________________________________________________________________________________________




//int[] arr = { 32, 56, 5, 9, 1, 3 };
//int res = 0;

//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//    {
//        res += arr[i];
//    }
//}

//Console.WriteLine(res);




//______________________________________________________________________________________________________________




//int[] arr = { 32, 56, 5, 9, 1, 3 };
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (max < arr[i])
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//int end = 0;
//int end1 = 0;
//int first = num;
//int second = num;
//int count = 0;

//while (first % 10 != 0)
//{
//    end = first % 10;
//    while (second % 10 != 0)
//    {
//        end1= second % 10;
//        if (end == end1)
//        {
//            count++;
//        }
//        second= second / 10;
//    }
//    first = first/10;
//}
//if (count  == num.ToString().Length)
//{
//    Console.WriteLine("tekrar");
//}
//else
//{
//    Console.WriteLine("deyil");
//}




//______________________________________________________________________________________________________________



//bool res = true;
//int num = Convert.ToInt32(Console.ReadLine());
//int count = -1;

//for (int i = 1; res; i *= 2)
//{
//    count++;
//    if (i == num)
//    {
//        Console.WriteLine(count);
//        res = false;
//    }
//    else if (i > num)
//    {


//        if (num - i / 2 > (num - i) * -1)
//        {
//            Console.WriteLine(count);
//            res = false;
//        }
//        else
//        {
//            Console.WriteLine(count - 1);
//            res = false;
//        }

//    }
//}




//______________________________________________________________________________________________________________



//int num = Convert.ToInt32(Console.ReadLine());
//int res = 0;

//while (num % 10 != 0)
//{
//    res = (num % 10) + res;
//    num/= 10;
//}
//Console.WriteLine(res);




//______________________________________________________________________________________________________________




//int[] arr = { 13, 6, 54, 91, 12, 345,42,2 };
//int min = arr[0];

//for (int i = 0; i < arr.Length; i++)
//{
//    if (min > arr[i])
//    {
//        min = arr[i];
//    }
//}

//Console.WriteLine(min);




//______________________________________________________________________________________________________________




//int[] arr = { 13, 6, 54, 91, 12, 345, 42, 2, 9, 1 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 10)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);




//______________________________________________________________________________________________________________




//int num = 36;

//if (num % 10 > num / 10)
//{
//    Console.WriteLine("Teklik boyukdur");
//}
//else if (num % 10 == num / 10)
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine("Onluq boyukdur");
//}




//______________________________________________________________________________________________________________






//int[] arr = { 13, 6, 54, 91, 12, 345, 42, 2 };
//int min = 0;
//int max = 0;
//int par = 0;



//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[min] > arr[i])
//    {
//        min = i;
//    }
//    if (arr[max] < arr[i])
//    {
//        max = i;
//    }

//}

//par = min;
//arr[min] = arr[max];
//arr[max] = arr[par];


//______________________________________________________________________________________________________________





//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//while (num % 10 != 0)
//{
//    count++;
//    num/= 10;
//}

//Console.WriteLine(count);




//______________________________________________________________________________________________________________




//int num = 5353;
//int newNum = 7 * 100000 + num * 10 + 8;
//Console.WriteLine(newNum);




//______________________________________________________________________________________________________________




//int num = 535;
//int newnum = num+num*1000;
//Console.WriteLine(newnum);




//______________________________________________________________________________________________________________




//int num = 434;
//int newnum = (num * 10 + 7) * 7 / 100;
//Console.WriteLine(newnum);




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("cut");
//}
//else if (num == 0)
//{
//    Console.WriteLine("Ne cut ne tek");
//}
//else
//{
//    Console.WriteLine("Tek");
//}




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 21 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}




//______________________________________________________________________________________________________________




//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine(num1);
//}
//else if (num1 == num2)
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine(num2);
//}




//______________________________________________________________________________________________________________




//string[] arr = { "fsdsfas", "3df3", "AB106", "safaf1" };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        Console.WriteLine("Var");
//    }
//    else
//    {
//        Console.WriteLine("yoxdur");
//    }
//}




//______________________________________________________________________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//for (int i = 1; i < num; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);











//int num = 5353;
//int newNum = 7 * 100000 + num * 10 + 8;
//Console.WriteLine(newNum);





//int num = Convert.ToInt32(Console.ReadLine())*10;
//int whl = num;
//int x = 7;

//while (whl != 0)
//{
//    x *= 10;
//    whl /= 10;
//}
//Console.WriteLine((x+num)+8);






//int num = Convert.ToInt32(Console.ReadLine());
//int whl = num;


//while (whl != 0)
//{
//    num *= 10;
//    whl /= 10;
//}





//bool res = true;
//int num = Convert.ToInt32(Console.ReadLine());
//int count = -1;

//for (int i = 1; res; i *= 2)
//{
//    count++;
//    if (i == num)
//    {
//        Console.WriteLine(count);
//        res = false;
//    }
//    else if (i > num)
//    {


//        if (num - i / 2 > (num - i) * -1)
//        {
//            Console.WriteLine(count);
//            res = false;
//        }
//        else
//        {
//            Console.WriteLine(count - 1);
//            res = false;
//        }

//    }
//}



int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int res = 1;


while (num != 0)
{
    count++;
    res *= 2;
    if (num == res)
    {
        Console.WriteLine(count);
        break;
    }
    else if (num - res < res * 2 - num)
    {
        Console.WriteLine(count);
        break;
    }
    else
    {
        Console.WriteLine(count+1);
        break;
    }
    
    num /= 2;
    

}
