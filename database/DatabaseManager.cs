using System;
using System.IO;

namespace TRex
{
    public class DatabaseManager
    {
        private readonly string filePath = "highscore.txt";

        public void SaveScore(int score)
        {
            int currentHighScore = GetHighScore();

            if (score > currentHighScore)
            {
                File.WriteAllText(filePath, score.ToString());
            }
        }

        public int GetHighScore()
        {
            if (!File.Exists(filePath))
                return 0;

            string text = File.ReadAllText(filePath);

            if (int.TryParse(text, out int highScore))
                return highScore;

            return 0;
        }
    }
}