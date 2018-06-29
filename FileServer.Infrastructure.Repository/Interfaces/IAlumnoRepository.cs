using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infrastructure.Repository
{
  public interface IAlumnoRepository
  {
    //definir metode de afegir alumne
    Alumno Add(Alumno alumno);
  }
}
