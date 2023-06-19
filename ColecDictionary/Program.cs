//programa que permita visualizar los departamentos de nicragua con
//su cantidad poblacional
//Encuentre:mayor, menor, suma y ordene los datos 
using Departamentos;
//Lista de departamentos
List<depto>lstDeptos = new List<depto>()
{
  new depto("Boaco",185013),
  new depto("Carazo",197139).
  new depto("Chinandega",439906),
  new depto("Chontales",190863),
  new depto("Costa caribe Norte",530586),
  new depto("Costa caribe Sur",414543),
  new depto("Esteli", 229866),
  new depto("Granada",214317),
  new depto("Jinotepe",475630),
  new depto("Leon", 421050),
  new depto("Madriz",174744),
  new depto("Managua",1546939),
  new depto("Masaya",391903),
  new depto("Matagalpa",593503),
  new depto("Nueva Segovi",271581),
  new depto("Rio San Juan",135446),
  new depto("Rivas",182645)
};
//Encontrar el mayor y el menor (poblacion)
 depto minDepto =lstDeptos.OrderBy(d=>.population).First();
 depto maxDepto =lstDeptos.OrderBy(d=>.population).Last();
 //Ordenando los deprtamentos 
 var DeptOrdenado =lstDeptos.OrderBy(d=>d.population);
 //Mostrar departamentos ordenados
 foreach (var item in DeptOrdenado)
   Console.WriteLine($"{item.Name,-20}==>{item.population,10:No}");
//Mostrando el mayor y menor
Console.WriteLine($"Dpto con menor poblacion:{minDepto.Name}");
Console.WriteLine($"Dpto con mayor poblacion:{maxDepto.Name}");
//Sumr tods la poblacion con su SUM de LINQ
int total = lstDeptos.Select(d=>d.population).Sum();
Console.WriteLine($"Poblcion General:{total:No}");
 


