using System;
using System.Collections.Generic;
using SimpleJSON;

namespace io.newgrounds.objects
{
    public class SaveSlot : Model
    {
        public string datetime { get; set; }

        public int id { get; set; }

        public int size { get; set; }

        public int timestamp { get; set; }

        public string url { get; set; }

    }
}