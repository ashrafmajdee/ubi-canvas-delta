namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BubbleDreamerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCA3736A1;
	}
}

