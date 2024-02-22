CREATE PROCEDURE SeeSells
AS
BEGIN

	--t1 is the principal and t2 is the secondary
	SELECT SellID, ProductID, SellDate, ItemName, Design, Color, WarrantlyType FROM [TableSellProduct] t1 
	INNER JOIN [TableProduct] t2
	ON t1.ProductID = t2.Product_ID

END 
GO