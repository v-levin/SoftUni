using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.RoliTheCoder
{
    public class RoliTheCoder
    {
        public class Event
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public List<string> Participants { get; set; }
        }

        public static void Main()
        {
            var events = new List<Event>();
            var eventsById = new Dictionary<int, Event>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Time for Code")
                {
                    break;
                }

                var inputParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var eventId = 0;

                if (!int.TryParse(inputParams[0], out eventId))
                {
                    continue;
                }

                string eventName = null;

                if (inputParams.Length > 1 && inputParams[1].StartsWith("#"))
                {
                    eventName = inputParams[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();

                if (inputParams.Length > 2)
                {
                    participants = inputParams.Skip(2).ToList();

                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventsById.ContainsKey(eventId))
                {
                    if (eventsById[eventId].Name == eventName)
                    {
                        var existingEvent = eventsById[eventId];
                        existingEvent.Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = participants
                    };

                    events.Add(newEvent);
                    eventsById.Add(eventId, newEvent);
                }
            }

            var sortedEvents = events.OrderByDescending(e => e.Participants.Distinct().Count()).ThenBy(e => e.Name).ToList();

            foreach (var ev in sortedEvents)
            {
                var distinctParticipants = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");

                foreach (var participant in distinctParticipants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
