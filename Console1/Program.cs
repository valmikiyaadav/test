// See https://aka.ms/new-console-template for more information

//int i;
//int k=0;
//int[] arry = {1, 2, 3};
//int[] arry2= new int[4];
//for (i= arry.Length-1; i >= 0; i--)
//{
//    arry2[k] = arry[i];
//    k++;
//}
//Console.Write(arry2[0]);


//int num;
//Console.WriteLine("Enter Number");
//num = int.Parse(Console.ReadLine());

//int num = 0;
//for(int i = 0; i > 100; i++)
//{
//    if (i > 1 & i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//string name = "Valmiki";
//char[] ctr = name.ToCharArray();
//string rstring = string.Empty;

////for (int i = ctr.Length - 1; i >= 0; i--)
//    for (int i = ctr.Length - 1; i >= 0; i--)
//    {
//        rstring += ctr[i];
//    }
//Console.Write(rstring);

#region Coourance
string name1 = "Valmikiyadav";
//char[] name1=name1.ToCharArray();

while (name1.Length > 0)
{
    int count = 0;
    for (int j = 0; j < name1.Length; j++)
    {
        if (name1[0] == name1[j])
        {
            count++;
        }
    }
    Console.WriteLine(name1[0] + ":" + count);
    name1 = name1.Replace(name1[0].ToString(), string.Empty);
}


#endregion

#region faboncci
//int lastno = 10;
//    int a=0;
//int b = 1;
//int c = 0;

//for(int i = 0; i < 10; i++)
//{
//    c = a + b;
//    a = b;
//    b = c;
//    Console.WriteLine(c);
//}
#endregion
//int a = 10;
//int b = 11;

//a=a+b;
//b = a - b;
//a= a - b;
//Console.WriteLine("a:"+a + ",b:" + b);


/*int flg = 0;
int n = 75;
int i = 0;
for (i = 2; i < n - 1; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine("NotPrime");
        flg = 1;
        break;
    }
}
    if (flg == 0)
    {
        Console.WriteLine("Prime");
        //break;
    }*/

//public class Add
//{
//    private int _Id { get; set; }

//    public int Id
//    {
//        get
//        {
//            if (_Id == 0)
//                return 1;
//            else
//                return 955;
//        }
//        set { _Id = value; }
//    }

//}
















