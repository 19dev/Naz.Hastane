﻿CREATE TABLE [dbo].[HIZMET_SUBAT] (
    [TANIM]          VARCHAR (2)   NOT NULL,
    [GRUP]           VARCHAR (3)   NOT NULL,
    [CODE]           VARCHAR (15)  NOT NULL,
    [OZELKOD]        VARCHAR (10)  NOT NULL,
    [NAME1]          VARCHAR (100) NOT NULL,
    [KDV]            FLOAT         NOT NULL,
    [BUT]            VARCHAR (50)  NULL,
    [PARSAYI]        INT           NULL,
    [MATERYAL]       VARCHAR (20)  NULL,
    [SIRANO]         VARCHAR (20)  NULL,
    [LABTIPI]        CHAR (1)      NULL,
    [GELIRGRUBU]     VARCHAR (10)  NULL,
    [OTOISLE]        CHAR (1)      NOT NULL,
    [DRYUZDE]        FLOAT         NOT NULL,
    [PHYUZDE]        FLOAT         NOT NULL,
    [HAVUZ]          VARCHAR (4)   NULL,
    [KKODU]          VARCHAR (20)  NULL,
    [APHIZMET]       VARCHAR (1)   NULL,
    [PYUZDE]         FLOAT         NOT NULL,
    [PDAHIL]         VARCHAR (1)   NOT NULL,
    [PAKET]          VARCHAR (1)   NOT NULL,
    [BKODU]          VARCHAR (15)  NULL,
    [YTKHIZMET]      VARCHAR (1)   NOT NULL,
    [HREFAKAT]       VARCHAR (1)   NOT NULL,
    [HMALIYET]       FLOAT         NULL,
    [CODE1]          VARCHAR (20)  NULL,
    [MEDGONDER]      VARCHAR (1)   NULL,
    [HKILIT]         VARCHAR (1)   NULL,
    [ARZT]           VARCHAR (4)   NULL,
    [ANHIZ]          VARCHAR (1)   NULL,
    [ANAHIZ]         VARCHAR (1)   NULL,
    [IKINCIHIZ]      VARCHAR (1)   NULL,
    [PAKETGRUBU]     VARCHAR (10)  NULL,
    [P]              VARCHAR (1)   NULL,
    [SATISF00]       FLOAT         NOT NULL,
    [KSATISF00]      FLOAT         NOT NULL,
    [SATISF01]       FLOAT         NULL,
    [KSATISF01]      FLOAT         NULL,
    [SATISF02]       FLOAT         NULL,
    [KSATISF02]      FLOAT         NULL,
    [SATISF03]       FLOAT         NULL,
    [KSATISF03]      FLOAT         NULL,
    [SATISF04]       FLOAT         NULL,
    [KSATISF04]      FLOAT         NULL,
    [SATISF05]       FLOAT         NULL,
    [KSATISF05]      FLOAT         NULL,
    [SATISF06]       FLOAT         NULL,
    [KSATISF06]      FLOAT         NULL,
    [SATISF07]       FLOAT         NULL,
    [KSATISF07]      FLOAT         NULL,
    [SATISF08]       FLOAT         NULL,
    [KSATISF08]      FLOAT         NULL,
    [SATISF09]       FLOAT         NULL,
    [KSATISF09]      FLOAT         NULL,
    [SATISF10]       FLOAT         NULL,
    [KSATISF10]      FLOAT         NULL,
    [SATISF11]       FLOAT         NULL,
    [KSATISF11]      FLOAT         NULL,
    [SATISF12]       FLOAT         NULL,
    [KSATISF12]      FLOAT         NULL,
    [SATISF13]       FLOAT         NULL,
    [KSATISF13]      FLOAT         NULL,
    [SATISF14]       FLOAT         NULL,
    [KSATISF14]      FLOAT         NULL,
    [SATISF15]       FLOAT         NULL,
    [KSATISF15]      FLOAT         NULL,
    [SATISF16]       FLOAT         NULL,
    [KSATISF16]      FLOAT         NULL,
    [SATISF17]       FLOAT         NULL,
    [KSATISF17]      FLOAT         NULL,
    [SATISF18]       FLOAT         NULL,
    [KSATISF18]      FLOAT         NULL,
    [SATISF19]       FLOAT         NULL,
    [KSATISF19]      FLOAT         NULL,
    [SATISF20]       FLOAT         NULL,
    [KSATISF20]      FLOAT         NULL,
    [SATISF21]       FLOAT         NULL,
    [KSATISF21]      FLOAT         NULL,
    [SATISF22]       FLOAT         NULL,
    [KSATISF22]      FLOAT         NULL,
    [SATISF23]       FLOAT         NULL,
    [KSATISF23]      FLOAT         NULL,
    [SATISF24]       FLOAT         NULL,
    [KSATISF24]      FLOAT         NULL,
    [SATISF25]       FLOAT         NULL,
    [KSATISF25]      FLOAT         NULL,
    [SATISF26]       FLOAT         NULL,
    [KSATISF26]      FLOAT         NULL,
    [SATISF27]       FLOAT         NULL,
    [KSATISF27]      FLOAT         NULL,
    [SATISF28]       FLOAT         NULL,
    [KSATISF28]      FLOAT         NULL,
    [SATISF29]       FLOAT         NULL,
    [KSATISF29]      FLOAT         NULL,
    [SATISF30]       FLOAT         NULL,
    [KSATISF30]      FLOAT         NULL,
    [SATISF31]       FLOAT         NULL,
    [KSATISF31]      FLOAT         NULL,
    [SATISF32]       FLOAT         NULL,
    [KSATISF32]      FLOAT         NULL,
    [SATISF33]       FLOAT         NULL,
    [KSATISF33]      FLOAT         NULL,
    [SATISF34]       FLOAT         NULL,
    [KSATISF34]      FLOAT         NULL,
    [SATISF35]       FLOAT         NULL,
    [KSATISF35]      FLOAT         NULL,
    [SATISF36]       FLOAT         NULL,
    [KSATISF36]      FLOAT         NULL,
    [SATISF37]       FLOAT         NULL,
    [KSATISF37]      FLOAT         NULL,
    [SATISF38]       FLOAT         NULL,
    [KSATISF38]      FLOAT         NULL,
    [SATISF39]       FLOAT         NULL,
    [KSATISF39]      FLOAT         NULL,
    [SATISF40]       FLOAT         NULL,
    [KSATISF40]      FLOAT         NULL,
    [SATISF41]       FLOAT         NULL,
    [KSATISF41]      FLOAT         NULL,
    [SATISF42]       FLOAT         NULL,
    [KSATISF42]      FLOAT         NULL,
    [SATISF43]       FLOAT         NULL,
    [KSATISF43]      FLOAT         NULL,
    [SATISF44]       FLOAT         NULL,
    [KSATISF44]      FLOAT         NULL,
    [SATISF45]       FLOAT         NULL,
    [KSATISF45]      FLOAT         NULL,
    [SATISF46]       FLOAT         NULL,
    [KSATISF46]      FLOAT         NULL,
    [SATISF47]       FLOAT         NULL,
    [KSATISF47]      FLOAT         NULL,
    [SATISF48]       FLOAT         NULL,
    [KSATISF48]      FLOAT         NULL,
    [SATISF49]       FLOAT         NULL,
    [KSATISF49]      FLOAT         NULL,
    [SATISF50]       FLOAT         NULL,
    [KSATISF50]      FLOAT         NULL,
    [SATISF51]       FLOAT         NULL,
    [KSATISF51]      FLOAT         NULL,
    [SATISF52]       FLOAT         NULL,
    [KSATISF52]      FLOAT         NULL,
    [SATISF53]       FLOAT         NULL,
    [KSATISF53]      FLOAT         NULL,
    [SATISF54]       FLOAT         NULL,
    [KSATISF54]      FLOAT         NULL,
    [SATISF55]       FLOAT         NULL,
    [KSATISF55]      FLOAT         NULL,
    [SATISF56]       FLOAT         NULL,
    [KSATISF56]      FLOAT         NULL,
    [SATISF57]       FLOAT         NULL,
    [KSATISF57]      FLOAT         NULL,
    [SATISF58]       FLOAT         NULL,
    [KSATISF58]      FLOAT         NULL,
    [SATISF59]       FLOAT         NULL,
    [KSATISF59]      FLOAT         NULL,
    [SATISF60]       FLOAT         NULL,
    [KSATISF60]      FLOAT         NULL,
    [SATISF61]       FLOAT         NULL,
    [KSATISF61]      FLOAT         NULL,
    [SATISF62]       FLOAT         NULL,
    [KSATISF62]      FLOAT         NULL,
    [SATISF63]       FLOAT         NULL,
    [KSATISF63]      FLOAT         NULL,
    [SATISF64]       FLOAT         NULL,
    [KSATISF64]      FLOAT         NULL,
    [SATISF65]       FLOAT         NULL,
    [KSATISF65]      FLOAT         NULL,
    [SATISF66]       FLOAT         NULL,
    [KSATISF66]      FLOAT         NULL,
    [SATISF67]       FLOAT         NULL,
    [KSATISF67]      FLOAT         NULL,
    [SATISF68]       FLOAT         NULL,
    [KSATISF68]      FLOAT         NULL,
    [SATISF69]       FLOAT         NULL,
    [KSATISF69]      FLOAT         NULL,
    [SATISF70]       FLOAT         NULL,
    [KSATISF70]      FLOAT         NULL,
    [SATISF71]       FLOAT         NULL,
    [KSATISF71]      FLOAT         NULL,
    [SATISF72]       FLOAT         NULL,
    [KSATISF72]      FLOAT         NULL,
    [SATISF73]       FLOAT         NULL,
    [KSATISF73]      FLOAT         NULL,
    [SATISF74]       FLOAT         NULL,
    [KSATISF74]      FLOAT         NULL,
    [SATISF75]       FLOAT         NULL,
    [KSATISF75]      FLOAT         NULL,
    [SATISF76]       FLOAT         NULL,
    [KSATISF76]      FLOAT         NULL,
    [SATISF77]       FLOAT         NULL,
    [KSATISF77]      FLOAT         NULL,
    [SATISF78]       FLOAT         NULL,
    [KSATISF78]      FLOAT         NULL,
    [SATISF79]       FLOAT         NULL,
    [KSATISF79]      FLOAT         NULL,
    [SATISF80]       FLOAT         NULL,
    [KSATISF80]      FLOAT         NULL,
    [SATISF81]       FLOAT         NULL,
    [KSATISF81]      FLOAT         NULL,
    [SATISF82]       FLOAT         NULL,
    [KSATISF82]      FLOAT         NULL,
    [SATISF83]       FLOAT         NULL,
    [KSATISF83]      FLOAT         NULL,
    [SATISF84]       FLOAT         NULL,
    [KSATISF84]      FLOAT         NULL,
    [SATISF85]       FLOAT         NULL,
    [KSATISF85]      FLOAT         NULL,
    [SATISF86]       FLOAT         NULL,
    [KSATISF86]      FLOAT         NULL,
    [SATISF87]       FLOAT         NULL,
    [KSATISF87]      FLOAT         NULL,
    [SATISF88]       FLOAT         NULL,
    [KSATISF88]      FLOAT         NULL,
    [SATISF89]       FLOAT         NULL,
    [KSATISF89]      FLOAT         NULL,
    [SATISF90]       FLOAT         NULL,
    [KSATISF90]      FLOAT         NULL,
    [SATISF91]       FLOAT         NULL,
    [KSATISF91]      FLOAT         NULL,
    [SATISF92]       FLOAT         NULL,
    [KSATISF92]      FLOAT         NULL,
    [SATISF93]       FLOAT         NULL,
    [KSATISF93]      FLOAT         NULL,
    [SATISF94]       FLOAT         NULL,
    [KSATISF94]      FLOAT         NULL,
    [SATISF95]       FLOAT         NULL,
    [KSATISF95]      FLOAT         NULL,
    [SATISF96]       FLOAT         NULL,
    [KSATISF96]      FLOAT         NULL,
    [SATISF97]       FLOAT         NULL,
    [KSATISF97]      FLOAT         NULL,
    [SATISF98]       FLOAT         NULL,
    [KSATISF98]      FLOAT         NULL,
    [SATISF99]       FLOAT         NULL,
    [KSATISF99]      FLOAT         NULL,
    [USER_ID]        VARCHAR (50)  NULL,
    [DATE_CREATE]    DATETIME      NULL,
    [USER_ID_UPDATE] VARCHAR (50)  NULL,
    [DATE_UPDATE]    VARCHAR (50)  NULL
);

