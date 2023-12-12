using GenericClass;

MyGenericClass<int> genericClass = new MyGenericClass<int>();

genericClass.AddToList(9);
genericClass.AddToList(4);
genericClass.AddToList(23);
genericClass.AddToList(13);
genericClass.AddToList(65);
genericClass.AddToList(-8);

Console.WriteLine(genericClass.ReturnItemFromList(0));

foreach (var num in genericClass.ReturnSortedList())
{
    Console.WriteLine(num);
}