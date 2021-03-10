using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usuariotwitter
{
    class usuario
    {
        //atributo - campos
        private string nombre;
        private string correo;
        private int numerodeseguidores;

        public void Publicar (string mensaje)
        {
            Console.WriteLine($"{nombre} acaba de publicar lo siguiente {mensaje}");
        }

        public void verPerfil()
        {
            Console.WriteLine($"user: {nombre} correo: {correo} seguidores: {numerodeseguidores}");
        }

        public void setNombre(string nombre)
        {
            //TODO: Verificar que el nombre de usuario no exista
            this.nombre = nombre;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        public void setSeguidores(int n)
        {
            if (n < 0)
                n = n * -1;
       
            numerodeseguidores = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            usuario mario = new usuario();

            //mario.setNombre
            mario.setNombre("mariosky");
            mario.setCorreo("sdjfh@gmail.com");
            mario.setSeguidores(50);

            mario.verPerfil();
            mario.Publicar("Hola al curso de prog 00");

            Console.ReadKey();
        }
    }
}
