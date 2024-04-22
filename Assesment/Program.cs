// single comment
/* multiple comment  */


/*string nam = "Dot net";//4 bytes
char ch = 'a';//1 byte
short s1 = 100;//2 bytes
int num = 12;//4 bytes
float f1 = 12.22F;//4 bytes
double d1 = 23.23;//8 bytes
decimal dc = 12.23M;//16 bytes

//print output by concatination
Console.WriteLine(  "integer number is "+num);

//using placeholder
Console.WriteLine(  "interger number is {0} and decimal number is {1}",num,dc);

//using string interpolation

Console.WriteLine($"short number is{s1} and float number is {f1}");

//accept value from user--->Console.ReadLine()--->return string

Console.WriteLine("enter your name");
string name=Console.ReadLine();


Console.WriteLine("Enter your age");
int age =Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("enter your salary");
double db=Convert.ToDouble (Console.ReadLine());

//output print
Console.WriteLine($"Hello {name} your age is {age} and salary is {db}");*/
//main method called implicitly

//declare object

//new keyword allocate memory to heap
//using Assesment;

/*Employee emp1 = new Employee();
emp1.Assign();
emp1.Calculate();
String result = emp1.Display();
Console.WriteLine(result);

Employee emp2 = new Employee();
emp2.Accept(102, "ketan", 20000, 13000, 2000);
emp2.Calculate();
Console.WriteLine(emp2.Display());*/

//student class
/*Student s1 = new Student();

Console.WriteLine(s1.Display());

Student s2 = new Student("Naveen");

Console.WriteLine(s2.Display());*/

//Date class

/*Date d1 = new Date();
Date d2 = new Date(12,02,2024);
Console.WriteLine(d1.Display());
Console.WriteLine(d2.Display());*/

//working with property
//product class
//property initalizer with syntex

/*Product p1 = new Product();
p1.Code = 101;//internally it calles set accessor
p1.Name = "mobile";
p1.Price = 50000;

Console.WriteLine($"code:{p1.Code}, name:{p1.Name}, price:{p1.Price}");

//object initalizer syntex
Product p2 = new Product { Code = 102, Name = "mouse", Price = 2000 };
Console.WriteLine($"code:{p2.Code}, name:{p2.Name}, price:{p2.Price}");*/

//book 
//with property iniyializer

/*Book b=new Book();
b.Bookid = 101;
b.Author = "Ester hicks";
b.Price = 400;
Console.WriteLine($"Book id={b.Bookid} , auother ={b.Author}, price={b.Price}");


//object initializer

Book b2 = new Book { Bookid = 102, Author = "Henry", Price = 500 };
Console.WriteLine($"Book id={b2.Bookid} , auother ={b2.Author}, price={b2.Price}");*/

/*StudentDemo s1 = new StudentDemo();
s1.Accept(101, "chetan", 80, 80, 90);
s1.Calculate();
string result=s1.Display();
Console.WriteLine(result);

Console.WriteLine("-----------------------------------------");

Shopping s=new Shopping();
s.Accept(111, "TV", 40000, 1);
s.Calculate();
Console.WriteLine(s.Show());

/*Employee emp = new Employee(101, "rishita", 2000, 1000, 100);
emp.Calculate();
Console.WriteLine(emp.Display());

//object of child class
Manager mn1 = new Manager(102, "sunil", 8000, 5000, 500, 2000);
mn1.Calculate();    
Console.WriteLine(mn1.Display());

//create refrence of base class but object of child class
Employee emp2 = new Manager(103, "reetu", 4000, 2000, 500, 2000);
emp2.Calculate();
Console.WriteLine(emp2.Display());*/

//dynamic binding //run time binding in polymorphism/in method overriding
/*Circle c1 = new Circle(5);
c1.CalculateArea();

Console.WriteLine(c1.Print());

Reactangle r = new Reactangle(10, 20);
r.CalculateArea();
Console.WriteLine(r.Print());*/

using Assesment;
using System.Threading.Channels;
/*OverloadDemo o1 = new OverloadDemo();

Job job = new Job();
Console.WriteLine(job.PayTax());

Business b= new Business();
Console.WriteLine(b.PayTax());

//working with implicit implementation

IOrder o1 = new Transaction();
Console.WriteLine(o1.Print());

ICustomer c1=new Transaction();
Console.WriteLine(c1.Print());*/

/*Calcu c=new Calcu();
Console.WriteLine(c.Add(20,10));
//Console.WriteLine(c.Sub(20, 10));

c.sub(20,10);
c.Mult(20,10);
c.Div(20,10);*/
/* int[] arr1=new int[5] {2,5,43,4,3};

//
Console.WriteLine(arr1[2]);

arr1[3] = 100;
Console.WriteLine(arr1[3]);

//display by for loop
*//*for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine(arr1[i]);
}*//*

string[] arr2 = { "reetu", "rohan", "sunil", "ruchika" };
for (int i = 0;i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}

//using for eachloop
//iterate the loop only in forward direction from 0index to last index
foreach (int val in arr1)
{
    Console.WriteLine(val);
}*/


/*
ProductDemo[] p1 = new ProductDemo[5];
for (int i = 0; i < p1.Length; i++)
{
    p1[i] = new ProductDemo();
}
p1[0] = new ProductDemo();
p1[0].Id = 1;
p1[0].Name = "Laptop";
p1[0].Price = 50000;
p1[1] = new ProductDemo();
p1[1].Id = 2;
p1[1].Name = "mouse";
p1[1].Price = 1000;
p1[2] = new ProductDemo();
p1[2].Id = 3;
p1[2].Name = "keyboard";
p1[2].Price = 2000;
p1[3] = new ProductDemo();
p1[3].Id = 4;
p1[3].Name = "printer";
p1[3].Price = 4000;
p1[4] = new ProductDemo();
p1[4].Id = 5;
p1[4].Name = "monitor";
p1[4].Price = 30000;

foreach(ProductDemo p in p1)
{
    Console.WriteLine($" { p.Id} :{ p.Name}: { p.Price}");
}

*/


