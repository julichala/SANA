CREATE TABLE [dbo].[Orders] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [AddDate]      DATETIME       NOT NULL,
    [ModifiedDate] DATETIME       NULL,
    [IdCustomer]   INT            NOT NULL,
    [OrderNotes]   NVARCHAR (200) NULL,
    [Ip]           NVARCHAR (20)  NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].[Customers] ([Id])
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Contains the customer''s orders', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Orders';

