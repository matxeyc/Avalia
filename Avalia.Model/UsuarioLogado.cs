using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalia.DTO;

namespace Avalia.Model
{
    public class UsuarioLogado
    {
        private static UsuarioDTO usuarioSingleton = new UsuarioDTO();

        public static void setUsuarioLogado(UsuarioDTO usuarioLogado)
        {
            usuarioSingleton = usuarioLogado;
        }

        public static UsuarioDTO getUsuarioLogado()
        {
            return usuarioSingleton;
        }

    }

    //Exemplo de Sigleton
   /* public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    */

}
