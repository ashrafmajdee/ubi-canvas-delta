namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionTrial : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAA9EB575;
	}
}

