using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample.Domain.Contracts
{
    public interface IBookRepository
    {
        List<DateTime> GetByDate(DateTime startDate, DateTime endDate);
    }
}
