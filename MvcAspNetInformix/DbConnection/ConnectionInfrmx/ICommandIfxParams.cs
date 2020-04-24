using IBM.Data.Informix;
using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAspNetInformix.DbConnection.ConnectionInfrmx
{
    public interface ICommandIfxParams
    {
        void CreateParams(IfxCommand ifxCommand, SqlResult sqlResult);
    }
}
