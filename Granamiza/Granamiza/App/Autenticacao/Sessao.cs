using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.Autenticacao
{
    public static class Sessao
    {
        //Usuário
        private static Int32 _idUsuario;
        private static String _nomeUsuario;
        private static String _emailUsuario;
        private static String _avatarUsuario;

        public static int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public static string NomeUsuario { get => _nomeUsuario; set => _nomeUsuario = value; }
        public static string EmailUsuario { get => _emailUsuario; set => _emailUsuario = value; }
        public static string AvatarUsuario { get => _avatarUsuario; set => _avatarUsuario = value; }
    }
}
