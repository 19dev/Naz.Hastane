CREATE procedure Mesut
AS
Declare @Arman varchar(10)
set @Arman = (Select Bkodu from Hizmet where TANIM = '11' AND GRUP = '019' AND CODE ='P600040 EK9')
Update Hizmet Set CODE = 'E ' & @Arman   WHERE TANIM = '11' AND GRUP = '019' AND BKODU = 'P600040'
