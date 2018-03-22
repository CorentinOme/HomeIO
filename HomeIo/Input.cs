using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeIo
{
    public class Input
    {
        private string nom;
        private string code;
        private int numero;
        private string type;
        private object valeurPrec;
        private object valeur;

        public Input (string nom, int numero, string type, string code)
        {
            this.nom = nom;
            this.code = code;
            this.numero = numero;
            this.type = type;
            this.valeur = ReadIO.ReadInputType(type, numero);
        }

        public void update()
        {
            this.valeurPrec = this.valeur;
            this.valeur = ReadIO.ReadInputType(type, numero);
        }

        public string getCode()
        {
            return this.code;
        }

        public object getValeur()
        {
            return this.valeur;
        }

        public object getValeurPrec()
        {
            return this.valeurPrec;
        }

    }
}
