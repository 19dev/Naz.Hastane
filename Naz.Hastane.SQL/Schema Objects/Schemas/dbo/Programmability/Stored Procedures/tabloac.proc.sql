


CREATE PROCEDURE [dbo].[tabloac] 
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


