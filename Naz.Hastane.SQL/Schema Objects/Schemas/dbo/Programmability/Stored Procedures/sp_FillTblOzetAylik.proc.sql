-- =============================================
-- Author:		Aydın Sakar
-- Create date: 4/2/2011
-- Description:	Run Ozet Reports
-- =============================================
CREATE PROCEDURE [dbo].[sp_FillTblOzetAylik] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	exec sp_FillTblOzet '20110101', '20110401', '2011',
		'20100101', '20100401', '2010',
		'20090101', '20090401', '2009'
		
	exec sp_FillTblOzetAYPAy '2011'
	exec sp_FillTblOzetAnaIslemAy '2011'
	exec sp_FillTblOzetYatakServisAy '2011'
	exec sp_FillTblOzetAnaIslem '2011','2010','2009'
	exec sp_FillTblOzetAYP '2011','2010','2009'
	exec sp_FillTblOzetDoktor '2011','2010','2009'
	exec sp_FillTblOzetKurum '2011','2010','2009'
	exec sp_FillTblOzetServis '2011','2010','2009'
	exec sp_FillTblOzetAYPAnaIslem '2011','2010','2009'
	exec sp_FillTblOzetAYPKurum '2011','2010','2009'
	exec sp_FillTblOzetDoktorAnaIslem '2011','2010','2009'
	exec sp_FillTblOzetHastaneServisAnaIslem '2011','2010','2009'
	exec sp_FillTblOzetKurumAnaIslem '2011','2010','2009'
	exec sp_FillTblOzetServisAnaIslem '2011','2010','2009'
	
END
