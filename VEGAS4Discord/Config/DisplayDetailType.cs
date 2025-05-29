using System;

namespace VegasDiscordRPC 
{
    [Flags]
    public enum DisplayDetailType
    {
        TRACKS = 1,
        PROJECT_FILENAME = 2,
        MEDIA_EVENTS = 4,

        TRACK_AND_FILENAME = TRACKS | PROJECT_FILENAME
    }
}
