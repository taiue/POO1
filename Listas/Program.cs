using System.Xml.Linq;

List<string> list = new List<string>();
//tipo list // nome da variavel // inicia instancia 

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");
list.Insert(2, "Marco");

foreach (var item in list)
{
    Console.WriteLine(item);    
}


Console.WriteLine("List count: " + list.Count());

//encontrar item da lista

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("primeiro A: "+s1);

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Ultimo A: " + s2);


int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("Primeira posição iniciano com A: " + pos1);


int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Ultima posição iniciano com A: " + pos2);

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("------------------------");
foreach (var item in list2)
    Console.WriteLine(item);

list.Remove("Alex");
Console.WriteLine("------------------------");
foreach (var item in list)
    Console.WriteLine(item);

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("------------------------");
foreach (var item in list)
    Console.WriteLine(item);
