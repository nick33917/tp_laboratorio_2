using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private double ValidarNumero(string srtNumero)
        {
            
            double num=0;
            bool flag;
            flag= double.TryParse(srtNumero,out num);
            return num;
        }

        public string SetNumero 
        { 
             set {this.numero = this.ValidarNumero(value);}
        }
               
        public static string BinarioDecimal(string binario)
        {
           string numDecimal = Convert.ToInt64(binario,2).ToString();
           return numDecimal;

        }

        public static string DecimalBinario(double numero)
        {
            string numBinario = Convert.ToString((long)numero,2);
            return numBinario;
        }
       
        public Numero () : this(0)
        {
        }
       
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
           
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double rtn;
            rtn = n1.numero - n2.numero;
            return rtn;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            double rtn;
            rtn = n1.numero + n2.numero;
            return rtn;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            double rtn;
            rtn = n1.numero * n2.numero;
            return rtn;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double rtn=0;
            if (n2.numero != 0)
            {
                rtn = n1.numero / n2.numero;
            } 
            return rtn;
            

        }



    }
}
