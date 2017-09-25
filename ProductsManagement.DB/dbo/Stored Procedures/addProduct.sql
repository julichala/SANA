-- =============================================
-- Author:		Andrés Chalarca
-- Create date: 2017/09/24
-- Description:	Create a product in the db
-- =============================================
CREATE PROCEDURE addProduct 
	-- Add the parameters for the stored procedure here
	@pProductNumber int = 0, 
	@pTitle nvarchar(200) = '',
	@pPrice decimal(18,0) = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

		INSERT INTO [dbo].[Products]
				   ([AddDate]
				   ,[ModifiedDate]
				   ,[Ip]
				   ,[ProductNumber]
				   ,[Title]
				   ,[Price])
			 VALUES
				   (GETDATE()
				   ,null
				   ,null
				   ,@pProductNumber
				   ,@pTitle
				   ,@pPrice)

END