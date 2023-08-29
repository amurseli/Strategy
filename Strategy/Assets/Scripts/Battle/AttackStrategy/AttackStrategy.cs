using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackStrategy{


    abstract bool executeAttack(Unit unit, Unit enemyUnit);

    public string getName();
}
