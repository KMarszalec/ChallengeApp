var name = "Ewa";
var isFamale = true;
var age = 33;

if (isFamale && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30lat");
}
else if (isFamale == true && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (isFamale == false && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}