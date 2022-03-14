using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Pepito{get; set;}
        public PersonaTest() => Pepito = new Persona("Pepito", "Gomez", 0);
        [Fact]
        public void Contructor()
        {
            Pepito = new Persona("Pepito", "Gomez", 0);
            Assert.Equal("Pepito", Pepito.Nombre);
            Assert.Equal("Gomez", Pepito.Apellido);
            Assert.Equal(0, Pepito.Efectivo);
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Pepito.Acreditar(1000);
            /*Assert.NotEqual = Fallo a proposito*/
            Assert.Equal(esperado, Pepito.Efectivo, 3);
        }
    }
}
