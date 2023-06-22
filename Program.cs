
using System.Collections;

internal class NewBaseType{
    private static void Main(string[] args)
    {
        int idx;
        ArrayList Materias = new ArrayList();
        ArrayList Cursos = new ArrayList();
        
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo tecnico");
        Materias.Add("Ingles");

        Cursos.Add("Octavo");
        Cursos.Add("Noveno");
        do{
            Console.Write("Escriba la pocicion donde desea insertar la Asignatura: ");
            idx= Convert.ToInt32(Console.ReadLine());
        }while(idx > Materias.Count);
        
        Materias .InsertRange(idx,Cursos);
        foreach(object materia in Materias){
            Console.WriteLine(materia.ToString());
        }
        
        // do{
            
        //     idx = Convert.ToInt32(Console.ReadLine());
        // }while(idx > Materias.Count);

        // Materias.Insert(idx,palabra);

        // foreach(object materia in Materias){
        //     Console.WriteLine(materia.ToString());
        // }
    }
 
}