﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MP4_Mangler.HeaderBoxes {
	/// <summary>
	/// An attempt to create a simple, minimal stds and children
	/// to demark an H.264 stream to IIS. Fingers crossed, it might work.
	/// </summary>
	public class stsd_h264:FullBox {

		public stsd_h264 () : base(0, 0x0000, "stsd") {
			_data = new System.IO.MemoryStream();
			BigEndianWriter ous = new BigEndianWriter(_data);
			ous.Write((UInt32)0); // entry count
			/*
			// This is a VC-1 block to test 'moov' correctness.
			byte[] hard_data = new byte[] { 
				0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0xE5, 0x6F, 0x76, 0x63,
				0x31, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x05, 0x00, 0x02, 0xD0, 0x00, 0x48, 0x00, 0x00,
				0x00, 0x48, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x15,
				0x15, 0x56, 0x43, 0x2D, 0x31, 0x20, 0x41, 0x64, 0x76, 0x61, 0x6E,
				0x63, 0x65, 0x64, 0x20, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x6C, 0x65,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
				0x05, 0x00, 0x00, 0xD0, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0xD0, 0x02, 0x00,
				0x00, 0xA0, 0x2B, 0x25, 0x00, 0x00, 0x00, 0x00, 0x00, 0x9A, 0x5B,
				0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x47, 0x00, 0x00,
				0x00, 0x00, 0x05, 0x00, 0x00, 0xD0, 0x02, 0x00, 0x00, 0x01, 0x00,
				0x18, 0x00, 0x57, 0x56, 0x43, 0x31, 0x00, 0x30, 0x2A, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
				0x00, 0x00, 0x00, 0x00, 0x25, 0x00, 0x00, 0x01, 0x0F, 0xD3, 0xBE,
				0x27, 0xF1, 0x67, 0x8A, 0x27, 0xF8, 0x59, 0xE8, 0x04, 0x50, 0x82,
				0x4A, 0x56, 0xDC, 0xEC, 0xC0, 0x00, 0x00, 0x01, 0x0E, 0x5A, 0x67,
				0xF8, 0x40
			};
			ous.WriteForward(hard_data);*/
		}

		public override void Prepare () {
		}
	}
}
