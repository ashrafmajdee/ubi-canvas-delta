namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EntityComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB760D976;
	}
}

