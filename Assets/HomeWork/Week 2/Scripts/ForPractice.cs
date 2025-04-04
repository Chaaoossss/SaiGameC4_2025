using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
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

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in các số từ 1 đến 100.
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log("BT1:" + i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50

    void BaiTap2()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số từ 1 đến 50.
        int sum = 0;
        for (int i = 1; i <= 50; i++)
        {
            sum += i;
        }
        Debug.Log("BT2:" + sum);
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in tất cả các số chẵn từ 1 đến 100.
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("BT3:" + i);
            }
        }
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính tích của các số từ 1 đến 10.
        int product = 1;
        for (int i = 1; i <= 10; i++)
        {
            product *= i;
        }
        Debug.Log("BT4:" + product);
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tìm số lớn nhất trong một mảng số nguyên.
        int[] numbers = { 3, 5, 7, 2, 8, 10 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số lẻ từ 1 đến 100.
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để đảo ngược một chuỗi.
        string str = "Hello World";
        char[] charArray = str.ToCharArray(); // Chuyển đổi chuỗi thành mảng ký tự
        System.Array.Reverse(charArray); // Đảo ngược mảng ký tự
        string reversedStr = new string(charArray); // Chuyển đổi mảng ký tự trở lại thành chuỗi
        Debug.Log("BT7:" + reversedStr);
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in ra bảng cửu chương của một số bất kỳ (từ 1 đến 10).
        int number = 5; // Số cần in bảng cửu chương
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("BT8:" + number + " x " + i + " = " + (number * i));
        }
    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng các số nguyên dương trong một mảng số nguyên.
        int[] numbers = { -1, 2, 3, -4, 5, 6 };
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                count++;
            }
        }
        Debug.Log("BT9:" + count);
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in ra một tam giác số như sau:
        //1
        //12
        //123
        //1234
        //12345

        int rows = 5; // Số hàng của tam giác
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Debug.Log("BT10:" + j);
            }
            Debug.Log("\n"); // Xuống dòng sau mỗi hàng
        }
    }

    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tìm phần tử nhỏ nhất trong một mảng số nguyên.
        int[] numbers = { 3, 5, 7, 2, 8, 10 };
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Debug.Log("BT11:" + min);
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in ra dãy Fibonacci từ 1 đến n (n là số nhập từ người dùng).
        int n = 10; // Số lượng phần tử trong dãy Fibonacci
        int a = 0, b = 1;
        Debug.Log("BT12:" + a);
        Debug.Log("BT12:" + b);
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Debug.Log("BT12:" + c);
            a = b;
            b = c;
        }
    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính giai thừa của một số nguyên dương n.
        int n = 5; // Số cần tính giai thừa
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Debug.Log("BT13:" + factorial);
    }

    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in ra các số nguyên từ n đến 1, với n là số nhập từ người dùng.
        int n = 10; // Số bắt đầu
        for (int i = n; i >= 1; i--)
        {
            Debug.Log("BT14:" + i);
        }
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử trong một mảng số nguyên.
        int[] numbers = { 3, 5, 7, 2, 8, 10 };
        int sum = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để kiểm tra xem một số nguyên có phải là số nguyên tố hay không.
        int number = 7; // Số cần kiểm tra
        bool isPrime = true;
        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Mathf.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Debug.Log("BT16:" + number + " là số nguyên tố.");
        }
        else
        {
            Debug.Log("BT16:" + number + " không phải là số nguyên tố.");
        }
    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để in ra các số từ 1 đến 100 chia hết cho 3.
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log("BT17:" + i);
            }
        }
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử chẵn trong một mảng số nguyên.
        int[] numbers = { 3, 5, 7, 2, 8, 10 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
        }
        Debug.Log("BT18:" + sum);
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để tính trung bình cộng của các phần tử trong một mảng số nguyên.
        int[] numbers = { 3, 5, 7, 2, 8, 10 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        float average = (float)sum / numbers.Length;
        Debug.Log("BT19:" + average);
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        // Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng ký tự hoa trong một chuỗi.
        List<string> animals = new List<string> { "Cat", "dog", "elephant", "Lion", "Tiger", "Ant" };
        int count = 0;
        for (int i = 0; i < animals.Count; i++)
        {
            if (char.IsUpper(animals[i][0]))
            {
                count++;
            }
        }
        Debug.Log("BT20:" + count);
    }
}
