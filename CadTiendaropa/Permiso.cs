
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CadTiendaropa
{

using System;
    using System.Collections.Generic;
    
public partial class Permiso
{

    public int idPermiso { get; set; }

    public int idRol { get; set; }

    public string nombreMenu { get; set; }

    public System.DateTime fechaRegistro { get; set; }



    public virtual Rol Rol { get; set; }

}

}
