using System;

public abstract class Empleado
{
    private string nombreApellido;
    public string identificacion;

    public Empleado(string nombre, string id)
    {
        NombreApellido = nombre;
        identificacion = id;
        
    }

    public string NombreApellido
    {
        get { return nombreApellido; }
        set { nombreApellido = value; }
    }

    public abstract double SalarioCalc();
}
