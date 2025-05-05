use wiprodb;

CREATE PROCEDURE GetProductRevenue
	@ProductID INT
AS
BEGIN
	SELECT o.orderdate, (o.quantity * p.price) AS TotalRevenue
	FROM orders o
	inner join products p on o.productid=p.productid
	WHERE o.productid=@productid;
END;

EXEC GetProductRevenue @ProductID = 1;

