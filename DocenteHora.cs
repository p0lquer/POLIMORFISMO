using System.Runtime.Remoting.Metadata.W3cXsd2001;

using System;

public class DocenteHora : Empleado
{
    private int horasTrabajadas;
    private const double tarifaHora = 800;
    public DocenteHora(string nombre, string id, int horas) : base(nombre, id)
    {
        NombreApellido = nombre;
        identificacion = id;
        HorasTrabajadas = horas;
    }
    public int HorasTrabajadas
    {
        get
        {
            return horasTrabajadas;
        }
        set
        {
            if (value > 0)
                horasTrabajadas = value;
        }
    }
    public double TarifaHora
    {
        get
        {
            return tarifaHora;
        }
    }

    public override double SalarioCalc()
    {
        return horasTrabajadas * TarifaHora;
    }
}