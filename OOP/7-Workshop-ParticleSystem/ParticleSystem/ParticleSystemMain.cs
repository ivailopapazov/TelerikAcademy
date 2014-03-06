using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 40;

        static readonly Random RandomGenerator = new Random();

        static void Main(string[] args)
        {
            StringBuilder choiceMenu = new StringBuilder();
            choiceMenu.AppendLine("Choose particle:");
            choiceMenu.AppendLine("1: Single Chaotic Particle");
            choiceMenu.AppendLine("2: Chaotic Particle Emitter");
            choiceMenu.AppendLine("3: Chicken Particle");
            choiceMenu.Append("4: Particle Repeller");

            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new RepellingParticleUpdater();

            var chaoticParticle = new List<Particle>()
            {
                new ChaoticParticle(new MatrixCoords(15,20), new MatrixCoords(0, 0), RandomGenerator),
            };

            var chaoticParticleEmitter = new List<Particle>()
            {
                new ChaoticParticleEmitter(new MatrixCoords(12,20), new MatrixCoords(0, 0), RandomGenerator),
            };

            var chickenParticle = new List<Particle>()
            {
                new ChickenParticle(new MatrixCoords(15,20), new MatrixCoords(0, 0), RandomGenerator),
            };

            var repellerParticle = new List<Particle>()
            {
                new ParticleEmitter(new MatrixCoords(9,9), new MatrixCoords(0, 0), RandomGenerator),
                new ParticleEmitter(new MatrixCoords(23,15), new MatrixCoords(0, 0), RandomGenerator),
                new ParticleRepeller(new MatrixCoords(15,15), new MatrixCoords(0, 0)),
            };

            Console.WriteLine(choiceMenu);
            int choice = int.Parse(Console.ReadLine());
            List<Particle> particles;

            switch (choice)
            {
                case 1:
                    particles = chaoticParticle;
                    break;
                case 2:
                    particles = chaoticParticleEmitter;
                    break;
                case 3:
                    particles = chickenParticle;
                    break;
                case 4:
                    particles = repellerParticle;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            var engine = new Engine(renderer, particleOperator, particles, 200);

            engine.Run();
        }
    }
}
