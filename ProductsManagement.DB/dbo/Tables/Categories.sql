CREATE TABLE [dbo].[Categories] (
    [Id]           INT            NOT NULL,
    [AddDate]      DATETIME       NOT NULL,
    [ModifiedDate] DATETIME       NULL,
    [Ip]           NVARCHAR (20)  NULL,
    [Name]         NVARCHAR (50)  NOT NULL,
    [Description]  NVARCHAR (200) NULL,
    [Subcategory]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Describe the category of the product', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Categories';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ProductDescription', @value = N'Describe the products', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Categories';

