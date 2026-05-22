using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> listaLibros = Libro.CrearLista();
    public Libro? GetPrimero() // aca se puede sacar el nuleable porque ya sabemos que la lista esta creada y tieneeee elementos
    {
        //entonces se puede usar solo First !!!!! CLASE 14
        return listaLibros.FirstOrDefault();
    }


    public Libro? GetUltimo()
    {
        return listaLibros.LastOrDefault();
    }

    public decimal GetTotalPrecios()
    {
        return listaLibros.Sum(l => l.Precio);
    }

    public decimal GetPromedioPrecios()
    {
        if (!listaLibros.Any()) // any: busca cuando hay algun elemento
        {
            return 0;
        }
        return listaLibros.Average(l => l.Precio); // si la lista esta vacia tira error
    }

    public List<Libro> GetListById()
    {
        return listaLibros.Where( l => l.Id > 15).ToList();
    }
    // * 6. Obtener una lista de cada libro con su título
    // y precio en formato moneda (GetLibros) (debe retornar una lista de string)

    public List<String> GetListBytitulos()
    {
        return listaLibros.Select(l => $"{l.Titulo}, {l.Precio:C2}").ToList();
    }

    public Libro? GetMayorPrecio()
    {
        return listaLibros.MaxBy(l => l.Precio);
    }

    public Libro? GetMenorPrecio()
    {
        return listaLibros.MinBy(l => l.Precio);
    }

    //9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPrecioProm()
    {
        decimal precioProm = GetPromedioPrecios();
        return listaLibros.Where(l => l.Precio > precioProm).ToList();
    }

    // * 10. Obtener los libros ordenados por título de forma descendente

    public List<Libro> GetOrdenadosPorTituloDesc()
    {
        return listaLibros.OrderByDescending(l => l.Titulo).ToList();
    }

}
