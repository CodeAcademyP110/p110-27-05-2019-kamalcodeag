namespace HomeWork
{
    #region HomeWork

    public class PhoneBook
    {
        private int counter = 0;
        public Contact[] contacts = new Contact[30]; // {Name = "a", Number = "123"}

        public void AddContact(Contact c)
        {
            contacts[counter++] = c;
        }

        public string this[string name]
        {
            get
            {
                foreach(var cont in contacts)
                {
                    if(cont != null && name == cont.Name)
                    {
                        return cont.Number;
                    }
                }
                
                return "Sorry, the name you searched for does not exist in the phonebook";
            }
            //set
            //{
            //    if(contacts[counter] != null)
            //    {
            //        contacts[counter].Name = name;
            //        contacts[counter++].Number = value;
            //    }
            //}
        }
    }

    #endregion



}
