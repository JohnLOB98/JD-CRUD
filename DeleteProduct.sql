CREATE PROCEDURE DeleteProduct
	
	-- Add the parameters for the stored procedure here
	@Product_ID	int	
		
AS
BEGIN
	
	-- Insert statements for procedure here
	DELETE TableProduct WHERE Product_ID = @Product_ID
	
END
GO
