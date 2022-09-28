namespace DataStructures.HashTables;
internal interface IHashTable<K, V>
{
    bool Contains(K key);
    void Insert(K key, V value);
    void Remove(K key);
}

