using Quantum.DAL.Infrastructure;
using Quantum.DAL.Infrastructure.Attributes;

namespace Quantum.DAL.StoredProcedures
{
    namespace Sets
    {
        internal class SPCreateSet : StoredProcedure
        {
            [InParameter] public string SetName;
        }
    }
}
