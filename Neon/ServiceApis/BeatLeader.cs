using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace Neon.ServiceApis
{
    internal class BeatLeader
    {
        String RankedEndpoint = "https://api.beatleader.xyz/playlists";

        // Ranked beatmaps
        public static JsonObject GetRankedBeatmaps()
        {
            JsonObject json = new JsonObject();
            // fetch the json from the endpoint
            var client = new HttpClient();
        }
    }
}