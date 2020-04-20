using Quantum.DAL.Infrastructure;
using Quantum.DAL.Infrastructure.Attributes;

namespace Quantum.DAL.StoredProcedures
{
    namespace Sets
    {
        [ProcedureName("CreateCardSet")]
        internal class SPCreateCardSet : StoredProcedure
        {
            [InParameter] public string Name;
        }

        [ProcedureName("DeleteCardSet")]
        internal class SPDeleteCardSet : StoredProcedure
        {
            [InParameter] public int Id;
        }

        [ProcedureName("GetCardSet")]
        internal class SPGetSetById : StoredProcedure
        {
            [InParameter] public int Id;
        }

        [ProcedureName("GetCardSets")]
        internal class SPGetSets : StoredProcedure
        {
        }

        [ProcedureName("UpdateCardSet")]
        internal class SPUpdateSet : StoredProcedure
        {
            [InParameter] public int Id;
            [InParameter] public string Name;
        }
    }
}
