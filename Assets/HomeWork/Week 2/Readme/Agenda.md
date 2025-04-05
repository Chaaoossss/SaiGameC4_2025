# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
Khởi tạo:
Awake()	Chạy trước Start(), khởi tạo dữ liệu.
Start()	Chạy một lần khi game bắt đầu.
Cập nhật
Update()	Chạy mỗi frame (dùng cho logic game).
FixedUpdate()	Chạy cố định theo chu kỳ vật lý.
LateUpdate()	Chạy sau Update(), thường dùng cho camera.
Va chạm
OnCollisionEnter()	Khi va chạm với vật thể khác.
OnTriggerEnter()	Khi đi vào vùng Trigger.
Input
OnMouseDown()	Khi click vào GameObject.
OnMouseOver()	Khi di chuột qua GameObject.
Hủy
OnDestroy()	Khi GameObject bị xóa.
UI & Gizmos
OnGUI()	Vẽ UI bằng GUI.
OnDrawGizmos()	Vẽ Gizmos trong Scene.
Các hàm này thuộc MonoBehaviour và Unity tự động gọi chúng khi cần.
## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau
1. Sắp xếp nổi bọt (Bubble Sort)
2. Sắp xếp chọn (Selection Sort)
3. Sắp xếp chèn (Insertion Sort)
4. Sắp xếp nhanh (Quick Sort)
5. Sắp xếp trộn (Merge Sort)
6. Sắp xếp đếm (Counting Sort)
7. Sắp xếp bằng thư viện có sẵn trong Unity (Array.Sort & List.Sort)
## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học
Refer to Sort Script

## 4. Thực Hiện Random Cho Current HP

- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game.

## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.

## 6. Tìm Enemy Có Current HP Lớn Nhất

- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md
