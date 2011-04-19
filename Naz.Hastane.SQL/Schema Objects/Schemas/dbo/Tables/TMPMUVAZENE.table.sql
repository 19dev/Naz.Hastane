CREATE TABLE [dbo].[TMPMUVAZENE] (
    [SERVIS]         VARCHAR (2)  NOT NULL,
    [SERVIS_ADI]     VARCHAR (50) NOT NULL,
    [KADRO_YATAK]    INT          NOT NULL,
    [MEVCUT_YATAK]   INT          NOT NULL,
    [YATAN_HASTA]    INT          NOT NULL,
    [UCRETSIZ_TAB]   INT          NOT NULL,
    [UCRETSIZ_OLEN]  INT          NOT NULL,
    [UCRETSIZ_YTGUN] INT          NOT NULL,
    [UCRETLI_TAB]    INT          NOT NULL,
    [UCRETLI_OLEN]   INT          NOT NULL,
    [UCRETLI_YTGUN]  INT          NOT NULL,
    [TOPLAM_TAB]     INT          NOT NULL,
    [TOPLAM_OLEN]    INT          NOT NULL,
    [TOPLAM_YTGUN]   INT          NOT NULL,
    [AMELIYAT_BUYUK] INT          NOT NULL,
    [AMELIYAT_ORTA]  INT          NOT NULL,
    [AMELIYAT_KUCUK] INT          NOT NULL,
    [DOGUM_NORMAL]   INT          NOT NULL,
    [DOGUM_MUD]      INT          NOT NULL,
    [POLSAYISI]      INT          NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL
);

