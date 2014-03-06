using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticleEmitter : ParticleEmitter
    {
        public ChaoticParticleEmitter(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed, randomGenerator)
        {
        }

        protected override Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
        {
            return new ChaoticParticle(position, new MatrixCoords(0, 0), this.randomGenerator);
        }
    }
}
