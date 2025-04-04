using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = UnityEngine.Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
    // Simple bubble sort algorithm
    void SortArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    // Sort Algorithm 2
    // Selection Sort Algorithm
    void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            // Find the index of the minimum element in the unsorted part
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum with the current position
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
    // Sort Algorithm 3
    // Insertion Sort algorithm
    void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Move elements that are greater than key to one position ahead
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
    // Sort Algorithm 4
    // Merge Sort main function
    void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            // Sort the left half
            MergeSort(array, left, middle);

            // Sort the right half
            MergeSort(array, middle + 1, right);

            // Merge the two halves
            Merge(array, left, middle, right);
        }
    }

    // Merge two sorted subarrays
    void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];

        for (int j = 0; j < n2; j++)
            rightArray[j] = array[middle + 1 + j];

        int k = left;
        int iIndex = 0, jIndex = 0;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copy remaining elements
        while (iIndex < n1)
        {
            array[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            array[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }


    // Sort Algorithm 5
    // Quick Sort algorithm
    void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Partition returns index of the pivot
            int pivotIndex = Partition(array, low, high);

            // Recursively sort left and right subarrays
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    // Partition function
    int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // choose last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                // Swap array[i] and array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Swap array[i + 1] and pivot
        int temp2 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp2;

        return i + 1; // Return the pivot index
    }

    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        Debug.Log("Original array:");

        foreach (int number in randomNumbers)
        {
            Debug.Log(number);
        }
        // Sort the array using the selected sorting algorithm
        InsertionSort(randomNumbers);

        Debug.Log("Sorted array:");
        foreach (int number in randomNumbers)
        {
            Debug.Log(number);
        }

        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
