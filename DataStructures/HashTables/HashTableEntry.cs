namespace DataStructures.HashTables;

internal class HashTableEntry<K, V> : IComparable<HashTableEntry<K, V>>
{
    public K Key { get; init; }

    public V Value { get; init; }

    public HashTableEntry(K key, V value)
    {
        Key = key;
        Value = value;
    }

    public int CompareTo(HashTableEntry<K, V>? other)
    {
        if(other == null)
        {
            return -1;
        }

        return this.Key.GetHashCode().CompareTo(other.Key.GetHashCode());
    }
}

