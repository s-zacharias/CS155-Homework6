using System;
namespace Project1
{
    public class Counter
    {

        // constructer
        public Counter()
        {
            
        }

        // declare counter variable 
        private int count;

        // method to set counter to 0
        public void setCounter()
        {
            this.count = 0;
        }

        // method to increment counter
        public void incrementCounter()
        {
            this.count++;
        }

        // method to decrement counter
        public void decrementCounter()
        {
            if (count > 0)
            {
                this.count--;
            }
        }

        // getter method
        public int currentCount()
        {
            return count;
        }

        // display method
        public void displayCountToScreen()
        {
            Console.WriteLine("The current count is: " + count);
        }

        // toString method
        public String toString()
        {
            return "Counter = " + count;
        }

        // Equals method
        public bool Equals(Counter other)
        {
            if (this.count == other.count)
            {
                return true;
            }
            if (other.count == null)
            {
                return false;
            } else
            {
                return false;
            }
        }
    }
}
