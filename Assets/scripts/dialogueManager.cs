using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueManager : MonoBehaviour
{
    //

    /*
Narration: As you absorb your morning grains, the television sounds the amber alert
 
TV: Yesterday, the Waffle Chateau™®© research institute's confidential database was hacked.
 
Narration: The Waffle Chateau™®© institute got hacked?! Well, honestly you're more surprised that some random restaurant chain even has a research institute in the first place. Though it would explain all the natural disaster prep they have....
 
*ring ring*
 
Narration: Oh great, it's your boss.
 
*You pick up the phone*
 
Boss: What's up bro, I got a mission for you! You know bout' the Waffle incident, it's a problem and we have to fix it. Okay?

     */

    public string[] test;

    public string[] declineMission;
    public string[] acceptMission;

    public string[] meetFrancis;
    public string[] approachKaren;

    public string[] unlockSecurity;

    public string[] candyStore;
    public string[] meetKeith;
    public string[] meetAnts;
    public string[] askUSB;
    public string[] photoDevPlace;

    public string[] meetShadyGuy;
    public string[] meetPhotoLabOwner;
    public string[] meetEmu;
    public string[] meetOwl;
    public string[] meetMatt;


    //ACCUSATIONS!
    public string[] karen;
    public string[] emu;
    public string[] owl;
    public string[] kevinKeith;
    public string[] francis;
    public string[] flamingo;
    public string[] ants;
    public string[] shadyguy;
    public string[] boss;
    public string[] kid;
    public string[] dad;
    public string[] self;

    private void Start()
    {
        test = new string[] { "Narration: As you absorb your morning grains, the television sounds the amber alert",
 "TV: Yesterday, the Waffle Chateau™®© research institute's confidential database was hacked.",
 "Narration: The Waffle Chateau™®© institute got hacked?! Well, honestly you're more surprised that some random restaurant chain even has a research institute in the first place. Though it would explain all the natural disaster prep they have....",
 "*ring ring*",
 "Narration: Oh great, it's your boss.",
 "*You pick up the phone*",
 "Boss: What's up bro, I got a mission for you! You know bout' the Waffle incident, it's a problem and we have to fix it. Okay?"};

        declineMission = new string[] {"You: Can I decline? I’d rather not go on a mission today.",
"Boss: Wow, that's not very cash money my dude. You're fired.",
"Narrator: (At least your door wasn't torn down-)",
"Narrator: The door busts open with your partner on the other side, surrounded by an army of penguin servants…. so much for your non-torn door.",
"Karen: HMPH - I brought bread but the manager said not to give it to you. Bye!",
"PTO ending" };

        acceptMission = new string[] {"Boss: Great! You're partner should be arriving in 3, 2-",
"Narration: The door bursts open with your partner on the other side, surrounded by an army of penguin servants… with complimentary tuxedos, of course *come on, I just installed that steel reinforced door yesterday…*you think to yourself.",
"Boss: By the way, you only got one shot at this.Good Luck!",
"Karen: Hello, I'm Karen Smith, proud mother of two beautiful baby boys and I've bought bread.",
"Narration: Before you can warn your partner, a swarm of a thousand pigeons sweeps into your apartment and devours the bread before flying out of sight.",
"You: Er, hi I'm *VERY LOUD CONSTRUCTION NOISES* -and",
"Karen: Right! Let's go to the pelican-mobile!",
"*doo ba doo ba doo ba doo ba doo ba doo ba, peeeeerrrry - wait wrong show*",
"Narration: You and Karen arrive in front of the crime scene.But before you can even take to steps you start to feel sick.",
"You: Ms.Smith, I don't feel so good *bleughs*",
"Narration: Another case of motion sickness, truly a tragedy." };

        meetFrancis = new string[] {"Narration: As Karen does what Karens do (harassing the fast food employee for some reason), you approach a shrimp in a fishbowl perched a golden Louie Buitton unicycle." ,
"Francis: Hi! I'm Francis Byrd, also known as THE GREAT AND MAJESTIC MAJESTY, SIR BRYD FRANCIS JR.",
"Narration: You'll just go with 'Francis'..." ,
"Francis: I am the witness. You won't believe what I saw. I was sitting there in my bedazzled fish tank when a flamingo emerged from the floor… LIKE A GHOST! I nearly ruined my designer pants!" ,
"Narration: They have designer pants for shrimp ?? Well that's besides the point, time to interrogate" ,
"You: What did the flamingo look like ?" ,
"Francis : They were tiny, looked like a pathetic little worm! Around, I don't know, seven or eight feet tall. They did have these awful bulging eyes though. Oh, and they wore the ugliest shirt ever! Worst fashion taste EVER! It had the words Dodo's Abnormal Journey!" ,
"Narration: Worst fashion taste ? Yeah, right! That was your favorite show, you recalled watching Dodo's Abnormal Journey with your dad before they even left to get the milk! You wonder when he's going to come back, you hope they gets 2 %." ,
"You: Hey, that show’s great -" ,
"Francis: “Bah - I don’t want to hear more simpleton sentiments from you. I’ll just put the information for the flamingo in your phone for you.", /*FLAMINGO added to profiles*/
"Francis: Oh, ewww, you're having some weird peasant inner dialogue, how annoying. You can leave now, I don't associate with those below me on the food chain.",
"Narration: Well, even though this guy claims to be a witness, you can never be too sure… it’s probably best that we keep our eyes on this guy" } /*FRANCIS added to profiles;*/ ;

        approachKaren = new string[] {"Narration: You walk over to Karen in hopes of getting a briefing on the case.",
"Karen: Who made this iced coffee? It's too cold! Are they trying to give me hypothermia? I am a single mother to two children---I deserve more respect than this." ,
"Employee: uh - uh - m - ma’am we made it like you or-" ,
"Karen: Oh, partner. Shouldn't you be getting work done? Go check the global database or something. I’m obviously very busy at the moment.",
"Narration: …. Well, it seems like you’re alone on this one.Though, Karen hasn’t been doing anything to help with the case since you arrived at all…. maybe they have an underlying motive…?"} /*KAREN added*/;

        unlockSecurity = new string[] {"Narration: You unlock the security office and find a USB conveniently labeled security footage from the break in. Not fishy at all, you review it and grab some popcorn. As you watch the video, you notice two unknown figures in the clip. One of them appears to be an emu, and the other an owl.",
"Suddenly you see Karen break down the door... again.",
"(I'm probably going to have to pay for that. Or else they might go screaming to the manager...)",
"Karen: I see you’re finally being useful. What did you find?" ,
"You: Well, the footage shows Francis and two other animals. Look, there's an emu behind Francis and an owl perched on the window but that's where the video ends." ,
        /* EMU added to profiles
         OWL has been added to profiles*/
"Narrator: Well, that's all the information you've got. The suspects couldn't have gotten far, they only sweeped the database this morning. Maybe you should look around and see if you find these potential suspects." };

        candyStore =new string[] { "Narrator: You arrive at the candy shop next door, carefully avoiding the ants on the floor as you look for any clues or witnesses. Don’t want to have any lawsuits for antslaughter"};

        meetKeith = new string[] {"Narrator: You walk up to the person up front" ,
"Kevin Keith: Hi, I’m Kevin Keith But My Friends Kall Me Keith Kevin. What Kan I Help You With?" ,
"Narrator: You haven’t known this person for more than five seconds but already feel a deep hatred for this man.Would be a real shame if they ended up the suspect..." ,
//<< KEVIN KEITH/KEITH KEVIN has been added to your profiles >>
"You: I’m here about the Waffle Chateau™®© case next door. I was wondering if you knew anything about it.",
"Keith Kevin: I Kould Let You In On What I Know-- - If You Help Me Out A Little First.You See, I Am A Bit Understaffed And I Need Someone To Sort This Kandy While I Take Kare Of The Ants.",
 "* trigger minigame*",
"Narrator: Kevin Keith/ Keith Kevin leans over counter and squints at the ant - ridden floor warily. They then start to whisper to you-- -",
"Kevin Keith: You Didn’t Hear This From Me But Those Dastardly Ants Most Definitely Did It.I Saw A Lot Of Them Karrying A USB When I Kicked Them Out Of My Store Yesterday. I Have The Right To Refuse Service To Anyone And These Pesky Bugs Keep Trying To Kome In And Take My Kandy.",
"Narrator: A USB? Perhaps a USB containing some incriminating evidence from the security room even…." };
        //<< ANTS have been added to your profiles >>

        meetAnts = new string[]  {"Ant 1: Hey watch it! We’re walkin’ ‘ere, stupid giant!",
"Narrator: You look down at the group of ants." ,
"You: My apologies, I almost missed you down there." ,
"Ant 2: Oh yeah? How’s the weather up there, satellite tower?" ,
"You: . . . . .What ?" ,
"Ant 3: You heard us! Did you hit your head on the doorway? I bet you play basketball too!" ,
"You: . . . . Um, no actually, I’m investigating about this Waffle Chateau™®©-" ,
"Ant 4: Why don’t you come back when you’ve shrunk, lamp post!" ,
"Ant 1: Yeah, then we could see more than your legs in your picture!" ,
"Ant 2: You tell ‘em, Andy!" ,
"Ant 3: Heheh, lamp post, good one Andy!" ,
"Ant 1: I you want anything from us, you gotta help us." ,
"Ant 4: Especially if you want us to forgive you." ,
"Ant 3: Why don’t you help us stack these candies into a manageable pile?" ,
//* trigger minigame
"You: Listen - I - I just need you guys to tell me what you know about the Waffle Chateau™®©!" ,
"Ant 4: Oh! My aunt loves that place! We went out to get breakfast there yesterday an’ they wouldn’t stop talking about their secret recipe.She’s obsessed with their Waffle Chateau Original Syrup™®©",
"Narrator: Perhaps even obsessed enough to steal from the database…. This is definitely something worth looking into." }
/*<< ANTS have been added to your profiles >> */;

        askUSB = new string[] {"You: I heard from the store owner that yesterday, you guys passed by with a USB." ,
"Ant 1: Woah, woah, woah.Call down there.Are you saying that we hacked the database? No, no.We were just bringing that USB down to the Photo Lab so that we could get our family photos printed out." ,
"Ant 2: In fact, we were pretty much taken’ photos all day.It's hard to get photos of the whole colony without some ant complaining that their eyes were closed." ,
"Ant 3: Or that some antenna was in the way.",
"You: Oh! I’ sorry to have wasted your time.",
"Ant 4: You better be! * mutters * Clobbering giant." };

        photoDevPlace = new string[] { "Narrator: You arrive at the photo lab next door."};


        meetShadyGuy = new string[]  {"Narrator: You approach the creature standing in a particularly dark corner of the room.",
"You: Hi, I’m investigating the Waffle Chateau™® incident next door.Do you know anything?",
"Shady Guy: … *looks around suspiciously*", //amongus
"You: … ummm… is that a no?",
"Shady Guy: … *sweats suspiciously*", //AMONGUS
"You: … Ok then… *backs away slowly*",
"Narrator: ……..Narrator: Well that was awkward. Still, very suspicious with how they’re acting…."
/*<< Shady Guy has been added to your profiles >>*/};

        meetPhotoLabOwner = new string[]  {"Narrator: You walk up to the front desk of the photo lab and notice a man looking through a camera.",
"You: Excuse me, could I ask you about the Waffle Chateau™®© incident?",
"Owner: I’m actually a little busy focusing these cameras. If you want to help, maybe I could answer your questions.",
"*trigger minigame*",
"You: Could you answer some questions about the incident?",
"Owner: Oh, I’d be more than happy to-AH!(turns around and sees player)",
"You: … It would be great if you could give some information for the case",
"Owner: YEAH - WELL - SEE - I HAVE TO -",
"Owner: I HAVE TO GO PRINT OUT SOME ANT PICTURES HAHA -",
"Narrator: The owner rushes away into a back room of sorts.",
"Narrator: … Well, that was strange.It is a bit strange that they seemed in such a hurry to go away...",
"Narrator: ...and is it just you or did that person seem oddly familiar…?"
/*<< Photo Lab Owner has been added to your profiles >>*/ };

        meetEmu = new string[] {"Narrator: You arrive at a barren patch in the grass to see an emu at a chessboard sitting on a foldable chair with a tall glass of apple juice in hand.",
"You: I'm an agent who has been assigned the Waffle Chateau™®© case, and I would  like to ask you some questions.",
"Emu: Could you give me a moment, kid? My chess partner went off to the restroom and my game’s not over.",
"You: So if it’s over you’ll talk? I could do the last move.",
"Emu: Only if you can beat me, youngster.",
"* trigger minigame*",
"Emu: Sonny, what are you going on about? The last time I was at the Waffle Chateau™®© database was to chat with my good friend Francis. We used to be war buddies. Do you remember the Second Great Emu war?",
"You: Uhhh, from three years ago ? Yeah, I guess but it’s really important you answer some questions -" ,
"Emu: Stupid millennial. This brings back so many memories from my life in the Emu wars....By November 1965, General Vo Nguyen Giap's regular Australian Army divisions had begun a bloody testing of the Emu divisions on the battlefield, and large numbers of Emu troops were becoming casualties. Francis and I fought side by side against those darned flamingoes. Thank the corvids that they're extinct. Hey! you better not be falling asleep, I'm not done monologuing.",
"You: Zzzzz....-WHAT! Huh? Oh right, er, n - no! I was paying attention!",
"Emu: Hmmph, typical young ‘uns not respecting their elders.I bet you didn’t even hunt wild boar during recess in your “schools” " ,
"You: … Hunt what?",
"Emu: Don’t talk to me until you know how to shoot a FIREWORK, child…!",
"Narrator: “Know how to shoot a firework?” Who is this Emu to lecture you about how to do that with their animal slaughter count ? !This Emu is certainly acting strangely." };


        meetOwl = new string[] {"Narrator: You see the Owl perched on a tall branch in the park peacefully feeding some pigeons food.",
"Narrator: … It's a little weird that they’re throwing food on the floor for them to eat like animals, but that’s not important. You have a job to do! They are quite high up though. It seems you’ll have to climb up to speak to them.",
/** trigger minigame**/
"You: Hold it right there, I need to question you about the Waffle Chateau™®© incident.",
"Owl: Oh, Hello there!Isn’t the weather great today?" ,
"You: Erm… I guess so.It’s a little chilly today since its about 290°Kelvin but nevermind that. What do you know about the Waffle Chateau™®© robbery?",
"Owl: Chilly? It’s a lot colder where I come from. If you’re cold, I could treat you to coffee if you'd like.",
"You: No thank you, that’s really kind of you but I just want to know if you know anything about the Waffle Chateau™®©",
"Owl: Here - take this coffee.I insist.",
"Narrator: The pigeons now look at you…. judgmentally as the owl extends their wing to give you the fresh coffee. Damn you, social norms! You take the coffee.",
"You: Uh… thanks..Have a good day I guess.",
/*<< Coffee is added to your inventory >>*/
"Owl: You too! Have a great day!",
"Narrator: You walk away from the owl with your cup of coffee only to realize you have not managed to get a single piece of information.It is somewhat suspicious that they avoided your question, no matter how polite they are."
/*<< Owl has been added to your profiles >>*/ };

        meetMatt = new string[] { "Narrator: You walk up to a child sitting in their own pool of tears in the sandbox.",
 "You: Hey Kid!Would you-- -",
 "Child: MY TOY IS GONE!!!",
 "You: Uhmmm… ",
 "Child: MY TOY!!!",
 "You: W -",
 "Child: TOYYYYY!!!" ,
 "You: WILL YOU JUST CALM DOWN.",
 "Child: … " ,
 "You: I’ll find your dumb toy for you if you just stop whining and answer my questions. Okay?" ,
 /** trigger minigame**/
 "You:  There you go.You have your toy. Now can you tell me what you know?",
 "Child: I don’t know much but this might be useful." ,
 "Narrator: The child hands you a torn piece of paper.You have no idea how this will be useful.Maybe if you find the other pieces, it might start to make sense."
/*<< Paper Scrap is added to your inventory >>*/ };

        karen = new string[] {"You: Karen Smith, you are under arrest for the Waffle Chateau™®© incident.",
"Narrator: Karen is visibly disgusted by your words.Suddenly their metaphorical hair seems to almost grow in size.",
"Karen: Well EXCUSE me, may I speak to your m a n a g e r ?",
"You: What are you talking about, we're partners- we have the SAME boss-",
"Narrator: They pull out a banana from their pocket and hold it up to their ear.",
"Karen: Is this my partner's manager?? I DEMAND THAT YOU FIRE THEM THIS INSTANT. I HAVE BEEN NOTHING BUT POLITE AND DO YOU KNOW WHAT THIS IMBECILE DECIDES TO DO. THEY ACT ALL COCKY LIKE HE'S BETTER THAN ME AND ACCUSES ME OF THE WAFFLE CHATEAU™®© SHENANIGANS.I REFUSE TO WORK WITH THEM, IN FACT I THINK - NO, I KNOW THAT THEY SHOULD BE FIRED AND APOLOGIZE FOR THEIR BEHAVIOR!" ,
"Boss: heheh, ok sure bro I'll fire them lol",
"You: HEY, YOU CAN'T JUST FIRE ME LIKE THAT! SHE’S SUPPOSED TO GO TO JAIL",
"Boss: lmao, idk man, I kinda just did.",
"You: BUT -"
/*THE KAREN ENDING*/ };

        emu = new string[] {"You: Irwin Stevenson, you are under arrest for the Waffle Chateau™®© incident.",
"Emu: I think you are mistaken, I can't be guilty. That’s ridiculous! Kids these days have no sense of respect for their elders.",
"You: Then why were you at the scene of the crime?",
"Emu: Just look at this picture I took with my uPad. It's got me and my dear buddy Francis having a grand time and some owl stealing a USB in the back." ,
"You: Wait, what? Why didn’t you show us earlier?",
"Emu: Do you think I should put this picture on my facenovel? Francis and I look so nice.",
"You: Uh, that's really nice and all but-",
"Emu: I know you're busy but I have so many stories to tell you." ,
"You: But -" ,
"Emu: In my younger and more vulnerable years my father gave me some advice that I’ve been turning over in my mind ever since. ‘Whenever you feel like criticizing any one,’ they told me,‘just remember that all the people in this world haven’t had the advantages that you’ve had.’He didn’t say any more but we’ve always been unusually communicative in a reserved way, and I understood that they meant a great deal more than that. In consequence I’m inclined to reserve all judgments, a habit that has opened up many curious natures to me and also made me the victim of not a few veteran bores. The abnormal mind is quick to detect and attach itself to this quality when it appears in a normal person, and so it came about that in college I was unjustly accused of being a politician, because I was privy to the secret griefs of wild, unknown men.Most of the confidences were unsought—frequently I have feigned sleep, preoccupation, or a hostile levity when I realized by some unmistakable sign that an intimate revelation was quivering on the horizon—for the intimate revelations of young men or at least the terms in which they express them are usually plagiaristic and marred by obvious suppressions.Reserving judgments is a matter of infinite hope.I am still a little afraid of missing something if I forget that, as my father snobbishly suggested, and I snobbishly repeat a sense of the fundamental decencies being parcelled out unequally at birth."
/*DEATH BY RAMBLING ENDING*/ };

        owl = new string[] {"You: Harry Whodini, you are under arrest for the Waffle Chateau™®© incident.",
"Owl: Oh! Hello again.It is nice to see you.How was the coffee?",
"Karen: Are you sure this is the right guy?",
"You: Yes ? Anyways, stop avoiding the topic and come with me.",
"Owl: I’m sorry, would you follow me to a more comfortable location so I can explain?",
"You: Uhmm... sure I guess?",
"Narrator: You follow the owl to a... Danny's? The Waffle Chateau™®©' number one competitor!",
"Owl: Wait out here for a moment. You can come inside in about five minutes and we can start from the top.",
"* Five minutes later *",
"You: You do the honours.",
"Karen: My pleasure.",
"Narrator: Karen breaks down the door",
"You: Hold it right there, we know you stole the database from Waffle Chateau™®©.",
"Narrator: An owl in a trenchcoat dramatically spins their chair to face you.",
/* lightning flashes inside the building*/
"Owl: Yes, I was behind it all along....!MWHAWHOWHOWHOWHO! I stole information from the Waffle Chateau™®© database so that Danny's could reign SUPREME. GLORY TO DANNY'S!" ,
"You: I knew it",
"Karen: Shut up, I need to go to Sunday brunch and convince Becky not to let anyone give their kids the bird flu vaccinations. And send a report to the manager that I never want to work with you again." +
"You: He's not a manager he's a-nevermind." ,
"Narrator: You arrest the owl on the spot" ,
"Owl: Darn you, if it weren't for you meddling kids, and that darned soccer mom I would've gotten away with it too!",
"*ring ring*" ,
"Boss: Hey! I heard that you finally caught the bad guy. Congrats! Anyways, I have a new mission for you. Have you ever heard of iJump?"
/*THE BORING ENDING-- - to be continued ???*/  };

        kevinKeith  = new string[]  {"You: Keith Kevin or Kevin Keith or whatever your name is, you are under arrest for the Waffle Chateau™®© incident.",
"Kevin Keith / Keith Kevin: What ? That kan’t be right! I was in the shop all day yesterday! Do you know how hard I have to work to try to keep those pesky ants out of my shop?" ,
"Narrator: You give them a confused look considering the memory of the ants verbally abusing you is still fresh in your head. However, you decide to keep that to yourself since you don’t feel the need to trauma dump your bullying experiences onto your prime suspect." ,
"Kevin Keith/ Keith Kevin: Of kourse you’re speechless. Did you think you kould arrest me out of nowhere!The audacity the authorities have these days. The world needs to hear about this!" ,
"Narrator: Kevin Keith/ Keith Kevin pulls out their phone and starts furiously typing. Not even one minute after they finish, your phone starts blowing up.You open your tweeter account to find-- - THOUSANDS OF MESSAGES!What ? Not only do you see #*****IsOverParty but people have already found your tweeter account and are trying to cancel you." ,
"*ring ring*",
"Boss: Hey dude, I’ve got some bad news for ya.We are gonna have to let you go.Your little scandal is bringing down our rep.",
"You: But - but I just followed procedure! I arrested a suspect!" ,
"Boss: Haha, I dunno, guess that sucks for you, bro"
/*CANCELLED ENDING*/ };

        francis = new string[] { "You: Francis the Great and Majestic, uh. . . .Francis Byrd, you are under arrest for the Waffle Chateau™®© incident.",
"Francis: Oh really? You would accuse me?! Do you know who I am -",
"You: Yes, you’re the one whose “witness testimony” said that the real culprit was an extinct flamingo! Seems pretty off, unless of course, you never were a witness to begin with!",
"Francis: *Gasps * That’s IT! I will sue you and make you pay your damages for this accusation at ONCE, peasant!",
"You: Pffft, good luck suing me, I’m with K.Y.L.E.so there’s no -",
/*----*/
"Lawyer: Sorry, but it appears that the court has found you guilty of defamation, you owe Francis the Great and Majestic Majesty Byrd ten trillion in birdcoin.",
"You: . . . . ." }
/*SUED ENDING*/;

        flamingo = new string[]{"You: Flamingo, you are under arrest for the Waffle Chateau™®© incident.",
 "Karen: … Um… who are you talking to?",
 "You : The flamingo! I accuse the flamingo!",
 "Karen: …. Listen, I don’t know if you need a break or something, but there is no ‘flamingo’ anywhere, what are you talking about?",
"You: There is a flamingo, Francis told me about it!",
"Karen: Ugh, how many times do I have to tell you, Flamingos have been extinct for years.They’re all fake, like vaccines and the earth being round.",
"You: It’s a flamingo! I’m sure of it!",
"Karen: …. Yes, manager ? My partner has lost it.",
"You: What - are you calling Boss ? !I swear, a flamingo was behind it! A flamingo with a dodo’s abnormal adventure shirt!",
"Narrator: You see everyone else staring at you.You feel a ring from your phone and pick it up.",
"Boss: Yeah, listen up dude, it seems that you might be a little wacky today soooo I’m going to send you to a therapist, kay.",
"You: What ? !No, I’m fine, I just need to track down the culprit!",
"Boss: Yeah sure, as if there are any extinct flamingos around anymore lol."
/*Insanity ending*/ };

        ants = new string[]{"You: Ants Andy, Anthony, Andrew, Greg and more, you are ALL under arrest for the Waffle Chateau™®© incident.",
"Andy: Awww, what the hell ? !",
"Anthony : This is rigged!Giants accusing us of being criminals -",
 "Andrew: Ohh wow, the tall - guy accuses US, who could’ve seen this coming ?",
"Greg : Why don’t you shrink and THEN we’ll talk about being criminals, huh!",
 "All ants: YEAH!",
 "You: I can’t - you know what, no. You guys are all under arrest and that’s FINAL, whether I’m “taller” or not",
"Andy: You want to arrest us, Sasquatch! Then try!",
"Anthony: Yeah, you better have enough normal - sized hand cuffs for us, Bigfoot!",
"Andrew: And you better have enough for ALL 100,000 of us too",
"Greg: Heheh, yeah, how about you try to arrest us all, tall-guy",
"You: You know what? Maybe I WILL!",
"Narrator: And so you go about getting them handcuffed …. All 100,000 of them…. You feel like you’re going to regret this decision."
/*Infinite handcuffs ending*/ };

        shadyguy = new string[] { "You: You…..shady guy by the photo developing place, are under arrest for the Waffle Chateau™® incident.",
"Shady Guy: … ",
"You: Uhmmm.Did you hear me ? You’re under arrest.",
"Narrator: The shady guy only seems to stare at you blankly.",
"You: I’m going to put you in handcuffs now. Don’t resist.",
"Narrator: As you try to push away their sleeves in an attempt to put them in handcuffs, their trenchcoat falls to the floor. You look back up to say sorry, only to see a contraption of sorts.As you let your eyes travel down, you see a kiwi(bird)?",
"Karen: Oh! Shady Homie “Brother” Guy the I! I’m so sorry for the inconvenience. We didn’t realize it was you.",
"You: You know this bird?",
"Karen : You don’t ? That’s the manager’s bro -",
"*ring ring*",
"You: Hello?",
"Boss : What’s up dude ? I heard you ran into my brother and tried to arrest them.Sorry man, but that’s a big no no.It’s family, you get it right.",
"You: Family ? What do you mean?",
"Karen: If you had let me EXPLAIN, you would’ve known that Shady Homie “Brother” Guy I is the manager’s brother, you incompetent waste of oxygen.",
"You: Oh.",
"Boss: Yeah dude, haha. But, I’ve gotta say dude, it is not cool to accuse my brother, man",
"You: Erm, sorry, I didn’t know boss",
"Boss: And that’s why I’m going to frame you for the incident instead, broski.",
"You: You - what ? ! But - why!",
"Boss: Sorry man, but it’s what I have to do. Can’t have the agency turn up without a suspect and my bro-bro is a no-no",
"You: But what if I show proof that you’ve framed me, huh!",
"Boss: Dude. I’M the boss.What I say goes <3"
/*Framed ENDING*/ };

        boss = new string[] {"You: Boss, you are under arrest for the Waffle Chateau™®© incident.",
"Karen: If you’re gonna arrest the manager, do it right. Dude Homie “Bro” Guy Jr. III, you are under arrest for the Waffle Chateau™®© incident.",
"Boss: Oh shoot, really ? Well then, before you bring me to jail, congrats your promoted to boss now.Karen, you take orders from them.",
"Karen: Wait what ? Are you promoting THEM ? And not ME ? I WAS SUPPOSED TO BECOME THE BOSS! WHY ELSE WOULD I HAVE ARRESTED YOU ? YOU DIDN’T EVEN HAVE ANYTHING TO DO WITH THE CRIME.I DEMAND THAT YOU TAKE IT BACK AND PROMOTE ME INSTEAD!",
"Boss(or not boss now): Sorry.* shrugs shoulders * I don’t have that power anymore, you gotta ask your boss.",
"Narrator: Karen turns to you fuming only to see you standing there blankly as you take it all in. Did you just become the head of K.Y.L.E.?"
/*PROMOTION ENDING*/ };

        kid = new string[] {"You: Hey kid! Matt was it ? You are under arrest for the Waffle Chateau™®© incident.",
"Kid: What are you talking about?",
"Andy : ‘Ey! What’s goin’ on here ? Are they botherin’ you son ? Hey guys, get over here!",
"Narrator: You watch in confusion as a seemingly infinite trail of ants step in front of the child protectively.",
"You: Uhmmm… Would you excuse me ? I have to arrest this child.",
"Anthony: If you want our kid, you have to get through all of us first!",
"Andrew: Do you think you can get past us just because you're tall? HUH!",
"Greg: WE WON’T LET YOU TAKE OUR KID! CHARGE!",
"Narrator: Before you process what’s happening, the hoard of ants start to charge towards you in unison.You watch the kid sit there smugly until your vision is slowly clouded by ants."
  /*Trampled ending*/ };

        dad = new string[] {"You: Sir, you are under arrest for the Waffle Chateau™®© incident.",
"Owner: What ? But son, that's impossible!",
"You: Son ? Dad ? Is that you ? I - I thought you went to the store to get milk?",
"Owner : Uhm… Say cheese!",
"You: Cheese ?",
"Narrator : The next thing you know, a camera flash blinds you and your father is gone again, but this time with another note.",
"<< Dad’s Note is added to your inventory >>",
"<< It reads:",
"Sorry kid.It seems that you're doing fine without me at least---apart from the fact that you got the wrong guy and let me escape. Tell your mother that I left my favourite shoes but I’m too awkward to go back so please leave them here tomorrow >>",
"Narrator: Well that was bittersweet.You got abandoned by your father twice. Impressive."
/*:(ending*/ };

        self = new string[] {"You: You know what, I’ll just arrest myself.",
"Karen: What?",
"You: I mean, free food and housing sounds kind of nice. I’m kind of over this lifestyle by now. Maybe prison is just the change I need.",
"Karen: Do you even hear yourself? I can’t even arrest you. You haven’t done anything.",
"Narrator: The gears in your head start turning and then you clock Karen in the face.",
"Karen: DID YOU JUST PUNCH ME?",
"You: Now you can arrest me for assaulting a law enforcement officer.",
"Karen: YOU-- - You know what, fine.You’re under arrest.I hope you rot in jail."
/*Incarceration ending*/ };


}

}
