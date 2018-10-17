using System;

namespace BaseInheritance
{
    class Deck:Rectangle
    {
        public Deck(int w, int s) : base(w, s)
        {
        }

        public int Cost()
        {
            int cost;
            cost = CalculateSurface() * 50;



            return cost;
        }

        public void DisplayInformation()
        {
            // the key word base allows us to refer to the components of the base class
            // for the compiler more important variables from the class in which we are
            // using the base keyword we indicate unambiguously to which component
            // we want to appeal. Thanks to the following call in the current method we will call
            // also the method from the base class - more information will be displayed
            base.DisplayInformation();
            Console.WriteLine("Cost: {0}", Cost());
        }

    }
}
