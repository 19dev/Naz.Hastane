﻿


CREATE PROCEDURE NX_SP_DEPO_AC
(
	@KOD varchar(15),
	@TANIM varchar(2),
	@GRUP varchar(3),
	@AKOD varchar(2),
	@BKOD varchar(2),
	@KUTU_ADEDI float
)
 AS
	INSERT INTO ILACSARF (AKOD,TANIM,GRUP,CODE,NAME1,NAME2,KDV)
		SELECT @BKOD,TANIM,GRUP,CODE,NAME1,NAME2,KDV
		FROM ILACSARF
            		WHERE AKOD=@AKOD AND TANIM=@TANIM AND GRUP=@GRUP AND CODE=@KOD

	RETURN @@ROWCOUNT


