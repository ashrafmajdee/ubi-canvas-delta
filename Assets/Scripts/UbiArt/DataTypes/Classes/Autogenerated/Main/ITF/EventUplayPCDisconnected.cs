namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventUplayPCDisconnected : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1A99FE1E;
	}
}

