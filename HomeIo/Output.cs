using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeIo
{
    public class Output
    {
        private string nom;
        private string code;
        private int numero;
        private string type;
        private object valeur;

        public Output (string nom, int numero, string type, string code)
        {
            this.nom = nom;
            this.code = code;
            this.numero = numero;
            this.type = type;
            this.valeur = ReadIO.ReadOutputType(type, numero);
        }

        public void update()
        {
            this.valeur = ReadIO.ReadOutputType(this.type, this.numero);
        }

        public void on()
        {
            this.valeur = true;
            this.write();
        }

        public void off()
        {
            this.valeur = false;
            this.write();
        }

        public void inverse()
        {
            this.valeur = ! (bool)this.valeur;
            this.write();
        }

        private void write()
        {
            HomeIo.WriteIO.BitOutput(this.numero, (bool)this.valeur);
        }

        public string getCode()
        {
            return this.code;
        }

        public object getValeur()
        {
            return this.valeur;
        }

    }
}
