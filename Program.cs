
using System.Collections;

internal class NewBaseType{
    private static void Main(string[] args)
    {
        string ? palabra;
        ArrayList Materias = new ArrayList();
        
        Materias.Add("0) Calculo.");
        Materias.Add("1) Español.");
        Materias.Add("2) Dibujo tecnico.");
        Materias.Add("3) Ingles.");

        Console.Write("Escriba la materia a buscar: ");
        palabra = Console.ReadLine();
        Console.WriteLine(Materias.Contains(palabra) ? "La materia esta disponible":"La materia no se encontro");

        do{
            Console.Write("Ingrese la posicion donde desea insertar la asignatura: ");
            idx = Convert.ToInt32(Console.ReadLine());
        }while(idx > Materias.Count);

        Materias.Insert(idx,palabra);

        foreach(object materia in Materias){
            Console.WriteLine(materia.ToString());
        }
    }
 
}