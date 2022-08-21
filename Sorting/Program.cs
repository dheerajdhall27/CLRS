using Sorting.HeapSort.PriorityQueue;

var minPriorityQueue = new PriorityQueue<Schedule>(true);

minPriorityQueue.Enqueue(new Schedule(4));
minPriorityQueue.Enqueue(new Schedule(1));
minPriorityQueue.Enqueue(new Schedule(3));
minPriorityQueue.Enqueue(new Schedule(2));
minPriorityQueue.Enqueue(new Schedule(16));
minPriorityQueue.Enqueue(new Schedule(9));
minPriorityQueue.Enqueue(new Schedule(10));
minPriorityQueue.Enqueue(new Schedule(14));
minPriorityQueue.Enqueue(new Schedule(8));
minPriorityQueue.Enqueue(new Schedule(7));

Console.WriteLine(minPriorityQueue);
