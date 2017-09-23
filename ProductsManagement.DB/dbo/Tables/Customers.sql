CREATE TABLE [dbo].[Customers] (
    [Id]           INT            NOT NULL,
    [AddDate]      DATETIME       NOT NULL,
    [ModifiedDate] DATETIME       NULL,
    [Ip]           NVARCHAR (20)  NULL,
    [Name]         NVARCHAR (200) NULL,
    [Adress]       NVARCHAR (200) NULL,
    [MobilePhone]  NVARCHAR (200) NULL,
    [Email]        NVARCHAR (200) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Contains the information about the customers', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Customers';

