﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace TerrariaItemModifier.Windows {
	/**<summary>A window to display credits for the program.</summary>*/
	public partial class CreditsWindow : Window {
		//========= CONSTRUCTORS =========
		#region Constructors

		/**<summary>Constructs the credits window.</summary>*/
		public CreditsWindow() {
			InitializeComponent();
		}

		#endregion
		//============ EVENTS ============
		#region Events

		private void OnRequestNavigate(object sender, RequestNavigateEventArgs e) {
			Process.Start((sender as Hyperlink).NavigateUri.ToString());
		}

		private void OnCloseClicked(object sender, RoutedEventArgs e) {
			DialogResult = true;
		}

		#endregion
		//=========== SHOWING ============
		#region Showing

		/**<summary>Shows the credits window.</summary>*/
		public static void Show(Window owner) {
			CreditsWindow window = new CreditsWindow();
			window.Owner = owner;
			window.ShowDialog();
		}

		#endregion
	}
}
