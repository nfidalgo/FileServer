using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model
{
  public class Alumno
  {
    // int ID ,string nombre,string apellidos, string dni
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Dni { get; set; }

    // Constructors
    public Alumno() {
    }

    public Alumno(int Id, string Nombre, string Apellidos, string Dni)
    {
      this.Id = Id;
      this.Nombre = Nombre;
      this.Apellidos = Apellidos;
      this.Dni = Dni;
    }

    //metode per comparar objectes
    //public override bool Equals(object obj)
    //{
    //  var item = obj as Alumno;
    //  Boolean vRetorno = false;

   //   if (item != null) vRetorno = this.Id.Equals(item.Id);

   //   return vRetorno;
   // }


    // override object.Equals
    public override bool Equals(object obj)
    {
      //       
      // See the full list of guidelines at
      //   http://go.microsoft.com/fwlink/?LinkID=85237  
      // and also the guidance for operator== at
      //   http://go.microsoft.com/fwlink/?LinkId=85238
      //

      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      // TODO: write your implementation of Equals() here
      throw new NotImplementedException();
      return base.Equals(obj);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
      // TODO: write your implementation of GetHashCode() here
      throw new NotImplementedException();
      return base.GetHashCode();
    }

    

  }
}
