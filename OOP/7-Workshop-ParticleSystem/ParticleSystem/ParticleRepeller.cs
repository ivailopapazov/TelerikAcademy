using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public int RepellRadius { get; protected set; }
        public int RepellingPower { get; protected set; }


        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int repellRadius = 7, int repellingPower = 1) 
            : base(position, speed)
        {
            this.RepellingPower = repellingPower;
            this.RepellRadius = repellRadius;
        }
    }
}
