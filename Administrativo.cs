using System;

public class Administrativo : Empleado
{
    private double salarioBase = 1200;
    public bool metaAlcanzada;

    public Administrativo(string nombre, string id, double salarioBase, bool metaAlcanzada) : base(nombre, id)
    {
        this.salarioBase = salarioBase;
        this.metaAlcanzada = metaAlcanzada;
    }

    public double SalarioBase
    {
        get
        {
            return salarioBase;
        }
    }
    public override double SalarioCalc()
    {
        return metaAlcanzada ? salarioBase : salarioBase / 2;
    }
}

