
create view [dbo].[kurumtipleri] as 
SELECT   sec,SLB, SLT
FROM         dbo.KEYDAT
WHERE     (SLK = '36')



