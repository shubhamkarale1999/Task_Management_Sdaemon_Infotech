using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management_Sdaemon_Infotech.Model
{
    [Table("tbl_ManageTask")]
    public class TaskManagement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Task Title")]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Due Date")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [DisplayName("Is Completed")]
        public bool IsComplete { get; set; }

       // public bool IsActive { get; set; }

        [StringLength(50)]
        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Created Date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Updated By")]
        public string? UpdatedBy { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
