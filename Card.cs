using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Card
{
    //puts a get on string Number and string Suit. after that, then it would geta public param.
    public string Number { get; }

    public string Suit { get; }

    public Card(string numParam, string suitParam)
    {
        Number = numParam;
        Suit = suitParam;
    }
}