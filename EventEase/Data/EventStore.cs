using EventEase.Models;

namespace EventEase.Data
{
    public class EventStore
    {
        public List<EventModel> Events { get; }

        public EventStore()
        {
            Events = GenerateEvents();
        }

        public EventModel? GetEvent(int id)
        {
            return Events.FirstOrDefault(evt => evt.Id == id);
        }

        private static List<EventModel> GenerateEvents()
        {
            var baseEvents = new List<EventModel>
            {
                new EventModel { Id = 1, Name = "Corporate Strategy Summit", Date = DateTime.Today.AddDays(14), Location = "Seattle Convention Center" },
                new EventModel { Id = 2, Name = "Product Launch Mixer", Date = DateTime.Today.AddDays(28), Location = "Downtown Hotel Ballroom" },
                new EventModel { Id = 3, Name = "Annual Client Gala", Date = DateTime.Today.AddDays(45), Location = "Riverside Banquet Hall" }
            };

            for (var index = 4; index <= 100; index++)
            {
                baseEvents.Add(new EventModel
                {
                    Id = index,
                    Name = $"Event #{index} - EventEase Showcase",
                    Date = DateTime.Today.AddDays(index + 10),
                    Location = $"Venue {index}, City Center"
                });
            }

            return baseEvents;
        }
    }
}
