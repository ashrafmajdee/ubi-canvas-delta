namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_ShooterDoorComponent : EventReceivePlayAnimComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA824841F;
	}
}

