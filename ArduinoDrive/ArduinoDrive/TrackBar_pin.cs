using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoDrive {
	class TrackBar_pin : TrackBar {
		
		private byte _pin_number;

		public byte PinNumber {
			get {
				return this._pin_number;
			}

			set {
				this._pin_number = value;
			}
		}

		public TrackBar_pin() {
			
		}
	}
}
