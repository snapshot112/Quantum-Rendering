using Particle_Propagation.Simulator;

namespace Quantum_Rendering;

class Program
{
    static void Main(string[] args)
    {
        Simulator simulator = new Simulator();

        simulator.Run();

        Console.WriteLine("Hello, World!");
        Console.Clear();
    }
}
