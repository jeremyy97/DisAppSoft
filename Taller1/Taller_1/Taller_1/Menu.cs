using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_1
{
    class Menu
    {
        public List<Publicacion> Publicaciones { get; set; }

        public Menu()
        {
            Publicaciones = new List<Publicacion>();
        }

        
        public void MostrarMenu()
        {
            try
            {
                Boolean salir = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite el número que antescede la opción que desea\n\n1- Publicar\n2- Comentar\n3- Salir Programa");
                    int tipo = Int16.Parse(Console.ReadLine());
                    string nombre = "";
                    switch (tipo)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Nombre: ");
                            nombre = Console.ReadLine();
                            MenuPublicar(new Usuario(nombre, 1));
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Nombre: ");
                            nombre = Console.ReadLine();
                            MenuComentar(new Usuario(nombre, 2));
                            break;
                        case 3:
                            Console.Clear();
                            salir = true;
                            Console.WriteLine("Gracias por usar nuestro sistema!");
                            break;
                        default:
                            Console.WriteLine("La opción ingresada no coincide con ninguna de las opciones disponibles.");
                            break;
                    }
                } while (!salir);
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
            }
        }

        
        public void MenuPublicar(Usuario usuario)
        {
            Boolean salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido " + usuario.Nombre + "\n\n1- Nueva Publicación\n2- Mostrar Publicaciones\n3- Cerrar Sesión");
                int tipo = Int16.Parse(Console.ReadLine());
                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Publicaciones.Add(PostLogic.NuevaPublicacion(usuario));
                        Console.WriteLine("Publicación agregada");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(PostLogic.ListaPublicaciones(Publicaciones));
                        Console.ReadKey();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("La opción ingresada no coincide con ninguna de las opciones disponibles.");
                        break;
                }
            } while (!salir);
        }

        
        public void MenuComentar(Usuario usuario)
        {
            Boolean salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido " + usuario.Nombre + "\n\n1- Nuevo Comentario\n2- Mostrar Publicaciones\n3- Cerrar Sesión");
                int tipo = Int16.Parse(Console.ReadLine());
                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el # de publicación que desea comentar");
                        int id = Int16.Parse(Console.ReadLine());
                        if (PostLogic.ExistePublicacion(id, Publicaciones))
                        {
                            Comentario comentario = CommentLogic.NuevoComentario(usuario);
                            PostLogic.AgregarComentario(id, Publicaciones, comentario);
                        }
                        else
                        {
                            Console.WriteLine("Id de publicación no existe");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(PostLogic.ListaPublicaciones(Publicaciones));
                        Console.ReadKey();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Muchas gracias!");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            } while (!salir);
        }
    }
}
