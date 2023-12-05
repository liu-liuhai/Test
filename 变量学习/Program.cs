using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace 变量学习
{
    internal class Program
    {


        static void Main(string[] args)
        {


            //char a = 'r';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a = 97;
            //char b = (char)a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //char a = 'b';
            //int b = a;
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //int a = 1;
            //char b = (char)a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int b = 8;
            //int c = 9;

            //Console.WriteLine(b);
            //string str = @"www.baidu.com.\nwww";
            //Console.WriteLine(@"www.baidu.com.\nwww");

            //char a = '1';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int c = 18;
            //string str = "www.jjy.com";

            //string ing = "123" + "456";
            //string ing2 = ing + "cpm";
            //Console.WriteLine(ing2);

            //double a = 1.8;
            //double b =2+a ;
            //Console.WriteLine(b);

            //string str = Console.ReadLine();
            //Console.WriteLine(str);

            //int m = 80;double a = 10;
            //bool bol = m > 90 && m < 70;
            //if ( bol = m > 90 && m < 70)
            //{
            //    Console.WriteLine(m);
            //}
            //else
            //{
            //    Console.WriteLine(bol);
            //}


            //double b;
            //Console.Write("请输入你的值：");
            //b= Convert.ToDouble(Console.ReadLine());
            //if (b % 2 == 1)
            //{
            //    Console.WriteLine("你输入的数据是奇数");

            //}
            //else
            //{
            //    Console.WriteLine("你输入的数据是偶数");
            //}

            //int age;
            //Console.WriteLine("请输入你的年龄：");

            //age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18 && age <= 60)
            //{
            //    Console.WriteLine("年龄符合，可以接种");
            //}
            //else
            //{
            //    Console.WriteLine("年龄不符合，不可以接种");
            //}

            //int a,b,c;

            //Console.Write("请输入a的值：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入b的值：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入c的值：");
            //c = Convert.ToInt32(Console.ReadLine());

            //double result;
            //result = (b * b) - (4 * a * c);
            //if(result > 0)
            //{
            //    Console.WriteLine("该方程有两个解");
            //}
            //else if(result < 0)
            //{
            //    Console.WriteLine("该方程无解");
            //}
            //else
            //{
            //    Console.WriteLine("该方程只有一个解");
            //}


            //int year;
            //Console.Write("请输入年份：");
            //year = Convert.ToInt32(Console.ReadLine());
            //if (year % 400 == 0)
            //{
            //    Console.WriteLine("该年为闰年");

            //}
            //else 
            //{
            //    if (year % 4 == 0 && year % 100 != 0)
            //    {
            //        Console.WriteLine("该年为闰年");
            //    }
            //    else
            //    {
            //        Console.WriteLine("该年为平年");
            //    }
            // }

            //double w;
            //Console.Write("请输入货物重量：");
            //w = Convert.ToDouble(Console.ReadLine());
            //if (w > 0 && w <= 1)
            //{
            //    Console.WriteLine("快递费为3.5元");
            //}
            //else if (w > 1 && w <= 3)
            //{
            //    Console.WriteLine("快递费为5.5元");
            //}
            //else if (w > 3 && w <= 10)
            //{
            //    Console.WriteLine("快递费为8.5元");
            //}
            //else
            //{
            //    Console.WriteLine("快递费为10.5");
            //}

            //int a = 1;
            //int b = 2;
            //int c = a + b;
            //Console.WriteLine(c);




            //double grade;
            //Console.Write("请输入成绩：");
            //grade = Convert.ToDouble(Console.ReadLine());
            //if (grade >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (grade >= 60 && grade < 89)
            //{
            //    Console.WriteLine("B");
            //}
            //else
            //{
            //    Console.WriteLine("C");
            //}





            //for (int i = 101; i <= 200; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //    {
            //        return false;
            //    }
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;







            //string score;
            //score = Console.ReadLine();
            //switch (score)
            //{
            //    case "yiben":
            //        Console.WriteLine("555");
            //        break;
            //    case "erben":
            //        Console.WriteLine("440");
            //        break;
            //    case "yishu":
            //        Console.WriteLine("290");
            //        break;
            //    case "tiyu":
            //        Console.WriteLine("280");
            //        break;
            //    default:
            //        Console.WriteLine("!!!");
            //        break;

            //}


            ////彩票兑换
            //int lottery = new Random().Next(0, 99);
            //int number1 = lottery / 10;
            //int number2 = lottery % 10;
            //Console.Write("请输入两个数字：");
            //int guess;
            //guess = Convert.ToInt32(Console.ReadLine());
            //int number3 = guess / 10;
            //int number4 = guess % 10;
            //if (number1 == number3 && number2 == number4)
            //{
            //    Console.WriteLine("一等奖，奖励1000元");
            //}
            //else if (number1 == number4 && number2 == number3)
            //{
            //    Console.WriteLine("二等奖，奖励500元");

            //}
            //else if (number1 == number3 || number1 == number4 || number2 == number3 || number2 == number4)
            //{
            //    Console.WriteLine("三等奖，奖励200元");

            //}
            //else
            //{
            //    Console.WriteLine("很遗憾，您没有中奖");
            //}



            ////温度转换
            //double Celsius;
            //Celsius = Convert.ToDouble(Console.ReadLine());
            //double Fahrenheit;
            //Fahrenheit = (9 / 5) * Celsius + 32;
            //Console.WriteLine(Fahrenheit);


            ////圆柱体积
            //double height;
            //Console.Write("请输入高：");
            //height = Convert.ToDouble(Console.ReadLine());
            //double r;
            //Console.Write("请输入半径：");
            //r = Convert.ToDouble(Console.ReadLine());
            //double v;
            //v = Math.PI * r * r * height;
            //Console.WriteLine(v);


            ////方程
            //int a, b, c; 
            //Console.Write("请输入a的值：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入b的值：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入c的值：");
            //c = Convert.ToInt32(Console.ReadLine());
            //int d, e, f;
            //Console.Write("请输入d的值：");
            //d = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入e的值：");
            //e = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入f的值：");
            //f = Convert.ToInt32(Console.ReadLine());
            //double x, y;
            //x = (e * d - b * f) / (a * d - b * c);
            //y = (a * f - e * c) / (a * d - b * c);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //ClassMates();
            //Course();
            //Work();
            //LoopNest();
            //LoopNest();
            //HotelReservation();
            crossArray();
        }
        public static void Course()
        {
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("我爱学习c#");
            //    i++;
            //} while (i <= 100);
            //Console.WriteLine("Over");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1, res = 0;
            //do
            //{
            //    res += i;
            //    i++;
            //} while (i < n);
            //Console.WriteLine(res);


            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1; int res = 1;
            //do
            //{
            //    res = res * i;
            //    i++;
            //} while (i < n);
            //Console.WriteLine(res);


            //Console.Write("请输入班级人数：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double res = 0; int i = 1;

            //do
            //{
            //    res += Convert.ToInt32(Console.ReadLine());
            //    i++;

            //}
            //while (i <= n);
            //Console.WriteLine("班级平均年龄是：" + res / n);



            //int a, b, c;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine($"{c},{b},{a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b},{c},{a}");
            //    }
            //}
            //else if (b > a && b > c)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine($"{c},{a},{b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a},{c},{b}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{c},{b},{a}");
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine("我爱学习");
            //}
            //Console.WriteLine("执行完毕...");


            //for (int t = 1; t <= 100; t++)
            //{
            //    total += t;
            //}
            //Console.WriteLine("累加的结果是：" + total);

            //int res = 1;
            //for (int g = 1; g <= 100; g++)
            //{
            //    res *= g;
            //}
            //Console.WriteLine("累乘的结果是：" + res);

            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n <= 0)
            //{
            //    Console.WriteLine("你输入的值不符合，请重新输入：");
            //    n = Convert.ToInt32(Console.ReadLine());
            //}
            //int total = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    total += Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("班级平均年龄为：" + total / n);


            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{j} * {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}


            //int i ;
            //int n = Convert.ToInt32(Console.ReadLine());
            //int res = 0;
            //for(i = 0; i <= n; i++) 
            //{
            //    res += i;
            //}
            //Console.WriteLine(res);
        }

      
       
        static public void Work()
        {
            ////元音字母"if"判断
            //Console.Write("请输入一个英文字母：");
            //char t = Convert.ToChar(Console.ReadLine());
            //if (t =='a'||t=='e'||t=='i'||t=='o'||t=='u')
            //{
            //    Console.WriteLine("你输入的字母是一个元音字母");
            //}
            //else
            //{
            //    Console.WriteLine("你输入的不是元音字母");
            //}

            ////元音字母“switch”判断
            //Console.WriteLine("请输入一个英文字母：");
            //char y= Convert.ToChar(Console.ReadLine());
            //switch (y)
            //{
            //    case 'a':
            //        Console.WriteLine("元音字母");
            //        break;
            //    case 'e':
            //        Console.WriteLine("元音字母");
            //        break;
            //    case 'i':
            //        Console.WriteLine("元音字母");
            //        break;
            //    case 'o':
            //        Console.WriteLine("元音字母");
            //        break;
            //    case 'u':
            //        Console.WriteLine("元音字母");
            //        break;
            //    default:
            //        Console.WriteLine("该字母不是元音字母");
            //        break;
            //}


            //百分制转换等级
            //Console.Write("请输入百分制数：");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a <= 60)
            //{
            //    Console.WriteLine("该数等级为D");

            //}
            //else if (a > 60 && a <= 70)
            //{
            //    Console.WriteLine("该数等级为C");

            //}
            //else if (a > 70 && a <= 80)
            //{
            //    Console.WriteLine("该数等级为B");

            //}
            //else if (a > 80 && a <= 100)
            //{
            //    Console.WriteLine("该数等级为A");

            //}
            //else
            //{
            //    Console.WriteLine("你输入的数不符合，请重新输入...");

            //}

           
        }

        static public void LoopNest()
        {
            //int res = 0;
            //for(int i = 1;i<=3;i++)
            //{
            //    for(int j = 1; j <= 2; j++)
            //    {
            //        res += j;
            //    }

            //}
            //Console.WriteLine(res);

            //int res = 0;
            //for(int i = 0;i<1000;i++)
            //{
            //    res += i;
            //    if (res > 10000)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            //int i = 1; int res = 0;
            //for (i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    res += i;
            //}
            //Console.WriteLine(res);


            //int h = 1;int res1 = 0;
            //for(h = 1; h <= 100; h++)
            //{
            //    if (h % 2 == 0)
            //    {
            //        continue;
            //    }
            //    res1 += h;

            //}
            //Console.WriteLine(res1);


            //找出前50个素数
            //bool flog;
            //for (int h = 2,count=0; count<50 ; h++)
            //{
            //    flog = true;
            //    for (int i = 2; i < h; i++)
            //    {
            //        if (h % i == 0)
            //        {
            //            flog = false;
            //            break;
            //        }

            //    }
            //    if (flog)
            //    {
            //        count++;
            //        Console.Write("{0}\t",h);
            //        if (count % 10 == 0)
            //        {
            //            Console.WriteLine();
            //        }

            //    }

            //计算班级平均年龄
            //int res = 0;
            //Console.Write("请输入一个值：");
            //int count = Convert.ToInt32(Console.ReadLine());
            //if (count <= 0)
            //{
            //    for (; ;)
            //    {
            //        Console.WriteLine("你输入的值不符合，请重新输入一个值：");
            //        count = Convert.ToInt32(Console.ReadLine());
            //        if (count > 0)
            //        {
            //            break;
            //        }
            //    }
            //    for (int i = 1; i <= count; i++)
            //    {
            //        res += Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("班级平均年龄为:"+res/count);
            //}
            //else
            //{
            //    for(int i =1;i<= count; i++)
            //    {
            //        res += Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("班级平均年龄为:"+res/count);
            //}

            ////水仙花数
            //int i = 0, ge, shi, bai;
            //for (i = 100; i < 1000; i++)
            //{
            //    ge = i % 10;
            //    shi = i / 10 % 10;
            //    bai = i / 100;
            //    if (i == ge * ge * ge + shi * shi * shi + bai * bai * bai)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // 学费计算
            //double totalMoney = 10000.0;
            //int i = 1;
            //Console.Write("请输入要计算的年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //while (i <= year)
            //{
            //    totalMoney *= (1 + 0.05);
            //    i++;
            //}
            //Console.WriteLine("该年应缴费：" + totalMoney + "元");

            //猴子吃桃
            int day;
            int total;
            int peachCount = 1;
            for (day = 9; day >= 1; day--)
            {
                total = (peachCount + 1) * 2;
                peachCount = total;
            }
            Console.WriteLine("猴子第一天采了" + peachCount + "只桃子。");
        }

        //数组
        //public static void shuzu()
        //{

        //Console.Write("请输入一个值：");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] arr;
        //while (n <= 0)
        //{
        //    Console.Write("输入数值错误，请重新输入：");
        //}
        //Console.WriteLine("输入的值正确，进行下一步操作。");
        //arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int m = arr[0]; int dex = 0;
        //for (int i = 1; i < n; i++)
        //{
        //    if (m > arr[i])
        //    {
        //        m = arr[i];
        //        dex = i;
        //    }

        //}
        //Console.WriteLine($"数组最小值是{m},最小值的索引为{dex}");


        //Console.WriteLine("请输入班级人数：");
        //int t = Convert.ToInt32(Console.ReadLine());
        //int[] age; int res = 0;
        //while (t <= 0)
        //{
        //    Console.Write("输入值错误，请重新输入一个正确的值：");
        //}
        //Console.WriteLine("输入正确，继续执行以下程序");
        //age = new int[t];
        //Console.WriteLine("");
        //for (int i = 0; i < age.Length; i++)
        //{
        //    age[i] = Convert.ToInt32(Console.ReadLine());
        //    res += age[i];
        //}
        //double ave = res / (t * 1.0);
        //for (int i = 0; i < age.Length; i++)
        //{
        //    if (age[i] > ave)
        //    {
        //        Console.WriteLine(age[i]);
        //    }
        //}


        //int[] month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //for (int i = 0; i < month.Length; i++)
        //{
        //    int month1 = month[i];
        //    Console.WriteLine(month1);
        //}

        //}
        //static public void Bubblesort()
        //{
        //    int[] arr = new int[9] { 8,5,78,18,65,98,100,25,74 };
        //    for(int i = 0;i<arr.Length-1;i++)
        //    {
        //        for(int j = 0; j < arr.Length-1-i; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp;
        //                temp = arr[j];
        //                arr[j ]= arr[j + 1];
        //                arr[j+1] = temp;

        //            }
        //        }
        //    }
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]+",");
        //    }


        //}
        //static public void Chosesort()
        //{
        //    int[] arr = new int[9] { 8, 5, 78, 18, 65, 98, 100, 25, 74 };
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]);

        //    }
        //    Console.WriteLine();
        //    for(int i = 0; i < arr.Length - 1; i++)
        //    {
        //        int min = arr[i],pos = i;
        //        for(int j =i; j < arr.Length; j++)
        //        {
        //            if (min > arr[j])
        //            {
        //                min = arr[j];
        //                pos = j;
        //            }
        //        }
        //        int temp;
        //        temp = arr[i];
        //        arr[i] = arr[pos];
        //        arr[pos] = temp;
        //    }
        //}

        //static public void Halfsort()
        //{
        //    int[] arr = new int[9] { 20, 52, 21, 18, 45, 85, 25, 41, 1 };
        //    int low = 0,hight =arr.Length - 1;
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    while (low < hight) 
        //    {

        //    }
        //}

        static public void ClassMates()
        {
            //string[,] myarr = new string[2, 2] { { "张三", "李四" }, { "王五", "赵六yi" } };
            //for(int i = 0; i < myarr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < myarr.GetLength(1); j++)
            //    {
            //        Console.Write("{0,-5}",myarr[i,j]);
                  
            //    }
            //   Console.WriteLine("\t");
            //}
        }

        static public void HotelReservation()
        {
            string[,] room = new string[4, 4];
            for(int i = 0;i < room.GetLength(0); i++)
            {
                for(int j = 0;j < room.GetLength(1); j++)
                {
                    room[i, j] = "可预订";

                }
            }
            while (true)
            {
                Console.Clear();
                for(int i = 0;i<room.GetLength(0); i++)
                {
                    for (int j = 0;j<room.GetLength(1); j++)
                    {
                        Console.Write($"【{i + 1}-{j + 1}:{room[i,j]}】");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("请输入想要预定的房间号 例如（1,2）。") ;
                string userInput = Console.ReadLine();
                string[] s = userInput.Split(',');
                int storey = Convert.ToInt32(s[0]);
                int roomId = Convert.ToInt32(s[1]);
                room[storey - 1, roomId - 1] = "已预订";
            }
        }

        static public void crossArray()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 1, 2 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };
           // Console.WriteLine(arr.GetLength(0));
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}",arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}


