using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_variaciones_Click(object sender, EventArgs e)
        {
            if (bttn_variaciones.Text.Equals("Posibles variaciones - dias"))
            {
                List<string> dias_semana = new List<string>();
                dias_semana.Add("Lunes");
                dias_semana.Add("Martes");
                dias_semana.Add("Miercoles");
                dias_semana.Add("Jueves");
                dias_semana.Add("Viernes");
                dias_semana.Add("Sabado");
                dias_semana.Add("Domingo");

                txtBx_salida.Text = "";
                //despues de
                int segundo_dia = 1;
                int x_dias = 1;
                while (x_dias <= dias_semana.Count / 2)
                {
                    txtBx_salida.AppendText("------------------X=" + x_dias + "-------------------\r\n");
                    do
                    {
                        generar_variaciones(dias_semana, segundo_dia, x_dias);
                        segundo_dia++;
                        if (segundo_dia >= dias_semana.Count)
                            segundo_dia = 0;
                    } while (segundo_dia != 1);
                    x_dias++;
                }
                bttn_variaciones.Text = "Posibles variaciones - meses";
            }
            else {
                List<string> meses = new List<string>();
                meses.Add("Enero");
                meses.Add("Febrero");
                meses.Add("Marzo");
                meses.Add("Abril");
                meses.Add("Mayo");
                meses.Add("Junio");
                meses.Add("Julio");
                meses.Add("Agosto");
                meses.Add("Septiembre");
                meses.Add("Octubre");
                meses.Add("Noviembre");
                meses.Add("Diciembre");

                txtBx_salida.Text = "";
                //despues de
                int segundo_mes = 1;
                int x_meses = 1;
                while (x_meses < meses.Count / 2)
                {
                    txtBx_salida.AppendText("------------------X=" + x_meses+ "-------------------\r\n");
                    do
                    {
                        generar_variaciones(meses, segundo_mes, x_meses);
                        segundo_mes++;
                        if (segundo_mes >= meses.Count)
                            segundo_mes = 0;
                    } while (segundo_mes != 1);
                    x_meses++;
                }
                bttn_variaciones.Text = "Posibles variaciones - dias";
            }
        }

        public void generar_variaciones(List<string> lista_valores, int segundo_valor, int valor_x) {
            int recorrido = segundo_valor;
            string todos_los_valores = "";
            string incognita = "";
            string primer_valor = "";

            for (int i=0;i<lista_valores.Count; i++) {
                if (recorrido >= lista_valores.Count)
                    recorrido = 0;
                todos_los_valores= todos_los_valores + lista_valores[recorrido] + " ";
                if (i == valor_x)
                    incognita = lista_valores[recorrido];
                if (i == valor_x + valor_x) {
                    primer_valor = lista_valores[recorrido];
                }
                recorrido++;
            }
            if (bttn_variaciones.Text.Equals("Posibles variaciones - dias"))
                mostrar_dias(primer_valor, lista_valores[segundo_valor], todos_los_valores, incognita);
            else
                mostrar_meses(primer_valor, lista_valores[segundo_valor], todos_los_valores, incognita);

        }

        public void mostrar_dias(string primer_dia, string segundo_dia, string semana, string dia_incognita) {
            txtBx_salida.AppendText(
                "Antes de: " + primer_dia +
                " - Despues de: " + segundo_dia + "\r\n" +
                semana +
                "\r\nDia incognita: " + dia_incognita + "\r\n");
            txtBx_salida.AppendText("-------------------------------------\r\n");
        }
        public void mostrar_meses(string primer_mes, string segundo_mes, string meses, string mes_incognita)
        {
            txtBx_salida.AppendText(
                "Antes de: " + primer_mes +
                " - Despues de: " + segundo_mes + "\r\n" +
                meses +
                "\r\nMes incognita: " + mes_incognita + "\r\n");
            txtBx_salida.AppendText("-------------------------------------\r\n");
        }

        public void mostrar_dias(string primer_dia, string segundo_dia) {
            string semana = primer_dia + "";
        }
    }
}
