namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIIdleAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x36B22073;
	}
}

