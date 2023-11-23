using Entidades.DataBase;
using Entidades.Excepciones;
using Entidades.Enum;
using Entidades.MetodosExtencion;
using Entidades.Modelos;

namespace TestProject
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void Prueba_CastearStrToInt_PersonaExtension()
        {
            //arrange
            int valorEsperado = 7;
            int valorRecibido = 0;
            string valorStr = "7";

            //act
            valorRecibido = valorStr.CastearStrToInt();

            //assert
            Assert.AreEqual(valorEsperado, valorRecibido);

        }

        /// <summary>
        /// Se intenta lanzar una excepción al pasar por parametros a GetQueue un valor NO permitido, dado que espera recibir el numero 1 para simular el estado 'true' desde la DB
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DBManagerException))]
        public void Prueba_RecibirQueuePacientesDesdeDataBase()
        {
            //arrange
            int valor = (int)EEstadoAtencion.Atendido;

            //act
            Queue<Paciente> cola = ADOPacientes.GetQueuePacientes(valor); // el metodo espera recibir el numero UNO como argumento

            //assert
            //Assert.AreEqual(null, cola);
        }


    }
}