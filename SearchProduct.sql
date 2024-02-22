CREATE PROCEDURE SearchProduct

	@Product_ID int

AS
SELECT * FROM CRUD_JD.dbo.TableProduct WHERE  Product_ID LIKE CONCAT('%',@Product_ID, '%') 