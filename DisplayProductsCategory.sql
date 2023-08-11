-- Второе задание.
-- Создание таблиц
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255)
);

-- Создание связуещей таблицы т.к. связь "многие ко многим".
CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Вставка данных в таблицы
INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, 'Category1'),
       (2, 'Category2'),
       (3, 'Category3');

INSERT INTO Products (ProductID, ProductName)
VALUES (1, 'Product1'),
       (2, 'Product2'),
       (3, 'Product3');

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES (1, 1), -- Продукт 1 принадлежит Категории 1 
       (1, 3), -- Продукт 1 принадлежит Категории 3
       (3, 3); -- Продукт 3 принадлежит Категории 3
			   -- Продукт 2 без Категории.

-- Вывод Продуктов и соответсвующих Категорий.
SELECT P.ProductName, ISNULL(C.CategoryName, 'No Category') AS CategoryName
FROM Products P
LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;