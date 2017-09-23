CREATE TABLE [dbo].[ProductsCategories] (
    [IdProduct]  INT NOT NULL,
    [IdCategory] INT NOT NULL,
    CONSTRAINT [FK_ProductsCategories_Categories] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_ProductsCategories_Products] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Products] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Contains the relationship between categories and products', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ProductsCategories';

