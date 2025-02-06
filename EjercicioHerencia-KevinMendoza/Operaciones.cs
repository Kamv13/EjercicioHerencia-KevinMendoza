


namespace EjercicioHerencia_KevinMendoza
{
    public class Operaciones : Figura
     {
        public const double Const1 = 0.5;

        public double AreaTriangulo() {
            return (double)(Const1! * (Base! * Altura!));
        }

        public void imprimir() {

            Console.WriteLine($"La figura es un {Tipo}");
            Console.WriteLine($"El area del {Tipo} es {AreaTriangulo()}");
        }
     
    }
}
