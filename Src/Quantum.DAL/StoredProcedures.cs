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

    namespace Cards
    {
        [ProcedureName("CreateCard")]
        internal class SPCreateCard : StoredProcedure
        {
            [InParameter] public int SetId;
            [InParameter] public string Word;
            [InParameter] public string Translation;
        }

        [ProcedureName("DeleteCard")]
        internal class SPDeleteCard : StoredProcedure
        {
            [InParameter] public int Id;
        }

        [ProcedureName("UpdateCard")]
        internal class SPUpdateCard : StoredProcedure
        {
            [InParameter] public int Id;
            [InParameter] public string Word;
            [InParameter] public string Translation;
        }

        [ProcedureName("GetCard")]
        internal class SPGetCard : StoredProcedure
        {
            [InParameter] public int Id;
        }

        [ProcedureName("GetCards")]
        internal class SPGetCards : StoredProcedure
        {
            [InParameter] public int SetId;
        }
    }
}
