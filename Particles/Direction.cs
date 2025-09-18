namespace Particle_Propagation.Particles;

public class Direction(int x, int y, int z, Vector distributionRange) : Vector(x, y, z)
{
    public Vector DistributionRange { get; } = distributionRange;
}