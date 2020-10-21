using System;
using System.Collections.Generic;

namespace 剑指_Offer_40._最小的k个数
{
    class Program
    {
        static void Main(string[] args)
        {
            // arr = [3,2,1], k = 2
            int[] arr = { 7, 9, 10, 8, 6, 1, 5, 2, 4, 3 };
            int k = 4;

            int[] result = GetLeastNumbers(arr, k);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static int[] GetLeastNumbers(int[] arr, int k)
        {
            if (k == 0)
            {
                return new int[] { };
            }
            // 大根堆: 解决前k个最小
            // 大根堆: 所有 子节点 比 根节点小
            // PS: 小根堆: 解决前k个最大
            PriorityQueue<int> queue = new PriorityQueue<int>();
            // 取前k个
            for (int i = 0; i < k; i++)
            {
                queue.Push(arr[i]);
            }
            // 从k后面开始遍历
            for (int i = k; i < arr.Length; i++)
            {
                if (queue.Top() > arr[i])
                {
                    // 堆顶永远放着堆中最大的数
                    // 当前遍历到的元素比堆顶更小，弹出堆顶
                    queue.Pop();
                    // 压入这个更小的数
                    queue.Push(arr[i]);
                }
            }
            int[] rtn = new int[k];
            for (int i = 0; i < k; i++)
            {
                // 要堆顶
                rtn[i] = queue.Top();
                // 弹出堆顶
                queue.Pop();
            }
            return rtn;
        }
    }

    /// <summary>
    /// 优先队列
    /// 可以用来做大根堆，小根堆
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class PriorityQueue<T>
    {
        IComparer<T> comparer;
        T[] heap;

        public int Count { get; private set; }

        public PriorityQueue() : this(null) { }
        public PriorityQueue(int capacity) : this(capacity, null) { }
        public PriorityQueue(IComparer<T> comparer) : this(16, comparer) { }

        public PriorityQueue(int capacity, IComparer<T> comparer)
        {
            this.comparer = (comparer == null) ? Comparer<T>.Default : comparer;
            this.heap = new T[capacity];
        }

        public void Push(T v)
        {
            if (Count >= heap.Length) Array.Resize(ref heap, Count * 2);
            heap[Count] = v;
            SiftUp(Count++);
        }

        public T Pop()
        {
            var v = Top();
            heap[0] = heap[--Count];
            if (Count > 0) SiftDown(0);
            return v;
        }

        public T Top()
        {
            if (Count > 0) return heap[0];
            throw new InvalidOperationException("优先队列为空");
        }

        void SiftUp(int n)
        {
            var v = heap[n];
            for (var n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
            heap[n] = v;
        }

        void SiftDown(int n)
        {
            var v = heap[n];
            for (var n2 = n * 2; n2 < Count; n = n2, n2 *= 2)
            {
                if (n2 + 1 < Count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                if (comparer.Compare(v, heap[n2]) >= 0) break;
                heap[n] = heap[n2];
            }
            heap[n] = v;
        }
    }
}

