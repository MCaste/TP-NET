using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
    {
    public class Usuario
        {

        Business.Logic.UsuarioLogic _UsuarioNegocio;

        public Business.Logic.UsuarioLogic UsuarioNegocio
        { 
        
            get{return UsuarioNegocio;}

            set { UsuarioNegocio = value; }
    
        }
        
        public Usuario()
            {
            
            }


        public void Menu()
            {

            Console.WriteLine("MENU:\n1-Listado General\n2-Consulta\n3-Agregar\n4-Modificar\n5-Eliminar\n6-Salir\n");

            int opcion = Convert.ToInt32(Console.ReadLine());

            do{

                switch(opcion)
                    {
                    case 1: ListadoGeneral();
                            break;
                    case 2: Consultar();
                            break;
                    case 3: Agregar();
                            break;
                    case 4: Modificar();
                            break;
                    case 5: Eliminar();
                            break;
                    default: Console.WriteLine("La opción ingresada es incorrecta, por favor ingresela nuevamente.\n");
                            break;
                    }
                }while ((opcion >=1)&&(opcion<6));
            }

        public void ListadoGeneral()
            {
            Console.Clear();

            foreach (Business.Entities.Usuario usr in UsuarioNegocio.GetAll())
                {
                MostrarDatos(usr);
                }            
            }

        public void MostrarDatos(Business.Entities.Usuario usr)
            {
            Console.WriteLine("\t\tUsuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
            }

        public void Consultar()
        
            {
            
            
            }

        public void Modificar()
           
            {
            
            }

        public void Agregar()
        
            { 
            
            
            }
        public void Eliminar()
        
            { 
            
            }


        }
    }
