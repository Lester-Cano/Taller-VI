using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginBattleState : State
{
    public BeginBattleState(TurnSystem turnSystem) : base(turnSystem)
    {
    }

    public override IEnumerator Start()
    {
        // !! Set "tittle level" text. !!

        // !! Create Grid Map. !!

        TurnSystem.map.SpawnUnit();
        TurnSystem.map.SpawnEnemies();


        //Fill allyTeam & enemyteam.

        #region filling

        //for (int x = 0; x < TurnSystem.map.mapXLength; x++)
        //{
        //    for (int y = 0; y < TurnSystem.map.mapYLength; y++)
        //    {
        //        TurnSystem.sprite = TurnSystem.map.map[x, y];

        //        // !! Check if there is an enemy or an ally and fill the fields. !!
        //    }
        //}


        #endregion

        yield return new WaitForSeconds(2f);

        TurnSystem.SetState(new PlayerTurnState(TurnSystem));
    }
}
