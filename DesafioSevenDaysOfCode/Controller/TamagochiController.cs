using DesafioSevenDaysOfCode.View;


namespace DesafioSevenDaysOfCode.Controller
{
    internal class TamagochiController
    {
        public  async Task Jogar()
        {
            Menu menu = new Menu();
            string opcaoUsuario;
            int jogar = 1;
            while (jogar == 1)
            {
                menu.Mensagens();
                opcaoUsuario = Console.ReadLine();
                switch (opcaoUsuario) 
                {
                    case "1":
                        {
                            await menu.MenuAdocao();
                            break;
                        }
                    case "2": 
                        {
                            menu.VerSeusMascotes();
                            break;
                        }
                    case "3": 
                        {
                            jogar = 0;
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Opção Invalida!");
                            break;
                        }
                }
            }
        }
    }
}
