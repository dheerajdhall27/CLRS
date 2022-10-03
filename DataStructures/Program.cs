
using DataStructures.Trees.BinarySearchTree;

BinarySearchTree<int> bst = new BinarySearchTree<int>();

bst.Insert(5);
bst.Insert(2);
bst.Insert(1);
bst.Insert(3);
bst.Insert(7);
bst.Insert(6);
bst.Insert(8);

var list = bst.GetPredecessor(5);

Console.WriteLine(list);