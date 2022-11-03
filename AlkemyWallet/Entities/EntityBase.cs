using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlkemyWallet.Entities
{
    public class EntityBase
    {

        
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public bool IsDeleted { get; set; } = false;
        

    }
}
