using DataStructures.HashTables;

var hashTable = new HashTable<int, int>();

hashTable.Insert(1, 1);
hashTable.Insert(2, 1);
hashTable.Insert(3, 1);
hashTable.Insert(4, 1);

Console.WriteLine(hashTable.Contains(2));

hashTable.Remove(2);

Console.WriteLine(hashTable.Contains(2));