using RBV_Clases;
public static class Globals
{
    private static Empresa empresa;
    public static Empresa Empresa
    {
        get
        {
            return empresa;
        }
        set
        {
            empresa = value;
        }
    }
}