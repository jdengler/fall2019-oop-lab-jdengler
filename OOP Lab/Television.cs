namespace OOP_Lab
{
    class Television
    {
        private string manufacturer;
        private int screenSize;
        private bool powerOn;
        private int channel;
        private int volume;

        // Constructor creates an instance of Television and initializes each 
        //      variable used in the class when called from Program class.
        public Television(string brand, int size)
        {
            manufacturer = brand;
            screenSize = size;
            powerOn = false;
            volume = 20;
            channel = 2;
        }

        // Mutator method to set channel variable
        public void SetChannel(int station)
        {
            channel = station;
        }

        // Accessor method to return channel variable
        public int GetChannel()
        {
            return channel;
        }

        // Mutator method to change tv power
        public void Power()
        {
            powerOn = !powerOn;
        }

        // Mutator method to increment volume
        public void IncreaseVolume()
        {
            volume++;
        }

        // Mutator method to decrement volume
        public void DecreaseVolume()
        {
            volume--;
        }

        // Accessor method to return volume variable
        public int GetVolume()
        {
            return volume;
        }

        // Accessor method to return manufacturer variable
        public string GetManufacturer()
        {
            return manufacturer;
        }

        // Accessor method to return screenSize variable
        public int GetScreenSize()
        {
            return screenSize;
        }

        // Returns string with television information depending on power
        public override string ToString()
        {
            if (powerOn)
                return ("A " + screenSize + " inch " + manufacturer + " has been turned on.");
            
            else
                return ("A " + screenSize + " inch " + manufacturer + " has been turned off.");
        }
    }
}