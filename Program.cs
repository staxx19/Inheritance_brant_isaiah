﻿namespace Inheritance_brant_isaiah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                FPS myFPS = new FPS("E", "ZombCube");

                Console.WriteLine(myFPS.Describe());
                myFPS.PlayGame();

                FPS csGo = new FPS("M", "CS:GO");
                Console.WriteLine(csGo.Describe());
                csGo.PlayGame();

            }
        }
    }
}