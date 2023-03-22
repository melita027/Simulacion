using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Simulacion
{
    public class ProductosMedios
    {
        string semilla1;
        string semilla2;
        string snumero2;//resultado del producto
        int tam1;//cantidad de digitos del producto
        int iteraciones;//cantidad de numeros aleatorios

        public void calularNumeros(string semilla1, string semilla2, int iteraciones, DataGridView dataGrid)
        {
            double numero1, numero2, numero3;
            string resultado, valor1 = "0",valor2="0";
            string medio="";
            int tam;
            try
            {
                //List<string> numeros = new List<string>();
                if (semilla1.Length < 3 || semilla1.Length > 5)
                {
                    MessageBox.Show("Las semillas deben tener de 3 a 5 dígitos");
                    return;
                }
                if (semilla2.Length < 3 || semilla2.Length > 5)
                {
                    MessageBox.Show("Las semillas deben tener de 3 a 5 dígitos");
                    return;
                }
                else
                {
                    numero1 = Convert.ToDouble(semilla1);
                    numero2 = Convert.ToDouble(semilla2);
                    for (int i = 0; i <= iteraciones; i++)
                    {
                        numero3 = numero1 * numero2;
                        resultado = Convert.ToString(numero3);
                        tam = resultado.Length;
                        switch (tam)
                        {
                            case 10: {
                                    medio = resultado.Substring(4, 7);
                                    if (medio.Length == 4)
                                    {
                                        string c = medio.Substring(0, 1);
                                        if (c == "0")
                                        {
                                            valor1 = medio.Substring(1, 3);
                                            valor2 = "0";
                                        }
                                        else
                                        {
                                            valor1 = medio.Substring(0, 3);
                                            valor2 = medio.Substring(1, 3);
                                        }

                                    }
                                    break; }
                            case 9: {
                                    medio = resultado.Substring(3, 3);
                                    if (medio.Length == 3)
                                    {
                                        string c = medio.Substring(0, 1);
                                        if (c == "0")
                                        {
                                            valor1 = medio.Substring(1, 2);
                                            valor2 = "0";
                                        }
                                        else
                                        {
                                            valor1 = medio;
                                            valor2 = "0";
                                        }
                                    }

                                    break; }
                            case 8: {
                                    medio = resultado.Substring(2, 4);
                                    if (medio.Length == 4)
                                    {
                                        string c = medio.Substring(0, 1);
                                        if (c == "0")
                                        {
                                            valor1 = medio.Substring(1, 3);
                                            valor2 = "0";
                                        }
                                        else
                                        {
                                            valor1 = medio.Substring(0, 3);
                                            valor2 = medio.Substring(1, 3);
                                        }

                                    }
                                    break; }
                            case 7: {
                                    medio = resultado.Substring(2, 3);
                                    if (medio.Length == 3)
                                    {
                                        string c = medio.Substring(0, 1);
                                        if (c == "0")
                                        {
                                            valor1 = medio.Substring(1, 2);
                                            valor2 = "0";
                                        }
                                        else
                                        {
                                            valor1 = medio;
                                            valor2 = "0";
                                        }
                                    }
                                    break; }
                            case 6:
                            {
                                medio = resultado.Substring(1, 4);
                                if (medio.Length == 4)
                                {
                                    string c = medio.Substring(0, 1);
                                    if (c == "0")
                                    {
                                     valor1 = medio.Substring(1, 3);
                                     valor2 = "0";
                                    }
                                    else
                                    {
                                        valor1 = medio.Substring(0, 3);
                                        valor2 = medio.Substring(1, 3);
                                    }

                                } break;
                            }
                            case 5:
                            {
                                    medio = resultado.Substring(1, 3);
                                    if (medio.Length == 3)
                                    {
                                        string c = medio.Substring(0, 1);
                                        if (c == "0")
                                        {
                                            valor1 = medio.Substring(1, 2);
                                            valor2 = "0";
                                        }
                                        else
                                        {
                                            valor1 = medio;
                                            valor2 = "0";
                                        }
                                    }
                                    break; 
                            }
                            case 3: {
                                    medio = resultado.Substring(1, 1);
                                    valor1 = medio;
                                    valor2 = "0"; break; }
                            case 4: { medio = resultado.Substring(1, 2);
                                    valor1 = medio;
                                    valor2 = "0";
                                    break; }
                            case 2: {
                                    medio = "0";
                                    valor1 = "0";
                                    valor2 = "0";
                                    break;
                                       }
                            case 1: {
                                    medio = "0";
                                    valor1 = "0";
                                    valor2 = "0"; break; }
                               
                        }
                        dataGrid.Rows.Add(i, numero1, numero2, numero3, medio, valor1, valor2);
                        numero1 = numero2;
                        numero2 = Convert.ToDouble(valor1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
