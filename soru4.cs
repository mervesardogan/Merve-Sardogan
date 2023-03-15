//soru4 QuickSort kullanıldı
using System;

public class MainClass {
    public static void Main() {
        int[] arr = new int[10000];
        // Rastgele dizi oluştur
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rand.Next(10000);
        }

        // Quick sort'u çalıştır ve süreyi ölç
        long startTime = DateTime.Now.Ticks;
        QuickSort(arr, 0, arr.Length - 1);
        long endTime = DateTime.Now.Ticks;
        Console.WriteLine("Quick sort süresi: " + (endTime - startTime) + " nanosaniye");

        // Brute force'u çalıştır ve süreyi ölç
        startTime = DateTime.Now.Ticks;
        BruteForceSort(arr);
        endTime = DateTime.Now.Ticks;
        Console.WriteLine("Brute force süresi: " + (endTime - startTime) + " nanosaniye");
    }

    public static void BruteForceSort(int[] arr) {
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[j] < arr[i]) {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    public static void QuickSort(int[] arr, int low, int high) {
        if (low < high) {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    public static int Partition(int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++) {
            if (arr[j] < pivot) {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;
        return i + 1;
    }
}