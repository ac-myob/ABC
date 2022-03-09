namespace ABC {
    class Cube {
        public char Side1 { get; set; }
        public char Side2 { get; set; }

        public Cube(char side1, char side2) {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public bool cubeHasChar(char inputChar) {
            return inputChar == this.Side1 || inputChar == this.Side2;
        }

        public void showCubeSides() {
            Console.WriteLine($"({this.Side1} {this.Side2})");
        }
    }
}