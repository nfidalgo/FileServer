using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FileServer.Common.Model;

namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
  [TestClass()]
  public class AlumnoRepositoryTests
  {
    private IAlumnoRepository mockObject;
    Alumno alumno = new Alumno { Id = 1, Nombre = "Noelia", Apellidos = "Fidalgo", Dni = "46768997S" };
    [TestInitialize]
    public void Setup()
    {
      var mock = new Mock<IAlumnoRepository>();
      //Alumno alumno = new Alumno { Id = 1, Nombre = "Noelia", Apellidos = "Fidalgo", Dni = "46768997S" };
      mock.Setup(x => x.Add(alumno)).Returns(alumno);
      mockObject = mock.Object;

    }

    [TestMethod()]
    public void AddTest()
    {
      var result = mockObject.Add(alumno);
      Assert.AreEqual(alumno, result);

    }
  }
}