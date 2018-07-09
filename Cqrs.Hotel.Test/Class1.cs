using System;
using Autofac;
using Cqrs.Hotel.Command.Commands.LeaveRoom;
using Cqrs.Hotel.Infraestructure;
using MediatR;
using Xunit;

namespace Cqrs.Hotel.Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            var hotel = new Hotel();
            var scope = hotel.Initilize();
        }
    }
}
