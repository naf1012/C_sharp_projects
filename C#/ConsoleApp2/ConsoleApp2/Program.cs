using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random array of integers
            int[] numbers = GenerateRandomArray(10);

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            int[] insertionSortedArray = (int[])numbers.Clone();
            InsertionSort(insertionSortedArray);
            Console.WriteLine("\nInsertion Sorted Array:");
            PrintArray(insertionSortedArray);

            int[] bubbleSortedArray = (int[])numbers.Clone();
            BubbleSort(bubbleSortedArray);
            Console.WriteLine("\nBubble Sorted Array:");
            PrintArray(bubbleSortedArray);

            int[] quickSortedArray = (int[])numbers.Clone();
            QuickSort(quickSortedArray, 0, quickSortedArray.Length - 1);
            Console.WriteLine("\nQuick Sorted Array:");
            PrintArray(quickSortedArray);

            int[] mergeSortedArray = (int[])numbers.Clone();
            MergeSort(mergeSortedArray, 0, mergeSortedArray.Length - 1);
            Console.WriteLine("\nMerge Sorted Array:");
            PrintArray(mergeSortedArray);

            int[] heapSortedArray = (int[])numbers.Clone();
            HeapSort(heapSortedArray);
            Console.WriteLine("\nHeap Sorted Array:");
            PrintArray(heapSortedArray);

            // Perform searches
            int target = bubbleSortedArray[3]; // Arbitrary target for search

            Console.WriteLine($"\nSearching for {target}...");

            // Linear Search
            int linearIndex = LinearSearch(bubbleSortedArray, target);
            Console.WriteLine(linearIndex != -1
                ? $"Linear Search: Found {target} at index {linearIndex}"
                : $"Linear Search: {target} not found");

            // Binary Search
            int binaryIndex = BinarySearch(bubbleSortedArray, target);
            Console.WriteLine(binaryIndex != -1
                ? $"Binary Search: Found {target} at index {binaryIndex}"
                : $"Binary Search: {target} not found");
        }


        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return (i + 1);
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        static void HeapSort(int[] array)
        {
            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Call max heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int left = 2 * i + 1; // left = 2*i + 1
            int right = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (left < n && array[left] > array[largest])
                largest = left;

            // If right child is larger than largest so far
            if (right < n && array[right] > array[largest])
                largest = right;

            // If largest is not root
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }
        }

        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
