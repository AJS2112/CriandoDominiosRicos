using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Validation
{
    public static class AssertionConcern
    {
        public static void AssertArgumentNotNull(string value, string message)
        {
            if (String.IsNullOrEmpty(value))
                throw new InvalidOperationException(message);
        }
    }
}
