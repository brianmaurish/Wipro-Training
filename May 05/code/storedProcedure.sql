use wiprodb;

CREATE PROCEDURE GetProducts
AS
Begin
SELECT * FROM dbo.products;
END;

exec GetProducts;

SELECT * FROM PRODUCTS;

CREATE PROCEDURE HigherEndProducts
AS
Begin
SELECT * FROM PRODUCTS
WHERE PRICE>60000.00;
END;

exec HigherEndProducts;

CREATE PROCEDURE GetOrdersByProcuct
	@ProductID INT
AS 
BEGIN
	SELECT
		o.orderid,
		o.quantity,
		o.orderdate,
		p.productname,
		p.price
	from orders o
	inner join products p on p.productid=p.productid
	where o.productid=@productid;
end;

exec GetOrdersByProcuct @productid=1;