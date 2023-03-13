public class Jogo
{
     
            /*bool playAgain = true;
            int min = 1;
            int max = 100;
            int tentativa;
            int number;
            int tentativas;
            string response;*/

            public bool playAgain { get; set; }
            public int min { get; set; }    
            public int max { get; set; }    
            public int tentativa { get; set; }
            public int number { get; set; }
            public int tentativas { get; set; }
            public string response { get; set; }

            public Jogo(){

                playAgain = true;
                min = 1;
                max = 100;
                response = "";

            }

            public void play_Again()
            {
                System.Console.WriteLine("return game ");
            }
        

            public void Jogar()
            {

                while (playAgain) 
                {

                    tentativa = 0;
                    tentativas = 0;
                    response = "";
                    number = new Random().Next(min, max);

                    while (tentativa != number) // <<<<<
                    {
                            Console.WriteLine("Digite um numero entre " + min.ToString() + " e " + max.ToString() + " : ");
                            tentativa = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Guess: " + tentativa);

                            if (tentativa > number)
                            {
                                Console.WriteLine(tentativa + " chutou alto");
                            }

                            else if (tentativa < number)
                            {
                                Console.WriteLine(tentativa + " chutou baixo");
                            }

                            tentativas++;

                    }

                        Console.WriteLine("Number: " + number);
                        Console.WriteLine("YOU WIN!");
                        Console.WriteLine("Tentativas : " + tentativas);

                        Console.WriteLine("Jogar novamente? (Y/N): ");
                        var texto = Console.ReadLine();
                        response = string.IsNullOrEmpty(texto) ? "Y" : texto;
                        
                        if(!string.IsNullOrEmpty(response))
                        
                        response = response.ToUpper();

                        Console.WriteLine("Thanks for Playing!");
                        Console.ReadKey();
        }     
                        return;
     }
}