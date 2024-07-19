namespace ScheduleEditor.Frontend.Models
{
    public class ScheduleEvent
    {
        public enum ClassType { Wykład, Laboratorium, Ćwiczenia, Projekt, Inne };

        public required string Id { get; set; }
        public required string Room { get; set; }
        public ClassType Type { get; set; }
        public required string Name { get; set; }
        public required string Lecturer { get; set; }
        public string? AdditionalInformation { get; set; }
        public bool AddtionalEvents { get; set; } = false;
    }
}
