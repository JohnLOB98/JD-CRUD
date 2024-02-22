CREATE PROCEDURE UpdateProduct
	
	-- Add the parameters for the stored procedure here
	@Product_ID	int,
    @ItemName	nvarchar(50),	
	@Design	nvarchar(150),	
	@Color	nvarchar(50),	
	@ItemDate datetime,	
	@WarrantlyType	nvarchar(50)	
		
AS
BEGIN
	
	UPDATE TableProduct SET ItemName = @ItemName, Design = @Design, Color = @Color, ItemDate = @ItemDate, WarrantlyType = @WarrantlyType
    WHERE Product_ID = @Product_ID 
	RETURN @@Identity
    -- Insert statements for procedure here
	
END
GO
