using System.ComponentModel.DataAnnotations;

namespace ScheduleEditor.Frontend.Models
{
    public class ScheduleEvent
    {
        public enum ClassType { Wykład, Laboratorium, Ćwiczenia, Projekt, Inne };

        public required string Id { get; set; }

        [Required(ErrorMessage = "Room Number is Required")]
        public required string Room { get; set; }
        public ClassType Type { get; set; }
        
        [Required(ErrorMessage = "Event Name is Required")]
        public required string Name { get; set; }

        [Required]
        public required string Lecturer { get; set; }

        [StringLength(120)]
        public string? AdditionalInformation { get; set; }
        public bool AddtionalEvents { get; set; } = false;
    }
}
