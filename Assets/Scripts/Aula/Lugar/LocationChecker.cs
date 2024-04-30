public class LocationChecker
{
    public enum Location
    {
        Null,
        Observatory,
        Circus,
        Aquarium,
        Theater,
        Library,
        Museum,
        Park,
        Radio,
        University,
        Cinema,
        Gym,
        Musical,
        ResearchCenter,
        Startup,
        BotanicalGarden,
        NGO
    }

    public static Location EvaluateLocation()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        // (Switch não usado pois o nível de ensino não é constante)
        if (gameState.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            if (gameState.Inteligencias == Inteligencias.LinguisticaComLogicoMatematica)
                return Location.Observatory;
            else if (gameState.Inteligencias == Inteligencias.IntrapessoalComEspacialVisual)
                return Location.Circus;
            else if (gameState.Inteligencias == Inteligencias.CorporalCinestesicaComNaturalista)
                return Location.Aquarium;
            else
                return Location.Theater;
        }
        else if (gameState.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental())
        {
            if (gameState.Inteligencias == Inteligencias.LinguisticaComLogicoMatematica)
                return Location.Library;
            else if (gameState.Inteligencias == Inteligencias.IntrapessoalComEspacialVisual)
                return Location.Museum;
            else if (gameState.Inteligencias == Inteligencias.CorporalCinestesicaComNaturalista)
                return Location.Park;
            else
                return Location.Radio;
        }
        else if (gameState.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
        {
            if (gameState.Inteligencias == Inteligencias.LinguisticaComLogicoMatematica)
                return Location.University;
            else if (gameState.Inteligencias == Inteligencias.IntrapessoalComEspacialVisual)
                return Location.Cinema;
            else if (gameState.Inteligencias == Inteligencias.CorporalCinestesicaComNaturalista)
                return Location.Gym;
            else
                return Location.Musical;
        }
        else
        {
            if (gameState.Inteligencias == Inteligencias.LinguisticaComLogicoMatematica)
                return Location.ResearchCenter;
            else if (gameState.Inteligencias == Inteligencias.IntrapessoalComEspacialVisual)
                return Location.Startup;
            else if (gameState.Inteligencias == Inteligencias.CorporalCinestesicaComNaturalista)
                return Location.BotanicalGarden;
            else
                return Location.NGO;
        }
    }

    public static string EvaluateLocationName()
    {
        Location location = EvaluateLocation();

        switch (location)
        {
            case Location.Observatory:
                return "Observatório";
            case Location.Circus:
                return "Circo";
            case Location.Aquarium:
                return "Aquário";
            case Location.Theater:
                return "Teatro";
            case Location.Library:
                return "Biblioteca";
            case Location.Museum:
                return "Museu";
            case Location.Park:
                return "Parque da Cidade";
            case Location.Radio:
                return "Rádio";
            case Location.University:
                return "Universidade";
            case Location.Cinema:
                return "Cinema";
            case Location.Gym:
                return "Ginásio de Esportes";
            case Location.Musical:
                return "Apresentação Musical";
            case Location.ResearchCenter:
                return "Centro de Pesquisa";
            case Location.Startup:
                return "Startup";
            case Location.BotanicalGarden:
                return "Jardim Botânico";
            case Location.NGO:
                return "ONG";
            default:
                return "";
        }
    }
}
