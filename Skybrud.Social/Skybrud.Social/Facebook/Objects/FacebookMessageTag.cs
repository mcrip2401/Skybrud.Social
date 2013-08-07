﻿using Skybrud.Social.Json;

namespace Skybrud.Social.Facebook.Objects {

    public class FacebookMessageTag {

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Offset { get; private set; }
        public int Length { get; private set; }

        public static FacebookMessageTag Parse(JsonObject obj) {
            return new FacebookMessageTag {
                Id = obj.GetLong("id"),
                Name = obj.GetString("name"),
                Type = obj.GetString("type"),
                Offset = obj.GetInt("offset"),
                Length = obj.GetInt("length")
            };
        }

        public static FacebookMessageTag[] ParseMultiple(JsonArray array) {
            return array == null ? new FacebookMessageTag[0] : array.ParseMultiple(Parse);
        }

    }

}
