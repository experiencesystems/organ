using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    class Login
    {
        /*cod_login int identity(1,1) constraint PK_tbLogin primary key,
        nome_login varchar(25) not null,
        senha varchar(20) not null,
        data_cadastro datetime not null constraint DF_tbLogin_data default getdate()*/
        int cod_login;
        string nome_login;
        string senha;
        string data_cadastro = "default";
    }
}
