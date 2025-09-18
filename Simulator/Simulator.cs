namespace Particle_Propagation.Simulator;

public class Simulator
{
    private readonly RenderEngine _renderEngine = new RenderEngine();
    private readonly List<Particle> _particles = new List<Particle>();
    
    public void Run()
    {
        bool running = true;
        while (running)
        {
            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D0:
                    Step(0);
                    break;
                case ConsoleKey.D1:
                    Step(1);
                    break;
                case ConsoleKey.D2:
                    Step(2);
                    break;
                case ConsoleKey.D3:
                    Step(3);
                    break;
                case ConsoleKey.D4:
                    Step(4);
                    break;
                case ConsoleKey.D5:
                    Step(5);
                    break;
                case ConsoleKey.D6:
                    Step(6);
                    break;
                case ConsoleKey.D7:
                    Step(7);
                    break;
                case ConsoleKey.D8:
                    Step(8);
                    break;
                case ConsoleKey.D9:
                    Step(9);
                    break;
                case ConsoleKey.Escape:
                    running = false;
                    break;
                default:
                    continue;
            }
        }
    }

    private void Step(int stepCount = 1)
    {
        Console.WriteLine("Step #" + stepCount);
        
        //Step logic
        foreach (var particle in _particles)
        {
            particle.Propagate();
        }
        
        //DetectCollisions(_particles);
        

        _renderEngine.Render(_particles);
    }

    public void Initialize(IList<Particle> particles)
    {
        _particles.AddRange(particles);
    }

    private void DetectCollisions(IList<Particle> particles)
    {
        throw new NotImplementedException();
    }
    
}