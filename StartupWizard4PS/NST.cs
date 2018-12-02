namespace StartupWizard4PS
{
    class NST
    {
        // deze methode schrijft de company lijst weg
        private string getNSTname(string NST)
        {
            switch (NST)
            {
                case "Test":
                    {
                        return "/NST100TestWS/WS/";
                    }
                case "Ontwikkel":
                    {
                        return "/NST100OntwWS/WS/";
                    }
                case "Productie":
                    {
                        return "/NST100ProdWS/WS/";
                    }
                default:
                    return "Invalid";
            }

        }
    }
}
