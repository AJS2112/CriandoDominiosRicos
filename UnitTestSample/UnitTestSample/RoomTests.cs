using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample.Domain;
using UnitTestSample.Domain.Contracts;
using UnitTestSample.FakeRepository;

namespace UnitTestSample
{
    [TestClass]
    public class Dada_uma_nova_sala
    {
        [TestMethod]
        [TestCategory("Nova Sala")]
        public void O_nome_deve_ser_sala_1()
        {
            var room = new Room("Sala 1");

            //Assert.Fail();
            Assert.AreEqual("Sala 1", room.Name);
        }

        [TestMethod]
        [TestCategory("Nova Sala")]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_ser_fornecido()
        {
            var room = new Room(null);
        }

        
    }
    [TestClass]
    public class Dada_uma_nova_reserva
    {
        [TestMethod]
        [TestCategory("Reserva de Sala")]
        [ExpectedException(typeof(Exception))]
        public void A_sala_deve_estar_disponivel()
        {
            var startDate = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            IBookRepository rep = new BookFakeRepository();

            var room = new Room("Sala 1");
            room.Book(
                startDate, 
                endDate, 
                rep.GetByDate(startDate,endDate));

        }

        [TestMethod]
        [TestCategory("Reserva de Sala")]
        public void A_sala_deve_ser_reservada_com_sucesso()
        {
            var startDate = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            IBookRepository rep = new BookFakeRepository();

            var room = new Room("Sala 1");
            room.Book(
                startDate,
                endDate,
                new List<DateTime>());

        }
    }
}
