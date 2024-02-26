using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Core.Ports.Driving
{
    public interface IOrderService
    {
        IEnumerable<string> GetOrders();
    }
}
