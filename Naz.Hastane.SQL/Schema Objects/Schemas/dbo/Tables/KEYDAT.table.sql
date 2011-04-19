CREATE TABLE [dbo].[KEYDAT] (
    [SLK]                   VARCHAR (2)   NOT NULL,
    [SLB]                   VARCHAR (10)  NOT NULL,
    [SLT]                   VARCHAR (150) NOT NULL,
    [SLX]                   FLOAT         NULL,
    [SLY]                   FLOAT         NULL,
    [SLZ]                   FLOAT         NULL,
    [SLVV]                  VARCHAR (100) NULL,
    [SLXX]                  VARCHAR (100) NULL,
    [SLYY]                  VARCHAR (100) NULL,
    [SLZZ]                  VARCHAR (100) NULL,
    [SLXA]                  VARCHAR (20)  NULL,
    [SLYA]                  VARCHAR (53)  NULL,
    [SLXB]                  VARCHAR (10)  NULL,
    [SEC]                   BIT           NULL,
    [lngAnaIslemID]         INT           NULL,
    [lngDoktorServisTipiID] INT           NULL,
    [Servis]                VARCHAR (50)  NULL,
    [Sekreter]              VARCHAR (50)  NULL,
    [SLBEk]                 NCHAR (10)    NULL
);

