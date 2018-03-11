using System;
using System.Linq;

namespace GameBoy.Net.Devices.Graphics.Util
{
    /// <summary>
    /// The GameBoy GPU render state.
    /// </summary>
    internal class RenderContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderContext"/> class.
        /// </summary>
        /// <param name="renderSettings">The render settings.</param>
        /// <param name="tileSet">The tile set.</param>
        /// <param name="backgroundTileMap">The background tile map.</param>
        /// <param name="windowTileMap">The window tile map.</param>
        /// <param name="spriteOam">The sprite oam.</param>
        /// <param name="spriteTileSet">The sprite tile set.</param>
        public RenderContext(RenderSettings renderSettings,
                             ArraySegment<byte> tileSet,
                             ArraySegment<byte> backgroundTileMap,
                             ArraySegment<byte> windowTileMap,
                             ArraySegment<byte> spriteOam,
                             ArraySegment<byte> spriteTileSet)
        {
            RenderSettings = renderSettings;
            TileSet = tileSet;
            BackgroundTileMap = backgroundTileMap;
            WindowTileMap = windowTileMap;
            SpriteOam = spriteOam;
            SpriteTileSet = spriteTileSet;
        }

        /// <summary>
        /// Gets the render settings.
        /// </summary>
        /// <value>
        /// The render settings.
        /// </value>
        public RenderSettings RenderSettings { get; }

        /// <summary>
        /// Gets the tile set bytes.
        /// </summary>
        /// <value>
        /// The tile set bytes.
        /// </value>
        public ArraySegment<byte> TileSet { get; }

        /// <summary>
        /// Gets the tile map bytes.
        /// </summary>
        /// <value>
        /// The tile map bytes.
        /// </value>
        public ArraySegment<byte> BackgroundTileMap { get; }

        /// <summary>
        /// Gets or sets the window tile map.
        /// </summary>
        /// <value>
        /// The window tile map.
        /// </value>
        public ArraySegment<byte> WindowTileMap { get; }

        /// <summary>
        /// Gets the sprite bytes.
        /// </summary>
        /// <value>
        /// The sprite bytes.
        /// </value>
        public ArraySegment<byte> SpriteOam { get; }

        /// <summary>
        /// Gets the sprite tile set bytes.
        /// </summary>
        /// <value>
        /// The sprite tile set bytes.
        /// </value>
        public ArraySegment<byte> SpriteTileSet { get; }

        /// <summary>
        /// Gets the checksum of this render context.
        /// </summary>
        /// <returns></returns>
        public RenderChecksum GetChecksum() => new RenderChecksum(this);
    }
}
