-- Bài tập 1: Tạo bảng Students

CREATE TABLE Students (
    Id        INT IDENTITY(1,1) PRIMARY KEY,
    Full_name NVARCHAR(100)     NOT NULL,
    Gender    VARCHAR(10),
    Age       INT,
    City      NVARCHAR(100),
    Weight    DECIMAL(10, 4)
);

-- Insert dữ liệu mẫu
INSERT INTO Students (Full_name, Gender, Age, City, Weight) VALUES
(N'Nguyen Thanh Nhan', 'Nam', 19, N'Can Tho',   56.5674),
(N'Pham Thu Huong',    'Nu',  20, N'Vinh Long', 72.4560),
(N'Nguyen Nhu Ngoc',   'Nu',  20, N'Soc Trang', 85.3870),
(N'Bui Thanh Bao',     'Nam', 19, N'Soc Trang', 49.3000),
(N'Le My Nhan',        'Nu',  22, N'Can Tho',   62.9630),
(N'Tan Thuc Bao',      'Nam', 35, N'An Giang',  55.5678),
(N'Trinh Giao Kim',    'Nam', 44, N'Bac Lieu',  67.3400);

SELECT * FROM Students;
