ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [TIPDATA_Log], FILENAME = '$(DefaultLogPath)$(DatabaseName)1_1.ldf', FILEGROWTH = 10240 KB);

