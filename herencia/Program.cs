public class EmpleadoPorComision : object
 {
 private string primerNombre;
 private string apellidoPaterno;
 private string numeroSeguroSocial;
 private decimal ventasBrutas;

    public EmpleadoPorComision(string nombre, string apellido, string nss,
decimal ventas, decimal tarifa )

 {

        
 primerNombre = nombre;
 apellidoPaterno = apellido;
 numeroSeguroSocial = nss;
 VentasBrutas = ventas;
 TarifaComision = tarifa; 
 
}

    public string PrimerNombre
    {
       get
       {
         return primerNombre;
       } 
     }

    public string ApellidoPaterno
    {
        get
        {
         return apellidoPaterno;
        }
    }

    public string NumeroSeguroSocial
    {
       get
       {
         return numeroSeguroSocial;
        } 
    }


    public decimal VentasBrutas
    {
       get
       {
            return VentasBrutas;
       }
       set
       {
            ventasBrutas = (value < 0) ? 0 : value;
       }

    }

    public decimal TarifaComision
    {
        get
        {
          return TarifaComision;
        } 
        set
        {
           TarifaComision = ( value > 0 && value < 1 ) ? value : 0;
        } 
    }

    public decimal Ingresos()
    {

        return TarifaComision * ventasBrutas;
    }

    public override string ToString()
    {
        return string.Format(
         "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
         "empleado por comisión", PrimerNombre, ApellidoPaterno,
         "número de seguro social", NumeroSeguroSocial,
         "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);

    }
}

















