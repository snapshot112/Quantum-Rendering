namespace Particle_Propagation.Simulator;

public interface IRenderEngine
{
    public void Render(IList<Particle> particles);
}

public class RenderEngine() : IRenderEngine
{
    public void Render(IList<Particle> particles)
    {
        throw new NotImplementedException();
    }
}