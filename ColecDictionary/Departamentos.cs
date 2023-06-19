using System.Transactions;
namespace Depatamentos
{
    //clase que define un departamento con su nombre y ponlacion
    public class depto
    {

        public string Name { get; set; }
        public int population { get; set}

        public depto(String n, int poblacion)

        {
            Name = n;
            population = poblacion;
        }



    }



}