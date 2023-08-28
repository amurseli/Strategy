using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackStrategy{

    abstract void executeAttack(Unit enemyUnit);
}
