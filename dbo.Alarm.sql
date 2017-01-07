CREATE TABLE [dbo].[Alarm] (
    [Id]      NVARCHAR (50)  NOT NULL,
    [TagID]   NVARCHAR (MAX) NULL,
    [Message] NVARCHAR (MAX) NULL,
    [Time]    DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

