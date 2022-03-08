using System.ComponentModel;
using System;
using System.Linq;
using System.Diagnostics;

namespace ABC
{
    class ABCSolver {
        private int[] sideFlag;
        private string word;
        private List<Cube> cubes;
        public ABCSolver(string word, string sides1, string sides2) {
            this.word = word;
            this.cubes = new List<Cube>();
            addCubes(sides1, sides2);
            sideFlag = new int[cubes.Count];
        }
        private void addCubes(string sides1, string sides2) {
            Debug.Assert(sides1.Length == sides2.Length, "Mismatch cube sizes");
            for (int i = 0; i < sides1.Length; ++i) {
                cubes.Add(new Cube(sides1[i], sides2[i]));
            }
        }
        private void generateWordMapping1() {
            foreach (char c in word) {
                for (int cubeIdx = 0; cubeIdx < cubes.Count; ++cubeIdx) {
                    if (cubes[cubeIdx].check(c) && sideFlag[cubeIdx] != 1) {
                        sideFlag[cubeIdx] = 1;
                        break;
                    }
                }
            }
        }

        private void printArray(int[] array) {
            foreach (int i in array) {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
        }
        public bool solve() {
            generateWordMapping1();
            return sideFlag.Sum() == this.word.Length;
        }
    }
}