/*int[]arr1=new int[] {80,45,12,78,1};

//print array
foreach (int val in arr1)
{
    Console.WriteLine(val);
}

//sort array in ascending order
Array.Sort(arr1);
Console.WriteLine("------after sorting------");
foreach (int val in arr1)
{
    Console.WriteLine(val);
}
//reverse
Array.Reverse(arr1);
Console.WriteLine("------after reversing the sorted array------");
foreach (int val in arr1)
{
    Console.WriteLine(val);
}
//copy three elements 45 12 1 in new array
int[] arr2 = new int[3];
Console.WriteLine("-----after copy------");
Array.Copy(arr1,2,arr2,0,3);

foreach (int val in arr2)
{
    Console.WriteLine(val);
}

Console.WriteLine("------clear----");
Array.Clear(arr2);

foreach (int val in arr2)
{
    Console.WriteLine(val);
}*/


/*
string[] arr1 = new string[] {"rohit","naveen","anshu","dipti","nisha"};
Console.WriteLine("------string array without sort-------");
foreach (string str in arr1)
{
    Console.WriteLine(str);
}
Console.WriteLine("------string array after sort-------");
Array.Sort(arr1);
foreach (string str in arr1)
{
    Console.WriteLine(str);
}

Console.WriteLine("------string array after  reverse-------");
Array.Reverse(arr1);
foreach (string str in arr1)
{
    Console.WriteLine(str);
}
Console.WriteLine("------string array after copy-------");
string[] arr2 = new string[2];
Array.Copy(arr1,2,arr2,0,2);
foreach (string str in arr2)
{
    Console.WriteLine(str);
}
Console.WriteLine("------string array after clear-------");
Array.Clear(arr1,0, 2);
foreach (string str in arr1)
{
    Console.WriteLine(str);
}*/
/*Console.WriteLine("enter the number of rows");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of columns");
int columns=Convert.ToInt32(Console.ReadLine());*/



/*int[,] arr1 = new int[3, 3];
Console.WriteLine("enter number of elements for first array");


for(int i = 0; i < arr1.GetLength(0); i++)
{
    for(int j = 0; j < arr1.GetLength(1); j++)
    {
         arr1[i,j]= Convert.ToInt32(Console.ReadLine());
    }
    
}
int[,] arr2 = new int[3, 3];
Console.WriteLine("enter number of elements for second array");


for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
    

 int[,] arr3 = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        arr3[i, j] = arr1[i, j] + arr2[i,j];
    }

   
}
Console.WriteLine("sum of array");
for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        Console.Write(arr3[i, j]);
    }
    Console.WriteLine();
}*/


//Jagged Array
using Assesment;
using System.Text;
/*int[][] arr = new int[4][];//number of rows are fixed in jagged array

arr[0]=new int[] {1,2,3,4,5};//0th row has 5 columns
arr[1]=new int[] {10,20,30,40};//1st row has 4 columns
arr[2] = new int[] { 100, 200, 300 };//2md row has 3 columns
arr[3] = new int[] {1,1 };//3rd row has 2 columns

//row
for (int i = 0; i < arr.Length; i++)//arr.length return the size of array

{
    for (int j = 0; j < arr[i].Length; j++)// col
    {
        Console.Write(arr[i][j]+" ");
    }
    Console.WriteLine();
}
//by for each loop
Console.WriteLine("------------");
foreach (int[] i in arr)
{
    foreach (int j in i)
    {
        Console.Write($"{j}");
    }
    Console.WriteLine();
}


// Jagged array

int[][] arr = new int[3][];// rows are fixed -

arr[0]=new int[] {1,2,3,4,5}; // 0th row has 5 columns
arr[1]=new int[] {10,20,30}; // 1st row has 3 columns
arr[2] = new int[] { 100, 200 }; // 2nd row 2 columns

// row
for (int i = 0; i <arr.Length; i++) // arr.Length returns size of row
{
    for (int j = 0; j < arr[i].Length; j++) // col
    {
        Console.Write($"{arr[i][j]}  ");
    }
    Console.WriteLine();
}

// with foreach
Console.WriteLine("-----using foreach----------");
foreach (int[] item in arr) // assing row to item
{
    foreach (int i in item)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}


*/
/*Console.WriteLine("----------StringBuilder class");

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
Console.WriteLine(sb);
Console.WriteLine($"address of sb {sb.GetHashCode()}");

Console.WriteLine("-----after changed the value");
sb.Append("Hello to all");
Console.WriteLine(sb);
Console.WriteLine($"address of sb {sb.GetHashCode()}");


sb.Clear();
//sb.Length; // to get total characters . i.e. length of string


string s = "dot net training";
string[]str=s.Split(',');

foreach(var item in str)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");
char[] ch = s.ToCharArray();
foreach (var item in ch)
{
    Console.WriteLine(item);
}


Console.WriteLine("------------------");
Console.WriteLine(s.IndexOf('d'));

StringBuilder sb1 = new StringBuilder();
sb1.Append("work on time");
sb1 .Replace("on", "with");

*/

  /*  Add a = new Add();
    a.addition();
Console.WriteLine(a.addition());
*/











