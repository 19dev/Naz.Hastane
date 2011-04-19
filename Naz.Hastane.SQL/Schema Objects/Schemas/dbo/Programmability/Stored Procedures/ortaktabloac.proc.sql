


CREATE PROCEDURE [dbo].[ortaktabloac] 
AS

CREATE TABLE [muh_login] (
	[user] [nchar] (20) COLLATE Turkish_CI_AS NOT NULL ,
	[password] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[default] [bit] NULL ,
	[donem] [nchar] (20) COLLATE Turkish_CI_AS NULL ,
	[parametreler] [bit] NULL ,
	CONSTRAINT [PK_muh_login] PRIMARY KEY  CLUSTERED 
	(
		[user]
	)  ON [PRIMARY] 
) ON [PRIMARY]



CREATE TABLE [muh_donemler] (
	[donem] [nchar] (10) COLLATE Turkish_CI_AS NOT NULL ,
	[donemadi] [nchar] (40) COLLATE Turkish_CI_AS NOT NULL ,
	[tarih1] [datetime] NULL ,
	[tarih2] [datetime] NULL ,
	[secili] [bit] NULL ,
	CONSTRAINT [PK_muh_donemler] PRIMARY KEY  CLUSTERED 
	(
		[donem]
	)  ON [PRIMARY] 
) ON [PRIMARY]




CREATE TABLE [muh_dovizkurlari] (
	[doviz] [char] (50) COLLATE Turkish_CI_AS NOT NULL ,
	[alis] [float] NULL ,
	[satis] [float] NULL ,
	[tarih] [datetime] NULL ,
	CONSTRAINT [PK_dovizkurlari] PRIMARY KEY  CLUSTERED 
	(
		[doviz]
	)  ON [PRIMARY] 
) ON [PRIMARY]


