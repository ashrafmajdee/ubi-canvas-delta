namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class EventQuerySnapData : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2C92A620;
	}
}

