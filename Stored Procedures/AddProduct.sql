CREATE PROCEDURE AddProduct
	
	-- Add the parameters for the stored procedure here
	@Product_ID	int,
    @ItemName	nvarchar(50),	
	@Design	nvarchar(150),	
	@Color	nvarchar(50),	
	@ItemDate	datetime,	
	@WarrantlyType	nvarchar(50)	
		
AS
BEGIN
	
	INSERT INTO [TableProduct] (Product_ID, ItemName, Design, Color, ItemDate, WarrantlyType)
	VALUES (@Product_ID, @ItemName, @Design, @Color, @ItemDate, @WarrantlyType)
    -- Insert statements for procedure here
	
END
GO
