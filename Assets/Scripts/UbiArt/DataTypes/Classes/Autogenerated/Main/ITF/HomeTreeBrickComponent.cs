namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeBrickComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x23C6E330;
	}
}

