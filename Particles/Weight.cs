namespace Particle_Propagation.Particles;

public class Weight(Vector location, float probability)
{
    public Vector Location { get; } = location;
    public float Probability { get; } = probability;

    public List<Weight> Propagate(Direction direction)
    {
        List<Weight> newWeights = new();

        int distributionCount = direction.X * direction.DistributionRange.X;
        float distributedWeight = Probability / distributionCount;
        
        for (int xi = Location.X + direction.X - direction.DistributionRange.X;
             xi <= Location.X + direction.X + direction.DistributionRange.X;
             xi++)
        {
            for (int xy = Location.Y + direction.Y - direction.DistributionRange.Y;
                 xy <= Location.Y + direction.Y + direction.DistributionRange.Y;
                 xy++)
            {
                for (int xz = Location.Z + direction.Z - direction.DistributionRange.Z;
                     xz <= Location.Z + direction.Z + direction.DistributionRange.Z;
                     xz++)
                {
                    newWeights.Add(new Weight(new Vector(xi, xy, xz), distributedWeight));
                }
            }
        }
        
        return newWeights;
    }
}