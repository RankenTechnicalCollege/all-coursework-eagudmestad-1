using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1___FlashCards
{
    public class FlashCard
    {
        //Instance Fields
        private string _term;
        private string _definition;

        //Constructor
        public FlashCard(string term,string definition)
        {
            _term = term;
            _definition = definition;
        }

        //Getters
        public string GetTerm()
        {
            return _term;
        }

        public string GetDefinition()
        {
            return _definition;
        }

    }
}
