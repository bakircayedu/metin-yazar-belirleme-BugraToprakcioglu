using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class Heap
    {
        private HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;

        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(int value)
        {
            if (currentSize == maxSize)
                return false;

            HeapDugumu newHeapDugumu = new HeapDugumu(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];

            while (index > 0 && heapArray[parent].Deger < bottom.Deger)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;

            }
            heapArray[index] = bottom;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];

            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (rightChild < currentSize && heapArray[leftChild].Deger < heapArray[rightChild].Deger)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Deger >= heapArray[largerChild].Deger)
                    break;
                heapArray[index] = heapArray[largerChild];

                index = largerChild;

            }
            heapArray[index] = top;
        }
        public HeapDugumu RemoveMax()
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
    }
}
