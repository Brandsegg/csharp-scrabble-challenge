﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private Dictionary<char, int> _letterPoints;
        private string _word;

        public Scrabble(string word)
        {
            _word = word;
            //TODO: do something with the word variable

            _letterPoints = new Dictionary<char, int>();
            _letterPoints.Add('A', 1);
            _letterPoints.Add('E', 1);
            _letterPoints.Add('I', 1);
            _letterPoints.Add('O', 1);
            _letterPoints.Add('U', 1);
            _letterPoints.Add('L', 1);
            _letterPoints.Add('N', 1);
            _letterPoints.Add('R', 1);
            _letterPoints.Add('S', 1);
            _letterPoints.Add('T', 1);
            _letterPoints.Add('D', 2);
            _letterPoints.Add('G', 2);
            _letterPoints.Add('B', 3);
            _letterPoints.Add('C', 3);
            _letterPoints.Add('M', 3);
            _letterPoints.Add('P', 3);
            _letterPoints.Add('F', 4);
            _letterPoints.Add('H', 4);
            _letterPoints.Add('V', 4);
            _letterPoints.Add('W', 4);
            _letterPoints.Add('Y', 4);
            _letterPoints.Add('K', 5);
            _letterPoints.Add('J', 8);
            _letterPoints.Add('X', 8);
            _letterPoints.Add('Q', 10);
            _letterPoints.Add('Z', 10);

            

        }
            
        public int score()
        {
            int points = 0;

            foreach (char c in _word)
            {
                Char.ToUpper(c);

                if (_letterPoints.ContainsKey(c)) 
                {
                    points += _letterPoints[c];
                }  
            }
            /*
            ///extension stuff
            if(_word.StartsWith('[') && _word.EndsWith(']'))

           */
            return points;
        }
    }
}
