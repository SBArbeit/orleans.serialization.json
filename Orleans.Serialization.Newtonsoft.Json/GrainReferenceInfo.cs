﻿namespace Orleans.Serialization.Newtonsoft.Json
{
    internal class GrainReferenceInfo
    {
        public string Key { get; set; }

        public byte[] Data { get; set; }
    }
}