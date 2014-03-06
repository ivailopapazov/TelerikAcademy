using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private const int ParticleStartChance = 20;
        private const int ParticleStopChance = 35;

        private bool isStopped;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed, randomGenerator)
        {
            this.isStopped = false;
        }
        
        public override IEnumerable<Particle> Update()
        {
            if (this.isStopped)
            {
                // Try to start if particle is stopped.
                if (randomGenerator.Next(101) <= ParticleStartChance)
                {
                    // If particle starts, update particle.
                    this.isStopped = false;
                    return base.Update();
                }
                else
                {
                    // If particle does not start, return empty particle list without moving the particle.
                    return new List<Particle>();
                }
            }
            // Particle is Moving
            else
            {
                // Try to stop if particle moves.
                if (randomGenerator.Next(101) <= ParticleStopChance)
	            {
                    // If particle stops
                    // Current particle doesn't move for the current tick
                    // Return new particle with current position (lays)
                    this.isStopped = true;
                    return new List<ChickenParticle>() { new ChickenParticle(this.Position, new MatrixCoords(0, 0), randomGenerator) };
	            }
                else
                {
                    // Particle continues to move. Update particle.
                    return base.Update();
                }
            }
        }
    }
}
