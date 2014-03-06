using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class RepellingParticleUpdater : ParticleUpdater
    {
        private List<ParticleRepeller> currentParticleRepellers = new List<ParticleRepeller>();
        private List<Particle> currentParticles = new List<Particle>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            ParticleRepeller castedParticleRepeller = p as ParticleRepeller;
            if (castedParticleRepeller != null)
            {
                this.currentParticleRepellers.Add(castedParticleRepeller);
            }
            else
            {
                this.currentParticles.Add(p);
            }

            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in currentParticleRepellers)
            {
                foreach (var particle in currentParticles)
                {
                    // Get distance vector
                    MatrixCoords distanceVector = particle.Position - repeller.Position;

                    // Get vector's magnitude (distance between particles)
                    int vectorMagnitude = GetVectorMagnitude(distanceVector);

                    // Get vector's direction (unit vectors). Simply said repelling direction.
                    MatrixCoords repellingDirection = GetVectorDirection(distanceVector);

                    // Get repelling vector
                    MatrixCoords repellingVector = new MatrixCoords();
                    repellingVector.Row = repellingDirection.Row * repeller.RepellingPower;
                    repellingVector.Col = repellingDirection.Col * repeller.RepellingPower;

                    // Check if a particle is in the repeller's repell radius
                    if (vectorMagnitude <= repeller.RepellRadius)
                    {
                        particle.Accelerate(repellingVector);
                    }
                }
            }

            // Clear particle lists for this tick
            this.currentParticleRepellers.Clear();
            this.currentParticles.Clear();

            base.TickEnded();
        }

        private MatrixCoords GetVectorDirection(MatrixCoords vector)
        {
            MatrixCoords unitVector = new MatrixCoords();

            if (vector.Row != 0)
            {
                unitVector.Row = vector.Row / Math.Abs(vector.Row);
            }
            if (vector.Col != 0)
            {
                unitVector.Col = vector.Col / Math.Abs(vector.Col);
            }

            return unitVector;
        }

        private int GetVectorMagnitude(MatrixCoords vector)
        {
            // Square vector components
            vector.Col *= vector.Col;
            vector.Row *= vector.Row;

            // Return square root of the sum of the squared vector components
            return (int)Math.Sqrt(vector.Row + vector.Col);
        }
    }
}
