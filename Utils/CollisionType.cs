namespace StyxEngine.Utils
{
    public enum CollisionType
    {
        None,           // No collision
        Wall,           // Walls that block movement
        Enemy,          // Enemies that can cause damage
        Collectible,    // Items like coins or power-ups
        Hazard,         // Traps, spikes, or anything dangerous
        Goal,           // Endpoints like flags, checkpoints
        Player
    }
}
