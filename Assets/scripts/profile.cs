using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileItem
{
    public string name;
    public string description;
    public Sprite sprite;
    public ProfileItem(string name, string description, Sprite sprite)
    {
        this.name = name;
        this.description = description;
        this.sprite = sprite;
    }
}

public class profile : MonoBehaviour
{
    public GameObject profileObj;
    public GameObject buttons;
    private int num;

    string[] charList = new string[] { "construction noises", "antersons", "boss", "francis", "harry", "irwin", "karen", "keithkevin kevinkeith", "matt", "robert", "shady", "wolfgang" };
    List<ProfileItem> profileList = new List<ProfileItem> { };

    string[] descriptions = new string[] {
        "Name: *construction noises* \n General History and Past Offenses:?",
        "Name: Andy Anterson, Anthony Anterson, Andrew Anterson, Greg Anterson-EXCEEDS CHARACTER LIMIT \n General History and Past Offenses: \n Harassed many individuals over 6.58315e-4 nautical miles tall \n Have millions of individuals in their colony",
        "Name: 'Boss' Dude Homie 'Bro' Guy Jr. the III - Florida Man \n General History and Past Offenses: \n You only got hired by them because they liked the pants you wore to your interview \n Doesn’t really do much",
        "Name: Francis Byrd \n General History and Past Offenses: \n Served in the First and Second Emu Wars of Australia \nSuspicious accumulation of wealth \n Hates Dodo’s Abnormal Adventure or anything commonfolk enjoy(claims the peasant energy clashes with his aesthetic)",
        "Name: Harry Whodini \n General History and Past Offenses: \n volunteered for charity \n donated to food shelters \n helped clean up litter in the public park \n tax evasion",
        "Name: Irwin Stevenson \n General History and Past Offenses: \n served in the First and Second Emu Wars of Australia \n Involuntary animal slaughter \n 'Accidentally' set off fireworks in their own apartment and burnt the flesh of their neighbors upstairs",
        "Name: Karen Smith \n General History and Past Offenses: \n Harassing random fast food workers for no reason \n Single mother to two sons \n Recently Divorced \n Avid baker",
        "Name: Keith/Kevin Kevin/Keith \n General History and Past Offenses: \n Is the owner of the kandy store \n Has 41968 followers on twitter, verified and makes 20 tweets a day at a minimum \n He Speaks And Writes Sentences With Every Word Kapitalized Like A Psykhopath Which Often Konfuses Or Irritates People \n Has an unspeakably unlikable aura",
        "Name: Matt Anterson \n General History and Past Offenses: \n Was adopted by an Ant colony 5 years ago \n Very smug and annoying \n Should probably be dropped off a cliff Sparta style",
        "Name: Robert *construction noises* \n General History and Past Offenses: \n Harassed many individuals over 3.29158e-4 nautical miles tall \n Have millions of individuals in their colony",
        "Name: Shady Homie 'Brother' Guy the I \n General History and Past Offenses: \n Generally shady, hangs around the photo developing shop but otherwise doesn’t say much \n Is unspeakably sweaty",
        "Name: Wolfgang Wolffe \n General History and Past Offenses: \n According to Francis Byrd, a flamingo had breached the Waffle Chateau Database \n Flamingos have been believed to have been extinct since Emu War II"
    };

    //house, kandy shop, waffle house lobby, waffle house lab, park, park, waffle house lab, kandy shop, park, photo shop, photo shop, waffle house lab

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < charList.Length; i++)
        {
            string direct = "mugshots/" + charList[i];
            ProfileItem temp = new ProfileItem(charList[i], descriptions[i], Resources.Load<Sprite>(direct));
            profileList.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setUp(int n)
    {
        num = n;
        print(num);
        profileObj.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Image>().sprite = profileList[num].sprite;
        profileObj.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Text>().text = profileList[num].description;

    }

    public void exitProfile()
    {
        print("x");
        profileObj.SetActive(false);
        buttons.SetActive(true);
        buttons.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
    }

    public void arrest()
    {
        print(profileList[num].name);
        //move player, start arrest text, set end scene active + change image
        profileObj.transform.parent.parent.parent.GetChild(11).gameObject.SetActive(true);
    }
}
