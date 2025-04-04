using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            Debug.Log("Array include " + number);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int SumArray = 0;
        foreach (int number in numbers)
        {
            SumArray = SumArray + number;
            Debug.Log("The sum of array is: " + SumArray);
        }
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = numbers[0];

        // Use foreach loop to find the maximum value
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Output the maximum value
        Debug.Log("The maximum number is: " + max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 11, 22, 33, 44, 55 };

        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int evenCount = CountEvens(numbers);
        Debug.Log("Number of even elements: " + evenCount);
    }

    // Function to count even numbers using foreach
    int CountEvens(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger" };
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string animal in animals)
        {
            Debug.Log("Animal: " + animal);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger" };
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string longest = FindLongestString(animals);
        Debug.Log("The longest animal name is: " + longest);
    }

    // Function to find the longest string in a list
    string FindLongestString(List<string> list)
    {
        string longest = "";

        foreach (string item in list)
        {
            if (item.Length > longest.Length)
            {
                longest = item;
            }
        }

        return longest;
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 11, 22, 33, 44, 55 };
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sum = 0;

        foreach (int number in numbers)
        {
            if (number % 2 != 0) // Check if the number is odd
            {
                sum += number;
            }
        }

        Debug.Log("Sum of odd numbers: " + sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 11, 22, 33, 44, 55 };
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Check if the number is even
            {
                Debug.Log("Even number: " + number);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] numbers = { 11, 22, 33, 44, 55 };
        int checkNumber = 11;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        bool exists = false;
        foreach (int number in numbers)
        {
            if (number == checkNumber)
            {
                exists = true;
                break; // Nếu tìm thấy, không cần kiểm tra tiếp
            }
        }
        if (exists)
        {
            Debug.Log("The number " + checkNumber + " exists in the array.");
        }
        else
        {
            Debug.Log("The number " + checkNumber + " does not exist in the array.");
        }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -11, 22, -33, 44, -55 };
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int negativeCount = 0;
        foreach (int number in numbers)
        {
            if (number < 0) // Check if the number is negative
            {
                negativeCount++;
            }
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 33, 44, 55 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int number in numbers)
        {
            if (number > 10) // Check if the number is greater than 10
            {
                Debug.Log("Number greater than 10: " + number);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger" };
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string shortest = FindShortestString(animals);
        Debug.Log("The shortest animal name is: " + shortest);
    }

    // Function to find the shortest string in a list
    string FindShortestString(List<string> list)
    {
        string shortest = list[0];

        foreach (string item in list)
        {
            if (item.Length < shortest.Length)
            {
                shortest = item;
            }
        }

        return shortest;
    }


    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 33, 44, 55 };
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        List<int> doubledList = new List<int>();
        // Add original elements
        foreach (int number in numbers)
        {
            doubledList.Add(number);
        }

        // Add original elements again
        foreach (int number in numbers)
        {
            doubledList.Add(number);
        }

        // Convert to array if needed
        int[] doubledArray = doubledList.ToArray();
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 33, 44, 55 };
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number != largest)
            {
                secondLargest = number;
            }
        }

        Debug.Log("The second largest number is: " + secondLargest);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger", "Ant" };
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string animal in animals)
        {
            if (animal.StartsWith("A"))
            {
                Debug.Log("Animal starting with A: " + animal);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger", "Ant" };
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        bool containsHello = false;
        foreach (string animal in animals)
        {
            if (animal == "Hello")
            {
                containsHello = true;
                break; // Nếu tìm thấy, không cần kiểm tra tiếp
            }
        }
        if (containsHello)
        {
            Debug.Log("The list contains 'Hello'.");
        }
        else
        {
            Debug.Log("The list does not contain 'Hello'.");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -11, 22, -33, 44, -55 };
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int number in numbers)
        {
            if (number < 0) // Check if the number is negative
            {
                Debug.Log("Negative number: " + number);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] numbers = { -11, 22, -33, 44, -55 };
        int checkNumber = -11;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int count = 0;
        foreach (int number in numbers)
        {
            if (number == checkNumber)
            {
                count++;
            }
        }
        Debug.Log("The number " + checkNumber + " appears " + count + " times in the array.");
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -11, 22, -33, 44, -55 };
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        List<int> newList = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 10) // Check if the number is greater than 10
            {
                newList.Add(number);
            }
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion", "Tiger", "Ant" };
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string animal in animals)
        {
            if (animal.Length > 5) // Check if the string length is greater than 5
            {
                Debug.Log("Animal with name longer than 5 characters: " + animal);
            }
        }
    }

}
