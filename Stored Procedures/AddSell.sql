CREATE PROCEDURE AddSell
	
	-- Add the parameters for the stored procedure here
	@ProductID	int,
	@SellDate	datetime
		
AS
BEGIN
	
	INSERT INTO [TableSellProduct] (ProductID, SellDate)
	VALUES (@ProductID, @SellDate)
    -- Insert statements for procedure here
	
END
GO