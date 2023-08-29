using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON , LOST }

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public TextMeshProUGUI dialogueBox;

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

        dialogueBox.text = "Un " + enemyUnit.unitName + " salvaje aparece...";

        playerUnit.setHUD(playerHUD);
        enemyUnit.setHUD(enemyHUD);

        yield return new WaitForSeconds(1f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerTurn(){
        dialogueBox.text = "Selecciona una opcion...";
    }

    IEnumerator PlayerAttack(int attackNumber){

        bool isDead = executeAttack(playerUnit, attackNumber, enemyUnit);

        dialogueBox.text = playerUnit.getAttackByNumber(attackNumber) + " golpeó al enemigo";

        if(isDead){
            state = BattleState.WON;
            EndBattle();
        }else{
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
        yield return new WaitForSeconds(0.01f);
    }

    void EndBattle(){
            Debug.Log(state);
        if(state == BattleState.WON){
            SceneManager.LoadScene("basicScene");
        }
        else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private bool executeAttack(Unit unit, int attack, Unit target){
        bool isDead = unit.executeAttack(attack,target);
        target.getHUD().SetHP(target.currentHP);
        return isDead;
    }

    IEnumerator EnemyTurn(){

        yield return new WaitForSeconds(1f);

        //private Random random = new Random();

        //int randomNumber = random.Next(1, 5);

        bool isDeadPlayer = executeAttack(enemyUnit, 1, playerUnit);


        dialogueBox.text = enemyUnit.getAttackByNumber(1) + " golpeó al jugador";

        yield return new WaitForSeconds(1f);

        if(isDeadPlayer){
            state = BattleState.LOST;
            EndBattle();
        }else{
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
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
