using Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Infrastructure
{
    public static class EntityExtensions
    {
        public static ConferenceDTO.SpeakerResponse MapSpeakerResponse(this Speaker speaker) =>
            new ConferenceDTO.SpeakerResponse
            {
                Id = speaker.Id,
                Name = speaker.Name,
                Bio = speaker.Bio,
                Website = speaker.Website,

                Sessions = speaker.SessionSpeakers?
                    .Select(ss => new ConferenceDTO.Session
                    {
                        Id = ss.SessionId,
                        Title = ss.Session.Title
                    }).ToList()
            };
    }
}
