namespace card
{
    public class Player
    {
        int score;
        string name;
        deck deck;

        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
        public deck Deck { get => deck; set => deck = value; }

        public Player(string name){
            Score = 0;
            Name = name;
            Deck = new deck();
        }

        public void ScorePoint(){
            Score++;
        }


    }
}