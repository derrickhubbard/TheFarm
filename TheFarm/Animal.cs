using System;

namespace TheFarm
{
    public class Aniaml
    {
        public string name;
        public string makeSound;
        public string kind;

        public Aniaml()
        {
            name = "Null";
            makeSound = "Whats Up";
            kind = "Duck";
        }
        public void Name (string newName)
        {
            name = newName;
        }
        public void MakeSound (string newSound)
        {
            makeSound = newSound;
        }
        public void Kind(string newkind)
        {
            kind = newkind;
        }
        public void Talk()
        {
            Console.WriteLine("This is a {0} named: {1}", kind, name);
            Console.WriteLine("This is the sound i {0}", makeSound);
        }
    }
}