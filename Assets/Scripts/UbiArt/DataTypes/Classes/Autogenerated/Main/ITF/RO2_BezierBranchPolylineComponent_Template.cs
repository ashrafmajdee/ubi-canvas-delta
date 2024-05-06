namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchPolylineComponent_Template : RO2_BezierBranchComponent_Template {
		public Path gameMaterial;
		public float beginLength;
		public float endLength;
		public float beginWidth;
		public float midWidth;
		public float endWidth;
		public float startOffset;
		public float endOffset;
		public float tessellationLength = 1f;
		public bool usePolylinePhantom;
		public bool isJobable = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			beginLength = s.Serialize<float>(beginLength, name: "beginLength");
			endLength = s.Serialize<float>(endLength, name: "endLength");
			beginWidth = s.Serialize<float>(beginWidth, name: "beginWidth");
			midWidth = s.Serialize<float>(midWidth, name: "midWidth");
			endWidth = s.Serialize<float>(endWidth, name: "endWidth");
			startOffset = s.Serialize<float>(startOffset, name: "startOffset");
			endOffset = s.Serialize<float>(endOffset, name: "endOffset");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			usePolylinePhantom = s.Serialize<bool>(usePolylinePhantom, name: "usePolylinePhantom");
			isJobable = s.Serialize<bool>(isJobable, name: "isJobable");
		}
		public override uint? ClassCRC => 0x4F9845F1;
	}
}

