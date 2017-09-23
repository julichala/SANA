CREATE TABLE [dbo].[OrderProducts] (
    [IdOrder]   INT NOT NULL,
    [idProduct] INT NOT NULL,
    CONSTRAINT [FK_OrderProducts_Orders] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Orders] ([Id]),
    CONSTRAINT [FK_OrderProducts_Products] FOREIGN KEY ([idProduct]) REFERENCES [dbo].[Products] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Contain the relatinship between Orders and Products.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderProducts';

