using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;
using Newtonsoft.Json;

namespace FileServer.Infrastructure.Repository.Repositories
{
  public class AlumnoRepository : IAlumnoRepository
  {
    public Alumno Add(Alumno alumno)
    {
      StreamWriter streamWriter = null;
      try
      {
        string AlumnoJson = JsonConvert.SerializeObject(alumno);

        streamWriter = new StreamWriter(@"c:\noe\json.txt", true);
        streamWriter.WriteLine(AlumnoJson);

        alumno = JsonConvert.DeserializeObject<Alumno>(AlumnoJson);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        alumno.Id = 0;
      }
      finally
      {
        if (streamWriter != null) streamWriter.Close();
      }

      return alumno;
    }
  }
}
