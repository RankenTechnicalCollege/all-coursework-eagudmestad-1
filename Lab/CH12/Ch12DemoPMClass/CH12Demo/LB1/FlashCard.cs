using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
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

        //getters
        public string GetTerm() => _term;

        public string GetDefinition()
        {
            return _definition;
        }
    }
}
