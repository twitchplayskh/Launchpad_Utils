
// This file has been generated by the GUI designer. Do not modify.
namespace Launchpad.LauncherUtil
{
	public partial class ProfileListDialog
	{
		private global::Gtk.VBox vbox9;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeview2;
		private global::Gtk.HBox hbox13;
		private global::Gtk.Alignment alignment22;
		private global::Gtk.Button newButton;
		private global::Gtk.Alignment alignment23;
		private global::Gtk.Button editButton;
		private global::Gtk.Alignment alignment24;
		private global::Gtk.Button deleteButton;
		private global::Gtk.Button buttonOK;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Launchpad.LauncherUtil.ProfileListDialog
			this.Name = "Launchpad.LauncherUtil.ProfileListDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Profiles");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Launchpad.LauncherUtil.ProfileListDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview2 = new global::Gtk.TreeView ();
			this.treeview2.CanFocus = true;
			this.treeview2.Name = "treeview2";
			this.GtkScrolledWindow.Add (this.treeview2);
			this.vbox9.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.alignment22 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment22.Name = "alignment22";
			// Container child alignment22.Gtk.Container+ContainerChild
			this.newButton = new global::Gtk.Button ();
			this.newButton.CanFocus = true;
			this.newButton.Name = "newButton";
			this.newButton.UseUnderline = true;
			this.newButton.Label = global::Mono.Unix.Catalog.GetString ("New..");
			this.alignment22.Add (this.newButton);
			this.hbox13.Add (this.alignment22);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.alignment22]));
			w5.Position = 0;
			// Container child hbox13.Gtk.Box+BoxChild
			this.alignment23 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment23.Name = "alignment23";
			// Container child alignment23.Gtk.Container+ContainerChild
			this.editButton = new global::Gtk.Button ();
			this.editButton.CanFocus = true;
			this.editButton.Name = "editButton";
			this.editButton.UseUnderline = true;
			this.editButton.Label = global::Mono.Unix.Catalog.GetString ("Edit");
			this.alignment23.Add (this.editButton);
			this.hbox13.Add (this.alignment23);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.alignment23]));
			w7.Position = 1;
			// Container child hbox13.Gtk.Box+BoxChild
			this.alignment24 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment24.Name = "alignment24";
			this.alignment24.LeftPadding = ((uint)(200));
			// Container child alignment24.Gtk.Container+ContainerChild
			this.deleteButton = new global::Gtk.Button ();
			this.deleteButton.CanFocus = true;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.UseUnderline = true;
			this.deleteButton.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.alignment24.Add (this.deleteButton);
			this.hbox13.Add (this.alignment24);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.alignment24]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 2;
			this.vbox9.Add (this.hbox13);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox13]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			w1.Add (this.vbox9);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox9]));
			w11.Position = 0;
			// Internal child Launchpad.LauncherUtil.ProfileListDialog.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOK = new global::Gtk.Button ();
			this.buttonOK.CanDefault = true;
			this.buttonOK.CanFocus = true;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseStock = true;
			this.buttonOK.UseUnderline = true;
			this.buttonOK.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOK, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOK]));
			w13.Expand = false;
			w13.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.treeview2.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeview2RowActivated);
			this.newButton.Clicked += new global::System.EventHandler (this.OnNewButtonClicked);
			this.editButton.Clicked += new global::System.EventHandler (this.OnEditButtonClicked);
			this.deleteButton.Clicked += new global::System.EventHandler (this.OnDeleteButtonClicked);
			this.buttonOK.Clicked += new global::System.EventHandler (this.OnButtonOKClicked);
		}
	}
}
