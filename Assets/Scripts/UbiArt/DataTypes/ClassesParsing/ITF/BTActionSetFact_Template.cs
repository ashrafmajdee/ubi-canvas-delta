﻿using System.Collections.Generic;
using System.Diagnostics;

namespace UbiArt.ITF {
	public partial class BTActionSetFact_Template {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game) {
					if ((previousSettings.Game == Game.RA || previousSettings.Game == Game.RM) 
						&& settings.Game == Game.RL) {
						type = (EValueType2)(int)typeRA;
					}
				}
			}
			previousSettings = settings;
		}
	}
}
