

Console.WriteLine("Enter a number:");

int Usernum = Convert.ToInt32(Console.ReadLine());
// kas  kasutaja arv on paris või paaritu

int result = Usernum % 2;

if (result != 0) // ei ole null
{
Console.WriteLine("User number is odd.");
} else
{
Console.WriteLine("User number is even.");
}