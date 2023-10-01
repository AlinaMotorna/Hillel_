namespace Information_about_the_user
{
    internal class User
    {
        public string login;
        public string name;
        public string surname;
        private string date = "1.12.23";

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
            }
        }

        internal void PrintUser()
        {
            throw new NotImplementedException();
        }
    }

}
