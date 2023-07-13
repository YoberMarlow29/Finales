using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteExistenteException : Exception
    {
        public Auto AutoExistente { get; }

        public PatenteExistenteException(Auto autoExistente)
        {
            AutoExistente = autoExistente;
        }

        public PatenteExistenteException(string message, Auto autoExistente) : base(message)
        {
            AutoExistente = autoExistente;
        }
    }
}
