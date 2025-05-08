use wiprodb;

create procedure CheckProductExists
	 @ProductID INT
AS
BEGIN
	if exists (select 1 from products where ProductID=@ProductID)
		PRINT 'Product Exists';
	else
		PRINT 'Product Not Found';
END
	
EXEC CheckProductExists @ProductID = 2;
