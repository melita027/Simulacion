using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public class CuadradosMedios
    {
        string semilla;
        string snumero2;//semilla al cuadrado
        string snumero3;//guardar digitos del medio
        string serror;
        double numero1;
        double numero2;
        double error;
        int tam1;//cantidad de digitos de la semilla
        int tam2;//cantidad de digitos de la semilla al cuadrado
        int iteraciones;//cantidad de numeros aleatorios
        int e;//numero de digitos
        


        public void calularNumeros(string semilla, int e, int iteraciones,DataGridView dataGrid)
        {
            try
            {
                List<string> numeros = new List<string>();
                if (semilla.Length <= 3)
                {
                    MessageBox.Show("La semilla debe tener más de 3 digitos");
                }
                else
                {
                    tam1 = semilla.Length;
                    numero1 = Convert.ToDouble(semilla);
                    for (int i = 1; i <= iteraciones; i++)
                    {

                        numero2 = Math.Pow(numero1, 2);
                        snumero2 = Convert.ToString(numero2);
                        tam2 = snumero2.Length;
                        while (tam2 < e)
                        {
                            snumero2 = "0" + snumero2;
                            tam2 = snumero2.Length;
                        }
                        /*if (tam2%2==1)//si la logitud no es par
                        {
                            snumero2 = "0" + snumero2;
                            tam2 = snumero2.Length;
                        }*/
                        snumero3 = snumero2.Substring((tam2 / 2) - 2, tam1);
                        if (numeros.Contains(snumero3)) { return; }
                        string s = "1";
                        while (s.Length < tam1 + 1)
                        {
                            s = s + "0";
                        }
                        error = Convert.ToDouble(snumero3) / Convert.ToDouble(s);
                        serror = Convert.ToString(error);
                        dataGrid.Rows.Add(i, snumero2, snumero3, serror);
                        numeros.Add(snumero3);
                        numero1 = Convert.ToDouble(snumero3);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
}   }
