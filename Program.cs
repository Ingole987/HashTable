// See https://aka.ms/new-console-template for more information
using HashTable;
Console.WriteLine("Hash table demo"); //() []
//MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
//hash.Add("0", "To");
//hash.Add("1", "be");
//hash.Add("2", "or");
//hash.Add("3", "not");
//hash.Add("4", "to");
//hash.Add("5", "be");
//string hash5 = hash.Get("5");
//Console.WriteLine("5th index value: " + hash5);
//string hash2 = hash.Get("2");
//Console.WriteLine("2th index value: " + hash2);
//Console.ReadKey();
MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
hash.Add("0", "Paranoids");
hash.Add("1", "are");
hash.Add("2", "not");
hash.Add("3", "paranoid");
hash.Add("4", "because");
hash.Add("5", "they");
hash.Add("6", "are");
hash.Add("7", "paranoid");
hash.Add("8", "but");
hash.Add("9", "because");
hash.Add("10", "they");
hash.Add("11", "keep");
hash.Add("12", "putting");
hash.Add("13", "themselves");
hash.Add("14", "delibrately");
hash.Add("15", "into");
hash.Add("16", "paranoid");
hash.Add("17", "avoidable");
hash.Add("18", "situation");

string hash18 = hash.Get("18");
Console.WriteLine("18th index value: " + hash18);


hash.Remove("17");
string hash17 = hash.Get("17");
Console.WriteLine("17th index value: " + hash18);

Console.ReadKey();
