using System.Reflection;

  
 char[] ruletter = new char[] { 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю' };
 char[] entletter = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
    Console.WriteLine("Введите предложения");
    string a=Console.ReadLine();
    char[] s = a.ToCharArray();
    bool b=true;
foreach (char c in ruletter  )
{
        if (!a.Contains(c))
        {
            b = false;
            break;
        }
    }
if (b == true)
{
    Console.WriteLine("ваша предложения является панграмма");
}
    Console.WriteLine(b);
