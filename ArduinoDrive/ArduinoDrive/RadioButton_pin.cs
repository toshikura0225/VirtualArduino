using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoDrive {
	class RadioButton_pin : RadioButton {
		
		private byte _pin_number;

		public byte PinNumber {
			get {
				return this._pin_number;
			}

			set {
				this._pin_number = value;
			}
		}

		public RadioButton_pin() {

		}

	}
}
