namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MoveableObjectControllerComponent_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFC124AA4;
	}
}

