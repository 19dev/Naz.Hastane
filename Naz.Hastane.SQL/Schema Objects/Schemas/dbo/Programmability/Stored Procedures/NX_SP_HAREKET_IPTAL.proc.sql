﻿


CREATE PROCEDURE NX_SP_HAREKET_IPTAL
(
		@HAREKET_ID int
	)
AS
	UPDATE NX_HAREKETLER SET DURUM='İ' /*İPTAL EDİLDİ*/ WHERE HAREKET_ID=@HAREKET_ID
	RETURN @@ROWCOUNT

