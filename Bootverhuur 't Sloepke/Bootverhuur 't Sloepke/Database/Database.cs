﻿using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    abstract class Database

    {
        protected static OracleConnection Con = new OracleConnection
       {
           ConnectionString =
                    "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = dbi347373; PASSWORD = Testpassword1234"
       };

        protected OracleCommand Cmd = new OracleCommand
            {
                BindByName = true,
                Connection = Con
            };
}
}
