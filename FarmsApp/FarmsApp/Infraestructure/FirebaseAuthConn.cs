using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarmsApp.Infraestructure
{
    public interface FirebaseAuthConn
    {
        Task<String> DoLoginWithUP(string usuario, string contraseña);

        Task<String> DoRegisterWithUP(string usuario, string contraseña);
    }
}
