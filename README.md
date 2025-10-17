# QL1
Ứng Dụng Quản Lý 1

## Thông Tin Ứng Dụng
- Phiên Bản: 1.0
- Tác Giả: maidinhthaison
- Ngày Phát Hành: 2024-09-15
- Mô Tả: Ứng dụng quản lý tiệm tạp hóa đơn giản, giúp theo dõi hàng hóa, khách hàng và doanh thu, thống kê báo cáo.
## Kỹ thuật Sử Dụng

- Ngôn Ngữ: Visual Basic .NET
- Net Framework: 8.0
- Cơ Sở Dữ Liệu: Microsoft Access
- Môi Trường Phát Triển: Visual Studio 2022
- Giao Diện: Windows Forms
- Thư Viện: System.Data.OleDb
- Quản Lý Gói: NuGet Package Manager
- Singleton Pattern: Sử dụng để quản lý kết nối cơ sở dữ liệu
- MVC Pattern: Áp dụng để tách biệt giao diện người dùng, logic nghiệp vụ và truy cập dữ liệu

## Chức Năng Chính
- Nhân viên bán hàng
1. Bán hàng cho khách, xuất hóa đơn bán hàng.
2. Xem thông tin hóa đơn bán trong ngày.
3. Xem danh sách sản phẩm: bảng giá, số lượng, …
4. Tìm kiếm sản phẩm trong cửa hàng.
5. Tạo/tìm kiếm danh sách khách hàng.
6. Thống kê sản phẩm trong cửa hàng.
7. Thống kê doanh thu và sản phẩm mà nhân viên đó bán được trong tháng/quí/năm.
8. Xem/Sửa thông tin cá nhân

- Chủ quán
1. Thêm/xóa/sửa thông tin nhân viên.
2. Khóa tài khoản nhân viên.
3. Thêm/xóa/sửa thông tin sản phẩm.
4. Xem danh sách sản phẩm: bảng giá, số lượng, …
5. Xem danh sách các sản phẩm hết hàng/hết hạn.
6. Thêm/xóa/sửa khu vực.
7. Thêm/xóa/sửa nhà cung cấp. Mỗi nhà cung cấp có danh sách sản phẩm và giá bán
mà nhà cung cấp đó bán.
8. Nhập hàng: tạo và quản lý phiếu nhập hàng, quản lý nợ, …
9. Quản lý phiếu chi.
10. Bán hàng và xuất hóa đơn.
11. Xem danh sách hóa đơn.
12. Tìm kiểm sản phẩm theo nhiều tiêu chí kết hợp.
13. Xem/sửa thông tin cá nhân.
14. Thống kê: 
a. Doanh thu trong tháng/quý/năm 
b. Lợi nhuận trong tháng/quý/năm 
c. Doanh thu theo sản phẩm trong tháng/quý/năm 
d. Lợi nhuận theo sản phẩm trong tháng/quý/năm 
e. Số lượng bán ra của một sản phẩm theo tháng.
f. Các sản phẩm bán chạy
15. Phân quyền người dùng: tạo/sửa/xóa loại người dùng, thêm/xóa chức năng cho 
mỗi loại người dùng.
16. Backup/restore dữ liệu



