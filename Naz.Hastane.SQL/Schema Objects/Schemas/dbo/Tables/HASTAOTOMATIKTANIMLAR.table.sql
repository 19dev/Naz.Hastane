CREATE TABLE [dbo].[HASTAOTOMATIKTANIMLAR] (
    [HOT_ID]        INT          IDENTITY (1, 1) NOT NULL,
    [OUTG]          CHAR (4)     NOT NULL,
    [OUTH]          CHAR (4)     NOT NULL,
    [TANIMGRUPCODE] VARCHAR (20) NOT NULL,
    [GUNBASLA]      INT          NOT NULL,
    [GUNBITIR]      INT          NOT NULL
);

