﻿namespace XFP.ICora.Hoyolab.TravelNotes
{
    public class TravelNotesDayData
    {
        [JsonPropertyName("current_primogems")]
        public int CurrentPrimogems { get; set; }


        [JsonPropertyName("current_mora")]
        public int CurrentMora { get; set; }


        [JsonPropertyName("last_primogems")]
        public int LastPrimogems { get; set; }


        [JsonPropertyName("last_mora")]
        public int LastMora { get; set; }
    }
}
