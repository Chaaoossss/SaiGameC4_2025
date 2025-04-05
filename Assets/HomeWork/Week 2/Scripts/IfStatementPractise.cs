using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        int i = 0; // Giả sử người dùng nhập số 0
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (i > 0)
        {
            Debug.Log("Số dương");
        }
        else if (i < 0)
        {
            Debug.Log("Số âm");
        }
        else
        {
            Debug.Log("Bằng 0");
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        int i = 4; // Giả sử người dùng nhập số 4
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (i % 2 == 0)
        {
            Debug.Log("Số chẵn");
        }
        else
        {
            Debug.Log("Số lẻ");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float diemTrungBinh = 6.5f; // Giả sử người dùng nhập điểm trung bình là 6.5
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (diemTrungBinh >= 5.0f)
        {
            Debug.Log("Học sinh đỗ");
        }
        else
        {
            Debug.Log("Học sinh trượt");
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        int a = 5; // Giả sử người dùng nhập số 5
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        int b = 10; // Giả sử người dùng nhập số 10
        if (a > b)
        {
            Debug.Log("Số lớn nhất là: " + a);
        }
        else if (b > a)
        {
            Debug.Log("Số lớn nhất là: " + b);
        }
        else
        {
            Debug.Log("Hai số bằng nhau");
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        float soTienHienCo = 200000; // Giả sử người dùng có 200,000 đồng
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        float giaSanPham = 150000; // Giả sử giá sản phẩm là 150,000 đồng
        if (soTienHienCo >= giaSanPham)
        {
            Debug.Log("Bạn có đủ tiền để mua sản phẩm");
        }
        else
        {
            Debug.Log("Bạn không đủ tiền để mua sản phẩm");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        int nam = 2024; // Giả sử người dùng nhập năm 2024
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
        {
            Debug.Log(nam + " là năm nhuận");
        }
        else
        {
            Debug.Log(nam + " không phải là năm nhuận");
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        int tuoi = 20; // Giả sử người dùng nhập tuổi là 20
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        int giaVe = 0;
        if (tuoi < 18)
        {
            giaVe = 50000;
        }
        else
        {
            giaVe = 100000;
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float diemTrungBinh = 9.5f; // Giả sử người dùng nhập điểm trung bình là 9.5
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (diemTrungBinh >= 9.0f)
        {
            Debug.Log("Học sinh xuất sắc");
        }
        else
        {
            Debug.Log("Học sinh không xuất sắc");
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        int a = 5; // Giả sử người dùng nhập số 5
        int b = 10; // Giả sử người dùng nhập số 10
        int c = 7; // Giả sử người dùng nhập số 7
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        if (a >= b && a >= c)
        {
            Debug.Log("Số lớn nhất là: " + a);
        }
        else if (b >= a && b >= c)
        {
            Debug.Log("Số lớn nhất là: " + b);
        }
        else
        {
            Debug.Log("Số lớn nhất là: " + c);
        }
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        int soGioLam = 45; // Giả sử người dùng làm 45 giờ
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        float luongCoDinh = 20000; // Giả sử lương cố định là 20,000 đồng/giờ
        float luongOT = 30000; // Giả sử lương làm thêm giờ là 30,000 đồng/giờ
        float luong = 0;
        if (soGioLam > 40)
        {
            luong = (40 * luongCoDinh) + ((soGioLam - 40) * luongOT);
        }
        else
        {
            luong = soGioLam * luongCoDinh;
        }

    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int tuoi = 20; // Giả sử người dùng nhập tuổi là 20
        bool coTheThanhVien = true; // Giả sử người dùng có thẻ thành viên
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if (tuoi > 18 && coTheThanhVien)
        {
            Debug.Log("Được vào câu lạc bộ");
        }
        else
        {
            Debug.Log("Không được vào câu lạc bộ");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float diemTrungBinh = 8.5f; // Giả sử người dùng nhập điểm trung bình là 8.5
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (diemTrungBinh >= 9.0f)
        {
            Debug.Log("Xuất sắc");
        }
        else if (diemTrungBinh >= 8.0f)
        {
            Debug.Log("Giỏi");
        }
        else if (diemTrungBinh >= 6.5f)
        {
            Debug.Log("Khá");
        }
        else if (diemTrungBinh >= 5.0f)
        {
            Debug.Log("Trung bình");
        }
        else
        {
            Debug.Log("Yếu");
        }
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        int soDien = 120; // Giả sử người dùng tiêu thụ 120 kWh
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        float giaDien = 0;
        if (soDien <= 100)
        {
            giaDien = soDien * 1500;
        }
        else
        {
            giaDien = (100 * 1500) + ((soDien - 100) * 2000);
        }
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        int soNamLamViec = 6; // Giả sử người dùng làm việc 6 năm
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        string danhGia = "Tốt"; // Giả sử đánh giá là "Tốt"
        if (soNamLamViec > 5 && danhGia == "Tốt")
        {
            Debug.Log("Đủ điều kiện thăng chức");
        }
        else
        {
            Debug.Log("Không đủ điều kiện thăng chức");
        }
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        float giaTriDonHang = 600000; // Giả sử giá trị đơn hàng là 600,000 đồng
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (giaTriDonHang >= 500000)
        {
            Debug.Log("Được miễn phí vận chuyển");
        }
        else
        {
            Debug.Log("Không được miễn phí vận chuyển");
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        float thuNhap = 10000000; // Giả sử người dùng nhập thu nhập là 10,000,000 đồng
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        float thue = 0;
        if (thuNhap <= 5000000)
        {
            thue = thuNhap * 0.05f; // 5% thuế
        }
        else if (thuNhap <= 10000000)
        {
            thue = 5000000* 0.05f + (thuNhap -5000000) * 0.1f; // 10% thuế
        }
        else
        {
            thue = 5000000 * 0.05f + (10000000 - 5000000) * 0.1f + (thuNhap - 10000000) * 0.15f; // 15% thuế
        }
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float diem1 = 8.0f; // Giả sử người dùng nhập điểm bài kiểm tra 1 là 8.0
        float diem2 = 7.5f; // Giả sử người dùng nhập điểm bài kiểm tra 2 là 7.5
        float diem3 = 9.0f; // Giả sử người dùng nhập điểm bài kiểm tra 3 là 9.0
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float diemTrungBinh = (diem1 + diem2 + diem3) / 3;
        if (diemTrungBinh >= 5.0f)
        {
            Debug.Log("Học sinh đạt yêu cầu");
        }
        else
        {
            Debug.Log("Học sinh không đạt yêu cầu");
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int soLuongHienTai = 50; // Giả sử người dùng có 50 sản phẩm
        // Kiểm tra nếu số lượng hàng hiện tại < 100 thì có thể nhập thêm hàng
        if (soLuongHienTai < 100)
        {
            Debug.Log("Có thể nhập thêm hàng");
        }
        else
        {
            Debug.Log("Không thể nhập thêm hàng");
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        int i = 15; // Giả sử người dùng nhập số 15
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if (i > 10)
        {
            Debug.Log("Số lớn hơn 10");
        }
        else
        {
            Debug.Log("Số không lớn hơn 10");
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        float diemTongKet = 8.5f; // Giả sử người dùng nhập điểm tổng kết là 8.5
        string diemHanhKiem = "Tốt"; // Giả sử người dùng nhập điểm hạnh kiểm là "Tốt"
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if (diemTongKet >= 8.0f && diemHanhKiem == "Tốt")
        {
            Debug.Log("Đủ điều kiện đăng ký khóa học nâng cao");
        }
        else
        {
            Debug.Log("Không đủ điều kiện đăng ký khóa học nâng cao");
        }
    }
}
