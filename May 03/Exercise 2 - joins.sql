create table products(
ProductID int primary key,
ProductName Varchar(100),
price decimal(10,2)
);

create table orders(
orderID INT PRIMARY KEY,
ProductID INT,
Quantity INT,
OrderDate DATE,
FOREIGN KEY (PRODUCTID) References Products(ProductID)
);

INSERT INTO Products(ProductID, ProductName,Price)
VALUES
(1,'Laptop',70000.00),
(2,'Smartphone',30000.00),
(3,'Tablet',70000.00),
(4,'Monitor',15000.00);

INSERT INTO Orders(OrderID,ProductID,Quantity,OrderDate)
VALUES
(101,1,2,'2024-12-01'),
(102,2,1,'2024-12-05'),
(103,3,3,'2024-12-10'),
(104,1,1,'2024-12-15'),
(105,4,2,'2024-12-20');

select orders.OrderID, products.ProductName, orders.Quantity, products.Price, (orders.quantity*products.price) AS TotalAmount, orders.OrderDate
FROM orders
RIGHT join products on orders.productid=products.productid;

select orders.OrderID, products.ProductName, orders.Quantity, products.Price, (orders.quantity*products.price) AS TotalAmount, orders.OrderDate
FROM orders
LEFT join products on orders.productid=products.productid;

SELECT PRODUCTS.ProductName, SUM(ORDERS.Quantity) AS TotalUnitsSold
FROM ORDERS
INNER JOIN PRODUCTS ON ORDERS.PRODUCTID=PRODUCTS.PRODUCTID
GROUP BY PRODUCTS.PRODUCTNAME;
