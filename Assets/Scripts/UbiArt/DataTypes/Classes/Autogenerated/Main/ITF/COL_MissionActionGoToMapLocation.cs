namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionGoToMapLocation : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9A095DB8;
	}
}

