using System;

namespace card
{
    public class Game
    {
        Player p1;
        Player p2;
        public Game(string p1_name, string p2_name){
            p1 = new Player(p1_name);
            p2 = new Player(p2_name);
        }

        public void Start(){
            Player first_p = p1;
            Player second_p = p2;
            while(!p1.Deck.isEmpty() && !p2.Deck.isEmpty()){
                string f_card = first_p.Deck.PickCard();
                Console.WriteLine(first_p.Name + " picked " + f_card);
                string s_card = second_p.Deck.PickCard();
                Console.WriteLine(second_p.Name + " picked " + s_card);
                if (s_card.Equals(f_card)){
                    second_p.ScorePoint();
                    Player temp = second_p;
                    second_p = first_p;
                    first_p = temp;
                }
            }
            Console.WriteLine(first_p.Name + " scored " + first_p.Score);
            Console.WriteLine(second_p.Name + " scored " + second_p.Score);
            if (first_p.Score > second_p.Score)
                Console.WriteLine(first_p.Name + " won !");
            else if (first_p.Score < second_p.Score)
                Console.WriteLine(second_p.Name + " won!");
            else  
                Console.WriteLine("It was a draw!");
        }
    }
}