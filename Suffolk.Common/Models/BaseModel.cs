namespace Suffolk.Common.Models
{
    using Suffolk.Common.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class BaseModel<Tkey> : IAuditInfo
    {
        [Key]
        public Tkey Id { get; set; }
        public DateTime CreatedOn { get; set; }= DateTime.Now;
        public DateTime? ModifiedOn { get; set; }
        [StringLength(35)]
        public string CreatedBy { get; set; }
        [StringLength(35)]
        public string ModifiedBy { get; set; }

    }
}
