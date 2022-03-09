using System.ComponentModel;
using System;
using System.Linq;
using System.Diagnostics;

namespace ABC
{
    class ABCSolver {
        // 1 = used, 0 = not used
        private int[] cubesUsed;
        private string word;
        private List<Cube> listOfCubes;

        public ABCSolver(string word, string sides1, string sides2) {
            this.word = word;
            this.listOfCubes = new List<Cube>();
            addCubes(sides1, sides2);
            cubesUsed = new int[listOfCubes.Count];
        }

        private void addCubes(string sides1, string sides2) {
            Debug.Assert(sides1.Length == sides2.Length, "Mismatch cube sizes");
            for (int i = 0; i < sides1.Length; ++i) {
                listOfCubes.Add(new Cube(sides1[i], sides2[i]));
            }
        }

        private void selectCubesToCreateWord() {
            foreach (char c in word) {
                for (int cubeIdx = 0; cubeIdx < listOfCubes.Count; ++cubeIdx) {
                    if (listOfCubes[cubeIdx].cubeHasChar(c) && cubesUsed[cubeIdx] != 1) {
                        cubesUsed[cubeIdx] = 1;
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
            selectCubesToCreateWord();
            return cubesUsed.Sum() == this.word.Length;
        }
    }
}
