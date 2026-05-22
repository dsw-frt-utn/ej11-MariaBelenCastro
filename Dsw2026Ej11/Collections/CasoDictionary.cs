using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> dictionaryAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno, int legajo)
    {
        dictionaryAlumnos.Add(legajo, alumno);
        /* dictionaryAlumnos.TryAdd(legajo, alumno); la diferencia es que este devuelve un bool.
        En caso de poder insertarlo devuelve un true
        if (dictionaryAlumnos.TryAdd(legajo, alumno)){
            manejo de exc
        }*/
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        //Alumno alumnoAux = dictionaryAlumnos[legajo]; // va directo al legajo que busca.Para busqueda parcial no sirve

        if (dictionaryAlumnos.ContainsKey(legajo))
        {
            return dictionaryAlumnos[legajo];
        }
        else
        {
            return null;
        }

        /*
        if (dictionaryAlumnos.TryGetValue(legajo, out var alumnoAux))
        {
            return alumnoAux;
        }
        else
        {
            return null;
        }*/
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return dictionaryAlumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        if (dictionaryAlumnos.ContainsKey(legajo))
        {
            dictionaryAlumnos.Remove(legajo);
        }
    }


}
