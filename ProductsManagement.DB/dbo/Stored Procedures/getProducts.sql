-- =============================================
-- Author:		Andrés Chalarca
-- Create date: 2017/08/23
-- Description:	Get all the products
-- =============================================
CREATE PROCEDURE getProducts 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

		SELECT [Id]
			  ,[AddDate]
			  ,[ModifiedDate]
			  ,[Ip]
			  ,[ProductNumber]
			  ,[Title]
			  ,[Price]
		  FROM [dbo].[Products]


END