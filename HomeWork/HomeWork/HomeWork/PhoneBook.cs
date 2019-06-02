using System;
using System.Collections.Generic;

namespace HomeWork
{
    #region HomeWork

    public class PhoneBook
    {
        public Dictionary<string, string> contacts = new Dictionary<string, string>();

        public string this[string name]
        {
            get
            {
                foreach (KeyValuePair<string, string> c in contacts)
                {
                    if (c.Key != null && c.Value != null && c.Key != name) //third part in the condition ???
                    {
                        return c.Key + " " + c.Value;
                    }
                }
                return "";
            }
            set
            {
                try
                {
                    contacts.Add(name, value);
                }
                catch
                {
                    throw new ArgumentException("***Sorry, the key and value pair you want to input already exists.***");
                }
            }
        }
    }

    #endregion



}
