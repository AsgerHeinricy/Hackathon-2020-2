using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsController : MonoBehaviour
{
    public Text currentCo2;
    public Text currentCo2Diploma;
    public GameObject co2Diploma;
    public int co2Use;

    public GameObject paper;
    public Text currentPaper;
    public int paperUse;

    public GameObject plasticBottle;
    public Text currentPlasticBottle;
    public int plasticBottleUse;

    public GameObject toiletFlush;
    public Text currentToiletFlush;
    public int toiletFlushUse;

    public GameObject television;
    public Text currentTelevision;
    public int televisionUse;

    public GameObject x9WattsLed;
    public Text current9WattsLed;
    public int x9WattsLedUse;

    public GameObject laptop;
    public Text currentLaptop;
    public int laptopUse;

    public GameObject mobilePhone;
    public Text currentMobilePhone;
    public int mobilePhoneUse;

    public GameObject candle;
    public Text currentCandle;
    public int candleUse;

    public GameObject plasticBag;
    public Text currentPlasticBag;
    public int plasticBagUse;

    public GameObject mask;
    public Text currentMask;
    public int maskUse;

    void Start()
    {
        currentCo2 = GetComponent<Text>();
        currentCo2Diploma = co2Diploma.GetComponent<Text>();
        currentPaper = paper.GetComponent<Text>();
        currentPlasticBottle = plasticBottle.GetComponent<Text>();
        currentToiletFlush = toiletFlush.GetComponent<Text>();
        currentTelevision = television.GetComponent<Text>();
        current9WattsLed = x9WattsLed.GetComponent<Text>();
        currentLaptop = laptop.GetComponent<Text>();
        currentMobilePhone = mobilePhone.GetComponent<Text>();
        currentCandle = candle.GetComponent<Text>();
        currentPlasticBag = plasticBag.GetComponent<Text>();
        currentMask = mask.GetComponent<Text>();
    }

    void Update()
    {
        currentCo2.text = "Current CO2: " + co2Use + " gram";
        currentPaper.text = "" + paperUse;
        currentPlasticBottle.text = "" + plasticBottleUse;
        currentToiletFlush.text = "" + toiletFlushUse;
        currentTelevision.text = "" + televisionUse;
        current9WattsLed.text = "" + x9WattsLedUse;
        currentLaptop.text = "" + laptopUse;
        currentMobilePhone.text = "" + mobilePhoneUse;
        currentCandle.text = "" + candleUse;
        currentPlasticBag.text = "" + plasticBagUse;
        currentMask.text = "" + maskUse;

        if (co2Use >= 0)
        {
            currentCo2Diploma.text = "Hohooo! If you are not cheating right now, you are the best! You are treating the climate like a god! Keep up that great work!";
        }

        if (co2Use >= 10000)
        {
            currentCo2Diploma.text = "Wow! You are treating the climate perfectly! You are emissioning under the average amount of a person per day!";
        }

        if (co2Use >= 20000)
        {
            currentCo2Diploma.text = "You are treating the climate with respect! You are emissioning the average amount of a person, per day!";
        }

        if (co2Use >= 30000)
        {
            currentCo2Diploma.text = "Arwh... You are emissioning a lot of CO2 per day :( Maybe you should try to use a bit less tomorrow?";
        }
    }

    public void AddPaper()
    {
        if (paperUse >= 0)
        {
            co2Use += 5;
            paperUse++;
        }
    }

    public void RemovePaper()
    {
        if(paperUse >= 1)
        {
            co2Use -= 5;
            paperUse--;
        }
    }




    public void AddPlasticBottle()
    {
        if (toiletFlushUse >= 0)
        {
            co2Use += 9;
            plasticBottleUse++;
        }
    }

    public void RemovePlasticBottle()
    {
        if(plasticBottleUse >= 1)
        {
            co2Use -= 9;
            plasticBottleUse--;
        }
    }




    public void AddToiletFlush()
    {
        if(toiletFlushUse >= 0)
        {
            co2Use += 5000;
            toiletFlushUse++;
        }
    }

    public void RemoveToiletFlush()
    {
        if(toiletFlushUse >= 1)
        {
            co2Use -= 5000;
            toiletFlushUse--;
        }
    }




    public void AddTelevision()
    {
        if (televisionUse >= 0)
        {
            co2Use += 6000;
            televisionUse++;
        }
    }

    public void RemoveTelevision()
    {
        if (televisionUse >= 1)
        {
            co2Use -= 6000;
            televisionUse--;
        }
    }




    public void Add9WattsLed()
    {
        if (x9WattsLedUse >= 0)
        {
            co2Use += 3;
            x9WattsLedUse++;
        }
    }

    public void Remove9WattsLed()
    {
        if (x9WattsLedUse >= 1)
        {
            co2Use -= 3;
            x9WattsLedUse--;
        }
    }




    public void AddLaptop()
    {
        if (laptopUse >= 0)
        {
            co2Use += 6;
            laptopUse++;
        }
    }

    public void RemoveLaptop()
    {
        if (laptopUse >= 1)
        {
            co2Use -= 6;
            laptopUse--;
        }
    }




    public void AddMobilePhone()
    {
        if (mobilePhoneUse >= 0)
        {
            co2Use += 3000;
            mobilePhoneUse++;
        }
    }

    public void RemoveMobilePhone()
    {
        if (mobilePhoneUse >= 1)
        {
            co2Use -= 3000;
            mobilePhoneUse--;
        }
    }




    public void AddCandle()
    {
        if (candleUse >= 0)
        {
            co2Use += 10;
            candleUse++;
        }
    }

    public void RemoveCandle()
    {
        if (candleUse >= 1)
        {
            co2Use -= 10;
            candleUse--;
        }
    }




    public void AddPlasticBag()
    {
        if (plasticBagUse >= 0)
        {
            co2Use += 33;
            plasticBagUse++;
        }
    }

    public void RemovePlasticBag()
    {
        if (plasticBagUse >= 1)
        {
            co2Use -= 33;
            plasticBagUse--;
        }
    }




    public void AddMask()
    {
        if (maskUse >= 0)
        {
            co2Use += 59;
            maskUse++;
        }
    }

    public void RemoveMask()
    {
        if (maskUse >= 1)
        {
            co2Use -= 59;
            maskUse--;
        }
    }
}
