using Quantum.DAL.Infrastructure;
using Quantum.DAL.Infrastructure.Attributes;

namespace Quantum.DAL.StoredProcedures
{
    namespace Sets
    {
        internal class SPCreateWordSet : StoredProcedure
        {
            [InParameter] public string SetName;
        }

        internal class SPDeleteWordSet : StoredProcedure
        {
            [InParameter] public int Id;
        }

        internal class SPGetSetById : StoredProcedure
        {
            [InParameter] public int Id;
        }

        internal class SPGetSets : StoredProcedure
        {
        }

        internal class SPUpdateSet : StoredProcedure
        {
            [InParameter] public int Id;
        }
    }
}
