CREATE TABLE [dbo].[NX_HAREKET_KALEMLERI] (
    [HAREKET_ID]    INT          NOT NULL,
    [MALZEME]       VARCHAR (15) NOT NULL,
    [MIKTAR]        FLOAT        NOT NULL,
    [ETIKET_FIYATI] FLOAT        NULL,
    [ECZACI_KARI]   FLOAT        NULL,
    [MAL_FAZLASI]   FLOAT        NULL,
    [MIADI]         DATETIME     NULL,
    [OZEL_INDIRIM]  FLOAT        NULL,
    [KDV]           FLOAT        NULL
);

