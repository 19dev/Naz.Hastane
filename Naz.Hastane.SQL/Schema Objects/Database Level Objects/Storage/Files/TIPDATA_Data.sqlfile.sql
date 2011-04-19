ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [TIPDATA_Data], FILENAME = '$(DefaultDataPath)$(DatabaseName)1.mdf', FILEGROWTH = 100 %) TO FILEGROUP [PRIMARY];

