using HeartlessRock.GameModes.Abstractions;

namespace HeartlessRock.Game;

internal class Game(IGameMode gameMode)
{
    private readonly IGameMode _gameMode = gameMode;
}
