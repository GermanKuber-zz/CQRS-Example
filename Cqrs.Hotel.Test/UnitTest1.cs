using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using Autofac;
using Cqrs.Hotel.Command;
using Cqrs.Hotel.Command.Infraestructure;
using Cqrs.Hotel.Command.Sagas.LeaveRoom;
using Cqrs.Hotel.Domain;
using Cqrs.Hotel.Domain.Events;
using Cqrs.Hotel.Domain.Events.LeftClientRoom;
using Cqrs.Hotel.Domain.Model;
using Cqrs.Hotel.Infraestructure;
using MediatR;
using MediatR.Pipeline;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Cqrs.Hotel.Test
{
    public class UnitTest1
    {


        [Fact]
        public void TestMethod1()
        {
            try
            {

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}
