using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
    {
    static class Program
        {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Modulo());
            Application.Run(new Comisiones());
            Application.Run(new AlumnoInscripciones());
            Application.Run(new Usuarios());
            Application.Run(new Especialidades());
            Application.Run(new Curso());
            Application.Run(new DocenteCurso());
            Application.Run(new Plan());
            }
        }
    }
