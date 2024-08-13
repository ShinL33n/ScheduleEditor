﻿using ScheduleEditor.Frontend.Models;
using static ScheduleEditor.Frontend.Models.ScheduleEvent;

namespace ScheduleEditor.Frontend.Clients
{
    public class EventsClient
    {
        private List<ScheduleEvent> _events = new List<ScheduleEvent> {
            new ScheduleEvent {
                Id = "tr3-td1",
                Name = "Przetwarzanie sygnałów",
                Type = ClassType.Laboratorium,
                Room = "NE 237",
                Lecturer = "dr inż. Daniel Węsierski",
                AdditionalInformation = "Co 2 tygodnie"
            },
            new ScheduleEvent {
                Id = "tr4-td1",
                Name = "Przetwarzanie sygnałów",
                Type = ClassType.Laboratorium,
                Room = "NE 237",
                Lecturer = "dr inż. Daniel Węsierski",
                AdditionalInformation = "Co 2 tygodnie"
            },
            new ScheduleEvent {
                Id = "tr5-td1",
                Name = "Elementy elektroniczne",
                Type = ClassType.Laboratorium,
                Room = "EA 212",
                Lecturer = "dr inż. Łukasz Gołuński",
                AdditionalInformation = "Co 2 tygodnie"
            },
            new ScheduleEvent {
                Id = "tr6-td1",
                Name = "Przetwarzanie sygnałów",
                Type = ClassType.Laboratorium,
                Room = "EA 212",
                Lecturer = "dr inż. Łukasz Gołuński",
                AdditionalInformation = "Co 2 tygodnie"
            },
            new ScheduleEvent {
                Id = "tr7-td1",
                Name = "Sensory i sieci sensorowe",
                Type = ClassType.Wykład,
                Room = "NE AUD1L",
                Lecturer = "dr inż. Grzegorz Jasiński"
            },
            new ScheduleEvent {
                Id = "tr8-td1",
                Name = "Sensory i sieci sensorowe",
                Type = ClassType.Wykład,
                Room = "NE AUD1L",
                Lecturer = "dr inż. Grzegorz Jasiński"
            }
        };

        public List<ScheduleEvent> GetAllEvents()
            => _events;

        // Change This Method If ScheduleEventViewModel Will Change Into Smth Different Than ScheduleEvent Class
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
