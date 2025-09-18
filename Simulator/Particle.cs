using Particle_Propagation.Particles;

namespace Particle_Propagation.Simulator;

public class Particle(Vector location, Direction direction)
{
    private int Energy { get; set; }
    private Direction Direction { get; } = direction;
    private List<Weight> Weights { get; set; } =  [new(location, 1)];

    public void Propagate()
    {
        List<Weight> newWeights = new List<Weight>();
        foreach (Weight weight in Weights)
        {
            newWeights.AddRange(weight.Propagate(Direction));
        }
        
        Weights = MergeWeights(newWeights);
    }

    private List<Weight> MergeWeights(IList<Weight> weights)
    {
         return weights
            .GroupBy(weight =>
                new { weight.Location.X , weight.Location.Y, weight.Location.Z })
            .Select(group =>
                new Weight(
                    new Vector(group.Key.X, group.Key.Y, group.Key.Z),
                    group.Sum(weight => weight.Probability)))
            .ToList();
    }
}

