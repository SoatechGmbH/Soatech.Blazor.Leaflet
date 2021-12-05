﻿namespace Soatech.Blazor.Leaflet.Configuration
{
    public class TileLayerOptions
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string UrlTemplate { get; set; } = "https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png";

        public string Attribution { get; set; } = "";

        public float MinZoom { get; set; } = 1;

        public float MaxZoom { get; set; } = 20;

        public ushort TileSize { get; set; } = 512;

        public int ZoomOffset { get; set; } = -2;
    }
}
