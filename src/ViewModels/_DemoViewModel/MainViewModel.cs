using CoreModel;
using ViewModelBase;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            StartGloba = new Command<string>(OuterHandler.Starter);
            StartBerezina = new Command<string>(OuterHandler.Starter);
            StartSafronov = new Command<string>(OuterHandler.Starter);
            StartMarkov = new Command<string>(OuterHandler.Starter);
            StartSlyusar = new Command<string>(OuterHandler.Starter);
            StartPavlov = new Command<string>(OuterHandler.Starter);
            StartPinigin = new Command<string>(OuterHandler.Starter);
            StartBiryukov = new Command<string>(OuterHandler.Starter);
        }

        // Команды для открытия программных модулей, привязка к MainWindow
        public Command<string> StartGloba { get; }
        public Command<string> StartBerezina { get; }
        public Command<string> StartSafronov { get; }
        public Command <string> StartMarkov { get; }
        public Command<string> StartSlyusar { get; }
        public Command<string> StartPavlov { get; }
        public Command<string> StartPinigin { get; }
        public Command<string> StartBiryukov { get; }

    }
}
