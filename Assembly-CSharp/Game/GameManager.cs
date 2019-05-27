using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameManager
{
    private GameMainCamera MainCamera;
    
    #region Login Levels

    public static bool Level1 = false;

    public static bool Level2 = false;

    public static bool Level3 = false;

    public static bool LevelOwl = false;

    #endregion

    public void AddCamera(GameMainCamera Cam)
    {
        this.MainCamera = Cam;
    }

    public void AddColossal()
    {
        /*ct add here*/
    }

    public void AddErenTitan()
    {
        /*Eren Titan code here*/
    }

    public void AddAnnieTitan()
    {
        /*Annie Titan code here*/
    }

    public void AddHero()
    {
        /*hero add code here*/
    }

    public void AddHook()
    {
        /*hook add code here*/
    }

    public void AddTime(float Time)
    {
        /*this.TotalServerTime -= Time;*/
    }
    public void AddTitan()
    {
        /*add titan code here*/
    }


}
