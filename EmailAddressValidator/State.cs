using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAddressValidator
{
    public class State
    {
        List<Tuple<string, string>> ITransitions;

        public State(string Transitions)
        {
            this.ITransitions = new List<Tuple<string, string>>();

            foreach (string t in Transitions.Split('!'))
                ITransitions.Add(new Tuple<string, string>(t.Split(',')[0], t.Split(',')[1]));  
        }

        public string GetState(char input)
        {
            foreach (var tuple in ITransitions)
            {
                if (tuple.Item1.Length > 1)
                {
                    char infLimit = Convert.ToChar(tuple.Item1.Split(':')[0]), supLimit = Convert.ToChar(tuple.Item1.Split(':')[1]);

                    if (input >= infLimit && input <= supLimit)
                        return tuple.Item2;
                }
                else
                {
                    char acceptedSymbol = Convert.ToChar(tuple.Item1);

                    if (input == acceptedSymbol)
                        return tuple.Item2;
                }
            }

            return null;
        }
    }
}
