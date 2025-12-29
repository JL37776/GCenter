using GCenter.Interfaces;

namespace GCenter.GameWorld.GameImplements;

public class GamePureBattle:IGameWorld,INetworkGame
{
    public void GameInit()
    {
        BuildConnection();
    }

    public void GameStart()
    {
    }

    public void GameEnd()
    {
    }

    public void BuildConnection()
    {
        
    }
}