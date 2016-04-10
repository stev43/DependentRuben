
using ROG_6.View;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace ROG_6
{
    class Controller
    {

        Model.Model model;
        View.View view;

        public Controller(Model.Model model, View.View view)
        {
            this.model = model;
            this.view = view;
        }

        public void Start()
        {

            view.printStart();

            List<string> tamagotchiList = StringConverter.getTamagotchis(model.tamagotchis);
            view.printTamagotchiList(tamagotchiList);

            List<string> actieList = StringConverter.getActies(model.acties);
            view.printActies(actieList);

            Boolean b = true;
            while (b)
            {
                b = checkInput(Console.ReadLine());
            }
            Console.ReadKey();
        }

        private Boolean checkInput(string input)
        {
            string command = input.ToLower();
            if (input.Contains(" "))
                command = input.Substring(0, input.IndexOf(" ")).ToLower();
            switch (command)
            {
                case "help":
                    view.printHelp();
                    break;
                case "create":
                    if (input.Contains(" "))
                    {
                        createCommandHandler(input.Substring(input.IndexOf(" "), input.Length - input.IndexOf(" ")));
                    }
                    else
                        view.printParameterError();
                    break;
                case "tamagotchi":
                    if (input.Contains(" "))
                        tamagotchiCommandHandler(input.Substring(input.IndexOf(" "), input.Length - input.IndexOf(" ")));
                    else
                        view.printParameterError();
                    break;
                case "action":
                    if (input.Contains(" ") && input.Length >= 7)
                        actionCommandHandler(input.Substring(input.IndexOf(" "), input.Length - input.IndexOf(" ")));
                    else
                        view.printParameterError();
                    break;
                case "info":
                    model.rules(model.selectedTamagotchi);
                    view.PrintTamagotchiInformatie(StringConverter.getTamagotchiInformation(model.selectedTamagotchi));
                    break;
                case "exit":
                    Console.WriteLine("Ending!");
                    return false;
                default:
                    view.PrintInvallidCommand(input);
                    break;
            }
            return true;
        }

        private void createCommandHandler(string parameter)
        {
            parameter = parameter.Trim();
            if (parameter != null && model.checkExsits(parameter) != true)
            {
                if (!Regex.IsMatch(parameter, @"a-zA-Z]+$"))
                {
                    view.PrintTamagotchiInformatie(StringConverter.getTamagotchiInformation(model.createTamagotchi(parameter)));
                }
                else
                {
                    view.PrintInvallidParameter(parameter);
                }
            }
            else
            {
                view.PrintInvallidParameter(parameter);
            }
        }

        private void tamagotchiCommandHandler(string parameter)
        {
            if (parameter.Contains("show"))
                view.printTamagotchiList(StringConverter.getTamagotchis(model.tamagotchis));
            else
            {
                parameter = parameter.Trim();
                if (Regex.IsMatch(parameter, @"^\d+$"))
                {
                    int nr = int.Parse(parameter);
                    if (model.tamagotchis.Count >= nr)
                        model.kiesTamagotchi(nr);
                    else
                    {
                        view.PrintInvallidParameter(parameter);
                    }
                }
                else
                {
                    view.PrintInvallidParameter(parameter);
                }
            }
        }

        private void actionCommandHandler(string parameter)
        {
            if (parameter.Contains("show"))
                view.printActies(StringConverter.getActies(model.acties));
            else
            {
                if (model.selectedTamagotchi != null && model.selectedTamagotchi.getBezig() != true)
                {
                    parameter = parameter.Trim();
                    if (Regex.IsMatch(parameter, @"^\d+$"))
                    {
                        int nr = int.Parse(parameter);
                        if (model.acties.Count >= nr && nr > 0)
                        {
                            nr -= 1;
                            model.actie(model.selectedTamagotchi, model.acties[nr]);
                        }
                        else
                        {
                            view.PrintInvallidParameter(parameter);
                        }
                    }
                    else
                    {
                        view.PrintInvallidParameter(parameter);
                    }
                }
                else
                {
                    view.PrintNoTamagotchi();
                }
            }

        }

    }
}
