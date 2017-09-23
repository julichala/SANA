CREATE TABLE [dbo].[Products] (
    [Id]            INT            NOT NULL,
    [AddDate]       DATETIME       NOT NULL,
    [ModifiedDate]  DATETIME       NULL,
    [Ip]            NCHAR (20)     NULL,
    [ProductNumber] INT            NOT NULL,
    [Title]         NVARCHAR (200) NOT NULL,
    [Price]         DECIMAL (18)   NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);

