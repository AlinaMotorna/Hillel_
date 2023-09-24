namespace Working_with_classes
{
    internal class Address
    {
        
		private int index;

		public int Index
		{
			get { return index; }
			set { 
				if (value >= 0000 && value <= 9999) 
				index = value; 
			}
		}
        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
            }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set
            {
                street = value;
            }
        }
        private string house;

        public string House
        {
            get { return house; }
            set
            {
                house = value;
            }
        }
        private string apartment;

        public string Apartment
        {
            get { return apartment; }
            set
            {
                apartment = value;
            }
        }
        public void PrintAddress()
        {
            Console.WriteLine(Index + "\n" + Country+"\n"+City+"\n"+ Street+"\n"+House+"\n"+ Apartment);
        }
    }

}
