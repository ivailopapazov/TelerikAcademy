namespace CheffClassRefactor
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            PeelVegetable(potato);
            CutPeeledVegetable(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            PeelVegetable(carrot);
            CutPeeledVegetable(carrot);
            bowl.Add(carrot);
        }

        private void CutPeeledVegetable(Vegetable vedgetable)
        {
            vedgetable.IsCuted = true;
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();
            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();
            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();
            return potato;
        }

        private void PeelVegetable(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }

}