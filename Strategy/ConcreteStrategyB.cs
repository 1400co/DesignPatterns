using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy B";
        }
    }
}
