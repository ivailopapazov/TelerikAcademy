using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        // Define max row and col vector component
        protected const int MaxColAccelerationMagnitude = 2;
        protected const int MaxRowAccelerationMagnitude = 2;

        protected Random randomGenerator;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed)
        {
            this.randomGenerator = randomGenerator;
        }

        public override IEnumerable<Particle> Update()
        {
            // Create new random MatrixCoords (in specified range);
            MatrixCoords randomAcceleration = new MatrixCoords();
            randomAcceleration.Col = randomGenerator.Next(-MaxColAccelerationMagnitude, MaxColAccelerationMagnitude + 1);
            randomAcceleration.Row = randomGenerator.Next(-MaxRowAccelerationMagnitude, MaxRowAccelerationMagnitude + 1);

            // Random particle acceleration
            this.Accelerate(randomAcceleration);
            
            // Update particle
            return base.Update();
        }

    }
}
