using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PieceData> pianoPieces = new Dictionary<string, PieceData>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentPiece = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currentPiece[0];
                string composer = currentPiece[1];
                string tonality = currentPiece[2];

                pianoPieces.Add(name, new PieceData(composer, tonality));
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Add")
                {
                    string pieceName = command[1];
                    string currentComposer = command[2];
                    string currentKey = command[3];

                    if (pianoPieces.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        pianoPieces.Add(pieceName, new PieceData(currentComposer, currentKey));

                        Console.WriteLine($"{pieceName} by {currentComposer} in {currentKey} added to the collection!");
                    }

                }
                else if (command[0] == "Remove")
                {
                    string pieceName = command[1];

                    if (pianoPieces.ContainsKey(pieceName))
                    {
                        pianoPieces.Remove(pieceName);

                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    string pieceName = command[1];
                    string newKey = command[2];

                    if (pianoPieces.ContainsKey(pieceName))
                    {
                        pianoPieces[pieceName].Tonality = newKey;

                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

            }


            Dictionary<string, PieceData> sortedPianoPieces =
                pianoPieces.OrderBy(x => x.Key)
                .ThenBy(x => x.Value.Composer)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var piece in sortedPianoPieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Tonality}");
            }






        }


        public class PieceData
        {
            public string Composer { get; set; }
            public string Tonality { get; set; }


            public PieceData(string composer, string tonality)
            {
                this.Composer = composer;
                this.Tonality = tonality;
            }
        }
    }
}
