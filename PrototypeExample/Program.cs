// See https://aka.ms/new-console-template for more information
using PrototypeExample;
// student data
Person st1 = new Student();
st1.Name = "Ahmed";
st1.Id = 1;
st1.PersonAddress = new Address {
    Building = "build number 1",
    Street = "nile street",
    City = "tanta"
};
///////// using shallow Copy ///////////
Person st2 = st1.ShallowCopy();
Console.WriteLine(" student(1) original data ");
Console.WriteLine(st1.ToString());
Console.WriteLine(" student(2) copy data ");
Console.WriteLine(st2.ToString());
st1.Name = "Fahmy";
st1.Id = 2;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" student(1) after changing data ");
Console.WriteLine(st1.ToString());
Console.WriteLine(" student(2)  data ");
Console.WriteLine(st2.ToString());
///////// using deep Copy ///////////
Person st3 = st1.DeepCopy();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" student(1) original data ");
Console.WriteLine(st1.ToString());
Console.WriteLine(" student(3) copy data ");
Console.WriteLine(st3.ToString());
st1.Id = 4;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" student(1) after changing data ");
Console.WriteLine(st1.ToString());
Console.WriteLine(" student(3)  data ");
Console.WriteLine(st3.ToString());
// professor data
Person prof1 = new Professor();
prof1.Name = "Mohamed";
prof1.Id = 1;
prof1.PersonAddress = new Address
{
    Building = "block number 10",
    Street = " street number 15",
    City = "cairo"
};
///////// using shallow Copy ///////////
Person prof2 = prof1.ShallowCopy();
Console.WriteLine(" professor(1) original data ");
Console.WriteLine(prof1.ToString());
Console.WriteLine(" professor(2) copy data ");
Console.WriteLine(prof2.ToString());
prof1.Name = "Kamel";
prof1.Id = 6;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(" professor(1) after changing data ");
Console.WriteLine(prof1.ToString());
Console.WriteLine(" professor(2)  data ");
Console.WriteLine(prof2.ToString());
///////// using deep Copy ///////////
Person prof3 = prof1.DeepCopy();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" professor(1) original data ");
Console.WriteLine(prof1.ToString());
Console.WriteLine(" professor(3) copy data ");
Console.WriteLine(prof3.ToString());
prof1.PersonAddress.City= "alexandria";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" professor(1) after changing data ");
Console.WriteLine(prof1.ToString());
Console.WriteLine(" professor(3)  data ");
Console.WriteLine(prof3.ToString());


