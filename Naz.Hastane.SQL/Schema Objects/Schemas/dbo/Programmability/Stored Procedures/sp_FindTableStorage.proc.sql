-- =============================================
-- Author:		Aydın Sakar
-- Create date: 2/10/2011
-- Description:	Find Table Storage
-- =============================================
CREATE PROCEDURE sp_FindTableStorage 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	
	declare @RowCount int, @tablename varchar(100)

	declare @Tables table (

		PK int IDENTITY(1,1),

		tablename varchar(100),

		processed bit

	)

	INSERT into @Tables (tablename)

		SELECT TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE' and TABLE_NAME not like 'dt%' order by TABLE_NAME asc


	declare @Space table (

		 name varchar(100), rows nvarchar(100), reserved varchar(100), data varchar(100), index_size varchar(100), unused varchar(100)

	)

	select top 1 @tablename = tablename from @Tables where processed is null

	SET @RowCount = 1

		WHILE (@RowCount <> 0)

			BEGIN

				insert into @Space exec sp_spaceused @tablename

				update @Tables set processed = 1 where tablename = @tablename

				select top 1 @tablename = tablename from @Tables where processed is null

				SET @RowCount = @@RowCount

			END


	update @Space set data = replace(data, ' KB', '')

	update @Space set data = convert(int, data)/1000

	--update @Space set data = data + ' MB'

	update @Space set reserved = replace(reserved, ' KB', '')

	update @Space set reserved = convert(int, reserved)/1000

	--update @Space set reserved = reserved + ' MB'

	update @Space set index_size = replace(index_size, ' KB', '')

	update @Space set index_size = convert(int, index_size)/1000

	--update @Space set index_size = index_size + ' MB'

	update @Space set unused = replace(unused, ' KB', '')

	update @Space set unused = convert(int, unused)/1000

	drop table TableSizes

	select * into TableSizes from @Space order by convert(int, replace(data, ' MB', '')) desc
	--select * into TableSizes from @Space order by data desc

END
