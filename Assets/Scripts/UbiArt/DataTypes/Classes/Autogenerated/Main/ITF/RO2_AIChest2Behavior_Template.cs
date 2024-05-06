namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_AIChest2Behavior_Template : TemplateAIBehavior {
		public float safeDistance;
		public float minSpeed;
		public float maxSpeed;
		public float swimMinSpeed;
		public float swimMaxSpeed;
		public float waitSpeed;
		public float upsideDownFloorSpeed;
		public float upsideDownCeilingSpeed;
		public float breakableSpeed;
		public float reducedScale;
		public uint lumsToGiveMax;
		public Path lumPath;
		public uint lumsToCloseEye;
		public float eyeClosingDuration;
		public float lumInsensitiveTime;
		public bool drcLumDropEnabled;
		public bool sendBreakEventsDirectly;
		public bool disableAfterBreakEvents;
		public bool snapBreakSequencePlayer;
		public CArrayO<Generic<Event>> breakEvents;
		public float detectDelay;
		public float hideTimeout;
		public bool canReverse;
		public float reverseInterval;
		public Generic<AIAction_Template> standAction;
		public Generic<AIAction_Template> runAction;
		public Generic<AIAction_Template> jumpAction;
		public Generic<AIAction_Template> toFlyAction;
		public Generic<AIAction_Template> flyAction;
		public Generic<AIAction_Template> landAction;
		public Generic<AIAction_Template> skidAction;
		public Generic<AIAction_Template> waitAction;
		public Generic<AIAction_Template> tauntAction;
		public Generic<AIAction_Template> diveAction;
		public Generic<AIAction_Template> swimAction;
		public Generic<AIAction_Template> thinkDetectAction;
		public Generic<AIAction_Template> thinkHideAction;
		public Generic<AIAction_Template> breaksAction;
		public Generic<AIAction_Template> brokenAction;
		public Generic<AIAction_Template> tickleAction;
		public bool registerCameraEnabled;
		public bool forceBreakable;
		public bool cineLaunchEnabled;
		public bool crushEnabled;
		public bool hitLumDropEnabled;
		public uint hitLumDropCount;
		public float distMinForSwipe;
		public bool tickleEnabled;
		public float tickleDuration;
		public bool forceShieldEnabled;
		public Path forceShieldPath;
		public StringID forceShieldBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			safeDistance = s.Serialize<float>(safeDistance, name: "safeDistance");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			swimMinSpeed = s.Serialize<float>(swimMinSpeed, name: "swimMinSpeed");
			swimMaxSpeed = s.Serialize<float>(swimMaxSpeed, name: "swimMaxSpeed");
			waitSpeed = s.Serialize<float>(waitSpeed, name: "waitSpeed");
			upsideDownFloorSpeed = s.Serialize<float>(upsideDownFloorSpeed, name: "upsideDownFloorSpeed");
			upsideDownCeilingSpeed = s.Serialize<float>(upsideDownCeilingSpeed, name: "upsideDownCeilingSpeed");
			breakableSpeed = s.Serialize<float>(breakableSpeed, name: "breakableSpeed");
			reducedScale = s.Serialize<float>(reducedScale, name: "reducedScale");
			lumsToGiveMax = s.Serialize<uint>(lumsToGiveMax, name: "lumsToGiveMax");
			lumPath = s.SerializeObject<Path>(lumPath, name: "lumPath");
			lumsToCloseEye = s.Serialize<uint>(lumsToCloseEye, name: "lumsToCloseEye");
			eyeClosingDuration = s.Serialize<float>(eyeClosingDuration, name: "eyeClosingDuration");
			lumInsensitiveTime = s.Serialize<float>(lumInsensitiveTime, name: "lumInsensitiveTime");
			drcLumDropEnabled = s.Serialize<bool>(drcLumDropEnabled, name: "drcLumDropEnabled");
			sendBreakEventsDirectly = s.Serialize<bool>(sendBreakEventsDirectly, name: "sendBreakEventsDirectly");
			disableAfterBreakEvents = s.Serialize<bool>(disableAfterBreakEvents, name: "disableAfterBreakEvents");
			snapBreakSequencePlayer = s.Serialize<bool>(snapBreakSequencePlayer, name: "snapBreakSequencePlayer");
			breakEvents = s.SerializeObject<CArrayO<Generic<Event>>>(breakEvents, name: "breakEvents");
			detectDelay = s.Serialize<float>(detectDelay, name: "detectDelay");
			hideTimeout = s.Serialize<float>(hideTimeout, name: "hideTimeout");
			canReverse = s.Serialize<bool>(canReverse, name: "canReverse");
			reverseInterval = s.Serialize<float>(reverseInterval, name: "reverseInterval");
			standAction = s.SerializeObject<Generic<AIAction_Template>>(standAction, name: "standAction");
			runAction = s.SerializeObject<Generic<AIAction_Template>>(runAction, name: "runAction");
			jumpAction = s.SerializeObject<Generic<AIAction_Template>>(jumpAction, name: "jumpAction");
			toFlyAction = s.SerializeObject<Generic<AIAction_Template>>(toFlyAction, name: "toFlyAction");
			flyAction = s.SerializeObject<Generic<AIAction_Template>>(flyAction, name: "flyAction");
			landAction = s.SerializeObject<Generic<AIAction_Template>>(landAction, name: "landAction");
			skidAction = s.SerializeObject<Generic<AIAction_Template>>(skidAction, name: "skidAction");
			waitAction = s.SerializeObject<Generic<AIAction_Template>>(waitAction, name: "waitAction");
			tauntAction = s.SerializeObject<Generic<AIAction_Template>>(tauntAction, name: "tauntAction");
			diveAction = s.SerializeObject<Generic<AIAction_Template>>(diveAction, name: "diveAction");
			swimAction = s.SerializeObject<Generic<AIAction_Template>>(swimAction, name: "swimAction");
			thinkDetectAction = s.SerializeObject<Generic<AIAction_Template>>(thinkDetectAction, name: "thinkDetectAction");
			thinkHideAction = s.SerializeObject<Generic<AIAction_Template>>(thinkHideAction, name: "thinkHideAction");
			breaksAction = s.SerializeObject<Generic<AIAction_Template>>(breaksAction, name: "breaksAction");
			brokenAction = s.SerializeObject<Generic<AIAction_Template>>(brokenAction, name: "brokenAction");
			tickleAction = s.SerializeObject<Generic<AIAction_Template>>(tickleAction, name: "tickleAction");
			registerCameraEnabled = s.Serialize<bool>(registerCameraEnabled, name: "registerCameraEnabled");
			forceBreakable = s.Serialize<bool>(forceBreakable, name: "forceBreakable");
			cineLaunchEnabled = s.Serialize<bool>(cineLaunchEnabled, name: "cineLaunchEnabled");

			crushEnabled = s.Serialize<bool>(crushEnabled, name: "crushEnabled");
			hitLumDropEnabled = s.Serialize<bool>(hitLumDropEnabled, name: "hitLumDropEnabled");
			hitLumDropCount = s.Serialize<uint>(hitLumDropCount, name: "hitLumDropCount");
			distMinForSwipe = s.Serialize<float>(distMinForSwipe, name: "distMinForSwipe");
			tickleEnabled = s.Serialize<bool>(tickleEnabled, name: "tickleEnabled");
			tickleDuration = s.Serialize<float>(tickleDuration, name: "tickleDuration");
			forceShieldEnabled = s.Serialize<bool>(forceShieldEnabled, name: "forceShieldEnabled");
			forceShieldPath = s.SerializeObject<Path>(forceShieldPath, name: "forceShieldPath");
			forceShieldBone = s.SerializeObject<StringID>(forceShieldBone, name: "forceShieldBone");
		}
		public override uint? ClassCRC => 0x242F9D6A;
	}
}

