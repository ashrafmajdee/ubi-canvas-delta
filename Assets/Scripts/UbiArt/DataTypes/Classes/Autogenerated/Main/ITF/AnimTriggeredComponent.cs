namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AnimTriggeredComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0E547111;
	}
}

