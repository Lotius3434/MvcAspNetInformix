﻿using MvcAspNetInformix.Models;

namespace MvcAspNetInformix.DbConnection
{
    public interface IMasterEditDataTable
    {
        ResulResponse EditDataTable(SqlResult sqlResult);
    }
}
