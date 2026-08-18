using UnityEngine;

public class Assignment : MonoBehaviour
{
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Postitive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else { Debug.Log("Zero");  }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1: Debug.Log("Monday"); break;
            case 2: Debug.Log("Tuseday"); break;
            case 3: Debug.Log("Wednesday"); break;
            case 4: Debug.Log("Thursday"); break;
            case 5: Debug.Log("Friday"); break;
            case 6: Debug.Log("Saturday"); break;
            case 7: Debug.Log("Sunday"); break;
            default: Debug.Log("Invalid day"); break;  
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("Ture");
        }
        else { Debug.Log("False"); }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else { Debug.Log("F"); }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if(as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else { Debug.Log("False"); }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        double result = 0;

        switch(as06Op)
        {
            case '+' : result = as06Num1 + as06Num2; Debug.Log($"Result = {result}"); break;
            case '-' : result = as06Num1 - as06Num2; Debug.Log($"Result = {result}"); break;
            case '*' : result = as06Num1 * as06Num2; Debug.Log($"Result = {result}"); break;
            case '/' : 
                if (as06Op == 0)
                {
                    Debug.Log("Error: Cannot divide by Zero.");
                }
                else
                {
                    result = as06Num1 / as06Num2;
                }
                break;
            default:
                Debug.Log("Invalid operator. Pls use +, -, *, /.");
            return;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 2 || as07Month == 1)
            {
                Debug.Log("It's Winter");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("It's Spring");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("It's Summer");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("It's Fall");
            }
        }
        else { Debug.Log("Invalid month number. Pls try 1-12"); }

    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("สินค้าหมด");
        }
        if (as08Quantity > 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("คุณได้รับสินค้า");
                if (as08Payment > as08Price)
                {
                    Debug.Log($"คุณได้รับเงินถอน: {as08Payment - as08Price} บาท");
                }
            }
            else { Debug.Log("คุณมีเงินไม่เพียงพอ"); }

        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 0 || as09UserChoice > 2)
        {
            Debug.Log("กรุณาพิมพ์เลือกใหม่ โดยใช้ 0-2");
        }
        else
        {
            if (as09UserChoice == as09ComputerChoice)
            {
                Debug.Log("เสมอ");
            }
            else if ((as09UserChoice == 0 && as09ComputerChoice == 2 || as09UserChoice == 1 && as09ComputerChoice == 0 || as09UserChoice == 2 && as09ComputerChoice == 1))
            {
                Debug.Log("คุณชนะ");
            }
            else { Debug.Log("คุณแพ้"); }
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        double multiplier = 1.0;
        switch (as10WeaponType?.ToLower())
        {
            case "sword": multiplier = 1.3; break;
            case "axe": multiplier = 1.4; break;
            case "bow": multiplier = 1.2; break;
            case "staff": multiplier = 1.5; break;
            case "dagger": multiplier = 1.1; break;
            default: multiplier = 1.0; break;
        }
        int totalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log($"{totalDamage}");

    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        if( as11Score < 0 || as11CompletionTime < 0 )
        {
            Debug.Log("Invalid score or time");
            return;
        }

        string rank = ""; int baseCoin = 0;
        if(as11Score >= 8000)
        {
            rank = "Gold"; baseCoin = 100;
        }
        else if(as11Score >= 6000)
        {
            rank = "Silver"; baseCoin = 75;
        }
        else if (as11Score >= 4000)
        {
            rank = "Bronze"; baseCoin = 50;
        }
        else if (as11Score >= 0)
        {
            rank = "Participation"; baseCoin = 25;
        }

        int timeBonus = 0;
        if(as11CompletionTime <= 30)
        {
            timeBonus = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            timeBonus = 10;
        }

        int totalCoin = timeBonus + baseCoin;
        Debug.Log($"{rank} Rank - {totalCoin} coins earned");
    }
}
