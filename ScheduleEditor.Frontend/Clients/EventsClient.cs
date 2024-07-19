using ScheduleEditor.Frontend.Models;
using static ScheduleEditor.Frontend.Models.ScheduleEvent;

namespace ScheduleEditor.Frontend.Clients
{
    public class EventsClient
    {
        private List<ScheduleEvent> _events = new();
        public ScheduleEvent[] GetAllEvents()
            => [.. _events];

        public ScheduleEvent? GetEvent(string id) 
            => GetEventById(id);

        public void AddEvent(ScheduleEvent scheduleEvent)
            => _events.Add(scheduleEvent);

        public void DeleteEvent(string id)
            => _events.Remove(GetEventById(id));

        public void UpdateEvent(ScheduleEvent newScheduleEvent)
        {
            ScheduleEvent existingScheduleEvent = GetEventById(newScheduleEvent.Id);
            existingScheduleEvent = newScheduleEvent;
        }

        //public void UpdateEvent(ScheduleEventViewModel newScheduleEvent)
        //{
        //    ScheduleEvent existingScheduleEvent = GetEventById(newScheduleEvent.Id);

        //    existingScheduleEvent.Room = newScheduleEvent.Room;
        //    existingScheduleEvent.Type = newScheduleEvent.Type;
        //    existingScheduleEvent.Name = newScheduleEvent.Name;
        //    existingScheduleEvent.Lecturer = newScheduleEvent.Lecturer;
        //    existingScheduleEvent.AdditionalInformation = newScheduleEvent.AdditionalInformation;
        //    existingScheduleEvent.AddtionalEvents = newScheduleEvent.AddtionalEvents;
        //}

        private ScheduleEvent? GetEventById(string id)
        {
            ScheduleEvent? scheduleEvent = _events.Find((scheduleEvent) => scheduleEvent.Id == id);
            //ArgumentNullException.ThrowIfNull(scheduleEvent);

            return scheduleEvent;
        }
    }
}
