using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ActorAnimationController : MonoBehaviour {
	Animator anim;
	public Text talkText;
	public Image talkBubMid;
	public Image talkBubBottom;

	public float animstate;
	public float talkState;

	public Dictionary<float, string> talkDic = new Dictionary<float, string>{
		{0f, ""},
		{1f, "...and that’s how I smote the Licorice Demons out of Helena!"},
		{2f, "I wouldn’t consider that smiting demons."},
		{3f, "Yeah, it sounds more like a beating administered under the pretense of exorcism."},
		{4f, "Hush hush. The Gods don’t exist anyway. We can do as we please."},
		{5f, "I FAILED ANOTHER KNIGHT EXAM!"},
		{6f, "Get along, little doggie."},
		{7f, "I’M NEVER GOING TO MOVE OUT OF MY PARENT’S HOVEL OR FIND A NICE LORD TO MARRY!"},
		{8f, "I reckon."},

		{9f, "Hey Bartholomew, watch this."},
		{10f, "Sir Knight, you seem troubled.  What if I told you there’s a way to banish all your woes?"},
		{11f, "What…*sniff*..way is that, good priest"},
		{12f, "Sacred secrets are yours for the low low price of 10 candy coins."},
		{13f, "Manifest Destiny."},
		{14f, "My luck is too foul to worsen."},

		{15f, "You’re trying too hard.  Just rely on the gods, and all your problems will be solved."},
		{16f, "We know what we must do, squire!"},
		{17f, "Rustle up some grub?"},
		{18f, "Wrong! We must call on the gods for aid!"},

		//option 1: send a sign
		{19f, "Hunh."},
		{20f, "Wait, what?"},
		{21f, "A SIGN FROM THE GODS!"},
		{22f, "The gods favor me!  This changes everything! I must embrace my destiny as the chosen one!"},
		{221f, "With the power of the gods, I can rescue the Gumdrop Prince from the Sugarplum Dragon, and become queen!  Come, Squire!"},
		{23f, "Dusty trails."},

		//option 2:  Festive Telegram
		{24f, "Greetings Sir Knight, handsome stranger, and heretics."},
		{26f, "Greetings messenger of the Gods. I am but a lowly knight who desires only to know her destiny."},
		{27f, "Texas has an area of 268,580 square miles."},
		{28f, "Squire! Dost thou know what this means?"},
		{29f, "Don’t mess with Texas."},
		{30f, "What? No, simple squire. It means I am favored by the Gods!"},
		{301f,"I need to take control of my life and try to find a boy-husband."},
		{302f, "I am off to find and rescue the Gumdrop Prince!"},
		{303f, "May the Gods watch over me."},


		//option 3: zombies
		{31f, "Oh.  My.  Gods."},
		{32f, "Anyone remember the zombie smiting incantation?  Me neither."},
		{33f, "Inconceivable."},
		{34f, "Die, sugary abominations!"},
		{35f, "What in tarnation!"},
		{36f, "The foul knaves have wounded you!  Are you alright squire?"},
		{37f, "I reckon."},
		{38f, "The gods have granted me dark powers over death! "},
		{39f, "A strange choice for so noble a knight as myself, but far be it for me to question their will!"},
		{40f, "I must wield this power to fulfill my destiny!"},
		{41f, "Now, to fetch the Gumdrop prince from the clutches of the sugarplum dragon and live happily ever after as queen of all the land!"},
	
	};

	public Dictionary<float, string> animDic = new Dictionary<float, string>{
		{1f, "IdleLeft"},
		{2f, "IdleRight"},
		{3f, "IdleFront"},
		{4f, "IdleBack"},
		{5f, "WalkLeft"},
		{6f, "WalkRight"},
		{7f, "WalkDown"},
		{8f, "WalkUp"}
	};


	void Start () {
//		anim = GetComponent<Animator>();
		animstate = 1f;
	}
	

	void Update () {


		//if animation triggered is already playing, don't play it
		//catch 0 because i'm lazy
//		if(animstate != 0f && !anim.GetCurrentAnimatorStateInfo(0).IsName(animDic[animstate]))
//			anim.SetTrigger(animDic[animstate]);

		//set talk bubbl'es text
		talkText.text = talkDic[talkState];

		//disable talk bubble BG if there's no next
		if(talkText.text == ""){
			talkBubMid.gameObject.SetActive(false);
			talkBubBottom.gameObject.SetActive(false);
		}else{
			talkBubMid.gameObject.SetActive(true);
			talkBubBottom.gameObject.SetActive(true);
		}
	}

}
