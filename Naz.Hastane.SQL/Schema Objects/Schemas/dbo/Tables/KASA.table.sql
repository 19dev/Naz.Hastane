CREATE TABLE [dbo].[KASA] (
    [MAKNO]          VARCHAR (7)   NOT NULL,
    [KNR]            VARCHAR (6)   NULL,
    [SNR]            VARCHAR (3)   NULL,
    [TARIH]          DATETIME      NOT NULL,
    [ACIKLAMA]       VARCHAR (150) NULL,
    [HFATURATARIHI]  VARCHAR (10)  NULL,
    [HFATURANO]      VARCHAR (10)  NULL,
    [HNEREYEODENDI]  VARCHAR (150) NULL,
    [MAKBUZNO]       VARCHAR (20)  NOT NULL,
    [MAKBUZTIPI]     VARCHAR (1)   NOT NULL,
    [ODEMESEKLI]     CHAR (1)      NOT NULL,
    [POSNO]          VARCHAR (2)   NULL,
    [MAKBUZGRUBU]    VARCHAR (2)   NULL,
    [TUTAR]          FLOAT         NOT NULL,
    [EKSIKODENEN]    FLOAT         NOT NULL,
    [BORCALACAK]     CHAR (1)      NOT NULL,
    [FATURANO]       VARCHAR (7)   NULL,
    [ISIPTAL]        VARCHAR (1)   NULL,
    [VEZNE]          CHAR (2)      NOT NULL,
    [USER_ID]        VARCHAR (20)  NOT NULL,
    [DATE_CREATE]    DATETIME      NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL,
    [ce]             CHAR (1)      NULL,
    [tutardoviz]     FLOAT         NULL,
    [dovizcinsi]     VARCHAR (50)  NULL,
    [HESAPKODU]      VARCHAR (50)  NULL,
    [ALTHESAPKODU]   VARCHAR (50)  NULL,
    [TIPTAL]         VARCHAR (1)   NULL,
    [PCARIKOD]       VARCHAR (10)  NULL,
    [HESAPCODE]      VARCHAR (50)  NULL,
    [AKTAR]          BIT           NULL,
    [SERVIS]         VARCHAR (2)   NULL,
    [ARZT]           VARCHAR (4)   NULL,
    [KATILIM]        VARCHAR (1)   NULL
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_DefaultView', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Filter', @value = NULL, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_OrderBy', @value = NULL, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_OrderByOn', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Orientation', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_TableMaxRecords', @value = 10000, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SNR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TARIH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TARIH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 2220, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TARIH';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ACIKLAMA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ACIKLAMA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 675, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ACIKLAMA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURATARIHI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURATARIHI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 480, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURATARIHI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 570, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HFATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HNEREYEODENDI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HNEREYEODENDI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 555, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HNEREYEODENDI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZTIPI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZTIPI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZTIPI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ODEMESEKLI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ODEMESEKLI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 660, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ODEMESEKLI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'POSNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'POSNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = 900, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'POSNO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZGRUBU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZGRUBU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'MAKBUZGRUBU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TUTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TUTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TUTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'EKSIKODENEN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'EKSIKODENEN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'EKSIKODENEN';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'BORCALACAK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'BORCALACAK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'BORCALACAK';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'FATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'FATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'FATURANO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ISIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ISIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ISIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'VEZNE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'VEZNE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'VEZNE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_CREATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_CREATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_CREATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'USER_ID_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'DATE_UPDATE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ce';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ce';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ce';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'tutardoviz';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'tutardoviz';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'tutardoviz';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'dovizcinsi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'dovizcinsi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'dovizcinsi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ALTHESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ALTHESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ALTHESAPKODU';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'TIPTAL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'PCARIKOD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'PCARIKOD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'PCARIKOD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPCODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPCODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'HESAPCODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'AKTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'AKTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'AKTAR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SERVIS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SERVIS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'SERVIS';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ARZT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ARZT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'ARZT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnHidden', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KATILIM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnOrder', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KATILIM';


GO
EXECUTE sp_addextendedproperty @name = N'MS_ColumnWidth', @value = -1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'KASA', @level2type = N'COLUMN', @level2name = N'KATILIM';

