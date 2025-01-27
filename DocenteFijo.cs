using System;

public class DocenteFijo : Empleado
{
    public bool metaAlcanzada;
    private double salarioBase = 1000;
    public DocenteFijo(string nombre, string id, double salarioBase, bool meta) : base(nombre, id)
    {
        NombreApellido = nombre;
        SalarioBase = salarioBase;
        this.metaAlcanzada = meta;
    }

    public double SalarioBase
    {
        get
        {
            return salarioBase;
        }
        set
        {
            salarioBase = value;
        }
    }

    public override double SalarioCalc()
    {
        return metaAlcanzada ? SalarioBase : SalarioBase / 2;
    }
}