﻿using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace EventJson
{
    public class JsonContent : StringContent
    {
        public JsonContent(object obj) :
            base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
        { }
    }
}