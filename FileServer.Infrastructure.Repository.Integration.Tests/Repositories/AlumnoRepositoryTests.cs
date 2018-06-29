using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;

namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
  [TestClass()]
  public class AlumnoRepositoryTests
  {
    IAlumnoRepository alumnoRepository = new AlumnoRepository();
    Alumno alumno = new Alumno { Id = 1, Nombre = "Noelia", Apellidos = "Fidalgo", Dni = "46768997S" };


    [TestMethod()]
    public void AddTest()
    {
      Assert.IsTrue(alumnoRepository.Add(alumno).Equals(alumno));
    }
  }
}