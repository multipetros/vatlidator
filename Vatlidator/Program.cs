﻿/* Vatlidator: Program Entry Point
 * (c) 2011-2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
using System;
using System.Windows.Forms;

namespace Vatlidator{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
