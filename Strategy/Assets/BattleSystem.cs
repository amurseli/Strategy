using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON , LOST }

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public TextMeshProUGUI dialgueBox;

    public battleHUD playerHUD;
    public battleHUD enemyHUD;

    Unit playerUnit;
    Unit enemyUnit;

    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle(){

        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        dialgueBox.text = "Un " + enemyUnit.unitName + " salvaje aparece...";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerTurn(){
        dialgueBox.text = "Selecciona una opcion...";
    }

    IEnumerator PlayerAttack(int attackNumber){
        Debug.Log("PlayerAttack");

        playerUnit.executeAttack(attackNumber, enemyUnit);

        yield return new WaitForSeconds(2f);

    }

    public void OnAttack1Button(){
        if(state != BattleState.PLAYERTURN){
            return;
        }
        StartCoroutine(PlayerAttack(1));
    }

    public void OnAttack2Button(){
        if(state != BattleState.PLAYERTURN){
            return;
        }
        StartCoroutine(PlayerAttack(2));
    }

    public void OnAttack3Button(){
        if(state != BattleState.PLAYERTURN){
            return;
        }
        StartCoroutine(PlayerAttack(3));
    }

    public void OnAttack4Button(){
        if(state != BattleState.PLAYERTURN){
            return;
        }
        StartCoroutine(PlayerAttack(4));
    }


}
