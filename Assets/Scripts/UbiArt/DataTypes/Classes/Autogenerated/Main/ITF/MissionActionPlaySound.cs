namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionPlaySound : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD605413F;
	}
}

