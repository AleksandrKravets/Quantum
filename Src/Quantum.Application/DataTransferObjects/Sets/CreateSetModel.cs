using System.ComponentModel.DataAnnotations;

namespace Quantum.Application.DataTransferObjects.Sets
{
    public class CreateSetModel
    {
        [Required]
        public string Name { get; set; }
    }
}
