using DataStructures.ElementaryDataStructures.LinkedLists;

namespace DataStructures.HashTables;

public class HashTable<K, V> : IHashTable<K, V>
{
    private int _hashtTableSize;

    private SinglyLinkedList<HashTableEntry<K, V>>[]  _table;

    public HashTable()
    {
        _hashtTableSize = 701;
        _table = new SinglyLinkedList<HashTableEntry<K, V>>[_hashtTableSize];
    }

    public bool Contains(K key)
    {
        int hashIndex = key.GetHashCode() % _hashtTableSize;

        var list = _table[hashIndex];

        if(list == null)
        {
            return false;
        }

        EqualityComparer<K> comparer = EqualityComparer<K>.Default;

        foreach(var node in list)
        {
            if(comparer.Equals(node.Key, key))
            {
                return true;
            }
        }

        return false;
    }

    public void Insert(K key, V value)
    {
        if(key == null)
        {
            throw new ArgumentNullException("The Key passed is null");
        }

        int hashIndex = key.GetHashCode() % _hashtTableSize;

        var hashTableEntry = new HashTableEntry<K, V>(key, value);

        if (_table[hashIndex] == null)
        {
            _table[hashIndex] = new SinglyLinkedList<HashTableEntry<K, V>>();
        }
        else
        {
            var node = _table[hashIndex].Search(hashTableEntry);

            if(node != null)
            {
                node.Value = hashTableEntry;
                return;
            }
        }

        _table[hashIndex].Insert(hashTableEntry);
    }

    public void Remove(K key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("The Key passed is null");
        }

        int hashIndex = key.GetHashCode() % _hashtTableSize;

        var list = _table[hashIndex];

        HashTableEntry<K, V>? listNode = default;

        EqualityComparer<K> comparer = EqualityComparer<K>.Default;

        foreach(var element in list)
        {
            if(comparer.Equals(element.Key, key))
            {
                listNode = element;
                break;
            }
        }

        if(listNode != null)
        {
            list.Delete(listNode);
        }
    }
}

