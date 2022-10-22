using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Prompt_Manager.models
{
    internal class Prompt
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Positive { get; set; }
        public string Negative { get; set; }
        public int Seed { get; set; }
        public int CFG { get; set; }
        public int Denoise { get; set; }
        public int Steps { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Prompt(string name, string image, string positive, string negative, int seed = -1, int cfg = 7, int denoise = 75, int steps = 50, int width =512, int height = 512)
        {
            Name = name;
            Image = image;
            Positive = positive;
            Negative = negative;
            Seed = seed;
            CFG = cfg;
            Denoise = denoise;
            Steps = steps;
            Width = width;
            Height = height;
        }
    }
}
